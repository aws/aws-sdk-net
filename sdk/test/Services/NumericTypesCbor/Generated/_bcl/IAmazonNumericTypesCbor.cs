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
 * Do not modify this file. This file is generated from the numerictypescbor-2026-10-26.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.NumericTypesCbor.Model;

#pragma warning disable CS1570
namespace Amazon.NumericTypesCbor
{
    /// <summary>
    /// <para>Interface for accessing NumericTypesCbor</para>
    ///
    /// 
    /// </summary>
    public partial interface IAmazonNumericTypesCbor : IAmazonService, IDisposable
    {


        
        #region  BodyNumbers


        /// <summary>
        /// Sends and receives every numeric type in the request and response bodies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BodyNumbers service method.</param>
        /// 
        /// <returns>The response from the BodyNumbers service method, as returned by NumericTypesCbor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/numerictypescbor-2026-10-26/BodyNumbers">REST API Reference for BodyNumbers Operation</seealso>
        BodyNumbersResponse BodyNumbers(BodyNumbersRequest request);



        /// <summary>
        /// Sends and receives every numeric type in the request and response bodies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BodyNumbers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BodyNumbers service method, as returned by NumericTypesCbor.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/numerictypescbor-2026-10-26/BodyNumbers">REST API Reference for BodyNumbers Operation</seealso>
        Task<BodyNumbersResponse> BodyNumbersAsync(BodyNumbersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}