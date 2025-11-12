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
    /// table format. Through integration with the <a href="https://docs.aws.amazon.com/https:/docs.aws.amazon.com/glue/latest/dg/catalog-and-crawler.html">Amazon
    /// Web Services Glue Data Catalog</a> you can interact with your tables using Amazon
    /// Web Services analytics services, such as <a href="https://docs.aws.amazon.com/https:/docs.aws.amazon.com/athena/">Amazon
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
        /// bucket, which you can use to organize tables. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-namespace-create.html">Create
        /// a namespace</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:CreateNamespace</c> permission to use this operation.
        /// 
        /// </para>
        ///  </dd> </dl>
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
        /// Creates a new table associated with the given namespace in a table bucket. For more
        /// information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-create.html">Creating
        /// an Amazon S3 table</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> <ul> <li> 
        /// <para>
        /// You must have the <c>s3tables:CreateTable</c> permission to use this operation. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you use this operation with the optional <c>metadata</c> request parameter you
        /// must have the <c>s3tables:PutTableData</c> permission. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you use this operation with the optional <c>encryptionConfiguration</c> request
        /// parameter you must have the <c>s3tables:PutTableEncryption</c> permission. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must have the <c>s3tables:TagResource</c> permission in addition to <c>s3tables:CreateTable</c>
        /// permission to create a table with tags.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// Additionally, If you choose SSE-KMS encryption you must grant the S3 Tables maintenance
        /// principal access to your KMS key. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-kms-permissions.html">Permissions
        /// requirements for S3 Tables SSE-KMS encryption</a>. 
        /// </para>
        ///  </note> </dd> </dl>
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
        /// Creates a table bucket. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-buckets-create.html">Creating
        /// a table bucket</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> <ul> <li> 
        /// <para>
        /// You must have the <c>s3tables:CreateTableBucket</c> permission to use this operation.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you use this operation with the optional <c>encryptionConfiguration</c> parameter
        /// you must have the <c>s3tables:PutTableBucketEncryption</c> permission.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must have the <c>s3tables:TagResource</c> permission in addition to <c>s3tables:CreateTableBucket</c>
        /// permission to create a table bucket with tags.
        /// </para>
        ///  </li> </ul> </dd> </dl>
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
        /// Deletes a namespace. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-namespace-delete.html">Delete
        /// a namespace</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:DeleteNamespace</c> permission to use this operation.
        /// 
        /// </para>
        ///  </dd> </dl>
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
        /// Deletes a table. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-delete.html">Deleting
        /// an Amazon S3 table</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:DeleteTable</c> permission to use this operation. 
        /// </para>
        ///  </dd> </dl>
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
        /// Deletes a table bucket. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-buckets-delete.html">Deleting
        /// a table bucket</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:DeleteTableBucket</c> permission to use this operation.
        /// 
        /// </para>
        ///  </dd> </dl>
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
        
        #region  DeleteTableBucketEncryption


        /// <summary>
        /// Deletes the encryption configuration for a table bucket.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:DeleteTableBucketEncryption</c> permission to use this
        /// operation.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTableBucketEncryption service method.</param>
        /// 
        /// <returns>The response from the DeleteTableBucketEncryption service method, as returned by S3Tables.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/DeleteTableBucketEncryption">REST API Reference for DeleteTableBucketEncryption Operation</seealso>
        DeleteTableBucketEncryptionResponse DeleteTableBucketEncryption(DeleteTableBucketEncryptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTableBucketEncryption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTableBucketEncryption operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTableBucketEncryption
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/DeleteTableBucketEncryption">REST API Reference for DeleteTableBucketEncryption Operation</seealso>
        IAsyncResult BeginDeleteTableBucketEncryption(DeleteTableBucketEncryptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTableBucketEncryption operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTableBucketEncryption.</param>
        /// 
        /// <returns>Returns a  DeleteTableBucketEncryptionResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/DeleteTableBucketEncryption">REST API Reference for DeleteTableBucketEncryption Operation</seealso>
        DeleteTableBucketEncryptionResponse EndDeleteTableBucketEncryption(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteTableBucketMetricsConfiguration


        /// <summary>
        /// Deletes the metrics configuration for a table bucket.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:DeleteTableBucketMetricsConfiguration</c> permission
        /// to use this operation.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTableBucketMetricsConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteTableBucketMetricsConfiguration service method, as returned by S3Tables.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/DeleteTableBucketMetricsConfiguration">REST API Reference for DeleteTableBucketMetricsConfiguration Operation</seealso>
        DeleteTableBucketMetricsConfigurationResponse DeleteTableBucketMetricsConfiguration(DeleteTableBucketMetricsConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTableBucketMetricsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTableBucketMetricsConfiguration operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTableBucketMetricsConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/DeleteTableBucketMetricsConfiguration">REST API Reference for DeleteTableBucketMetricsConfiguration Operation</seealso>
        IAsyncResult BeginDeleteTableBucketMetricsConfiguration(DeleteTableBucketMetricsConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTableBucketMetricsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTableBucketMetricsConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteTableBucketMetricsConfigurationResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/DeleteTableBucketMetricsConfiguration">REST API Reference for DeleteTableBucketMetricsConfiguration Operation</seealso>
        DeleteTableBucketMetricsConfigurationResponse EndDeleteTableBucketMetricsConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteTableBucketPolicy


        /// <summary>
        /// Deletes a table bucket policy. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-bucket-policy.html#table-bucket-policy-delete">Deleting
        /// a table bucket policy</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:DeleteTableBucketPolicy</c> permission to use this operation.
        /// 
        /// </para>
        ///  </dd> </dl>
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
        /// Deletes a table policy. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-table-policy.html#table-policy-delete">Deleting
        /// a table policy</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:DeleteTablePolicy</c> permission to use this operation.
        /// 
        /// </para>
        ///  </dd> </dl>
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
        /// Gets details about a namespace. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-namespace.html">Table
        /// namespaces</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:GetNamespace</c> permission to use this operation. 
        /// </para>
        ///  </dd> </dl>
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
        /// Gets details about a table. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-tables.html">S3
        /// Tables</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:GetTable</c> permission to use this operation. 
        /// </para>
        ///  </dd> </dl>
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
        /// Gets details on a table bucket. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-buckets-details.html">Viewing
        /// details about an Amazon S3 table bucket</a> in the <i>Amazon Simple Storage Service
        /// User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:GetTableBucket</c> permission to use this operation.
        /// 
        /// </para>
        ///  </dd> </dl>
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
        
        #region  GetTableBucketEncryption


        /// <summary>
        /// Gets the encryption configuration for a table bucket.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:GetTableBucketEncryption</c> permission to use this
        /// operation.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTableBucketEncryption service method.</param>
        /// 
        /// <returns>The response from the GetTableBucketEncryption service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.AccessDeniedException">
        /// The action cannot be performed because you do not have the required permission.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableBucketEncryption">REST API Reference for GetTableBucketEncryption Operation</seealso>
        GetTableBucketEncryptionResponse GetTableBucketEncryption(GetTableBucketEncryptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTableBucketEncryption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTableBucketEncryption operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTableBucketEncryption
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableBucketEncryption">REST API Reference for GetTableBucketEncryption Operation</seealso>
        IAsyncResult BeginGetTableBucketEncryption(GetTableBucketEncryptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTableBucketEncryption operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTableBucketEncryption.</param>
        /// 
        /// <returns>Returns a  GetTableBucketEncryptionResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableBucketEncryption">REST API Reference for GetTableBucketEncryption Operation</seealso>
        GetTableBucketEncryptionResponse EndGetTableBucketEncryption(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTableBucketMaintenanceConfiguration


        /// <summary>
        /// Gets details about a maintenance configuration for a given table bucket. For more
        /// information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-table-buckets-maintenance.html">Amazon
        /// S3 table bucket maintenance</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:GetTableBucketMaintenanceConfiguration</c> permission
        /// to use this operation. 
        /// </para>
        ///  </dd> </dl>
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
        
        #region  GetTableBucketMetricsConfiguration


        /// <summary>
        /// Gets the metrics configuration for a table bucket.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:GetTableBucketMetricsConfiguration</c> permission to
        /// use this operation.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTableBucketMetricsConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetTableBucketMetricsConfiguration service method, as returned by S3Tables.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableBucketMetricsConfiguration">REST API Reference for GetTableBucketMetricsConfiguration Operation</seealso>
        GetTableBucketMetricsConfigurationResponse GetTableBucketMetricsConfiguration(GetTableBucketMetricsConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTableBucketMetricsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTableBucketMetricsConfiguration operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTableBucketMetricsConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableBucketMetricsConfiguration">REST API Reference for GetTableBucketMetricsConfiguration Operation</seealso>
        IAsyncResult BeginGetTableBucketMetricsConfiguration(GetTableBucketMetricsConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTableBucketMetricsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTableBucketMetricsConfiguration.</param>
        /// 
        /// <returns>Returns a  GetTableBucketMetricsConfigurationResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableBucketMetricsConfiguration">REST API Reference for GetTableBucketMetricsConfiguration Operation</seealso>
        GetTableBucketMetricsConfigurationResponse EndGetTableBucketMetricsConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTableBucketPolicy


        /// <summary>
        /// Gets details about a table bucket policy. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-bucket-policy.html#table-bucket-policy-get">Viewing
        /// a table bucket policy</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:GetTableBucketPolicy</c> permission to use this operation.
        /// 
        /// </para>
        ///  </dd> </dl>
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
        
        #region  GetTableEncryption


        /// <summary>
        /// Gets the encryption configuration for a table.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:GetTableEncryption</c> permission to use this operation.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTableEncryption service method.</param>
        /// 
        /// <returns>The response from the GetTableEncryption service method, as returned by S3Tables.</returns>
        /// <exception cref="Amazon.S3Tables.Model.AccessDeniedException">
        /// The action cannot be performed because you do not have the required permission.
        /// </exception>
        /// <exception cref="Amazon.S3Tables.Model.BadRequestException">
        /// The request is invalid or malformed.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableEncryption">REST API Reference for GetTableEncryption Operation</seealso>
        GetTableEncryptionResponse GetTableEncryption(GetTableEncryptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTableEncryption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTableEncryption operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTableEncryption
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableEncryption">REST API Reference for GetTableEncryption Operation</seealso>
        IAsyncResult BeginGetTableEncryption(GetTableEncryptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTableEncryption operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTableEncryption.</param>
        /// 
        /// <returns>Returns a  GetTableEncryptionResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/GetTableEncryption">REST API Reference for GetTableEncryption Operation</seealso>
        GetTableEncryptionResponse EndGetTableEncryption(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTableMaintenanceConfiguration


        /// <summary>
        /// Gets details about the maintenance configuration of a table. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-maintenance.html">S3
        /// Tables maintenance</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> <ul> <li> 
        /// <para>
        /// You must have the <c>s3tables:GetTableMaintenanceConfiguration</c> permission to use
        /// this operation. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must have the <c>s3tables:GetTableData</c> permission to use set the compaction
        /// strategy to <c>sort</c> or <c>zorder</c>.
        /// </para>
        ///  </li> </ul> </dd> </dl>
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
        /// Gets the status of a maintenance job for a table. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-maintenance.html">S3
        /// Tables maintenance</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:GetTableMaintenanceJobStatus</c> permission to use this
        /// operation. 
        /// </para>
        ///  </dd> </dl>
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
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:GetTableMetadataLocation</c> permission to use this
        /// operation. 
        /// </para>
        ///  </dd> </dl>
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
        /// Gets details about a table policy. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-table-policy.html#table-policy-get">Viewing
        /// a table policy</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:GetTablePolicy</c> permission to use this operation.
        /// 
        /// </para>
        ///  </dd> </dl>
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
        /// Lists the namespaces within a table bucket. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-namespace.html">Table
        /// namespaces</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:ListNamespaces</c> permission to use this operation.
        /// 
        /// </para>
        ///  </dd> </dl>
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
        /// Lists table buckets for your account. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-buckets.html">S3
        /// Table buckets</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:ListTableBuckets</c> permission to use this operation.
        /// 
        /// </para>
        ///  </dd> </dl>
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
        /// List tables in the given table bucket. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-tables.html">S3
        /// Tables</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:ListTables</c> permission to use this operation. 
        /// </para>
        ///  </dd> </dl>
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
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists all of the tags applied to a specified Amazon S3 Tables resource. Each tag is
        /// a label consisting of a key and value pair. Tags can help you organize, track costs
        /// for, and control access to resources. 
        /// 
        ///  <note> 
        /// <para>
        /// For a list of S3 resources that support tagging, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/tagging.html#manage-tags">Managing
        /// tags for Amazon S3 resources</a>.
        /// </para>
        ///  </note> <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// For tables and table buckets, you must have the <c>s3tables:ListTagsForResource</c>
        /// permission to use this operation.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by S3Tables.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  PutTableBucketEncryption


        /// <summary>
        /// Sets the encryption configuration for a table bucket.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:PutTableBucketEncryption</c> permission to use this
        /// operation.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you choose SSE-KMS encryption you must grant the S3 Tables maintenance principal
        /// access to your KMS key. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-kms-permissions.html">Permissions
        /// requirements for S3 Tables SSE-KMS encryption</a> in the <i>Amazon Simple Storage
        /// Service User Guide</i>.
        /// </para>
        ///  </note> </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutTableBucketEncryption service method.</param>
        /// 
        /// <returns>The response from the PutTableBucketEncryption service method, as returned by S3Tables.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/PutTableBucketEncryption">REST API Reference for PutTableBucketEncryption Operation</seealso>
        PutTableBucketEncryptionResponse PutTableBucketEncryption(PutTableBucketEncryptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutTableBucketEncryption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutTableBucketEncryption operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutTableBucketEncryption
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/PutTableBucketEncryption">REST API Reference for PutTableBucketEncryption Operation</seealso>
        IAsyncResult BeginPutTableBucketEncryption(PutTableBucketEncryptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutTableBucketEncryption operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutTableBucketEncryption.</param>
        /// 
        /// <returns>Returns a  PutTableBucketEncryptionResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/PutTableBucketEncryption">REST API Reference for PutTableBucketEncryption Operation</seealso>
        PutTableBucketEncryptionResponse EndPutTableBucketEncryption(IAsyncResult asyncResult);

        #endregion
        
        #region  PutTableBucketMaintenanceConfiguration


        /// <summary>
        /// Creates a new maintenance configuration or replaces an existing maintenance configuration
        /// for a table bucket. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-table-buckets-maintenance.html">Amazon
        /// S3 table bucket maintenance</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:PutTableBucketMaintenanceConfiguration</c> permission
        /// to use this operation. 
        /// </para>
        ///  </dd> </dl>
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
        
        #region  PutTableBucketMetricsConfiguration


        /// <summary>
        /// Sets the metrics configuration for a table bucket.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:PutTableBucketMetricsConfiguration</c> permission to
        /// use this operation.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutTableBucketMetricsConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutTableBucketMetricsConfiguration service method, as returned by S3Tables.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/PutTableBucketMetricsConfiguration">REST API Reference for PutTableBucketMetricsConfiguration Operation</seealso>
        PutTableBucketMetricsConfigurationResponse PutTableBucketMetricsConfiguration(PutTableBucketMetricsConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutTableBucketMetricsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutTableBucketMetricsConfiguration operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutTableBucketMetricsConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/PutTableBucketMetricsConfiguration">REST API Reference for PutTableBucketMetricsConfiguration Operation</seealso>
        IAsyncResult BeginPutTableBucketMetricsConfiguration(PutTableBucketMetricsConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutTableBucketMetricsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutTableBucketMetricsConfiguration.</param>
        /// 
        /// <returns>Returns a  PutTableBucketMetricsConfigurationResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/PutTableBucketMetricsConfiguration">REST API Reference for PutTableBucketMetricsConfiguration Operation</seealso>
        PutTableBucketMetricsConfigurationResponse EndPutTableBucketMetricsConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  PutTableBucketPolicy


        /// <summary>
        /// Creates a new table bucket policy or replaces an existing table bucket policy for
        /// a table bucket. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-bucket-policy.html#table-bucket-policy-add">Adding
        /// a table bucket policy</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:PutTableBucketPolicy</c> permission to use this operation.
        /// 
        /// </para>
        ///  </dd> </dl>
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
        /// for a table. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-maintenance.html">S3
        /// Tables maintenance</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:PutTableMaintenanceConfiguration</c> permission to use
        /// this operation. 
        /// </para>
        ///  </dd> </dl>
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
        /// Creates a new table policy or replaces an existing table policy for a table. For more
        /// information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-table-policy.html#table-policy-add">Adding
        /// a table policy</a> in the <i>Amazon Simple Storage Service User Guide</i>. 
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:PutTablePolicy</c> permission to use this operation.
        /// 
        /// </para>
        ///  </dd> </dl>
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
        /// Renames a table or a namespace. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-tables.html">S3
        /// Tables</a> in the <i>Amazon Simple Storage Service User Guide</i>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:RenameTable</c> permission to use this operation. 
        /// </para>
        ///  </dd> </dl>
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
        
        #region  TagResource


        /// <summary>
        /// Applies one or more user-defined tags to an Amazon S3 Tables resource or updates existing
        /// tags. Each tag is a label consisting of a key and value pair. Tags can help you organize,
        /// track costs for, and control access to your resources. You can add up to 50 tags for
        /// each S3 resource. 
        /// 
        ///  <note> 
        /// <para>
        /// For a list of S3 resources that support tagging, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/tagging.html#manage-tags">Managing
        /// tags for Amazon S3 resources</a>.
        /// </para>
        ///  </note> <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// For tables and table buckets, you must have the <c>s3tables:TagResource</c> permission
        /// to use this operation.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by S3Tables.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes the specified user-defined tags from an Amazon S3 Tables resource. You can
        /// pass one or more tag keys. 
        /// 
        ///  <note> 
        /// <para>
        /// For a list of S3 resources that support tagging, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/tagging.html#manage-tags">Managing
        /// tags for Amazon S3 resources</a>.
        /// </para>
        ///  </note> <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// For tables and table buckets, you must have the <c>s3tables:UntagResource</c> permission
        /// to use this operation.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by S3Tables.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonS3TablesClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from S3Tables.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/s3tables-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateTableMetadataLocation


        /// <summary>
        /// Updates the metadata location for a table. The metadata location of a table must be
        /// an S3 URI that begins with the table's warehouse location. The metadata location for
        /// an Apache Iceberg table must end with <c>.metadata.json</c>, or if the metadata file
        /// is Gzip-compressed, <c>.metadata.json.gz</c>.
        /// 
        ///  <dl> <dt>Permissions</dt> <dd> 
        /// <para>
        /// You must have the <c>s3tables:UpdateTableMetadataLocation</c> permission to use this
        /// operation. 
        /// </para>
        ///  </dd> </dl>
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