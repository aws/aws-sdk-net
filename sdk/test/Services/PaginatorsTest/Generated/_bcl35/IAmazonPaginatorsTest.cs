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
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.PaginatorsTest.Model;

namespace Amazon.PaginatorsTest
{
    /// <summary>
    /// Interface for accessing PaginatorsTest
    ///
    /// 
    /// </summary>
    public partial interface IAmazonPaginatorsTest : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IPaginatorsTestPaginatorFactory Paginators { get; }
#endif


        
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
        /// Initiates the asynchronous execution of the TestPaginator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestPaginator operation on AmazonPaginatorsTestClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTestPaginator
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/paginator-test-2021-03-14/TestPaginator">REST API Reference for TestPaginator Operation</seealso>
        IAsyncResult BeginTestPaginator(TestPaginatorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TestPaginator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTestPaginator.</param>
        /// 
        /// <returns>Returns a  TestPaginatorResult from PaginatorsTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/paginator-test-2021-03-14/TestPaginator">REST API Reference for TestPaginator Operation</seealso>
        TestPaginatorResponse EndTestPaginator(IAsyncResult asyncResult);

        #endregion
        
    }
}