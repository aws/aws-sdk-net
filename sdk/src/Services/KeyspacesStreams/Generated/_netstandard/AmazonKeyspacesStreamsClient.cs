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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.KeyspacesStreams.Model;
using Amazon.KeyspacesStreams.Model.Internal.MarshallTransformations;
using Amazon.KeyspacesStreams.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.KeyspacesStreams
{
    /// <summary>
    /// <para>Implementation for accessing KeyspacesStreams</para>
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
    public partial class AmazonKeyspacesStreamsClient : AmazonServiceClient, IAmazonKeyspacesStreams
    {
        private static IServiceMetadata serviceMetadata = new AmazonKeyspacesStreamsMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonKeyspacesStreamsClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonKeyspacesStreamsClient()
            : base(new AmazonKeyspacesStreamsConfig()) { }

        /// <summary>
        /// Constructs AmazonKeyspacesStreamsClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonKeyspacesStreamsClient(RegionEndpoint region)
            : base(new AmazonKeyspacesStreamsConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonKeyspacesStreamsClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonKeyspacesStreamsClient Configuration Object</param>
        public AmazonKeyspacesStreamsClient(AmazonKeyspacesStreamsConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonKeyspacesStreamsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonKeyspacesStreamsClient(AWSCredentials credentials)
            : this(credentials, new AmazonKeyspacesStreamsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKeyspacesStreamsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKeyspacesStreamsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonKeyspacesStreamsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonKeyspacesStreamsClient with AWS Credentials and an
        /// AmazonKeyspacesStreamsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonKeyspacesStreamsClient Configuration Object</param>
        public AmazonKeyspacesStreamsClient(AWSCredentials credentials, AmazonKeyspacesStreamsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonKeyspacesStreamsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonKeyspacesStreamsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonKeyspacesStreamsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKeyspacesStreamsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKeyspacesStreamsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonKeyspacesStreamsConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonKeyspacesStreamsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonKeyspacesStreamsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonKeyspacesStreamsClient Configuration Object</param>
        public AmazonKeyspacesStreamsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonKeyspacesStreamsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonKeyspacesStreamsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonKeyspacesStreamsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonKeyspacesStreamsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKeyspacesStreamsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKeyspacesStreamsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonKeyspacesStreamsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonKeyspacesStreamsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonKeyspacesStreamsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonKeyspacesStreamsClient Configuration Object</param>
        public AmazonKeyspacesStreamsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonKeyspacesStreamsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IKeyspacesStreamsPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IKeyspacesStreamsPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new KeyspacesStreamsPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonKeyspacesStreamsEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonKeyspacesStreamsAuthSchemeHandler());
        }

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  GetRecords

        internal virtual GetRecordsResponse GetRecords(GetRecordsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecordsResponseUnmarshaller.Instance;

            return Invoke<GetRecordsResponse>(request, options);
        }



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
        public virtual Task<GetRecordsResponse> GetRecordsAsync(GetRecordsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetRecordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecordsResponseUnmarshaller.Instance;

            return InvokeAsync<GetRecordsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetShardIterator

        internal virtual GetShardIteratorResponse GetShardIterator(GetShardIteratorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetShardIteratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetShardIteratorResponseUnmarshaller.Instance;

            return Invoke<GetShardIteratorResponse>(request, options);
        }



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
        public virtual Task<GetShardIteratorResponse> GetShardIteratorAsync(GetShardIteratorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetShardIteratorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetShardIteratorResponseUnmarshaller.Instance;

            return InvokeAsync<GetShardIteratorResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetStream

        internal virtual GetStreamResponse GetStream(GetStreamRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStreamResponseUnmarshaller.Instance;

            return Invoke<GetStreamResponse>(request, options);
        }



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
        public virtual Task<GetStreamResponse> GetStreamAsync(GetStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStreamResponseUnmarshaller.Instance;

            return InvokeAsync<GetStreamResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListStreams

        internal virtual ListStreamsResponse ListStreams(ListStreamsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListStreamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStreamsResponseUnmarshaller.Instance;

            return Invoke<ListStreamsResponse>(request, options);
        }



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
        public virtual Task<ListStreamsResponse> ListStreamsAsync(ListStreamsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListStreamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStreamsResponseUnmarshaller.Instance;

            return InvokeAsync<ListStreamsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}