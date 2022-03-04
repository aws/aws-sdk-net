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
 * Do not modify this file. This file is generated from the macie-2017-12-19.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Macie.Model;

namespace Amazon.Macie
{
    /// <summary>
    /// Interface for accessing Macie
    ///
    /// Amazon Macie Classic 
    /// <para>
    /// Amazon Macie Classic has been discontinued and is no longer available.
    /// </para>
    ///  
    /// <para>
    /// A new Amazon Macie is now available with significant design improvements and additional
    /// features, at a lower price and in most Amazon Web Services Regions. We encourage you
    /// to take advantage of the new and improved features, and benefit from the reduced cost.
    /// To learn about features and pricing for the new Macie, see <a href="http://aws.amazon.com/macie/">Amazon
    /// Macie</a>. To learn how to use the new Macie, see the <a href="https://docs.aws.amazon.com/macie/latest/user/what-is-macie.html">Amazon
    /// Macie User Guide</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonMacie : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IMaciePaginatorFactory Paginators { get; }
#endif


        
        #region  AssociateMemberAccount


        /// <summary>
        /// (Discontinued) Associates a specified Amazon Web Services account with Amazon Macie
        /// Classic as a member account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateMemberAccount service method.</param>
        /// 
        /// <returns>The response from the AssociateMemberAccount service method, as returned by Macie.</returns>
        /// <exception cref="Amazon.Macie.Model.InternalException">
        /// (Discontinued) Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Macie.Model.InvalidInputException">
        /// (Discontinued) The request was rejected because an invalid or out-of-range value was
        /// supplied for an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Macie.Model.LimitExceededException">
        /// (Discontinued) The request was rejected because it attempted to create resources beyond
        /// the current Amazon Web Services account quotas. The error code describes the quota
        /// exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/AssociateMemberAccount">REST API Reference for AssociateMemberAccount Operation</seealso>
        AssociateMemberAccountResponse AssociateMemberAccount(AssociateMemberAccountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateMemberAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateMemberAccount operation on AmazonMacieClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateMemberAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/AssociateMemberAccount">REST API Reference for AssociateMemberAccount Operation</seealso>
        IAsyncResult BeginAssociateMemberAccount(AssociateMemberAccountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateMemberAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateMemberAccount.</param>
        /// 
        /// <returns>Returns a  AssociateMemberAccountResult from Macie.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/AssociateMemberAccount">REST API Reference for AssociateMemberAccount Operation</seealso>
        AssociateMemberAccountResponse EndAssociateMemberAccount(IAsyncResult asyncResult);

        #endregion
        
        #region  AssociateS3Resources


        /// <summary>
        /// (Discontinued) Associates specified S3 resources with Amazon Macie Classic for monitoring
        /// and data classification. If <code>memberAccountId</code> isn't specified, the action
        /// associates specified S3 resources with Macie Classic for the current Macie Classic
        /// administrator account. If <code>memberAccountId</code> is specified, the action associates
        /// specified S3 resources with Macie Classic for the specified member account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateS3Resources service method.</param>
        /// 
        /// <returns>The response from the AssociateS3Resources service method, as returned by Macie.</returns>
        /// <exception cref="Amazon.Macie.Model.AccessDeniedException">
        /// (Discontinued) You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Macie.Model.InternalException">
        /// (Discontinued) Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Macie.Model.InvalidInputException">
        /// (Discontinued) The request was rejected because an invalid or out-of-range value was
        /// supplied for an input parameter.
        /// </exception>
        /// <exception cref="Amazon.Macie.Model.LimitExceededException">
        /// (Discontinued) The request was rejected because it attempted to create resources beyond
        /// the current Amazon Web Services account quotas. The error code describes the quota
        /// exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/AssociateS3Resources">REST API Reference for AssociateS3Resources Operation</seealso>
        AssociateS3ResourcesResponse AssociateS3Resources(AssociateS3ResourcesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateS3Resources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateS3Resources operation on AmazonMacieClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateS3Resources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/AssociateS3Resources">REST API Reference for AssociateS3Resources Operation</seealso>
        IAsyncResult BeginAssociateS3Resources(AssociateS3ResourcesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateS3Resources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateS3Resources.</param>
        /// 
        /// <returns>Returns a  AssociateS3ResourcesResult from Macie.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/AssociateS3Resources">REST API Reference for AssociateS3Resources Operation</seealso>
        AssociateS3ResourcesResponse EndAssociateS3Resources(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateMemberAccount


        /// <summary>
        /// (Discontinued) Removes the specified member account from Amazon Macie Classic.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMemberAccount service method.</param>
        /// 
        /// <returns>The response from the DisassociateMemberAccount service method, as returned by Macie.</returns>
        /// <exception cref="Amazon.Macie.Model.InternalException">
        /// (Discontinued) Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Macie.Model.InvalidInputException">
        /// (Discontinued) The request was rejected because an invalid or out-of-range value was
        /// supplied for an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/DisassociateMemberAccount">REST API Reference for DisassociateMemberAccount Operation</seealso>
        DisassociateMemberAccountResponse DisassociateMemberAccount(DisassociateMemberAccountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateMemberAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMemberAccount operation on AmazonMacieClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateMemberAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/DisassociateMemberAccount">REST API Reference for DisassociateMemberAccount Operation</seealso>
        IAsyncResult BeginDisassociateMemberAccount(DisassociateMemberAccountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateMemberAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateMemberAccount.</param>
        /// 
        /// <returns>Returns a  DisassociateMemberAccountResult from Macie.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/DisassociateMemberAccount">REST API Reference for DisassociateMemberAccount Operation</seealso>
        DisassociateMemberAccountResponse EndDisassociateMemberAccount(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateS3Resources


        /// <summary>
        /// (Discontinued) Removes specified S3 resources from being monitored by Amazon Macie
        /// Classic. If <code>memberAccountId</code> isn't specified, the action removes specified
        /// S3 resources from Macie Classic for the current Macie Classic administrator account.
        /// If <code>memberAccountId</code> is specified, the action removes specified S3 resources
        /// from Macie Classic for the specified member account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateS3Resources service method.</param>
        /// 
        /// <returns>The response from the DisassociateS3Resources service method, as returned by Macie.</returns>
        /// <exception cref="Amazon.Macie.Model.AccessDeniedException">
        /// (Discontinued) You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Macie.Model.InternalException">
        /// (Discontinued) Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Macie.Model.InvalidInputException">
        /// (Discontinued) The request was rejected because an invalid or out-of-range value was
        /// supplied for an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/DisassociateS3Resources">REST API Reference for DisassociateS3Resources Operation</seealso>
        DisassociateS3ResourcesResponse DisassociateS3Resources(DisassociateS3ResourcesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateS3Resources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateS3Resources operation on AmazonMacieClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateS3Resources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/DisassociateS3Resources">REST API Reference for DisassociateS3Resources Operation</seealso>
        IAsyncResult BeginDisassociateS3Resources(DisassociateS3ResourcesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateS3Resources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateS3Resources.</param>
        /// 
        /// <returns>Returns a  DisassociateS3ResourcesResult from Macie.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/DisassociateS3Resources">REST API Reference for DisassociateS3Resources Operation</seealso>
        DisassociateS3ResourcesResponse EndDisassociateS3Resources(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMemberAccounts


        /// <summary>
        /// (Discontinued) Lists all Amazon Macie Classic member accounts for the current Macie
        /// Classic administrator account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMemberAccounts service method.</param>
        /// 
        /// <returns>The response from the ListMemberAccounts service method, as returned by Macie.</returns>
        /// <exception cref="Amazon.Macie.Model.InternalException">
        /// (Discontinued) Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Macie.Model.InvalidInputException">
        /// (Discontinued) The request was rejected because an invalid or out-of-range value was
        /// supplied for an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/ListMemberAccounts">REST API Reference for ListMemberAccounts Operation</seealso>
        ListMemberAccountsResponse ListMemberAccounts(ListMemberAccountsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMemberAccounts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMemberAccounts operation on AmazonMacieClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMemberAccounts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/ListMemberAccounts">REST API Reference for ListMemberAccounts Operation</seealso>
        IAsyncResult BeginListMemberAccounts(ListMemberAccountsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMemberAccounts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMemberAccounts.</param>
        /// 
        /// <returns>Returns a  ListMemberAccountsResult from Macie.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/ListMemberAccounts">REST API Reference for ListMemberAccounts Operation</seealso>
        ListMemberAccountsResponse EndListMemberAccounts(IAsyncResult asyncResult);

        #endregion
        
        #region  ListS3Resources


        /// <summary>
        /// (Discontinued) Lists all the S3 resources associated with Amazon Macie Classic. If
        /// <code>memberAccountId</code> isn't specified, the action lists the S3 resources associated
        /// with Macie Classic for the current Macie Classic administrator account. If <code>memberAccountId</code>
        /// is specified, the action lists the S3 resources associated with Macie Classic for
        /// the specified member account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListS3Resources service method.</param>
        /// 
        /// <returns>The response from the ListS3Resources service method, as returned by Macie.</returns>
        /// <exception cref="Amazon.Macie.Model.AccessDeniedException">
        /// (Discontinued) You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Macie.Model.InternalException">
        /// (Discontinued) Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Macie.Model.InvalidInputException">
        /// (Discontinued) The request was rejected because an invalid or out-of-range value was
        /// supplied for an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/ListS3Resources">REST API Reference for ListS3Resources Operation</seealso>
        ListS3ResourcesResponse ListS3Resources(ListS3ResourcesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListS3Resources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListS3Resources operation on AmazonMacieClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListS3Resources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/ListS3Resources">REST API Reference for ListS3Resources Operation</seealso>
        IAsyncResult BeginListS3Resources(ListS3ResourcesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListS3Resources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListS3Resources.</param>
        /// 
        /// <returns>Returns a  ListS3ResourcesResult from Macie.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/ListS3Resources">REST API Reference for ListS3Resources Operation</seealso>
        ListS3ResourcesResponse EndListS3Resources(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateS3Resources


        /// <summary>
        /// (Discontinued) Updates the classification types for the specified S3 resources. If
        /// <code>memberAccountId</code> isn't specified, the action updates the classification
        /// types of the S3 resources associated with Amazon Macie Classic for the current Macie
        /// Classic administrator account. If <code>memberAccountId</code> is specified, the action
        /// updates the classification types of the S3 resources associated with Macie Classic
        /// for the specified member account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateS3Resources service method.</param>
        /// 
        /// <returns>The response from the UpdateS3Resources service method, as returned by Macie.</returns>
        /// <exception cref="Amazon.Macie.Model.AccessDeniedException">
        /// (Discontinued) You do not have required permissions to access the requested resource.
        /// </exception>
        /// <exception cref="Amazon.Macie.Model.InternalException">
        /// (Discontinued) Internal server error.
        /// </exception>
        /// <exception cref="Amazon.Macie.Model.InvalidInputException">
        /// (Discontinued) The request was rejected because an invalid or out-of-range value was
        /// supplied for an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/UpdateS3Resources">REST API Reference for UpdateS3Resources Operation</seealso>
        UpdateS3ResourcesResponse UpdateS3Resources(UpdateS3ResourcesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateS3Resources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateS3Resources operation on AmazonMacieClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateS3Resources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/UpdateS3Resources">REST API Reference for UpdateS3Resources Operation</seealso>
        IAsyncResult BeginUpdateS3Resources(UpdateS3ResourcesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateS3Resources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateS3Resources.</param>
        /// 
        /// <returns>Returns a  UpdateS3ResourcesResult from Macie.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/macie-2017-12-19/UpdateS3Resources">REST API Reference for UpdateS3Resources Operation</seealso>
        UpdateS3ResourcesResponse EndUpdateS3Resources(IAsyncResult asyncResult);

        #endregion
        
    }
}