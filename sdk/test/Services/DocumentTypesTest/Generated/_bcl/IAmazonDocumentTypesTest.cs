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
 * Do not modify this file. This file is generated from the document-types-test-2022-09-16.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.DocumentTypesTest.Model;

#pragma warning disable CS1570
namespace Amazon.DocumentTypesTest
{
    /// <summary>
    /// <para>Interface for accessing DocumentTypesTest</para>
    ///
    /// 
    /// </summary>
    public partial interface IAmazonDocumentTypesTest : IAmazonService, IDisposable
    {


        
        #region  ExecuteQuery


        /// <summary>
        /// Execute Query
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteQuery service method.</param>
        /// 
        /// <returns>The response from the ExecuteQuery service method, as returned by DocumentTypesTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/document-types-test-2022-09-16/ExecuteQuery">REST API Reference for ExecuteQuery Operation</seealso>
        ExecuteQueryResponse ExecuteQuery(ExecuteQueryRequest request);



        /// <summary>
        /// Execute Query
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExecuteQuery service method, as returned by DocumentTypesTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/document-types-test-2022-09-16/ExecuteQuery">REST API Reference for ExecuteQuery Operation</seealso>
        Task<ExecuteQueryResponse> ExecuteQueryAsync(ExecuteQueryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}