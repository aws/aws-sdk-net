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
 * Do not modify this file. This file is generated from the echo-service-2020-07-02.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Echo.Model;

#pragma warning disable CS1570
namespace Amazon.Echo
{
    /// <summary>
    /// <para>Interface for accessing Echo</para>
    ///
    /// 
    /// </summary>
    public partial interface IAmazonEcho : IAmazonService, IDisposable
    {


        
        #region  EchoOperation


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EchoOperation service method.</param>
        /// 
        /// <returns>The response from the EchoOperation service method, as returned by Echo.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/echo-2020-07-02/EchoOperation">REST API Reference for EchoOperation Operation</seealso>
        EchoOperationResponse EchoOperation(EchoOperationRequest request);



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EchoOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EchoOperation service method, as returned by Echo.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/echo-2020-07-02/EchoOperation">REST API Reference for EchoOperation Operation</seealso>
        Task<EchoOperationResponse> EchoOperationAsync(EchoOperationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}