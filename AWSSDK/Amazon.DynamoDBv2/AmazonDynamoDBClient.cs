/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.DynamoDBv2.Model;
using Amazon.DynamoDBv2.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;


namespace Amazon.DynamoDBv2
{
    /// <summary>
    /// Implementation for accessing AmazonDynamoDBv2.
    ///  
    /// Amazon DynamoDB <b>Overview</b> <para>This is the Amazon DynamoDB API Reference. This guide provides descriptions and samples of the Amazon
    /// DynamoDB API. </para>
    /// </summary>
    public class AmazonDynamoDBClient : AmazonWebServiceClient, AmazonDynamoDB
    {
    
        AbstractAWSSigner signer = new AWS4Signer();

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
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonDynamoDBClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDynamoDBConfig(), true, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonDynamoDBClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
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
        /// <param name="region">The region to connect.</param>
        public AmazonDynamoDBClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDynamoDBConfig(){RegionEndpoint = region}, true, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonDynamoDBClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
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
        /// <param name="config">The AmazonDynamoDBv2 Configuration Object</param>
        public AmazonDynamoDBClient(AmazonDynamoDBConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config, true, AuthenticationTypes.User | AuthenticationTypes.Session) { }

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
            : this(credentials, new AmazonDynamoDBConfig(){RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonDynamoDBClient with AWS Credentials and an
        /// AmazonDynamoDBClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonDynamoDBClient Configuration Object</param>
        public AmazonDynamoDBClient(AWSCredentials credentials, AmazonDynamoDBConfig clientConfig)
            : base(credentials, clientConfig, false, AuthenticationTypes.User | AuthenticationTypes.Session)
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
        /// AmazonDynamoDBClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonDynamoDBClient Configuration Object</param>
        public AmazonDynamoDBClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonDynamoDBConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
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
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDynamoDBConfig(){RegionEndpoint = region})
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
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        #endregion
   
        #region Scan

        /// <summary>
        /// <para>The <i>Scan</i> operation returns one or more items and item attributes by accessing every item in the table. To have Amazon DynamoDB
        /// return fewer items, you can provide a <i>ScanFilter</i> .</para> <para>If the total number of scanned items exceeds the maximum data set
        /// size limit of 1 MB, the scan stops and results are returned to the user with a <i>LastEvaluatedKey</i> to continue the scan in a subsequent
        /// operation. The results also include the number of items exceeding the limit. A scan can result in no table data meeting the filter criteria.
        /// </para> <para>The result set is eventually consistent. </para> <para>By default, <i>Scan</i> operations proceed sequentially; however, for
        /// faster performance on large tables, applications can perform a parallel <i>Scan</i> by specifying the <i>Segment</i> and
        /// <i>TotalSegments</i> parameters. For more information, see Parallel Scan in the <i>Amazon DynamoDB Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="scanRequest">Container for the necessary parameters to execute the Scan service method on AmazonDynamoDBv2.</param>
        /// 
        /// <returns>The response from the Scan service method, as returned by AmazonDynamoDBv2.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ProvisionedThroughputExceededException"/>
        /// <exception cref="InternalServerErrorException"/>
        public ScanResponse Scan(ScanRequest scanRequest)
        {
            IAsyncResult asyncResult = invokeScan(scanRequest, null, null, true);
            return EndScan(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the Scan operation.
        /// <seealso cref="Amazon.DynamoDBv2.AmazonDynamoDB.Scan"/>
        /// </summary>
        /// 
        /// <param name="scanRequest">Container for the necessary parameters to execute the Scan operation on AmazonDynamoDBv2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndScan
        ///         operation.</returns>
        public IAsyncResult BeginScan(ScanRequest scanRequest, AsyncCallback callback, object state)
        {
            return invokeScan(scanRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the Scan operation.
        /// <seealso cref="Amazon.DynamoDBv2.AmazonDynamoDB.Scan"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginScan.</param>
        /// 
        /// <returns>Returns a ScanResult from AmazonDynamoDBv2.</returns>
        public ScanResponse EndScan(IAsyncResult asyncResult)
        {
            return endOperation<ScanResponse>(asyncResult);
        }
        
        IAsyncResult invokeScan(ScanRequest scanRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ScanRequestMarshaller().Marshall(scanRequest);
            var unmarshaller = ScanResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region UpdateTable

        /// <summary>
        /// <para>Updates the provisioned throughput for the given table. Setting the throughput for a table helps you manage performance and is part of
        /// the provisioned throughput feature of Amazon DynamoDB.</para> <para>The provisioned throughput values can be upgraded or downgraded based on
        /// the maximums and minimums listed in the Limits section in the <i>Amazon DynamoDB Developer Guide</i> .</para> <para>The table must be in
        /// the <c>ACTIVE</c> state for this operation to succeed. <i>UpdateTable</i> is an asynchronous operation; while executing the operation, the
        /// table is in the <c>UPDATING</c> state. While the table is in the <c>UPDATING</c> state, the table still has the provisioned throughput from
        /// before the call. The new provisioned throughput setting is in effect only when the table returns to the <c>ACTIVE</c> state after the
        /// <i>UpdateTable</i> operation. </para> <para>You cannot add, modify or delete local secondary indexes using <i>UpdateTable</i> . Local
        /// secondary indexes can only be defined at table creation time.</para>
        /// </summary>
        /// 
        /// <param name="updateTableRequest">Container for the necessary parameters to execute the UpdateTable service method on
        ///          AmazonDynamoDBv2.</param>
        /// 
        /// <returns>The response from the UpdateTable service method, as returned by AmazonDynamoDBv2.</returns>
        /// 
        /// <exception cref="ResourceInUseException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="InternalServerErrorException"/>
        public UpdateTableResponse UpdateTable(UpdateTableRequest updateTableRequest)
        {
            IAsyncResult asyncResult = invokeUpdateTable(updateTableRequest, null, null, true);
            return EndUpdateTable(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTable operation.
        /// <seealso cref="Amazon.DynamoDBv2.AmazonDynamoDB.UpdateTable"/>
        /// </summary>
        /// 
        /// <param name="updateTableRequest">Container for the necessary parameters to execute the UpdateTable operation on AmazonDynamoDBv2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTable
        ///         operation.</returns>
        public IAsyncResult BeginUpdateTable(UpdateTableRequest updateTableRequest, AsyncCallback callback, object state)
        {
            return invokeUpdateTable(updateTableRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateTable operation.
        /// <seealso cref="Amazon.DynamoDBv2.AmazonDynamoDB.UpdateTable"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTable.</param>
        /// 
        /// <returns>Returns a UpdateTableResult from AmazonDynamoDBv2.</returns>
        public UpdateTableResponse EndUpdateTable(IAsyncResult asyncResult)
        {
            return endOperation<UpdateTableResponse>(asyncResult);
        }
        
        IAsyncResult invokeUpdateTable(UpdateTableRequest updateTableRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdateTableRequestMarshaller().Marshall(updateTableRequest);
            var unmarshaller = UpdateTableResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteTable

        /// <summary>
        /// <para>The <i>DeleteTable</i> operation deletes a table and all of its items. After a <i>DeleteTable</i> request, the specified table is in
        /// the <c>DELETING</c> state until Amazon DynamoDB completes the deletion. If the table is in the <c>ACTIVE</c> state, you can delete it. If a
        /// table is in <c>CREATING</c> or <c>UPDATING</c> states, then Amazon DynamoDB returns a
        /// <i>ResourceInUseException</i> . If the specified table does not exist, Amazon DynamoDB returns a
        /// <i>ResourceNotFoundException</i> . If table is already in the <c>DELETING</c> state, no error is returned. </para> <para><b>NOTE:</b> Amazon
        /// DynamoDB might continue to accept data read and write operations, such as GetItem and PutItem, on a table in the DELETING state until the
        /// table deletion is complete. </para> <para>Tables are unique among those associated with the AWS Account issuing the request, and the AWS
        /// region that receives the request (such as dynamodb.us-east-1.amazonaws.com). Each Amazon DynamoDB endpoint is entirely independent. For
        /// example, if you have two tables called "MyTable," one in dynamodb.us-east-1.amazonaws.com and one in dynamodb.us-west-1.amazonaws.com, they
        /// are completely independent and do not share any data; deleting one does not delete the other.</para> <para>When you delete a table, any
        /// local secondary indexes on that table are also deleted.</para> <para>Use the <i>DescribeTable</i> API to check the status of the table.
        /// </para>
        /// </summary>
        /// 
        /// <param name="deleteTableRequest">Container for the necessary parameters to execute the DeleteTable service method on
        ///          AmazonDynamoDBv2.</param>
        /// 
        /// <returns>The response from the DeleteTable service method, as returned by AmazonDynamoDBv2.</returns>
        /// 
        /// <exception cref="ResourceInUseException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="InternalServerErrorException"/>
        public DeleteTableResponse DeleteTable(DeleteTableRequest deleteTableRequest)
        {
            IAsyncResult asyncResult = invokeDeleteTable(deleteTableRequest, null, null, true);
            return EndDeleteTable(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTable operation.
        /// <seealso cref="Amazon.DynamoDBv2.AmazonDynamoDB.DeleteTable"/>
        /// </summary>
        /// 
        /// <param name="deleteTableRequest">Container for the necessary parameters to execute the DeleteTable operation on AmazonDynamoDBv2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTable
        ///         operation.</returns>
        public IAsyncResult BeginDeleteTable(DeleteTableRequest deleteTableRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteTable(deleteTableRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteTable operation.
        /// <seealso cref="Amazon.DynamoDBv2.AmazonDynamoDB.DeleteTable"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTable.</param>
        /// 
        /// <returns>Returns a DeleteTableResult from AmazonDynamoDBv2.</returns>
        public DeleteTableResponse EndDeleteTable(IAsyncResult asyncResult)
        {
            return endOperation<DeleteTableResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteTable(DeleteTableRequest deleteTableRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteTableRequestMarshaller().Marshall(deleteTableRequest);
            var unmarshaller = DeleteTableResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region BatchWriteItem

        /// <summary>
        /// <para>The <i>BatchWriteItem</i> operation puts or deletes multiple items in one or more tables. A single call to <i>BatchWriteItem</i> can
        /// write up to 1 MB of data, which can comprise as many as 25 put or delete requests. Individual items to be written can be as large as 64
        /// KB.</para> <para><b>NOTE:</b> BatchWriteItem cannot update items. To update items, use the UpdateItem API. </para> <para>The individual
        /// <i>PutItem</i> and <i>DeleteItem</i> operations specified in <i>BatchWriteItem</i> are atomic; however <i>BatchWriteItem</i> as a whole is
        /// not. If any requested operations fail because the table's provisioned throughput is exceeded or an internal processing failure occurs, the
        /// failed operations are returned in the <i>UnprocessedItems</i> response parameter. You can investigate and optionally resend the requests.
        /// Typically, you would call <i>BatchWriteItem</i> in a loop. Each iteration would check for unprocessed items and submit a new
        /// <i>BatchWriteItem</i> request with those unprocessed items until all items have been processed.</para> <para>To write one item, you can use
        /// the <i>PutItem</i> operation; to delete one item, you can use the <i>DeleteItem</i> operation.</para> <para>With <i>BatchWriteItem</i> , you
        /// can efficiently write or delete large amounts of data, such as from Amazon Elastic MapReduce (EMR), or copy data from another database into
        /// Amazon DynamoDB. In order to improve performance with these large-scale operations, <i>BatchWriteItem</i> does not behave in the same way as
        /// individual <i>PutItem</i> and <i>DeleteItem</i> calls would For example, you cannot specify conditions on individual put and delete
        /// requests, and <i>BatchWriteItem</i> does not return deleted items in the response.</para> <para>If you use a programming language that
        /// supports concurrency, such as Java, you can use threads to write items in parallel. Your application must include the necessary logic to
        /// manage the threads.</para> <para>With languages that don't support threading, such as PHP, <i>BatchWriteItem</i> will write or delete the
        /// specified items one at a time. In both situations, <i>BatchWriteItem</i> provides an alternative where the API performs the specified put
        /// and delete operations in parallel, giving you the power of the thread pool approach without having to introduce complexity into your
        /// application.</para> <para>Parallel processing reduces latency, but each specified put and delete request consumes the same number of write
        /// capacity units whether it is processed in parallel or not. Delete operations on nonexistent items consume one write capacity unit.</para>
        /// <para>If one or more of the following is true, Amazon DynamoDB rejects the entire batch write operation:</para>
        /// <ul>
        /// <li> <para>One or more tables specified in the <i>BatchWriteItem</i> request does not exist.</para> </li>
        /// <li> <para>Primary key attributes specified on an item in the request do not match those in the corresponding table's primary key
        /// schema.</para> </li>
        /// <li> <para>You try to perform multiple operations on the same item in the same <i>BatchWriteItem</i> request. For example, you cannot put
        /// and delete the same item in the same <i>BatchWriteItem</i> request. </para> </li>
        /// <li> <para>The total request size exceeds 1 MB.</para> </li>
        /// <li> <para>Any individual item in a batch exceeds 64 KB.</para> </li>
        /// 
        /// </ul>
        /// </summary>
        /// 
        /// <param name="batchWriteItemRequest">Container for the necessary parameters to execute the BatchWriteItem service method on
        ///          AmazonDynamoDBv2.</param>
        /// 
        /// <returns>The response from the BatchWriteItem service method, as returned by AmazonDynamoDBv2.</returns>
        /// 
        /// <exception cref="ItemCollectionSizeLimitExceededException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ProvisionedThroughputExceededException"/>
        /// <exception cref="InternalServerErrorException"/>
        public BatchWriteItemResponse BatchWriteItem(BatchWriteItemRequest batchWriteItemRequest)
        {
            IAsyncResult asyncResult = invokeBatchWriteItem(batchWriteItemRequest, null, null, true);
            return EndBatchWriteItem(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the BatchWriteItem operation.
        /// <seealso cref="Amazon.DynamoDBv2.AmazonDynamoDB.BatchWriteItem"/>
        /// </summary>
        /// 
        /// <param name="batchWriteItemRequest">Container for the necessary parameters to execute the BatchWriteItem operation on
        ///          AmazonDynamoDBv2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchWriteItem
        ///         operation.</returns>
        public IAsyncResult BeginBatchWriteItem(BatchWriteItemRequest batchWriteItemRequest, AsyncCallback callback, object state)
        {
            return invokeBatchWriteItem(batchWriteItemRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the BatchWriteItem operation.
        /// <seealso cref="Amazon.DynamoDBv2.AmazonDynamoDB.BatchWriteItem"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchWriteItem.</param>
        /// 
        /// <returns>Returns a BatchWriteItemResult from AmazonDynamoDBv2.</returns>
        public BatchWriteItemResponse EndBatchWriteItem(IAsyncResult asyncResult)
        {
            return endOperation<BatchWriteItemResponse>(asyncResult);
        }
        
        IAsyncResult invokeBatchWriteItem(BatchWriteItemRequest batchWriteItemRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new BatchWriteItemRequestMarshaller().Marshall(batchWriteItemRequest);
            var unmarshaller = BatchWriteItemResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeTable

        /// <summary>
        /// <para>Returns information about the table, including the current status of the table, when it was created, the primary key schema, and any
        /// indexes on the table.</para>
        /// </summary>
        /// 
        /// <param name="describeTableRequest">Container for the necessary parameters to execute the DescribeTable service method on
        ///          AmazonDynamoDBv2.</param>
        /// 
        /// <returns>The response from the DescribeTable service method, as returned by AmazonDynamoDBv2.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="InternalServerErrorException"/>
        public DescribeTableResponse DescribeTable(DescribeTableRequest describeTableRequest)
        {
            IAsyncResult asyncResult = invokeDescribeTable(describeTableRequest, null, null, true);
            return EndDescribeTable(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTable operation.
        /// <seealso cref="Amazon.DynamoDBv2.AmazonDynamoDB.DescribeTable"/>
        /// </summary>
        /// 
        /// <param name="describeTableRequest">Container for the necessary parameters to execute the DescribeTable operation on
        ///          AmazonDynamoDBv2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTable
        ///         operation.</returns>
        public IAsyncResult BeginDescribeTable(DescribeTableRequest describeTableRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeTable(describeTableRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeTable operation.
        /// <seealso cref="Amazon.DynamoDBv2.AmazonDynamoDB.DescribeTable"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTable.</param>
        /// 
        /// <returns>Returns a DescribeTableResult from AmazonDynamoDBv2.</returns>
        public DescribeTableResponse EndDescribeTable(IAsyncResult asyncResult)
        {
            return endOperation<DescribeTableResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeTable(DescribeTableRequest describeTableRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeTableRequestMarshaller().Marshall(describeTableRequest);
            var unmarshaller = DescribeTableResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region GetItem

        /// <summary>
        /// <para>The <i>GetItem</i> operation returns a set of attributes for the item with the given primary key. If there is no matching item,
        /// <i>GetItem</i> does not return any data.</para> <para> <i>GetItem</i> provides an eventually consistent read by default. If your application
        /// requires a strongly consistent read, set <i>ConsistentRead</i> to <c>true</c> . Although a strongly consistent read might take more time
        /// than an eventually consistent read, it always returns the last updated value.</para>
        /// </summary>
        /// 
        /// <param name="getItemRequest">Container for the necessary parameters to execute the GetItem service method on AmazonDynamoDBv2.</param>
        /// 
        /// <returns>The response from the GetItem service method, as returned by AmazonDynamoDBv2.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ProvisionedThroughputExceededException"/>
        /// <exception cref="InternalServerErrorException"/>
        public GetItemResponse GetItem(GetItemRequest getItemRequest)
        {
            IAsyncResult asyncResult = invokeGetItem(getItemRequest, null, null, true);
            return EndGetItem(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the GetItem operation.
        /// <seealso cref="Amazon.DynamoDBv2.AmazonDynamoDB.GetItem"/>
        /// </summary>
        /// 
        /// <param name="getItemRequest">Container for the necessary parameters to execute the GetItem operation on AmazonDynamoDBv2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetItem
        ///         operation.</returns>
        public IAsyncResult BeginGetItem(GetItemRequest getItemRequest, AsyncCallback callback, object state)
        {
            return invokeGetItem(getItemRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the GetItem operation.
        /// <seealso cref="Amazon.DynamoDBv2.AmazonDynamoDB.GetItem"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetItem.</param>
        /// 
        /// <returns>Returns a GetItemResult from AmazonDynamoDBv2.</returns>
        public GetItemResponse EndGetItem(IAsyncResult asyncResult)
        {
            return endOperation<GetItemResponse>(asyncResult);
        }
        
        IAsyncResult invokeGetItem(GetItemRequest getItemRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetItemRequestMarshaller().Marshall(getItemRequest);
            var unmarshaller = GetItemResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteItem

        /// <summary>
        /// <para>Deletes a single item in a table by primary key. You can perform a conditional delete operation that deletes the item if it exists, or
        /// if it has an expected attribute value.</para> <para>In addition to deleting an item, you can also return the item's attribute values in the
        /// same operation, using the <i>ReturnValues</i> parameter.</para> <para>Unless you specify conditions, the <i>DeleteItem</i> is an idempotent
        /// operation; running it multiple times on the same item or attribute does <i>not</i> result in an error response.</para> <para>Conditional
        /// deletes are useful for only deleting items if specific conditions are met. If those conditions are met, Amazon DynamoDB performs the delete.
        /// Otherwise, the item is not deleted. </para>
        /// </summary>
        /// 
        /// <param name="deleteItemRequest">Container for the necessary parameters to execute the DeleteItem service method on AmazonDynamoDBv2.</param>
        /// 
        /// <returns>The response from the DeleteItem service method, as returned by AmazonDynamoDBv2.</returns>
        /// 
        /// <exception cref="ItemCollectionSizeLimitExceededException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ConditionalCheckFailedException"/>
        /// <exception cref="ProvisionedThroughputExceededException"/>
        /// <exception cref="InternalServerErrorException"/>
        public DeleteItemResponse DeleteItem(DeleteItemRequest deleteItemRequest)
        {
            IAsyncResult asyncResult = invokeDeleteItem(deleteItemRequest, null, null, true);
            return EndDeleteItem(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteItem operation.
        /// <seealso cref="Amazon.DynamoDBv2.AmazonDynamoDB.DeleteItem"/>
        /// </summary>
        /// 
        /// <param name="deleteItemRequest">Container for the necessary parameters to execute the DeleteItem operation on AmazonDynamoDBv2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteItem
        ///         operation.</returns>
        public IAsyncResult BeginDeleteItem(DeleteItemRequest deleteItemRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteItem(deleteItemRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteItem operation.
        /// <seealso cref="Amazon.DynamoDBv2.AmazonDynamoDB.DeleteItem"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteItem.</param>
        /// 
        /// <returns>Returns a DeleteItemResult from AmazonDynamoDBv2.</returns>
        public DeleteItemResponse EndDeleteItem(IAsyncResult asyncResult)
        {
            return endOperation<DeleteItemResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteItem(DeleteItemRequest deleteItemRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteItemRequestMarshaller().Marshall(deleteItemRequest);
            var unmarshaller = DeleteItemResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateTable

        /// <summary>
        /// <para>The <i>CreateTable</i> operation adds a new table to your account. In an AWS account, table names must be unique within each region.
        /// That is, you can have two tables with same name if you create the tables in different regions.</para> <para> <i>CreateTable</i> is an
        /// asynchronous operation. Upon receiving a <i>CreateTable</i> request, Amazon DynamoDB immediately returns a response with a
        /// <i>TableStatus</i> of <c>CREATING</c> . After the table is created, Amazon DynamoDB sets the <i>TableStatus</i> to <c>ACTIVE</c> . You can
        /// perform read and write operations only on an <c>ACTIVE</c> table. </para> <para>If you want to create multiple tables with local secondary
        /// indexes on them, you must create them sequentially. Only one table with local secondary indexes can be in the <c>CREATING</c> state at any
        /// given time.</para> <para>You can use the <i>DescribeTable</i> API to check the table status.</para>
        /// </summary>
        /// 
        /// <param name="createTableRequest">Container for the necessary parameters to execute the CreateTable service method on
        ///          AmazonDynamoDBv2.</param>
        /// 
        /// <returns>The response from the CreateTable service method, as returned by AmazonDynamoDBv2.</returns>
        /// 
        /// <exception cref="ResourceInUseException"/>
        /// <exception cref="LimitExceededException"/>
        /// <exception cref="InternalServerErrorException"/>
        public CreateTableResponse CreateTable(CreateTableRequest createTableRequest)
        {
            IAsyncResult asyncResult = invokeCreateTable(createTableRequest, null, null, true);
            return EndCreateTable(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTable operation.
        /// <seealso cref="Amazon.DynamoDBv2.AmazonDynamoDB.CreateTable"/>
        /// </summary>
        /// 
        /// <param name="createTableRequest">Container for the necessary parameters to execute the CreateTable operation on AmazonDynamoDBv2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTable
        ///         operation.</returns>
        public IAsyncResult BeginCreateTable(CreateTableRequest createTableRequest, AsyncCallback callback, object state)
        {
            return invokeCreateTable(createTableRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateTable operation.
        /// <seealso cref="Amazon.DynamoDBv2.AmazonDynamoDB.CreateTable"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTable.</param>
        /// 
        /// <returns>Returns a CreateTableResult from AmazonDynamoDBv2.</returns>
        public CreateTableResponse EndCreateTable(IAsyncResult asyncResult)
        {
            return endOperation<CreateTableResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateTable(CreateTableRequest createTableRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateTableRequestMarshaller().Marshall(createTableRequest);
            var unmarshaller = CreateTableResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region Query

        /// <summary>
        /// <para>A <i>Query</i> operation directly accesses items from a table using the table primary key, or from an index using the index key. You
        /// must provide a specific hash key value. You can narrow the scope of the query by using comparison operators on the range key value, or on
        /// the index key. You can use the <i>ScanIndexForward</i> parameter to get results in forward or reverse order, by range key or by index key.
        /// </para> <para>Queries that do not return results consume the minimum read capacity units according to the type of read.</para> <para>If the
        /// total number of items meeting the query criteria exceeds the result set size limit of 1 MB, the query stops and results are returned to the
        /// user with a <i>LastEvaluatedKey</i> to continue the query in a subsequent operation. Unlike a <i>Scan</i> operation, a <i>Query</i>
        /// operation never returns an empty result set <i>and</i> a
        /// <i>LastEvaluatedKey</i> . The <i>LastEvaluatedKey</i> is only provided if the results exceed 1 MB, or if you have used
        /// <i>Limit</i> . </para> <para>To request a strongly consistent result, set <i>ConsistentRead</i> to true.</para>
        /// </summary>
        /// 
        /// <param name="queryRequest">Container for the necessary parameters to execute the Query service method on AmazonDynamoDBv2.</param>
        /// 
        /// <returns>The response from the Query service method, as returned by AmazonDynamoDBv2.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ProvisionedThroughputExceededException"/>
        /// <exception cref="InternalServerErrorException"/>
        public QueryResponse Query(QueryRequest queryRequest)
        {
            IAsyncResult asyncResult = invokeQuery(queryRequest, null, null, true);
            return EndQuery(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the Query operation.
        /// <seealso cref="Amazon.DynamoDBv2.AmazonDynamoDB.Query"/>
        /// </summary>
        /// 
        /// <param name="queryRequest">Container for the necessary parameters to execute the Query operation on AmazonDynamoDBv2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndQuery
        ///         operation.</returns>
        public IAsyncResult BeginQuery(QueryRequest queryRequest, AsyncCallback callback, object state)
        {
            return invokeQuery(queryRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the Query operation.
        /// <seealso cref="Amazon.DynamoDBv2.AmazonDynamoDB.Query"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginQuery.</param>
        /// 
        /// <returns>Returns a QueryResult from AmazonDynamoDBv2.</returns>
        public QueryResponse EndQuery(IAsyncResult asyncResult)
        {
            return endOperation<QueryResponse>(asyncResult);
        }
        
        IAsyncResult invokeQuery(QueryRequest queryRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new QueryRequestMarshaller().Marshall(queryRequest);
            var unmarshaller = QueryResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region PutItem

        /// <summary>
        /// <para>Creates a new item, or replaces an old item with a new item. If an item already exists in the specified table with the same primary
        /// key, the new item completely replaces the existing item. You can perform a conditional put (insert a new item if one with the specified
        /// primary key doesn't exist), or replace an existing item if it has certain attribute values. </para> <para>In addition to putting an item,
        /// you can also return the item's attribute values in the same operation, using the <i>ReturnValues</i> parameter.</para> <para>When you add an
        /// item, the primary key attribute(s) are the only required attributes. Attribute values cannot be null. String and binary type attributes must
        /// have lengths greater than zero. Set type attributes cannot be empty. Requests with empty values will be rejected with a
        /// <i>ValidationException</i> .</para> <para>You can request that <i>PutItem</i> return either a copy of the old item (before the update) or a
        /// copy of the new item (after the update). For more information, see the <i>ReturnValues</i> description.</para> <para><b>NOTE:</b> To prevent
        /// a new item from replacing an existing item, use a conditional put operation with Exists set to false for the primary key attribute, or
        /// attributes. </para> <para>For more information about using this API, see Working with Items in the <i>Amazon DynamoDB Developer Guide</i>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="putItemRequest">Container for the necessary parameters to execute the PutItem service method on AmazonDynamoDBv2.</param>
        /// 
        /// <returns>The response from the PutItem service method, as returned by AmazonDynamoDBv2.</returns>
        /// 
        /// <exception cref="ItemCollectionSizeLimitExceededException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ConditionalCheckFailedException"/>
        /// <exception cref="ProvisionedThroughputExceededException"/>
        /// <exception cref="InternalServerErrorException"/>
        public PutItemResponse PutItem(PutItemRequest putItemRequest)
        {
            IAsyncResult asyncResult = invokePutItem(putItemRequest, null, null, true);
            return EndPutItem(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the PutItem operation.
        /// <seealso cref="Amazon.DynamoDBv2.AmazonDynamoDB.PutItem"/>
        /// </summary>
        /// 
        /// <param name="putItemRequest">Container for the necessary parameters to execute the PutItem operation on AmazonDynamoDBv2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutItem
        ///         operation.</returns>
        public IAsyncResult BeginPutItem(PutItemRequest putItemRequest, AsyncCallback callback, object state)
        {
            return invokePutItem(putItemRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the PutItem operation.
        /// <seealso cref="Amazon.DynamoDBv2.AmazonDynamoDB.PutItem"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutItem.</param>
        /// 
        /// <returns>Returns a PutItemResult from AmazonDynamoDBv2.</returns>
        public PutItemResponse EndPutItem(IAsyncResult asyncResult)
        {
            return endOperation<PutItemResponse>(asyncResult);
        }
        
        IAsyncResult invokePutItem(PutItemRequest putItemRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new PutItemRequestMarshaller().Marshall(putItemRequest);
            var unmarshaller = PutItemResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ListTables

        /// <summary>
        /// <para>Returns an array of all the tables associated with the current account and endpoint. </para> <para>Each Amazon DynamoDB endpoint is
        /// entirely independent. For example, if you have two tables called "MyTable," one in <i>dynamodb.us-east-1.amazonaws.com</i> and one in
        /// <i>dynamodb.us-west-1.amazonaws.com</i> , they are completely independent and do not share any data. The <i>ListTables</i> operation returns
        /// all of the table names associated with the account making the request, for the endpoint that receives the request.</para>
        /// </summary>
        /// 
        /// <param name="listTablesRequest">Container for the necessary parameters to execute the ListTables service method on AmazonDynamoDBv2.</param>
        /// 
        /// <returns>The response from the ListTables service method, as returned by AmazonDynamoDBv2.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        public ListTablesResponse ListTables(ListTablesRequest listTablesRequest)
        {
            IAsyncResult asyncResult = invokeListTables(listTablesRequest, null, null, true);
            return EndListTables(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListTables operation.
        /// <seealso cref="Amazon.DynamoDBv2.AmazonDynamoDB.ListTables"/>
        /// </summary>
        /// 
        /// <param name="listTablesRequest">Container for the necessary parameters to execute the ListTables operation on AmazonDynamoDBv2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTables
        ///         operation.</returns>
        public IAsyncResult BeginListTables(ListTablesRequest listTablesRequest, AsyncCallback callback, object state)
        {
            return invokeListTables(listTablesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListTables operation.
        /// <seealso cref="Amazon.DynamoDBv2.AmazonDynamoDB.ListTables"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTables.</param>
        /// 
        /// <returns>Returns a ListTablesResult from AmazonDynamoDBv2.</returns>
        public ListTablesResponse EndListTables(IAsyncResult asyncResult)
        {
            return endOperation<ListTablesResponse>(asyncResult);
        }
        
        IAsyncResult invokeListTables(ListTablesRequest listTablesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListTablesRequestMarshaller().Marshall(listTablesRequest);
            var unmarshaller = ListTablesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Returns an array of all the tables associated with the current account and endpoint. </para> <para>Each Amazon DynamoDB endpoint is
        /// entirely independent. For example, if you have two tables called "MyTable," one in <i>dynamodb.us-east-1.amazonaws.com</i> and one in
        /// <i>dynamodb.us-west-1.amazonaws.com</i> , they are completely independent and do not share any data. The <i>ListTables</i> operation returns
        /// all of the table names associated with the account making the request, for the endpoint that receives the request.</para>
        /// </summary>
        /// 
        /// <returns>The response from the ListTables service method, as returned by AmazonDynamoDBv2.</returns>
        /// 
        /// <exception cref="InternalServerErrorException"/>
        public ListTablesResponse ListTables()
        {
            return ListTables(new ListTablesRequest());
        }
        

        #endregion
    
        #region UpdateItem

        /// <summary>
        /// <para> Edits an existing item's attributes, or inserts a new item if it does not already exist. You can put, delete, or add attribute
        /// values. You can also perform a conditional update (insert a new attribute name-value pair if it doesn't exist, or replace an existing
        /// name-value pair if it has certain expected attribute values).</para> <para>In addition to updating an item, you can also return the item's
        /// attribute values in the same operation, using the <i>ReturnValues</i> parameter.</para>
        /// </summary>
        /// 
        /// <param name="updateItemRequest">Container for the necessary parameters to execute the UpdateItem service method on AmazonDynamoDBv2.</param>
        /// 
        /// <returns>The response from the UpdateItem service method, as returned by AmazonDynamoDBv2.</returns>
        /// 
        /// <exception cref="ItemCollectionSizeLimitExceededException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ConditionalCheckFailedException"/>
        /// <exception cref="ProvisionedThroughputExceededException"/>
        /// <exception cref="InternalServerErrorException"/>
        public UpdateItemResponse UpdateItem(UpdateItemRequest updateItemRequest)
        {
            IAsyncResult asyncResult = invokeUpdateItem(updateItemRequest, null, null, true);
            return EndUpdateItem(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateItem operation.
        /// <seealso cref="Amazon.DynamoDBv2.AmazonDynamoDB.UpdateItem"/>
        /// </summary>
        /// 
        /// <param name="updateItemRequest">Container for the necessary parameters to execute the UpdateItem operation on AmazonDynamoDBv2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateItem
        ///         operation.</returns>
        public IAsyncResult BeginUpdateItem(UpdateItemRequest updateItemRequest, AsyncCallback callback, object state)
        {
            return invokeUpdateItem(updateItemRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the UpdateItem operation.
        /// <seealso cref="Amazon.DynamoDBv2.AmazonDynamoDB.UpdateItem"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateItem.</param>
        /// 
        /// <returns>Returns a UpdateItemResult from AmazonDynamoDBv2.</returns>
        public UpdateItemResponse EndUpdateItem(IAsyncResult asyncResult)
        {
            return endOperation<UpdateItemResponse>(asyncResult);
        }
        
        IAsyncResult invokeUpdateItem(UpdateItemRequest updateItemRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UpdateItemRequestMarshaller().Marshall(updateItemRequest);
            var unmarshaller = UpdateItemResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region BatchGetItem

        /// <summary>
        /// <para>The <i>BatchGetItem</i> operation returns the attributes of one or more items from one or more tables. You identify requested items by
        /// primary key.</para> <para>A single operation can retrieve up to 1 MB of data, which can comprise as many as 100 items. <i>BatchGetItem</i>
        /// will return a partial result if the response size limit is exceeded, the table's provisioned throughput is exceeded, or an internal
        /// processing failure occurs. If a partial result is returned, the operation returns a value for <i>UnprocessedKeys</i> . You can use this
        /// value to retry the operation starting with the next item to get.</para> <para>For example, if you ask to retrieve 100 items, but each
        /// individual item is 50 KB in size, the system returns 20 items (1 MB) and an appropriate <i>UnprocessedKeys</i> value so you can get the next
        /// page of results. If desired, your application can include its own logic to assemble the pages of results into one dataset.</para> <para>If
        /// no items can be processed because of insufficient provisioned throughput on each of the tables involved in the request, <i>BatchGetItem</i>
        /// throws <i>ProvisionedThroughputExceededException</i> . </para> <para>By default, <i>BatchGetItem</i> performs eventually consistent reads on
        /// every table in the request. If you want strongly consistent reads instead, you can set <i>ConsistentRead</i> to <c>true</c> for any or all
        /// tables.</para> <para>In order to minimize response latency, <i>BatchGetItem</i> fetches items in parallel.</para> <para>When designing your
        /// application, keep in mind that Amazon DynamoDB does not return attributes in any particular order. To help parse the response by item,
        /// include the primary key values for the items in your request in the <i>AttributesToGet</i> parameter.</para> <para>If a requested item does
        /// not exist, it is not returned in the result. Requests for nonexistent items consume the minimum read capacity units according to the type of
        /// read. For more information, see Capacity Units Calculations in the <i>Amazon DynamoDB Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="batchGetItemRequest">Container for the necessary parameters to execute the BatchGetItem service method on
        ///          AmazonDynamoDBv2.</param>
        /// 
        /// <returns>The response from the BatchGetItem service method, as returned by AmazonDynamoDBv2.</returns>
        /// 
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ProvisionedThroughputExceededException"/>
        /// <exception cref="InternalServerErrorException"/>
        public BatchGetItemResponse BatchGetItem(BatchGetItemRequest batchGetItemRequest)
        {
            IAsyncResult asyncResult = invokeBatchGetItem(batchGetItemRequest, null, null, true);
            return EndBatchGetItem(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetItem operation.
        /// <seealso cref="Amazon.DynamoDBv2.AmazonDynamoDB.BatchGetItem"/>
        /// </summary>
        /// 
        /// <param name="batchGetItemRequest">Container for the necessary parameters to execute the BatchGetItem operation on AmazonDynamoDBv2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetItem
        ///         operation.</returns>
        public IAsyncResult BeginBatchGetItem(BatchGetItemRequest batchGetItemRequest, AsyncCallback callback, object state)
        {
            return invokeBatchGetItem(batchGetItemRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the BatchGetItem operation.
        /// <seealso cref="Amazon.DynamoDBv2.AmazonDynamoDB.BatchGetItem"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetItem.</param>
        /// 
        /// <returns>Returns a BatchGetItemResult from AmazonDynamoDBv2.</returns>
        public BatchGetItemResponse EndBatchGetItem(IAsyncResult asyncResult)
        {
            return endOperation<BatchGetItemResponse>(asyncResult);
        }
        
        IAsyncResult invokeBatchGetItem(BatchGetItemRequest batchGetItemRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new BatchGetItemRequestMarshaller().Marshall(batchGetItemRequest);
            var unmarshaller = BatchGetItemResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        /// <summary>
        /// Override the pausing function so retries would happen more frequent then the default operation.
        /// </summary>
        /// <param name="retries">Current number of retries.</param>
        protected override void pauseExponentially(int retries)
        {
            int delay = (retries == 0) ? 0 : 50 * (int)Math.Pow(2, retries - 1);
            delay = Math.Min(delay, MAX_BACKOFF_IN_MILLISECONDS);
            Thread.Sleep(delay);
        }

    }
}
    
