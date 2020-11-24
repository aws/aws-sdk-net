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
    /// Amazon Timestream is a fast, scalable, fully managed time series database service
    /// that makes it easy to store and analyze trillions of time series data points per day.
    /// With Timestream, you can easily store and analyze IoT sensor data to derive insights
    /// from your IoT applications. You can analyze industrial telemetry to streamline equipment
    /// management and maintenance. You can also store and analyze log data and metrics to
    /// improve the performance and availability of your applications. Timestream is built
    /// from the ground up to effectively ingest, process, and store time series data. It
    /// organizes data to optimize query processing. It automatically scales based on the
    /// volume of data ingested and on the query volume to ensure you receive optimal performance
    /// while inserting and querying data. As your data grows over time, Timestream’s adaptive
    /// query processing engine spans across storage tiers to provide fast analysis while
    /// reducing costs.
    /// </summary>
    public partial interface IAmazonTimestreamWrite : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ITimestreamWritePaginatorFactory Paginators { get; }
#endif


        
        #region  CreateDatabase


        /// <summary>
        /// Creates a new Timestream database. If the KMS key is not specified, the database will
        /// be encrypted with a Timestream managed KMS key located in your account. Refer to <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-cmk">AWS
        /// managed KMS keys</a> for more info. Service quotas apply. For more information, see
        /// <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/ts-limits.html">Access
        /// Management</a> in the Timestream Developer Guide.
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
        /// The requested endpoint was invalid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ServiceQuotaExceededException">
        /// Instance quota of resource exceeded for this account.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user exceeding service quotas. The request was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// Invalid or malformed request.
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
        /// The CreateTable operation adds a new table to an existing database in your account.
        /// In an AWS account, table names must be at least unique within each Region if they
        /// are in the same database. You may have identical table names in the same Region if
        /// the tables are in seperate databases. While creating the table, you must specify the
        /// table name, database name, and the retention properties. Service quotas apply. For
        /// more information, see <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/ts-limits.html">Access
        /// Management</a> in the Timestream Developer Guide.
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
        /// The requested endpoint was invalid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ServiceQuotaExceededException">
        /// Instance quota of resource exceeded for this account.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user exceeding service quotas. The request was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// Invalid or malformed request.
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
        /// database is deleted, the time series data from its tables cannot be recovered.</i>
        /// 
        /// 
        ///  
        /// <para>
        /// All tables in the database must be deleted first, or a ValidationException error will
        /// be thrown. 
        /// </para>
        ///  
        /// <para>
        /// Due to the nature of distributed retries, the operation can return either success
        /// or a ResourceNotFoundException. Clients should consider them equivalent.
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
        /// The requested endpoint was invalid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user exceeding service quotas. The request was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// Invalid or malformed request.
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
        /// database table is deleted, the time series data stored in the table cannot be recovered.
        /// 
        /// 
        ///  
        /// <para>
        /// Due to the nature of distributed retries, the operation can return either success
        /// or a ResourceNotFoundException. Clients should consider them equivalent.
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
        /// The requested endpoint was invalid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user exceeding service quotas. The request was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// Invalid or malformed request.
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
        
        #region  DescribeDatabase


        /// <summary>
        /// Returns information about the database, including the database name, time that the
        /// database was created, and the total number of tables found within the database. Service
        /// quotas apply. For more information, see <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/ts-limits.html">Access
        /// Management</a> in the Timestream Developer Guide.
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
        /// The requested endpoint was invalid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user exceeding service quotas. The request was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// Invalid or malformed request.
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
        /// DescribeEndpoints returns a list of available endpoints to make Timestream API calls
        /// against. This API is available through both Write and Query.
        /// 
        ///  
        /// <para>
        /// Because Timestream’s SDKs are designed to transparently work with the service’s architecture,
        /// including the management and mapping of the service endpoints, <i>it is not recommended
        /// that you use this API unless</i>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Your application uses a programming language that does not yet have SDK support
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You require better control over the client-side implementation
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For detailed information on how to use DescribeEndpoints, see <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/Using-API.endpoint-discovery.html">The
        /// Endpoint Discovery Pattern and REST APIs</a>.
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
        /// Too many requests were made by a user exceeding service quotas. The request was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// Invalid or malformed request.
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
        /// duration of the memory store and the magnetic store. Service quotas apply. For more
        /// information, see <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/ts-limits.html">Access
        /// Management</a> in the Timestream Developer Guide.
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
        /// The requested endpoint was invalid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user exceeding service quotas. The request was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// Invalid or malformed request.
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
        
        #region  ListDatabases


        /// <summary>
        /// Returns a list of your Timestream databases. Service quotas apply. For more information,
        /// see <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/ts-limits.html">Access
        /// Management</a> in the Timestream Developer Guide.
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
        /// The requested endpoint was invalid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user exceeding service quotas. The request was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// Invalid or malformed request.
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
        /// A list of tables, along with the name, status and retention properties of each table.
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
        /// The requested endpoint was invalid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user exceeding service quotas. The request was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// Invalid or malformed request.
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
        /// List all tags on a Timestream resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by TimestreamWrite.</returns>
        /// <exception cref="Amazon.TimestreamWrite.Model.InvalidEndpointException">
        /// The requested endpoint was invalid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user exceeding service quotas. The request was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// Invalid or malformed request.
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
        
        #region  TagResource


        /// <summary>
        /// Associate a set of tags with a Timestream resource. You can then activate these user-defined
        /// tags so that they appear on the Billing and Cost Management console for cost allocation
        /// tracking.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by TimestreamWrite.</returns>
        /// <exception cref="Amazon.TimestreamWrite.Model.InvalidEndpointException">
        /// The requested endpoint was invalid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ServiceQuotaExceededException">
        /// Instance quota of resource exceeded for this account.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user exceeding service quotas. The request was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// Invalid or malformed request.
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
        /// The requested endpoint was invalid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ServiceQuotaExceededException">
        /// Instance quota of resource exceeded for this account.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user exceeding service quotas. The request was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// Invalid or malformed request.
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
        /// The requested endpoint was invalid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ServiceQuotaExceededException">
        /// Instance quota of resource exceeded for this account.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user exceeding service quotas. The request was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// Invalid or malformed request.
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
        /// Service quotas apply. For more information, see <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/ts-limits.html">Access
        /// Management</a> in the Timestream Developer Guide.
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
        /// The requested endpoint was invalid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user exceeding service quotas. The request was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// Invalid or malformed request.
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
        /// The WriteRecords operation enables you to write your time series data into Timestream.
        /// You can specify a single data point or a batch of data points to be inserted into
        /// the system. Timestream offers you with a flexible schema that auto detects the column
        /// names and data types for your Timestream tables based on the dimension names and data
        /// types of the data points you specify when invoking writes into the database. Timestream
        /// support eventual consistency read semantics. This means that when you query data immediately
        /// after writing a batch of data into Timestream, the query results might not reflect
        /// the results of a recently completed write operation. The results may also include
        /// some stale data. If you repeat the query request after a short time, the results should
        /// return the latest data. Service quotas apply. For more information, see <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/ts-limits.html">Access
        /// Management</a> in the Timestream Developer Guide.
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
        /// The requested endpoint was invalid.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.RejectedRecordsException">
        /// WriteRecords would throw this exception in the following cases: 
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  Records with duplicate data where there are multiple records with the same dimensions,
        /// timestamps, and measure names but different measure values. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Records with timestamps that lie outside the retention duration of the memory store
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Records with dimensions or measures that exceed the Timestream defined limits. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  For more information, see <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/ts-limits.html">Access
        /// Management</a> in the Timestream Developer Guide. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent resource. The resource might not be specified
        /// correctly, or its status might not be ACTIVE.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ThrottlingException">
        /// Too many requests were made by a user exceeding service quotas. The request was throttled.
        /// </exception>
        /// <exception cref="Amazon.TimestreamWrite.Model.ValidationException">
        /// Invalid or malformed request.
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