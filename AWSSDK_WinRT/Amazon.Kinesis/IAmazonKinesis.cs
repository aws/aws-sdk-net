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
using System.Threading.Tasks;

using Amazon.Kinesis.Model;

namespace Amazon.Kinesis
{
    /// <summary>
    /// Interface for accessing AmazonKinesis.
    /// 
    /// Amazon Kinesis Service API Reference <para>Amazon Kinesis is a managed service that scales elastically for real time processing of streaming
    /// big data.</para>
    /// </summary>
	public partial interface IAmazonKinesis : IDisposable
    {
 
        /// <summary>
        /// <para>This operation adds a new Amazon Kinesis stream to your AWS account. A stream captures and transports data records that are
        /// continuously emitted from different data sources or <i>producers</i> .
        /// Scale-out within an Amazon Kinesis stream is explicitly supported by means of shards, which are uniquely identified groups of
        /// data records in an Amazon Kinesis stream.</para> <para>You specify and control the number of shards that a stream is composed of. Each shard
        /// can support up to 5 read transactions per second up to a maximum total of 2 MB of data read per second. Each shard can support up to 1000
        /// write transactions per second up to a maximum total of 1 MB data written per second. You can add shards to a stream if the amount of data
        /// input increases and you can remove shards if the amount of data input decreases.</para> <para>The stream name identifies the stream. The
        /// name is scoped to the AWS account used by the application. It is also scoped by region. That is, two streams in two different accounts can
        /// have the same name, and two streams in the same account, but in two different regions, can have the same name. </para> <para>
        /// <c>CreateStream</c> is an asynchronous operation. Upon receiving a <c>CreateStream</c> request, Amazon Kinesis immediately returns and sets
        /// the stream status to CREATING. After the stream is created, Amazon Kinesis sets the stream status to ACTIVE. You should perform read and
        /// write operations only on an ACTIVE stream. </para> <para>You receive a <c>LimitExceededException</c> when making a <c>CreateStream</c>
        /// request if you try to do one of the following:</para>
        /// <ul>
        /// <li>Have more than five streams in the CREATING state at any point in time.</li>
        /// <li>Create more shards than are authorized for your account.</li>
        /// 
        /// </ul>
        /// <para> <b>Note:</b> The default limit for an AWS account is two shards per stream. If you need to create a stream with more than two
        /// shards, contact AWS Support to increase the limit on your account.</para> <para>You can use the <c>DescribeStream</c> operation to check the
        /// stream status, which is returned in <c>StreamStatus</c> .</para> <para> <c>CreateStream</c> has a limit of 5 transactions per second per
        /// account.</para>
        /// </summary>
        /// 
        /// <param name="createStreamRequest">Container for the necessary parameters to execute the CreateStream service method on
        /// AmazonKinesis.</param>
        /// 
        /// <exception cref="T:Amazon.Kinesis.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.Kinesis.Model.ResourceInUseException" />
        /// <exception cref="T:Amazon.Kinesis.Model.InvalidArgumentException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CreateStreamResponse> CreateStreamAsync(CreateStreamRequest createStreamRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>This operation deletes a stream and all of its shards and data. You must shut down any applications that are operating on the stream
        /// before you delete the stream. If an application attempts to operate on a deleted stream, it will receive the exception
        /// <c>ResourceNotFoundException</c> .</para> <para>If the stream is in the ACTIVE state, you can delete it. After a <c>DeleteStream</c>
        /// request, the specified stream is in the DELETING state until Amazon Kinesis completes the deletion.</para> <para> <b>Note:</b> Amazon
        /// Kinesis might continue to accept data read and write operations, such as PutRecord and GetRecords, on a stream in the DELETING state until
        /// the stream deletion is complete.</para> <para>When you delete a stream, any shards in that stream are also deleted.</para> <para>You can use
        /// the DescribeStream operation to check the state of the stream, which is returned in <c>StreamStatus</c> .</para> <para> <c>DeleteStream</c>
        /// has a limit of 5 transactions per second per account.</para>
        /// </summary>
        /// 
        /// <param name="deleteStreamRequest">Container for the necessary parameters to execute the DeleteStream service method on
        /// AmazonKinesis.</param>
        /// 
        /// <exception cref="T:Amazon.Kinesis.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.Kinesis.Model.ResourceNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteStreamResponse> DeleteStreamAsync(DeleteStreamRequest deleteStreamRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>This operation returns the following information about the stream: the current status of the stream, the stream Amazon Resource Name
        /// (ARN), and an array of shard objects that comprise the stream. For each shard object there is information about the hash key and sequence
        /// number ranges that the shard spans, and the IDs of any earlier shards that played in a role in a MergeShards or SplitShard operation that
        /// created the shard. A sequence number is the identifier associated with every record ingested in the Amazon Kinesis stream. The sequence
        /// number is assigned by the Amazon Kinesis service when a record is put into the stream. </para> <para>You can limit the number of returned
        /// shards using the <c>Limit</c> parameter. The number of shards in a stream may be too large to return from a single call to
        /// <c>DescribeStream</c> .
        /// You can detect this by using the <c>HasMoreShards</c> flag in the returned output. <c>HasMoreShards</c> is set to <c>true</c>
        /// when there is more data available. </para> <para>If there are more shards available, you can request more shards by using the shard ID of
        /// the last shard returned by the <c>DescribeStream</c> request, in the <c>ExclusiveStartShardId</c> parameter in a subsequent request to
        /// <c>DescribeStream</c> .
        /// 
        /// <c>DescribeStream</c> is a paginated operation. </para> <para> <c>DescribeStream</c> has a limit of 10 transactions per
        /// second per account.</para>
        /// </summary>
        /// 
        /// <param name="describeStreamRequest">Container for the necessary parameters to execute the DescribeStream service method on
        /// AmazonKinesis.</param>
        /// 
        /// <returns>The response from the DescribeStream service method, as returned by AmazonKinesis.</returns>
        /// 
        /// <exception cref="T:Amazon.Kinesis.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.Kinesis.Model.ResourceNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeStreamResponse> DescribeStreamAsync(DescribeStreamRequest describeStreamRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>This operation returns one or more data records from a shard. A <c>GetRecords</c> operation request can retrieve up to 10 MB of
        /// data.</para> <para>You specify a shard iterator for the shard that you want to read data from in the <c>ShardIterator</c> parameter. The
        /// shard iterator specifies the position in the shard from which you want to start reading data records sequentially. A shard iterator
        /// specifies this position using the sequence number of a data record in the shard. For more information about the shard iterator, see
        /// GetShardIterator.</para> <para> <c>GetRecords</c> may return a partial result if the response size limit is exceeded. You will get an error,
        /// but not a partial result if the shard's provisioned throughput is exceeded, the shard iterator has expired, or an internal processing
        /// failure has occurred. Clients can request a smaller amount of data by specifying a maximum number of returned records using the <c>Limit</c>
        /// parameter. The <c>Limit</c> parameter can be set to an integer value of up to 10,000. If you set the value to an integer greater than
        /// 10,000, you will receive <c>InvalidArgumentException</c> .</para> <para>A new shard iterator is returned by every <c>GetRecords</c> request
        /// in <c>NextShardIterator</c> ,
        /// which you use in the <c>ShardIterator</c> parameter of the next <c>GetRecords</c> request. When you repeatedly read from an
        /// Amazon Kinesis stream use a GetShardIterator request to get the first shard iterator to use in your first <c>GetRecords</c> request and then
        /// use the shard iterator returned in <c>NextShardIterator</c> for subsequent reads.</para> <para> <c>GetRecords</c> can return <c>null</c> for
        /// the <c>NextShardIterator</c> to reflect that the shard has been closed and that the requested shard iterator would never have returned more
        /// data. </para> <para>If no items can be processed because of insufficient provisioned throughput on the shard involved in the request,
        /// <c>GetRecords</c> throws <c>ProvisionedThroughputExceededException</c> .</para>
        /// </summary>
        /// 
        /// <param name="getRecordsRequest">Container for the necessary parameters to execute the GetRecords service method on AmazonKinesis.</param>
        /// 
        /// <returns>The response from the GetRecords service method, as returned by AmazonKinesis.</returns>
        /// 
        /// <exception cref="T:Amazon.Kinesis.Model.ProvisionedThroughputExceededException" />
        /// <exception cref="T:Amazon.Kinesis.Model.ExpiredIteratorException" />
        /// <exception cref="T:Amazon.Kinesis.Model.InvalidArgumentException" />
        /// <exception cref="T:Amazon.Kinesis.Model.ResourceNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<GetRecordsResponse> GetRecordsAsync(GetRecordsRequest getRecordsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>This operation returns a shard iterator in <c>ShardIterator</c> . The shard iterator specifies the position in the shard from which
        /// you want to start reading data records sequentially. A shard iterator specifies this position using the sequence number of a data record in
        /// a shard. A sequence number is the identifier associated with every record ingested in the Amazon Kinesis stream. The sequence number is
        /// assigned by the Amazon Kinesis service when a record is put into the stream. </para> <para>You must specify the shard iterator type in the
        /// <c>GetShardIterator</c> request. For example, you can set the <c>ShardIteratorType</c> parameter to read exactly from the position denoted
        /// by a specific sequence number by using the AT_SEQUENCE_NUMBER shard iterator type, or right after the sequence number by using the
        /// AFTER_SEQUENCE_NUMBER shard iterator type, using sequence numbers returned by earlier PutRecord, GetRecords or DescribeStream requests. You
        /// can specify the shard iterator type TRIM_HORIZON in the request to cause <c>ShardIterator</c> to point to the last untrimmed record in the
        /// shard in the system, which is the oldest data record in the shard. Or you can point to just after the most recent record in the shard, by
        /// using the shard iterator type LATEST, so that you always read the most recent data in the shard. </para> <para> <b>Note:</b> Each shard
        /// iterator expires five minutes after it is returned to the requester.</para> <para>When you repeatedly read from an Amazon Kinesis stream use
        /// a GetShardIterator request to get the first shard iterator to to use in your first <c>GetRecords</c> request and then use the shard iterator
        /// returned by the <c>GetRecords</c> request in <c>NextShardIterator</c> for subsequent reads. A new shard iterator is returned by every
        /// <c>GetRecords</c> request in <c>NextShardIterator</c> ,
        /// which you use in the <c>ShardIterator</c> parameter of the next <c>GetRecords</c> request. </para> <para>If a
        /// <c>GetShardIterator</c> request is made too often, you will receive a <c>ProvisionedThroughputExceededException</c> .
        /// For more information about throughput limits, see the <a href="http://docs.aws.amazon.com/kinesis/latest/dev/">Amazon Kinesis
        /// Developer Guide</a> . </para> <para> <c>GetShardIterator</c> can return <c>null</c> for its <c>ShardIterator</c> to indicate that the shard
        /// has been closed and that the requested iterator will return no more data. A shard can be closed by a SplitShard or MergeShards
        /// operation.</para> <para> <c>GetShardIterator</c> has a limit of 5 transactions per second per account per shard.</para>
        /// </summary>
        /// 
        /// <param name="getShardIteratorRequest">Container for the necessary parameters to execute the GetShardIterator service method on
        /// AmazonKinesis.</param>
        /// 
        /// <returns>The response from the GetShardIterator service method, as returned by AmazonKinesis.</returns>
        /// 
        /// <exception cref="T:Amazon.Kinesis.Model.ProvisionedThroughputExceededException" />
        /// <exception cref="T:Amazon.Kinesis.Model.InvalidArgumentException" />
        /// <exception cref="T:Amazon.Kinesis.Model.ResourceNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<GetShardIteratorResponse> GetShardIteratorAsync(GetShardIteratorRequest getShardIteratorRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> This operation returns an array of the names of all the streams that are associated with the AWS account making the
        /// <c>ListStreams</c> request. A given AWS account can have many streams active at one time. </para> <para> The number of streams may be too
        /// large to return from a single call to <c>ListStreams</c> .
        /// You can limit the number of returned streams using the <c>Limit</c> parameter. If you do not specify a value for the
        /// <c>Limit</c> parameter, Amazon Kinesis uses the default limit, which is currently 10.</para> <para> You can detect if there are more streams
        /// available to list by using the <c>HasMoreStreams</c> flag from the returned output. If there are more streams available, you can request
        /// more streams by using the name of the last stream returned by the <c>ListStreams</c> request in the <c>ExclusiveStartStreamName</c>
        /// parameter in a subsequent request to <c>ListStreams</c> .
        /// The group of stream names returned by the subsequent request is then added to the list. You can continue this process until all
        /// the stream names have been collected in the list. </para> <para> <c>ListStreams</c> has a limit of 5 transactions per second per
        /// account.</para>
        /// </summary>
        /// 
        /// <param name="listStreamsRequest">Container for the necessary parameters to execute the ListStreams service method on AmazonKinesis.</param>
        /// 
        /// <returns>The response from the ListStreams service method, as returned by AmazonKinesis.</returns>
        /// 
        /// <exception cref="T:Amazon.Kinesis.Model.LimitExceededException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ListStreamsResponse> ListStreamsAsync(ListStreamsRequest listStreamsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>This operation merges two adjacent shards in a stream and combines them into a single shard to reduce the stream's capacity to ingest
        /// and transport data. Two shards are considered adjacent if the union of the hash key ranges for the two shards form a contiguous set with no
        /// gaps. For example, if you have two shards, one with a hash key range of 276...381 and the other with a hash key range of 382...454, then you
        /// could merge these two shards into a single shard that would have a hash key range of 276...454. After the merge, the single child shard
        /// receives data for all hash key values covered by the two parent shards.</para> <para> <c>MergeShards</c> is called when there is a need to
        /// reduce the overall capacity of a stream because of excess capacity that is not being used. The operation requires that you specify the shard
        /// to be merged and the adjacent shard for a given stream. For more information about merging shards, see the <a href="http://docs.aws.amazon.com/kinesis/latest/dev/">Amazon Kinesis Developer Guide</a> .</para> <para>If the stream is in the ACTIVE
        /// state, you can call <c>MergeShards</c> . If a stream is in CREATING or UPDATING or DELETING states, then Amazon Kinesis returns a
        /// <c>ResourceInUseException</c> .
        /// If the specified stream does not exist, Amazon Kinesis returns a <c>ResourceNotFoundException</c> . </para> <para>You can use
        /// the DescribeStream operation to check the state of the stream, which is returned in <c>StreamStatus</c> .</para> <para> <c>MergeShards</c>
        /// is an asynchronous operation. Upon receiving a <c>MergeShards</c> request, Amazon Kinesis immediately returns a response and sets the
        /// <c>StreamStatus</c> to UPDATING. After the operation is completed, Amazon Kinesis sets the <c>StreamStatus</c> to ACTIVE. Read and write
        /// operations continue to work while the stream is in the UPDATING state. </para> <para>You use the DescribeStream operation to determine the
        /// shard IDs that are specified in the <c>MergeShards</c> request. </para> <para>If you try to operate on too many streams in parallel using
        /// CreateStream, DeleteStream, <c>MergeShards</c> or SplitShard, you will receive a <c>LimitExceededException</c> . </para> <para>
        /// <c>MergeShards</c> has limit of 5 transactions per second per account.</para>
        /// </summary>
        /// 
        /// <param name="mergeShardsRequest">Container for the necessary parameters to execute the MergeShards service method on AmazonKinesis.</param>
        /// 
        /// <exception cref="T:Amazon.Kinesis.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.Kinesis.Model.ResourceInUseException" />
        /// <exception cref="T:Amazon.Kinesis.Model.InvalidArgumentException" />
        /// <exception cref="T:Amazon.Kinesis.Model.ResourceNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<MergeShardsResponse> MergeShardsAsync(MergeShardsRequest mergeShardsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>This operation puts a data record into an Amazon Kinesis stream from a producer. This operation must be called to send data from the
        /// producer into the Amazon Kinesis stream for real-time ingestion and subsequent processing. The <c>PutRecord</c> operation requires the name
        /// of the stream that captures, stores, and transports the data; a partition key; and the data blob itself. The data blob could be a segment
        /// from a log file, geographic/location data, website clickstream data, or any other data type.</para> <para>The partition key is used to
        /// distribute data across shards. Amazon Kinesis segregates the data records that belong to a data stream into multiple shards, using the
        /// partition key associated with each data record to determine which shard a given data record belongs to. </para> <para>Partition keys are
        /// Unicode strings, with a maximum length limit of 256 bytes. An MD5 hash function is used to map partition keys to 128-bit integer values and
        /// to map associated data records to shards using the hash key ranges of the shards. You can override hashing the partition key to determine
        /// the shard by explicitly specifying a hash value using the <c>ExplicitHashKey</c> parameter. For more information, see the <a href="http://docs.aws.amazon.com/kinesis/latest/dev/">Amazon Kinesis Developer Guide</a> .</para> <para> <c>PutRecord</c> returns the shard
        /// ID of where the data record was placed and the sequence number that was assigned to the data record.</para> <para>The
        /// <c>SequenceNumberForOrdering</c> sets the initial sequence number for the partition key. Later <c>PutRecord</c> requests to the same
        /// partition key (from the same client) will automatically increase from <c>SequenceNumberForOrdering</c> , ensuring strict sequential
        /// ordering.</para> <para>If a <c>PutRecord</c> request cannot be processed because of insufficient provisioned throughput on the shard
        /// involved in the request, <c>PutRecord</c> throws <c>ProvisionedThroughputExceededException</c> . </para> <para>Data records are accessible
        /// for only 24 hours from the time that they are added to an Amazon Kinesis stream.</para>
        /// </summary>
        /// 
        /// <param name="putRecordRequest">Container for the necessary parameters to execute the PutRecord service method on AmazonKinesis.</param>
        /// 
        /// <returns>The response from the PutRecord service method, as returned by AmazonKinesis.</returns>
        /// 
        /// <exception cref="T:Amazon.Kinesis.Model.ProvisionedThroughputExceededException" />
        /// <exception cref="T:Amazon.Kinesis.Model.InvalidArgumentException" />
        /// <exception cref="T:Amazon.Kinesis.Model.ResourceNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<PutRecordResponse> PutRecordAsync(PutRecordRequest putRecordRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>This operation splits a shard into two new shards in the stream, to increase the stream's capacity to ingest and transport data.
        /// <c>SplitShard</c> is called when there is a need to increase the overall capacity of stream because of an expected increase in the volume of
        /// data records being ingested. </para> <para> <c>SplitShard</c> can also be used when a given shard appears to be approaching its maximum
        /// utilization, for example, when the set of producers sending data into the specific shard are suddenly sending more than previously
        /// anticipated. You can also call the <c>SplitShard</c> operation to increase stream capacity, so that more Amazon Kinesis applications can
        /// simultaneously read data from the stream for real-time processing. </para> <para>The <c>SplitShard</c> operation requires that you specify
        /// the shard to be split and the new hash key, which is the position in the shard where the shard gets split in two. In many cases, the new
        /// hash key might simply be the average of the beginning and ending hash key, but it can be any hash key value in the range being mapped into
        /// the shard. For more information about splitting shards, see the <a href="http://docs.aws.amazon.com/kinesis/latest/dev/">Amazon Kinesis
        /// Developer Guide</a> .
        /// </para> <para>You can use the DescribeStream operation to determine the shard ID and hash key values for the <c>ShardToSplit</c>
        /// and <c>NewStartingHashKey</c> parameters that are specified in the <c>SplitShard</c> request.</para> <para> <c>SplitShard</c> is an
        /// asynchronous operation. Upon receiving a <c>SplitShard</c> request, Amazon Kinesis immediately returns a response and sets the stream status
        /// to UPDATING. After the operation is completed, Amazon Kinesis sets the stream status to ACTIVE. Read and write operations continue to work
        /// while the stream is in the UPDATING state. </para> <para>You can use <c>DescribeStream</c> to check the status of the stream, which is
        /// returned in <c>StreamStatus</c> .
        /// If the stream is in the ACTIVE state, you can call <c>SplitShard</c> .
        /// If a stream is in CREATING or UPDATING or DELETING states, then Amazon Kinesis returns a <c>ResourceInUseException</c> .</para>
        /// <para>If the specified stream does not exist, Amazon Kinesis returns a <c>ResourceNotFoundException</c> .
        /// If you try to create more shards than are authorized for your account, you receive a <c>LimitExceededException</c> .
        /// </para> <para> <b>Note:</b> The default limit for an AWS account is two shards per stream. If you need to create a stream with more than two
        /// shards, contact AWS Support to increase the limit on your account.</para> <para>If you try to operate on too many streams in parallel using
        /// CreateStream, DeleteStream, MergeShards or SplitShard, you will receive a <c>LimitExceededException</c> . </para> <para> <c>SplitShard</c>
        /// has limit of 5 transactions per second per account.</para>
        /// </summary>
        /// 
        /// <param name="splitShardRequest">Container for the necessary parameters to execute the SplitShard service method on AmazonKinesis.</param>
        /// 
        /// <exception cref="T:Amazon.Kinesis.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.Kinesis.Model.ResourceInUseException" />
        /// <exception cref="T:Amazon.Kinesis.Model.InvalidArgumentException" />
        /// <exception cref="T:Amazon.Kinesis.Model.ResourceNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<SplitShardResponse> SplitShardAsync(SplitShardRequest splitShardRequest, CancellationToken cancellationToken = default(CancellationToken));
    }
}
