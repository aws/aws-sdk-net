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
 * Do not modify this file. This file is generated from the rbin-2021-06-15.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.RecycleBin.Model;

namespace Amazon.RecycleBin
{
    /// <summary>
    /// Interface for accessing RecycleBin
    ///
    /// This is the <i>Recycle Bin API Reference</i>. This documentation provides descriptions
    /// and syntax for each of the actions and data types in Recycle Bin.
    /// 
    ///  
    /// <para>
    /// Recycle Bin is a resource recovery feature that enables you to restore accidentally
    /// deleted snapshots and EBS-backed AMIs. When using Recycle Bin, if your resources are
    /// deleted, they are retained in the Recycle Bin for a time period that you specify.
    /// </para>
    ///  
    /// <para>
    /// You can restore a resource from the Recycle Bin at any time before its retention period
    /// expires. After you restore a resource from the Recycle Bin, the resource is removed
    /// from the Recycle Bin, and you can then use it in the same way you use any other resource
    /// of that type in your account. If the retention period expires and the resource is
    /// not restored, the resource is permanently deleted from the Recycle Bin and is no longer
    /// available for recovery. For more information about Recycle Bin, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/snapshot-recycle-bin.html">
    /// Recycle Bin</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial interface IAmazonRecycleBin : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IRecycleBinPaginatorFactory Paginators { get; }
#endif


        
        #region  CreateRule


