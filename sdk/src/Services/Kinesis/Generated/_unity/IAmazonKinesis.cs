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

using Amazon.Runtime;
using Amazon.Kinesis.Model;

namespace Amazon.Kinesis
{
    /// <summary>
    /// Interface for accessing Kinesis
    ///
    /// Amazon Kinesis Data Streams Service API Reference 
    /// <para>
    /// Amazon Kinesis Data Streams is a managed service that scales elastically for real-time
    /// processing of streaming big data.
    /// </para>
    /// </summary>
    public partial interface IAmazonKinesis : IAmazonService, IDisposable
    {

        
        #region  AddTagsToStream


        /// <summary>
        /// Initiates the asynchronous execution of the AddTagsToStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToStream operation on AmazonKinesisClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/AddTagsToStream">REST API Reference for AddTagsToStream Operation</seealso>
        void AddTagsToStreamAsync(AddTagsToStreamRequest request, AmazonServiceCallback<AddTagsToStreamRequest, AddTagsToStreamResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  CreateStream


        /// <summary>
        /// Initiates the asynchronous execution of the CreateStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStream operation on AmazonKinesisClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/CreateStream">REST API Reference for CreateStream Operation</seealso>
        void CreateStreamAsync(CreateStreamRequest request, AmazonServiceCallback<CreateStreamRequest, CreateStreamResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  DecreaseStreamRetentionPeriod


        /// <summary>
        /// Decreases the Kinesis data stream's retention period, which is the length of time
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
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the DecreaseStreamRetentionPeriod service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <code>ACTIVE</code> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DecreaseStreamRetentionPeriod">REST API Reference for DecreaseStreamRetentionPeriod Operation</seealso>
        void DecreaseStreamRetentionPeriodAsync(string streamName, int retentionPeriodHours,  AmazonServiceCallback<DecreaseStreamRetentionPeriodRequest, DecreaseStreamRetentionPeriodResponse> callback, AsyncOptions options = null);

        /// <summary>
        /// Initiates the asynchronous execution of the DecreaseStreamRetentionPeriod operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DecreaseStreamRetentionPeriod operation on AmazonKinesisClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DecreaseStreamRetentionPeriod">REST API Reference for DecreaseStreamRetentionPeriod Operation</seealso>
        void DecreaseStreamRetentionPeriodAsync(DecreaseStreamRetentionPeriodRequest request, AmazonServiceCallback<DecreaseStreamRetentionPeriodRequest, DecreaseStreamRetentionPeriodResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  DeleteStream


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStream operation on AmazonKinesisClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DeleteStream">REST API Reference for DeleteStream Operation</seealso>
        void DeleteStreamAsync(DeleteStreamRequest request, AmazonServiceCallback<DeleteStreamRequest, DeleteStreamResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  DescribeLimits


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLimits operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLimits operation on AmazonKinesisClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DescribeLimits">REST API Reference for DescribeLimits Operation</seealso>
        void DescribeLimitsAsync(DescribeLimitsRequest request, AmazonServiceCallback<DescribeLimitsRequest, DescribeLimitsResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  DescribeStream


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStream operation on AmazonKinesisClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DescribeStream">REST API Reference for DescribeStream Operation</seealso>
        void DescribeStreamAsync(DescribeStreamRequest request, AmazonServiceCallback<DescribeStreamRequest, DescribeStreamResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  DescribeStreamSummary


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStreamSummary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStreamSummary operation on AmazonKinesisClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DescribeStreamSummary">REST API Reference for DescribeStreamSummary Operation</seealso>
        void DescribeStreamSummaryAsync(DescribeStreamSummaryRequest request, AmazonServiceCallback<DescribeStreamSummaryRequest, DescribeStreamSummaryResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  DisableEnhancedMonitoring


        /// <summary>
        /// Initiates the asynchronous execution of the DisableEnhancedMonitoring operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableEnhancedMonitoring operation on AmazonKinesisClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/DisableEnhancedMonitoring">REST API Reference for DisableEnhancedMonitoring Operation</seealso>
        void DisableEnhancedMonitoringAsync(DisableEnhancedMonitoringRequest request, AmazonServiceCallback<DisableEnhancedMonitoringRequest, DisableEnhancedMonitoringResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  EnableEnhancedMonitoring


        /// <summary>
        /// Initiates the asynchronous execution of the EnableEnhancedMonitoring operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableEnhancedMonitoring operation on AmazonKinesisClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/EnableEnhancedMonitoring">REST API Reference for EnableEnhancedMonitoring Operation</seealso>
        void EnableEnhancedMonitoringAsync(EnableEnhancedMonitoringRequest request, AmazonServiceCallback<EnableEnhancedMonitoringRequest, EnableEnhancedMonitoringResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  GetRecords


        /// <summary>
        /// Initiates the asynchronous execution of the GetRecords operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRecords operation on AmazonKinesisClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/GetRecords">REST API Reference for GetRecords Operation</seealso>
        void GetRecordsAsync(GetRecordsRequest request, AmazonServiceCallback<GetRecordsRequest, GetRecordsResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  GetShardIterator


        /// <summary>
        /// Initiates the asynchronous execution of the GetShardIterator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetShardIterator operation on AmazonKinesisClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/GetShardIterator">REST API Reference for GetShardIterator Operation</seealso>
        void GetShardIteratorAsync(GetShardIteratorRequest request, AmazonServiceCallback<GetShardIteratorRequest, GetShardIteratorResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  IncreaseStreamRetentionPeriod


        /// <summary>
        /// Increases the Kinesis data stream's retention period, which is the length of time
        /// data records are accessible after they are added to the stream. The maximum value
        /// of a stream's retention period is 168 hours (7 days).
        /// 
        ///  
        /// <para>
        /// If you choose a longer stream retention period, this operation increases the time
        /// period during which records that have not yet expired are accessible. However, it
        /// does not make previous, expired data (older than the stream's previous retention period)
        /// accessible after the operation has been called. For example, if a stream's retention
        /// period is set to 24 hours and is increased to 168 hours, any data that is older than
        /// 24 hours remains inaccessible to consumer applications.
        /// </para>
        /// </summary>
        /// <param name="streamName">The name of the stream to modify.</param>
        /// <param name="retentionPeriodHours">The new retention period of the stream, in hours. Must be more than the current retention period.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the IncreaseStreamRetentionPeriod service method, as returned by Kinesis.</returns>
        /// <exception cref="Amazon.Kinesis.Model.InvalidArgumentException">
        /// A specified parameter exceeds its restrictions, is not supported, or can't be used.
        /// For more information, see the returned message.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.LimitExceededException">
        /// The requested resource exceeds the maximum number allowed, or the number of concurrent
        /// stream requests exceeds the maximum number allowed.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceInUseException">
        /// The resource is not available for this operation. For successful operation, the resource
        /// must be in the <code>ACTIVE</code> state.
        /// </exception>
        /// <exception cref="Amazon.Kinesis.Model.ResourceNotFoundException">
        /// The requested resource could not be found. The stream might not be specified correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/IncreaseStreamRetentionPeriod">REST API Reference for IncreaseStreamRetentionPeriod Operation</seealso>
        void IncreaseStreamRetentionPeriodAsync(string streamName, int retentionPeriodHours,  AmazonServiceCallback<IncreaseStreamRetentionPeriodRequest, IncreaseStreamRetentionPeriodResponse> callback, AsyncOptions options = null);

        /// <summary>
        /// Initiates the asynchronous execution of the IncreaseStreamRetentionPeriod operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the IncreaseStreamRetentionPeriod operation on AmazonKinesisClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/IncreaseStreamRetentionPeriod">REST API Reference for IncreaseStreamRetentionPeriod Operation</seealso>
        void IncreaseStreamRetentionPeriodAsync(IncreaseStreamRetentionPeriodRequest request, AmazonServiceCallback<IncreaseStreamRetentionPeriodRequest, IncreaseStreamRetentionPeriodResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  ListShards


        /// <summary>
        /// Initiates the asynchronous execution of the ListShards operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListShards operation on AmazonKinesisClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/ListShards">REST API Reference for ListShards Operation</seealso>
        void ListShardsAsync(ListShardsRequest request, AmazonServiceCallback<ListShardsRequest, ListShardsResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  ListStreams


        /// <summary>
        /// Initiates the asynchronous execution of the ListStreams operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStreams operation on AmazonKinesisClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/ListStreams">REST API Reference for ListStreams Operation</seealso>
        void ListStreamsAsync(ListStreamsRequest request, AmazonServiceCallback<ListStreamsRequest, ListStreamsResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  ListTagsForStream


        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForStream operation on AmazonKinesisClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/ListTagsForStream">REST API Reference for ListTagsForStream Operation</seealso>
        void ListTagsForStreamAsync(ListTagsForStreamRequest request, AmazonServiceCallback<ListTagsForStreamRequest, ListTagsForStreamResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  MergeShards


        /// <summary>
        /// Initiates the asynchronous execution of the MergeShards operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the MergeShards operation on AmazonKinesisClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/MergeShards">REST API Reference for MergeShards Operation</seealso>
        void MergeShardsAsync(MergeShardsRequest request, AmazonServiceCallback<MergeShardsRequest, MergeShardsResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  PutRecord


        /// <summary>
        /// Initiates the asynchronous execution of the PutRecord operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutRecord operation on AmazonKinesisClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/PutRecord">REST API Reference for PutRecord Operation</seealso>
        void PutRecordAsync(PutRecordRequest request, AmazonServiceCallback<PutRecordRequest, PutRecordResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  PutRecords


        /// <summary>
        /// Initiates the asynchronous execution of the PutRecords operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutRecords operation on AmazonKinesisClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/PutRecords">REST API Reference for PutRecords Operation</seealso>
        void PutRecordsAsync(PutRecordsRequest request, AmazonServiceCallback<PutRecordsRequest, PutRecordsResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  RemoveTagsFromStream


        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTagsFromStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromStream operation on AmazonKinesisClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/RemoveTagsFromStream">REST API Reference for RemoveTagsFromStream Operation</seealso>
        void RemoveTagsFromStreamAsync(RemoveTagsFromStreamRequest request, AmazonServiceCallback<RemoveTagsFromStreamRequest, RemoveTagsFromStreamResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  SplitShard


        /// <summary>
        /// Initiates the asynchronous execution of the SplitShard operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SplitShard operation on AmazonKinesisClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/SplitShard">REST API Reference for SplitShard Operation</seealso>
        void SplitShardAsync(SplitShardRequest request, AmazonServiceCallback<SplitShardRequest, SplitShardResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  StartStreamEncryption


        /// <summary>
        /// Initiates the asynchronous execution of the StartStreamEncryption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartStreamEncryption operation on AmazonKinesisClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/StartStreamEncryption">REST API Reference for StartStreamEncryption Operation</seealso>
        void StartStreamEncryptionAsync(StartStreamEncryptionRequest request, AmazonServiceCallback<StartStreamEncryptionRequest, StartStreamEncryptionResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  StopStreamEncryption


        /// <summary>
        /// Initiates the asynchronous execution of the StopStreamEncryption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopStreamEncryption operation on AmazonKinesisClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/StopStreamEncryption">REST API Reference for StopStreamEncryption Operation</seealso>
        void StopStreamEncryptionAsync(StopStreamEncryptionRequest request, AmazonServiceCallback<StopStreamEncryptionRequest, StopStreamEncryptionResponse> callback, AsyncOptions options = null);


        #endregion
        
        #region  UpdateShardCount


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateShardCount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateShardCount operation on AmazonKinesisClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-2013-12-02/UpdateShardCount">REST API Reference for UpdateShardCount Operation</seealso>
        void UpdateShardCountAsync(UpdateShardCountRequest request, AmazonServiceCallback<UpdateShardCountRequest, UpdateShardCountResponse> callback, AsyncOptions options = null);


        #endregion
        
    }
}