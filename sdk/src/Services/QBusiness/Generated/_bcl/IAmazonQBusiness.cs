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
using System.Threading;
using System.Threading.Tasks;
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

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IQBusinessPaginatorFactory Paginators { get; }

        
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
        /// Adds or updates a permission policy for a Amazon Q Business application, allowing
        /// cross-account access for an ISV. This operation creates a new policy statement for
        /// the specified Amazon Q Business application. The policy statement defines the IAM
        /// actions that the ISV is allowed to perform on the Amazon Q Business application's
        /// resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociatePermission service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<AssociatePermissionResponse> AssociatePermissionAsync(AssociatePermissionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<BatchDeleteDocumentResponse> BatchDeleteDocumentAsync(BatchDeleteDocumentRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<BatchPutDocumentResponse> BatchPutDocumentAsync(BatchPutDocumentRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Unsubscribes a user or a group from their pricing tier in an Amazon Q Business application.
        /// An unsubscribed user or group loses all Amazon Q Business feature access at the start
        /// of next month.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CancelSubscriptionResponse> CancelSubscriptionAsync(CancelSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Starts or continues a non-streaming Amazon Q Business conversation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ChatSync service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ChatSyncResponse> ChatSyncAsync(ChatSyncRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Verifies if a user has access permissions for a specified document and returns the
        /// actual ACL attached to the document. Resolves user access on the document via user
        /// aliases and groups when verifying user access.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CheckDocumentAccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CheckDocumentAccessResponse> CheckDocumentAccessAsync(CheckDocumentAccessRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates a unique URL for anonymous Amazon Q Business web experience. This URL can
        /// only be used once and must be used within 5 minutes after it's generated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAnonymousWebExperienceUrl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateAnonymousWebExperienceUrlResponse> CreateAnonymousWebExperienceUrlAsync(CreateAnonymousWebExperienceUrlRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates a new chat response configuration for an Amazon Q Business application. This
        /// operation establishes a set of parameters that define how the system generates and
        /// formats responses to user queries in chat interactions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChatResponseConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateChatResponseConfigurationResponse> CreateChatResponseConfigurationAsync(CreateChatResponseConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates a new data accessor for an ISV to access data from a Amazon Q Business application.
        /// The data accessor is an entity that represents the ISV's access to the Amazon Q Business
        /// application's data. It includes the IAM role ARN for the ISV, a friendly name, and
        /// a set of action configurations that define the specific actions the ISV is allowed
        /// to perform and any associated data filters. When the data accessor is created, an
        /// IAM Identity Center application is also created to manage the ISV's identity and authentication
        /// for accessing the Amazon Q Business application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataAccessor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateDataAccessorResponse> CreateDataAccessorAsync(CreateDataAccessorRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates a data source connector for an Amazon Q Business application.
        /// 
        ///  
        /// <para>
        ///  <c>CreateDataSource</c> is a synchronous operation. The operation returns 200 if
        /// the data source was successfully created. Otherwise, an exception is raised.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateDataSourceResponse> CreateDataSourceAsync(CreateDataSourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateIndexResponse> CreateIndexAsync(CreateIndexRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates an Amazon Q Business plugin.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePlugin service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreatePluginResponse> CreatePluginAsync(CreatePluginRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Adds a retriever to your Amazon Q Business application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRetriever service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateRetrieverResponse> CreateRetrieverAsync(CreateRetrieverRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateSubscriptionResponse> CreateSubscriptionAsync(CreateSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates a universally unique identifier (UUID) mapped to a list of local user ids
        /// within an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateUserResponse> CreateUserAsync(CreateUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates an Amazon Q Business web experience.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWebExperience service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateWebExperienceResponse> CreateWebExperienceAsync(CreateWebExperienceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes an Amazon Q Business application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteApplicationResponse> DeleteApplicationAsync(DeleteApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes an attachment associated with a specific Amazon Q Business conversation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAttachment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteAttachmentResponse> DeleteAttachmentAsync(DeleteAttachmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes chat controls configured for an existing Amazon Q Business application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChatControlsConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteChatControlsConfigurationResponse> DeleteChatControlsConfigurationAsync(DeleteChatControlsConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes a specified chat response configuration from an Amazon Q Business application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChatResponseConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteChatResponseConfigurationResponse> DeleteChatResponseConfigurationAsync(DeleteChatResponseConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <exception cref="Amazon.QBusiness.Model.ConflictException">
        /// You are trying to perform an action that conflicts with the current status of your
        /// resource. Fix any inconsistencies with your resources and try again.
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
        /// Deletes an Amazon Q Business web experience conversation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConversation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConversation service method, as returned by QBusiness.</returns>
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
        Task<DeleteConversationResponse> DeleteConversationAsync(DeleteConversationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes a specified data accessor. This operation permanently removes the data accessor
        /// and its associated IAM Identity Center application. Any access granted to the ISV
        /// through this data accessor will be revoked.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataAccessor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteDataAccessorResponse> DeleteDataAccessorAsync(DeleteDataAccessorRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes an Amazon Q Business data source connector. While the data source is being
        /// deleted, the <c>Status</c> field returned by a call to the <c>DescribeDataSource</c>
        /// API is set to <c>DELETING</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteDataSourceResponse> DeleteDataSourceAsync(DeleteDataSourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteGroupResponse> DeleteGroupAsync(DeleteGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes an Amazon Q Business index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIndex service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteIndexResponse> DeleteIndexAsync(DeleteIndexRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes an Amazon Q Business plugin.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePlugin service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeletePluginResponse> DeletePluginAsync(DeletePluginRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes the retriever used by an Amazon Q Business application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRetriever service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteRetrieverResponse> DeleteRetrieverAsync(DeleteRetrieverRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes a user by email id.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes an Amazon Q Business web experience.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWebExperience service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteWebExperienceResponse> DeleteWebExperienceAsync(DeleteWebExperienceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Removes a permission policy from a Amazon Q Business application, revoking the cross-account
        /// access that was previously granted to an ISV. This operation deletes the specified
        /// policy statement from the application's permission policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociatePermission service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DisassociatePermissionResponse> DisassociatePermissionAsync(DisassociatePermissionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets information about an existing Amazon Q Business application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetApplicationResponse> GetApplicationAsync(GetApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets information about chat controls configured for an existing Amazon Q Business
        /// application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChatControlsConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetChatControlsConfigurationResponse> GetChatControlsConfigurationAsync(GetChatControlsConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Retrieves detailed information about a specific chat response configuration from an
        /// Amazon Q Business application. This operation returns the complete configuration settings
        /// and metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChatResponseConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetChatResponseConfigurationResponse> GetChatResponseConfigurationAsync(GetChatResponseConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Retrieves information about a specified data accessor. This operation returns details
        /// about the data accessor, including its display name, unique identifier, Amazon Resource
        /// Name (ARN), the associated Amazon Q Business application and IAM Identity Center application,
        /// the IAM role for the ISV, the action configurations, and the timestamps for when the
        /// data accessor was created and last updated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataAccessor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetDataAccessorResponse> GetDataAccessorAsync(GetDataAccessorRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets information about an existing Amazon Q Business data source connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetDataSourceResponse> GetDataSourceAsync(GetDataSourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Retrieves the content of a document that was ingested into Amazon Q Business. This
        /// API validates user authorization against document ACLs before returning a pre-signed
        /// URL for secure document access. You can download or view source documents referenced
        /// in chat responses through the URL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDocumentContent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetDocumentContentResponse> GetDocumentContentAsync(GetDocumentContentRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Describes a group by group name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetGroupResponse> GetGroupAsync(GetGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets information about an existing Amazon Q Business index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIndex service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetIndexResponse> GetIndexAsync(GetIndexRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetMediaResponse> GetMediaAsync(GetMediaRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets information about an existing Amazon Q Business plugin.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPlugin service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetPluginResponse> GetPluginAsync(GetPluginRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Retrieves the current permission policy for a Amazon Q Business application. The policy
        /// is returned as a JSON-formatted string and defines the IAM actions that are allowed
        /// or denied for the application's resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetPolicyResponse> GetPolicyAsync(GetPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets information about an existing retriever used by an Amazon Q Business application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRetriever service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetRetrieverResponse> GetRetrieverAsync(GetRetrieverRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Describes the universally unique identifier (UUID) associated with a local user in
        /// a data source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetUserResponse> GetUserAsync(GetUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets information about an existing Amazon Q Business web experience.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWebExperience service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetWebExperienceResponse> GetWebExperienceAsync(GetWebExperienceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListApplicationsResponse> ListApplicationsAsync(ListApplicationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets a list of attachments associated with an Amazon Q Business web experience or
        /// a list of attachements associated with a specific Amazon Q Business conversation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAttachments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListAttachmentsResponse> ListAttachmentsAsync(ListAttachmentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Retrieves a list of all chat response configurations available in a specified Amazon
        /// Q Business application. This operation returns summary information about each configuration
        /// to help administrators manage and select appropriate response settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChatResponseConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListChatResponseConfigurationsResponse> ListChatResponseConfigurationsAsync(ListChatResponseConfigurationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists one or more Amazon Q Business conversations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConversations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListConversationsResponse> ListConversationsAsync(ListConversationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists the data accessors for a Amazon Q Business application. This operation returns
        /// a paginated list of data accessor summaries, including the friendly name, unique identifier,
        /// ARN, associated IAM role, and creation/update timestamps for each data accessor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataAccessors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListDataAccessorsResponse> ListDataAccessorsAsync(ListDataAccessorsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists the Amazon Q Business data source connectors that you have created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListDataSourcesResponse> ListDataSourcesAsync(ListDataSourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Get information about an Amazon Q Business data source connector synchronization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSourceSyncJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListDataSourceSyncJobsResponse> ListDataSourceSyncJobsAsync(ListDataSourceSyncJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// A list of documents attached to an index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDocuments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListDocumentsResponse> ListDocumentsAsync(ListDocumentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Provides a list of groups that are mapped to users.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListGroupsResponse> ListGroupsAsync(ListGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists the Amazon Q Business indices you have created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIndices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListIndicesResponse> ListIndicesAsync(ListIndicesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets a list of messages associated with an Amazon Q Business web experience.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMessages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListMessagesResponse> ListMessagesAsync(ListMessagesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists configured Amazon Q Business actions for a specific plugin in an Amazon Q Business
        /// application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPluginActions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListPluginActionsResponse> ListPluginActionsAsync(ListPluginActionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists configured Amazon Q Business plugins.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPlugins service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListPluginsResponse> ListPluginsAsync(ListPluginsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists configured Amazon Q Business actions for any plugin type—both built-in and custom.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPluginTypeActions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListPluginTypeActionsResponse> ListPluginTypeActionsAsync(ListPluginTypeActionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists metadata for all Amazon Q Business plugin types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPluginTypeMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListPluginTypeMetadataResponse> ListPluginTypeMetadataAsync(ListPluginTypeMetadataRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists the retriever used by an Amazon Q Business application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRetrievers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListRetrieversResponse> ListRetrieversAsync(ListRetrieversRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists all subscriptions created in an Amazon Q Business application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscriptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListSubscriptionsResponse> ListSubscriptionsAsync(ListSubscriptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets a list of tags associated with a specified resource. Amazon Q Business applications
        /// and data sources can have tags associated with them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists one or more Amazon Q Business Web Experiences.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWebExperiences service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListWebExperiencesResponse> ListWebExperiencesAsync(ListWebExperiencesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Enables your end user to provide feedback on their Amazon Q Business generated chat
        /// responses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutFeedback service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<PutFeedbackResponse> PutFeedbackAsync(PutFeedbackRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<PutGroupResponse> PutGroupAsync(PutGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Searches for relevant content in a Amazon Q Business application based on a query.
        /// This operation takes a search query text, the Amazon Q Business application identifier,
        /// and optional filters (such as content source and maximum results) as input. It returns
        /// a list of relevant content items, where each item includes the content text, the unique
        /// document identifier, the document title, the document URI, any relevant document attributes,
        /// and score attributes indicating the confidence level of the relevance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchRelevantContent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<SearchRelevantContentResponse> SearchRelevantContentAsync(SearchRelevantContentRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Starts a data source connector synchronization job. If a synchronization job is already
        /// in progress, Amazon Q Business returns a <c>ConflictException</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDataSourceSyncJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StartDataSourceSyncJobResponse> StartDataSourceSyncJobAsync(StartDataSourceSyncJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Stops an Amazon Q Business data source connector synchronization job already in progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDataSourceSyncJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StopDataSourceSyncJobResponse> StopDataSourceSyncJobAsync(StopDataSourceSyncJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Adds the specified tag to the specified Amazon Q Business application or data source
        /// resource. If the tag already exists, the existing value is replaced with the new value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Removes a tag from an Amazon Q Business application or a data source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateApplicationResponse> UpdateApplicationAsync(UpdateApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates a set of chat controls configured for an existing Amazon Q Business application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChatControlsConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateChatControlsConfigurationResponse> UpdateChatControlsConfigurationAsync(UpdateChatControlsConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates an existing chat response configuration in an Amazon Q Business application.
        /// This operation allows administrators to modify configuration settings, display name,
        /// and response parameters to refine how the system generates responses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChatResponseConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateChatResponseConfigurationResponse> UpdateChatResponseConfigurationAsync(UpdateChatResponseConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates an existing data accessor. This operation allows modifying the action configurations
        /// (the allowed actions and associated filters) and the display name of the data accessor.
        /// It does not allow changing the IAM role associated with the data accessor or other
        /// core properties of the data accessor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataAccessor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateDataAccessorResponse> UpdateDataAccessorAsync(UpdateDataAccessorRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates an existing Amazon Q Business data source connector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateDataSourceResponse> UpdateDataSourceAsync(UpdateDataSourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates an Amazon Q Business index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIndex service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateIndexResponse> UpdateIndexAsync(UpdateIndexRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates an Amazon Q Business plugin.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePlugin service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdatePluginResponse> UpdatePluginAsync(UpdatePluginRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates the retriever used for your Amazon Q Business application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRetriever service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateRetrieverResponse> UpdateRetrieverAsync(UpdateRetrieverRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates the pricing tier for an Amazon Q Business subscription. Upgrades are instant.
        /// Downgrades apply at the start of the next month. Subscription tier determines feature
        /// access for the user. For more information on subscriptions and pricing tiers, see
        /// <a href="https://aws.amazon.com/q/business/pricing/">Amazon Q Business pricing</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateSubscriptionResponse> UpdateSubscriptionAsync(UpdateSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates a information associated with a user id.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateUserResponse> UpdateUserAsync(UpdateUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates an Amazon Q Business web experience.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWebExperience service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateWebExperienceResponse> UpdateWebExperienceAsync(UpdateWebExperienceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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