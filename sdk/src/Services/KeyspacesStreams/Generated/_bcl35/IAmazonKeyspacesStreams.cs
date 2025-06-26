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
 * Do not modify this file. This file is generated from the keyspacesstreams-2024-09-09.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.KeyspacesStreams.Model;

#pragma warning disable CS1570
namespace Amazon.KeyspacesStreams
{
    /// <summary>
    /// <para>Interface for accessing KeyspacesStreams</para>
    ///
    /// Amazon Keyspaces (for Apache Cassandra) change data capture (CDC) records change events
    /// for Amazon Keyspaces tables. The change events captured in a stream are time-ordered
    /// and de-duplicated write operations. Using stream data you can build event driven applications
    /// that incorporate near-real time change events from Amazon Keyspaces tables. 
    /// 
    ///  
    /// <para>
    /// Amazon Keyspaces CDC is serverless and scales the infrastructure for change events
    /// automatically based on the volume of changes on your table. 
    /// </para>
    ///  
    /// <para>
    ///  This API reference describes the Amazon Keyspaces CDC stream API in detail. 
    /// </para>
    ///  
    /// <para>
    /// For more information about Amazon Keyspaces CDC, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/cdc.html">Working
    /// with change data capture (CDC) streams in Amazon Keyspaces</a> in the <i>Amazon Keyspaces
    /// Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// To learn how Amazon Keyspaces CDC API actions are recorded with CloudTrail, see <a
    /// href="https://docs.aws.amazon.com/keyspaces/latest/devguide/logging-using-cloudtrail.html#service-name-info-in-cloudtrail">Amazon
    /// Keyspaces information in CloudTrail</a> in the <i>Amazon Keyspaces Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// To see the metrics Amazon Keyspaces CDC sends to Amazon CloudWatch, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/metrics-dimensions.html#keyspaces-cdc-metrics">Amazon
    /// Keyspaces change data capture (CDC) CloudWatch metrics</a> in the <i>Amazon Keyspaces
    /// Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial interface IAmazonKeyspacesStreams : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IKeyspacesStreamsPaginatorFactory Paginators { get; }
#endif


        
        #region  GetRecords


