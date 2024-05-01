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
 * Do not modify this file. This file is generated from the paginators-test-2022-03-14.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.PaginatorsTest.Model;

#pragma warning disable CS1570
namespace Amazon.PaginatorsTest
{
    /// <summary>
    /// <para>Interface for accessing PaginatorsTest</para>
    ///
    /// 
    /// </summary>
    public partial interface IAmazonPaginatorsTest : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IPaginatorsTestPaginatorFactory Paginators { get; }

        
        #region  TestPaginator


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestPaginator service method.</param>
        /// 
        /// <returns>The response from the TestPaginator service method, as returned by PaginatorsTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/paginator-test-2021-03-14/TestPaginator">REST API Reference for TestPaginator Operation</seealso>
        TestPaginatorResponse TestPaginator(TestPaginatorRequest request);



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestPaginator service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TestPaginator service method, as returned by PaginatorsTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/paginator-test-2021-03-14/TestPaginator">REST API Reference for TestPaginator Operation</seealso>
        Task<TestPaginatorResponse> TestPaginatorAsync(TestPaginatorRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}