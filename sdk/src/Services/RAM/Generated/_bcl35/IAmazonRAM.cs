/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ram-2018-01-04.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.RAM.Model;

namespace Amazon.RAM
{
    /// <summary>
    /// Interface for accessing RAM
    ///
    /// Use AWS Resource Access Manager to share AWS resources between AWS accounts. To share
    /// a resource, you create a resource share, associate the resource with the resource
    /// share, and specify the principals that can access the resources associated with the
    /// resource share. The following principals are supported: AWS accounts, organizational
    /// units (OU) from AWS Organizations, and organizations from AWS Organizations.
    /// 
    ///  
    /// <para>
    /// For more information, see the <a href="https://docs.aws.amazon.com/ram/latest/userguide/">AWS
    /// Resource Access Manager User Guide</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonRAM : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IRAMPaginatorFactory Paginators { get; }
#endif


        
        #region  AcceptResourceShareInvitation


        /// <summary>
        /// Accepts an invitation to a resource share from another AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptResourceShareInvitation service method.</param>
        /// 
        /// <returns>The response from the AcceptResourceShareInvitation service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.IdempotentParameterMismatchException">
        /// A client token input parameter was reused with an operation, but at least one of the
        /// other input parameters is different from the previous call to the operation.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidClientTokenException">
        /// A client token is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The format of an Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.OperationNotPermittedException">
        /// The requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceShareInvitationAlreadyAcceptedException">
        /// The invitation was already accepted.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceShareInvitationAlreadyRejectedException">
        /// The invitation was already rejected.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceShareInvitationArnNotFoundException">
        /// The Amazon Resource Name (ARN) for an invitation was not found.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceShareInvitationExpiredException">
        /// The invitation is expired.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The service is not available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/AcceptResourceShareInvitation">REST API Reference for AcceptResourceShareInvitation Operation</seealso>
        AcceptResourceShareInvitationResponse AcceptResourceShareInvitation(AcceptResourceShareInvitationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AcceptResourceShareInvitation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptResourceShareInvitation operation on AmazonRAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAcceptResourceShareInvitation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/AcceptResourceShareInvitation">REST API Reference for AcceptResourceShareInvitation Operation</seealso>
        IAsyncResult BeginAcceptResourceShareInvitation(AcceptResourceShareInvitationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AcceptResourceShareInvitation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAcceptResourceShareInvitation.</param>
        /// 
        /// <returns>Returns a  AcceptResourceShareInvitationResult from RAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/AcceptResourceShareInvitation">REST API Reference for AcceptResourceShareInvitation Operation</seealso>
        AcceptResourceShareInvitationResponse EndAcceptResourceShareInvitation(IAsyncResult asyncResult);

        #endregion
        
        #region  AssociateResourceShare


        /// <summary>
        /// Associates the specified resource share with the specified principals and resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateResourceShare service method.</param>
        /// 
        /// <returns>The response from the AssociateResourceShare service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.IdempotentParameterMismatchException">
        /// A client token input parameter was reused with an operation, but at least one of the
        /// other input parameters is different from the previous call to the operation.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidClientTokenException">
        /// A client token is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// A parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidStateTransitionException">
        /// The requested state transition is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The format of an Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.OperationNotPermittedException">
        /// The requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceShareLimitExceededException">
        /// The requested resource share exceeds the limit for your account.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The service is not available.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.UnknownResourceException">
        /// A specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/AssociateResourceShare">REST API Reference for AssociateResourceShare Operation</seealso>
        AssociateResourceShareResponse AssociateResourceShare(AssociateResourceShareRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateResourceShare operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateResourceShare operation on AmazonRAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateResourceShare
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/AssociateResourceShare">REST API Reference for AssociateResourceShare Operation</seealso>
        IAsyncResult BeginAssociateResourceShare(AssociateResourceShareRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateResourceShare operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateResourceShare.</param>
        /// 
        /// <returns>Returns a  AssociateResourceShareResult from RAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/AssociateResourceShare">REST API Reference for AssociateResourceShare Operation</seealso>
        AssociateResourceShareResponse EndAssociateResourceShare(IAsyncResult asyncResult);

        #endregion
        
        #region  AssociateResourceSharePermission


        /// <summary>
        /// Associates a permission with a resource share.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateResourceSharePermission service method.</param>
        /// 
        /// <returns>The response from the AssociateResourceSharePermission service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidClientTokenException">
        /// A client token is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// A parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The format of an Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.OperationNotPermittedException">
        /// The requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The service is not available.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.UnknownResourceException">
        /// A specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/AssociateResourceSharePermission">REST API Reference for AssociateResourceSharePermission Operation</seealso>
        AssociateResourceSharePermissionResponse AssociateResourceSharePermission(AssociateResourceSharePermissionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateResourceSharePermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateResourceSharePermission operation on AmazonRAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateResourceSharePermission
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/AssociateResourceSharePermission">REST API Reference for AssociateResourceSharePermission Operation</seealso>
        IAsyncResult BeginAssociateResourceSharePermission(AssociateResourceSharePermissionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateResourceSharePermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateResourceSharePermission.</param>
        /// 
        /// <returns>Returns a  AssociateResourceSharePermissionResult from RAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/AssociateResourceSharePermission">REST API Reference for AssociateResourceSharePermission Operation</seealso>
        AssociateResourceSharePermissionResponse EndAssociateResourceSharePermission(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateResourceShare


        /// <summary>
        /// Creates a resource share.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResourceShare service method.</param>
        /// 
        /// <returns>The response from the CreateResourceShare service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.IdempotentParameterMismatchException">
        /// A client token input parameter was reused with an operation, but at least one of the
        /// other input parameters is different from the previous call to the operation.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidClientTokenException">
        /// A client token is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// A parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidStateTransitionException">
        /// The requested state transition is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The format of an Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.OperationNotPermittedException">
        /// The requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceShareLimitExceededException">
        /// The requested resource share exceeds the limit for your account.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The service is not available.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.TagPolicyViolationException">
        /// The specified tag is a reserved word and cannot be used.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.UnknownResourceException">
        /// A specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/CreateResourceShare">REST API Reference for CreateResourceShare Operation</seealso>
        CreateResourceShareResponse CreateResourceShare(CreateResourceShareRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateResourceShare operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateResourceShare operation on AmazonRAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateResourceShare
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/CreateResourceShare">REST API Reference for CreateResourceShare Operation</seealso>
        IAsyncResult BeginCreateResourceShare(CreateResourceShareRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateResourceShare operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateResourceShare.</param>
        /// 
        /// <returns>Returns a  CreateResourceShareResult from RAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/CreateResourceShare">REST API Reference for CreateResourceShare Operation</seealso>
        CreateResourceShareResponse EndCreateResourceShare(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteResourceShare


        /// <summary>
        /// Deletes the specified resource share.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourceShare service method.</param>
        /// 
        /// <returns>The response from the DeleteResourceShare service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.IdempotentParameterMismatchException">
        /// A client token input parameter was reused with an operation, but at least one of the
        /// other input parameters is different from the previous call to the operation.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidClientTokenException">
        /// A client token is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// A parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidStateTransitionException">
        /// The requested state transition is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The format of an Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.OperationNotPermittedException">
        /// The requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The service is not available.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.UnknownResourceException">
        /// A specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/DeleteResourceShare">REST API Reference for DeleteResourceShare Operation</seealso>
        DeleteResourceShareResponse DeleteResourceShare(DeleteResourceShareRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResourceShare operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourceShare operation on AmazonRAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteResourceShare
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/DeleteResourceShare">REST API Reference for DeleteResourceShare Operation</seealso>
        IAsyncResult BeginDeleteResourceShare(DeleteResourceShareRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteResourceShare operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteResourceShare.</param>
        /// 
        /// <returns>Returns a  DeleteResourceShareResult from RAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/DeleteResourceShare">REST API Reference for DeleteResourceShare Operation</seealso>
        DeleteResourceShareResponse EndDeleteResourceShare(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateResourceShare


        /// <summary>
        /// Disassociates the specified principals or resources from the specified resource share.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateResourceShare service method.</param>
        /// 
        /// <returns>The response from the DisassociateResourceShare service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.IdempotentParameterMismatchException">
        /// A client token input parameter was reused with an operation, but at least one of the
        /// other input parameters is different from the previous call to the operation.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidClientTokenException">
        /// A client token is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// A parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidStateTransitionException">
        /// The requested state transition is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The format of an Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.OperationNotPermittedException">
        /// The requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceShareLimitExceededException">
        /// The requested resource share exceeds the limit for your account.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The service is not available.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.UnknownResourceException">
        /// A specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/DisassociateResourceShare">REST API Reference for DisassociateResourceShare Operation</seealso>
        DisassociateResourceShareResponse DisassociateResourceShare(DisassociateResourceShareRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateResourceShare operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateResourceShare operation on AmazonRAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateResourceShare
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/DisassociateResourceShare">REST API Reference for DisassociateResourceShare Operation</seealso>
        IAsyncResult BeginDisassociateResourceShare(DisassociateResourceShareRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateResourceShare operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateResourceShare.</param>
        /// 
        /// <returns>Returns a  DisassociateResourceShareResult from RAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/DisassociateResourceShare">REST API Reference for DisassociateResourceShare Operation</seealso>
        DisassociateResourceShareResponse EndDisassociateResourceShare(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateResourceSharePermission


        /// <summary>
        /// Disassociates an AWS RAM permission from a resource share.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateResourceSharePermission service method.</param>
        /// 
        /// <returns>The response from the DisassociateResourceSharePermission service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidClientTokenException">
        /// A client token is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// A parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The format of an Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.OperationNotPermittedException">
        /// The requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The service is not available.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.UnknownResourceException">
        /// A specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/DisassociateResourceSharePermission">REST API Reference for DisassociateResourceSharePermission Operation</seealso>
        DisassociateResourceSharePermissionResponse DisassociateResourceSharePermission(DisassociateResourceSharePermissionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateResourceSharePermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateResourceSharePermission operation on AmazonRAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateResourceSharePermission
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/DisassociateResourceSharePermission">REST API Reference for DisassociateResourceSharePermission Operation</seealso>
        IAsyncResult BeginDisassociateResourceSharePermission(DisassociateResourceSharePermissionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateResourceSharePermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateResourceSharePermission.</param>
        /// 
        /// <returns>Returns a  DisassociateResourceSharePermissionResult from RAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/DisassociateResourceSharePermission">REST API Reference for DisassociateResourceSharePermission Operation</seealso>
        DisassociateResourceSharePermissionResponse EndDisassociateResourceSharePermission(IAsyncResult asyncResult);

        #endregion
        
        #region  EnableSharingWithAwsOrganization


        /// <summary>
        /// Enables resource sharing within your AWS Organization.
        /// 
        ///  
        /// <para>
        /// The caller must be the master account for the AWS Organization.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableSharingWithAwsOrganization service method.</param>
        /// 
        /// <returns>The response from the EnableSharingWithAwsOrganization service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.OperationNotPermittedException">
        /// The requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The service is not available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/EnableSharingWithAwsOrganization">REST API Reference for EnableSharingWithAwsOrganization Operation</seealso>
        EnableSharingWithAwsOrganizationResponse EnableSharingWithAwsOrganization(EnableSharingWithAwsOrganizationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EnableSharingWithAwsOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableSharingWithAwsOrganization operation on AmazonRAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableSharingWithAwsOrganization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/EnableSharingWithAwsOrganization">REST API Reference for EnableSharingWithAwsOrganization Operation</seealso>
        IAsyncResult BeginEnableSharingWithAwsOrganization(EnableSharingWithAwsOrganizationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EnableSharingWithAwsOrganization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableSharingWithAwsOrganization.</param>
        /// 
        /// <returns>Returns a  EnableSharingWithAwsOrganizationResult from RAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/EnableSharingWithAwsOrganization">REST API Reference for EnableSharingWithAwsOrganization Operation</seealso>
        EnableSharingWithAwsOrganizationResponse EndEnableSharingWithAwsOrganization(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPermission


        /// <summary>
        /// Gets the contents of an AWS RAM permission in JSON format.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPermission service method.</param>
        /// 
        /// <returns>The response from the GetPermission service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// A parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The format of an Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.OperationNotPermittedException">
        /// The requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The service is not available.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.UnknownResourceException">
        /// A specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/GetPermission">REST API Reference for GetPermission Operation</seealso>
        GetPermissionResponse GetPermission(GetPermissionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPermission operation on AmazonRAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPermission
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/GetPermission">REST API Reference for GetPermission Operation</seealso>
        IAsyncResult BeginGetPermission(GetPermissionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPermission.</param>
        /// 
        /// <returns>Returns a  GetPermissionResult from RAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/GetPermission">REST API Reference for GetPermission Operation</seealso>
        GetPermissionResponse EndGetPermission(IAsyncResult asyncResult);

        #endregion
        
        #region  GetResourcePolicies


        /// <summary>
        /// Gets the policies for the specified resources that you own and have shared.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicies service method.</param>
        /// 
        /// <returns>The response from the GetResourcePolicies service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidNextTokenException">
        /// The specified value for NextToken is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// A parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The format of an Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceArnNotFoundException">
        /// An Amazon Resource Name (ARN) was not found.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The service is not available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/GetResourcePolicies">REST API Reference for GetResourcePolicies Operation</seealso>
        GetResourcePoliciesResponse GetResourcePolicies(GetResourcePoliciesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourcePolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicies operation on AmazonRAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResourcePolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/GetResourcePolicies">REST API Reference for GetResourcePolicies Operation</seealso>
        IAsyncResult BeginGetResourcePolicies(GetResourcePoliciesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetResourcePolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResourcePolicies.</param>
        /// 
        /// <returns>Returns a  GetResourcePoliciesResult from RAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/GetResourcePolicies">REST API Reference for GetResourcePolicies Operation</seealso>
        GetResourcePoliciesResponse EndGetResourcePolicies(IAsyncResult asyncResult);

        #endregion
        
        #region  GetResourceShareAssociations


        /// <summary>
        /// Gets the resources or principals for the resource shares that you own.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceShareAssociations service method.</param>
        /// 
        /// <returns>The response from the GetResourceShareAssociations service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidNextTokenException">
        /// The specified value for NextToken is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// A parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The format of an Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.OperationNotPermittedException">
        /// The requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The service is not available.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.UnknownResourceException">
        /// A specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/GetResourceShareAssociations">REST API Reference for GetResourceShareAssociations Operation</seealso>
        GetResourceShareAssociationsResponse GetResourceShareAssociations(GetResourceShareAssociationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourceShareAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourceShareAssociations operation on AmazonRAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResourceShareAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/GetResourceShareAssociations">REST API Reference for GetResourceShareAssociations Operation</seealso>
        IAsyncResult BeginGetResourceShareAssociations(GetResourceShareAssociationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetResourceShareAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResourceShareAssociations.</param>
        /// 
        /// <returns>Returns a  GetResourceShareAssociationsResult from RAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/GetResourceShareAssociations">REST API Reference for GetResourceShareAssociations Operation</seealso>
        GetResourceShareAssociationsResponse EndGetResourceShareAssociations(IAsyncResult asyncResult);

        #endregion
        
        #region  GetResourceShareInvitations


        /// <summary>
        /// Gets the invitations for resource sharing that you've received.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceShareInvitations service method.</param>
        /// 
        /// <returns>The response from the GetResourceShareInvitations service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidMaxResultsException">
        /// The specified value for MaxResults is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidNextTokenException">
        /// The specified value for NextToken is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// A parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The format of an Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceShareInvitationArnNotFoundException">
        /// The Amazon Resource Name (ARN) for an invitation was not found.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The service is not available.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.UnknownResourceException">
        /// A specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/GetResourceShareInvitations">REST API Reference for GetResourceShareInvitations Operation</seealso>
        GetResourceShareInvitationsResponse GetResourceShareInvitations(GetResourceShareInvitationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourceShareInvitations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourceShareInvitations operation on AmazonRAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResourceShareInvitations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/GetResourceShareInvitations">REST API Reference for GetResourceShareInvitations Operation</seealso>
        IAsyncResult BeginGetResourceShareInvitations(GetResourceShareInvitationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetResourceShareInvitations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResourceShareInvitations.</param>
        /// 
        /// <returns>Returns a  GetResourceShareInvitationsResult from RAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/GetResourceShareInvitations">REST API Reference for GetResourceShareInvitations Operation</seealso>
        GetResourceShareInvitationsResponse EndGetResourceShareInvitations(IAsyncResult asyncResult);

        #endregion
        
        #region  GetResourceShares


        /// <summary>
        /// Gets the resource shares that you own or the resource shares that are shared with
        /// you.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceShares service method.</param>
        /// 
        /// <returns>The response from the GetResourceShares service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidNextTokenException">
        /// The specified value for NextToken is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// A parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The format of an Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The service is not available.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.UnknownResourceException">
        /// A specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/GetResourceShares">REST API Reference for GetResourceShares Operation</seealso>
        GetResourceSharesResponse GetResourceShares(GetResourceSharesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourceShares operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourceShares operation on AmazonRAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResourceShares
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/GetResourceShares">REST API Reference for GetResourceShares Operation</seealso>
        IAsyncResult BeginGetResourceShares(GetResourceSharesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetResourceShares operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResourceShares.</param>
        /// 
        /// <returns>Returns a  GetResourceSharesResult from RAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/GetResourceShares">REST API Reference for GetResourceShares Operation</seealso>
        GetResourceSharesResponse EndGetResourceShares(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPendingInvitationResources


        /// <summary>
        /// Lists the resources in a resource share that is shared with you but that the invitation
        /// is still pending for.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPendingInvitationResources service method.</param>
        /// 
        /// <returns>The response from the ListPendingInvitationResources service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidNextTokenException">
        /// The specified value for NextToken is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// A parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The format of an Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MissingRequiredParameterException">
        /// A required input parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceShareInvitationAlreadyRejectedException">
        /// The invitation was already rejected.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceShareInvitationArnNotFoundException">
        /// The Amazon Resource Name (ARN) for an invitation was not found.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceShareInvitationExpiredException">
        /// The invitation is expired.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The service is not available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/ListPendingInvitationResources">REST API Reference for ListPendingInvitationResources Operation</seealso>
        ListPendingInvitationResourcesResponse ListPendingInvitationResources(ListPendingInvitationResourcesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPendingInvitationResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPendingInvitationResources operation on AmazonRAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPendingInvitationResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/ListPendingInvitationResources">REST API Reference for ListPendingInvitationResources Operation</seealso>
        IAsyncResult BeginListPendingInvitationResources(ListPendingInvitationResourcesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPendingInvitationResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPendingInvitationResources.</param>
        /// 
        /// <returns>Returns a  ListPendingInvitationResourcesResult from RAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/ListPendingInvitationResources">REST API Reference for ListPendingInvitationResources Operation</seealso>
        ListPendingInvitationResourcesResponse EndListPendingInvitationResources(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPermissions


        /// <summary>
        /// Lists the AWS RAM permissions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPermissions service method.</param>
        /// 
        /// <returns>The response from the ListPermissions service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidNextTokenException">
        /// The specified value for NextToken is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// A parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.OperationNotPermittedException">
        /// The requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The service is not available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/ListPermissions">REST API Reference for ListPermissions Operation</seealso>
        ListPermissionsResponse ListPermissions(ListPermissionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPermissions operation on AmazonRAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/ListPermissions">REST API Reference for ListPermissions Operation</seealso>
        IAsyncResult BeginListPermissions(ListPermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPermissions.</param>
        /// 
        /// <returns>Returns a  ListPermissionsResult from RAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/ListPermissions">REST API Reference for ListPermissions Operation</seealso>
        ListPermissionsResponse EndListPermissions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPrincipals


        /// <summary>
        /// Lists the principals that you have shared resources with or that have shared resources
        /// with you.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPrincipals service method.</param>
        /// 
        /// <returns>The response from the ListPrincipals service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidNextTokenException">
        /// The specified value for NextToken is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// A parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The format of an Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The service is not available.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.UnknownResourceException">
        /// A specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/ListPrincipals">REST API Reference for ListPrincipals Operation</seealso>
        ListPrincipalsResponse ListPrincipals(ListPrincipalsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPrincipals operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPrincipals operation on AmazonRAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPrincipals
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/ListPrincipals">REST API Reference for ListPrincipals Operation</seealso>
        IAsyncResult BeginListPrincipals(ListPrincipalsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPrincipals operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPrincipals.</param>
        /// 
        /// <returns>Returns a  ListPrincipalsResult from RAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/ListPrincipals">REST API Reference for ListPrincipals Operation</seealso>
        ListPrincipalsResponse EndListPrincipals(IAsyncResult asyncResult);

        #endregion
        
        #region  ListResources


        /// <summary>
        /// Lists the resources that you added to a resource shares or the resources that are
        /// shared with you.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResources service method.</param>
        /// 
        /// <returns>The response from the ListResources service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidNextTokenException">
        /// The specified value for NextToken is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// A parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidResourceTypeException">
        /// The specified resource type is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The format of an Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The service is not available.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.UnknownResourceException">
        /// A specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/ListResources">REST API Reference for ListResources Operation</seealso>
        ListResourcesResponse ListResources(ListResourcesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResources operation on AmazonRAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/ListResources">REST API Reference for ListResources Operation</seealso>
        IAsyncResult BeginListResources(ListResourcesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResources.</param>
        /// 
        /// <returns>Returns a  ListResourcesResult from RAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/ListResources">REST API Reference for ListResources Operation</seealso>
        ListResourcesResponse EndListResources(IAsyncResult asyncResult);

        #endregion
        
        #region  ListResourceSharePermissions


        /// <summary>
        /// Lists the AWS RAM permissions that are associated with a resource share.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceSharePermissions service method.</param>
        /// 
        /// <returns>The response from the ListResourceSharePermissions service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidNextTokenException">
        /// The specified value for NextToken is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// A parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The format of an Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.OperationNotPermittedException">
        /// The requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The service is not available.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.UnknownResourceException">
        /// A specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/ListResourceSharePermissions">REST API Reference for ListResourceSharePermissions Operation</seealso>
        ListResourceSharePermissionsResponse ListResourceSharePermissions(ListResourceSharePermissionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListResourceSharePermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourceSharePermissions operation on AmazonRAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResourceSharePermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/ListResourceSharePermissions">REST API Reference for ListResourceSharePermissions Operation</seealso>
        IAsyncResult BeginListResourceSharePermissions(ListResourceSharePermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListResourceSharePermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResourceSharePermissions.</param>
        /// 
        /// <returns>Returns a  ListResourceSharePermissionsResult from RAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/ListResourceSharePermissions">REST API Reference for ListResourceSharePermissions Operation</seealso>
        ListResourceSharePermissionsResponse EndListResourceSharePermissions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListResourceTypes


        /// <summary>
        /// Lists the shareable resource types supported by AWS RAM.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceTypes service method.</param>
        /// 
        /// <returns>The response from the ListResourceTypes service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidNextTokenException">
        /// The specified value for NextToken is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// A parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The service is not available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/ListResourceTypes">REST API Reference for ListResourceTypes Operation</seealso>
        ListResourceTypesResponse ListResourceTypes(ListResourceTypesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListResourceTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourceTypes operation on AmazonRAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResourceTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/ListResourceTypes">REST API Reference for ListResourceTypes Operation</seealso>
        IAsyncResult BeginListResourceTypes(ListResourceTypesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListResourceTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResourceTypes.</param>
        /// 
        /// <returns>Returns a  ListResourceTypesResult from RAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/ListResourceTypes">REST API Reference for ListResourceTypes Operation</seealso>
        ListResourceTypesResponse EndListResourceTypes(IAsyncResult asyncResult);

        #endregion
        
        #region  PromoteResourceShareCreatedFromPolicy


        /// <summary>
        /// Resource shares that were created by attaching a policy to a resource are visible
        /// only to the resource share owner, and the resource share cannot be modified in AWS
        /// RAM.
        /// 
        ///  
        /// <para>
        /// Use this API action to promote the resource share. When you promote the resource share,
        /// it becomes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Visible to all principals that it is shared with.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Modifiable in AWS RAM.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PromoteResourceShareCreatedFromPolicy service method.</param>
        /// 
        /// <returns>The response from the PromoteResourceShareCreatedFromPolicy service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// A parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The format of an Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MissingRequiredParameterException">
        /// A required input parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.OperationNotPermittedException">
        /// The requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The service is not available.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.UnknownResourceException">
        /// A specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/PromoteResourceShareCreatedFromPolicy">REST API Reference for PromoteResourceShareCreatedFromPolicy Operation</seealso>
        PromoteResourceShareCreatedFromPolicyResponse PromoteResourceShareCreatedFromPolicy(PromoteResourceShareCreatedFromPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PromoteResourceShareCreatedFromPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PromoteResourceShareCreatedFromPolicy operation on AmazonRAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPromoteResourceShareCreatedFromPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/PromoteResourceShareCreatedFromPolicy">REST API Reference for PromoteResourceShareCreatedFromPolicy Operation</seealso>
        IAsyncResult BeginPromoteResourceShareCreatedFromPolicy(PromoteResourceShareCreatedFromPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PromoteResourceShareCreatedFromPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPromoteResourceShareCreatedFromPolicy.</param>
        /// 
        /// <returns>Returns a  PromoteResourceShareCreatedFromPolicyResult from RAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/PromoteResourceShareCreatedFromPolicy">REST API Reference for PromoteResourceShareCreatedFromPolicy Operation</seealso>
        PromoteResourceShareCreatedFromPolicyResponse EndPromoteResourceShareCreatedFromPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  RejectResourceShareInvitation


        /// <summary>
        /// Rejects an invitation to a resource share from another AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectResourceShareInvitation service method.</param>
        /// 
        /// <returns>The response from the RejectResourceShareInvitation service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.IdempotentParameterMismatchException">
        /// A client token input parameter was reused with an operation, but at least one of the
        /// other input parameters is different from the previous call to the operation.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidClientTokenException">
        /// A client token is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The format of an Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.OperationNotPermittedException">
        /// The requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceShareInvitationAlreadyAcceptedException">
        /// The invitation was already accepted.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceShareInvitationAlreadyRejectedException">
        /// The invitation was already rejected.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceShareInvitationArnNotFoundException">
        /// The Amazon Resource Name (ARN) for an invitation was not found.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceShareInvitationExpiredException">
        /// The invitation is expired.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The service is not available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/RejectResourceShareInvitation">REST API Reference for RejectResourceShareInvitation Operation</seealso>
        RejectResourceShareInvitationResponse RejectResourceShareInvitation(RejectResourceShareInvitationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RejectResourceShareInvitation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RejectResourceShareInvitation operation on AmazonRAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRejectResourceShareInvitation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/RejectResourceShareInvitation">REST API Reference for RejectResourceShareInvitation Operation</seealso>
        IAsyncResult BeginRejectResourceShareInvitation(RejectResourceShareInvitationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RejectResourceShareInvitation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRejectResourceShareInvitation.</param>
        /// 
        /// <returns>Returns a  RejectResourceShareInvitationResult from RAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/RejectResourceShareInvitation">REST API Reference for RejectResourceShareInvitation Operation</seealso>
        RejectResourceShareInvitationResponse EndRejectResourceShareInvitation(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds the specified tags to the specified resource share that you own.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// A parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The format of an Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ResourceArnNotFoundException">
        /// An Amazon Resource Name (ARN) was not found.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The service is not available.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.TagLimitExceededException">
        /// The requested tags exceed the limit for your account.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.TagPolicyViolationException">
        /// The specified tag is a reserved word and cannot be used.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonRAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from RAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes the specified tags from the specified resource share that you own.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// A parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The service is not available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonRAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from RAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateResourceShare


        /// <summary>
        /// Updates the specified resource share that you own.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourceShare service method.</param>
        /// 
        /// <returns>The response from the UpdateResourceShare service method, as returned by RAM.</returns>
        /// <exception cref="Amazon.RAM.Model.IdempotentParameterMismatchException">
        /// A client token input parameter was reused with an operation, but at least one of the
        /// other input parameters is different from the previous call to the operation.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidClientTokenException">
        /// A client token is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.InvalidParameterException">
        /// A parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MalformedArnException">
        /// The format of an Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.MissingRequiredParameterException">
        /// A required input parameter is missing.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.OperationNotPermittedException">
        /// The requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServerInternalException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.ServiceUnavailableException">
        /// The service is not available.
        /// </exception>
        /// <exception cref="Amazon.RAM.Model.UnknownResourceException">
        /// A specified resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/UpdateResourceShare">REST API Reference for UpdateResourceShare Operation</seealso>
        UpdateResourceShareResponse UpdateResourceShare(UpdateResourceShareRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateResourceShare operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourceShare operation on AmazonRAMClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateResourceShare
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/UpdateResourceShare">REST API Reference for UpdateResourceShare Operation</seealso>
        IAsyncResult BeginUpdateResourceShare(UpdateResourceShareRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateResourceShare operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateResourceShare.</param>
        /// 
        /// <returns>Returns a  UpdateResourceShareResult from RAM.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ram-2018-01-04/UpdateResourceShare">REST API Reference for UpdateResourceShare Operation</seealso>
        UpdateResourceShareResponse EndUpdateResourceShare(IAsyncResult asyncResult);

        #endregion
        
    }
}