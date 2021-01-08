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
 * Do not modify this file. This file is generated from the kinesis-video-media-2017-09-30.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.KinesisVideoMedia.Model;
using Amazon.KinesisVideoMedia.Model.Internal.MarshallTransformations;
using Amazon.KinesisVideoMedia.Internal;
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
        private static IServiceMetadata serviceMetadata = new AmazonKinesisVideoMediaMetadata();


        #region Overrides

        
        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
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


        #region  GetMedia

        /// <summary>
        /// Use this API to retrieve media content from a Kinesis video stream. In the request,
        /// you identify the stream name or stream Amazon Resource Name (ARN), and the starting
        /// chunk. Kinesis Video Streams then returns a stream of chunks in order by fragment
        /// number.
        /// 
        ///  <note> 
        /// <para>
        /// You must first call the <code>GetDataEndpoint</code> API to get an endpoint. Then
        /// send the <code>GetMedia</code> requests to this endpoint using the <a href="https://docs.aws.amazon.com/cli/latest/reference/">--endpoint-url
        /// parameter</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// When you put media data (fragments) on a stream, Kinesis Video Streams stores each
        /// incoming fragment and related metadata in what is called a "chunk." For more information,
        /// see <a href="https://docs.aws.amazon.com/kinesisvideostreams/latest/dg/API_dataplane_PutMedia.html">PutMedia</a>.
        /// The <code>GetMedia</code> API returns a stream of these chunks starting from the chunk
        /// that you specify in the request. 
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
        ///  </li> </ul> <note> 
        /// <para>
        /// If an error is thrown after invoking a Kinesis Video Streams media API, in addition
        /// to the HTTP status code and the response body, it includes the following pieces of
        /// information: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>x-amz-ErrorType</code> HTTP header – contains a more specific error type in
        /// addition to what the HTTP status code provides. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>x-amz-RequestId</code> HTTP header – if you want to report an issue to AWS,
        /// the support team can better diagnose the problem if given the Request Id.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Both the HTTP status code and the ErrorType header can be utilized to make programmatic
        /// decisions about whether errors are retry-able and under what conditions, as well as
        /// provide information on what actions the client programmer might need to take in order
        /// to successfully try again.
        /// </para>
        ///  
        /// <para>
        /// For more information, see the <b>Errors</b> section at the bottom of this topic, as
        /// well as <a href="https://docs.aws.amazon.com/kinesisvideostreams/latest/dg/CommonErrors.html">Common
        /// Errors</a>. 
        /// </para>
        ///  </note>
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMediaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMediaResponseUnmarshaller.Instance;

            return Invoke<GetMediaResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetMedia operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMedia operation on AmazonKinesisVideoMediaClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMedia
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-video-media-2017-09-30/GetMedia">REST API Reference for GetMedia Operation</seealso>
        public virtual IAsyncResult BeginGetMedia(GetMediaRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMediaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMediaResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetMedia operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMedia.</param>
        /// 
        /// <returns>Returns a  GetMediaResult from KinesisVideoMedia.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-video-media-2017-09-30/GetMedia">REST API Reference for GetMedia Operation</seealso>
        public virtual GetMediaResponse EndGetMedia(IAsyncResult asyncResult)
        {
            return EndInvoke<GetMediaResponse>(asyncResult);
        }

        #endregion
        
    }
}