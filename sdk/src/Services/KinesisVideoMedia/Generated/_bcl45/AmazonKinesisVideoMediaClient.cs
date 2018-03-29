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
 * Do not modify this file. This file is generated from the kinesis-video-media-2017-09-30.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.KinesisVideoMedia.Model;
using Amazon.KinesisVideoMedia.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.KinesisVideoMedia
{
    /// <summary>
    /// Implementation for accessing KinesisVideoMedia
    ///
    /// 
    /// </summary>
    public partial class AmazonKinesisVideoMediaClient : AmazonServiceClient, IAmazonKinesisVideoMedia
    {

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
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

        
        #region  GetMedia


        /// <summary>
        /// Use this API to retrieve media content from a Kinesis video stream. In the request,
        /// you identify stream name or stream Amazon Resource Name (ARN), and the starting chunk.
        /// Kinesis Video Streams then returns a stream of chunks in order by fragment number.
        /// 
        ///  <note> 
        /// <para>
        ///  You must first call the <code>GetDataEndpoint</code> API to get an endpoint to which
        /// you can then send the <code>GetMedia</code> requests. 
        /// </para>
        ///  </note> 
        /// <para>
        /// When you put media data (fragments) on a stream, Kinesis Video Streams stores each
        /// incoming fragment and related metadata in what is called a "chunk." For more information,
        /// see . The <code>GetMedia</code> API returns a stream of these chunks starting from
        /// the chunk that you specify in the request. 
        /// </para>
        ///  
        /// <para>
        /// The following limits apply when using the <code>GetMedia</code> API:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A client can call <code>GetMedia</code> up to five times per second per stream. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Kinesis Video Streams sends media data at a rate of up to 25 megabytes per second
        /// (or 200 megabits per second) during a <code>GetMedia</code> session. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMedia service method.</param>
        /// 
        /// <returns>The response from the GetMedia service method, as returned by KinesisVideoMedia.</returns>
        /// <exception cref="Amazon.KinesisVideoMedia.Model.ClientLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client calls. Try making the call later.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoMedia.Model.ConnectionLimitExceededException">
        /// Kinesis Video Streams has throttled the request because you have exceeded the limit
        /// of allowed client connections.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoMedia.Model.InvalidArgumentException">
        /// The value for this input parameter is invalid.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoMedia.Model.InvalidEndpointException">
        /// Status Code: 400, Caller used wrong endpoint to write data to a stream. On receiving
        /// such an exception, the user must call <code>GetDataEndpoint</code> with <code>AccessMode</code>
        /// set to "READ" and use the endpoint Kinesis Video returns in the next <code>GetMedia</code>
        /// call.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoMedia.Model.NotAuthorizedException">
        /// Status Code: 403, The caller is not authorized to perform an operation on the given
        /// stream, or the token has expired.
        /// </exception>
        /// <exception cref="Amazon.KinesisVideoMedia.Model.ResourceNotFoundException">
        /// Status Code: 404, The stream with the given name does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-video-media-2017-09-30/GetMedia">REST API Reference for GetMedia Operation</seealso>
        public virtual GetMediaResponse GetMedia(GetMediaRequest request)
        {
            var marshaller = GetMediaRequestMarshaller.Instance;
            var unmarshaller = GetMediaResponseUnmarshaller.Instance;

            return Invoke<GetMediaRequest,GetMediaResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMedia operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMedia operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-video-media-2017-09-30/GetMedia">REST API Reference for GetMedia Operation</seealso>
        public virtual Task<GetMediaResponse> GetMediaAsync(GetMediaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetMediaRequestMarshaller.Instance;
            var unmarshaller = GetMediaResponseUnmarshaller.Instance;

            return InvokeAsync<GetMediaRequest,GetMediaResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}