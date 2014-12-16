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
 * Do not modify this file. This file is generated from the kinesis-2013-12-02.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Kinesis.Model;
using Amazon.Kinesis.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Kinesis
{
    /// <summary>
    /// Implementation for accessing Kinesis
    ///
    /// Amazon Kinesis Service API Reference 
    /// <para>
    /// Amazon Kinesis is a managed service that scales elastically for real time processing
    /// of streaming big data.
    /// </para>
    /// </summary>
    public partial class AmazonKinesisClient : AmazonServiceClient, IAmazonKinesis
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonKinesisClient with the credentials loaded from the application's
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
        public AmazonKinesisClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonKinesisConfig()) { }

        /// <summary>
        /// Constructs AmazonKinesisClient with the credentials loaded from the application's
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
        public AmazonKinesisClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonKinesisConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonKinesisClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonKinesisClient Configuration Object</param>
        public AmazonKinesisClient(AmazonKinesisConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonKinesisClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonKinesisClient(AWSCredentials credentials)
            : this(credentials, new AmazonKinesisConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKinesisClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonKinesisConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisClient with AWS Credentials and an
        /// AmazonKinesisClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonKinesisClient Configuration Object</param>
        public AmazonKinesisClient(AWSCredentials credentials, AmazonKinesisConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonKinesisClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonKinesisConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKinesisClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonKinesisConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonKinesisClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonKinesisClient Configuration Object</param>
        public AmazonKinesisClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonKinesisConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonKinesisClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonKinesisConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKinesisClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonKinesisConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonKinesisClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonKinesisClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonKinesisClient Configuration Object</param>
        public AmazonKinesisClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonKinesisConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }


        #endregion

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        
        #region  AddTagsToStream

        /// <summary>
        /// Adds or updates tags for the specified Amazon Kinesis stream. Each stream can have
        /// up to 10 tags. 
        /// 
        ///  
        /// <para>
        /// If tags have already been assigned to the stream, <code>AddTagsToStream</code> overwrites
        /// any existing tags that correspond to the specified tag keys.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToStream service method.</param>
        /// 
        /// <returns>The response from the AddTagsToStream service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed (5).
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For example, you attempted to split
        /// a shard but the stream is not in the <code>ACTIVE</code> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. It might not be specified correctly, or
        /// it might not be in the <code>ACTIVE</code> state.
        /// </exception>
        public AddTagsToStreamResponse AddTagsToStream(AddTagsToStreamRequest request)
        {
            var marshaller = new AddTagsToStreamRequestMarshaller();
            var unmarshaller = AddTagsToStreamResponseUnmarshaller.Instance;

            return Invoke<AddTagsToStreamRequest,AddTagsToStreamResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddTagsToStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToStream operation on AmazonKinesisClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddTagsToStream
        ///         operation.</returns>
        public IAsyncResult BeginAddTagsToStream(AddTagsToStreamRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AddTagsToStreamRequestMarshaller();
            var unmarshaller = AddTagsToStreamResponseUnmarshaller.Instance;

            return BeginInvoke<AddTagsToStreamRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddTagsToStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddTagsToStream.</param>
        /// 
        /// <returns>Returns a  AddTagsToStreamResult from Kinesis.</returns>
        public  AddTagsToStreamResponse EndAddTagsToStream(IAsyncResult asyncResult)
        {
            return EndInvoke<AddTagsToStreamResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateStream

        /// <summary>
        /// Creates a Amazon Kinesis stream. A stream captures and transports data records that
        /// are continuously emitted from different data sources or <i>producers</i>. Scale-out
        /// within an Amazon Kinesis stream is explicitly supported by means of shards, which
        /// are uniquely identified groups of data records in an Amazon Kinesis stream.
        /// 
        ///  
        /// <para>
        /// You specify and control the number of shards that a stream is composed of. Each open
        /// shard can support up to 5 read transactions per second, up to a maximum total of 2
        /// MB of data read per second. Each shard can support up to 1000 records written per
        /// second, up to a maximum total of 1 MB data written per second. You can add shards
        /// to a stream if the amount of data input increases and you can remove shards if the
        /// amount of data input decreases.
        /// </para>
        ///  
        /// <para>
        /// The stream name identifies the stream. The name is scoped to the AWS account used
        /// by the application. It is also scoped by region. That is, two streams in two different
        /// accounts can have the same name, and two streams in the same account, but in two different
        /// regions, can have the same name. 
        /// </para>
        ///  
        /// <para>
        /// <code>CreateStream</code> is an asynchronous operation. Upon receiving a <code>CreateStream</code>
        /// request, Amazon Kinesis immediately returns and sets the stream status to <code>CREATING</code>.
        /// After the stream is created, Amazon Kinesis sets the stream status to <code>ACTIVE</code>.
        /// You should perform read and write operations only on an <code>ACTIVE</code> stream.
        /// 
        /// </para>
        ///  
        /// <para>
        /// You receive a <code>LimitExceededException</code> when making a <code>CreateStream</code>
        /// request if you try to do one of the following:
        /// </para>
        ///  <ul> <li>Have more than five streams in the <code>CREATING</code> state at any point
        /// in time.</li> <li>Create more shards than are authorized for your account.</li> </ul>
        /// 
        /// <para>
        /// The default limit for an AWS account is 10 shards per stream. If you need to create
        /// a stream with more than 10 shards, <a href="http://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html">contact
        /// AWS Support</a> to increase the limit on your account.
        /// </para>
        ///  
        /// <para>
        /// You can use <code>DescribeStream</code> to check the stream status, which is returned
        /// in <code>StreamStatus</code>.
        /// </para>
        ///  
        /// <para>
        /// <code>CreateStream</code> has a limit of 5 transactions per second per account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStream service method.</param>
        /// 
        /// <returns>The response from the CreateStream service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed (5).
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For example, you attempted to split
        /// a shard but the stream is not in the <code>ACTIVE</code> state.
        /// </exception>
        public CreateStreamResponse CreateStream(CreateStreamRequest request)
        {
            var marshaller = new CreateStreamRequestMarshaller();
            var unmarshaller = CreateStreamResponseUnmarshaller.Instance;

            return Invoke<CreateStreamRequest,CreateStreamResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStream operation on AmazonKinesisClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateStream
        ///         operation.</returns>
        public IAsyncResult BeginCreateStream(CreateStreamRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateStreamRequestMarshaller();
            var unmarshaller = CreateStreamResponseUnmarshaller.Instance;

            return BeginInvoke<CreateStreamRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStream.</param>
        /// 
        /// <returns>Returns a  CreateStreamResult from Kinesis.</returns>
        public  CreateStreamResponse EndCreateStream(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateStreamResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteStream

        /// <summary>
        /// Deletes a stream and all its shards and data. You must shut down any applications
        /// that are operating on the stream before you delete the stream. If an application attempts
        /// to operate on a deleted stream, it will receive the exception <code>ResourceNotFoundException</code>.
        /// 
        ///  
        /// <para>
        /// If the stream is in the <code>ACTIVE</code> state, you can delete it. After a <code>DeleteStream</code>
        /// request, the specified stream is in the <code>DELETING</code> state until Amazon Kinesis
        /// completes the deletion.
        /// </para>
        ///  
        /// <para>
        /// <b>Note:</b> Amazon Kinesis might continue to accept data read and write operations,
        /// such as <a>PutRecord</a>, <a>PutRecords</a>, and <a>GetRecords</a>, on a stream in
        /// the <code>DELETING</code> state until the stream deletion is complete.
        /// </para>
        ///  
        /// <para>
        /// When you delete a stream, any shards in that stream are also deleted, and any tags
        /// are dissociated from the stream.
        /// </para>
        ///  
        /// <para>
        /// You can use the <a>DescribeStream</a> operation to check the state of the stream,
        /// which is returned in <code>StreamStatus</code>.
        /// </para>
        ///  
        /// <para>
        /// <code>DeleteStream</code> has a limit of 5 transactions per second per account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStream service method.</param>
        /// 
        /// <returns>The response from the DeleteStream service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed (5).
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. It might not be specified correctly, or
        /// it might not be in the <code>ACTIVE</code> state.
        /// </exception>
        public DeleteStreamResponse DeleteStream(DeleteStreamRequest request)
        {
            var marshaller = new DeleteStreamRequestMarshaller();
            var unmarshaller = DeleteStreamResponseUnmarshaller.Instance;

            return Invoke<DeleteStreamRequest,DeleteStreamResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStream operation on AmazonKinesisClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteStream
        ///         operation.</returns>
        public IAsyncResult BeginDeleteStream(DeleteStreamRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteStreamRequestMarshaller();
            var unmarshaller = DeleteStreamResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteStreamRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteStream.</param>
        /// 
        /// <returns>Returns a  DeleteStreamResult from Kinesis.</returns>
        public  DeleteStreamResponse EndDeleteStream(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteStreamResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeStream

        /// <summary>
        /// Describes the specified stream.
        /// 
        ///  
        /// <para>
        /// The information about the stream includes its current status, its Amazon Resource
        /// Name (ARN), and an array of shard objects. For each shard object, there is information
        /// about the hash key and sequence number ranges that the shard spans, and the IDs of
        /// any earlier shards that played in a role in creating the shard. A sequence number
        /// is the identifier associated with every record ingested in the Amazon Kinesis stream.
        /// The sequence number is assigned when a record is put into the stream.
        /// </para>
        ///  
        /// <para>
        /// You can limit the number of returned shards using the <code>Limit</code> parameter.
        /// The number of shards in a stream may be too large to return from a single call to
        /// <code>DescribeStream</code>. You can detect this by using the <code>HasMoreShards</code>
        /// flag in the returned output. <code>HasMoreShards</code> is set to <code>true</code>
        /// when there is more data available. 
        /// </para>
        ///  
        /// <para>
        /// <code>DescribeStream</code> is a paginated operation. If there are more shards available,
        /// you can request them using the shard ID of the last shard returned. Specify this ID
        /// in the <code>ExclusiveStartShardId</code> parameter in a subsequent request to <code>DescribeStream</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// <code>DescribeStream</code> has a limit of 10 transactions per second per account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStream service method.</param>
        /// 
        /// <returns>The response from the DescribeStream service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed (5).
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. It might not be specified correctly, or
        /// it might not be in the <code>ACTIVE</code> state.
        /// </exception>
        public DescribeStreamResponse DescribeStream(DescribeStreamRequest request)
        {
            var marshaller = new DescribeStreamRequestMarshaller();
            var unmarshaller = DescribeStreamResponseUnmarshaller.Instance;

            return Invoke<DescribeStreamRequest,DescribeStreamResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStream operation on AmazonKinesisClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStream
        ///         operation.</returns>
        public IAsyncResult BeginDescribeStream(DescribeStreamRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeStreamRequestMarshaller();
            var unmarshaller = DescribeStreamResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeStreamRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStream.</param>
        /// 
        /// <returns>Returns a  DescribeStreamResult from Kinesis.</returns>
        public  DescribeStreamResponse EndDescribeStream(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeStreamResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRecords

        /// <summary>
        /// Gets data records from a shard.
        /// 
        ///  
        /// <para>
        /// Specify a shard iterator using the <code>ShardIterator</code> parameter. The shard
        /// iterator specifies the position in the shard from which you want to start reading
        /// data records sequentially. If there are no records available in the portion of the
        /// shard that the iterator points to, <code>GetRecords</code> returns an empty list.
        /// Note that it might take multiple calls to get to a portion of the shard that contains
        /// records.
        /// </para>
        ///  
        /// <para>
        /// You can scale by provisioning multiple shards. Your application should have one thread
        /// per shard, each reading continuously from its stream. To read from a stream continually,
        /// call <code>GetRecords</code> in a loop. Use <a>GetShardIterator</a> to get the shard
        /// iterator to specify in the first <code>GetRecords</code> call. <code>GetRecords</code>
        /// returns a new shard iterator in <code>NextShardIterator</code>. Specify the shard
        /// iterator returned in <code>NextShardIterator</code> in subsequent calls to <code>GetRecords</code>.
        /// Note that if the shard has been closed, the shard iterator can't return more data
        /// and <code>GetRecords</code> returns <code>null</code> in <code>NextShardIterator</code>.
        /// You can terminate the loop when the shard is closed, or when the shard iterator reaches
        /// the record with the sequence number or other attribute that marks it as the last record
        /// to process.
        /// </para>
        ///  
        /// <para>
        /// Each data record can be up to 50 KB in size, and each shard can read up to 2 MB per
        /// second. You can ensure that your calls don't exceed the maximum supported size or
        /// throughput by using the <code>Limit</code> parameter to specify the maximum number
        /// of records that <code>GetRecords</code> can return. Consider your average record size
        /// when determining this limit. For example, if your average record size is 40 KB, you
        /// can limit the data returned to about 1 MB per call by specifying 25 as the limit.
        /// </para>
        ///  
        /// <para>
        /// The size of the data returned by <code>GetRecords</code> will vary depending on the
        /// utilization of the shard. The maximum size of data that <code>GetRecords</code> can
        /// return is 10 MB. If a call returns 10 MB of data, subsequent calls made within the
        /// next 5 seconds throw <code>ProvisionedThroughputExceededException</code>. If there
        /// is insufficient provisioned throughput on the shard, subsequent calls made within
        /// the next 1 second throw <code>ProvisionedThroughputExceededException</code>. Note
        /// that <code>GetRecords</code> won't return any data when it throws an exception. For
        /// this reason, we recommend that you wait one second between calls to <code>GetRecords</code>;
        /// however, it's possible that the application will get exceptions for longer than 1
        /// second.
        /// </para>
        ///  
        /// <para>
        /// To detect whether the application is falling behind in processing, add a timestamp
        /// to your records and note how long it takes to process them. You can also monitor how
        /// much data is in a stream using the CloudWatch metrics for write operations (<code>PutRecord</code>
        /// and <code>PutRecords</code>). For more information, see <a href="http://docs.aws.amazon.com/kinesis/latest/dev/monitoring_with_cloudwatch.html">Monitoring
        /// Amazon Kinesis with Amazon CloudWatch</a> in the <i>Amazon Kinesis Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecords service method.</param>
        /// 
        /// <returns>The response from the GetRecords service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.ExpiredIteratorException">
        /// The provided iterator exceeds the maximum age allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ProvisionedThroughputExceededException">
        /// The request rate is too high, or the requested data is too large for the available
        /// throughput. Reduce the frequency or size of your requests. For more information, see
        /// <a href="http://docs.aws.amazon.com/general/latest/gr/api-retries.html" target="_blank">Error
        /// Retries and Exponential Backoff in AWS</a> in the <i>AWS General Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. It might not be specified correctly, or
        /// it might not be in the <code>ACTIVE</code> state.
        /// </exception>
        public GetRecordsResponse GetRecords(GetRecordsRequest request)
        {
            var marshaller = new GetRecordsRequestMarshaller();
            var unmarshaller = GetRecordsResponseUnmarshaller.Instance;

            return Invoke<GetRecordsRequest,GetRecordsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRecords operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRecords operation on AmazonKinesisClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRecords
        ///         operation.</returns>
        public IAsyncResult BeginGetRecords(GetRecordsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetRecordsRequestMarshaller();
            var unmarshaller = GetRecordsResponseUnmarshaller.Instance;

            return BeginInvoke<GetRecordsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRecords operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRecords.</param>
        /// 
        /// <returns>Returns a  GetRecordsResult from Kinesis.</returns>
        public  GetRecordsResponse EndGetRecords(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRecordsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetShardIterator

        /// <summary>
        /// Gets a shard iterator. A shard iterator expires five minutes after it is returned
        /// to the requester.
        /// 
        ///  
        /// <para>
        /// A shard iterator specifies the position in the shard from which to start reading data
        /// records sequentially. A shard iterator specifies this position using the sequence
        /// number of a data record in a shard. A sequence number is the identifier associated
        /// with every record ingested in the Amazon Kinesis stream. The sequence number is assigned
        /// when a record is put into the stream. 
        /// </para>
        ///  
        /// <para>
        /// You must specify the shard iterator type. For example, you can set the <code>ShardIteratorType</code>
        /// parameter to read exactly from the position denoted by a specific sequence number
        /// by using the <code>AT_SEQUENCE_NUMBER</code> shard iterator type, or right after the
        /// sequence number by using the <code>AFTER_SEQUENCE_NUMBER</code> shard iterator type,
        /// using sequence numbers returned by earlier calls to <a>PutRecord</a>, <a>PutRecords</a>,
        /// <a>GetRecords</a>, or <a>DescribeStream</a>. You can specify the shard iterator type
        /// <code>TRIM_HORIZON</code> in the request to cause <code>ShardIterator</code> to point
        /// to the last untrimmed record in the shard in the system, which is the oldest data
        /// record in the shard. Or you can point to just after the most recent record in the
        /// shard, by using the shard iterator type <code>LATEST</code>, so that you always read
        /// the most recent data in the shard. 
        /// </para>
        ///  
        /// <para>
        /// When you repeatedly read from an Amazon Kinesis stream use a <a>GetShardIterator</a>
        /// request to get the first shard iterator to to use in your first <code>GetRecords</code>
        /// request and then use the shard iterator returned by the <code>GetRecords</code> request
        /// in <code>NextShardIterator</code> for subsequent reads. A new shard iterator is returned
        /// by every <code>GetRecords</code> request in <code>NextShardIterator</code>, which
        /// you use in the <code>ShardIterator</code> parameter of the next <code>GetRecords</code>
        /// request. 
        /// </para>
        ///  
        /// <para>
        /// If a <code>GetShardIterator</code> request is made too often, you receive a <code>ProvisionedThroughputExceededException</code>.
        /// For more information about throughput limits, see <a>GetRecords</a>.
        /// </para>
        ///  
        /// <para>
        /// If the shard is closed, the iterator can't return more data, and <code>GetShardIterator</code>
        /// returns <code>null</code> for its <code>ShardIterator</code>. A shard can be closed
        /// using <a>SplitShard</a> or <a>MergeShards</a>.
        /// </para>
        ///  
        /// <para>
        /// <code>GetShardIterator</code> has a limit of 5 transactions per second per account
        /// per open shard.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetShardIterator service method.</param>
        /// 
        /// <returns>The response from the GetShardIterator service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ProvisionedThroughputExceededException">
        /// The request rate is too high, or the requested data is too large for the available
        /// throughput. Reduce the frequency or size of your requests. For more information, see
        /// <a href="http://docs.aws.amazon.com/general/latest/gr/api-retries.html" target="_blank">Error
        /// Retries and Exponential Backoff in AWS</a> in the <i>AWS General Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. It might not be specified correctly, or
        /// it might not be in the <code>ACTIVE</code> state.
        /// </exception>
        public GetShardIteratorResponse GetShardIterator(GetShardIteratorRequest request)
        {
            var marshaller = new GetShardIteratorRequestMarshaller();
            var unmarshaller = GetShardIteratorResponseUnmarshaller.Instance;

            return Invoke<GetShardIteratorRequest,GetShardIteratorResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetShardIterator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetShardIterator operation on AmazonKinesisClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetShardIterator
        ///         operation.</returns>
        public IAsyncResult BeginGetShardIterator(GetShardIteratorRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetShardIteratorRequestMarshaller();
            var unmarshaller = GetShardIteratorResponseUnmarshaller.Instance;

            return BeginInvoke<GetShardIteratorRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetShardIterator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetShardIterator.</param>
        /// 
        /// <returns>Returns a  GetShardIteratorResult from Kinesis.</returns>
        public  GetShardIteratorResponse EndGetShardIterator(IAsyncResult asyncResult)
        {
            return EndInvoke<GetShardIteratorResponse>(asyncResult);
        }

        #endregion
        
        #region  ListStreams

        /// <summary>
        /// Lists your streams.
        /// 
        ///  
        /// <para>
        ///  The number of streams may be too large to return from a single call to <code>ListStreams</code>.
        /// You can limit the number of returned streams using the <code>Limit</code> parameter.
        /// If you do not specify a value for the <code>Limit</code> parameter, Amazon Kinesis
        /// uses the default limit, which is currently 10.
        /// </para>
        ///  
        /// <para>
        ///  You can detect if there are more streams available to list by using the <code>HasMoreStreams</code>
        /// flag from the returned output. If there are more streams available, you can request
        /// more streams by using the name of the last stream returned by the <code>ListStreams</code>
        /// request in the <code>ExclusiveStartStreamName</code> parameter in a subsequent request
        /// to <code>ListStreams</code>. The group of stream names returned by the subsequent
        /// request is then added to the list. You can continue this process until all the stream
        /// names have been collected in the list. 
        /// </para>
        ///  
        /// <para>
        /// <code>ListStreams</code> has a limit of 5 transactions per second per account.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListStreams service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed (5).
        /// </exception>
        public ListStreamsResponse ListStreams()
        {
            return ListStreams(new ListStreamsRequest());
        }

        /// <summary>
        /// Lists your streams.
        /// 
        ///  
        /// <para>
        ///  The number of streams may be too large to return from a single call to <code>ListStreams</code>.
        /// You can limit the number of returned streams using the <code>Limit</code> parameter.
        /// If you do not specify a value for the <code>Limit</code> parameter, Amazon Kinesis
        /// uses the default limit, which is currently 10.
        /// </para>
        ///  
        /// <para>
        ///  You can detect if there are more streams available to list by using the <code>HasMoreStreams</code>
        /// flag from the returned output. If there are more streams available, you can request
        /// more streams by using the name of the last stream returned by the <code>ListStreams</code>
        /// request in the <code>ExclusiveStartStreamName</code> parameter in a subsequent request
        /// to <code>ListStreams</code>. The group of stream names returned by the subsequent
        /// request is then added to the list. You can continue this process until all the stream
        /// names have been collected in the list. 
        /// </para>
        ///  
        /// <para>
        /// <code>ListStreams</code> has a limit of 5 transactions per second per account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStreams service method.</param>
        /// 
        /// <returns>The response from the ListStreams service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed (5).
        /// </exception>
        public ListStreamsResponse ListStreams(ListStreamsRequest request)
        {
            var marshaller = new ListStreamsRequestMarshaller();
            var unmarshaller = ListStreamsResponseUnmarshaller.Instance;

            return Invoke<ListStreamsRequest,ListStreamsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListStreams operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStreams operation on AmazonKinesisClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStreams
        ///         operation.</returns>
        public IAsyncResult BeginListStreams(ListStreamsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListStreamsRequestMarshaller();
            var unmarshaller = ListStreamsResponseUnmarshaller.Instance;

            return BeginInvoke<ListStreamsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListStreams operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStreams.</param>
        /// 
        /// <returns>Returns a  ListStreamsResult from Kinesis.</returns>
        public  ListStreamsResponse EndListStreams(IAsyncResult asyncResult)
        {
            return EndInvoke<ListStreamsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForStream

        /// <summary>
        /// Lists the tags for the specified Amazon Kinesis stream.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForStream service method.</param>
        /// 
        /// <returns>The response from the ListTagsForStream service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed (5).
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. It might not be specified correctly, or
        /// it might not be in the <code>ACTIVE</code> state.
        /// </exception>
        public ListTagsForStreamResponse ListTagsForStream(ListTagsForStreamRequest request)
        {
            var marshaller = new ListTagsForStreamRequestMarshaller();
            var unmarshaller = ListTagsForStreamResponseUnmarshaller.Instance;

            return Invoke<ListTagsForStreamRequest,ListTagsForStreamResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForStream operation on AmazonKinesisClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForStream
        ///         operation.</returns>
        public IAsyncResult BeginListTagsForStream(ListTagsForStreamRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListTagsForStreamRequestMarshaller();
            var unmarshaller = ListTagsForStreamResponseUnmarshaller.Instance;

            return BeginInvoke<ListTagsForStreamRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForStream.</param>
        /// 
        /// <returns>Returns a  ListTagsForStreamResult from Kinesis.</returns>
        public  ListTagsForStreamResponse EndListTagsForStream(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForStreamResponse>(asyncResult);
        }

        #endregion
        
        #region  MergeShards

        /// <summary>
        /// Merges two adjacent shards in a stream and combines them into a single shard to reduce
        /// the stream's capacity to ingest and transport data. Two shards are considered adjacent
        /// if the union of the hash key ranges for the two shards form a contiguous set with
        /// no gaps. For example, if you have two shards, one with a hash key range of 276...381
        /// and the other with a hash key range of 382...454, then you could merge these two shards
        /// into a single shard that would have a hash key range of 276...454. After the merge,
        /// the single child shard receives data for all hash key values covered by the two parent
        /// shards.
        /// 
        ///  
        /// <para>
        /// <code>MergeShards</code> is called when there is a need to reduce the overall capacity
        /// of a stream because of excess capacity that is not being used. You must specify the
        /// shard to be merged and the adjacent shard for a stream. For more information about
        /// merging shards, see <a href="http://docs.aws.amazon.com/kinesis/latest/dev/kinesis-using-api-java.html#kinesis-using-api-java-resharding-merge">Merge
        /// Two Shards</a> in the <i>Amazon Kinesis Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If the stream is in the <code>ACTIVE</code> state, you can call <code>MergeShards</code>.
        /// If a stream is in the <code>CREATING</code>, <code>UPDATING</code>, or <code>DELETING</code>
        /// state, <code>MergeShards</code> returns a <code>ResourceInUseException</code>. If
        /// the specified stream does not exist, <code>MergeShards</code> returns a <code>ResourceNotFoundException</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// You can use <a>DescribeStream</a> to check the state of the stream, which is returned
        /// in <code>StreamStatus</code>.
        /// </para>
        ///  
        /// <para>
        /// <code>MergeShards</code> is an asynchronous operation. Upon receiving a <code>MergeShards</code>
        /// request, Amazon Kinesis immediately returns a response and sets the <code>StreamStatus</code>
        /// to <code>UPDATING</code>. After the operation is completed, Amazon Kinesis sets the
        /// <code>StreamStatus</code> to <code>ACTIVE</code>. Read and write operations continue
        /// to work while the stream is in the <code>UPDATING</code> state. 
        /// </para>
        ///  
        /// <para>
        /// You use <a>DescribeStream</a> to determine the shard IDs that are specified in the
        /// <code>MergeShards</code> request. 
        /// </para>
        ///  
        /// <para>
        /// If you try to operate on too many streams in parallel using <a>CreateStream</a>, <a>DeleteStream</a>,
        /// <code>MergeShards</code> or <a>SplitShard</a>, you will receive a <code>LimitExceededException</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// <code>MergeShards</code> has limit of 5 transactions per second per account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MergeShards service method.</param>
        /// 
        /// <returns>The response from the MergeShards service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed (5).
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For example, you attempted to split
        /// a shard but the stream is not in the <code>ACTIVE</code> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. It might not be specified correctly, or
        /// it might not be in the <code>ACTIVE</code> state.
        /// </exception>
        public MergeShardsResponse MergeShards(MergeShardsRequest request)
        {
            var marshaller = new MergeShardsRequestMarshaller();
            var unmarshaller = MergeShardsResponseUnmarshaller.Instance;

            return Invoke<MergeShardsRequest,MergeShardsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the MergeShards operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the MergeShards operation on AmazonKinesisClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndMergeShards
        ///         operation.</returns>
        public IAsyncResult BeginMergeShards(MergeShardsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new MergeShardsRequestMarshaller();
            var unmarshaller = MergeShardsResponseUnmarshaller.Instance;

            return BeginInvoke<MergeShardsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  MergeShards operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginMergeShards.</param>
        /// 
        /// <returns>Returns a  MergeShardsResult from Kinesis.</returns>
        public  MergeShardsResponse EndMergeShards(IAsyncResult asyncResult)
        {
            return EndInvoke<MergeShardsResponse>(asyncResult);
        }

        #endregion
        
        #region  PutRecord

        /// <summary>
        /// Puts (writes) a single data record from a producer into an Amazon Kinesis stream.
        /// Call <code>PutRecord</code> to send data from the producer into the Amazon Kinesis
        /// stream for real-time ingestion and subsequent processing, one record at a time. Each
        /// shard can support up to 1000 records written per second, up to a maximum total of
        /// 1 MB data written per second.
        /// 
        ///  
        /// <para>
        /// You must specify the name of the stream that captures, stores, and transports the
        /// data; a partition key; and the data blob itself.
        /// </para>
        ///  
        /// <para>
        /// The data blob can be any type of data; for example, a segment from a log file, geographic/location
        /// data, website clickstream data, and so on.
        /// </para>
        ///  
        /// <para>
        /// The partition key is used by Amazon Kinesis to distribute data across shards. Amazon
        /// Kinesis segregates the data records that belong to a data stream into multiple shards,
        /// using the partition key associated with each data record to determine which shard
        /// a given data record belongs to. 
        /// </para>
        ///  
        /// <para>
        /// Partition keys are Unicode strings, with a maximum length limit of 256 bytes. An MD5
        /// hash function is used to map partition keys to 128-bit integer values and to map associated
        /// data records to shards using the hash key ranges of the shards. You can override hashing
        /// the partition key to determine the shard by explicitly specifying a hash value using
        /// the <code>ExplicitHashKey</code> parameter. For more information, see <a href="http://docs.aws.amazon.com/kinesis/latest/dev/kinesis-using-api-java.html#kinesis-using-api-defn-partition-key">Partition
        /// Key</a> in the <i>Amazon Kinesis Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// <code>PutRecord</code> returns the shard ID of where the data record was placed and
        /// the sequence number that was assigned to the data record.
        /// </para>
        ///  
        /// <para>
        /// Sequence numbers generally increase over time. To guarantee strictly increasing ordering,
        /// use the <code>SequenceNumberForOrdering</code> parameter. For more information, see
        /// <a href="http://docs.aws.amazon.com/kinesis/latest/dev/kinesis-using-api-java.html#kinesis-using-api-defn-sequence-number">Sequence
        /// Number</a> in the <i>Amazon Kinesis Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If a <code>PutRecord</code> request cannot be processed because of insufficient provisioned
        /// throughput on the shard involved in the request, <code>PutRecord</code> throws <code>ProvisionedThroughputExceededException</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Data records are accessible for only 24 hours from the time that they are added to
        /// an Amazon Kinesis stream.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRecord service method.</param>
        /// 
        /// <returns>The response from the PutRecord service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ProvisionedThroughputExceededException">
        /// The request rate is too high, or the requested data is too large for the available
        /// throughput. Reduce the frequency or size of your requests. For more information, see
        /// <a href="http://docs.aws.amazon.com/general/latest/gr/api-retries.html" target="_blank">Error
        /// Retries and Exponential Backoff in AWS</a> in the <i>AWS General Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. It might not be specified correctly, or
        /// it might not be in the <code>ACTIVE</code> state.
        /// </exception>
        public PutRecordResponse PutRecord(PutRecordRequest request)
        {
            var marshaller = new PutRecordRequestMarshaller();
            var unmarshaller = PutRecordResponseUnmarshaller.Instance;

            return Invoke<PutRecordRequest,PutRecordResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutRecord operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutRecord operation on AmazonKinesisClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutRecord
        ///         operation.</returns>
        public IAsyncResult BeginPutRecord(PutRecordRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new PutRecordRequestMarshaller();
            var unmarshaller = PutRecordResponseUnmarshaller.Instance;

            return BeginInvoke<PutRecordRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutRecord operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutRecord.</param>
        /// 
        /// <returns>Returns a  PutRecordResult from Kinesis.</returns>
        public  PutRecordResponse EndPutRecord(IAsyncResult asyncResult)
        {
            return EndInvoke<PutRecordResponse>(asyncResult);
        }

        #endregion
        
        #region  PutRecords

        /// <summary>
        /// Puts (writes) multiple data records from a producer into an Amazon Kinesis stream
        /// in a single call (also referred to as a <code>PutRecords</code> request). Use this
        /// operation to send data from a data producer into the Amazon Kinesis stream for real-time
        /// ingestion and processing. Each shard can support up to 1000 records written per second,
        /// up to a maximum total of 1 MB data written per second.
        /// 
        ///  
        /// <para>
        /// You must specify the name of the stream that captures, stores, and transports the
        /// data; and an array of request <code>Records</code>, with each record in the array
        /// requiring a partition key and data blob. 
        /// </para>
        ///  
        /// <para>
        /// The data blob can be any type of data; for example, a segment from a log file, geographic/location
        /// data, website clickstream data, and so on.
        /// </para>
        ///  
        /// <para>
        /// The partition key is used by Amazon Kinesis as input to a hash function that maps
        /// the partition key and associated data to a specific shard. An MD5 hash function is
        /// used to map partition keys to 128-bit integer values and to map associated data records
        /// to shards. As a result of this hashing mechanism, all data records with the same partition
        /// key map to the same shard within the stream. For more information, see <a href="http://docs.aws.amazon.com/kinesis/latest/dev/kinesis-using-api-java.html#kinesis-using-api-defn-partition-key">Partition
        /// Key</a> in the <i>Amazon Kinesis Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Each record in the <code>Records</code> array may include an optional parameter, <code>ExplicitHashKey</code>,
        /// which overrides the partition key to shard mapping. This parameter allows a data producer
        /// to determine explicitly the shard where the record is stored. For more information,
        /// see <a href="http://docs.aws.amazon.com/kinesis/latest/dev/kinesis-using-api-java.html#kinesis-using-api-putrecords">Adding
        /// Multiple Records with PutRecords</a> in the <i>Amazon Kinesis Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The <code>PutRecords</code> response includes an array of response <code>Records</code>.
        /// Each record in the response array directly correlates with a record in the request
        /// array using natural ordering, from the top to the bottom of the request and response.
        /// The response <code>Records</code> array always includes the same number of records
        /// as the request array.
        /// </para>
        ///  
        /// <para>
        /// The response <code>Records</code> array includes both successfully and unsuccessfully
        /// processed records. Amazon Kinesis attempts to process all records in each <code>PutRecords</code>
        /// request. A single record failure does not stop the processing of subsequent records.
        /// </para>
        ///  
        /// <para>
        /// A successfully-processed record includes <code>ShardId</code> and <code>SequenceNumber</code>
        /// values. The <code>ShardId</code> parameter identifies the shard in the stream where
        /// the record is stored. The <code>SequenceNumber</code> parameter is an identifier assigned
        /// to the put record, unique to all records in the stream.
        /// </para>
        ///  
        /// <para>
        /// An unsuccessfully-processed record includes <code>ErrorCode</code> and <code>ErrorMessage</code>
        /// values. <code>ErrorCode</code> reflects the type of error and can be one of the following
        /// values: <code>ProvisionedThroughputExceededException</code> or <code>InternalFailure</code>.
        /// <code>ErrorMessage</code> provides more detailed information about the <code>ProvisionedThroughputExceededException</code>
        /// exception including the account ID, stream name, and shard ID of the record that was
        /// throttled.
        /// </para>
        ///  
        /// <para>
        /// Data records are accessible for only 24 hours from the time that they are added to
        /// an Amazon Kinesis stream.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRecords service method.</param>
        /// 
        /// <returns>The response from the PutRecords service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ProvisionedThroughputExceededException">
        /// The request rate is too high, or the requested data is too large for the available
        /// throughput. Reduce the frequency or size of your requests. For more information, see
        /// <a href="http://docs.aws.amazon.com/general/latest/gr/api-retries.html" target="_blank">Error
        /// Retries and Exponential Backoff in AWS</a> in the <i>AWS General Reference</i>.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. It might not be specified correctly, or
        /// it might not be in the <code>ACTIVE</code> state.
        /// </exception>
        public PutRecordsResponse PutRecords(PutRecordsRequest request)
        {
            var marshaller = new PutRecordsRequestMarshaller();
            var unmarshaller = PutRecordsResponseUnmarshaller.Instance;

            return Invoke<PutRecordsRequest,PutRecordsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutRecords operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutRecords operation on AmazonKinesisClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutRecords
        ///         operation.</returns>
        public IAsyncResult BeginPutRecords(PutRecordsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new PutRecordsRequestMarshaller();
            var unmarshaller = PutRecordsResponseUnmarshaller.Instance;

            return BeginInvoke<PutRecordsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutRecords operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutRecords.</param>
        /// 
        /// <returns>Returns a  PutRecordsResult from Kinesis.</returns>
        public  PutRecordsResponse EndPutRecords(IAsyncResult asyncResult)
        {
            return EndInvoke<PutRecordsResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveTagsFromStream

        /// <summary>
        /// Deletes tags from the specified Amazon Kinesis stream.
        /// 
        ///  
        /// <para>
        /// If you specify a tag that does not exist, it is ignored.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromStream service method.</param>
        /// 
        /// <returns>The response from the RemoveTagsFromStream service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed (5).
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For example, you attempted to split
        /// a shard but the stream is not in the <code>ACTIVE</code> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. It might not be specified correctly, or
        /// it might not be in the <code>ACTIVE</code> state.
        /// </exception>
        public RemoveTagsFromStreamResponse RemoveTagsFromStream(RemoveTagsFromStreamRequest request)
        {
            var marshaller = new RemoveTagsFromStreamRequestMarshaller();
            var unmarshaller = RemoveTagsFromStreamResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsFromStreamRequest,RemoveTagsFromStreamResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTagsFromStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromStream operation on AmazonKinesisClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveTagsFromStream
        ///         operation.</returns>
        public IAsyncResult BeginRemoveTagsFromStream(RemoveTagsFromStreamRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new RemoveTagsFromStreamRequestMarshaller();
            var unmarshaller = RemoveTagsFromStreamResponseUnmarshaller.Instance;

            return BeginInvoke<RemoveTagsFromStreamRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveTagsFromStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveTagsFromStream.</param>
        /// 
        /// <returns>Returns a  RemoveTagsFromStreamResult from Kinesis.</returns>
        public  RemoveTagsFromStreamResponse EndRemoveTagsFromStream(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveTagsFromStreamResponse>(asyncResult);
        }

        #endregion
        
        #region  SplitShard

        /// <summary>
        /// Splits a shard into two new shards in the stream, to increase the stream's capacity
        /// to ingest and transport data. <code>SplitShard</code> is called when there is a need
        /// to increase the overall capacity of stream because of an expected increase in the
        /// volume of data records being ingested. 
        /// 
        ///  
        /// <para>
        /// You can also use <code>SplitShard</code> when a shard appears to be approaching its
        /// maximum utilization, for example, when the set of producers sending data into the
        /// specific shard are suddenly sending more than previously anticipated. You can also
        /// call <code>SplitShard</code> to increase stream capacity, so that more Amazon Kinesis
        /// applications can simultaneously read data from the stream for real-time processing.
        /// 
        /// </para>
        ///  
        /// <para>
        /// You must specify the shard to be split and the new hash key, which is the position
        /// in the shard where the shard gets split in two. In many cases, the new hash key might
        /// simply be the average of the beginning and ending hash key, but it can be any hash
        /// key value in the range being mapped into the shard. For more information about splitting
        /// shards, see <a href="http://docs.aws.amazon.com/kinesis/latest/dev/kinesis-using-api-java.html#kinesis-using-api-java-resharding-split">Split
        /// a Shard</a> in the <i>Amazon Kinesis Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can use <a>DescribeStream</a> to determine the shard ID and hash key values for
        /// the <code>ShardToSplit</code> and <code>NewStartingHashKey</code> parameters that
        /// are specified in the <code>SplitShard</code> request.
        /// </para>
        ///  
        /// <para>
        /// <code>SplitShard</code> is an asynchronous operation. Upon receiving a <code>SplitShard</code>
        /// request, Amazon Kinesis immediately returns a response and sets the stream status
        /// to <code>UPDATING</code>. After the operation is completed, Amazon Kinesis sets the
        /// stream status to <code>ACTIVE</code>. Read and write operations continue to work while
        /// the stream is in the <code>UPDATING</code> state. 
        /// </para>
        ///  
        /// <para>
        /// You can use <code>DescribeStream</code> to check the status of the stream, which is
        /// returned in <code>StreamStatus</code>. If the stream is in the <code>ACTIVE</code>
        /// state, you can call <code>SplitShard</code>. If a stream is in <code>CREATING</code>
        /// or <code>UPDATING</code> or <code>DELETING</code> states, <code>DescribeStream</code>
        /// returns a <code>ResourceInUseException</code>.
        /// </para>
        ///  
        /// <para>
        /// If the specified stream does not exist, <code>DescribeStream</code> returns a <code>ResourceNotFoundException</code>.
        /// If you try to create more shards than are authorized for your account, you receive
        /// a <code>LimitExceededException</code>. 
        /// </para>
        ///  
        /// <para>
        /// The default limit for an AWS account is 10 shards per stream. If you need to create
        /// a stream with more than 10 shards, <a href="http://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html">contact
        /// AWS Support</a> to increase the limit on your account.
        /// </para>
        ///  
        /// <para>
        /// If you try to operate on too many streams in parallel using <a>CreateStream</a>, <a>DeleteStream</a>,
        /// <a>MergeShards</a> or <a>SplitShard</a>, you receive a <code>LimitExceededException</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// <code>SplitShard</code> has limit of 5 transactions per second per account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SplitShard service method.</param>
        /// 
        /// <returns>The response from the SplitShard service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed (5).
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For example, you attempted to split
        /// a shard but the stream is not in the <code>ACTIVE</code> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. It might not be specified correctly, or
        /// it might not be in the <code>ACTIVE</code> state.
        /// </exception>
        public SplitShardResponse SplitShard(SplitShardRequest request)
        {
            var marshaller = new SplitShardRequestMarshaller();
            var unmarshaller = SplitShardResponseUnmarshaller.Instance;

            return Invoke<SplitShardRequest,SplitShardResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SplitShard operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SplitShard operation on AmazonKinesisClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSplitShard
        ///         operation.</returns>
        public IAsyncResult BeginSplitShard(SplitShardRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new SplitShardRequestMarshaller();
            var unmarshaller = SplitShardResponseUnmarshaller.Instance;

            return BeginInvoke<SplitShardRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SplitShard operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSplitShard.</param>
        /// 
        /// <returns>Returns a  SplitShardResult from Kinesis.</returns>
        public  SplitShardResponse EndSplitShard(IAsyncResult asyncResult)
        {
            return EndInvoke<SplitShardResponse>(asyncResult);
        }

        #endregion
        
    }
}