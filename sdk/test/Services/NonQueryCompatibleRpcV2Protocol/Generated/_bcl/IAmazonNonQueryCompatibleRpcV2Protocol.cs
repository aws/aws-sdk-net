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
 * Do not modify this file. This file is generated from the non-query-compatible-rpcv2-protocol-2025-06-20.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.NonQueryCompatibleRpcV2Protocol.Model;

#pragma warning disable CS1570
namespace Amazon.NonQueryCompatibleRpcV2Protocol
{
    /// <summary>
    /// <para>Interface for accessing NonQueryCompatibleRpcV2Protocol</para>
    ///
    /// 
    /// </summary>
    public partial interface IAmazonNonQueryCompatibleRpcV2Protocol : IAmazonService, IDisposable
    {


        
        #region  NonQueryCompatibleOperation


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NonQueryCompatibleOperation service method.</param>
        /// 
        /// <returns>The response from the NonQueryCompatibleOperation service method, as returned by NonQueryCompatibleRpcV2Protocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/non-query-compatible-rpcv2-protocol-2025-06-20/NonQueryCompatibleOperation">REST API Reference for NonQueryCompatibleOperation Operation</seealso>
        NonQueryCompatibleOperationResponse NonQueryCompatibleOperation(NonQueryCompatibleOperationRequest request);



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NonQueryCompatibleOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the NonQueryCompatibleOperation service method, as returned by NonQueryCompatibleRpcV2Protocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/non-query-compatible-rpcv2-protocol-2025-06-20/NonQueryCompatibleOperation">REST API Reference for NonQueryCompatibleOperation Operation</seealso>
        Task<NonQueryCompatibleOperationResponse> NonQueryCompatibleOperationAsync(NonQueryCompatibleOperationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}