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
 * Do not modify this file. This file is generated from the aws-query-compatible-2012-11-05.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.QueryCompatible.Model;

#pragma warning disable CS1570
namespace Amazon.QueryCompatible
{
    /// <summary>
    /// <para>Interface for accessing QueryCompatible</para>
    ///
    /// 
    /// </summary>
    public partial interface IAmazonQueryCompatible : IAmazonService, IDisposable
    {




        
        #region  CreateQueue


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateQueue service method.</param>
        /// 
        /// <returns>The response from the CreateQueue service method, as returned by QueryCompatible.</returns>
        /// <exception cref="Amazon.QueryCompatible.Model.QueueDeletedRecentlyException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.QueryCompatible.Model.QueueNameExistsException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/aws-query-compatible-2012-11-05/CreateQueue">REST API Reference for CreateQueue Operation</seealso>
        CreateQueueResponse CreateQueue(CreateQueueRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateQueue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateQueue operation on AmazonQueryCompatibleClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateQueue
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/aws-query-compatible-2012-11-05/CreateQueue">REST API Reference for CreateQueue Operation</seealso>
        IAsyncResult BeginCreateQueue(CreateQueueRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateQueue operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateQueue.</param>
        /// 
        /// <returns>Returns a  CreateQueueResult from QueryCompatible.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/aws-query-compatible-2012-11-05/CreateQueue">REST API Reference for CreateQueue Operation</seealso>
        CreateQueueResponse EndCreateQueue(IAsyncResult asyncResult);

        #endregion
        
        #region  MemberRefOp


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MemberRefOp service method.</param>
        /// 
        /// <returns>The response from the MemberRefOp service method, as returned by QueryCompatible.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/aws-query-compatible-2012-11-05/MemberRefOp">REST API Reference for MemberRefOp Operation</seealso>
        MemberRefOpResponse MemberRefOp(MemberRefOpRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the MemberRefOp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the MemberRefOp operation on AmazonQueryCompatibleClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndMemberRefOp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/aws-query-compatible-2012-11-05/MemberRefOp">REST API Reference for MemberRefOp Operation</seealso>
        IAsyncResult BeginMemberRefOp(MemberRefOpRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  MemberRefOp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginMemberRefOp.</param>
        /// 
        /// <returns>Returns a  MemberRefOpResult from QueryCompatible.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/aws-query-compatible-2012-11-05/MemberRefOp">REST API Reference for MemberRefOp Operation</seealso>
        MemberRefOpResponse EndMemberRefOp(IAsyncResult asyncResult);

        #endregion
        
        #region  StaticOp


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StaticOp service method.</param>
        /// 
        /// <returns>The response from the StaticOp service method, as returned by QueryCompatible.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/aws-query-compatible-2012-11-05/StaticOp">REST API Reference for StaticOp Operation</seealso>
        StaticOpResponse StaticOp(StaticOpRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StaticOp operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StaticOp operation on AmazonQueryCompatibleClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStaticOp
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/aws-query-compatible-2012-11-05/StaticOp">REST API Reference for StaticOp Operation</seealso>
        IAsyncResult BeginStaticOp(StaticOpRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StaticOp operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStaticOp.</param>
        /// 
        /// <returns>Returns a  StaticOpResult from QueryCompatible.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/aws-query-compatible-2012-11-05/StaticOp">REST API Reference for StaticOp Operation</seealso>
        StaticOpResponse EndStaticOp(IAsyncResult asyncResult);

        #endregion
        
    }
}