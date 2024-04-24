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
 * Do not modify this file. This file is generated from the use-service-id-2022-07-12.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.UseServiceIdTestserviceId.Model;

#pragma warning disable CS1570
namespace Amazon.UseServiceIdTestserviceId
{
    /// <summary>
    /// <para>Interface for accessing UseServiceIdTestserviceId</para>
    ///
    /// 
    /// </summary>
    public partial interface IAmazonUseServiceIdTestserviceId : IAmazonService, IDisposable
    {




        
        #region  NoPayload


        /// <summary>
        /// Request without a body
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NoPayload service method.</param>
        /// 
        /// <returns>The response from the NoPayload service method, as returned by UseServiceIdTestserviceId.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/use-service-id-2022-07-12/NoPayload">REST API Reference for NoPayload Operation</seealso>
        NoPayloadResponse NoPayload(NoPayloadRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the NoPayload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the NoPayload operation on AmazonUseServiceIdTestserviceIdClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndNoPayload
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/use-service-id-2022-07-12/NoPayload">REST API Reference for NoPayload Operation</seealso>
        IAsyncResult BeginNoPayload(NoPayloadRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  NoPayload operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginNoPayload.</param>
        /// 
        /// <returns>Returns a  NoPayloadResult from UseServiceIdTestserviceId.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/use-service-id-2022-07-12/NoPayload">REST API Reference for NoPayload Operation</seealso>
        NoPayloadResponse EndNoPayload(IAsyncResult asyncResult);

        #endregion
        
    }
}