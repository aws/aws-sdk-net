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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.KinesisVideoArchivedMedia.Model;

namespace Amazon.KinesisVideoArchivedMedia
{
    /// <summary>
    /// Interface for accessing KinesisVideoArchivedMedia
    ///
    /// 
    /// </summary>
    public partial interface IAmazonKinesisVideoArchivedMedia : IAmazonService, IDisposable
    {
                
        #region  GetHLSStreamingSessionURL


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
        Task<GetHLSStreamingSessionURLResponse> GetHLSStreamingSessionURLAsync(GetHLSStreamingSessionURLRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetMediaForFragmentList


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
        Task<GetMediaForFragmentListResponse> GetMediaForFragmentListAsync(GetMediaForFragmentListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListFragments


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
        Task<ListFragmentsResponse> ListFragmentsAsync(ListFragmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}