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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.QBusiness.Model;

#pragma warning disable CS1570
namespace Amazon.QBusiness
{
    /// <summary>
    /// <para>Interface for accessing QBusiness</para>
    ///
    /// This is the <i>Amazon Q Business</i> API Reference. Amazon Q Business is a fully managed,
    /// generative-AI powered enterprise chat assistant that you can deploy within your organization.
    /// Amazon Q Business enhances employee productivity by supporting key tasks such as question-answering,
    /// knowledge discovery, writing email messages, summarizing text, drafting document outlines,
    /// and brainstorming ideas. Users ask questions of Amazon Q Business and get answers
    /// that are presented in a conversational manner. For an introduction to the service,
    /// see the <a href="https://docs.aws.amazon.com/amazonq/latest/business-use-dg/what-is.html">
    /// <i>Amazon Q Business User Guide</i> </a>.
    /// 
    ///  
    /// <para>
    /// For an overview of the Amazon Q Business APIs, see <a href="https://docs.aws.amazon.com/amazonq/latest/business-use-dg/api-ref.html#api-overview">Overview
    /// of Amazon Q Business API operations</a>.
    /// </para>
    ///  
    /// <para>
    /// For information about the IAM access control permissions you need to use this API,
    /// see <a href="https://docs.aws.amazon.com/amazonq/latest/business-use-dg/iam-roles.html">IAM
    /// roles for Amazon Q Business</a> in the <i>Amazon Q Business User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// The following resources provide additional information about using the Amazon Q Business
    /// API:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <i> <a href="https://docs.aws.amazon.com/amazonq/latest/business-use-dg/setting-up.html">Setting
    /// up for Amazon Q Business</a> </i> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i> <a href="https://awscli.amazonaws.com/v2/documentation/api/latest/reference/qbusiness/index.html">Amazon
    /// Q Business CLI Reference</a> </i> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i> <a href="https://docs.aws.amazon.com/general/latest/gr/amazonq.html">Amazon Web
    /// Services General Reference</a> </i> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonQBusiness : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IQBusinessPaginatorFactory Paginators { get; }
#endif


        
        #region  AssociatePermission


