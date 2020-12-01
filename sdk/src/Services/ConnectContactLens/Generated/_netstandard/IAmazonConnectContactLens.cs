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
 * Do not modify this file. This file is generated from the connect-contact-lens-2020-08-21.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ConnectContactLens.Model;

namespace Amazon.ConnectContactLens
{
    /// <summary>
    /// Interface for accessing ConnectContactLens
    ///
    /// Contact Lens for Amazon Connect enables you to analyze conversations between customer
    /// and agents, by using speech transcription, natural language processing, and intelligent
    /// search capabilities. It performs sentiment analysis, detects issues, and enables you
    /// to automatically categorize contacts.
    /// 
    ///  
    /// <para>
    /// Contact Lens for Amazon Connect provides both real-time and post-call analytics of
    /// customer-agent conversations. For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/analyze-conversations.html">Analyze
    /// conversations using Contact Lens</a> in the <i>Amazon Connect Administrator Guide</i>.
    /// 
    /// </para>
    /// </summary>
#if NETSTANDARD13
    [Obsolete("Support for .NET Standard 1.3 is in maintenance mode and will only receive critical bug fixes and security patches. Visit https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/migration-from-net-standard-1-3.html for further details.")]
#endif
    public partial interface IAmazonConnectContactLens : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IConnectContactLensPaginatorFactory Paginators { get; }
#endif
                
        #region  ListRealtimeContactAnalysisSegments



        /// <summary>
        /// Provides a list of analysis segments for a real-time analysis session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRealtimeContactAnalysisSegments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRealtimeContactAnalysisSegments service method, as returned by ConnectContactLens.</returns>
        /// <exception cref="Amazon.ConnectContactLens.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ConnectContactLens.Model.InternalServiceException">
        /// Request processing failed due to an error or failure with the service.
        /// </exception>
        /// <exception cref="Amazon.ConnectContactLens.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.ConnectContactLens.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.ConnectContactLens.Model.ThrottlingException">
        /// The throttling limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/connect-contact-lens-2020-08-21/ListRealtimeContactAnalysisSegments">REST API Reference for ListRealtimeContactAnalysisSegments Operation</seealso>
        Task<ListRealtimeContactAnalysisSegmentsResponse> ListRealtimeContactAnalysisSegmentsAsync(ListRealtimeContactAnalysisSegmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}