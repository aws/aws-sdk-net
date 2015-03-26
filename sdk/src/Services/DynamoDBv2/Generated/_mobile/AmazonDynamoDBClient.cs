/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.DynamoDBv2.Model;
using Amazon.DynamoDBv2.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.DynamoDBv2
{
    /// <summary>
    /// Implementation for accessing DynamoDB
    ///
    /// Amazon DynamoDB 
    /// <para>
    ///  <b>Overview</b>
    /// </para>
    ///  
    /// <para>
    /// This is the Amazon DynamoDB API Reference. This guide provides descriptions and samples
    /// of the low-level DynamoDB API. For information about DynamoDB application development,
    /// go to the <a href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/">Amazon
    /// DynamoDB Developer Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// Instead of making the requests to the low-level DynamoDB API directly from your application,
    /// we recommend that you use the AWS Software Development Kits (SDKs). The easy-to-use
    /// libraries in the AWS SDKs make it unnecessary to call the low-level DynamoDB API directly
    /// from your application. The libraries take care of request authentication, serialization,
    /// and connection management. For more information, go to <a href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/UsingAWSSDK.html">Using
    /// the AWS SDKs with DynamoDB</a> in the <i>Amazon DynamoDB Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// If you decide to code against the low-level DynamoDB API directly, you will need to
    /// write the necessary code to authenticate your requests. For more information on signing
    /// your requests, go to <a href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/API.html">Using
    /// the DynamoDB API</a> in the <i>Amazon DynamoDB Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// The following are short descriptions of each low-level API action, organized by function.
    /// </para>
    ///  
    /// <para>
    ///  <b>Managing Tables</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// <i>CreateTable</i> - Creates a table with user-specified provisioned throughput settings.
    /// You must designate one attribute as the hash primary key for the table; you can optionally
    /// designate a second attribute as the range primary key. DynamoDB creates indexes on
    /// these key attributes for fast data access. Optionally, you can create one or more
    /// secondary indexes, which provide fast data access using non-key attributes.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// <i>DescribeTable</i> - Returns metadata for a table, such as table size, status, and
    /// index information.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// <i>UpdateTable</i> - Modifies the provisioned throughput settings for a table. Optionally,
    /// you can modify the provisioned throughput settings for global secondary indexes on
    /// the table.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// <i>ListTables</i> - Returns a list of all tables associated with the current AWS account
    /// and endpoint.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// <i>DeleteTable</i> - Deletes a table and all of its indexes.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For conceptual information about managing tables, go to <a href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/WorkingWithTables.html">Working
    /// with Tables</a> in the <i>Amazon DynamoDB Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Reading Data</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// <i>GetItem</i> - Returns a set of attributes for the item that has a given primary
    /// key. By default, <i>GetItem</i> performs an eventually consistent read; however, applications
    /// can request a strongly consistent read instead.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// <i>BatchGetItem</i> - Performs multiple <i>GetItem</i> requests for data items using
    /// their primary keys, from one table or multiple tables. The response from <i>BatchGetItem</i>
    /// has a size limit of 16 MB and returns a maximum of 100 items. Both eventually consistent
    /// and strongly consistent reads can be used.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// <i>Query</i> - Returns one or more items from a table or a secondary index. You must
    /// provide a specific hash key value. You can narrow the scope of the query using comparison
    /// operators against a range key value, or on the index key. <i>Query</i> supports either
    /// eventual or strong consistency. A single response has a size limit of 1 MB.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// <i>Scan</i> - Reads every item in a table; the result set is eventually consistent.
    /// You can limit the number of items returned by filtering the data attributes, using
    /// conditional expressions. <i>Scan</i> can be used to enable ad-hoc querying of a table
    /// against non-key attributes; however, since this is a full table scan without using
    /// an index, <i>Scan</i> should not be used for any application query use case that requires
    /// predictable performance.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For conceptual information about reading data, go to <a href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/WorkingWithItems.html">Working
    /// with Items</a> and <a href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/QueryAndScan.html">Query
    /// and Scan Operations</a> in the <i>Amazon DynamoDB Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Modifying Data</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// <i>PutItem</i> - Creates a new item, or replaces an existing item with a new item
    /// (including all the attributes). By default, if an item in the table already exists
    /// with the same primary key, the new item completely replaces the existing item. You
    /// can use conditional operators to replace an item only if its attribute values match
    /// certain conditions, or to insert a new item only if that item doesn't already exist.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// <i>UpdateItem</i> - Modifies the attributes of an existing item. You can also use
    /// conditional operators to perform an update only if the item's attribute values match
    /// certain conditions.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// <i>DeleteItem</i> - Deletes an item in a table by primary key. You can use conditional
    /// operators to perform a delete an item only if the item's attribute values match certain
    /// conditions.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// <i>BatchWriteItem</i> - Performs multiple <i>PutItem</i> and <i>DeleteItem</i> requests
    /// across multiple tables in a single request. A failure of any request(s) in the batch
    /// will not cause the entire <i>BatchWriteItem</i> operation to fail. Supports batches
    /// of up to 25 items to put or delete, with a maximum total request size of 16 MB. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For conceptual information about modifying data, go to <a href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/WorkingWithItems.html">Working
    /// with Items</a> and <a href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/QueryAndScan.html">Query
    /// and Scan Operations</a> in the <i>Amazon DynamoDB Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class AmazonDynamoDBClient : AmazonServiceClient, IAmazonDynamoDB
    {
        
        #region Constructors

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

        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 

        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.ReplaceHandler<Amazon.Runtime.Internal.RetryHandler>(new Amazon.Runtime.Internal.RetryHandler(new Amazon.DynamoDBv2.Internal.DynamoDBRetryPolicy(this.Config.MaxErrorRetry)));
        }

        #endregion

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        
        #region  BatchGetItem

        internal BatchGetItemResponse BatchGetItem(BatchGetItemRequest request)
        {
            var marshaller = new BatchGetItemRequestMarshaller();
            var unmarshaller = BatchGetItemResponseUnmarshaller.Instance;

            return Invoke<BatchGetItemRequest,BatchGetItemResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetItem operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetItem operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<BatchGetItemResponse> BatchGetItemAsync(BatchGetItemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new BatchGetItemRequestMarshaller();
            var unmarshaller = BatchGetItemResponseUnmarshaller.Instance;

            return InvokeAsync<BatchGetItemRequest,BatchGetItemResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  BatchWriteItem

        internal BatchWriteItemResponse BatchWriteItem(BatchWriteItemRequest request)
        {
            var marshaller = new BatchWriteItemRequestMarshaller();
            var unmarshaller = BatchWriteItemResponseUnmarshaller.Instance;

            return Invoke<BatchWriteItemRequest,BatchWriteItemResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchWriteItem operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchWriteItem operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<BatchWriteItemResponse> BatchWriteItemAsync(BatchWriteItemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new BatchWriteItemRequestMarshaller();
            var unmarshaller = BatchWriteItemResponseUnmarshaller.Instance;

            return InvokeAsync<BatchWriteItemRequest,BatchWriteItemResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateTable

        internal CreateTableResponse CreateTable(CreateTableRequest request)
        {
            var marshaller = new CreateTableRequestMarshaller();
            var unmarshaller = CreateTableResponseUnmarshaller.Instance;

            return Invoke<CreateTableRequest,CreateTableResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTable operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateTableResponse> CreateTableAsync(CreateTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateTableRequestMarshaller();
            var unmarshaller = CreateTableResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTableRequest,CreateTableResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteItem

        internal DeleteItemResponse DeleteItem(DeleteItemRequest request)
        {
            var marshaller = new DeleteItemRequestMarshaller();
            var unmarshaller = DeleteItemResponseUnmarshaller.Instance;

            return Invoke<DeleteItemRequest,DeleteItemResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteItem operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteItem operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteItemResponse> DeleteItemAsync(DeleteItemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteItemRequestMarshaller();
            var unmarshaller = DeleteItemResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteItemRequest,DeleteItemResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteTable

        internal DeleteTableResponse DeleteTable(DeleteTableRequest request)
        {
            var marshaller = new DeleteTableRequestMarshaller();
            var unmarshaller = DeleteTableResponseUnmarshaller.Instance;

            return Invoke<DeleteTableRequest,DeleteTableResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTable operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteTableResponse> DeleteTableAsync(DeleteTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteTableRequestMarshaller();
            var unmarshaller = DeleteTableResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTableRequest,DeleteTableResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeTable

        internal DescribeTableResponse DescribeTable(DescribeTableRequest request)
        {
            var marshaller = new DescribeTableRequestMarshaller();
            var unmarshaller = DescribeTableResponseUnmarshaller.Instance;

            return Invoke<DescribeTableRequest,DescribeTableResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTable operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeTableResponse> DescribeTableAsync(DescribeTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeTableRequestMarshaller();
            var unmarshaller = DescribeTableResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTableRequest,DescribeTableResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetItem

        internal GetItemResponse GetItem(GetItemRequest request)
        {
            var marshaller = new GetItemRequestMarshaller();
            var unmarshaller = GetItemResponseUnmarshaller.Instance;

            return Invoke<GetItemRequest,GetItemResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetItem operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetItem operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetItemResponse> GetItemAsync(GetItemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetItemRequestMarshaller();
            var unmarshaller = GetItemResponseUnmarshaller.Instance;

            return InvokeAsync<GetItemRequest,GetItemResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTables

        internal ListTablesResponse ListTables()
        {
            return ListTables(new ListTablesRequest());
        }
        internal ListTablesResponse ListTables(ListTablesRequest request)
        {
            var marshaller = new ListTablesRequestMarshaller();
            var unmarshaller = ListTablesResponseUnmarshaller.Instance;

            return Invoke<ListTablesRequest,ListTablesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTables operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTables operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ListTablesResponse> ListTablesAsync(ListTablesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListTablesRequestMarshaller();
            var unmarshaller = ListTablesResponseUnmarshaller.Instance;

            return InvokeAsync<ListTablesRequest,ListTablesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutItem

        internal PutItemResponse PutItem(PutItemRequest request)
        {
            var marshaller = new PutItemRequestMarshaller();
            var unmarshaller = PutItemResponseUnmarshaller.Instance;

            return Invoke<PutItemRequest,PutItemResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutItem operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutItem operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<PutItemResponse> PutItemAsync(PutItemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutItemRequestMarshaller();
            var unmarshaller = PutItemResponseUnmarshaller.Instance;

            return InvokeAsync<PutItemRequest,PutItemResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  Query

        internal QueryResponse Query(QueryRequest request)
        {
            var marshaller = new QueryRequestMarshaller();
            var unmarshaller = QueryResponseUnmarshaller.Instance;

            return Invoke<QueryRequest,QueryResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the Query operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Query operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<QueryResponse> QueryAsync(QueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new QueryRequestMarshaller();
            var unmarshaller = QueryResponseUnmarshaller.Instance;

            return InvokeAsync<QueryRequest,QueryResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  Scan

        internal ScanResponse Scan(ScanRequest request)
        {
            var marshaller = new ScanRequestMarshaller();
            var unmarshaller = ScanResponseUnmarshaller.Instance;

            return Invoke<ScanRequest,ScanResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the Scan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Scan operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ScanResponse> ScanAsync(ScanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ScanRequestMarshaller();
            var unmarshaller = ScanResponseUnmarshaller.Instance;

            return InvokeAsync<ScanRequest,ScanResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateItem

        internal UpdateItemResponse UpdateItem(UpdateItemRequest request)
        {
            var marshaller = new UpdateItemRequestMarshaller();
            var unmarshaller = UpdateItemResponseUnmarshaller.Instance;

            return Invoke<UpdateItemRequest,UpdateItemResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateItem operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateItem operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateItemResponse> UpdateItemAsync(UpdateItemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateItemRequestMarshaller();
            var unmarshaller = UpdateItemResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateItemRequest,UpdateItemResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateTable

        internal UpdateTableResponse UpdateTable(UpdateTableRequest request)
        {
            var marshaller = new UpdateTableRequestMarshaller();
            var unmarshaller = UpdateTableResponseUnmarshaller.Instance;

            return Invoke<UpdateTableRequest,UpdateTableResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTable operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UpdateTableResponse> UpdateTableAsync(UpdateTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UpdateTableRequestMarshaller();
            var unmarshaller = UpdateTableResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTableRequest,UpdateTableResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}