        /// <summary>
        /// Retrieves data records from a specified shard in an Amazon Keyspaces data stream.
        /// This operation returns a collection of data records from the shard, including the
        /// primary key columns and information about modifications made to the captured table
        /// data. Each record represents a single data modification in the Amazon Keyspaces table
        /// and includes metadata about when the change occurred.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecords service method.</param>
        /// 
        /// <returns>The response from the GetRecords service method, as returned by KeyspacesStreams.</returns>
        /// <exception cref="Amazon.KeyspacesStreams.Model.AccessDeniedException">
        /// You don't have sufficient access permissions to perform this operation. 
        /// 
        ///  
        /// <para>
        /// This exception occurs when your IAM user or role lacks the required permissions to
        /// access the Amazon Keyspaces resource or perform the requested action. Check your IAM
        /// policies and ensure they grant the necessary permissions.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyspacesStreams.Model.InternalServerException">
        /// The Amazon Keyspaces service encountered an unexpected error while processing the
        /// request. 
        /// 
        ///  
        /// <para>
        /// This internal server error is not related to your request parameters. Retry your request
        /// after a brief delay. If the issue persists, contact Amazon Web Services Support with
        /// details of your request to help identify and resolve the problem.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyspacesStreams.Model.ResourceNotFoundException">
        /// The requested resource doesn't exist or could not be found. 
        /// 
        ///  
        /// <para>
        /// This exception occurs when you attempt to access a keyspace, table, stream, or other
        /// Amazon Keyspaces resource that doesn't exist or that has been deleted. Verify that
        /// the resource identifier is correct and that the resource exists in your account.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyspacesStreams.Model.ThrottlingException">
        /// The request rate is too high and exceeds the service's throughput limits. 
        /// 
        ///  
        /// <para>
        /// This exception occurs when you send too many requests in a short period of time. Implement
        /// exponential backoff in your retry strategy to handle this exception. Reducing your
        /// request frequency or distributing requests more evenly can help avoid throughput exceptions.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyspacesStreams.Model.ValidationException">
        /// The request validation failed because one or more input parameters failed validation.
        /// 
        /// 
        ///  
        /// <para>
        /// This exception occurs when there are syntax errors in the request, field constraints
        /// are violated, or required parameters are missing. To help you fix the issue, the exception
        /// message provides details about which parameter failed and why.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspacesstreams-2024-09-09/GetRecords">REST API Reference for GetRecords Operation</seealso>
        GetRecordsResponse GetRecords(GetRecordsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRecords operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRecords operation on AmazonKeyspacesStreamsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRecords
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspacesstreams-2024-09-09/GetRecords">REST API Reference for GetRecords Operation</seealso>
        IAsyncResult BeginGetRecords(GetRecordsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRecords operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRecords.</param>
        /// 
        /// <returns>Returns a  GetRecordsResult from KeyspacesStreams.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspacesstreams-2024-09-09/GetRecords">REST API Reference for GetRecords Operation</seealso>
        GetRecordsResponse EndGetRecords(IAsyncResult asyncResult);

        #endregion
        
        #region  GetShardIterator


        /// <summary>
        /// Returns a shard iterator that serves as a bookmark for reading data from a specific
        /// position in an Amazon Keyspaces data stream's shard. The shard iterator specifies
        /// the shard position from which to start reading data records sequentially. You can
        /// specify whether to begin reading at the latest record, the oldest record, or at a
        /// particular sequence number within the shard.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetShardIterator service method.</param>
        /// 
        /// <returns>The response from the GetShardIterator service method, as returned by KeyspacesStreams.</returns>
        /// <exception cref="Amazon.KeyspacesStreams.Model.AccessDeniedException">
        /// You don't have sufficient access permissions to perform this operation. 
        /// 
        ///  
        /// <para>
        /// This exception occurs when your IAM user or role lacks the required permissions to
        /// access the Amazon Keyspaces resource or perform the requested action. Check your IAM
        /// policies and ensure they grant the necessary permissions.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyspacesStreams.Model.InternalServerException">
        /// The Amazon Keyspaces service encountered an unexpected error while processing the
        /// request. 
        /// 
        ///  
        /// <para>
        /// This internal server error is not related to your request parameters. Retry your request
        /// after a brief delay. If the issue persists, contact Amazon Web Services Support with
        /// details of your request to help identify and resolve the problem.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyspacesStreams.Model.ResourceNotFoundException">
        /// The requested resource doesn't exist or could not be found. 
        /// 
        ///  
        /// <para>
        /// This exception occurs when you attempt to access a keyspace, table, stream, or other
        /// Amazon Keyspaces resource that doesn't exist or that has been deleted. Verify that
        /// the resource identifier is correct and that the resource exists in your account.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyspacesStreams.Model.ThrottlingException">
        /// The request rate is too high and exceeds the service's throughput limits. 
        /// 
        ///  
        /// <para>
        /// This exception occurs when you send too many requests in a short period of time. Implement
        /// exponential backoff in your retry strategy to handle this exception. Reducing your
        /// request frequency or distributing requests more evenly can help avoid throughput exceptions.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyspacesStreams.Model.ValidationException">
        /// The request validation failed because one or more input parameters failed validation.
        /// 
        /// 
        ///  
        /// <para>
        /// This exception occurs when there are syntax errors in the request, field constraints
        /// are violated, or required parameters are missing. To help you fix the issue, the exception
        /// message provides details about which parameter failed and why.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspacesstreams-2024-09-09/GetShardIterator">REST API Reference for GetShardIterator Operation</seealso>
        GetShardIteratorResponse GetShardIterator(GetShardIteratorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetShardIterator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetShardIterator operation on AmazonKeyspacesStreamsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetShardIterator
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspacesstreams-2024-09-09/GetShardIterator">REST API Reference for GetShardIterator Operation</seealso>
        IAsyncResult BeginGetShardIterator(GetShardIteratorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetShardIterator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetShardIterator.</param>
        /// 
        /// <returns>Returns a  GetShardIteratorResult from KeyspacesStreams.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspacesstreams-2024-09-09/GetShardIterator">REST API Reference for GetShardIterator Operation</seealso>
        GetShardIteratorResponse EndGetShardIterator(IAsyncResult asyncResult);

        #endregion
        
        #region  GetStream


        /// <summary>
        /// Returns detailed information about a specific data capture stream for an Amazon Keyspaces
        /// table. The information includes the stream's Amazon Resource Name (ARN), creation
        /// time, current status, retention period, shard composition, and associated table details.
        /// This operation helps you monitor and manage the configuration of your Amazon Keyspaces
        /// data streams.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStream service method.</param>
        /// 
        /// <returns>The response from the GetStream service method, as returned by KeyspacesStreams.</returns>
        /// <exception cref="Amazon.KeyspacesStreams.Model.AccessDeniedException">
        /// You don't have sufficient access permissions to perform this operation. 
        /// 
        ///  
        /// <para>
        /// This exception occurs when your IAM user or role lacks the required permissions to
        /// access the Amazon Keyspaces resource or perform the requested action. Check your IAM
        /// policies and ensure they grant the necessary permissions.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyspacesStreams.Model.InternalServerException">
        /// The Amazon Keyspaces service encountered an unexpected error while processing the
        /// request. 
        /// 
        ///  
        /// <para>
        /// This internal server error is not related to your request parameters. Retry your request
        /// after a brief delay. If the issue persists, contact Amazon Web Services Support with
        /// details of your request to help identify and resolve the problem.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyspacesStreams.Model.ResourceNotFoundException">
        /// The requested resource doesn't exist or could not be found. 
        /// 
        ///  
        /// <para>
        /// This exception occurs when you attempt to access a keyspace, table, stream, or other
        /// Amazon Keyspaces resource that doesn't exist or that has been deleted. Verify that
        /// the resource identifier is correct and that the resource exists in your account.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyspacesStreams.Model.ThrottlingException">
        /// The request rate is too high and exceeds the service's throughput limits. 
        /// 
        ///  
        /// <para>
        /// This exception occurs when you send too many requests in a short period of time. Implement
        /// exponential backoff in your retry strategy to handle this exception. Reducing your
        /// request frequency or distributing requests more evenly can help avoid throughput exceptions.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyspacesStreams.Model.ValidationException">
        /// The request validation failed because one or more input parameters failed validation.
        /// 
        /// 
        ///  
        /// <para>
        /// This exception occurs when there are syntax errors in the request, field constraints
        /// are violated, or required parameters are missing. To help you fix the issue, the exception
        /// message provides details about which parameter failed and why.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspacesstreams-2024-09-09/GetStream">REST API Reference for GetStream Operation</seealso>
        GetStreamResponse GetStream(GetStreamRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStream operation on AmazonKeyspacesStreamsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetStream
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspacesstreams-2024-09-09/GetStream">REST API Reference for GetStream Operation</seealso>
        IAsyncResult BeginGetStream(GetStreamRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStream.</param>
        /// 
        /// <returns>Returns a  GetStreamResult from KeyspacesStreams.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspacesstreams-2024-09-09/GetStream">REST API Reference for GetStream Operation</seealso>
        GetStreamResponse EndGetStream(IAsyncResult asyncResult);

        #endregion
        
        #region  ListStreams


        /// <summary>
        /// Returns a list of all data capture streams associated with your Amazon Keyspaces account
        /// or for a specific keyspace or table. The response includes information such as stream
        /// ARNs, table associations, creation timestamps, and current status. This operation
        /// helps you discover and manage all active data streams in your Amazon Keyspaces environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStreams service method.</param>
        /// 
        /// <returns>The response from the ListStreams service method, as returned by KeyspacesStreams.</returns>
        /// <exception cref="Amazon.KeyspacesStreams.Model.AccessDeniedException">
        /// You don't have sufficient access permissions to perform this operation. 
        /// 
        ///  
        /// <para>
        /// This exception occurs when your IAM user or role lacks the required permissions to
        /// access the Amazon Keyspaces resource or perform the requested action. Check your IAM
        /// policies and ensure they grant the necessary permissions.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyspacesStreams.Model.InternalServerException">
        /// The Amazon Keyspaces service encountered an unexpected error while processing the
        /// request. 
        /// 
        ///  
        /// <para>
        /// This internal server error is not related to your request parameters. Retry your request
        /// after a brief delay. If the issue persists, contact Amazon Web Services Support with
        /// details of your request to help identify and resolve the problem.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyspacesStreams.Model.ResourceNotFoundException">
        /// The requested resource doesn't exist or could not be found. 
        /// 
        ///  
        /// <para>
        /// This exception occurs when you attempt to access a keyspace, table, stream, or other
        /// Amazon Keyspaces resource that doesn't exist or that has been deleted. Verify that
        /// the resource identifier is correct and that the resource exists in your account.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyspacesStreams.Model.ThrottlingException">
        /// The request rate is too high and exceeds the service's throughput limits. 
        /// 
        ///  
        /// <para>
        /// This exception occurs when you send too many requests in a short period of time. Implement
        /// exponential backoff in your retry strategy to handle this exception. Reducing your
        /// request frequency or distributing requests more evenly can help avoid throughput exceptions.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyspacesStreams.Model.ValidationException">
        /// The request validation failed because one or more input parameters failed validation.
        /// 
        /// 
        ///  
        /// <para>
        /// This exception occurs when there are syntax errors in the request, field constraints
        /// are violated, or required parameters are missing. To help you fix the issue, the exception
        /// message provides details about which parameter failed and why.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspacesstreams-2024-09-09/ListStreams">REST API Reference for ListStreams Operation</seealso>
        ListStreamsResponse ListStreams(ListStreamsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListStreams operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStreams operation on AmazonKeyspacesStreamsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStreams
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspacesstreams-2024-09-09/ListStreams">REST API Reference for ListStreams Operation</seealso>
        IAsyncResult BeginListStreams(ListStreamsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListStreams operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStreams.</param>
        /// 
        /// <returns>Returns a  ListStreamsResult from KeyspacesStreams.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/keyspacesstreams-2024-09-09/ListStreams">REST API Reference for ListStreams Operation</seealso>
        ListStreamsResponse EndListStreams(IAsyncResult asyncResult);

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