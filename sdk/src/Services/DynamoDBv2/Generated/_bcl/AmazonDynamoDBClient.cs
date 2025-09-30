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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.DynamoDBv2.Model;
using Amazon.DynamoDBv2.Model.Internal.MarshallTransformations;
using Amazon.DynamoDBv2.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.DynamoDBv2
{
    /// <summary>
    /// <para>Implementation for accessing DynamoDB</para>
    ///
    /// Amazon DynamoDB 
    /// <para>
    /// Amazon DynamoDB is a fully managed NoSQL database service that provides fast and predictable
    /// performance with seamless scalability. DynamoDB lets you offload the administrative
    /// burdens of operating and scaling a distributed database, so that you don't have to
    /// worry about hardware provisioning, setup and configuration, replication, software
    /// patching, or cluster scaling.
    /// </para>
    ///  
    /// <para>
    /// With DynamoDB, you can create database tables that can store and retrieve any amount
    /// of data, and serve any level of request traffic. You can scale up or scale down your
    /// tables' throughput capacity without downtime or performance degradation, and use the
    /// Amazon Web Services Management Console to monitor resource utilization and performance
    /// metrics.
    /// </para>
    ///  
    /// <para>
    /// DynamoDB automatically spreads the data and traffic for your tables over a sufficient
    /// number of servers to handle your throughput and storage requirements, while maintaining
    /// consistent and fast performance. All of your data is stored on solid state disks (SSDs)
    /// and automatically replicated across multiple Availability Zones in an Amazon Web Services
    /// Region, providing built-in high availability and data durability.
    /// </para>
    /// </summary>
    public partial class AmazonDynamoDBClient : AmazonServiceClient, IAmazonDynamoDB
    {
        private static IServiceMetadata serviceMetadata = new AmazonDynamoDBMetadata();
        private IDynamoDBv2PaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IDynamoDBv2PaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new DynamoDBv2PaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonDynamoDBClient with the credentials loaded from the application's
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
        public AmazonDynamoDBClient()
            : base(new AmazonDynamoDBConfig()) { }

        /// <summary>
        /// Constructs AmazonDynamoDBClient with the credentials loaded from the application's
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
        public AmazonDynamoDBClient(RegionEndpoint region)
            : base(new AmazonDynamoDBConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonDynamoDBClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonDynamoDBClient Configuration Object</param>
        public AmazonDynamoDBClient(AmazonDynamoDBConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonDynamoDBClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonDynamoDBClient(AWSCredentials credentials)
            : this(credentials, new AmazonDynamoDBConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDynamoDBClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDynamoDBClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonDynamoDBConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDynamoDBClient with AWS Credentials and an
        /// AmazonDynamoDBClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonDynamoDBClient Configuration Object</param>
        public AmazonDynamoDBClient(AWSCredentials credentials, AmazonDynamoDBConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDynamoDBClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonDynamoDBClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDynamoDBConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDynamoDBClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDynamoDBClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDynamoDBConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonDynamoDBClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDynamoDBClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonDynamoDBClient Configuration Object</param>
        public AmazonDynamoDBClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonDynamoDBConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDynamoDBClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonDynamoDBClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDynamoDBConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDynamoDBClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDynamoDBClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDynamoDBConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDynamoDBClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDynamoDBClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonDynamoDBClient Configuration Object</param>
        public AmazonDynamoDBClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonDynamoDBConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides  

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonDynamoDBEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonDynamoDBAuthSchemeHandler());
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

        #region  EndpointOperation Override

        /// <summary>
        /// Resolve endpoint for service api request.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        protected override IEnumerable<DiscoveryEndpointBase> EndpointOperation(EndpointOperationContextBase context)
        {
            return EndpointDiscoveryResolver.ResolveEndpoints(context, () =>
            {
                var request = new DescribeEndpointsRequest
                {
                };
                
                var response = DescribeEndpoints(request);
                if(response.HttpStatusCode != HttpStatusCode.OK || response.Endpoints == null)
                {
                    return null;
                }

                var endpoints = new List<DiscoveryEndpointBase>();
                foreach(var endpoint in response.Endpoints)
                {
                    endpoints.Add(new DiscoveryEndpoint(endpoint.Address, endpoint.CachePeriodInMinutes.GetValueOrDefault()));
                }
            
                return endpoints;
            });
        }

        #endregion

        #region  BatchExecuteStatement


        /// <summary>
        /// This operation allows you to perform batch reads or writes on data stored in DynamoDB,
        /// using PartiQL. Each read statement in a <c>BatchExecuteStatement</c> must specify
        /// an equality condition on all key attributes. This enforces that each <c>SELECT</c>
        /// statement in a batch returns at most a single item. For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/ql-reference.multiplestatements.batching.html">Running
        /// batch operations with PartiQL for DynamoDB </a>.
        /// 
        ///  <note> 
        /// <para>
        /// The entire batch must consist of either read statements or write statements, you cannot
        /// mix both in one batch.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// A HTTP 200 response does not mean that all statements in the BatchExecuteStatement
        /// succeeded. Error details for individual statements can be found under the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_BatchStatementResponse.html#DDB-Type-BatchStatementResponse-Error">Error</a>
        /// field of the <c>BatchStatementResponse</c> for each statement.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchExecuteStatement service method.</param>
        /// 
        /// <returns>The response from the BatchExecuteStatement service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.RequestLimitExceededException">
        /// Throughput exceeds the current throughput quota for your account. For detailed information
        /// about why the request was throttled and the ARN of the impacted resource, find the
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. Contact <a href="https://aws.amazon.com/support">Amazon
        /// Web Services Support</a> to request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ThrottlingException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/BatchExecuteStatement">REST API Reference for BatchExecuteStatement Operation</seealso>
        public virtual BatchExecuteStatementResponse BatchExecuteStatement(BatchExecuteStatementRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchExecuteStatementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchExecuteStatementResponseUnmarshaller.Instance;

            return Invoke<BatchExecuteStatementResponse>(request, options);
        }


        /// <summary>
        /// This operation allows you to perform batch reads or writes on data stored in DynamoDB,
        /// using PartiQL. Each read statement in a <c>BatchExecuteStatement</c> must specify
        /// an equality condition on all key attributes. This enforces that each <c>SELECT</c>
        /// statement in a batch returns at most a single item. For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/ql-reference.multiplestatements.batching.html">Running
        /// batch operations with PartiQL for DynamoDB </a>.
        /// 
        ///  <note> 
        /// <para>
        /// The entire batch must consist of either read statements or write statements, you cannot
        /// mix both in one batch.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// A HTTP 200 response does not mean that all statements in the BatchExecuteStatement
        /// succeeded. Error details for individual statements can be found under the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_BatchStatementResponse.html#DDB-Type-BatchStatementResponse-Error">Error</a>
        /// field of the <c>BatchStatementResponse</c> for each statement.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchExecuteStatement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchExecuteStatement service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.RequestLimitExceededException">
        /// Throughput exceeds the current throughput quota for your account. For detailed information
        /// about why the request was throttled and the ARN of the impacted resource, find the
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. Contact <a href="https://aws.amazon.com/support">Amazon
        /// Web Services Support</a> to request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ThrottlingException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/BatchExecuteStatement">REST API Reference for BatchExecuteStatement Operation</seealso>
        public virtual Task<BatchExecuteStatementResponse> BatchExecuteStatementAsync(BatchExecuteStatementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchExecuteStatementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchExecuteStatementResponseUnmarshaller.Instance;
            
            return InvokeAsync<BatchExecuteStatementResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchGetItem


        /// <summary>
        /// The <c>BatchGetItem</c> operation returns the attributes of one or more items from
        /// one or more tables. You identify requested items by primary key.
        /// 
        ///  
        /// <para>
        /// A single operation can retrieve up to 16 MB of data, which can contain as many as
        /// 100 items. <c>BatchGetItem</c> returns a partial result if the response size limit
        /// is exceeded, the table's provisioned throughput is exceeded, more than 1MB per partition
        /// is requested, or an internal processing failure occurs. If a partial result is returned,
        /// the operation returns a value for <c>UnprocessedKeys</c>. You can use this value to
        /// retry the operation starting with the next item to get.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you request more than 100 items, <c>BatchGetItem</c> returns a <c>ValidationException</c>
        /// with the message "Too many items requested for the BatchGetItem call."
        /// </para>
        ///  </important> 
        /// <para>
        /// For example, if you ask to retrieve 100 items, but each individual item is 300 KB
        /// in size, the system returns 52 items (so as not to exceed the 16 MB limit). It also
        /// returns an appropriate <c>UnprocessedKeys</c> value so you can get the next page of
        /// results. If desired, your application can include its own logic to assemble the pages
        /// of results into one dataset.
        /// </para>
        ///  
        /// <para>
        /// If <i>none</i> of the items can be processed due to insufficient provisioned throughput
        /// on all of the tables in the request, then <c>BatchGetItem</c> returns a <c>ProvisionedThroughputExceededException</c>.
        /// If <i>at least one</i> of the items is successfully processed, then <c>BatchGetItem</c>
        /// completes successfully, while returning the keys of the unread items in <c>UnprocessedKeys</c>.
        /// </para>
        ///  <important> 
        /// <para>
        /// If DynamoDB returns any unprocessed items, you should retry the batch operation on
        /// those items. However, <i>we strongly recommend that you use an exponential backoff
        /// algorithm</i>. If you retry the batch operation immediately, the underlying read or
        /// write requests can still fail due to throttling on the individual tables. If you delay
        /// the batch operation using exponential backoff, the individual requests in the batch
        /// are much more likely to succeed.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/ErrorHandling.html#BatchOperations">Batch
        /// Operations and Error Handling</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        ///  </important> 
        /// <para>
        /// By default, <c>BatchGetItem</c> performs eventually consistent reads on every table
        /// in the request. If you want strongly consistent reads instead, you can set <c>ConsistentRead</c>
        /// to <c>true</c> for any or all tables.
        /// </para>
        ///  
        /// <para>
        /// In order to minimize response latency, <c>BatchGetItem</c> may retrieve items in parallel.
        /// </para>
        ///  
        /// <para>
        /// When designing your application, keep in mind that DynamoDB does not return items
        /// in any particular order. To help parse the response by item, include the primary key
        /// values for the items in your request in the <c>ProjectionExpression</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// If a requested item does not exist, it is not returned in the result. Requests for
        /// nonexistent items consume the minimum read capacity units according to the type of
        /// read. For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/WorkingWithTables.html#CapacityUnitCalculations">Working
        /// with Tables</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>BatchGetItem</c> will result in a <c>ValidationException</c> if the same key is
        /// specified multiple times.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="requestItems">A map of one or more table names or table ARNs and, for each table, a map that describes one or more items to retrieve from that table. Each table name or ARN can be used only once per <c>BatchGetItem</c> request. Each element in the map of items to retrieve consists of the following: <ul> <li>  <c>ConsistentRead</c> - If <c>true</c>, a strongly consistent read is used; if <c>false</c> (the default), an eventually consistent read is used. </li> <li>  <c>ExpressionAttributeNames</c> - One or more substitution tokens for attribute names in the <c>ProjectionExpression</c> parameter. The following are some use cases for using <c>ExpressionAttributeNames</c>: <ul> <li> To access an attribute whose name conflicts with a DynamoDB reserved word. </li> <li> To create a placeholder for repeating occurrences of an attribute name in an expression. </li> <li> To prevent special characters in an attribute name from being misinterpreted in an expression. </li> </ul> Use the <b>#</b> character in an expression to dereference an attribute name. For example, consider the following attribute name: <ul> <li>  <c>Percentile</c>  </li> </ul> The name of this attribute conflicts with a reserved word, so it cannot be used directly in an expression. (For the complete list of reserved words, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/ReservedWords.html">Reserved Words</a> in the <i>Amazon DynamoDB Developer Guide</i>). To work around this, you could specify the following for <c>ExpressionAttributeNames</c>: <ul> <li>  <c>{"#P":"Percentile"}</c>  </li> </ul> You could then use this substitution in an expression, as in this example: <ul> <li>  <c>#P = :val</c>  </li> </ul> <note> Tokens that begin with the <b>:</b> character are <i>expression attribute values</i>, which are placeholders for the actual value at runtime. </note> For more information about expression attribute names, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Expressions.AccessingItemAttributes.html">Accessing Item Attributes</a> in the <i>Amazon DynamoDB Developer Guide</i>. </li> <li>  <c>Keys</c> - An array of primary key attribute values that define specific items in the table. For each primary key, you must provide <i>all</i> of the key attributes. For example, with a simple primary key, you only need to provide the partition key value. For a composite key, you must provide <i>both</i> the partition key value and the sort key value. </li> <li>  <c>ProjectionExpression</c> - A string that identifies one or more attributes to retrieve from the table. These attributes can include scalars, sets, or elements of a JSON document. The attributes in the expression must be separated by commas. If no attribute names are specified, then all attributes are returned. If any of the requested attributes are not found, they do not appear in the result. For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Expressions.AccessingItemAttributes.html">Accessing Item Attributes</a> in the <i>Amazon DynamoDB Developer Guide</i>. </li> <li>  <c>AttributesToGet</c> - This is a legacy parameter. Use <c>ProjectionExpression</c> instead. For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/LegacyConditionalParameters.AttributesToGet.html">AttributesToGet</a> in the <i>Amazon DynamoDB Developer Guide</i>.  </li> </ul></param>
        /// <param name="returnConsumedCapacity">A property of BatchGetItemRequest used to execute the BatchGetItem service method.</param>
        /// 
        /// <returns>The response from the BatchGetItem service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. The Amazon Web Services SDKs for DynamoDB automatically
        /// retry requests that receive this exception. Your request is eventually successful,
        /// unless your retry queue is too large to finish. Reduce the frequency of requests and
        /// use exponential backoff. For more information, go to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Programming.Errors.html#Programming.Errors.RetryAndBackoff">Error
        /// Retries and Exponential Backoff</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.RequestLimitExceededException">
        /// Throughput exceeds the current throughput quota for your account. For detailed information
        /// about why the request was throttled and the ARN of the impacted resource, find the
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. Contact <a href="https://aws.amazon.com/support">Amazon
        /// Web Services Support</a> to request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ThrottlingException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/BatchGetItem">REST API Reference for BatchGetItem Operation</seealso>
        public virtual BatchGetItemResponse BatchGetItem(Dictionary<string, KeysAndAttributes> requestItems, ReturnConsumedCapacity returnConsumedCapacity)
        {
            var request = new BatchGetItemRequest();
            request.RequestItems = requestItems;
            request.ReturnConsumedCapacity = returnConsumedCapacity;
            return BatchGetItem(request);
        }


        /// <summary>
        /// The <c>BatchGetItem</c> operation returns the attributes of one or more items from
        /// one or more tables. You identify requested items by primary key.
        /// 
        ///  
        /// <para>
        /// A single operation can retrieve up to 16 MB of data, which can contain as many as
        /// 100 items. <c>BatchGetItem</c> returns a partial result if the response size limit
        /// is exceeded, the table's provisioned throughput is exceeded, more than 1MB per partition
        /// is requested, or an internal processing failure occurs. If a partial result is returned,
        /// the operation returns a value for <c>UnprocessedKeys</c>. You can use this value to
        /// retry the operation starting with the next item to get.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you request more than 100 items, <c>BatchGetItem</c> returns a <c>ValidationException</c>
        /// with the message "Too many items requested for the BatchGetItem call."
        /// </para>
        ///  </important> 
        /// <para>
        /// For example, if you ask to retrieve 100 items, but each individual item is 300 KB
        /// in size, the system returns 52 items (so as not to exceed the 16 MB limit). It also
        /// returns an appropriate <c>UnprocessedKeys</c> value so you can get the next page of
        /// results. If desired, your application can include its own logic to assemble the pages
        /// of results into one dataset.
        /// </para>
        ///  
        /// <para>
        /// If <i>none</i> of the items can be processed due to insufficient provisioned throughput
        /// on all of the tables in the request, then <c>BatchGetItem</c> returns a <c>ProvisionedThroughputExceededException</c>.
        /// If <i>at least one</i> of the items is successfully processed, then <c>BatchGetItem</c>
        /// completes successfully, while returning the keys of the unread items in <c>UnprocessedKeys</c>.
        /// </para>
        ///  <important> 
        /// <para>
        /// If DynamoDB returns any unprocessed items, you should retry the batch operation on
        /// those items. However, <i>we strongly recommend that you use an exponential backoff
        /// algorithm</i>. If you retry the batch operation immediately, the underlying read or
        /// write requests can still fail due to throttling on the individual tables. If you delay
        /// the batch operation using exponential backoff, the individual requests in the batch
        /// are much more likely to succeed.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/ErrorHandling.html#BatchOperations">Batch
        /// Operations and Error Handling</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        ///  </important> 
        /// <para>
        /// By default, <c>BatchGetItem</c> performs eventually consistent reads on every table
        /// in the request. If you want strongly consistent reads instead, you can set <c>ConsistentRead</c>
        /// to <c>true</c> for any or all tables.
        /// </para>
        ///  
        /// <para>
        /// In order to minimize response latency, <c>BatchGetItem</c> may retrieve items in parallel.
        /// </para>
        ///  
        /// <para>
        /// When designing your application, keep in mind that DynamoDB does not return items
        /// in any particular order. To help parse the response by item, include the primary key
        /// values for the items in your request in the <c>ProjectionExpression</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// If a requested item does not exist, it is not returned in the result. Requests for
        /// nonexistent items consume the minimum read capacity units according to the type of
        /// read. For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/WorkingWithTables.html#CapacityUnitCalculations">Working
        /// with Tables</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>BatchGetItem</c> will result in a <c>ValidationException</c> if the same key is
        /// specified multiple times.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="requestItems">A map of one or more table names or table ARNs and, for each table, a map that describes one or more items to retrieve from that table. Each table name or ARN can be used only once per <c>BatchGetItem</c> request. Each element in the map of items to retrieve consists of the following: <ul> <li>  <c>ConsistentRead</c> - If <c>true</c>, a strongly consistent read is used; if <c>false</c> (the default), an eventually consistent read is used. </li> <li>  <c>ExpressionAttributeNames</c> - One or more substitution tokens for attribute names in the <c>ProjectionExpression</c> parameter. The following are some use cases for using <c>ExpressionAttributeNames</c>: <ul> <li> To access an attribute whose name conflicts with a DynamoDB reserved word. </li> <li> To create a placeholder for repeating occurrences of an attribute name in an expression. </li> <li> To prevent special characters in an attribute name from being misinterpreted in an expression. </li> </ul> Use the <b>#</b> character in an expression to dereference an attribute name. For example, consider the following attribute name: <ul> <li>  <c>Percentile</c>  </li> </ul> The name of this attribute conflicts with a reserved word, so it cannot be used directly in an expression. (For the complete list of reserved words, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/ReservedWords.html">Reserved Words</a> in the <i>Amazon DynamoDB Developer Guide</i>). To work around this, you could specify the following for <c>ExpressionAttributeNames</c>: <ul> <li>  <c>{"#P":"Percentile"}</c>  </li> </ul> You could then use this substitution in an expression, as in this example: <ul> <li>  <c>#P = :val</c>  </li> </ul> <note> Tokens that begin with the <b>:</b> character are <i>expression attribute values</i>, which are placeholders for the actual value at runtime. </note> For more information about expression attribute names, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Expressions.AccessingItemAttributes.html">Accessing Item Attributes</a> in the <i>Amazon DynamoDB Developer Guide</i>. </li> <li>  <c>Keys</c> - An array of primary key attribute values that define specific items in the table. For each primary key, you must provide <i>all</i> of the key attributes. For example, with a simple primary key, you only need to provide the partition key value. For a composite key, you must provide <i>both</i> the partition key value and the sort key value. </li> <li>  <c>ProjectionExpression</c> - A string that identifies one or more attributes to retrieve from the table. These attributes can include scalars, sets, or elements of a JSON document. The attributes in the expression must be separated by commas. If no attribute names are specified, then all attributes are returned. If any of the requested attributes are not found, they do not appear in the result. For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Expressions.AccessingItemAttributes.html">Accessing Item Attributes</a> in the <i>Amazon DynamoDB Developer Guide</i>. </li> <li>  <c>AttributesToGet</c> - This is a legacy parameter. Use <c>ProjectionExpression</c> instead. For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/LegacyConditionalParameters.AttributesToGet.html">AttributesToGet</a> in the <i>Amazon DynamoDB Developer Guide</i>.  </li> </ul></param>
        /// 
        /// <returns>The response from the BatchGetItem service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. The Amazon Web Services SDKs for DynamoDB automatically
        /// retry requests that receive this exception. Your request is eventually successful,
        /// unless your retry queue is too large to finish. Reduce the frequency of requests and
        /// use exponential backoff. For more information, go to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Programming.Errors.html#Programming.Errors.RetryAndBackoff">Error
        /// Retries and Exponential Backoff</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.RequestLimitExceededException">
        /// Throughput exceeds the current throughput quota for your account. For detailed information
        /// about why the request was throttled and the ARN of the impacted resource, find the
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. Contact <a href="https://aws.amazon.com/support">Amazon
        /// Web Services Support</a> to request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ThrottlingException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/BatchGetItem">REST API Reference for BatchGetItem Operation</seealso>
        public virtual BatchGetItemResponse BatchGetItem(Dictionary<string, KeysAndAttributes> requestItems)
        {
            var request = new BatchGetItemRequest();
            request.RequestItems = requestItems;
            return BatchGetItem(request);
        }


        /// <summary>
        /// The <c>BatchGetItem</c> operation returns the attributes of one or more items from
        /// one or more tables. You identify requested items by primary key.
        /// 
        ///  
        /// <para>
        /// A single operation can retrieve up to 16 MB of data, which can contain as many as
        /// 100 items. <c>BatchGetItem</c> returns a partial result if the response size limit
        /// is exceeded, the table's provisioned throughput is exceeded, more than 1MB per partition
        /// is requested, or an internal processing failure occurs. If a partial result is returned,
        /// the operation returns a value for <c>UnprocessedKeys</c>. You can use this value to
        /// retry the operation starting with the next item to get.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you request more than 100 items, <c>BatchGetItem</c> returns a <c>ValidationException</c>
        /// with the message "Too many items requested for the BatchGetItem call."
        /// </para>
        ///  </important> 
        /// <para>
        /// For example, if you ask to retrieve 100 items, but each individual item is 300 KB
        /// in size, the system returns 52 items (so as not to exceed the 16 MB limit). It also
        /// returns an appropriate <c>UnprocessedKeys</c> value so you can get the next page of
        /// results. If desired, your application can include its own logic to assemble the pages
        /// of results into one dataset.
        /// </para>
        ///  
        /// <para>
        /// If <i>none</i> of the items can be processed due to insufficient provisioned throughput
        /// on all of the tables in the request, then <c>BatchGetItem</c> returns a <c>ProvisionedThroughputExceededException</c>.
        /// If <i>at least one</i> of the items is successfully processed, then <c>BatchGetItem</c>
        /// completes successfully, while returning the keys of the unread items in <c>UnprocessedKeys</c>.
        /// </para>
        ///  <important> 
        /// <para>
        /// If DynamoDB returns any unprocessed items, you should retry the batch operation on
        /// those items. However, <i>we strongly recommend that you use an exponential backoff
        /// algorithm</i>. If you retry the batch operation immediately, the underlying read or
        /// write requests can still fail due to throttling on the individual tables. If you delay
        /// the batch operation using exponential backoff, the individual requests in the batch
        /// are much more likely to succeed.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/ErrorHandling.html#BatchOperations">Batch
        /// Operations and Error Handling</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        ///  </important> 
        /// <para>
        /// By default, <c>BatchGetItem</c> performs eventually consistent reads on every table
        /// in the request. If you want strongly consistent reads instead, you can set <c>ConsistentRead</c>
        /// to <c>true</c> for any or all tables.
        /// </para>
        ///  
        /// <para>
        /// In order to minimize response latency, <c>BatchGetItem</c> may retrieve items in parallel.
        /// </para>
        ///  
        /// <para>
        /// When designing your application, keep in mind that DynamoDB does not return items
        /// in any particular order. To help parse the response by item, include the primary key
        /// values for the items in your request in the <c>ProjectionExpression</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// If a requested item does not exist, it is not returned in the result. Requests for
        /// nonexistent items consume the minimum read capacity units according to the type of
        /// read. For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/WorkingWithTables.html#CapacityUnitCalculations">Working
        /// with Tables</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>BatchGetItem</c> will result in a <c>ValidationException</c> if the same key is
        /// specified multiple times.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetItem service method.</param>
        /// 
        /// <returns>The response from the BatchGetItem service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. The Amazon Web Services SDKs for DynamoDB automatically
        /// retry requests that receive this exception. Your request is eventually successful,
        /// unless your retry queue is too large to finish. Reduce the frequency of requests and
        /// use exponential backoff. For more information, go to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Programming.Errors.html#Programming.Errors.RetryAndBackoff">Error
        /// Retries and Exponential Backoff</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.RequestLimitExceededException">
        /// Throughput exceeds the current throughput quota for your account. For detailed information
        /// about why the request was throttled and the ARN of the impacted resource, find the
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. Contact <a href="https://aws.amazon.com/support">Amazon
        /// Web Services Support</a> to request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ThrottlingException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/BatchGetItem">REST API Reference for BatchGetItem Operation</seealso>
        public virtual BatchGetItemResponse BatchGetItem(BatchGetItemRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetItemResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = BatchGetItemEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<BatchGetItemResponse>(request, options);
        }


        /// <summary>
        /// The <c>BatchGetItem</c> operation returns the attributes of one or more items from
        /// one or more tables. You identify requested items by primary key.
        /// 
        ///  
        /// <para>
        /// A single operation can retrieve up to 16 MB of data, which can contain as many as
        /// 100 items. <c>BatchGetItem</c> returns a partial result if the response size limit
        /// is exceeded, the table's provisioned throughput is exceeded, more than 1MB per partition
        /// is requested, or an internal processing failure occurs. If a partial result is returned,
        /// the operation returns a value for <c>UnprocessedKeys</c>. You can use this value to
        /// retry the operation starting with the next item to get.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you request more than 100 items, <c>BatchGetItem</c> returns a <c>ValidationException</c>
        /// with the message "Too many items requested for the BatchGetItem call."
        /// </para>
        ///  </important> 
        /// <para>
        /// For example, if you ask to retrieve 100 items, but each individual item is 300 KB
        /// in size, the system returns 52 items (so as not to exceed the 16 MB limit). It also
        /// returns an appropriate <c>UnprocessedKeys</c> value so you can get the next page of
        /// results. If desired, your application can include its own logic to assemble the pages
        /// of results into one dataset.
        /// </para>
        ///  
        /// <para>
        /// If <i>none</i> of the items can be processed due to insufficient provisioned throughput
        /// on all of the tables in the request, then <c>BatchGetItem</c> returns a <c>ProvisionedThroughputExceededException</c>.
        /// If <i>at least one</i> of the items is successfully processed, then <c>BatchGetItem</c>
        /// completes successfully, while returning the keys of the unread items in <c>UnprocessedKeys</c>.
        /// </para>
        ///  <important> 
        /// <para>
        /// If DynamoDB returns any unprocessed items, you should retry the batch operation on
        /// those items. However, <i>we strongly recommend that you use an exponential backoff
        /// algorithm</i>. If you retry the batch operation immediately, the underlying read or
        /// write requests can still fail due to throttling on the individual tables. If you delay
        /// the batch operation using exponential backoff, the individual requests in the batch
        /// are much more likely to succeed.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/ErrorHandling.html#BatchOperations">Batch
        /// Operations and Error Handling</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        ///  </important> 
        /// <para>
        /// By default, <c>BatchGetItem</c> performs eventually consistent reads on every table
        /// in the request. If you want strongly consistent reads instead, you can set <c>ConsistentRead</c>
        /// to <c>true</c> for any or all tables.
        /// </para>
        ///  
        /// <para>
        /// In order to minimize response latency, <c>BatchGetItem</c> may retrieve items in parallel.
        /// </para>
        ///  
        /// <para>
        /// When designing your application, keep in mind that DynamoDB does not return items
        /// in any particular order. To help parse the response by item, include the primary key
        /// values for the items in your request in the <c>ProjectionExpression</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// If a requested item does not exist, it is not returned in the result. Requests for
        /// nonexistent items consume the minimum read capacity units according to the type of
        /// read. For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/WorkingWithTables.html#CapacityUnitCalculations">Working
        /// with Tables</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>BatchGetItem</c> will result in a <c>ValidationException</c> if the same key is
        /// specified multiple times.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="requestItems">A map of one or more table names or table ARNs and, for each table, a map that describes one or more items to retrieve from that table. Each table name or ARN can be used only once per <c>BatchGetItem</c> request. Each element in the map of items to retrieve consists of the following: <ul> <li>  <c>ConsistentRead</c> - If <c>true</c>, a strongly consistent read is used; if <c>false</c> (the default), an eventually consistent read is used. </li> <li>  <c>ExpressionAttributeNames</c> - One or more substitution tokens for attribute names in the <c>ProjectionExpression</c> parameter. The following are some use cases for using <c>ExpressionAttributeNames</c>: <ul> <li> To access an attribute whose name conflicts with a DynamoDB reserved word. </li> <li> To create a placeholder for repeating occurrences of an attribute name in an expression. </li> <li> To prevent special characters in an attribute name from being misinterpreted in an expression. </li> </ul> Use the <b>#</b> character in an expression to dereference an attribute name. For example, consider the following attribute name: <ul> <li>  <c>Percentile</c>  </li> </ul> The name of this attribute conflicts with a reserved word, so it cannot be used directly in an expression. (For the complete list of reserved words, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/ReservedWords.html">Reserved Words</a> in the <i>Amazon DynamoDB Developer Guide</i>). To work around this, you could specify the following for <c>ExpressionAttributeNames</c>: <ul> <li>  <c>{"#P":"Percentile"}</c>  </li> </ul> You could then use this substitution in an expression, as in this example: <ul> <li>  <c>#P = :val</c>  </li> </ul> <note> Tokens that begin with the <b>:</b> character are <i>expression attribute values</i>, which are placeholders for the actual value at runtime. </note> For more information about expression attribute names, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Expressions.AccessingItemAttributes.html">Accessing Item Attributes</a> in the <i>Amazon DynamoDB Developer Guide</i>. </li> <li>  <c>Keys</c> - An array of primary key attribute values that define specific items in the table. For each primary key, you must provide <i>all</i> of the key attributes. For example, with a simple primary key, you only need to provide the partition key value. For a composite key, you must provide <i>both</i> the partition key value and the sort key value. </li> <li>  <c>ProjectionExpression</c> - A string that identifies one or more attributes to retrieve from the table. These attributes can include scalars, sets, or elements of a JSON document. The attributes in the expression must be separated by commas. If no attribute names are specified, then all attributes are returned. If any of the requested attributes are not found, they do not appear in the result. For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Expressions.AccessingItemAttributes.html">Accessing Item Attributes</a> in the <i>Amazon DynamoDB Developer Guide</i>. </li> <li>  <c>AttributesToGet</c> - This is a legacy parameter. Use <c>ProjectionExpression</c> instead. For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/LegacyConditionalParameters.AttributesToGet.html">AttributesToGet</a> in the <i>Amazon DynamoDB Developer Guide</i>.  </li> </ul></param>
        /// <param name="returnConsumedCapacity">A property of BatchGetItemRequest used to execute the BatchGetItem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetItem service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. The Amazon Web Services SDKs for DynamoDB automatically
        /// retry requests that receive this exception. Your request is eventually successful,
        /// unless your retry queue is too large to finish. Reduce the frequency of requests and
        /// use exponential backoff. For more information, go to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Programming.Errors.html#Programming.Errors.RetryAndBackoff">Error
        /// Retries and Exponential Backoff</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.RequestLimitExceededException">
        /// Throughput exceeds the current throughput quota for your account. For detailed information
        /// about why the request was throttled and the ARN of the impacted resource, find the
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. Contact <a href="https://aws.amazon.com/support">Amazon
        /// Web Services Support</a> to request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ThrottlingException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/BatchGetItem">REST API Reference for BatchGetItem Operation</seealso>
        public virtual Task<BatchGetItemResponse> BatchGetItemAsync(Dictionary<string, KeysAndAttributes> requestItems, ReturnConsumedCapacity returnConsumedCapacity, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new BatchGetItemRequest();
            request.RequestItems = requestItems;
            request.ReturnConsumedCapacity = returnConsumedCapacity;
            return BatchGetItemAsync(request, cancellationToken);
        }


        /// <summary>
        /// The <c>BatchGetItem</c> operation returns the attributes of one or more items from
        /// one or more tables. You identify requested items by primary key.
        /// 
        ///  
        /// <para>
        /// A single operation can retrieve up to 16 MB of data, which can contain as many as
        /// 100 items. <c>BatchGetItem</c> returns a partial result if the response size limit
        /// is exceeded, the table's provisioned throughput is exceeded, more than 1MB per partition
        /// is requested, or an internal processing failure occurs. If a partial result is returned,
        /// the operation returns a value for <c>UnprocessedKeys</c>. You can use this value to
        /// retry the operation starting with the next item to get.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you request more than 100 items, <c>BatchGetItem</c> returns a <c>ValidationException</c>
        /// with the message "Too many items requested for the BatchGetItem call."
        /// </para>
        ///  </important> 
        /// <para>
        /// For example, if you ask to retrieve 100 items, but each individual item is 300 KB
        /// in size, the system returns 52 items (so as not to exceed the 16 MB limit). It also
        /// returns an appropriate <c>UnprocessedKeys</c> value so you can get the next page of
        /// results. If desired, your application can include its own logic to assemble the pages
        /// of results into one dataset.
        /// </para>
        ///  
        /// <para>
        /// If <i>none</i> of the items can be processed due to insufficient provisioned throughput
        /// on all of the tables in the request, then <c>BatchGetItem</c> returns a <c>ProvisionedThroughputExceededException</c>.
        /// If <i>at least one</i> of the items is successfully processed, then <c>BatchGetItem</c>
        /// completes successfully, while returning the keys of the unread items in <c>UnprocessedKeys</c>.
        /// </para>
        ///  <important> 
        /// <para>
        /// If DynamoDB returns any unprocessed items, you should retry the batch operation on
        /// those items. However, <i>we strongly recommend that you use an exponential backoff
        /// algorithm</i>. If you retry the batch operation immediately, the underlying read or
        /// write requests can still fail due to throttling on the individual tables. If you delay
        /// the batch operation using exponential backoff, the individual requests in the batch
        /// are much more likely to succeed.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/ErrorHandling.html#BatchOperations">Batch
        /// Operations and Error Handling</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        ///  </important> 
        /// <para>
        /// By default, <c>BatchGetItem</c> performs eventually consistent reads on every table
        /// in the request. If you want strongly consistent reads instead, you can set <c>ConsistentRead</c>
        /// to <c>true</c> for any or all tables.
        /// </para>
        ///  
        /// <para>
        /// In order to minimize response latency, <c>BatchGetItem</c> may retrieve items in parallel.
        /// </para>
        ///  
        /// <para>
        /// When designing your application, keep in mind that DynamoDB does not return items
        /// in any particular order. To help parse the response by item, include the primary key
        /// values for the items in your request in the <c>ProjectionExpression</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// If a requested item does not exist, it is not returned in the result. Requests for
        /// nonexistent items consume the minimum read capacity units according to the type of
        /// read. For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/WorkingWithTables.html#CapacityUnitCalculations">Working
        /// with Tables</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>BatchGetItem</c> will result in a <c>ValidationException</c> if the same key is
        /// specified multiple times.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="requestItems">A map of one or more table names or table ARNs and, for each table, a map that describes one or more items to retrieve from that table. Each table name or ARN can be used only once per <c>BatchGetItem</c> request. Each element in the map of items to retrieve consists of the following: <ul> <li>  <c>ConsistentRead</c> - If <c>true</c>, a strongly consistent read is used; if <c>false</c> (the default), an eventually consistent read is used. </li> <li>  <c>ExpressionAttributeNames</c> - One or more substitution tokens for attribute names in the <c>ProjectionExpression</c> parameter. The following are some use cases for using <c>ExpressionAttributeNames</c>: <ul> <li> To access an attribute whose name conflicts with a DynamoDB reserved word. </li> <li> To create a placeholder for repeating occurrences of an attribute name in an expression. </li> <li> To prevent special characters in an attribute name from being misinterpreted in an expression. </li> </ul> Use the <b>#</b> character in an expression to dereference an attribute name. For example, consider the following attribute name: <ul> <li>  <c>Percentile</c>  </li> </ul> The name of this attribute conflicts with a reserved word, so it cannot be used directly in an expression. (For the complete list of reserved words, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/ReservedWords.html">Reserved Words</a> in the <i>Amazon DynamoDB Developer Guide</i>). To work around this, you could specify the following for <c>ExpressionAttributeNames</c>: <ul> <li>  <c>{"#P":"Percentile"}</c>  </li> </ul> You could then use this substitution in an expression, as in this example: <ul> <li>  <c>#P = :val</c>  </li> </ul> <note> Tokens that begin with the <b>:</b> character are <i>expression attribute values</i>, which are placeholders for the actual value at runtime. </note> For more information about expression attribute names, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Expressions.AccessingItemAttributes.html">Accessing Item Attributes</a> in the <i>Amazon DynamoDB Developer Guide</i>. </li> <li>  <c>Keys</c> - An array of primary key attribute values that define specific items in the table. For each primary key, you must provide <i>all</i> of the key attributes. For example, with a simple primary key, you only need to provide the partition key value. For a composite key, you must provide <i>both</i> the partition key value and the sort key value. </li> <li>  <c>ProjectionExpression</c> - A string that identifies one or more attributes to retrieve from the table. These attributes can include scalars, sets, or elements of a JSON document. The attributes in the expression must be separated by commas. If no attribute names are specified, then all attributes are returned. If any of the requested attributes are not found, they do not appear in the result. For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Expressions.AccessingItemAttributes.html">Accessing Item Attributes</a> in the <i>Amazon DynamoDB Developer Guide</i>. </li> <li>  <c>AttributesToGet</c> - This is a legacy parameter. Use <c>ProjectionExpression</c> instead. For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/LegacyConditionalParameters.AttributesToGet.html">AttributesToGet</a> in the <i>Amazon DynamoDB Developer Guide</i>.  </li> </ul></param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetItem service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. The Amazon Web Services SDKs for DynamoDB automatically
        /// retry requests that receive this exception. Your request is eventually successful,
        /// unless your retry queue is too large to finish. Reduce the frequency of requests and
        /// use exponential backoff. For more information, go to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Programming.Errors.html#Programming.Errors.RetryAndBackoff">Error
        /// Retries and Exponential Backoff</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.RequestLimitExceededException">
        /// Throughput exceeds the current throughput quota for your account. For detailed information
        /// about why the request was throttled and the ARN of the impacted resource, find the
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. Contact <a href="https://aws.amazon.com/support">Amazon
        /// Web Services Support</a> to request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ThrottlingException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/BatchGetItem">REST API Reference for BatchGetItem Operation</seealso>
        public virtual Task<BatchGetItemResponse> BatchGetItemAsync(Dictionary<string, KeysAndAttributes> requestItems, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new BatchGetItemRequest();
            request.RequestItems = requestItems;
            return BatchGetItemAsync(request, cancellationToken);
        }


        /// <summary>
        /// The <c>BatchGetItem</c> operation returns the attributes of one or more items from
        /// one or more tables. You identify requested items by primary key.
        /// 
        ///  
        /// <para>
        /// A single operation can retrieve up to 16 MB of data, which can contain as many as
        /// 100 items. <c>BatchGetItem</c> returns a partial result if the response size limit
        /// is exceeded, the table's provisioned throughput is exceeded, more than 1MB per partition
        /// is requested, or an internal processing failure occurs. If a partial result is returned,
        /// the operation returns a value for <c>UnprocessedKeys</c>. You can use this value to
        /// retry the operation starting with the next item to get.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you request more than 100 items, <c>BatchGetItem</c> returns a <c>ValidationException</c>
        /// with the message "Too many items requested for the BatchGetItem call."
        /// </para>
        ///  </important> 
        /// <para>
        /// For example, if you ask to retrieve 100 items, but each individual item is 300 KB
        /// in size, the system returns 52 items (so as not to exceed the 16 MB limit). It also
        /// returns an appropriate <c>UnprocessedKeys</c> value so you can get the next page of
        /// results. If desired, your application can include its own logic to assemble the pages
        /// of results into one dataset.
        /// </para>
        ///  
        /// <para>
        /// If <i>none</i> of the items can be processed due to insufficient provisioned throughput
        /// on all of the tables in the request, then <c>BatchGetItem</c> returns a <c>ProvisionedThroughputExceededException</c>.
        /// If <i>at least one</i> of the items is successfully processed, then <c>BatchGetItem</c>
        /// completes successfully, while returning the keys of the unread items in <c>UnprocessedKeys</c>.
        /// </para>
        ///  <important> 
        /// <para>
        /// If DynamoDB returns any unprocessed items, you should retry the batch operation on
        /// those items. However, <i>we strongly recommend that you use an exponential backoff
        /// algorithm</i>. If you retry the batch operation immediately, the underlying read or
        /// write requests can still fail due to throttling on the individual tables. If you delay
        /// the batch operation using exponential backoff, the individual requests in the batch
        /// are much more likely to succeed.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/ErrorHandling.html#BatchOperations">Batch
        /// Operations and Error Handling</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        ///  </important> 
        /// <para>
        /// By default, <c>BatchGetItem</c> performs eventually consistent reads on every table
        /// in the request. If you want strongly consistent reads instead, you can set <c>ConsistentRead</c>
        /// to <c>true</c> for any or all tables.
        /// </para>
        ///  
        /// <para>
        /// In order to minimize response latency, <c>BatchGetItem</c> may retrieve items in parallel.
        /// </para>
        ///  
        /// <para>
        /// When designing your application, keep in mind that DynamoDB does not return items
        /// in any particular order. To help parse the response by item, include the primary key
        /// values for the items in your request in the <c>ProjectionExpression</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// If a requested item does not exist, it is not returned in the result. Requests for
        /// nonexistent items consume the minimum read capacity units according to the type of
        /// read. For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/WorkingWithTables.html#CapacityUnitCalculations">Working
        /// with Tables</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>BatchGetItem</c> will result in a <c>ValidationException</c> if the same key is
        /// specified multiple times.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetItem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetItem service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. The Amazon Web Services SDKs for DynamoDB automatically
        /// retry requests that receive this exception. Your request is eventually successful,
        /// unless your retry queue is too large to finish. Reduce the frequency of requests and
        /// use exponential backoff. For more information, go to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Programming.Errors.html#Programming.Errors.RetryAndBackoff">Error
        /// Retries and Exponential Backoff</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.RequestLimitExceededException">
        /// Throughput exceeds the current throughput quota for your account. For detailed information
        /// about why the request was throttled and the ARN of the impacted resource, find the
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. Contact <a href="https://aws.amazon.com/support">Amazon
        /// Web Services Support</a> to request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ThrottlingException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/BatchGetItem">REST API Reference for BatchGetItem Operation</seealso>
        public virtual Task<BatchGetItemResponse> BatchGetItemAsync(BatchGetItemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchGetItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetItemResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = BatchGetItemEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;
            
            return InvokeAsync<BatchGetItemResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BatchWriteItem


        /// <summary>
        /// The <c>BatchWriteItem</c> operation puts or deletes multiple items in one or more
        /// tables. A single call to <c>BatchWriteItem</c> can transmit up to 16MB of data over
        /// the network, consisting of up to 25 item put or delete operations. While individual
        /// items can be up to 400 KB once stored, it's important to note that an item's representation
        /// might be greater than 400KB while being sent in DynamoDB's JSON format for the API
        /// call. For more details on this distinction, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/HowItWorks.NamingRulesDataTypes.html">Naming
        /// Rules and Data Types</a>.
        /// 
        ///  <note> 
        /// <para>
        ///  <c>BatchWriteItem</c> cannot update items. If you perform a <c>BatchWriteItem</c>
        /// operation on an existing item, that item's values will be overwritten by the operation
        /// and it will appear like it was updated. To update items, we recommend you use the
        /// <c>UpdateItem</c> action.
        /// </para>
        ///  </note> 
        /// <para>
        /// The individual <c>PutItem</c> and <c>DeleteItem</c> operations specified in <c>BatchWriteItem</c>
        /// are atomic; however <c>BatchWriteItem</c> as a whole is not. If any requested operations
        /// fail because the table's provisioned throughput is exceeded or an internal processing
        /// failure occurs, the failed operations are returned in the <c>UnprocessedItems</c>
        /// response parameter. You can investigate and optionally resend the requests. Typically,
        /// you would call <c>BatchWriteItem</c> in a loop. Each iteration would check for unprocessed
        /// items and submit a new <c>BatchWriteItem</c> request with those unprocessed items
        /// until all items have been processed.
        /// </para>
        ///  
        /// <para>
        /// For tables and indexes with provisioned capacity, if none of the items can be processed
        /// due to insufficient provisioned throughput on all of the tables in the request, then
        /// <c>BatchWriteItem</c> returns a <c>ProvisionedThroughputExceededException</c>. For
        /// all tables and indexes, if none of the items can be processed due to other throttling
        /// scenarios (such as exceeding partition level limits), then <c>BatchWriteItem</c> returns
        /// a <c>ThrottlingException</c>.
        /// </para>
        ///  <important> 
        /// <para>
        /// If DynamoDB returns any unprocessed items, you should retry the batch operation on
        /// those items. However, <i>we strongly recommend that you use an exponential backoff
        /// algorithm</i>. If you retry the batch operation immediately, the underlying read or
        /// write requests can still fail due to throttling on the individual tables. If you delay
        /// the batch operation using exponential backoff, the individual requests in the batch
        /// are much more likely to succeed.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/ErrorHandling.html#Programming.Errors.BatchOperations">Batch
        /// Operations and Error Handling</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        ///  </important> 
        /// <para>
        /// With <c>BatchWriteItem</c>, you can efficiently write or delete large amounts of data,
        /// such as from Amazon EMR, or copy data from another database into DynamoDB. In order
        /// to improve performance with these large-scale operations, <c>BatchWriteItem</c> does
        /// not behave in the same way as individual <c>PutItem</c> and <c>DeleteItem</c> calls
        /// would. For example, you cannot specify conditions on individual put and delete requests,
        /// and <c>BatchWriteItem</c> does not return deleted items in the response.
        /// </para>
        ///  
        /// <para>
        /// If you use a programming language that supports concurrency, you can use threads to
        /// write items in parallel. Your application must include the necessary logic to manage
        /// the threads. With languages that don't support threading, you must update or delete
        /// the specified items one at a time. In both situations, <c>BatchWriteItem</c> performs
        /// the specified put and delete operations in parallel, giving you the power of the thread
        /// pool approach without having to introduce complexity into your application.
        /// </para>
        ///  
        /// <para>
        /// Parallel processing reduces latency, but each specified put and delete request consumes
        /// the same number of write capacity units whether it is processed in parallel or not.
        /// Delete operations on nonexistent items consume one write capacity unit.
        /// </para>
        ///  
        /// <para>
        /// If one or more of the following is true, DynamoDB rejects the entire batch write operation:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// One or more tables specified in the <c>BatchWriteItem</c> request does not exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Primary key attributes specified on an item in the request do not match those in the
        /// corresponding table's primary key schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You try to perform multiple operations on the same item in the same <c>BatchWriteItem</c>
        /// request. For example, you cannot put and delete the same item in the same <c>BatchWriteItem</c>
        /// request. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Your request contains at least two items with identical hash and range keys (which
        /// essentially is two put operations). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There are more than 25 requests in the batch.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Any individual item in a batch exceeds 400 KB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The total request size exceeds 16 MB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Any individual items with keys exceeding the key length limits. For a partition key,
        /// the limit is 2048 bytes and for a sort key, the limit is 1024 bytes.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="requestItems">A map of one or more table names or table ARNs and, for each table, a list of operations to be performed (<c>DeleteRequest</c> or <c>PutRequest</c>). Each element in the map consists of the following: <ul> <li>  <c>DeleteRequest</c> - Perform a <c>DeleteItem</c> operation on the specified item. The item to be deleted is identified by a <c>Key</c> subelement: <ul> <li>  <c>Key</c> - A map of primary key attribute values that uniquely identify the item. Each entry in this map consists of an attribute name and an attribute value. For each primary key, you must provide <i>all</i> of the key attributes. For example, with a simple primary key, you only need to provide a value for the partition key. For a composite primary key, you must provide values for <i>both</i> the partition key and the sort key. </li> </ul> </li> <li>  <c>PutRequest</c> - Perform a <c>PutItem</c> operation on the specified item. The item to be put is identified by an <c>Item</c> subelement: <ul> <li>  <c>Item</c> - A map of attributes and their values. Each entry in this map consists of an attribute name and an attribute value. Attribute values must not be null; string and binary type attributes must have lengths greater than zero; and set type attributes must not be empty. Requests that contain empty values are rejected with a <c>ValidationException</c> exception. If you specify any attributes that are part of an index key, then the data types for those attributes must match those of the schema in the table's attribute definition. </li> </ul> </li> </ul></param>
        /// 
        /// <returns>The response from the BatchWriteItem service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ItemCollectionSizeLimitExceededException">
        /// An item collection is too large. This exception is only returned for tables that have
        /// one or more local secondary indexes.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. The Amazon Web Services SDKs for DynamoDB automatically
        /// retry requests that receive this exception. Your request is eventually successful,
        /// unless your retry queue is too large to finish. Reduce the frequency of requests and
        /// use exponential backoff. For more information, go to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Programming.Errors.html#Programming.Errors.RetryAndBackoff">Error
        /// Retries and Exponential Backoff</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ReplicatedWriteConflictException">
        /// The request was rejected because one or more items in the request are being modified
        /// by a request in another Region.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.RequestLimitExceededException">
        /// Throughput exceeds the current throughput quota for your account. For detailed information
        /// about why the request was throttled and the ARN of the impacted resource, find the
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. Contact <a href="https://aws.amazon.com/support">Amazon
        /// Web Services Support</a> to request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ThrottlingException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/BatchWriteItem">REST API Reference for BatchWriteItem Operation</seealso>
        public virtual BatchWriteItemResponse BatchWriteItem(Dictionary<string, List<WriteRequest>> requestItems)
        {
            var request = new BatchWriteItemRequest();
            request.RequestItems = requestItems;
            return BatchWriteItem(request);
        }


        /// <summary>
        /// The <c>BatchWriteItem</c> operation puts or deletes multiple items in one or more
        /// tables. A single call to <c>BatchWriteItem</c> can transmit up to 16MB of data over
        /// the network, consisting of up to 25 item put or delete operations. While individual
        /// items can be up to 400 KB once stored, it's important to note that an item's representation
        /// might be greater than 400KB while being sent in DynamoDB's JSON format for the API
        /// call. For more details on this distinction, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/HowItWorks.NamingRulesDataTypes.html">Naming
        /// Rules and Data Types</a>.
        /// 
        ///  <note> 
        /// <para>
        ///  <c>BatchWriteItem</c> cannot update items. If you perform a <c>BatchWriteItem</c>
        /// operation on an existing item, that item's values will be overwritten by the operation
        /// and it will appear like it was updated. To update items, we recommend you use the
        /// <c>UpdateItem</c> action.
        /// </para>
        ///  </note> 
        /// <para>
        /// The individual <c>PutItem</c> and <c>DeleteItem</c> operations specified in <c>BatchWriteItem</c>
        /// are atomic; however <c>BatchWriteItem</c> as a whole is not. If any requested operations
        /// fail because the table's provisioned throughput is exceeded or an internal processing
        /// failure occurs, the failed operations are returned in the <c>UnprocessedItems</c>
        /// response parameter. You can investigate and optionally resend the requests. Typically,
        /// you would call <c>BatchWriteItem</c> in a loop. Each iteration would check for unprocessed
        /// items and submit a new <c>BatchWriteItem</c> request with those unprocessed items
        /// until all items have been processed.
        /// </para>
        ///  
        /// <para>
        /// For tables and indexes with provisioned capacity, if none of the items can be processed
        /// due to insufficient provisioned throughput on all of the tables in the request, then
        /// <c>BatchWriteItem</c> returns a <c>ProvisionedThroughputExceededException</c>. For
        /// all tables and indexes, if none of the items can be processed due to other throttling
        /// scenarios (such as exceeding partition level limits), then <c>BatchWriteItem</c> returns
        /// a <c>ThrottlingException</c>.
        /// </para>
        ///  <important> 
        /// <para>
        /// If DynamoDB returns any unprocessed items, you should retry the batch operation on
        /// those items. However, <i>we strongly recommend that you use an exponential backoff
        /// algorithm</i>. If you retry the batch operation immediately, the underlying read or
        /// write requests can still fail due to throttling on the individual tables. If you delay
        /// the batch operation using exponential backoff, the individual requests in the batch
        /// are much more likely to succeed.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/ErrorHandling.html#Programming.Errors.BatchOperations">Batch
        /// Operations and Error Handling</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        ///  </important> 
        /// <para>
        /// With <c>BatchWriteItem</c>, you can efficiently write or delete large amounts of data,
        /// such as from Amazon EMR, or copy data from another database into DynamoDB. In order
        /// to improve performance with these large-scale operations, <c>BatchWriteItem</c> does
        /// not behave in the same way as individual <c>PutItem</c> and <c>DeleteItem</c> calls
        /// would. For example, you cannot specify conditions on individual put and delete requests,
        /// and <c>BatchWriteItem</c> does not return deleted items in the response.
        /// </para>
        ///  
        /// <para>
        /// If you use a programming language that supports concurrency, you can use threads to
        /// write items in parallel. Your application must include the necessary logic to manage
        /// the threads. With languages that don't support threading, you must update or delete
        /// the specified items one at a time. In both situations, <c>BatchWriteItem</c> performs
        /// the specified put and delete operations in parallel, giving you the power of the thread
        /// pool approach without having to introduce complexity into your application.
        /// </para>
        ///  
        /// <para>
        /// Parallel processing reduces latency, but each specified put and delete request consumes
        /// the same number of write capacity units whether it is processed in parallel or not.
        /// Delete operations on nonexistent items consume one write capacity unit.
        /// </para>
        ///  
        /// <para>
        /// If one or more of the following is true, DynamoDB rejects the entire batch write operation:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// One or more tables specified in the <c>BatchWriteItem</c> request does not exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Primary key attributes specified on an item in the request do not match those in the
        /// corresponding table's primary key schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You try to perform multiple operations on the same item in the same <c>BatchWriteItem</c>
        /// request. For example, you cannot put and delete the same item in the same <c>BatchWriteItem</c>
        /// request. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Your request contains at least two items with identical hash and range keys (which
        /// essentially is two put operations). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There are more than 25 requests in the batch.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Any individual item in a batch exceeds 400 KB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The total request size exceeds 16 MB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Any individual items with keys exceeding the key length limits. For a partition key,
        /// the limit is 2048 bytes and for a sort key, the limit is 1024 bytes.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchWriteItem service method.</param>
        /// 
        /// <returns>The response from the BatchWriteItem service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ItemCollectionSizeLimitExceededException">
        /// An item collection is too large. This exception is only returned for tables that have
        /// one or more local secondary indexes.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. The Amazon Web Services SDKs for DynamoDB automatically
        /// retry requests that receive this exception. Your request is eventually successful,
        /// unless your retry queue is too large to finish. Reduce the frequency of requests and
        /// use exponential backoff. For more information, go to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Programming.Errors.html#Programming.Errors.RetryAndBackoff">Error
        /// Retries and Exponential Backoff</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ReplicatedWriteConflictException">
        /// The request was rejected because one or more items in the request are being modified
        /// by a request in another Region.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.RequestLimitExceededException">
        /// Throughput exceeds the current throughput quota for your account. For detailed information
        /// about why the request was throttled and the ARN of the impacted resource, find the
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. Contact <a href="https://aws.amazon.com/support">Amazon
        /// Web Services Support</a> to request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ThrottlingException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/BatchWriteItem">REST API Reference for BatchWriteItem Operation</seealso>
        public virtual BatchWriteItemResponse BatchWriteItem(BatchWriteItemRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchWriteItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchWriteItemResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = BatchWriteItemEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<BatchWriteItemResponse>(request, options);
        }


        /// <summary>
        /// The <c>BatchWriteItem</c> operation puts or deletes multiple items in one or more
        /// tables. A single call to <c>BatchWriteItem</c> can transmit up to 16MB of data over
        /// the network, consisting of up to 25 item put or delete operations. While individual
        /// items can be up to 400 KB once stored, it's important to note that an item's representation
        /// might be greater than 400KB while being sent in DynamoDB's JSON format for the API
        /// call. For more details on this distinction, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/HowItWorks.NamingRulesDataTypes.html">Naming
        /// Rules and Data Types</a>.
        /// 
        ///  <note> 
        /// <para>
        ///  <c>BatchWriteItem</c> cannot update items. If you perform a <c>BatchWriteItem</c>
        /// operation on an existing item, that item's values will be overwritten by the operation
        /// and it will appear like it was updated. To update items, we recommend you use the
        /// <c>UpdateItem</c> action.
        /// </para>
        ///  </note> 
        /// <para>
        /// The individual <c>PutItem</c> and <c>DeleteItem</c> operations specified in <c>BatchWriteItem</c>
        /// are atomic; however <c>BatchWriteItem</c> as a whole is not. If any requested operations
        /// fail because the table's provisioned throughput is exceeded or an internal processing
        /// failure occurs, the failed operations are returned in the <c>UnprocessedItems</c>
        /// response parameter. You can investigate and optionally resend the requests. Typically,
        /// you would call <c>BatchWriteItem</c> in a loop. Each iteration would check for unprocessed
        /// items and submit a new <c>BatchWriteItem</c> request with those unprocessed items
        /// until all items have been processed.
        /// </para>
        ///  
        /// <para>
        /// For tables and indexes with provisioned capacity, if none of the items can be processed
        /// due to insufficient provisioned throughput on all of the tables in the request, then
        /// <c>BatchWriteItem</c> returns a <c>ProvisionedThroughputExceededException</c>. For
        /// all tables and indexes, if none of the items can be processed due to other throttling
        /// scenarios (such as exceeding partition level limits), then <c>BatchWriteItem</c> returns
        /// a <c>ThrottlingException</c>.
        /// </para>
        ///  <important> 
        /// <para>
        /// If DynamoDB returns any unprocessed items, you should retry the batch operation on
        /// those items. However, <i>we strongly recommend that you use an exponential backoff
        /// algorithm</i>. If you retry the batch operation immediately, the underlying read or
        /// write requests can still fail due to throttling on the individual tables. If you delay
        /// the batch operation using exponential backoff, the individual requests in the batch
        /// are much more likely to succeed.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/ErrorHandling.html#Programming.Errors.BatchOperations">Batch
        /// Operations and Error Handling</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        ///  </important> 
        /// <para>
        /// With <c>BatchWriteItem</c>, you can efficiently write or delete large amounts of data,
        /// such as from Amazon EMR, or copy data from another database into DynamoDB. In order
        /// to improve performance with these large-scale operations, <c>BatchWriteItem</c> does
        /// not behave in the same way as individual <c>PutItem</c> and <c>DeleteItem</c> calls
        /// would. For example, you cannot specify conditions on individual put and delete requests,
        /// and <c>BatchWriteItem</c> does not return deleted items in the response.
        /// </para>
        ///  
        /// <para>
        /// If you use a programming language that supports concurrency, you can use threads to
        /// write items in parallel. Your application must include the necessary logic to manage
        /// the threads. With languages that don't support threading, you must update or delete
        /// the specified items one at a time. In both situations, <c>BatchWriteItem</c> performs
        /// the specified put and delete operations in parallel, giving you the power of the thread
        /// pool approach without having to introduce complexity into your application.
        /// </para>
        ///  
        /// <para>
        /// Parallel processing reduces latency, but each specified put and delete request consumes
        /// the same number of write capacity units whether it is processed in parallel or not.
        /// Delete operations on nonexistent items consume one write capacity unit.
        /// </para>
        ///  
        /// <para>
        /// If one or more of the following is true, DynamoDB rejects the entire batch write operation:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// One or more tables specified in the <c>BatchWriteItem</c> request does not exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Primary key attributes specified on an item in the request do not match those in the
        /// corresponding table's primary key schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You try to perform multiple operations on the same item in the same <c>BatchWriteItem</c>
        /// request. For example, you cannot put and delete the same item in the same <c>BatchWriteItem</c>
        /// request. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Your request contains at least two items with identical hash and range keys (which
        /// essentially is two put operations). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There are more than 25 requests in the batch.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Any individual item in a batch exceeds 400 KB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The total request size exceeds 16 MB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Any individual items with keys exceeding the key length limits. For a partition key,
        /// the limit is 2048 bytes and for a sort key, the limit is 1024 bytes.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="requestItems">A map of one or more table names or table ARNs and, for each table, a list of operations to be performed (<c>DeleteRequest</c> or <c>PutRequest</c>). Each element in the map consists of the following: <ul> <li>  <c>DeleteRequest</c> - Perform a <c>DeleteItem</c> operation on the specified item. The item to be deleted is identified by a <c>Key</c> subelement: <ul> <li>  <c>Key</c> - A map of primary key attribute values that uniquely identify the item. Each entry in this map consists of an attribute name and an attribute value. For each primary key, you must provide <i>all</i> of the key attributes. For example, with a simple primary key, you only need to provide a value for the partition key. For a composite primary key, you must provide values for <i>both</i> the partition key and the sort key. </li> </ul> </li> <li>  <c>PutRequest</c> - Perform a <c>PutItem</c> operation on the specified item. The item to be put is identified by an <c>Item</c> subelement: <ul> <li>  <c>Item</c> - A map of attributes and their values. Each entry in this map consists of an attribute name and an attribute value. Attribute values must not be null; string and binary type attributes must have lengths greater than zero; and set type attributes must not be empty. Requests that contain empty values are rejected with a <c>ValidationException</c> exception. If you specify any attributes that are part of an index key, then the data types for those attributes must match those of the schema in the table's attribute definition. </li> </ul> </li> </ul></param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchWriteItem service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ItemCollectionSizeLimitExceededException">
        /// An item collection is too large. This exception is only returned for tables that have
        /// one or more local secondary indexes.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. The Amazon Web Services SDKs for DynamoDB automatically
        /// retry requests that receive this exception. Your request is eventually successful,
        /// unless your retry queue is too large to finish. Reduce the frequency of requests and
        /// use exponential backoff. For more information, go to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Programming.Errors.html#Programming.Errors.RetryAndBackoff">Error
        /// Retries and Exponential Backoff</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ReplicatedWriteConflictException">
        /// The request was rejected because one or more items in the request are being modified
        /// by a request in another Region.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.RequestLimitExceededException">
        /// Throughput exceeds the current throughput quota for your account. For detailed information
        /// about why the request was throttled and the ARN of the impacted resource, find the
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. Contact <a href="https://aws.amazon.com/support">Amazon
        /// Web Services Support</a> to request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ThrottlingException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/BatchWriteItem">REST API Reference for BatchWriteItem Operation</seealso>
        public virtual Task<BatchWriteItemResponse> BatchWriteItemAsync(Dictionary<string, List<WriteRequest>> requestItems, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new BatchWriteItemRequest();
            request.RequestItems = requestItems;
            return BatchWriteItemAsync(request, cancellationToken);
        }


        /// <summary>
        /// The <c>BatchWriteItem</c> operation puts or deletes multiple items in one or more
        /// tables. A single call to <c>BatchWriteItem</c> can transmit up to 16MB of data over
        /// the network, consisting of up to 25 item put or delete operations. While individual
        /// items can be up to 400 KB once stored, it's important to note that an item's representation
        /// might be greater than 400KB while being sent in DynamoDB's JSON format for the API
        /// call. For more details on this distinction, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/HowItWorks.NamingRulesDataTypes.html">Naming
        /// Rules and Data Types</a>.
        /// 
        ///  <note> 
        /// <para>
        ///  <c>BatchWriteItem</c> cannot update items. If you perform a <c>BatchWriteItem</c>
        /// operation on an existing item, that item's values will be overwritten by the operation
        /// and it will appear like it was updated. To update items, we recommend you use the
        /// <c>UpdateItem</c> action.
        /// </para>
        ///  </note> 
        /// <para>
        /// The individual <c>PutItem</c> and <c>DeleteItem</c> operations specified in <c>BatchWriteItem</c>
        /// are atomic; however <c>BatchWriteItem</c> as a whole is not. If any requested operations
        /// fail because the table's provisioned throughput is exceeded or an internal processing
        /// failure occurs, the failed operations are returned in the <c>UnprocessedItems</c>
        /// response parameter. You can investigate and optionally resend the requests. Typically,
        /// you would call <c>BatchWriteItem</c> in a loop. Each iteration would check for unprocessed
        /// items and submit a new <c>BatchWriteItem</c> request with those unprocessed items
        /// until all items have been processed.
        /// </para>
        ///  
        /// <para>
        /// For tables and indexes with provisioned capacity, if none of the items can be processed
        /// due to insufficient provisioned throughput on all of the tables in the request, then
        /// <c>BatchWriteItem</c> returns a <c>ProvisionedThroughputExceededException</c>. For
        /// all tables and indexes, if none of the items can be processed due to other throttling
        /// scenarios (such as exceeding partition level limits), then <c>BatchWriteItem</c> returns
        /// a <c>ThrottlingException</c>.
        /// </para>
        ///  <important> 
        /// <para>
        /// If DynamoDB returns any unprocessed items, you should retry the batch operation on
        /// those items. However, <i>we strongly recommend that you use an exponential backoff
        /// algorithm</i>. If you retry the batch operation immediately, the underlying read or
        /// write requests can still fail due to throttling on the individual tables. If you delay
        /// the batch operation using exponential backoff, the individual requests in the batch
        /// are much more likely to succeed.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/ErrorHandling.html#Programming.Errors.BatchOperations">Batch
        /// Operations and Error Handling</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        ///  </important> 
        /// <para>
        /// With <c>BatchWriteItem</c>, you can efficiently write or delete large amounts of data,
        /// such as from Amazon EMR, or copy data from another database into DynamoDB. In order
        /// to improve performance with these large-scale operations, <c>BatchWriteItem</c> does
        /// not behave in the same way as individual <c>PutItem</c> and <c>DeleteItem</c> calls
        /// would. For example, you cannot specify conditions on individual put and delete requests,
        /// and <c>BatchWriteItem</c> does not return deleted items in the response.
        /// </para>
        ///  
        /// <para>
        /// If you use a programming language that supports concurrency, you can use threads to
        /// write items in parallel. Your application must include the necessary logic to manage
        /// the threads. With languages that don't support threading, you must update or delete
        /// the specified items one at a time. In both situations, <c>BatchWriteItem</c> performs
        /// the specified put and delete operations in parallel, giving you the power of the thread
        /// pool approach without having to introduce complexity into your application.
        /// </para>
        ///  
        /// <para>
        /// Parallel processing reduces latency, but each specified put and delete request consumes
        /// the same number of write capacity units whether it is processed in parallel or not.
        /// Delete operations on nonexistent items consume one write capacity unit.
        /// </para>
        ///  
        /// <para>
        /// If one or more of the following is true, DynamoDB rejects the entire batch write operation:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// One or more tables specified in the <c>BatchWriteItem</c> request does not exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Primary key attributes specified on an item in the request do not match those in the
        /// corresponding table's primary key schema.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You try to perform multiple operations on the same item in the same <c>BatchWriteItem</c>
        /// request. For example, you cannot put and delete the same item in the same <c>BatchWriteItem</c>
        /// request. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Your request contains at least two items with identical hash and range keys (which
        /// essentially is two put operations). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There are more than 25 requests in the batch.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Any individual item in a batch exceeds 400 KB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The total request size exceeds 16 MB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Any individual items with keys exceeding the key length limits. For a partition key,
        /// the limit is 2048 bytes and for a sort key, the limit is 1024 bytes.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchWriteItem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchWriteItem service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ItemCollectionSizeLimitExceededException">
        /// An item collection is too large. This exception is only returned for tables that have
        /// one or more local secondary indexes.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. The Amazon Web Services SDKs for DynamoDB automatically
        /// retry requests that receive this exception. Your request is eventually successful,
        /// unless your retry queue is too large to finish. Reduce the frequency of requests and
        /// use exponential backoff. For more information, go to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Programming.Errors.html#Programming.Errors.RetryAndBackoff">Error
        /// Retries and Exponential Backoff</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ReplicatedWriteConflictException">
        /// The request was rejected because one or more items in the request are being modified
        /// by a request in another Region.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.RequestLimitExceededException">
        /// Throughput exceeds the current throughput quota for your account. For detailed information
        /// about why the request was throttled and the ARN of the impacted resource, find the
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. Contact <a href="https://aws.amazon.com/support">Amazon
        /// Web Services Support</a> to request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ThrottlingException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/BatchWriteItem">REST API Reference for BatchWriteItem Operation</seealso>
        public virtual Task<BatchWriteItemResponse> BatchWriteItemAsync(BatchWriteItemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = BatchWriteItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchWriteItemResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = BatchWriteItemEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;
            
            return InvokeAsync<BatchWriteItemResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateBackup


        /// <summary>
        /// Creates a backup for an existing table.
        /// 
        ///  
        /// <para>
        ///  Each time you create an on-demand backup, the entire table data is backed up. There
        /// is no limit to the number of on-demand backups that can be taken. 
        /// </para>
        ///  
        /// <para>
        ///  When you create an on-demand backup, a time marker of the request is cataloged, and
        /// the backup is created asynchronously, by applying all changes until the time of the
        /// request to the last full table snapshot. Backup requests are processed instantaneously
        /// and become available for restore within minutes. 
        /// </para>
        ///  
        /// <para>
        /// You can call <c>CreateBackup</c> at a maximum rate of 50 times per second.
        /// </para>
        ///  
        /// <para>
        /// All backups in DynamoDB work without consuming any provisioned throughput on the table.
        /// </para>
        ///  
        /// <para>
        ///  If you submit a backup request on 2018-12-14 at 14:25:00, the backup is guaranteed
        /// to contain all data committed to the table up to 14:24:00, and data committed after
        /// 14:26:00 will not be. The backup might contain data modifications made between 14:24:00
        /// and 14:26:00. On-demand backup does not support causal consistency. 
        /// </para>
        ///  
        /// <para>
        ///  Along with data, the following are also included on the backups: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Global secondary indexes (GSIs)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Local secondary indexes (LSIs)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Streams
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Provisioned read and write capacity
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBackup service method.</param>
        /// 
        /// <returns>The response from the CreateBackup service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.BackupInUseException">
        /// There is another ongoing conflicting backup control plane operation on the table.
        /// The backup is either being created, deleted or restored to a table.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ContinuousBackupsUnavailableException">
        /// Backups have not yet been enabled for this table.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.LimitExceededException">
        /// There is no limit to the number of daily on-demand backups that can be taken. 
        /// 
        ///  
        /// <para>
        /// For most purposes, up to 500 simultaneous table operations are allowed per account.
        /// These operations include <c>CreateTable</c>, <c>UpdateTable</c>, <c>DeleteTable</c>,<c>UpdateTimeToLive</c>,
        /// <c>RestoreTableFromBackup</c>, and <c>RestoreTableToPointInTime</c>. 
        /// </para>
        ///  
        /// <para>
        /// When you are creating a table with one or more secondary indexes, you can have up
        /// to 250 such requests running at a time. However, if the table or index specifications
        /// are complex, then DynamoDB might temporarily reduce the number of concurrent operations.
        /// </para>
        ///  
        /// <para>
        /// When importing into DynamoDB, up to 50 simultaneous import table operations are allowed
        /// per account.
        /// </para>
        ///  
        /// <para>
        /// There is a soft account quota of 2,500 tables.
        /// </para>
        ///  
        /// <para>
        /// GetRecords was called with a value of more than 1000 for the limit request parameter.
        /// </para>
        ///  
        /// <para>
        /// More than 2 processes are reading from the same streams shard at the same time. Exceeding
        /// this limit may result in request throttling.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.TableInUseException">
        /// A target table with the specified name is either being created or deleted.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.TableNotFoundException">
        /// A source table with the name <c>TableName</c> does not currently exist within the
        /// subscriber's account or the subscriber is operating in the wrong Amazon Web Services
        /// Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/CreateBackup">REST API Reference for CreateBackup Operation</seealso>
        public virtual CreateBackupResponse CreateBackup(CreateBackupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBackupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBackupResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = CreateBackupEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<CreateBackupResponse>(request, options);
        }


        /// <summary>
        /// Creates a backup for an existing table.
        /// 
        ///  
        /// <para>
        ///  Each time you create an on-demand backup, the entire table data is backed up. There
        /// is no limit to the number of on-demand backups that can be taken. 
        /// </para>
        ///  
        /// <para>
        ///  When you create an on-demand backup, a time marker of the request is cataloged, and
        /// the backup is created asynchronously, by applying all changes until the time of the
        /// request to the last full table snapshot. Backup requests are processed instantaneously
        /// and become available for restore within minutes. 
        /// </para>
        ///  
        /// <para>
        /// You can call <c>CreateBackup</c> at a maximum rate of 50 times per second.
        /// </para>
        ///  
        /// <para>
        /// All backups in DynamoDB work without consuming any provisioned throughput on the table.
        /// </para>
        ///  
        /// <para>
        ///  If you submit a backup request on 2018-12-14 at 14:25:00, the backup is guaranteed
        /// to contain all data committed to the table up to 14:24:00, and data committed after
        /// 14:26:00 will not be. The backup might contain data modifications made between 14:24:00
        /// and 14:26:00. On-demand backup does not support causal consistency. 
        /// </para>
        ///  
        /// <para>
        ///  Along with data, the following are also included on the backups: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Global secondary indexes (GSIs)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Local secondary indexes (LSIs)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Streams
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Provisioned read and write capacity
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBackup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBackup service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.BackupInUseException">
        /// There is another ongoing conflicting backup control plane operation on the table.
        /// The backup is either being created, deleted or restored to a table.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ContinuousBackupsUnavailableException">
        /// Backups have not yet been enabled for this table.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.LimitExceededException">
        /// There is no limit to the number of daily on-demand backups that can be taken. 
        /// 
        ///  
        /// <para>
        /// For most purposes, up to 500 simultaneous table operations are allowed per account.
        /// These operations include <c>CreateTable</c>, <c>UpdateTable</c>, <c>DeleteTable</c>,<c>UpdateTimeToLive</c>,
        /// <c>RestoreTableFromBackup</c>, and <c>RestoreTableToPointInTime</c>. 
        /// </para>
        ///  
        /// <para>
        /// When you are creating a table with one or more secondary indexes, you can have up
        /// to 250 such requests running at a time. However, if the table or index specifications
        /// are complex, then DynamoDB might temporarily reduce the number of concurrent operations.
        /// </para>
        ///  
        /// <para>
        /// When importing into DynamoDB, up to 50 simultaneous import table operations are allowed
        /// per account.
        /// </para>
        ///  
        /// <para>
        /// There is a soft account quota of 2,500 tables.
        /// </para>
        ///  
        /// <para>
        /// GetRecords was called with a value of more than 1000 for the limit request parameter.
        /// </para>
        ///  
        /// <para>
        /// More than 2 processes are reading from the same streams shard at the same time. Exceeding
        /// this limit may result in request throttling.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.TableInUseException">
        /// A target table with the specified name is either being created or deleted.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.TableNotFoundException">
        /// A source table with the name <c>TableName</c> does not currently exist within the
        /// subscriber's account or the subscriber is operating in the wrong Amazon Web Services
        /// Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/CreateBackup">REST API Reference for CreateBackup Operation</seealso>
        public virtual Task<CreateBackupResponse> CreateBackupAsync(CreateBackupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBackupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBackupResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = CreateBackupEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;
            
            return InvokeAsync<CreateBackupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateGlobalTable


        /// <summary>
        /// Creates a global table from an existing table. A global table creates a replication
        /// relationship between two or more DynamoDB tables with the same table name in the provided
        /// Regions. 
        /// 
        ///  <important> 
        /// <para>
        /// This documentation is for version 2017.11.29 (Legacy) of global tables, which should
        /// be avoided for new global tables. Customers should use <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/GlobalTables.html">Global
        /// Tables version 2019.11.21 (Current)</a> when possible, because it provides greater
        /// flexibility, higher efficiency, and consumes less write capacity than 2017.11.29 (Legacy).
        /// </para>
        ///  
        /// <para>
        /// To determine which version you're using, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/globaltables.DetermineVersion.html">Determining
        /// the global table version you are using</a>. To update existing global tables from
        /// version 2017.11.29 (Legacy) to version 2019.11.21 (Current), see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/V2globaltables_upgrade.html">Upgrading
        /// global tables</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// If you want to add a new replica table to a global table, each of the following conditions
        /// must be true:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The table must have the same primary key as all of the other replicas.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The table must have the same name as all of the other replicas.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The table must have DynamoDB Streams enabled, with the stream containing both the
        /// new and the old images of the item.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// None of the replica tables in the global table can contain any data.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  If global secondary indexes are specified, then the following conditions must also
        /// be met: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  The global secondary indexes must have the same name. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  The global secondary indexes must have the same hash key and sort key (if present).
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  If local secondary indexes are specified, then the following conditions must also
        /// be met: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  The local secondary indexes must have the same name. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  The local secondary indexes must have the same hash key and sort key (if present).
        /// 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        ///  Write capacity settings should be set consistently across your replica tables and
        /// secondary indexes. DynamoDB strongly recommends enabling auto scaling to manage the
        /// write capacity settings for all of your global tables replicas and indexes. 
        /// </para>
        ///  
        /// <para>
        ///  If you prefer to manage write capacity settings manually, you should provision equal
        /// replicated write capacity units to your replica tables. You should also provision
        /// equal replicated write capacity units to matching secondary indexes across your global
        /// table. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGlobalTable service method.</param>
        /// 
        /// <returns>The response from the CreateGlobalTable service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.GlobalTableAlreadyExistsException">
        /// The specified global table already exists.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.LimitExceededException">
        /// There is no limit to the number of daily on-demand backups that can be taken. 
        /// 
        ///  
        /// <para>
        /// For most purposes, up to 500 simultaneous table operations are allowed per account.
        /// These operations include <c>CreateTable</c>, <c>UpdateTable</c>, <c>DeleteTable</c>,<c>UpdateTimeToLive</c>,
        /// <c>RestoreTableFromBackup</c>, and <c>RestoreTableToPointInTime</c>. 
        /// </para>
        ///  
        /// <para>
        /// When you are creating a table with one or more secondary indexes, you can have up
        /// to 250 such requests running at a time. However, if the table or index specifications
        /// are complex, then DynamoDB might temporarily reduce the number of concurrent operations.
        /// </para>
        ///  
        /// <para>
        /// When importing into DynamoDB, up to 50 simultaneous import table operations are allowed
        /// per account.
        /// </para>
        ///  
        /// <para>
        /// There is a soft account quota of 2,500 tables.
        /// </para>
        ///  
        /// <para>
        /// GetRecords was called with a value of more than 1000 for the limit request parameter.
        /// </para>
        ///  
        /// <para>
        /// More than 2 processes are reading from the same streams shard at the same time. Exceeding
        /// this limit may result in request throttling.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.TableNotFoundException">
        /// A source table with the name <c>TableName</c> does not currently exist within the
        /// subscriber's account or the subscriber is operating in the wrong Amazon Web Services
        /// Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/CreateGlobalTable">REST API Reference for CreateGlobalTable Operation</seealso>
        public virtual CreateGlobalTableResponse CreateGlobalTable(CreateGlobalTableRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGlobalTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGlobalTableResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = CreateGlobalTableEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<CreateGlobalTableResponse>(request, options);
        }


        /// <summary>
        /// Creates a global table from an existing table. A global table creates a replication
        /// relationship between two or more DynamoDB tables with the same table name in the provided
        /// Regions. 
        /// 
        ///  <important> 
        /// <para>
        /// This documentation is for version 2017.11.29 (Legacy) of global tables, which should
        /// be avoided for new global tables. Customers should use <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/GlobalTables.html">Global
        /// Tables version 2019.11.21 (Current)</a> when possible, because it provides greater
        /// flexibility, higher efficiency, and consumes less write capacity than 2017.11.29 (Legacy).
        /// </para>
        ///  
        /// <para>
        /// To determine which version you're using, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/globaltables.DetermineVersion.html">Determining
        /// the global table version you are using</a>. To update existing global tables from
        /// version 2017.11.29 (Legacy) to version 2019.11.21 (Current), see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/V2globaltables_upgrade.html">Upgrading
        /// global tables</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// If you want to add a new replica table to a global table, each of the following conditions
        /// must be true:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The table must have the same primary key as all of the other replicas.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The table must have the same name as all of the other replicas.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The table must have DynamoDB Streams enabled, with the stream containing both the
        /// new and the old images of the item.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// None of the replica tables in the global table can contain any data.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  If global secondary indexes are specified, then the following conditions must also
        /// be met: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  The global secondary indexes must have the same name. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  The global secondary indexes must have the same hash key and sort key (if present).
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  If local secondary indexes are specified, then the following conditions must also
        /// be met: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  The local secondary indexes must have the same name. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  The local secondary indexes must have the same hash key and sort key (if present).
        /// 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        ///  Write capacity settings should be set consistently across your replica tables and
        /// secondary indexes. DynamoDB strongly recommends enabling auto scaling to manage the
        /// write capacity settings for all of your global tables replicas and indexes. 
        /// </para>
        ///  
        /// <para>
        ///  If you prefer to manage write capacity settings manually, you should provision equal
        /// replicated write capacity units to your replica tables. You should also provision
        /// equal replicated write capacity units to matching secondary indexes across your global
        /// table. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGlobalTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGlobalTable service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.GlobalTableAlreadyExistsException">
        /// The specified global table already exists.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.LimitExceededException">
        /// There is no limit to the number of daily on-demand backups that can be taken. 
        /// 
        ///  
        /// <para>
        /// For most purposes, up to 500 simultaneous table operations are allowed per account.
        /// These operations include <c>CreateTable</c>, <c>UpdateTable</c>, <c>DeleteTable</c>,<c>UpdateTimeToLive</c>,
        /// <c>RestoreTableFromBackup</c>, and <c>RestoreTableToPointInTime</c>. 
        /// </para>
        ///  
        /// <para>
        /// When you are creating a table with one or more secondary indexes, you can have up
        /// to 250 such requests running at a time. However, if the table or index specifications
        /// are complex, then DynamoDB might temporarily reduce the number of concurrent operations.
        /// </para>
        ///  
        /// <para>
        /// When importing into DynamoDB, up to 50 simultaneous import table operations are allowed
        /// per account.
        /// </para>
        ///  
        /// <para>
        /// There is a soft account quota of 2,500 tables.
        /// </para>
        ///  
        /// <para>
        /// GetRecords was called with a value of more than 1000 for the limit request parameter.
        /// </para>
        ///  
        /// <para>
        /// More than 2 processes are reading from the same streams shard at the same time. Exceeding
        /// this limit may result in request throttling.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.TableNotFoundException">
        /// A source table with the name <c>TableName</c> does not currently exist within the
        /// subscriber's account or the subscriber is operating in the wrong Amazon Web Services
        /// Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/CreateGlobalTable">REST API Reference for CreateGlobalTable Operation</seealso>
        public virtual Task<CreateGlobalTableResponse> CreateGlobalTableAsync(CreateGlobalTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateGlobalTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGlobalTableResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = CreateGlobalTableEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;
            
            return InvokeAsync<CreateGlobalTableResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTable


        /// <summary>
        /// The <c>CreateTable</c> operation adds a new table to your account. In an Amazon Web
        /// Services account, table names must be unique within each Region. That is, you can
        /// have two tables with same name if you create the tables in different Regions.
        /// 
        ///  
        /// <para>
        ///  <c>CreateTable</c> is an asynchronous operation. Upon receiving a <c>CreateTable</c>
        /// request, DynamoDB immediately returns a response with a <c>TableStatus</c> of <c>CREATING</c>.
        /// After the table is created, DynamoDB sets the <c>TableStatus</c> to <c>ACTIVE</c>.
        /// You can perform read and write operations only on an <c>ACTIVE</c> table. 
        /// </para>
        ///  
        /// <para>
        /// You can optionally define secondary indexes on the new table, as part of the <c>CreateTable</c>
        /// operation. If you want to create multiple tables with secondary indexes on them, you
        /// must create the tables sequentially. Only one table with secondary indexes can be
        /// in the <c>CREATING</c> state at any given time.
        /// </para>
        ///  
        /// <para>
        /// You can use the <c>DescribeTable</c> action to check the table status.
        /// </para>
        /// </summary>
        /// <param name="tableName">The name of the table to create. You can also provide the Amazon Resource Name (ARN) of the table in this parameter.</param>
        /// <param name="keySchema">Specifies the attributes that make up the primary key for a table or an index. The attributes in <c>KeySchema</c> must also be defined in the <c>AttributeDefinitions</c> array. For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/DataModel.html">Data Model</a> in the <i>Amazon DynamoDB Developer Guide</i>. Each <c>KeySchemaElement</c> in the array is composed of: <ul> <li>  <c>AttributeName</c> - The name of this key attribute. </li> <li>  <c>KeyType</c> - The role that the key attribute will assume: <ul> <li>  <c>HASH</c> - partition key </li> <li>  <c>RANGE</c> - sort key </li> </ul> </li> </ul> <note> The partition key of an item is also known as its <i>hash attribute</i>. The term "hash attribute" derives from the DynamoDB usage of an internal hash function to evenly distribute data items across partitions, based on their partition key values. The sort key of an item is also known as its <i>range attribute</i>. The term "range attribute" derives from the way DynamoDB stores items with the same partition key physically close together, in sorted order by the sort key value. </note> For a simple primary key (partition key), you must provide exactly one element with a <c>KeyType</c> of <c>HASH</c>. For a composite primary key (partition key and sort key), you must provide exactly two elements, in this order: The first element must have a <c>KeyType</c> of <c>HASH</c>, and the second element must have a <c>KeyType</c> of <c>RANGE</c>. For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/WorkingWithTables.html#WorkingWithTables.primary.key">Working with Tables</a> in the <i>Amazon DynamoDB Developer Guide</i>.</param>
        /// <param name="attributeDefinitions">An array of attributes that describe the key schema for the table and indexes.</param>
        /// <param name="provisionedThroughput">Represents the provisioned throughput settings for a specified table or index. The settings can be modified using the <c>UpdateTable</c> operation.  If you set BillingMode as <c>PROVISIONED</c>, you must specify this property. If you set BillingMode as <c>PAY_PER_REQUEST</c>, you cannot specify this property. For current minimum and maximum provisioned throughput values, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Limits.html">Service, Account, and Table Quotas</a> in the <i>Amazon DynamoDB Developer Guide</i>.</param>
        /// 
        /// <returns>The response from the CreateTable service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.LimitExceededException">
        /// There is no limit to the number of daily on-demand backups that can be taken. 
        /// 
        ///  
        /// <para>
        /// For most purposes, up to 500 simultaneous table operations are allowed per account.
        /// These operations include <c>CreateTable</c>, <c>UpdateTable</c>, <c>DeleteTable</c>,<c>UpdateTimeToLive</c>,
        /// <c>RestoreTableFromBackup</c>, and <c>RestoreTableToPointInTime</c>. 
        /// </para>
        ///  
        /// <para>
        /// When you are creating a table with one or more secondary indexes, you can have up
        /// to 250 such requests running at a time. However, if the table or index specifications
        /// are complex, then DynamoDB might temporarily reduce the number of concurrent operations.
        /// </para>
        ///  
        /// <para>
        /// When importing into DynamoDB, up to 50 simultaneous import table operations are allowed
        /// per account.
        /// </para>
        ///  
        /// <para>
        /// There is a soft account quota of 2,500 tables.
        /// </para>
        ///  
        /// <para>
        /// GetRecords was called with a value of more than 1000 for the limit request parameter.
        /// </para>
        ///  
        /// <para>
        /// More than 2 processes are reading from the same streams shard at the same time. Exceeding
        /// this limit may result in request throttling.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceInUseException">
        /// The operation conflicts with the resource's availability. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You attempted to recreate an existing table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a table currently in the <c>CREATING</c> state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a resource that was already being updated.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When appropriate, wait for the ongoing update to complete and attempt the request
        /// again.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/CreateTable">REST API Reference for CreateTable Operation</seealso>
        public virtual CreateTableResponse CreateTable(string tableName, List<KeySchemaElement> keySchema, List<AttributeDefinition> attributeDefinitions, ProvisionedThroughput provisionedThroughput)
        {
            var request = new CreateTableRequest();
            request.TableName = tableName;
            request.KeySchema = keySchema;
            request.AttributeDefinitions = attributeDefinitions;
            request.ProvisionedThroughput = provisionedThroughput;
            return CreateTable(request);
        }


        /// <summary>
        /// The <c>CreateTable</c> operation adds a new table to your account. In an Amazon Web
        /// Services account, table names must be unique within each Region. That is, you can
        /// have two tables with same name if you create the tables in different Regions.
        /// 
        ///  
        /// <para>
        ///  <c>CreateTable</c> is an asynchronous operation. Upon receiving a <c>CreateTable</c>
        /// request, DynamoDB immediately returns a response with a <c>TableStatus</c> of <c>CREATING</c>.
        /// After the table is created, DynamoDB sets the <c>TableStatus</c> to <c>ACTIVE</c>.
        /// You can perform read and write operations only on an <c>ACTIVE</c> table. 
        /// </para>
        ///  
        /// <para>
        /// You can optionally define secondary indexes on the new table, as part of the <c>CreateTable</c>
        /// operation. If you want to create multiple tables with secondary indexes on them, you
        /// must create the tables sequentially. Only one table with secondary indexes can be
        /// in the <c>CREATING</c> state at any given time.
        /// </para>
        ///  
        /// <para>
        /// You can use the <c>DescribeTable</c> action to check the table status.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTable service method.</param>
        /// 
        /// <returns>The response from the CreateTable service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.LimitExceededException">
        /// There is no limit to the number of daily on-demand backups that can be taken. 
        /// 
        ///  
        /// <para>
        /// For most purposes, up to 500 simultaneous table operations are allowed per account.
        /// These operations include <c>CreateTable</c>, <c>UpdateTable</c>, <c>DeleteTable</c>,<c>UpdateTimeToLive</c>,
        /// <c>RestoreTableFromBackup</c>, and <c>RestoreTableToPointInTime</c>. 
        /// </para>
        ///  
        /// <para>
        /// When you are creating a table with one or more secondary indexes, you can have up
        /// to 250 such requests running at a time. However, if the table or index specifications
        /// are complex, then DynamoDB might temporarily reduce the number of concurrent operations.
        /// </para>
        ///  
        /// <para>
        /// When importing into DynamoDB, up to 50 simultaneous import table operations are allowed
        /// per account.
        /// </para>
        ///  
        /// <para>
        /// There is a soft account quota of 2,500 tables.
        /// </para>
        ///  
        /// <para>
        /// GetRecords was called with a value of more than 1000 for the limit request parameter.
        /// </para>
        ///  
        /// <para>
        /// More than 2 processes are reading from the same streams shard at the same time. Exceeding
        /// this limit may result in request throttling.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceInUseException">
        /// The operation conflicts with the resource's availability. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You attempted to recreate an existing table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a table currently in the <c>CREATING</c> state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a resource that was already being updated.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When appropriate, wait for the ongoing update to complete and attempt the request
        /// again.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/CreateTable">REST API Reference for CreateTable Operation</seealso>
        public virtual CreateTableResponse CreateTable(CreateTableRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTableResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = CreateTableEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<CreateTableResponse>(request, options);
        }


        /// <summary>
        /// The <c>CreateTable</c> operation adds a new table to your account. In an Amazon Web
        /// Services account, table names must be unique within each Region. That is, you can
        /// have two tables with same name if you create the tables in different Regions.
        /// 
        ///  
        /// <para>
        ///  <c>CreateTable</c> is an asynchronous operation. Upon receiving a <c>CreateTable</c>
        /// request, DynamoDB immediately returns a response with a <c>TableStatus</c> of <c>CREATING</c>.
        /// After the table is created, DynamoDB sets the <c>TableStatus</c> to <c>ACTIVE</c>.
        /// You can perform read and write operations only on an <c>ACTIVE</c> table. 
        /// </para>
        ///  
        /// <para>
        /// You can optionally define secondary indexes on the new table, as part of the <c>CreateTable</c>
        /// operation. If you want to create multiple tables with secondary indexes on them, you
        /// must create the tables sequentially. Only one table with secondary indexes can be
        /// in the <c>CREATING</c> state at any given time.
        /// </para>
        ///  
        /// <para>
        /// You can use the <c>DescribeTable</c> action to check the table status.
        /// </para>
        /// </summary>
        /// <param name="tableName">The name of the table to create. You can also provide the Amazon Resource Name (ARN) of the table in this parameter.</param>
        /// <param name="keySchema">Specifies the attributes that make up the primary key for a table or an index. The attributes in <c>KeySchema</c> must also be defined in the <c>AttributeDefinitions</c> array. For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/DataModel.html">Data Model</a> in the <i>Amazon DynamoDB Developer Guide</i>. Each <c>KeySchemaElement</c> in the array is composed of: <ul> <li>  <c>AttributeName</c> - The name of this key attribute. </li> <li>  <c>KeyType</c> - The role that the key attribute will assume: <ul> <li>  <c>HASH</c> - partition key </li> <li>  <c>RANGE</c> - sort key </li> </ul> </li> </ul> <note> The partition key of an item is also known as its <i>hash attribute</i>. The term "hash attribute" derives from the DynamoDB usage of an internal hash function to evenly distribute data items across partitions, based on their partition key values. The sort key of an item is also known as its <i>range attribute</i>. The term "range attribute" derives from the way DynamoDB stores items with the same partition key physically close together, in sorted order by the sort key value. </note> For a simple primary key (partition key), you must provide exactly one element with a <c>KeyType</c> of <c>HASH</c>. For a composite primary key (partition key and sort key), you must provide exactly two elements, in this order: The first element must have a <c>KeyType</c> of <c>HASH</c>, and the second element must have a <c>KeyType</c> of <c>RANGE</c>. For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/WorkingWithTables.html#WorkingWithTables.primary.key">Working with Tables</a> in the <i>Amazon DynamoDB Developer Guide</i>.</param>
        /// <param name="attributeDefinitions">An array of attributes that describe the key schema for the table and indexes.</param>
        /// <param name="provisionedThroughput">Represents the provisioned throughput settings for a specified table or index. The settings can be modified using the <c>UpdateTable</c> operation.  If you set BillingMode as <c>PROVISIONED</c>, you must specify this property. If you set BillingMode as <c>PAY_PER_REQUEST</c>, you cannot specify this property. For current minimum and maximum provisioned throughput values, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Limits.html">Service, Account, and Table Quotas</a> in the <i>Amazon DynamoDB Developer Guide</i>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTable service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.LimitExceededException">
        /// There is no limit to the number of daily on-demand backups that can be taken. 
        /// 
        ///  
        /// <para>
        /// For most purposes, up to 500 simultaneous table operations are allowed per account.
        /// These operations include <c>CreateTable</c>, <c>UpdateTable</c>, <c>DeleteTable</c>,<c>UpdateTimeToLive</c>,
        /// <c>RestoreTableFromBackup</c>, and <c>RestoreTableToPointInTime</c>. 
        /// </para>
        ///  
        /// <para>
        /// When you are creating a table with one or more secondary indexes, you can have up
        /// to 250 such requests running at a time. However, if the table or index specifications
        /// are complex, then DynamoDB might temporarily reduce the number of concurrent operations.
        /// </para>
        ///  
        /// <para>
        /// When importing into DynamoDB, up to 50 simultaneous import table operations are allowed
        /// per account.
        /// </para>
        ///  
        /// <para>
        /// There is a soft account quota of 2,500 tables.
        /// </para>
        ///  
        /// <para>
        /// GetRecords was called with a value of more than 1000 for the limit request parameter.
        /// </para>
        ///  
        /// <para>
        /// More than 2 processes are reading from the same streams shard at the same time. Exceeding
        /// this limit may result in request throttling.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceInUseException">
        /// The operation conflicts with the resource's availability. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You attempted to recreate an existing table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a table currently in the <c>CREATING</c> state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a resource that was already being updated.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When appropriate, wait for the ongoing update to complete and attempt the request
        /// again.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/CreateTable">REST API Reference for CreateTable Operation</seealso>
        public virtual Task<CreateTableResponse> CreateTableAsync(string tableName, List<KeySchemaElement> keySchema, List<AttributeDefinition> attributeDefinitions, ProvisionedThroughput provisionedThroughput, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new CreateTableRequest();
            request.TableName = tableName;
            request.KeySchema = keySchema;
            request.AttributeDefinitions = attributeDefinitions;
            request.ProvisionedThroughput = provisionedThroughput;
            return CreateTableAsync(request, cancellationToken);
        }


        /// <summary>
        /// The <c>CreateTable</c> operation adds a new table to your account. In an Amazon Web
        /// Services account, table names must be unique within each Region. That is, you can
        /// have two tables with same name if you create the tables in different Regions.
        /// 
        ///  
        /// <para>
        ///  <c>CreateTable</c> is an asynchronous operation. Upon receiving a <c>CreateTable</c>
        /// request, DynamoDB immediately returns a response with a <c>TableStatus</c> of <c>CREATING</c>.
        /// After the table is created, DynamoDB sets the <c>TableStatus</c> to <c>ACTIVE</c>.
        /// You can perform read and write operations only on an <c>ACTIVE</c> table. 
        /// </para>
        ///  
        /// <para>
        /// You can optionally define secondary indexes on the new table, as part of the <c>CreateTable</c>
        /// operation. If you want to create multiple tables with secondary indexes on them, you
        /// must create the tables sequentially. Only one table with secondary indexes can be
        /// in the <c>CREATING</c> state at any given time.
        /// </para>
        ///  
        /// <para>
        /// You can use the <c>DescribeTable</c> action to check the table status.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTable service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.LimitExceededException">
        /// There is no limit to the number of daily on-demand backups that can be taken. 
        /// 
        ///  
        /// <para>
        /// For most purposes, up to 500 simultaneous table operations are allowed per account.
        /// These operations include <c>CreateTable</c>, <c>UpdateTable</c>, <c>DeleteTable</c>,<c>UpdateTimeToLive</c>,
        /// <c>RestoreTableFromBackup</c>, and <c>RestoreTableToPointInTime</c>. 
        /// </para>
        ///  
        /// <para>
        /// When you are creating a table with one or more secondary indexes, you can have up
        /// to 250 such requests running at a time. However, if the table or index specifications
        /// are complex, then DynamoDB might temporarily reduce the number of concurrent operations.
        /// </para>
        ///  
        /// <para>
        /// When importing into DynamoDB, up to 50 simultaneous import table operations are allowed
        /// per account.
        /// </para>
        ///  
        /// <para>
        /// There is a soft account quota of 2,500 tables.
        /// </para>
        ///  
        /// <para>
        /// GetRecords was called with a value of more than 1000 for the limit request parameter.
        /// </para>
        ///  
        /// <para>
        /// More than 2 processes are reading from the same streams shard at the same time. Exceeding
        /// this limit may result in request throttling.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceInUseException">
        /// The operation conflicts with the resource's availability. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You attempted to recreate an existing table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a table currently in the <c>CREATING</c> state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a resource that was already being updated.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When appropriate, wait for the ongoing update to complete and attempt the request
        /// again.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/CreateTable">REST API Reference for CreateTable Operation</seealso>
        public virtual Task<CreateTableResponse> CreateTableAsync(CreateTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTableResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = CreateTableEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;
            
            return InvokeAsync<CreateTableResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBackup


        /// <summary>
        /// Deletes an existing backup of a table.
        /// 
        ///  
        /// <para>
        /// You can call <c>DeleteBackup</c> at a maximum rate of 10 times per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackup service method.</param>
        /// 
        /// <returns>The response from the DeleteBackup service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.BackupInUseException">
        /// There is another ongoing conflicting backup control plane operation on the table.
        /// The backup is either being created, deleted or restored to a table.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.BackupNotFoundException">
        /// Backup not found for the given BackupARN.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.LimitExceededException">
        /// There is no limit to the number of daily on-demand backups that can be taken. 
        /// 
        ///  
        /// <para>
        /// For most purposes, up to 500 simultaneous table operations are allowed per account.
        /// These operations include <c>CreateTable</c>, <c>UpdateTable</c>, <c>DeleteTable</c>,<c>UpdateTimeToLive</c>,
        /// <c>RestoreTableFromBackup</c>, and <c>RestoreTableToPointInTime</c>. 
        /// </para>
        ///  
        /// <para>
        /// When you are creating a table with one or more secondary indexes, you can have up
        /// to 250 such requests running at a time. However, if the table or index specifications
        /// are complex, then DynamoDB might temporarily reduce the number of concurrent operations.
        /// </para>
        ///  
        /// <para>
        /// When importing into DynamoDB, up to 50 simultaneous import table operations are allowed
        /// per account.
        /// </para>
        ///  
        /// <para>
        /// There is a soft account quota of 2,500 tables.
        /// </para>
        ///  
        /// <para>
        /// GetRecords was called with a value of more than 1000 for the limit request parameter.
        /// </para>
        ///  
        /// <para>
        /// More than 2 processes are reading from the same streams shard at the same time. Exceeding
        /// this limit may result in request throttling.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/DeleteBackup">REST API Reference for DeleteBackup Operation</seealso>
        public virtual DeleteBackupResponse DeleteBackup(DeleteBackupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBackupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBackupResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = DeleteBackupEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<DeleteBackupResponse>(request, options);
        }


        /// <summary>
        /// Deletes an existing backup of a table.
        /// 
        ///  
        /// <para>
        /// You can call <c>DeleteBackup</c> at a maximum rate of 10 times per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBackup service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.BackupInUseException">
        /// There is another ongoing conflicting backup control plane operation on the table.
        /// The backup is either being created, deleted or restored to a table.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.BackupNotFoundException">
        /// Backup not found for the given BackupARN.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.LimitExceededException">
        /// There is no limit to the number of daily on-demand backups that can be taken. 
        /// 
        ///  
        /// <para>
        /// For most purposes, up to 500 simultaneous table operations are allowed per account.
        /// These operations include <c>CreateTable</c>, <c>UpdateTable</c>, <c>DeleteTable</c>,<c>UpdateTimeToLive</c>,
        /// <c>RestoreTableFromBackup</c>, and <c>RestoreTableToPointInTime</c>. 
        /// </para>
        ///  
        /// <para>
        /// When you are creating a table with one or more secondary indexes, you can have up
        /// to 250 such requests running at a time. However, if the table or index specifications
        /// are complex, then DynamoDB might temporarily reduce the number of concurrent operations.
        /// </para>
        ///  
        /// <para>
        /// When importing into DynamoDB, up to 50 simultaneous import table operations are allowed
        /// per account.
        /// </para>
        ///  
        /// <para>
        /// There is a soft account quota of 2,500 tables.
        /// </para>
        ///  
        /// <para>
        /// GetRecords was called with a value of more than 1000 for the limit request parameter.
        /// </para>
        ///  
        /// <para>
        /// More than 2 processes are reading from the same streams shard at the same time. Exceeding
        /// this limit may result in request throttling.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/DeleteBackup">REST API Reference for DeleteBackup Operation</seealso>
        public virtual Task<DeleteBackupResponse> DeleteBackupAsync(DeleteBackupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBackupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBackupResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = DeleteBackupEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;
            
            return InvokeAsync<DeleteBackupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteItem


        /// <summary>
        /// Deletes a single item in a table by primary key. You can perform a conditional delete
        /// operation that deletes the item if it exists, or if it has an expected attribute value.
        /// 
        ///  
        /// <para>
        /// In addition to deleting an item, you can also return the item's attribute values in
        /// the same operation, using the <c>ReturnValues</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// Unless you specify conditions, the <c>DeleteItem</c> is an idempotent operation; running
        /// it multiple times on the same item or attribute does <i>not</i> result in an error
        /// response.
        /// </para>
        ///  
        /// <para>
        /// Conditional deletes are useful for deleting items only if specific conditions are
        /// met. If those conditions are met, DynamoDB performs the delete. Otherwise, the item
        /// is not deleted.
        /// </para>
        /// </summary>
        /// <param name="tableName">The name of the table from which to delete the item. You can also provide the Amazon Resource Name (ARN) of the table in this parameter.</param>
        /// <param name="key">A map of attribute names to <c>AttributeValue</c> objects, representing the primary key of the item to delete. For the primary key, you must provide all of the key attributes. For example, with a simple primary key, you only need to provide a value for the partition key. For a composite primary key, you must provide values for both the partition key and the sort key.</param>
        /// 
        /// <returns>The response from the DeleteItem service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.ConditionalCheckFailedException">
        /// A condition specified in the operation failed to be evaluated.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ItemCollectionSizeLimitExceededException">
        /// An item collection is too large. This exception is only returned for tables that have
        /// one or more local secondary indexes.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. The Amazon Web Services SDKs for DynamoDB automatically
        /// retry requests that receive this exception. Your request is eventually successful,
        /// unless your retry queue is too large to finish. Reduce the frequency of requests and
        /// use exponential backoff. For more information, go to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Programming.Errors.html#Programming.Errors.RetryAndBackoff">Error
        /// Retries and Exponential Backoff</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ReplicatedWriteConflictException">
        /// The request was rejected because one or more items in the request are being modified
        /// by a request in another Region.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.RequestLimitExceededException">
        /// Throughput exceeds the current throughput quota for your account. For detailed information
        /// about why the request was throttled and the ARN of the impacted resource, find the
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. Contact <a href="https://aws.amazon.com/support">Amazon
        /// Web Services Support</a> to request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ThrottlingException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.TransactionConflictException">
        /// Operation was rejected because there is an ongoing transaction for the item.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/DeleteItem">REST API Reference for DeleteItem Operation</seealso>
        public virtual DeleteItemResponse DeleteItem(string tableName, Dictionary<string, AttributeValue> key)
        {
            var request = new DeleteItemRequest();
            request.TableName = tableName;
            request.Key = key;
            return DeleteItem(request);
        }


        /// <summary>
        /// Deletes a single item in a table by primary key. You can perform a conditional delete
        /// operation that deletes the item if it exists, or if it has an expected attribute value.
        /// 
        ///  
        /// <para>
        /// In addition to deleting an item, you can also return the item's attribute values in
        /// the same operation, using the <c>ReturnValues</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// Unless you specify conditions, the <c>DeleteItem</c> is an idempotent operation; running
        /// it multiple times on the same item or attribute does <i>not</i> result in an error
        /// response.
        /// </para>
        ///  
        /// <para>
        /// Conditional deletes are useful for deleting items only if specific conditions are
        /// met. If those conditions are met, DynamoDB performs the delete. Otherwise, the item
        /// is not deleted.
        /// </para>
        /// </summary>
        /// <param name="tableName">The name of the table from which to delete the item. You can also provide the Amazon Resource Name (ARN) of the table in this parameter.</param>
        /// <param name="key">A map of attribute names to <c>AttributeValue</c> objects, representing the primary key of the item to delete. For the primary key, you must provide all of the key attributes. For example, with a simple primary key, you only need to provide a value for the partition key. For a composite primary key, you must provide values for both the partition key and the sort key.</param>
        /// <param name="returnValues">Use <c>ReturnValues</c> if you want to get the item attributes as they appeared before they were deleted. For <c>DeleteItem</c>, the valid values are: <ul> <li>  <c>NONE</c> - If <c>ReturnValues</c> is not specified, or if its value is <c>NONE</c>, then nothing is returned. (This setting is the default for <c>ReturnValues</c>.) </li> <li>  <c>ALL_OLD</c> - The content of the old item is returned. </li> </ul> There is no additional cost associated with requesting a return value aside from the small network and processing overhead of receiving a larger response. No read capacity units are consumed. <note> The <c>ReturnValues</c> parameter is used by several DynamoDB operations; however, <c>DeleteItem</c> does not recognize any values other than <c>NONE</c> or <c>ALL_OLD</c>. </note></param>
        /// 
        /// <returns>The response from the DeleteItem service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.ConditionalCheckFailedException">
        /// A condition specified in the operation failed to be evaluated.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ItemCollectionSizeLimitExceededException">
        /// An item collection is too large. This exception is only returned for tables that have
        /// one or more local secondary indexes.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. The Amazon Web Services SDKs for DynamoDB automatically
        /// retry requests that receive this exception. Your request is eventually successful,
        /// unless your retry queue is too large to finish. Reduce the frequency of requests and
        /// use exponential backoff. For more information, go to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Programming.Errors.html#Programming.Errors.RetryAndBackoff">Error
        /// Retries and Exponential Backoff</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ReplicatedWriteConflictException">
        /// The request was rejected because one or more items in the request are being modified
        /// by a request in another Region.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.RequestLimitExceededException">
        /// Throughput exceeds the current throughput quota for your account. For detailed information
        /// about why the request was throttled and the ARN of the impacted resource, find the
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. Contact <a href="https://aws.amazon.com/support">Amazon
        /// Web Services Support</a> to request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ThrottlingException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.TransactionConflictException">
        /// Operation was rejected because there is an ongoing transaction for the item.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/DeleteItem">REST API Reference for DeleteItem Operation</seealso>
        public virtual DeleteItemResponse DeleteItem(string tableName, Dictionary<string, AttributeValue> key, ReturnValue returnValues)
        {
            var request = new DeleteItemRequest();
            request.TableName = tableName;
            request.Key = key;
            request.ReturnValues = returnValues;
            return DeleteItem(request);
        }


        /// <summary>
        /// Deletes a single item in a table by primary key. You can perform a conditional delete
        /// operation that deletes the item if it exists, or if it has an expected attribute value.
        /// 
        ///  
        /// <para>
        /// In addition to deleting an item, you can also return the item's attribute values in
        /// the same operation, using the <c>ReturnValues</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// Unless you specify conditions, the <c>DeleteItem</c> is an idempotent operation; running
        /// it multiple times on the same item or attribute does <i>not</i> result in an error
        /// response.
        /// </para>
        ///  
        /// <para>
        /// Conditional deletes are useful for deleting items only if specific conditions are
        /// met. If those conditions are met, DynamoDB performs the delete. Otherwise, the item
        /// is not deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteItem service method.</param>
        /// 
        /// <returns>The response from the DeleteItem service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.ConditionalCheckFailedException">
        /// A condition specified in the operation failed to be evaluated.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ItemCollectionSizeLimitExceededException">
        /// An item collection is too large. This exception is only returned for tables that have
        /// one or more local secondary indexes.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. The Amazon Web Services SDKs for DynamoDB automatically
        /// retry requests that receive this exception. Your request is eventually successful,
        /// unless your retry queue is too large to finish. Reduce the frequency of requests and
        /// use exponential backoff. For more information, go to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Programming.Errors.html#Programming.Errors.RetryAndBackoff">Error
        /// Retries and Exponential Backoff</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ReplicatedWriteConflictException">
        /// The request was rejected because one or more items in the request are being modified
        /// by a request in another Region.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.RequestLimitExceededException">
        /// Throughput exceeds the current throughput quota for your account. For detailed information
        /// about why the request was throttled and the ARN of the impacted resource, find the
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. Contact <a href="https://aws.amazon.com/support">Amazon
        /// Web Services Support</a> to request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ThrottlingException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.TransactionConflictException">
        /// Operation was rejected because there is an ongoing transaction for the item.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/DeleteItem">REST API Reference for DeleteItem Operation</seealso>
        public virtual DeleteItemResponse DeleteItem(DeleteItemRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteItemResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = DeleteItemEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<DeleteItemResponse>(request, options);
        }


        /// <summary>
        /// Deletes a single item in a table by primary key. You can perform a conditional delete
        /// operation that deletes the item if it exists, or if it has an expected attribute value.
        /// 
        ///  
        /// <para>
        /// In addition to deleting an item, you can also return the item's attribute values in
        /// the same operation, using the <c>ReturnValues</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// Unless you specify conditions, the <c>DeleteItem</c> is an idempotent operation; running
        /// it multiple times on the same item or attribute does <i>not</i> result in an error
        /// response.
        /// </para>
        ///  
        /// <para>
        /// Conditional deletes are useful for deleting items only if specific conditions are
        /// met. If those conditions are met, DynamoDB performs the delete. Otherwise, the item
        /// is not deleted.
        /// </para>
        /// </summary>
        /// <param name="tableName">The name of the table from which to delete the item. You can also provide the Amazon Resource Name (ARN) of the table in this parameter.</param>
        /// <param name="key">A map of attribute names to <c>AttributeValue</c> objects, representing the primary key of the item to delete. For the primary key, you must provide all of the key attributes. For example, with a simple primary key, you only need to provide a value for the partition key. For a composite primary key, you must provide values for both the partition key and the sort key.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteItem service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.ConditionalCheckFailedException">
        /// A condition specified in the operation failed to be evaluated.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ItemCollectionSizeLimitExceededException">
        /// An item collection is too large. This exception is only returned for tables that have
        /// one or more local secondary indexes.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. The Amazon Web Services SDKs for DynamoDB automatically
        /// retry requests that receive this exception. Your request is eventually successful,
        /// unless your retry queue is too large to finish. Reduce the frequency of requests and
        /// use exponential backoff. For more information, go to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Programming.Errors.html#Programming.Errors.RetryAndBackoff">Error
        /// Retries and Exponential Backoff</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ReplicatedWriteConflictException">
        /// The request was rejected because one or more items in the request are being modified
        /// by a request in another Region.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.RequestLimitExceededException">
        /// Throughput exceeds the current throughput quota for your account. For detailed information
        /// about why the request was throttled and the ARN of the impacted resource, find the
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. Contact <a href="https://aws.amazon.com/support">Amazon
        /// Web Services Support</a> to request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ThrottlingException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.TransactionConflictException">
        /// Operation was rejected because there is an ongoing transaction for the item.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/DeleteItem">REST API Reference for DeleteItem Operation</seealso>
        public virtual Task<DeleteItemResponse> DeleteItemAsync(string tableName, Dictionary<string, AttributeValue> key, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteItemRequest();
            request.TableName = tableName;
            request.Key = key;
            return DeleteItemAsync(request, cancellationToken);
        }


        /// <summary>
        /// Deletes a single item in a table by primary key. You can perform a conditional delete
        /// operation that deletes the item if it exists, or if it has an expected attribute value.
        /// 
        ///  
        /// <para>
        /// In addition to deleting an item, you can also return the item's attribute values in
        /// the same operation, using the <c>ReturnValues</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// Unless you specify conditions, the <c>DeleteItem</c> is an idempotent operation; running
        /// it multiple times on the same item or attribute does <i>not</i> result in an error
        /// response.
        /// </para>
        ///  
        /// <para>
        /// Conditional deletes are useful for deleting items only if specific conditions are
        /// met. If those conditions are met, DynamoDB performs the delete. Otherwise, the item
        /// is not deleted.
        /// </para>
        /// </summary>
        /// <param name="tableName">The name of the table from which to delete the item. You can also provide the Amazon Resource Name (ARN) of the table in this parameter.</param>
        /// <param name="key">A map of attribute names to <c>AttributeValue</c> objects, representing the primary key of the item to delete. For the primary key, you must provide all of the key attributes. For example, with a simple primary key, you only need to provide a value for the partition key. For a composite primary key, you must provide values for both the partition key and the sort key.</param>
        /// <param name="returnValues">Use <c>ReturnValues</c> if you want to get the item attributes as they appeared before they were deleted. For <c>DeleteItem</c>, the valid values are: <ul> <li>  <c>NONE</c> - If <c>ReturnValues</c> is not specified, or if its value is <c>NONE</c>, then nothing is returned. (This setting is the default for <c>ReturnValues</c>.) </li> <li>  <c>ALL_OLD</c> - The content of the old item is returned. </li> </ul> There is no additional cost associated with requesting a return value aside from the small network and processing overhead of receiving a larger response. No read capacity units are consumed. <note> The <c>ReturnValues</c> parameter is used by several DynamoDB operations; however, <c>DeleteItem</c> does not recognize any values other than <c>NONE</c> or <c>ALL_OLD</c>. </note></param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteItem service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.ConditionalCheckFailedException">
        /// A condition specified in the operation failed to be evaluated.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ItemCollectionSizeLimitExceededException">
        /// An item collection is too large. This exception is only returned for tables that have
        /// one or more local secondary indexes.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. The Amazon Web Services SDKs for DynamoDB automatically
        /// retry requests that receive this exception. Your request is eventually successful,
        /// unless your retry queue is too large to finish. Reduce the frequency of requests and
        /// use exponential backoff. For more information, go to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Programming.Errors.html#Programming.Errors.RetryAndBackoff">Error
        /// Retries and Exponential Backoff</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ReplicatedWriteConflictException">
        /// The request was rejected because one or more items in the request are being modified
        /// by a request in another Region.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.RequestLimitExceededException">
        /// Throughput exceeds the current throughput quota for your account. For detailed information
        /// about why the request was throttled and the ARN of the impacted resource, find the
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. Contact <a href="https://aws.amazon.com/support">Amazon
        /// Web Services Support</a> to request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ThrottlingException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.TransactionConflictException">
        /// Operation was rejected because there is an ongoing transaction for the item.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/DeleteItem">REST API Reference for DeleteItem Operation</seealso>
        public virtual Task<DeleteItemResponse> DeleteItemAsync(string tableName, Dictionary<string, AttributeValue> key, ReturnValue returnValues, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteItemRequest();
            request.TableName = tableName;
            request.Key = key;
            request.ReturnValues = returnValues;
            return DeleteItemAsync(request, cancellationToken);
        }


        /// <summary>
        /// Deletes a single item in a table by primary key. You can perform a conditional delete
        /// operation that deletes the item if it exists, or if it has an expected attribute value.
        /// 
        ///  
        /// <para>
        /// In addition to deleting an item, you can also return the item's attribute values in
        /// the same operation, using the <c>ReturnValues</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// Unless you specify conditions, the <c>DeleteItem</c> is an idempotent operation; running
        /// it multiple times on the same item or attribute does <i>not</i> result in an error
        /// response.
        /// </para>
        ///  
        /// <para>
        /// Conditional deletes are useful for deleting items only if specific conditions are
        /// met. If those conditions are met, DynamoDB performs the delete. Otherwise, the item
        /// is not deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteItem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteItem service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.ConditionalCheckFailedException">
        /// A condition specified in the operation failed to be evaluated.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ItemCollectionSizeLimitExceededException">
        /// An item collection is too large. This exception is only returned for tables that have
        /// one or more local secondary indexes.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. The Amazon Web Services SDKs for DynamoDB automatically
        /// retry requests that receive this exception. Your request is eventually successful,
        /// unless your retry queue is too large to finish. Reduce the frequency of requests and
        /// use exponential backoff. For more information, go to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Programming.Errors.html#Programming.Errors.RetryAndBackoff">Error
        /// Retries and Exponential Backoff</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ReplicatedWriteConflictException">
        /// The request was rejected because one or more items in the request are being modified
        /// by a request in another Region.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.RequestLimitExceededException">
        /// Throughput exceeds the current throughput quota for your account. For detailed information
        /// about why the request was throttled and the ARN of the impacted resource, find the
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. Contact <a href="https://aws.amazon.com/support">Amazon
        /// Web Services Support</a> to request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ThrottlingException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.TransactionConflictException">
        /// Operation was rejected because there is an ongoing transaction for the item.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/DeleteItem">REST API Reference for DeleteItem Operation</seealso>
        public virtual Task<DeleteItemResponse> DeleteItemAsync(DeleteItemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteItemResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = DeleteItemEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;
            
            return InvokeAsync<DeleteItemResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteResourcePolicy


        /// <summary>
        /// Deletes the resource-based policy attached to the resource, which can be a table or
        /// stream.
        /// 
        ///  
        /// <para>
        ///  <c>DeleteResourcePolicy</c> is an idempotent operation; running it multiple times
        /// on the same resource <i>doesn't</i> result in an error response, unless you specify
        /// an <c>ExpectedRevisionId</c>, which will then return a <c>PolicyNotFoundException</c>.
        /// </para>
        ///  <important> 
        /// <para>
        /// To make sure that you don't inadvertently lock yourself out of your own resources,
        /// the root principal in your Amazon Web Services account can perform <c>DeleteResourcePolicy</c>
        /// requests, even if your resource-based policy explicitly denies the root principal's
        /// access. 
        /// </para>
        ///  </important> <note> 
        /// <para>
        ///  <c>DeleteResourcePolicy</c> is an asynchronous operation. If you issue a <c>GetResourcePolicy</c>
        /// request immediately after running the <c>DeleteResourcePolicy</c> request, DynamoDB
        /// might still return the deleted policy. This is because the policy for your resource
        /// might not have been deleted yet. Wait for a few seconds, and then try the <c>GetResourcePolicy</c>
        /// request again.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteResourcePolicy service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.LimitExceededException">
        /// There is no limit to the number of daily on-demand backups that can be taken. 
        /// 
        ///  
        /// <para>
        /// For most purposes, up to 500 simultaneous table operations are allowed per account.
        /// These operations include <c>CreateTable</c>, <c>UpdateTable</c>, <c>DeleteTable</c>,<c>UpdateTimeToLive</c>,
        /// <c>RestoreTableFromBackup</c>, and <c>RestoreTableToPointInTime</c>. 
        /// </para>
        ///  
        /// <para>
        /// When you are creating a table with one or more secondary indexes, you can have up
        /// to 250 such requests running at a time. However, if the table or index specifications
        /// are complex, then DynamoDB might temporarily reduce the number of concurrent operations.
        /// </para>
        ///  
        /// <para>
        /// When importing into DynamoDB, up to 50 simultaneous import table operations are allowed
        /// per account.
        /// </para>
        ///  
        /// <para>
        /// There is a soft account quota of 2,500 tables.
        /// </para>
        ///  
        /// <para>
        /// GetRecords was called with a value of more than 1000 for the limit request parameter.
        /// </para>
        ///  
        /// <para>
        /// More than 2 processes are reading from the same streams shard at the same time. Exceeding
        /// this limit may result in request throttling.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.PolicyNotFoundException">
        /// The operation tried to access a nonexistent resource-based policy.
        /// 
        ///  
        /// <para>
        /// If you specified an <c>ExpectedRevisionId</c>, it's possible that a policy is present
        /// for the resource but its revision ID didn't match the expected value.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceInUseException">
        /// The operation conflicts with the resource's availability. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You attempted to recreate an existing table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a table currently in the <c>CREATING</c> state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a resource that was already being updated.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When appropriate, wait for the ongoing update to complete and attempt the request
        /// again.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        public virtual DeleteResourcePolicyResponse DeleteResourcePolicy(DeleteResourcePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = DeleteResourcePolicyEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<DeleteResourcePolicyResponse>(request, options);
        }


        /// <summary>
        /// Deletes the resource-based policy attached to the resource, which can be a table or
        /// stream.
        /// 
        ///  
        /// <para>
        ///  <c>DeleteResourcePolicy</c> is an idempotent operation; running it multiple times
        /// on the same resource <i>doesn't</i> result in an error response, unless you specify
        /// an <c>ExpectedRevisionId</c>, which will then return a <c>PolicyNotFoundException</c>.
        /// </para>
        ///  <important> 
        /// <para>
        /// To make sure that you don't inadvertently lock yourself out of your own resources,
        /// the root principal in your Amazon Web Services account can perform <c>DeleteResourcePolicy</c>
        /// requests, even if your resource-based policy explicitly denies the root principal's
        /// access. 
        /// </para>
        ///  </important> <note> 
        /// <para>
        ///  <c>DeleteResourcePolicy</c> is an asynchronous operation. If you issue a <c>GetResourcePolicy</c>
        /// request immediately after running the <c>DeleteResourcePolicy</c> request, DynamoDB
        /// might still return the deleted policy. This is because the policy for your resource
        /// might not have been deleted yet. Wait for a few seconds, and then try the <c>GetResourcePolicy</c>
        /// request again.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteResourcePolicy service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.LimitExceededException">
        /// There is no limit to the number of daily on-demand backups that can be taken. 
        /// 
        ///  
        /// <para>
        /// For most purposes, up to 500 simultaneous table operations are allowed per account.
        /// These operations include <c>CreateTable</c>, <c>UpdateTable</c>, <c>DeleteTable</c>,<c>UpdateTimeToLive</c>,
        /// <c>RestoreTableFromBackup</c>, and <c>RestoreTableToPointInTime</c>. 
        /// </para>
        ///  
        /// <para>
        /// When you are creating a table with one or more secondary indexes, you can have up
        /// to 250 such requests running at a time. However, if the table or index specifications
        /// are complex, then DynamoDB might temporarily reduce the number of concurrent operations.
        /// </para>
        ///  
        /// <para>
        /// When importing into DynamoDB, up to 50 simultaneous import table operations are allowed
        /// per account.
        /// </para>
        ///  
        /// <para>
        /// There is a soft account quota of 2,500 tables.
        /// </para>
        ///  
        /// <para>
        /// GetRecords was called with a value of more than 1000 for the limit request parameter.
        /// </para>
        ///  
        /// <para>
        /// More than 2 processes are reading from the same streams shard at the same time. Exceeding
        /// this limit may result in request throttling.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.PolicyNotFoundException">
        /// The operation tried to access a nonexistent resource-based policy.
        /// 
        ///  
        /// <para>
        /// If you specified an <c>ExpectedRevisionId</c>, it's possible that a policy is present
        /// for the resource but its revision ID didn't match the expected value.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceInUseException">
        /// The operation conflicts with the resource's availability. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You attempted to recreate an existing table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a table currently in the <c>CREATING</c> state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a resource that was already being updated.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When appropriate, wait for the ongoing update to complete and attempt the request
        /// again.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        public virtual Task<DeleteResourcePolicyResponse> DeleteResourcePolicyAsync(DeleteResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = DeleteResourcePolicyEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;
            
            return InvokeAsync<DeleteResourcePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTable


        /// <summary>
        /// The <c>DeleteTable</c> operation deletes a table and all of its items. After a <c>DeleteTable</c>
        /// request, the specified table is in the <c>DELETING</c> state until DynamoDB completes
        /// the deletion. If the table is in the <c>ACTIVE</c> state, you can delete it. If a
        /// table is in <c>CREATING</c> or <c>UPDATING</c> states, then DynamoDB returns a <c>ResourceInUseException</c>.
        /// If the specified table does not exist, DynamoDB returns a <c>ResourceNotFoundException</c>.
        /// If table is already in the <c>DELETING</c> state, no error is returned. 
        /// 
        ///  <note> 
        /// <para>
        /// DynamoDB might continue to accept data read and write operations, such as <c>GetItem</c>
        /// and <c>PutItem</c>, on a table in the <c>DELETING</c> state until the table deletion
        /// is complete. For the full list of table states, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_TableDescription.html#DDB-Type-TableDescription-TableStatus">TableStatus</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// When you delete a table, any indexes on that table are also deleted.
        /// </para>
        ///  
        /// <para>
        /// If you have DynamoDB Streams enabled on the table, then the corresponding stream on
        /// that table goes into the <c>DISABLED</c> state, and the stream is automatically deleted
        /// after 24 hours.
        /// </para>
        ///  
        /// <para>
        /// Use the <c>DescribeTable</c> action to check the status of the table. 
        /// </para>
        /// </summary>
        /// <param name="tableName">The name of the table to delete. You can also provide the Amazon Resource Name (ARN) of the table in this parameter.</param>
        /// 
        /// <returns>The response from the DeleteTable service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.LimitExceededException">
        /// There is no limit to the number of daily on-demand backups that can be taken. 
        /// 
        ///  
        /// <para>
        /// For most purposes, up to 500 simultaneous table operations are allowed per account.
        /// These operations include <c>CreateTable</c>, <c>UpdateTable</c>, <c>DeleteTable</c>,<c>UpdateTimeToLive</c>,
        /// <c>RestoreTableFromBackup</c>, and <c>RestoreTableToPointInTime</c>. 
        /// </para>
        ///  
        /// <para>
        /// When you are creating a table with one or more secondary indexes, you can have up
        /// to 250 such requests running at a time. However, if the table or index specifications
        /// are complex, then DynamoDB might temporarily reduce the number of concurrent operations.
        /// </para>
        ///  
        /// <para>
        /// When importing into DynamoDB, up to 50 simultaneous import table operations are allowed
        /// per account.
        /// </para>
        ///  
        /// <para>
        /// There is a soft account quota of 2,500 tables.
        /// </para>
        ///  
        /// <para>
        /// GetRecords was called with a value of more than 1000 for the limit request parameter.
        /// </para>
        ///  
        /// <para>
        /// More than 2 processes are reading from the same streams shard at the same time. Exceeding
        /// this limit may result in request throttling.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceInUseException">
        /// The operation conflicts with the resource's availability. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You attempted to recreate an existing table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a table currently in the <c>CREATING</c> state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a resource that was already being updated.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When appropriate, wait for the ongoing update to complete and attempt the request
        /// again.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/DeleteTable">REST API Reference for DeleteTable Operation</seealso>
        public virtual DeleteTableResponse DeleteTable(string tableName)
        {
            var request = new DeleteTableRequest();
            request.TableName = tableName;
            return DeleteTable(request);
        }


        /// <summary>
        /// The <c>DeleteTable</c> operation deletes a table and all of its items. After a <c>DeleteTable</c>
        /// request, the specified table is in the <c>DELETING</c> state until DynamoDB completes
        /// the deletion. If the table is in the <c>ACTIVE</c> state, you can delete it. If a
        /// table is in <c>CREATING</c> or <c>UPDATING</c> states, then DynamoDB returns a <c>ResourceInUseException</c>.
        /// If the specified table does not exist, DynamoDB returns a <c>ResourceNotFoundException</c>.
        /// If table is already in the <c>DELETING</c> state, no error is returned. 
        /// 
        ///  <note> 
        /// <para>
        /// DynamoDB might continue to accept data read and write operations, such as <c>GetItem</c>
        /// and <c>PutItem</c>, on a table in the <c>DELETING</c> state until the table deletion
        /// is complete. For the full list of table states, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_TableDescription.html#DDB-Type-TableDescription-TableStatus">TableStatus</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// When you delete a table, any indexes on that table are also deleted.
        /// </para>
        ///  
        /// <para>
        /// If you have DynamoDB Streams enabled on the table, then the corresponding stream on
        /// that table goes into the <c>DISABLED</c> state, and the stream is automatically deleted
        /// after 24 hours.
        /// </para>
        ///  
        /// <para>
        /// Use the <c>DescribeTable</c> action to check the status of the table. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTable service method.</param>
        /// 
        /// <returns>The response from the DeleteTable service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.LimitExceededException">
        /// There is no limit to the number of daily on-demand backups that can be taken. 
        /// 
        ///  
        /// <para>
        /// For most purposes, up to 500 simultaneous table operations are allowed per account.
        /// These operations include <c>CreateTable</c>, <c>UpdateTable</c>, <c>DeleteTable</c>,<c>UpdateTimeToLive</c>,
        /// <c>RestoreTableFromBackup</c>, and <c>RestoreTableToPointInTime</c>. 
        /// </para>
        ///  
        /// <para>
        /// When you are creating a table with one or more secondary indexes, you can have up
        /// to 250 such requests running at a time. However, if the table or index specifications
        /// are complex, then DynamoDB might temporarily reduce the number of concurrent operations.
        /// </para>
        ///  
        /// <para>
        /// When importing into DynamoDB, up to 50 simultaneous import table operations are allowed
        /// per account.
        /// </para>
        ///  
        /// <para>
        /// There is a soft account quota of 2,500 tables.
        /// </para>
        ///  
        /// <para>
        /// GetRecords was called with a value of more than 1000 for the limit request parameter.
        /// </para>
        ///  
        /// <para>
        /// More than 2 processes are reading from the same streams shard at the same time. Exceeding
        /// this limit may result in request throttling.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceInUseException">
        /// The operation conflicts with the resource's availability. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You attempted to recreate an existing table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a table currently in the <c>CREATING</c> state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a resource that was already being updated.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When appropriate, wait for the ongoing update to complete and attempt the request
        /// again.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/DeleteTable">REST API Reference for DeleteTable Operation</seealso>
        public virtual DeleteTableResponse DeleteTable(DeleteTableRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTableResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = DeleteTableEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<DeleteTableResponse>(request, options);
        }


        /// <summary>
        /// The <c>DeleteTable</c> operation deletes a table and all of its items. After a <c>DeleteTable</c>
        /// request, the specified table is in the <c>DELETING</c> state until DynamoDB completes
        /// the deletion. If the table is in the <c>ACTIVE</c> state, you can delete it. If a
        /// table is in <c>CREATING</c> or <c>UPDATING</c> states, then DynamoDB returns a <c>ResourceInUseException</c>.
        /// If the specified table does not exist, DynamoDB returns a <c>ResourceNotFoundException</c>.
        /// If table is already in the <c>DELETING</c> state, no error is returned. 
        /// 
        ///  <note> 
        /// <para>
        /// DynamoDB might continue to accept data read and write operations, such as <c>GetItem</c>
        /// and <c>PutItem</c>, on a table in the <c>DELETING</c> state until the table deletion
        /// is complete. For the full list of table states, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_TableDescription.html#DDB-Type-TableDescription-TableStatus">TableStatus</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// When you delete a table, any indexes on that table are also deleted.
        /// </para>
        ///  
        /// <para>
        /// If you have DynamoDB Streams enabled on the table, then the corresponding stream on
        /// that table goes into the <c>DISABLED</c> state, and the stream is automatically deleted
        /// after 24 hours.
        /// </para>
        ///  
        /// <para>
        /// Use the <c>DescribeTable</c> action to check the status of the table. 
        /// </para>
        /// </summary>
        /// <param name="tableName">The name of the table to delete. You can also provide the Amazon Resource Name (ARN) of the table in this parameter.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTable service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.LimitExceededException">
        /// There is no limit to the number of daily on-demand backups that can be taken. 
        /// 
        ///  
        /// <para>
        /// For most purposes, up to 500 simultaneous table operations are allowed per account.
        /// These operations include <c>CreateTable</c>, <c>UpdateTable</c>, <c>DeleteTable</c>,<c>UpdateTimeToLive</c>,
        /// <c>RestoreTableFromBackup</c>, and <c>RestoreTableToPointInTime</c>. 
        /// </para>
        ///  
        /// <para>
        /// When you are creating a table with one or more secondary indexes, you can have up
        /// to 250 such requests running at a time. However, if the table or index specifications
        /// are complex, then DynamoDB might temporarily reduce the number of concurrent operations.
        /// </para>
        ///  
        /// <para>
        /// When importing into DynamoDB, up to 50 simultaneous import table operations are allowed
        /// per account.
        /// </para>
        ///  
        /// <para>
        /// There is a soft account quota of 2,500 tables.
        /// </para>
        ///  
        /// <para>
        /// GetRecords was called with a value of more than 1000 for the limit request parameter.
        /// </para>
        ///  
        /// <para>
        /// More than 2 processes are reading from the same streams shard at the same time. Exceeding
        /// this limit may result in request throttling.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceInUseException">
        /// The operation conflicts with the resource's availability. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You attempted to recreate an existing table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a table currently in the <c>CREATING</c> state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a resource that was already being updated.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When appropriate, wait for the ongoing update to complete and attempt the request
        /// again.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/DeleteTable">REST API Reference for DeleteTable Operation</seealso>
        public virtual Task<DeleteTableResponse> DeleteTableAsync(string tableName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteTableRequest();
            request.TableName = tableName;
            return DeleteTableAsync(request, cancellationToken);
        }


        /// <summary>
        /// The <c>DeleteTable</c> operation deletes a table and all of its items. After a <c>DeleteTable</c>
        /// request, the specified table is in the <c>DELETING</c> state until DynamoDB completes
        /// the deletion. If the table is in the <c>ACTIVE</c> state, you can delete it. If a
        /// table is in <c>CREATING</c> or <c>UPDATING</c> states, then DynamoDB returns a <c>ResourceInUseException</c>.
        /// If the specified table does not exist, DynamoDB returns a <c>ResourceNotFoundException</c>.
        /// If table is already in the <c>DELETING</c> state, no error is returned. 
        /// 
        ///  <note> 
        /// <para>
        /// DynamoDB might continue to accept data read and write operations, such as <c>GetItem</c>
        /// and <c>PutItem</c>, on a table in the <c>DELETING</c> state until the table deletion
        /// is complete. For the full list of table states, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_TableDescription.html#DDB-Type-TableDescription-TableStatus">TableStatus</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// When you delete a table, any indexes on that table are also deleted.
        /// </para>
        ///  
        /// <para>
        /// If you have DynamoDB Streams enabled on the table, then the corresponding stream on
        /// that table goes into the <c>DISABLED</c> state, and the stream is automatically deleted
        /// after 24 hours.
        /// </para>
        ///  
        /// <para>
        /// Use the <c>DescribeTable</c> action to check the status of the table. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTable service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.LimitExceededException">
        /// There is no limit to the number of daily on-demand backups that can be taken. 
        /// 
        ///  
        /// <para>
        /// For most purposes, up to 500 simultaneous table operations are allowed per account.
        /// These operations include <c>CreateTable</c>, <c>UpdateTable</c>, <c>DeleteTable</c>,<c>UpdateTimeToLive</c>,
        /// <c>RestoreTableFromBackup</c>, and <c>RestoreTableToPointInTime</c>. 
        /// </para>
        ///  
        /// <para>
        /// When you are creating a table with one or more secondary indexes, you can have up
        /// to 250 such requests running at a time. However, if the table or index specifications
        /// are complex, then DynamoDB might temporarily reduce the number of concurrent operations.
        /// </para>
        ///  
        /// <para>
        /// When importing into DynamoDB, up to 50 simultaneous import table operations are allowed
        /// per account.
        /// </para>
        ///  
        /// <para>
        /// There is a soft account quota of 2,500 tables.
        /// </para>
        ///  
        /// <para>
        /// GetRecords was called with a value of more than 1000 for the limit request parameter.
        /// </para>
        ///  
        /// <para>
        /// More than 2 processes are reading from the same streams shard at the same time. Exceeding
        /// this limit may result in request throttling.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceInUseException">
        /// The operation conflicts with the resource's availability. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You attempted to recreate an existing table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a table currently in the <c>CREATING</c> state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a resource that was already being updated.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When appropriate, wait for the ongoing update to complete and attempt the request
        /// again.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/DeleteTable">REST API Reference for DeleteTable Operation</seealso>
        public virtual Task<DeleteTableResponse> DeleteTableAsync(DeleteTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTableResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = DeleteTableEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;
            
            return InvokeAsync<DeleteTableResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeBackup


        /// <summary>
        /// Describes an existing backup of a table.
        /// 
        ///  
        /// <para>
        /// You can call <c>DescribeBackup</c> at a maximum rate of 10 times per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBackup service method.</param>
        /// 
        /// <returns>The response from the DescribeBackup service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.BackupNotFoundException">
        /// Backup not found for the given BackupARN.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/DescribeBackup">REST API Reference for DescribeBackup Operation</seealso>
        public virtual DescribeBackupResponse DescribeBackup(DescribeBackupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeBackupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBackupResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = DescribeBackupEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<DescribeBackupResponse>(request, options);
        }


        /// <summary>
        /// Describes an existing backup of a table.
        /// 
        ///  
        /// <para>
        /// You can call <c>DescribeBackup</c> at a maximum rate of 10 times per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBackup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeBackup service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.BackupNotFoundException">
        /// Backup not found for the given BackupARN.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/DescribeBackup">REST API Reference for DescribeBackup Operation</seealso>
        public virtual Task<DescribeBackupResponse> DescribeBackupAsync(DescribeBackupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeBackupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBackupResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = DescribeBackupEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;
            
            return InvokeAsync<DescribeBackupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeContinuousBackups


        /// <summary>
        /// Checks the status of continuous backups and point in time recovery on the specified
        /// table. Continuous backups are <c>ENABLED</c> on all tables at table creation. If point
        /// in time recovery is enabled, <c>PointInTimeRecoveryStatus</c> will be set to ENABLED.
        /// 
        ///  
        /// <para>
        ///  After continuous backups and point in time recovery are enabled, you can restore
        /// to any point in time within <c>EarliestRestorableDateTime</c> and <c>LatestRestorableDateTime</c>.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <c>LatestRestorableDateTime</c> is typically 5 minutes before the current time. You
        /// can restore your table to any point in time in the last 35 days. You can set the recovery
        /// period to any value between 1 and 35 days. 
        /// </para>
        ///  
        /// <para>
        /// You can call <c>DescribeContinuousBackups</c> at a maximum rate of 10 times per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeContinuousBackups service method.</param>
        /// 
        /// <returns>The response from the DescribeContinuousBackups service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.TableNotFoundException">
        /// A source table with the name <c>TableName</c> does not currently exist within the
        /// subscriber's account or the subscriber is operating in the wrong Amazon Web Services
        /// Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/DescribeContinuousBackups">REST API Reference for DescribeContinuousBackups Operation</seealso>
        public virtual DescribeContinuousBackupsResponse DescribeContinuousBackups(DescribeContinuousBackupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeContinuousBackupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeContinuousBackupsResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = DescribeContinuousBackupsEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<DescribeContinuousBackupsResponse>(request, options);
        }


        /// <summary>
        /// Checks the status of continuous backups and point in time recovery on the specified
        /// table. Continuous backups are <c>ENABLED</c> on all tables at table creation. If point
        /// in time recovery is enabled, <c>PointInTimeRecoveryStatus</c> will be set to ENABLED.
        /// 
        ///  
        /// <para>
        ///  After continuous backups and point in time recovery are enabled, you can restore
        /// to any point in time within <c>EarliestRestorableDateTime</c> and <c>LatestRestorableDateTime</c>.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <c>LatestRestorableDateTime</c> is typically 5 minutes before the current time. You
        /// can restore your table to any point in time in the last 35 days. You can set the recovery
        /// period to any value between 1 and 35 days. 
        /// </para>
        ///  
        /// <para>
        /// You can call <c>DescribeContinuousBackups</c> at a maximum rate of 10 times per second.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeContinuousBackups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeContinuousBackups service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.TableNotFoundException">
        /// A source table with the name <c>TableName</c> does not currently exist within the
        /// subscriber's account or the subscriber is operating in the wrong Amazon Web Services
        /// Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/DescribeContinuousBackups">REST API Reference for DescribeContinuousBackups Operation</seealso>
        public virtual Task<DescribeContinuousBackupsResponse> DescribeContinuousBackupsAsync(DescribeContinuousBackupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeContinuousBackupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeContinuousBackupsResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = DescribeContinuousBackupsEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;
            
            return InvokeAsync<DescribeContinuousBackupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeContributorInsights


        /// <summary>
        /// Returns information about contributor insights for a given table or global secondary
        /// index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeContributorInsights service method.</param>
        /// 
        /// <returns>The response from the DescribeContributorInsights service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/DescribeContributorInsights">REST API Reference for DescribeContributorInsights Operation</seealso>
        public virtual DescribeContributorInsightsResponse DescribeContributorInsights(DescribeContributorInsightsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeContributorInsightsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeContributorInsightsResponseUnmarshaller.Instance;

            return Invoke<DescribeContributorInsightsResponse>(request, options);
        }


        /// <summary>
        /// Returns information about contributor insights for a given table or global secondary
        /// index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeContributorInsights service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeContributorInsights service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/DescribeContributorInsights">REST API Reference for DescribeContributorInsights Operation</seealso>
        public virtual Task<DescribeContributorInsightsResponse> DescribeContributorInsightsAsync(DescribeContributorInsightsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeContributorInsightsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeContributorInsightsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeContributorInsightsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEndpoints


        /// <summary>
        /// Returns the regional endpoint information. For more information on policy permissions,
        /// please see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/inter-network-traffic-privacy.html#inter-network-traffic-DescribeEndpoints">Internetwork
        /// traffic privacy</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpoints service method.</param>
        /// 
        /// <returns>The response from the DescribeEndpoints service method, as returned by DynamoDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/DescribeEndpoints">REST API Reference for DescribeEndpoints Operation</seealso>
        public virtual DescribeEndpointsResponse DescribeEndpoints(DescribeEndpointsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEndpointsResponseUnmarshaller.Instance;

            return Invoke<DescribeEndpointsResponse>(request, options);
        }


        /// <summary>
        /// Returns the regional endpoint information. For more information on policy permissions,
        /// please see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/inter-network-traffic-privacy.html#inter-network-traffic-DescribeEndpoints">Internetwork
        /// traffic privacy</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEndpoints service method, as returned by DynamoDB.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/DescribeEndpoints">REST API Reference for DescribeEndpoints Operation</seealso>
        public virtual Task<DescribeEndpointsResponse> DescribeEndpointsAsync(DescribeEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEndpointsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeEndpointsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeExport


        /// <summary>
        /// Describes an existing table export.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeExport service method.</param>
        /// 
        /// <returns>The response from the DescribeExport service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.ExportNotFoundException">
        /// The specified export was not found.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.LimitExceededException">
        /// There is no limit to the number of daily on-demand backups that can be taken. 
        /// 
        ///  
        /// <para>
        /// For most purposes, up to 500 simultaneous table operations are allowed per account.
        /// These operations include <c>CreateTable</c>, <c>UpdateTable</c>, <c>DeleteTable</c>,<c>UpdateTimeToLive</c>,
        /// <c>RestoreTableFromBackup</c>, and <c>RestoreTableToPointInTime</c>. 
        /// </para>
        ///  
        /// <para>
        /// When you are creating a table with one or more secondary indexes, you can have up
        /// to 250 such requests running at a time. However, if the table or index specifications
        /// are complex, then DynamoDB might temporarily reduce the number of concurrent operations.
        /// </para>
        ///  
        /// <para>
        /// When importing into DynamoDB, up to 50 simultaneous import table operations are allowed
        /// per account.
        /// </para>
        ///  
        /// <para>
        /// There is a soft account quota of 2,500 tables.
        /// </para>
        ///  
        /// <para>
        /// GetRecords was called with a value of more than 1000 for the limit request parameter.
        /// </para>
        ///  
        /// <para>
        /// More than 2 processes are reading from the same streams shard at the same time. Exceeding
        /// this limit may result in request throttling.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/DescribeExport">REST API Reference for DescribeExport Operation</seealso>
        public virtual DescribeExportResponse DescribeExport(DescribeExportRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeExportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeExportResponseUnmarshaller.Instance;

            return Invoke<DescribeExportResponse>(request, options);
        }


        /// <summary>
        /// Describes an existing table export.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeExport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeExport service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.ExportNotFoundException">
        /// The specified export was not found.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.LimitExceededException">
        /// There is no limit to the number of daily on-demand backups that can be taken. 
        /// 
        ///  
        /// <para>
        /// For most purposes, up to 500 simultaneous table operations are allowed per account.
        /// These operations include <c>CreateTable</c>, <c>UpdateTable</c>, <c>DeleteTable</c>,<c>UpdateTimeToLive</c>,
        /// <c>RestoreTableFromBackup</c>, and <c>RestoreTableToPointInTime</c>. 
        /// </para>
        ///  
        /// <para>
        /// When you are creating a table with one or more secondary indexes, you can have up
        /// to 250 such requests running at a time. However, if the table or index specifications
        /// are complex, then DynamoDB might temporarily reduce the number of concurrent operations.
        /// </para>
        ///  
        /// <para>
        /// When importing into DynamoDB, up to 50 simultaneous import table operations are allowed
        /// per account.
        /// </para>
        ///  
        /// <para>
        /// There is a soft account quota of 2,500 tables.
        /// </para>
        ///  
        /// <para>
        /// GetRecords was called with a value of more than 1000 for the limit request parameter.
        /// </para>
        ///  
        /// <para>
        /// More than 2 processes are reading from the same streams shard at the same time. Exceeding
        /// this limit may result in request throttling.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/DescribeExport">REST API Reference for DescribeExport Operation</seealso>
        public virtual Task<DescribeExportResponse> DescribeExportAsync(DescribeExportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeExportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeExportResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeExportResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeGlobalTable


        /// <summary>
        /// Returns information about the specified global table.
        /// 
        ///  <important> 
        /// <para>
        /// This documentation is for version 2017.11.29 (Legacy) of global tables, which should
        /// be avoided for new global tables. Customers should use <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/GlobalTables.html">Global
        /// Tables version 2019.11.21 (Current)</a> when possible, because it provides greater
        /// flexibility, higher efficiency, and consumes less write capacity than 2017.11.29 (Legacy).
        /// </para>
        ///  
        /// <para>
        /// To determine which version you're using, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/globaltables.DetermineVersion.html">Determining
        /// the global table version you are using</a>. To update existing global tables from
        /// version 2017.11.29 (Legacy) to version 2019.11.21 (Current), see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/V2globaltables_upgrade.html">Upgrading
        /// global tables</a>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGlobalTable service method.</param>
        /// 
        /// <returns>The response from the DescribeGlobalTable service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.GlobalTableNotFoundException">
        /// The specified global table does not exist.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/DescribeGlobalTable">REST API Reference for DescribeGlobalTable Operation</seealso>
        public virtual DescribeGlobalTableResponse DescribeGlobalTable(DescribeGlobalTableRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeGlobalTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGlobalTableResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = DescribeGlobalTableEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<DescribeGlobalTableResponse>(request, options);
        }


        /// <summary>
        /// Returns information about the specified global table.
        /// 
        ///  <important> 
        /// <para>
        /// This documentation is for version 2017.11.29 (Legacy) of global tables, which should
        /// be avoided for new global tables. Customers should use <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/GlobalTables.html">Global
        /// Tables version 2019.11.21 (Current)</a> when possible, because it provides greater
        /// flexibility, higher efficiency, and consumes less write capacity than 2017.11.29 (Legacy).
        /// </para>
        ///  
        /// <para>
        /// To determine which version you're using, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/globaltables.DetermineVersion.html">Determining
        /// the global table version you are using</a>. To update existing global tables from
        /// version 2017.11.29 (Legacy) to version 2019.11.21 (Current), see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/V2globaltables_upgrade.html">Upgrading
        /// global tables</a>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGlobalTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeGlobalTable service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.GlobalTableNotFoundException">
        /// The specified global table does not exist.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/DescribeGlobalTable">REST API Reference for DescribeGlobalTable Operation</seealso>
        public virtual Task<DescribeGlobalTableResponse> DescribeGlobalTableAsync(DescribeGlobalTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeGlobalTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGlobalTableResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = DescribeGlobalTableEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;
            
            return InvokeAsync<DescribeGlobalTableResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeGlobalTableSettings


        /// <summary>
        /// Describes Region-specific settings for a global table.
        /// 
        ///  <important> 
        /// <para>
        /// This documentation is for version 2017.11.29 (Legacy) of global tables, which should
        /// be avoided for new global tables. Customers should use <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/GlobalTables.html">Global
        /// Tables version 2019.11.21 (Current)</a> when possible, because it provides greater
        /// flexibility, higher efficiency, and consumes less write capacity than 2017.11.29 (Legacy).
        /// </para>
        ///  
        /// <para>
        /// To determine which version you're using, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/globaltables.DetermineVersion.html">Determining
        /// the global table version you are using</a>. To update existing global tables from
        /// version 2017.11.29 (Legacy) to version 2019.11.21 (Current), see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/V2globaltables_upgrade.html">Upgrading
        /// global tables</a>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGlobalTableSettings service method.</param>
        /// 
        /// <returns>The response from the DescribeGlobalTableSettings service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.GlobalTableNotFoundException">
        /// The specified global table does not exist.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/DescribeGlobalTableSettings">REST API Reference for DescribeGlobalTableSettings Operation</seealso>
        public virtual DescribeGlobalTableSettingsResponse DescribeGlobalTableSettings(DescribeGlobalTableSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeGlobalTableSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGlobalTableSettingsResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = DescribeGlobalTableSettingsEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<DescribeGlobalTableSettingsResponse>(request, options);
        }


        /// <summary>
        /// Describes Region-specific settings for a global table.
        /// 
        ///  <important> 
        /// <para>
        /// This documentation is for version 2017.11.29 (Legacy) of global tables, which should
        /// be avoided for new global tables. Customers should use <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/GlobalTables.html">Global
        /// Tables version 2019.11.21 (Current)</a> when possible, because it provides greater
        /// flexibility, higher efficiency, and consumes less write capacity than 2017.11.29 (Legacy).
        /// </para>
        ///  
        /// <para>
        /// To determine which version you're using, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/globaltables.DetermineVersion.html">Determining
        /// the global table version you are using</a>. To update existing global tables from
        /// version 2017.11.29 (Legacy) to version 2019.11.21 (Current), see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/V2globaltables_upgrade.html">Upgrading
        /// global tables</a>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGlobalTableSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeGlobalTableSettings service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.GlobalTableNotFoundException">
        /// The specified global table does not exist.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/DescribeGlobalTableSettings">REST API Reference for DescribeGlobalTableSettings Operation</seealso>
        public virtual Task<DescribeGlobalTableSettingsResponse> DescribeGlobalTableSettingsAsync(DescribeGlobalTableSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeGlobalTableSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGlobalTableSettingsResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = DescribeGlobalTableSettingsEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;
            
            return InvokeAsync<DescribeGlobalTableSettingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeImport


        /// <summary>
        /// Represents the properties of the import.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeImport service method.</param>
        /// 
        /// <returns>The response from the DescribeImport service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.ImportNotFoundException">
        /// The specified import was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/DescribeImport">REST API Reference for DescribeImport Operation</seealso>
        public virtual DescribeImportResponse DescribeImport(DescribeImportRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeImportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeImportResponseUnmarshaller.Instance;

            return Invoke<DescribeImportResponse>(request, options);
        }


        /// <summary>
        /// Represents the properties of the import.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeImport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeImport service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.ImportNotFoundException">
        /// The specified import was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/DescribeImport">REST API Reference for DescribeImport Operation</seealso>
        public virtual Task<DescribeImportResponse> DescribeImportAsync(DescribeImportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeImportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeImportResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeImportResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeKinesisStreamingDestination


        /// <summary>
        /// Returns information about the status of Kinesis streaming.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeKinesisStreamingDestination service method.</param>
        /// 
        /// <returns>The response from the DescribeKinesisStreamingDestination service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/DescribeKinesisStreamingDestination">REST API Reference for DescribeKinesisStreamingDestination Operation</seealso>
        public virtual DescribeKinesisStreamingDestinationResponse DescribeKinesisStreamingDestination(DescribeKinesisStreamingDestinationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeKinesisStreamingDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeKinesisStreamingDestinationResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = DescribeKinesisStreamingDestinationEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<DescribeKinesisStreamingDestinationResponse>(request, options);
        }


        /// <summary>
        /// Returns information about the status of Kinesis streaming.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeKinesisStreamingDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeKinesisStreamingDestination service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/DescribeKinesisStreamingDestination">REST API Reference for DescribeKinesisStreamingDestination Operation</seealso>
        public virtual Task<DescribeKinesisStreamingDestinationResponse> DescribeKinesisStreamingDestinationAsync(DescribeKinesisStreamingDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeKinesisStreamingDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeKinesisStreamingDestinationResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = DescribeKinesisStreamingDestinationEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;
            
            return InvokeAsync<DescribeKinesisStreamingDestinationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLimits


        /// <summary>
        /// Returns the current provisioned-capacity quotas for your Amazon Web Services account
        /// in a Region, both for the Region as a whole and for any one DynamoDB table that you
        /// create there.
        /// 
        ///  
        /// <para>
        /// When you establish an Amazon Web Services account, the account has initial quotas
        /// on the maximum read capacity units and write capacity units that you can provision
        /// across all of your DynamoDB tables in a given Region. Also, there are per-table quotas
        /// that apply when you create a table there. For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Limits.html">Service,
        /// Account, and Table Quotas</a> page in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Although you can increase these quotas by filing a case at <a href="https://console.aws.amazon.com/support/home#/">Amazon
        /// Web Services Support Center</a>, obtaining the increase is not instantaneous. The
        /// <c>DescribeLimits</c> action lets you write code to compare the capacity you are currently
        /// using to those quotas imposed by your account so that you have enough time to apply
        /// for an increase before you hit a quota.
        /// </para>
        ///  
        /// <para>
        /// For example, you could use one of the Amazon Web Services SDKs to do the following:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Call <c>DescribeLimits</c> for a particular Region to obtain your current account
        /// quotas on provisioned capacity there.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create a variable to hold the aggregate read capacity units provisioned for all your
        /// tables in that Region, and one to hold the aggregate write capacity units. Zero them
        /// both.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Call <c>ListTables</c> to obtain a list of all your DynamoDB tables.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For each table name listed by <c>ListTables</c>, do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Call <c>DescribeTable</c> with the table name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use the data returned by <c>DescribeTable</c> to add the read capacity units and write
        /// capacity units provisioned for the table itself to your variables.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the table has one or more global secondary indexes (GSIs), loop over these GSIs
        /// and add their provisioned capacity values to your variables as well.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Report the account quotas for that Region returned by <c>DescribeLimits</c>, along
        /// with the total current provisioned capacity levels you have calculated.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// This will let you see whether you are getting close to your account-level quotas.
        /// </para>
        ///  
        /// <para>
        /// The per-table quotas apply only when you are creating a new table. They restrict the
        /// sum of the provisioned capacity of the new table itself and all its global secondary
        /// indexes.
        /// </para>
        ///  
        /// <para>
        /// For existing tables and their GSIs, DynamoDB doesn't let you increase provisioned
        /// capacity extremely rapidly, but the only quota that applies is that the aggregate
        /// provisioned capacity over all your tables and GSIs cannot exceed either of the per-account
        /// quotas.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>DescribeLimits</c> should only be called periodically. You can expect throttling
        /// errors if you call it more than once in a minute.
        /// </para>
        ///  </note> 
        /// <para>
        /// The <c>DescribeLimits</c> Request element has no content.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLimits service method.</param>
        /// 
        /// <returns>The response from the DescribeLimits service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/DescribeLimits">REST API Reference for DescribeLimits Operation</seealso>
        public virtual DescribeLimitsResponse DescribeLimits(DescribeLimitsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLimitsResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = DescribeLimitsEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<DescribeLimitsResponse>(request, options);
        }


        /// <summary>
        /// Returns the current provisioned-capacity quotas for your Amazon Web Services account
        /// in a Region, both for the Region as a whole and for any one DynamoDB table that you
        /// create there.
        /// 
        ///  
        /// <para>
        /// When you establish an Amazon Web Services account, the account has initial quotas
        /// on the maximum read capacity units and write capacity units that you can provision
        /// across all of your DynamoDB tables in a given Region. Also, there are per-table quotas
        /// that apply when you create a table there. For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Limits.html">Service,
        /// Account, and Table Quotas</a> page in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Although you can increase these quotas by filing a case at <a href="https://console.aws.amazon.com/support/home#/">Amazon
        /// Web Services Support Center</a>, obtaining the increase is not instantaneous. The
        /// <c>DescribeLimits</c> action lets you write code to compare the capacity you are currently
        /// using to those quotas imposed by your account so that you have enough time to apply
        /// for an increase before you hit a quota.
        /// </para>
        ///  
        /// <para>
        /// For example, you could use one of the Amazon Web Services SDKs to do the following:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Call <c>DescribeLimits</c> for a particular Region to obtain your current account
        /// quotas on provisioned capacity there.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create a variable to hold the aggregate read capacity units provisioned for all your
        /// tables in that Region, and one to hold the aggregate write capacity units. Zero them
        /// both.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Call <c>ListTables</c> to obtain a list of all your DynamoDB tables.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For each table name listed by <c>ListTables</c>, do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Call <c>DescribeTable</c> with the table name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use the data returned by <c>DescribeTable</c> to add the read capacity units and write
        /// capacity units provisioned for the table itself to your variables.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the table has one or more global secondary indexes (GSIs), loop over these GSIs
        /// and add their provisioned capacity values to your variables as well.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Report the account quotas for that Region returned by <c>DescribeLimits</c>, along
        /// with the total current provisioned capacity levels you have calculated.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// This will let you see whether you are getting close to your account-level quotas.
        /// </para>
        ///  
        /// <para>
        /// The per-table quotas apply only when you are creating a new table. They restrict the
        /// sum of the provisioned capacity of the new table itself and all its global secondary
        /// indexes.
        /// </para>
        ///  
        /// <para>
        /// For existing tables and their GSIs, DynamoDB doesn't let you increase provisioned
        /// capacity extremely rapidly, but the only quota that applies is that the aggregate
        /// provisioned capacity over all your tables and GSIs cannot exceed either of the per-account
        /// quotas.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>DescribeLimits</c> should only be called periodically. You can expect throttling
        /// errors if you call it more than once in a minute.
        /// </para>
        ///  </note> 
        /// <para>
        /// The <c>DescribeLimits</c> Request element has no content.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLimits service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLimits service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/DescribeLimits">REST API Reference for DescribeLimits Operation</seealso>
        public virtual Task<DescribeLimitsResponse> DescribeLimitsAsync(DescribeLimitsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLimitsResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = DescribeLimitsEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;
            
            return InvokeAsync<DescribeLimitsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTable


        /// <summary>
        /// Returns information about the table, including the current status of the table, when
        /// it was created, the primary key schema, and any indexes on the table.
        /// 
        ///  <note> 
        /// <para>
        /// If you issue a <c>DescribeTable</c> request immediately after a <c>CreateTable</c>
        /// request, DynamoDB might return a <c>ResourceNotFoundException</c>. This is because
        /// <c>DescribeTable</c> uses an eventually consistent query, and the metadata for your
        /// table might not be available at that moment. Wait for a few seconds, and then try
        /// the <c>DescribeTable</c> request again.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="tableName">The name of the table to describe. You can also provide the Amazon Resource Name (ARN) of the table in this parameter.</param>
        /// 
        /// <returns>The response from the DescribeTable service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/DescribeTable">REST API Reference for DescribeTable Operation</seealso>
        public virtual DescribeTableResponse DescribeTable(string tableName)
        {
            var request = new DescribeTableRequest();
            request.TableName = tableName;
            return DescribeTable(request);
        }


        /// <summary>
        /// Returns information about the table, including the current status of the table, when
        /// it was created, the primary key schema, and any indexes on the table.
        /// 
        ///  <note> 
        /// <para>
        /// If you issue a <c>DescribeTable</c> request immediately after a <c>CreateTable</c>
        /// request, DynamoDB might return a <c>ResourceNotFoundException</c>. This is because
        /// <c>DescribeTable</c> uses an eventually consistent query, and the metadata for your
        /// table might not be available at that moment. Wait for a few seconds, and then try
        /// the <c>DescribeTable</c> request again.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTable service method.</param>
        /// 
        /// <returns>The response from the DescribeTable service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/DescribeTable">REST API Reference for DescribeTable Operation</seealso>
        public virtual DescribeTableResponse DescribeTable(DescribeTableRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTableResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = DescribeTableEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<DescribeTableResponse>(request, options);
        }


        /// <summary>
        /// Returns information about the table, including the current status of the table, when
        /// it was created, the primary key schema, and any indexes on the table.
        /// 
        ///  <note> 
        /// <para>
        /// If you issue a <c>DescribeTable</c> request immediately after a <c>CreateTable</c>
        /// request, DynamoDB might return a <c>ResourceNotFoundException</c>. This is because
        /// <c>DescribeTable</c> uses an eventually consistent query, and the metadata for your
        /// table might not be available at that moment. Wait for a few seconds, and then try
        /// the <c>DescribeTable</c> request again.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="tableName">The name of the table to describe. You can also provide the Amazon Resource Name (ARN) of the table in this parameter.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTable service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/DescribeTable">REST API Reference for DescribeTable Operation</seealso>
        public virtual Task<DescribeTableResponse> DescribeTableAsync(string tableName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DescribeTableRequest();
            request.TableName = tableName;
            return DescribeTableAsync(request, cancellationToken);
        }


        /// <summary>
        /// Returns information about the table, including the current status of the table, when
        /// it was created, the primary key schema, and any indexes on the table.
        /// 
        ///  <note> 
        /// <para>
        /// If you issue a <c>DescribeTable</c> request immediately after a <c>CreateTable</c>
        /// request, DynamoDB might return a <c>ResourceNotFoundException</c>. This is because
        /// <c>DescribeTable</c> uses an eventually consistent query, and the metadata for your
        /// table might not be available at that moment. Wait for a few seconds, and then try
        /// the <c>DescribeTable</c> request again.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTable service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/DescribeTable">REST API Reference for DescribeTable Operation</seealso>
        public virtual Task<DescribeTableResponse> DescribeTableAsync(DescribeTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTableResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = DescribeTableEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;
            
            return InvokeAsync<DescribeTableResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTableReplicaAutoScaling


        /// <summary>
        /// Describes auto scaling settings across replicas of the global table at once.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTableReplicaAutoScaling service method.</param>
        /// 
        /// <returns>The response from the DescribeTableReplicaAutoScaling service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/DescribeTableReplicaAutoScaling">REST API Reference for DescribeTableReplicaAutoScaling Operation</seealso>
        public virtual DescribeTableReplicaAutoScalingResponse DescribeTableReplicaAutoScaling(DescribeTableReplicaAutoScalingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeTableReplicaAutoScalingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTableReplicaAutoScalingResponseUnmarshaller.Instance;

            return Invoke<DescribeTableReplicaAutoScalingResponse>(request, options);
        }


        /// <summary>
        /// Describes auto scaling settings across replicas of the global table at once.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTableReplicaAutoScaling service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTableReplicaAutoScaling service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/DescribeTableReplicaAutoScaling">REST API Reference for DescribeTableReplicaAutoScaling Operation</seealso>
        public virtual Task<DescribeTableReplicaAutoScalingResponse> DescribeTableReplicaAutoScalingAsync(DescribeTableReplicaAutoScalingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeTableReplicaAutoScalingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTableReplicaAutoScalingResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeTableReplicaAutoScalingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTimeToLive


        /// <summary>
        /// Gives a description of the Time to Live (TTL) status on the specified table.
        /// </summary>
        /// <param name="tableName">The name of the table to be described. You can also provide the Amazon Resource Name (ARN) of the table in this parameter.</param>
        /// 
        /// <returns>The response from the DescribeTimeToLive service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/DescribeTimeToLive">REST API Reference for DescribeTimeToLive Operation</seealso>
        public virtual DescribeTimeToLiveResponse DescribeTimeToLive(string tableName)
        {
            var request = new DescribeTimeToLiveRequest();
            request.TableName = tableName;
            return DescribeTimeToLive(request);
        }


        /// <summary>
        /// Gives a description of the Time to Live (TTL) status on the specified table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTimeToLive service method.</param>
        /// 
        /// <returns>The response from the DescribeTimeToLive service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/DescribeTimeToLive">REST API Reference for DescribeTimeToLive Operation</seealso>
        public virtual DescribeTimeToLiveResponse DescribeTimeToLive(DescribeTimeToLiveRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeTimeToLiveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTimeToLiveResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = DescribeTimeToLiveEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<DescribeTimeToLiveResponse>(request, options);
        }


        /// <summary>
        /// Gives a description of the Time to Live (TTL) status on the specified table.
        /// </summary>
        /// <param name="tableName">The name of the table to be described. You can also provide the Amazon Resource Name (ARN) of the table in this parameter.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTimeToLive service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/DescribeTimeToLive">REST API Reference for DescribeTimeToLive Operation</seealso>
        public virtual Task<DescribeTimeToLiveResponse> DescribeTimeToLiveAsync(string tableName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DescribeTimeToLiveRequest();
            request.TableName = tableName;
            return DescribeTimeToLiveAsync(request, cancellationToken);
        }


        /// <summary>
        /// Gives a description of the Time to Live (TTL) status on the specified table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTimeToLive service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTimeToLive service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/DescribeTimeToLive">REST API Reference for DescribeTimeToLive Operation</seealso>
        public virtual Task<DescribeTimeToLiveResponse> DescribeTimeToLiveAsync(DescribeTimeToLiveRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeTimeToLiveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTimeToLiveResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = DescribeTimeToLiveEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;
            
            return InvokeAsync<DescribeTimeToLiveResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisableKinesisStreamingDestination


        /// <summary>
        /// Stops replication from the DynamoDB table to the Kinesis data stream. This is done
        /// without deleting either of the resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableKinesisStreamingDestination service method.</param>
        /// 
        /// <returns>The response from the DisableKinesisStreamingDestination service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.LimitExceededException">
        /// There is no limit to the number of daily on-demand backups that can be taken. 
        /// 
        ///  
        /// <para>
        /// For most purposes, up to 500 simultaneous table operations are allowed per account.
        /// These operations include <c>CreateTable</c>, <c>UpdateTable</c>, <c>DeleteTable</c>,<c>UpdateTimeToLive</c>,
        /// <c>RestoreTableFromBackup</c>, and <c>RestoreTableToPointInTime</c>. 
        /// </para>
        ///  
        /// <para>
        /// When you are creating a table with one or more secondary indexes, you can have up
        /// to 250 such requests running at a time. However, if the table or index specifications
        /// are complex, then DynamoDB might temporarily reduce the number of concurrent operations.
        /// </para>
        ///  
        /// <para>
        /// When importing into DynamoDB, up to 50 simultaneous import table operations are allowed
        /// per account.
        /// </para>
        ///  
        /// <para>
        /// There is a soft account quota of 2,500 tables.
        /// </para>
        ///  
        /// <para>
        /// GetRecords was called with a value of more than 1000 for the limit request parameter.
        /// </para>
        ///  
        /// <para>
        /// More than 2 processes are reading from the same streams shard at the same time. Exceeding
        /// this limit may result in request throttling.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceInUseException">
        /// The operation conflicts with the resource's availability. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You attempted to recreate an existing table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a table currently in the <c>CREATING</c> state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a resource that was already being updated.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When appropriate, wait for the ongoing update to complete and attempt the request
        /// again.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/DisableKinesisStreamingDestination">REST API Reference for DisableKinesisStreamingDestination Operation</seealso>
        public virtual DisableKinesisStreamingDestinationResponse DisableKinesisStreamingDestination(DisableKinesisStreamingDestinationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisableKinesisStreamingDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableKinesisStreamingDestinationResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = DisableKinesisStreamingDestinationEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<DisableKinesisStreamingDestinationResponse>(request, options);
        }


        /// <summary>
        /// Stops replication from the DynamoDB table to the Kinesis data stream. This is done
        /// without deleting either of the resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableKinesisStreamingDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableKinesisStreamingDestination service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.LimitExceededException">
        /// There is no limit to the number of daily on-demand backups that can be taken. 
        /// 
        ///  
        /// <para>
        /// For most purposes, up to 500 simultaneous table operations are allowed per account.
        /// These operations include <c>CreateTable</c>, <c>UpdateTable</c>, <c>DeleteTable</c>,<c>UpdateTimeToLive</c>,
        /// <c>RestoreTableFromBackup</c>, and <c>RestoreTableToPointInTime</c>. 
        /// </para>
        ///  
        /// <para>
        /// When you are creating a table with one or more secondary indexes, you can have up
        /// to 250 such requests running at a time. However, if the table or index specifications
        /// are complex, then DynamoDB might temporarily reduce the number of concurrent operations.
        /// </para>
        ///  
        /// <para>
        /// When importing into DynamoDB, up to 50 simultaneous import table operations are allowed
        /// per account.
        /// </para>
        ///  
        /// <para>
        /// There is a soft account quota of 2,500 tables.
        /// </para>
        ///  
        /// <para>
        /// GetRecords was called with a value of more than 1000 for the limit request parameter.
        /// </para>
        ///  
        /// <para>
        /// More than 2 processes are reading from the same streams shard at the same time. Exceeding
        /// this limit may result in request throttling.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceInUseException">
        /// The operation conflicts with the resource's availability. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You attempted to recreate an existing table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a table currently in the <c>CREATING</c> state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a resource that was already being updated.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When appropriate, wait for the ongoing update to complete and attempt the request
        /// again.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/DisableKinesisStreamingDestination">REST API Reference for DisableKinesisStreamingDestination Operation</seealso>
        public virtual Task<DisableKinesisStreamingDestinationResponse> DisableKinesisStreamingDestinationAsync(DisableKinesisStreamingDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisableKinesisStreamingDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableKinesisStreamingDestinationResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = DisableKinesisStreamingDestinationEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;
            
            return InvokeAsync<DisableKinesisStreamingDestinationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableKinesisStreamingDestination


        /// <summary>
        /// Starts table data replication to the specified Kinesis data stream at a timestamp
        /// chosen during the enable workflow. If this operation doesn't return results immediately,
        /// use DescribeKinesisStreamingDestination to check if streaming to the Kinesis data
        /// stream is ACTIVE.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableKinesisStreamingDestination service method.</param>
        /// 
        /// <returns>The response from the EnableKinesisStreamingDestination service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.LimitExceededException">
        /// There is no limit to the number of daily on-demand backups that can be taken. 
        /// 
        ///  
        /// <para>
        /// For most purposes, up to 500 simultaneous table operations are allowed per account.
        /// These operations include <c>CreateTable</c>, <c>UpdateTable</c>, <c>DeleteTable</c>,<c>UpdateTimeToLive</c>,
        /// <c>RestoreTableFromBackup</c>, and <c>RestoreTableToPointInTime</c>. 
        /// </para>
        ///  
        /// <para>
        /// When you are creating a table with one or more secondary indexes, you can have up
        /// to 250 such requests running at a time. However, if the table or index specifications
        /// are complex, then DynamoDB might temporarily reduce the number of concurrent operations.
        /// </para>
        ///  
        /// <para>
        /// When importing into DynamoDB, up to 50 simultaneous import table operations are allowed
        /// per account.
        /// </para>
        ///  
        /// <para>
        /// There is a soft account quota of 2,500 tables.
        /// </para>
        ///  
        /// <para>
        /// GetRecords was called with a value of more than 1000 for the limit request parameter.
        /// </para>
        ///  
        /// <para>
        /// More than 2 processes are reading from the same streams shard at the same time. Exceeding
        /// this limit may result in request throttling.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceInUseException">
        /// The operation conflicts with the resource's availability. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You attempted to recreate an existing table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a table currently in the <c>CREATING</c> state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a resource that was already being updated.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When appropriate, wait for the ongoing update to complete and attempt the request
        /// again.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/EnableKinesisStreamingDestination">REST API Reference for EnableKinesisStreamingDestination Operation</seealso>
        public virtual EnableKinesisStreamingDestinationResponse EnableKinesisStreamingDestination(EnableKinesisStreamingDestinationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EnableKinesisStreamingDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableKinesisStreamingDestinationResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = EnableKinesisStreamingDestinationEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<EnableKinesisStreamingDestinationResponse>(request, options);
        }


        /// <summary>
        /// Starts table data replication to the specified Kinesis data stream at a timestamp
        /// chosen during the enable workflow. If this operation doesn't return results immediately,
        /// use DescribeKinesisStreamingDestination to check if streaming to the Kinesis data
        /// stream is ACTIVE.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableKinesisStreamingDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableKinesisStreamingDestination service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.LimitExceededException">
        /// There is no limit to the number of daily on-demand backups that can be taken. 
        /// 
        ///  
        /// <para>
        /// For most purposes, up to 500 simultaneous table operations are allowed per account.
        /// These operations include <c>CreateTable</c>, <c>UpdateTable</c>, <c>DeleteTable</c>,<c>UpdateTimeToLive</c>,
        /// <c>RestoreTableFromBackup</c>, and <c>RestoreTableToPointInTime</c>. 
        /// </para>
        ///  
        /// <para>
        /// When you are creating a table with one or more secondary indexes, you can have up
        /// to 250 such requests running at a time. However, if the table or index specifications
        /// are complex, then DynamoDB might temporarily reduce the number of concurrent operations.
        /// </para>
        ///  
        /// <para>
        /// When importing into DynamoDB, up to 50 simultaneous import table operations are allowed
        /// per account.
        /// </para>
        ///  
        /// <para>
        /// There is a soft account quota of 2,500 tables.
        /// </para>
        ///  
        /// <para>
        /// GetRecords was called with a value of more than 1000 for the limit request parameter.
        /// </para>
        ///  
        /// <para>
        /// More than 2 processes are reading from the same streams shard at the same time. Exceeding
        /// this limit may result in request throttling.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceInUseException">
        /// The operation conflicts with the resource's availability. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You attempted to recreate an existing table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a table currently in the <c>CREATING</c> state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a resource that was already being updated.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When appropriate, wait for the ongoing update to complete and attempt the request
        /// again.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/EnableKinesisStreamingDestination">REST API Reference for EnableKinesisStreamingDestination Operation</seealso>
        public virtual Task<EnableKinesisStreamingDestinationResponse> EnableKinesisStreamingDestinationAsync(EnableKinesisStreamingDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EnableKinesisStreamingDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableKinesisStreamingDestinationResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = EnableKinesisStreamingDestinationEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;
            
            return InvokeAsync<EnableKinesisStreamingDestinationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ExecuteStatement


        /// <summary>
        /// This operation allows you to perform reads and singleton writes on data stored in
        /// DynamoDB, using PartiQL.
        /// 
        ///  
        /// <para>
        /// For PartiQL reads (<c>SELECT</c> statement), if the total number of processed items
        /// exceeds the maximum dataset size limit of 1 MB, the read stops and results are returned
        /// to the user as a <c>LastEvaluatedKey</c> value to continue the read in a subsequent
        /// operation. If the filter criteria in <c>WHERE</c> clause does not match any data,
        /// the read will return an empty result set.
        /// </para>
        ///  
        /// <para>
        /// A single <c>SELECT</c> statement response can return up to the maximum number of items
        /// (if using the Limit parameter) or a maximum of 1 MB of data (and then apply any filtering
        /// to the results using <c>WHERE</c> clause). If <c>LastEvaluatedKey</c> is present in
        /// the response, you need to paginate the result set. If <c>NextToken</c> is present,
        /// you need to paginate the result set and include <c>NextToken</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteStatement service method.</param>
        /// 
        /// <returns>The response from the ExecuteStatement service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.ConditionalCheckFailedException">
        /// A condition specified in the operation failed to be evaluated.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.DuplicateItemException">
        /// There was an attempt to insert an item with the same primary key as an item that
        /// already exists in the DynamoDB table.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ItemCollectionSizeLimitExceededException">
        /// An item collection is too large. This exception is only returned for tables that have
        /// one or more local secondary indexes.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. The Amazon Web Services SDKs for DynamoDB automatically
        /// retry requests that receive this exception. Your request is eventually successful,
        /// unless your retry queue is too large to finish. Reduce the frequency of requests and
        /// use exponential backoff. For more information, go to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Programming.Errors.html#Programming.Errors.RetryAndBackoff">Error
        /// Retries and Exponential Backoff</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.RequestLimitExceededException">
        /// Throughput exceeds the current throughput quota for your account. For detailed information
        /// about why the request was throttled and the ARN of the impacted resource, find the
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. Contact <a href="https://aws.amazon.com/support">Amazon
        /// Web Services Support</a> to request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ThrottlingException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.TransactionConflictException">
        /// Operation was rejected because there is an ongoing transaction for the item.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/ExecuteStatement">REST API Reference for ExecuteStatement Operation</seealso>
        public virtual ExecuteStatementResponse ExecuteStatement(ExecuteStatementRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExecuteStatementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteStatementResponseUnmarshaller.Instance;

            return Invoke<ExecuteStatementResponse>(request, options);
        }


        /// <summary>
        /// This operation allows you to perform reads and singleton writes on data stored in
        /// DynamoDB, using PartiQL.
        /// 
        ///  
        /// <para>
        /// For PartiQL reads (<c>SELECT</c> statement), if the total number of processed items
        /// exceeds the maximum dataset size limit of 1 MB, the read stops and results are returned
        /// to the user as a <c>LastEvaluatedKey</c> value to continue the read in a subsequent
        /// operation. If the filter criteria in <c>WHERE</c> clause does not match any data,
        /// the read will return an empty result set.
        /// </para>
        ///  
        /// <para>
        /// A single <c>SELECT</c> statement response can return up to the maximum number of items
        /// (if using the Limit parameter) or a maximum of 1 MB of data (and then apply any filtering
        /// to the results using <c>WHERE</c> clause). If <c>LastEvaluatedKey</c> is present in
        /// the response, you need to paginate the result set. If <c>NextToken</c> is present,
        /// you need to paginate the result set and include <c>NextToken</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteStatement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExecuteStatement service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.ConditionalCheckFailedException">
        /// A condition specified in the operation failed to be evaluated.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.DuplicateItemException">
        /// There was an attempt to insert an item with the same primary key as an item that
        /// already exists in the DynamoDB table.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ItemCollectionSizeLimitExceededException">
        /// An item collection is too large. This exception is only returned for tables that have
        /// one or more local secondary indexes.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. The Amazon Web Services SDKs for DynamoDB automatically
        /// retry requests that receive this exception. Your request is eventually successful,
        /// unless your retry queue is too large to finish. Reduce the frequency of requests and
        /// use exponential backoff. For more information, go to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Programming.Errors.html#Programming.Errors.RetryAndBackoff">Error
        /// Retries and Exponential Backoff</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.RequestLimitExceededException">
        /// Throughput exceeds the current throughput quota for your account. For detailed information
        /// about why the request was throttled and the ARN of the impacted resource, find the
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. Contact <a href="https://aws.amazon.com/support">Amazon
        /// Web Services Support</a> to request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ThrottlingException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.TransactionConflictException">
        /// Operation was rejected because there is an ongoing transaction for the item.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/ExecuteStatement">REST API Reference for ExecuteStatement Operation</seealso>
        public virtual Task<ExecuteStatementResponse> ExecuteStatementAsync(ExecuteStatementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExecuteStatementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteStatementResponseUnmarshaller.Instance;
            
            return InvokeAsync<ExecuteStatementResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ExecuteTransaction


        /// <summary>
        /// This operation allows you to perform transactional reads or writes on data stored
        /// in DynamoDB, using PartiQL.
        /// 
        ///  <note> 
        /// <para>
        /// The entire transaction must consist of either read statements or write statements,
        /// you cannot mix both in one transaction. The EXISTS function is an exception and can
        /// be used to check the condition of specific attributes of the item in a similar manner
        /// to <c>ConditionCheck</c> in the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/transaction-apis.html#transaction-apis-txwriteitems">TransactWriteItems</a>
        /// API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteTransaction service method.</param>
        /// 
        /// <returns>The response from the ExecuteTransaction service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.IdempotentParameterMismatchException">
        /// DynamoDB rejected the request because you retried a request with a different payload
        /// but with an idempotent token that was already used.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. The Amazon Web Services SDKs for DynamoDB automatically
        /// retry requests that receive this exception. Your request is eventually successful,
        /// unless your retry queue is too large to finish. Reduce the frequency of requests and
        /// use exponential backoff. For more information, go to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Programming.Errors.html#Programming.Errors.RetryAndBackoff">Error
        /// Retries and Exponential Backoff</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.RequestLimitExceededException">
        /// Throughput exceeds the current throughput quota for your account. For detailed information
        /// about why the request was throttled and the ARN of the impacted resource, find the
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. Contact <a href="https://aws.amazon.com/support">Amazon
        /// Web Services Support</a> to request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ThrottlingException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.TransactionCanceledException">
        /// The entire transaction request was canceled.
        /// 
        ///  
        /// <para>
        /// DynamoDB cancels a <c>TransactWriteItems</c> request under the following circumstances:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A condition in one of the condition expressions is not met.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A table in the <c>TransactWriteItems</c> request is in a different account or region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// More than one action in the <c>TransactWriteItems</c> operation targets the same item.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is insufficient provisioned capacity for the transaction to be completed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An item size becomes too large (larger than 400 KB), or a local secondary index (LSI)
        /// becomes too large, or a similar validation error occurs because of changes made by
        /// the transaction.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a user error, such as an invalid data format.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  There is an ongoing <c>TransactWriteItems</c> operation that conflicts with a concurrent
        /// <c>TransactWriteItems</c> request. In this case the <c>TransactWriteItems</c> operation
        /// fails with a <c>TransactionCanceledException</c>. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// DynamoDB cancels a <c>TransactGetItems</c> request under the following circumstances:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// There is an ongoing <c>TransactGetItems</c> operation that conflicts with a concurrent
        /// <c>PutItem</c>, <c>UpdateItem</c>, <c>DeleteItem</c> or <c>TransactWriteItems</c>
        /// request. In this case the <c>TransactGetItems</c> operation fails with a <c>TransactionCanceledException</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A table in the <c>TransactGetItems</c> request is in a different account or region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is insufficient provisioned capacity for the transaction to be completed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a user error, such as an invalid data format.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// If using Java, DynamoDB lists the cancellation reasons on the <c>CancellationReasons</c>
        /// property. This property is not set for other languages. Transaction cancellation reasons
        /// are ordered in the order of requested items, if an item has no error it will have
        /// <c>None</c> code and <c>Null</c> message.
        /// </para>
        ///  </note> 
        /// <para>
        /// Cancellation reason codes and possible error messages:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// No Errors:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Code: <c>None</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Message: <c>null</c> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Conditional Check Failed:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Code: <c>ConditionalCheckFailed</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Message: The conditional request failed. 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Item Collection Size Limit Exceeded:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Code: <c>ItemCollectionSizeLimitExceeded</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Message: Collection size exceeded.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Transaction Conflict:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Code: <c>TransactionConflict</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Message: Transaction is ongoing for the item.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Provisioned Throughput Exceeded:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Code: <c>ProvisionedThroughputExceeded</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Messages:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The level of configured provisioned throughput for the table was exceeded. Consider
        /// increasing your provisioning level with the UpdateTable API.
        /// </para>
        ///  <note> 
        /// <para>
        /// This Message is received when provisioned throughput is exceeded is on a provisioned
        /// DynamoDB table.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// The level of configured provisioned throughput for one or more global secondary indexes
        /// of the table was exceeded. Consider increasing your provisioning level for the under-provisioned
        /// global secondary indexes with the UpdateTable API.
        /// </para>
        ///  <note> 
        /// <para>
        /// This message is returned when provisioned throughput is exceeded is on a provisioned
        /// GSI.
        /// </para>
        ///  </note> </li> </ul> </li> </ul> </li> <li> 
        /// <para>
        /// Throttling Error:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Code: <c>ThrottlingError</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Messages: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Throughput exceeds the current capacity of your table or index. DynamoDB is automatically
        /// scaling your table or index so please try again shortly. If exceptions persist, check
        /// if you have a hot key: https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/bp-partition-key-design.html.
        /// </para>
        ///  <note> 
        /// <para>
        /// This message is returned when writes get throttled on an On-Demand table as DynamoDB
        /// is automatically scaling the table.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// Throughput exceeds the current capacity for one or more global secondary indexes.
        /// DynamoDB is automatically scaling your index so please try again shortly.
        /// </para>
        ///  <note> 
        /// <para>
        /// This message is returned when writes get throttled on an On-Demand GSI as DynamoDB
        /// is automatically scaling the GSI.
        /// </para>
        ///  </note> </li> </ul> </li> </ul> </li> <li> 
        /// <para>
        /// Validation Error:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Code: <c>ValidationError</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Messages: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// One or more parameter values were invalid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The update expression attempted to update the secondary index key beyond allowed size
        /// limits.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The update expression attempted to update the secondary index key to unsupported type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An operand in the update expression has an incorrect data type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Item size to update has exceeded the maximum allowed size.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Number overflow. Attempting to store a number with magnitude larger than supported
        /// range.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Type mismatch for attribute to update.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Nesting Levels have exceeded supported limits.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The document path provided in the update expression is invalid for update.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The provided expression refers to an attribute that does not exist in the item.
        /// </para>
        ///  </li> </ul> </li> </ul> </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.TransactionInProgressException">
        /// The transaction with the given request token is already in progress.
        /// 
        ///  
        /// <para>
        ///  Recommended Settings 
        /// </para>
        ///  <note> 
        /// <para>
        ///  This is a general recommendation for handling the <c>TransactionInProgressException</c>.
        /// These settings help ensure that the client retries will trigger completion of the
        /// ongoing <c>TransactWriteItems</c> request. 
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        ///  Set <c>clientExecutionTimeout</c> to a value that allows at least one retry to be
        /// processed after 5 seconds have elapsed since the first attempt for the <c>TransactWriteItems</c>
        /// operation. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Set <c>socketTimeout</c> to a value a little lower than the <c>requestTimeout</c>
        /// setting. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>requestTimeout</c> should be set based on the time taken for the individual retries
        /// of a single HTTP request for your use case, but setting it to 1 second or higher should
        /// work well to reduce chances of retries and <c>TransactionInProgressException</c> errors.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Use exponential backoff when retrying and tune backoff if needed. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  Assuming <a href="https://github.com/aws/aws-sdk-java/blob/fd409dee8ae23fb8953e0bb4dbde65536a7e0514/aws-java-sdk-core/src/main/java/com/amazonaws/retry/PredefinedRetryPolicies.java#L97">default
        /// retry policy</a>, example timeout settings based on the guidelines above are as follows:
        /// 
        /// </para>
        ///  
        /// <para>
        /// Example timeline:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// 0-1000 first attempt
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 1000-1500 first sleep/delay (default retry policy uses 500 ms as base delay for 4xx
        /// errors)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 1500-2500 second attempt
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 2500-3500 second sleep/delay (500 * 2, exponential backoff)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 3500-4500 third attempt
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 4500-6500 third sleep/delay (500 * 2^2)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 6500-7500 fourth attempt (this can trigger inline recovery since 5 seconds have elapsed
        /// since the first attempt reached TC)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/ExecuteTransaction">REST API Reference for ExecuteTransaction Operation</seealso>
        public virtual ExecuteTransactionResponse ExecuteTransaction(ExecuteTransactionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExecuteTransactionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteTransactionResponseUnmarshaller.Instance;

            return Invoke<ExecuteTransactionResponse>(request, options);
        }


        /// <summary>
        /// This operation allows you to perform transactional reads or writes on data stored
        /// in DynamoDB, using PartiQL.
        /// 
        ///  <note> 
        /// <para>
        /// The entire transaction must consist of either read statements or write statements,
        /// you cannot mix both in one transaction. The EXISTS function is an exception and can
        /// be used to check the condition of specific attributes of the item in a similar manner
        /// to <c>ConditionCheck</c> in the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/transaction-apis.html#transaction-apis-txwriteitems">TransactWriteItems</a>
        /// API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteTransaction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExecuteTransaction service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.IdempotentParameterMismatchException">
        /// DynamoDB rejected the request because you retried a request with a different payload
        /// but with an idempotent token that was already used.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. The Amazon Web Services SDKs for DynamoDB automatically
        /// retry requests that receive this exception. Your request is eventually successful,
        /// unless your retry queue is too large to finish. Reduce the frequency of requests and
        /// use exponential backoff. For more information, go to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Programming.Errors.html#Programming.Errors.RetryAndBackoff">Error
        /// Retries and Exponential Backoff</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.RequestLimitExceededException">
        /// Throughput exceeds the current throughput quota for your account. For detailed information
        /// about why the request was throttled and the ARN of the impacted resource, find the
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. Contact <a href="https://aws.amazon.com/support">Amazon
        /// Web Services Support</a> to request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ThrottlingException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.TransactionCanceledException">
        /// The entire transaction request was canceled.
        /// 
        ///  
        /// <para>
        /// DynamoDB cancels a <c>TransactWriteItems</c> request under the following circumstances:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A condition in one of the condition expressions is not met.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A table in the <c>TransactWriteItems</c> request is in a different account or region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// More than one action in the <c>TransactWriteItems</c> operation targets the same item.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is insufficient provisioned capacity for the transaction to be completed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An item size becomes too large (larger than 400 KB), or a local secondary index (LSI)
        /// becomes too large, or a similar validation error occurs because of changes made by
        /// the transaction.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a user error, such as an invalid data format.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  There is an ongoing <c>TransactWriteItems</c> operation that conflicts with a concurrent
        /// <c>TransactWriteItems</c> request. In this case the <c>TransactWriteItems</c> operation
        /// fails with a <c>TransactionCanceledException</c>. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// DynamoDB cancels a <c>TransactGetItems</c> request under the following circumstances:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// There is an ongoing <c>TransactGetItems</c> operation that conflicts with a concurrent
        /// <c>PutItem</c>, <c>UpdateItem</c>, <c>DeleteItem</c> or <c>TransactWriteItems</c>
        /// request. In this case the <c>TransactGetItems</c> operation fails with a <c>TransactionCanceledException</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A table in the <c>TransactGetItems</c> request is in a different account or region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is insufficient provisioned capacity for the transaction to be completed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a user error, such as an invalid data format.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// If using Java, DynamoDB lists the cancellation reasons on the <c>CancellationReasons</c>
        /// property. This property is not set for other languages. Transaction cancellation reasons
        /// are ordered in the order of requested items, if an item has no error it will have
        /// <c>None</c> code and <c>Null</c> message.
        /// </para>
        ///  </note> 
        /// <para>
        /// Cancellation reason codes and possible error messages:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// No Errors:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Code: <c>None</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Message: <c>null</c> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Conditional Check Failed:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Code: <c>ConditionalCheckFailed</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Message: The conditional request failed. 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Item Collection Size Limit Exceeded:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Code: <c>ItemCollectionSizeLimitExceeded</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Message: Collection size exceeded.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Transaction Conflict:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Code: <c>TransactionConflict</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Message: Transaction is ongoing for the item.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Provisioned Throughput Exceeded:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Code: <c>ProvisionedThroughputExceeded</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Messages:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The level of configured provisioned throughput for the table was exceeded. Consider
        /// increasing your provisioning level with the UpdateTable API.
        /// </para>
        ///  <note> 
        /// <para>
        /// This Message is received when provisioned throughput is exceeded is on a provisioned
        /// DynamoDB table.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// The level of configured provisioned throughput for one or more global secondary indexes
        /// of the table was exceeded. Consider increasing your provisioning level for the under-provisioned
        /// global secondary indexes with the UpdateTable API.
        /// </para>
        ///  <note> 
        /// <para>
        /// This message is returned when provisioned throughput is exceeded is on a provisioned
        /// GSI.
        /// </para>
        ///  </note> </li> </ul> </li> </ul> </li> <li> 
        /// <para>
        /// Throttling Error:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Code: <c>ThrottlingError</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Messages: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Throughput exceeds the current capacity of your table or index. DynamoDB is automatically
        /// scaling your table or index so please try again shortly. If exceptions persist, check
        /// if you have a hot key: https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/bp-partition-key-design.html.
        /// </para>
        ///  <note> 
        /// <para>
        /// This message is returned when writes get throttled on an On-Demand table as DynamoDB
        /// is automatically scaling the table.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// Throughput exceeds the current capacity for one or more global secondary indexes.
        /// DynamoDB is automatically scaling your index so please try again shortly.
        /// </para>
        ///  <note> 
        /// <para>
        /// This message is returned when writes get throttled on an On-Demand GSI as DynamoDB
        /// is automatically scaling the GSI.
        /// </para>
        ///  </note> </li> </ul> </li> </ul> </li> <li> 
        /// <para>
        /// Validation Error:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Code: <c>ValidationError</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Messages: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// One or more parameter values were invalid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The update expression attempted to update the secondary index key beyond allowed size
        /// limits.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The update expression attempted to update the secondary index key to unsupported type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An operand in the update expression has an incorrect data type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Item size to update has exceeded the maximum allowed size.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Number overflow. Attempting to store a number with magnitude larger than supported
        /// range.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Type mismatch for attribute to update.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Nesting Levels have exceeded supported limits.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The document path provided in the update expression is invalid for update.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The provided expression refers to an attribute that does not exist in the item.
        /// </para>
        ///  </li> </ul> </li> </ul> </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.TransactionInProgressException">
        /// The transaction with the given request token is already in progress.
        /// 
        ///  
        /// <para>
        ///  Recommended Settings 
        /// </para>
        ///  <note> 
        /// <para>
        ///  This is a general recommendation for handling the <c>TransactionInProgressException</c>.
        /// These settings help ensure that the client retries will trigger completion of the
        /// ongoing <c>TransactWriteItems</c> request. 
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        ///  Set <c>clientExecutionTimeout</c> to a value that allows at least one retry to be
        /// processed after 5 seconds have elapsed since the first attempt for the <c>TransactWriteItems</c>
        /// operation. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Set <c>socketTimeout</c> to a value a little lower than the <c>requestTimeout</c>
        /// setting. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>requestTimeout</c> should be set based on the time taken for the individual retries
        /// of a single HTTP request for your use case, but setting it to 1 second or higher should
        /// work well to reduce chances of retries and <c>TransactionInProgressException</c> errors.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Use exponential backoff when retrying and tune backoff if needed. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  Assuming <a href="https://github.com/aws/aws-sdk-java/blob/fd409dee8ae23fb8953e0bb4dbde65536a7e0514/aws-java-sdk-core/src/main/java/com/amazonaws/retry/PredefinedRetryPolicies.java#L97">default
        /// retry policy</a>, example timeout settings based on the guidelines above are as follows:
        /// 
        /// </para>
        ///  
        /// <para>
        /// Example timeline:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// 0-1000 first attempt
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 1000-1500 first sleep/delay (default retry policy uses 500 ms as base delay for 4xx
        /// errors)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 1500-2500 second attempt
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 2500-3500 second sleep/delay (500 * 2, exponential backoff)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 3500-4500 third attempt
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 4500-6500 third sleep/delay (500 * 2^2)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 6500-7500 fourth attempt (this can trigger inline recovery since 5 seconds have elapsed
        /// since the first attempt reached TC)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/ExecuteTransaction">REST API Reference for ExecuteTransaction Operation</seealso>
        public virtual Task<ExecuteTransactionResponse> ExecuteTransactionAsync(ExecuteTransactionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExecuteTransactionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteTransactionResponseUnmarshaller.Instance;
            
            return InvokeAsync<ExecuteTransactionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ExportTableToPointInTime


        /// <summary>
        /// Exports table data to an S3 bucket. The table must have point in time recovery enabled,
        /// and you can export data from any time within the point in time recovery window.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportTableToPointInTime service method.</param>
        /// 
        /// <returns>The response from the ExportTableToPointInTime service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.ExportConflictException">
        /// There was a conflict when writing to the specified S3 bucket.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.InvalidExportTimeException">
        /// The specified <c>ExportTime</c> is outside of the point in time recovery window.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.LimitExceededException">
        /// There is no limit to the number of daily on-demand backups that can be taken. 
        /// 
        ///  
        /// <para>
        /// For most purposes, up to 500 simultaneous table operations are allowed per account.
        /// These operations include <c>CreateTable</c>, <c>UpdateTable</c>, <c>DeleteTable</c>,<c>UpdateTimeToLive</c>,
        /// <c>RestoreTableFromBackup</c>, and <c>RestoreTableToPointInTime</c>. 
        /// </para>
        ///  
        /// <para>
        /// When you are creating a table with one or more secondary indexes, you can have up
        /// to 250 such requests running at a time. However, if the table or index specifications
        /// are complex, then DynamoDB might temporarily reduce the number of concurrent operations.
        /// </para>
        ///  
        /// <para>
        /// When importing into DynamoDB, up to 50 simultaneous import table operations are allowed
        /// per account.
        /// </para>
        ///  
        /// <para>
        /// There is a soft account quota of 2,500 tables.
        /// </para>
        ///  
        /// <para>
        /// GetRecords was called with a value of more than 1000 for the limit request parameter.
        /// </para>
        ///  
        /// <para>
        /// More than 2 processes are reading from the same streams shard at the same time. Exceeding
        /// this limit may result in request throttling.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.PointInTimeRecoveryUnavailableException">
        /// Point in time recovery has not yet been enabled for this source table.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.TableNotFoundException">
        /// A source table with the name <c>TableName</c> does not currently exist within the
        /// subscriber's account or the subscriber is operating in the wrong Amazon Web Services
        /// Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/ExportTableToPointInTime">REST API Reference for ExportTableToPointInTime Operation</seealso>
        public virtual ExportTableToPointInTimeResponse ExportTableToPointInTime(ExportTableToPointInTimeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExportTableToPointInTimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportTableToPointInTimeResponseUnmarshaller.Instance;

            return Invoke<ExportTableToPointInTimeResponse>(request, options);
        }


        /// <summary>
        /// Exports table data to an S3 bucket. The table must have point in time recovery enabled,
        /// and you can export data from any time within the point in time recovery window.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportTableToPointInTime service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExportTableToPointInTime service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.ExportConflictException">
        /// There was a conflict when writing to the specified S3 bucket.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.InvalidExportTimeException">
        /// The specified <c>ExportTime</c> is outside of the point in time recovery window.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.LimitExceededException">
        /// There is no limit to the number of daily on-demand backups that can be taken. 
        /// 
        ///  
        /// <para>
        /// For most purposes, up to 500 simultaneous table operations are allowed per account.
        /// These operations include <c>CreateTable</c>, <c>UpdateTable</c>, <c>DeleteTable</c>,<c>UpdateTimeToLive</c>,
        /// <c>RestoreTableFromBackup</c>, and <c>RestoreTableToPointInTime</c>. 
        /// </para>
        ///  
        /// <para>
        /// When you are creating a table with one or more secondary indexes, you can have up
        /// to 250 such requests running at a time. However, if the table or index specifications
        /// are complex, then DynamoDB might temporarily reduce the number of concurrent operations.
        /// </para>
        ///  
        /// <para>
        /// When importing into DynamoDB, up to 50 simultaneous import table operations are allowed
        /// per account.
        /// </para>
        ///  
        /// <para>
        /// There is a soft account quota of 2,500 tables.
        /// </para>
        ///  
        /// <para>
        /// GetRecords was called with a value of more than 1000 for the limit request parameter.
        /// </para>
        ///  
        /// <para>
        /// More than 2 processes are reading from the same streams shard at the same time. Exceeding
        /// this limit may result in request throttling.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.PointInTimeRecoveryUnavailableException">
        /// Point in time recovery has not yet been enabled for this source table.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.TableNotFoundException">
        /// A source table with the name <c>TableName</c> does not currently exist within the
        /// subscriber's account or the subscriber is operating in the wrong Amazon Web Services
        /// Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/ExportTableToPointInTime">REST API Reference for ExportTableToPointInTime Operation</seealso>
        public virtual Task<ExportTableToPointInTimeResponse> ExportTableToPointInTimeAsync(ExportTableToPointInTimeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ExportTableToPointInTimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportTableToPointInTimeResponseUnmarshaller.Instance;
            
            return InvokeAsync<ExportTableToPointInTimeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetItem


        /// <summary>
        /// The <c>GetItem</c> operation returns a set of attributes for the item with the given
        /// primary key. If there is no matching item, <c>GetItem</c> does not return any data
        /// and there will be no <c>Item</c> element in the response.
        /// 
        ///  
        /// <para>
        ///  <c>GetItem</c> provides an eventually consistent read by default. If your application
        /// requires a strongly consistent read, set <c>ConsistentRead</c> to <c>true</c>. Although
        /// a strongly consistent read might take more time than an eventually consistent read,
        /// it always returns the last updated value.
        /// </para>
        /// </summary>
        /// <param name="tableName">The name of the table containing the requested item. You can also provide the Amazon Resource Name (ARN) of the table in this parameter.</param>
        /// <param name="key">A map of attribute names to <c>AttributeValue</c> objects, representing the primary key of the item to retrieve. For the primary key, you must provide all of the attributes. For example, with a simple primary key, you only need to provide a value for the partition key. For a composite primary key, you must provide values for both the partition key and the sort key.</param>
        /// 
        /// <returns>The response from the GetItem service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. The Amazon Web Services SDKs for DynamoDB automatically
        /// retry requests that receive this exception. Your request is eventually successful,
        /// unless your retry queue is too large to finish. Reduce the frequency of requests and
        /// use exponential backoff. For more information, go to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Programming.Errors.html#Programming.Errors.RetryAndBackoff">Error
        /// Retries and Exponential Backoff</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.RequestLimitExceededException">
        /// Throughput exceeds the current throughput quota for your account. For detailed information
        /// about why the request was throttled and the ARN of the impacted resource, find the
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. Contact <a href="https://aws.amazon.com/support">Amazon
        /// Web Services Support</a> to request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ThrottlingException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/GetItem">REST API Reference for GetItem Operation</seealso>
        public virtual GetItemResponse GetItem(string tableName, Dictionary<string, AttributeValue> key)
        {
            var request = new GetItemRequest();
            request.TableName = tableName;
            request.Key = key;
            return GetItem(request);
        }


        /// <summary>
        /// The <c>GetItem</c> operation returns a set of attributes for the item with the given
        /// primary key. If there is no matching item, <c>GetItem</c> does not return any data
        /// and there will be no <c>Item</c> element in the response.
        /// 
        ///  
        /// <para>
        ///  <c>GetItem</c> provides an eventually consistent read by default. If your application
        /// requires a strongly consistent read, set <c>ConsistentRead</c> to <c>true</c>. Although
        /// a strongly consistent read might take more time than an eventually consistent read,
        /// it always returns the last updated value.
        /// </para>
        /// </summary>
        /// <param name="tableName">The name of the table containing the requested item. You can also provide the Amazon Resource Name (ARN) of the table in this parameter.</param>
        /// <param name="key">A map of attribute names to <c>AttributeValue</c> objects, representing the primary key of the item to retrieve. For the primary key, you must provide all of the attributes. For example, with a simple primary key, you only need to provide a value for the partition key. For a composite primary key, you must provide values for both the partition key and the sort key.</param>
        /// <param name="consistentRead">Determines the read consistency model: If set to <c>true</c>, then the operation uses strongly consistent reads; otherwise, the operation uses eventually consistent reads.</param>
        /// 
        /// <returns>The response from the GetItem service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. The Amazon Web Services SDKs for DynamoDB automatically
        /// retry requests that receive this exception. Your request is eventually successful,
        /// unless your retry queue is too large to finish. Reduce the frequency of requests and
        /// use exponential backoff. For more information, go to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Programming.Errors.html#Programming.Errors.RetryAndBackoff">Error
        /// Retries and Exponential Backoff</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.RequestLimitExceededException">
        /// Throughput exceeds the current throughput quota for your account. For detailed information
        /// about why the request was throttled and the ARN of the impacted resource, find the
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. Contact <a href="https://aws.amazon.com/support">Amazon
        /// Web Services Support</a> to request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ThrottlingException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/GetItem">REST API Reference for GetItem Operation</seealso>
        public virtual GetItemResponse GetItem(string tableName, Dictionary<string, AttributeValue> key, bool? consistentRead)
        {
            var request = new GetItemRequest();
            request.TableName = tableName;
            request.Key = key;
            request.ConsistentRead = consistentRead;
            return GetItem(request);
        }


        /// <summary>
        /// The <c>GetItem</c> operation returns a set of attributes for the item with the given
        /// primary key. If there is no matching item, <c>GetItem</c> does not return any data
        /// and there will be no <c>Item</c> element in the response.
        /// 
        ///  
        /// <para>
        ///  <c>GetItem</c> provides an eventually consistent read by default. If your application
        /// requires a strongly consistent read, set <c>ConsistentRead</c> to <c>true</c>. Although
        /// a strongly consistent read might take more time than an eventually consistent read,
        /// it always returns the last updated value.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetItem service method.</param>
        /// 
        /// <returns>The response from the GetItem service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. The Amazon Web Services SDKs for DynamoDB automatically
        /// retry requests that receive this exception. Your request is eventually successful,
        /// unless your retry queue is too large to finish. Reduce the frequency of requests and
        /// use exponential backoff. For more information, go to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Programming.Errors.html#Programming.Errors.RetryAndBackoff">Error
        /// Retries and Exponential Backoff</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.RequestLimitExceededException">
        /// Throughput exceeds the current throughput quota for your account. For detailed information
        /// about why the request was throttled and the ARN of the impacted resource, find the
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. Contact <a href="https://aws.amazon.com/support">Amazon
        /// Web Services Support</a> to request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ThrottlingException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/GetItem">REST API Reference for GetItem Operation</seealso>
        public virtual GetItemResponse GetItem(GetItemRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetItemResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = GetItemEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<GetItemResponse>(request, options);
        }


        /// <summary>
        /// The <c>GetItem</c> operation returns a set of attributes for the item with the given
        /// primary key. If there is no matching item, <c>GetItem</c> does not return any data
        /// and there will be no <c>Item</c> element in the response.
        /// 
        ///  
        /// <para>
        ///  <c>GetItem</c> provides an eventually consistent read by default. If your application
        /// requires a strongly consistent read, set <c>ConsistentRead</c> to <c>true</c>. Although
        /// a strongly consistent read might take more time than an eventually consistent read,
        /// it always returns the last updated value.
        /// </para>
        /// </summary>
        /// <param name="tableName">The name of the table containing the requested item. You can also provide the Amazon Resource Name (ARN) of the table in this parameter.</param>
        /// <param name="key">A map of attribute names to <c>AttributeValue</c> objects, representing the primary key of the item to retrieve. For the primary key, you must provide all of the attributes. For example, with a simple primary key, you only need to provide a value for the partition key. For a composite primary key, you must provide values for both the partition key and the sort key.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetItem service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. The Amazon Web Services SDKs for DynamoDB automatically
        /// retry requests that receive this exception. Your request is eventually successful,
        /// unless your retry queue is too large to finish. Reduce the frequency of requests and
        /// use exponential backoff. For more information, go to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Programming.Errors.html#Programming.Errors.RetryAndBackoff">Error
        /// Retries and Exponential Backoff</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.RequestLimitExceededException">
        /// Throughput exceeds the current throughput quota for your account. For detailed information
        /// about why the request was throttled and the ARN of the impacted resource, find the
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. Contact <a href="https://aws.amazon.com/support">Amazon
        /// Web Services Support</a> to request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ThrottlingException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/GetItem">REST API Reference for GetItem Operation</seealso>
        public virtual Task<GetItemResponse> GetItemAsync(string tableName, Dictionary<string, AttributeValue> key, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetItemRequest();
            request.TableName = tableName;
            request.Key = key;
            return GetItemAsync(request, cancellationToken);
        }


        /// <summary>
        /// The <c>GetItem</c> operation returns a set of attributes for the item with the given
        /// primary key. If there is no matching item, <c>GetItem</c> does not return any data
        /// and there will be no <c>Item</c> element in the response.
        /// 
        ///  
        /// <para>
        ///  <c>GetItem</c> provides an eventually consistent read by default. If your application
        /// requires a strongly consistent read, set <c>ConsistentRead</c> to <c>true</c>. Although
        /// a strongly consistent read might take more time than an eventually consistent read,
        /// it always returns the last updated value.
        /// </para>
        /// </summary>
        /// <param name="tableName">The name of the table containing the requested item. You can also provide the Amazon Resource Name (ARN) of the table in this parameter.</param>
        /// <param name="key">A map of attribute names to <c>AttributeValue</c> objects, representing the primary key of the item to retrieve. For the primary key, you must provide all of the attributes. For example, with a simple primary key, you only need to provide a value for the partition key. For a composite primary key, you must provide values for both the partition key and the sort key.</param>
        /// <param name="consistentRead">Determines the read consistency model: If set to <c>true</c>, then the operation uses strongly consistent reads; otherwise, the operation uses eventually consistent reads.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetItem service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. The Amazon Web Services SDKs for DynamoDB automatically
        /// retry requests that receive this exception. Your request is eventually successful,
        /// unless your retry queue is too large to finish. Reduce the frequency of requests and
        /// use exponential backoff. For more information, go to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Programming.Errors.html#Programming.Errors.RetryAndBackoff">Error
        /// Retries and Exponential Backoff</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.RequestLimitExceededException">
        /// Throughput exceeds the current throughput quota for your account. For detailed information
        /// about why the request was throttled and the ARN of the impacted resource, find the
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. Contact <a href="https://aws.amazon.com/support">Amazon
        /// Web Services Support</a> to request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ThrottlingException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/GetItem">REST API Reference for GetItem Operation</seealso>
        public virtual Task<GetItemResponse> GetItemAsync(string tableName, Dictionary<string, AttributeValue> key, bool? consistentRead, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetItemRequest();
            request.TableName = tableName;
            request.Key = key;
            request.ConsistentRead = consistentRead;
            return GetItemAsync(request, cancellationToken);
        }


        /// <summary>
        /// The <c>GetItem</c> operation returns a set of attributes for the item with the given
        /// primary key. If there is no matching item, <c>GetItem</c> does not return any data
        /// and there will be no <c>Item</c> element in the response.
        /// 
        ///  
        /// <para>
        ///  <c>GetItem</c> provides an eventually consistent read by default. If your application
        /// requires a strongly consistent read, set <c>ConsistentRead</c> to <c>true</c>. Although
        /// a strongly consistent read might take more time than an eventually consistent read,
        /// it always returns the last updated value.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetItem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetItem service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. The Amazon Web Services SDKs for DynamoDB automatically
        /// retry requests that receive this exception. Your request is eventually successful,
        /// unless your retry queue is too large to finish. Reduce the frequency of requests and
        /// use exponential backoff. For more information, go to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Programming.Errors.html#Programming.Errors.RetryAndBackoff">Error
        /// Retries and Exponential Backoff</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.RequestLimitExceededException">
        /// Throughput exceeds the current throughput quota for your account. For detailed information
        /// about why the request was throttled and the ARN of the impacted resource, find the
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. Contact <a href="https://aws.amazon.com/support">Amazon
        /// Web Services Support</a> to request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ThrottlingException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/GetItem">REST API Reference for GetItem Operation</seealso>
        public virtual Task<GetItemResponse> GetItemAsync(GetItemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetItemResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = GetItemEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;
            
            return InvokeAsync<GetItemResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetResourcePolicy


        /// <summary>
        /// Returns the resource-based policy document attached to the resource, which can be
        /// a table or stream, in JSON format.
        /// 
        ///  
        /// <para>
        ///  <c>GetResourcePolicy</c> follows an <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/HowItWorks.ReadConsistency.html">
        /// <i>eventually consistent</i> </a> model. The following list describes the outcomes
        /// when you issue the <c>GetResourcePolicy</c> request immediately after issuing another
        /// request:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you issue a <c>GetResourcePolicy</c> request immediately after a <c>PutResourcePolicy</c>
        /// request, DynamoDB might return a <c>PolicyNotFoundException</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you issue a <c>GetResourcePolicy</c>request immediately after a <c>DeleteResourcePolicy</c>
        /// request, DynamoDB might return the policy that was present before the deletion request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you issue a <c>GetResourcePolicy</c> request immediately after a <c>CreateTable</c>
        /// request, which includes a resource-based policy, DynamoDB might return a <c>ResourceNotFoundException</c>
        /// or a <c>PolicyNotFoundException</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Because <c>GetResourcePolicy</c> uses an <i>eventually consistent</i> query, the metadata
        /// for your policy or table might not be available at that moment. Wait for a few seconds,
        /// and then retry the <c>GetResourcePolicy</c> request.
        /// </para>
        ///  
        /// <para>
        /// After a <c>GetResourcePolicy</c> request returns a policy created using the <c>PutResourcePolicy</c>
        /// request, the policy will be applied in the authorization of requests to the resource.
        /// Because this process is eventually consistent, it will take some time to apply the
        /// policy to all requests to a resource. Policies that you attach while creating a table
        /// using the <c>CreateTable</c> request will always be applied to all requests for that
        /// table.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the GetResourcePolicy service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.PolicyNotFoundException">
        /// The operation tried to access a nonexistent resource-based policy.
        /// 
        ///  
        /// <para>
        /// If you specified an <c>ExpectedRevisionId</c>, it's possible that a policy is present
        /// for the resource but its revision ID didn't match the expected value.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        public virtual GetResourcePolicyResponse GetResourcePolicy(GetResourcePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePolicyResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = GetResourcePolicyEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<GetResourcePolicyResponse>(request, options);
        }


        /// <summary>
        /// Returns the resource-based policy document attached to the resource, which can be
        /// a table or stream, in JSON format.
        /// 
        ///  
        /// <para>
        ///  <c>GetResourcePolicy</c> follows an <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/HowItWorks.ReadConsistency.html">
        /// <i>eventually consistent</i> </a> model. The following list describes the outcomes
        /// when you issue the <c>GetResourcePolicy</c> request immediately after issuing another
        /// request:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you issue a <c>GetResourcePolicy</c> request immediately after a <c>PutResourcePolicy</c>
        /// request, DynamoDB might return a <c>PolicyNotFoundException</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you issue a <c>GetResourcePolicy</c>request immediately after a <c>DeleteResourcePolicy</c>
        /// request, DynamoDB might return the policy that was present before the deletion request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you issue a <c>GetResourcePolicy</c> request immediately after a <c>CreateTable</c>
        /// request, which includes a resource-based policy, DynamoDB might return a <c>ResourceNotFoundException</c>
        /// or a <c>PolicyNotFoundException</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Because <c>GetResourcePolicy</c> uses an <i>eventually consistent</i> query, the metadata
        /// for your policy or table might not be available at that moment. Wait for a few seconds,
        /// and then retry the <c>GetResourcePolicy</c> request.
        /// </para>
        ///  
        /// <para>
        /// After a <c>GetResourcePolicy</c> request returns a policy created using the <c>PutResourcePolicy</c>
        /// request, the policy will be applied in the authorization of requests to the resource.
        /// Because this process is eventually consistent, it will take some time to apply the
        /// policy to all requests to a resource. Policies that you attach while creating a table
        /// using the <c>CreateTable</c> request will always be applied to all requests for that
        /// table.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResourcePolicy service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.PolicyNotFoundException">
        /// The operation tried to access a nonexistent resource-based policy.
        /// 
        ///  
        /// <para>
        /// If you specified an <c>ExpectedRevisionId</c>, it's possible that a policy is present
        /// for the resource but its revision ID didn't match the expected value.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        public virtual Task<GetResourcePolicyResponse> GetResourcePolicyAsync(GetResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePolicyResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = GetResourcePolicyEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;
            
            return InvokeAsync<GetResourcePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ImportTable


        /// <summary>
        /// Imports table data from an S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportTable service method.</param>
        /// 
        /// <returns>The response from the ImportTable service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.ImportConflictException">
        /// There was a conflict when importing from the specified S3 source. This can occur
        /// when the current import conflicts with a previous import request that had the same
        /// client token.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.LimitExceededException">
        /// There is no limit to the number of daily on-demand backups that can be taken. 
        /// 
        ///  
        /// <para>
        /// For most purposes, up to 500 simultaneous table operations are allowed per account.
        /// These operations include <c>CreateTable</c>, <c>UpdateTable</c>, <c>DeleteTable</c>,<c>UpdateTimeToLive</c>,
        /// <c>RestoreTableFromBackup</c>, and <c>RestoreTableToPointInTime</c>. 
        /// </para>
        ///  
        /// <para>
        /// When you are creating a table with one or more secondary indexes, you can have up
        /// to 250 such requests running at a time. However, if the table or index specifications
        /// are complex, then DynamoDB might temporarily reduce the number of concurrent operations.
        /// </para>
        ///  
        /// <para>
        /// When importing into DynamoDB, up to 50 simultaneous import table operations are allowed
        /// per account.
        /// </para>
        ///  
        /// <para>
        /// There is a soft account quota of 2,500 tables.
        /// </para>
        ///  
        /// <para>
        /// GetRecords was called with a value of more than 1000 for the limit request parameter.
        /// </para>
        ///  
        /// <para>
        /// More than 2 processes are reading from the same streams shard at the same time. Exceeding
        /// this limit may result in request throttling.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceInUseException">
        /// The operation conflicts with the resource's availability. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You attempted to recreate an existing table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a table currently in the <c>CREATING</c> state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a resource that was already being updated.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When appropriate, wait for the ongoing update to complete and attempt the request
        /// again.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/ImportTable">REST API Reference for ImportTable Operation</seealso>
        public virtual ImportTableResponse ImportTable(ImportTableRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ImportTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportTableResponseUnmarshaller.Instance;

            return Invoke<ImportTableResponse>(request, options);
        }


        /// <summary>
        /// Imports table data from an S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportTable service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.ImportConflictException">
        /// There was a conflict when importing from the specified S3 source. This can occur
        /// when the current import conflicts with a previous import request that had the same
        /// client token.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.LimitExceededException">
        /// There is no limit to the number of daily on-demand backups that can be taken. 
        /// 
        ///  
        /// <para>
        /// For most purposes, up to 500 simultaneous table operations are allowed per account.
        /// These operations include <c>CreateTable</c>, <c>UpdateTable</c>, <c>DeleteTable</c>,<c>UpdateTimeToLive</c>,
        /// <c>RestoreTableFromBackup</c>, and <c>RestoreTableToPointInTime</c>. 
        /// </para>
        ///  
        /// <para>
        /// When you are creating a table with one or more secondary indexes, you can have up
        /// to 250 such requests running at a time. However, if the table or index specifications
        /// are complex, then DynamoDB might temporarily reduce the number of concurrent operations.
        /// </para>
        ///  
        /// <para>
        /// When importing into DynamoDB, up to 50 simultaneous import table operations are allowed
        /// per account.
        /// </para>
        ///  
        /// <para>
        /// There is a soft account quota of 2,500 tables.
        /// </para>
        ///  
        /// <para>
        /// GetRecords was called with a value of more than 1000 for the limit request parameter.
        /// </para>
        ///  
        /// <para>
        /// More than 2 processes are reading from the same streams shard at the same time. Exceeding
        /// this limit may result in request throttling.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceInUseException">
        /// The operation conflicts with the resource's availability. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You attempted to recreate an existing table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a table currently in the <c>CREATING</c> state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a resource that was already being updated.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When appropriate, wait for the ongoing update to complete and attempt the request
        /// again.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/ImportTable">REST API Reference for ImportTable Operation</seealso>
        public virtual Task<ImportTableResponse> ImportTableAsync(ImportTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ImportTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportTableResponseUnmarshaller.Instance;
            
            return InvokeAsync<ImportTableResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListBackups


        /// <summary>
        /// List DynamoDB backups that are associated with an Amazon Web Services account and
        /// weren't made with Amazon Web Services Backup. To list these backups for a given table,
        /// specify <c>TableName</c>. <c>ListBackups</c> returns a paginated list of results with
        /// at most 1 MB worth of items in a page. You can also specify a maximum number of entries
        /// to be returned in a page.
        /// 
        ///  
        /// <para>
        /// In the request, start time is inclusive, but end time is exclusive. Note that these
        /// boundaries are for the time at which the original backup was requested.
        /// </para>
        ///  
        /// <para>
        /// You can call <c>ListBackups</c> a maximum of five times per second.
        /// </para>
        ///  
        /// <para>
        /// If you want to retrieve the complete list of backups made with Amazon Web Services
        /// Backup, use the <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/API_ListBackupJobs.html">Amazon
        /// Web Services Backup list API.</a> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBackups service method.</param>
        /// 
        /// <returns>The response from the ListBackups service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/ListBackups">REST API Reference for ListBackups Operation</seealso>
        public virtual ListBackupsResponse ListBackups(ListBackupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBackupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBackupsResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = ListBackupsEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<ListBackupsResponse>(request, options);
        }


        /// <summary>
        /// List DynamoDB backups that are associated with an Amazon Web Services account and
        /// weren't made with Amazon Web Services Backup. To list these backups for a given table,
        /// specify <c>TableName</c>. <c>ListBackups</c> returns a paginated list of results with
        /// at most 1 MB worth of items in a page. You can also specify a maximum number of entries
        /// to be returned in a page.
        /// 
        ///  
        /// <para>
        /// In the request, start time is inclusive, but end time is exclusive. Note that these
        /// boundaries are for the time at which the original backup was requested.
        /// </para>
        ///  
        /// <para>
        /// You can call <c>ListBackups</c> a maximum of five times per second.
        /// </para>
        ///  
        /// <para>
        /// If you want to retrieve the complete list of backups made with Amazon Web Services
        /// Backup, use the <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/API_ListBackupJobs.html">Amazon
        /// Web Services Backup list API.</a> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBackups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBackups service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/ListBackups">REST API Reference for ListBackups Operation</seealso>
        public virtual Task<ListBackupsResponse> ListBackupsAsync(ListBackupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBackupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBackupsResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = ListBackupsEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;
            
            return InvokeAsync<ListBackupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListContributorInsights


        /// <summary>
        /// Returns a list of ContributorInsightsSummary for a table and all its global secondary
        /// indexes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListContributorInsights service method.</param>
        /// 
        /// <returns>The response from the ListContributorInsights service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/ListContributorInsights">REST API Reference for ListContributorInsights Operation</seealso>
        public virtual ListContributorInsightsResponse ListContributorInsights(ListContributorInsightsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListContributorInsightsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListContributorInsightsResponseUnmarshaller.Instance;

            return Invoke<ListContributorInsightsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of ContributorInsightsSummary for a table and all its global secondary
        /// indexes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListContributorInsights service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListContributorInsights service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/ListContributorInsights">REST API Reference for ListContributorInsights Operation</seealso>
        public virtual Task<ListContributorInsightsResponse> ListContributorInsightsAsync(ListContributorInsightsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListContributorInsightsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListContributorInsightsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListContributorInsightsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListExports


        /// <summary>
        /// Lists completed exports within the past 90 days.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExports service method.</param>
        /// 
        /// <returns>The response from the ListExports service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.LimitExceededException">
        /// There is no limit to the number of daily on-demand backups that can be taken. 
        /// 
        ///  
        /// <para>
        /// For most purposes, up to 500 simultaneous table operations are allowed per account.
        /// These operations include <c>CreateTable</c>, <c>UpdateTable</c>, <c>DeleteTable</c>,<c>UpdateTimeToLive</c>,
        /// <c>RestoreTableFromBackup</c>, and <c>RestoreTableToPointInTime</c>. 
        /// </para>
        ///  
        /// <para>
        /// When you are creating a table with one or more secondary indexes, you can have up
        /// to 250 such requests running at a time. However, if the table or index specifications
        /// are complex, then DynamoDB might temporarily reduce the number of concurrent operations.
        /// </para>
        ///  
        /// <para>
        /// When importing into DynamoDB, up to 50 simultaneous import table operations are allowed
        /// per account.
        /// </para>
        ///  
        /// <para>
        /// There is a soft account quota of 2,500 tables.
        /// </para>
        ///  
        /// <para>
        /// GetRecords was called with a value of more than 1000 for the limit request parameter.
        /// </para>
        ///  
        /// <para>
        /// More than 2 processes are reading from the same streams shard at the same time. Exceeding
        /// this limit may result in request throttling.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/ListExports">REST API Reference for ListExports Operation</seealso>
        public virtual ListExportsResponse ListExports(ListExportsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListExportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExportsResponseUnmarshaller.Instance;

            return Invoke<ListExportsResponse>(request, options);
        }


        /// <summary>
        /// Lists completed exports within the past 90 days.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExports service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListExports service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.LimitExceededException">
        /// There is no limit to the number of daily on-demand backups that can be taken. 
        /// 
        ///  
        /// <para>
        /// For most purposes, up to 500 simultaneous table operations are allowed per account.
        /// These operations include <c>CreateTable</c>, <c>UpdateTable</c>, <c>DeleteTable</c>,<c>UpdateTimeToLive</c>,
        /// <c>RestoreTableFromBackup</c>, and <c>RestoreTableToPointInTime</c>. 
        /// </para>
        ///  
        /// <para>
        /// When you are creating a table with one or more secondary indexes, you can have up
        /// to 250 such requests running at a time. However, if the table or index specifications
        /// are complex, then DynamoDB might temporarily reduce the number of concurrent operations.
        /// </para>
        ///  
        /// <para>
        /// When importing into DynamoDB, up to 50 simultaneous import table operations are allowed
        /// per account.
        /// </para>
        ///  
        /// <para>
        /// There is a soft account quota of 2,500 tables.
        /// </para>
        ///  
        /// <para>
        /// GetRecords was called with a value of more than 1000 for the limit request parameter.
        /// </para>
        ///  
        /// <para>
        /// More than 2 processes are reading from the same streams shard at the same time. Exceeding
        /// this limit may result in request throttling.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/ListExports">REST API Reference for ListExports Operation</seealso>
        public virtual Task<ListExportsResponse> ListExportsAsync(ListExportsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListExportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListExportsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListExportsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListGlobalTables


        /// <summary>
        /// Lists all global tables that have a replica in the specified Region.
        /// 
        ///  <important> 
        /// <para>
        /// This documentation is for version 2017.11.29 (Legacy) of global tables, which should
        /// be avoided for new global tables. Customers should use <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/GlobalTables.html">Global
        /// Tables version 2019.11.21 (Current)</a> when possible, because it provides greater
        /// flexibility, higher efficiency, and consumes less write capacity than 2017.11.29 (Legacy).
        /// </para>
        ///  
        /// <para>
        /// To determine which version you're using, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/globaltables.DetermineVersion.html">Determining
        /// the global table version you are using</a>. To update existing global tables from
        /// version 2017.11.29 (Legacy) to version 2019.11.21 (Current), see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/V2globaltables_upgrade.html">Upgrading
        /// global tables</a>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGlobalTables service method.</param>
        /// 
        /// <returns>The response from the ListGlobalTables service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/ListGlobalTables">REST API Reference for ListGlobalTables Operation</seealso>
        public virtual ListGlobalTablesResponse ListGlobalTables(ListGlobalTablesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGlobalTablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGlobalTablesResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = ListGlobalTablesEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<ListGlobalTablesResponse>(request, options);
        }


        /// <summary>
        /// Lists all global tables that have a replica in the specified Region.
        /// 
        ///  <important> 
        /// <para>
        /// This documentation is for version 2017.11.29 (Legacy) of global tables, which should
        /// be avoided for new global tables. Customers should use <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/GlobalTables.html">Global
        /// Tables version 2019.11.21 (Current)</a> when possible, because it provides greater
        /// flexibility, higher efficiency, and consumes less write capacity than 2017.11.29 (Legacy).
        /// </para>
        ///  
        /// <para>
        /// To determine which version you're using, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/globaltables.DetermineVersion.html">Determining
        /// the global table version you are using</a>. To update existing global tables from
        /// version 2017.11.29 (Legacy) to version 2019.11.21 (Current), see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/V2globaltables_upgrade.html">Upgrading
        /// global tables</a>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGlobalTables service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGlobalTables service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/ListGlobalTables">REST API Reference for ListGlobalTables Operation</seealso>
        public virtual Task<ListGlobalTablesResponse> ListGlobalTablesAsync(ListGlobalTablesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListGlobalTablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGlobalTablesResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = ListGlobalTablesEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;
            
            return InvokeAsync<ListGlobalTablesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListImports


        /// <summary>
        /// Lists completed imports within the past 90 days.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImports service method.</param>
        /// 
        /// <returns>The response from the ListImports service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.LimitExceededException">
        /// There is no limit to the number of daily on-demand backups that can be taken. 
        /// 
        ///  
        /// <para>
        /// For most purposes, up to 500 simultaneous table operations are allowed per account.
        /// These operations include <c>CreateTable</c>, <c>UpdateTable</c>, <c>DeleteTable</c>,<c>UpdateTimeToLive</c>,
        /// <c>RestoreTableFromBackup</c>, and <c>RestoreTableToPointInTime</c>. 
        /// </para>
        ///  
        /// <para>
        /// When you are creating a table with one or more secondary indexes, you can have up
        /// to 250 such requests running at a time. However, if the table or index specifications
        /// are complex, then DynamoDB might temporarily reduce the number of concurrent operations.
        /// </para>
        ///  
        /// <para>
        /// When importing into DynamoDB, up to 50 simultaneous import table operations are allowed
        /// per account.
        /// </para>
        ///  
        /// <para>
        /// There is a soft account quota of 2,500 tables.
        /// </para>
        ///  
        /// <para>
        /// GetRecords was called with a value of more than 1000 for the limit request parameter.
        /// </para>
        ///  
        /// <para>
        /// More than 2 processes are reading from the same streams shard at the same time. Exceeding
        /// this limit may result in request throttling.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/ListImports">REST API Reference for ListImports Operation</seealso>
        public virtual ListImportsResponse ListImports(ListImportsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListImportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImportsResponseUnmarshaller.Instance;

            return Invoke<ListImportsResponse>(request, options);
        }


        /// <summary>
        /// Lists completed imports within the past 90 days.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImports service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListImports service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.LimitExceededException">
        /// There is no limit to the number of daily on-demand backups that can be taken. 
        /// 
        ///  
        /// <para>
        /// For most purposes, up to 500 simultaneous table operations are allowed per account.
        /// These operations include <c>CreateTable</c>, <c>UpdateTable</c>, <c>DeleteTable</c>,<c>UpdateTimeToLive</c>,
        /// <c>RestoreTableFromBackup</c>, and <c>RestoreTableToPointInTime</c>. 
        /// </para>
        ///  
        /// <para>
        /// When you are creating a table with one or more secondary indexes, you can have up
        /// to 250 such requests running at a time. However, if the table or index specifications
        /// are complex, then DynamoDB might temporarily reduce the number of concurrent operations.
        /// </para>
        ///  
        /// <para>
        /// When importing into DynamoDB, up to 50 simultaneous import table operations are allowed
        /// per account.
        /// </para>
        ///  
        /// <para>
        /// There is a soft account quota of 2,500 tables.
        /// </para>
        ///  
        /// <para>
        /// GetRecords was called with a value of more than 1000 for the limit request parameter.
        /// </para>
        ///  
        /// <para>
        /// More than 2 processes are reading from the same streams shard at the same time. Exceeding
        /// this limit may result in request throttling.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/ListImports">REST API Reference for ListImports Operation</seealso>
        public virtual Task<ListImportsResponse> ListImportsAsync(ListImportsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListImportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListImportsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListImportsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTables


        /// <summary>
        /// Returns an array of table names associated with the current account and endpoint.
        /// The output from <c>ListTables</c> is paginated, with each page returning a maximum
        /// of 100 table names.
        /// </summary>
        /// 
        /// <returns>The response from the ListTables service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/ListTables">REST API Reference for ListTables Operation</seealso>
        public virtual ListTablesResponse ListTables()
        {
            return ListTables(new ListTablesRequest());
        }


        /// <summary>
        /// Returns an array of table names associated with the current account and endpoint.
        /// The output from <c>ListTables</c> is paginated, with each page returning a maximum
        /// of 100 table names.
        /// </summary>
        /// <param name="exclusiveStartTableName">The first table name that this operation will evaluate. Use the value that was returned for <c>LastEvaluatedTableName</c> in a previous operation, so that you can obtain the next page of results.</param>
        /// 
        /// <returns>The response from the ListTables service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/ListTables">REST API Reference for ListTables Operation</seealso>
        public virtual ListTablesResponse ListTables(string exclusiveStartTableName)
        {
            var request = new ListTablesRequest();
            request.ExclusiveStartTableName = exclusiveStartTableName;
            return ListTables(request);
        }


        /// <summary>
        /// Returns an array of table names associated with the current account and endpoint.
        /// The output from <c>ListTables</c> is paginated, with each page returning a maximum
        /// of 100 table names.
        /// </summary>
        /// <param name="exclusiveStartTableName">The first table name that this operation will evaluate. Use the value that was returned for <c>LastEvaluatedTableName</c> in a previous operation, so that you can obtain the next page of results.</param>
        /// <param name="limit">A maximum number of table names to return. If this parameter is not specified, the limit is 100.</param>
        /// 
        /// <returns>The response from the ListTables service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/ListTables">REST API Reference for ListTables Operation</seealso>
        public virtual ListTablesResponse ListTables(string exclusiveStartTableName, int? limit)
        {
            var request = new ListTablesRequest();
            request.ExclusiveStartTableName = exclusiveStartTableName;
            request.Limit = limit;
            return ListTables(request);
        }


        /// <summary>
        /// Returns an array of table names associated with the current account and endpoint.
        /// The output from <c>ListTables</c> is paginated, with each page returning a maximum
        /// of 100 table names.
        /// </summary>
        /// <param name="limit">A maximum number of table names to return. If this parameter is not specified, the limit is 100.</param>
        /// 
        /// <returns>The response from the ListTables service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/ListTables">REST API Reference for ListTables Operation</seealso>
        public virtual ListTablesResponse ListTables(int? limit)
        {
            var request = new ListTablesRequest();
            request.Limit = limit;
            return ListTables(request);
        }


        /// <summary>
        /// Returns an array of table names associated with the current account and endpoint.
        /// The output from <c>ListTables</c> is paginated, with each page returning a maximum
        /// of 100 table names.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTables service method.</param>
        /// 
        /// <returns>The response from the ListTables service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/ListTables">REST API Reference for ListTables Operation</seealso>
        public virtual ListTablesResponse ListTables(ListTablesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTablesResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = ListTablesEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<ListTablesResponse>(request, options);
        }


        /// <summary>
        /// Returns an array of table names associated with the current account and endpoint.
        /// The output from <c>ListTables</c> is paginated, with each page returning a maximum
        /// of 100 table names.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTables service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/ListTables">REST API Reference for ListTables Operation</seealso>
        public virtual Task<ListTablesResponse> ListTablesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListTablesAsync(new ListTablesRequest(), cancellationToken);
        }

        /// <summary>
        /// Returns an array of table names associated with the current account and endpoint.
        /// The output from <c>ListTables</c> is paginated, with each page returning a maximum
        /// of 100 table names.
        /// </summary>
        /// <param name="exclusiveStartTableName">The first table name that this operation will evaluate. Use the value that was returned for <c>LastEvaluatedTableName</c> in a previous operation, so that you can obtain the next page of results.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTables service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/ListTables">REST API Reference for ListTables Operation</seealso>
        public virtual Task<ListTablesResponse> ListTablesAsync(string exclusiveStartTableName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListTablesRequest();
            request.ExclusiveStartTableName = exclusiveStartTableName;
            return ListTablesAsync(request, cancellationToken);
        }


        /// <summary>
        /// Returns an array of table names associated with the current account and endpoint.
        /// The output from <c>ListTables</c> is paginated, with each page returning a maximum
        /// of 100 table names.
        /// </summary>
        /// <param name="exclusiveStartTableName">The first table name that this operation will evaluate. Use the value that was returned for <c>LastEvaluatedTableName</c> in a previous operation, so that you can obtain the next page of results.</param>
        /// <param name="limit">A maximum number of table names to return. If this parameter is not specified, the limit is 100.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTables service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/ListTables">REST API Reference for ListTables Operation</seealso>
        public virtual Task<ListTablesResponse> ListTablesAsync(string exclusiveStartTableName, int? limit, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListTablesRequest();
            request.ExclusiveStartTableName = exclusiveStartTableName;
            request.Limit = limit;
            return ListTablesAsync(request, cancellationToken);
        }


        /// <summary>
        /// Returns an array of table names associated with the current account and endpoint.
        /// The output from <c>ListTables</c> is paginated, with each page returning a maximum
        /// of 100 table names.
        /// </summary>
        /// <param name="limit">A maximum number of table names to return. If this parameter is not specified, the limit is 100.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTables service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/ListTables">REST API Reference for ListTables Operation</seealso>
        public virtual Task<ListTablesResponse> ListTablesAsync(int? limit, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListTablesRequest();
            request.Limit = limit;
            return ListTablesAsync(request, cancellationToken);
        }


        /// <summary>
        /// Returns an array of table names associated with the current account and endpoint.
        /// The output from <c>ListTables</c> is paginated, with each page returning a maximum
        /// of 100 table names.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTables service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTables service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/ListTables">REST API Reference for ListTables Operation</seealso>
        public virtual Task<ListTablesResponse> ListTablesAsync(ListTablesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTablesResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = ListTablesEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;
            
            return InvokeAsync<ListTablesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsOfResource


        /// <summary>
        /// List all tags on an Amazon DynamoDB resource. You can call ListTagsOfResource up to
        /// 10 times per second, per account.
        /// 
        ///  
        /// <para>
        /// For an overview on tagging DynamoDB resources, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Tagging.html">Tagging
        /// for DynamoDB</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsOfResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsOfResource service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/ListTagsOfResource">REST API Reference for ListTagsOfResource Operation</seealso>
        public virtual ListTagsOfResourceResponse ListTagsOfResource(ListTagsOfResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsOfResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsOfResourceResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = ListTagsOfResourceEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<ListTagsOfResourceResponse>(request, options);
        }


        /// <summary>
        /// List all tags on an Amazon DynamoDB resource. You can call ListTagsOfResource up to
        /// 10 times per second, per account.
        /// 
        ///  
        /// <para>
        /// For an overview on tagging DynamoDB resources, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Tagging.html">Tagging
        /// for DynamoDB</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsOfResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsOfResource service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/ListTagsOfResource">REST API Reference for ListTagsOfResource Operation</seealso>
        public virtual Task<ListTagsOfResourceResponse> ListTagsOfResourceAsync(ListTagsOfResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsOfResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsOfResourceResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = ListTagsOfResourceEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;
            
            return InvokeAsync<ListTagsOfResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutItem


        /// <summary>
        /// Creates a new item, or replaces an old item with a new item. If an item that has the
        /// same primary key as the new item already exists in the specified table, the new item
        /// completely replaces the existing item. You can perform a conditional put operation
        /// (add a new item if one with the specified primary key doesn't exist), or replace an
        /// existing item if it has certain attribute values. You can return the item's attribute
        /// values in the same operation, using the <c>ReturnValues</c> parameter.
        /// 
        ///  
        /// <para>
        /// When you add an item, the primary key attributes are the only required attributes.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Empty String and Binary attribute values are allowed. Attribute values of type String
        /// and Binary must have a length greater than zero if the attribute is used as a key
        /// attribute for a table or index. Set type attributes cannot be empty. 
        /// </para>
        ///  
        /// <para>
        /// Invalid Requests with empty values will be rejected with a <c>ValidationException</c>
        /// exception.
        /// </para>
        ///  <note> 
        /// <para>
        /// To prevent a new item from replacing an existing item, use a conditional expression
        /// that contains the <c>attribute_not_exists</c> function with the name of the attribute
        /// being used as the partition key for the table. Since every record must contain that
        /// attribute, the <c>attribute_not_exists</c> function will only succeed if no matching
        /// item exists.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information about <c>PutItem</c>, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/WorkingWithItems.html">Working
        /// with Items</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="tableName">The name of the table to contain the item. You can also provide the Amazon Resource Name (ARN) of the table in this parameter.</param>
        /// <param name="item">A map of attribute name/value pairs, one for each attribute. Only the primary key attributes are required; you can optionally provide other attribute name-value pairs for the item. You must provide all of the attributes for the primary key. For example, with a simple primary key, you only need to provide a value for the partition key. For a composite primary key, you must provide both values for both the partition key and the sort key. If you specify any attributes that are part of an index key, then the data types for those attributes must match those of the schema in the table's attribute definition. Empty String and Binary attribute values are allowed. Attribute values of type String and Binary must have a length greater than zero if the attribute is used as a key attribute for a table or index. For more information about primary keys, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/HowItWorks.CoreComponents.html#HowItWorks.CoreComponents.PrimaryKey">Primary Key</a> in the <i>Amazon DynamoDB Developer Guide</i>. Each element in the <c>Item</c> map is an <c>AttributeValue</c> object.</param>
        /// 
        /// <returns>The response from the PutItem service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.ConditionalCheckFailedException">
        /// A condition specified in the operation failed to be evaluated.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ItemCollectionSizeLimitExceededException">
        /// An item collection is too large. This exception is only returned for tables that have
        /// one or more local secondary indexes.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. The Amazon Web Services SDKs for DynamoDB automatically
        /// retry requests that receive this exception. Your request is eventually successful,
        /// unless your retry queue is too large to finish. Reduce the frequency of requests and
        /// use exponential backoff. For more information, go to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Programming.Errors.html#Programming.Errors.RetryAndBackoff">Error
        /// Retries and Exponential Backoff</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ReplicatedWriteConflictException">
        /// The request was rejected because one or more items in the request are being modified
        /// by a request in another Region.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.RequestLimitExceededException">
        /// Throughput exceeds the current throughput quota for your account. For detailed information
        /// about why the request was throttled and the ARN of the impacted resource, find the
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. Contact <a href="https://aws.amazon.com/support">Amazon
        /// Web Services Support</a> to request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ThrottlingException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.TransactionConflictException">
        /// Operation was rejected because there is an ongoing transaction for the item.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/PutItem">REST API Reference for PutItem Operation</seealso>
        public virtual PutItemResponse PutItem(string tableName, Dictionary<string, AttributeValue> item)
        {
            var request = new PutItemRequest();
            request.TableName = tableName;
            request.Item = item;
            return PutItem(request);
        }


        /// <summary>
        /// Creates a new item, or replaces an old item with a new item. If an item that has the
        /// same primary key as the new item already exists in the specified table, the new item
        /// completely replaces the existing item. You can perform a conditional put operation
        /// (add a new item if one with the specified primary key doesn't exist), or replace an
        /// existing item if it has certain attribute values. You can return the item's attribute
        /// values in the same operation, using the <c>ReturnValues</c> parameter.
        /// 
        ///  
        /// <para>
        /// When you add an item, the primary key attributes are the only required attributes.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Empty String and Binary attribute values are allowed. Attribute values of type String
        /// and Binary must have a length greater than zero if the attribute is used as a key
        /// attribute for a table or index. Set type attributes cannot be empty. 
        /// </para>
        ///  
        /// <para>
        /// Invalid Requests with empty values will be rejected with a <c>ValidationException</c>
        /// exception.
        /// </para>
        ///  <note> 
        /// <para>
        /// To prevent a new item from replacing an existing item, use a conditional expression
        /// that contains the <c>attribute_not_exists</c> function with the name of the attribute
        /// being used as the partition key for the table. Since every record must contain that
        /// attribute, the <c>attribute_not_exists</c> function will only succeed if no matching
        /// item exists.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information about <c>PutItem</c>, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/WorkingWithItems.html">Working
        /// with Items</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="tableName">The name of the table to contain the item. You can also provide the Amazon Resource Name (ARN) of the table in this parameter.</param>
        /// <param name="item">A map of attribute name/value pairs, one for each attribute. Only the primary key attributes are required; you can optionally provide other attribute name-value pairs for the item. You must provide all of the attributes for the primary key. For example, with a simple primary key, you only need to provide a value for the partition key. For a composite primary key, you must provide both values for both the partition key and the sort key. If you specify any attributes that are part of an index key, then the data types for those attributes must match those of the schema in the table's attribute definition. Empty String and Binary attribute values are allowed. Attribute values of type String and Binary must have a length greater than zero if the attribute is used as a key attribute for a table or index. For more information about primary keys, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/HowItWorks.CoreComponents.html#HowItWorks.CoreComponents.PrimaryKey">Primary Key</a> in the <i>Amazon DynamoDB Developer Guide</i>. Each element in the <c>Item</c> map is an <c>AttributeValue</c> object.</param>
        /// <param name="returnValues">Use <c>ReturnValues</c> if you want to get the item attributes as they appeared before they were updated with the <c>PutItem</c> request. For <c>PutItem</c>, the valid values are: <ul> <li>  <c>NONE</c> - If <c>ReturnValues</c> is not specified, or if its value is <c>NONE</c>, then nothing is returned. (This setting is the default for <c>ReturnValues</c>.) </li> <li>  <c>ALL_OLD</c> - If <c>PutItem</c> overwrote an attribute name-value pair, then the content of the old item is returned. </li> </ul> The values returned are strongly consistent. There is no additional cost associated with requesting a return value aside from the small network and processing overhead of receiving a larger response. No read capacity units are consumed. <note> The <c>ReturnValues</c> parameter is used by several DynamoDB operations; however, <c>PutItem</c> does not recognize any values other than <c>NONE</c> or <c>ALL_OLD</c>. </note></param>
        /// 
        /// <returns>The response from the PutItem service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.ConditionalCheckFailedException">
        /// A condition specified in the operation failed to be evaluated.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ItemCollectionSizeLimitExceededException">
        /// An item collection is too large. This exception is only returned for tables that have
        /// one or more local secondary indexes.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. The Amazon Web Services SDKs for DynamoDB automatically
        /// retry requests that receive this exception. Your request is eventually successful,
        /// unless your retry queue is too large to finish. Reduce the frequency of requests and
        /// use exponential backoff. For more information, go to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Programming.Errors.html#Programming.Errors.RetryAndBackoff">Error
        /// Retries and Exponential Backoff</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ReplicatedWriteConflictException">
        /// The request was rejected because one or more items in the request are being modified
        /// by a request in another Region.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.RequestLimitExceededException">
        /// Throughput exceeds the current throughput quota for your account. For detailed information
        /// about why the request was throttled and the ARN of the impacted resource, find the
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. Contact <a href="https://aws.amazon.com/support">Amazon
        /// Web Services Support</a> to request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ThrottlingException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.TransactionConflictException">
        /// Operation was rejected because there is an ongoing transaction for the item.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/PutItem">REST API Reference for PutItem Operation</seealso>
        public virtual PutItemResponse PutItem(string tableName, Dictionary<string, AttributeValue> item, ReturnValue returnValues)
        {
            var request = new PutItemRequest();
            request.TableName = tableName;
            request.Item = item;
            request.ReturnValues = returnValues;
            return PutItem(request);
        }


        /// <summary>
        /// Creates a new item, or replaces an old item with a new item. If an item that has the
        /// same primary key as the new item already exists in the specified table, the new item
        /// completely replaces the existing item. You can perform a conditional put operation
        /// (add a new item if one with the specified primary key doesn't exist), or replace an
        /// existing item if it has certain attribute values. You can return the item's attribute
        /// values in the same operation, using the <c>ReturnValues</c> parameter.
        /// 
        ///  
        /// <para>
        /// When you add an item, the primary key attributes are the only required attributes.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Empty String and Binary attribute values are allowed. Attribute values of type String
        /// and Binary must have a length greater than zero if the attribute is used as a key
        /// attribute for a table or index. Set type attributes cannot be empty. 
        /// </para>
        ///  
        /// <para>
        /// Invalid Requests with empty values will be rejected with a <c>ValidationException</c>
        /// exception.
        /// </para>
        ///  <note> 
        /// <para>
        /// To prevent a new item from replacing an existing item, use a conditional expression
        /// that contains the <c>attribute_not_exists</c> function with the name of the attribute
        /// being used as the partition key for the table. Since every record must contain that
        /// attribute, the <c>attribute_not_exists</c> function will only succeed if no matching
        /// item exists.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information about <c>PutItem</c>, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/WorkingWithItems.html">Working
        /// with Items</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutItem service method.</param>
        /// 
        /// <returns>The response from the PutItem service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.ConditionalCheckFailedException">
        /// A condition specified in the operation failed to be evaluated.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ItemCollectionSizeLimitExceededException">
        /// An item collection is too large. This exception is only returned for tables that have
        /// one or more local secondary indexes.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. The Amazon Web Services SDKs for DynamoDB automatically
        /// retry requests that receive this exception. Your request is eventually successful,
        /// unless your retry queue is too large to finish. Reduce the frequency of requests and
        /// use exponential backoff. For more information, go to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Programming.Errors.html#Programming.Errors.RetryAndBackoff">Error
        /// Retries and Exponential Backoff</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ReplicatedWriteConflictException">
        /// The request was rejected because one or more items in the request are being modified
        /// by a request in another Region.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.RequestLimitExceededException">
        /// Throughput exceeds the current throughput quota for your account. For detailed information
        /// about why the request was throttled and the ARN of the impacted resource, find the
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. Contact <a href="https://aws.amazon.com/support">Amazon
        /// Web Services Support</a> to request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ThrottlingException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.TransactionConflictException">
        /// Operation was rejected because there is an ongoing transaction for the item.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/PutItem">REST API Reference for PutItem Operation</seealso>
        public virtual PutItemResponse PutItem(PutItemRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutItemResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = PutItemEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<PutItemResponse>(request, options);
        }


        /// <summary>
        /// Creates a new item, or replaces an old item with a new item. If an item that has the
        /// same primary key as the new item already exists in the specified table, the new item
        /// completely replaces the existing item. You can perform a conditional put operation
        /// (add a new item if one with the specified primary key doesn't exist), or replace an
        /// existing item if it has certain attribute values. You can return the item's attribute
        /// values in the same operation, using the <c>ReturnValues</c> parameter.
        /// 
        ///  
        /// <para>
        /// When you add an item, the primary key attributes are the only required attributes.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Empty String and Binary attribute values are allowed. Attribute values of type String
        /// and Binary must have a length greater than zero if the attribute is used as a key
        /// attribute for a table or index. Set type attributes cannot be empty. 
        /// </para>
        ///  
        /// <para>
        /// Invalid Requests with empty values will be rejected with a <c>ValidationException</c>
        /// exception.
        /// </para>
        ///  <note> 
        /// <para>
        /// To prevent a new item from replacing an existing item, use a conditional expression
        /// that contains the <c>attribute_not_exists</c> function with the name of the attribute
        /// being used as the partition key for the table. Since every record must contain that
        /// attribute, the <c>attribute_not_exists</c> function will only succeed if no matching
        /// item exists.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information about <c>PutItem</c>, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/WorkingWithItems.html">Working
        /// with Items</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="tableName">The name of the table to contain the item. You can also provide the Amazon Resource Name (ARN) of the table in this parameter.</param>
        /// <param name="item">A map of attribute name/value pairs, one for each attribute. Only the primary key attributes are required; you can optionally provide other attribute name-value pairs for the item. You must provide all of the attributes for the primary key. For example, with a simple primary key, you only need to provide a value for the partition key. For a composite primary key, you must provide both values for both the partition key and the sort key. If you specify any attributes that are part of an index key, then the data types for those attributes must match those of the schema in the table's attribute definition. Empty String and Binary attribute values are allowed. Attribute values of type String and Binary must have a length greater than zero if the attribute is used as a key attribute for a table or index. For more information about primary keys, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/HowItWorks.CoreComponents.html#HowItWorks.CoreComponents.PrimaryKey">Primary Key</a> in the <i>Amazon DynamoDB Developer Guide</i>. Each element in the <c>Item</c> map is an <c>AttributeValue</c> object.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutItem service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.ConditionalCheckFailedException">
        /// A condition specified in the operation failed to be evaluated.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ItemCollectionSizeLimitExceededException">
        /// An item collection is too large. This exception is only returned for tables that have
        /// one or more local secondary indexes.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. The Amazon Web Services SDKs for DynamoDB automatically
        /// retry requests that receive this exception. Your request is eventually successful,
        /// unless your retry queue is too large to finish. Reduce the frequency of requests and
        /// use exponential backoff. For more information, go to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Programming.Errors.html#Programming.Errors.RetryAndBackoff">Error
        /// Retries and Exponential Backoff</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ReplicatedWriteConflictException">
        /// The request was rejected because one or more items in the request are being modified
        /// by a request in another Region.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.RequestLimitExceededException">
        /// Throughput exceeds the current throughput quota for your account. For detailed information
        /// about why the request was throttled and the ARN of the impacted resource, find the
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. Contact <a href="https://aws.amazon.com/support">Amazon
        /// Web Services Support</a> to request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ThrottlingException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.TransactionConflictException">
        /// Operation was rejected because there is an ongoing transaction for the item.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/PutItem">REST API Reference for PutItem Operation</seealso>
        public virtual Task<PutItemResponse> PutItemAsync(string tableName, Dictionary<string, AttributeValue> item, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new PutItemRequest();
            request.TableName = tableName;
            request.Item = item;
            return PutItemAsync(request, cancellationToken);
        }


        /// <summary>
        /// Creates a new item, or replaces an old item with a new item. If an item that has the
        /// same primary key as the new item already exists in the specified table, the new item
        /// completely replaces the existing item. You can perform a conditional put operation
        /// (add a new item if one with the specified primary key doesn't exist), or replace an
        /// existing item if it has certain attribute values. You can return the item's attribute
        /// values in the same operation, using the <c>ReturnValues</c> parameter.
        /// 
        ///  
        /// <para>
        /// When you add an item, the primary key attributes are the only required attributes.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Empty String and Binary attribute values are allowed. Attribute values of type String
        /// and Binary must have a length greater than zero if the attribute is used as a key
        /// attribute for a table or index. Set type attributes cannot be empty. 
        /// </para>
        ///  
        /// <para>
        /// Invalid Requests with empty values will be rejected with a <c>ValidationException</c>
        /// exception.
        /// </para>
        ///  <note> 
        /// <para>
        /// To prevent a new item from replacing an existing item, use a conditional expression
        /// that contains the <c>attribute_not_exists</c> function with the name of the attribute
        /// being used as the partition key for the table. Since every record must contain that
        /// attribute, the <c>attribute_not_exists</c> function will only succeed if no matching
        /// item exists.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information about <c>PutItem</c>, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/WorkingWithItems.html">Working
        /// with Items</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="tableName">The name of the table to contain the item. You can also provide the Amazon Resource Name (ARN) of the table in this parameter.</param>
        /// <param name="item">A map of attribute name/value pairs, one for each attribute. Only the primary key attributes are required; you can optionally provide other attribute name-value pairs for the item. You must provide all of the attributes for the primary key. For example, with a simple primary key, you only need to provide a value for the partition key. For a composite primary key, you must provide both values for both the partition key and the sort key. If you specify any attributes that are part of an index key, then the data types for those attributes must match those of the schema in the table's attribute definition. Empty String and Binary attribute values are allowed. Attribute values of type String and Binary must have a length greater than zero if the attribute is used as a key attribute for a table or index. For more information about primary keys, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/HowItWorks.CoreComponents.html#HowItWorks.CoreComponents.PrimaryKey">Primary Key</a> in the <i>Amazon DynamoDB Developer Guide</i>. Each element in the <c>Item</c> map is an <c>AttributeValue</c> object.</param>
        /// <param name="returnValues">Use <c>ReturnValues</c> if you want to get the item attributes as they appeared before they were updated with the <c>PutItem</c> request. For <c>PutItem</c>, the valid values are: <ul> <li>  <c>NONE</c> - If <c>ReturnValues</c> is not specified, or if its value is <c>NONE</c>, then nothing is returned. (This setting is the default for <c>ReturnValues</c>.) </li> <li>  <c>ALL_OLD</c> - If <c>PutItem</c> overwrote an attribute name-value pair, then the content of the old item is returned. </li> </ul> The values returned are strongly consistent. There is no additional cost associated with requesting a return value aside from the small network and processing overhead of receiving a larger response. No read capacity units are consumed. <note> The <c>ReturnValues</c> parameter is used by several DynamoDB operations; however, <c>PutItem</c> does not recognize any values other than <c>NONE</c> or <c>ALL_OLD</c>. </note></param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutItem service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.ConditionalCheckFailedException">
        /// A condition specified in the operation failed to be evaluated.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ItemCollectionSizeLimitExceededException">
        /// An item collection is too large. This exception is only returned for tables that have
        /// one or more local secondary indexes.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. The Amazon Web Services SDKs for DynamoDB automatically
        /// retry requests that receive this exception. Your request is eventually successful,
        /// unless your retry queue is too large to finish. Reduce the frequency of requests and
        /// use exponential backoff. For more information, go to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Programming.Errors.html#Programming.Errors.RetryAndBackoff">Error
        /// Retries and Exponential Backoff</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ReplicatedWriteConflictException">
        /// The request was rejected because one or more items in the request are being modified
        /// by a request in another Region.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.RequestLimitExceededException">
        /// Throughput exceeds the current throughput quota for your account. For detailed information
        /// about why the request was throttled and the ARN of the impacted resource, find the
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. Contact <a href="https://aws.amazon.com/support">Amazon
        /// Web Services Support</a> to request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ThrottlingException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.TransactionConflictException">
        /// Operation was rejected because there is an ongoing transaction for the item.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/PutItem">REST API Reference for PutItem Operation</seealso>
        public virtual Task<PutItemResponse> PutItemAsync(string tableName, Dictionary<string, AttributeValue> item, ReturnValue returnValues, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new PutItemRequest();
            request.TableName = tableName;
            request.Item = item;
            request.ReturnValues = returnValues;
            return PutItemAsync(request, cancellationToken);
        }


        /// <summary>
        /// Creates a new item, or replaces an old item with a new item. If an item that has the
        /// same primary key as the new item already exists in the specified table, the new item
        /// completely replaces the existing item. You can perform a conditional put operation
        /// (add a new item if one with the specified primary key doesn't exist), or replace an
        /// existing item if it has certain attribute values. You can return the item's attribute
        /// values in the same operation, using the <c>ReturnValues</c> parameter.
        /// 
        ///  
        /// <para>
        /// When you add an item, the primary key attributes are the only required attributes.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Empty String and Binary attribute values are allowed. Attribute values of type String
        /// and Binary must have a length greater than zero if the attribute is used as a key
        /// attribute for a table or index. Set type attributes cannot be empty. 
        /// </para>
        ///  
        /// <para>
        /// Invalid Requests with empty values will be rejected with a <c>ValidationException</c>
        /// exception.
        /// </para>
        ///  <note> 
        /// <para>
        /// To prevent a new item from replacing an existing item, use a conditional expression
        /// that contains the <c>attribute_not_exists</c> function with the name of the attribute
        /// being used as the partition key for the table. Since every record must contain that
        /// attribute, the <c>attribute_not_exists</c> function will only succeed if no matching
        /// item exists.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information about <c>PutItem</c>, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/WorkingWithItems.html">Working
        /// with Items</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutItem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutItem service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.ConditionalCheckFailedException">
        /// A condition specified in the operation failed to be evaluated.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ItemCollectionSizeLimitExceededException">
        /// An item collection is too large. This exception is only returned for tables that have
        /// one or more local secondary indexes.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. The Amazon Web Services SDKs for DynamoDB automatically
        /// retry requests that receive this exception. Your request is eventually successful,
        /// unless your retry queue is too large to finish. Reduce the frequency of requests and
        /// use exponential backoff. For more information, go to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Programming.Errors.html#Programming.Errors.RetryAndBackoff">Error
        /// Retries and Exponential Backoff</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ReplicatedWriteConflictException">
        /// The request was rejected because one or more items in the request are being modified
        /// by a request in another Region.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.RequestLimitExceededException">
        /// Throughput exceeds the current throughput quota for your account. For detailed information
        /// about why the request was throttled and the ARN of the impacted resource, find the
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. Contact <a href="https://aws.amazon.com/support">Amazon
        /// Web Services Support</a> to request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ThrottlingException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.TransactionConflictException">
        /// Operation was rejected because there is an ongoing transaction for the item.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/PutItem">REST API Reference for PutItem Operation</seealso>
        public virtual Task<PutItemResponse> PutItemAsync(PutItemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutItemResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = PutItemEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;
            
            return InvokeAsync<PutItemResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutResourcePolicy


        /// <summary>
        /// Attaches a resource-based policy document to the resource, which can be a table or
        /// stream. When you attach a resource-based policy using this API, the policy application
        /// is <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/HowItWorks.ReadConsistency.html">
        /// <i>eventually consistent</i> </a>.
        /// 
        ///  
        /// <para>
        ///  <c>PutResourcePolicy</c> is an idempotent operation; running it multiple times on
        /// the same resource using the same policy document will return the same revision ID.
        /// If you specify an <c>ExpectedRevisionId</c> that doesn't match the current policy's
        /// <c>RevisionId</c>, the <c>PolicyNotFoundException</c> will be returned.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>PutResourcePolicy</c> is an asynchronous operation. If you issue a <c>GetResourcePolicy</c>
        /// request immediately after a <c>PutResourcePolicy</c> request, DynamoDB might return
        /// your previous policy, if there was one, or return the <c>PolicyNotFoundException</c>.
        /// This is because <c>GetResourcePolicy</c> uses an eventually consistent query, and
        /// the metadata for your policy or table might not be available at that moment. Wait
        /// for a few seconds, and then try the <c>GetResourcePolicy</c> request again.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the PutResourcePolicy service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.LimitExceededException">
        /// There is no limit to the number of daily on-demand backups that can be taken. 
        /// 
        ///  
        /// <para>
        /// For most purposes, up to 500 simultaneous table operations are allowed per account.
        /// These operations include <c>CreateTable</c>, <c>UpdateTable</c>, <c>DeleteTable</c>,<c>UpdateTimeToLive</c>,
        /// <c>RestoreTableFromBackup</c>, and <c>RestoreTableToPointInTime</c>. 
        /// </para>
        ///  
        /// <para>
        /// When you are creating a table with one or more secondary indexes, you can have up
        /// to 250 such requests running at a time. However, if the table or index specifications
        /// are complex, then DynamoDB might temporarily reduce the number of concurrent operations.
        /// </para>
        ///  
        /// <para>
        /// When importing into DynamoDB, up to 50 simultaneous import table operations are allowed
        /// per account.
        /// </para>
        ///  
        /// <para>
        /// There is a soft account quota of 2,500 tables.
        /// </para>
        ///  
        /// <para>
        /// GetRecords was called with a value of more than 1000 for the limit request parameter.
        /// </para>
        ///  
        /// <para>
        /// More than 2 processes are reading from the same streams shard at the same time. Exceeding
        /// this limit may result in request throttling.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.PolicyNotFoundException">
        /// The operation tried to access a nonexistent resource-based policy.
        /// 
        ///  
        /// <para>
        /// If you specified an <c>ExpectedRevisionId</c>, it's possible that a policy is present
        /// for the resource but its revision ID didn't match the expected value.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceInUseException">
        /// The operation conflicts with the resource's availability. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You attempted to recreate an existing table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a table currently in the <c>CREATING</c> state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a resource that was already being updated.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When appropriate, wait for the ongoing update to complete and attempt the request
        /// again.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        public virtual PutResourcePolicyResponse PutResourcePolicy(PutResourcePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = PutResourcePolicyEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<PutResourcePolicyResponse>(request, options);
        }


        /// <summary>
        /// Attaches a resource-based policy document to the resource, which can be a table or
        /// stream. When you attach a resource-based policy using this API, the policy application
        /// is <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/HowItWorks.ReadConsistency.html">
        /// <i>eventually consistent</i> </a>.
        /// 
        ///  
        /// <para>
        ///  <c>PutResourcePolicy</c> is an idempotent operation; running it multiple times on
        /// the same resource using the same policy document will return the same revision ID.
        /// If you specify an <c>ExpectedRevisionId</c> that doesn't match the current policy's
        /// <c>RevisionId</c>, the <c>PolicyNotFoundException</c> will be returned.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>PutResourcePolicy</c> is an asynchronous operation. If you issue a <c>GetResourcePolicy</c>
        /// request immediately after a <c>PutResourcePolicy</c> request, DynamoDB might return
        /// your previous policy, if there was one, or return the <c>PolicyNotFoundException</c>.
        /// This is because <c>GetResourcePolicy</c> uses an eventually consistent query, and
        /// the metadata for your policy or table might not be available at that moment. Wait
        /// for a few seconds, and then try the <c>GetResourcePolicy</c> request again.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutResourcePolicy service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.LimitExceededException">
        /// There is no limit to the number of daily on-demand backups that can be taken. 
        /// 
        ///  
        /// <para>
        /// For most purposes, up to 500 simultaneous table operations are allowed per account.
        /// These operations include <c>CreateTable</c>, <c>UpdateTable</c>, <c>DeleteTable</c>,<c>UpdateTimeToLive</c>,
        /// <c>RestoreTableFromBackup</c>, and <c>RestoreTableToPointInTime</c>. 
        /// </para>
        ///  
        /// <para>
        /// When you are creating a table with one or more secondary indexes, you can have up
        /// to 250 such requests running at a time. However, if the table or index specifications
        /// are complex, then DynamoDB might temporarily reduce the number of concurrent operations.
        /// </para>
        ///  
        /// <para>
        /// When importing into DynamoDB, up to 50 simultaneous import table operations are allowed
        /// per account.
        /// </para>
        ///  
        /// <para>
        /// There is a soft account quota of 2,500 tables.
        /// </para>
        ///  
        /// <para>
        /// GetRecords was called with a value of more than 1000 for the limit request parameter.
        /// </para>
        ///  
        /// <para>
        /// More than 2 processes are reading from the same streams shard at the same time. Exceeding
        /// this limit may result in request throttling.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.PolicyNotFoundException">
        /// The operation tried to access a nonexistent resource-based policy.
        /// 
        ///  
        /// <para>
        /// If you specified an <c>ExpectedRevisionId</c>, it's possible that a policy is present
        /// for the resource but its revision ID didn't match the expected value.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceInUseException">
        /// The operation conflicts with the resource's availability. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You attempted to recreate an existing table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a table currently in the <c>CREATING</c> state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a resource that was already being updated.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When appropriate, wait for the ongoing update to complete and attempt the request
        /// again.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        public virtual Task<PutResourcePolicyResponse> PutResourcePolicyAsync(PutResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = PutResourcePolicyEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;
            
            return InvokeAsync<PutResourcePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  Query


        /// <summary>
        /// You must provide the name of the partition key attribute and a single value for that
        /// attribute. <c>Query</c> returns all items with that partition key value. Optionally,
        /// you can provide a sort key attribute and use a comparison operator to refine the search
        /// results.
        /// 
        ///  
        /// <para>
        /// Use the <c>KeyConditionExpression</c> parameter to provide a specific value for the
        /// partition key. The <c>Query</c> operation will return all of the items from the table
        /// or index with that partition key value. You can optionally narrow the scope of the
        /// <c>Query</c> operation by specifying a sort key value and a comparison operator in
        /// <c>KeyConditionExpression</c>. To further refine the <c>Query</c> results, you can
        /// optionally provide a <c>FilterExpression</c>. A <c>FilterExpression</c> determines
        /// which items within the results should be returned to you. All of the other results
        /// are discarded. 
        /// </para>
        ///  
        /// <para>
        ///  A <c>Query</c> operation always returns a result set. If no matching items are found,
        /// the result set will be empty. Queries that do not return results consume the minimum
        /// number of read capacity units for that type of read operation. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  DynamoDB calculates the number of read capacity units consumed based on item size,
        /// not on the amount of data that is returned to an application. The number of capacity
        /// units consumed will be the same whether you request all of the attributes (the default
        /// behavior) or just some of them (using a projection expression). The number will also
        /// be the same whether or not you use a <c>FilterExpression</c>. 
        /// </para>
        ///  </note> 
        /// <para>
        ///  <c>Query</c> results are always sorted by the sort key value. If the data type of
        /// the sort key is Number, the results are returned in numeric order; otherwise, the
        /// results are returned in order of UTF-8 bytes. By default, the sort order is ascending.
        /// To reverse the order, set the <c>ScanIndexForward</c> parameter to false. 
        /// </para>
        ///  
        /// <para>
        ///  A single <c>Query</c> operation will read up to the maximum number of items set (if
        /// using the <c>Limit</c> parameter) or a maximum of 1 MB of data and then apply any
        /// filtering to the results using <c>FilterExpression</c>. If <c>LastEvaluatedKey</c>
        /// is present in the response, you will need to paginate the result set. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Query.html#Query.Pagination">Paginating
        /// the Results</a> in the <i>Amazon DynamoDB Developer Guide</i>. 
        /// </para>
        ///  
        /// <para>
        ///  <c>FilterExpression</c> is applied after a <c>Query</c> finishes, but before the
        /// results are returned. A <c>FilterExpression</c> cannot contain partition key or sort
        /// key attributes. You need to specify those attributes in the <c>KeyConditionExpression</c>.
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        ///  A <c>Query</c> operation can return an empty result set and a <c>LastEvaluatedKey</c>
        /// if all the items read for the page of results are filtered out. 
        /// </para>
        ///  </note> 
        /// <para>
        /// You can query a table, a local secondary index, or a global secondary index. For a
        /// query on a table or on a local secondary index, you can set the <c>ConsistentRead</c>
        /// parameter to <c>true</c> and obtain a strongly consistent result. Global secondary
        /// indexes support eventually consistent reads only, so do not specify <c>ConsistentRead</c>
        /// when querying a global secondary index.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Query service method.</param>
        /// 
        /// <returns>The response from the Query service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. The Amazon Web Services SDKs for DynamoDB automatically
        /// retry requests that receive this exception. Your request is eventually successful,
        /// unless your retry queue is too large to finish. Reduce the frequency of requests and
        /// use exponential backoff. For more information, go to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Programming.Errors.html#Programming.Errors.RetryAndBackoff">Error
        /// Retries and Exponential Backoff</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.RequestLimitExceededException">
        /// Throughput exceeds the current throughput quota for your account. For detailed information
        /// about why the request was throttled and the ARN of the impacted resource, find the
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. Contact <a href="https://aws.amazon.com/support">Amazon
        /// Web Services Support</a> to request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ThrottlingException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/Query">REST API Reference for Query Operation</seealso>
        public virtual QueryResponse Query(QueryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = QueryEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<QueryResponse>(request, options);
        }


        /// <summary>
        /// You must provide the name of the partition key attribute and a single value for that
        /// attribute. <c>Query</c> returns all items with that partition key value. Optionally,
        /// you can provide a sort key attribute and use a comparison operator to refine the search
        /// results.
        /// 
        ///  
        /// <para>
        /// Use the <c>KeyConditionExpression</c> parameter to provide a specific value for the
        /// partition key. The <c>Query</c> operation will return all of the items from the table
        /// or index with that partition key value. You can optionally narrow the scope of the
        /// <c>Query</c> operation by specifying a sort key value and a comparison operator in
        /// <c>KeyConditionExpression</c>. To further refine the <c>Query</c> results, you can
        /// optionally provide a <c>FilterExpression</c>. A <c>FilterExpression</c> determines
        /// which items within the results should be returned to you. All of the other results
        /// are discarded. 
        /// </para>
        ///  
        /// <para>
        ///  A <c>Query</c> operation always returns a result set. If no matching items are found,
        /// the result set will be empty. Queries that do not return results consume the minimum
        /// number of read capacity units for that type of read operation. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  DynamoDB calculates the number of read capacity units consumed based on item size,
        /// not on the amount of data that is returned to an application. The number of capacity
        /// units consumed will be the same whether you request all of the attributes (the default
        /// behavior) or just some of them (using a projection expression). The number will also
        /// be the same whether or not you use a <c>FilterExpression</c>. 
        /// </para>
        ///  </note> 
        /// <para>
        ///  <c>Query</c> results are always sorted by the sort key value. If the data type of
        /// the sort key is Number, the results are returned in numeric order; otherwise, the
        /// results are returned in order of UTF-8 bytes. By default, the sort order is ascending.
        /// To reverse the order, set the <c>ScanIndexForward</c> parameter to false. 
        /// </para>
        ///  
        /// <para>
        ///  A single <c>Query</c> operation will read up to the maximum number of items set (if
        /// using the <c>Limit</c> parameter) or a maximum of 1 MB of data and then apply any
        /// filtering to the results using <c>FilterExpression</c>. If <c>LastEvaluatedKey</c>
        /// is present in the response, you will need to paginate the result set. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Query.html#Query.Pagination">Paginating
        /// the Results</a> in the <i>Amazon DynamoDB Developer Guide</i>. 
        /// </para>
        ///  
        /// <para>
        ///  <c>FilterExpression</c> is applied after a <c>Query</c> finishes, but before the
        /// results are returned. A <c>FilterExpression</c> cannot contain partition key or sort
        /// key attributes. You need to specify those attributes in the <c>KeyConditionExpression</c>.
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        ///  A <c>Query</c> operation can return an empty result set and a <c>LastEvaluatedKey</c>
        /// if all the items read for the page of results are filtered out. 
        /// </para>
        ///  </note> 
        /// <para>
        /// You can query a table, a local secondary index, or a global secondary index. For a
        /// query on a table or on a local secondary index, you can set the <c>ConsistentRead</c>
        /// parameter to <c>true</c> and obtain a strongly consistent result. Global secondary
        /// indexes support eventually consistent reads only, so do not specify <c>ConsistentRead</c>
        /// when querying a global secondary index.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Query service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Query service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. The Amazon Web Services SDKs for DynamoDB automatically
        /// retry requests that receive this exception. Your request is eventually successful,
        /// unless your retry queue is too large to finish. Reduce the frequency of requests and
        /// use exponential backoff. For more information, go to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Programming.Errors.html#Programming.Errors.RetryAndBackoff">Error
        /// Retries and Exponential Backoff</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.RequestLimitExceededException">
        /// Throughput exceeds the current throughput quota for your account. For detailed information
        /// about why the request was throttled and the ARN of the impacted resource, find the
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. Contact <a href="https://aws.amazon.com/support">Amazon
        /// Web Services Support</a> to request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ThrottlingException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/Query">REST API Reference for Query Operation</seealso>
        public virtual Task<QueryResponse> QueryAsync(QueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = QueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = QueryResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = QueryEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;
            
            return InvokeAsync<QueryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RestoreTableFromBackup


        /// <summary>
        /// Creates a new table from an existing backup. Any number of users can execute up to
        /// 50 concurrent restores (any type of restore) in a given account. 
        /// 
        ///  
        /// <para>
        /// You can call <c>RestoreTableFromBackup</c> at a maximum rate of 10 times per second.
        /// </para>
        ///  
        /// <para>
        /// You must manually set up the following on the restored table:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Auto scaling policies
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IAM policies
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon CloudWatch metrics and alarms
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tags
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Stream settings
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Time to Live (TTL) settings
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreTableFromBackup service method.</param>
        /// 
        /// <returns>The response from the RestoreTableFromBackup service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.BackupInUseException">
        /// There is another ongoing conflicting backup control plane operation on the table.
        /// The backup is either being created, deleted or restored to a table.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.BackupNotFoundException">
        /// Backup not found for the given BackupARN.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.LimitExceededException">
        /// There is no limit to the number of daily on-demand backups that can be taken. 
        /// 
        ///  
        /// <para>
        /// For most purposes, up to 500 simultaneous table operations are allowed per account.
        /// These operations include <c>CreateTable</c>, <c>UpdateTable</c>, <c>DeleteTable</c>,<c>UpdateTimeToLive</c>,
        /// <c>RestoreTableFromBackup</c>, and <c>RestoreTableToPointInTime</c>. 
        /// </para>
        ///  
        /// <para>
        /// When you are creating a table with one or more secondary indexes, you can have up
        /// to 250 such requests running at a time. However, if the table or index specifications
        /// are complex, then DynamoDB might temporarily reduce the number of concurrent operations.
        /// </para>
        ///  
        /// <para>
        /// When importing into DynamoDB, up to 50 simultaneous import table operations are allowed
        /// per account.
        /// </para>
        ///  
        /// <para>
        /// There is a soft account quota of 2,500 tables.
        /// </para>
        ///  
        /// <para>
        /// GetRecords was called with a value of more than 1000 for the limit request parameter.
        /// </para>
        ///  
        /// <para>
        /// More than 2 processes are reading from the same streams shard at the same time. Exceeding
        /// this limit may result in request throttling.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.TableAlreadyExistsException">
        /// A target table with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.TableInUseException">
        /// A target table with the specified name is either being created or deleted.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/RestoreTableFromBackup">REST API Reference for RestoreTableFromBackup Operation</seealso>
        public virtual RestoreTableFromBackupResponse RestoreTableFromBackup(RestoreTableFromBackupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RestoreTableFromBackupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreTableFromBackupResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = RestoreTableFromBackupEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<RestoreTableFromBackupResponse>(request, options);
        }


        /// <summary>
        /// Creates a new table from an existing backup. Any number of users can execute up to
        /// 50 concurrent restores (any type of restore) in a given account. 
        /// 
        ///  
        /// <para>
        /// You can call <c>RestoreTableFromBackup</c> at a maximum rate of 10 times per second.
        /// </para>
        ///  
        /// <para>
        /// You must manually set up the following on the restored table:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Auto scaling policies
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IAM policies
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon CloudWatch metrics and alarms
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tags
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Stream settings
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Time to Live (TTL) settings
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreTableFromBackup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestoreTableFromBackup service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.BackupInUseException">
        /// There is another ongoing conflicting backup control plane operation on the table.
        /// The backup is either being created, deleted or restored to a table.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.BackupNotFoundException">
        /// Backup not found for the given BackupARN.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.LimitExceededException">
        /// There is no limit to the number of daily on-demand backups that can be taken. 
        /// 
        ///  
        /// <para>
        /// For most purposes, up to 500 simultaneous table operations are allowed per account.
        /// These operations include <c>CreateTable</c>, <c>UpdateTable</c>, <c>DeleteTable</c>,<c>UpdateTimeToLive</c>,
        /// <c>RestoreTableFromBackup</c>, and <c>RestoreTableToPointInTime</c>. 
        /// </para>
        ///  
        /// <para>
        /// When you are creating a table with one or more secondary indexes, you can have up
        /// to 250 such requests running at a time. However, if the table or index specifications
        /// are complex, then DynamoDB might temporarily reduce the number of concurrent operations.
        /// </para>
        ///  
        /// <para>
        /// When importing into DynamoDB, up to 50 simultaneous import table operations are allowed
        /// per account.
        /// </para>
        ///  
        /// <para>
        /// There is a soft account quota of 2,500 tables.
        /// </para>
        ///  
        /// <para>
        /// GetRecords was called with a value of more than 1000 for the limit request parameter.
        /// </para>
        ///  
        /// <para>
        /// More than 2 processes are reading from the same streams shard at the same time. Exceeding
        /// this limit may result in request throttling.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.TableAlreadyExistsException">
        /// A target table with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.TableInUseException">
        /// A target table with the specified name is either being created or deleted.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/RestoreTableFromBackup">REST API Reference for RestoreTableFromBackup Operation</seealso>
        public virtual Task<RestoreTableFromBackupResponse> RestoreTableFromBackupAsync(RestoreTableFromBackupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RestoreTableFromBackupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreTableFromBackupResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = RestoreTableFromBackupEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;
            
            return InvokeAsync<RestoreTableFromBackupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RestoreTableToPointInTime


        /// <summary>
        /// Restores the specified table to the specified point in time within <c>EarliestRestorableDateTime</c>
        /// and <c>LatestRestorableDateTime</c>. You can restore your table to any point in time
        /// in the last 35 days. You can set the recovery period to any value between 1 and 35
        /// days. Any number of users can execute up to 50 concurrent restores (any type of restore)
        /// in a given account. 
        /// 
        ///  
        /// <para>
        /// When you restore using point in time recovery, DynamoDB restores your table data to
        /// the state based on the selected date and time (day:hour:minute:second) to a new table.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Along with data, the following are also included on the new restored table using point
        /// in time recovery: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Global secondary indexes (GSIs)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Local secondary indexes (LSIs)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Provisioned read and write capacity
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Encryption settings
        /// </para>
        ///  <important> 
        /// <para>
        ///  All these settings come from the current settings of the source table at the time
        /// of restore. 
        /// </para>
        ///  </important> </li> </ul> 
        /// <para>
        /// You must manually set up the following on the restored table:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Auto scaling policies
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IAM policies
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon CloudWatch metrics and alarms
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tags
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Stream settings
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Time to Live (TTL) settings
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Point in time recovery settings
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreTableToPointInTime service method.</param>
        /// 
        /// <returns>The response from the RestoreTableToPointInTime service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.InvalidRestoreTimeException">
        /// An invalid restore time was specified. RestoreDateTime must be between EarliestRestorableDateTime
        /// and LatestRestorableDateTime.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.LimitExceededException">
        /// There is no limit to the number of daily on-demand backups that can be taken. 
        /// 
        ///  
        /// <para>
        /// For most purposes, up to 500 simultaneous table operations are allowed per account.
        /// These operations include <c>CreateTable</c>, <c>UpdateTable</c>, <c>DeleteTable</c>,<c>UpdateTimeToLive</c>,
        /// <c>RestoreTableFromBackup</c>, and <c>RestoreTableToPointInTime</c>. 
        /// </para>
        ///  
        /// <para>
        /// When you are creating a table with one or more secondary indexes, you can have up
        /// to 250 such requests running at a time. However, if the table or index specifications
        /// are complex, then DynamoDB might temporarily reduce the number of concurrent operations.
        /// </para>
        ///  
        /// <para>
        /// When importing into DynamoDB, up to 50 simultaneous import table operations are allowed
        /// per account.
        /// </para>
        ///  
        /// <para>
        /// There is a soft account quota of 2,500 tables.
        /// </para>
        ///  
        /// <para>
        /// GetRecords was called with a value of more than 1000 for the limit request parameter.
        /// </para>
        ///  
        /// <para>
        /// More than 2 processes are reading from the same streams shard at the same time. Exceeding
        /// this limit may result in request throttling.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.PointInTimeRecoveryUnavailableException">
        /// Point in time recovery has not yet been enabled for this source table.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.TableAlreadyExistsException">
        /// A target table with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.TableInUseException">
        /// A target table with the specified name is either being created or deleted.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.TableNotFoundException">
        /// A source table with the name <c>TableName</c> does not currently exist within the
        /// subscriber's account or the subscriber is operating in the wrong Amazon Web Services
        /// Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/RestoreTableToPointInTime">REST API Reference for RestoreTableToPointInTime Operation</seealso>
        public virtual RestoreTableToPointInTimeResponse RestoreTableToPointInTime(RestoreTableToPointInTimeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RestoreTableToPointInTimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreTableToPointInTimeResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = RestoreTableToPointInTimeEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<RestoreTableToPointInTimeResponse>(request, options);
        }


        /// <summary>
        /// Restores the specified table to the specified point in time within <c>EarliestRestorableDateTime</c>
        /// and <c>LatestRestorableDateTime</c>. You can restore your table to any point in time
        /// in the last 35 days. You can set the recovery period to any value between 1 and 35
        /// days. Any number of users can execute up to 50 concurrent restores (any type of restore)
        /// in a given account. 
        /// 
        ///  
        /// <para>
        /// When you restore using point in time recovery, DynamoDB restores your table data to
        /// the state based on the selected date and time (day:hour:minute:second) to a new table.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Along with data, the following are also included on the new restored table using point
        /// in time recovery: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Global secondary indexes (GSIs)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Local secondary indexes (LSIs)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Provisioned read and write capacity
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Encryption settings
        /// </para>
        ///  <important> 
        /// <para>
        ///  All these settings come from the current settings of the source table at the time
        /// of restore. 
        /// </para>
        ///  </important> </li> </ul> 
        /// <para>
        /// You must manually set up the following on the restored table:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Auto scaling policies
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IAM policies
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon CloudWatch metrics and alarms
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tags
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Stream settings
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Time to Live (TTL) settings
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Point in time recovery settings
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreTableToPointInTime service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestoreTableToPointInTime service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.InvalidRestoreTimeException">
        /// An invalid restore time was specified. RestoreDateTime must be between EarliestRestorableDateTime
        /// and LatestRestorableDateTime.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.LimitExceededException">
        /// There is no limit to the number of daily on-demand backups that can be taken. 
        /// 
        ///  
        /// <para>
        /// For most purposes, up to 500 simultaneous table operations are allowed per account.
        /// These operations include <c>CreateTable</c>, <c>UpdateTable</c>, <c>DeleteTable</c>,<c>UpdateTimeToLive</c>,
        /// <c>RestoreTableFromBackup</c>, and <c>RestoreTableToPointInTime</c>. 
        /// </para>
        ///  
        /// <para>
        /// When you are creating a table with one or more secondary indexes, you can have up
        /// to 250 such requests running at a time. However, if the table or index specifications
        /// are complex, then DynamoDB might temporarily reduce the number of concurrent operations.
        /// </para>
        ///  
        /// <para>
        /// When importing into DynamoDB, up to 50 simultaneous import table operations are allowed
        /// per account.
        /// </para>
        ///  
        /// <para>
        /// There is a soft account quota of 2,500 tables.
        /// </para>
        ///  
        /// <para>
        /// GetRecords was called with a value of more than 1000 for the limit request parameter.
        /// </para>
        ///  
        /// <para>
        /// More than 2 processes are reading from the same streams shard at the same time. Exceeding
        /// this limit may result in request throttling.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.PointInTimeRecoveryUnavailableException">
        /// Point in time recovery has not yet been enabled for this source table.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.TableAlreadyExistsException">
        /// A target table with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.TableInUseException">
        /// A target table with the specified name is either being created or deleted.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.TableNotFoundException">
        /// A source table with the name <c>TableName</c> does not currently exist within the
        /// subscriber's account or the subscriber is operating in the wrong Amazon Web Services
        /// Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/RestoreTableToPointInTime">REST API Reference for RestoreTableToPointInTime Operation</seealso>
        public virtual Task<RestoreTableToPointInTimeResponse> RestoreTableToPointInTimeAsync(RestoreTableToPointInTimeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RestoreTableToPointInTimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreTableToPointInTimeResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = RestoreTableToPointInTimeEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;
            
            return InvokeAsync<RestoreTableToPointInTimeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  Scan


        /// <summary>
        /// The <c>Scan</c> operation returns one or more items and item attributes by accessing
        /// every item in a table or a secondary index. To have DynamoDB return fewer items, you
        /// can provide a <c>FilterExpression</c> operation.
        /// 
        ///  
        /// <para>
        /// If the total size of scanned items exceeds the maximum dataset size limit of 1 MB,
        /// the scan completes and results are returned to the user. The <c>LastEvaluatedKey</c>
        /// value is also returned and the requestor can use the <c>LastEvaluatedKey</c> to continue
        /// the scan in a subsequent operation. Each scan response also includes number of items
        /// that were scanned (ScannedCount) as part of the request. If using a <c>FilterExpression</c>,
        /// a scan result can result in no items meeting the criteria and the <c>Count</c> will
        /// result in zero. If you did not use a <c>FilterExpression</c> in the scan request,
        /// then <c>Count</c> is the same as <c>ScannedCount</c>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>Count</c> and <c>ScannedCount</c> only return the count of items specific to a
        /// single scan request and, unless the table is less than 1MB, do not represent the total
        /// number of items in the table. 
        /// </para>
        ///  </note> 
        /// <para>
        /// A single <c>Scan</c> operation first reads up to the maximum number of items set (if
        /// using the <c>Limit</c> parameter) or a maximum of 1 MB of data and then applies any
        /// filtering to the results if a <c>FilterExpression</c> is provided. If <c>LastEvaluatedKey</c>
        /// is present in the response, pagination is required to complete the full table scan.
        /// For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Scan.html#Scan.Pagination">Paginating
        /// the Results</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <c>Scan</c> operations proceed sequentially; however, for faster performance on a
        /// large table or secondary index, applications can request a parallel <c>Scan</c> operation
        /// by providing the <c>Segment</c> and <c>TotalSegments</c> parameters. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Scan.html#Scan.ParallelScan">Parallel
        /// Scan</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// By default, a <c>Scan</c> uses eventually consistent reads when accessing the items
        /// in a table. Therefore, the results from an eventually consistent <c>Scan</c> may not
        /// include the latest item changes at the time the scan iterates through each item in
        /// the table. If you require a strongly consistent read of each item as the scan iterates
        /// through the items in the table, you can set the <c>ConsistentRead</c> parameter to
        /// true. Strong consistency only relates to the consistency of the read at the item level.
        /// </para>
        ///  <note> 
        /// <para>
        ///  DynamoDB does not provide snapshot isolation for a scan operation when the <c>ConsistentRead</c>
        /// parameter is set to true. Thus, a DynamoDB scan operation does not guarantee that
        /// all reads in a scan see a consistent snapshot of the table when the scan operation
        /// was requested. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="tableName">The name of the table containing the requested items or if you provide <c>IndexName</c>, the name of the table to which that index belongs. You can also provide the Amazon Resource Name (ARN) of the table in this parameter.</param>
        /// <param name="attributesToGet">This is a legacy parameter. Use <c>ProjectionExpression</c> instead. For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/LegacyConditionalParameters.AttributesToGet.html">AttributesToGet</a> in the <i>Amazon DynamoDB Developer Guide</i>.</param>
        /// 
        /// <returns>The response from the Scan service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. The Amazon Web Services SDKs for DynamoDB automatically
        /// retry requests that receive this exception. Your request is eventually successful,
        /// unless your retry queue is too large to finish. Reduce the frequency of requests and
        /// use exponential backoff. For more information, go to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Programming.Errors.html#Programming.Errors.RetryAndBackoff">Error
        /// Retries and Exponential Backoff</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.RequestLimitExceededException">
        /// Throughput exceeds the current throughput quota for your account. For detailed information
        /// about why the request was throttled and the ARN of the impacted resource, find the
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. Contact <a href="https://aws.amazon.com/support">Amazon
        /// Web Services Support</a> to request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ThrottlingException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/Scan">REST API Reference for Scan Operation</seealso>
        public virtual ScanResponse Scan(string tableName, List<string> attributesToGet)
        {
            var request = new ScanRequest();
            request.TableName = tableName;
            request.AttributesToGet = attributesToGet;
            return Scan(request);
        }


        /// <summary>
        /// The <c>Scan</c> operation returns one or more items and item attributes by accessing
        /// every item in a table or a secondary index. To have DynamoDB return fewer items, you
        /// can provide a <c>FilterExpression</c> operation.
        /// 
        ///  
        /// <para>
        /// If the total size of scanned items exceeds the maximum dataset size limit of 1 MB,
        /// the scan completes and results are returned to the user. The <c>LastEvaluatedKey</c>
        /// value is also returned and the requestor can use the <c>LastEvaluatedKey</c> to continue
        /// the scan in a subsequent operation. Each scan response also includes number of items
        /// that were scanned (ScannedCount) as part of the request. If using a <c>FilterExpression</c>,
        /// a scan result can result in no items meeting the criteria and the <c>Count</c> will
        /// result in zero. If you did not use a <c>FilterExpression</c> in the scan request,
        /// then <c>Count</c> is the same as <c>ScannedCount</c>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>Count</c> and <c>ScannedCount</c> only return the count of items specific to a
        /// single scan request and, unless the table is less than 1MB, do not represent the total
        /// number of items in the table. 
        /// </para>
        ///  </note> 
        /// <para>
        /// A single <c>Scan</c> operation first reads up to the maximum number of items set (if
        /// using the <c>Limit</c> parameter) or a maximum of 1 MB of data and then applies any
        /// filtering to the results if a <c>FilterExpression</c> is provided. If <c>LastEvaluatedKey</c>
        /// is present in the response, pagination is required to complete the full table scan.
        /// For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Scan.html#Scan.Pagination">Paginating
        /// the Results</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <c>Scan</c> operations proceed sequentially; however, for faster performance on a
        /// large table or secondary index, applications can request a parallel <c>Scan</c> operation
        /// by providing the <c>Segment</c> and <c>TotalSegments</c> parameters. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Scan.html#Scan.ParallelScan">Parallel
        /// Scan</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// By default, a <c>Scan</c> uses eventually consistent reads when accessing the items
        /// in a table. Therefore, the results from an eventually consistent <c>Scan</c> may not
        /// include the latest item changes at the time the scan iterates through each item in
        /// the table. If you require a strongly consistent read of each item as the scan iterates
        /// through the items in the table, you can set the <c>ConsistentRead</c> parameter to
        /// true. Strong consistency only relates to the consistency of the read at the item level.
        /// </para>
        ///  <note> 
        /// <para>
        ///  DynamoDB does not provide snapshot isolation for a scan operation when the <c>ConsistentRead</c>
        /// parameter is set to true. Thus, a DynamoDB scan operation does not guarantee that
        /// all reads in a scan see a consistent snapshot of the table when the scan operation
        /// was requested. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="tableName">The name of the table containing the requested items or if you provide <c>IndexName</c>, the name of the table to which that index belongs. You can also provide the Amazon Resource Name (ARN) of the table in this parameter.</param>
        /// <param name="scanFilter">This is a legacy parameter. Use <c>FilterExpression</c> instead. For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/LegacyConditionalParameters.ScanFilter.html">ScanFilter</a> in the <i>Amazon DynamoDB Developer Guide</i>.</param>
        /// 
        /// <returns>The response from the Scan service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. The Amazon Web Services SDKs for DynamoDB automatically
        /// retry requests that receive this exception. Your request is eventually successful,
        /// unless your retry queue is too large to finish. Reduce the frequency of requests and
        /// use exponential backoff. For more information, go to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Programming.Errors.html#Programming.Errors.RetryAndBackoff">Error
        /// Retries and Exponential Backoff</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.RequestLimitExceededException">
        /// Throughput exceeds the current throughput quota for your account. For detailed information
        /// about why the request was throttled and the ARN of the impacted resource, find the
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. Contact <a href="https://aws.amazon.com/support">Amazon
        /// Web Services Support</a> to request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ThrottlingException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/Scan">REST API Reference for Scan Operation</seealso>
        public virtual ScanResponse Scan(string tableName, Dictionary<string, Condition> scanFilter)
        {
            var request = new ScanRequest();
            request.TableName = tableName;
            request.ScanFilter = scanFilter;
            return Scan(request);
        }


        /// <summary>
        /// The <c>Scan</c> operation returns one or more items and item attributes by accessing
        /// every item in a table or a secondary index. To have DynamoDB return fewer items, you
        /// can provide a <c>FilterExpression</c> operation.
        /// 
        ///  
        /// <para>
        /// If the total size of scanned items exceeds the maximum dataset size limit of 1 MB,
        /// the scan completes and results are returned to the user. The <c>LastEvaluatedKey</c>
        /// value is also returned and the requestor can use the <c>LastEvaluatedKey</c> to continue
        /// the scan in a subsequent operation. Each scan response also includes number of items
        /// that were scanned (ScannedCount) as part of the request. If using a <c>FilterExpression</c>,
        /// a scan result can result in no items meeting the criteria and the <c>Count</c> will
        /// result in zero. If you did not use a <c>FilterExpression</c> in the scan request,
        /// then <c>Count</c> is the same as <c>ScannedCount</c>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>Count</c> and <c>ScannedCount</c> only return the count of items specific to a
        /// single scan request and, unless the table is less than 1MB, do not represent the total
        /// number of items in the table. 
        /// </para>
        ///  </note> 
        /// <para>
        /// A single <c>Scan</c> operation first reads up to the maximum number of items set (if
        /// using the <c>Limit</c> parameter) or a maximum of 1 MB of data and then applies any
        /// filtering to the results if a <c>FilterExpression</c> is provided. If <c>LastEvaluatedKey</c>
        /// is present in the response, pagination is required to complete the full table scan.
        /// For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Scan.html#Scan.Pagination">Paginating
        /// the Results</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <c>Scan</c> operations proceed sequentially; however, for faster performance on a
        /// large table or secondary index, applications can request a parallel <c>Scan</c> operation
        /// by providing the <c>Segment</c> and <c>TotalSegments</c> parameters. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Scan.html#Scan.ParallelScan">Parallel
        /// Scan</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// By default, a <c>Scan</c> uses eventually consistent reads when accessing the items
        /// in a table. Therefore, the results from an eventually consistent <c>Scan</c> may not
        /// include the latest item changes at the time the scan iterates through each item in
        /// the table. If you require a strongly consistent read of each item as the scan iterates
        /// through the items in the table, you can set the <c>ConsistentRead</c> parameter to
        /// true. Strong consistency only relates to the consistency of the read at the item level.
        /// </para>
        ///  <note> 
        /// <para>
        ///  DynamoDB does not provide snapshot isolation for a scan operation when the <c>ConsistentRead</c>
        /// parameter is set to true. Thus, a DynamoDB scan operation does not guarantee that
        /// all reads in a scan see a consistent snapshot of the table when the scan operation
        /// was requested. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="tableName">The name of the table containing the requested items or if you provide <c>IndexName</c>, the name of the table to which that index belongs. You can also provide the Amazon Resource Name (ARN) of the table in this parameter.</param>
        /// <param name="attributesToGet">This is a legacy parameter. Use <c>ProjectionExpression</c> instead. For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/LegacyConditionalParameters.AttributesToGet.html">AttributesToGet</a> in the <i>Amazon DynamoDB Developer Guide</i>.</param>
        /// <param name="scanFilter">This is a legacy parameter. Use <c>FilterExpression</c> instead. For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/LegacyConditionalParameters.ScanFilter.html">ScanFilter</a> in the <i>Amazon DynamoDB Developer Guide</i>.</param>
        /// 
        /// <returns>The response from the Scan service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. The Amazon Web Services SDKs for DynamoDB automatically
        /// retry requests that receive this exception. Your request is eventually successful,
        /// unless your retry queue is too large to finish. Reduce the frequency of requests and
        /// use exponential backoff. For more information, go to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Programming.Errors.html#Programming.Errors.RetryAndBackoff">Error
        /// Retries and Exponential Backoff</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.RequestLimitExceededException">
        /// Throughput exceeds the current throughput quota for your account. For detailed information
        /// about why the request was throttled and the ARN of the impacted resource, find the
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. Contact <a href="https://aws.amazon.com/support">Amazon
        /// Web Services Support</a> to request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ThrottlingException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/Scan">REST API Reference for Scan Operation</seealso>
        public virtual ScanResponse Scan(string tableName, List<string> attributesToGet, Dictionary<string, Condition> scanFilter)
        {
            var request = new ScanRequest();
            request.TableName = tableName;
            request.AttributesToGet = attributesToGet;
            request.ScanFilter = scanFilter;
            return Scan(request);
        }


        /// <summary>
        /// The <c>Scan</c> operation returns one or more items and item attributes by accessing
        /// every item in a table or a secondary index. To have DynamoDB return fewer items, you
        /// can provide a <c>FilterExpression</c> operation.
        /// 
        ///  
        /// <para>
        /// If the total size of scanned items exceeds the maximum dataset size limit of 1 MB,
        /// the scan completes and results are returned to the user. The <c>LastEvaluatedKey</c>
        /// value is also returned and the requestor can use the <c>LastEvaluatedKey</c> to continue
        /// the scan in a subsequent operation. Each scan response also includes number of items
        /// that were scanned (ScannedCount) as part of the request. If using a <c>FilterExpression</c>,
        /// a scan result can result in no items meeting the criteria and the <c>Count</c> will
        /// result in zero. If you did not use a <c>FilterExpression</c> in the scan request,
        /// then <c>Count</c> is the same as <c>ScannedCount</c>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>Count</c> and <c>ScannedCount</c> only return the count of items specific to a
        /// single scan request and, unless the table is less than 1MB, do not represent the total
        /// number of items in the table. 
        /// </para>
        ///  </note> 
        /// <para>
        /// A single <c>Scan</c> operation first reads up to the maximum number of items set (if
        /// using the <c>Limit</c> parameter) or a maximum of 1 MB of data and then applies any
        /// filtering to the results if a <c>FilterExpression</c> is provided. If <c>LastEvaluatedKey</c>
        /// is present in the response, pagination is required to complete the full table scan.
        /// For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Scan.html#Scan.Pagination">Paginating
        /// the Results</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <c>Scan</c> operations proceed sequentially; however, for faster performance on a
        /// large table or secondary index, applications can request a parallel <c>Scan</c> operation
        /// by providing the <c>Segment</c> and <c>TotalSegments</c> parameters. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Scan.html#Scan.ParallelScan">Parallel
        /// Scan</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// By default, a <c>Scan</c> uses eventually consistent reads when accessing the items
        /// in a table. Therefore, the results from an eventually consistent <c>Scan</c> may not
        /// include the latest item changes at the time the scan iterates through each item in
        /// the table. If you require a strongly consistent read of each item as the scan iterates
        /// through the items in the table, you can set the <c>ConsistentRead</c> parameter to
        /// true. Strong consistency only relates to the consistency of the read at the item level.
        /// </para>
        ///  <note> 
        /// <para>
        ///  DynamoDB does not provide snapshot isolation for a scan operation when the <c>ConsistentRead</c>
        /// parameter is set to true. Thus, a DynamoDB scan operation does not guarantee that
        /// all reads in a scan see a consistent snapshot of the table when the scan operation
        /// was requested. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Scan service method.</param>
        /// 
        /// <returns>The response from the Scan service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. The Amazon Web Services SDKs for DynamoDB automatically
        /// retry requests that receive this exception. Your request is eventually successful,
        /// unless your retry queue is too large to finish. Reduce the frequency of requests and
        /// use exponential backoff. For more information, go to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Programming.Errors.html#Programming.Errors.RetryAndBackoff">Error
        /// Retries and Exponential Backoff</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.RequestLimitExceededException">
        /// Throughput exceeds the current throughput quota for your account. For detailed information
        /// about why the request was throttled and the ARN of the impacted resource, find the
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. Contact <a href="https://aws.amazon.com/support">Amazon
        /// Web Services Support</a> to request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ThrottlingException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/Scan">REST API Reference for Scan Operation</seealso>
        public virtual ScanResponse Scan(ScanRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ScanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ScanResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = ScanEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<ScanResponse>(request, options);
        }


        /// <summary>
        /// The <c>Scan</c> operation returns one or more items and item attributes by accessing
        /// every item in a table or a secondary index. To have DynamoDB return fewer items, you
        /// can provide a <c>FilterExpression</c> operation.
        /// 
        ///  
        /// <para>
        /// If the total size of scanned items exceeds the maximum dataset size limit of 1 MB,
        /// the scan completes and results are returned to the user. The <c>LastEvaluatedKey</c>
        /// value is also returned and the requestor can use the <c>LastEvaluatedKey</c> to continue
        /// the scan in a subsequent operation. Each scan response also includes number of items
        /// that were scanned (ScannedCount) as part of the request. If using a <c>FilterExpression</c>,
        /// a scan result can result in no items meeting the criteria and the <c>Count</c> will
        /// result in zero. If you did not use a <c>FilterExpression</c> in the scan request,
        /// then <c>Count</c> is the same as <c>ScannedCount</c>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>Count</c> and <c>ScannedCount</c> only return the count of items specific to a
        /// single scan request and, unless the table is less than 1MB, do not represent the total
        /// number of items in the table. 
        /// </para>
        ///  </note> 
        /// <para>
        /// A single <c>Scan</c> operation first reads up to the maximum number of items set (if
        /// using the <c>Limit</c> parameter) or a maximum of 1 MB of data and then applies any
        /// filtering to the results if a <c>FilterExpression</c> is provided. If <c>LastEvaluatedKey</c>
        /// is present in the response, pagination is required to complete the full table scan.
        /// For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Scan.html#Scan.Pagination">Paginating
        /// the Results</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <c>Scan</c> operations proceed sequentially; however, for faster performance on a
        /// large table or secondary index, applications can request a parallel <c>Scan</c> operation
        /// by providing the <c>Segment</c> and <c>TotalSegments</c> parameters. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Scan.html#Scan.ParallelScan">Parallel
        /// Scan</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// By default, a <c>Scan</c> uses eventually consistent reads when accessing the items
        /// in a table. Therefore, the results from an eventually consistent <c>Scan</c> may not
        /// include the latest item changes at the time the scan iterates through each item in
        /// the table. If you require a strongly consistent read of each item as the scan iterates
        /// through the items in the table, you can set the <c>ConsistentRead</c> parameter to
        /// true. Strong consistency only relates to the consistency of the read at the item level.
        /// </para>
        ///  <note> 
        /// <para>
        ///  DynamoDB does not provide snapshot isolation for a scan operation when the <c>ConsistentRead</c>
        /// parameter is set to true. Thus, a DynamoDB scan operation does not guarantee that
        /// all reads in a scan see a consistent snapshot of the table when the scan operation
        /// was requested. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="tableName">The name of the table containing the requested items or if you provide <c>IndexName</c>, the name of the table to which that index belongs. You can also provide the Amazon Resource Name (ARN) of the table in this parameter.</param>
        /// <param name="attributesToGet">This is a legacy parameter. Use <c>ProjectionExpression</c> instead. For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/LegacyConditionalParameters.AttributesToGet.html">AttributesToGet</a> in the <i>Amazon DynamoDB Developer Guide</i>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Scan service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. The Amazon Web Services SDKs for DynamoDB automatically
        /// retry requests that receive this exception. Your request is eventually successful,
        /// unless your retry queue is too large to finish. Reduce the frequency of requests and
        /// use exponential backoff. For more information, go to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Programming.Errors.html#Programming.Errors.RetryAndBackoff">Error
        /// Retries and Exponential Backoff</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.RequestLimitExceededException">
        /// Throughput exceeds the current throughput quota for your account. For detailed information
        /// about why the request was throttled and the ARN of the impacted resource, find the
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. Contact <a href="https://aws.amazon.com/support">Amazon
        /// Web Services Support</a> to request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ThrottlingException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/Scan">REST API Reference for Scan Operation</seealso>
        public virtual Task<ScanResponse> ScanAsync(string tableName, List<string> attributesToGet, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ScanRequest();
            request.TableName = tableName;
            request.AttributesToGet = attributesToGet;
            return ScanAsync(request, cancellationToken);
        }


        /// <summary>
        /// The <c>Scan</c> operation returns one or more items and item attributes by accessing
        /// every item in a table or a secondary index. To have DynamoDB return fewer items, you
        /// can provide a <c>FilterExpression</c> operation.
        /// 
        ///  
        /// <para>
        /// If the total size of scanned items exceeds the maximum dataset size limit of 1 MB,
        /// the scan completes and results are returned to the user. The <c>LastEvaluatedKey</c>
        /// value is also returned and the requestor can use the <c>LastEvaluatedKey</c> to continue
        /// the scan in a subsequent operation. Each scan response also includes number of items
        /// that were scanned (ScannedCount) as part of the request. If using a <c>FilterExpression</c>,
        /// a scan result can result in no items meeting the criteria and the <c>Count</c> will
        /// result in zero. If you did not use a <c>FilterExpression</c> in the scan request,
        /// then <c>Count</c> is the same as <c>ScannedCount</c>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>Count</c> and <c>ScannedCount</c> only return the count of items specific to a
        /// single scan request and, unless the table is less than 1MB, do not represent the total
        /// number of items in the table. 
        /// </para>
        ///  </note> 
        /// <para>
        /// A single <c>Scan</c> operation first reads up to the maximum number of items set (if
        /// using the <c>Limit</c> parameter) or a maximum of 1 MB of data and then applies any
        /// filtering to the results if a <c>FilterExpression</c> is provided. If <c>LastEvaluatedKey</c>
        /// is present in the response, pagination is required to complete the full table scan.
        /// For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Scan.html#Scan.Pagination">Paginating
        /// the Results</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <c>Scan</c> operations proceed sequentially; however, for faster performance on a
        /// large table or secondary index, applications can request a parallel <c>Scan</c> operation
        /// by providing the <c>Segment</c> and <c>TotalSegments</c> parameters. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Scan.html#Scan.ParallelScan">Parallel
        /// Scan</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// By default, a <c>Scan</c> uses eventually consistent reads when accessing the items
        /// in a table. Therefore, the results from an eventually consistent <c>Scan</c> may not
        /// include the latest item changes at the time the scan iterates through each item in
        /// the table. If you require a strongly consistent read of each item as the scan iterates
        /// through the items in the table, you can set the <c>ConsistentRead</c> parameter to
        /// true. Strong consistency only relates to the consistency of the read at the item level.
        /// </para>
        ///  <note> 
        /// <para>
        ///  DynamoDB does not provide snapshot isolation for a scan operation when the <c>ConsistentRead</c>
        /// parameter is set to true. Thus, a DynamoDB scan operation does not guarantee that
        /// all reads in a scan see a consistent snapshot of the table when the scan operation
        /// was requested. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="tableName">The name of the table containing the requested items or if you provide <c>IndexName</c>, the name of the table to which that index belongs. You can also provide the Amazon Resource Name (ARN) of the table in this parameter.</param>
        /// <param name="scanFilter">This is a legacy parameter. Use <c>FilterExpression</c> instead. For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/LegacyConditionalParameters.ScanFilter.html">ScanFilter</a> in the <i>Amazon DynamoDB Developer Guide</i>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Scan service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. The Amazon Web Services SDKs for DynamoDB automatically
        /// retry requests that receive this exception. Your request is eventually successful,
        /// unless your retry queue is too large to finish. Reduce the frequency of requests and
        /// use exponential backoff. For more information, go to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Programming.Errors.html#Programming.Errors.RetryAndBackoff">Error
        /// Retries and Exponential Backoff</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.RequestLimitExceededException">
        /// Throughput exceeds the current throughput quota for your account. For detailed information
        /// about why the request was throttled and the ARN of the impacted resource, find the
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. Contact <a href="https://aws.amazon.com/support">Amazon
        /// Web Services Support</a> to request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ThrottlingException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/Scan">REST API Reference for Scan Operation</seealso>
        public virtual Task<ScanResponse> ScanAsync(string tableName, Dictionary<string, Condition> scanFilter, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ScanRequest();
            request.TableName = tableName;
            request.ScanFilter = scanFilter;
            return ScanAsync(request, cancellationToken);
        }


        /// <summary>
        /// The <c>Scan</c> operation returns one or more items and item attributes by accessing
        /// every item in a table or a secondary index. To have DynamoDB return fewer items, you
        /// can provide a <c>FilterExpression</c> operation.
        /// 
        ///  
        /// <para>
        /// If the total size of scanned items exceeds the maximum dataset size limit of 1 MB,
        /// the scan completes and results are returned to the user. The <c>LastEvaluatedKey</c>
        /// value is also returned and the requestor can use the <c>LastEvaluatedKey</c> to continue
        /// the scan in a subsequent operation. Each scan response also includes number of items
        /// that were scanned (ScannedCount) as part of the request. If using a <c>FilterExpression</c>,
        /// a scan result can result in no items meeting the criteria and the <c>Count</c> will
        /// result in zero. If you did not use a <c>FilterExpression</c> in the scan request,
        /// then <c>Count</c> is the same as <c>ScannedCount</c>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>Count</c> and <c>ScannedCount</c> only return the count of items specific to a
        /// single scan request and, unless the table is less than 1MB, do not represent the total
        /// number of items in the table. 
        /// </para>
        ///  </note> 
        /// <para>
        /// A single <c>Scan</c> operation first reads up to the maximum number of items set (if
        /// using the <c>Limit</c> parameter) or a maximum of 1 MB of data and then applies any
        /// filtering to the results if a <c>FilterExpression</c> is provided. If <c>LastEvaluatedKey</c>
        /// is present in the response, pagination is required to complete the full table scan.
        /// For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Scan.html#Scan.Pagination">Paginating
        /// the Results</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <c>Scan</c> operations proceed sequentially; however, for faster performance on a
        /// large table or secondary index, applications can request a parallel <c>Scan</c> operation
        /// by providing the <c>Segment</c> and <c>TotalSegments</c> parameters. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Scan.html#Scan.ParallelScan">Parallel
        /// Scan</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// By default, a <c>Scan</c> uses eventually consistent reads when accessing the items
        /// in a table. Therefore, the results from an eventually consistent <c>Scan</c> may not
        /// include the latest item changes at the time the scan iterates through each item in
        /// the table. If you require a strongly consistent read of each item as the scan iterates
        /// through the items in the table, you can set the <c>ConsistentRead</c> parameter to
        /// true. Strong consistency only relates to the consistency of the read at the item level.
        /// </para>
        ///  <note> 
        /// <para>
        ///  DynamoDB does not provide snapshot isolation for a scan operation when the <c>ConsistentRead</c>
        /// parameter is set to true. Thus, a DynamoDB scan operation does not guarantee that
        /// all reads in a scan see a consistent snapshot of the table when the scan operation
        /// was requested. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="tableName">The name of the table containing the requested items or if you provide <c>IndexName</c>, the name of the table to which that index belongs. You can also provide the Amazon Resource Name (ARN) of the table in this parameter.</param>
        /// <param name="attributesToGet">This is a legacy parameter. Use <c>ProjectionExpression</c> instead. For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/LegacyConditionalParameters.AttributesToGet.html">AttributesToGet</a> in the <i>Amazon DynamoDB Developer Guide</i>.</param>
        /// <param name="scanFilter">This is a legacy parameter. Use <c>FilterExpression</c> instead. For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/LegacyConditionalParameters.ScanFilter.html">ScanFilter</a> in the <i>Amazon DynamoDB Developer Guide</i>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Scan service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. The Amazon Web Services SDKs for DynamoDB automatically
        /// retry requests that receive this exception. Your request is eventually successful,
        /// unless your retry queue is too large to finish. Reduce the frequency of requests and
        /// use exponential backoff. For more information, go to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Programming.Errors.html#Programming.Errors.RetryAndBackoff">Error
        /// Retries and Exponential Backoff</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.RequestLimitExceededException">
        /// Throughput exceeds the current throughput quota for your account. For detailed information
        /// about why the request was throttled and the ARN of the impacted resource, find the
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. Contact <a href="https://aws.amazon.com/support">Amazon
        /// Web Services Support</a> to request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ThrottlingException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/Scan">REST API Reference for Scan Operation</seealso>
        public virtual Task<ScanResponse> ScanAsync(string tableName, List<string> attributesToGet, Dictionary<string, Condition> scanFilter, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ScanRequest();
            request.TableName = tableName;
            request.AttributesToGet = attributesToGet;
            request.ScanFilter = scanFilter;
            return ScanAsync(request, cancellationToken);
        }


        /// <summary>
        /// The <c>Scan</c> operation returns one or more items and item attributes by accessing
        /// every item in a table or a secondary index. To have DynamoDB return fewer items, you
        /// can provide a <c>FilterExpression</c> operation.
        /// 
        ///  
        /// <para>
        /// If the total size of scanned items exceeds the maximum dataset size limit of 1 MB,
        /// the scan completes and results are returned to the user. The <c>LastEvaluatedKey</c>
        /// value is also returned and the requestor can use the <c>LastEvaluatedKey</c> to continue
        /// the scan in a subsequent operation. Each scan response also includes number of items
        /// that were scanned (ScannedCount) as part of the request. If using a <c>FilterExpression</c>,
        /// a scan result can result in no items meeting the criteria and the <c>Count</c> will
        /// result in zero. If you did not use a <c>FilterExpression</c> in the scan request,
        /// then <c>Count</c> is the same as <c>ScannedCount</c>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>Count</c> and <c>ScannedCount</c> only return the count of items specific to a
        /// single scan request and, unless the table is less than 1MB, do not represent the total
        /// number of items in the table. 
        /// </para>
        ///  </note> 
        /// <para>
        /// A single <c>Scan</c> operation first reads up to the maximum number of items set (if
        /// using the <c>Limit</c> parameter) or a maximum of 1 MB of data and then applies any
        /// filtering to the results if a <c>FilterExpression</c> is provided. If <c>LastEvaluatedKey</c>
        /// is present in the response, pagination is required to complete the full table scan.
        /// For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Scan.html#Scan.Pagination">Paginating
        /// the Results</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <c>Scan</c> operations proceed sequentially; however, for faster performance on a
        /// large table or secondary index, applications can request a parallel <c>Scan</c> operation
        /// by providing the <c>Segment</c> and <c>TotalSegments</c> parameters. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Scan.html#Scan.ParallelScan">Parallel
        /// Scan</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// By default, a <c>Scan</c> uses eventually consistent reads when accessing the items
        /// in a table. Therefore, the results from an eventually consistent <c>Scan</c> may not
        /// include the latest item changes at the time the scan iterates through each item in
        /// the table. If you require a strongly consistent read of each item as the scan iterates
        /// through the items in the table, you can set the <c>ConsistentRead</c> parameter to
        /// true. Strong consistency only relates to the consistency of the read at the item level.
        /// </para>
        ///  <note> 
        /// <para>
        ///  DynamoDB does not provide snapshot isolation for a scan operation when the <c>ConsistentRead</c>
        /// parameter is set to true. Thus, a DynamoDB scan operation does not guarantee that
        /// all reads in a scan see a consistent snapshot of the table when the scan operation
        /// was requested. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Scan service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Scan service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. The Amazon Web Services SDKs for DynamoDB automatically
        /// retry requests that receive this exception. Your request is eventually successful,
        /// unless your retry queue is too large to finish. Reduce the frequency of requests and
        /// use exponential backoff. For more information, go to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Programming.Errors.html#Programming.Errors.RetryAndBackoff">Error
        /// Retries and Exponential Backoff</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.RequestLimitExceededException">
        /// Throughput exceeds the current throughput quota for your account. For detailed information
        /// about why the request was throttled and the ARN of the impacted resource, find the
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. Contact <a href="https://aws.amazon.com/support">Amazon
        /// Web Services Support</a> to request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ThrottlingException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/Scan">REST API Reference for Scan Operation</seealso>
        public virtual Task<ScanResponse> ScanAsync(ScanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ScanRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ScanResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = ScanEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;
            
            return InvokeAsync<ScanResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Associate a set of tags with an Amazon DynamoDB resource. You can then activate these
        /// user-defined tags so that they appear on the Billing and Cost Management console for
        /// cost allocation tracking. You can call TagResource up to five times per second, per
        /// account. 
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <c>TagResource</c> is an asynchronous operation. If you issue a <a>ListTagsOfResource</a>
        /// request immediately after a <c>TagResource</c> request, DynamoDB might return your
        /// previous tag set, if there was one, or an empty tag set. This is because <c>ListTagsOfResource</c>
        /// uses an eventually consistent query, and the metadata for your tags or table might
        /// not be available at that moment. Wait for a few seconds, and then try the <c>ListTagsOfResource</c>
        /// request again.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The application or removal of tags using <c>TagResource</c> and <c>UntagResource</c>
        /// APIs is eventually consistent. <c>ListTagsOfResource</c> API will only reflect the
        /// changes after a few seconds.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For an overview on tagging DynamoDB resources, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Tagging.html">Tagging
        /// for DynamoDB</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.LimitExceededException">
        /// There is no limit to the number of daily on-demand backups that can be taken. 
        /// 
        ///  
        /// <para>
        /// For most purposes, up to 500 simultaneous table operations are allowed per account.
        /// These operations include <c>CreateTable</c>, <c>UpdateTable</c>, <c>DeleteTable</c>,<c>UpdateTimeToLive</c>,
        /// <c>RestoreTableFromBackup</c>, and <c>RestoreTableToPointInTime</c>. 
        /// </para>
        ///  
        /// <para>
        /// When you are creating a table with one or more secondary indexes, you can have up
        /// to 250 such requests running at a time. However, if the table or index specifications
        /// are complex, then DynamoDB might temporarily reduce the number of concurrent operations.
        /// </para>
        ///  
        /// <para>
        /// When importing into DynamoDB, up to 50 simultaneous import table operations are allowed
        /// per account.
        /// </para>
        ///  
        /// <para>
        /// There is a soft account quota of 2,500 tables.
        /// </para>
        ///  
        /// <para>
        /// GetRecords was called with a value of more than 1000 for the limit request parameter.
        /// </para>
        ///  
        /// <para>
        /// More than 2 processes are reading from the same streams shard at the same time. Exceeding
        /// this limit may result in request throttling.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceInUseException">
        /// The operation conflicts with the resource's availability. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You attempted to recreate an existing table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a table currently in the <c>CREATING</c> state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a resource that was already being updated.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When appropriate, wait for the ongoing update to complete and attempt the request
        /// again.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = TagResourceEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Associate a set of tags with an Amazon DynamoDB resource. You can then activate these
        /// user-defined tags so that they appear on the Billing and Cost Management console for
        /// cost allocation tracking. You can call TagResource up to five times per second, per
        /// account. 
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <c>TagResource</c> is an asynchronous operation. If you issue a <a>ListTagsOfResource</a>
        /// request immediately after a <c>TagResource</c> request, DynamoDB might return your
        /// previous tag set, if there was one, or an empty tag set. This is because <c>ListTagsOfResource</c>
        /// uses an eventually consistent query, and the metadata for your tags or table might
        /// not be available at that moment. Wait for a few seconds, and then try the <c>ListTagsOfResource</c>
        /// request again.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The application or removal of tags using <c>TagResource</c> and <c>UntagResource</c>
        /// APIs is eventually consistent. <c>ListTagsOfResource</c> API will only reflect the
        /// changes after a few seconds.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For an overview on tagging DynamoDB resources, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Tagging.html">Tagging
        /// for DynamoDB</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.LimitExceededException">
        /// There is no limit to the number of daily on-demand backups that can be taken. 
        /// 
        ///  
        /// <para>
        /// For most purposes, up to 500 simultaneous table operations are allowed per account.
        /// These operations include <c>CreateTable</c>, <c>UpdateTable</c>, <c>DeleteTable</c>,<c>UpdateTimeToLive</c>,
        /// <c>RestoreTableFromBackup</c>, and <c>RestoreTableToPointInTime</c>. 
        /// </para>
        ///  
        /// <para>
        /// When you are creating a table with one or more secondary indexes, you can have up
        /// to 250 such requests running at a time. However, if the table or index specifications
        /// are complex, then DynamoDB might temporarily reduce the number of concurrent operations.
        /// </para>
        ///  
        /// <para>
        /// When importing into DynamoDB, up to 50 simultaneous import table operations are allowed
        /// per account.
        /// </para>
        ///  
        /// <para>
        /// There is a soft account quota of 2,500 tables.
        /// </para>
        ///  
        /// <para>
        /// GetRecords was called with a value of more than 1000 for the limit request parameter.
        /// </para>
        ///  
        /// <para>
        /// More than 2 processes are reading from the same streams shard at the same time. Exceeding
        /// this limit may result in request throttling.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceInUseException">
        /// The operation conflicts with the resource's availability. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You attempted to recreate an existing table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a table currently in the <c>CREATING</c> state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a resource that was already being updated.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When appropriate, wait for the ongoing update to complete and attempt the request
        /// again.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = TagResourceEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TransactGetItems


        /// <summary>
        /// <c>TransactGetItems</c> is a synchronous operation that atomically retrieves multiple
        /// items from one or more tables (but not from indexes) in a single account and Region.
        /// A <c>TransactGetItems</c> call can contain up to 100 <c>TransactGetItem</c> objects,
        /// each of which contains a <c>Get</c> structure that specifies an item to retrieve from
        /// a table in the account and Region. A call to <c>TransactGetItems</c> cannot retrieve
        /// items from tables in more than one Amazon Web Services account or Region. The aggregate
        /// size of the items in the transaction cannot exceed 4 MB.
        /// 
        ///  
        /// <para>
        /// DynamoDB rejects the entire <c>TransactGetItems</c> request if any of the following
        /// is true:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A conflicting operation is in the process of updating an item to be read.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is insufficient provisioned capacity for the transaction to be completed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a user error, such as an invalid data format.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The aggregate size of the items in the transaction exceeded 4 MB.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TransactGetItems service method.</param>
        /// 
        /// <returns>The response from the TransactGetItems service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. The Amazon Web Services SDKs for DynamoDB automatically
        /// retry requests that receive this exception. Your request is eventually successful,
        /// unless your retry queue is too large to finish. Reduce the frequency of requests and
        /// use exponential backoff. For more information, go to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Programming.Errors.html#Programming.Errors.RetryAndBackoff">Error
        /// Retries and Exponential Backoff</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.RequestLimitExceededException">
        /// Throughput exceeds the current throughput quota for your account. For detailed information
        /// about why the request was throttled and the ARN of the impacted resource, find the
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. Contact <a href="https://aws.amazon.com/support">Amazon
        /// Web Services Support</a> to request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ThrottlingException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.TransactionCanceledException">
        /// The entire transaction request was canceled.
        /// 
        ///  
        /// <para>
        /// DynamoDB cancels a <c>TransactWriteItems</c> request under the following circumstances:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A condition in one of the condition expressions is not met.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A table in the <c>TransactWriteItems</c> request is in a different account or region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// More than one action in the <c>TransactWriteItems</c> operation targets the same item.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is insufficient provisioned capacity for the transaction to be completed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An item size becomes too large (larger than 400 KB), or a local secondary index (LSI)
        /// becomes too large, or a similar validation error occurs because of changes made by
        /// the transaction.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a user error, such as an invalid data format.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  There is an ongoing <c>TransactWriteItems</c> operation that conflicts with a concurrent
        /// <c>TransactWriteItems</c> request. In this case the <c>TransactWriteItems</c> operation
        /// fails with a <c>TransactionCanceledException</c>. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// DynamoDB cancels a <c>TransactGetItems</c> request under the following circumstances:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// There is an ongoing <c>TransactGetItems</c> operation that conflicts with a concurrent
        /// <c>PutItem</c>, <c>UpdateItem</c>, <c>DeleteItem</c> or <c>TransactWriteItems</c>
        /// request. In this case the <c>TransactGetItems</c> operation fails with a <c>TransactionCanceledException</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A table in the <c>TransactGetItems</c> request is in a different account or region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is insufficient provisioned capacity for the transaction to be completed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a user error, such as an invalid data format.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// If using Java, DynamoDB lists the cancellation reasons on the <c>CancellationReasons</c>
        /// property. This property is not set for other languages. Transaction cancellation reasons
        /// are ordered in the order of requested items, if an item has no error it will have
        /// <c>None</c> code and <c>Null</c> message.
        /// </para>
        ///  </note> 
        /// <para>
        /// Cancellation reason codes and possible error messages:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// No Errors:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Code: <c>None</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Message: <c>null</c> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Conditional Check Failed:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Code: <c>ConditionalCheckFailed</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Message: The conditional request failed. 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Item Collection Size Limit Exceeded:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Code: <c>ItemCollectionSizeLimitExceeded</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Message: Collection size exceeded.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Transaction Conflict:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Code: <c>TransactionConflict</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Message: Transaction is ongoing for the item.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Provisioned Throughput Exceeded:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Code: <c>ProvisionedThroughputExceeded</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Messages:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The level of configured provisioned throughput for the table was exceeded. Consider
        /// increasing your provisioning level with the UpdateTable API.
        /// </para>
        ///  <note> 
        /// <para>
        /// This Message is received when provisioned throughput is exceeded is on a provisioned
        /// DynamoDB table.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// The level of configured provisioned throughput for one or more global secondary indexes
        /// of the table was exceeded. Consider increasing your provisioning level for the under-provisioned
        /// global secondary indexes with the UpdateTable API.
        /// </para>
        ///  <note> 
        /// <para>
        /// This message is returned when provisioned throughput is exceeded is on a provisioned
        /// GSI.
        /// </para>
        ///  </note> </li> </ul> </li> </ul> </li> <li> 
        /// <para>
        /// Throttling Error:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Code: <c>ThrottlingError</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Messages: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Throughput exceeds the current capacity of your table or index. DynamoDB is automatically
        /// scaling your table or index so please try again shortly. If exceptions persist, check
        /// if you have a hot key: https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/bp-partition-key-design.html.
        /// </para>
        ///  <note> 
        /// <para>
        /// This message is returned when writes get throttled on an On-Demand table as DynamoDB
        /// is automatically scaling the table.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// Throughput exceeds the current capacity for one or more global secondary indexes.
        /// DynamoDB is automatically scaling your index so please try again shortly.
        /// </para>
        ///  <note> 
        /// <para>
        /// This message is returned when writes get throttled on an On-Demand GSI as DynamoDB
        /// is automatically scaling the GSI.
        /// </para>
        ///  </note> </li> </ul> </li> </ul> </li> <li> 
        /// <para>
        /// Validation Error:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Code: <c>ValidationError</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Messages: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// One or more parameter values were invalid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The update expression attempted to update the secondary index key beyond allowed size
        /// limits.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The update expression attempted to update the secondary index key to unsupported type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An operand in the update expression has an incorrect data type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Item size to update has exceeded the maximum allowed size.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Number overflow. Attempting to store a number with magnitude larger than supported
        /// range.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Type mismatch for attribute to update.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Nesting Levels have exceeded supported limits.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The document path provided in the update expression is invalid for update.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The provided expression refers to an attribute that does not exist in the item.
        /// </para>
        ///  </li> </ul> </li> </ul> </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/TransactGetItems">REST API Reference for TransactGetItems Operation</seealso>
        public virtual TransactGetItemsResponse TransactGetItems(TransactGetItemsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TransactGetItemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TransactGetItemsResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = TransactGetItemsEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<TransactGetItemsResponse>(request, options);
        }


        /// <summary>
        /// <c>TransactGetItems</c> is a synchronous operation that atomically retrieves multiple
        /// items from one or more tables (but not from indexes) in a single account and Region.
        /// A <c>TransactGetItems</c> call can contain up to 100 <c>TransactGetItem</c> objects,
        /// each of which contains a <c>Get</c> structure that specifies an item to retrieve from
        /// a table in the account and Region. A call to <c>TransactGetItems</c> cannot retrieve
        /// items from tables in more than one Amazon Web Services account or Region. The aggregate
        /// size of the items in the transaction cannot exceed 4 MB.
        /// 
        ///  
        /// <para>
        /// DynamoDB rejects the entire <c>TransactGetItems</c> request if any of the following
        /// is true:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A conflicting operation is in the process of updating an item to be read.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is insufficient provisioned capacity for the transaction to be completed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a user error, such as an invalid data format.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The aggregate size of the items in the transaction exceeded 4 MB.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TransactGetItems service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TransactGetItems service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. The Amazon Web Services SDKs for DynamoDB automatically
        /// retry requests that receive this exception. Your request is eventually successful,
        /// unless your retry queue is too large to finish. Reduce the frequency of requests and
        /// use exponential backoff. For more information, go to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Programming.Errors.html#Programming.Errors.RetryAndBackoff">Error
        /// Retries and Exponential Backoff</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.RequestLimitExceededException">
        /// Throughput exceeds the current throughput quota for your account. For detailed information
        /// about why the request was throttled and the ARN of the impacted resource, find the
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. Contact <a href="https://aws.amazon.com/support">Amazon
        /// Web Services Support</a> to request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ThrottlingException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.TransactionCanceledException">
        /// The entire transaction request was canceled.
        /// 
        ///  
        /// <para>
        /// DynamoDB cancels a <c>TransactWriteItems</c> request under the following circumstances:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A condition in one of the condition expressions is not met.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A table in the <c>TransactWriteItems</c> request is in a different account or region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// More than one action in the <c>TransactWriteItems</c> operation targets the same item.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is insufficient provisioned capacity for the transaction to be completed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An item size becomes too large (larger than 400 KB), or a local secondary index (LSI)
        /// becomes too large, or a similar validation error occurs because of changes made by
        /// the transaction.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a user error, such as an invalid data format.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  There is an ongoing <c>TransactWriteItems</c> operation that conflicts with a concurrent
        /// <c>TransactWriteItems</c> request. In this case the <c>TransactWriteItems</c> operation
        /// fails with a <c>TransactionCanceledException</c>. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// DynamoDB cancels a <c>TransactGetItems</c> request under the following circumstances:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// There is an ongoing <c>TransactGetItems</c> operation that conflicts with a concurrent
        /// <c>PutItem</c>, <c>UpdateItem</c>, <c>DeleteItem</c> or <c>TransactWriteItems</c>
        /// request. In this case the <c>TransactGetItems</c> operation fails with a <c>TransactionCanceledException</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A table in the <c>TransactGetItems</c> request is in a different account or region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is insufficient provisioned capacity for the transaction to be completed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a user error, such as an invalid data format.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// If using Java, DynamoDB lists the cancellation reasons on the <c>CancellationReasons</c>
        /// property. This property is not set for other languages. Transaction cancellation reasons
        /// are ordered in the order of requested items, if an item has no error it will have
        /// <c>None</c> code and <c>Null</c> message.
        /// </para>
        ///  </note> 
        /// <para>
        /// Cancellation reason codes and possible error messages:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// No Errors:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Code: <c>None</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Message: <c>null</c> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Conditional Check Failed:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Code: <c>ConditionalCheckFailed</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Message: The conditional request failed. 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Item Collection Size Limit Exceeded:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Code: <c>ItemCollectionSizeLimitExceeded</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Message: Collection size exceeded.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Transaction Conflict:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Code: <c>TransactionConflict</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Message: Transaction is ongoing for the item.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Provisioned Throughput Exceeded:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Code: <c>ProvisionedThroughputExceeded</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Messages:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The level of configured provisioned throughput for the table was exceeded. Consider
        /// increasing your provisioning level with the UpdateTable API.
        /// </para>
        ///  <note> 
        /// <para>
        /// This Message is received when provisioned throughput is exceeded is on a provisioned
        /// DynamoDB table.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// The level of configured provisioned throughput for one or more global secondary indexes
        /// of the table was exceeded. Consider increasing your provisioning level for the under-provisioned
        /// global secondary indexes with the UpdateTable API.
        /// </para>
        ///  <note> 
        /// <para>
        /// This message is returned when provisioned throughput is exceeded is on a provisioned
        /// GSI.
        /// </para>
        ///  </note> </li> </ul> </li> </ul> </li> <li> 
        /// <para>
        /// Throttling Error:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Code: <c>ThrottlingError</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Messages: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Throughput exceeds the current capacity of your table or index. DynamoDB is automatically
        /// scaling your table or index so please try again shortly. If exceptions persist, check
        /// if you have a hot key: https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/bp-partition-key-design.html.
        /// </para>
        ///  <note> 
        /// <para>
        /// This message is returned when writes get throttled on an On-Demand table as DynamoDB
        /// is automatically scaling the table.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// Throughput exceeds the current capacity for one or more global secondary indexes.
        /// DynamoDB is automatically scaling your index so please try again shortly.
        /// </para>
        ///  <note> 
        /// <para>
        /// This message is returned when writes get throttled on an On-Demand GSI as DynamoDB
        /// is automatically scaling the GSI.
        /// </para>
        ///  </note> </li> </ul> </li> </ul> </li> <li> 
        /// <para>
        /// Validation Error:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Code: <c>ValidationError</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Messages: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// One or more parameter values were invalid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The update expression attempted to update the secondary index key beyond allowed size
        /// limits.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The update expression attempted to update the secondary index key to unsupported type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An operand in the update expression has an incorrect data type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Item size to update has exceeded the maximum allowed size.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Number overflow. Attempting to store a number with magnitude larger than supported
        /// range.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Type mismatch for attribute to update.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Nesting Levels have exceeded supported limits.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The document path provided in the update expression is invalid for update.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The provided expression refers to an attribute that does not exist in the item.
        /// </para>
        ///  </li> </ul> </li> </ul> </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/TransactGetItems">REST API Reference for TransactGetItems Operation</seealso>
        public virtual Task<TransactGetItemsResponse> TransactGetItemsAsync(TransactGetItemsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TransactGetItemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TransactGetItemsResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = TransactGetItemsEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;
            
            return InvokeAsync<TransactGetItemsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TransactWriteItems


        /// <summary>
        /// <c>TransactWriteItems</c> is a synchronous write operation that groups up to 100
        /// action requests. These actions can target items in different tables, but not in different
        /// Amazon Web Services accounts or Regions, and no two actions can target the same item.
        /// For example, you cannot both <c>ConditionCheck</c> and <c>Update</c> the same item.
        /// The aggregate size of the items in the transaction cannot exceed 4 MB.
        /// 
        ///  
        /// <para>
        /// The actions are completed atomically so that either all of them succeed, or all of
        /// them fail. They are defined by the following objects:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Put</c>  —   Initiates a <c>PutItem</c> operation to write a new item. This structure
        /// specifies the primary key of the item to be written, the name of the table to write
        /// it in, an optional condition expression that must be satisfied for the write to succeed,
        /// a list of the item's attributes, and a field indicating whether to retrieve the item's
        /// attributes if the condition is not met.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Update</c>  —   Initiates an <c>UpdateItem</c> operation to update an existing
        /// item. This structure specifies the primary key of the item to be updated, the name
        /// of the table where it resides, an optional condition expression that must be satisfied
        /// for the update to succeed, an expression that defines one or more attributes to be
        /// updated, and a field indicating whether to retrieve the item's attributes if the condition
        /// is not met.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Delete</c>  —   Initiates a <c>DeleteItem</c> operation to delete an existing
        /// item. This structure specifies the primary key of the item to be deleted, the name
        /// of the table where it resides, an optional condition expression that must be satisfied
        /// for the deletion to succeed, and a field indicating whether to retrieve the item's
        /// attributes if the condition is not met.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ConditionCheck</c>  —   Applies a condition to an item that is not being modified
        /// by the transaction. This structure specifies the primary key of the item to be checked,
        /// the name of the table where it resides, a condition expression that must be satisfied
        /// for the transaction to succeed, and a field indicating whether to retrieve the item's
        /// attributes if the condition is not met.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// DynamoDB rejects the entire <c>TransactWriteItems</c> request if any of the following
        /// is true:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A condition in one of the condition expressions is not met.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An ongoing operation is in the process of updating the same item.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is insufficient provisioned capacity for the transaction to be completed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An item size becomes too large (bigger than 400 KB), a local secondary index (LSI)
        /// becomes too large, or a similar validation error occurs because of changes made by
        /// the transaction.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The aggregate size of the items in the transaction exceeds 4 MB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a user error, such as an invalid data format.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TransactWriteItems service method.</param>
        /// 
        /// <returns>The response from the TransactWriteItems service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.IdempotentParameterMismatchException">
        /// DynamoDB rejected the request because you retried a request with a different payload
        /// but with an idempotent token that was already used.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. The Amazon Web Services SDKs for DynamoDB automatically
        /// retry requests that receive this exception. Your request is eventually successful,
        /// unless your retry queue is too large to finish. Reduce the frequency of requests and
        /// use exponential backoff. For more information, go to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Programming.Errors.html#Programming.Errors.RetryAndBackoff">Error
        /// Retries and Exponential Backoff</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.RequestLimitExceededException">
        /// Throughput exceeds the current throughput quota for your account. For detailed information
        /// about why the request was throttled and the ARN of the impacted resource, find the
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. Contact <a href="https://aws.amazon.com/support">Amazon
        /// Web Services Support</a> to request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ThrottlingException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.TransactionCanceledException">
        /// The entire transaction request was canceled.
        /// 
        ///  
        /// <para>
        /// DynamoDB cancels a <c>TransactWriteItems</c> request under the following circumstances:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A condition in one of the condition expressions is not met.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A table in the <c>TransactWriteItems</c> request is in a different account or region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// More than one action in the <c>TransactWriteItems</c> operation targets the same item.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is insufficient provisioned capacity for the transaction to be completed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An item size becomes too large (larger than 400 KB), or a local secondary index (LSI)
        /// becomes too large, or a similar validation error occurs because of changes made by
        /// the transaction.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a user error, such as an invalid data format.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  There is an ongoing <c>TransactWriteItems</c> operation that conflicts with a concurrent
        /// <c>TransactWriteItems</c> request. In this case the <c>TransactWriteItems</c> operation
        /// fails with a <c>TransactionCanceledException</c>. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// DynamoDB cancels a <c>TransactGetItems</c> request under the following circumstances:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// There is an ongoing <c>TransactGetItems</c> operation that conflicts with a concurrent
        /// <c>PutItem</c>, <c>UpdateItem</c>, <c>DeleteItem</c> or <c>TransactWriteItems</c>
        /// request. In this case the <c>TransactGetItems</c> operation fails with a <c>TransactionCanceledException</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A table in the <c>TransactGetItems</c> request is in a different account or region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is insufficient provisioned capacity for the transaction to be completed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a user error, such as an invalid data format.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// If using Java, DynamoDB lists the cancellation reasons on the <c>CancellationReasons</c>
        /// property. This property is not set for other languages. Transaction cancellation reasons
        /// are ordered in the order of requested items, if an item has no error it will have
        /// <c>None</c> code and <c>Null</c> message.
        /// </para>
        ///  </note> 
        /// <para>
        /// Cancellation reason codes and possible error messages:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// No Errors:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Code: <c>None</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Message: <c>null</c> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Conditional Check Failed:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Code: <c>ConditionalCheckFailed</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Message: The conditional request failed. 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Item Collection Size Limit Exceeded:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Code: <c>ItemCollectionSizeLimitExceeded</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Message: Collection size exceeded.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Transaction Conflict:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Code: <c>TransactionConflict</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Message: Transaction is ongoing for the item.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Provisioned Throughput Exceeded:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Code: <c>ProvisionedThroughputExceeded</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Messages:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The level of configured provisioned throughput for the table was exceeded. Consider
        /// increasing your provisioning level with the UpdateTable API.
        /// </para>
        ///  <note> 
        /// <para>
        /// This Message is received when provisioned throughput is exceeded is on a provisioned
        /// DynamoDB table.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// The level of configured provisioned throughput for one or more global secondary indexes
        /// of the table was exceeded. Consider increasing your provisioning level for the under-provisioned
        /// global secondary indexes with the UpdateTable API.
        /// </para>
        ///  <note> 
        /// <para>
        /// This message is returned when provisioned throughput is exceeded is on a provisioned
        /// GSI.
        /// </para>
        ///  </note> </li> </ul> </li> </ul> </li> <li> 
        /// <para>
        /// Throttling Error:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Code: <c>ThrottlingError</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Messages: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Throughput exceeds the current capacity of your table or index. DynamoDB is automatically
        /// scaling your table or index so please try again shortly. If exceptions persist, check
        /// if you have a hot key: https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/bp-partition-key-design.html.
        /// </para>
        ///  <note> 
        /// <para>
        /// This message is returned when writes get throttled on an On-Demand table as DynamoDB
        /// is automatically scaling the table.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// Throughput exceeds the current capacity for one or more global secondary indexes.
        /// DynamoDB is automatically scaling your index so please try again shortly.
        /// </para>
        ///  <note> 
        /// <para>
        /// This message is returned when writes get throttled on an On-Demand GSI as DynamoDB
        /// is automatically scaling the GSI.
        /// </para>
        ///  </note> </li> </ul> </li> </ul> </li> <li> 
        /// <para>
        /// Validation Error:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Code: <c>ValidationError</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Messages: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// One or more parameter values were invalid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The update expression attempted to update the secondary index key beyond allowed size
        /// limits.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The update expression attempted to update the secondary index key to unsupported type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An operand in the update expression has an incorrect data type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Item size to update has exceeded the maximum allowed size.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Number overflow. Attempting to store a number with magnitude larger than supported
        /// range.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Type mismatch for attribute to update.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Nesting Levels have exceeded supported limits.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The document path provided in the update expression is invalid for update.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The provided expression refers to an attribute that does not exist in the item.
        /// </para>
        ///  </li> </ul> </li> </ul> </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.TransactionInProgressException">
        /// The transaction with the given request token is already in progress.
        /// 
        ///  
        /// <para>
        ///  Recommended Settings 
        /// </para>
        ///  <note> 
        /// <para>
        ///  This is a general recommendation for handling the <c>TransactionInProgressException</c>.
        /// These settings help ensure that the client retries will trigger completion of the
        /// ongoing <c>TransactWriteItems</c> request. 
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        ///  Set <c>clientExecutionTimeout</c> to a value that allows at least one retry to be
        /// processed after 5 seconds have elapsed since the first attempt for the <c>TransactWriteItems</c>
        /// operation. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Set <c>socketTimeout</c> to a value a little lower than the <c>requestTimeout</c>
        /// setting. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>requestTimeout</c> should be set based on the time taken for the individual retries
        /// of a single HTTP request for your use case, but setting it to 1 second or higher should
        /// work well to reduce chances of retries and <c>TransactionInProgressException</c> errors.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Use exponential backoff when retrying and tune backoff if needed. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  Assuming <a href="https://github.com/aws/aws-sdk-java/blob/fd409dee8ae23fb8953e0bb4dbde65536a7e0514/aws-java-sdk-core/src/main/java/com/amazonaws/retry/PredefinedRetryPolicies.java#L97">default
        /// retry policy</a>, example timeout settings based on the guidelines above are as follows:
        /// 
        /// </para>
        ///  
        /// <para>
        /// Example timeline:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// 0-1000 first attempt
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 1000-1500 first sleep/delay (default retry policy uses 500 ms as base delay for 4xx
        /// errors)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 1500-2500 second attempt
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 2500-3500 second sleep/delay (500 * 2, exponential backoff)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 3500-4500 third attempt
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 4500-6500 third sleep/delay (500 * 2^2)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 6500-7500 fourth attempt (this can trigger inline recovery since 5 seconds have elapsed
        /// since the first attempt reached TC)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/TransactWriteItems">REST API Reference for TransactWriteItems Operation</seealso>
        public virtual TransactWriteItemsResponse TransactWriteItems(TransactWriteItemsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TransactWriteItemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TransactWriteItemsResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = TransactWriteItemsEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<TransactWriteItemsResponse>(request, options);
        }


        /// <summary>
        /// <c>TransactWriteItems</c> is a synchronous write operation that groups up to 100
        /// action requests. These actions can target items in different tables, but not in different
        /// Amazon Web Services accounts or Regions, and no two actions can target the same item.
        /// For example, you cannot both <c>ConditionCheck</c> and <c>Update</c> the same item.
        /// The aggregate size of the items in the transaction cannot exceed 4 MB.
        /// 
        ///  
        /// <para>
        /// The actions are completed atomically so that either all of them succeed, or all of
        /// them fail. They are defined by the following objects:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Put</c>  —   Initiates a <c>PutItem</c> operation to write a new item. This structure
        /// specifies the primary key of the item to be written, the name of the table to write
        /// it in, an optional condition expression that must be satisfied for the write to succeed,
        /// a list of the item's attributes, and a field indicating whether to retrieve the item's
        /// attributes if the condition is not met.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Update</c>  —   Initiates an <c>UpdateItem</c> operation to update an existing
        /// item. This structure specifies the primary key of the item to be updated, the name
        /// of the table where it resides, an optional condition expression that must be satisfied
        /// for the update to succeed, an expression that defines one or more attributes to be
        /// updated, and a field indicating whether to retrieve the item's attributes if the condition
        /// is not met.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Delete</c>  —   Initiates a <c>DeleteItem</c> operation to delete an existing
        /// item. This structure specifies the primary key of the item to be deleted, the name
        /// of the table where it resides, an optional condition expression that must be satisfied
        /// for the deletion to succeed, and a field indicating whether to retrieve the item's
        /// attributes if the condition is not met.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ConditionCheck</c>  —   Applies a condition to an item that is not being modified
        /// by the transaction. This structure specifies the primary key of the item to be checked,
        /// the name of the table where it resides, a condition expression that must be satisfied
        /// for the transaction to succeed, and a field indicating whether to retrieve the item's
        /// attributes if the condition is not met.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// DynamoDB rejects the entire <c>TransactWriteItems</c> request if any of the following
        /// is true:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A condition in one of the condition expressions is not met.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An ongoing operation is in the process of updating the same item.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is insufficient provisioned capacity for the transaction to be completed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An item size becomes too large (bigger than 400 KB), a local secondary index (LSI)
        /// becomes too large, or a similar validation error occurs because of changes made by
        /// the transaction.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The aggregate size of the items in the transaction exceeds 4 MB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a user error, such as an invalid data format.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TransactWriteItems service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TransactWriteItems service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.IdempotentParameterMismatchException">
        /// DynamoDB rejected the request because you retried a request with a different payload
        /// but with an idempotent token that was already used.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. The Amazon Web Services SDKs for DynamoDB automatically
        /// retry requests that receive this exception. Your request is eventually successful,
        /// unless your retry queue is too large to finish. Reduce the frequency of requests and
        /// use exponential backoff. For more information, go to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Programming.Errors.html#Programming.Errors.RetryAndBackoff">Error
        /// Retries and Exponential Backoff</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.RequestLimitExceededException">
        /// Throughput exceeds the current throughput quota for your account. For detailed information
        /// about why the request was throttled and the ARN of the impacted resource, find the
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. Contact <a href="https://aws.amazon.com/support">Amazon
        /// Web Services Support</a> to request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ThrottlingException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.TransactionCanceledException">
        /// The entire transaction request was canceled.
        /// 
        ///  
        /// <para>
        /// DynamoDB cancels a <c>TransactWriteItems</c> request under the following circumstances:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A condition in one of the condition expressions is not met.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A table in the <c>TransactWriteItems</c> request is in a different account or region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// More than one action in the <c>TransactWriteItems</c> operation targets the same item.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is insufficient provisioned capacity for the transaction to be completed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An item size becomes too large (larger than 400 KB), or a local secondary index (LSI)
        /// becomes too large, or a similar validation error occurs because of changes made by
        /// the transaction.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a user error, such as an invalid data format.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  There is an ongoing <c>TransactWriteItems</c> operation that conflicts with a concurrent
        /// <c>TransactWriteItems</c> request. In this case the <c>TransactWriteItems</c> operation
        /// fails with a <c>TransactionCanceledException</c>. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// DynamoDB cancels a <c>TransactGetItems</c> request under the following circumstances:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// There is an ongoing <c>TransactGetItems</c> operation that conflicts with a concurrent
        /// <c>PutItem</c>, <c>UpdateItem</c>, <c>DeleteItem</c> or <c>TransactWriteItems</c>
        /// request. In this case the <c>TransactGetItems</c> operation fails with a <c>TransactionCanceledException</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A table in the <c>TransactGetItems</c> request is in a different account or region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is insufficient provisioned capacity for the transaction to be completed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a user error, such as an invalid data format.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// If using Java, DynamoDB lists the cancellation reasons on the <c>CancellationReasons</c>
        /// property. This property is not set for other languages. Transaction cancellation reasons
        /// are ordered in the order of requested items, if an item has no error it will have
        /// <c>None</c> code and <c>Null</c> message.
        /// </para>
        ///  </note> 
        /// <para>
        /// Cancellation reason codes and possible error messages:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// No Errors:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Code: <c>None</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Message: <c>null</c> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Conditional Check Failed:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Code: <c>ConditionalCheckFailed</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Message: The conditional request failed. 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Item Collection Size Limit Exceeded:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Code: <c>ItemCollectionSizeLimitExceeded</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Message: Collection size exceeded.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Transaction Conflict:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Code: <c>TransactionConflict</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Message: Transaction is ongoing for the item.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Provisioned Throughput Exceeded:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Code: <c>ProvisionedThroughputExceeded</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Messages:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The level of configured provisioned throughput for the table was exceeded. Consider
        /// increasing your provisioning level with the UpdateTable API.
        /// </para>
        ///  <note> 
        /// <para>
        /// This Message is received when provisioned throughput is exceeded is on a provisioned
        /// DynamoDB table.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// The level of configured provisioned throughput for one or more global secondary indexes
        /// of the table was exceeded. Consider increasing your provisioning level for the under-provisioned
        /// global secondary indexes with the UpdateTable API.
        /// </para>
        ///  <note> 
        /// <para>
        /// This message is returned when provisioned throughput is exceeded is on a provisioned
        /// GSI.
        /// </para>
        ///  </note> </li> </ul> </li> </ul> </li> <li> 
        /// <para>
        /// Throttling Error:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Code: <c>ThrottlingError</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Messages: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Throughput exceeds the current capacity of your table or index. DynamoDB is automatically
        /// scaling your table or index so please try again shortly. If exceptions persist, check
        /// if you have a hot key: https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/bp-partition-key-design.html.
        /// </para>
        ///  <note> 
        /// <para>
        /// This message is returned when writes get throttled on an On-Demand table as DynamoDB
        /// is automatically scaling the table.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// Throughput exceeds the current capacity for one or more global secondary indexes.
        /// DynamoDB is automatically scaling your index so please try again shortly.
        /// </para>
        ///  <note> 
        /// <para>
        /// This message is returned when writes get throttled on an On-Demand GSI as DynamoDB
        /// is automatically scaling the GSI.
        /// </para>
        ///  </note> </li> </ul> </li> </ul> </li> <li> 
        /// <para>
        /// Validation Error:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Code: <c>ValidationError</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Messages: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// One or more parameter values were invalid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The update expression attempted to update the secondary index key beyond allowed size
        /// limits.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The update expression attempted to update the secondary index key to unsupported type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An operand in the update expression has an incorrect data type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Item size to update has exceeded the maximum allowed size.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Number overflow. Attempting to store a number with magnitude larger than supported
        /// range.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Type mismatch for attribute to update.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Nesting Levels have exceeded supported limits.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The document path provided in the update expression is invalid for update.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The provided expression refers to an attribute that does not exist in the item.
        /// </para>
        ///  </li> </ul> </li> </ul> </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.TransactionInProgressException">
        /// The transaction with the given request token is already in progress.
        /// 
        ///  
        /// <para>
        ///  Recommended Settings 
        /// </para>
        ///  <note> 
        /// <para>
        ///  This is a general recommendation for handling the <c>TransactionInProgressException</c>.
        /// These settings help ensure that the client retries will trigger completion of the
        /// ongoing <c>TransactWriteItems</c> request. 
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        ///  Set <c>clientExecutionTimeout</c> to a value that allows at least one retry to be
        /// processed after 5 seconds have elapsed since the first attempt for the <c>TransactWriteItems</c>
        /// operation. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Set <c>socketTimeout</c> to a value a little lower than the <c>requestTimeout</c>
        /// setting. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>requestTimeout</c> should be set based on the time taken for the individual retries
        /// of a single HTTP request for your use case, but setting it to 1 second or higher should
        /// work well to reduce chances of retries and <c>TransactionInProgressException</c> errors.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Use exponential backoff when retrying and tune backoff if needed. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  Assuming <a href="https://github.com/aws/aws-sdk-java/blob/fd409dee8ae23fb8953e0bb4dbde65536a7e0514/aws-java-sdk-core/src/main/java/com/amazonaws/retry/PredefinedRetryPolicies.java#L97">default
        /// retry policy</a>, example timeout settings based on the guidelines above are as follows:
        /// 
        /// </para>
        ///  
        /// <para>
        /// Example timeline:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// 0-1000 first attempt
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 1000-1500 first sleep/delay (default retry policy uses 500 ms as base delay for 4xx
        /// errors)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 1500-2500 second attempt
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 2500-3500 second sleep/delay (500 * 2, exponential backoff)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 3500-4500 third attempt
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 4500-6500 third sleep/delay (500 * 2^2)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 6500-7500 fourth attempt (this can trigger inline recovery since 5 seconds have elapsed
        /// since the first attempt reached TC)
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/TransactWriteItems">REST API Reference for TransactWriteItems Operation</seealso>
        public virtual Task<TransactWriteItemsResponse> TransactWriteItemsAsync(TransactWriteItemsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TransactWriteItemsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TransactWriteItemsResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = TransactWriteItemsEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;
            
            return InvokeAsync<TransactWriteItemsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes the association of tags from an Amazon DynamoDB resource. You can call <c>UntagResource</c>
        /// up to five times per second, per account. 
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <c>UntagResource</c> is an asynchronous operation. If you issue a <a>ListTagsOfResource</a>
        /// request immediately after an <c>UntagResource</c> request, DynamoDB might return your
        /// previous tag set, if there was one, or an empty tag set. This is because <c>ListTagsOfResource</c>
        /// uses an eventually consistent query, and the metadata for your tags or table might
        /// not be available at that moment. Wait for a few seconds, and then try the <c>ListTagsOfResource</c>
        /// request again.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The application or removal of tags using <c>TagResource</c> and <c>UntagResource</c>
        /// APIs is eventually consistent. <c>ListTagsOfResource</c> API will only reflect the
        /// changes after a few seconds.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For an overview on tagging DynamoDB resources, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Tagging.html">Tagging
        /// for DynamoDB</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.LimitExceededException">
        /// There is no limit to the number of daily on-demand backups that can be taken. 
        /// 
        ///  
        /// <para>
        /// For most purposes, up to 500 simultaneous table operations are allowed per account.
        /// These operations include <c>CreateTable</c>, <c>UpdateTable</c>, <c>DeleteTable</c>,<c>UpdateTimeToLive</c>,
        /// <c>RestoreTableFromBackup</c>, and <c>RestoreTableToPointInTime</c>. 
        /// </para>
        ///  
        /// <para>
        /// When you are creating a table with one or more secondary indexes, you can have up
        /// to 250 such requests running at a time. However, if the table or index specifications
        /// are complex, then DynamoDB might temporarily reduce the number of concurrent operations.
        /// </para>
        ///  
        /// <para>
        /// When importing into DynamoDB, up to 50 simultaneous import table operations are allowed
        /// per account.
        /// </para>
        ///  
        /// <para>
        /// There is a soft account quota of 2,500 tables.
        /// </para>
        ///  
        /// <para>
        /// GetRecords was called with a value of more than 1000 for the limit request parameter.
        /// </para>
        ///  
        /// <para>
        /// More than 2 processes are reading from the same streams shard at the same time. Exceeding
        /// this limit may result in request throttling.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceInUseException">
        /// The operation conflicts with the resource's availability. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You attempted to recreate an existing table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a table currently in the <c>CREATING</c> state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a resource that was already being updated.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When appropriate, wait for the ongoing update to complete and attempt the request
        /// again.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = UntagResourceEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Removes the association of tags from an Amazon DynamoDB resource. You can call <c>UntagResource</c>
        /// up to five times per second, per account. 
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <c>UntagResource</c> is an asynchronous operation. If you issue a <a>ListTagsOfResource</a>
        /// request immediately after an <c>UntagResource</c> request, DynamoDB might return your
        /// previous tag set, if there was one, or an empty tag set. This is because <c>ListTagsOfResource</c>
        /// uses an eventually consistent query, and the metadata for your tags or table might
        /// not be available at that moment. Wait for a few seconds, and then try the <c>ListTagsOfResource</c>
        /// request again.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The application or removal of tags using <c>TagResource</c> and <c>UntagResource</c>
        /// APIs is eventually consistent. <c>ListTagsOfResource</c> API will only reflect the
        /// changes after a few seconds.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For an overview on tagging DynamoDB resources, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Tagging.html">Tagging
        /// for DynamoDB</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.LimitExceededException">
        /// There is no limit to the number of daily on-demand backups that can be taken. 
        /// 
        ///  
        /// <para>
        /// For most purposes, up to 500 simultaneous table operations are allowed per account.
        /// These operations include <c>CreateTable</c>, <c>UpdateTable</c>, <c>DeleteTable</c>,<c>UpdateTimeToLive</c>,
        /// <c>RestoreTableFromBackup</c>, and <c>RestoreTableToPointInTime</c>. 
        /// </para>
        ///  
        /// <para>
        /// When you are creating a table with one or more secondary indexes, you can have up
        /// to 250 such requests running at a time. However, if the table or index specifications
        /// are complex, then DynamoDB might temporarily reduce the number of concurrent operations.
        /// </para>
        ///  
        /// <para>
        /// When importing into DynamoDB, up to 50 simultaneous import table operations are allowed
        /// per account.
        /// </para>
        ///  
        /// <para>
        /// There is a soft account quota of 2,500 tables.
        /// </para>
        ///  
        /// <para>
        /// GetRecords was called with a value of more than 1000 for the limit request parameter.
        /// </para>
        ///  
        /// <para>
        /// More than 2 processes are reading from the same streams shard at the same time. Exceeding
        /// this limit may result in request throttling.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceInUseException">
        /// The operation conflicts with the resource's availability. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You attempted to recreate an existing table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a table currently in the <c>CREATING</c> state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a resource that was already being updated.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When appropriate, wait for the ongoing update to complete and attempt the request
        /// again.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = UntagResourceEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateContinuousBackups


        /// <summary>
        /// <c>UpdateContinuousBackups</c> enables or disables point in time recovery for the
        /// specified table. A successful <c>UpdateContinuousBackups</c> call returns the current
        /// <c>ContinuousBackupsDescription</c>. Continuous backups are <c>ENABLED</c> on all
        /// tables at table creation. If point in time recovery is enabled, <c>PointInTimeRecoveryStatus</c>
        /// will be set to ENABLED.
        /// 
        ///  
        /// <para>
        ///  Once continuous backups and point in time recovery are enabled, you can restore to
        /// any point in time within <c>EarliestRestorableDateTime</c> and <c>LatestRestorableDateTime</c>.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <c>LatestRestorableDateTime</c> is typically 5 minutes before the current time. You
        /// can restore your table to any point in time in the last 35 days. You can set the <c>RecoveryPeriodInDays</c>
        /// to any value between 1 and 35 days.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContinuousBackups service method.</param>
        /// 
        /// <returns>The response from the UpdateContinuousBackups service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.ContinuousBackupsUnavailableException">
        /// Backups have not yet been enabled for this table.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.TableNotFoundException">
        /// A source table with the name <c>TableName</c> does not currently exist within the
        /// subscriber's account or the subscriber is operating in the wrong Amazon Web Services
        /// Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/UpdateContinuousBackups">REST API Reference for UpdateContinuousBackups Operation</seealso>
        public virtual UpdateContinuousBackupsResponse UpdateContinuousBackups(UpdateContinuousBackupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateContinuousBackupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateContinuousBackupsResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = UpdateContinuousBackupsEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<UpdateContinuousBackupsResponse>(request, options);
        }


        /// <summary>
        /// <c>UpdateContinuousBackups</c> enables or disables point in time recovery for the
        /// specified table. A successful <c>UpdateContinuousBackups</c> call returns the current
        /// <c>ContinuousBackupsDescription</c>. Continuous backups are <c>ENABLED</c> on all
        /// tables at table creation. If point in time recovery is enabled, <c>PointInTimeRecoveryStatus</c>
        /// will be set to ENABLED.
        /// 
        ///  
        /// <para>
        ///  Once continuous backups and point in time recovery are enabled, you can restore to
        /// any point in time within <c>EarliestRestorableDateTime</c> and <c>LatestRestorableDateTime</c>.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <c>LatestRestorableDateTime</c> is typically 5 minutes before the current time. You
        /// can restore your table to any point in time in the last 35 days. You can set the <c>RecoveryPeriodInDays</c>
        /// to any value between 1 and 35 days.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContinuousBackups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateContinuousBackups service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.ContinuousBackupsUnavailableException">
        /// Backups have not yet been enabled for this table.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.TableNotFoundException">
        /// A source table with the name <c>TableName</c> does not currently exist within the
        /// subscriber's account or the subscriber is operating in the wrong Amazon Web Services
        /// Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/UpdateContinuousBackups">REST API Reference for UpdateContinuousBackups Operation</seealso>
        public virtual Task<UpdateContinuousBackupsResponse> UpdateContinuousBackupsAsync(UpdateContinuousBackupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateContinuousBackupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateContinuousBackupsResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = UpdateContinuousBackupsEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;
            
            return InvokeAsync<UpdateContinuousBackupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateContributorInsights


        /// <summary>
        /// Updates the status for contributor insights for a specific table or index. CloudWatch
        /// Contributor Insights for DynamoDB graphs display the partition key and (if applicable)
        /// sort key of frequently accessed items and frequently throttled items in plaintext.
        /// If you require the use of Amazon Web Services Key Management Service (KMS) to encrypt
        /// this table’s partition key and sort key data with an Amazon Web Services managed key
        /// or customer managed key, you should not enable CloudWatch Contributor Insights for
        /// DynamoDB for this table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContributorInsights service method.</param>
        /// 
        /// <returns>The response from the UpdateContributorInsights service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/UpdateContributorInsights">REST API Reference for UpdateContributorInsights Operation</seealso>
        public virtual UpdateContributorInsightsResponse UpdateContributorInsights(UpdateContributorInsightsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateContributorInsightsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateContributorInsightsResponseUnmarshaller.Instance;

            return Invoke<UpdateContributorInsightsResponse>(request, options);
        }


        /// <summary>
        /// Updates the status for contributor insights for a specific table or index. CloudWatch
        /// Contributor Insights for DynamoDB graphs display the partition key and (if applicable)
        /// sort key of frequently accessed items and frequently throttled items in plaintext.
        /// If you require the use of Amazon Web Services Key Management Service (KMS) to encrypt
        /// this table’s partition key and sort key data with an Amazon Web Services managed key
        /// or customer managed key, you should not enable CloudWatch Contributor Insights for
        /// DynamoDB for this table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateContributorInsights service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateContributorInsights service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/UpdateContributorInsights">REST API Reference for UpdateContributorInsights Operation</seealso>
        public virtual Task<UpdateContributorInsightsResponse> UpdateContributorInsightsAsync(UpdateContributorInsightsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateContributorInsightsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateContributorInsightsResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateContributorInsightsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateGlobalTable


        /// <summary>
        /// Adds or removes replicas in the specified global table. The global table must already
        /// exist to be able to use this operation. Any replica to be added must be empty, have
        /// the same name as the global table, have the same key schema, have DynamoDB Streams
        /// enabled, and have the same provisioned and maximum write capacity units.
        /// 
        ///  <important> 
        /// <para>
        /// This documentation is for version 2017.11.29 (Legacy) of global tables, which should
        /// be avoided for new global tables. Customers should use <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/GlobalTables.html">Global
        /// Tables version 2019.11.21 (Current)</a> when possible, because it provides greater
        /// flexibility, higher efficiency, and consumes less write capacity than 2017.11.29 (Legacy).
        /// </para>
        ///  
        /// <para>
        /// To determine which version you're using, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/globaltables.DetermineVersion.html">Determining
        /// the global table version you are using</a>. To update existing global tables from
        /// version 2017.11.29 (Legacy) to version 2019.11.21 (Current), see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/V2globaltables_upgrade.html">Upgrading
        /// global tables</a>.
        /// </para>
        ///  </important> <note> 
        /// <para>
        ///  If you are using global tables <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/GlobalTables.html">Version
        /// 2019.11.21</a> (Current) you can use <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_UpdateTable.html">UpdateTable</a>
        /// instead. 
        /// </para>
        ///  
        /// <para>
        ///  Although you can use <c>UpdateGlobalTable</c> to add replicas and remove replicas
        /// in a single request, for simplicity we recommend that you issue separate requests
        /// for adding or removing replicas. 
        /// </para>
        ///  </note> 
        /// <para>
        ///  If global secondary indexes are specified, then the following conditions must also
        /// be met: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  The global secondary indexes must have the same name. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  The global secondary indexes must have the same hash key and sort key (if present).
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  The global secondary indexes must have the same provisioned and maximum write capacity
        /// units. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGlobalTable service method.</param>
        /// 
        /// <returns>The response from the UpdateGlobalTable service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.GlobalTableNotFoundException">
        /// The specified global table does not exist.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ReplicaAlreadyExistsException">
        /// The specified replica is already part of the global table.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ReplicaNotFoundException">
        /// The specified replica is no longer part of the global table.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.TableNotFoundException">
        /// A source table with the name <c>TableName</c> does not currently exist within the
        /// subscriber's account or the subscriber is operating in the wrong Amazon Web Services
        /// Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/UpdateGlobalTable">REST API Reference for UpdateGlobalTable Operation</seealso>
        public virtual UpdateGlobalTableResponse UpdateGlobalTable(UpdateGlobalTableRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGlobalTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGlobalTableResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = UpdateGlobalTableEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<UpdateGlobalTableResponse>(request, options);
        }


        /// <summary>
        /// Adds or removes replicas in the specified global table. The global table must already
        /// exist to be able to use this operation. Any replica to be added must be empty, have
        /// the same name as the global table, have the same key schema, have DynamoDB Streams
        /// enabled, and have the same provisioned and maximum write capacity units.
        /// 
        ///  <important> 
        /// <para>
        /// This documentation is for version 2017.11.29 (Legacy) of global tables, which should
        /// be avoided for new global tables. Customers should use <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/GlobalTables.html">Global
        /// Tables version 2019.11.21 (Current)</a> when possible, because it provides greater
        /// flexibility, higher efficiency, and consumes less write capacity than 2017.11.29 (Legacy).
        /// </para>
        ///  
        /// <para>
        /// To determine which version you're using, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/globaltables.DetermineVersion.html">Determining
        /// the global table version you are using</a>. To update existing global tables from
        /// version 2017.11.29 (Legacy) to version 2019.11.21 (Current), see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/V2globaltables_upgrade.html">Upgrading
        /// global tables</a>.
        /// </para>
        ///  </important> <note> 
        /// <para>
        ///  If you are using global tables <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/GlobalTables.html">Version
        /// 2019.11.21</a> (Current) you can use <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_UpdateTable.html">UpdateTable</a>
        /// instead. 
        /// </para>
        ///  
        /// <para>
        ///  Although you can use <c>UpdateGlobalTable</c> to add replicas and remove replicas
        /// in a single request, for simplicity we recommend that you issue separate requests
        /// for adding or removing replicas. 
        /// </para>
        ///  </note> 
        /// <para>
        ///  If global secondary indexes are specified, then the following conditions must also
        /// be met: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  The global secondary indexes must have the same name. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  The global secondary indexes must have the same hash key and sort key (if present).
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  The global secondary indexes must have the same provisioned and maximum write capacity
        /// units. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGlobalTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGlobalTable service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.GlobalTableNotFoundException">
        /// The specified global table does not exist.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ReplicaAlreadyExistsException">
        /// The specified replica is already part of the global table.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ReplicaNotFoundException">
        /// The specified replica is no longer part of the global table.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.TableNotFoundException">
        /// A source table with the name <c>TableName</c> does not currently exist within the
        /// subscriber's account or the subscriber is operating in the wrong Amazon Web Services
        /// Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/UpdateGlobalTable">REST API Reference for UpdateGlobalTable Operation</seealso>
        public virtual Task<UpdateGlobalTableResponse> UpdateGlobalTableAsync(UpdateGlobalTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGlobalTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGlobalTableResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = UpdateGlobalTableEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;
            
            return InvokeAsync<UpdateGlobalTableResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateGlobalTableSettings


        /// <summary>
        /// Updates settings for a global table.
        /// 
        ///  <important> 
        /// <para>
        /// This documentation is for version 2017.11.29 (Legacy) of global tables, which should
        /// be avoided for new global tables. Customers should use <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/GlobalTables.html">Global
        /// Tables version 2019.11.21 (Current)</a> when possible, because it provides greater
        /// flexibility, higher efficiency, and consumes less write capacity than 2017.11.29 (Legacy).
        /// </para>
        ///  
        /// <para>
        /// To determine which version you're using, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/globaltables.DetermineVersion.html">Determining
        /// the global table version you are using</a>. To update existing global tables from
        /// version 2017.11.29 (Legacy) to version 2019.11.21 (Current), see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/V2globaltables_upgrade.html">Upgrading
        /// global tables</a>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGlobalTableSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateGlobalTableSettings service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.GlobalTableNotFoundException">
        /// The specified global table does not exist.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.IndexNotFoundException">
        /// The operation tried to access a nonexistent index.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.LimitExceededException">
        /// There is no limit to the number of daily on-demand backups that can be taken. 
        /// 
        ///  
        /// <para>
        /// For most purposes, up to 500 simultaneous table operations are allowed per account.
        /// These operations include <c>CreateTable</c>, <c>UpdateTable</c>, <c>DeleteTable</c>,<c>UpdateTimeToLive</c>,
        /// <c>RestoreTableFromBackup</c>, and <c>RestoreTableToPointInTime</c>. 
        /// </para>
        ///  
        /// <para>
        /// When you are creating a table with one or more secondary indexes, you can have up
        /// to 250 such requests running at a time. However, if the table or index specifications
        /// are complex, then DynamoDB might temporarily reduce the number of concurrent operations.
        /// </para>
        ///  
        /// <para>
        /// When importing into DynamoDB, up to 50 simultaneous import table operations are allowed
        /// per account.
        /// </para>
        ///  
        /// <para>
        /// There is a soft account quota of 2,500 tables.
        /// </para>
        ///  
        /// <para>
        /// GetRecords was called with a value of more than 1000 for the limit request parameter.
        /// </para>
        ///  
        /// <para>
        /// More than 2 processes are reading from the same streams shard at the same time. Exceeding
        /// this limit may result in request throttling.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ReplicaNotFoundException">
        /// The specified replica is no longer part of the global table.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceInUseException">
        /// The operation conflicts with the resource's availability. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You attempted to recreate an existing table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a table currently in the <c>CREATING</c> state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a resource that was already being updated.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When appropriate, wait for the ongoing update to complete and attempt the request
        /// again.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/UpdateGlobalTableSettings">REST API Reference for UpdateGlobalTableSettings Operation</seealso>
        public virtual UpdateGlobalTableSettingsResponse UpdateGlobalTableSettings(UpdateGlobalTableSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGlobalTableSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGlobalTableSettingsResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = UpdateGlobalTableSettingsEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<UpdateGlobalTableSettingsResponse>(request, options);
        }


        /// <summary>
        /// Updates settings for a global table.
        /// 
        ///  <important> 
        /// <para>
        /// This documentation is for version 2017.11.29 (Legacy) of global tables, which should
        /// be avoided for new global tables. Customers should use <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/GlobalTables.html">Global
        /// Tables version 2019.11.21 (Current)</a> when possible, because it provides greater
        /// flexibility, higher efficiency, and consumes less write capacity than 2017.11.29 (Legacy).
        /// </para>
        ///  
        /// <para>
        /// To determine which version you're using, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/globaltables.DetermineVersion.html">Determining
        /// the global table version you are using</a>. To update existing global tables from
        /// version 2017.11.29 (Legacy) to version 2019.11.21 (Current), see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/V2globaltables_upgrade.html">Upgrading
        /// global tables</a>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGlobalTableSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGlobalTableSettings service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.GlobalTableNotFoundException">
        /// The specified global table does not exist.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.IndexNotFoundException">
        /// The operation tried to access a nonexistent index.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.LimitExceededException">
        /// There is no limit to the number of daily on-demand backups that can be taken. 
        /// 
        ///  
        /// <para>
        /// For most purposes, up to 500 simultaneous table operations are allowed per account.
        /// These operations include <c>CreateTable</c>, <c>UpdateTable</c>, <c>DeleteTable</c>,<c>UpdateTimeToLive</c>,
        /// <c>RestoreTableFromBackup</c>, and <c>RestoreTableToPointInTime</c>. 
        /// </para>
        ///  
        /// <para>
        /// When you are creating a table with one or more secondary indexes, you can have up
        /// to 250 such requests running at a time. However, if the table or index specifications
        /// are complex, then DynamoDB might temporarily reduce the number of concurrent operations.
        /// </para>
        ///  
        /// <para>
        /// When importing into DynamoDB, up to 50 simultaneous import table operations are allowed
        /// per account.
        /// </para>
        ///  
        /// <para>
        /// There is a soft account quota of 2,500 tables.
        /// </para>
        ///  
        /// <para>
        /// GetRecords was called with a value of more than 1000 for the limit request parameter.
        /// </para>
        ///  
        /// <para>
        /// More than 2 processes are reading from the same streams shard at the same time. Exceeding
        /// this limit may result in request throttling.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ReplicaNotFoundException">
        /// The specified replica is no longer part of the global table.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceInUseException">
        /// The operation conflicts with the resource's availability. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You attempted to recreate an existing table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a table currently in the <c>CREATING</c> state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a resource that was already being updated.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When appropriate, wait for the ongoing update to complete and attempt the request
        /// again.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/UpdateGlobalTableSettings">REST API Reference for UpdateGlobalTableSettings Operation</seealso>
        public virtual Task<UpdateGlobalTableSettingsResponse> UpdateGlobalTableSettingsAsync(UpdateGlobalTableSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateGlobalTableSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGlobalTableSettingsResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = UpdateGlobalTableSettingsEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;
            
            return InvokeAsync<UpdateGlobalTableSettingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateItem


        /// <summary>
        /// Edits an existing item's attributes, or adds a new item to the table if it does not
        /// already exist. You can put, delete, or add attribute values. You can also perform
        /// a conditional update on an existing item (insert a new attribute name-value pair if
        /// it doesn't exist, or replace an existing name-value pair if it has certain expected
        /// attribute values).
        /// 
        ///  
        /// <para>
        /// You can also return the item's attribute values in the same <c>UpdateItem</c> operation
        /// using the <c>ReturnValues</c> parameter.
        /// </para>
        /// </summary>
        /// <param name="tableName">The name of the table containing the item to update. You can also provide the Amazon Resource Name (ARN) of the table in this parameter.</param>
        /// <param name="key">The primary key of the item to be updated. Each element consists of an attribute name and a value for that attribute. For the primary key, you must provide all of the attributes. For example, with a simple primary key, you only need to provide a value for the partition key. For a composite primary key, you must provide values for both the partition key and the sort key.</param>
        /// <param name="attributeUpdates">This is a legacy parameter. Use <c>UpdateExpression</c> instead. For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/LegacyConditionalParameters.AttributeUpdates.html">AttributeUpdates</a> in the <i>Amazon DynamoDB Developer Guide</i>.</param>
        /// 
        /// <returns>The response from the UpdateItem service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.ConditionalCheckFailedException">
        /// A condition specified in the operation failed to be evaluated.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ItemCollectionSizeLimitExceededException">
        /// An item collection is too large. This exception is only returned for tables that have
        /// one or more local secondary indexes.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. The Amazon Web Services SDKs for DynamoDB automatically
        /// retry requests that receive this exception. Your request is eventually successful,
        /// unless your retry queue is too large to finish. Reduce the frequency of requests and
        /// use exponential backoff. For more information, go to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Programming.Errors.html#Programming.Errors.RetryAndBackoff">Error
        /// Retries and Exponential Backoff</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ReplicatedWriteConflictException">
        /// The request was rejected because one or more items in the request are being modified
        /// by a request in another Region.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.RequestLimitExceededException">
        /// Throughput exceeds the current throughput quota for your account. For detailed information
        /// about why the request was throttled and the ARN of the impacted resource, find the
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. Contact <a href="https://aws.amazon.com/support">Amazon
        /// Web Services Support</a> to request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ThrottlingException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.TransactionConflictException">
        /// Operation was rejected because there is an ongoing transaction for the item.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/UpdateItem">REST API Reference for UpdateItem Operation</seealso>
        public virtual UpdateItemResponse UpdateItem(string tableName, Dictionary<string, AttributeValue> key, Dictionary<string, AttributeValueUpdate> attributeUpdates)
        {
            var request = new UpdateItemRequest();
            request.TableName = tableName;
            request.Key = key;
            request.AttributeUpdates = attributeUpdates;
            return UpdateItem(request);
        }


        /// <summary>
        /// Edits an existing item's attributes, or adds a new item to the table if it does not
        /// already exist. You can put, delete, or add attribute values. You can also perform
        /// a conditional update on an existing item (insert a new attribute name-value pair if
        /// it doesn't exist, or replace an existing name-value pair if it has certain expected
        /// attribute values).
        /// 
        ///  
        /// <para>
        /// You can also return the item's attribute values in the same <c>UpdateItem</c> operation
        /// using the <c>ReturnValues</c> parameter.
        /// </para>
        /// </summary>
        /// <param name="tableName">The name of the table containing the item to update. You can also provide the Amazon Resource Name (ARN) of the table in this parameter.</param>
        /// <param name="key">The primary key of the item to be updated. Each element consists of an attribute name and a value for that attribute. For the primary key, you must provide all of the attributes. For example, with a simple primary key, you only need to provide a value for the partition key. For a composite primary key, you must provide values for both the partition key and the sort key.</param>
        /// <param name="attributeUpdates">This is a legacy parameter. Use <c>UpdateExpression</c> instead. For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/LegacyConditionalParameters.AttributeUpdates.html">AttributeUpdates</a> in the <i>Amazon DynamoDB Developer Guide</i>.</param>
        /// <param name="returnValues">Use <c>ReturnValues</c> if you want to get the item attributes as they appear before or after they are successfully updated. For <c>UpdateItem</c>, the valid values are: <ul> <li>  <c>NONE</c> - If <c>ReturnValues</c> is not specified, or if its value is <c>NONE</c>, then nothing is returned. (This setting is the default for <c>ReturnValues</c>.) </li> <li>  <c>ALL_OLD</c> - Returns all of the attributes of the item, as they appeared before the UpdateItem operation. </li> <li>  <c>UPDATED_OLD</c> - Returns only the updated attributes, as they appeared before the UpdateItem operation. </li> <li>  <c>ALL_NEW</c> - Returns all of the attributes of the item, as they appear after the UpdateItem operation. </li> <li>  <c>UPDATED_NEW</c> - Returns only the updated attributes, as they appear after the UpdateItem operation. </li> </ul> There is no additional cost associated with requesting a return value aside from the small network and processing overhead of receiving a larger response. No read capacity units are consumed. The values returned are strongly consistent.</param>
        /// 
        /// <returns>The response from the UpdateItem service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.ConditionalCheckFailedException">
        /// A condition specified in the operation failed to be evaluated.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ItemCollectionSizeLimitExceededException">
        /// An item collection is too large. This exception is only returned for tables that have
        /// one or more local secondary indexes.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. The Amazon Web Services SDKs for DynamoDB automatically
        /// retry requests that receive this exception. Your request is eventually successful,
        /// unless your retry queue is too large to finish. Reduce the frequency of requests and
        /// use exponential backoff. For more information, go to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Programming.Errors.html#Programming.Errors.RetryAndBackoff">Error
        /// Retries and Exponential Backoff</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ReplicatedWriteConflictException">
        /// The request was rejected because one or more items in the request are being modified
        /// by a request in another Region.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.RequestLimitExceededException">
        /// Throughput exceeds the current throughput quota for your account. For detailed information
        /// about why the request was throttled and the ARN of the impacted resource, find the
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. Contact <a href="https://aws.amazon.com/support">Amazon
        /// Web Services Support</a> to request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ThrottlingException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.TransactionConflictException">
        /// Operation was rejected because there is an ongoing transaction for the item.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/UpdateItem">REST API Reference for UpdateItem Operation</seealso>
        public virtual UpdateItemResponse UpdateItem(string tableName, Dictionary<string, AttributeValue> key, Dictionary<string, AttributeValueUpdate> attributeUpdates, ReturnValue returnValues)
        {
            var request = new UpdateItemRequest();
            request.TableName = tableName;
            request.Key = key;
            request.AttributeUpdates = attributeUpdates;
            request.ReturnValues = returnValues;
            return UpdateItem(request);
        }


        /// <summary>
        /// Edits an existing item's attributes, or adds a new item to the table if it does not
        /// already exist. You can put, delete, or add attribute values. You can also perform
        /// a conditional update on an existing item (insert a new attribute name-value pair if
        /// it doesn't exist, or replace an existing name-value pair if it has certain expected
        /// attribute values).
        /// 
        ///  
        /// <para>
        /// You can also return the item's attribute values in the same <c>UpdateItem</c> operation
        /// using the <c>ReturnValues</c> parameter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateItem service method.</param>
        /// 
        /// <returns>The response from the UpdateItem service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.ConditionalCheckFailedException">
        /// A condition specified in the operation failed to be evaluated.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ItemCollectionSizeLimitExceededException">
        /// An item collection is too large. This exception is only returned for tables that have
        /// one or more local secondary indexes.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. The Amazon Web Services SDKs for DynamoDB automatically
        /// retry requests that receive this exception. Your request is eventually successful,
        /// unless your retry queue is too large to finish. Reduce the frequency of requests and
        /// use exponential backoff. For more information, go to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Programming.Errors.html#Programming.Errors.RetryAndBackoff">Error
        /// Retries and Exponential Backoff</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ReplicatedWriteConflictException">
        /// The request was rejected because one or more items in the request are being modified
        /// by a request in another Region.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.RequestLimitExceededException">
        /// Throughput exceeds the current throughput quota for your account. For detailed information
        /// about why the request was throttled and the ARN of the impacted resource, find the
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. Contact <a href="https://aws.amazon.com/support">Amazon
        /// Web Services Support</a> to request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ThrottlingException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.TransactionConflictException">
        /// Operation was rejected because there is an ongoing transaction for the item.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/UpdateItem">REST API Reference for UpdateItem Operation</seealso>
        public virtual UpdateItemResponse UpdateItem(UpdateItemRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateItemResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = UpdateItemEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<UpdateItemResponse>(request, options);
        }


        /// <summary>
        /// Edits an existing item's attributes, or adds a new item to the table if it does not
        /// already exist. You can put, delete, or add attribute values. You can also perform
        /// a conditional update on an existing item (insert a new attribute name-value pair if
        /// it doesn't exist, or replace an existing name-value pair if it has certain expected
        /// attribute values).
        /// 
        ///  
        /// <para>
        /// You can also return the item's attribute values in the same <c>UpdateItem</c> operation
        /// using the <c>ReturnValues</c> parameter.
        /// </para>
        /// </summary>
        /// <param name="tableName">The name of the table containing the item to update. You can also provide the Amazon Resource Name (ARN) of the table in this parameter.</param>
        /// <param name="key">The primary key of the item to be updated. Each element consists of an attribute name and a value for that attribute. For the primary key, you must provide all of the attributes. For example, with a simple primary key, you only need to provide a value for the partition key. For a composite primary key, you must provide values for both the partition key and the sort key.</param>
        /// <param name="attributeUpdates">This is a legacy parameter. Use <c>UpdateExpression</c> instead. For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/LegacyConditionalParameters.AttributeUpdates.html">AttributeUpdates</a> in the <i>Amazon DynamoDB Developer Guide</i>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateItem service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.ConditionalCheckFailedException">
        /// A condition specified in the operation failed to be evaluated.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ItemCollectionSizeLimitExceededException">
        /// An item collection is too large. This exception is only returned for tables that have
        /// one or more local secondary indexes.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. The Amazon Web Services SDKs for DynamoDB automatically
        /// retry requests that receive this exception. Your request is eventually successful,
        /// unless your retry queue is too large to finish. Reduce the frequency of requests and
        /// use exponential backoff. For more information, go to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Programming.Errors.html#Programming.Errors.RetryAndBackoff">Error
        /// Retries and Exponential Backoff</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ReplicatedWriteConflictException">
        /// The request was rejected because one or more items in the request are being modified
        /// by a request in another Region.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.RequestLimitExceededException">
        /// Throughput exceeds the current throughput quota for your account. For detailed information
        /// about why the request was throttled and the ARN of the impacted resource, find the
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. Contact <a href="https://aws.amazon.com/support">Amazon
        /// Web Services Support</a> to request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ThrottlingException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.TransactionConflictException">
        /// Operation was rejected because there is an ongoing transaction for the item.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/UpdateItem">REST API Reference for UpdateItem Operation</seealso>
        public virtual Task<UpdateItemResponse> UpdateItemAsync(string tableName, Dictionary<string, AttributeValue> key, Dictionary<string, AttributeValueUpdate> attributeUpdates, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new UpdateItemRequest();
            request.TableName = tableName;
            request.Key = key;
            request.AttributeUpdates = attributeUpdates;
            return UpdateItemAsync(request, cancellationToken);
        }


        /// <summary>
        /// Edits an existing item's attributes, or adds a new item to the table if it does not
        /// already exist. You can put, delete, or add attribute values. You can also perform
        /// a conditional update on an existing item (insert a new attribute name-value pair if
        /// it doesn't exist, or replace an existing name-value pair if it has certain expected
        /// attribute values).
        /// 
        ///  
        /// <para>
        /// You can also return the item's attribute values in the same <c>UpdateItem</c> operation
        /// using the <c>ReturnValues</c> parameter.
        /// </para>
        /// </summary>
        /// <param name="tableName">The name of the table containing the item to update. You can also provide the Amazon Resource Name (ARN) of the table in this parameter.</param>
        /// <param name="key">The primary key of the item to be updated. Each element consists of an attribute name and a value for that attribute. For the primary key, you must provide all of the attributes. For example, with a simple primary key, you only need to provide a value for the partition key. For a composite primary key, you must provide values for both the partition key and the sort key.</param>
        /// <param name="attributeUpdates">This is a legacy parameter. Use <c>UpdateExpression</c> instead. For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/LegacyConditionalParameters.AttributeUpdates.html">AttributeUpdates</a> in the <i>Amazon DynamoDB Developer Guide</i>.</param>
        /// <param name="returnValues">Use <c>ReturnValues</c> if you want to get the item attributes as they appear before or after they are successfully updated. For <c>UpdateItem</c>, the valid values are: <ul> <li>  <c>NONE</c> - If <c>ReturnValues</c> is not specified, or if its value is <c>NONE</c>, then nothing is returned. (This setting is the default for <c>ReturnValues</c>.) </li> <li>  <c>ALL_OLD</c> - Returns all of the attributes of the item, as they appeared before the UpdateItem operation. </li> <li>  <c>UPDATED_OLD</c> - Returns only the updated attributes, as they appeared before the UpdateItem operation. </li> <li>  <c>ALL_NEW</c> - Returns all of the attributes of the item, as they appear after the UpdateItem operation. </li> <li>  <c>UPDATED_NEW</c> - Returns only the updated attributes, as they appear after the UpdateItem operation. </li> </ul> There is no additional cost associated with requesting a return value aside from the small network and processing overhead of receiving a larger response. No read capacity units are consumed. The values returned are strongly consistent.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateItem service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.ConditionalCheckFailedException">
        /// A condition specified in the operation failed to be evaluated.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ItemCollectionSizeLimitExceededException">
        /// An item collection is too large. This exception is only returned for tables that have
        /// one or more local secondary indexes.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. The Amazon Web Services SDKs for DynamoDB automatically
        /// retry requests that receive this exception. Your request is eventually successful,
        /// unless your retry queue is too large to finish. Reduce the frequency of requests and
        /// use exponential backoff. For more information, go to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Programming.Errors.html#Programming.Errors.RetryAndBackoff">Error
        /// Retries and Exponential Backoff</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ReplicatedWriteConflictException">
        /// The request was rejected because one or more items in the request are being modified
        /// by a request in another Region.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.RequestLimitExceededException">
        /// Throughput exceeds the current throughput quota for your account. For detailed information
        /// about why the request was throttled and the ARN of the impacted resource, find the
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. Contact <a href="https://aws.amazon.com/support">Amazon
        /// Web Services Support</a> to request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ThrottlingException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.TransactionConflictException">
        /// Operation was rejected because there is an ongoing transaction for the item.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/UpdateItem">REST API Reference for UpdateItem Operation</seealso>
        public virtual Task<UpdateItemResponse> UpdateItemAsync(string tableName, Dictionary<string, AttributeValue> key, Dictionary<string, AttributeValueUpdate> attributeUpdates, ReturnValue returnValues, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new UpdateItemRequest();
            request.TableName = tableName;
            request.Key = key;
            request.AttributeUpdates = attributeUpdates;
            request.ReturnValues = returnValues;
            return UpdateItemAsync(request, cancellationToken);
        }


        /// <summary>
        /// Edits an existing item's attributes, or adds a new item to the table if it does not
        /// already exist. You can put, delete, or add attribute values. You can also perform
        /// a conditional update on an existing item (insert a new attribute name-value pair if
        /// it doesn't exist, or replace an existing name-value pair if it has certain expected
        /// attribute values).
        /// 
        ///  
        /// <para>
        /// You can also return the item's attribute values in the same <c>UpdateItem</c> operation
        /// using the <c>ReturnValues</c> parameter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateItem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateItem service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.ConditionalCheckFailedException">
        /// A condition specified in the operation failed to be evaluated.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ItemCollectionSizeLimitExceededException">
        /// An item collection is too large. This exception is only returned for tables that have
        /// one or more local secondary indexes.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. The Amazon Web Services SDKs for DynamoDB automatically
        /// retry requests that receive this exception. Your request is eventually successful,
        /// unless your retry queue is too large to finish. Reduce the frequency of requests and
        /// use exponential backoff. For more information, go to <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Programming.Errors.html#Programming.Errors.RetryAndBackoff">Error
        /// Retries and Exponential Backoff</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ReplicatedWriteConflictException">
        /// The request was rejected because one or more items in the request are being modified
        /// by a request in another Region.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.RequestLimitExceededException">
        /// Throughput exceeds the current throughput quota for your account. For detailed information
        /// about why the request was throttled and the ARN of the impacted resource, find the
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception. Contact <a href="https://aws.amazon.com/support">Amazon
        /// Web Services Support</a> to request a quota increase.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ThrottlingException">
        /// The request was denied due to request throttling. For detailed information about why
        /// the request was throttled and the ARN of the impacted resource, find the <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_ThrottlingReason.html">ThrottlingReason</a>
        /// field in the returned exception.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.TransactionConflictException">
        /// Operation was rejected because there is an ongoing transaction for the item.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/UpdateItem">REST API Reference for UpdateItem Operation</seealso>
        public virtual Task<UpdateItemResponse> UpdateItemAsync(UpdateItemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateItemRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateItemResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = UpdateItemEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;
            
            return InvokeAsync<UpdateItemResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateKinesisStreamingDestination


        /// <summary>
        /// The command to update the Kinesis stream destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateKinesisStreamingDestination service method.</param>
        /// 
        /// <returns>The response from the UpdateKinesisStreamingDestination service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.LimitExceededException">
        /// There is no limit to the number of daily on-demand backups that can be taken. 
        /// 
        ///  
        /// <para>
        /// For most purposes, up to 500 simultaneous table operations are allowed per account.
        /// These operations include <c>CreateTable</c>, <c>UpdateTable</c>, <c>DeleteTable</c>,<c>UpdateTimeToLive</c>,
        /// <c>RestoreTableFromBackup</c>, and <c>RestoreTableToPointInTime</c>. 
        /// </para>
        ///  
        /// <para>
        /// When you are creating a table with one or more secondary indexes, you can have up
        /// to 250 such requests running at a time. However, if the table or index specifications
        /// are complex, then DynamoDB might temporarily reduce the number of concurrent operations.
        /// </para>
        ///  
        /// <para>
        /// When importing into DynamoDB, up to 50 simultaneous import table operations are allowed
        /// per account.
        /// </para>
        ///  
        /// <para>
        /// There is a soft account quota of 2,500 tables.
        /// </para>
        ///  
        /// <para>
        /// GetRecords was called with a value of more than 1000 for the limit request parameter.
        /// </para>
        ///  
        /// <para>
        /// More than 2 processes are reading from the same streams shard at the same time. Exceeding
        /// this limit may result in request throttling.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceInUseException">
        /// The operation conflicts with the resource's availability. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You attempted to recreate an existing table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a table currently in the <c>CREATING</c> state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a resource that was already being updated.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When appropriate, wait for the ongoing update to complete and attempt the request
        /// again.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/UpdateKinesisStreamingDestination">REST API Reference for UpdateKinesisStreamingDestination Operation</seealso>
        public virtual UpdateKinesisStreamingDestinationResponse UpdateKinesisStreamingDestination(UpdateKinesisStreamingDestinationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateKinesisStreamingDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKinesisStreamingDestinationResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = UpdateKinesisStreamingDestinationEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<UpdateKinesisStreamingDestinationResponse>(request, options);
        }


        /// <summary>
        /// The command to update the Kinesis stream destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateKinesisStreamingDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateKinesisStreamingDestination service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.LimitExceededException">
        /// There is no limit to the number of daily on-demand backups that can be taken. 
        /// 
        ///  
        /// <para>
        /// For most purposes, up to 500 simultaneous table operations are allowed per account.
        /// These operations include <c>CreateTable</c>, <c>UpdateTable</c>, <c>DeleteTable</c>,<c>UpdateTimeToLive</c>,
        /// <c>RestoreTableFromBackup</c>, and <c>RestoreTableToPointInTime</c>. 
        /// </para>
        ///  
        /// <para>
        /// When you are creating a table with one or more secondary indexes, you can have up
        /// to 250 such requests running at a time. However, if the table or index specifications
        /// are complex, then DynamoDB might temporarily reduce the number of concurrent operations.
        /// </para>
        ///  
        /// <para>
        /// When importing into DynamoDB, up to 50 simultaneous import table operations are allowed
        /// per account.
        /// </para>
        ///  
        /// <para>
        /// There is a soft account quota of 2,500 tables.
        /// </para>
        ///  
        /// <para>
        /// GetRecords was called with a value of more than 1000 for the limit request parameter.
        /// </para>
        ///  
        /// <para>
        /// More than 2 processes are reading from the same streams shard at the same time. Exceeding
        /// this limit may result in request throttling.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceInUseException">
        /// The operation conflicts with the resource's availability. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You attempted to recreate an existing table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a table currently in the <c>CREATING</c> state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a resource that was already being updated.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When appropriate, wait for the ongoing update to complete and attempt the request
        /// again.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/UpdateKinesisStreamingDestination">REST API Reference for UpdateKinesisStreamingDestination Operation</seealso>
        public virtual Task<UpdateKinesisStreamingDestinationResponse> UpdateKinesisStreamingDestinationAsync(UpdateKinesisStreamingDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateKinesisStreamingDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKinesisStreamingDestinationResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = UpdateKinesisStreamingDestinationEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;
            
            return InvokeAsync<UpdateKinesisStreamingDestinationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateTable


        /// <summary>
        /// Modifies the provisioned throughput settings, global secondary indexes, or DynamoDB
        /// Streams settings for a given table.
        /// 
        ///  
        /// <para>
        /// You can only perform one of the following operations at once:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Modify the provisioned throughput settings of the table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Remove a global secondary index from the table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create a new global secondary index on the table. After the index begins backfilling,
        /// you can use <c>UpdateTable</c> to perform other operations.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <c>UpdateTable</c> is an asynchronous operation; while it's executing, the table
        /// status changes from <c>ACTIVE</c> to <c>UPDATING</c>. While it's <c>UPDATING</c>,
        /// you can't issue another <c>UpdateTable</c> request. When the table returns to the
        /// <c>ACTIVE</c> state, the <c>UpdateTable</c> operation is complete.
        /// </para>
        /// </summary>
        /// <param name="tableName">The name of the table to be updated. You can also provide the Amazon Resource Name (ARN) of the table in this parameter.</param>
        /// <param name="provisionedThroughput">The new provisioned throughput settings for the specified table or index.</param>
        /// 
        /// <returns>The response from the UpdateTable service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.LimitExceededException">
        /// There is no limit to the number of daily on-demand backups that can be taken. 
        /// 
        ///  
        /// <para>
        /// For most purposes, up to 500 simultaneous table operations are allowed per account.
        /// These operations include <c>CreateTable</c>, <c>UpdateTable</c>, <c>DeleteTable</c>,<c>UpdateTimeToLive</c>,
        /// <c>RestoreTableFromBackup</c>, and <c>RestoreTableToPointInTime</c>. 
        /// </para>
        ///  
        /// <para>
        /// When you are creating a table with one or more secondary indexes, you can have up
        /// to 250 such requests running at a time. However, if the table or index specifications
        /// are complex, then DynamoDB might temporarily reduce the number of concurrent operations.
        /// </para>
        ///  
        /// <para>
        /// When importing into DynamoDB, up to 50 simultaneous import table operations are allowed
        /// per account.
        /// </para>
        ///  
        /// <para>
        /// There is a soft account quota of 2,500 tables.
        /// </para>
        ///  
        /// <para>
        /// GetRecords was called with a value of more than 1000 for the limit request parameter.
        /// </para>
        ///  
        /// <para>
        /// More than 2 processes are reading from the same streams shard at the same time. Exceeding
        /// this limit may result in request throttling.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceInUseException">
        /// The operation conflicts with the resource's availability. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You attempted to recreate an existing table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a table currently in the <c>CREATING</c> state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a resource that was already being updated.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When appropriate, wait for the ongoing update to complete and attempt the request
        /// again.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/UpdateTable">REST API Reference for UpdateTable Operation</seealso>
        public virtual UpdateTableResponse UpdateTable(string tableName, ProvisionedThroughput provisionedThroughput)
        {
            var request = new UpdateTableRequest();
            request.TableName = tableName;
            request.ProvisionedThroughput = provisionedThroughput;
            return UpdateTable(request);
        }


        /// <summary>
        /// Modifies the provisioned throughput settings, global secondary indexes, or DynamoDB
        /// Streams settings for a given table.
        /// 
        ///  
        /// <para>
        /// You can only perform one of the following operations at once:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Modify the provisioned throughput settings of the table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Remove a global secondary index from the table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create a new global secondary index on the table. After the index begins backfilling,
        /// you can use <c>UpdateTable</c> to perform other operations.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <c>UpdateTable</c> is an asynchronous operation; while it's executing, the table
        /// status changes from <c>ACTIVE</c> to <c>UPDATING</c>. While it's <c>UPDATING</c>,
        /// you can't issue another <c>UpdateTable</c> request. When the table returns to the
        /// <c>ACTIVE</c> state, the <c>UpdateTable</c> operation is complete.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTable service method.</param>
        /// 
        /// <returns>The response from the UpdateTable service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.LimitExceededException">
        /// There is no limit to the number of daily on-demand backups that can be taken. 
        /// 
        ///  
        /// <para>
        /// For most purposes, up to 500 simultaneous table operations are allowed per account.
        /// These operations include <c>CreateTable</c>, <c>UpdateTable</c>, <c>DeleteTable</c>,<c>UpdateTimeToLive</c>,
        /// <c>RestoreTableFromBackup</c>, and <c>RestoreTableToPointInTime</c>. 
        /// </para>
        ///  
        /// <para>
        /// When you are creating a table with one or more secondary indexes, you can have up
        /// to 250 such requests running at a time. However, if the table or index specifications
        /// are complex, then DynamoDB might temporarily reduce the number of concurrent operations.
        /// </para>
        ///  
        /// <para>
        /// When importing into DynamoDB, up to 50 simultaneous import table operations are allowed
        /// per account.
        /// </para>
        ///  
        /// <para>
        /// There is a soft account quota of 2,500 tables.
        /// </para>
        ///  
        /// <para>
        /// GetRecords was called with a value of more than 1000 for the limit request parameter.
        /// </para>
        ///  
        /// <para>
        /// More than 2 processes are reading from the same streams shard at the same time. Exceeding
        /// this limit may result in request throttling.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceInUseException">
        /// The operation conflicts with the resource's availability. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You attempted to recreate an existing table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a table currently in the <c>CREATING</c> state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a resource that was already being updated.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When appropriate, wait for the ongoing update to complete and attempt the request
        /// again.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/UpdateTable">REST API Reference for UpdateTable Operation</seealso>
        public virtual UpdateTableResponse UpdateTable(UpdateTableRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTableResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = UpdateTableEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<UpdateTableResponse>(request, options);
        }


        /// <summary>
        /// Modifies the provisioned throughput settings, global secondary indexes, or DynamoDB
        /// Streams settings for a given table.
        /// 
        ///  
        /// <para>
        /// You can only perform one of the following operations at once:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Modify the provisioned throughput settings of the table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Remove a global secondary index from the table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create a new global secondary index on the table. After the index begins backfilling,
        /// you can use <c>UpdateTable</c> to perform other operations.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <c>UpdateTable</c> is an asynchronous operation; while it's executing, the table
        /// status changes from <c>ACTIVE</c> to <c>UPDATING</c>. While it's <c>UPDATING</c>,
        /// you can't issue another <c>UpdateTable</c> request. When the table returns to the
        /// <c>ACTIVE</c> state, the <c>UpdateTable</c> operation is complete.
        /// </para>
        /// </summary>
        /// <param name="tableName">The name of the table to be updated. You can also provide the Amazon Resource Name (ARN) of the table in this parameter.</param>
        /// <param name="provisionedThroughput">The new provisioned throughput settings for the specified table or index.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTable service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.LimitExceededException">
        /// There is no limit to the number of daily on-demand backups that can be taken. 
        /// 
        ///  
        /// <para>
        /// For most purposes, up to 500 simultaneous table operations are allowed per account.
        /// These operations include <c>CreateTable</c>, <c>UpdateTable</c>, <c>DeleteTable</c>,<c>UpdateTimeToLive</c>,
        /// <c>RestoreTableFromBackup</c>, and <c>RestoreTableToPointInTime</c>. 
        /// </para>
        ///  
        /// <para>
        /// When you are creating a table with one or more secondary indexes, you can have up
        /// to 250 such requests running at a time. However, if the table or index specifications
        /// are complex, then DynamoDB might temporarily reduce the number of concurrent operations.
        /// </para>
        ///  
        /// <para>
        /// When importing into DynamoDB, up to 50 simultaneous import table operations are allowed
        /// per account.
        /// </para>
        ///  
        /// <para>
        /// There is a soft account quota of 2,500 tables.
        /// </para>
        ///  
        /// <para>
        /// GetRecords was called with a value of more than 1000 for the limit request parameter.
        /// </para>
        ///  
        /// <para>
        /// More than 2 processes are reading from the same streams shard at the same time. Exceeding
        /// this limit may result in request throttling.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceInUseException">
        /// The operation conflicts with the resource's availability. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You attempted to recreate an existing table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a table currently in the <c>CREATING</c> state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a resource that was already being updated.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When appropriate, wait for the ongoing update to complete and attempt the request
        /// again.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/UpdateTable">REST API Reference for UpdateTable Operation</seealso>
        public virtual Task<UpdateTableResponse> UpdateTableAsync(string tableName, ProvisionedThroughput provisionedThroughput, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new UpdateTableRequest();
            request.TableName = tableName;
            request.ProvisionedThroughput = provisionedThroughput;
            return UpdateTableAsync(request, cancellationToken);
        }


        /// <summary>
        /// Modifies the provisioned throughput settings, global secondary indexes, or DynamoDB
        /// Streams settings for a given table.
        /// 
        ///  
        /// <para>
        /// You can only perform one of the following operations at once:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Modify the provisioned throughput settings of the table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Remove a global secondary index from the table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create a new global secondary index on the table. After the index begins backfilling,
        /// you can use <c>UpdateTable</c> to perform other operations.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <c>UpdateTable</c> is an asynchronous operation; while it's executing, the table
        /// status changes from <c>ACTIVE</c> to <c>UPDATING</c>. While it's <c>UPDATING</c>,
        /// you can't issue another <c>UpdateTable</c> request. When the table returns to the
        /// <c>ACTIVE</c> state, the <c>UpdateTable</c> operation is complete.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTable service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTable service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.LimitExceededException">
        /// There is no limit to the number of daily on-demand backups that can be taken. 
        /// 
        ///  
        /// <para>
        /// For most purposes, up to 500 simultaneous table operations are allowed per account.
        /// These operations include <c>CreateTable</c>, <c>UpdateTable</c>, <c>DeleteTable</c>,<c>UpdateTimeToLive</c>,
        /// <c>RestoreTableFromBackup</c>, and <c>RestoreTableToPointInTime</c>. 
        /// </para>
        ///  
        /// <para>
        /// When you are creating a table with one or more secondary indexes, you can have up
        /// to 250 such requests running at a time. However, if the table or index specifications
        /// are complex, then DynamoDB might temporarily reduce the number of concurrent operations.
        /// </para>
        ///  
        /// <para>
        /// When importing into DynamoDB, up to 50 simultaneous import table operations are allowed
        /// per account.
        /// </para>
        ///  
        /// <para>
        /// There is a soft account quota of 2,500 tables.
        /// </para>
        ///  
        /// <para>
        /// GetRecords was called with a value of more than 1000 for the limit request parameter.
        /// </para>
        ///  
        /// <para>
        /// More than 2 processes are reading from the same streams shard at the same time. Exceeding
        /// this limit may result in request throttling.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceInUseException">
        /// The operation conflicts with the resource's availability. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You attempted to recreate an existing table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a table currently in the <c>CREATING</c> state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a resource that was already being updated.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When appropriate, wait for the ongoing update to complete and attempt the request
        /// again.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/UpdateTable">REST API Reference for UpdateTable Operation</seealso>
        public virtual Task<UpdateTableResponse> UpdateTableAsync(UpdateTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTableResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = UpdateTableEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;
            
            return InvokeAsync<UpdateTableResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateTableReplicaAutoScaling


        /// <summary>
        /// Updates auto scaling settings on your global tables at once.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTableReplicaAutoScaling service method.</param>
        /// 
        /// <returns>The response from the UpdateTableReplicaAutoScaling service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.LimitExceededException">
        /// There is no limit to the number of daily on-demand backups that can be taken. 
        /// 
        ///  
        /// <para>
        /// For most purposes, up to 500 simultaneous table operations are allowed per account.
        /// These operations include <c>CreateTable</c>, <c>UpdateTable</c>, <c>DeleteTable</c>,<c>UpdateTimeToLive</c>,
        /// <c>RestoreTableFromBackup</c>, and <c>RestoreTableToPointInTime</c>. 
        /// </para>
        ///  
        /// <para>
        /// When you are creating a table with one or more secondary indexes, you can have up
        /// to 250 such requests running at a time. However, if the table or index specifications
        /// are complex, then DynamoDB might temporarily reduce the number of concurrent operations.
        /// </para>
        ///  
        /// <para>
        /// When importing into DynamoDB, up to 50 simultaneous import table operations are allowed
        /// per account.
        /// </para>
        ///  
        /// <para>
        /// There is a soft account quota of 2,500 tables.
        /// </para>
        ///  
        /// <para>
        /// GetRecords was called with a value of more than 1000 for the limit request parameter.
        /// </para>
        ///  
        /// <para>
        /// More than 2 processes are reading from the same streams shard at the same time. Exceeding
        /// this limit may result in request throttling.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceInUseException">
        /// The operation conflicts with the resource's availability. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You attempted to recreate an existing table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a table currently in the <c>CREATING</c> state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a resource that was already being updated.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When appropriate, wait for the ongoing update to complete and attempt the request
        /// again.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/UpdateTableReplicaAutoScaling">REST API Reference for UpdateTableReplicaAutoScaling Operation</seealso>
        public virtual UpdateTableReplicaAutoScalingResponse UpdateTableReplicaAutoScaling(UpdateTableReplicaAutoScalingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTableReplicaAutoScalingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTableReplicaAutoScalingResponseUnmarshaller.Instance;

            return Invoke<UpdateTableReplicaAutoScalingResponse>(request, options);
        }


        /// <summary>
        /// Updates auto scaling settings on your global tables at once.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTableReplicaAutoScaling service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTableReplicaAutoScaling service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.LimitExceededException">
        /// There is no limit to the number of daily on-demand backups that can be taken. 
        /// 
        ///  
        /// <para>
        /// For most purposes, up to 500 simultaneous table operations are allowed per account.
        /// These operations include <c>CreateTable</c>, <c>UpdateTable</c>, <c>DeleteTable</c>,<c>UpdateTimeToLive</c>,
        /// <c>RestoreTableFromBackup</c>, and <c>RestoreTableToPointInTime</c>. 
        /// </para>
        ///  
        /// <para>
        /// When you are creating a table with one or more secondary indexes, you can have up
        /// to 250 such requests running at a time. However, if the table or index specifications
        /// are complex, then DynamoDB might temporarily reduce the number of concurrent operations.
        /// </para>
        ///  
        /// <para>
        /// When importing into DynamoDB, up to 50 simultaneous import table operations are allowed
        /// per account.
        /// </para>
        ///  
        /// <para>
        /// There is a soft account quota of 2,500 tables.
        /// </para>
        ///  
        /// <para>
        /// GetRecords was called with a value of more than 1000 for the limit request parameter.
        /// </para>
        ///  
        /// <para>
        /// More than 2 processes are reading from the same streams shard at the same time. Exceeding
        /// this limit may result in request throttling.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceInUseException">
        /// The operation conflicts with the resource's availability. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You attempted to recreate an existing table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a table currently in the <c>CREATING</c> state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a resource that was already being updated.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When appropriate, wait for the ongoing update to complete and attempt the request
        /// again.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/UpdateTableReplicaAutoScaling">REST API Reference for UpdateTableReplicaAutoScaling Operation</seealso>
        public virtual Task<UpdateTableReplicaAutoScalingResponse> UpdateTableReplicaAutoScalingAsync(UpdateTableReplicaAutoScalingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTableReplicaAutoScalingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTableReplicaAutoScalingResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateTableReplicaAutoScalingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateTimeToLive


        /// <summary>
        /// The <c>UpdateTimeToLive</c> method enables or disables Time to Live (TTL) for the
        /// specified table. A successful <c>UpdateTimeToLive</c> call returns the current <c>TimeToLiveSpecification</c>.
        /// It can take up to one hour for the change to fully process. Any additional <c>UpdateTimeToLive</c>
        /// calls for the same table during this one hour duration result in a <c>ValidationException</c>.
        /// 
        /// 
        ///  
        /// <para>
        /// TTL compares the current time in epoch time format to the time stored in the TTL attribute
        /// of an item. If the epoch time value stored in the attribute is less than the current
        /// time, the item is marked as expired and subsequently deleted.
        /// </para>
        ///  <note> 
        /// <para>
        ///  The epoch time format is the number of seconds elapsed since 12:00:00 AM January
        /// 1, 1970 UTC. 
        /// </para>
        ///  </note> 
        /// <para>
        /// DynamoDB deletes expired items on a best-effort basis to ensure availability of throughput
        /// for other data operations. 
        /// </para>
        ///  <important> 
        /// <para>
        /// DynamoDB typically deletes expired items within two days of expiration. The exact
        /// duration within which an item gets deleted after expiration is specific to the nature
        /// of the workload. Items that have expired and not been deleted will still show up in
        /// reads, queries, and scans.
        /// </para>
        ///  </important> 
        /// <para>
        /// As items are deleted, they are removed from any local secondary index and global secondary
        /// index immediately in the same eventually consistent way as a standard delete operation.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/TTL.html">Time
        /// To Live</a> in the Amazon DynamoDB Developer Guide. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTimeToLive service method.</param>
        /// 
        /// <returns>The response from the UpdateTimeToLive service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.LimitExceededException">
        /// There is no limit to the number of daily on-demand backups that can be taken. 
        /// 
        ///  
        /// <para>
        /// For most purposes, up to 500 simultaneous table operations are allowed per account.
        /// These operations include <c>CreateTable</c>, <c>UpdateTable</c>, <c>DeleteTable</c>,<c>UpdateTimeToLive</c>,
        /// <c>RestoreTableFromBackup</c>, and <c>RestoreTableToPointInTime</c>. 
        /// </para>
        ///  
        /// <para>
        /// When you are creating a table with one or more secondary indexes, you can have up
        /// to 250 such requests running at a time. However, if the table or index specifications
        /// are complex, then DynamoDB might temporarily reduce the number of concurrent operations.
        /// </para>
        ///  
        /// <para>
        /// When importing into DynamoDB, up to 50 simultaneous import table operations are allowed
        /// per account.
        /// </para>
        ///  
        /// <para>
        /// There is a soft account quota of 2,500 tables.
        /// </para>
        ///  
        /// <para>
        /// GetRecords was called with a value of more than 1000 for the limit request parameter.
        /// </para>
        ///  
        /// <para>
        /// More than 2 processes are reading from the same streams shard at the same time. Exceeding
        /// this limit may result in request throttling.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceInUseException">
        /// The operation conflicts with the resource's availability. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You attempted to recreate an existing table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a table currently in the <c>CREATING</c> state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a resource that was already being updated.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When appropriate, wait for the ongoing update to complete and attempt the request
        /// again.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/UpdateTimeToLive">REST API Reference for UpdateTimeToLive Operation</seealso>
        public virtual UpdateTimeToLiveResponse UpdateTimeToLive(UpdateTimeToLiveRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTimeToLiveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTimeToLiveResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = UpdateTimeToLiveEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;

            return Invoke<UpdateTimeToLiveResponse>(request, options);
        }


        /// <summary>
        /// The <c>UpdateTimeToLive</c> method enables or disables Time to Live (TTL) for the
        /// specified table. A successful <c>UpdateTimeToLive</c> call returns the current <c>TimeToLiveSpecification</c>.
        /// It can take up to one hour for the change to fully process. Any additional <c>UpdateTimeToLive</c>
        /// calls for the same table during this one hour duration result in a <c>ValidationException</c>.
        /// 
        /// 
        ///  
        /// <para>
        /// TTL compares the current time in epoch time format to the time stored in the TTL attribute
        /// of an item. If the epoch time value stored in the attribute is less than the current
        /// time, the item is marked as expired and subsequently deleted.
        /// </para>
        ///  <note> 
        /// <para>
        ///  The epoch time format is the number of seconds elapsed since 12:00:00 AM January
        /// 1, 1970 UTC. 
        /// </para>
        ///  </note> 
        /// <para>
        /// DynamoDB deletes expired items on a best-effort basis to ensure availability of throughput
        /// for other data operations. 
        /// </para>
        ///  <important> 
        /// <para>
        /// DynamoDB typically deletes expired items within two days of expiration. The exact
        /// duration within which an item gets deleted after expiration is specific to the nature
        /// of the workload. Items that have expired and not been deleted will still show up in
        /// reads, queries, and scans.
        /// </para>
        ///  </important> 
        /// <para>
        /// As items are deleted, they are removed from any local secondary index and global secondary
        /// index immediately in the same eventually consistent way as a standard delete operation.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/TTL.html">Time
        /// To Live</a> in the Amazon DynamoDB Developer Guide. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTimeToLive service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTimeToLive service method, as returned by DynamoDB.</returns>
        /// <exception cref="Amazon.DynamoDBv2.Model.InternalServerErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.LimitExceededException">
        /// There is no limit to the number of daily on-demand backups that can be taken. 
        /// 
        ///  
        /// <para>
        /// For most purposes, up to 500 simultaneous table operations are allowed per account.
        /// These operations include <c>CreateTable</c>, <c>UpdateTable</c>, <c>DeleteTable</c>,<c>UpdateTimeToLive</c>,
        /// <c>RestoreTableFromBackup</c>, and <c>RestoreTableToPointInTime</c>. 
        /// </para>
        ///  
        /// <para>
        /// When you are creating a table with one or more secondary indexes, you can have up
        /// to 250 such requests running at a time. However, if the table or index specifications
        /// are complex, then DynamoDB might temporarily reduce the number of concurrent operations.
        /// </para>
        ///  
        /// <para>
        /// When importing into DynamoDB, up to 50 simultaneous import table operations are allowed
        /// per account.
        /// </para>
        ///  
        /// <para>
        /// There is a soft account quota of 2,500 tables.
        /// </para>
        ///  
        /// <para>
        /// GetRecords was called with a value of more than 1000 for the limit request parameter.
        /// </para>
        ///  
        /// <para>
        /// More than 2 processes are reading from the same streams shard at the same time. Exceeding
        /// this limit may result in request throttling.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceInUseException">
        /// The operation conflicts with the resource's availability. For example:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You attempted to recreate an existing table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to delete a table currently in the <c>CREATING</c> state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a resource that was already being updated.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When appropriate, wait for the ongoing update to complete and attempt the request
        /// again.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.DynamoDBv2.Model.ResourceNotFoundException">
        /// The operation tried to access a nonexistent table or index. The resource might not
        /// be specified correctly, or its status might not be <c>ACTIVE</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dynamodb-2012-08-10/UpdateTimeToLive">REST API Reference for UpdateTimeToLive Operation</seealso>
        public virtual Task<UpdateTimeToLiveResponse> UpdateTimeToLiveAsync(UpdateTimeToLiveRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTimeToLiveRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTimeToLiveResponseUnmarshaller.Instance;
            options.EndpointDiscoveryMarshaller = UpdateTimeToLiveEndpointDiscoveryMarshaller.Instance;
            options.EndpointOperation = EndpointOperation;
            
            return InvokeAsync<UpdateTimeToLiveResponse>(request, options, cancellationToken);
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