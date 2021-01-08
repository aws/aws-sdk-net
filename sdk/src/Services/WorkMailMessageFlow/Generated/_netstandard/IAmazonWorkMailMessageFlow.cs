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
 * Do not modify this file. This file is generated from the workmailmessageflow-2019-05-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.WorkMailMessageFlow.Model;

namespace Amazon.WorkMailMessageFlow
{
    /// <summary>
    /// Interface for accessing WorkMailMessageFlow
    ///
    /// The WorkMail Message Flow API provides access to email messages as they are being
    /// sent and received by a WorkMail organization.
    /// </summary>
#if NETSTANDARD13
    [Obsolete("Support for .NET Standard 1.3 is in maintenance mode and will only receive critical bug fixes and security patches. Visit https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/migration-from-net-standard-1-3.html for further details.")]
#endif
    public partial interface IAmazonWorkMailMessageFlow : IAmazonService, IDisposable
    {
                
        #region  GetRawMessageContent



        /// <summary>
        /// Retrieves the raw content of an in-transit email message, in MIME format.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRawMessageContent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRawMessageContent service method, as returned by WorkMailMessageFlow.</returns>
        /// <exception cref="Amazon.WorkMailMessageFlow.Model.ResourceNotFoundException">
        /// The requested email message is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmailmessageflow-2019-05-01/GetRawMessageContent">REST API Reference for GetRawMessageContent Operation</seealso>
        Task<GetRawMessageContentResponse> GetRawMessageContentAsync(GetRawMessageContentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}