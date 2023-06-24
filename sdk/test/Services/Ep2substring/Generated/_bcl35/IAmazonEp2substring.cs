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
 * Do not modify this file. This file is generated from the ep2-substring-2022-08-24.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Ep2substring.Model;

namespace Amazon.Ep2substring
{
    /// <summary>
    /// Interface for accessing Ep2substring
    ///
    /// 
    /// </summary>
    public partial interface IAmazonEp2substring : IAmazonService, IDisposable
    {




        
        #region  MyOperation


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MyOperation service method.</param>
        /// 
        /// <returns>The response from the MyOperation service method, as returned by Ep2substring.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ep2-substring-2022-08-24/MyOperation">REST API Reference for MyOperation Operation</seealso>
        MyOperationResponse MyOperation(MyOperationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the MyOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the MyOperation operation on AmazonEp2substringClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndMyOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ep2-substring-2022-08-24/MyOperation">REST API Reference for MyOperation Operation</seealso>
        IAsyncResult BeginMyOperation(MyOperationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  MyOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginMyOperation.</param>
        /// 
        /// <returns>Returns a  MyOperationResult from Ep2substring.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ep2-substring-2022-08-24/MyOperation">REST API Reference for MyOperation Operation</seealso>
        MyOperationResponse EndMyOperation(IAsyncResult asyncResult);

        #endregion
        
    }
}