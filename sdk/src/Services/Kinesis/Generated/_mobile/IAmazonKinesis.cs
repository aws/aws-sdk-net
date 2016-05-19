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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Kinesis.Model;

namespace Amazon.Kinesis
{
    /// <summary>
    /// Interface for accessing Kinesis
    ///
    /// Amazon Kinesis Streams Service API Reference 
    /// <para>
    /// Amazon Kinesis Streams is a managed service that scales elastically for real time
    /// processing of streaming big data.
    /// </para>
    /// </summary>
    public partial interface IAmazonKinesis : IDisposable
    {
                
        #region  AddTagsToStream


        /// <summary>
        /// Initiates the asynchronous execution of the AddTagsToStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToStream operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AddTagsToStreamResponse> AddTagsToStreamAsync(AddTagsToStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateStream


        /// <summary>
        /// Initiates the asynchronous execution of the CreateStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStream operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateStreamResponse> CreateStreamAsync(CreateStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DecreaseStreamRetentionPeriod


        /// <summary>
        /// Decreases the Amazon Kinesis stream's retention period, which is the length of time
        /// data records are accessible after they are added to the stream. The minimum value
        /// of a stream's retention period is 24 hours.
        /// 
        ///  
        /// <para>
        /// This operation may result in lost data. For example, if the stream's retention period
        /// is 48 hours and is decreased to 24 hours, any data already in the stream that is older
        /// than 24 hours is inaccessible.
        /// </para>
        /// </summary>
        /// <param name="streamName">The name of the stream to modify.</param>
        /// <param name="retentionPeriodHours">The new retention period of the stream, in hours. Must be less than the current retention period.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DecreaseStreamRetentionPeriod service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed (5).
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// needs to be in the <code>ACTIVE</code> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly,
        /// or it might not be in the <code>ACTIVE</code> state if the operation requires it.
        /// </exception>
        Task<DecreaseStreamRetentionPeriodResponse> DecreaseStreamRetentionPeriodAsync(string streamName, int retentionPeriodHours, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the DecreaseStreamRetentionPeriod operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DecreaseStreamRetentionPeriod operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DecreaseStreamRetentionPeriodResponse> DecreaseStreamRetentionPeriodAsync(DecreaseStreamRetentionPeriodRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteStream


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStream operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteStreamResponse> DeleteStreamAsync(DeleteStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeStream


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStream operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeStreamResponse> DescribeStreamAsync(DescribeStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisableEnhancedMonitoring


        /// <summary>
        /// Initiates the asynchronous execution of the DisableEnhancedMonitoring operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableEnhancedMonitoring operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DisableEnhancedMonitoringResponse> DisableEnhancedMonitoringAsync(DisableEnhancedMonitoringRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  EnableEnhancedMonitoring


        /// <summary>
        /// Initiates the asynchronous execution of the EnableEnhancedMonitoring operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableEnhancedMonitoring operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<EnableEnhancedMonitoringResponse> EnableEnhancedMonitoringAsync(EnableEnhancedMonitoringRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetRecords


        /// <summary>
        /// Initiates the asynchronous execution of the GetRecords operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRecords operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetRecordsResponse> GetRecordsAsync(GetRecordsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetShardIterator


        /// <summary>
        /// Initiates the asynchronous execution of the GetShardIterator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetShardIterator operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetShardIteratorResponse> GetShardIteratorAsync(GetShardIteratorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  IncreaseStreamRetentionPeriod


        /// <summary>
        /// Increases the Amazon Kinesis stream's retention period, which is the length of time
        /// data records are accessible after they are added to the stream. The maximum value
        /// of a stream's retention period is 168 hours (7 days).
        /// 
        ///  
        /// <para>
        /// Upon choosing a longer stream retention period, this operation will increase the time
        /// period records are accessible that have not yet expired. However, it will not make
        /// previous data that has expired (older than the stream's previous retention period)
        /// accessible after the operation has been called. For example, if a stream's retention
        /// period is set to 24 hours and is increased to 168 hours, any data that is older than
        /// 24 hours will remain inaccessible to consumer applications.
        /// </para>
        /// </summary>
        /// <param name="streamName">The name of the stream to modify.</param>
        /// <param name="retentionPeriodHours">The new retention period of the stream, in hours. Must be more than the current retention period.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the IncreaseStreamRetentionPeriod service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed (5).
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// needs to be in the <code>ACTIVE</code> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly,
        /// or it might not be in the <code>ACTIVE</code> state if the operation requires it.
        /// </exception>
        Task<IncreaseStreamRetentionPeriodResponse> IncreaseStreamRetentionPeriodAsync(string streamName, int retentionPeriodHours, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the IncreaseStreamRetentionPeriod operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the IncreaseStreamRetentionPeriod operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<IncreaseStreamRetentionPeriodResponse> IncreaseStreamRetentionPeriodAsync(IncreaseStreamRetentionPeriodRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListStreams


        /// <summary>
        /// Lists your Amazon Kinesis streams.
        /// 
        ///  
        /// <para>
        /// The number of streams may be too large to return from a single call to <code>ListStreams</code>.
        /// You can limit the number of returned streams using the <code>Limit</code> parameter.
        /// If you do not specify a value for the <code>Limit</code> parameter, Amazon Kinesis
        /// uses the default limit, which is currently 10.
        /// </para>
        ///  
        /// <para>
        /// You can detect if there are more streams available to list by using the <code>HasMoreStreams</code>
        /// flag from the returned output. If there are more streams available, you can request
        /// more streams by using the name of the last stream returned by the <code>ListStreams</code>
        /// request in the <code>ExclusiveStartStreamName</code> parameter in a subsequent request
        /// to <code>ListStreams</code>. The group of stream names returned by the subsequent
        /// request is then added to the list. You can continue this process until all the stream
        /// names have been collected in the list. 
        /// </para>
        ///  
        /// <para>
        /// <a>ListStreams</a> has a limit of 5 transactions per second per account.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStreams service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed (5).
        /// </exception>
        Task<ListStreamsResponse> ListStreamsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the ListStreams operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStreams operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListStreamsResponse> ListStreamsAsync(ListStreamsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForStream


        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForStream operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListTagsForStreamResponse> ListTagsForStreamAsync(ListTagsForStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  MergeShards


        /// <summary>
        /// Initiates the asynchronous execution of the MergeShards operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the MergeShards operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<MergeShardsResponse> MergeShardsAsync(MergeShardsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutRecord


        /// <summary>
        /// Initiates the asynchronous execution of the PutRecord operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutRecord operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PutRecordResponse> PutRecordAsync(PutRecordRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutRecords


        /// <summary>
        /// Initiates the asynchronous execution of the PutRecords operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutRecords operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PutRecordsResponse> PutRecordsAsync(PutRecordsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RemoveTagsFromStream


        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTagsFromStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromStream operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RemoveTagsFromStreamResponse> RemoveTagsFromStreamAsync(RemoveTagsFromStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SplitShard


        /// <summary>
        /// Initiates the asynchronous execution of the SplitShard operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SplitShard operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<SplitShardResponse> SplitShardAsync(SplitShardRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}