/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Threading;

using Amazon.DynamoDB.Model;
using Amazon.DynamoDB.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;


namespace Amazon.DynamoDB
{
    /// <summary>
    /// Implementation for accessing AmazonDynamoDB.
    ///  
    /// <para>Amazon DynamoDB is a fast, highly scalable, highly available, cost-effective non-relational database service.</para> <para>Amazon
    /// DynamoDB removes traditional scalability limitations on data storage while maintaining low latency and predictable performance.</para>
    /// </summary>
    public class AmazonDynamoDBClient : AmazonWebServiceClient, AmazonDynamoDB
    {
    
        AbstractAWSSigner signer = new AWS3Signer();


        /// <summary>
        /// Constructs AmazonDynamoDBClient with the credentials defined in the App.config.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonDynamoDBClient()
            : base(new RefreshingSessionAWSCredentials(), new AmazonDynamoDBConfig(), true, AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonDynamoDBClient with the credentials defined in the App.config.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonDynamoDB Configuration Object</param>
        public AmazonDynamoDBClient(AmazonDynamoDBConfig config)
            : base(new RefreshingSessionAWSCredentials(), config, true, AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonDynamoDBClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonDynamoDBClient(AWSCredentials credentials)
            : this(credentials, new AmazonDynamoDBConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDynamoDBClient with AWS Credentials and an
        /// AmazonDynamoDBClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonAutoScalingClient Configuration Object</param>
        public AmazonDynamoDBClient(AWSCredentials credentials, AmazonDynamoDBConfig clientConfig)
            : base(credentials, clientConfig, false, AuthenticationTypes.Session)
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
        /// Constructs AmazonDynamoDBClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDynamoDBClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonDynamoDBClient Configuration Object</param>
        public AmazonDynamoDBClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonDynamoDBConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.Session)
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
        /// Constructs AmazonDynamoDBClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDynamoDBClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonDynamoDBClient Configuration Object</param>
        public AmazonDynamoDBClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonDynamoDBConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.Session)
        {
        }
        

         /// <summary>
         /// <para>Retrieves one or more items and its attributes by performing a full scan of a table.</para> <para>Provide a <c>ScanFilter</c> to get
         /// more specific results.</para>
         /// </summary>
         /// 
         /// <param name="scanRequest">Container for the necessary parameters to execute the Scan service method on AmazonDynamoDB.</param>
         /// 
         /// <returns>The response from the Scan service method, as returned by AmazonDynamoDB.</returns>
         /// 
         /// <exception cref="ProvisionedThroughputExceededException"/>
         /// <exception cref="InternalServerErrorException"/>
         /// <exception cref="ResourceNotFoundException"/>
        public ScanResponse Scan(ScanRequest scanRequest) 
        {
            IRequest<ScanRequest> request = new ScanRequestMarshaller().Marshall(scanRequest);
            ScanResponse response = Invoke<ScanRequest, ScanResponse> (request, this.signer, ScanResponseUnmarshaller.GetInstance());
            return response;
        }
        

         /// <summary>
         /// <para>Adds a new table to your account.</para> <para>The table name must be unique among those associated with the AWS Account issuing the
         /// request, and the AWS Region that receives the request (e.g. <c>us-east-1</c> ).</para> <para>The <c>CreateTable</c> operation triggers an
         /// asynchronous workflow to begin creating the table. Amazon DynamoDB immediately returns the state of the table ( <c>CREATING</c> ) until the
         /// table is in the <c>ACTIVE</c> state. Once the table is in the <c>ACTIVE</c> state, you can perform data plane operations.</para>
         /// </summary>
         /// 
         /// <param name="createTableRequest">Container for the necessary parameters to execute the CreateTable service method on AmazonDynamoDB.</param>
         /// 
         /// <returns>The response from the CreateTable service method, as returned by AmazonDynamoDB.</returns>
         /// 
         /// <exception cref="ResourceInUseException"/>
         /// <exception cref="LimitExceededException"/>
         /// <exception cref="InternalServerErrorException"/>
        public CreateTableResponse CreateTable(CreateTableRequest createTableRequest) 
        {
            IRequest<CreateTableRequest> request = new CreateTableRequestMarshaller().Marshall(createTableRequest);
            CreateTableResponse response = Invoke<CreateTableRequest, CreateTableResponse> (request, this.signer, CreateTableResponseUnmarshaller.GetInstance());
            return response;
        }
        

         /// <summary>
         /// <para>Retrieves a paginated list of table names created by the AWS Account of the caller in the AWS Region (e.g. <c>us-east-1</c> ).</para>
         /// </summary>
         /// 
         /// <param name="listTablesRequest">Container for the necessary parameters to execute the ListTables service method on AmazonDynamoDB.</param>
         /// 
         /// <returns>The response from the ListTables service method, as returned by AmazonDynamoDB.</returns>
         /// 
         /// <exception cref="InternalServerErrorException"/>
        public ListTablesResponse ListTables(ListTablesRequest listTablesRequest) 
        {
            IRequest<ListTablesRequest> request = new ListTablesRequestMarshaller().Marshall(listTablesRequest);
            ListTablesResponse response = Invoke<ListTablesRequest, ListTablesResponse> (request, this.signer, ListTablesResponseUnmarshaller.GetInstance());
            return response;
        }
        

         /// <summary>
         /// <para>Retrieves a paginated list of table names created by the AWS Account of the caller in the AWS Region (e.g. <c>us-east-1</c> ).</para>
         /// </summary>
         /// 
         /// <returns>The response from the ListTables service method, as returned by AmazonDynamoDB.</returns>
         /// 
         /// <exception cref="InternalServerErrorException"/>
        public ListTablesResponse ListTables()
        {
            return ListTables(new ListTablesRequest());
        }
        

         /// <summary>
         /// <para>Gets the values of one or more items and its attributes by primary key (composite primary key, only).</para> <para>Narrow the scope of
         /// the query using comparison operators on the <c>RangeKeyValue</c> of the composite key. Use the <c>ScanIndexForward</c> parameter to get
         /// results in forward or reverse order by range key.</para>
         /// </summary>
         /// 
         /// <param name="queryRequest">Container for the necessary parameters to execute the Query service method on AmazonDynamoDB.</param>
         /// 
         /// <returns>The response from the Query service method, as returned by AmazonDynamoDB.</returns>
         /// 
         /// <exception cref="ProvisionedThroughputExceededException"/>
         /// <exception cref="InternalServerErrorException"/>
         /// <exception cref="ResourceNotFoundException"/>
        public QueryResponse Query(QueryRequest queryRequest) 
        {
            IRequest<QueryRequest> request = new QueryRequestMarshaller().Marshall(queryRequest);
            QueryResponse response = Invoke<QueryRequest, QueryResponse> (request, this.signer, QueryResponseUnmarshaller.GetInstance());
            return response;
        }
        

         /// <summary>
         /// <para>Edits an existing item's attributes.</para> <para>You can perform a conditional update (insert a new attribute name-value pair if it
         /// doesn't exist, or replace an existing name-value pair if it has certain expected attribute values).</para>
         /// </summary>
         /// 
         /// <param name="updateItemRequest">Container for the necessary parameters to execute the UpdateItem service method on AmazonDynamoDB.</param>
         /// 
         /// <returns>The response from the UpdateItem service method, as returned by AmazonDynamoDB.</returns>
         /// 
         /// <exception cref="ProvisionedThroughputExceededException"/>
         /// <exception cref="ConditionalCheckFailedException"/>
         /// <exception cref="InternalServerErrorException"/>
         /// <exception cref="ResourceNotFoundException"/>
        public UpdateItemResponse UpdateItem(UpdateItemRequest updateItemRequest) 
        {
            IRequest<UpdateItemRequest> request = new UpdateItemRequestMarshaller().Marshall(updateItemRequest);
            UpdateItemResponse response = Invoke<UpdateItemRequest, UpdateItemResponse> (request, this.signer, UpdateItemResponseUnmarshaller.GetInstance());
            return response;
        }
        

         /// <summary>
         /// <para>Updates the provisioned throughput for the given table.</para> <para>Setting the throughput for a table helps you manage performance
         /// and is part of the Provisioned Throughput feature of Amazon DynamoDB.</para>
         /// </summary>
         /// 
         /// <param name="updateTableRequest">Container for the necessary parameters to execute the UpdateTable service method on AmazonDynamoDB.</param>
         /// 
         /// <returns>The response from the UpdateTable service method, as returned by AmazonDynamoDB.</returns>
         /// 
         /// <exception cref="ResourceInUseException"/>
         /// <exception cref="LimitExceededException"/>
         /// <exception cref="InternalServerErrorException"/>
         /// <exception cref="ResourceNotFoundException"/>
        public UpdateTableResponse UpdateTable(UpdateTableRequest updateTableRequest) 
        {
            IRequest<UpdateTableRequest> request = new UpdateTableRequestMarshaller().Marshall(updateTableRequest);
            UpdateTableResponse response = Invoke<UpdateTableRequest, UpdateTableResponse> (request, this.signer, UpdateTableResponseUnmarshaller.GetInstance());
            return response;
        }
        

         /// <summary>
         /// <para>Creates a new item, or replaces an old item with a new item (including all the attributes).</para> <para>If an item already exists in
         /// the specified table with the same primary key, the new item completely replaces the existing item. You can perform a conditional put (insert
         /// a new item if one with the specified primary key doesn't exist), or replace an existing item if it has certain attribute values.</para>
         /// </summary>
         /// 
         /// <param name="putItemRequest">Container for the necessary parameters to execute the PutItem service method on AmazonDynamoDB.</param>
         /// 
         /// <returns>The response from the PutItem service method, as returned by AmazonDynamoDB.</returns>
         /// 
         /// <exception cref="ProvisionedThroughputExceededException"/>
         /// <exception cref="ConditionalCheckFailedException"/>
         /// <exception cref="InternalServerErrorException"/>
         /// <exception cref="ResourceNotFoundException"/>
        public PutItemResponse PutItem(PutItemRequest putItemRequest) 
        {
            IRequest<PutItemRequest> request = new PutItemRequestMarshaller().Marshall(putItemRequest);
            PutItemResponse response = Invoke<PutItemRequest, PutItemResponse> (request, this.signer, PutItemResponseUnmarshaller.GetInstance());
            return response;
        }
        

         /// <summary>
         /// <para>Deletes a table and all of its items.</para> <para>If the table is in the <c>ACTIVE</c> state, you can delete it. If a table is in
         /// <c>CREATING</c> or <c>UPDATING</c> states then Amazon DynamoDB returns a <c>ResourceInUseException</c> . If the specified table does not
         /// exist, Amazon DynamoDB returns a <c>ResourceNotFoundException</c> .</para>
         /// </summary>
         /// 
         /// <param name="deleteTableRequest">Container for the necessary parameters to execute the DeleteTable service method on AmazonDynamoDB.</param>
         /// 
         /// <returns>The response from the DeleteTable service method, as returned by AmazonDynamoDB.</returns>
         /// 
         /// <exception cref="ResourceInUseException"/>
         /// <exception cref="LimitExceededException"/>
         /// <exception cref="InternalServerErrorException"/>
         /// <exception cref="ResourceNotFoundException"/>
        public DeleteTableResponse DeleteTable(DeleteTableRequest deleteTableRequest) 
        {
            IRequest<DeleteTableRequest> request = new DeleteTableRequestMarshaller().Marshall(deleteTableRequest);
            DeleteTableResponse response = Invoke<DeleteTableRequest, DeleteTableResponse> (request, this.signer, DeleteTableResponseUnmarshaller.GetInstance());
            return response;
        }
        

         /// <summary>
         /// <para>Deletes a single item in a table by primary key.</para> <para>You can perform a conditional delete operation that deletes the item if
         /// it exists, or if it has an expected attribute value.</para>
         /// </summary>
         /// 
         /// <param name="deleteItemRequest">Container for the necessary parameters to execute the DeleteItem service method on AmazonDynamoDB.</param>
         /// 
         /// <returns>The response from the DeleteItem service method, as returned by AmazonDynamoDB.</returns>
         /// 
         /// <exception cref="ProvisionedThroughputExceededException"/>
         /// <exception cref="ConditionalCheckFailedException"/>
         /// <exception cref="InternalServerErrorException"/>
         /// <exception cref="ResourceNotFoundException"/>
        public DeleteItemResponse DeleteItem(DeleteItemRequest deleteItemRequest) 
        {
            IRequest<DeleteItemRequest> request = new DeleteItemRequestMarshaller().Marshall(deleteItemRequest);
            DeleteItemResponse response = Invoke<DeleteItemRequest, DeleteItemResponse> (request, this.signer, DeleteItemResponseUnmarshaller.GetInstance());
            return response;
        }
        

         /// <summary>
         /// <para>Retrieves information about the table, including the current status of the table, the primary key schema and when the table was
         /// created.</para> <para>If the table does not exist, Amazon DynamoDB returns a <c>ResourceNotFoundException</c> .</para>
         /// </summary>
         /// 
         /// <param name="describeTableRequest">Container for the necessary parameters to execute the DescribeTable service method on
         ///           AmazonDynamoDB.</param>
         /// 
         /// <returns>The response from the DescribeTable service method, as returned by AmazonDynamoDB.</returns>
         /// 
         /// <exception cref="InternalServerErrorException"/>
         /// <exception cref="ResourceNotFoundException"/>
        public DescribeTableResponse DescribeTable(DescribeTableRequest describeTableRequest) 
        {
            IRequest<DescribeTableRequest> request = new DescribeTableRequestMarshaller().Marshall(describeTableRequest);
            DescribeTableResponse response = Invoke<DescribeTableRequest, DescribeTableResponse> (request, this.signer, DescribeTableResponseUnmarshaller.GetInstance());
            return response;
        }
        

         /// <summary>
         /// <para>Retrieves a set of Attributes for an item that matches the primary key.</para> <para>The <c>GetItem</c> operation provides an
         /// eventually-consistent read by default. If eventually-consistent reads are not acceptable for your application, use <c>ConsistentRead</c> .
         /// Although this operation might take longer than a standard read, it always returns the last updated value.</para>
         /// </summary>
         /// 
         /// <param name="getItemRequest">Container for the necessary parameters to execute the GetItem service method on AmazonDynamoDB.</param>
         /// 
         /// <returns>The response from the GetItem service method, as returned by AmazonDynamoDB.</returns>
         /// 
         /// <exception cref="ProvisionedThroughputExceededException"/>
         /// <exception cref="InternalServerErrorException"/>
         /// <exception cref="ResourceNotFoundException"/>
        public GetItemResponse GetItem(GetItemRequest getItemRequest) 
        {
            IRequest<GetItemRequest> request = new GetItemRequestMarshaller().Marshall(getItemRequest);
            GetItemResponse response = Invoke<GetItemRequest, GetItemResponse> (request, this.signer, GetItemResponseUnmarshaller.GetInstance());
            return response;
        }
        

         /// <summary>
         /// <para>Retrieves the attributes for multiple items from multiple tables using their primary keys.</para> <para>The maximum number of item
         /// attributes that can be retrieved for a single operation is 100. Also, the number of items retrieved is constrained by a 1 MB the size limit.
         /// If the response size limit is exceeded or a partial result is returned due to an internal processing failure, Amazon DynamoDB returns an
         /// <c>UnprocessedKeys</c> value so you can retry the operation starting with the next item to get.</para> <para>Amazon DynamoDB automatically
         /// adjusts the number of items returned per page to enforce this limit. For example, even if you ask to retrieve 100 items, but each individual
         /// item is 50k in size, the system returns 20 items and an appropriate <c>UnprocessedKeys</c> value so you can get the next page of results. If
         /// necessary, your application needs its own logic to assemble the pages of results into one set.</para>
         /// </summary>
         /// 
         /// <param name="batchGetItemRequest">Container for the necessary parameters to execute the BatchGetItem service method on
         ///           AmazonDynamoDB.</param>
         /// 
         /// <returns>The response from the BatchGetItem service method, as returned by AmazonDynamoDB.</returns>
         /// 
         /// <exception cref="ProvisionedThroughputExceededException"/>
         /// <exception cref="InternalServerErrorException"/>
         /// <exception cref="ResourceNotFoundException"/>
        public BatchGetItemResponse BatchGetItem(BatchGetItemRequest batchGetItemRequest) 
        {
            IRequest<BatchGetItemRequest> request = new BatchGetItemRequestMarshaller().Marshall(batchGetItemRequest);
            BatchGetItemResponse response = Invoke<BatchGetItemRequest, BatchGetItemResponse> (request, this.signer, BatchGetItemResponseUnmarshaller.GetInstance());
            return response;
        }
        
        /// <summary>
        /// Override the pausing function so retries would happen more frequent then the default operation.
        /// </summary>
        /// <param name="retries">Current number of retries.</param>
        protected override void pauseExponentially(int retries)
        {
            int delay = (int)(200 * Math.Pow(2, retries - 1));
            delay = Math.Min(delay, MAX_BACKOFF_IN_MILLISECONDS);
            Thread.Sleep(delay);
        }
    }
}
    
