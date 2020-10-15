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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.WorkMail.Model;

namespace Amazon.WorkMail
{
    /// <summary>
    /// Interface for accessing WorkMail
    ///
    /// Amazon WorkMail is a secure, managed business email and calendaring service with support
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

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IWorkMailPaginatorFactory Paginators { get; }

        
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/AssociateDelegateToResource">REST API Reference for AssociateDelegateToResource Operation</seealso>
        AssociateDelegateToResourceResponse AssociateDelegateToResource(AssociateDelegateToResourceRequest request);



        /// <summary>
        /// Adds a member (user or group) to the resource's set of delegates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateDelegateToResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/AssociateDelegateToResource">REST API Reference for AssociateDelegateToResource Operation</seealso>
        Task<AssociateDelegateToResourceResponse> AssociateDelegateToResourceAsync(AssociateDelegateToResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Adds a member (user or group) to the group's set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateMemberToGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<AssociateMemberToGroupResponse> AssociateMemberToGroupAsync(AssociateMemberToGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Cancels a mailbox export job.
        /// 
        ///  <note> 
        /// <para>
        /// If the mailbox export job is near completion, it might not be possible to cancel it.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelMailboxExportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CancelMailboxExportJobResponse> CancelMailboxExportJobAsync(CancelMailboxExportJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateAlias


        /// <summary>
        /// Adds an alias to the set of a given member (user or group) of Amazon WorkMail.
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
        /// For an email or alias to be created in Amazon WorkMail, the included domain must be
        /// defined in the organization.
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
        /// Adds an alias to the set of a given member (user or group) of Amazon WorkMail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// For an email or alias to be created in Amazon WorkMail, the included domain must be
        /// defined in the organization.
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
        Task<CreateAliasResponse> CreateAliasAsync(CreateAliasRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateGroup


        /// <summary>
        /// Creates a group that can be used in Amazon WorkMail by calling the <a>RegisterToWorkMail</a>
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
        /// The user, group, or resource name isn't unique in Amazon WorkMail.
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
        /// This user, group, or resource name is not allowed in Amazon WorkMail.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.UnsupportedOperationException">
        /// You can't perform a write operation against a read-only directory.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        CreateGroupResponse CreateGroup(CreateGroupRequest request);



        /// <summary>
        /// Creates a group that can be used in Amazon WorkMail by calling the <a>RegisterToWorkMail</a>
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// The user, group, or resource name isn't unique in Amazon WorkMail.
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
        /// This user, group, or resource name is not allowed in Amazon WorkMail.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.UnsupportedOperationException">
        /// You can't perform a write operation against a read-only directory.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        Task<CreateGroupResponse> CreateGroupAsync(CreateGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateOrganization


        /// <summary>
        /// Creates a new Amazon WorkMail organization. Optionally, you can choose to associate
        /// an existing AWS Directory Service directory with your organization. If an AWS Directory
        /// Service directory ID is specified, the organization alias must match the directory
        /// alias. If you choose not to associate an existing directory with your organization,
        /// then we create a new Amazon WorkMail directory for you. For more information, see
        /// <a href="https://docs.aws.amazon.com/workmail/latest/adminguide/add_new_organization.html">Adding
        /// an organization</a> in the <i>Amazon WorkMail Administrator Guide</i>.
        /// 
        ///  
        /// <para>
        /// You can associate multiple email domains with an organization, then set your default
        /// email domain from the Amazon WorkMail console. You can also associate a domain that
        /// is managed in an Amazon Route 53 public hosted zone. For more information, see <a
        /// href="https://docs.aws.amazon.com/workmail/latest/adminguide/add_domain.html">Adding
        /// a domain</a> and <a href="https://docs.aws.amazon.com/workmail/latest/adminguide/default_domain.html">Choosing
        /// the default domain</a> in the <i>Amazon WorkMail Administrator Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Optionally, you can use a customer managed master key from AWS Key Management Service
        /// (AWS KMS) to encrypt email for your organization. If you don't associate an AWS KMS
        /// key, Amazon WorkMail creates a default AWS managed master key for you.
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
        /// The user, group, or resource name isn't unique in Amazon WorkMail.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateOrganization">REST API Reference for CreateOrganization Operation</seealso>
        CreateOrganizationResponse CreateOrganization(CreateOrganizationRequest request);



        /// <summary>
        /// Creates a new Amazon WorkMail organization. Optionally, you can choose to associate
        /// an existing AWS Directory Service directory with your organization. If an AWS Directory
        /// Service directory ID is specified, the organization alias must match the directory
        /// alias. If you choose not to associate an existing directory with your organization,
        /// then we create a new Amazon WorkMail directory for you. For more information, see
        /// <a href="https://docs.aws.amazon.com/workmail/latest/adminguide/add_new_organization.html">Adding
        /// an organization</a> in the <i>Amazon WorkMail Administrator Guide</i>.
        /// 
        ///  
        /// <para>
        /// You can associate multiple email domains with an organization, then set your default
        /// email domain from the Amazon WorkMail console. You can also associate a domain that
        /// is managed in an Amazon Route 53 public hosted zone. For more information, see <a
        /// href="https://docs.aws.amazon.com/workmail/latest/adminguide/add_domain.html">Adding
        /// a domain</a> and <a href="https://docs.aws.amazon.com/workmail/latest/adminguide/default_domain.html">Choosing
        /// the default domain</a> in the <i>Amazon WorkMail Administrator Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Optionally, you can use a customer managed master key from AWS Key Management Service
        /// (AWS KMS) to encrypt email for your organization. If you don't associate an AWS KMS
        /// key, Amazon WorkMail creates a default AWS managed master key for you.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// The user, group, or resource name isn't unique in Amazon WorkMail.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateOrganization">REST API Reference for CreateOrganization Operation</seealso>
        Task<CreateOrganizationResponse> CreateOrganizationAsync(CreateOrganizationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateResource


        /// <summary>
        /// Creates a new Amazon WorkMail resource.
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
        /// The user, group, or resource name isn't unique in Amazon WorkMail.
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
        /// This user, group, or resource name is not allowed in Amazon WorkMail.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateResource">REST API Reference for CreateResource Operation</seealso>
        CreateResourceResponse CreateResource(CreateResourceRequest request);



        /// <summary>
        /// Creates a new Amazon WorkMail resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// The user, group, or resource name isn't unique in Amazon WorkMail.
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
        /// This user, group, or resource name is not allowed in Amazon WorkMail.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateResource">REST API Reference for CreateResource Operation</seealso>
        Task<CreateResourceResponse> CreateResourceAsync(CreateResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateUser


        /// <summary>
        /// Creates a user who can be used in Amazon WorkMail by calling the <a>RegisterToWorkMail</a>
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
        /// The user, group, or resource name isn't unique in Amazon WorkMail.
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
        /// This user, group, or resource name is not allowed in Amazon WorkMail.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.UnsupportedOperationException">
        /// You can't perform a write operation against a read-only directory.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateUser">REST API Reference for CreateUser Operation</seealso>
        CreateUserResponse CreateUser(CreateUserRequest request);



        /// <summary>
        /// Creates a user who can be used in Amazon WorkMail by calling the <a>RegisterToWorkMail</a>
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// The user, group, or resource name isn't unique in Amazon WorkMail.
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
        /// This user, group, or resource name is not allowed in Amazon WorkMail.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.UnsupportedOperationException">
        /// You can't perform a write operation against a read-only directory.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/CreateUser">REST API Reference for CreateUser Operation</seealso>
        Task<CreateUserResponse> CreateUserAsync(CreateUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteAccessControlRule


        /// <summary>
        /// Deletes an access control rule for the specified WorkMail organization.
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
        /// Deletes an access control rule for the specified WorkMail organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessControlRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteAccessControlRuleResponse> DeleteAccessControlRuleAsync(DeleteAccessControlRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Remove one or more specified aliases from a set of aliases for a given user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteAliasResponse> DeleteAliasAsync(DeleteAliasRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteGroup


        /// <summary>
        /// Deletes a group from Amazon WorkMail.
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
        /// Deletes a group from Amazon WorkMail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteGroupResponse> DeleteGroupAsync(DeleteGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes permissions granted to a member (user or group).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMailboxPermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteMailboxPermissionsResponse> DeleteMailboxPermissionsAsync(DeleteMailboxPermissionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteOrganization


        /// <summary>
        /// Deletes an Amazon WorkMail organization and all underlying AWS resources managed by
        /// Amazon WorkMail as part of the organization. You can choose whether to delete the
        /// associated directory. For more information, see <a href="https://docs.aws.amazon.com/workmail/latest/adminguide/remove_organization.html">Removing
        /// an organization</a> in the <i>Amazon WorkMail Administrator Guide</i>.
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
        /// Deletes an Amazon WorkMail organization and all underlying AWS resources managed by
        /// Amazon WorkMail as part of the organization. You can choose whether to delete the
        /// associated directory. For more information, see <a href="https://docs.aws.amazon.com/workmail/latest/adminguide/remove_organization.html">Removing
        /// an organization</a> in the <i>Amazon WorkMail Administrator Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteOrganizationResponse> DeleteOrganizationAsync(DeleteOrganizationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteResource">REST API Reference for DeleteResource Operation</seealso>
        DeleteResourceResponse DeleteResource(DeleteResourceRequest request);



        /// <summary>
        /// Deletes the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DeleteResource">REST API Reference for DeleteResource Operation</seealso>
        Task<DeleteResourceResponse> DeleteResourceAsync(DeleteResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes the specified retention policy from the specified organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRetentionPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteRetentionPolicyResponse> DeleteRetentionPolicyAsync(DeleteRetentionPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteUser


        /// <summary>
        /// Deletes a user from Amazon WorkMail and all subsequent systems. Before you can delete
        /// a user, the user state must be <code>DISABLED</code>. Use the <a>DescribeUser</a>
        /// action to confirm the user state.
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
        /// Deletes a user from Amazon WorkMail and all subsequent systems. Before you can delete
        /// a user, the user state must be <code>DISABLED</code>. Use the <a>DescribeUser</a>
        /// action to confirm the user state.
        /// 
        ///  
        /// <para>
        /// Deleting a user is permanent and cannot be undone. WorkMail archives user mailboxes
        /// for 30 days before they are permanently removed.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeregisterFromWorkMail


        /// <summary>
        /// Mark a user, group, or resource as no longer used in Amazon WorkMail. This action
        /// disassociates the mailbox and schedules it for clean-up. WorkMail keeps mailboxes
        /// for 30 days before they are permanently removed. The functionality in the console
        /// is <i>Disable</i>.
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
        /// Mark a user, group, or resource as no longer used in Amazon WorkMail. This action
        /// disassociates the mailbox and schedules it for clean-up. WorkMail keeps mailboxes
        /// for 30 days before they are permanently removed. The functionality in the console
        /// is <i>Disable</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterFromWorkMail service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeregisterFromWorkMailResponse> DeregisterFromWorkMailAsync(DeregisterFromWorkMailRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns the data available for the group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeGroupResponse> DescribeGroupAsync(DescribeGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Describes the current status of a mailbox export job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMailboxExportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeMailboxExportJobResponse> DescribeMailboxExportJobAsync(DescribeMailboxExportJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Provides more information regarding a given organization based on its identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeOrganizationResponse> DescribeOrganizationAsync(DescribeOrganizationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DescribeResource">REST API Reference for DescribeResource Operation</seealso>
        DescribeResourceResponse DescribeResource(DescribeResourceRequest request);



        /// <summary>
        /// Returns the data available for the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DescribeResource">REST API Reference for DescribeResource Operation</seealso>
        Task<DescribeResourceResponse> DescribeResourceAsync(DescribeResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeUser


        /// <summary>
        /// Provides information regarding the user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUser service method.</param>
        /// 
        /// <returns>The response from the DescribeUser service method, as returned by WorkMail.</returns>
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
        /// Provides information regarding the user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeUser service method, as returned by WorkMail.</returns>
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
        Task<DescribeUserResponse> DescribeUserAsync(DescribeUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DisassociateDelegateFromResource">REST API Reference for DisassociateDelegateFromResource Operation</seealso>
        DisassociateDelegateFromResourceResponse DisassociateDelegateFromResource(DisassociateDelegateFromResourceRequest request);



        /// <summary>
        /// Removes a member from the resource's set of delegates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateDelegateFromResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/DisassociateDelegateFromResource">REST API Reference for DisassociateDelegateFromResource Operation</seealso>
        Task<DisassociateDelegateFromResourceResponse> DisassociateDelegateFromResourceAsync(DisassociateDelegateFromResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Removes a member from a group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMemberFromGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DisassociateMemberFromGroupResponse> DisassociateMemberFromGroupAsync(DisassociateMemberFromGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetAccessControlEffect


        /// <summary>
        /// Gets the effects of an organization's access control rules as they apply to a specified
        /// IPv4 address, access protocol action, or user ID.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/GetAccessControlEffect">REST API Reference for GetAccessControlEffect Operation</seealso>
        GetAccessControlEffectResponse GetAccessControlEffect(GetAccessControlEffectRequest request);



        /// <summary>
        /// Gets the effects of an organization's access control rules as they apply to a specified
        /// IPv4 address, access protocol action, or user ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessControlEffect service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/GetAccessControlEffect">REST API Reference for GetAccessControlEffect Operation</seealso>
        Task<GetAccessControlEffectResponse> GetAccessControlEffectAsync(GetAccessControlEffectRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets the default retention policy details for the specified organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDefaultRetentionPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetDefaultRetentionPolicyResponse> GetDefaultRetentionPolicyAsync(GetDefaultRetentionPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Requests a user's mailbox details for a specified organization and user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMailboxDetails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMailboxDetails service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the user, group, or resource does not exist in your organization.
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
        Task<GetMailboxDetailsResponse> GetMailboxDetailsAsync(GetMailboxDetailsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists the access control rules for the specified organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessControlRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListAccessControlRulesResponse> ListAccessControlRulesAsync(ListAccessControlRulesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates a paginated call to list the aliases associated with a given entity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAliases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListAliasesResponse> ListAliasesAsync(ListAliasesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns an overview of the members of a group. Users and groups can be members of
        /// a group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupMembers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListGroupMembersResponse> ListGroupMembersAsync(ListGroupMembersRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns summaries of the organization's groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListGroupsResponse> ListGroupsAsync(ListGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists the mailbox export jobs started for the specified organization within the last
        /// seven days.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMailboxExportJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListMailboxExportJobsResponse> ListMailboxExportJobsAsync(ListMailboxExportJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists the mailbox permissions associated with a user, group, or resource mailbox.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMailboxPermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListMailboxPermissionsResponse> ListMailboxPermissionsAsync(ListMailboxPermissionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns summaries of the customer's organizations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOrganizations service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListOrganizations">REST API Reference for ListOrganizations Operation</seealso>
        Task<ListOrganizationsResponse> ListOrganizationsAsync(ListOrganizationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListResourceDelegates">REST API Reference for ListResourceDelegates Operation</seealso>
        ListResourceDelegatesResponse ListResourceDelegates(ListResourceDelegatesRequest request);



        /// <summary>
        /// Lists the delegates associated with a resource. Users and groups can be resource delegates
        /// and answer requests on behalf of the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceDelegates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListResourceDelegates">REST API Reference for ListResourceDelegates Operation</seealso>
        Task<ListResourceDelegatesResponse> ListResourceDelegatesAsync(ListResourceDelegatesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListResources">REST API Reference for ListResources Operation</seealso>
        ListResourcesResponse ListResources(ListResourcesRequest request);



        /// <summary>
        /// Returns summaries of the organization's resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListResources">REST API Reference for ListResources Operation</seealso>
        Task<ListResourcesResponse> ListResourcesAsync(ListResourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags applied to an Amazon WorkMail organization resource.
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
        /// Lists the tags applied to an Amazon WorkMail organization resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns summaries of the organization's users.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutAccessControlRule


        /// <summary>
        /// Adds a new access control rule for the specified organization. The rule allows or
        /// denies access to the organization for the specified IPv4 addresses, access protocol
        /// actions, and user IDs. Adding a new rule with the same name as an existing rule replaces
        /// the older rule.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/PutAccessControlRule">REST API Reference for PutAccessControlRule Operation</seealso>
        PutAccessControlRuleResponse PutAccessControlRule(PutAccessControlRuleRequest request);



        /// <summary>
        /// Adds a new access control rule for the specified organization. The rule allows or
        /// denies access to the organization for the specified IPv4 addresses, access protocol
        /// actions, and user IDs. Adding a new rule with the same name as an existing rule replaces
        /// the older rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAccessControlRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/PutAccessControlRule">REST API Reference for PutAccessControlRule Operation</seealso>
        Task<PutAccessControlRuleResponse> PutAccessControlRuleAsync(PutAccessControlRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Sets permissions for a user, group, or resource. This replaces any pre-existing permissions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMailboxPermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<PutMailboxPermissionsResponse> PutMailboxPermissionsAsync(PutMailboxPermissionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Puts a retention policy to the specified organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRetentionPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<PutRetentionPolicyResponse> PutRetentionPolicyAsync(PutRetentionPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RegisterToWorkMail


        /// <summary>
        /// Registers an existing and disabled user, group, or resource for Amazon WorkMail use
        /// by associating a mailbox and calendaring capabilities. It performs no change if the
        /// user, group, or resource is enabled and fails if the user, group, or resource is deleted.
        /// This operation results in the accumulation of costs. For more information, see <a
        /// href="https://aws.amazon.com/workmail/pricing">Pricing</a>. The equivalent console
        /// functionality for this operation is <i>Enable</i>. 
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
        /// For an email or alias to be created in Amazon WorkMail, the included domain must be
        /// defined in the organization.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/RegisterToWorkMail">REST API Reference for RegisterToWorkMail Operation</seealso>
        RegisterToWorkMailResponse RegisterToWorkMail(RegisterToWorkMailRequest request);



        /// <summary>
        /// Registers an existing and disabled user, group, or resource for Amazon WorkMail use
        /// by associating a mailbox and calendaring capabilities. It performs no change if the
        /// user, group, or resource is enabled and fails if the user, group, or resource is deleted.
        /// This operation results in the accumulation of costs. For more information, see <a
        /// href="https://aws.amazon.com/workmail/pricing">Pricing</a>. The equivalent console
        /// functionality for this operation is <i>Enable</i>. 
        /// 
        ///  
        /// <para>
        /// Users can either be created by calling the <a>CreateUser</a> API operation or they
        /// can be synchronized from your directory. For more information, see <a>DeregisterFromWorkMail</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterToWorkMail service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// For an email or alias to be created in Amazon WorkMail, the included domain must be
        /// defined in the organization.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/RegisterToWorkMail">REST API Reference for RegisterToWorkMail Operation</seealso>
        Task<RegisterToWorkMailResponse> RegisterToWorkMailAsync(RegisterToWorkMailRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Allows the administrator to reset the password for a user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetPassword service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ResetPasswordResponse> ResetPasswordAsync(ResetPasswordRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartMailboxExportJob


        /// <summary>
        /// Starts a mailbox export job to export MIME-format email messages and calendar items
        /// from the specified mailbox to the specified Amazon Simple Storage Service (Amazon
        /// S3) bucket. For more information, see <a href="https://docs.aws.amazon.com/workmail/latest/adminguide/mail-export.html">Exporting
        /// mailbox content</a> in the <i>Amazon WorkMail Administrator Guide</i>.
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
        /// Starts a mailbox export job to export MIME-format email messages and calendar items
        /// from the specified mailbox to the specified Amazon Simple Storage Service (Amazon
        /// S3) bucket. For more information, see <a href="https://docs.aws.amazon.com/workmail/latest/adminguide/mail-export.html">Exporting
        /// mailbox content</a> in the <i>Amazon WorkMail Administrator Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMailboxExportJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StartMailboxExportJobResponse> StartMailboxExportJobAsync(StartMailboxExportJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Applies the specified tags to the specified Amazon WorkMail organization resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by WorkMail.</returns>
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
        /// Applies the specified tags to the specified Amazon WorkMail organization resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by WorkMail.</returns>
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
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Untags the specified tags from the specified Amazon WorkMail organization resource.
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
        /// Untags the specified tags from the specified Amazon WorkMail organization resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.ResourceNotFoundException">
        /// The resource cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates a user's current mailbox quota for a specified organization and user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMailboxQuota service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateMailboxQuotaResponse> UpdateMailboxQuotaAsync(UpdateMailboxQuotaRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// For an email or alias to be created in Amazon WorkMail, the included domain must be
        /// defined in the organization.
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
        /// Updates the primary email for a user, group, or resource. The current email is moved
        /// into the list of aliases (or swapped between an existing alias and the current primary
        /// email), and the email provided in the input is promoted as the primary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePrimaryEmailAddress service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// For an email or alias to be created in Amazon WorkMail, the included domain must be
        /// defined in the organization.
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
        Task<UpdatePrimaryEmailAddressResponse> UpdatePrimaryEmailAddressAsync(UpdatePrimaryEmailAddressRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateResource


        /// <summary>
        /// Updates data for the resource. To have the latest information, it must be preceded
        /// by a <a>DescribeResource</a> call. The dataset in the request should be the one expected
        /// when performing another <code>DescribeResource</code> call.
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
        /// <exception cref="Amazon.WorkMail.Model.MailDomainNotFoundException">
        /// For an email or alias to be created in Amazon WorkMail, the included domain must be
        /// defined in the organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.MailDomainStateException">
        /// After a domain has been added to the organization, it must be verified. The domain
        /// is not yet verified.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.NameAvailabilityException">
        /// The user, group, or resource name isn't unique in Amazon WorkMail.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/UpdateResource">REST API Reference for UpdateResource Operation</seealso>
        UpdateResourceResponse UpdateResource(UpdateResourceRequest request);



        /// <summary>
        /// Updates data for the resource. To have the latest information, it must be preceded
        /// by a <a>DescribeResource</a> call. The dataset in the request should be the one expected
        /// when performing another <code>DescribeResource</code> call.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// <exception cref="Amazon.WorkMail.Model.MailDomainNotFoundException">
        /// For an email or alias to be created in Amazon WorkMail, the included domain must be
        /// defined in the organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.MailDomainStateException">
        /// After a domain has been added to the organization, it must be verified. The domain
        /// is not yet verified.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.NameAvailabilityException">
        /// The user, group, or resource name isn't unique in Amazon WorkMail.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state to perform certain operations on the organization
        /// or its members.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workmail-2017-10-01/UpdateResource">REST API Reference for UpdateResource Operation</seealso>
        Task<UpdateResourceResponse> UpdateResourceAsync(UpdateResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}