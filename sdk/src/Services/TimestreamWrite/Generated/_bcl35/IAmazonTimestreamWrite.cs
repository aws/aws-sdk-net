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
 * Do not modify this file. This file is generated from the timestream-write-2018-11-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.TimestreamWrite.Model;

namespace Amazon.TimestreamWrite
{
    /// <summary>
    /// Interface for accessing TimestreamWrite
    ///
    /// Amazon Timestream Write 
    /// <para>
    /// Amazon Timestream is a fast, scalable, fully managed time-series database service
    /// that makes it easy to store and analyze trillions of time-series data points per day.
    /// With Timestream, you can easily store and analyze IoT sensor data to derive insights
    /// from your IoT applications. You can analyze industrial telemetry to streamline equipment
    /// management and maintenance. You can also store and analyze log data and metrics to
    /// improve the performance and availability of your applications. 
    /// </para>
    ///  
    /// <para>
    /// Timestream is built from the ground up to effectively ingest, process, and store time-series
    /// data. It organizes data to optimize query processing. It automatically scales based
    /// on the volume of data ingested and on the query volume to ensure you receive optimal
    /// performance while inserting and querying data. As your data grows over time, Timestream’s
    /// adaptive query processing engine spans across storage tiers to provide fast analysis
    /// while reducing costs.
    /// </para>
    /// </summary>
    public partial interface IAmazonTimestreamWrite : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ITimestreamWritePaginatorFactory Paginators { get; }
#endif


        
        #region  CreateBatchLoadTask


