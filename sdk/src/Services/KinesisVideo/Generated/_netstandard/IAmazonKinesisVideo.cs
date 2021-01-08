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
 * Do not modify this file. This file is generated from the kinesisvideo-2017-09-30.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.KinesisVideo.Model;

namespace Amazon.KinesisVideo
{
    /// <summary>
    /// Interface for accessing KinesisVideo
    ///
    /// 
    /// </summary>
#if NETSTANDARD13
    [Obsolete("Support for .NET Standard 1.3 is in maintenance mode and will only receive critical bug fixes and security patches. Visit https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/migration-from-net-standard-1-3.html for further details.")]
#endif
    public partial interface IAmazonKinesisVideo : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IKinesisVideoPaginatorFactory Paginators { get; }
#endif
                
        #region  CreateSignalingChannel



        /// <summary>
        /// Creates a signaling channel. 
        /// 
        ///  
        /// <para>
        ///  <code>CreateSignalingChannel</code> is an asynchronous operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSignalingChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSignalingChannel service method, as returned by KinesisVideo.</returns>
        /// <exception cref="Amazon.KinesisVideo.Model.AccessDeniedException">
        /// You do not have required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.AccountChannelLimitExceededException">
        /// You have reached the maximum limit of active signaling channels for this AWS account
        /// in this region.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client calls. Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.InvalidArgumentException">
        /// The value for this input parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceInUseException">
        /// The signaling channel is currently not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.TagsPerResourceExceededLimitException">
        /// You have exceeded the limit of tags that you can associate with the resource. Kinesis
        /// video streams support up to 50 tags.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/CreateSignalingChannel">REST API Reference for CreateSignalingChannel Operation</seealso>
        Task<CreateSignalingChannelResponse> CreateSignalingChannelAsync(CreateSignalingChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateStream



        /// <summary>
        /// Creates a new Kinesis video stream. 
        /// 
        ///  
        /// <para>
        /// When you create a new stream, Kinesis Video Streams assigns it a version number. When
        /// you change the stream's metadata, Kinesis Video Streams updates the version. 
        /// </para>
        ///  
        /// <para>
        ///  <code>CreateStream</code> is an asynchronous operation.
        /// </para>
        ///  
        /// <para>
        /// For information about how the service works, see <a href="https://docs.aws.amazon.com/kinesisvideostreams/latest/dg/how-it-works.html">How
        /// it Works</a>. 
        /// </para>
        ///  
        /// <para>
        /// You must have permissions for the <code>KinesisVideo:CreateStream</code> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateStream service method, as returned by KinesisVideo.</returns>
        /// <exception cref="Amazon.KinesisVideo.Model.AccountStreamLimitExceededException">
        /// The number of streams created for the account is too high.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client calls. Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.DeviceStreamLimitExceededException">
        /// Not implemented.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.InvalidArgumentException">
        /// The value for this input parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.InvalidDeviceException">
        /// Not implemented.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceInUseException">
        /// The signaling channel is currently not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.TagsPerResourceExceededLimitException">
        /// You have exceeded the limit of tags that you can associate with the resource. Kinesis
        /// video streams support up to 50 tags.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/CreateStream">REST API Reference for CreateStream Operation</seealso>
        Task<CreateStreamResponse> CreateStreamAsync(CreateStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteSignalingChannel



        /// <summary>
        /// Deletes a specified signaling channel. <code>DeleteSignalingChannel</code> is an asynchronous
        /// operation. If you don't specify the channel's current version, the most recent version
        /// is deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSignalingChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSignalingChannel service method, as returned by KinesisVideo.</returns>
        /// <exception cref="Amazon.KinesisVideo.Model.AccessDeniedException">
        /// You do not have required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client calls. Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.InvalidArgumentException">
        /// The value for this input parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceInUseException">
        /// The signaling channel is currently not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceNotFoundException">
        /// Amazon Kinesis Video Streams can't find the stream that you specified.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.VersionMismatchException">
        /// The stream version that you specified is not the latest version. To get the latest
        /// version, use the <a href="https://docs.aws.amazon.com/kinesisvideostreams/latest/dg/API_DescribeStream.html">DescribeStream</a>
        /// API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/DeleteSignalingChannel">REST API Reference for DeleteSignalingChannel Operation</seealso>
        Task<DeleteSignalingChannelResponse> DeleteSignalingChannelAsync(DeleteSignalingChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteStream



        /// <summary>
        /// Deletes a Kinesis video stream and the data contained in the stream. 
        /// 
        ///  
        /// <para>
        /// This method marks the stream for deletion, and makes the data in the stream inaccessible
        /// immediately.
        /// </para>
        ///  
        /// <para>
        ///  
        /// </para>
        ///  
        /// <para>
        ///  To ensure that you have the latest version of the stream before deleting it, you
        /// can specify the stream version. Kinesis Video Streams assigns a version to each stream.
        /// When you update a stream, Kinesis Video Streams assigns a new version number. To get
        /// the latest stream version, use the <code>DescribeStream</code> API. 
        /// </para>
        ///  
        /// <para>
        /// This operation requires permission for the <code>KinesisVideo:DeleteStream</code>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteStream service method, as returned by KinesisVideo.</returns>
        /// <exception cref="Amazon.KinesisVideo.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client calls. Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.InvalidArgumentException">
        /// The value for this input parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.NotAuthorizedException">
        /// The caller is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceInUseException">
        /// The signaling channel is currently not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceNotFoundException">
        /// Amazon Kinesis Video Streams can't find the stream that you specified.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.VersionMismatchException">
        /// The stream version that you specified is not the latest version. To get the latest
        /// version, use the <a href="https://docs.aws.amazon.com/kinesisvideostreams/latest/dg/API_DescribeStream.html">DescribeStream</a>
        /// API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/DeleteStream">REST API Reference for DeleteStream Operation</seealso>
        Task<DeleteStreamResponse> DeleteStreamAsync(DeleteStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeSignalingChannel



        /// <summary>
        /// Returns the most current information about the signaling channel. You must specify
        /// either the name or the Amazon Resource Name (ARN) of the channel that you want to
        /// describe.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSignalingChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSignalingChannel service method, as returned by KinesisVideo.</returns>
        /// <exception cref="Amazon.KinesisVideo.Model.AccessDeniedException">
        /// You do not have required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client calls. Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.InvalidArgumentException">
        /// The value for this input parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceNotFoundException">
        /// Amazon Kinesis Video Streams can't find the stream that you specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/DescribeSignalingChannel">REST API Reference for DescribeSignalingChannel Operation</seealso>
        Task<DescribeSignalingChannelResponse> DescribeSignalingChannelAsync(DescribeSignalingChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeStream



        /// <summary>
        /// Returns the most current information about the specified stream. You must specify
        /// either the <code>StreamName</code> or the <code>StreamARN</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStream service method, as returned by KinesisVideo.</returns>
        /// <exception cref="Amazon.KinesisVideo.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client calls. Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.InvalidArgumentException">
        /// The value for this input parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.NotAuthorizedException">
        /// The caller is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceNotFoundException">
        /// Amazon Kinesis Video Streams can't find the stream that you specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/DescribeStream">REST API Reference for DescribeStream Operation</seealso>
        Task<DescribeStreamResponse> DescribeStreamAsync(DescribeStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDataEndpoint



        /// <summary>
        /// Gets an endpoint for a specified stream for either reading or writing. Use this endpoint
        /// in your application to read from the specified stream (using the <code>GetMedia</code>
        /// or <code>GetMediaForFragmentList</code> operations) or write to it (using the <code>PutMedia</code>
        /// operation). 
        /// 
        ///  <note> 
        /// <para>
        /// The returned endpoint does not have the API name appended. The client needs to add
        /// the API name to the returned endpoint.
        /// </para>
        ///  </note> 
        /// <para>
        /// In the request, specify the stream either by <code>StreamName</code> or <code>StreamARN</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDataEndpoint service method, as returned by KinesisVideo.</returns>
        /// <exception cref="Amazon.KinesisVideo.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client calls. Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.InvalidArgumentException">
        /// The value for this input parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.NotAuthorizedException">
        /// The caller is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceNotFoundException">
        /// Amazon Kinesis Video Streams can't find the stream that you specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/GetDataEndpoint">REST API Reference for GetDataEndpoint Operation</seealso>
        Task<GetDataEndpointResponse> GetDataEndpointAsync(GetDataEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSignalingChannelEndpoint



        /// <summary>
        /// Provides an endpoint for the specified signaling channel to send and receive messages.
        /// This API uses the <code>SingleMasterChannelEndpointConfiguration</code> input parameter,
        /// which consists of the <code>Protocols</code> and <code>Role</code> properties.
        /// 
        ///  
        /// <para>
        ///  <code>Protocols</code> is used to determine the communication mechanism. For example,
        /// if you specify <code>WSS</code> as the protocol, this API produces a secure websocket
        /// endpoint. If you specify <code>HTTPS</code> as the protocol, this API generates an
        /// HTTPS endpoint. 
        /// </para>
        ///  
        /// <para>
        ///  <code>Role</code> determines the messaging permissions. A <code>MASTER</code> role
        /// results in this API generating an endpoint that a client can use to communicate with
        /// any of the viewers on the channel. A <code>VIEWER</code> role results in this API
        /// generating an endpoint that a client can use to communicate only with a <code>MASTER</code>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSignalingChannelEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSignalingChannelEndpoint service method, as returned by KinesisVideo.</returns>
        /// <exception cref="Amazon.KinesisVideo.Model.AccessDeniedException">
        /// You do not have required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client calls. Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.InvalidArgumentException">
        /// The value for this input parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceInUseException">
        /// The signaling channel is currently not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceNotFoundException">
        /// Amazon Kinesis Video Streams can't find the stream that you specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/GetSignalingChannelEndpoint">REST API Reference for GetSignalingChannelEndpoint Operation</seealso>
        Task<GetSignalingChannelEndpointResponse> GetSignalingChannelEndpointAsync(GetSignalingChannelEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSignalingChannels



        /// <summary>
        /// Returns an array of <code>ChannelInfo</code> objects. Each object describes a signaling
        /// channel. To retrieve only those channels that satisfy a specific condition, you can
        /// specify a <code>ChannelNameCondition</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSignalingChannels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSignalingChannels service method, as returned by KinesisVideo.</returns>
        /// <exception cref="Amazon.KinesisVideo.Model.AccessDeniedException">
        /// You do not have required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client calls. Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.InvalidArgumentException">
        /// The value for this input parameter is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/ListSignalingChannels">REST API Reference for ListSignalingChannels Operation</seealso>
        Task<ListSignalingChannelsResponse> ListSignalingChannelsAsync(ListSignalingChannelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListStreams



        /// <summary>
        /// Returns an array of <code>StreamInfo</code> objects. Each object describes a stream.
        /// To retrieve only streams that satisfy a specific condition, you can specify a <code>StreamNameCondition</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStreams service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStreams service method, as returned by KinesisVideo.</returns>
        /// <exception cref="Amazon.KinesisVideo.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client calls. Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.InvalidArgumentException">
        /// The value for this input parameter is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/ListStreams">REST API Reference for ListStreams Operation</seealso>
        Task<ListStreamsResponse> ListStreamsAsync(ListStreamsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Returns a list of tags associated with the specified signaling channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by KinesisVideo.</returns>
        /// <exception cref="Amazon.KinesisVideo.Model.AccessDeniedException">
        /// You do not have required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client calls. Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.InvalidArgumentException">
        /// The value for this input parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceNotFoundException">
        /// Amazon Kinesis Video Streams can't find the stream that you specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForStream



        /// <summary>
        /// Returns a list of tags associated with the specified stream.
        /// 
        ///  
        /// <para>
        /// In the request, you must specify either the <code>StreamName</code> or the <code>StreamARN</code>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForStream service method, as returned by KinesisVideo.</returns>
        /// <exception cref="Amazon.KinesisVideo.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client calls. Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.InvalidArgumentException">
        /// The value for this input parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.InvalidResourceFormatException">
        /// The format of the <code>StreamARN</code> is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.NotAuthorizedException">
        /// The caller is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceNotFoundException">
        /// Amazon Kinesis Video Streams can't find the stream that you specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/ListTagsForStream">REST API Reference for ListTagsForStream Operation</seealso>
        Task<ListTagsForStreamResponse> ListTagsForStreamAsync(ListTagsForStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Adds one or more tags to a signaling channel. A <i>tag</i> is a key-value pair (the
        /// value is optional) that you can define and assign to AWS resources. If you specify
        /// a tag that already exists, the tag value is replaced with the value that you specify
        /// in the request. For more information, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/cost-alloc-tags.html">Using
        /// Cost Allocation Tags</a> in the <i>AWS Billing and Cost Management User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by KinesisVideo.</returns>
        /// <exception cref="Amazon.KinesisVideo.Model.AccessDeniedException">
        /// You do not have required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client calls. Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.InvalidArgumentException">
        /// The value for this input parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceNotFoundException">
        /// Amazon Kinesis Video Streams can't find the stream that you specified.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.TagsPerResourceExceededLimitException">
        /// You have exceeded the limit of tags that you can associate with the resource. Kinesis
        /// video streams support up to 50 tags.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagStream



        /// <summary>
        /// Adds one or more tags to a stream. A <i>tag</i> is a key-value pair (the value is
        /// optional) that you can define and assign to AWS resources. If you specify a tag that
        /// already exists, the tag value is replaced with the value that you specify in the request.
        /// For more information, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/cost-alloc-tags.html">Using
        /// Cost Allocation Tags</a> in the <i>AWS Billing and Cost Management User Guide</i>.
        /// 
        /// 
        ///  
        /// <para>
        /// You must provide either the <code>StreamName</code> or the <code>StreamARN</code>.
        /// </para>
        ///  
        /// <para>
        /// This operation requires permission for the <code>KinesisVideo:TagStream</code> action.
        /// </para>
        ///  
        /// <para>
        /// Kinesis video streams support up to 50 tags.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagStream service method, as returned by KinesisVideo.</returns>
        /// <exception cref="Amazon.KinesisVideo.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client calls. Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.InvalidArgumentException">
        /// The value for this input parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.InvalidResourceFormatException">
        /// The format of the <code>StreamARN</code> is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.NotAuthorizedException">
        /// The caller is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceNotFoundException">
        /// Amazon Kinesis Video Streams can't find the stream that you specified.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.TagsPerResourceExceededLimitException">
        /// You have exceeded the limit of tags that you can associate with the resource. Kinesis
        /// video streams support up to 50 tags.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/TagStream">REST API Reference for TagStream Operation</seealso>
        Task<TagStreamResponse> TagStreamAsync(TagStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes one or more tags from a signaling channel. In the request, specify only a
        /// tag key or keys; don't specify the value. If you specify a tag key that does not exist,
        /// it's ignored.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by KinesisVideo.</returns>
        /// <exception cref="Amazon.KinesisVideo.Model.AccessDeniedException">
        /// You do not have required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client calls. Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.InvalidArgumentException">
        /// The value for this input parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceNotFoundException">
        /// Amazon Kinesis Video Streams can't find the stream that you specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagStream



        /// <summary>
        /// Removes one or more tags from a stream. In the request, specify only a tag key or
        /// keys; don't specify the value. If you specify a tag key that does not exist, it's
        /// ignored.
        /// 
        ///  
        /// <para>
        /// In the request, you must provide the <code>StreamName</code> or <code>StreamARN</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagStream service method, as returned by KinesisVideo.</returns>
        /// <exception cref="Amazon.KinesisVideo.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client calls. Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.InvalidArgumentException">
        /// The value for this input parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.InvalidResourceFormatException">
        /// The format of the <code>StreamARN</code> is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.NotAuthorizedException">
        /// The caller is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceNotFoundException">
        /// Amazon Kinesis Video Streams can't find the stream that you specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/UntagStream">REST API Reference for UntagStream Operation</seealso>
        Task<UntagStreamResponse> UntagStreamAsync(UntagStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateDataRetention



        /// <summary>
        /// Increases or decreases the stream's data retention period by the value that you specify.
        /// To indicate whether you want to increase or decrease the data retention period, specify
        /// the <code>Operation</code> parameter in the request body. In the request, you must
        /// specify either the <code>StreamName</code> or the <code>StreamARN</code>. 
        /// 
        ///  <note> 
        /// <para>
        /// The retention period that you specify replaces the current value.
        /// </para>
        ///  </note> 
        /// <para>
        /// This operation requires permission for the <code>KinesisVideo:UpdateDataRetention</code>
        /// action.
        /// </para>
        ///  
        /// <para>
        /// Changing the data retention period affects the data in the stream as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the data retention period is increased, existing data is retained for the new retention
        /// period. For example, if the data retention period is increased from one hour to seven
        /// hours, all existing data is retained for seven hours.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the data retention period is decreased, existing data is retained for the new retention
        /// period. For example, if the data retention period is decreased from seven hours to
        /// one hour, all existing data is retained for one hour, and any data older than one
        /// hour is deleted immediately.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataRetention service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDataRetention service method, as returned by KinesisVideo.</returns>
        /// <exception cref="Amazon.KinesisVideo.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client calls. Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.InvalidArgumentException">
        /// The value for this input parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.NotAuthorizedException">
        /// The caller is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceInUseException">
        /// The signaling channel is currently not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceNotFoundException">
        /// Amazon Kinesis Video Streams can't find the stream that you specified.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.VersionMismatchException">
        /// The stream version that you specified is not the latest version. To get the latest
        /// version, use the <a href="https://docs.aws.amazon.com/kinesisvideostreams/latest/dg/API_DescribeStream.html">DescribeStream</a>
        /// API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/UpdateDataRetention">REST API Reference for UpdateDataRetention Operation</seealso>
        Task<UpdateDataRetentionResponse> UpdateDataRetentionAsync(UpdateDataRetentionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateSignalingChannel



        /// <summary>
        /// Updates the existing signaling channel. This is an asynchronous operation and takes
        /// time to complete. 
        /// 
        ///  
        /// <para>
        /// If the <code>MessageTtlSeconds</code> value is updated (either increased or reduced),
        /// it only applies to new messages sent via this channel after it's been updated. Existing
        /// messages are still expired as per the previous <code>MessageTtlSeconds</code> value.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSignalingChannel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSignalingChannel service method, as returned by KinesisVideo.</returns>
        /// <exception cref="Amazon.KinesisVideo.Model.AccessDeniedException">
        /// You do not have required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client calls. Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.InvalidArgumentException">
        /// The value for this input parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceInUseException">
        /// The signaling channel is currently not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceNotFoundException">
        /// Amazon Kinesis Video Streams can't find the stream that you specified.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.VersionMismatchException">
        /// The stream version that you specified is not the latest version. To get the latest
        /// version, use the <a href="https://docs.aws.amazon.com/kinesisvideostreams/latest/dg/API_DescribeStream.html">DescribeStream</a>
        /// API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/UpdateSignalingChannel">REST API Reference for UpdateSignalingChannel Operation</seealso>
        Task<UpdateSignalingChannelResponse> UpdateSignalingChannelAsync(UpdateSignalingChannelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateStream



        /// <summary>
        /// Updates stream metadata, such as the device name and media type.
        /// 
        ///  
        /// <para>
        /// You must provide the stream name or the Amazon Resource Name (ARN) of the stream.
        /// </para>
        ///  
        /// <para>
        /// To make sure that you have the latest version of the stream before updating it, you
        /// can specify the stream version. Kinesis Video Streams assigns a version to each stream.
        /// When you update a stream, Kinesis Video Streams assigns a new version number. To get
        /// the latest stream version, use the <code>DescribeStream</code> API. 
        /// </para>
        ///  
        /// <para>
        ///  <code>UpdateStream</code> is an asynchronous operation, and takes time to complete.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateStream service method, as returned by KinesisVideo.</returns>
        /// <exception cref="Amazon.KinesisVideo.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client calls. Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.InvalidArgumentException">
        /// The value for this input parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.NotAuthorizedException">
        /// The caller is not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceInUseException">
        /// The signaling channel is currently not available for this operation.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.ResourceNotFoundException">
        /// Amazon Kinesis Video Streams can't find the stream that you specified.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideo.Model.VersionMismatchException">
        /// The stream version that you specified is not the latest version. To get the latest
        /// version, use the <a href="https://docs.aws.amazon.com/kinesisvideostreams/latest/dg/API_DescribeStream.html">DescribeStream</a>
        /// API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesisvideo-2017-09-30/UpdateStream">REST API Reference for UpdateStream Operation</seealso>
        Task<UpdateStreamResponse> UpdateStreamAsync(UpdateStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}