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
 * Do not modify this file. This file is generated from the query-compatible-rpcv2-protocol-2025-06-20.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.QueryCompatibleRpcV2Protocol.Model;

#pragma warning disable CS1570
namespace Amazon.QueryCompatibleRpcV2Protocol
{
    /// <summary>
    /// <para>Interface for accessing QueryCompatibleRpcV2Protocol</para>
    ///
    /// 
    /// </summary>
    public partial interface IAmazonQueryCompatibleRpcV2Protocol : IAmazonService, IDisposable
    {


        
        #region  QueryCompatibleOperation


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryCompatibleOperation service method.</param>
        /// 
        /// <returns>The response from the QueryCompatibleOperation service method, as returned by QueryCompatibleRpcV2Protocol.</returns>
        /// <exception cref="Amazon.QueryCompatibleRpcV2Protocol.Model.CustomCodeErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.QueryCompatibleRpcV2Protocol.Model.NoCustomCodeErrorException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-compatible-rpcv2-protocol-2025-06-20/QueryCompatibleOperation">REST API Reference for QueryCompatibleOperation Operation</seealso>
        QueryCompatibleOperationResponse QueryCompatibleOperation(QueryCompatibleOperationRequest request);



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryCompatibleOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the QueryCompatibleOperation service method, as returned by QueryCompatibleRpcV2Protocol.</returns>
        /// <exception cref="Amazon.QueryCompatibleRpcV2Protocol.Model.CustomCodeErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.QueryCompatibleRpcV2Protocol.Model.NoCustomCodeErrorException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-compatible-rpcv2-protocol-2025-06-20/QueryCompatibleOperation">REST API Reference for QueryCompatibleOperation Operation</seealso>
        Task<QueryCompatibleOperationResponse> QueryCompatibleOperationAsync(QueryCompatibleOperationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}