        /// <summary>
        /// Creates a Recycle Bin retention rule. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/recycle-bin-working-with-rules.html#recycle-bin-create-rule">
        /// Create Recycle Bin retention rules</a> in the <i>Amazon Elastic Compute Cloud User
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRule service method.</param>
        /// 
        /// <returns>The response from the CreateRule service method, as returned by RecycleBin.</returns>
        /// <exception cref="Amazon.RecycleBin.Model.InternalServerException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota for the number of tags per resource to be
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ValidationException">
        /// One or more of the parameters in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/CreateRule">REST API Reference for CreateRule Operation</seealso>
        CreateRuleResponse CreateRule(CreateRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRule operation on AmazonRecycleBinClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/CreateRule">REST API Reference for CreateRule Operation</seealso>
        IAsyncResult BeginCreateRule(CreateRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRule.</param>
        /// 
        /// <returns>Returns a  CreateRuleResult from RecycleBin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/CreateRule">REST API Reference for CreateRule Operation</seealso>
        CreateRuleResponse EndCreateRule(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteRule


        /// <summary>
        /// Deletes a Recycle Bin retention rule. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/recycle-bin-working-with-rules.html#recycle-bin-delete-rule">
        /// Delete Recycle Bin retention rules</a> in the <i>Amazon Elastic Compute Cloud User
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRule service method.</param>
        /// 
        /// <returns>The response from the DeleteRule service method, as returned by RecycleBin.</returns>
        /// <exception cref="Amazon.RecycleBin.Model.ConflictException">
        /// The specified retention rule lock request can't be completed.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.InternalServerException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ValidationException">
        /// One or more of the parameters in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        DeleteRuleResponse DeleteRule(DeleteRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRule operation on AmazonRecycleBinClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        IAsyncResult BeginDeleteRule(DeleteRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRule.</param>
        /// 
        /// <returns>Returns a  DeleteRuleResult from RecycleBin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        DeleteRuleResponse EndDeleteRule(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRule


        /// <summary>
        /// Gets information about a Recycle Bin retention rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRule service method.</param>
        /// 
        /// <returns>The response from the GetRule service method, as returned by RecycleBin.</returns>
        /// <exception cref="Amazon.RecycleBin.Model.InternalServerException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ValidationException">
        /// One or more of the parameters in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/GetRule">REST API Reference for GetRule Operation</seealso>
        GetRuleResponse GetRule(GetRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRule operation on AmazonRecycleBinClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/GetRule">REST API Reference for GetRule Operation</seealso>
        IAsyncResult BeginGetRule(GetRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRule.</param>
        /// 
        /// <returns>Returns a  GetRuleResult from RecycleBin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/GetRule">REST API Reference for GetRule Operation</seealso>
        GetRuleResponse EndGetRule(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRules


        /// <summary>
        /// Lists the Recycle Bin retention rules in the Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRules service method.</param>
        /// 
        /// <returns>The response from the ListRules service method, as returned by RecycleBin.</returns>
        /// <exception cref="Amazon.RecycleBin.Model.InternalServerException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ValidationException">
        /// One or more of the parameters in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/ListRules">REST API Reference for ListRules Operation</seealso>
        ListRulesResponse ListRules(ListRulesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRules operation on AmazonRecycleBinClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/ListRules">REST API Reference for ListRules Operation</seealso>
        IAsyncResult BeginListRules(ListRulesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRules.</param>
        /// 
        /// <returns>Returns a  ListRulesResult from RecycleBin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/ListRules">REST API Reference for ListRules Operation</seealso>
        ListRulesResponse EndListRules(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags assigned to a retention rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by RecycleBin.</returns>
        /// <exception cref="Amazon.RecycleBin.Model.InternalServerException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ValidationException">
        /// One or more of the parameters in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonRecycleBinClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from RecycleBin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  LockRule


        /// <summary>
        /// Locks a retention rule. A locked retention rule can't be modified or deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the LockRule service method.</param>
        /// 
        /// <returns>The response from the LockRule service method, as returned by RecycleBin.</returns>
        /// <exception cref="Amazon.RecycleBin.Model.ConflictException">
        /// The specified retention rule lock request can't be completed.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.InternalServerException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ValidationException">
        /// One or more of the parameters in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/LockRule">REST API Reference for LockRule Operation</seealso>
        LockRuleResponse LockRule(LockRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the LockRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the LockRule operation on AmazonRecycleBinClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndLockRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/LockRule">REST API Reference for LockRule Operation</seealso>
        IAsyncResult BeginLockRule(LockRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  LockRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginLockRule.</param>
        /// 
        /// <returns>Returns a  LockRuleResult from RecycleBin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/LockRule">REST API Reference for LockRule Operation</seealso>
        LockRuleResponse EndLockRule(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Assigns tags to the specified retention rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by RecycleBin.</returns>
        /// <exception cref="Amazon.RecycleBin.Model.InternalServerException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota for the number of tags per resource to be
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ValidationException">
        /// One or more of the parameters in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonRecycleBinClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from RecycleBin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UnlockRule


        /// <summary>
        /// Unlocks a retention rule. After a retention rule is unlocked, it can be modified or
        /// deleted only after the unlock delay period expires.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnlockRule service method.</param>
        /// 
        /// <returns>The response from the UnlockRule service method, as returned by RecycleBin.</returns>
        /// <exception cref="Amazon.RecycleBin.Model.ConflictException">
        /// The specified retention rule lock request can't be completed.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.InternalServerException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ValidationException">
        /// One or more of the parameters in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/UnlockRule">REST API Reference for UnlockRule Operation</seealso>
        UnlockRuleResponse UnlockRule(UnlockRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UnlockRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnlockRule operation on AmazonRecycleBinClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUnlockRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/UnlockRule">REST API Reference for UnlockRule Operation</seealso>
        IAsyncResult BeginUnlockRule(UnlockRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UnlockRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUnlockRule.</param>
        /// 
        /// <returns>Returns a  UnlockRuleResult from RecycleBin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/UnlockRule">REST API Reference for UnlockRule Operation</seealso>
        UnlockRuleResponse EndUnlockRule(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Unassigns a tag from a retention rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by RecycleBin.</returns>
        /// <exception cref="Amazon.RecycleBin.Model.InternalServerException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ValidationException">
        /// One or more of the parameters in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonRecycleBinClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from RecycleBin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateRule


        /// <summary>
        /// Updates an existing Recycle Bin retention rule. You can update a retention rule's
        /// description, resource tags, and retention period at any time after creation. You can't
        /// update a retention rule's resource type after creation. For more information, see
        /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/recycle-bin-working-with-rules.html#recycle-bin-update-rule">
        /// Update Recycle Bin retention rules</a> in the <i>Amazon Elastic Compute Cloud User
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRule service method.</param>
        /// 
        /// <returns>The response from the UpdateRule service method, as returned by RecycleBin.</returns>
        /// <exception cref="Amazon.RecycleBin.Model.ConflictException">
        /// The specified retention rule lock request can't be completed.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.InternalServerException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ValidationException">
        /// One or more of the parameters in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/UpdateRule">REST API Reference for UpdateRule Operation</seealso>
        UpdateRuleResponse UpdateRule(UpdateRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRule operation on AmazonRecycleBinClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/UpdateRule">REST API Reference for UpdateRule Operation</seealso>
        IAsyncResult BeginUpdateRule(UpdateRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRule.</param>
        /// 
        /// <returns>Returns a  UpdateRuleResult from RecycleBin.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/UpdateRule">REST API Reference for UpdateRule Operation</seealso>
        UpdateRuleResponse EndUpdateRule(IAsyncResult asyncResult);

        #endregion
        
    }
}