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
using System.Threading;
using System.Threading.Tasks;
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
#if AWS_ASYNC_ENUMERABLES_API
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetRecordsResponse> GetRecordsAsync(GetRecordsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetShardIteratorResponse> GetShardIteratorAsync(GetShardIteratorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetStreamResponse> GetStreamAsync(GetStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListStreams



        /// <summary>
        /// Returns a list of all data capture streams associated with your Amazon Keyspaces account
        /// or for a specific keyspace or table. The response includes information such as stream
        /// ARNs, table associations, creation timestamps, and current status. This operation
        /// helps you discover and manage all active data streams in your Amazon Keyspaces environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStreams service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListStreamsResponse> ListStreamsAsync(ListStreamsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonKeyspacesStreamsConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonKeyspacesStreamsConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonKeyspacesStreamsConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonKeyspacesStreamsConfig to create AmazonKeyspacesStreamsClient");
            }

            return awsCredentials == null ? 
                    new AmazonKeyspacesStreamsClient(serviceClientConfig) :
                    new AmazonKeyspacesStreamsClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}