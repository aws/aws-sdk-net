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
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.DocumentTypesTest.Model;

namespace Amazon.DocumentTypesTest
{
    /// <summary>
    /// Interface for accessing DocumentTypesTest
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
        /// Initiates the asynchronous execution of the ExecuteQuery operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExecuteQuery operation on AmazonDocumentTypesTestClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExecuteQuery
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/document-types-test-2022-09-16/ExecuteQuery">REST API Reference for ExecuteQuery Operation</seealso>
        IAsyncResult BeginExecuteQuery(ExecuteQueryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ExecuteQuery operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExecuteQuery.</param>
        /// 
        /// <returns>Returns a  ExecuteQueryResult from DocumentTypesTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/document-types-test-2022-09-16/ExecuteQuery">REST API Reference for ExecuteQuery Operation</seealso>
        ExecuteQueryResponse EndExecuteQuery(IAsyncResult asyncResult);

        #endregion
        
    }
}