        /// <summary>
        /// Adds or updates a permission policy for a Amazon Q Business application, allowing
        /// cross-account access for an ISV. This operation creates a new policy statement for
        /// the specified Amazon Q Business application. The policy statement defines the IAM
        /// actions that the ISV is allowed to perform on the Amazon Q Business application's
        /// resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociatePermission service method.</param>
        /// 
        /// <returns>The response from the AssociatePermission service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Q Business service.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/AssociatePermission">REST API Reference for AssociatePermission Operation</seealso>
        AssociatePermissionResponse AssociatePermission(AssociatePermissionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociatePermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociatePermission operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociatePermission
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/AssociatePermission">REST API Reference for AssociatePermission Operation</seealso>
        IAsyncResult BeginAssociatePermission(AssociatePermissionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociatePermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociatePermission.</param>
        /// 
        /// <returns>Returns a  AssociatePermissionResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/AssociatePermission">REST API Reference for AssociatePermission Operation</seealso>
        AssociatePermissionResponse EndAssociatePermission(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchDeleteDocument


        /// <summary>
        /// Asynchronously deletes one or more documents added using the <c>BatchPutDocument</c>
        /// API from an Amazon Q Business index.
        /// 
        ///  
        /// <para>
        /// You can see the progress of the deletion, and any error messages related to the process,
        /// by using CloudWatch.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteDocument service method.</param>
        /// 
        /// <returns>The response from the BatchDeleteDocument service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/BatchDeleteDocument">REST API Reference for BatchDeleteDocument Operation</seealso>
        BatchDeleteDocumentResponse BatchDeleteDocument(BatchDeleteDocumentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeleteDocument operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteDocument operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDeleteDocument
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/BatchDeleteDocument">REST API Reference for BatchDeleteDocument Operation</seealso>
        IAsyncResult BeginBatchDeleteDocument(BatchDeleteDocumentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDeleteDocument operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDeleteDocument.</param>
        /// 
        /// <returns>Returns a  BatchDeleteDocumentResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/BatchDeleteDocument">REST API Reference for BatchDeleteDocument Operation</seealso>
        BatchDeleteDocumentResponse EndBatchDeleteDocument(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchPutDocument


        /// <summary>
        /// Adds one or more documents to an Amazon Q Business index.
        /// 
        ///  
        /// <para>
        /// You use this API to:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// ingest your structured and unstructured documents and documents stored in an Amazon
        /// S3 bucket into an Amazon Q Business index.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// add custom attributes to documents in an Amazon Q Business index.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// attach an access control list to the documents added to an Amazon Q Business index.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can see the progress of the deletion, and any error messages related to the process,
        /// by using CloudWatch.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchPutDocument service method.</param>
        /// 
        /// <returns>The response from the BatchPutDocument service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Q Business service.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/BatchPutDocument">REST API Reference for BatchPutDocument Operation</seealso>
        BatchPutDocumentResponse BatchPutDocument(BatchPutDocumentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchPutDocument operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchPutDocument operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchPutDocument
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/BatchPutDocument">REST API Reference for BatchPutDocument Operation</seealso>
        IAsyncResult BeginBatchPutDocument(BatchPutDocumentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchPutDocument operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchPutDocument.</param>
        /// 
        /// <returns>Returns a  BatchPutDocumentResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/BatchPutDocument">REST API Reference for BatchPutDocument Operation</seealso>
        BatchPutDocumentResponse EndBatchPutDocument(IAsyncResult asyncResult);

        #endregion
        
        #region  CancelSubscription


        /// <summary>
        /// Unsubscribes a user or a group from their pricing tier in an Amazon Q Business application.
        /// An unsubscribed user or group loses all Amazon Q Business feature access at the start
        /// of next month.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelSubscription service method.</param>
        /// 
        /// <returns>The response from the CancelSubscription service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CancelSubscription">REST API Reference for CancelSubscription Operation</seealso>
        CancelSubscriptionResponse CancelSubscription(CancelSubscriptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelSubscription operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CancelSubscription">REST API Reference for CancelSubscription Operation</seealso>
        IAsyncResult BeginCancelSubscription(CancelSubscriptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelSubscription.</param>
        /// 
        /// <returns>Returns a  CancelSubscriptionResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CancelSubscription">REST API Reference for CancelSubscription Operation</seealso>
        CancelSubscriptionResponse EndCancelSubscription(IAsyncResult asyncResult);

        #endregion
        
        #region  ChatSync


        /// <summary>
        /// Starts or continues a non-streaming Amazon Q Business conversation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ChatSync service method.</param>
        /// 
        /// <returns>The response from the ChatSync service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ExternalResourceException">
        /// An external resource that you configured with your application is returning errors
        /// and preventing this operation from succeeding. Fix those errors and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.LicenseNotFoundException">
        /// You don't have permissions to perform the action because your license is inactive.
        /// Ask your admin to activate your license and try again after your licence is active.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ChatSync">REST API Reference for ChatSync Operation</seealso>
        ChatSyncResponse ChatSync(ChatSyncRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ChatSync operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ChatSync operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndChatSync
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ChatSync">REST API Reference for ChatSync Operation</seealso>
        IAsyncResult BeginChatSync(ChatSyncRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ChatSync operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginChatSync.</param>
        /// 
        /// <returns>Returns a  ChatSyncResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ChatSync">REST API Reference for ChatSync Operation</seealso>
        ChatSyncResponse EndChatSync(IAsyncResult asyncResult);

        #endregion
        
        #region  CheckDocumentAccess


        /// <summary>
        /// Verifies if a user has access permissions for a specified document and returns the
        /// actual ACL attached to the document. Resolves user access on the document via user
        /// aliases and groups when verifying user access.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CheckDocumentAccess service method.</param>
        /// 
        /// <returns>The response from the CheckDocumentAccess service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CheckDocumentAccess">REST API Reference for CheckDocumentAccess Operation</seealso>
        CheckDocumentAccessResponse CheckDocumentAccess(CheckDocumentAccessRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CheckDocumentAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CheckDocumentAccess operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCheckDocumentAccess
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CheckDocumentAccess">REST API Reference for CheckDocumentAccess Operation</seealso>
        IAsyncResult BeginCheckDocumentAccess(CheckDocumentAccessRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CheckDocumentAccess operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCheckDocumentAccess.</param>
        /// 
        /// <returns>Returns a  CheckDocumentAccessResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CheckDocumentAccess">REST API Reference for CheckDocumentAccess Operation</seealso>
        CheckDocumentAccessResponse EndCheckDocumentAccess(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateAnonymousWebExperienceUrl


        /// <summary>
        /// Creates a unique URL for anonymous Amazon Q Business web experience. This URL can
        /// only be used once and must be used within 5 minutes after it's generated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAnonymousWebExperienceUrl service method.</param>
        /// 
        /// <returns>The response from the CreateAnonymousWebExperienceUrl service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Q Business service.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateAnonymousWebExperienceUrl">REST API Reference for CreateAnonymousWebExperienceUrl Operation</seealso>
        CreateAnonymousWebExperienceUrlResponse CreateAnonymousWebExperienceUrl(CreateAnonymousWebExperienceUrlRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAnonymousWebExperienceUrl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAnonymousWebExperienceUrl operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAnonymousWebExperienceUrl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateAnonymousWebExperienceUrl">REST API Reference for CreateAnonymousWebExperienceUrl Operation</seealso>
        IAsyncResult BeginCreateAnonymousWebExperienceUrl(CreateAnonymousWebExperienceUrlRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAnonymousWebExperienceUrl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAnonymousWebExperienceUrl.</param>
        /// 
        /// <returns>Returns a  CreateAnonymousWebExperienceUrlResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateAnonymousWebExperienceUrl">REST API Reference for CreateAnonymousWebExperienceUrl Operation</seealso>
        CreateAnonymousWebExperienceUrlResponse EndCreateAnonymousWebExperienceUrl(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateApplication


        /// <summary>
        /// Creates an Amazon Q Business application.
        /// 
        ///  <note> 
        /// <para>
        /// There are new tiers for Amazon Q Business. Not all features in Amazon Q Business Pro
        /// are also available in Amazon Q Business Lite. For information on what's included in
        /// Amazon Q Business Lite and what's included in Amazon Q Business Pro, see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/tiers.html#user-sub-tiers">Amazon
        /// Q Business tiers</a>. You must use the Amazon Q Business console to assign subscription
        /// tiers to users. 
        /// </para>
        ///  
        /// <para>
        /// An Amazon Q Apps service linked role will be created if it's absent in the Amazon
        /// Web Services account when <c>QAppsConfiguration</c> is enabled in the request. For
        /// more information, see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/using-service-linked-roles-qapps.html">
        /// Using service-linked roles for Q Apps</a>.
        /// </para>
        ///  
        /// <para>
        /// When you create an application, Amazon Q Business may securely transmit data for processing
        /// from your selected Amazon Web Services region, but within your geography. For more
        /// information, see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/cross-region-inference.html">Cross
        /// region inference in Amazon Q Business</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Q Business service.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        CreateApplicationResponse CreateApplication(CreateApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        IAsyncResult BeginCreateApplication(CreateApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApplication.</param>
        /// 
        /// <returns>Returns a  CreateApplicationResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        CreateApplicationResponse EndCreateApplication(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateChatResponseConfiguration


        /// <summary>
        /// Creates a new chat response configuration for an Amazon Q Business application. This
        /// operation establishes a set of parameters that define how the system generates and
        /// formats responses to user queries in chat interactions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChatResponseConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateChatResponseConfiguration service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Q Business service.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateChatResponseConfiguration">REST API Reference for CreateChatResponseConfiguration Operation</seealso>
        CreateChatResponseConfigurationResponse CreateChatResponseConfiguration(CreateChatResponseConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateChatResponseConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateChatResponseConfiguration operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateChatResponseConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateChatResponseConfiguration">REST API Reference for CreateChatResponseConfiguration Operation</seealso>
        IAsyncResult BeginCreateChatResponseConfiguration(CreateChatResponseConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateChatResponseConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateChatResponseConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateChatResponseConfigurationResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateChatResponseConfiguration">REST API Reference for CreateChatResponseConfiguration Operation</seealso>
        CreateChatResponseConfigurationResponse EndCreateChatResponseConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDataAccessor


        /// <summary>
        /// Creates a new data accessor for an ISV to access data from a Amazon Q Business application.
        /// The data accessor is an entity that represents the ISV's access to the Amazon Q Business
        /// application's data. It includes the IAM role ARN for the ISV, a friendly name, and
        /// a set of action configurations that define the specific actions the ISV is allowed
        /// to perform and any associated data filters. When the data accessor is created, an
        /// IAM Identity Center application is also created to manage the ISV's identity and authentication
        /// for accessing the Amazon Q Business application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataAccessor service method.</param>
        /// 
        /// <returns>The response from the CreateDataAccessor service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Q Business service.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateDataAccessor">REST API Reference for CreateDataAccessor Operation</seealso>
        CreateDataAccessorResponse CreateDataAccessor(CreateDataAccessorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataAccessor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataAccessor operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataAccessor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateDataAccessor">REST API Reference for CreateDataAccessor Operation</seealso>
        IAsyncResult BeginCreateDataAccessor(CreateDataAccessorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataAccessor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataAccessor.</param>
        /// 
        /// <returns>Returns a  CreateDataAccessorResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateDataAccessor">REST API Reference for CreateDataAccessor Operation</seealso>
        CreateDataAccessorResponse EndCreateDataAccessor(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDataSource


        /// <summary>
        /// Creates a data source connector for an Amazon Q Business application.
        /// 
        ///  
        /// <para>
        ///  <c>CreateDataSource</c> is a synchronous operation. The operation returns 200 if
        /// the data source was successfully created. Otherwise, an exception is raised.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSource service method.</param>
        /// 
        /// <returns>The response from the CreateDataSource service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Q Business service.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateDataSource">REST API Reference for CreateDataSource Operation</seealso>
        CreateDataSourceResponse CreateDataSource(CreateDataSourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDataSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSource operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDataSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateDataSource">REST API Reference for CreateDataSource Operation</seealso>
        IAsyncResult BeginCreateDataSource(CreateDataSourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDataSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDataSource.</param>
        /// 
        /// <returns>Returns a  CreateDataSourceResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateDataSource">REST API Reference for CreateDataSource Operation</seealso>
        CreateDataSourceResponse EndCreateDataSource(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateIndex


        /// <summary>
        /// Creates an Amazon Q Business index.
        /// 
        ///  
        /// <para>
        /// To determine if index creation has completed, check the <c>Status</c> field returned
        /// from a call to <c>DescribeIndex</c>. The <c>Status</c> field is set to <c>ACTIVE</c>
        /// when the index is ready to use.
        /// </para>
        ///  
        /// <para>
        /// Once the index is active, you can index your documents using the <a href="https://docs.aws.amazon.com/amazonq/latest/api-reference/API_BatchPutDocument.html">
        /// <c>BatchPutDocument</c> </a> API or the <a href="https://docs.aws.amazon.com/amazonq/latest/api-reference/API_CreateDataSource.html">
        /// <c>CreateDataSource</c> </a> API.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIndex service method.</param>
        /// 
        /// <returns>The response from the CreateIndex service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Q Business service.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateIndex">REST API Reference for CreateIndex Operation</seealso>
        CreateIndexResponse CreateIndex(CreateIndexRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateIndex operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIndex operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateIndex
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateIndex">REST API Reference for CreateIndex Operation</seealso>
        IAsyncResult BeginCreateIndex(CreateIndexRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateIndex operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateIndex.</param>
        /// 
        /// <returns>Returns a  CreateIndexResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateIndex">REST API Reference for CreateIndex Operation</seealso>
        CreateIndexResponse EndCreateIndex(IAsyncResult asyncResult);

        #endregion
        
        #region  CreatePlugin


        /// <summary>
        /// Creates an Amazon Q Business plugin.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePlugin service method.</param>
        /// 
        /// <returns>The response from the CreatePlugin service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Q Business service.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreatePlugin">REST API Reference for CreatePlugin Operation</seealso>
        CreatePluginResponse CreatePlugin(CreatePluginRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePlugin operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePlugin operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePlugin
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreatePlugin">REST API Reference for CreatePlugin Operation</seealso>
        IAsyncResult BeginCreatePlugin(CreatePluginRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePlugin operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePlugin.</param>
        /// 
        /// <returns>Returns a  CreatePluginResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreatePlugin">REST API Reference for CreatePlugin Operation</seealso>
        CreatePluginResponse EndCreatePlugin(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateRetriever


        /// <summary>
        /// Adds a retriever to your Amazon Q Business application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRetriever service method.</param>
        /// 
        /// <returns>The response from the CreateRetriever service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Q Business service.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateRetriever">REST API Reference for CreateRetriever Operation</seealso>
        CreateRetrieverResponse CreateRetriever(CreateRetrieverRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRetriever operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRetriever operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRetriever
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateRetriever">REST API Reference for CreateRetriever Operation</seealso>
        IAsyncResult BeginCreateRetriever(CreateRetrieverRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRetriever operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRetriever.</param>
        /// 
        /// <returns>Returns a  CreateRetrieverResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateRetriever">REST API Reference for CreateRetriever Operation</seealso>
        CreateRetrieverResponse EndCreateRetriever(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSubscription


        /// <summary>
        /// Subscribes an IAM Identity Center user or a group to a pricing tier for an Amazon
        /// Q Business application.
        /// 
        ///  
        /// <para>
        /// Amazon Q Business offers two subscription tiers: <c>Q_LITE</c> and <c>Q_BUSINESS</c>.
        /// Subscription tier determines feature access for the user. For more information on
        /// subscriptions and pricing tiers, see <a href="https://aws.amazon.com/q/business/pricing/">Amazon
        /// Q Business pricing</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// For an example IAM role policy for assigning subscriptions, see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/setting-up.html#permissions">Set
        /// up required permissions</a> in the Amazon Q Business User Guide.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscription service method.</param>
        /// 
        /// <returns>The response from the CreateSubscription service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateSubscription">REST API Reference for CreateSubscription Operation</seealso>
        CreateSubscriptionResponse CreateSubscription(CreateSubscriptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSubscription operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateSubscription">REST API Reference for CreateSubscription Operation</seealso>
        IAsyncResult BeginCreateSubscription(CreateSubscriptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSubscription.</param>
        /// 
        /// <returns>Returns a  CreateSubscriptionResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateSubscription">REST API Reference for CreateSubscription Operation</seealso>
        CreateSubscriptionResponse EndCreateSubscription(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateUser


        /// <summary>
        /// Creates a universally unique identifier (UUID) mapped to a list of local user ids
        /// within an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUser service method.</param>
        /// 
        /// <returns>The response from the CreateUser service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Q Business service.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateUser">REST API Reference for CreateUser Operation</seealso>
        CreateUserResponse CreateUser(CreateUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUser operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateUser">REST API Reference for CreateUser Operation</seealso>
        IAsyncResult BeginCreateUser(CreateUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUser.</param>
        /// 
        /// <returns>Returns a  CreateUserResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateUser">REST API Reference for CreateUser Operation</seealso>
        CreateUserResponse EndCreateUser(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateWebExperience


        /// <summary>
        /// Creates an Amazon Q Business web experience.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWebExperience service method.</param>
        /// 
        /// <returns>The response from the CreateWebExperience service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Q Business service.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateWebExperience">REST API Reference for CreateWebExperience Operation</seealso>
        CreateWebExperienceResponse CreateWebExperience(CreateWebExperienceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWebExperience operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWebExperience operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWebExperience
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateWebExperience">REST API Reference for CreateWebExperience Operation</seealso>
        IAsyncResult BeginCreateWebExperience(CreateWebExperienceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWebExperience operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWebExperience.</param>
        /// 
        /// <returns>Returns a  CreateWebExperienceResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/CreateWebExperience">REST API Reference for CreateWebExperience Operation</seealso>
        CreateWebExperienceResponse EndCreateWebExperience(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteApplication


        /// <summary>
        /// Deletes an Amazon Q Business application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// 
        /// <returns>The response from the DeleteApplication service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        IAsyncResult BeginDeleteApplication(DeleteApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApplication.</param>
        /// 
        /// <returns>Returns a  DeleteApplicationResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        DeleteApplicationResponse EndDeleteApplication(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAttachment


        /// <summary>
        /// Deletes an attachment associated with a specific Amazon Q Business conversation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAttachment service method.</param>
        /// 
        /// <returns>The response from the DeleteAttachment service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.LicenseNotFoundException">
        /// You don't have permissions to perform the action because your license is inactive.
        /// Ask your admin to activate your license and try again after your licence is active.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteAttachment">REST API Reference for DeleteAttachment Operation</seealso>
        DeleteAttachmentResponse DeleteAttachment(DeleteAttachmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAttachment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAttachment operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAttachment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteAttachment">REST API Reference for DeleteAttachment Operation</seealso>
        IAsyncResult BeginDeleteAttachment(DeleteAttachmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAttachment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAttachment.</param>
        /// 
        /// <returns>Returns a  DeleteAttachmentResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteAttachment">REST API Reference for DeleteAttachment Operation</seealso>
        DeleteAttachmentResponse EndDeleteAttachment(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteChatControlsConfiguration


        /// <summary>
        /// Deletes chat controls configured for an existing Amazon Q Business application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChatControlsConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteChatControlsConfiguration service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteChatControlsConfiguration">REST API Reference for DeleteChatControlsConfiguration Operation</seealso>
        DeleteChatControlsConfigurationResponse DeleteChatControlsConfiguration(DeleteChatControlsConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteChatControlsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteChatControlsConfiguration operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteChatControlsConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteChatControlsConfiguration">REST API Reference for DeleteChatControlsConfiguration Operation</seealso>
        IAsyncResult BeginDeleteChatControlsConfiguration(DeleteChatControlsConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteChatControlsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteChatControlsConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteChatControlsConfigurationResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteChatControlsConfiguration">REST API Reference for DeleteChatControlsConfiguration Operation</seealso>
        DeleteChatControlsConfigurationResponse EndDeleteChatControlsConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteChatResponseConfiguration


        /// <summary>
        /// Deletes a specified chat response configuration from an Amazon Q Business application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChatResponseConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteChatResponseConfiguration service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteChatResponseConfiguration">REST API Reference for DeleteChatResponseConfiguration Operation</seealso>
        DeleteChatResponseConfigurationResponse DeleteChatResponseConfiguration(DeleteChatResponseConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteChatResponseConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteChatResponseConfiguration operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteChatResponseConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteChatResponseConfiguration">REST API Reference for DeleteChatResponseConfiguration Operation</seealso>
        IAsyncResult BeginDeleteChatResponseConfiguration(DeleteChatResponseConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteChatResponseConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteChatResponseConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteChatResponseConfigurationResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteChatResponseConfiguration">REST API Reference for DeleteChatResponseConfiguration Operation</seealso>
        DeleteChatResponseConfigurationResponse EndDeleteChatResponseConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteConversation


        /// <summary>
        /// Deletes an Amazon Q Business web experience conversation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConversation service method.</param>
        /// 
        /// <returns>The response from the DeleteConversation service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.LicenseNotFoundException">
        /// You don't have permissions to perform the action because your license is inactive.
        /// Ask your admin to activate your license and try again after your licence is active.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteConversation">REST API Reference for DeleteConversation Operation</seealso>
        DeleteConversationResponse DeleteConversation(DeleteConversationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConversation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConversation operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConversation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteConversation">REST API Reference for DeleteConversation Operation</seealso>
        IAsyncResult BeginDeleteConversation(DeleteConversationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConversation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConversation.</param>
        /// 
        /// <returns>Returns a  DeleteConversationResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteConversation">REST API Reference for DeleteConversation Operation</seealso>
        DeleteConversationResponse EndDeleteConversation(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDataAccessor


        /// <summary>
        /// Deletes a specified data accessor. This operation permanently removes the data accessor
        /// and its associated IAM Identity Center application. Any access granted to the ISV
        /// through this data accessor will be revoked.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataAccessor service method.</param>
        /// 
        /// <returns>The response from the DeleteDataAccessor service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteDataAccessor">REST API Reference for DeleteDataAccessor Operation</seealso>
        DeleteDataAccessorResponse DeleteDataAccessor(DeleteDataAccessorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataAccessor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataAccessor operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataAccessor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteDataAccessor">REST API Reference for DeleteDataAccessor Operation</seealso>
        IAsyncResult BeginDeleteDataAccessor(DeleteDataAccessorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataAccessor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataAccessor.</param>
        /// 
        /// <returns>Returns a  DeleteDataAccessorResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteDataAccessor">REST API Reference for DeleteDataAccessor Operation</seealso>
        DeleteDataAccessorResponse EndDeleteDataAccessor(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDataSource


        /// <summary>
        /// Deletes an Amazon Q Business data source connector. While the data source is being
        /// deleted, the <c>Status</c> field returned by a call to the <c>DescribeDataSource</c>
        /// API is set to <c>DELETING</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSource service method.</param>
        /// 
        /// <returns>The response from the DeleteDataSource service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteDataSource">REST API Reference for DeleteDataSource Operation</seealso>
        DeleteDataSourceResponse DeleteDataSource(DeleteDataSourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSource operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteDataSource">REST API Reference for DeleteDataSource Operation</seealso>
        IAsyncResult BeginDeleteDataSource(DeleteDataSourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataSource.</param>
        /// 
        /// <returns>Returns a  DeleteDataSourceResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteDataSource">REST API Reference for DeleteDataSource Operation</seealso>
        DeleteDataSourceResponse EndDeleteDataSource(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteGroup


        /// <summary>
        /// Deletes a group so that all users and sub groups that belong to the group can no longer
        /// access documents only available to that group. For example, after deleting the group
        /// "Summer Interns", all interns who belonged to that group no longer see intern-only
        /// documents in their chat results. 
        /// 
        ///  
        /// <para>
        /// If you want to delete, update, or replace users or sub groups of a group, you need
        /// to use the <c>PutGroup</c> operation. For example, if a user in the group "Engineering"
        /// leaves the engineering team and another user takes their place, you provide an updated
        /// list of users or sub groups that belong to the "Engineering" group when calling <c>PutGroup</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteGroup service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        DeleteGroupResponse DeleteGroup(DeleteGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        IAsyncResult BeginDeleteGroup(DeleteGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGroup.</param>
        /// 
        /// <returns>Returns a  DeleteGroupResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        DeleteGroupResponse EndDeleteGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteIndex


        /// <summary>
        /// Deletes an Amazon Q Business index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIndex service method.</param>
        /// 
        /// <returns>The response from the DeleteIndex service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteIndex">REST API Reference for DeleteIndex Operation</seealso>
        DeleteIndexResponse DeleteIndex(DeleteIndexRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIndex operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIndex operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteIndex
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteIndex">REST API Reference for DeleteIndex Operation</seealso>
        IAsyncResult BeginDeleteIndex(DeleteIndexRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIndex operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIndex.</param>
        /// 
        /// <returns>Returns a  DeleteIndexResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteIndex">REST API Reference for DeleteIndex Operation</seealso>
        DeleteIndexResponse EndDeleteIndex(IAsyncResult asyncResult);

        #endregion
        
        #region  DeletePlugin


        /// <summary>
        /// Deletes an Amazon Q Business plugin.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePlugin service method.</param>
        /// 
        /// <returns>The response from the DeletePlugin service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeletePlugin">REST API Reference for DeletePlugin Operation</seealso>
        DeletePluginResponse DeletePlugin(DeletePluginRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePlugin operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePlugin operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePlugin
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeletePlugin">REST API Reference for DeletePlugin Operation</seealso>
        IAsyncResult BeginDeletePlugin(DeletePluginRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePlugin operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePlugin.</param>
        /// 
        /// <returns>Returns a  DeletePluginResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeletePlugin">REST API Reference for DeletePlugin Operation</seealso>
        DeletePluginResponse EndDeletePlugin(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteRetriever


        /// <summary>
        /// Deletes the retriever used by an Amazon Q Business application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRetriever service method.</param>
        /// 
        /// <returns>The response from the DeleteRetriever service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteRetriever">REST API Reference for DeleteRetriever Operation</seealso>
        DeleteRetrieverResponse DeleteRetriever(DeleteRetrieverRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRetriever operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRetriever operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRetriever
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteRetriever">REST API Reference for DeleteRetriever Operation</seealso>
        IAsyncResult BeginDeleteRetriever(DeleteRetrieverRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRetriever operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRetriever.</param>
        /// 
        /// <returns>Returns a  DeleteRetrieverResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteRetriever">REST API Reference for DeleteRetriever Operation</seealso>
        DeleteRetrieverResponse EndDeleteRetriever(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteUser


        /// <summary>
        /// Deletes a user by email id.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser service method.</param>
        /// 
        /// <returns>The response from the DeleteUser service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        DeleteUserResponse DeleteUser(DeleteUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        IAsyncResult BeginDeleteUser(DeleteUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUser.</param>
        /// 
        /// <returns>Returns a  DeleteUserResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        DeleteUserResponse EndDeleteUser(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteWebExperience


        /// <summary>
        /// Deletes an Amazon Q Business web experience.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWebExperience service method.</param>
        /// 
        /// <returns>The response from the DeleteWebExperience service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteWebExperience">REST API Reference for DeleteWebExperience Operation</seealso>
        DeleteWebExperienceResponse DeleteWebExperience(DeleteWebExperienceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWebExperience operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWebExperience operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWebExperience
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteWebExperience">REST API Reference for DeleteWebExperience Operation</seealso>
        IAsyncResult BeginDeleteWebExperience(DeleteWebExperienceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWebExperience operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWebExperience.</param>
        /// 
        /// <returns>Returns a  DeleteWebExperienceResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DeleteWebExperience">REST API Reference for DeleteWebExperience Operation</seealso>
        DeleteWebExperienceResponse EndDeleteWebExperience(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociatePermission


        /// <summary>
        /// Removes a permission policy from a Amazon Q Business application, revoking the cross-account
        /// access that was previously granted to an ISV. This operation deletes the specified
        /// policy statement from the application's permission policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociatePermission service method.</param>
        /// 
        /// <returns>The response from the DisassociatePermission service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DisassociatePermission">REST API Reference for DisassociatePermission Operation</seealso>
        DisassociatePermissionResponse DisassociatePermission(DisassociatePermissionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociatePermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociatePermission operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociatePermission
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DisassociatePermission">REST API Reference for DisassociatePermission Operation</seealso>
        IAsyncResult BeginDisassociatePermission(DisassociatePermissionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociatePermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociatePermission.</param>
        /// 
        /// <returns>Returns a  DisassociatePermissionResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/DisassociatePermission">REST API Reference for DisassociatePermission Operation</seealso>
        DisassociatePermissionResponse EndDisassociatePermission(IAsyncResult asyncResult);

        #endregion
        
        #region  GetApplication


        /// <summary>
        /// Gets information about an existing Amazon Q Business application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplication service method.</param>
        /// 
        /// <returns>The response from the GetApplication service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetApplication">REST API Reference for GetApplication Operation</seealso>
        GetApplicationResponse GetApplication(GetApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApplication operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetApplication">REST API Reference for GetApplication Operation</seealso>
        IAsyncResult BeginGetApplication(GetApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApplication.</param>
        /// 
        /// <returns>Returns a  GetApplicationResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetApplication">REST API Reference for GetApplication Operation</seealso>
        GetApplicationResponse EndGetApplication(IAsyncResult asyncResult);

        #endregion
        
        #region  GetChatControlsConfiguration


        /// <summary>
        /// Gets information about chat controls configured for an existing Amazon Q Business
        /// application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChatControlsConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetChatControlsConfiguration service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetChatControlsConfiguration">REST API Reference for GetChatControlsConfiguration Operation</seealso>
        GetChatControlsConfigurationResponse GetChatControlsConfiguration(GetChatControlsConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetChatControlsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetChatControlsConfiguration operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetChatControlsConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetChatControlsConfiguration">REST API Reference for GetChatControlsConfiguration Operation</seealso>
        IAsyncResult BeginGetChatControlsConfiguration(GetChatControlsConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetChatControlsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetChatControlsConfiguration.</param>
        /// 
        /// <returns>Returns a  GetChatControlsConfigurationResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetChatControlsConfiguration">REST API Reference for GetChatControlsConfiguration Operation</seealso>
        GetChatControlsConfigurationResponse EndGetChatControlsConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  GetChatResponseConfiguration


        /// <summary>
        /// Retrieves detailed information about a specific chat response configuration from an
        /// Amazon Q Business application. This operation returns the complete configuration settings
        /// and metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChatResponseConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetChatResponseConfiguration service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetChatResponseConfiguration">REST API Reference for GetChatResponseConfiguration Operation</seealso>
        GetChatResponseConfigurationResponse GetChatResponseConfiguration(GetChatResponseConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetChatResponseConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetChatResponseConfiguration operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetChatResponseConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetChatResponseConfiguration">REST API Reference for GetChatResponseConfiguration Operation</seealso>
        IAsyncResult BeginGetChatResponseConfiguration(GetChatResponseConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetChatResponseConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetChatResponseConfiguration.</param>
        /// 
        /// <returns>Returns a  GetChatResponseConfigurationResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetChatResponseConfiguration">REST API Reference for GetChatResponseConfiguration Operation</seealso>
        GetChatResponseConfigurationResponse EndGetChatResponseConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDataAccessor


        /// <summary>
        /// Retrieves information about a specified data accessor. This operation returns details
        /// about the data accessor, including its display name, unique identifier, Amazon Resource
        /// Name (ARN), the associated Amazon Q Business application and IAM Identity Center application,
        /// the IAM role for the ISV, the action configurations, and the timestamps for when the
        /// data accessor was created and last updated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataAccessor service method.</param>
        /// 
        /// <returns>The response from the GetDataAccessor service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetDataAccessor">REST API Reference for GetDataAccessor Operation</seealso>
        GetDataAccessorResponse GetDataAccessor(GetDataAccessorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDataAccessor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataAccessor operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDataAccessor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetDataAccessor">REST API Reference for GetDataAccessor Operation</seealso>
        IAsyncResult BeginGetDataAccessor(GetDataAccessorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDataAccessor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDataAccessor.</param>
        /// 
        /// <returns>Returns a  GetDataAccessorResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetDataAccessor">REST API Reference for GetDataAccessor Operation</seealso>
        GetDataAccessorResponse EndGetDataAccessor(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDataSource


        /// <summary>
        /// Gets information about an existing Amazon Q Business data source connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataSource service method.</param>
        /// 
        /// <returns>The response from the GetDataSource service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetDataSource">REST API Reference for GetDataSource Operation</seealso>
        GetDataSourceResponse GetDataSource(GetDataSourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDataSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataSource operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDataSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetDataSource">REST API Reference for GetDataSource Operation</seealso>
        IAsyncResult BeginGetDataSource(GetDataSourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDataSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDataSource.</param>
        /// 
        /// <returns>Returns a  GetDataSourceResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetDataSource">REST API Reference for GetDataSource Operation</seealso>
        GetDataSourceResponse EndGetDataSource(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDocumentContent


        /// <summary>
        /// Retrieves the content of a document that was ingested into Amazon Q Business. This
        /// API validates user authorization against document ACLs before returning a pre-signed
        /// URL for secure document access. You can download or view source documents referenced
        /// in chat responses through the URL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDocumentContent service method.</param>
        /// 
        /// <returns>The response from the GetDocumentContent service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetDocumentContent">REST API Reference for GetDocumentContent Operation</seealso>
        GetDocumentContentResponse GetDocumentContent(GetDocumentContentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDocumentContent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDocumentContent operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDocumentContent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetDocumentContent">REST API Reference for GetDocumentContent Operation</seealso>
        IAsyncResult BeginGetDocumentContent(GetDocumentContentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDocumentContent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDocumentContent.</param>
        /// 
        /// <returns>Returns a  GetDocumentContentResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetDocumentContent">REST API Reference for GetDocumentContent Operation</seealso>
        GetDocumentContentResponse EndGetDocumentContent(IAsyncResult asyncResult);

        #endregion
        
        #region  GetGroup


        /// <summary>
        /// Describes a group by group name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroup service method.</param>
        /// 
        /// <returns>The response from the GetGroup service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetGroup">REST API Reference for GetGroup Operation</seealso>
        GetGroupResponse GetGroup(GetGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGroup operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetGroup">REST API Reference for GetGroup Operation</seealso>
        IAsyncResult BeginGetGroup(GetGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGroup.</param>
        /// 
        /// <returns>Returns a  GetGroupResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetGroup">REST API Reference for GetGroup Operation</seealso>
        GetGroupResponse EndGetGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  GetIndex


        /// <summary>
        /// Gets information about an existing Amazon Q Business index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIndex service method.</param>
        /// 
        /// <returns>The response from the GetIndex service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetIndex">REST API Reference for GetIndex Operation</seealso>
        GetIndexResponse GetIndex(GetIndexRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetIndex operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIndex operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIndex
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetIndex">REST API Reference for GetIndex Operation</seealso>
        IAsyncResult BeginGetIndex(GetIndexRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetIndex operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIndex.</param>
        /// 
        /// <returns>Returns a  GetIndexResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetIndex">REST API Reference for GetIndex Operation</seealso>
        GetIndexResponse EndGetIndex(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMedia


        /// <summary>
        /// Returns the image bytes corresponding to a media object. If you have implemented your
        /// own application with the Chat and ChatSync APIs, and have enabled content extraction
        /// from visual data in Amazon Q Business, you use the GetMedia API operation to download
        /// the images so you can show them in your UI with responses.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/extracting-meaning-from-images.html">Extracting
        /// semantic meaning from images and visuals</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMedia service method.</param>
        /// 
        /// <returns>The response from the GetMedia service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.LicenseNotFoundException">
        /// You don't have permissions to perform the action because your license is inactive.
        /// Ask your admin to activate your license and try again after your licence is active.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.MediaTooLargeException">
        /// The requested media object is too large to be returned.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetMedia">REST API Reference for GetMedia Operation</seealso>
        GetMediaResponse GetMedia(GetMediaRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetMedia operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMedia operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMedia
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetMedia">REST API Reference for GetMedia Operation</seealso>
        IAsyncResult BeginGetMedia(GetMediaRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMedia operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMedia.</param>
        /// 
        /// <returns>Returns a  GetMediaResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetMedia">REST API Reference for GetMedia Operation</seealso>
        GetMediaResponse EndGetMedia(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPlugin


        /// <summary>
        /// Gets information about an existing Amazon Q Business plugin.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPlugin service method.</param>
        /// 
        /// <returns>The response from the GetPlugin service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetPlugin">REST API Reference for GetPlugin Operation</seealso>
        GetPluginResponse GetPlugin(GetPluginRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPlugin operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPlugin operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPlugin
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetPlugin">REST API Reference for GetPlugin Operation</seealso>
        IAsyncResult BeginGetPlugin(GetPluginRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPlugin operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPlugin.</param>
        /// 
        /// <returns>Returns a  GetPluginResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetPlugin">REST API Reference for GetPlugin Operation</seealso>
        GetPluginResponse EndGetPlugin(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPolicy


        /// <summary>
        /// Retrieves the current permission policy for a Amazon Q Business application. The policy
        /// is returned as a JSON-formatted string and defines the IAM actions that are allowed
        /// or denied for the application's resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy service method.</param>
        /// 
        /// <returns>The response from the GetPolicy service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        GetPolicyResponse GetPolicy(GetPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        IAsyncResult BeginGetPolicy(GetPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPolicy.</param>
        /// 
        /// <returns>Returns a  GetPolicyResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        GetPolicyResponse EndGetPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRetriever


        /// <summary>
        /// Gets information about an existing retriever used by an Amazon Q Business application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRetriever service method.</param>
        /// 
        /// <returns>The response from the GetRetriever service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetRetriever">REST API Reference for GetRetriever Operation</seealso>
        GetRetrieverResponse GetRetriever(GetRetrieverRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRetriever operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRetriever operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRetriever
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetRetriever">REST API Reference for GetRetriever Operation</seealso>
        IAsyncResult BeginGetRetriever(GetRetrieverRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRetriever operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRetriever.</param>
        /// 
        /// <returns>Returns a  GetRetrieverResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetRetriever">REST API Reference for GetRetriever Operation</seealso>
        GetRetrieverResponse EndGetRetriever(IAsyncResult asyncResult);

        #endregion
        
        #region  GetUser


        /// <summary>
        /// Describes the universally unique identifier (UUID) associated with a local user in
        /// a data source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUser service method.</param>
        /// 
        /// <returns>The response from the GetUser service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetUser">REST API Reference for GetUser Operation</seealso>
        GetUserResponse GetUser(GetUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUser operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetUser">REST API Reference for GetUser Operation</seealso>
        IAsyncResult BeginGetUser(GetUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUser.</param>
        /// 
        /// <returns>Returns a  GetUserResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetUser">REST API Reference for GetUser Operation</seealso>
        GetUserResponse EndGetUser(IAsyncResult asyncResult);

        #endregion
        
        #region  GetWebExperience


        /// <summary>
        /// Gets information about an existing Amazon Q Business web experience.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWebExperience service method.</param>
        /// 
        /// <returns>The response from the GetWebExperience service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetWebExperience">REST API Reference for GetWebExperience Operation</seealso>
        GetWebExperienceResponse GetWebExperience(GetWebExperienceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetWebExperience operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWebExperience operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWebExperience
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetWebExperience">REST API Reference for GetWebExperience Operation</seealso>
        IAsyncResult BeginGetWebExperience(GetWebExperienceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetWebExperience operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWebExperience.</param>
        /// 
        /// <returns>Returns a  GetWebExperienceResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/GetWebExperience">REST API Reference for GetWebExperience Operation</seealso>
        GetWebExperienceResponse EndGetWebExperience(IAsyncResult asyncResult);

        #endregion
        
        #region  ListApplications


        /// <summary>
        /// Lists Amazon Q Business applications.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Q Business applications may securely transmit data for processing across Amazon
        /// Web Services Regions within your geography. For more information, see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/cross-region-inference.html">Cross
        /// region inference in Amazon Q Business</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplications service method.</param>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListApplications">REST API Reference for ListApplications Operation</seealso>
        ListApplicationsResponse ListApplications(ListApplicationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListApplications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApplications operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApplications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListApplications">REST API Reference for ListApplications Operation</seealso>
        IAsyncResult BeginListApplications(ListApplicationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListApplications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListApplications.</param>
        /// 
        /// <returns>Returns a  ListApplicationsResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListApplications">REST API Reference for ListApplications Operation</seealso>
        ListApplicationsResponse EndListApplications(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAttachments


        /// <summary>
        /// Gets a list of attachments associated with an Amazon Q Business web experience or
        /// a list of attachements associated with a specific Amazon Q Business conversation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAttachments service method.</param>
        /// 
        /// <returns>The response from the ListAttachments service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.LicenseNotFoundException">
        /// You don't have permissions to perform the action because your license is inactive.
        /// Ask your admin to activate your license and try again after your licence is active.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListAttachments">REST API Reference for ListAttachments Operation</seealso>
        ListAttachmentsResponse ListAttachments(ListAttachmentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAttachments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAttachments operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAttachments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListAttachments">REST API Reference for ListAttachments Operation</seealso>
        IAsyncResult BeginListAttachments(ListAttachmentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAttachments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAttachments.</param>
        /// 
        /// <returns>Returns a  ListAttachmentsResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListAttachments">REST API Reference for ListAttachments Operation</seealso>
        ListAttachmentsResponse EndListAttachments(IAsyncResult asyncResult);

        #endregion
        
        #region  ListChatResponseConfigurations


        /// <summary>
        /// Retrieves a list of all chat response configurations available in a specified Amazon
        /// Q Business application. This operation returns summary information about each configuration
        /// to help administrators manage and select appropriate response settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChatResponseConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListChatResponseConfigurations service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListChatResponseConfigurations">REST API Reference for ListChatResponseConfigurations Operation</seealso>
        ListChatResponseConfigurationsResponse ListChatResponseConfigurations(ListChatResponseConfigurationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListChatResponseConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChatResponseConfigurations operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListChatResponseConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListChatResponseConfigurations">REST API Reference for ListChatResponseConfigurations Operation</seealso>
        IAsyncResult BeginListChatResponseConfigurations(ListChatResponseConfigurationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListChatResponseConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListChatResponseConfigurations.</param>
        /// 
        /// <returns>Returns a  ListChatResponseConfigurationsResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListChatResponseConfigurations">REST API Reference for ListChatResponseConfigurations Operation</seealso>
        ListChatResponseConfigurationsResponse EndListChatResponseConfigurations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListConversations


        /// <summary>
        /// Lists one or more Amazon Q Business conversations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConversations service method.</param>
        /// 
        /// <returns>The response from the ListConversations service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.LicenseNotFoundException">
        /// You don't have permissions to perform the action because your license is inactive.
        /// Ask your admin to activate your license and try again after your licence is active.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListConversations">REST API Reference for ListConversations Operation</seealso>
        ListConversationsResponse ListConversations(ListConversationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListConversations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConversations operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConversations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListConversations">REST API Reference for ListConversations Operation</seealso>
        IAsyncResult BeginListConversations(ListConversationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListConversations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConversations.</param>
        /// 
        /// <returns>Returns a  ListConversationsResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListConversations">REST API Reference for ListConversations Operation</seealso>
        ListConversationsResponse EndListConversations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDataAccessors


        /// <summary>
        /// Lists the data accessors for a Amazon Q Business application. This operation returns
        /// a paginated list of data accessor summaries, including the friendly name, unique identifier,
        /// ARN, associated IAM role, and creation/update timestamps for each data accessor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataAccessors service method.</param>
        /// 
        /// <returns>The response from the ListDataAccessors service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListDataAccessors">REST API Reference for ListDataAccessors Operation</seealso>
        ListDataAccessorsResponse ListDataAccessors(ListDataAccessorsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDataAccessors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDataAccessors operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDataAccessors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListDataAccessors">REST API Reference for ListDataAccessors Operation</seealso>
        IAsyncResult BeginListDataAccessors(ListDataAccessorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDataAccessors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDataAccessors.</param>
        /// 
        /// <returns>Returns a  ListDataAccessorsResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListDataAccessors">REST API Reference for ListDataAccessors Operation</seealso>
        ListDataAccessorsResponse EndListDataAccessors(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDataSources


        /// <summary>
        /// Lists the Amazon Q Business data source connectors that you have created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSources service method.</param>
        /// 
        /// <returns>The response from the ListDataSources service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListDataSources">REST API Reference for ListDataSources Operation</seealso>
        ListDataSourcesResponse ListDataSources(ListDataSourcesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDataSources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDataSources operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDataSources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListDataSources">REST API Reference for ListDataSources Operation</seealso>
        IAsyncResult BeginListDataSources(ListDataSourcesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDataSources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDataSources.</param>
        /// 
        /// <returns>Returns a  ListDataSourcesResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListDataSources">REST API Reference for ListDataSources Operation</seealso>
        ListDataSourcesResponse EndListDataSources(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDataSourceSyncJobs


        /// <summary>
        /// Get information about an Amazon Q Business data source connector synchronization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSourceSyncJobs service method.</param>
        /// 
        /// <returns>The response from the ListDataSourceSyncJobs service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListDataSourceSyncJobs">REST API Reference for ListDataSourceSyncJobs Operation</seealso>
        ListDataSourceSyncJobsResponse ListDataSourceSyncJobs(ListDataSourceSyncJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDataSourceSyncJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDataSourceSyncJobs operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDataSourceSyncJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListDataSourceSyncJobs">REST API Reference for ListDataSourceSyncJobs Operation</seealso>
        IAsyncResult BeginListDataSourceSyncJobs(ListDataSourceSyncJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDataSourceSyncJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDataSourceSyncJobs.</param>
        /// 
        /// <returns>Returns a  ListDataSourceSyncJobsResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListDataSourceSyncJobs">REST API Reference for ListDataSourceSyncJobs Operation</seealso>
        ListDataSourceSyncJobsResponse EndListDataSourceSyncJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDocuments


        /// <summary>
        /// A list of documents attached to an index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDocuments service method.</param>
        /// 
        /// <returns>The response from the ListDocuments service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListDocuments">REST API Reference for ListDocuments Operation</seealso>
        ListDocumentsResponse ListDocuments(ListDocumentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDocuments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDocuments operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDocuments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListDocuments">REST API Reference for ListDocuments Operation</seealso>
        IAsyncResult BeginListDocuments(ListDocumentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDocuments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDocuments.</param>
        /// 
        /// <returns>Returns a  ListDocumentsResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListDocuments">REST API Reference for ListDocuments Operation</seealso>
        ListDocumentsResponse EndListDocuments(IAsyncResult asyncResult);

        #endregion
        
        #region  ListGroups


        /// <summary>
        /// Provides a list of groups that are mapped to users.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroups service method.</param>
        /// 
        /// <returns>The response from the ListGroups service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListGroups">REST API Reference for ListGroups Operation</seealso>
        ListGroupsResponse ListGroups(ListGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroups operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListGroups">REST API Reference for ListGroups Operation</seealso>
        IAsyncResult BeginListGroups(ListGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGroups.</param>
        /// 
        /// <returns>Returns a  ListGroupsResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListGroups">REST API Reference for ListGroups Operation</seealso>
        ListGroupsResponse EndListGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  ListIndices


        /// <summary>
        /// Lists the Amazon Q Business indices you have created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIndices service method.</param>
        /// 
        /// <returns>The response from the ListIndices service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListIndices">REST API Reference for ListIndices Operation</seealso>
        ListIndicesResponse ListIndices(ListIndicesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListIndices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIndices operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIndices
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListIndices">REST API Reference for ListIndices Operation</seealso>
        IAsyncResult BeginListIndices(ListIndicesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListIndices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIndices.</param>
        /// 
        /// <returns>Returns a  ListIndicesResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListIndices">REST API Reference for ListIndices Operation</seealso>
        ListIndicesResponse EndListIndices(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMessages


        /// <summary>
        /// Gets a list of messages associated with an Amazon Q Business web experience.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMessages service method.</param>
        /// 
        /// <returns>The response from the ListMessages service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.LicenseNotFoundException">
        /// You don't have permissions to perform the action because your license is inactive.
        /// Ask your admin to activate your license and try again after your licence is active.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListMessages">REST API Reference for ListMessages Operation</seealso>
        ListMessagesResponse ListMessages(ListMessagesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMessages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMessages operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMessages
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListMessages">REST API Reference for ListMessages Operation</seealso>
        IAsyncResult BeginListMessages(ListMessagesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMessages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMessages.</param>
        /// 
        /// <returns>Returns a  ListMessagesResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListMessages">REST API Reference for ListMessages Operation</seealso>
        ListMessagesResponse EndListMessages(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPluginActions


        /// <summary>
        /// Lists configured Amazon Q Business actions for a specific plugin in an Amazon Q Business
        /// application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPluginActions service method.</param>
        /// 
        /// <returns>The response from the ListPluginActions service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListPluginActions">REST API Reference for ListPluginActions Operation</seealso>
        ListPluginActionsResponse ListPluginActions(ListPluginActionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPluginActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPluginActions operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPluginActions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListPluginActions">REST API Reference for ListPluginActions Operation</seealso>
        IAsyncResult BeginListPluginActions(ListPluginActionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPluginActions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPluginActions.</param>
        /// 
        /// <returns>Returns a  ListPluginActionsResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListPluginActions">REST API Reference for ListPluginActions Operation</seealso>
        ListPluginActionsResponse EndListPluginActions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPlugins


        /// <summary>
        /// Lists configured Amazon Q Business plugins.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPlugins service method.</param>
        /// 
        /// <returns>The response from the ListPlugins service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListPlugins">REST API Reference for ListPlugins Operation</seealso>
        ListPluginsResponse ListPlugins(ListPluginsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPlugins operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPlugins operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPlugins
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListPlugins">REST API Reference for ListPlugins Operation</seealso>
        IAsyncResult BeginListPlugins(ListPluginsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPlugins operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPlugins.</param>
        /// 
        /// <returns>Returns a  ListPluginsResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListPlugins">REST API Reference for ListPlugins Operation</seealso>
        ListPluginsResponse EndListPlugins(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPluginTypeActions


        /// <summary>
        /// Lists configured Amazon Q Business actions for any plugin type—both built-in and custom.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPluginTypeActions service method.</param>
        /// 
        /// <returns>The response from the ListPluginTypeActions service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListPluginTypeActions">REST API Reference for ListPluginTypeActions Operation</seealso>
        ListPluginTypeActionsResponse ListPluginTypeActions(ListPluginTypeActionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPluginTypeActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPluginTypeActions operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPluginTypeActions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListPluginTypeActions">REST API Reference for ListPluginTypeActions Operation</seealso>
        IAsyncResult BeginListPluginTypeActions(ListPluginTypeActionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPluginTypeActions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPluginTypeActions.</param>
        /// 
        /// <returns>Returns a  ListPluginTypeActionsResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListPluginTypeActions">REST API Reference for ListPluginTypeActions Operation</seealso>
        ListPluginTypeActionsResponse EndListPluginTypeActions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPluginTypeMetadata


        /// <summary>
        /// Lists metadata for all Amazon Q Business plugin types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPluginTypeMetadata service method.</param>
        /// 
        /// <returns>The response from the ListPluginTypeMetadata service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListPluginTypeMetadata">REST API Reference for ListPluginTypeMetadata Operation</seealso>
        ListPluginTypeMetadataResponse ListPluginTypeMetadata(ListPluginTypeMetadataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPluginTypeMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPluginTypeMetadata operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPluginTypeMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListPluginTypeMetadata">REST API Reference for ListPluginTypeMetadata Operation</seealso>
        IAsyncResult BeginListPluginTypeMetadata(ListPluginTypeMetadataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPluginTypeMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPluginTypeMetadata.</param>
        /// 
        /// <returns>Returns a  ListPluginTypeMetadataResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListPluginTypeMetadata">REST API Reference for ListPluginTypeMetadata Operation</seealso>
        ListPluginTypeMetadataResponse EndListPluginTypeMetadata(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRetrievers


        /// <summary>
        /// Lists the retriever used by an Amazon Q Business application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRetrievers service method.</param>
        /// 
        /// <returns>The response from the ListRetrievers service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListRetrievers">REST API Reference for ListRetrievers Operation</seealso>
        ListRetrieversResponse ListRetrievers(ListRetrieversRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRetrievers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRetrievers operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRetrievers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListRetrievers">REST API Reference for ListRetrievers Operation</seealso>
        IAsyncResult BeginListRetrievers(ListRetrieversRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRetrievers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRetrievers.</param>
        /// 
        /// <returns>Returns a  ListRetrieversResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListRetrievers">REST API Reference for ListRetrievers Operation</seealso>
        ListRetrieversResponse EndListRetrievers(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSubscriptions


        /// <summary>
        /// Lists all subscriptions created in an Amazon Q Business application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptions service method.</param>
        /// 
        /// <returns>The response from the ListSubscriptions service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListSubscriptions">REST API Reference for ListSubscriptions Operation</seealso>
        ListSubscriptionsResponse ListSubscriptions(ListSubscriptionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSubscriptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptions operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSubscriptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListSubscriptions">REST API Reference for ListSubscriptions Operation</seealso>
        IAsyncResult BeginListSubscriptions(ListSubscriptionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSubscriptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSubscriptions.</param>
        /// 
        /// <returns>Returns a  ListSubscriptionsResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListSubscriptions">REST API Reference for ListSubscriptions Operation</seealso>
        ListSubscriptionsResponse EndListSubscriptions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Gets a list of tags associated with a specified resource. Amazon Q Business applications
        /// and data sources can have tags associated with them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListWebExperiences


        /// <summary>
        /// Lists one or more Amazon Q Business Web Experiences.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWebExperiences service method.</param>
        /// 
        /// <returns>The response from the ListWebExperiences service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListWebExperiences">REST API Reference for ListWebExperiences Operation</seealso>
        ListWebExperiencesResponse ListWebExperiences(ListWebExperiencesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListWebExperiences operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWebExperiences operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWebExperiences
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListWebExperiences">REST API Reference for ListWebExperiences Operation</seealso>
        IAsyncResult BeginListWebExperiences(ListWebExperiencesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListWebExperiences operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWebExperiences.</param>
        /// 
        /// <returns>Returns a  ListWebExperiencesResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/ListWebExperiences">REST API Reference for ListWebExperiences Operation</seealso>
        ListWebExperiencesResponse EndListWebExperiences(IAsyncResult asyncResult);

        #endregion
        
        #region  PutFeedback


        /// <summary>
        /// Enables your end user to provide feedback on their Amazon Q Business generated chat
        /// responses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutFeedback service method.</param>
        /// 
        /// <returns>The response from the PutFeedback service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/PutFeedback">REST API Reference for PutFeedback Operation</seealso>
        PutFeedbackResponse PutFeedback(PutFeedbackRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutFeedback operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutFeedback operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutFeedback
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/PutFeedback">REST API Reference for PutFeedback Operation</seealso>
        IAsyncResult BeginPutFeedback(PutFeedbackRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutFeedback operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutFeedback.</param>
        /// 
        /// <returns>Returns a  PutFeedbackResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/PutFeedback">REST API Reference for PutFeedback Operation</seealso>
        PutFeedbackResponse EndPutFeedback(IAsyncResult asyncResult);

        #endregion
        
        #region  PutGroup


        /// <summary>
        /// Create, or updates, a mapping of users—who have access to a document—to groups.
        /// 
        ///  
        /// <para>
        /// You can also map sub groups to groups. For example, the group "Company Intellectual
        /// Property Teams" includes sub groups "Research" and "Engineering". These sub groups
        /// include their own list of users or people who work in these teams. Only users who
        /// work in research and engineering, and therefore belong in the intellectual property
        /// group, can see top-secret company documents in their Amazon Q Business chat results.
        /// </para>
        ///  
        /// <para>
        /// There are two options for creating groups, either passing group members inline or
        /// using an S3 file via the S3PathForGroupMembers field. For inline groups, there is
        /// a limit of 1000 members per group and for provided S3 files there is a limit of 100
        /// thousand members. When creating a group using an S3 file, you provide both an S3 file
        /// and a <c>RoleArn</c> for Amazon Q Buisness to access the file.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutGroup service method.</param>
        /// 
        /// <returns>The response from the PutGroup service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Q Business service.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/PutGroup">REST API Reference for PutGroup Operation</seealso>
        PutGroupResponse PutGroup(PutGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutGroup operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/PutGroup">REST API Reference for PutGroup Operation</seealso>
        IAsyncResult BeginPutGroup(PutGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutGroup.</param>
        /// 
        /// <returns>Returns a  PutGroupResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/PutGroup">REST API Reference for PutGroup Operation</seealso>
        PutGroupResponse EndPutGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  SearchRelevantContent


        /// <summary>
        /// Searches for relevant content in a Amazon Q Business application based on a query.
        /// This operation takes a search query text, the Amazon Q Business application identifier,
        /// and optional filters (such as content source and maximum results) as input. It returns
        /// a list of relevant content items, where each item includes the content text, the unique
        /// document identifier, the document title, the document URI, any relevant document attributes,
        /// and score attributes indicating the confidence level of the relevance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchRelevantContent service method.</param>
        /// 
        /// <returns>The response from the SearchRelevantContent service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.LicenseNotFoundException">
        /// You don't have permissions to perform the action because your license is inactive.
        /// Ask your admin to activate your license and try again after your licence is active.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/SearchRelevantContent">REST API Reference for SearchRelevantContent Operation</seealso>
        SearchRelevantContentResponse SearchRelevantContent(SearchRelevantContentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SearchRelevantContent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchRelevantContent operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchRelevantContent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/SearchRelevantContent">REST API Reference for SearchRelevantContent Operation</seealso>
        IAsyncResult BeginSearchRelevantContent(SearchRelevantContentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SearchRelevantContent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchRelevantContent.</param>
        /// 
        /// <returns>Returns a  SearchRelevantContentResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/SearchRelevantContent">REST API Reference for SearchRelevantContent Operation</seealso>
        SearchRelevantContentResponse EndSearchRelevantContent(IAsyncResult asyncResult);

        #endregion
        
        #region  StartDataSourceSyncJob


        /// <summary>
        /// Starts a data source connector synchronization job. If a synchronization job is already
        /// in progress, Amazon Q Business returns a <c>ConflictException</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDataSourceSyncJob service method.</param>
        /// 
        /// <returns>The response from the StartDataSourceSyncJob service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Q Business service.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/StartDataSourceSyncJob">REST API Reference for StartDataSourceSyncJob Operation</seealso>
        StartDataSourceSyncJobResponse StartDataSourceSyncJob(StartDataSourceSyncJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartDataSourceSyncJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartDataSourceSyncJob operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartDataSourceSyncJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/StartDataSourceSyncJob">REST API Reference for StartDataSourceSyncJob Operation</seealso>
        IAsyncResult BeginStartDataSourceSyncJob(StartDataSourceSyncJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartDataSourceSyncJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartDataSourceSyncJob.</param>
        /// 
        /// <returns>Returns a  StartDataSourceSyncJobResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/StartDataSourceSyncJob">REST API Reference for StartDataSourceSyncJob Operation</seealso>
        StartDataSourceSyncJobResponse EndStartDataSourceSyncJob(IAsyncResult asyncResult);

        #endregion
        
        #region  StopDataSourceSyncJob


        /// <summary>
        /// Stops an Amazon Q Business data source connector synchronization job already in progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDataSourceSyncJob service method.</param>
        /// 
        /// <returns>The response from the StopDataSourceSyncJob service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/StopDataSourceSyncJob">REST API Reference for StopDataSourceSyncJob Operation</seealso>
        StopDataSourceSyncJobResponse StopDataSourceSyncJob(StopDataSourceSyncJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopDataSourceSyncJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopDataSourceSyncJob operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopDataSourceSyncJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/StopDataSourceSyncJob">REST API Reference for StopDataSourceSyncJob Operation</seealso>
        IAsyncResult BeginStopDataSourceSyncJob(StopDataSourceSyncJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopDataSourceSyncJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopDataSourceSyncJob.</param>
        /// 
        /// <returns>Returns a  StopDataSourceSyncJobResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/StopDataSourceSyncJob">REST API Reference for StopDataSourceSyncJob Operation</seealso>
        StopDataSourceSyncJobResponse EndStopDataSourceSyncJob(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds the specified tag to the specified Amazon Q Business application or data source
        /// resource. If the tag already exists, the existing value is replaced with the new value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes a tag from an Amazon Q Business application or a data source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateApplication


        /// <summary>
        /// Updates an existing Amazon Q Business application.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Q Business applications may securely transmit data for processing across Amazon
        /// Web Services Regions within your geography. For more information, see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/cross-region-inference.html">Cross
        /// region inference in Amazon Q Business</a>.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// An Amazon Q Apps service-linked role will be created if it's absent in the Amazon
        /// Web Services account when <c>QAppsConfiguration</c> is enabled in the request. For
        /// more information, see <a href="https://docs.aws.amazon.com/amazonq/latest/qbusiness-ug/using-service-linked-roles-qapps.html">Using
        /// service-linked roles for Q Apps</a>. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication service method.</param>
        /// 
        /// <returns>The response from the UpdateApplication service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        IAsyncResult BeginUpdateApplication(UpdateApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApplication.</param>
        /// 
        /// <returns>Returns a  UpdateApplicationResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        UpdateApplicationResponse EndUpdateApplication(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateChatControlsConfiguration


        /// <summary>
        /// Updates a set of chat controls configured for an existing Amazon Q Business application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChatControlsConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateChatControlsConfiguration service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Q Business service.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateChatControlsConfiguration">REST API Reference for UpdateChatControlsConfiguration Operation</seealso>
        UpdateChatControlsConfigurationResponse UpdateChatControlsConfiguration(UpdateChatControlsConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateChatControlsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateChatControlsConfiguration operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateChatControlsConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateChatControlsConfiguration">REST API Reference for UpdateChatControlsConfiguration Operation</seealso>
        IAsyncResult BeginUpdateChatControlsConfiguration(UpdateChatControlsConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateChatControlsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateChatControlsConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateChatControlsConfigurationResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateChatControlsConfiguration">REST API Reference for UpdateChatControlsConfiguration Operation</seealso>
        UpdateChatControlsConfigurationResponse EndUpdateChatControlsConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateChatResponseConfiguration


        /// <summary>
        /// Updates an existing chat response configuration in an Amazon Q Business application.
        /// This operation allows administrators to modify configuration settings, display name,
        /// and response parameters to refine how the system generates responses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChatResponseConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateChatResponseConfiguration service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateChatResponseConfiguration">REST API Reference for UpdateChatResponseConfiguration Operation</seealso>
        UpdateChatResponseConfigurationResponse UpdateChatResponseConfiguration(UpdateChatResponseConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateChatResponseConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateChatResponseConfiguration operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateChatResponseConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateChatResponseConfiguration">REST API Reference for UpdateChatResponseConfiguration Operation</seealso>
        IAsyncResult BeginUpdateChatResponseConfiguration(UpdateChatResponseConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateChatResponseConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateChatResponseConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateChatResponseConfigurationResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateChatResponseConfiguration">REST API Reference for UpdateChatResponseConfiguration Operation</seealso>
        UpdateChatResponseConfigurationResponse EndUpdateChatResponseConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDataAccessor


        /// <summary>
        /// Updates an existing data accessor. This operation allows modifying the action configurations
        /// (the allowed actions and associated filters) and the display name of the data accessor.
        /// It does not allow changing the IAM role associated with the data accessor or other
        /// core properties of the data accessor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataAccessor service method.</param>
        /// 
        /// <returns>The response from the UpdateDataAccessor service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateDataAccessor">REST API Reference for UpdateDataAccessor Operation</seealso>
        UpdateDataAccessorResponse UpdateDataAccessor(UpdateDataAccessorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDataAccessor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataAccessor operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDataAccessor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateDataAccessor">REST API Reference for UpdateDataAccessor Operation</seealso>
        IAsyncResult BeginUpdateDataAccessor(UpdateDataAccessorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDataAccessor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDataAccessor.</param>
        /// 
        /// <returns>Returns a  UpdateDataAccessorResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateDataAccessor">REST API Reference for UpdateDataAccessor Operation</seealso>
        UpdateDataAccessorResponse EndUpdateDataAccessor(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDataSource


        /// <summary>
        /// Updates an existing Amazon Q Business data source connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSource service method.</param>
        /// 
        /// <returns>The response from the UpdateDataSource service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateDataSource">REST API Reference for UpdateDataSource Operation</seealso>
        UpdateDataSourceResponse UpdateDataSource(UpdateDataSourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDataSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSource operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDataSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateDataSource">REST API Reference for UpdateDataSource Operation</seealso>
        IAsyncResult BeginUpdateDataSource(UpdateDataSourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDataSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDataSource.</param>
        /// 
        /// <returns>Returns a  UpdateDataSourceResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateDataSource">REST API Reference for UpdateDataSource Operation</seealso>
        UpdateDataSourceResponse EndUpdateDataSource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateIndex


        /// <summary>
        /// Updates an Amazon Q Business index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIndex service method.</param>
        /// 
        /// <returns>The response from the UpdateIndex service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Q Business service.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateIndex">REST API Reference for UpdateIndex Operation</seealso>
        UpdateIndexResponse UpdateIndex(UpdateIndexRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIndex operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIndex operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateIndex
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateIndex">REST API Reference for UpdateIndex Operation</seealso>
        IAsyncResult BeginUpdateIndex(UpdateIndexRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateIndex operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateIndex.</param>
        /// 
        /// <returns>Returns a  UpdateIndexResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateIndex">REST API Reference for UpdateIndex Operation</seealso>
        UpdateIndexResponse EndUpdateIndex(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdatePlugin


        /// <summary>
        /// Updates an Amazon Q Business plugin.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePlugin service method.</param>
        /// 
        /// <returns>The response from the UpdatePlugin service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Q Business service.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdatePlugin">REST API Reference for UpdatePlugin Operation</seealso>
        UpdatePluginResponse UpdatePlugin(UpdatePluginRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePlugin operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePlugin operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePlugin
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdatePlugin">REST API Reference for UpdatePlugin Operation</seealso>
        IAsyncResult BeginUpdatePlugin(UpdatePluginRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePlugin operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePlugin.</param>
        /// 
        /// <returns>Returns a  UpdatePluginResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdatePlugin">REST API Reference for UpdatePlugin Operation</seealso>
        UpdatePluginResponse EndUpdatePlugin(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateRetriever


        /// <summary>
        /// Updates the retriever used for your Amazon Q Business application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRetriever service method.</param>
        /// 
        /// <returns>The response from the UpdateRetriever service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Q Business service.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateRetriever">REST API Reference for UpdateRetriever Operation</seealso>
        UpdateRetrieverResponse UpdateRetriever(UpdateRetrieverRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRetriever operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRetriever operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRetriever
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateRetriever">REST API Reference for UpdateRetriever Operation</seealso>
        IAsyncResult BeginUpdateRetriever(UpdateRetrieverRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRetriever operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRetriever.</param>
        /// 
        /// <returns>Returns a  UpdateRetrieverResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateRetriever">REST API Reference for UpdateRetriever Operation</seealso>
        UpdateRetrieverResponse EndUpdateRetriever(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSubscription


        /// <summary>
        /// Updates the pricing tier for an Amazon Q Business subscription. Upgrades are instant.
        /// Downgrades apply at the start of the next month. Subscription tier determines feature
        /// access for the user. For more information on subscriptions and pricing tiers, see
        /// <a href="https://aws.amazon.com/q/business/pricing/">Amazon Q Business pricing</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscription service method.</param>
        /// 
        /// <returns>The response from the UpdateSubscription service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateSubscription">REST API Reference for UpdateSubscription Operation</seealso>
        UpdateSubscriptionResponse UpdateSubscription(UpdateSubscriptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscription operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateSubscription">REST API Reference for UpdateSubscription Operation</seealso>
        IAsyncResult BeginUpdateSubscription(UpdateSubscriptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSubscription.</param>
        /// 
        /// <returns>Returns a  UpdateSubscriptionResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateSubscription">REST API Reference for UpdateSubscription Operation</seealso>
        UpdateSubscriptionResponse EndUpdateSubscription(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateUser


        /// <summary>
        /// Updates a information associated with a user id.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser service method.</param>
        /// 
        /// <returns>The response from the UpdateUser service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ServiceQuotaExceededException">
        /// You have exceeded the set limits for your Amazon Q Business service.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        UpdateUserResponse UpdateUser(UpdateUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        IAsyncResult BeginUpdateUser(UpdateUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUser.</param>
        /// 
        /// <returns>Returns a  UpdateUserResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        UpdateUserResponse EndUpdateUser(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateWebExperience


        /// <summary>
        /// Updates an Amazon Q Business web experience.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWebExperience service method.</param>
        /// 
        /// <returns>The response from the UpdateWebExperience service method, as returned by QBusiness.</returns>
        /// <exception cref="Amazon.QBusiness.Model.AccessDeniedException">
        /// You don't have access to perform this action. Make sure you have the required permission
        /// policies and user accounts and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.InternalServerException">
        /// An issue occurred with the internal server used for your Amazon Q Business service.
        /// Wait some minutes and try again, or contact <a href="http://aws.amazon.com/contact-us/">Support</a>
        /// for help.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ResourceNotFoundException">
        /// The application or plugin resource you want to use doesn’t exist. Make sure you have
        /// provided the correct resource and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ThrottlingException">
        /// The request was denied due to throttling. Reduce the number of requests and try again.
        /// </exception>
        /// <exception cref="Amazon.QBusiness.Model.ValidationException">
        /// The input doesn't meet the constraints set by the Amazon Q Business service. Provide
        /// the correct input and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateWebExperience">REST API Reference for UpdateWebExperience Operation</seealso>
        UpdateWebExperienceResponse UpdateWebExperience(UpdateWebExperienceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateWebExperience operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWebExperience operation on AmazonQBusinessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWebExperience
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateWebExperience">REST API Reference for UpdateWebExperience Operation</seealso>
        IAsyncResult BeginUpdateWebExperience(UpdateWebExperienceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWebExperience operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWebExperience.</param>
        /// 
        /// <returns>Returns a  UpdateWebExperienceResult from QBusiness.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/qbusiness-2023-11-27/UpdateWebExperience">REST API Reference for UpdateWebExperience Operation</seealso>
        UpdateWebExperienceResponse EndUpdateWebExperience(IAsyncResult asyncResult);

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}