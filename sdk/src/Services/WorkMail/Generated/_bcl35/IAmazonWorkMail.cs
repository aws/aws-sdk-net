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
 * Do not modify this file. This file is generated from the workmail-2017-10-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.WorkMail.Model;

#pragma warning disable CS1570
namespace Amazon.WorkMail
{
    /// <summary>
    /// <para>Interface for accessing WorkMail</para>
    ///
    /// WorkMail is a secure, managed business email and calendaring service with support
    /// for existing desktop and mobile email clients. You can access your email, contacts,
    /// and calendars using Microsoft Outlook, your browser, or other native iOS and Android
    /// email applications. You can integrate WorkMail with your existing corporate directory
    /// and control both the keys that encrypt your data and the location in which your data
    /// is stored.
    /// 
    ///  
    /// <para>
    /// The WorkMail API is designed for the following scenarios:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Listing and describing organizations
    /// </para>
    ///  </li> </ul> <ul> <li> 
    /// <para>
    /// Managing users
    /// </para>
    ///  </li> </ul> <ul> <li> 
    /// <para>
    /// Managing groups
    /// </para>
    ///  </li> </ul> <ul> <li> 
    /// <para>
    /// Managing resources
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// All WorkMail API operations are Amazon-authenticated and certificate-signed. They
    /// not only require the use of the AWS SDK, but also allow for the exclusive use of AWS
    /// Identity and Access Management users and roles to help facilitate access, trust, and
    /// permission policies. By creating a role and allowing an IAM user to access the WorkMail
    /// site, the IAM user gains full administrative visibility into the entire WorkMail organization
    /// (or as set in the IAM policy). This includes, but is not limited to, the ability to
    /// create, update, and delete users, groups, and resources. This allows developers to
    /// perform the scenarios listed above, as well as give users the ability to grant access
    /// on a selective basis using the IAM model.
    /// </para>
    /// </summary>
    public partial interface IAmazonWorkMail : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IWorkMailPaginatorFactory Paginators { get; }
#endif


        
        #region  AssociateDelegateToResource


