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
 * Do not modify this file. This file is generated from the workmail-2017-10-01.normal.json service model.
 */


using System;
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
    /// and calendars using Microsoft Outlook, your browser, or their native iOS and Android
    /// email applications. You can integrate Amazon WorkMail with your existing corporate
    /// directory and control both the keys that encrypt your data and the location in which
    /// your data is stored.
    /// 
    ///  
    /// <para>
    /// The Amazon WorkMail API is designed for the following scenarios:
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
    /// All Amazon WorkMail API actions are Amazon-authenticated and certificate-signed. They
    /// not only require the use of the AWS SDK, but also allow for the exclusive use of IAM
    /// users and roles to help facilitate access, trust, and permission policies. By creating
    /// a role and allowing an IAM user to access the Amazon WorkMail site, the IAM user gains
    /// full administrative visibility into the entire Amazon WorkMail organization (or as
    /// set in the IAM policy). This includes, but is not limited to, the ability to create,
    /// update, and delete users, groups, and resources. This allows developers to perform
    /// the scenarios listed above, as well as give users the ability to grant access on a
    /// selective basis using the IAM model.
    /// </para>
    /// </summary>
    public partial interface IAmazonWorkMail : IAmazonService, IDisposable
    {

        
        #region  AssociateDelegateToResource


        /// <summary>
        /// Adds a member to the resource's set of delegates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateDelegateToResource service method.</param>
        /// 
        /// <returns>The response from the AssociateDelegateToResource service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the entity is valid, but it does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on an entity that isn't in the expected state, such
        /// as trying to update a deleted user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state (Active or Synchronizing) to perform certain
        /// operations on the organization or its entities.
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
        /// Adds a member to the group's set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateMemberToGroup service method.</param>
        /// 
        /// <returns>The response from the AssociateMemberToGroup service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryServiceAuthenticationFailedException">
        /// The Directory Service doesn't recognize the credentials supplied by the Amazon WorkMail
        /// service.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryUnavailableException">
        /// The directory that you are trying to perform operations on isn't available.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the entity is valid, but it does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on an entity that isn't in the expected state, such
        /// as trying to update a deleted user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state (Active or Synchronizing) to perform certain
        /// operations on the organization or its entities.
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
        
        #region  CreateAlias


        /// <summary>
        /// Adds an alias to the set of a given member of Amazon WorkMail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAlias service method.</param>
        /// 
        /// <returns>The response from the CreateAlias service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EmailAddressInUseException">
        /// The email address that you're trying to assign is already created for a different
        /// user, group, or resource.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the entity is valid, but it does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on an entity that isn't in the expected state, such
        /// as trying to update a deleted user.
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
        /// The organization must have a valid state (Active or Synchronizing) to perform certain
        /// operations on the organization or its entities.
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
        
        #region  CreateGroup


        /// <summary>
        /// Creates a group that can be used in Amazon WorkMail by calling the RegisterToWorkMail
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup service method.</param>
        /// 
        /// <returns>The response from the CreateGroup service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryServiceAuthenticationFailedException">
        /// The Directory Service doesn't recognize the credentials supplied by the Amazon WorkMail
        /// service.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryUnavailableException">
        /// The directory that you are trying to perform operations on isn't available.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.NameAvailabilityException">
        /// The entity (user, group, or user) name isn't unique in Amazon WorkMail.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state (Active or Synchronizing) to perform certain
        /// operations on the organization or its entities.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.ReservedNameException">
        /// This entity name is not allowed in Amazon WorkMail.
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
        
        #region  CreateResource


        /// <summary>
        /// Creates a new Amazon WorkMail resource. The available types are equipment and room.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResource service method.</param>
        /// 
        /// <returns>The response from the CreateResource service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryServiceAuthenticationFailedException">
        /// The Directory Service doesn't recognize the credentials supplied by the Amazon WorkMail
        /// service.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryUnavailableException">
        /// The directory that you are trying to perform operations on isn't available.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.NameAvailabilityException">
        /// The entity (user, group, or user) name isn't unique in Amazon WorkMail.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state (Active or Synchronizing) to perform certain
        /// operations on the organization or its entities.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.ReservedNameException">
        /// This entity name is not allowed in Amazon WorkMail.
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
        /// Creates a user who can be used in Amazon WorkMail by calling the RegisterToWorkMail
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUser service method.</param>
        /// 
        /// <returns>The response from the CreateUser service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryServiceAuthenticationFailedException">
        /// The Directory Service doesn't recognize the credentials supplied by the Amazon WorkMail
        /// service.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryUnavailableException">
        /// The directory that you are trying to perform operations on isn't available.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidPasswordException">
        /// The supplied password doesn't match the minimum security constraints, such as length
        /// or use of special characters.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.NameAvailabilityException">
        /// The entity (user, group, or user) name isn't unique in Amazon WorkMail.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state (Active or Synchronizing) to perform certain
        /// operations on the organization or its entities.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.ReservedNameException">
        /// This entity name is not allowed in Amazon WorkMail.
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
        
        #region  DeleteAlias


        /// <summary>
        /// Remove the alias from a set of aliases for a given user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlias service method.</param>
        /// 
        /// <returns>The response from the DeleteAlias service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the entity is valid, but it does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on an entity that isn't in the expected state, such
        /// as trying to update a deleted user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state (Active or Synchronizing) to perform certain
        /// operations on the organization or its entities.
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
        
        #region  DeleteGroup


        /// <summary>
        /// Deletes a group from Amazon WorkMail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteGroup service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryServiceAuthenticationFailedException">
        /// The Directory Service doesn't recognize the credentials supplied by the Amazon WorkMail
        /// service.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryUnavailableException">
        /// The directory that you are trying to perform operations on isn't available.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on an entity that isn't in the expected state, such
        /// as trying to update a deleted user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state (Active or Synchronizing) to perform certain
        /// operations on the organization or its entities.
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
        
        #region  DeleteMailboxPermissions


        /// <summary>
        /// Deletes permissions granted to a user or group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMailboxPermissions service method.</param>
        /// 
        /// <returns>The response from the DeleteMailboxPermissions service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the entity is valid, but it does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on an entity that isn't in the expected state, such
        /// as trying to update a deleted user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state (Active or Synchronizing) to perform certain
        /// operations on the organization or its entities.
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
        
        #region  DeleteResource


        /// <summary>
        /// Deletes the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResource service method.</param>
        /// 
        /// <returns>The response from the DeleteResource service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on an entity that isn't in the expected state, such
        /// as trying to update a deleted user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state (Active or Synchronizing) to perform certain
        /// operations on the organization or its entities.
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
        
        #region  DeleteUser


        /// <summary>
        /// Deletes a user from Amazon WorkMail and all subsequent systems. The action can't be
        /// undone. The mailbox is kept as-is for a minimum of 30 days, without any means to restore
        /// it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser service method.</param>
        /// 
        /// <returns>The response from the DeleteUser service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryServiceAuthenticationFailedException">
        /// The Directory Service doesn't recognize the credentials supplied by the Amazon WorkMail
        /// service.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryUnavailableException">
        /// The directory that you are trying to perform operations on isn't available.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on an entity that isn't in the expected state, such
        /// as trying to update a deleted user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state (Active or Synchronizing) to perform certain
        /// operations on the organization or its entities.
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
        /// Mark a user, group, or resource as no longer used in Amazon WorkMail. This action
        /// disassociates the mailbox and schedules it for clean-up. Amazon WorkMail keeps mailboxes
        /// for 30 days before they are permanently removed. The functionality in the console
        /// is <i>Disable</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterFromWorkMail service method.</param>
        /// 
        /// <returns>The response from the DeregisterFromWorkMail service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the entity is valid, but it does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on an entity that isn't in the expected state, such
        /// as trying to update a deleted user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state (Active or Synchronizing) to perform certain
        /// operations on the organization or its entities.
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
        
        #region  DescribeGroup


        /// <summary>
        /// Returns the data available for the group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGroup service method.</param>
        /// 
        /// <returns>The response from the DescribeGroup service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the entity is valid, but it does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state (Active or Synchronizing) to perform certain
        /// operations on the organization or its entities.
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
        /// The identifier supplied for the entity is valid, but it does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state (Active or Synchronizing) to perform certain
        /// operations on the organization or its entities.
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
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the entity is valid, but it does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state (Active or Synchronizing) to perform certain
        /// operations on the organization or its entities.
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
        /// The identifier supplied for the entity is valid, but it does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on an entity that isn't in the expected state, such
        /// as trying to update a deleted user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state (Active or Synchronizing) to perform certain
        /// operations on the organization or its entities.
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
        /// The Directory Service doesn't recognize the credentials supplied by the Amazon WorkMail
        /// service.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryUnavailableException">
        /// The directory that you are trying to perform operations on isn't available.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the entity is valid, but it does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on an entity that isn't in the expected state, such
        /// as trying to update a deleted user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state (Active or Synchronizing) to perform certain
        /// operations on the organization or its entities.
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
        
        #region  ListAliases


        /// <summary>
        /// Creates a paginated call to list the aliases associated with a given entity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAliases service method.</param>
        /// 
        /// <returns>The response from the ListAliases service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the entity is valid, but it does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on an entity that isn't in the expected state, such
        /// as trying to update a deleted user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state (Active or Synchronizing) to perform certain
        /// operations on the organization or its entities.
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
        
        #region  ListGroupMembers


        /// <summary>
        /// Returns an overview of the members of a group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupMembers service method.</param>
        /// 
        /// <returns>The response from the ListGroupMembers service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the entity is valid, but it does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on an entity that isn't in the expected state, such
        /// as trying to update a deleted user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state (Active or Synchronizing) to perform certain
        /// operations on the organization or its entities.
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
        /// The identifier supplied for the entity is valid, but it does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state (Active or Synchronizing) to perform certain
        /// operations on the organization or its entities.
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
        
        #region  ListMailboxPermissions


        /// <summary>
        /// Lists the mailbox permissions associated with a mailbox.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMailboxPermissions service method.</param>
        /// 
        /// <returns>The response from the ListMailboxPermissions service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the entity is valid, but it does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state (Active or Synchronizing) to perform certain
        /// operations on the organization or its entities.
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
        
        #region  ListOrganizations


        /// <summary>
        /// Returns summaries of the customer's non-deleted organizations.
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
        
        #region  ListResourceDelegates


        /// <summary>
        /// Lists the delegates associated with a resource. Users and groups can be resource delegates
        /// and answer requests on behalf of the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceDelegates service method.</param>
        /// 
        /// <returns>The response from the ListResourceDelegates service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the entity is valid, but it does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on an entity that isn't in the expected state, such
        /// as trying to update a deleted user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state (Active or Synchronizing) to perform certain
        /// operations on the organization or its entities.
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
        /// The organization must have a valid state (Active or Synchronizing) to perform certain
        /// operations on the organization or its entities.
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
        /// The organization must have a valid state (Active or Synchronizing) to perform certain
        /// operations on the organization or its entities.
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
        
        #region  PutMailboxPermissions


        /// <summary>
        /// Sets permissions for a user or group. This replaces any pre-existing permissions set
        /// for the entity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMailboxPermissions service method.</param>
        /// 
        /// <returns>The response from the PutMailboxPermissions service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the entity is valid, but it does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on an entity that isn't in the expected state, such
        /// as trying to update a deleted user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state (Active or Synchronizing) to perform certain
        /// operations on the organization or its entities.
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
        
        #region  RegisterToWorkMail


        /// <summary>
        /// Registers an existing and disabled user, group, or resource/entity for Amazon WorkMail
        /// use by associating a mailbox and calendaring capabilities. It performs no change if
        /// the entity is enabled and fails if the entity is deleted. This operation results in
        /// the accumulation of costs. For more information, see <a href="http://aws.amazon.com/workmail/pricing">Pricing</a>.
        /// The equivalent console functionality for this operation is <i>Enable</i>. Users can
        /// either be created by calling the CreateUser API or they can be synchronized from your
        /// directory. For more information, see DeregisterFromWorkMail.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterToWorkMail service method.</param>
        /// 
        /// <returns>The response from the RegisterToWorkMail service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryServiceAuthenticationFailedException">
        /// The Directory Service doesn't recognize the credentials supplied by the Amazon WorkMail
        /// service.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryUnavailableException">
        /// The directory that you are trying to perform operations on isn't available.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EmailAddressInUseException">
        /// The email address that you're trying to assign is already created for a different
        /// user, group, or resource.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityAlreadyRegisteredException">
        /// The user, group, or resource that you're trying to register is already registered.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the entity is valid, but it does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on an entity that isn't in the expected state, such
        /// as trying to update a deleted user.
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
        /// The organization must have a valid state (Active or Synchronizing) to perform certain
        /// operations on the organization or its entities.
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
        /// The Directory Service doesn't recognize the credentials supplied by the Amazon WorkMail
        /// service.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryUnavailableException">
        /// The directory that you are trying to perform operations on isn't available.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the entity is valid, but it does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on an entity that isn't in the expected state, such
        /// as trying to update a deleted user.
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
        /// The organization must have a valid state (Active or Synchronizing) to perform certain
        /// operations on the organization or its entities.
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
        
        #region  UpdatePrimaryEmailAddress


        /// <summary>
        /// Updates the primary email for an entity. The current email is moved into the list
        /// of aliases (or swapped between an existing alias and the current primary email) and
        /// the email provided in the input is promoted as the primary.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePrimaryEmailAddress service method.</param>
        /// 
        /// <returns>The response from the UpdatePrimaryEmailAddress service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryServiceAuthenticationFailedException">
        /// The Directory Service doesn't recognize the credentials supplied by the Amazon WorkMail
        /// service.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryUnavailableException">
        /// The directory that you are trying to perform operations on isn't available.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EmailAddressInUseException">
        /// The email address that you're trying to assign is already created for a different
        /// user, group, or resource.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the entity is valid, but it does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on an entity that isn't in the expected state, such
        /// as trying to update a deleted user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidParameterException">
        /// One or more of the input parameters don't match the service's restrictions.
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
        /// The organization must have a valid state (Active or Synchronizing) to perform certain
        /// operations on the organization or its entities.
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
        /// Updates data for the resource. It must be preceded by a describe call in order to
        /// have the latest information. The dataset in the request should be the one expected
        /// when performing another describe call.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResource service method.</param>
        /// 
        /// <returns>The response from the UpdateResource service method, as returned by WorkMail.</returns>
        /// <exception cref="Amazon.WorkMail.Model.DirectoryUnavailableException">
        /// The directory that you are trying to perform operations on isn't available.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EmailAddressInUseException">
        /// The email address that you're trying to assign is already created for a different
        /// user, group, or resource.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityNotFoundException">
        /// The identifier supplied for the entity is valid, but it does not exist in your organization.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.EntityStateException">
        /// You are performing an operation on an entity that isn't in the expected state, such
        /// as trying to update a deleted user.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.InvalidConfigurationException">
        /// The configuration for a resource isn't valid. A resource must either be able to auto-respond
        /// to requests or have at least one delegate associated that can do it on its behalf.
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
        /// The entity (user, group, or user) name isn't unique in Amazon WorkMail.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationNotFoundException">
        /// An operation received a valid organization identifier that either doesn't belong or
        /// exist in the system.
        /// </exception>
        /// <exception cref="Amazon.WorkMail.Model.OrganizationStateException">
        /// The organization must have a valid state (Active or Synchronizing) to perform certain
        /// operations on the organization or its entities.
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
        
    }
}