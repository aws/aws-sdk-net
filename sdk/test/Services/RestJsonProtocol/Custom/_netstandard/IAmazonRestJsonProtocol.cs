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

using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.RestJsonProtocol.Model;

#pragma warning disable CS1570
namespace Amazon.RestJsonProtocol
{
    #region  SparseJsonMaps

    /// <summary>
    /// <para>Interface for accessing RestJsonProtocol</para>
    ///
    /// A REST JSON service that sends JSON requests and responses.
    /// </summary>
    public partial interface IAmazonRestJsonProtocol : IAmazonService, IDisposable
    {
        #region  SparseJsonMaps



        /// <summary>
        /// The example tests serialization of JSON map values in sparse maps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SparseJsonMaps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SparseJsonMaps service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/SparseJsonMaps">REST API Reference for SparseJsonMaps Operation</seealso>
        Task<SparseJsonMapsResponse> SparseJsonMapsAsync(SparseJsonMapsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
    }

    #endregion
}