        /// <summary>
        /// Creates a new Timestream batch load task. A batch load task processes data from a
        /// CSV source in an S3 location and writes to a Timestream table. A mapping from source
        /// to target is defined in a batch load task. Errors and events are written to a report
        /// at an S3 location. For the report, if the KMS key is not specified, the batch load
        /// task will be encrypted with a Timestream managed KMS key located in your account.
        /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-cmk">Amazon
        /// Web Services managed keys</a>. <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/ts-limits.html">Service
        /// quotas apply</a>. For details, see <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/code-samples.create-batch-load.html">code
        /// sample</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBatchLoadTask service method.</param>
        /// 
        /// <returns>The response from the CreateBatchLoadTask service method, as returned by TimestreamWrite.</returns>
        /// <exception cref="Amazon.TimestreamWrite.Model.AccessDeniedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ConflictException">
        /// Timestream was unable to process this request because it contains resource that already
        /// exists.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InternalServerException">
        /// Timestream was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ServiceQuotaExceededException">
        /// The instance quota of resource exceeded for this account.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user and they exceeded the service quotas. The request
        /// was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// An invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/CreateBatchLoadTask">REST API Reference for CreateBatchLoadTask Operation</seealso>
        CreateBatchLoadTaskResponse CreateBatchLoadTask(CreateBatchLoadTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBatchLoadTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBatchLoadTask operation on AmazonTimestreamWriteClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBatchLoadTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/CreateBatchLoadTask">REST API Reference for CreateBatchLoadTask Operation</seealso>
        IAsyncResult BeginCreateBatchLoadTask(CreateBatchLoadTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBatchLoadTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBatchLoadTask.</param>
        /// 
        /// <returns>Returns a  CreateBatchLoadTaskResult from TimestreamWrite.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/CreateBatchLoadTask">REST API Reference for CreateBatchLoadTask Operation</seealso>
        CreateBatchLoadTaskResponse EndCreateBatchLoadTask(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDatabase


        /// <summary>
        /// Creates a new Timestream database. If the KMS key is not specified, the database will
        /// be encrypted with a Timestream managed KMS key located in your account. For more information,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-cmk">Amazon
        /// Web Services managed keys</a>. <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/ts-limits.html">Service
        /// quotas apply</a>. For details, see <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/code-samples.create-db.html">code
        /// sample</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDatabase service method.</param>
        /// 
        /// <returns>The response from the CreateDatabase service method, as returned by TimestreamWrite.</returns>
        /// <exception cref="Amazon.TimestreamWrite.Model.AccessDeniedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ConflictException">
        /// Timestream was unable to process this request because it contains resource that already
        /// exists.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InternalServerException">
        /// Timestream was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ServiceQuotaExceededException">
        /// The instance quota of resource exceeded for this account.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user and they exceeded the service quotas. The request
        /// was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// An invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/CreateDatabase">REST API Reference for CreateDatabase Operation</seealso>
        CreateDatabaseResponse CreateDatabase(CreateDatabaseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDatabase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDatabase operation on AmazonTimestreamWriteClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDatabase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/CreateDatabase">REST API Reference for CreateDatabase Operation</seealso>
        IAsyncResult BeginCreateDatabase(CreateDatabaseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDatabase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDatabase.</param>
        /// 
        /// <returns>Returns a  CreateDatabaseResult from TimestreamWrite.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/CreateDatabase">REST API Reference for CreateDatabase Operation</seealso>
        CreateDatabaseResponse EndCreateDatabase(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateTable


        /// <summary>
        /// Adds a new table to an existing database in your account. In an Amazon Web Services
        /// account, table names must be at least unique within each Region if they are in the
        /// same database. You might have identical table names in the same Region if the tables
        /// are in separate databases. While creating the table, you must specify the table name,
        /// database name, and the retention properties. <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/ts-limits.html">Service
        /// quotas apply</a>. See <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/code-samples.create-table.html">code
        /// sample</a> for details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTable service method.</param>
        /// 
        /// <returns>The response from the CreateTable service method, as returned by TimestreamWrite.</returns>
        /// <exception cref="Amazon.TimestreamWrite.Model.AccessDeniedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ConflictException">
        /// Timestream was unable to process this request because it contains resource that already
        /// exists.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InternalServerException">
        /// Timestream was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ServiceQuotaExceededException">
        /// The instance quota of resource exceeded for this account.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user and they exceeded the service quotas. The request
        /// was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// An invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/CreateTable">REST API Reference for CreateTable Operation</seealso>
        CreateTableResponse CreateTable(CreateTableRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTable operation on AmazonTimestreamWriteClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/CreateTable">REST API Reference for CreateTable Operation</seealso>
        IAsyncResult BeginCreateTable(CreateTableRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTable.</param>
        /// 
        /// <returns>Returns a  CreateTableResult from TimestreamWrite.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/CreateTable">REST API Reference for CreateTable Operation</seealso>
        CreateTableResponse EndCreateTable(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDatabase


        /// <summary>
        /// Deletes a given Timestream database. <i>This is an irreversible operation. After a
        /// database is deleted, the time-series data from its tables cannot be recovered.</i>
        /// 
        /// 
        ///  <note> 
        /// <para>
        /// All tables in the database must be deleted first, or a ValidationException error will
        /// be thrown. 
        /// </para>
        ///  
        /// <para>
        /// Due to the nature of distributed retries, the operation can return either success
        /// or a ResourceNotFoundException. Clients should consider them equivalent.
        /// </para>
        ///  </note> 
        /// <para>
        /// See <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/code-samples.delete-db.html">code
        /// sample</a> for details.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatabase service method.</param>
        /// 
        /// <returns>The response from the DeleteDatabase service method, as returned by TimestreamWrite.</returns>
        /// <exception cref="Amazon.TimestreamWrite.Model.AccessDeniedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InternalServerException">
        /// Timestream was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user and they exceeded the service quotas. The request
        /// was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// An invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/DeleteDatabase">REST API Reference for DeleteDatabase Operation</seealso>
        DeleteDatabaseResponse DeleteDatabase(DeleteDatabaseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDatabase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDatabase operation on AmazonTimestreamWriteClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDatabase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/DeleteDatabase">REST API Reference for DeleteDatabase Operation</seealso>
        IAsyncResult BeginDeleteDatabase(DeleteDatabaseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDatabase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDatabase.</param>
        /// 
        /// <returns>Returns a  DeleteDatabaseResult from TimestreamWrite.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/DeleteDatabase">REST API Reference for DeleteDatabase Operation</seealso>
        DeleteDatabaseResponse EndDeleteDatabase(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteTable


        /// <summary>
        /// Deletes a given Timestream table. This is an irreversible operation. After a Timestream
        /// database table is deleted, the time-series data stored in the table cannot be recovered.
        /// 
        /// 
        ///  <note> 
        /// <para>
        /// Due to the nature of distributed retries, the operation can return either success
        /// or a ResourceNotFoundException. Clients should consider them equivalent.
        /// </para>
        ///  </note> 
        /// <para>
        /// See <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/code-samples.delete-table.html">code
        /// sample</a> for details.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTable service method.</param>
        /// 
        /// <returns>The response from the DeleteTable service method, as returned by TimestreamWrite.</returns>
        /// <exception cref="Amazon.TimestreamWrite.Model.AccessDeniedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InternalServerException">
        /// Timestream was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user and they exceeded the service quotas. The request
        /// was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// An invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/DeleteTable">REST API Reference for DeleteTable Operation</seealso>
        DeleteTableResponse DeleteTable(DeleteTableRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTable operation on AmazonTimestreamWriteClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/DeleteTable">REST API Reference for DeleteTable Operation</seealso>
        IAsyncResult BeginDeleteTable(DeleteTableRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTable.</param>
        /// 
        /// <returns>Returns a  DeleteTableResult from TimestreamWrite.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/DeleteTable">REST API Reference for DeleteTable Operation</seealso>
        DeleteTableResponse EndDeleteTable(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeBatchLoadTask


        /// <summary>
        /// Returns information about the batch load task, including configurations, mappings,
        /// progress, and other details. <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/ts-limits.html">Service
        /// quotas apply</a>. See <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/code-samples.describe-batch-load.html">code
        /// sample</a> for details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBatchLoadTask service method.</param>
        /// 
        /// <returns>The response from the DescribeBatchLoadTask service method, as returned by TimestreamWrite.</returns>
        /// <exception cref="Amazon.TimestreamWrite.Model.AccessDeniedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InternalServerException">
        /// Timestream was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user and they exceeded the service quotas. The request
        /// was throttled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/DescribeBatchLoadTask">REST API Reference for DescribeBatchLoadTask Operation</seealso>
        DescribeBatchLoadTaskResponse DescribeBatchLoadTask(DescribeBatchLoadTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBatchLoadTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBatchLoadTask operation on AmazonTimestreamWriteClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeBatchLoadTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/DescribeBatchLoadTask">REST API Reference for DescribeBatchLoadTask Operation</seealso>
        IAsyncResult BeginDescribeBatchLoadTask(DescribeBatchLoadTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeBatchLoadTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeBatchLoadTask.</param>
        /// 
        /// <returns>Returns a  DescribeBatchLoadTaskResult from TimestreamWrite.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/DescribeBatchLoadTask">REST API Reference for DescribeBatchLoadTask Operation</seealso>
        DescribeBatchLoadTaskResponse EndDescribeBatchLoadTask(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDatabase


        /// <summary>
        /// Returns information about the database, including the database name, time that the
        /// database was created, and the total number of tables found within the database. <a
        /// href="https://docs.aws.amazon.com/timestream/latest/developerguide/ts-limits.html">Service
        /// quotas apply</a>. See <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/code-samples.describe-db.html">code
        /// sample</a> for details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDatabase service method.</param>
        /// 
        /// <returns>The response from the DescribeDatabase service method, as returned by TimestreamWrite.</returns>
        /// <exception cref="Amazon.TimestreamWrite.Model.AccessDeniedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InternalServerException">
        /// Timestream was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user and they exceeded the service quotas. The request
        /// was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// An invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/DescribeDatabase">REST API Reference for DescribeDatabase Operation</seealso>
        DescribeDatabaseResponse DescribeDatabase(DescribeDatabaseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDatabase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDatabase operation on AmazonTimestreamWriteClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDatabase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/DescribeDatabase">REST API Reference for DescribeDatabase Operation</seealso>
        IAsyncResult BeginDescribeDatabase(DescribeDatabaseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDatabase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDatabase.</param>
        /// 
        /// <returns>Returns a  DescribeDatabaseResult from TimestreamWrite.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/DescribeDatabase">REST API Reference for DescribeDatabase Operation</seealso>
        DescribeDatabaseResponse EndDescribeDatabase(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeEndpoints


        /// <summary>
        /// Returns a list of available endpoints to make Timestream API calls against. This API
        /// operation is available through both the Write and Query APIs.
        /// 
        ///  
        /// <para>
        /// Because the Timestream SDKs are designed to transparently work with the service’s
        /// architecture, including the management and mapping of the service endpoints, <i>we
        /// don't recommend that you use this API operation unless</i>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You are using <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/VPCEndpoints">VPC
        /// endpoints (Amazon Web Services PrivateLink) with Timestream</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your application uses a programming language that does not yet have SDK support
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You require better control over the client-side implementation
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For detailed information on how and when to use and implement DescribeEndpoints, see
        /// <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/Using.API.html#Using-API.endpoint-discovery">The
        /// Endpoint Discovery Pattern</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpoints service method.</param>
        /// 
        /// <returns>The response from the DescribeEndpoints service method, as returned by TimestreamWrite.</returns>
        /// <exception cref="Amazon.TimestreamWrite.Model.InternalServerException">
        /// Timestream was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user and they exceeded the service quotas. The request
        /// was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// An invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/DescribeEndpoints">REST API Reference for DescribeEndpoints Operation</seealso>
        DescribeEndpointsResponse DescribeEndpoints(DescribeEndpointsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpoints operation on AmazonTimestreamWriteClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEndpoints
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/DescribeEndpoints">REST API Reference for DescribeEndpoints Operation</seealso>
        IAsyncResult BeginDescribeEndpoints(DescribeEndpointsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEndpoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEndpoints.</param>
        /// 
        /// <returns>Returns a  DescribeEndpointsResult from TimestreamWrite.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/DescribeEndpoints">REST API Reference for DescribeEndpoints Operation</seealso>
        DescribeEndpointsResponse EndDescribeEndpoints(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeTable


        /// <summary>
        /// Returns information about the table, including the table name, database name, retention
        /// duration of the memory store and the magnetic store. <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/ts-limits.html">Service
        /// quotas apply</a>. See <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/code-samples.describe-table.html">code
        /// sample</a> for details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTable service method.</param>
        /// 
        /// <returns>The response from the DescribeTable service method, as returned by TimestreamWrite.</returns>
        /// <exception cref="Amazon.TimestreamWrite.Model.AccessDeniedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InternalServerException">
        /// Timestream was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user and they exceeded the service quotas. The request
        /// was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// An invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/DescribeTable">REST API Reference for DescribeTable Operation</seealso>
        DescribeTableResponse DescribeTable(DescribeTableRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTable operation on AmazonTimestreamWriteClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/DescribeTable">REST API Reference for DescribeTable Operation</seealso>
        IAsyncResult BeginDescribeTable(DescribeTableRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTable.</param>
        /// 
        /// <returns>Returns a  DescribeTableResult from TimestreamWrite.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/DescribeTable">REST API Reference for DescribeTable Operation</seealso>
        DescribeTableResponse EndDescribeTable(IAsyncResult asyncResult);

        #endregion
        
        #region  ListBatchLoadTasks


        /// <summary>
        /// Provides a list of batch load tasks, along with the name, status, when the task is
        /// resumable until, and other details. See <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/code-samples.list-batch-load-tasks.html">code
        /// sample</a> for details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBatchLoadTasks service method.</param>
        /// 
        /// <returns>The response from the ListBatchLoadTasks service method, as returned by TimestreamWrite.</returns>
        /// <exception cref="Amazon.TimestreamWrite.Model.AccessDeniedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InternalServerException">
        /// Timestream was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user and they exceeded the service quotas. The request
        /// was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// An invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/ListBatchLoadTasks">REST API Reference for ListBatchLoadTasks Operation</seealso>
        ListBatchLoadTasksResponse ListBatchLoadTasks(ListBatchLoadTasksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListBatchLoadTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBatchLoadTasks operation on AmazonTimestreamWriteClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBatchLoadTasks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/ListBatchLoadTasks">REST API Reference for ListBatchLoadTasks Operation</seealso>
        IAsyncResult BeginListBatchLoadTasks(ListBatchLoadTasksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListBatchLoadTasks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBatchLoadTasks.</param>
        /// 
        /// <returns>Returns a  ListBatchLoadTasksResult from TimestreamWrite.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/ListBatchLoadTasks">REST API Reference for ListBatchLoadTasks Operation</seealso>
        ListBatchLoadTasksResponse EndListBatchLoadTasks(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDatabases


        /// <summary>
        /// Returns a list of your Timestream databases. <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/ts-limits.html">Service
        /// quotas apply</a>. See <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/code-samples.list-db.html">code
        /// sample</a> for details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatabases service method.</param>
        /// 
        /// <returns>The response from the ListDatabases service method, as returned by TimestreamWrite.</returns>
        /// <exception cref="Amazon.TimestreamWrite.Model.AccessDeniedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InternalServerException">
        /// Timestream was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user and they exceeded the service quotas. The request
        /// was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// An invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/ListDatabases">REST API Reference for ListDatabases Operation</seealso>
        ListDatabasesResponse ListDatabases(ListDatabasesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDatabases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDatabases operation on AmazonTimestreamWriteClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDatabases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/ListDatabases">REST API Reference for ListDatabases Operation</seealso>
        IAsyncResult BeginListDatabases(ListDatabasesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDatabases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDatabases.</param>
        /// 
        /// <returns>Returns a  ListDatabasesResult from TimestreamWrite.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/ListDatabases">REST API Reference for ListDatabases Operation</seealso>
        ListDatabasesResponse EndListDatabases(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTables


        /// <summary>
        /// Provides a list of tables, along with the name, status, and retention properties of
        /// each table. See <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/code-samples.list-table.html">code
        /// sample</a> for details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTables service method.</param>
        /// 
        /// <returns>The response from the ListTables service method, as returned by TimestreamWrite.</returns>
        /// <exception cref="Amazon.TimestreamWrite.Model.AccessDeniedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InternalServerException">
        /// Timestream was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user and they exceeded the service quotas. The request
        /// was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// An invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/ListTables">REST API Reference for ListTables Operation</seealso>
        ListTablesResponse ListTables(ListTablesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTables operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTables operation on AmazonTimestreamWriteClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTables
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/ListTables">REST API Reference for ListTables Operation</seealso>
        IAsyncResult BeginListTables(ListTablesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTables operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTables.</param>
        /// 
        /// <returns>Returns a  ListTablesResult from TimestreamWrite.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/ListTables">REST API Reference for ListTables Operation</seealso>
        ListTablesResponse EndListTables(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists all tags on a Timestream resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by TimestreamWrite.</returns>
        /// <exception cref="Amazon.TimestreamWrite.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user and they exceeded the service quotas. The request
        /// was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// An invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonTimestreamWriteClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from TimestreamWrite.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ResumeBatchLoadTask


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResumeBatchLoadTask service method.</param>
        /// 
        /// <returns>The response from the ResumeBatchLoadTask service method, as returned by TimestreamWrite.</returns>
        /// <exception cref="Amazon.TimestreamWrite.Model.AccessDeniedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InternalServerException">
        /// Timestream was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user and they exceeded the service quotas. The request
        /// was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// An invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/ResumeBatchLoadTask">REST API Reference for ResumeBatchLoadTask Operation</seealso>
        ResumeBatchLoadTaskResponse ResumeBatchLoadTask(ResumeBatchLoadTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ResumeBatchLoadTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResumeBatchLoadTask operation on AmazonTimestreamWriteClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResumeBatchLoadTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/ResumeBatchLoadTask">REST API Reference for ResumeBatchLoadTask Operation</seealso>
        IAsyncResult BeginResumeBatchLoadTask(ResumeBatchLoadTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ResumeBatchLoadTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResumeBatchLoadTask.</param>
        /// 
        /// <returns>Returns a  ResumeBatchLoadTaskResult from TimestreamWrite.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/ResumeBatchLoadTask">REST API Reference for ResumeBatchLoadTask Operation</seealso>
        ResumeBatchLoadTaskResponse EndResumeBatchLoadTask(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Associates a set of tags with a Timestream resource. You can then activate these
        /// user-defined tags so that they appear on the Billing and Cost Management console for
        /// cost allocation tracking.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by TimestreamWrite.</returns>
        /// <exception cref="Amazon.TimestreamWrite.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ServiceQuotaExceededException">
        /// The instance quota of resource exceeded for this account.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user and they exceeded the service quotas. The request
        /// was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// An invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonTimestreamWriteClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from TimestreamWrite.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes the association of tags from a Timestream resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by TimestreamWrite.</returns>
        /// <exception cref="Amazon.TimestreamWrite.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ServiceQuotaExceededException">
        /// The instance quota of resource exceeded for this account.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user and they exceeded the service quotas. The request
        /// was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// An invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonTimestreamWriteClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from TimestreamWrite.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDatabase


        /// <summary>
        /// Modifies the KMS key for an existing database. While updating the database, you must
        /// specify the database name and the identifier of the new KMS key to be used (<code>KmsKeyId</code>).
        /// If there are any concurrent <code>UpdateDatabase</code> requests, first writer wins.
        /// 
        /// 
        ///  
        /// <para>
        /// See <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/code-samples.update-db.html">code
        /// sample</a> for details.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDatabase service method.</param>
        /// 
        /// <returns>The response from the UpdateDatabase service method, as returned by TimestreamWrite.</returns>
        /// <exception cref="Amazon.TimestreamWrite.Model.AccessDeniedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InternalServerException">
        /// Timestream was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ServiceQuotaExceededException">
        /// The instance quota of resource exceeded for this account.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user and they exceeded the service quotas. The request
        /// was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// An invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/UpdateDatabase">REST API Reference for UpdateDatabase Operation</seealso>
        UpdateDatabaseResponse UpdateDatabase(UpdateDatabaseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDatabase operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDatabase operation on AmazonTimestreamWriteClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDatabase
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/UpdateDatabase">REST API Reference for UpdateDatabase Operation</seealso>
        IAsyncResult BeginUpdateDatabase(UpdateDatabaseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDatabase operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDatabase.</param>
        /// 
        /// <returns>Returns a  UpdateDatabaseResult from TimestreamWrite.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/UpdateDatabase">REST API Reference for UpdateDatabase Operation</seealso>
        UpdateDatabaseResponse EndUpdateDatabase(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateTable


        /// <summary>
        /// Modifies the retention duration of the memory store and magnetic store for your Timestream
        /// table. Note that the change in retention duration takes effect immediately. For example,
        /// if the retention period of the memory store was initially set to 2 hours and then
        /// changed to 24 hours, the memory store will be capable of holding 24 hours of data,
        /// but will be populated with 24 hours of data 22 hours after this change was made. Timestream
        /// does not retrieve data from the magnetic store to populate the memory store. 
        /// 
        ///  
        /// <para>
        /// See <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/code-samples.update-table.html">code
        /// sample</a> for details.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTable service method.</param>
        /// 
        /// <returns>The response from the UpdateTable service method, as returned by TimestreamWrite.</returns>
        /// <exception cref="Amazon.TimestreamWrite.Model.AccessDeniedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InternalServerException">
        /// Timestream was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user and they exceeded the service quotas. The request
        /// was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// An invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/UpdateTable">REST API Reference for UpdateTable Operation</seealso>
        UpdateTableResponse UpdateTable(UpdateTableRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTable operation on AmazonTimestreamWriteClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/UpdateTable">REST API Reference for UpdateTable Operation</seealso>
        IAsyncResult BeginUpdateTable(UpdateTableRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTable.</param>
        /// 
        /// <returns>Returns a  UpdateTableResult from TimestreamWrite.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/UpdateTable">REST API Reference for UpdateTable Operation</seealso>
        UpdateTableResponse EndUpdateTable(IAsyncResult asyncResult);

        #endregion
        
        #region  WriteRecords


        /// <summary>
        /// Enables you to write your time-series data into Timestream. You can specify a single
        /// data point or a batch of data points to be inserted into the system. Timestream offers
        /// you a flexible schema that auto detects the column names and data types for your Timestream
        /// tables based on the dimension names and data types of the data points you specify
        /// when invoking writes into the database. 
        /// 
        ///  
        /// <para>
        /// Timestream supports eventual consistency read semantics. This means that when you
        /// query data immediately after writing a batch of data into Timestream, the query results
        /// might not reflect the results of a recently completed write operation. The results
        /// may also include some stale data. If you repeat the query request after a short time,
        /// the results should return the latest data. <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/ts-limits.html">Service
        /// quotas apply</a>. 
        /// </para>
        ///  
        /// <para>
        /// See <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/code-samples.write.html">code
        /// sample</a> for details.
        /// </para>
        ///  
        /// <para>
        ///  <b>Upserts</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use the <code>Version</code> parameter in a <code>WriteRecords</code> request
        /// to update data points. Timestream tracks a version number with each record. <code>Version</code>
        /// defaults to <code>1</code> when it's not specified for the record in the request.
        /// Timestream updates an existing record’s measure value along with its <code>Version</code>
        /// when it receives a write request with a higher <code>Version</code> number for that
        /// record. When it receives an update request where the measure value is the same as
        /// that of the existing record, Timestream still updates <code>Version</code>, if it
        /// is greater than the existing value of <code>Version</code>. You can update a data
        /// point as many times as desired, as long as the value of <code>Version</code> continuously
        /// increases. 
        /// </para>
        ///  
        /// <para>
        ///  For example, suppose you write a new record without indicating <code>Version</code>
        /// in the request. Timestream stores this record, and set <code>Version</code> to <code>1</code>.
        /// Now, suppose you try to update this record with a <code>WriteRecords</code> request
        /// of the same record with a different measure value but, like before, do not provide
        /// <code>Version</code>. In this case, Timestream will reject this update with a <code>RejectedRecordsException</code>
        /// since the updated record’s version is not greater than the existing value of Version.
        /// 
        /// </para>
        ///  
        /// <para>
        /// However, if you were to resend the update request with <code>Version</code> set to
        /// <code>2</code>, Timestream would then succeed in updating the record’s value, and
        /// the <code>Version</code> would be set to <code>2</code>. Next, suppose you sent a
        /// <code>WriteRecords</code> request with this same record and an identical measure value,
        /// but with <code>Version</code> set to <code>3</code>. In this case, Timestream would
        /// only update <code>Version</code> to <code>3</code>. Any further updates would need
        /// to send a version number greater than <code>3</code>, or the update requests would
        /// receive a <code>RejectedRecordsException</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the WriteRecords service method.</param>
        /// 
        /// <returns>The response from the WriteRecords service method, as returned by TimestreamWrite.</returns>
        /// <exception cref="Amazon.TimestreamWrite.Model.AccessDeniedException">
        /// You are not authorized to perform this action.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InternalServerException">
        /// Timestream was unable to fully process this request because of an internal server
        /// error.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.InvalidEndpointException">
        /// The requested endpoint was not valid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.RejectedRecordsException">
        /// WriteRecords would throw this exception in the following cases: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Records with duplicate data where there are multiple records with the same dimensions,
        /// timestamps, and measure names but: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Measure values are different
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Version is not present in the request <i>or</i> the value of version in the new record
        /// is equal to or lower than the existing value
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  In this case, if Timestream rejects data, the <code>ExistingVersion</code> field
        /// in the <code>RejectedRecords</code> response will indicate the current record’s version.
        /// To force an update, you can resend the request with a version for the record set to
        /// a value greater than the <code>ExistingVersion</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Records with timestamps that lie outside the retention duration of the memory store.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Records with dimensions or measures that exceed the Timestream defined limits. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  For more information, see <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/ts-limits.html">Quotas</a>
        /// in the Amazon Timestream Developer Guide. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user and they exceeded the service quotas. The request
        /// was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// An invalid or malformed request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/WriteRecords">REST API Reference for WriteRecords Operation</seealso>
        WriteRecordsResponse WriteRecords(WriteRecordsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the WriteRecords operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the WriteRecords operation on AmazonTimestreamWriteClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndWriteRecords
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/WriteRecords">REST API Reference for WriteRecords Operation</seealso>
        IAsyncResult BeginWriteRecords(WriteRecordsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  WriteRecords operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginWriteRecords.</param>
        /// 
        /// <returns>Returns a  WriteRecordsResult from TimestreamWrite.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/timestream-write-2018-11-01/WriteRecords">REST API Reference for WriteRecords Operation</seealso>
        WriteRecordsResponse EndWriteRecords(IAsyncResult asyncResult);

        #endregion
        
    }
}