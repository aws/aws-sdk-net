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
 * Do not modify this file. This file is generated from the ep2-host-label-2022-08-24.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Ep2hostlabel.Model;

namespace Amazon.Ep2hostlabel
{
    /// <summary>
    /// Interface for accessing Ep2hostlabel
    ///
    /// 
    /// </summary>
    public partial interface IAmazonEp2hostlabel : IAmazonService, IDisposable
    {
                
        #region  MyOperation



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MyOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the MyOperation service method, as returned by Ep2hostlabel.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ep2-host-label-2022-08-24/MyOperation">REST API Reference for MyOperation Operation</seealso>
        Task<MyOperationResponse> MyOperationAsync(MyOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}