        /// <summary>
        /// Adds a member (user or group) to the resource's set of delegates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateDelegateToResource service method.</param>
        /// 
        /// <returns>The response from the AssociateDelegateToResource service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on a user, group, or resource that isn't in the expected
        /// state, such as trying to delete an active user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.UnsupportedOperationException">
        /// You can't perform a write operation against a read-only directory.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/AssociateDelegateToResource">REST API Reference for AssociateDelegateToResource Operation</seealso>
        AssociateDelegateToResourceResponse AssociateDelegateToResource(AssociateDelegateToResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateDelegateToResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateDelegateToResource operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateDelegateToResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/AssociateDelegateToResource">REST API Reference for AssociateDelegateToResource Operation</seealso>
        IAsyncResult BeginAssociateDelegateToResource(AssociateDelegateToResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateDelegateToResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateDelegateToResource.</param>
        /// 
        /// <returns>Returns a  AssociateDelegateToResourceResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/AssociateDelegateToResource">REST API Reference for AssociateDelegateToResource Operation</seealso>
        AssociateDelegateToResourceResponse EndAssociateDelegateToResource(IAsyncResult asyncResult);

        #endregion
        
        #region  AssociateMemberToGroup


        /// <summary>
        /// Adds a member (user or group) to the group's set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateMemberToGroup service method.</param>
        /// 
        /// <returns>The response from the AssociateMemberToGroup service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryServiceAuthenticationFailedException">
        /// The directory service doesn't recognize the credentials supplied by WorkMail.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryUnavailableException">
        /// The directory is unavailable. It might be located in another Region or deleted.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on a user, group, or resource that isn't in the expected
        /// state, such as trying to delete an active user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.UnsupportedOperationException">
        /// You can't perform a write operation against a read-only directory.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/AssociateMemberToGroup">REST API Reference for AssociateMemberToGroup Operation</seealso>
        AssociateMemberToGroupResponse AssociateMemberToGroup(AssociateMemberToGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateMemberToGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateMemberToGroup operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateMemberToGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/AssociateMemberToGroup">REST API Reference for AssociateMemberToGroup Operation</seealso>
        IAsyncResult BeginAssociateMemberToGroup(AssociateMemberToGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateMemberToGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateMemberToGroup.</param>
        /// 
        /// <returns>Returns a  AssociateMemberToGroupResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/AssociateMemberToGroup">REST API Reference for AssociateMemberToGroup Operation</seealso>
        AssociateMemberToGroupResponse EndAssociateMemberToGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  AssumeImpersonationRole


        /// <summary>
        /// Assumes an impersonation role for the given WorkMail organization. This method returns
        /// an authentication token you can use to make impersonated calls.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssumeImpersonationRole service method.</param>
        /// 
        /// <returns>The response from the AssumeImpersonationRole service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/AssumeImpersonationRole">REST API Reference for AssumeImpersonationRole Operation</seealso>
        AssumeImpersonationRoleResponse AssumeImpersonationRole(AssumeImpersonationRoleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssumeImpersonationRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssumeImpersonationRole operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssumeImpersonationRole
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/AssumeImpersonationRole">REST API Reference for AssumeImpersonationRole Operation</seealso>
        IAsyncResult BeginAssumeImpersonationRole(AssumeImpersonationRoleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssumeImpersonationRole operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssumeImpersonationRole.</param>
        /// 
        /// <returns>Returns a  AssumeImpersonationRoleResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/AssumeImpersonationRole">REST API Reference for AssumeImpersonationRole Operation</seealso>
        AssumeImpersonationRoleResponse EndAssumeImpersonationRole(IAsyncResult asyncResult);

        #endregion
        
        #region  CancelMailboxExportJob


        /// <summary>
        /// Cancels a mailbox export job.
        /// 
        ///  <note> 
        /// <para>
        /// If the mailbox export job is near completion, it might not be possible to cancel it.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelMailboxExportJob service method.</param>
        /// 
        /// <returns>The response from the CancelMailboxExportJob service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CancelMailboxExportJob">REST API Reference for CancelMailboxExportJob Operation</seealso>
        CancelMailboxExportJobResponse CancelMailboxExportJob(CancelMailboxExportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelMailboxExportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelMailboxExportJob operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelMailboxExportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CancelMailboxExportJob">REST API Reference for CancelMailboxExportJob Operation</seealso>
        IAsyncResult BeginCancelMailboxExportJob(CancelMailboxExportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelMailboxExportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelMailboxExportJob.</param>
        /// 
        /// <returns>Returns a  CancelMailboxExportJobResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CancelMailboxExportJob">REST API Reference for CancelMailboxExportJob Operation</seealso>
        CancelMailboxExportJobResponse EndCancelMailboxExportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateAlias


        /// <summary>
        /// Adds an alias to the set of a given member (user or group) of WorkMail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAlias service method.</param>
        /// 
        /// <returns>The response from the CreateAlias service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EmailAddressInUseException">
        /// The email address that you're trying to assign is already created for a different
        /// user, group, or resource.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on a user, group, or resource that isn't in the expected
        /// state, such as trying to delete an active user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.LimitExceededException">
        /// The request exceeds the limit of the resource.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.MailDomainNotFoundException">
        /// The domain specified is not found in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.MailDomainStateException">
        /// After a domain has been added to the organization, it must be verified. The domain
        /// is not yet verified.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateAlias">REST API Reference for CreateAlias Operation</seealso>
        CreateAliasResponse CreateAlias(CreateAliasRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAlias operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateAlias">REST API Reference for CreateAlias Operation</seealso>
        IAsyncResult BeginCreateAlias(CreateAliasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAlias.</param>
        /// 
        /// <returns>Returns a  CreateAliasResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateAlias">REST API Reference for CreateAlias Operation</seealso>
        CreateAliasResponse EndCreateAlias(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateAvailabilityConfiguration


        /// <summary>
        /// Creates an <c>AvailabilityConfiguration</c> for the given WorkMail organization and
        /// domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAvailabilityConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateAvailabilityConfiguration service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.LimitExceededException">
        /// The request exceeds the limit of the resource.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.NameAvailabilityException">
        /// The user, group, or resource name isn't unique in WorkMail.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateAvailabilityConfiguration">REST API Reference for CreateAvailabilityConfiguration Operation</seealso>
        CreateAvailabilityConfigurationResponse CreateAvailabilityConfiguration(CreateAvailabilityConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAvailabilityConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAvailabilityConfiguration operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAvailabilityConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateAvailabilityConfiguration">REST API Reference for CreateAvailabilityConfiguration Operation</seealso>
        IAsyncResult BeginCreateAvailabilityConfiguration(CreateAvailabilityConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAvailabilityConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAvailabilityConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateAvailabilityConfigurationResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateAvailabilityConfiguration">REST API Reference for CreateAvailabilityConfiguration Operation</seealso>
        CreateAvailabilityConfigurationResponse EndCreateAvailabilityConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateGroup


        /// <summary>
        /// Creates a group that can be used in WorkMail by calling the <a>RegisterToWorkMail</a>
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup service method.</param>
        /// 
        /// <returns>The response from the CreateGroup service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryServiceAuthenticationFailedException">
        /// The directory service doesn't recognize the credentials supplied by WorkMail.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryUnavailableException">
        /// The directory is unavailable. It might be located in another Region or deleted.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.NameAvailabilityException">
        /// The user, group, or resource name isn't unique in WorkMail.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.ReservedNameException">
        /// This user, group, or resource name is not allowed in WorkMail.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.UnsupportedOperationException">
        /// You can't perform a write operation against a read-only directory.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        CreateGroupResponse CreateGroup(CreateGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        IAsyncResult BeginCreateGroup(CreateGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGroup.</param>
        /// 
        /// <returns>Returns a  CreateGroupResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        CreateGroupResponse EndCreateGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateIdentityCenterApplication


        /// <summary>
        /// Creates the WorkMail application in IAM Identity Center that can be used later in
        /// the WorkMail - IdC integration. For more information, see PutIdentityProviderConfiguration.
        /// This action does not affect the authentication settings for any WorkMail organizations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIdentityCenterApplication service method.</param>
        /// 
        /// <returns>The response from the CreateIdentityCenterApplication service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateIdentityCenterApplication">REST API Reference for CreateIdentityCenterApplication Operation</seealso>
        CreateIdentityCenterApplicationResponse CreateIdentityCenterApplication(CreateIdentityCenterApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateIdentityCenterApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIdentityCenterApplication operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateIdentityCenterApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateIdentityCenterApplication">REST API Reference for CreateIdentityCenterApplication Operation</seealso>
        IAsyncResult BeginCreateIdentityCenterApplication(CreateIdentityCenterApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateIdentityCenterApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateIdentityCenterApplication.</param>
        /// 
        /// <returns>Returns a  CreateIdentityCenterApplicationResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateIdentityCenterApplication">REST API Reference for CreateIdentityCenterApplication Operation</seealso>
        CreateIdentityCenterApplicationResponse EndCreateIdentityCenterApplication(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateImpersonationRole


        /// <summary>
        /// Creates an impersonation role for the given WorkMail organization.
        /// 
        ///  
        /// <para>
        ///  <i>Idempotency</i> ensures that an API request completes no more than one time. With
        /// an idempotent request, if the original request completes successfully, any subsequent
        /// retries also complete successfully without performing any further actions.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateImpersonationRole service method.</param>
        /// 
        /// <returns>The response from the CreateImpersonationRole service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on a user, group, or resource that isn't in the expected
        /// state, such as trying to delete an active user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.LimitExceededException">
        /// The request exceeds the limit of the resource.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateImpersonationRole">REST API Reference for CreateImpersonationRole Operation</seealso>
        CreateImpersonationRoleResponse CreateImpersonationRole(CreateImpersonationRoleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateImpersonationRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateImpersonationRole operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateImpersonationRole
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateImpersonationRole">REST API Reference for CreateImpersonationRole Operation</seealso>
        IAsyncResult BeginCreateImpersonationRole(CreateImpersonationRoleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateImpersonationRole operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateImpersonationRole.</param>
        /// 
        /// <returns>Returns a  CreateImpersonationRoleResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateImpersonationRole">REST API Reference for CreateImpersonationRole Operation</seealso>
        CreateImpersonationRoleResponse EndCreateImpersonationRole(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateMobileDeviceAccessRule


        /// <summary>
        /// Creates a new mobile device access rule for the specified WorkMail organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMobileDeviceAccessRule service method.</param>
        /// 
        /// <returns>The response from the CreateMobileDeviceAccessRule service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.LimitExceededException">
        /// The request exceeds the limit of the resource.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateMobileDeviceAccessRule">REST API Reference for CreateMobileDeviceAccessRule Operation</seealso>
        CreateMobileDeviceAccessRuleResponse CreateMobileDeviceAccessRule(CreateMobileDeviceAccessRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMobileDeviceAccessRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMobileDeviceAccessRule operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMobileDeviceAccessRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateMobileDeviceAccessRule">REST API Reference for CreateMobileDeviceAccessRule Operation</seealso>
        IAsyncResult BeginCreateMobileDeviceAccessRule(CreateMobileDeviceAccessRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMobileDeviceAccessRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMobileDeviceAccessRule.</param>
        /// 
        /// <returns>Returns a  CreateMobileDeviceAccessRuleResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateMobileDeviceAccessRule">REST API Reference for CreateMobileDeviceAccessRule Operation</seealso>
        CreateMobileDeviceAccessRuleResponse EndCreateMobileDeviceAccessRule(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateOrganization


        /// <summary>
        /// Creates a new WorkMail organization. Optionally, you can choose to associate an existing
        /// AWS Directory Service directory with your organization. If an AWS Directory Service
        /// directory ID is specified, the organization alias must match the directory alias.
        /// If you choose not to associate an existing directory with your organization, then
        /// we create a new WorkMail directory for you. For more information, see <a href="https://docs.aws.amazon.com/workmail/latest/adminguide/add_new_organization.html">Adding
        /// an organization</a> in the <i>WorkMail Administrator Guide</i>.
        /// 
        ///  
        /// <para>
        /// You can associate multiple email domains with an organization, then choose your default
        /// email domain from the WorkMail console. You can also associate a domain that is managed
        /// in an Amazon Route 53 public hosted zone. For more information, see <a href="https://docs.aws.amazon.com/workmail/latest/adminguide/add_domain.html">Adding
        /// a domain</a> and <a href="https://docs.aws.amazon.com/workmail/latest/adminguide/default_domain.html">Choosing
        /// the default domain</a> in the <i>WorkMail Administrator Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Optionally, you can use a customer managed key from AWS Key Management Service (AWS
        /// KMS) to encrypt email for your organization. If you don't associate an AWS KMS key,
        /// WorkMail creates a default, AWS managed key for you.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOrganization service method.</param>
        /// 
        /// <returns>The response from the CreateOrganization service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryInUseException">
        /// The directory is already in use by another WorkMail organization in the same account
        /// and Region.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryUnavailableException">
        /// The directory is unavailable. It might be located in another Region or deleted.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.LimitExceededException">
        /// The request exceeds the limit of the resource.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.NameAvailabilityException">
        /// The user, group, or resource name isn't unique in WorkMail.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateOrganization">REST API Reference for CreateOrganization Operation</seealso>
        CreateOrganizationResponse CreateOrganization(CreateOrganizationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateOrganization operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateOrganization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateOrganization">REST API Reference for CreateOrganization Operation</seealso>
        IAsyncResult BeginCreateOrganization(CreateOrganizationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateOrganization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateOrganization.</param>
        /// 
        /// <returns>Returns a  CreateOrganizationResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateOrganization">REST API Reference for CreateOrganization Operation</seealso>
        CreateOrganizationResponse EndCreateOrganization(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateResource


        /// <summary>
        /// Creates a new WorkMail resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResource service method.</param>
        /// 
        /// <returns>The response from the CreateResource service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryServiceAuthenticationFailedException">
        /// The directory service doesn't recognize the credentials supplied by WorkMail.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryUnavailableException">
        /// The directory is unavailable. It might be located in another Region or deleted.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.NameAvailabilityException">
        /// The user, group, or resource name isn't unique in WorkMail.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.ReservedNameException">
        /// This user, group, or resource name is not allowed in WorkMail.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.UnsupportedOperationException">
        /// You can't perform a write operation against a read-only directory.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateResource">REST API Reference for CreateResource Operation</seealso>
        CreateResourceResponse CreateResource(CreateResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateResource operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateResource">REST API Reference for CreateResource Operation</seealso>
        IAsyncResult BeginCreateResource(CreateResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateResource.</param>
        /// 
        /// <returns>Returns a  CreateResourceResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateResource">REST API Reference for CreateResource Operation</seealso>
        CreateResourceResponse EndCreateResource(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateUser


        /// <summary>
        /// Creates a user who can be used in WorkMail by calling the <a>RegisterToWorkMail</a>
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUser service method.</param>
        /// 
        /// <returns>The response from the CreateUser service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryServiceAuthenticationFailedException">
        /// The directory service doesn't recognize the credentials supplied by WorkMail.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryUnavailableException">
        /// The directory is unavailable. It might be located in another Region or deleted.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidPasswordException">
        /// The supplied password doesn't match the minimum security constraints, such as length
        /// or use of special characters.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.NameAvailabilityException">
        /// The user, group, or resource name isn't unique in WorkMail.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.ReservedNameException">
        /// This user, group, or resource name is not allowed in WorkMail.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.UnsupportedOperationException">
        /// You can't perform a write operation against a read-only directory.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateUser">REST API Reference for CreateUser Operation</seealso>
        CreateUserResponse CreateUser(CreateUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUser operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateUser">REST API Reference for CreateUser Operation</seealso>
        IAsyncResult BeginCreateUser(CreateUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUser.</param>
        /// 
        /// <returns>Returns a  CreateUserResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateUser">REST API Reference for CreateUser Operation</seealso>
        CreateUserResponse EndCreateUser(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAccessControlRule


        /// <summary>
        /// Deletes an access control rule for the specified WorkMail organization.
        /// 
        ///  <note> 
        /// <para>
        /// Deleting already deleted and non-existing rules does not produce an error. In those
        /// cases, the service sends back an HTTP 200 response with an empty HTTP body.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessControlRule service method.</param>
        /// 
        /// <returns>The response from the DeleteAccessControlRule service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteAccessControlRule">REST API Reference for DeleteAccessControlRule Operation</seealso>
        DeleteAccessControlRuleResponse DeleteAccessControlRule(DeleteAccessControlRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccessControlRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessControlRule operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAccessControlRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteAccessControlRule">REST API Reference for DeleteAccessControlRule Operation</seealso>
        IAsyncResult BeginDeleteAccessControlRule(DeleteAccessControlRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAccessControlRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAccessControlRule.</param>
        /// 
        /// <returns>Returns a  DeleteAccessControlRuleResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteAccessControlRule">REST API Reference for DeleteAccessControlRule Operation</seealso>
        DeleteAccessControlRuleResponse EndDeleteAccessControlRule(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAlias


        /// <summary>
        /// Remove one or more specified aliases from a set of aliases for a given user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlias service method.</param>
        /// 
        /// <returns>The response from the DeleteAlias service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on a user, group, or resource that isn't in the expected
        /// state, such as trying to delete an active user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteAlias">REST API Reference for DeleteAlias Operation</seealso>
        DeleteAliasResponse DeleteAlias(DeleteAliasRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlias operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteAlias">REST API Reference for DeleteAlias Operation</seealso>
        IAsyncResult BeginDeleteAlias(DeleteAliasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAlias.</param>
        /// 
        /// <returns>Returns a  DeleteAliasResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteAlias">REST API Reference for DeleteAlias Operation</seealso>
        DeleteAliasResponse EndDeleteAlias(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAvailabilityConfiguration


        /// <summary>
        /// Deletes the <c>AvailabilityConfiguration</c> for the given WorkMail organization and
        /// domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAvailabilityConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteAvailabilityConfiguration service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteAvailabilityConfiguration">REST API Reference for DeleteAvailabilityConfiguration Operation</seealso>
        DeleteAvailabilityConfigurationResponse DeleteAvailabilityConfiguration(DeleteAvailabilityConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAvailabilityConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAvailabilityConfiguration operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAvailabilityConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteAvailabilityConfiguration">REST API Reference for DeleteAvailabilityConfiguration Operation</seealso>
        IAsyncResult BeginDeleteAvailabilityConfiguration(DeleteAvailabilityConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAvailabilityConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAvailabilityConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteAvailabilityConfigurationResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteAvailabilityConfiguration">REST API Reference for DeleteAvailabilityConfiguration Operation</seealso>
        DeleteAvailabilityConfigurationResponse EndDeleteAvailabilityConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteEmailMonitoringConfiguration


        /// <summary>
        /// Deletes the email monitoring configuration for a specified organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEmailMonitoringConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteEmailMonitoringConfiguration service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteEmailMonitoringConfiguration">REST API Reference for DeleteEmailMonitoringConfiguration Operation</seealso>
        DeleteEmailMonitoringConfigurationResponse DeleteEmailMonitoringConfiguration(DeleteEmailMonitoringConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEmailMonitoringConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEmailMonitoringConfiguration operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEmailMonitoringConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteEmailMonitoringConfiguration">REST API Reference for DeleteEmailMonitoringConfiguration Operation</seealso>
        IAsyncResult BeginDeleteEmailMonitoringConfiguration(DeleteEmailMonitoringConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEmailMonitoringConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEmailMonitoringConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteEmailMonitoringConfigurationResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteEmailMonitoringConfiguration">REST API Reference for DeleteEmailMonitoringConfiguration Operation</seealso>
        DeleteEmailMonitoringConfigurationResponse EndDeleteEmailMonitoringConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteGroup


        /// <summary>
        /// Deletes a group from WorkMail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteGroup service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryServiceAuthenticationFailedException">
        /// The directory service doesn't recognize the credentials supplied by WorkMail.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryUnavailableException">
        /// The directory is unavailable. It might be located in another Region or deleted.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on a user, group, or resource that isn't in the expected
        /// state, such as trying to delete an active user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.UnsupportedOperationException">
        /// You can't perform a write operation against a read-only directory.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        DeleteGroupResponse DeleteGroup(DeleteGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        IAsyncResult BeginDeleteGroup(DeleteGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGroup.</param>
        /// 
        /// <returns>Returns a  DeleteGroupResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        DeleteGroupResponse EndDeleteGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteIdentityCenterApplication


        /// <summary>
        /// Deletes the IAM Identity Center application from WorkMail. This action does not affect
        /// the authentication settings for any WorkMail organizations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdentityCenterApplication service method.</param>
        /// 
        /// <returns>The response from the DeleteIdentityCenterApplication service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteIdentityCenterApplication">REST API Reference for DeleteIdentityCenterApplication Operation</seealso>
        DeleteIdentityCenterApplicationResponse DeleteIdentityCenterApplication(DeleteIdentityCenterApplicationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIdentityCenterApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdentityCenterApplication operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteIdentityCenterApplication
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteIdentityCenterApplication">REST API Reference for DeleteIdentityCenterApplication Operation</seealso>
        IAsyncResult BeginDeleteIdentityCenterApplication(DeleteIdentityCenterApplicationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIdentityCenterApplication operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIdentityCenterApplication.</param>
        /// 
        /// <returns>Returns a  DeleteIdentityCenterApplicationResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteIdentityCenterApplication">REST API Reference for DeleteIdentityCenterApplication Operation</seealso>
        DeleteIdentityCenterApplicationResponse EndDeleteIdentityCenterApplication(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteIdentityProviderConfiguration


        /// <summary>
        /// Disables the integration between IdC and WorkMail. Authentication will continue with
        /// the directory as it was before the IdC integration. You might have to reset your directory
        /// passwords and reconfigure your desktop and mobile email clients.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdentityProviderConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteIdentityProviderConfiguration service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteIdentityProviderConfiguration">REST API Reference for DeleteIdentityProviderConfiguration Operation</seealso>
        DeleteIdentityProviderConfigurationResponse DeleteIdentityProviderConfiguration(DeleteIdentityProviderConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIdentityProviderConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdentityProviderConfiguration operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteIdentityProviderConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteIdentityProviderConfiguration">REST API Reference for DeleteIdentityProviderConfiguration Operation</seealso>
        IAsyncResult BeginDeleteIdentityProviderConfiguration(DeleteIdentityProviderConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIdentityProviderConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIdentityProviderConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteIdentityProviderConfigurationResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteIdentityProviderConfiguration">REST API Reference for DeleteIdentityProviderConfiguration Operation</seealso>
        DeleteIdentityProviderConfigurationResponse EndDeleteIdentityProviderConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteImpersonationRole


        /// <summary>
        /// Deletes an impersonation role for the given WorkMail organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteImpersonationRole service method.</param>
        /// 
        /// <returns>The response from the DeleteImpersonationRole service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteImpersonationRole">REST API Reference for DeleteImpersonationRole Operation</seealso>
        DeleteImpersonationRoleResponse DeleteImpersonationRole(DeleteImpersonationRoleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteImpersonationRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteImpersonationRole operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteImpersonationRole
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteImpersonationRole">REST API Reference for DeleteImpersonationRole Operation</seealso>
        IAsyncResult BeginDeleteImpersonationRole(DeleteImpersonationRoleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteImpersonationRole operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteImpersonationRole.</param>
        /// 
        /// <returns>Returns a  DeleteImpersonationRoleResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteImpersonationRole">REST API Reference for DeleteImpersonationRole Operation</seealso>
        DeleteImpersonationRoleResponse EndDeleteImpersonationRole(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteMailboxPermissions


        /// <summary>
        /// Deletes permissions granted to a member (user or group).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMailboxPermissions service method.</param>
        /// 
        /// <returns>The response from the DeleteMailboxPermissions service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on a user, group, or resource that isn't in the expected
        /// state, such as trying to delete an active user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteMailboxPermissions">REST API Reference for DeleteMailboxPermissions Operation</seealso>
        DeleteMailboxPermissionsResponse DeleteMailboxPermissions(DeleteMailboxPermissionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMailboxPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMailboxPermissions operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMailboxPermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteMailboxPermissions">REST API Reference for DeleteMailboxPermissions Operation</seealso>
        IAsyncResult BeginDeleteMailboxPermissions(DeleteMailboxPermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMailboxPermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMailboxPermissions.</param>
        /// 
        /// <returns>Returns a  DeleteMailboxPermissionsResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteMailboxPermissions">REST API Reference for DeleteMailboxPermissions Operation</seealso>
        DeleteMailboxPermissionsResponse EndDeleteMailboxPermissions(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteMobileDeviceAccessOverride


        /// <summary>
        /// Deletes the mobile device access override for the given WorkMail organization, user,
        /// and device.
        /// 
        ///  <note> 
        /// <para>
        /// Deleting already deleted and non-existing overrides does not produce an error. In
        /// those cases, the service sends back an HTTP 200 response with an empty HTTP body.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMobileDeviceAccessOverride service method.</param>
        /// 
        /// <returns>The response from the DeleteMobileDeviceAccessOverride service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteMobileDeviceAccessOverride">REST API Reference for DeleteMobileDeviceAccessOverride Operation</seealso>
        DeleteMobileDeviceAccessOverrideResponse DeleteMobileDeviceAccessOverride(DeleteMobileDeviceAccessOverrideRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMobileDeviceAccessOverride operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMobileDeviceAccessOverride operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMobileDeviceAccessOverride
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteMobileDeviceAccessOverride">REST API Reference for DeleteMobileDeviceAccessOverride Operation</seealso>
        IAsyncResult BeginDeleteMobileDeviceAccessOverride(DeleteMobileDeviceAccessOverrideRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMobileDeviceAccessOverride operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMobileDeviceAccessOverride.</param>
        /// 
        /// <returns>Returns a  DeleteMobileDeviceAccessOverrideResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteMobileDeviceAccessOverride">REST API Reference for DeleteMobileDeviceAccessOverride Operation</seealso>
        DeleteMobileDeviceAccessOverrideResponse EndDeleteMobileDeviceAccessOverride(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteMobileDeviceAccessRule


        /// <summary>
        /// Deletes a mobile device access rule for the specified WorkMail organization.
        /// 
        ///  <note> 
        /// <para>
        /// Deleting already deleted and non-existing rules does not produce an error. In those
        /// cases, the service sends back an HTTP 200 response with an empty HTTP body.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMobileDeviceAccessRule service method.</param>
        /// 
        /// <returns>The response from the DeleteMobileDeviceAccessRule service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteMobileDeviceAccessRule">REST API Reference for DeleteMobileDeviceAccessRule Operation</seealso>
        DeleteMobileDeviceAccessRuleResponse DeleteMobileDeviceAccessRule(DeleteMobileDeviceAccessRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMobileDeviceAccessRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMobileDeviceAccessRule operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMobileDeviceAccessRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteMobileDeviceAccessRule">REST API Reference for DeleteMobileDeviceAccessRule Operation</seealso>
        IAsyncResult BeginDeleteMobileDeviceAccessRule(DeleteMobileDeviceAccessRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMobileDeviceAccessRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMobileDeviceAccessRule.</param>
        /// 
        /// <returns>Returns a  DeleteMobileDeviceAccessRuleResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteMobileDeviceAccessRule">REST API Reference for DeleteMobileDeviceAccessRule Operation</seealso>
        DeleteMobileDeviceAccessRuleResponse EndDeleteMobileDeviceAccessRule(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteOrganization


        /// <summary>
        /// Deletes an WorkMail organization and all underlying AWS resources managed by WorkMail
        /// as part of the organization. You can choose whether to delete the associated directory.
        /// For more information, see <a href="https://docs.aws.amazon.com/workmail/latest/adminguide/remove_organization.html">Removing
        /// an organization</a> in the <i>WorkMail Administrator Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOrganization service method.</param>
        /// 
        /// <returns>The response from the DeleteOrganization service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteOrganization">REST API Reference for DeleteOrganization Operation</seealso>
        DeleteOrganizationResponse DeleteOrganization(DeleteOrganizationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteOrganization operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteOrganization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteOrganization">REST API Reference for DeleteOrganization Operation</seealso>
        IAsyncResult BeginDeleteOrganization(DeleteOrganizationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteOrganization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteOrganization.</param>
        /// 
        /// <returns>Returns a  DeleteOrganizationResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteOrganization">REST API Reference for DeleteOrganization Operation</seealso>
        DeleteOrganizationResponse EndDeleteOrganization(IAsyncResult asyncResult);

        #endregion
        
        #region  DeletePersonalAccessToken


        /// <summary>
        /// Deletes the Personal Access Token from the provided WorkMail Organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePersonalAccessToken service method.</param>
        /// 
        /// <returns>The response from the DeletePersonalAccessToken service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeletePersonalAccessToken">REST API Reference for DeletePersonalAccessToken Operation</seealso>
        DeletePersonalAccessTokenResponse DeletePersonalAccessToken(DeletePersonalAccessTokenRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePersonalAccessToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePersonalAccessToken operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePersonalAccessToken
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeletePersonalAccessToken">REST API Reference for DeletePersonalAccessToken Operation</seealso>
        IAsyncResult BeginDeletePersonalAccessToken(DeletePersonalAccessTokenRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePersonalAccessToken operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePersonalAccessToken.</param>
        /// 
        /// <returns>Returns a  DeletePersonalAccessTokenResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeletePersonalAccessToken">REST API Reference for DeletePersonalAccessToken Operation</seealso>
        DeletePersonalAccessTokenResponse EndDeletePersonalAccessToken(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteResource


        /// <summary>
        /// Deletes the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResource service method.</param>
        /// 
        /// <returns>The response from the DeleteResource service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on a user, group, or resource that isn't in the expected
        /// state, such as trying to delete an active user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.UnsupportedOperationException">
        /// You can't perform a write operation against a read-only directory.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteResource">REST API Reference for DeleteResource Operation</seealso>
        DeleteResourceResponse DeleteResource(DeleteResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResource operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteResource">REST API Reference for DeleteResource Operation</seealso>
        IAsyncResult BeginDeleteResource(DeleteResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteResource.</param>
        /// 
        /// <returns>Returns a  DeleteResourceResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteResource">REST API Reference for DeleteResource Operation</seealso>
        DeleteResourceResponse EndDeleteResource(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteRetentionPolicy


        /// <summary>
        /// Deletes the specified retention policy from the specified organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRetentionPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteRetentionPolicy service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteRetentionPolicy">REST API Reference for DeleteRetentionPolicy Operation</seealso>
        DeleteRetentionPolicyResponse DeleteRetentionPolicy(DeleteRetentionPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRetentionPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRetentionPolicy operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRetentionPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteRetentionPolicy">REST API Reference for DeleteRetentionPolicy Operation</seealso>
        IAsyncResult BeginDeleteRetentionPolicy(DeleteRetentionPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRetentionPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRetentionPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteRetentionPolicyResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteRetentionPolicy">REST API Reference for DeleteRetentionPolicy Operation</seealso>
        DeleteRetentionPolicyResponse EndDeleteRetentionPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteUser


        /// <summary>
        /// Deletes a user from WorkMail and all subsequent systems. Before you can delete a user,
        /// the user state must be <c>DISABLED</c>. Use the <a>DescribeUser</a> action to confirm
        /// the user state.
        /// 
        ///  
        /// <para>
        /// Deleting a user is permanent and cannot be undone. WorkMail archives user mailboxes
        /// for 30 days before they are permanently removed.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser service method.</param>
        /// 
        /// <returns>The response from the DeleteUser service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryServiceAuthenticationFailedException">
        /// The directory service doesn't recognize the credentials supplied by WorkMail.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryUnavailableException">
        /// The directory is unavailable. It might be located in another Region or deleted.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on a user, group, or resource that isn't in the expected
        /// state, such as trying to delete an active user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.UnsupportedOperationException">
        /// You can't perform a write operation against a read-only directory.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        DeleteUserResponse DeleteUser(DeleteUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        IAsyncResult BeginDeleteUser(DeleteUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUser.</param>
        /// 
        /// <returns>Returns a  DeleteUserResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        DeleteUserResponse EndDeleteUser(IAsyncResult asyncResult);

        #endregion
        
        #region  DeregisterFromWorkMail


        /// <summary>
        /// Mark a user, group, or resource as no longer used in WorkMail. This action disassociates
        /// the mailbox and schedules it for clean-up. WorkMail keeps mailboxes for 30 days before
        /// they are permanently removed. The functionality in the console is <i>Disable</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterFromWorkMail service method.</param>
        /// 
        /// <returns>The response from the DeregisterFromWorkMail service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on a user, group, or resource that isn't in the expected
        /// state, such as trying to delete an active user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeregisterFromWorkMail">REST API Reference for DeregisterFromWorkMail Operation</seealso>
        DeregisterFromWorkMailResponse DeregisterFromWorkMail(DeregisterFromWorkMailRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterFromWorkMail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterFromWorkMail operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterFromWorkMail
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeregisterFromWorkMail">REST API Reference for DeregisterFromWorkMail Operation</seealso>
        IAsyncResult BeginDeregisterFromWorkMail(DeregisterFromWorkMailRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterFromWorkMail operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterFromWorkMail.</param>
        /// 
        /// <returns>Returns a  DeregisterFromWorkMailResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeregisterFromWorkMail">REST API Reference for DeregisterFromWorkMail Operation</seealso>
        DeregisterFromWorkMailResponse EndDeregisterFromWorkMail(IAsyncResult asyncResult);

        #endregion
        
        #region  DeregisterMailDomain


        /// <summary>
        /// Removes a domain from WorkMail, stops email routing to WorkMail, and removes the authorization
        /// allowing WorkMail use. SES keeps the domain because other applications may use it.
        /// You must first remove any email address used by WorkMail entities before you remove
        /// the domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterMailDomain service method.</param>
        /// 
        /// <returns>The response from the DeregisterMailDomain service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.InvalidCustomSesConfigurationException">
        /// You SES configuration has customizations that WorkMail cannot save. The error message
        /// lists the invalid setting. For examples of invalid settings, refer to <a href="https://docs.aws.amazon.com/ses/latest/APIReference/API_CreateReceiptRule.html">CreateReceiptRule</a>.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.MailDomainInUseException">
        /// The domain you're trying to change is in use by another user or organization in your
        /// account. See the error message for details.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeregisterMailDomain">REST API Reference for DeregisterMailDomain Operation</seealso>
        DeregisterMailDomainResponse DeregisterMailDomain(DeregisterMailDomainRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterMailDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterMailDomain operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterMailDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeregisterMailDomain">REST API Reference for DeregisterMailDomain Operation</seealso>
        IAsyncResult BeginDeregisterMailDomain(DeregisterMailDomainRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterMailDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterMailDomain.</param>
        /// 
        /// <returns>Returns a  DeregisterMailDomainResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeregisterMailDomain">REST API Reference for DeregisterMailDomain Operation</seealso>
        DeregisterMailDomainResponse EndDeregisterMailDomain(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeEmailMonitoringConfiguration


        /// <summary>
        /// Describes the current email monitoring configuration for a specified organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEmailMonitoringConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeEmailMonitoringConfiguration service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DescribeEmailMonitoringConfiguration">REST API Reference for DescribeEmailMonitoringConfiguration Operation</seealso>
        DescribeEmailMonitoringConfigurationResponse DescribeEmailMonitoringConfiguration(DescribeEmailMonitoringConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEmailMonitoringConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEmailMonitoringConfiguration operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEmailMonitoringConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DescribeEmailMonitoringConfiguration">REST API Reference for DescribeEmailMonitoringConfiguration Operation</seealso>
        IAsyncResult BeginDescribeEmailMonitoringConfiguration(DescribeEmailMonitoringConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEmailMonitoringConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEmailMonitoringConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeEmailMonitoringConfigurationResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DescribeEmailMonitoringConfiguration">REST API Reference for DescribeEmailMonitoringConfiguration Operation</seealso>
        DescribeEmailMonitoringConfigurationResponse EndDescribeEmailMonitoringConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeEntity


        /// <summary>
        /// Returns basic details about an entity in WorkMail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEntity service method.</param>
        /// 
        /// <returns>The response from the DescribeEntity service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DescribeEntity">REST API Reference for DescribeEntity Operation</seealso>
        DescribeEntityResponse DescribeEntity(DescribeEntityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEntity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEntity operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEntity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DescribeEntity">REST API Reference for DescribeEntity Operation</seealso>
        IAsyncResult BeginDescribeEntity(DescribeEntityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEntity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEntity.</param>
        /// 
        /// <returns>Returns a  DescribeEntityResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DescribeEntity">REST API Reference for DescribeEntity Operation</seealso>
        DescribeEntityResponse EndDescribeEntity(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeGroup


        /// <summary>
        /// Returns the data available for the group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGroup service method.</param>
        /// 
        /// <returns>The response from the DescribeGroup service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DescribeGroup">REST API Reference for DescribeGroup Operation</seealso>
        DescribeGroupResponse DescribeGroup(DescribeGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGroup operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DescribeGroup">REST API Reference for DescribeGroup Operation</seealso>
        IAsyncResult BeginDescribeGroup(DescribeGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeGroup.</param>
        /// 
        /// <returns>Returns a  DescribeGroupResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DescribeGroup">REST API Reference for DescribeGroup Operation</seealso>
        DescribeGroupResponse EndDescribeGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeIdentityProviderConfiguration


        /// <summary>
        /// Returns detailed information on the current IdC setup for the WorkMail organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdentityProviderConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeIdentityProviderConfiguration service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DescribeIdentityProviderConfiguration">REST API Reference for DescribeIdentityProviderConfiguration Operation</seealso>
        DescribeIdentityProviderConfigurationResponse DescribeIdentityProviderConfiguration(DescribeIdentityProviderConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeIdentityProviderConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdentityProviderConfiguration operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeIdentityProviderConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DescribeIdentityProviderConfiguration">REST API Reference for DescribeIdentityProviderConfiguration Operation</seealso>
        IAsyncResult BeginDescribeIdentityProviderConfiguration(DescribeIdentityProviderConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeIdentityProviderConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeIdentityProviderConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeIdentityProviderConfigurationResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DescribeIdentityProviderConfiguration">REST API Reference for DescribeIdentityProviderConfiguration Operation</seealso>
        DescribeIdentityProviderConfigurationResponse EndDescribeIdentityProviderConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeInboundDmarcSettings


        /// <summary>
        /// Lists the settings in a DMARC policy for a specified organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInboundDmarcSettings service method.</param>
        /// 
        /// <returns>The response from the DescribeInboundDmarcSettings service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DescribeInboundDmarcSettings">REST API Reference for DescribeInboundDmarcSettings Operation</seealso>
        DescribeInboundDmarcSettingsResponse DescribeInboundDmarcSettings(DescribeInboundDmarcSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInboundDmarcSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInboundDmarcSettings operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInboundDmarcSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DescribeInboundDmarcSettings">REST API Reference for DescribeInboundDmarcSettings Operation</seealso>
        IAsyncResult BeginDescribeInboundDmarcSettings(DescribeInboundDmarcSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInboundDmarcSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInboundDmarcSettings.</param>
        /// 
        /// <returns>Returns a  DescribeInboundDmarcSettingsResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DescribeInboundDmarcSettings">REST API Reference for DescribeInboundDmarcSettings Operation</seealso>
        DescribeInboundDmarcSettingsResponse EndDescribeInboundDmarcSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeMailboxExportJob


        /// <summary>
        /// Describes the current status of a mailbox export job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMailboxExportJob service method.</param>
        /// 
        /// <returns>The response from the DescribeMailboxExportJob service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DescribeMailboxExportJob">REST API Reference for DescribeMailboxExportJob Operation</seealso>
        DescribeMailboxExportJobResponse DescribeMailboxExportJob(DescribeMailboxExportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMailboxExportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMailboxExportJob operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMailboxExportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DescribeMailboxExportJob">REST API Reference for DescribeMailboxExportJob Operation</seealso>
        IAsyncResult BeginDescribeMailboxExportJob(DescribeMailboxExportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMailboxExportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMailboxExportJob.</param>
        /// 
        /// <returns>Returns a  DescribeMailboxExportJobResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DescribeMailboxExportJob">REST API Reference for DescribeMailboxExportJob Operation</seealso>
        DescribeMailboxExportJobResponse EndDescribeMailboxExportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeOrganization


        /// <summary>
        /// Provides more information regarding a given organization based on its identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganization service method.</param>
        /// 
        /// <returns>The response from the DescribeOrganization service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DescribeOrganization">REST API Reference for DescribeOrganization Operation</seealso>
        DescribeOrganizationResponse DescribeOrganization(DescribeOrganizationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganization operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeOrganization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DescribeOrganization">REST API Reference for DescribeOrganization Operation</seealso>
        IAsyncResult BeginDescribeOrganization(DescribeOrganizationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeOrganization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeOrganization.</param>
        /// 
        /// <returns>Returns a  DescribeOrganizationResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DescribeOrganization">REST API Reference for DescribeOrganization Operation</seealso>
        DescribeOrganizationResponse EndDescribeOrganization(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeResource


        /// <summary>
        /// Returns the data available for the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeResource service method.</param>
        /// 
        /// <returns>The response from the DescribeResource service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.UnsupportedOperationException">
        /// You can't perform a write operation against a read-only directory.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DescribeResource">REST API Reference for DescribeResource Operation</seealso>
        DescribeResourceResponse DescribeResource(DescribeResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeResource operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DescribeResource">REST API Reference for DescribeResource Operation</seealso>
        IAsyncResult BeginDescribeResource(DescribeResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeResource.</param>
        /// 
        /// <returns>Returns a  DescribeResourceResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DescribeResource">REST API Reference for DescribeResource Operation</seealso>
        DescribeResourceResponse EndDescribeResource(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeUser


        /// <summary>
        /// Provides information regarding the user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUser service method.</param>
        /// 
        /// <returns>The response from the DescribeUser service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryServiceAuthenticationFailedException">
        /// The directory service doesn't recognize the credentials supplied by WorkMail.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryUnavailableException">
        /// The directory is unavailable. It might be located in another Region or deleted.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DescribeUser">REST API Reference for DescribeUser Operation</seealso>
        DescribeUserResponse DescribeUser(DescribeUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeUser operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DescribeUser">REST API Reference for DescribeUser Operation</seealso>
        IAsyncResult BeginDescribeUser(DescribeUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeUser.</param>
        /// 
        /// <returns>Returns a  DescribeUserResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DescribeUser">REST API Reference for DescribeUser Operation</seealso>
        DescribeUserResponse EndDescribeUser(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateDelegateFromResource


        /// <summary>
        /// Removes a member from the resource's set of delegates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDelegateFromResource service method.</param>
        /// 
        /// <returns>The response from the DisassociateDelegateFromResource service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on a user, group, or resource that isn't in the expected
        /// state, such as trying to delete an active user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.UnsupportedOperationException">
        /// You can't perform a write operation against a read-only directory.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DisassociateDelegateFromResource">REST API Reference for DisassociateDelegateFromResource Operation</seealso>
        DisassociateDelegateFromResourceResponse DisassociateDelegateFromResource(DisassociateDelegateFromResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateDelegateFromResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDelegateFromResource operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateDelegateFromResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DisassociateDelegateFromResource">REST API Reference for DisassociateDelegateFromResource Operation</seealso>
        IAsyncResult BeginDisassociateDelegateFromResource(DisassociateDelegateFromResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateDelegateFromResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateDelegateFromResource.</param>
        /// 
        /// <returns>Returns a  DisassociateDelegateFromResourceResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DisassociateDelegateFromResource">REST API Reference for DisassociateDelegateFromResource Operation</seealso>
        DisassociateDelegateFromResourceResponse EndDisassociateDelegateFromResource(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateMemberFromGroup


        /// <summary>
        /// Removes a member from a group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMemberFromGroup service method.</param>
        /// 
        /// <returns>The response from the DisassociateMemberFromGroup service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryServiceAuthenticationFailedException">
        /// The directory service doesn't recognize the credentials supplied by WorkMail.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryUnavailableException">
        /// The directory is unavailable. It might be located in another Region or deleted.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on a user, group, or resource that isn't in the expected
        /// state, such as trying to delete an active user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.UnsupportedOperationException">
        /// You can't perform a write operation against a read-only directory.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DisassociateMemberFromGroup">REST API Reference for DisassociateMemberFromGroup Operation</seealso>
        DisassociateMemberFromGroupResponse DisassociateMemberFromGroup(DisassociateMemberFromGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateMemberFromGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMemberFromGroup operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateMemberFromGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DisassociateMemberFromGroup">REST API Reference for DisassociateMemberFromGroup Operation</seealso>
        IAsyncResult BeginDisassociateMemberFromGroup(DisassociateMemberFromGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateMemberFromGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateMemberFromGroup.</param>
        /// 
        /// <returns>Returns a  DisassociateMemberFromGroupResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DisassociateMemberFromGroup">REST API Reference for DisassociateMemberFromGroup Operation</seealso>
        DisassociateMemberFromGroupResponse EndDisassociateMemberFromGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAccessControlEffect


        /// <summary>
        /// Gets the effects of an organization's access control rules as they apply to a specified
        /// IPv4 address, access protocol action, and user ID or impersonation role ID. You must
        /// provide either the user ID or impersonation role ID. Impersonation role ID can only
        /// be used with Action EWS.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessControlEffect service method.</param>
        /// 
        /// <returns>The response from the GetAccessControlEffect service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/GetAccessControlEffect">REST API Reference for GetAccessControlEffect Operation</seealso>
        GetAccessControlEffectResponse GetAccessControlEffect(GetAccessControlEffectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccessControlEffect operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccessControlEffect operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccessControlEffect
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/GetAccessControlEffect">REST API Reference for GetAccessControlEffect Operation</seealso>
        IAsyncResult BeginGetAccessControlEffect(GetAccessControlEffectRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccessControlEffect operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccessControlEffect.</param>
        /// 
        /// <returns>Returns a  GetAccessControlEffectResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/GetAccessControlEffect">REST API Reference for GetAccessControlEffect Operation</seealso>
        GetAccessControlEffectResponse EndGetAccessControlEffect(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDefaultRetentionPolicy


        /// <summary>
        /// Gets the default retention policy details for the specified organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDefaultRetentionPolicy service method.</param>
        /// 
        /// <returns>The response from the GetDefaultRetentionPolicy service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/GetDefaultRetentionPolicy">REST API Reference for GetDefaultRetentionPolicy Operation</seealso>
        GetDefaultRetentionPolicyResponse GetDefaultRetentionPolicy(GetDefaultRetentionPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDefaultRetentionPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDefaultRetentionPolicy operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDefaultRetentionPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/GetDefaultRetentionPolicy">REST API Reference for GetDefaultRetentionPolicy Operation</seealso>
        IAsyncResult BeginGetDefaultRetentionPolicy(GetDefaultRetentionPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDefaultRetentionPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDefaultRetentionPolicy.</param>
        /// 
        /// <returns>Returns a  GetDefaultRetentionPolicyResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/GetDefaultRetentionPolicy">REST API Reference for GetDefaultRetentionPolicy Operation</seealso>
        GetDefaultRetentionPolicyResponse EndGetDefaultRetentionPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  GetImpersonationRole


        /// <summary>
        /// Gets the impersonation role details for the given WorkMail organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImpersonationRole service method.</param>
        /// 
        /// <returns>The response from the GetImpersonationRole service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/GetImpersonationRole">REST API Reference for GetImpersonationRole Operation</seealso>
        GetImpersonationRoleResponse GetImpersonationRole(GetImpersonationRoleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetImpersonationRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetImpersonationRole operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetImpersonationRole
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/GetImpersonationRole">REST API Reference for GetImpersonationRole Operation</seealso>
        IAsyncResult BeginGetImpersonationRole(GetImpersonationRoleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetImpersonationRole operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetImpersonationRole.</param>
        /// 
        /// <returns>Returns a  GetImpersonationRoleResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/GetImpersonationRole">REST API Reference for GetImpersonationRole Operation</seealso>
        GetImpersonationRoleResponse EndGetImpersonationRole(IAsyncResult asyncResult);

        #endregion
        
        #region  GetImpersonationRoleEffect


        /// <summary>
        /// Tests whether the given impersonation role can impersonate a target user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetImpersonationRoleEffect service method.</param>
        /// 
        /// <returns>The response from the GetImpersonationRoleEffect service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on a user, group, or resource that isn't in the expected
        /// state, such as trying to delete an active user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/GetImpersonationRoleEffect">REST API Reference for GetImpersonationRoleEffect Operation</seealso>
        GetImpersonationRoleEffectResponse GetImpersonationRoleEffect(GetImpersonationRoleEffectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetImpersonationRoleEffect operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetImpersonationRoleEffect operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetImpersonationRoleEffect
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/GetImpersonationRoleEffect">REST API Reference for GetImpersonationRoleEffect Operation</seealso>
        IAsyncResult BeginGetImpersonationRoleEffect(GetImpersonationRoleEffectRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetImpersonationRoleEffect operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetImpersonationRoleEffect.</param>
        /// 
        /// <returns>Returns a  GetImpersonationRoleEffectResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/GetImpersonationRoleEffect">REST API Reference for GetImpersonationRoleEffect Operation</seealso>
        GetImpersonationRoleEffectResponse EndGetImpersonationRoleEffect(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMailboxDetails


        /// <summary>
        /// Requests a user's mailbox details for a specified organization and user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMailboxDetails service method.</param>
        /// 
        /// <returns>The response from the GetMailboxDetails service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/GetMailboxDetails">REST API Reference for GetMailboxDetails Operation</seealso>
        GetMailboxDetailsResponse GetMailboxDetails(GetMailboxDetailsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetMailboxDetails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMailboxDetails operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMailboxDetails
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/GetMailboxDetails">REST API Reference for GetMailboxDetails Operation</seealso>
        IAsyncResult BeginGetMailboxDetails(GetMailboxDetailsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMailboxDetails operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMailboxDetails.</param>
        /// 
        /// <returns>Returns a  GetMailboxDetailsResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/GetMailboxDetails">REST API Reference for GetMailboxDetails Operation</seealso>
        GetMailboxDetailsResponse EndGetMailboxDetails(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMailDomain


        /// <summary>
        /// Gets details for a mail domain, including domain records required to configure your
        /// domain with recommended security.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMailDomain service method.</param>
        /// 
        /// <returns>The response from the GetMailDomain service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.MailDomainNotFoundException">
        /// The domain specified is not found in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/GetMailDomain">REST API Reference for GetMailDomain Operation</seealso>
        GetMailDomainResponse GetMailDomain(GetMailDomainRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetMailDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMailDomain operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMailDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/GetMailDomain">REST API Reference for GetMailDomain Operation</seealso>
        IAsyncResult BeginGetMailDomain(GetMailDomainRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMailDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMailDomain.</param>
        /// 
        /// <returns>Returns a  GetMailDomainResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/GetMailDomain">REST API Reference for GetMailDomain Operation</seealso>
        GetMailDomainResponse EndGetMailDomain(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMobileDeviceAccessEffect


        /// <summary>
        /// Simulates the effect of the mobile device access rules for the given attributes of
        /// a sample access event. Use this method to test the effects of the current set of mobile
        /// device access rules for the WorkMail organization for a particular user's attributes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMobileDeviceAccessEffect service method.</param>
        /// 
        /// <returns>The response from the GetMobileDeviceAccessEffect service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/GetMobileDeviceAccessEffect">REST API Reference for GetMobileDeviceAccessEffect Operation</seealso>
        GetMobileDeviceAccessEffectResponse GetMobileDeviceAccessEffect(GetMobileDeviceAccessEffectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetMobileDeviceAccessEffect operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMobileDeviceAccessEffect operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMobileDeviceAccessEffect
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/GetMobileDeviceAccessEffect">REST API Reference for GetMobileDeviceAccessEffect Operation</seealso>
        IAsyncResult BeginGetMobileDeviceAccessEffect(GetMobileDeviceAccessEffectRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMobileDeviceAccessEffect operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMobileDeviceAccessEffect.</param>
        /// 
        /// <returns>Returns a  GetMobileDeviceAccessEffectResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/GetMobileDeviceAccessEffect">REST API Reference for GetMobileDeviceAccessEffect Operation</seealso>
        GetMobileDeviceAccessEffectResponse EndGetMobileDeviceAccessEffect(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMobileDeviceAccessOverride


        /// <summary>
        /// Gets the mobile device access override for the given WorkMail organization, user,
        /// and device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMobileDeviceAccessOverride service method.</param>
        /// 
        /// <returns>The response from the GetMobileDeviceAccessOverride service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/GetMobileDeviceAccessOverride">REST API Reference for GetMobileDeviceAccessOverride Operation</seealso>
        GetMobileDeviceAccessOverrideResponse GetMobileDeviceAccessOverride(GetMobileDeviceAccessOverrideRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetMobileDeviceAccessOverride operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMobileDeviceAccessOverride operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMobileDeviceAccessOverride
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/GetMobileDeviceAccessOverride">REST API Reference for GetMobileDeviceAccessOverride Operation</seealso>
        IAsyncResult BeginGetMobileDeviceAccessOverride(GetMobileDeviceAccessOverrideRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMobileDeviceAccessOverride operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMobileDeviceAccessOverride.</param>
        /// 
        /// <returns>Returns a  GetMobileDeviceAccessOverrideResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/GetMobileDeviceAccessOverride">REST API Reference for GetMobileDeviceAccessOverride Operation</seealso>
        GetMobileDeviceAccessOverrideResponse EndGetMobileDeviceAccessOverride(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPersonalAccessTokenMetadata


        /// <summary>
        /// Requests details of a specific Personal Access Token within the WorkMail organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPersonalAccessTokenMetadata service method.</param>
        /// 
        /// <returns>The response from the GetPersonalAccessTokenMetadata service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/GetPersonalAccessTokenMetadata">REST API Reference for GetPersonalAccessTokenMetadata Operation</seealso>
        GetPersonalAccessTokenMetadataResponse GetPersonalAccessTokenMetadata(GetPersonalAccessTokenMetadataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPersonalAccessTokenMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPersonalAccessTokenMetadata operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPersonalAccessTokenMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/GetPersonalAccessTokenMetadata">REST API Reference for GetPersonalAccessTokenMetadata Operation</seealso>
        IAsyncResult BeginGetPersonalAccessTokenMetadata(GetPersonalAccessTokenMetadataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPersonalAccessTokenMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPersonalAccessTokenMetadata.</param>
        /// 
        /// <returns>Returns a  GetPersonalAccessTokenMetadataResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/GetPersonalAccessTokenMetadata">REST API Reference for GetPersonalAccessTokenMetadata Operation</seealso>
        GetPersonalAccessTokenMetadataResponse EndGetPersonalAccessTokenMetadata(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAccessControlRules


        /// <summary>
        /// Lists the access control rules for the specified organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessControlRules service method.</param>
        /// 
        /// <returns>The response from the ListAccessControlRules service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListAccessControlRules">REST API Reference for ListAccessControlRules Operation</seealso>
        ListAccessControlRulesResponse ListAccessControlRules(ListAccessControlRulesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccessControlRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccessControlRules operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAccessControlRules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListAccessControlRules">REST API Reference for ListAccessControlRules Operation</seealso>
        IAsyncResult BeginListAccessControlRules(ListAccessControlRulesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAccessControlRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccessControlRules.</param>
        /// 
        /// <returns>Returns a  ListAccessControlRulesResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListAccessControlRules">REST API Reference for ListAccessControlRules Operation</seealso>
        ListAccessControlRulesResponse EndListAccessControlRules(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAliases


        /// <summary>
        /// Creates a paginated call to list the aliases associated with a given entity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAliases service method.</param>
        /// 
        /// <returns>The response from the ListAliases service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on a user, group, or resource that isn't in the expected
        /// state, such as trying to delete an active user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListAliases">REST API Reference for ListAliases Operation</seealso>
        ListAliasesResponse ListAliases(ListAliasesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAliases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAliases operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAliases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListAliases">REST API Reference for ListAliases Operation</seealso>
        IAsyncResult BeginListAliases(ListAliasesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAliases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAliases.</param>
        /// 
        /// <returns>Returns a  ListAliasesResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListAliases">REST API Reference for ListAliases Operation</seealso>
        ListAliasesResponse EndListAliases(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAvailabilityConfigurations


        /// <summary>
        /// List all the <c>AvailabilityConfiguration</c>'s for the given WorkMail organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAvailabilityConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListAvailabilityConfigurations service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListAvailabilityConfigurations">REST API Reference for ListAvailabilityConfigurations Operation</seealso>
        ListAvailabilityConfigurationsResponse ListAvailabilityConfigurations(ListAvailabilityConfigurationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAvailabilityConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAvailabilityConfigurations operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAvailabilityConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListAvailabilityConfigurations">REST API Reference for ListAvailabilityConfigurations Operation</seealso>
        IAsyncResult BeginListAvailabilityConfigurations(ListAvailabilityConfigurationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAvailabilityConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAvailabilityConfigurations.</param>
        /// 
        /// <returns>Returns a  ListAvailabilityConfigurationsResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListAvailabilityConfigurations">REST API Reference for ListAvailabilityConfigurations Operation</seealso>
        ListAvailabilityConfigurationsResponse EndListAvailabilityConfigurations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListGroupMembers


        /// <summary>
        /// Returns an overview of the members of a group. Users and groups can be members of
        /// a group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupMembers service method.</param>
        /// 
        /// <returns>The response from the ListGroupMembers service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on a user, group, or resource that isn't in the expected
        /// state, such as trying to delete an active user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListGroupMembers">REST API Reference for ListGroupMembers Operation</seealso>
        ListGroupMembersResponse ListGroupMembers(ListGroupMembersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroupMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroupMembers operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGroupMembers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListGroupMembers">REST API Reference for ListGroupMembers Operation</seealso>
        IAsyncResult BeginListGroupMembers(ListGroupMembersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListGroupMembers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGroupMembers.</param>
        /// 
        /// <returns>Returns a  ListGroupMembersResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListGroupMembers">REST API Reference for ListGroupMembers Operation</seealso>
        ListGroupMembersResponse EndListGroupMembers(IAsyncResult asyncResult);

        #endregion
        
        #region  ListGroups


        /// <summary>
        /// Returns summaries of the organization's groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroups service method.</param>
        /// 
        /// <returns>The response from the ListGroups service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListGroups">REST API Reference for ListGroups Operation</seealso>
        ListGroupsResponse ListGroups(ListGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroups operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListGroups">REST API Reference for ListGroups Operation</seealso>
        IAsyncResult BeginListGroups(ListGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGroups.</param>
        /// 
        /// <returns>Returns a  ListGroupsResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListGroups">REST API Reference for ListGroups Operation</seealso>
        ListGroupsResponse EndListGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  ListGroupsForEntity


        /// <summary>
        /// Returns all the groups to which an entity belongs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupsForEntity service method.</param>
        /// 
        /// <returns>The response from the ListGroupsForEntity service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on a user, group, or resource that isn't in the expected
        /// state, such as trying to delete an active user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListGroupsForEntity">REST API Reference for ListGroupsForEntity Operation</seealso>
        ListGroupsForEntityResponse ListGroupsForEntity(ListGroupsForEntityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroupsForEntity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroupsForEntity operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGroupsForEntity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListGroupsForEntity">REST API Reference for ListGroupsForEntity Operation</seealso>
        IAsyncResult BeginListGroupsForEntity(ListGroupsForEntityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListGroupsForEntity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGroupsForEntity.</param>
        /// 
        /// <returns>Returns a  ListGroupsForEntityResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListGroupsForEntity">REST API Reference for ListGroupsForEntity Operation</seealso>
        ListGroupsForEntityResponse EndListGroupsForEntity(IAsyncResult asyncResult);

        #endregion
        
        #region  ListImpersonationRoles


        /// <summary>
        /// Lists all the impersonation roles for the given WorkMail organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListImpersonationRoles service method.</param>
        /// 
        /// <returns>The response from the ListImpersonationRoles service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListImpersonationRoles">REST API Reference for ListImpersonationRoles Operation</seealso>
        ListImpersonationRolesResponse ListImpersonationRoles(ListImpersonationRolesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListImpersonationRoles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListImpersonationRoles operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListImpersonationRoles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListImpersonationRoles">REST API Reference for ListImpersonationRoles Operation</seealso>
        IAsyncResult BeginListImpersonationRoles(ListImpersonationRolesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListImpersonationRoles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListImpersonationRoles.</param>
        /// 
        /// <returns>Returns a  ListImpersonationRolesResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListImpersonationRoles">REST API Reference for ListImpersonationRoles Operation</seealso>
        ListImpersonationRolesResponse EndListImpersonationRoles(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMailboxExportJobs


        /// <summary>
        /// Lists the mailbox export jobs started for the specified organization within the last
        /// seven days.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMailboxExportJobs service method.</param>
        /// 
        /// <returns>The response from the ListMailboxExportJobs service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListMailboxExportJobs">REST API Reference for ListMailboxExportJobs Operation</seealso>
        ListMailboxExportJobsResponse ListMailboxExportJobs(ListMailboxExportJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMailboxExportJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMailboxExportJobs operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMailboxExportJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListMailboxExportJobs">REST API Reference for ListMailboxExportJobs Operation</seealso>
        IAsyncResult BeginListMailboxExportJobs(ListMailboxExportJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMailboxExportJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMailboxExportJobs.</param>
        /// 
        /// <returns>Returns a  ListMailboxExportJobsResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListMailboxExportJobs">REST API Reference for ListMailboxExportJobs Operation</seealso>
        ListMailboxExportJobsResponse EndListMailboxExportJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMailboxPermissions


        /// <summary>
        /// Lists the mailbox permissions associated with a user, group, or resource mailbox.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMailboxPermissions service method.</param>
        /// 
        /// <returns>The response from the ListMailboxPermissions service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListMailboxPermissions">REST API Reference for ListMailboxPermissions Operation</seealso>
        ListMailboxPermissionsResponse ListMailboxPermissions(ListMailboxPermissionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMailboxPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMailboxPermissions operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMailboxPermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListMailboxPermissions">REST API Reference for ListMailboxPermissions Operation</seealso>
        IAsyncResult BeginListMailboxPermissions(ListMailboxPermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMailboxPermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMailboxPermissions.</param>
        /// 
        /// <returns>Returns a  ListMailboxPermissionsResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListMailboxPermissions">REST API Reference for ListMailboxPermissions Operation</seealso>
        ListMailboxPermissionsResponse EndListMailboxPermissions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMailDomains


        /// <summary>
        /// Lists the mail domains in a given WorkMail organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMailDomains service method.</param>
        /// 
        /// <returns>The response from the ListMailDomains service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListMailDomains">REST API Reference for ListMailDomains Operation</seealso>
        ListMailDomainsResponse ListMailDomains(ListMailDomainsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMailDomains operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMailDomains operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMailDomains
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListMailDomains">REST API Reference for ListMailDomains Operation</seealso>
        IAsyncResult BeginListMailDomains(ListMailDomainsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMailDomains operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMailDomains.</param>
        /// 
        /// <returns>Returns a  ListMailDomainsResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListMailDomains">REST API Reference for ListMailDomains Operation</seealso>
        ListMailDomainsResponse EndListMailDomains(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMobileDeviceAccessOverrides


        /// <summary>
        /// Lists all the mobile device access overrides for any given combination of WorkMail
        /// organization, user, or device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMobileDeviceAccessOverrides service method.</param>
        /// 
        /// <returns>The response from the ListMobileDeviceAccessOverrides service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListMobileDeviceAccessOverrides">REST API Reference for ListMobileDeviceAccessOverrides Operation</seealso>
        ListMobileDeviceAccessOverridesResponse ListMobileDeviceAccessOverrides(ListMobileDeviceAccessOverridesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMobileDeviceAccessOverrides operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMobileDeviceAccessOverrides operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMobileDeviceAccessOverrides
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListMobileDeviceAccessOverrides">REST API Reference for ListMobileDeviceAccessOverrides Operation</seealso>
        IAsyncResult BeginListMobileDeviceAccessOverrides(ListMobileDeviceAccessOverridesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMobileDeviceAccessOverrides operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMobileDeviceAccessOverrides.</param>
        /// 
        /// <returns>Returns a  ListMobileDeviceAccessOverridesResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListMobileDeviceAccessOverrides">REST API Reference for ListMobileDeviceAccessOverrides Operation</seealso>
        ListMobileDeviceAccessOverridesResponse EndListMobileDeviceAccessOverrides(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMobileDeviceAccessRules


        /// <summary>
        /// Lists the mobile device access rules for the specified WorkMail organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMobileDeviceAccessRules service method.</param>
        /// 
        /// <returns>The response from the ListMobileDeviceAccessRules service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListMobileDeviceAccessRules">REST API Reference for ListMobileDeviceAccessRules Operation</seealso>
        ListMobileDeviceAccessRulesResponse ListMobileDeviceAccessRules(ListMobileDeviceAccessRulesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMobileDeviceAccessRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMobileDeviceAccessRules operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMobileDeviceAccessRules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListMobileDeviceAccessRules">REST API Reference for ListMobileDeviceAccessRules Operation</seealso>
        IAsyncResult BeginListMobileDeviceAccessRules(ListMobileDeviceAccessRulesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMobileDeviceAccessRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMobileDeviceAccessRules.</param>
        /// 
        /// <returns>Returns a  ListMobileDeviceAccessRulesResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListMobileDeviceAccessRules">REST API Reference for ListMobileDeviceAccessRules Operation</seealso>
        ListMobileDeviceAccessRulesResponse EndListMobileDeviceAccessRules(IAsyncResult asyncResult);

        #endregion
        
        #region  ListOrganizations


        /// <summary>
        /// Returns summaries of the customer's organizations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizations service method.</param>
        /// 
        /// <returns>The response from the ListOrganizations service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListOrganizations">REST API Reference for ListOrganizations Operation</seealso>
        ListOrganizationsResponse ListOrganizations(ListOrganizationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListOrganizations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizations operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOrganizations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListOrganizations">REST API Reference for ListOrganizations Operation</seealso>
        IAsyncResult BeginListOrganizations(ListOrganizationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListOrganizations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOrganizations.</param>
        /// 
        /// <returns>Returns a  ListOrganizationsResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListOrganizations">REST API Reference for ListOrganizations Operation</seealso>
        ListOrganizationsResponse EndListOrganizations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPersonalAccessTokens


        /// <summary>
        /// Returns a summary of your Personal Access Tokens.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPersonalAccessTokens service method.</param>
        /// 
        /// <returns>The response from the ListPersonalAccessTokens service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on a user, group, or resource that isn't in the expected
        /// state, such as trying to delete an active user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListPersonalAccessTokens">REST API Reference for ListPersonalAccessTokens Operation</seealso>
        ListPersonalAccessTokensResponse ListPersonalAccessTokens(ListPersonalAccessTokensRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPersonalAccessTokens operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPersonalAccessTokens operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPersonalAccessTokens
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListPersonalAccessTokens">REST API Reference for ListPersonalAccessTokens Operation</seealso>
        IAsyncResult BeginListPersonalAccessTokens(ListPersonalAccessTokensRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPersonalAccessTokens operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPersonalAccessTokens.</param>
        /// 
        /// <returns>Returns a  ListPersonalAccessTokensResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListPersonalAccessTokens">REST API Reference for ListPersonalAccessTokens Operation</seealso>
        ListPersonalAccessTokensResponse EndListPersonalAccessTokens(IAsyncResult asyncResult);

        #endregion
        
        #region  ListResourceDelegates


        /// <summary>
        /// Lists the delegates associated with a resource. Users and groups can be resource delegates
        /// and answer requests on behalf of the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceDelegates service method.</param>
        /// 
        /// <returns>The response from the ListResourceDelegates service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on a user, group, or resource that isn't in the expected
        /// state, such as trying to delete an active user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.UnsupportedOperationException">
        /// You can't perform a write operation against a read-only directory.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListResourceDelegates">REST API Reference for ListResourceDelegates Operation</seealso>
        ListResourceDelegatesResponse ListResourceDelegates(ListResourceDelegatesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListResourceDelegates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourceDelegates operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResourceDelegates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListResourceDelegates">REST API Reference for ListResourceDelegates Operation</seealso>
        IAsyncResult BeginListResourceDelegates(ListResourceDelegatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListResourceDelegates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResourceDelegates.</param>
        /// 
        /// <returns>Returns a  ListResourceDelegatesResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListResourceDelegates">REST API Reference for ListResourceDelegates Operation</seealso>
        ListResourceDelegatesResponse EndListResourceDelegates(IAsyncResult asyncResult);

        #endregion
        
        #region  ListResources


        /// <summary>
        /// Returns summaries of the organization's resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResources service method.</param>
        /// 
        /// <returns>The response from the ListResources service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.UnsupportedOperationException">
        /// You can't perform a write operation against a read-only directory.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListResources">REST API Reference for ListResources Operation</seealso>
        ListResourcesResponse ListResources(ListResourcesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResources operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListResources">REST API Reference for ListResources Operation</seealso>
        IAsyncResult BeginListResources(ListResourcesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResources.</param>
        /// 
        /// <returns>Returns a  ListResourcesResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListResources">REST API Reference for ListResources Operation</seealso>
        ListResourcesResponse EndListResources(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags applied to an WorkMail organization resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListUsers


        /// <summary>
        /// Returns summaries of the organization's users.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsers service method.</param>
        /// 
        /// <returns>The response from the ListUsers service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListUsers">REST API Reference for ListUsers Operation</seealso>
        ListUsersResponse ListUsers(ListUsersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListUsers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUsers operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListUsers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListUsers">REST API Reference for ListUsers Operation</seealso>
        IAsyncResult BeginListUsers(ListUsersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListUsers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUsers.</param>
        /// 
        /// <returns>Returns a  ListUsersResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListUsers">REST API Reference for ListUsers Operation</seealso>
        ListUsersResponse EndListUsers(IAsyncResult asyncResult);

        #endregion
        
        #region  PutAccessControlRule


        /// <summary>
        /// Adds a new access control rule for the specified organization. The rule allows or
        /// denies access to the organization for the specified IPv4 addresses, access protocol
        /// actions, user IDs and impersonation IDs. Adding a new rule with the same name as an
        /// existing rule replaces the older rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAccessControlRule service method.</param>
        /// 
        /// <returns>The response from the PutAccessControlRule service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.LimitExceededException">
        /// The request exceeds the limit of the resource.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/PutAccessControlRule">REST API Reference for PutAccessControlRule Operation</seealso>
        PutAccessControlRuleResponse PutAccessControlRule(PutAccessControlRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutAccessControlRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutAccessControlRule operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutAccessControlRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/PutAccessControlRule">REST API Reference for PutAccessControlRule Operation</seealso>
        IAsyncResult BeginPutAccessControlRule(PutAccessControlRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutAccessControlRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutAccessControlRule.</param>
        /// 
        /// <returns>Returns a  PutAccessControlRuleResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/PutAccessControlRule">REST API Reference for PutAccessControlRule Operation</seealso>
        PutAccessControlRuleResponse EndPutAccessControlRule(IAsyncResult asyncResult);

        #endregion
        
        #region  PutEmailMonitoringConfiguration


        /// <summary>
        /// Creates or updates the email monitoring configuration for a specified organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEmailMonitoringConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutEmailMonitoringConfiguration service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/PutEmailMonitoringConfiguration">REST API Reference for PutEmailMonitoringConfiguration Operation</seealso>
        PutEmailMonitoringConfigurationResponse PutEmailMonitoringConfiguration(PutEmailMonitoringConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutEmailMonitoringConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutEmailMonitoringConfiguration operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutEmailMonitoringConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/PutEmailMonitoringConfiguration">REST API Reference for PutEmailMonitoringConfiguration Operation</seealso>
        IAsyncResult BeginPutEmailMonitoringConfiguration(PutEmailMonitoringConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutEmailMonitoringConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutEmailMonitoringConfiguration.</param>
        /// 
        /// <returns>Returns a  PutEmailMonitoringConfigurationResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/PutEmailMonitoringConfiguration">REST API Reference for PutEmailMonitoringConfiguration Operation</seealso>
        PutEmailMonitoringConfigurationResponse EndPutEmailMonitoringConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  PutIdentityProviderConfiguration


        /// <summary>
        /// Enables integration between IAM Identity Center (IdC) and WorkMail to proxy authentication
        /// requests for mailbox users. You can connect your IdC directory or your external directory
        /// to WorkMail through IdC and manage access to WorkMail mailboxes in a single place.
        /// For enhanced protection, you could enable Multifactor Authentication (MFA) and Personal
        /// Access Tokens.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutIdentityProviderConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutIdentityProviderConfiguration service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/PutIdentityProviderConfiguration">REST API Reference for PutIdentityProviderConfiguration Operation</seealso>
        PutIdentityProviderConfigurationResponse PutIdentityProviderConfiguration(PutIdentityProviderConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutIdentityProviderConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutIdentityProviderConfiguration operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutIdentityProviderConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/PutIdentityProviderConfiguration">REST API Reference for PutIdentityProviderConfiguration Operation</seealso>
        IAsyncResult BeginPutIdentityProviderConfiguration(PutIdentityProviderConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutIdentityProviderConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutIdentityProviderConfiguration.</param>
        /// 
        /// <returns>Returns a  PutIdentityProviderConfigurationResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/PutIdentityProviderConfiguration">REST API Reference for PutIdentityProviderConfiguration Operation</seealso>
        PutIdentityProviderConfigurationResponse EndPutIdentityProviderConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  PutInboundDmarcSettings


        /// <summary>
        /// Enables or disables a DMARC policy for a given organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutInboundDmarcSettings service method.</param>
        /// 
        /// <returns>The response from the PutInboundDmarcSettings service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/PutInboundDmarcSettings">REST API Reference for PutInboundDmarcSettings Operation</seealso>
        PutInboundDmarcSettingsResponse PutInboundDmarcSettings(PutInboundDmarcSettingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutInboundDmarcSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutInboundDmarcSettings operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutInboundDmarcSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/PutInboundDmarcSettings">REST API Reference for PutInboundDmarcSettings Operation</seealso>
        IAsyncResult BeginPutInboundDmarcSettings(PutInboundDmarcSettingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutInboundDmarcSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutInboundDmarcSettings.</param>
        /// 
        /// <returns>Returns a  PutInboundDmarcSettingsResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/PutInboundDmarcSettings">REST API Reference for PutInboundDmarcSettings Operation</seealso>
        PutInboundDmarcSettingsResponse EndPutInboundDmarcSettings(IAsyncResult asyncResult);

        #endregion
        
        #region  PutMailboxPermissions


        /// <summary>
        /// Sets permissions for a user, group, or resource. This replaces any pre-existing permissions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMailboxPermissions service method.</param>
        /// 
        /// <returns>The response from the PutMailboxPermissions service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on a user, group, or resource that isn't in the expected
        /// state, such as trying to delete an active user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/PutMailboxPermissions">REST API Reference for PutMailboxPermissions Operation</seealso>
        PutMailboxPermissionsResponse PutMailboxPermissions(PutMailboxPermissionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutMailboxPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutMailboxPermissions operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutMailboxPermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/PutMailboxPermissions">REST API Reference for PutMailboxPermissions Operation</seealso>
        IAsyncResult BeginPutMailboxPermissions(PutMailboxPermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutMailboxPermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutMailboxPermissions.</param>
        /// 
        /// <returns>Returns a  PutMailboxPermissionsResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/PutMailboxPermissions">REST API Reference for PutMailboxPermissions Operation</seealso>
        PutMailboxPermissionsResponse EndPutMailboxPermissions(IAsyncResult asyncResult);

        #endregion
        
        #region  PutMobileDeviceAccessOverride


        /// <summary>
        /// Creates or updates a mobile device access override for the given WorkMail organization,
        /// user, and device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMobileDeviceAccessOverride service method.</param>
        /// 
        /// <returns>The response from the PutMobileDeviceAccessOverride service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on a user, group, or resource that isn't in the expected
        /// state, such as trying to delete an active user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/PutMobileDeviceAccessOverride">REST API Reference for PutMobileDeviceAccessOverride Operation</seealso>
        PutMobileDeviceAccessOverrideResponse PutMobileDeviceAccessOverride(PutMobileDeviceAccessOverrideRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutMobileDeviceAccessOverride operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutMobileDeviceAccessOverride operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutMobileDeviceAccessOverride
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/PutMobileDeviceAccessOverride">REST API Reference for PutMobileDeviceAccessOverride Operation</seealso>
        IAsyncResult BeginPutMobileDeviceAccessOverride(PutMobileDeviceAccessOverrideRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutMobileDeviceAccessOverride operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutMobileDeviceAccessOverride.</param>
        /// 
        /// <returns>Returns a  PutMobileDeviceAccessOverrideResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/PutMobileDeviceAccessOverride">REST API Reference for PutMobileDeviceAccessOverride Operation</seealso>
        PutMobileDeviceAccessOverrideResponse EndPutMobileDeviceAccessOverride(IAsyncResult asyncResult);

        #endregion
        
        #region  PutRetentionPolicy


        /// <summary>
        /// Puts a retention policy to the specified organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRetentionPolicy service method.</param>
        /// 
        /// <returns>The response from the PutRetentionPolicy service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.LimitExceededException">
        /// The request exceeds the limit of the resource.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/PutRetentionPolicy">REST API Reference for PutRetentionPolicy Operation</seealso>
        PutRetentionPolicyResponse PutRetentionPolicy(PutRetentionPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutRetentionPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutRetentionPolicy operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutRetentionPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/PutRetentionPolicy">REST API Reference for PutRetentionPolicy Operation</seealso>
        IAsyncResult BeginPutRetentionPolicy(PutRetentionPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutRetentionPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutRetentionPolicy.</param>
        /// 
        /// <returns>Returns a  PutRetentionPolicyResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/PutRetentionPolicy">REST API Reference for PutRetentionPolicy Operation</seealso>
        PutRetentionPolicyResponse EndPutRetentionPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  RegisterMailDomain


        /// <summary>
        /// Registers a new domain in WorkMail and SES, and configures it for use by WorkMail.
        /// Emails received by SES for this domain are routed to the specified WorkMail organization,
        /// and WorkMail has permanent permission to use the specified domain for sending your
        /// users' emails.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterMailDomain service method.</param>
        /// 
        /// <returns>The response from the RegisterMailDomain service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.LimitExceededException">
        /// The request exceeds the limit of the resource.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.MailDomainInUseException">
        /// The domain you're trying to change is in use by another user or organization in your
        /// account. See the error message for details.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/RegisterMailDomain">REST API Reference for RegisterMailDomain Operation</seealso>
        RegisterMailDomainResponse RegisterMailDomain(RegisterMailDomainRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterMailDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterMailDomain operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterMailDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/RegisterMailDomain">REST API Reference for RegisterMailDomain Operation</seealso>
        IAsyncResult BeginRegisterMailDomain(RegisterMailDomainRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterMailDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterMailDomain.</param>
        /// 
        /// <returns>Returns a  RegisterMailDomainResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/RegisterMailDomain">REST API Reference for RegisterMailDomain Operation</seealso>
        RegisterMailDomainResponse EndRegisterMailDomain(IAsyncResult asyncResult);

        #endregion
        
        #region  RegisterToWorkMail


        /// <summary>
        /// Registers an existing and disabled user, group, or resource for WorkMail use by associating
        /// a mailbox and calendaring capabilities. It performs no change if the user, group,
        /// or resource is enabled and fails if the user, group, or resource is deleted. This
        /// operation results in the accumulation of costs. For more information, see <a href="https://aws.amazon.com/workmail/pricing">Pricing</a>.
        /// The equivalent console functionality for this operation is <i>Enable</i>.
        /// 
        ///  
        /// <para>
        /// Users can either be created by calling the <a>CreateUser</a> API operation or they
        /// can be synchronized from your directory. For more information, see <a>DeregisterFromWorkMail</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterToWorkMail service method.</param>
        /// 
        /// <returns>The response from the RegisterToWorkMail service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryServiceAuthenticationFailedException">
        /// The directory service doesn't recognize the credentials supplied by WorkMail.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryUnavailableException">
        /// The directory is unavailable. It might be located in another Region or deleted.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EmailAddressInUseException">
        /// The email address that you're trying to assign is already created for a different
        /// user, group, or resource.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityAlreadyRegisteredException">
        /// The user, group, or resource that you're trying to register is already registered.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on a user, group, or resource that isn't in the expected
        /// state, such as trying to delete an active user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.MailDomainNotFoundException">
        /// The domain specified is not found in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.MailDomainStateException">
        /// After a domain has been added to the organization, it must be verified. The domain
        /// is not yet verified.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.UnsupportedOperationException">
        /// You can't perform a write operation against a read-only directory.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/RegisterToWorkMail">REST API Reference for RegisterToWorkMail Operation</seealso>
        RegisterToWorkMailResponse RegisterToWorkMail(RegisterToWorkMailRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterToWorkMail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterToWorkMail operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterToWorkMail
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/RegisterToWorkMail">REST API Reference for RegisterToWorkMail Operation</seealso>
        IAsyncResult BeginRegisterToWorkMail(RegisterToWorkMailRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterToWorkMail operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterToWorkMail.</param>
        /// 
        /// <returns>Returns a  RegisterToWorkMailResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/RegisterToWorkMail">REST API Reference for RegisterToWorkMail Operation</seealso>
        RegisterToWorkMailResponse EndRegisterToWorkMail(IAsyncResult asyncResult);

        #endregion
        
        #region  ResetPassword


        /// <summary>
        /// Allows the administrator to reset the password for a user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetPassword service method.</param>
        /// 
        /// <returns>The response from the ResetPassword service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryServiceAuthenticationFailedException">
        /// The directory service doesn't recognize the credentials supplied by WorkMail.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryUnavailableException">
        /// The directory is unavailable. It might be located in another Region or deleted.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on a user, group, or resource that isn't in the expected
        /// state, such as trying to delete an active user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidPasswordException">
        /// The supplied password doesn't match the minimum security constraints, such as length
        /// or use of special characters.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.UnsupportedOperationException">
        /// You can't perform a write operation against a read-only directory.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ResetPassword">REST API Reference for ResetPassword Operation</seealso>
        ResetPasswordResponse ResetPassword(ResetPasswordRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ResetPassword operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetPassword operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResetPassword
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ResetPassword">REST API Reference for ResetPassword Operation</seealso>
        IAsyncResult BeginResetPassword(ResetPasswordRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ResetPassword operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetPassword.</param>
        /// 
        /// <returns>Returns a  ResetPasswordResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ResetPassword">REST API Reference for ResetPassword Operation</seealso>
        ResetPasswordResponse EndResetPassword(IAsyncResult asyncResult);

        #endregion
        
        #region  StartMailboxExportJob


        /// <summary>
        /// Starts a mailbox export job to export MIME-format email messages and calendar items
        /// from the specified mailbox to the specified Amazon Simple Storage Service (Amazon
        /// S3) bucket. For more information, see <a href="https://docs.aws.amazon.com/workmail/latest/adminguide/mail-export.html">Exporting
        /// mailbox content</a> in the <i>WorkMail Administrator Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMailboxExportJob service method.</param>
        /// 
        /// <returns>The response from the StartMailboxExportJob service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.LimitExceededException">
        /// The request exceeds the limit of the resource.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/StartMailboxExportJob">REST API Reference for StartMailboxExportJob Operation</seealso>
        StartMailboxExportJobResponse StartMailboxExportJob(StartMailboxExportJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartMailboxExportJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartMailboxExportJob operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartMailboxExportJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/StartMailboxExportJob">REST API Reference for StartMailboxExportJob Operation</seealso>
        IAsyncResult BeginStartMailboxExportJob(StartMailboxExportJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartMailboxExportJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartMailboxExportJob.</param>
        /// 
        /// <returns>Returns a  StartMailboxExportJobResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/StartMailboxExportJob">REST API Reference for StartMailboxExportJob Operation</seealso>
        StartMailboxExportJobResponse EndStartMailboxExportJob(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Applies the specified tags to the specified WorkMailorganization resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.TooManyTagsException">
        /// The resource can have up to 50 user-applied tags.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  TestAvailabilityConfiguration


        /// <summary>
        /// Performs a test on an availability provider to ensure that access is allowed. For
        /// EWS, it verifies the provided credentials can be used to successfully log in. For
        /// Lambda, it verifies that the Lambda function can be invoked and that the resource
        /// access policy was configured to deny anonymous access. An anonymous invocation is
        /// one done without providing either a <c>SourceArn</c> or <c>SourceAccount</c> header.
        /// 
        ///  <note> 
        /// <para>
        /// The request must contain either one provider definition (<c>EwsProvider</c> or <c>LambdaProvider</c>)
        /// or the <c>DomainName</c> parameter. If the <c>DomainName</c> parameter is provided,
        /// the configuration stored under the <c>DomainName</c> will be tested.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestAvailabilityConfiguration service method.</param>
        /// 
        /// <returns>The response from the TestAvailabilityConfiguration service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/TestAvailabilityConfiguration">REST API Reference for TestAvailabilityConfiguration Operation</seealso>
        TestAvailabilityConfigurationResponse TestAvailabilityConfiguration(TestAvailabilityConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TestAvailabilityConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestAvailabilityConfiguration operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTestAvailabilityConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/TestAvailabilityConfiguration">REST API Reference for TestAvailabilityConfiguration Operation</seealso>
        IAsyncResult BeginTestAvailabilityConfiguration(TestAvailabilityConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TestAvailabilityConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTestAvailabilityConfiguration.</param>
        /// 
        /// <returns>Returns a  TestAvailabilityConfigurationResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/TestAvailabilityConfiguration">REST API Reference for TestAvailabilityConfiguration Operation</seealso>
        TestAvailabilityConfigurationResponse EndTestAvailabilityConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Untags the specified tags from the specified WorkMail organization resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAvailabilityConfiguration


        /// <summary>
        /// Updates an existing <c>AvailabilityConfiguration</c> for the given WorkMail organization
        /// and domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAvailabilityConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateAvailabilityConfiguration service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/UpdateAvailabilityConfiguration">REST API Reference for UpdateAvailabilityConfiguration Operation</seealso>
        UpdateAvailabilityConfigurationResponse UpdateAvailabilityConfiguration(UpdateAvailabilityConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAvailabilityConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAvailabilityConfiguration operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAvailabilityConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/UpdateAvailabilityConfiguration">REST API Reference for UpdateAvailabilityConfiguration Operation</seealso>
        IAsyncResult BeginUpdateAvailabilityConfiguration(UpdateAvailabilityConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAvailabilityConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAvailabilityConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateAvailabilityConfigurationResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/UpdateAvailabilityConfiguration">REST API Reference for UpdateAvailabilityConfiguration Operation</seealso>
        UpdateAvailabilityConfigurationResponse EndUpdateAvailabilityConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDefaultMailDomain


        /// <summary>
        /// Updates the default mail domain for an organization. The default mail domain is used
        /// by the WorkMail AWS Console to suggest an email address when enabling a mail user.
        /// You can only have one default domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDefaultMailDomain service method.</param>
        /// 
        /// <returns>The response from the UpdateDefaultMailDomain service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.MailDomainNotFoundException">
        /// The domain specified is not found in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.MailDomainStateException">
        /// After a domain has been added to the organization, it must be verified. The domain
        /// is not yet verified.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/UpdateDefaultMailDomain">REST API Reference for UpdateDefaultMailDomain Operation</seealso>
        UpdateDefaultMailDomainResponse UpdateDefaultMailDomain(UpdateDefaultMailDomainRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDefaultMailDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDefaultMailDomain operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDefaultMailDomain
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/UpdateDefaultMailDomain">REST API Reference for UpdateDefaultMailDomain Operation</seealso>
        IAsyncResult BeginUpdateDefaultMailDomain(UpdateDefaultMailDomainRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDefaultMailDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDefaultMailDomain.</param>
        /// 
        /// <returns>Returns a  UpdateDefaultMailDomainResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/UpdateDefaultMailDomain">REST API Reference for UpdateDefaultMailDomain Operation</seealso>
        UpdateDefaultMailDomainResponse EndUpdateDefaultMailDomain(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateGroup


        /// <summary>
        /// Updates attributes in a group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateGroup service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on a user, group, or resource that isn't in the expected
        /// state, such as trying to delete an active user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.UnsupportedOperationException">
        /// You can't perform a write operation against a read-only directory.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        UpdateGroupResponse UpdateGroup(UpdateGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        IAsyncResult BeginUpdateGroup(UpdateGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGroup.</param>
        /// 
        /// <returns>Returns a  UpdateGroupResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        UpdateGroupResponse EndUpdateGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateImpersonationRole


        /// <summary>
        /// Updates an impersonation role for the given WorkMail organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateImpersonationRole service method.</param>
        /// 
        /// <returns>The response from the UpdateImpersonationRole service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on a user, group, or resource that isn't in the expected
        /// state, such as trying to delete an active user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.LimitExceededException">
        /// The request exceeds the limit of the resource.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/UpdateImpersonationRole">REST API Reference for UpdateImpersonationRole Operation</seealso>
        UpdateImpersonationRoleResponse UpdateImpersonationRole(UpdateImpersonationRoleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateImpersonationRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateImpersonationRole operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateImpersonationRole
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/UpdateImpersonationRole">REST API Reference for UpdateImpersonationRole Operation</seealso>
        IAsyncResult BeginUpdateImpersonationRole(UpdateImpersonationRoleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateImpersonationRole operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateImpersonationRole.</param>
        /// 
        /// <returns>Returns a  UpdateImpersonationRoleResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/UpdateImpersonationRole">REST API Reference for UpdateImpersonationRole Operation</seealso>
        UpdateImpersonationRoleResponse EndUpdateImpersonationRole(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateMailboxQuota


        /// <summary>
        /// Updates a user's current mailbox quota for a specified organization and user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMailboxQuota service method.</param>
        /// 
        /// <returns>The response from the UpdateMailboxQuota service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on a user, group, or resource that isn't in the expected
        /// state, such as trying to delete an active user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/UpdateMailboxQuota">REST API Reference for UpdateMailboxQuota Operation</seealso>
        UpdateMailboxQuotaResponse UpdateMailboxQuota(UpdateMailboxQuotaRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMailboxQuota operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMailboxQuota operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMailboxQuota
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/UpdateMailboxQuota">REST API Reference for UpdateMailboxQuota Operation</seealso>
        IAsyncResult BeginUpdateMailboxQuota(UpdateMailboxQuotaRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMailboxQuota operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMailboxQuota.</param>
        /// 
        /// <returns>Returns a  UpdateMailboxQuotaResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/UpdateMailboxQuota">REST API Reference for UpdateMailboxQuota Operation</seealso>
        UpdateMailboxQuotaResponse EndUpdateMailboxQuota(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateMobileDeviceAccessRule


        /// <summary>
        /// Updates a mobile device access rule for the specified WorkMail organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMobileDeviceAccessRule service method.</param>
        /// 
        /// <returns>The response from the UpdateMobileDeviceAccessRule service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/UpdateMobileDeviceAccessRule">REST API Reference for UpdateMobileDeviceAccessRule Operation</seealso>
        UpdateMobileDeviceAccessRuleResponse UpdateMobileDeviceAccessRule(UpdateMobileDeviceAccessRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMobileDeviceAccessRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMobileDeviceAccessRule operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMobileDeviceAccessRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/UpdateMobileDeviceAccessRule">REST API Reference for UpdateMobileDeviceAccessRule Operation</seealso>
        IAsyncResult BeginUpdateMobileDeviceAccessRule(UpdateMobileDeviceAccessRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMobileDeviceAccessRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMobileDeviceAccessRule.</param>
        /// 
        /// <returns>Returns a  UpdateMobileDeviceAccessRuleResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/UpdateMobileDeviceAccessRule">REST API Reference for UpdateMobileDeviceAccessRule Operation</seealso>
        UpdateMobileDeviceAccessRuleResponse EndUpdateMobileDeviceAccessRule(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdatePrimaryEmailAddress


        /// <summary>
        /// Updates the primary email for a user, group, or resource. The current email is moved
        /// into the list of aliases (or swapped between an existing alias and the current primary
        /// email), and the email provided in the input is promoted as the primary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePrimaryEmailAddress service method.</param>
        /// 
        /// <returns>The response from the UpdatePrimaryEmailAddress service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryServiceAuthenticationFailedException">
        /// The directory service doesn't recognize the credentials supplied by WorkMail.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryUnavailableException">
        /// The directory is unavailable. It might be located in another Region or deleted.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EmailAddressInUseException">
        /// The email address that you're trying to assign is already created for a different
        /// user, group, or resource.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on a user, group, or resource that isn't in the expected
        /// state, such as trying to delete an active user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.MailDomainNotFoundException">
        /// The domain specified is not found in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.MailDomainStateException">
        /// After a domain has been added to the organization, it must be verified. The domain
        /// is not yet verified.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.UnsupportedOperationException">
        /// You can't perform a write operation against a read-only directory.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/UpdatePrimaryEmailAddress">REST API Reference for UpdatePrimaryEmailAddress Operation</seealso>
        UpdatePrimaryEmailAddressResponse UpdatePrimaryEmailAddress(UpdatePrimaryEmailAddressRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePrimaryEmailAddress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePrimaryEmailAddress operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePrimaryEmailAddress
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/UpdatePrimaryEmailAddress">REST API Reference for UpdatePrimaryEmailAddress Operation</seealso>
        IAsyncResult BeginUpdatePrimaryEmailAddress(UpdatePrimaryEmailAddressRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePrimaryEmailAddress operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePrimaryEmailAddress.</param>
        /// 
        /// <returns>Returns a  UpdatePrimaryEmailAddressResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/UpdatePrimaryEmailAddress">REST API Reference for UpdatePrimaryEmailAddress Operation</seealso>
        UpdatePrimaryEmailAddressResponse EndUpdatePrimaryEmailAddress(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateResource


        /// <summary>
        /// Updates data for the resource. To have the latest information, it must be preceded
        /// by a <a>DescribeResource</a> call. The dataset in the request should be the one expected
        /// when performing another <c>DescribeResource</c> call.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResource service method.</param>
        /// 
        /// <returns>The response from the UpdateResource service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryUnavailableException">
        /// The directory is unavailable. It might be located in another Region or deleted.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EmailAddressInUseException">
        /// The email address that you're trying to assign is already created for a different
        /// user, group, or resource.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on a user, group, or resource that isn't in the expected
        /// state, such as trying to delete an active user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidConfigurationException">
        /// The configuration for a resource isn't valid. A resource must either be able to auto-respond
        /// to requests or have at least one delegate associated that can do so on its behalf.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.MailDomainNotFoundException">
        /// The domain specified is not found in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.MailDomainStateException">
        /// After a domain has been added to the organization, it must be verified. The domain
        /// is not yet verified.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.NameAvailabilityException">
        /// The user, group, or resource name isn't unique in WorkMail.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.UnsupportedOperationException">
        /// You can't perform a write operation against a read-only directory.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/UpdateResource">REST API Reference for UpdateResource Operation</seealso>
        UpdateResourceResponse UpdateResource(UpdateResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateResource operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/UpdateResource">REST API Reference for UpdateResource Operation</seealso>
        IAsyncResult BeginUpdateResource(UpdateResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateResource.</param>
        /// 
        /// <returns>Returns a  UpdateResourceResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/UpdateResource">REST API Reference for UpdateResource Operation</seealso>
        UpdateResourceResponse EndUpdateResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateUser


        /// <summary>
        /// Updates data for the user. To have the latest information, it must be preceded by
        /// a <a>DescribeUser</a> call. The dataset in the request should be the one expected
        /// when performing another <c>DescribeUser</c> call.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser service method.</param>
        /// 
        /// <returns>The response from the UpdateUser service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryServiceAuthenticationFailedException">
        /// The directory service doesn't recognize the credentials supplied by WorkMail.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryUnavailableException">
        /// The directory is unavailable. It might be located in another Region or deleted.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on a user, group, or resource that isn't in the expected
        /// state, such as trying to delete an active user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.UnsupportedOperationException">
        /// You can't perform a write operation against a read-only directory.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        UpdateUserResponse UpdateUser(UpdateUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser operation on AmazonWorkMailClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        IAsyncResult BeginUpdateUser(UpdateUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUser.</param>
        /// 
        /// <returns>Returns a  UpdateUserResult from WorkMail.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        UpdateUserResponse EndUpdateUser(IAsyncResult asyncResult);

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