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
 * Do not modify this file. This file is generated from the query-compatible-json-rpc-10-2020-07-14.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.QueryCompatibleJSONRPC10.Model;

#pragma warning disable CS1570
namespace Amazon.QueryCompatibleJSONRPC10
{
    /// <summary>
    /// <para>Interface for accessing QueryCompatibleJSONRPC10</para>
    ///
    /// 
    /// </summary>
    public partial interface IAmazonQueryCompatibleJSONRPC10 : IAmazonService, IDisposable
    {




        
        #region  QueryCompatibleOperation


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryCompatibleOperation service method.</param>
        /// 
        /// <returns>The response from the QueryCompatibleOperation service method, as returned by QueryCompatibleJSONRPC10.</returns>
        /// <exception cref="Amazon.QueryCompatibleJSONRPC10.Model.CustomCodeErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.QueryCompatibleJSONRPC10.Model.NoCustomCodeErrorException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-compatible-json-rpc-10-2020-07-14/QueryCompatibleOperation">REST API Reference for QueryCompatibleOperation Operation</seealso>
        QueryCompatibleOperationResponse QueryCompatibleOperation(QueryCompatibleOperationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the QueryCompatibleOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the QueryCompatibleOperation operation on AmazonQueryCompatibleJSONRPC10Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndQueryCompatibleOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-compatible-json-rpc-10-2020-07-14/QueryCompatibleOperation">REST API Reference for QueryCompatibleOperation Operation</seealso>
        IAsyncResult BeginQueryCompatibleOperation(QueryCompatibleOperationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  QueryCompatibleOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginQueryCompatibleOperation.</param>
        /// 
        /// <returns>Returns a  QueryCompatibleOperationResult from QueryCompatibleJSONRPC10.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-compatible-json-rpc-10-2020-07-14/QueryCompatibleOperation">REST API Reference for QueryCompatibleOperation Operation</seealso>
        QueryCompatibleOperationResponse EndQueryCompatibleOperation(IAsyncResult asyncResult);

        #endregion
        
    }
}