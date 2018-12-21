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
 * Do not modify this file. This file is generated from the kinesis-video-archived-media-2017-09-30.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.KinesisVideoArchivedMedia.Model;
using Amazon.KinesisVideoArchivedMedia.Model.Internal.MarshallTransformations;
using Amazon.KinesisVideoArchivedMedia.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.KinesisVideoArchivedMedia
{
    /// <summary>
    /// Implementation for accessing KinesisVideoArchivedMedia
    ///
    /// 
    /// </summary>
    public partial class AmazonKinesisVideoArchivedMediaClient : AmazonServiceClient, IAmazonKinesisVideoArchivedMedia
    {
        private static IServiceMetadata serviceMetadata = new AmazonKinesisVideoArchivedMediaMetadata();
        

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


        #region  GetHLSStreamingSessionURL

        internal virtual GetHLSStreamingSessionURLResponse GetHLSStreamingSessionURL(GetHLSStreamingSessionURLRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetHLSStreamingSessionURLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetHLSStreamingSessionURLResponseUnmarshaller.Instance;

            return Invoke<GetHLSStreamingSessionURLResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetHLSStreamingSessionURL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHLSStreamingSessionURL operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-video-archived-media-2017-09-30/GetHLSStreamingSessionURL">REST API Reference for GetHLSStreamingSessionURL Operation</seealso>
        public virtual Task<GetHLSStreamingSessionURLResponse> GetHLSStreamingSessionURLAsync(GetHLSStreamingSessionURLRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetHLSStreamingSessionURLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetHLSStreamingSessionURLResponseUnmarshaller.Instance;

            return InvokeAsync<GetHLSStreamingSessionURLResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetMediaForFragmentList

        internal virtual GetMediaForFragmentListResponse GetMediaForFragmentList(GetMediaForFragmentListRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMediaForFragmentListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMediaForFragmentListResponseUnmarshaller.Instance;

            return Invoke<GetMediaForFragmentListResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetMediaForFragmentList operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMediaForFragmentList operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-video-archived-media-2017-09-30/GetMediaForFragmentList">REST API Reference for GetMediaForFragmentList Operation</seealso>
        public virtual Task<GetMediaForFragmentListResponse> GetMediaForFragmentListAsync(GetMediaForFragmentListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetMediaForFragmentListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMediaForFragmentListResponseUnmarshaller.Instance;

            return InvokeAsync<GetMediaForFragmentListResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFragments

        internal virtual ListFragmentsResponse ListFragments(ListFragmentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFragmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFragmentsResponseUnmarshaller.Instance;

            return Invoke<ListFragmentsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListFragments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFragments operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kinesis-video-archived-media-2017-09-30/ListFragments">REST API Reference for ListFragments Operation</seealso>
        public virtual Task<ListFragmentsResponse> ListFragmentsAsync(ListFragmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFragmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFragmentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListFragmentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}