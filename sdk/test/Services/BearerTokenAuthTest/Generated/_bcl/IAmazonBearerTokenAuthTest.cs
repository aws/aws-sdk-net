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
 * Do not modify this file. This file is generated from the bearer-token-auth-test-2022-03-21.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.BearerTokenAuthTest.Model;

#pragma warning disable CS1570
namespace Amazon.BearerTokenAuthTest
{
    /// <summary>
    /// <para>Interface for accessing BearerTokenAuthTest</para>
    ///
    /// 
    /// </summary>
    public partial interface IAmazonBearerTokenAuthTest : IAmazonService, IDisposable
    {


        
        #region  InheritBearerAuthOperation


        /// <summary>
        /// Request that inherits the bearer signature version set at the Service
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InheritBearerAuthOperation service method.</param>
        /// 
        /// <returns>The response from the InheritBearerAuthOperation service method, as returned by BearerTokenAuthTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bearer-token-auth-test-2022-03-21/InheritBearerAuthOperation">REST API Reference for InheritBearerAuthOperation Operation</seealso>
        InheritBearerAuthOperationResponse InheritBearerAuthOperation(InheritBearerAuthOperationRequest request);



        /// <summary>
        /// Request that inherits the bearer signature version set at the Service
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InheritBearerAuthOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the InheritBearerAuthOperation service method, as returned by BearerTokenAuthTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bearer-token-auth-test-2022-03-21/InheritBearerAuthOperation">REST API Reference for InheritBearerAuthOperation Operation</seealso>
        Task<InheritBearerAuthOperationResponse> InheritBearerAuthOperationAsync(InheritBearerAuthOperationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  OverrideAuthToSigV4Operation


        /// <summary>
        /// An operation that overrides auth to Sigv4.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the OverrideAuthToSigV4Operation service method.</param>
        /// 
        /// <returns>The response from the OverrideAuthToSigV4Operation service method, as returned by BearerTokenAuthTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bearer-token-auth-test-2022-03-21/OverrideAuthToSigV4Operation">REST API Reference for OverrideAuthToSigV4Operation Operation</seealso>
        OverrideAuthToSigV4OperationResponse OverrideAuthToSigV4Operation(OverrideAuthToSigV4OperationRequest request);



        /// <summary>
        /// An operation that overrides auth to Sigv4.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the OverrideAuthToSigV4Operation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the OverrideAuthToSigV4Operation service method, as returned by BearerTokenAuthTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bearer-token-auth-test-2022-03-21/OverrideAuthToSigV4Operation">REST API Reference for OverrideAuthToSigV4Operation Operation</seealso>
        Task<OverrideAuthToSigV4OperationResponse> OverrideAuthToSigV4OperationAsync(OverrideAuthToSigV4OperationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}