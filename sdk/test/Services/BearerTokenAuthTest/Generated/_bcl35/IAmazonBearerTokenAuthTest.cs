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
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.BearerTokenAuthTest.Model;

namespace Amazon.BearerTokenAuthTest
{
    /// <summary>
    /// Interface for accessing BearerTokenAuthTest
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
        /// Initiates the asynchronous execution of the InheritBearerAuthOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InheritBearerAuthOperation operation on AmazonBearerTokenAuthTestClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndInheritBearerAuthOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bearer-token-auth-test-2022-03-21/InheritBearerAuthOperation">REST API Reference for InheritBearerAuthOperation Operation</seealso>
        IAsyncResult BeginInheritBearerAuthOperation(InheritBearerAuthOperationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  InheritBearerAuthOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInheritBearerAuthOperation.</param>
        /// 
        /// <returns>Returns a  InheritBearerAuthOperationResult from BearerTokenAuthTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bearer-token-auth-test-2022-03-21/InheritBearerAuthOperation">REST API Reference for InheritBearerAuthOperation Operation</seealso>
        InheritBearerAuthOperationResponse EndInheritBearerAuthOperation(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the OverrideAuthToSigV4Operation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the OverrideAuthToSigV4Operation operation on AmazonBearerTokenAuthTestClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndOverrideAuthToSigV4Operation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bearer-token-auth-test-2022-03-21/OverrideAuthToSigV4Operation">REST API Reference for OverrideAuthToSigV4Operation Operation</seealso>
        IAsyncResult BeginOverrideAuthToSigV4Operation(OverrideAuthToSigV4OperationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  OverrideAuthToSigV4Operation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginOverrideAuthToSigV4Operation.</param>
        /// 
        /// <returns>Returns a  OverrideAuthToSigV4OperationResult from BearerTokenAuthTest.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bearer-token-auth-test-2022-03-21/OverrideAuthToSigV4Operation">REST API Reference for OverrideAuthToSigV4Operation Operation</seealso>
        OverrideAuthToSigV4OperationResponse EndOverrideAuthToSigV4Operation(IAsyncResult asyncResult);

        #endregion
        
    }
}