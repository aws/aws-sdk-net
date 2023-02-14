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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.IdentityManagement.Model;

namespace Amazon.IdentityManagement
{
    /// <summary>
    /// Interface for accessing IdentityManagementService
    ///
    /// Identity and Access Management 
    /// <para>
    /// Identity and Access Management (IAM) is a web service for securely controlling access
    /// to Amazon Web Services services. With IAM, you can centrally manage users, security
    /// credentials such as access keys, and permissions that control which Amazon Web Services
    /// resources users and applications can access. For more information about IAM, see <a
    /// href="http://aws.amazon.com/iam/">Identity and Access Management (IAM)</a> and the
    /// <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/">Identity and Access Management
    /// User Guide</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonIdentityManagementService : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IIdentityManagementPaginatorFactory Paginators { get; }
#endif


        
        #region  AddClientIDToOpenIDConnectProvider


        /// <summary>
        /// Adds a new client ID (also known as audience) to the list of client IDs already registered
        /// for the specified IAM OpenID Connect (OIDC) provider resource.
        /// 
        ///  
        /// <para>
        /// This operation is idempotent; it does not fail or return an error if you add an existing
        /// client ID to the provider.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddClientIDToOpenIDConnectProvider service method.</param>
        /// 
        /// <returns>The response from the AddClientIDToOpenIDConnectProvider service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/AddClientIDToOpenIDConnectProvider">REST API Reference for AddClientIDToOpenIDConnectProvider Operation</seealso>
        AddClientIDToOpenIDConnectProviderResponse AddClientIDToOpenIDConnectProvider(AddClientIDToOpenIDConnectProviderRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AddClientIDToOpenIDConnectProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddClientIDToOpenIDConnectProvider operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddClientIDToOpenIDConnectProvider
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/AddClientIDToOpenIDConnectProvider">REST API Reference for AddClientIDToOpenIDConnectProvider Operation</seealso>
        IAsyncResult BeginAddClientIDToOpenIDConnectProvider(AddClientIDToOpenIDConnectProviderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AddClientIDToOpenIDConnectProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddClientIDToOpenIDConnectProvider.</param>
        /// 
        /// <returns>Returns a  AddClientIDToOpenIDConnectProviderResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/AddClientIDToOpenIDConnectProvider">REST API Reference for AddClientIDToOpenIDConnectProvider Operation</seealso>
        AddClientIDToOpenIDConnectProviderResponse EndAddClientIDToOpenIDConnectProvider(IAsyncResult asyncResult);

        #endregion
        
        #region  AddRoleToInstanceProfile


        /// <summary>
        /// Adds the specified IAM role to the specified instance profile. An instance profile
        /// can contain only one role, and this quota cannot be increased. You can remove the
        /// existing role and then add a different role to an instance profile. You must then
        /// wait for the change to appear across all of Amazon Web Services because of <a href="https://en.wikipedia.org/wiki/Eventual_consistency">eventual
        /// consistency</a>. To force the change, you must <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DisassociateIamInstanceProfile.html">disassociate
        /// the instance profile</a> and then <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_AssociateIamInstanceProfile.html">associate
        /// the instance profile</a>, or you can stop your instance and then restart it.
        /// 
        ///  <note> 
        /// <para>
        /// The caller of this operation must be granted the <code>PassRole</code> permission
        /// on the IAM role by a permissions policy.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information about roles, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html">Working
        /// with roles</a>. For more information about instance profiles, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/AboutInstanceProfiles.html">About
        /// instance profiles</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddRoleToInstanceProfile service method.</param>
        /// 
        /// <returns>The response from the AddRoleToInstanceProfile service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.UnmodifiableEntityException">
        /// The request was rejected because only the service that depends on the service-linked
        /// role can modify or delete the role on your behalf. The error message includes the
        /// name of the service that depends on this service-linked role. You must request the
        /// change through that service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/AddRoleToInstanceProfile">REST API Reference for AddRoleToInstanceProfile Operation</seealso>
        AddRoleToInstanceProfileResponse AddRoleToInstanceProfile(AddRoleToInstanceProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AddRoleToInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddRoleToInstanceProfile operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddRoleToInstanceProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/AddRoleToInstanceProfile">REST API Reference for AddRoleToInstanceProfile Operation</seealso>
        IAsyncResult BeginAddRoleToInstanceProfile(AddRoleToInstanceProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AddRoleToInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddRoleToInstanceProfile.</param>
        /// 
        /// <returns>Returns a  AddRoleToInstanceProfileResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/AddRoleToInstanceProfile">REST API Reference for AddRoleToInstanceProfile Operation</seealso>
        AddRoleToInstanceProfileResponse EndAddRoleToInstanceProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  AddUserToGroup


        /// <summary>
        /// Adds the specified user to the specified group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddUserToGroup service method.</param>
        /// 
        /// <returns>The response from the AddUserToGroup service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/AddUserToGroup">REST API Reference for AddUserToGroup Operation</seealso>
        AddUserToGroupResponse AddUserToGroup(AddUserToGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AddUserToGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddUserToGroup operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddUserToGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/AddUserToGroup">REST API Reference for AddUserToGroup Operation</seealso>
        IAsyncResult BeginAddUserToGroup(AddUserToGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AddUserToGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddUserToGroup.</param>
        /// 
        /// <returns>Returns a  AddUserToGroupResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/AddUserToGroup">REST API Reference for AddUserToGroup Operation</seealso>
        AddUserToGroupResponse EndAddUserToGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  AttachGroupPolicy


        /// <summary>
        /// Attaches the specified managed policy to the specified IAM group.
        /// 
        ///  
        /// <para>
        /// You use this operation to attach a managed policy to a group. To embed an inline policy
        /// in a group, use <a>PutGroupPolicy</a>.
        /// </para>
        ///  
        /// <para>
        /// As a best practice, you can validate your IAM policies. To learn more, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_policy-validator.html">Validating
        /// IAM policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// policies and inline policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachGroupPolicy service method.</param>
        /// 
        /// <returns>The response from the AttachGroupPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.PolicyNotAttachableException">
        /// The request failed because Amazon Web Services service role policies can only be attached
        /// to the service-linked role for that service.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/AttachGroupPolicy">REST API Reference for AttachGroupPolicy Operation</seealso>
        AttachGroupPolicyResponse AttachGroupPolicy(AttachGroupPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AttachGroupPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachGroupPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAttachGroupPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/AttachGroupPolicy">REST API Reference for AttachGroupPolicy Operation</seealso>
        IAsyncResult BeginAttachGroupPolicy(AttachGroupPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AttachGroupPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachGroupPolicy.</param>
        /// 
        /// <returns>Returns a  AttachGroupPolicyResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/AttachGroupPolicy">REST API Reference for AttachGroupPolicy Operation</seealso>
        AttachGroupPolicyResponse EndAttachGroupPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  AttachRolePolicy


        /// <summary>
        /// Attaches the specified managed policy to the specified IAM role. When you attach a
        /// managed policy to a role, the managed policy becomes part of the role's permission
        /// (access) policy.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot use a managed policy as the role's trust policy. The role's trust policy
        /// is created at the same time as the role, using <a>CreateRole</a>. You can update a
        /// role's trust policy using <a>UpdateAssumeRolePolicy</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Use this operation to attach a <i>managed</i> policy to a role. To embed an inline
        /// policy in a role, use <a>PutRolePolicy</a>. For more information about policies, see
        /// <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// policies and inline policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// As a best practice, you can validate your IAM policies. To learn more, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_policy-validator.html">Validating
        /// IAM policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachRolePolicy service method.</param>
        /// 
        /// <returns>The response from the AttachRolePolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.PolicyNotAttachableException">
        /// The request failed because Amazon Web Services service role policies can only be attached
        /// to the service-linked role for that service.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.UnmodifiableEntityException">
        /// The request was rejected because only the service that depends on the service-linked
        /// role can modify or delete the role on your behalf. The error message includes the
        /// name of the service that depends on this service-linked role. You must request the
        /// change through that service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/AttachRolePolicy">REST API Reference for AttachRolePolicy Operation</seealso>
        AttachRolePolicyResponse AttachRolePolicy(AttachRolePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AttachRolePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachRolePolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAttachRolePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/AttachRolePolicy">REST API Reference for AttachRolePolicy Operation</seealso>
        IAsyncResult BeginAttachRolePolicy(AttachRolePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AttachRolePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachRolePolicy.</param>
        /// 
        /// <returns>Returns a  AttachRolePolicyResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/AttachRolePolicy">REST API Reference for AttachRolePolicy Operation</seealso>
        AttachRolePolicyResponse EndAttachRolePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  AttachUserPolicy


        /// <summary>
        /// Attaches the specified managed policy to the specified user.
        /// 
        ///  
        /// <para>
        /// You use this operation to attach a <i>managed</i> policy to a user. To embed an inline
        /// policy in a user, use <a>PutUserPolicy</a>.
        /// </para>
        ///  
        /// <para>
        /// As a best practice, you can validate your IAM policies. To learn more, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_policy-validator.html">Validating
        /// IAM policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// policies and inline policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachUserPolicy service method.</param>
        /// 
        /// <returns>The response from the AttachUserPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.PolicyNotAttachableException">
        /// The request failed because Amazon Web Services service role policies can only be attached
        /// to the service-linked role for that service.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/AttachUserPolicy">REST API Reference for AttachUserPolicy Operation</seealso>
        AttachUserPolicyResponse AttachUserPolicy(AttachUserPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AttachUserPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachUserPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAttachUserPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/AttachUserPolicy">REST API Reference for AttachUserPolicy Operation</seealso>
        IAsyncResult BeginAttachUserPolicy(AttachUserPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AttachUserPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachUserPolicy.</param>
        /// 
        /// <returns>Returns a  AttachUserPolicyResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/AttachUserPolicy">REST API Reference for AttachUserPolicy Operation</seealso>
        AttachUserPolicyResponse EndAttachUserPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  ChangePassword


        /// <summary>
        /// Changes the password of the IAM user who is calling this operation. This operation
        /// can be performed using the CLI, the Amazon Web Services API, or the <b>My Security
        /// Credentials</b> page in the Amazon Web Services Management Console. The Amazon Web
        /// Services account root user password is not affected by this operation.
        /// 
        ///  
        /// <para>
        /// Use <a>UpdateLoginProfile</a> to use the CLI, the Amazon Web Services API, or the
        /// <b>Users</b> page in the IAM console to change the password for any IAM user. For
        /// more information about modifying passwords, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingLogins.html">Managing
        /// passwords</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ChangePassword service method.</param>
        /// 
        /// <returns>The response from the ChangePassword service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityTemporarilyUnmodifiableException">
        /// The request was rejected because it referenced an entity that is temporarily unmodifiable,
        /// such as a user name that was deleted and then recreated. The error indicates that
        /// the request is likely to succeed if you try again after waiting several minutes. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidUserTypeException">
        /// The request was rejected because the type of user for the transaction was incorrect.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.PasswordPolicyViolationException">
        /// The request was rejected because the provided password did not meet the requirements
        /// imposed by the account password policy.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ChangePassword">REST API Reference for ChangePassword Operation</seealso>
        ChangePasswordResponse ChangePassword(ChangePasswordRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ChangePassword operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ChangePassword operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndChangePassword
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ChangePassword">REST API Reference for ChangePassword Operation</seealso>
        IAsyncResult BeginChangePassword(ChangePasswordRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ChangePassword operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginChangePassword.</param>
        /// 
        /// <returns>Returns a  ChangePasswordResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ChangePassword">REST API Reference for ChangePassword Operation</seealso>
        ChangePasswordResponse EndChangePassword(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateAccessKey


        /// <summary>
        /// Creates a new Amazon Web Services secret access key and corresponding Amazon Web
        /// Services access key ID for the specified user. The default status for new keys is
        /// <code>Active</code>.
        /// 
        ///  
        /// <para>
        /// If you do not specify a user name, IAM determines the user name implicitly based on
        /// the Amazon Web Services access key ID signing the request. This operation works for
        /// access keys under the Amazon Web Services account. Consequently, you can use this
        /// operation to manage Amazon Web Services account root user credentials. This is true
        /// even if the Amazon Web Services account has no associated users.
        /// </para>
        ///  
        /// <para>
        ///  For information about quotas on the number of keys you can create, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_iam-quotas.html">IAM
        /// and STS quotas</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        /// To ensure the security of your Amazon Web Services account, the secret access key
        /// is accessible only during key and user creation. You must save the key (for example,
        /// in a text file) if you want to be able to access it again. If a secret key is lost,
        /// you can delete the access keys for the associated user and then create new keys.
        /// </para>
        ///  </important>
        /// </summary>
        /// 
        /// <returns>The response from the CreateAccessKey service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateAccessKey">REST API Reference for CreateAccessKey Operation</seealso>
        CreateAccessKeyResponse CreateAccessKey();

        /// <summary>
        /// Creates a new Amazon Web Services secret access key and corresponding Amazon Web
        /// Services access key ID for the specified user. The default status for new keys is
        /// <code>Active</code>.
        /// 
        ///  
        /// <para>
        /// If you do not specify a user name, IAM determines the user name implicitly based on
        /// the Amazon Web Services access key ID signing the request. This operation works for
        /// access keys under the Amazon Web Services account. Consequently, you can use this
        /// operation to manage Amazon Web Services account root user credentials. This is true
        /// even if the Amazon Web Services account has no associated users.
        /// </para>
        ///  
        /// <para>
        ///  For information about quotas on the number of keys you can create, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_iam-quotas.html">IAM
        /// and STS quotas</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        /// To ensure the security of your Amazon Web Services account, the secret access key
        /// is accessible only during key and user creation. You must save the key (for example,
        /// in a text file) if you want to be able to access it again. If a secret key is lost,
        /// you can delete the access keys for the associated user and then create new keys.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessKey service method.</param>
        /// 
        /// <returns>The response from the CreateAccessKey service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateAccessKey">REST API Reference for CreateAccessKey Operation</seealso>
        CreateAccessKeyResponse CreateAccessKey(CreateAccessKeyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAccessKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessKey operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAccessKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateAccessKey">REST API Reference for CreateAccessKey Operation</seealso>
        IAsyncResult BeginCreateAccessKey(CreateAccessKeyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAccessKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAccessKey.</param>
        /// 
        /// <returns>Returns a  CreateAccessKeyResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateAccessKey">REST API Reference for CreateAccessKey Operation</seealso>
        CreateAccessKeyResponse EndCreateAccessKey(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateAccountAlias


        /// <summary>
        /// Creates an alias for your Amazon Web Services account. For information about using
        /// an Amazon Web Services account alias, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/AccountAlias.html">Using
        /// an alias for your Amazon Web Services account ID</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccountAlias service method.</param>
        /// 
        /// <returns>The response from the CreateAccountAlias service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateAccountAlias">REST API Reference for CreateAccountAlias Operation</seealso>
        CreateAccountAliasResponse CreateAccountAlias(CreateAccountAliasRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAccountAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAccountAlias operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAccountAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateAccountAlias">REST API Reference for CreateAccountAlias Operation</seealso>
        IAsyncResult BeginCreateAccountAlias(CreateAccountAliasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAccountAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAccountAlias.</param>
        /// 
        /// <returns>Returns a  CreateAccountAliasResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateAccountAlias">REST API Reference for CreateAccountAlias Operation</seealso>
        CreateAccountAliasResponse EndCreateAccountAlias(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateGroup


        /// <summary>
        /// Creates a new group.
        /// 
        ///  
        /// <para>
        ///  For information about the number of groups you can create, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_iam-quotas.html">IAM
        /// and STS quotas</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup service method.</param>
        /// 
        /// <returns>The response from the CreateGroup service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        CreateGroupResponse CreateGroup(CreateGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        IAsyncResult BeginCreateGroup(CreateGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGroup.</param>
        /// 
        /// <returns>Returns a  CreateGroupResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        CreateGroupResponse EndCreateGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateInstanceProfile


        /// <summary>
        /// Creates a new instance profile. For information about instance profiles, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use_switch-role-ec2.html">Using
        /// roles for applications on Amazon EC2</a> in the <i>IAM User Guide</i>, and <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/iam-roles-for-amazon-ec2.html#ec2-instance-profile">Instance
        /// profiles</a> in the <i>Amazon EC2 User Guide</i>.
        /// 
        ///  
        /// <para>
        ///  For information about the number of instance profiles you can create, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_iam-quotas.html">IAM
        /// object quotas</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInstanceProfile service method.</param>
        /// 
        /// <returns>The response from the CreateInstanceProfile service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ConcurrentModificationException">
        /// The request was rejected because multiple requests to change this object were submitted
        /// simultaneously. Wait a few minutes and submit your request again.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateInstanceProfile">REST API Reference for CreateInstanceProfile Operation</seealso>
        CreateInstanceProfileResponse CreateInstanceProfile(CreateInstanceProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInstanceProfile operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateInstanceProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateInstanceProfile">REST API Reference for CreateInstanceProfile Operation</seealso>
        IAsyncResult BeginCreateInstanceProfile(CreateInstanceProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInstanceProfile.</param>
        /// 
        /// <returns>Returns a  CreateInstanceProfileResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateInstanceProfile">REST API Reference for CreateInstanceProfile Operation</seealso>
        CreateInstanceProfileResponse EndCreateInstanceProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateLoginProfile


        /// <summary>
        /// Creates a password for the specified IAM user. A password allows an IAM user to access
        /// Amazon Web Services services through the Amazon Web Services Management Console.
        /// 
        ///  
        /// <para>
        /// You can use the CLI, the Amazon Web Services API, or the <b>Users</b> page in the
        /// IAM console to create a password for any IAM user. Use <a>ChangePassword</a> to update
        /// your own existing password in the <b>My Security Credentials</b> page in the Amazon
        /// Web Services Management Console.
        /// </para>
        ///  
        /// <para>
        /// For more information about managing passwords, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingLogins.html">Managing
        /// passwords</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLoginProfile service method.</param>
        /// 
        /// <returns>The response from the CreateLoginProfile service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.PasswordPolicyViolationException">
        /// The request was rejected because the provided password did not meet the requirements
        /// imposed by the account password policy.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateLoginProfile">REST API Reference for CreateLoginProfile Operation</seealso>
        CreateLoginProfileResponse CreateLoginProfile(CreateLoginProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLoginProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLoginProfile operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLoginProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateLoginProfile">REST API Reference for CreateLoginProfile Operation</seealso>
        IAsyncResult BeginCreateLoginProfile(CreateLoginProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLoginProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLoginProfile.</param>
        /// 
        /// <returns>Returns a  CreateLoginProfileResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateLoginProfile">REST API Reference for CreateLoginProfile Operation</seealso>
        CreateLoginProfileResponse EndCreateLoginProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateOpenIDConnectProvider


        /// <summary>
        /// Creates an IAM entity to describe an identity provider (IdP) that supports <a href="http://openid.net/connect/">OpenID
        /// Connect (OIDC)</a>.
        /// 
        ///  
        /// <para>
        /// The OIDC provider that you create with this operation can be used as a principal in
        /// a role's trust policy. Such a policy establishes a trust relationship between Amazon
        /// Web Services and the OIDC provider.
        /// </para>
        ///  
        /// <para>
        /// If you are using an OIDC identity provider from Google, Facebook, or Amazon Cognito,
        /// you don't need to create a separate IAM identity provider. These OIDC identity providers
        /// are already built-in to Amazon Web Services and are available for your use. Instead,
        /// you can move directly to creating new roles using your identity provider. To learn
        /// more, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_create_for-idp_oidc.html">Creating
        /// a role for web identity or OpenID connect federation</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When you create the IAM OIDC provider, you specify the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The URL of the OIDC identity provider (IdP) to trust
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A list of client IDs (also known as audiences) that identify the application or applications
        /// allowed to authenticate using the OIDC provider
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A list of thumbprints of one or more server certificates that the IdP uses
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You get all of this information from the OIDC IdP you want to use to access Amazon
        /// Web Services.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Web Services secures communication with some OIDC identity providers (IdPs)
        /// through our library of trusted certificate authorities (CAs) instead of using a certificate
        /// thumbprint to verify your IdP server certificate. These OIDC IdPs include Google,
        /// Auth0, and those that use an Amazon S3 bucket to host a JSON Web Key Set (JWKS) endpoint.
        /// In these cases, your legacy thumbprint remains in your configuration, but is no longer
        /// used for validation.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// The trust for the OIDC provider is derived from the IAM provider that this operation
        /// creates. Therefore, it is best to limit access to the <a>CreateOpenIDConnectProvider</a>
        /// operation to highly privileged users.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOpenIDConnectProvider service method.</param>
        /// 
        /// <returns>The response from the CreateOpenIDConnectProvider service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ConcurrentModificationException">
        /// The request was rejected because multiple requests to change this object were submitted
        /// simultaneously. Wait a few minutes and submit your request again.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateOpenIDConnectProvider">REST API Reference for CreateOpenIDConnectProvider Operation</seealso>
        CreateOpenIDConnectProviderResponse CreateOpenIDConnectProvider(CreateOpenIDConnectProviderRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateOpenIDConnectProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateOpenIDConnectProvider operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateOpenIDConnectProvider
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateOpenIDConnectProvider">REST API Reference for CreateOpenIDConnectProvider Operation</seealso>
        IAsyncResult BeginCreateOpenIDConnectProvider(CreateOpenIDConnectProviderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateOpenIDConnectProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateOpenIDConnectProvider.</param>
        /// 
        /// <returns>Returns a  CreateOpenIDConnectProviderResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateOpenIDConnectProvider">REST API Reference for CreateOpenIDConnectProvider Operation</seealso>
        CreateOpenIDConnectProviderResponse EndCreateOpenIDConnectProvider(IAsyncResult asyncResult);

        #endregion
        
        #region  CreatePolicy


        /// <summary>
        /// Creates a new managed policy for your Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// This operation creates a policy version with a version identifier of <code>v1</code>
        /// and sets v1 as the policy's default version. For more information about policy versions,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-versions.html">Versioning
        /// for managed policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// As a best practice, you can validate your IAM policies. To learn more, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_policy-validator.html">Validating
        /// IAM policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about managed policies in general, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// policies and inline policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePolicy service method.</param>
        /// 
        /// <returns>The response from the CreatePolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ConcurrentModificationException">
        /// The request was rejected because multiple requests to change this object were submitted
        /// simultaneously. Wait a few minutes and submit your request again.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message
        /// describes the specific error.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreatePolicy">REST API Reference for CreatePolicy Operation</seealso>
        CreatePolicyResponse CreatePolicy(CreatePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreatePolicy">REST API Reference for CreatePolicy Operation</seealso>
        IAsyncResult BeginCreatePolicy(CreatePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePolicy.</param>
        /// 
        /// <returns>Returns a  CreatePolicyResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreatePolicy">REST API Reference for CreatePolicy Operation</seealso>
        CreatePolicyResponse EndCreatePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  CreatePolicyVersion


        /// <summary>
        /// Creates a new version of the specified managed policy. To update a managed policy,
        /// you create a new policy version. A managed policy can have up to five versions. If
        /// the policy has five versions, you must delete an existing version using <a>DeletePolicyVersion</a>
        /// before you create a new version.
        /// 
        ///  
        /// <para>
        /// Optionally, you can set the new version as the policy's default version. The default
        /// version is the version that is in effect for the IAM users, groups, and roles to which
        /// the policy is attached.
        /// </para>
        ///  
        /// <para>
        /// For more information about managed policy versions, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-versions.html">Versioning
        /// for managed policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePolicyVersion service method.</param>
        /// 
        /// <returns>The response from the CreatePolicyVersion service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message
        /// describes the specific error.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreatePolicyVersion">REST API Reference for CreatePolicyVersion Operation</seealso>
        CreatePolicyVersionResponse CreatePolicyVersion(CreatePolicyVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePolicyVersion operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePolicyVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreatePolicyVersion">REST API Reference for CreatePolicyVersion Operation</seealso>
        IAsyncResult BeginCreatePolicyVersion(CreatePolicyVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePolicyVersion.</param>
        /// 
        /// <returns>Returns a  CreatePolicyVersionResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreatePolicyVersion">REST API Reference for CreatePolicyVersion Operation</seealso>
        CreatePolicyVersionResponse EndCreatePolicyVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateRole


        /// <summary>
        /// Creates a new role for your Amazon Web Services account. For more information about
        /// roles, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html">IAM
        /// roles</a>. For information about quotas for role names and the number of roles you
        /// can create, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_iam-quotas.html">IAM
        /// and STS quotas</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRole service method.</param>
        /// 
        /// <returns>The response from the CreateRole service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ConcurrentModificationException">
        /// The request was rejected because multiple requests to change this object were submitted
        /// simultaneously. Wait a few minutes and submit your request again.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message
        /// describes the specific error.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateRole">REST API Reference for CreateRole Operation</seealso>
        CreateRoleResponse CreateRole(CreateRoleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRole operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRole
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateRole">REST API Reference for CreateRole Operation</seealso>
        IAsyncResult BeginCreateRole(CreateRoleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRole operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRole.</param>
        /// 
        /// <returns>Returns a  CreateRoleResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateRole">REST API Reference for CreateRole Operation</seealso>
        CreateRoleResponse EndCreateRole(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSAMLProvider


        /// <summary>
        /// Creates an IAM resource that describes an identity provider (IdP) that supports SAML
        /// 2.0.
        /// 
        ///  
        /// <para>
        /// The SAML provider resource that you create with this operation can be used as a principal
        /// in an IAM role's trust policy. Such a policy can enable federated users who sign in
        /// using the SAML IdP to assume the role. You can create an IAM role that supports Web-based
        /// single sign-on (SSO) to the Amazon Web Services Management Console or one that supports
        /// API access to Amazon Web Services.
        /// </para>
        ///  
        /// <para>
        /// When you create the SAML provider resource, you upload a SAML metadata document that
        /// you get from your IdP. That document includes the issuer's name, expiration information,
        /// and keys that can be used to validate the SAML authentication response (assertions)
        /// that the IdP sends. You must generate the metadata document using the identity management
        /// software that is used as your organization's IdP.
        /// </para>
        ///  <note> 
        /// <para>
        ///  This operation requires <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version 4</a>.
        /// </para>
        ///  </note> 
        /// <para>
        ///  For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_providers_enable-console-saml.html">Enabling
        /// SAML 2.0 federated users to access the Amazon Web Services Management Console</a>
        /// and <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_providers_saml.html">About
        /// SAML 2.0-based federation</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSAMLProvider service method.</param>
        /// 
        /// <returns>The response from the CreateSAMLProvider service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ConcurrentModificationException">
        /// The request was rejected because multiple requests to change this object were submitted
        /// simultaneously. Wait a few minutes and submit your request again.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateSAMLProvider">REST API Reference for CreateSAMLProvider Operation</seealso>
        CreateSAMLProviderResponse CreateSAMLProvider(CreateSAMLProviderRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSAMLProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSAMLProvider operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSAMLProvider
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateSAMLProvider">REST API Reference for CreateSAMLProvider Operation</seealso>
        IAsyncResult BeginCreateSAMLProvider(CreateSAMLProviderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSAMLProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSAMLProvider.</param>
        /// 
        /// <returns>Returns a  CreateSAMLProviderResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateSAMLProvider">REST API Reference for CreateSAMLProvider Operation</seealso>
        CreateSAMLProviderResponse EndCreateSAMLProvider(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateServiceLinkedRole


        /// <summary>
        /// Creates an IAM role that is linked to a specific Amazon Web Services service. The
        /// service controls the attached policies and when the role can be deleted. This helps
        /// ensure that the service is not broken by an unexpectedly changed or deleted role,
        /// which could put your Amazon Web Services resources into an unknown state. Allowing
        /// the service to control the role helps improve service stability and proper cleanup
        /// when a service and its role are no longer needed. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/using-service-linked-roles.html">Using
        /// service-linked roles</a> in the <i>IAM User Guide</i>. 
        /// 
        ///  
        /// <para>
        /// To attach a policy to this service-linked role, you must make the request using the
        /// Amazon Web Services service that depends on this role.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceLinkedRole service method.</param>
        /// 
        /// <returns>The response from the CreateServiceLinkedRole service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateServiceLinkedRole">REST API Reference for CreateServiceLinkedRole Operation</seealso>
        CreateServiceLinkedRoleResponse CreateServiceLinkedRole(CreateServiceLinkedRoleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateServiceLinkedRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceLinkedRole operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateServiceLinkedRole
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateServiceLinkedRole">REST API Reference for CreateServiceLinkedRole Operation</seealso>
        IAsyncResult BeginCreateServiceLinkedRole(CreateServiceLinkedRoleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateServiceLinkedRole operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateServiceLinkedRole.</param>
        /// 
        /// <returns>Returns a  CreateServiceLinkedRoleResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateServiceLinkedRole">REST API Reference for CreateServiceLinkedRole Operation</seealso>
        CreateServiceLinkedRoleResponse EndCreateServiceLinkedRole(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateServiceSpecificCredential


        /// <summary>
        /// Generates a set of credentials consisting of a user name and password that can be
        /// used to access the service specified in the request. These credentials are generated
        /// by IAM, and can be used only for the specified service. 
        /// 
        ///  
        /// <para>
        /// You can have a maximum of two sets of service-specific credentials for each supported
        /// service per user.
        /// </para>
        ///  
        /// <para>
        /// You can create service-specific credentials for CodeCommit and Amazon Keyspaces (for
        /// Apache Cassandra).
        /// </para>
        ///  
        /// <para>
        /// You can reset the password to a new service-generated value by calling <a>ResetServiceSpecificCredential</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information about service-specific credentials, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_ssh-keys.html">Using
        /// IAM with CodeCommit: Git credentials, SSH keys, and Amazon Web Services access keys</a>
        /// in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceSpecificCredential service method.</param>
        /// 
        /// <returns>The response from the CreateServiceSpecificCredential service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceNotSupportedException">
        /// The specified service does not support service-specific credentials.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateServiceSpecificCredential">REST API Reference for CreateServiceSpecificCredential Operation</seealso>
        CreateServiceSpecificCredentialResponse CreateServiceSpecificCredential(CreateServiceSpecificCredentialRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateServiceSpecificCredential operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceSpecificCredential operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateServiceSpecificCredential
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateServiceSpecificCredential">REST API Reference for CreateServiceSpecificCredential Operation</seealso>
        IAsyncResult BeginCreateServiceSpecificCredential(CreateServiceSpecificCredentialRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateServiceSpecificCredential operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateServiceSpecificCredential.</param>
        /// 
        /// <returns>Returns a  CreateServiceSpecificCredentialResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateServiceSpecificCredential">REST API Reference for CreateServiceSpecificCredential Operation</seealso>
        CreateServiceSpecificCredentialResponse EndCreateServiceSpecificCredential(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateUser


        /// <summary>
        /// Creates a new IAM user for your Amazon Web Services account.
        /// 
        ///  
        /// <para>
        ///  For information about quotas for the number of IAM users you can create, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_iam-quotas.html">IAM
        /// and STS quotas</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUser service method.</param>
        /// 
        /// <returns>The response from the CreateUser service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ConcurrentModificationException">
        /// The request was rejected because multiple requests to change this object were submitted
        /// simultaneously. Wait a few minutes and submit your request again.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateUser">REST API Reference for CreateUser Operation</seealso>
        CreateUserResponse CreateUser(CreateUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUser operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateUser">REST API Reference for CreateUser Operation</seealso>
        IAsyncResult BeginCreateUser(CreateUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUser.</param>
        /// 
        /// <returns>Returns a  CreateUserResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateUser">REST API Reference for CreateUser Operation</seealso>
        CreateUserResponse EndCreateUser(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateVirtualMFADevice


        /// <summary>
        /// Creates a new virtual MFA device for the Amazon Web Services account. After creating
        /// the virtual MFA, use <a>EnableMFADevice</a> to attach the MFA device to an IAM user.
        /// For more information about creating and working with virtual MFA devices, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_VirtualMFA.html">Using
        /// a virtual MFA device</a> in the <i>IAM User Guide</i>.
        /// 
        ///  
        /// <para>
        /// For information about the maximum number of MFA devices you can create, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_iam-quotas.html">IAM
        /// and STS quotas</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        /// The seed information contained in the QR code and the Base32 string should be treated
        /// like any other secret access information. In other words, protect the seed information
        /// as you would your Amazon Web Services access keys or your passwords. After you provision
        /// your virtual device, you should ensure that the information is destroyed following
        /// secure procedures.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVirtualMFADevice service method.</param>
        /// 
        /// <returns>The response from the CreateVirtualMFADevice service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ConcurrentModificationException">
        /// The request was rejected because multiple requests to change this object were submitted
        /// simultaneously. Wait a few minutes and submit your request again.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateVirtualMFADevice">REST API Reference for CreateVirtualMFADevice Operation</seealso>
        CreateVirtualMFADeviceResponse CreateVirtualMFADevice(CreateVirtualMFADeviceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVirtualMFADevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVirtualMFADevice operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVirtualMFADevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateVirtualMFADevice">REST API Reference for CreateVirtualMFADevice Operation</seealso>
        IAsyncResult BeginCreateVirtualMFADevice(CreateVirtualMFADeviceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVirtualMFADevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVirtualMFADevice.</param>
        /// 
        /// <returns>Returns a  CreateVirtualMFADeviceResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateVirtualMFADevice">REST API Reference for CreateVirtualMFADevice Operation</seealso>
        CreateVirtualMFADeviceResponse EndCreateVirtualMFADevice(IAsyncResult asyncResult);

        #endregion
        
        #region  DeactivateMFADevice


        /// <summary>
        /// Deactivates the specified MFA device and removes it from association with the user
        /// name for which it was originally enabled.
        /// 
        ///  
        /// <para>
        /// For more information about creating and working with virtual MFA devices, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_VirtualMFA.html">Enabling
        /// a virtual multi-factor authentication (MFA) device</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeactivateMFADevice service method.</param>
        /// 
        /// <returns>The response from the DeactivateMFADevice service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityTemporarilyUnmodifiableException">
        /// The request was rejected because it referenced an entity that is temporarily unmodifiable,
        /// such as a user name that was deleted and then recreated. The error indicates that
        /// the request is likely to succeed if you try again after waiting several minutes. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeactivateMFADevice">REST API Reference for DeactivateMFADevice Operation</seealso>
        DeactivateMFADeviceResponse DeactivateMFADevice(DeactivateMFADeviceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeactivateMFADevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeactivateMFADevice operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeactivateMFADevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeactivateMFADevice">REST API Reference for DeactivateMFADevice Operation</seealso>
        IAsyncResult BeginDeactivateMFADevice(DeactivateMFADeviceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeactivateMFADevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeactivateMFADevice.</param>
        /// 
        /// <returns>Returns a  DeactivateMFADeviceResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeactivateMFADevice">REST API Reference for DeactivateMFADevice Operation</seealso>
        DeactivateMFADeviceResponse EndDeactivateMFADevice(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAccessKey


        /// <summary>
        /// Deletes the access key pair associated with the specified IAM user.
        /// 
        ///  
        /// <para>
        /// If you do not specify a user name, IAM determines the user name implicitly based on
        /// the Amazon Web Services access key ID signing the request. This operation works for
        /// access keys under the Amazon Web Services account. Consequently, you can use this
        /// operation to manage Amazon Web Services account root user credentials even if the
        /// Amazon Web Services account has no associated users.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessKey service method.</param>
        /// 
        /// <returns>The response from the DeleteAccessKey service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteAccessKey">REST API Reference for DeleteAccessKey Operation</seealso>
        DeleteAccessKeyResponse DeleteAccessKey(DeleteAccessKeyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccessKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessKey operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAccessKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteAccessKey">REST API Reference for DeleteAccessKey Operation</seealso>
        IAsyncResult BeginDeleteAccessKey(DeleteAccessKeyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAccessKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAccessKey.</param>
        /// 
        /// <returns>Returns a  DeleteAccessKeyResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteAccessKey">REST API Reference for DeleteAccessKey Operation</seealso>
        DeleteAccessKeyResponse EndDeleteAccessKey(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAccountAlias


        /// <summary>
        /// Deletes the specified Amazon Web Services account alias. For information about using
        /// an Amazon Web Services account alias, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/AccountAlias.html">Using
        /// an alias for your Amazon Web Services account ID</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountAlias service method.</param>
        /// 
        /// <returns>The response from the DeleteAccountAlias service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteAccountAlias">REST API Reference for DeleteAccountAlias Operation</seealso>
        DeleteAccountAliasResponse DeleteAccountAlias(DeleteAccountAliasRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccountAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountAlias operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAccountAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteAccountAlias">REST API Reference for DeleteAccountAlias Operation</seealso>
        IAsyncResult BeginDeleteAccountAlias(DeleteAccountAliasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAccountAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAccountAlias.</param>
        /// 
        /// <returns>Returns a  DeleteAccountAliasResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteAccountAlias">REST API Reference for DeleteAccountAlias Operation</seealso>
        DeleteAccountAliasResponse EndDeleteAccountAlias(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAccountPasswordPolicy


        /// <summary>
        /// Deletes the password policy for the Amazon Web Services account. There are no parameters.
        /// </summary>
        /// 
        /// <returns>The response from the DeleteAccountPasswordPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteAccountPasswordPolicy">REST API Reference for DeleteAccountPasswordPolicy Operation</seealso>
        DeleteAccountPasswordPolicyResponse DeleteAccountPasswordPolicy();

        /// <summary>
        /// Deletes the password policy for the Amazon Web Services account. There are no parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountPasswordPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteAccountPasswordPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteAccountPasswordPolicy">REST API Reference for DeleteAccountPasswordPolicy Operation</seealso>
        DeleteAccountPasswordPolicyResponse DeleteAccountPasswordPolicy(DeleteAccountPasswordPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccountPasswordPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountPasswordPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAccountPasswordPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteAccountPasswordPolicy">REST API Reference for DeleteAccountPasswordPolicy Operation</seealso>
        IAsyncResult BeginDeleteAccountPasswordPolicy(DeleteAccountPasswordPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAccountPasswordPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAccountPasswordPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteAccountPasswordPolicyResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteAccountPasswordPolicy">REST API Reference for DeleteAccountPasswordPolicy Operation</seealso>
        DeleteAccountPasswordPolicyResponse EndDeleteAccountPasswordPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteGroup


        /// <summary>
        /// Deletes the specified IAM group. The group must not contain any users or have any
        /// attached policies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteGroup service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.DeleteConflictException">
        /// The request was rejected because it attempted to delete a resource that has attached
        /// subordinate entities. The error message describes these entities.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        DeleteGroupResponse DeleteGroup(DeleteGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        IAsyncResult BeginDeleteGroup(DeleteGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGroup.</param>
        /// 
        /// <returns>Returns a  DeleteGroupResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        DeleteGroupResponse EndDeleteGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteGroupPolicy


        /// <summary>
        /// Deletes the specified inline policy that is embedded in the specified IAM group.
        /// 
        ///  
        /// <para>
        /// A group can also have managed policies attached to it. To detach a managed policy
        /// from a group, use <a>DetachGroupPolicy</a>. For more information about policies, refer
        /// to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// policies and inline policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroupPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteGroupPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteGroupPolicy">REST API Reference for DeleteGroupPolicy Operation</seealso>
        DeleteGroupPolicyResponse DeleteGroupPolicy(DeleteGroupPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGroupPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroupPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGroupPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteGroupPolicy">REST API Reference for DeleteGroupPolicy Operation</seealso>
        IAsyncResult BeginDeleteGroupPolicy(DeleteGroupPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGroupPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGroupPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteGroupPolicyResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteGroupPolicy">REST API Reference for DeleteGroupPolicy Operation</seealso>
        DeleteGroupPolicyResponse EndDeleteGroupPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteInstanceProfile


        /// <summary>
        /// Deletes the specified instance profile. The instance profile must not have an associated
        /// role.
        /// 
        ///  <important> 
        /// <para>
        /// Make sure that you do not have any Amazon EC2 instances running with the instance
        /// profile you are about to delete. Deleting a role or instance profile that is associated
        /// with a running instance will break any applications running on the instance.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information about instance profiles, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/AboutInstanceProfiles.html">About
        /// instance profiles</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstanceProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteInstanceProfile service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.DeleteConflictException">
        /// The request was rejected because it attempted to delete a resource that has attached
        /// subordinate entities. The error message describes these entities.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteInstanceProfile">REST API Reference for DeleteInstanceProfile Operation</seealso>
        DeleteInstanceProfileResponse DeleteInstanceProfile(DeleteInstanceProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstanceProfile operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteInstanceProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteInstanceProfile">REST API Reference for DeleteInstanceProfile Operation</seealso>
        IAsyncResult BeginDeleteInstanceProfile(DeleteInstanceProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInstanceProfile.</param>
        /// 
        /// <returns>Returns a  DeleteInstanceProfileResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteInstanceProfile">REST API Reference for DeleteInstanceProfile Operation</seealso>
        DeleteInstanceProfileResponse EndDeleteInstanceProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteLoginProfile


        /// <summary>
        /// Deletes the password for the specified IAM user, For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_passwords_admin-change-user.html">Managing
        /// passwords for IAM users</a>.
        /// 
        ///  
        /// <para>
        /// You can use the CLI, the Amazon Web Services API, or the <b>Users</b> page in the
        /// IAM console to delete a password for any IAM user. You can use <a>ChangePassword</a>
        /// to update, but not delete, your own password in the <b>My Security Credentials</b>
        /// page in the Amazon Web Services Management Console.
        /// </para>
        ///  <important> 
        /// <para>
        /// Deleting a user's password does not prevent a user from accessing Amazon Web Services
        /// through the command line interface or the API. To prevent all user access, you must
        /// also either make any access keys inactive or delete them. For more information about
        /// making keys inactive or deleting them, see <a>UpdateAccessKey</a> and <a>DeleteAccessKey</a>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoginProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteLoginProfile service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityTemporarilyUnmodifiableException">
        /// The request was rejected because it referenced an entity that is temporarily unmodifiable,
        /// such as a user name that was deleted and then recreated. The error indicates that
        /// the request is likely to succeed if you try again after waiting several minutes. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteLoginProfile">REST API Reference for DeleteLoginProfile Operation</seealso>
        DeleteLoginProfileResponse DeleteLoginProfile(DeleteLoginProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLoginProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoginProfile operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLoginProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteLoginProfile">REST API Reference for DeleteLoginProfile Operation</seealso>
        IAsyncResult BeginDeleteLoginProfile(DeleteLoginProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLoginProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLoginProfile.</param>
        /// 
        /// <returns>Returns a  DeleteLoginProfileResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteLoginProfile">REST API Reference for DeleteLoginProfile Operation</seealso>
        DeleteLoginProfileResponse EndDeleteLoginProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteOpenIDConnectProvider


        /// <summary>
        /// Deletes an OpenID Connect identity provider (IdP) resource object in IAM.
        /// 
        ///  
        /// <para>
        /// Deleting an IAM OIDC provider resource does not update any roles that reference the
        /// provider as a principal in their trust policies. Any attempt to assume a role that
        /// references a deleted provider fails.
        /// </para>
        ///  
        /// <para>
        /// This operation is idempotent; it does not fail or return an error if you call the
        /// operation for a provider that does not exist.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOpenIDConnectProvider service method.</param>
        /// 
        /// <returns>The response from the DeleteOpenIDConnectProvider service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteOpenIDConnectProvider">REST API Reference for DeleteOpenIDConnectProvider Operation</seealso>
        DeleteOpenIDConnectProviderResponse DeleteOpenIDConnectProvider(DeleteOpenIDConnectProviderRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteOpenIDConnectProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteOpenIDConnectProvider operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteOpenIDConnectProvider
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteOpenIDConnectProvider">REST API Reference for DeleteOpenIDConnectProvider Operation</seealso>
        IAsyncResult BeginDeleteOpenIDConnectProvider(DeleteOpenIDConnectProviderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteOpenIDConnectProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteOpenIDConnectProvider.</param>
        /// 
        /// <returns>Returns a  DeleteOpenIDConnectProviderResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteOpenIDConnectProvider">REST API Reference for DeleteOpenIDConnectProvider Operation</seealso>
        DeleteOpenIDConnectProviderResponse EndDeleteOpenIDConnectProvider(IAsyncResult asyncResult);

        #endregion
        
        #region  DeletePolicy


        /// <summary>
        /// Deletes the specified managed policy.
        /// 
        ///  
        /// <para>
        /// Before you can delete a managed policy, you must first detach the policy from all
        /// users, groups, and roles that it is attached to. In addition, you must delete all
        /// the policy's versions. The following steps describe the process for deleting a managed
        /// policy:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Detach the policy from all users, groups, and roles that the policy is attached to,
        /// using <a>DetachUserPolicy</a>, <a>DetachGroupPolicy</a>, or <a>DetachRolePolicy</a>.
        /// To list all the users, groups, and roles that a policy is attached to, use <a>ListEntitiesForPolicy</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Delete all versions of the policy using <a>DeletePolicyVersion</a>. To list the policy's
        /// versions, use <a>ListPolicyVersions</a>. You cannot use <a>DeletePolicyVersion</a>
        /// to delete the version that is marked as the default version. You delete the policy's
        /// default version in the next step of the process.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Delete the policy (this automatically deletes the policy's default version) using
        /// this operation.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For information about managed policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// policies and inline policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicy service method.</param>
        /// 
        /// <returns>The response from the DeletePolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.DeleteConflictException">
        /// The request was rejected because it attempted to delete a resource that has attached
        /// subordinate entities. The error message describes these entities.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        DeletePolicyResponse DeletePolicy(DeletePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        IAsyncResult BeginDeletePolicy(DeletePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePolicy.</param>
        /// 
        /// <returns>Returns a  DeletePolicyResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        DeletePolicyResponse EndDeletePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  DeletePolicyVersion


        /// <summary>
        /// Deletes the specified version from the specified managed policy.
        /// 
        ///  
        /// <para>
        /// You cannot delete the default version from a policy using this operation. To delete
        /// the default version from a policy, use <a>DeletePolicy</a>. To find out which version
        /// of a policy is marked as the default version, use <a>ListPolicyVersions</a>.
        /// </para>
        ///  
        /// <para>
        /// For information about versions for managed policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-versions.html">Versioning
        /// for managed policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicyVersion service method.</param>
        /// 
        /// <returns>The response from the DeletePolicyVersion service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.DeleteConflictException">
        /// The request was rejected because it attempted to delete a resource that has attached
        /// subordinate entities. The error message describes these entities.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeletePolicyVersion">REST API Reference for DeletePolicyVersion Operation</seealso>
        DeletePolicyVersionResponse DeletePolicyVersion(DeletePolicyVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicyVersion operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePolicyVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeletePolicyVersion">REST API Reference for DeletePolicyVersion Operation</seealso>
        IAsyncResult BeginDeletePolicyVersion(DeletePolicyVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePolicyVersion.</param>
        /// 
        /// <returns>Returns a  DeletePolicyVersionResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeletePolicyVersion">REST API Reference for DeletePolicyVersion Operation</seealso>
        DeletePolicyVersionResponse EndDeletePolicyVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteRole


        /// <summary>
        /// Deletes the specified role. Unlike the Amazon Web Services Management Console, when
        /// you delete a role programmatically, you must delete the items attached to the role
        /// manually, or the deletion fails. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_manage_delete.html#roles-managingrole-deleting-cli">Deleting
        /// an IAM role</a>. Before attempting to delete a role, remove the following attached
        /// items: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Inline policies (<a>DeleteRolePolicy</a>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Attached managed policies (<a>DetachRolePolicy</a>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Instance profile (<a>RemoveRoleFromInstanceProfile</a>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Optional – Delete instance profile after detaching from role for resource clean up
        /// (<a>DeleteInstanceProfile</a>)
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// Make sure that you do not have any Amazon EC2 instances running with the role you
        /// are about to delete. Deleting a role or instance profile that is associated with a
        /// running instance will break any applications running on the instance.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRole service method.</param>
        /// 
        /// <returns>The response from the DeleteRole service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ConcurrentModificationException">
        /// The request was rejected because multiple requests to change this object were submitted
        /// simultaneously. Wait a few minutes and submit your request again.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.DeleteConflictException">
        /// The request was rejected because it attempted to delete a resource that has attached
        /// subordinate entities. The error message describes these entities.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.UnmodifiableEntityException">
        /// The request was rejected because only the service that depends on the service-linked
        /// role can modify or delete the role on your behalf. The error message includes the
        /// name of the service that depends on this service-linked role. You must request the
        /// change through that service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteRole">REST API Reference for DeleteRole Operation</seealso>
        DeleteRoleResponse DeleteRole(DeleteRoleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRole operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRole
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteRole">REST API Reference for DeleteRole Operation</seealso>
        IAsyncResult BeginDeleteRole(DeleteRoleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRole operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRole.</param>
        /// 
        /// <returns>Returns a  DeleteRoleResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteRole">REST API Reference for DeleteRole Operation</seealso>
        DeleteRoleResponse EndDeleteRole(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteRolePermissionsBoundary


        /// <summary>
        /// Deletes the permissions boundary for the specified IAM role. 
        /// 
        ///  <important> 
        /// <para>
        /// Deleting the permissions boundary for a role might increase its permissions. For example,
        /// it might allow anyone who assumes the role to perform all the actions granted in its
        /// permissions policies. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRolePermissionsBoundary service method.</param>
        /// 
        /// <returns>The response from the DeleteRolePermissionsBoundary service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.UnmodifiableEntityException">
        /// The request was rejected because only the service that depends on the service-linked
        /// role can modify or delete the role on your behalf. The error message includes the
        /// name of the service that depends on this service-linked role. You must request the
        /// change through that service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteRolePermissionsBoundary">REST API Reference for DeleteRolePermissionsBoundary Operation</seealso>
        DeleteRolePermissionsBoundaryResponse DeleteRolePermissionsBoundary(DeleteRolePermissionsBoundaryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRolePermissionsBoundary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRolePermissionsBoundary operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRolePermissionsBoundary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteRolePermissionsBoundary">REST API Reference for DeleteRolePermissionsBoundary Operation</seealso>
        IAsyncResult BeginDeleteRolePermissionsBoundary(DeleteRolePermissionsBoundaryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRolePermissionsBoundary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRolePermissionsBoundary.</param>
        /// 
        /// <returns>Returns a  DeleteRolePermissionsBoundaryResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteRolePermissionsBoundary">REST API Reference for DeleteRolePermissionsBoundary Operation</seealso>
        DeleteRolePermissionsBoundaryResponse EndDeleteRolePermissionsBoundary(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteRolePolicy


        /// <summary>
        /// Deletes the specified inline policy that is embedded in the specified IAM role.
        /// 
        ///  
        /// <para>
        /// A role can also have managed policies attached to it. To detach a managed policy from
        /// a role, use <a>DetachRolePolicy</a>. For more information about policies, refer to
        /// <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// policies and inline policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRolePolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteRolePolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.UnmodifiableEntityException">
        /// The request was rejected because only the service that depends on the service-linked
        /// role can modify or delete the role on your behalf. The error message includes the
        /// name of the service that depends on this service-linked role. You must request the
        /// change through that service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteRolePolicy">REST API Reference for DeleteRolePolicy Operation</seealso>
        DeleteRolePolicyResponse DeleteRolePolicy(DeleteRolePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRolePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRolePolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRolePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteRolePolicy">REST API Reference for DeleteRolePolicy Operation</seealso>
        IAsyncResult BeginDeleteRolePolicy(DeleteRolePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRolePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRolePolicy.</param>
        /// 
        /// <returns>Returns a  DeleteRolePolicyResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteRolePolicy">REST API Reference for DeleteRolePolicy Operation</seealso>
        DeleteRolePolicyResponse EndDeleteRolePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSAMLProvider


        /// <summary>
        /// Deletes a SAML provider resource in IAM.
        /// 
        ///  
        /// <para>
        /// Deleting the provider resource from IAM does not update any roles that reference the
        /// SAML provider resource's ARN as a principal in their trust policies. Any attempt to
        /// assume a role that references a non-existent provider resource ARN fails.
        /// </para>
        ///  <note> 
        /// <para>
        ///  This operation requires <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version 4</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSAMLProvider service method.</param>
        /// 
        /// <returns>The response from the DeleteSAMLProvider service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteSAMLProvider">REST API Reference for DeleteSAMLProvider Operation</seealso>
        DeleteSAMLProviderResponse DeleteSAMLProvider(DeleteSAMLProviderRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSAMLProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSAMLProvider operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSAMLProvider
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteSAMLProvider">REST API Reference for DeleteSAMLProvider Operation</seealso>
        IAsyncResult BeginDeleteSAMLProvider(DeleteSAMLProviderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSAMLProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSAMLProvider.</param>
        /// 
        /// <returns>Returns a  DeleteSAMLProviderResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteSAMLProvider">REST API Reference for DeleteSAMLProvider Operation</seealso>
        DeleteSAMLProviderResponse EndDeleteSAMLProvider(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteServerCertificate


        /// <summary>
        /// Deletes the specified server certificate.
        /// 
        ///  
        /// <para>
        /// For more information about working with server certificates, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_server-certs.html">Working
        /// with server certificates</a> in the <i>IAM User Guide</i>. This topic also includes
        /// a list of Amazon Web Services services that can use the server certificates that you
        /// manage with IAM.
        /// </para>
        ///  <important> 
        /// <para>
        ///  If you are using a server certificate with Elastic Load Balancing, deleting the certificate
        /// could have implications for your application. If Elastic Load Balancing doesn't detect
        /// the deletion of bound certificates, it may continue to use the certificates. This
        /// could cause Elastic Load Balancing to stop accepting traffic. We recommend that you
        /// remove the reference to the certificate from Elastic Load Balancing before using this
        /// command to delete the certificate. For more information, see <a href="https://docs.aws.amazon.com/ElasticLoadBalancing/latest/APIReference/API_DeleteLoadBalancerListeners.html">DeleteLoadBalancerListeners</a>
        /// in the <i>Elastic Load Balancing API Reference</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServerCertificate service method.</param>
        /// 
        /// <returns>The response from the DeleteServerCertificate service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.DeleteConflictException">
        /// The request was rejected because it attempted to delete a resource that has attached
        /// subordinate entities. The error message describes these entities.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteServerCertificate">REST API Reference for DeleteServerCertificate Operation</seealso>
        DeleteServerCertificateResponse DeleteServerCertificate(DeleteServerCertificateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteServerCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteServerCertificate operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteServerCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteServerCertificate">REST API Reference for DeleteServerCertificate Operation</seealso>
        IAsyncResult BeginDeleteServerCertificate(DeleteServerCertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteServerCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteServerCertificate.</param>
        /// 
        /// <returns>Returns a  DeleteServerCertificateResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteServerCertificate">REST API Reference for DeleteServerCertificate Operation</seealso>
        DeleteServerCertificateResponse EndDeleteServerCertificate(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteServiceLinkedRole


        /// <summary>
        /// Submits a service-linked role deletion request and returns a <code>DeletionTaskId</code>,
        /// which you can use to check the status of the deletion. Before you call this operation,
        /// confirm that the role has no active sessions and that any resources used by the role
        /// in the linked service are deleted. If you call this operation more than once for the
        /// same service-linked role and an earlier deletion task is not complete, then the <code>DeletionTaskId</code>
        /// of the earlier request is returned.
        /// 
        ///  
        /// <para>
        /// If you submit a deletion request for a service-linked role whose linked service is
        /// still accessing a resource, then the deletion task fails. If it fails, the <a>GetServiceLinkedRoleDeletionStatus</a>
        /// operation returns the reason for the failure, usually including the resources that
        /// must be deleted. To delete the service-linked role, you must first remove those resources
        /// from the linked service and then submit the deletion request again. Resources are
        /// specific to the service that is linked to the role. For more information about removing
        /// resources from a service, see the <a href="http://docs.aws.amazon.com/">Amazon Web
        /// Services documentation</a> for your service.
        /// </para>
        ///  
        /// <para>
        /// For more information about service-linked roles, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_terms-and-concepts.html#iam-term-service-linked-role">Roles
        /// terms and concepts: Amazon Web Services service-linked role</a> in the <i>IAM User
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceLinkedRole service method.</param>
        /// 
        /// <returns>The response from the DeleteServiceLinkedRole service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteServiceLinkedRole">REST API Reference for DeleteServiceLinkedRole Operation</seealso>
        DeleteServiceLinkedRoleResponse DeleteServiceLinkedRole(DeleteServiceLinkedRoleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteServiceLinkedRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceLinkedRole operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteServiceLinkedRole
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteServiceLinkedRole">REST API Reference for DeleteServiceLinkedRole Operation</seealso>
        IAsyncResult BeginDeleteServiceLinkedRole(DeleteServiceLinkedRoleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteServiceLinkedRole operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteServiceLinkedRole.</param>
        /// 
        /// <returns>Returns a  DeleteServiceLinkedRoleResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteServiceLinkedRole">REST API Reference for DeleteServiceLinkedRole Operation</seealso>
        DeleteServiceLinkedRoleResponse EndDeleteServiceLinkedRole(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteServiceSpecificCredential


        /// <summary>
        /// Deletes the specified service-specific credential.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceSpecificCredential service method.</param>
        /// 
        /// <returns>The response from the DeleteServiceSpecificCredential service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteServiceSpecificCredential">REST API Reference for DeleteServiceSpecificCredential Operation</seealso>
        DeleteServiceSpecificCredentialResponse DeleteServiceSpecificCredential(DeleteServiceSpecificCredentialRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteServiceSpecificCredential operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceSpecificCredential operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteServiceSpecificCredential
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteServiceSpecificCredential">REST API Reference for DeleteServiceSpecificCredential Operation</seealso>
        IAsyncResult BeginDeleteServiceSpecificCredential(DeleteServiceSpecificCredentialRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteServiceSpecificCredential operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteServiceSpecificCredential.</param>
        /// 
        /// <returns>Returns a  DeleteServiceSpecificCredentialResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteServiceSpecificCredential">REST API Reference for DeleteServiceSpecificCredential Operation</seealso>
        DeleteServiceSpecificCredentialResponse EndDeleteServiceSpecificCredential(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSigningCertificate


        /// <summary>
        /// Deletes a signing certificate associated with the specified IAM user.
        /// 
        ///  
        /// <para>
        /// If you do not specify a user name, IAM determines the user name implicitly based on
        /// the Amazon Web Services access key ID signing the request. This operation works for
        /// access keys under the Amazon Web Services account. Consequently, you can use this
        /// operation to manage Amazon Web Services account root user credentials even if the
        /// Amazon Web Services account has no associated IAM users.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSigningCertificate service method.</param>
        /// 
        /// <returns>The response from the DeleteSigningCertificate service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteSigningCertificate">REST API Reference for DeleteSigningCertificate Operation</seealso>
        DeleteSigningCertificateResponse DeleteSigningCertificate(DeleteSigningCertificateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSigningCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSigningCertificate operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSigningCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteSigningCertificate">REST API Reference for DeleteSigningCertificate Operation</seealso>
        IAsyncResult BeginDeleteSigningCertificate(DeleteSigningCertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSigningCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSigningCertificate.</param>
        /// 
        /// <returns>Returns a  DeleteSigningCertificateResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteSigningCertificate">REST API Reference for DeleteSigningCertificate Operation</seealso>
        DeleteSigningCertificateResponse EndDeleteSigningCertificate(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSSHPublicKey


        /// <summary>
        /// Deletes the specified SSH public key.
        /// 
        ///  
        /// <para>
        /// The SSH public key deleted by this operation is used only for authenticating the associated
        /// IAM user to an CodeCommit repository. For more information about using SSH keys to
        /// authenticate to an CodeCommit repository, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/setting-up-credentials-ssh.html">Set
        /// up CodeCommit for SSH connections</a> in the <i>CodeCommit User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSSHPublicKey service method.</param>
        /// 
        /// <returns>The response from the DeleteSSHPublicKey service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteSSHPublicKey">REST API Reference for DeleteSSHPublicKey Operation</seealso>
        DeleteSSHPublicKeyResponse DeleteSSHPublicKey(DeleteSSHPublicKeyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSSHPublicKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSSHPublicKey operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSSHPublicKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteSSHPublicKey">REST API Reference for DeleteSSHPublicKey Operation</seealso>
        IAsyncResult BeginDeleteSSHPublicKey(DeleteSSHPublicKeyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSSHPublicKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSSHPublicKey.</param>
        /// 
        /// <returns>Returns a  DeleteSSHPublicKeyResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteSSHPublicKey">REST API Reference for DeleteSSHPublicKey Operation</seealso>
        DeleteSSHPublicKeyResponse EndDeleteSSHPublicKey(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteUser


        /// <summary>
        /// Deletes the specified IAM user. Unlike the Amazon Web Services Management Console,
        /// when you delete a user programmatically, you must delete the items attached to the
        /// user manually, or the deletion fails. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_users_manage.html#id_users_deleting_cli">Deleting
        /// an IAM user</a>. Before attempting to delete a user, remove the following items:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Password (<a>DeleteLoginProfile</a>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Access keys (<a>DeleteAccessKey</a>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Signing certificate (<a>DeleteSigningCertificate</a>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSH public key (<a>DeleteSSHPublicKey</a>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Git credentials (<a>DeleteServiceSpecificCredential</a>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Multi-factor authentication (MFA) device (<a>DeactivateMFADevice</a>, <a>DeleteVirtualMFADevice</a>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Inline policies (<a>DeleteUserPolicy</a>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Attached managed policies (<a>DetachUserPolicy</a>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Group memberships (<a>RemoveUserFromGroup</a>)
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser service method.</param>
        /// 
        /// <returns>The response from the DeleteUser service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ConcurrentModificationException">
        /// The request was rejected because multiple requests to change this object were submitted
        /// simultaneously. Wait a few minutes and submit your request again.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.DeleteConflictException">
        /// The request was rejected because it attempted to delete a resource that has attached
        /// subordinate entities. The error message describes these entities.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        DeleteUserResponse DeleteUser(DeleteUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        IAsyncResult BeginDeleteUser(DeleteUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUser.</param>
        /// 
        /// <returns>Returns a  DeleteUserResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        DeleteUserResponse EndDeleteUser(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteUserPermissionsBoundary


        /// <summary>
        /// Deletes the permissions boundary for the specified IAM user.
        /// 
        ///  <important> 
        /// <para>
        /// Deleting the permissions boundary for a user might increase its permissions by allowing
        /// the user to perform all the actions granted in its permissions policies. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserPermissionsBoundary service method.</param>
        /// 
        /// <returns>The response from the DeleteUserPermissionsBoundary service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteUserPermissionsBoundary">REST API Reference for DeleteUserPermissionsBoundary Operation</seealso>
        DeleteUserPermissionsBoundaryResponse DeleteUserPermissionsBoundary(DeleteUserPermissionsBoundaryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserPermissionsBoundary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserPermissionsBoundary operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUserPermissionsBoundary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteUserPermissionsBoundary">REST API Reference for DeleteUserPermissionsBoundary Operation</seealso>
        IAsyncResult BeginDeleteUserPermissionsBoundary(DeleteUserPermissionsBoundaryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUserPermissionsBoundary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUserPermissionsBoundary.</param>
        /// 
        /// <returns>Returns a  DeleteUserPermissionsBoundaryResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteUserPermissionsBoundary">REST API Reference for DeleteUserPermissionsBoundary Operation</seealso>
        DeleteUserPermissionsBoundaryResponse EndDeleteUserPermissionsBoundary(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteUserPolicy


        /// <summary>
        /// Deletes the specified inline policy that is embedded in the specified IAM user.
        /// 
        ///  
        /// <para>
        /// A user can also have managed policies attached to it. To detach a managed policy from
        /// a user, use <a>DetachUserPolicy</a>. For more information about policies, refer to
        /// <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// policies and inline policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteUserPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteUserPolicy">REST API Reference for DeleteUserPolicy Operation</seealso>
        DeleteUserPolicyResponse DeleteUserPolicy(DeleteUserPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteUserPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteUserPolicy">REST API Reference for DeleteUserPolicy Operation</seealso>
        IAsyncResult BeginDeleteUserPolicy(DeleteUserPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteUserPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteUserPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteUserPolicyResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteUserPolicy">REST API Reference for DeleteUserPolicy Operation</seealso>
        DeleteUserPolicyResponse EndDeleteUserPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteVirtualMFADevice


        /// <summary>
        /// Deletes a virtual MFA device.
        /// 
        ///  <note> 
        /// <para>
        ///  You must deactivate a user's virtual MFA device before you can delete it. For information
        /// about deactivating MFA devices, see <a>DeactivateMFADevice</a>. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVirtualMFADevice service method.</param>
        /// 
        /// <returns>The response from the DeleteVirtualMFADevice service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.DeleteConflictException">
        /// The request was rejected because it attempted to delete a resource that has attached
        /// subordinate entities. The error message describes these entities.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteVirtualMFADevice">REST API Reference for DeleteVirtualMFADevice Operation</seealso>
        DeleteVirtualMFADeviceResponse DeleteVirtualMFADevice(DeleteVirtualMFADeviceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVirtualMFADevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVirtualMFADevice operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVirtualMFADevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteVirtualMFADevice">REST API Reference for DeleteVirtualMFADevice Operation</seealso>
        IAsyncResult BeginDeleteVirtualMFADevice(DeleteVirtualMFADeviceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVirtualMFADevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVirtualMFADevice.</param>
        /// 
        /// <returns>Returns a  DeleteVirtualMFADeviceResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteVirtualMFADevice">REST API Reference for DeleteVirtualMFADevice Operation</seealso>
        DeleteVirtualMFADeviceResponse EndDeleteVirtualMFADevice(IAsyncResult asyncResult);

        #endregion
        
        #region  DetachGroupPolicy


        /// <summary>
        /// Removes the specified managed policy from the specified IAM group.
        /// 
        ///  
        /// <para>
        /// A group can also have inline policies embedded with it. To delete an inline policy,
        /// use <a>DeleteGroupPolicy</a>. For information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// policies and inline policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachGroupPolicy service method.</param>
        /// 
        /// <returns>The response from the DetachGroupPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DetachGroupPolicy">REST API Reference for DetachGroupPolicy Operation</seealso>
        DetachGroupPolicyResponse DetachGroupPolicy(DetachGroupPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DetachGroupPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachGroupPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetachGroupPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DetachGroupPolicy">REST API Reference for DetachGroupPolicy Operation</seealso>
        IAsyncResult BeginDetachGroupPolicy(DetachGroupPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DetachGroupPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachGroupPolicy.</param>
        /// 
        /// <returns>Returns a  DetachGroupPolicyResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DetachGroupPolicy">REST API Reference for DetachGroupPolicy Operation</seealso>
        DetachGroupPolicyResponse EndDetachGroupPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  DetachRolePolicy


        /// <summary>
        /// Removes the specified managed policy from the specified role.
        /// 
        ///  
        /// <para>
        /// A role can also have inline policies embedded with it. To delete an inline policy,
        /// use <a>DeleteRolePolicy</a>. For information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// policies and inline policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachRolePolicy service method.</param>
        /// 
        /// <returns>The response from the DetachRolePolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.UnmodifiableEntityException">
        /// The request was rejected because only the service that depends on the service-linked
        /// role can modify or delete the role on your behalf. The error message includes the
        /// name of the service that depends on this service-linked role. You must request the
        /// change through that service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DetachRolePolicy">REST API Reference for DetachRolePolicy Operation</seealso>
        DetachRolePolicyResponse DetachRolePolicy(DetachRolePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DetachRolePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachRolePolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetachRolePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DetachRolePolicy">REST API Reference for DetachRolePolicy Operation</seealso>
        IAsyncResult BeginDetachRolePolicy(DetachRolePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DetachRolePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachRolePolicy.</param>
        /// 
        /// <returns>Returns a  DetachRolePolicyResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DetachRolePolicy">REST API Reference for DetachRolePolicy Operation</seealso>
        DetachRolePolicyResponse EndDetachRolePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  DetachUserPolicy


        /// <summary>
        /// Removes the specified managed policy from the specified user.
        /// 
        ///  
        /// <para>
        /// A user can also have inline policies embedded with it. To delete an inline policy,
        /// use <a>DeleteUserPolicy</a>. For information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// policies and inline policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachUserPolicy service method.</param>
        /// 
        /// <returns>The response from the DetachUserPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DetachUserPolicy">REST API Reference for DetachUserPolicy Operation</seealso>
        DetachUserPolicyResponse DetachUserPolicy(DetachUserPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DetachUserPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachUserPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetachUserPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DetachUserPolicy">REST API Reference for DetachUserPolicy Operation</seealso>
        IAsyncResult BeginDetachUserPolicy(DetachUserPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DetachUserPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachUserPolicy.</param>
        /// 
        /// <returns>Returns a  DetachUserPolicyResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DetachUserPolicy">REST API Reference for DetachUserPolicy Operation</seealso>
        DetachUserPolicyResponse EndDetachUserPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  EnableMFADevice


        /// <summary>
        /// Enables the specified MFA device and associates it with the specified IAM user. When
        /// enabled, the MFA device is required for every subsequent login by the IAM user associated
        /// with the device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableMFADevice service method.</param>
        /// 
        /// <returns>The response from the EnableMFADevice service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityTemporarilyUnmodifiableException">
        /// The request was rejected because it referenced an entity that is temporarily unmodifiable,
        /// such as a user name that was deleted and then recreated. The error indicates that
        /// the request is likely to succeed if you try again after waiting several minutes. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidAuthenticationCodeException">
        /// The request was rejected because the authentication code was not recognized. The error
        /// message describes the specific error.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/EnableMFADevice">REST API Reference for EnableMFADevice Operation</seealso>
        EnableMFADeviceResponse EnableMFADevice(EnableMFADeviceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EnableMFADevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableMFADevice operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableMFADevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/EnableMFADevice">REST API Reference for EnableMFADevice Operation</seealso>
        IAsyncResult BeginEnableMFADevice(EnableMFADeviceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EnableMFADevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableMFADevice.</param>
        /// 
        /// <returns>Returns a  EnableMFADeviceResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/EnableMFADevice">REST API Reference for EnableMFADevice Operation</seealso>
        EnableMFADeviceResponse EndEnableMFADevice(IAsyncResult asyncResult);

        #endregion
        
        #region  GenerateCredentialReport


        /// <summary>
        /// Generates a credential report for the Amazon Web Services account. For more information
        /// about the credential report, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/credential-reports.html">Getting
        /// credential reports</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// 
        /// <returns>The response from the GenerateCredentialReport service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GenerateCredentialReport">REST API Reference for GenerateCredentialReport Operation</seealso>
        GenerateCredentialReportResponse GenerateCredentialReport();

        /// <summary>
        /// Generates a credential report for the Amazon Web Services account. For more information
        /// about the credential report, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/credential-reports.html">Getting
        /// credential reports</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateCredentialReport service method.</param>
        /// 
        /// <returns>The response from the GenerateCredentialReport service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GenerateCredentialReport">REST API Reference for GenerateCredentialReport Operation</seealso>
        GenerateCredentialReportResponse GenerateCredentialReport(GenerateCredentialReportRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GenerateCredentialReport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GenerateCredentialReport operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGenerateCredentialReport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GenerateCredentialReport">REST API Reference for GenerateCredentialReport Operation</seealso>
        IAsyncResult BeginGenerateCredentialReport(GenerateCredentialReportRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GenerateCredentialReport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGenerateCredentialReport.</param>
        /// 
        /// <returns>Returns a  GenerateCredentialReportResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GenerateCredentialReport">REST API Reference for GenerateCredentialReport Operation</seealso>
        GenerateCredentialReportResponse EndGenerateCredentialReport(IAsyncResult asyncResult);

        #endregion
        
        #region  GenerateOrganizationsAccessReport


        /// <summary>
        /// Generates a report for service last accessed data for Organizations. You can generate
        /// a report for any entities (organization root, organizational unit, or account) or
        /// policies in your organization.
        /// 
        ///  
        /// <para>
        /// To call this operation, you must be signed in using your Organizations management
        /// account credentials. You can use your long-term IAM user or root user credentials,
        /// or temporary credentials from assuming an IAM role. SCPs must be enabled for your
        /// organization root. You must have the required IAM and Organizations permissions. For
        /// more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_access-advisor.html">Refining
        /// permissions using service last accessed data</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can generate a service last accessed data report for entities by specifying only
        /// the entity's path. This data includes a list of services that are allowed by any service
        /// control policies (SCPs) that apply to the entity.
        /// </para>
        ///  
        /// <para>
        /// You can generate a service last accessed data report for a policy by specifying an
        /// entity's path and an optional Organizations policy ID. This data includes a list of
        /// services that are allowed by the specified SCP.
        /// </para>
        ///  
        /// <para>
        /// For each service in both report types, the data includes the most recent account activity
        /// that the policy allows to account principals in the entity or the entity's children.
        /// For important information about the data, reporting period, permissions required,
        /// troubleshooting, and supported Regions see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_access-advisor.html">Reducing
        /// permissions using service last accessed data</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        /// The data includes all attempts to access Amazon Web Services, not just the successful
        /// ones. This includes all attempts that were made using the Amazon Web Services Management
        /// Console, the Amazon Web Services API through any of the SDKs, or any of the command
        /// line tools. An unexpected entry in the service last accessed data does not mean that
        /// an account has been compromised, because the request might have been denied. Refer
        /// to your CloudTrail logs as the authoritative source for information about all API
        /// calls and whether they were successful or denied access. For more information, see <a
        /// href="https://docs.aws.amazon.com/IAM/latest/UserGuide/cloudtrail-integration.html">Logging
        /// IAM events with CloudTrail</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </important> 
        /// <para>
        /// This operation returns a <code>JobId</code>. Use this parameter in the <code> <a>GetOrganizationsAccessReport</a>
        /// </code> operation to check the status of the report generation. To check the status
        /// of this request, use the <code>JobId</code> parameter in the <code> <a>GetOrganizationsAccessReport</a>
        /// </code> operation and test the <code>JobStatus</code> response parameter. When the
        /// job is complete, you can retrieve the report.
        /// </para>
        ///  
        /// <para>
        /// To generate a service last accessed data report for entities, specify an entity path
        /// without specifying the optional Organizations policy ID. The type of entity that you
        /// specify determines the data returned in the report.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Root</b> – When you specify the organizations root as the entity, the resulting
        /// report lists all of the services allowed by SCPs that are attached to your root. For
        /// each service, the report includes data for all accounts in your organization except
        /// the management account, because the management account is not limited by SCPs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>OU</b> – When you specify an organizational unit (OU) as the entity, the resulting
        /// report lists all of the services allowed by SCPs that are attached to the OU and its
        /// parents. For each service, the report includes data for all accounts in the OU or
        /// its children. This data excludes the management account, because the management account
        /// is not limited by SCPs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>management account</b> – When you specify the management account, the resulting
        /// report lists all Amazon Web Services services, because the management account is not
        /// limited by SCPs. For each service, the report includes data for only the management
        /// account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Account</b> – When you specify another account as the entity, the resulting report
        /// lists all of the services allowed by SCPs that are attached to the account and its
        /// parents. For each service, the report includes data for only the specified account.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To generate a service last accessed data report for policies, specify an entity path
        /// and the optional Organizations policy ID. The type of entity that you specify determines
        /// the data returned for each service.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Root</b> – When you specify the root entity and a policy ID, the resulting report
        /// lists all of the services that are allowed by the specified SCP. For each service,
        /// the report includes data for all accounts in your organization to which the SCP applies.
        /// This data excludes the management account, because the management account is not limited
        /// by SCPs. If the SCP is not attached to any entities in the organization, then the
        /// report will return a list of services with no data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>OU</b> – When you specify an OU entity and a policy ID, the resulting report lists
        /// all of the services that are allowed by the specified SCP. For each service, the report
        /// includes data for all accounts in the OU or its children to which the SCP applies.
        /// This means that other accounts outside the OU that are affected by the SCP might not
        /// be included in the data. This data excludes the management account, because the management
        /// account is not limited by SCPs. If the SCP is not attached to the OU or one of its
        /// children, the report will return a list of services with no data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>management account</b> – When you specify the management account, the resulting
        /// report lists all Amazon Web Services services, because the management account is not
        /// limited by SCPs. If you specify a policy ID in the CLI or API, the policy is ignored.
        /// For each service, the report includes data for only the management account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Account</b> – When you specify another account entity and a policy ID, the resulting
        /// report lists all of the services that are allowed by the specified SCP. For each service,
        /// the report includes data for only the specified account. This means that other accounts
        /// in the organization that are affected by the SCP might not be included in the data.
        /// If the SCP is not attached to the account, the report will return a list of services
        /// with no data.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// Service last accessed data does not use other policy types when determining whether
        /// a principal could access a service. These other policy types include identity-based
        /// policies, resource-based policies, access control lists, IAM permissions boundaries,
        /// and STS assume role policies. It only applies SCP logic. For more about the evaluation
        /// of policy types, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_evaluation-logic.html#policy-eval-basics">Evaluating
        /// policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information about service last accessed data, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_access-advisor.html">Reducing
        /// policy scope by viewing user activity</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateOrganizationsAccessReport service method.</param>
        /// 
        /// <returns>The response from the GenerateOrganizationsAccessReport service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ReportGenerationLimitExceededException">
        /// The request failed because the maximum number of concurrent requests for this account
        /// are already running.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GenerateOrganizationsAccessReport">REST API Reference for GenerateOrganizationsAccessReport Operation</seealso>
        GenerateOrganizationsAccessReportResponse GenerateOrganizationsAccessReport(GenerateOrganizationsAccessReportRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GenerateOrganizationsAccessReport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GenerateOrganizationsAccessReport operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGenerateOrganizationsAccessReport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GenerateOrganizationsAccessReport">REST API Reference for GenerateOrganizationsAccessReport Operation</seealso>
        IAsyncResult BeginGenerateOrganizationsAccessReport(GenerateOrganizationsAccessReportRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GenerateOrganizationsAccessReport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGenerateOrganizationsAccessReport.</param>
        /// 
        /// <returns>Returns a  GenerateOrganizationsAccessReportResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GenerateOrganizationsAccessReport">REST API Reference for GenerateOrganizationsAccessReport Operation</seealso>
        GenerateOrganizationsAccessReportResponse EndGenerateOrganizationsAccessReport(IAsyncResult asyncResult);

        #endregion
        
        #region  GenerateServiceLastAccessedDetails


        /// <summary>
        /// Generates a report that includes details about when an IAM resource (user, group,
        /// role, or policy) was last used in an attempt to access Amazon Web Services services.
        /// Recent activity usually appears within four hours. IAM reports activity for at least
        /// the last 400 days, or less if your Region began supporting this feature within the
        /// last year. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_access-advisor.html#access-advisor_tracking-period">Regions
        /// where data is tracked</a>.
        /// 
        ///  <important> 
        /// <para>
        /// The service last accessed data includes all attempts to access an Amazon Web Services
        /// API, not just the successful ones. This includes all attempts that were made using
        /// the Amazon Web Services Management Console, the Amazon Web Services API through any
        /// of the SDKs, or any of the command line tools. An unexpected entry in the service
        /// last accessed data does not mean that your account has been compromised, because the
        /// request might have been denied. Refer to your CloudTrail logs as the authoritative
        /// source for information about all API calls and whether they were successful or denied
        /// access. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/cloudtrail-integration.html">Logging
        /// IAM events with CloudTrail</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </important> 
        /// <para>
        /// The <code>GenerateServiceLastAccessedDetails</code> operation returns a <code>JobId</code>.
        /// Use this parameter in the following operations to retrieve the following details from
        /// your report: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetServiceLastAccessedDetails</a> – Use this operation for users, groups, roles,
        /// or policies to list every Amazon Web Services service that the resource could access
        /// using permissions policies. For each service, the response includes information about
        /// the most recent access attempt.
        /// </para>
        ///  
        /// <para>
        /// The <code>JobId</code> returned by <code>GenerateServiceLastAccessedDetail</code>
        /// must be used by the same role within a session, or by the same user when used to call
        /// <code>GetServiceLastAccessedDetail</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetServiceLastAccessedDetailsWithEntities</a> – Use this operation for groups
        /// and policies to list information about the associated entities (users or roles) that
        /// attempted to access a specific Amazon Web Services service. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To check the status of the <code>GenerateServiceLastAccessedDetails</code> request,
        /// use the <code>JobId</code> parameter in the same operations and test the <code>JobStatus</code>
        /// response parameter.
        /// </para>
        ///  
        /// <para>
        /// For additional information about the permissions policies that allow an identity (user,
        /// group, or role) to access specific services, use the <a>ListPoliciesGrantingServiceAccess</a>
        /// operation.
        /// </para>
        ///  <note> 
        /// <para>
        /// Service last accessed data does not use other policy types when determining whether
        /// a resource could access a service. These other policy types include resource-based
        /// policies, access control lists, Organizations policies, IAM permissions boundaries,
        /// and STS assume role policies. It only applies permissions policy logic. For more about
        /// the evaluation of policy types, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_evaluation-logic.html#policy-eval-basics">Evaluating
        /// policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information about service and action last accessed data, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_access-advisor.html">Reducing
        /// permissions using service last accessed data</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateServiceLastAccessedDetails service method.</param>
        /// 
        /// <returns>The response from the GenerateServiceLastAccessedDetails service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GenerateServiceLastAccessedDetails">REST API Reference for GenerateServiceLastAccessedDetails Operation</seealso>
        GenerateServiceLastAccessedDetailsResponse GenerateServiceLastAccessedDetails(GenerateServiceLastAccessedDetailsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GenerateServiceLastAccessedDetails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GenerateServiceLastAccessedDetails operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGenerateServiceLastAccessedDetails
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GenerateServiceLastAccessedDetails">REST API Reference for GenerateServiceLastAccessedDetails Operation</seealso>
        IAsyncResult BeginGenerateServiceLastAccessedDetails(GenerateServiceLastAccessedDetailsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GenerateServiceLastAccessedDetails operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGenerateServiceLastAccessedDetails.</param>
        /// 
        /// <returns>Returns a  GenerateServiceLastAccessedDetailsResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GenerateServiceLastAccessedDetails">REST API Reference for GenerateServiceLastAccessedDetails Operation</seealso>
        GenerateServiceLastAccessedDetailsResponse EndGenerateServiceLastAccessedDetails(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAccessKeyLastUsed


        /// <summary>
        /// Retrieves information about when the specified access key was last used. The information
        /// includes the date and time of last use, along with the Amazon Web Services service
        /// and Region that were specified in the last request made with that key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessKeyLastUsed service method.</param>
        /// 
        /// <returns>The response from the GetAccessKeyLastUsed service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetAccessKeyLastUsed">REST API Reference for GetAccessKeyLastUsed Operation</seealso>
        GetAccessKeyLastUsedResponse GetAccessKeyLastUsed(GetAccessKeyLastUsedRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccessKeyLastUsed operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccessKeyLastUsed operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccessKeyLastUsed
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetAccessKeyLastUsed">REST API Reference for GetAccessKeyLastUsed Operation</seealso>
        IAsyncResult BeginGetAccessKeyLastUsed(GetAccessKeyLastUsedRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccessKeyLastUsed operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccessKeyLastUsed.</param>
        /// 
        /// <returns>Returns a  GetAccessKeyLastUsedResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetAccessKeyLastUsed">REST API Reference for GetAccessKeyLastUsed Operation</seealso>
        GetAccessKeyLastUsedResponse EndGetAccessKeyLastUsed(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAccountAuthorizationDetails


        /// <summary>
        /// Retrieves information about all IAM users, groups, roles, and policies in your Amazon
        /// Web Services account, including their relationships to one another. Use this operation
        /// to obtain a snapshot of the configuration of IAM permissions (users, groups, roles,
        /// and policies) in your account.
        /// 
        ///  <note> 
        /// <para>
        /// Policies returned by this operation are URL-encoded compliant with <a href="https://tools.ietf.org/html/rfc3986">RFC
        /// 3986</a>. You can use a URL decoding method to convert the policy back to plain JSON
        /// text. For example, if you use Java, you can use the <code>decode</code> method of
        /// the <code>java.net.URLDecoder</code> utility class in the Java SDK. Other languages
        /// and SDKs provide similar functionality.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can optionally filter the results using the <code>Filter</code> parameter. You
        /// can paginate the results using the <code>MaxItems</code> and <code>Marker</code> parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountAuthorizationDetails service method.</param>
        /// 
        /// <returns>The response from the GetAccountAuthorizationDetails service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetAccountAuthorizationDetails">REST API Reference for GetAccountAuthorizationDetails Operation</seealso>
        GetAccountAuthorizationDetailsResponse GetAccountAuthorizationDetails(GetAccountAuthorizationDetailsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccountAuthorizationDetails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccountAuthorizationDetails operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccountAuthorizationDetails
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetAccountAuthorizationDetails">REST API Reference for GetAccountAuthorizationDetails Operation</seealso>
        IAsyncResult BeginGetAccountAuthorizationDetails(GetAccountAuthorizationDetailsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccountAuthorizationDetails operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccountAuthorizationDetails.</param>
        /// 
        /// <returns>Returns a  GetAccountAuthorizationDetailsResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetAccountAuthorizationDetails">REST API Reference for GetAccountAuthorizationDetails Operation</seealso>
        GetAccountAuthorizationDetailsResponse EndGetAccountAuthorizationDetails(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAccountPasswordPolicy


        /// <summary>
        /// Retrieves the password policy for the Amazon Web Services account. This tells you
        /// the complexity requirements and mandatory rotation periods for the IAM user passwords
        /// in your account. For more information about using a password policy, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingPasswordPolicies.html">Managing
        /// an IAM password policy</a>.
        /// </summary>
        /// 
        /// <returns>The response from the GetAccountPasswordPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetAccountPasswordPolicy">REST API Reference for GetAccountPasswordPolicy Operation</seealso>
        GetAccountPasswordPolicyResponse GetAccountPasswordPolicy();

        /// <summary>
        /// Retrieves the password policy for the Amazon Web Services account. This tells you
        /// the complexity requirements and mandatory rotation periods for the IAM user passwords
        /// in your account. For more information about using a password policy, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingPasswordPolicies.html">Managing
        /// an IAM password policy</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountPasswordPolicy service method.</param>
        /// 
        /// <returns>The response from the GetAccountPasswordPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetAccountPasswordPolicy">REST API Reference for GetAccountPasswordPolicy Operation</seealso>
        GetAccountPasswordPolicyResponse GetAccountPasswordPolicy(GetAccountPasswordPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccountPasswordPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccountPasswordPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccountPasswordPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetAccountPasswordPolicy">REST API Reference for GetAccountPasswordPolicy Operation</seealso>
        IAsyncResult BeginGetAccountPasswordPolicy(GetAccountPasswordPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccountPasswordPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccountPasswordPolicy.</param>
        /// 
        /// <returns>Returns a  GetAccountPasswordPolicyResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetAccountPasswordPolicy">REST API Reference for GetAccountPasswordPolicy Operation</seealso>
        GetAccountPasswordPolicyResponse EndGetAccountPasswordPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAccountSummary


        /// <summary>
        /// Retrieves information about IAM entity usage and IAM quotas in the Amazon Web Services
        /// account.
        /// 
        ///  
        /// <para>
        ///  For information about IAM quotas, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_iam-quotas.html">IAM
        /// and STS quotas</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the GetAccountSummary service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetAccountSummary">REST API Reference for GetAccountSummary Operation</seealso>
        GetAccountSummaryResponse GetAccountSummary();

        /// <summary>
        /// Retrieves information about IAM entity usage and IAM quotas in the Amazon Web Services
        /// account.
        /// 
        ///  
        /// <para>
        ///  For information about IAM quotas, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_iam-quotas.html">IAM
        /// and STS quotas</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSummary service method.</param>
        /// 
        /// <returns>The response from the GetAccountSummary service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetAccountSummary">REST API Reference for GetAccountSummary Operation</seealso>
        GetAccountSummaryResponse GetAccountSummary(GetAccountSummaryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccountSummary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSummary operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccountSummary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetAccountSummary">REST API Reference for GetAccountSummary Operation</seealso>
        IAsyncResult BeginGetAccountSummary(GetAccountSummaryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccountSummary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccountSummary.</param>
        /// 
        /// <returns>Returns a  GetAccountSummaryResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetAccountSummary">REST API Reference for GetAccountSummary Operation</seealso>
        GetAccountSummaryResponse EndGetAccountSummary(IAsyncResult asyncResult);

        #endregion
        
        #region  GetContextKeysForCustomPolicy


        /// <summary>
        /// Gets a list of all of the context keys referenced in the input policies. The policies
        /// are supplied as a list of one or more strings. To get the context keys from policies
        /// associated with an IAM user, group, or role, use <a>GetContextKeysForPrincipalPolicy</a>.
        /// 
        ///  
        /// <para>
        /// Context keys are variables maintained by Amazon Web Services and its services that
        /// provide details about the context of an API query request. Context keys can be evaluated
        /// by testing against a value specified in an IAM policy. Use <code>GetContextKeysForCustomPolicy</code>
        /// to understand what key names and values you must supply when you call <a>SimulateCustomPolicy</a>.
        /// Note that all parameters are shown in unencoded form here for clarity but must be
        /// URL encoded to be included as a part of a real HTML request.
        /// </para>
        /// </summary>
        /// <param name="policyInputList">A list of policies for which you want the list of context keys referenced in those policies. Each document is specified as a string containing the complete, valid JSON text of an IAM policy. The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> used to validate this parameter is a string of characters consisting of the following: <ul> <li> Any printable ASCII character ranging from the space character (<code>\u0020</code>) through the end of the ASCII character range </li> <li> The printable characters in the Basic Latin and Latin-1 Supplement character set (through <code>\u00FF</code>) </li> <li> The special characters tab (<code>\u0009</code>), line feed (<code>\u000A</code>), and carriage return (<code>\u000D</code>) </li> </ul></param>
        /// 
        /// <returns>The response from the GetContextKeysForCustomPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetContextKeysForCustomPolicy">REST API Reference for GetContextKeysForCustomPolicy Operation</seealso>
        GetContextKeysForCustomPolicyResponse GetContextKeysForCustomPolicy(List<string> policyInputList);

        /// <summary>
        /// Gets a list of all of the context keys referenced in the input policies. The policies
        /// are supplied as a list of one or more strings. To get the context keys from policies
        /// associated with an IAM user, group, or role, use <a>GetContextKeysForPrincipalPolicy</a>.
        /// 
        ///  
        /// <para>
        /// Context keys are variables maintained by Amazon Web Services and its services that
        /// provide details about the context of an API query request. Context keys can be evaluated
        /// by testing against a value specified in an IAM policy. Use <code>GetContextKeysForCustomPolicy</code>
        /// to understand what key names and values you must supply when you call <a>SimulateCustomPolicy</a>.
        /// Note that all parameters are shown in unencoded form here for clarity but must be
        /// URL encoded to be included as a part of a real HTML request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContextKeysForCustomPolicy service method.</param>
        /// 
        /// <returns>The response from the GetContextKeysForCustomPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetContextKeysForCustomPolicy">REST API Reference for GetContextKeysForCustomPolicy Operation</seealso>
        GetContextKeysForCustomPolicyResponse GetContextKeysForCustomPolicy(GetContextKeysForCustomPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetContextKeysForCustomPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetContextKeysForCustomPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetContextKeysForCustomPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetContextKeysForCustomPolicy">REST API Reference for GetContextKeysForCustomPolicy Operation</seealso>
        IAsyncResult BeginGetContextKeysForCustomPolicy(GetContextKeysForCustomPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetContextKeysForCustomPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetContextKeysForCustomPolicy.</param>
        /// 
        /// <returns>Returns a  GetContextKeysForCustomPolicyResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetContextKeysForCustomPolicy">REST API Reference for GetContextKeysForCustomPolicy Operation</seealso>
        GetContextKeysForCustomPolicyResponse EndGetContextKeysForCustomPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  GetContextKeysForPrincipalPolicy


        /// <summary>
        /// Gets a list of all of the context keys referenced in all the IAM policies that are
        /// attached to the specified IAM entity. The entity can be an IAM user, group, or role.
        /// If you specify a user, then the request also includes all of the policies attached
        /// to groups that the user is a member of.
        /// 
        ///  
        /// <para>
        /// You can optionally include a list of one or more additional policies, specified as
        /// strings. If you want to include <i>only</i> a list of policies by string, use <a>GetContextKeysForCustomPolicy</a>
        /// instead.
        /// </para>
        ///  
        /// <para>
        ///  <b>Note:</b> This operation discloses information about the permissions granted to
        /// other users. If you do not want users to see other user's permissions, then consider
        /// allowing them to use <a>GetContextKeysForCustomPolicy</a> instead.
        /// </para>
        ///  
        /// <para>
        /// Context keys are variables maintained by Amazon Web Services and its services that
        /// provide details about the context of an API query request. Context keys can be evaluated
        /// by testing against a value in an IAM policy. Use <a>GetContextKeysForPrincipalPolicy</a>
        /// to understand what key names and values you must supply when you call <a>SimulatePrincipalPolicy</a>.
        /// </para>
        /// </summary>
        /// <param name="policySourceArn">The ARN of a user, group, or role whose policies contain the context keys that you want listed. If you specify a user, the list includes context keys that are found in all policies that are attached to the user. The list also includes all groups that the user is a member of. If you pick a group or a role, then it includes only those context keys that are found in policies attached to that entity. Note that all parameters are shown in unencoded form here for clarity, but must be URL encoded to be included as a part of a real HTML request. For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon Resource Names (ARNs)</a> in the <i>Amazon Web Services General Reference</i>.</param>
        /// 
        /// <returns>The response from the GetContextKeysForPrincipalPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetContextKeysForPrincipalPolicy">REST API Reference for GetContextKeysForPrincipalPolicy Operation</seealso>
        GetContextKeysForPrincipalPolicyResponse GetContextKeysForPrincipalPolicy(string policySourceArn);

        /// <summary>
        /// Gets a list of all of the context keys referenced in all the IAM policies that are
        /// attached to the specified IAM entity. The entity can be an IAM user, group, or role.
        /// If you specify a user, then the request also includes all of the policies attached
        /// to groups that the user is a member of.
        /// 
        ///  
        /// <para>
        /// You can optionally include a list of one or more additional policies, specified as
        /// strings. If you want to include <i>only</i> a list of policies by string, use <a>GetContextKeysForCustomPolicy</a>
        /// instead.
        /// </para>
        ///  
        /// <para>
        ///  <b>Note:</b> This operation discloses information about the permissions granted to
        /// other users. If you do not want users to see other user's permissions, then consider
        /// allowing them to use <a>GetContextKeysForCustomPolicy</a> instead.
        /// </para>
        ///  
        /// <para>
        /// Context keys are variables maintained by Amazon Web Services and its services that
        /// provide details about the context of an API query request. Context keys can be evaluated
        /// by testing against a value in an IAM policy. Use <a>GetContextKeysForPrincipalPolicy</a>
        /// to understand what key names and values you must supply when you call <a>SimulatePrincipalPolicy</a>.
        /// </para>
        /// </summary>
        /// <param name="policySourceArn">The ARN of a user, group, or role whose policies contain the context keys that you want listed. If you specify a user, the list includes context keys that are found in all policies that are attached to the user. The list also includes all groups that the user is a member of. If you pick a group or a role, then it includes only those context keys that are found in policies attached to that entity. Note that all parameters are shown in unencoded form here for clarity, but must be URL encoded to be included as a part of a real HTML request. For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon Resource Names (ARNs)</a> in the <i>Amazon Web Services General Reference</i>.</param>
        /// <param name="policyInputList">An optional list of additional policies for which you want the list of context keys that are referenced. The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> used to validate this parameter is a string of characters consisting of the following: <ul> <li> Any printable ASCII character ranging from the space character (<code>\u0020</code>) through the end of the ASCII character range </li> <li> The printable characters in the Basic Latin and Latin-1 Supplement character set (through <code>\u00FF</code>) </li> <li> The special characters tab (<code>\u0009</code>), line feed (<code>\u000A</code>), and carriage return (<code>\u000D</code>) </li> </ul></param>
        /// 
        /// <returns>The response from the GetContextKeysForPrincipalPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetContextKeysForPrincipalPolicy">REST API Reference for GetContextKeysForPrincipalPolicy Operation</seealso>
        GetContextKeysForPrincipalPolicyResponse GetContextKeysForPrincipalPolicy(string policySourceArn, List<string> policyInputList);

        /// <summary>
        /// Gets a list of all of the context keys referenced in all the IAM policies that are
        /// attached to the specified IAM entity. The entity can be an IAM user, group, or role.
        /// If you specify a user, then the request also includes all of the policies attached
        /// to groups that the user is a member of.
        /// 
        ///  
        /// <para>
        /// You can optionally include a list of one or more additional policies, specified as
        /// strings. If you want to include <i>only</i> a list of policies by string, use <a>GetContextKeysForCustomPolicy</a>
        /// instead.
        /// </para>
        ///  
        /// <para>
        ///  <b>Note:</b> This operation discloses information about the permissions granted to
        /// other users. If you do not want users to see other user's permissions, then consider
        /// allowing them to use <a>GetContextKeysForCustomPolicy</a> instead.
        /// </para>
        ///  
        /// <para>
        /// Context keys are variables maintained by Amazon Web Services and its services that
        /// provide details about the context of an API query request. Context keys can be evaluated
        /// by testing against a value in an IAM policy. Use <a>GetContextKeysForPrincipalPolicy</a>
        /// to understand what key names and values you must supply when you call <a>SimulatePrincipalPolicy</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContextKeysForPrincipalPolicy service method.</param>
        /// 
        /// <returns>The response from the GetContextKeysForPrincipalPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetContextKeysForPrincipalPolicy">REST API Reference for GetContextKeysForPrincipalPolicy Operation</seealso>
        GetContextKeysForPrincipalPolicyResponse GetContextKeysForPrincipalPolicy(GetContextKeysForPrincipalPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetContextKeysForPrincipalPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetContextKeysForPrincipalPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetContextKeysForPrincipalPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetContextKeysForPrincipalPolicy">REST API Reference for GetContextKeysForPrincipalPolicy Operation</seealso>
        IAsyncResult BeginGetContextKeysForPrincipalPolicy(GetContextKeysForPrincipalPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetContextKeysForPrincipalPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetContextKeysForPrincipalPolicy.</param>
        /// 
        /// <returns>Returns a  GetContextKeysForPrincipalPolicyResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetContextKeysForPrincipalPolicy">REST API Reference for GetContextKeysForPrincipalPolicy Operation</seealso>
        GetContextKeysForPrincipalPolicyResponse EndGetContextKeysForPrincipalPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCredentialReport


        /// <summary>
        /// Retrieves a credential report for the Amazon Web Services account. For more information
        /// about the credential report, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/credential-reports.html">Getting
        /// credential reports</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// 
        /// <returns>The response from the GetCredentialReport service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.CredentialReportExpiredException">
        /// The request was rejected because the most recent credential report has expired. To
        /// generate a new credential report, use <a>GenerateCredentialReport</a>. For more information
        /// about credential report expiration, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/credential-reports.html">Getting
        /// credential reports</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.CredentialReportNotPresentException">
        /// The request was rejected because the credential report does not exist. To generate
        /// a credential report, use <a>GenerateCredentialReport</a>.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.CredentialReportNotReadyException">
        /// The request was rejected because the credential report is still being generated.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetCredentialReport">REST API Reference for GetCredentialReport Operation</seealso>
        GetCredentialReportResponse GetCredentialReport();

        /// <summary>
        /// Retrieves a credential report for the Amazon Web Services account. For more information
        /// about the credential report, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/credential-reports.html">Getting
        /// credential reports</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCredentialReport service method.</param>
        /// 
        /// <returns>The response from the GetCredentialReport service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.CredentialReportExpiredException">
        /// The request was rejected because the most recent credential report has expired. To
        /// generate a new credential report, use <a>GenerateCredentialReport</a>. For more information
        /// about credential report expiration, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/credential-reports.html">Getting
        /// credential reports</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.CredentialReportNotPresentException">
        /// The request was rejected because the credential report does not exist. To generate
        /// a credential report, use <a>GenerateCredentialReport</a>.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.CredentialReportNotReadyException">
        /// The request was rejected because the credential report is still being generated.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetCredentialReport">REST API Reference for GetCredentialReport Operation</seealso>
        GetCredentialReportResponse GetCredentialReport(GetCredentialReportRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCredentialReport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCredentialReport operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCredentialReport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetCredentialReport">REST API Reference for GetCredentialReport Operation</seealso>
        IAsyncResult BeginGetCredentialReport(GetCredentialReportRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCredentialReport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCredentialReport.</param>
        /// 
        /// <returns>Returns a  GetCredentialReportResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetCredentialReport">REST API Reference for GetCredentialReport Operation</seealso>
        GetCredentialReportResponse EndGetCredentialReport(IAsyncResult asyncResult);

        #endregion
        
        #region  GetGroup


        /// <summary>
        /// Returns a list of IAM users that are in the specified IAM group. You can paginate
        /// the results using the <code>MaxItems</code> and <code>Marker</code> parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroup service method.</param>
        /// 
        /// <returns>The response from the GetGroup service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetGroup">REST API Reference for GetGroup Operation</seealso>
        GetGroupResponse GetGroup(GetGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGroup operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetGroup">REST API Reference for GetGroup Operation</seealso>
        IAsyncResult BeginGetGroup(GetGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGroup.</param>
        /// 
        /// <returns>Returns a  GetGroupResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetGroup">REST API Reference for GetGroup Operation</seealso>
        GetGroupResponse EndGetGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  GetGroupPolicy


        /// <summary>
        /// Retrieves the specified inline policy document that is embedded in the specified IAM
        /// group.
        /// 
        ///  <note> 
        /// <para>
        /// Policies returned by this operation are URL-encoded compliant with <a href="https://tools.ietf.org/html/rfc3986">RFC
        /// 3986</a>. You can use a URL decoding method to convert the policy back to plain JSON
        /// text. For example, if you use Java, you can use the <code>decode</code> method of
        /// the <code>java.net.URLDecoder</code> utility class in the Java SDK. Other languages
        /// and SDKs provide similar functionality.
        /// </para>
        ///  </note> 
        /// <para>
        /// An IAM group can also have managed policies attached to it. To retrieve a managed
        /// policy document that is attached to a group, use <a>GetPolicy</a> to determine the
        /// policy's default version, then use <a>GetPolicyVersion</a> to retrieve the policy
        /// document.
        /// </para>
        ///  
        /// <para>
        /// For more information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// policies and inline policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroupPolicy service method.</param>
        /// 
        /// <returns>The response from the GetGroupPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetGroupPolicy">REST API Reference for GetGroupPolicy Operation</seealso>
        GetGroupPolicyResponse GetGroupPolicy(GetGroupPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetGroupPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGroupPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetGroupPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetGroupPolicy">REST API Reference for GetGroupPolicy Operation</seealso>
        IAsyncResult BeginGetGroupPolicy(GetGroupPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetGroupPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetGroupPolicy.</param>
        /// 
        /// <returns>Returns a  GetGroupPolicyResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetGroupPolicy">REST API Reference for GetGroupPolicy Operation</seealso>
        GetGroupPolicyResponse EndGetGroupPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  GetInstanceProfile


        /// <summary>
        /// Retrieves information about the specified instance profile, including the instance
        /// profile's path, GUID, ARN, and role. For more information about instance profiles,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/AboutInstanceProfiles.html">About
        /// instance profiles</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceProfile service method.</param>
        /// 
        /// <returns>The response from the GetInstanceProfile service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetInstanceProfile">REST API Reference for GetInstanceProfile Operation</seealso>
        GetInstanceProfileResponse GetInstanceProfile(GetInstanceProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceProfile operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInstanceProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetInstanceProfile">REST API Reference for GetInstanceProfile Operation</seealso>
        IAsyncResult BeginGetInstanceProfile(GetInstanceProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInstanceProfile.</param>
        /// 
        /// <returns>Returns a  GetInstanceProfileResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetInstanceProfile">REST API Reference for GetInstanceProfile Operation</seealso>
        GetInstanceProfileResponse EndGetInstanceProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  GetLoginProfile


        /// <summary>
        /// Retrieves the user name for the specified IAM user. A login profile is created when
        /// you create a password for the user to access the Amazon Web Services Management Console.
        /// If the user does not exist or does not have a password, the operation returns a 404
        /// (<code>NoSuchEntity</code>) error.
        /// 
        ///  
        /// <para>
        /// If you create an IAM user with access to the console, the <code>CreateDate</code>
        /// reflects the date you created the initial password for the user.
        /// </para>
        ///  
        /// <para>
        /// If you create an IAM user with programmatic access, and then later add a password
        /// for the user to access the Amazon Web Services Management Console, the <code>CreateDate</code>
        /// reflects the initial password creation date. A user with programmatic access does
        /// not have a login profile unless you create a password for the user to access the Amazon
        /// Web Services Management Console.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLoginProfile service method.</param>
        /// 
        /// <returns>The response from the GetLoginProfile service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetLoginProfile">REST API Reference for GetLoginProfile Operation</seealso>
        GetLoginProfileResponse GetLoginProfile(GetLoginProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetLoginProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLoginProfile operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLoginProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetLoginProfile">REST API Reference for GetLoginProfile Operation</seealso>
        IAsyncResult BeginGetLoginProfile(GetLoginProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetLoginProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLoginProfile.</param>
        /// 
        /// <returns>Returns a  GetLoginProfileResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetLoginProfile">REST API Reference for GetLoginProfile Operation</seealso>
        GetLoginProfileResponse EndGetLoginProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  GetOpenIDConnectProvider


        /// <summary>
        /// Returns information about the specified OpenID Connect (OIDC) provider resource object
        /// in IAM.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOpenIDConnectProvider service method.</param>
        /// 
        /// <returns>The response from the GetOpenIDConnectProvider service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetOpenIDConnectProvider">REST API Reference for GetOpenIDConnectProvider Operation</seealso>
        GetOpenIDConnectProviderResponse GetOpenIDConnectProvider(GetOpenIDConnectProviderRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetOpenIDConnectProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOpenIDConnectProvider operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOpenIDConnectProvider
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetOpenIDConnectProvider">REST API Reference for GetOpenIDConnectProvider Operation</seealso>
        IAsyncResult BeginGetOpenIDConnectProvider(GetOpenIDConnectProviderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetOpenIDConnectProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOpenIDConnectProvider.</param>
        /// 
        /// <returns>Returns a  GetOpenIDConnectProviderResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetOpenIDConnectProvider">REST API Reference for GetOpenIDConnectProvider Operation</seealso>
        GetOpenIDConnectProviderResponse EndGetOpenIDConnectProvider(IAsyncResult asyncResult);

        #endregion
        
        #region  GetOrganizationsAccessReport


        /// <summary>
        /// Retrieves the service last accessed data report for Organizations that was previously
        /// generated using the <code> <a>GenerateOrganizationsAccessReport</a> </code> operation.
        /// This operation retrieves the status of your report job and the report contents.
        /// 
        ///  
        /// <para>
        /// Depending on the parameters that you passed when you generated the report, the data
        /// returned could include different information. For details, see <a>GenerateOrganizationsAccessReport</a>.
        /// </para>
        ///  
        /// <para>
        /// To call this operation, you must be signed in to the management account in your organization.
        /// SCPs must be enabled for your organization root. You must have permissions to perform
        /// this operation. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_access-advisor.html">Refining
        /// permissions using service last accessed data</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For each service that principals in an account (root users, IAM users, or IAM roles)
        /// could access using SCPs, the operation returns details about the most recent access
        /// attempt. If there was no attempt, the service is listed without details about the
        /// most recent attempt to access the service. If the operation fails, it returns the
        /// reason that it failed.
        /// </para>
        ///  
        /// <para>
        /// By default, the list is sorted by service namespace.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOrganizationsAccessReport service method.</param>
        /// 
        /// <returns>The response from the GetOrganizationsAccessReport service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetOrganizationsAccessReport">REST API Reference for GetOrganizationsAccessReport Operation</seealso>
        GetOrganizationsAccessReportResponse GetOrganizationsAccessReport(GetOrganizationsAccessReportRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetOrganizationsAccessReport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOrganizationsAccessReport operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOrganizationsAccessReport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetOrganizationsAccessReport">REST API Reference for GetOrganizationsAccessReport Operation</seealso>
        IAsyncResult BeginGetOrganizationsAccessReport(GetOrganizationsAccessReportRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetOrganizationsAccessReport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOrganizationsAccessReport.</param>
        /// 
        /// <returns>Returns a  GetOrganizationsAccessReportResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetOrganizationsAccessReport">REST API Reference for GetOrganizationsAccessReport Operation</seealso>
        GetOrganizationsAccessReportResponse EndGetOrganizationsAccessReport(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPolicy


        /// <summary>
        /// Retrieves information about the specified managed policy, including the policy's default
        /// version and the total number of IAM users, groups, and roles to which the policy is
        /// attached. To retrieve the list of the specific users, groups, and roles that the policy
        /// is attached to, use <a>ListEntitiesForPolicy</a>. This operation returns metadata
        /// about the policy. To retrieve the actual policy document for a specific version of
        /// the policy, use <a>GetPolicyVersion</a>.
        /// 
        ///  
        /// <para>
        /// This operation retrieves information about managed policies. To retrieve information
        /// about an inline policy that is embedded with an IAM user, group, or role, use <a>GetUserPolicy</a>,
        /// <a>GetGroupPolicy</a>, or <a>GetRolePolicy</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// policies and inline policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy service method.</param>
        /// 
        /// <returns>The response from the GetPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        GetPolicyResponse GetPolicy(GetPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        IAsyncResult BeginGetPolicy(GetPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPolicy.</param>
        /// 
        /// <returns>Returns a  GetPolicyResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        GetPolicyResponse EndGetPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPolicyVersion


        /// <summary>
        /// Retrieves information about the specified version of the specified managed policy,
        /// including the policy document.
        /// 
        ///  <note> 
        /// <para>
        /// Policies returned by this operation are URL-encoded compliant with <a href="https://tools.ietf.org/html/rfc3986">RFC
        /// 3986</a>. You can use a URL decoding method to convert the policy back to plain JSON
        /// text. For example, if you use Java, you can use the <code>decode</code> method of
        /// the <code>java.net.URLDecoder</code> utility class in the Java SDK. Other languages
        /// and SDKs provide similar functionality.
        /// </para>
        ///  </note> 
        /// <para>
        /// To list the available versions for a policy, use <a>ListPolicyVersions</a>.
        /// </para>
        ///  
        /// <para>
        /// This operation retrieves information about managed policies. To retrieve information
        /// about an inline policy that is embedded in a user, group, or role, use <a>GetUserPolicy</a>,
        /// <a>GetGroupPolicy</a>, or <a>GetRolePolicy</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information about the types of policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// policies and inline policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about managed policy versions, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-versions.html">Versioning
        /// for managed policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPolicyVersion service method.</param>
        /// 
        /// <returns>The response from the GetPolicyVersion service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetPolicyVersion">REST API Reference for GetPolicyVersion Operation</seealso>
        GetPolicyVersionResponse GetPolicyVersion(GetPolicyVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPolicyVersion operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPolicyVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetPolicyVersion">REST API Reference for GetPolicyVersion Operation</seealso>
        IAsyncResult BeginGetPolicyVersion(GetPolicyVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPolicyVersion.</param>
        /// 
        /// <returns>Returns a  GetPolicyVersionResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetPolicyVersion">REST API Reference for GetPolicyVersion Operation</seealso>
        GetPolicyVersionResponse EndGetPolicyVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRole


        /// <summary>
        /// Retrieves information about the specified role, including the role's path, GUID, ARN,
        /// and the role's trust policy that grants permission to assume the role. For more information
        /// about roles, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html">Working
        /// with roles</a>.
        /// 
        ///  <note> 
        /// <para>
        /// Policies returned by this operation are URL-encoded compliant with <a href="https://tools.ietf.org/html/rfc3986">RFC
        /// 3986</a>. You can use a URL decoding method to convert the policy back to plain JSON
        /// text. For example, if you use Java, you can use the <code>decode</code> method of
        /// the <code>java.net.URLDecoder</code> utility class in the Java SDK. Other languages
        /// and SDKs provide similar functionality.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRole service method.</param>
        /// 
        /// <returns>The response from the GetRole service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetRole">REST API Reference for GetRole Operation</seealso>
        GetRoleResponse GetRole(GetRoleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRole operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRole
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetRole">REST API Reference for GetRole Operation</seealso>
        IAsyncResult BeginGetRole(GetRoleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRole operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRole.</param>
        /// 
        /// <returns>Returns a  GetRoleResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetRole">REST API Reference for GetRole Operation</seealso>
        GetRoleResponse EndGetRole(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRolePolicy


        /// <summary>
        /// Retrieves the specified inline policy document that is embedded with the specified
        /// IAM role.
        /// 
        ///  <note> 
        /// <para>
        /// Policies returned by this operation are URL-encoded compliant with <a href="https://tools.ietf.org/html/rfc3986">RFC
        /// 3986</a>. You can use a URL decoding method to convert the policy back to plain JSON
        /// text. For example, if you use Java, you can use the <code>decode</code> method of
        /// the <code>java.net.URLDecoder</code> utility class in the Java SDK. Other languages
        /// and SDKs provide similar functionality.
        /// </para>
        ///  </note> 
        /// <para>
        /// An IAM role can also have managed policies attached to it. To retrieve a managed policy
        /// document that is attached to a role, use <a>GetPolicy</a> to determine the policy's
        /// default version, then use <a>GetPolicyVersion</a> to retrieve the policy document.
        /// </para>
        ///  
        /// <para>
        /// For more information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// policies and inline policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about roles, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/roles-toplevel.html">Using
        /// roles to delegate permissions and federate identities</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRolePolicy service method.</param>
        /// 
        /// <returns>The response from the GetRolePolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetRolePolicy">REST API Reference for GetRolePolicy Operation</seealso>
        GetRolePolicyResponse GetRolePolicy(GetRolePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRolePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRolePolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRolePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetRolePolicy">REST API Reference for GetRolePolicy Operation</seealso>
        IAsyncResult BeginGetRolePolicy(GetRolePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRolePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRolePolicy.</param>
        /// 
        /// <returns>Returns a  GetRolePolicyResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetRolePolicy">REST API Reference for GetRolePolicy Operation</seealso>
        GetRolePolicyResponse EndGetRolePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSAMLProvider


        /// <summary>
        /// Returns the SAML provider metadocument that was uploaded when the IAM SAML provider
        /// resource object was created or updated.
        /// 
        ///  <note> 
        /// <para>
        /// This operation requires <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version 4</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSAMLProvider service method.</param>
        /// 
        /// <returns>The response from the GetSAMLProvider service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetSAMLProvider">REST API Reference for GetSAMLProvider Operation</seealso>
        GetSAMLProviderResponse GetSAMLProvider(GetSAMLProviderRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSAMLProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSAMLProvider operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSAMLProvider
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetSAMLProvider">REST API Reference for GetSAMLProvider Operation</seealso>
        IAsyncResult BeginGetSAMLProvider(GetSAMLProviderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSAMLProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSAMLProvider.</param>
        /// 
        /// <returns>Returns a  GetSAMLProviderResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetSAMLProvider">REST API Reference for GetSAMLProvider Operation</seealso>
        GetSAMLProviderResponse EndGetSAMLProvider(IAsyncResult asyncResult);

        #endregion
        
        #region  GetServerCertificate


        /// <summary>
        /// Retrieves information about the specified server certificate stored in IAM.
        /// 
        ///  
        /// <para>
        /// For more information about working with server certificates, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_server-certs.html">Working
        /// with server certificates</a> in the <i>IAM User Guide</i>. This topic includes a list
        /// of Amazon Web Services services that can use the server certificates that you manage
        /// with IAM.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServerCertificate service method.</param>
        /// 
        /// <returns>The response from the GetServerCertificate service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetServerCertificate">REST API Reference for GetServerCertificate Operation</seealso>
        GetServerCertificateResponse GetServerCertificate(GetServerCertificateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetServerCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetServerCertificate operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetServerCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetServerCertificate">REST API Reference for GetServerCertificate Operation</seealso>
        IAsyncResult BeginGetServerCertificate(GetServerCertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetServerCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetServerCertificate.</param>
        /// 
        /// <returns>Returns a  GetServerCertificateResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetServerCertificate">REST API Reference for GetServerCertificate Operation</seealso>
        GetServerCertificateResponse EndGetServerCertificate(IAsyncResult asyncResult);

        #endregion
        
        #region  GetServiceLastAccessedDetails


        /// <summary>
        /// Retrieves a service last accessed report that was created using the <code>GenerateServiceLastAccessedDetails</code>
        /// operation. You can use the <code>JobId</code> parameter in <code>GetServiceLastAccessedDetails</code>
        /// to retrieve the status of your report job. When the report is complete, you can retrieve
        /// the generated report. The report includes a list of Amazon Web Services services that
        /// the resource (user, group, role, or managed policy) can access.
        /// 
        ///  <note> 
        /// <para>
        /// Service last accessed data does not use other policy types when determining whether
        /// a resource could access a service. These other policy types include resource-based
        /// policies, access control lists, Organizations policies, IAM permissions boundaries,
        /// and STS assume role policies. It only applies permissions policy logic. For more about
        /// the evaluation of policy types, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_evaluation-logic.html#policy-eval-basics">Evaluating
        /// policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// For each service that the resource could access using permissions policies, the operation
        /// returns details about the most recent access attempt. If there was no attempt, the
        /// service is listed without details about the most recent attempt to access the service.
        /// If the operation fails, the <code>GetServiceLastAccessedDetails</code> operation returns
        /// the reason that it failed.
        /// </para>
        ///  
        /// <para>
        /// The <code>GetServiceLastAccessedDetails</code> operation returns a list of services.
        /// This list includes the number of entities that have attempted to access the service
        /// and the date and time of the last attempt. It also returns the ARN of the following
        /// entity, depending on the resource ARN that you used to generate the report:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>User</b> – Returns the user ARN that you used to generate the report
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Group</b> – Returns the ARN of the group member (user) that last attempted to
        /// access the service
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Role</b> – Returns the role ARN that you used to generate the report
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Policy</b> – Returns the ARN of the user or role that last used the policy to
        /// attempt to access the service
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// By default, the list is sorted by service namespace.
        /// </para>
        ///  
        /// <para>
        /// If you specified <code>ACTION_LEVEL</code> granularity when you generated the report,
        /// this operation returns service and action last accessed data. This includes the most
        /// recent access attempt for each tracked action within a service. Otherwise, this operation
        /// returns only service data.
        /// </para>
        ///  
        /// <para>
        /// For more information about service and action last accessed data, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_access-advisor.html">Reducing
        /// permissions using service last accessed data</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceLastAccessedDetails service method.</param>
        /// 
        /// <returns>The response from the GetServiceLastAccessedDetails service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetServiceLastAccessedDetails">REST API Reference for GetServiceLastAccessedDetails Operation</seealso>
        GetServiceLastAccessedDetailsResponse GetServiceLastAccessedDetails(GetServiceLastAccessedDetailsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetServiceLastAccessedDetails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetServiceLastAccessedDetails operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetServiceLastAccessedDetails
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetServiceLastAccessedDetails">REST API Reference for GetServiceLastAccessedDetails Operation</seealso>
        IAsyncResult BeginGetServiceLastAccessedDetails(GetServiceLastAccessedDetailsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetServiceLastAccessedDetails operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetServiceLastAccessedDetails.</param>
        /// 
        /// <returns>Returns a  GetServiceLastAccessedDetailsResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetServiceLastAccessedDetails">REST API Reference for GetServiceLastAccessedDetails Operation</seealso>
        GetServiceLastAccessedDetailsResponse EndGetServiceLastAccessedDetails(IAsyncResult asyncResult);

        #endregion
        
        #region  GetServiceLastAccessedDetailsWithEntities


        /// <summary>
        /// After you generate a group or policy report using the <code>GenerateServiceLastAccessedDetails</code>
        /// operation, you can use the <code>JobId</code> parameter in <code>GetServiceLastAccessedDetailsWithEntities</code>.
        /// This operation retrieves the status of your report job and a list of entities that
        /// could have used group or policy permissions to access the specified service.
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <b>Group</b> – For a group report, this operation returns a list of users in the
        /// group that could have used the group’s policies in an attempt to access the service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Policy</b> – For a policy report, this operation returns a list of entities (users
        /// or roles) that could have used the policy in an attempt to access the service.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can also use this operation for user or role reports to retrieve details about
        /// those entities.
        /// </para>
        ///  
        /// <para>
        /// If the operation fails, the <code>GetServiceLastAccessedDetailsWithEntities</code>
        /// operation returns the reason that it failed.
        /// </para>
        ///  
        /// <para>
        /// By default, the list of associated entities is sorted by date, with the most recent
        /// access listed first.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceLastAccessedDetailsWithEntities service method.</param>
        /// 
        /// <returns>The response from the GetServiceLastAccessedDetailsWithEntities service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetServiceLastAccessedDetailsWithEntities">REST API Reference for GetServiceLastAccessedDetailsWithEntities Operation</seealso>
        GetServiceLastAccessedDetailsWithEntitiesResponse GetServiceLastAccessedDetailsWithEntities(GetServiceLastAccessedDetailsWithEntitiesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetServiceLastAccessedDetailsWithEntities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetServiceLastAccessedDetailsWithEntities operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetServiceLastAccessedDetailsWithEntities
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetServiceLastAccessedDetailsWithEntities">REST API Reference for GetServiceLastAccessedDetailsWithEntities Operation</seealso>
        IAsyncResult BeginGetServiceLastAccessedDetailsWithEntities(GetServiceLastAccessedDetailsWithEntitiesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetServiceLastAccessedDetailsWithEntities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetServiceLastAccessedDetailsWithEntities.</param>
        /// 
        /// <returns>Returns a  GetServiceLastAccessedDetailsWithEntitiesResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetServiceLastAccessedDetailsWithEntities">REST API Reference for GetServiceLastAccessedDetailsWithEntities Operation</seealso>
        GetServiceLastAccessedDetailsWithEntitiesResponse EndGetServiceLastAccessedDetailsWithEntities(IAsyncResult asyncResult);

        #endregion
        
        #region  GetServiceLinkedRoleDeletionStatus


        /// <summary>
        /// Retrieves the status of your service-linked role deletion. After you use <a>DeleteServiceLinkedRole</a>
        /// to submit a service-linked role for deletion, you can use the <code>DeletionTaskId</code>
        /// parameter in <code>GetServiceLinkedRoleDeletionStatus</code> to check the status of
        /// the deletion. If the deletion fails, this operation returns the reason that it failed,
        /// if that information is returned by the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceLinkedRoleDeletionStatus service method.</param>
        /// 
        /// <returns>The response from the GetServiceLinkedRoleDeletionStatus service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetServiceLinkedRoleDeletionStatus">REST API Reference for GetServiceLinkedRoleDeletionStatus Operation</seealso>
        GetServiceLinkedRoleDeletionStatusResponse GetServiceLinkedRoleDeletionStatus(GetServiceLinkedRoleDeletionStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetServiceLinkedRoleDeletionStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetServiceLinkedRoleDeletionStatus operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetServiceLinkedRoleDeletionStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetServiceLinkedRoleDeletionStatus">REST API Reference for GetServiceLinkedRoleDeletionStatus Operation</seealso>
        IAsyncResult BeginGetServiceLinkedRoleDeletionStatus(GetServiceLinkedRoleDeletionStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetServiceLinkedRoleDeletionStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetServiceLinkedRoleDeletionStatus.</param>
        /// 
        /// <returns>Returns a  GetServiceLinkedRoleDeletionStatusResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetServiceLinkedRoleDeletionStatus">REST API Reference for GetServiceLinkedRoleDeletionStatus Operation</seealso>
        GetServiceLinkedRoleDeletionStatusResponse EndGetServiceLinkedRoleDeletionStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSSHPublicKey


        /// <summary>
        /// Retrieves the specified SSH public key, including metadata about the key.
        /// 
        ///  
        /// <para>
        /// The SSH public key retrieved by this operation is used only for authenticating the
        /// associated IAM user to an CodeCommit repository. For more information about using
        /// SSH keys to authenticate to an CodeCommit repository, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/setting-up-credentials-ssh.html">Set
        /// up CodeCommit for SSH connections</a> in the <i>CodeCommit User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSSHPublicKey service method.</param>
        /// 
        /// <returns>The response from the GetSSHPublicKey service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.UnrecognizedPublicKeyEncodingException">
        /// The request was rejected because the public key encoding format is unsupported or
        /// unrecognized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetSSHPublicKey">REST API Reference for GetSSHPublicKey Operation</seealso>
        GetSSHPublicKeyResponse GetSSHPublicKey(GetSSHPublicKeyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSSHPublicKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSSHPublicKey operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSSHPublicKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetSSHPublicKey">REST API Reference for GetSSHPublicKey Operation</seealso>
        IAsyncResult BeginGetSSHPublicKey(GetSSHPublicKeyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSSHPublicKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSSHPublicKey.</param>
        /// 
        /// <returns>Returns a  GetSSHPublicKeyResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetSSHPublicKey">REST API Reference for GetSSHPublicKey Operation</seealso>
        GetSSHPublicKeyResponse EndGetSSHPublicKey(IAsyncResult asyncResult);

        #endregion
        
        #region  GetUser


        /// <summary>
        /// Retrieves information about the specified IAM user, including the user's creation
        /// date, path, unique ID, and ARN.
        /// 
        ///  
        /// <para>
        /// If you do not specify a user name, IAM determines the user name implicitly based on
        /// the Amazon Web Services access key ID used to sign the request to this operation.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the GetUser service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetUser">REST API Reference for GetUser Operation</seealso>
        GetUserResponse GetUser();

        /// <summary>
        /// Retrieves information about the specified IAM user, including the user's creation
        /// date, path, unique ID, and ARN.
        /// 
        ///  
        /// <para>
        /// If you do not specify a user name, IAM determines the user name implicitly based on
        /// the Amazon Web Services access key ID used to sign the request to this operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUser service method.</param>
        /// 
        /// <returns>The response from the GetUser service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetUser">REST API Reference for GetUser Operation</seealso>
        GetUserResponse GetUser(GetUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUser operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetUser">REST API Reference for GetUser Operation</seealso>
        IAsyncResult BeginGetUser(GetUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUser.</param>
        /// 
        /// <returns>Returns a  GetUserResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetUser">REST API Reference for GetUser Operation</seealso>
        GetUserResponse EndGetUser(IAsyncResult asyncResult);

        #endregion
        
        #region  GetUserPolicy


        /// <summary>
        /// Retrieves the specified inline policy document that is embedded in the specified IAM
        /// user.
        /// 
        ///  <note> 
        /// <para>
        /// Policies returned by this operation are URL-encoded compliant with <a href="https://tools.ietf.org/html/rfc3986">RFC
        /// 3986</a>. You can use a URL decoding method to convert the policy back to plain JSON
        /// text. For example, if you use Java, you can use the <code>decode</code> method of
        /// the <code>java.net.URLDecoder</code> utility class in the Java SDK. Other languages
        /// and SDKs provide similar functionality.
        /// </para>
        ///  </note> 
        /// <para>
        /// An IAM user can also have managed policies attached to it. To retrieve a managed policy
        /// document that is attached to a user, use <a>GetPolicy</a> to determine the policy's
        /// default version. Then use <a>GetPolicyVersion</a> to retrieve the policy document.
        /// </para>
        ///  
        /// <para>
        /// For more information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// policies and inline policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUserPolicy service method.</param>
        /// 
        /// <returns>The response from the GetUserPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetUserPolicy">REST API Reference for GetUserPolicy Operation</seealso>
        GetUserPolicyResponse GetUserPolicy(GetUserPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetUserPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUserPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUserPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetUserPolicy">REST API Reference for GetUserPolicy Operation</seealso>
        IAsyncResult BeginGetUserPolicy(GetUserPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetUserPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUserPolicy.</param>
        /// 
        /// <returns>Returns a  GetUserPolicyResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetUserPolicy">REST API Reference for GetUserPolicy Operation</seealso>
        GetUserPolicyResponse EndGetUserPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAccessKeys


        /// <summary>
        /// Returns information about the access key IDs associated with the specified IAM user.
        /// If there is none, the operation returns an empty list.
        /// 
        ///  
        /// <para>
        /// Although each user is limited to a small number of keys, you can still paginate the
        /// results using the <code>MaxItems</code> and <code>Marker</code> parameters.
        /// </para>
        ///  
        /// <para>
        /// If the <code>UserName</code> is not specified, the user name is determined implicitly
        /// based on the Amazon Web Services access key ID used to sign the request. If a temporary
        /// access key is used, then <code>UserName</code> is required. If a long-term key is
        /// assigned to the user, then <code>UserName</code> is not required. This operation works
        /// for access keys under the Amazon Web Services account. Consequently, you can use this
        /// operation to manage Amazon Web Services account root user credentials even if the
        /// Amazon Web Services account has no associated users.
        /// </para>
        ///  <note> 
        /// <para>
        /// To ensure the security of your Amazon Web Services account, the secret access key
        /// is accessible only during key and user creation.
        /// </para>
        ///  </note>
        /// </summary>
        /// 
        /// <returns>The response from the ListAccessKeys service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListAccessKeys">REST API Reference for ListAccessKeys Operation</seealso>
        ListAccessKeysResponse ListAccessKeys();

        /// <summary>
        /// Returns information about the access key IDs associated with the specified IAM user.
        /// If there is none, the operation returns an empty list.
        /// 
        ///  
        /// <para>
        /// Although each user is limited to a small number of keys, you can still paginate the
        /// results using the <code>MaxItems</code> and <code>Marker</code> parameters.
        /// </para>
        ///  
        /// <para>
        /// If the <code>UserName</code> is not specified, the user name is determined implicitly
        /// based on the Amazon Web Services access key ID used to sign the request. If a temporary
        /// access key is used, then <code>UserName</code> is required. If a long-term key is
        /// assigned to the user, then <code>UserName</code> is not required. This operation works
        /// for access keys under the Amazon Web Services account. Consequently, you can use this
        /// operation to manage Amazon Web Services account root user credentials even if the
        /// Amazon Web Services account has no associated users.
        /// </para>
        ///  <note> 
        /// <para>
        /// To ensure the security of your Amazon Web Services account, the secret access key
        /// is accessible only during key and user creation.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessKeys service method.</param>
        /// 
        /// <returns>The response from the ListAccessKeys service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListAccessKeys">REST API Reference for ListAccessKeys Operation</seealso>
        ListAccessKeysResponse ListAccessKeys(ListAccessKeysRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccessKeys operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccessKeys operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAccessKeys
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListAccessKeys">REST API Reference for ListAccessKeys Operation</seealso>
        IAsyncResult BeginListAccessKeys(ListAccessKeysRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAccessKeys operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccessKeys.</param>
        /// 
        /// <returns>Returns a  ListAccessKeysResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListAccessKeys">REST API Reference for ListAccessKeys Operation</seealso>
        ListAccessKeysResponse EndListAccessKeys(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAccountAliases


        /// <summary>
        /// Lists the account alias associated with the Amazon Web Services account (Note: you
        /// can have only one). For information about using an Amazon Web Services account alias,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/AccountAlias.html">Using
        /// an alias for your Amazon Web Services account ID</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// 
        /// <returns>The response from the ListAccountAliases service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListAccountAliases">REST API Reference for ListAccountAliases Operation</seealso>
        ListAccountAliasesResponse ListAccountAliases();

        /// <summary>
        /// Lists the account alias associated with the Amazon Web Services account (Note: you
        /// can have only one). For information about using an Amazon Web Services account alias,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/AccountAlias.html">Using
        /// an alias for your Amazon Web Services account ID</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccountAliases service method.</param>
        /// 
        /// <returns>The response from the ListAccountAliases service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListAccountAliases">REST API Reference for ListAccountAliases Operation</seealso>
        ListAccountAliasesResponse ListAccountAliases(ListAccountAliasesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccountAliases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccountAliases operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAccountAliases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListAccountAliases">REST API Reference for ListAccountAliases Operation</seealso>
        IAsyncResult BeginListAccountAliases(ListAccountAliasesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAccountAliases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccountAliases.</param>
        /// 
        /// <returns>Returns a  ListAccountAliasesResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListAccountAliases">REST API Reference for ListAccountAliases Operation</seealso>
        ListAccountAliasesResponse EndListAccountAliases(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAttachedGroupPolicies


        /// <summary>
        /// Lists all managed policies that are attached to the specified IAM group.
        /// 
        ///  
        /// <para>
        /// An IAM group can also have inline policies embedded with it. To list the inline policies
        /// for a group, use <a>ListGroupPolicies</a>. For information about policies, see <a
        /// href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// policies and inline policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters. You can use the <code>PathPrefix</code> parameter to limit the list of
        /// policies to only those matching the specified path prefix. If there are no policies
        /// attached to the specified group (or none that match the specified path prefix), the
        /// operation returns an empty list.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedGroupPolicies service method.</param>
        /// 
        /// <returns>The response from the ListAttachedGroupPolicies service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListAttachedGroupPolicies">REST API Reference for ListAttachedGroupPolicies Operation</seealso>
        ListAttachedGroupPoliciesResponse ListAttachedGroupPolicies(ListAttachedGroupPoliciesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAttachedGroupPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedGroupPolicies operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAttachedGroupPolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListAttachedGroupPolicies">REST API Reference for ListAttachedGroupPolicies Operation</seealso>
        IAsyncResult BeginListAttachedGroupPolicies(ListAttachedGroupPoliciesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAttachedGroupPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAttachedGroupPolicies.</param>
        /// 
        /// <returns>Returns a  ListAttachedGroupPoliciesResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListAttachedGroupPolicies">REST API Reference for ListAttachedGroupPolicies Operation</seealso>
        ListAttachedGroupPoliciesResponse EndListAttachedGroupPolicies(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAttachedRolePolicies


        /// <summary>
        /// Lists all managed policies that are attached to the specified IAM role.
        /// 
        ///  
        /// <para>
        /// An IAM role can also have inline policies embedded with it. To list the inline policies
        /// for a role, use <a>ListRolePolicies</a>. For information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// policies and inline policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters. You can use the <code>PathPrefix</code> parameter to limit the list of
        /// policies to only those matching the specified path prefix. If there are no policies
        /// attached to the specified role (or none that match the specified path prefix), the
        /// operation returns an empty list.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedRolePolicies service method.</param>
        /// 
        /// <returns>The response from the ListAttachedRolePolicies service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListAttachedRolePolicies">REST API Reference for ListAttachedRolePolicies Operation</seealso>
        ListAttachedRolePoliciesResponse ListAttachedRolePolicies(ListAttachedRolePoliciesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAttachedRolePolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedRolePolicies operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAttachedRolePolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListAttachedRolePolicies">REST API Reference for ListAttachedRolePolicies Operation</seealso>
        IAsyncResult BeginListAttachedRolePolicies(ListAttachedRolePoliciesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAttachedRolePolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAttachedRolePolicies.</param>
        /// 
        /// <returns>Returns a  ListAttachedRolePoliciesResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListAttachedRolePolicies">REST API Reference for ListAttachedRolePolicies Operation</seealso>
        ListAttachedRolePoliciesResponse EndListAttachedRolePolicies(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAttachedUserPolicies


        /// <summary>
        /// Lists all managed policies that are attached to the specified IAM user.
        /// 
        ///  
        /// <para>
        /// An IAM user can also have inline policies embedded with it. To list the inline policies
        /// for a user, use <a>ListUserPolicies</a>. For information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// policies and inline policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters. You can use the <code>PathPrefix</code> parameter to limit the list of
        /// policies to only those matching the specified path prefix. If there are no policies
        /// attached to the specified group (or none that match the specified path prefix), the
        /// operation returns an empty list.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedUserPolicies service method.</param>
        /// 
        /// <returns>The response from the ListAttachedUserPolicies service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListAttachedUserPolicies">REST API Reference for ListAttachedUserPolicies Operation</seealso>
        ListAttachedUserPoliciesResponse ListAttachedUserPolicies(ListAttachedUserPoliciesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAttachedUserPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedUserPolicies operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAttachedUserPolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListAttachedUserPolicies">REST API Reference for ListAttachedUserPolicies Operation</seealso>
        IAsyncResult BeginListAttachedUserPolicies(ListAttachedUserPoliciesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAttachedUserPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAttachedUserPolicies.</param>
        /// 
        /// <returns>Returns a  ListAttachedUserPoliciesResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListAttachedUserPolicies">REST API Reference for ListAttachedUserPolicies Operation</seealso>
        ListAttachedUserPoliciesResponse EndListAttachedUserPolicies(IAsyncResult asyncResult);

        #endregion
        
        #region  ListEntitiesForPolicy


        /// <summary>
        /// Lists all IAM users, groups, and roles that the specified managed policy is attached
        /// to.
        /// 
        ///  
        /// <para>
        /// You can use the optional <code>EntityFilter</code> parameter to limit the results
        /// to a particular type of entity (users, groups, or roles). For example, to list only
        /// the roles that are attached to the specified policy, set <code>EntityFilter</code>
        /// to <code>Role</code>.
        /// </para>
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEntitiesForPolicy service method.</param>
        /// 
        /// <returns>The response from the ListEntitiesForPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListEntitiesForPolicy">REST API Reference for ListEntitiesForPolicy Operation</seealso>
        ListEntitiesForPolicyResponse ListEntitiesForPolicy(ListEntitiesForPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListEntitiesForPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEntitiesForPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEntitiesForPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListEntitiesForPolicy">REST API Reference for ListEntitiesForPolicy Operation</seealso>
        IAsyncResult BeginListEntitiesForPolicy(ListEntitiesForPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListEntitiesForPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEntitiesForPolicy.</param>
        /// 
        /// <returns>Returns a  ListEntitiesForPolicyResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListEntitiesForPolicy">REST API Reference for ListEntitiesForPolicy Operation</seealso>
        ListEntitiesForPolicyResponse EndListEntitiesForPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  ListGroupPolicies


        /// <summary>
        /// Lists the names of the inline policies that are embedded in the specified IAM group.
        /// 
        ///  
        /// <para>
        /// An IAM group can also have managed policies attached to it. To list the managed policies
        /// that are attached to a group, use <a>ListAttachedGroupPolicies</a>. For more information
        /// about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// policies and inline policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters. If there are no inline policies embedded with the specified group, the
        /// operation returns an empty list.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupPolicies service method.</param>
        /// 
        /// <returns>The response from the ListGroupPolicies service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListGroupPolicies">REST API Reference for ListGroupPolicies Operation</seealso>
        ListGroupPoliciesResponse ListGroupPolicies(ListGroupPoliciesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroupPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroupPolicies operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGroupPolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListGroupPolicies">REST API Reference for ListGroupPolicies Operation</seealso>
        IAsyncResult BeginListGroupPolicies(ListGroupPoliciesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListGroupPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGroupPolicies.</param>
        /// 
        /// <returns>Returns a  ListGroupPoliciesResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListGroupPolicies">REST API Reference for ListGroupPolicies Operation</seealso>
        ListGroupPoliciesResponse EndListGroupPolicies(IAsyncResult asyncResult);

        #endregion
        
        #region  ListGroups


        /// <summary>
        /// Lists the IAM groups that have the specified path prefix.
        /// 
        ///  
        /// <para>
        ///  You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListGroups service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListGroups">REST API Reference for ListGroups Operation</seealso>
        ListGroupsResponse ListGroups();

        /// <summary>
        /// Lists the IAM groups that have the specified path prefix.
        /// 
        ///  
        /// <para>
        ///  You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroups service method.</param>
        /// 
        /// <returns>The response from the ListGroups service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListGroups">REST API Reference for ListGroups Operation</seealso>
        ListGroupsResponse ListGroups(ListGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroups operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListGroups">REST API Reference for ListGroups Operation</seealso>
        IAsyncResult BeginListGroups(ListGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGroups.</param>
        /// 
        /// <returns>Returns a  ListGroupsResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListGroups">REST API Reference for ListGroups Operation</seealso>
        ListGroupsResponse EndListGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  ListGroupsForUser


        /// <summary>
        /// Lists the IAM groups that the specified IAM user belongs to.
        /// 
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupsForUser service method.</param>
        /// 
        /// <returns>The response from the ListGroupsForUser service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListGroupsForUser">REST API Reference for ListGroupsForUser Operation</seealso>
        ListGroupsForUserResponse ListGroupsForUser(ListGroupsForUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroupsForUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroupsForUser operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGroupsForUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListGroupsForUser">REST API Reference for ListGroupsForUser Operation</seealso>
        IAsyncResult BeginListGroupsForUser(ListGroupsForUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListGroupsForUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGroupsForUser.</param>
        /// 
        /// <returns>Returns a  ListGroupsForUserResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListGroupsForUser">REST API Reference for ListGroupsForUser Operation</seealso>
        ListGroupsForUserResponse EndListGroupsForUser(IAsyncResult asyncResult);

        #endregion
        
        #region  ListInstanceProfiles


        /// <summary>
        /// Lists the instance profiles that have the specified path prefix. If there are none,
        /// the operation returns an empty list. For more information about instance profiles,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/AboutInstanceProfiles.html">About
        /// instance profiles</a>.
        /// 
        ///  <note> 
        /// <para>
        /// IAM resource-listing operations return a subset of the available attributes for the
        /// resource. For example, this operation does not return tags, even though they are an
        /// attribute of the returned object. To view all of the information for an instance profile,
        /// see <a>GetInstanceProfile</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListInstanceProfiles service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListInstanceProfiles">REST API Reference for ListInstanceProfiles Operation</seealso>
        ListInstanceProfilesResponse ListInstanceProfiles();

        /// <summary>
        /// Lists the instance profiles that have the specified path prefix. If there are none,
        /// the operation returns an empty list. For more information about instance profiles,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/AboutInstanceProfiles.html">About
        /// instance profiles</a>.
        /// 
        ///  <note> 
        /// <para>
        /// IAM resource-listing operations return a subset of the available attributes for the
        /// resource. For example, this operation does not return tags, even though they are an
        /// attribute of the returned object. To view all of the information for an instance profile,
        /// see <a>GetInstanceProfile</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceProfiles service method.</param>
        /// 
        /// <returns>The response from the ListInstanceProfiles service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListInstanceProfiles">REST API Reference for ListInstanceProfiles Operation</seealso>
        ListInstanceProfilesResponse ListInstanceProfiles(ListInstanceProfilesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListInstanceProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceProfiles operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInstanceProfiles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListInstanceProfiles">REST API Reference for ListInstanceProfiles Operation</seealso>
        IAsyncResult BeginListInstanceProfiles(ListInstanceProfilesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListInstanceProfiles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInstanceProfiles.</param>
        /// 
        /// <returns>Returns a  ListInstanceProfilesResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListInstanceProfiles">REST API Reference for ListInstanceProfiles Operation</seealso>
        ListInstanceProfilesResponse EndListInstanceProfiles(IAsyncResult asyncResult);

        #endregion
        
        #region  ListInstanceProfilesForRole


        /// <summary>
        /// Lists the instance profiles that have the specified associated IAM role. If there
        /// are none, the operation returns an empty list. For more information about instance
        /// profiles, go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/AboutInstanceProfiles.html">About
        /// instance profiles</a>.
        /// 
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceProfilesForRole service method.</param>
        /// 
        /// <returns>The response from the ListInstanceProfilesForRole service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListInstanceProfilesForRole">REST API Reference for ListInstanceProfilesForRole Operation</seealso>
        ListInstanceProfilesForRoleResponse ListInstanceProfilesForRole(ListInstanceProfilesForRoleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListInstanceProfilesForRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceProfilesForRole operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInstanceProfilesForRole
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListInstanceProfilesForRole">REST API Reference for ListInstanceProfilesForRole Operation</seealso>
        IAsyncResult BeginListInstanceProfilesForRole(ListInstanceProfilesForRoleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListInstanceProfilesForRole operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInstanceProfilesForRole.</param>
        /// 
        /// <returns>Returns a  ListInstanceProfilesForRoleResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListInstanceProfilesForRole">REST API Reference for ListInstanceProfilesForRole Operation</seealso>
        ListInstanceProfilesForRoleResponse EndListInstanceProfilesForRole(IAsyncResult asyncResult);

        #endregion
        
        #region  ListInstanceProfileTags


        /// <summary>
        /// Lists the tags that are attached to the specified IAM instance profile. The returned
        /// list of tags is sorted by tag key. For more information about tagging, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging
        /// IAM resources</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceProfileTags service method.</param>
        /// 
        /// <returns>The response from the ListInstanceProfileTags service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListInstanceProfileTags">REST API Reference for ListInstanceProfileTags Operation</seealso>
        ListInstanceProfileTagsResponse ListInstanceProfileTags(ListInstanceProfileTagsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListInstanceProfileTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceProfileTags operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInstanceProfileTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListInstanceProfileTags">REST API Reference for ListInstanceProfileTags Operation</seealso>
        IAsyncResult BeginListInstanceProfileTags(ListInstanceProfileTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListInstanceProfileTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInstanceProfileTags.</param>
        /// 
        /// <returns>Returns a  ListInstanceProfileTagsResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListInstanceProfileTags">REST API Reference for ListInstanceProfileTags Operation</seealso>
        ListInstanceProfileTagsResponse EndListInstanceProfileTags(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMFADevices


        /// <summary>
        /// Lists the MFA devices for an IAM user. If the request includes a IAM user name, then
        /// this operation lists all the MFA devices associated with the specified user. If you
        /// do not specify a user name, IAM determines the user name implicitly based on the Amazon
        /// Web Services access key ID signing the request for this operation.
        /// 
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListMFADevices service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListMFADevices">REST API Reference for ListMFADevices Operation</seealso>
        ListMFADevicesResponse ListMFADevices();

        /// <summary>
        /// Lists the MFA devices for an IAM user. If the request includes a IAM user name, then
        /// this operation lists all the MFA devices associated with the specified user. If you
        /// do not specify a user name, IAM determines the user name implicitly based on the Amazon
        /// Web Services access key ID signing the request for this operation.
        /// 
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMFADevices service method.</param>
        /// 
        /// <returns>The response from the ListMFADevices service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListMFADevices">REST API Reference for ListMFADevices Operation</seealso>
        ListMFADevicesResponse ListMFADevices(ListMFADevicesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMFADevices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMFADevices operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMFADevices
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListMFADevices">REST API Reference for ListMFADevices Operation</seealso>
        IAsyncResult BeginListMFADevices(ListMFADevicesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMFADevices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMFADevices.</param>
        /// 
        /// <returns>Returns a  ListMFADevicesResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListMFADevices">REST API Reference for ListMFADevices Operation</seealso>
        ListMFADevicesResponse EndListMFADevices(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMFADeviceTags


        /// <summary>
        /// Lists the tags that are attached to the specified IAM virtual multi-factor authentication
        /// (MFA) device. The returned list of tags is sorted by tag key. For more information
        /// about tagging, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging
        /// IAM resources</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMFADeviceTags service method.</param>
        /// 
        /// <returns>The response from the ListMFADeviceTags service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListMFADeviceTags">REST API Reference for ListMFADeviceTags Operation</seealso>
        ListMFADeviceTagsResponse ListMFADeviceTags(ListMFADeviceTagsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMFADeviceTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMFADeviceTags operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMFADeviceTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListMFADeviceTags">REST API Reference for ListMFADeviceTags Operation</seealso>
        IAsyncResult BeginListMFADeviceTags(ListMFADeviceTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMFADeviceTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMFADeviceTags.</param>
        /// 
        /// <returns>Returns a  ListMFADeviceTagsResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListMFADeviceTags">REST API Reference for ListMFADeviceTags Operation</seealso>
        ListMFADeviceTagsResponse EndListMFADeviceTags(IAsyncResult asyncResult);

        #endregion
        
        #region  ListOpenIDConnectProviders


        /// <summary>
        /// Lists information about the IAM OpenID Connect (OIDC) provider resource objects defined
        /// in the Amazon Web Services account.
        /// 
        ///  <note> 
        /// <para>
        /// IAM resource-listing operations return a subset of the available attributes for the
        /// resource. For example, this operation does not return tags, even though they are an
        /// attribute of the returned object. To view all of the information for an OIDC provider,
        /// see <a>GetOpenIDConnectProvider</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOpenIDConnectProviders service method.</param>
        /// 
        /// <returns>The response from the ListOpenIDConnectProviders service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListOpenIDConnectProviders">REST API Reference for ListOpenIDConnectProviders Operation</seealso>
        ListOpenIDConnectProvidersResponse ListOpenIDConnectProviders(ListOpenIDConnectProvidersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListOpenIDConnectProviders operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOpenIDConnectProviders operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOpenIDConnectProviders
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListOpenIDConnectProviders">REST API Reference for ListOpenIDConnectProviders Operation</seealso>
        IAsyncResult BeginListOpenIDConnectProviders(ListOpenIDConnectProvidersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListOpenIDConnectProviders operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOpenIDConnectProviders.</param>
        /// 
        /// <returns>Returns a  ListOpenIDConnectProvidersResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListOpenIDConnectProviders">REST API Reference for ListOpenIDConnectProviders Operation</seealso>
        ListOpenIDConnectProvidersResponse EndListOpenIDConnectProviders(IAsyncResult asyncResult);

        #endregion
        
        #region  ListOpenIDConnectProviderTags


        /// <summary>
        /// Lists the tags that are attached to the specified OpenID Connect (OIDC)-compatible
        /// identity provider. The returned list of tags is sorted by tag key. For more information,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_providers_oidc.html">About
        /// web identity federation</a>.
        /// 
        ///  
        /// <para>
        /// For more information about tagging, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging
        /// IAM resources</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOpenIDConnectProviderTags service method.</param>
        /// 
        /// <returns>The response from the ListOpenIDConnectProviderTags service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListOpenIDConnectProviderTags">REST API Reference for ListOpenIDConnectProviderTags Operation</seealso>
        ListOpenIDConnectProviderTagsResponse ListOpenIDConnectProviderTags(ListOpenIDConnectProviderTagsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListOpenIDConnectProviderTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOpenIDConnectProviderTags operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOpenIDConnectProviderTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListOpenIDConnectProviderTags">REST API Reference for ListOpenIDConnectProviderTags Operation</seealso>
        IAsyncResult BeginListOpenIDConnectProviderTags(ListOpenIDConnectProviderTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListOpenIDConnectProviderTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOpenIDConnectProviderTags.</param>
        /// 
        /// <returns>Returns a  ListOpenIDConnectProviderTagsResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListOpenIDConnectProviderTags">REST API Reference for ListOpenIDConnectProviderTags Operation</seealso>
        ListOpenIDConnectProviderTagsResponse EndListOpenIDConnectProviderTags(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPolicies


        /// <summary>
        /// Lists all the managed policies that are available in your Amazon Web Services account,
        /// including your own customer-defined managed policies and all Amazon Web Services managed
        /// policies.
        /// 
        ///  
        /// <para>
        /// You can filter the list of policies that is returned using the optional <code>OnlyAttached</code>,
        /// <code>Scope</code>, and <code>PathPrefix</code> parameters. For example, to list only
        /// the customer managed policies in your Amazon Web Services account, set <code>Scope</code>
        /// to <code>Local</code>. To list only Amazon Web Services managed policies, set <code>Scope</code>
        /// to <code>AWS</code>.
        /// </para>
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        ///  
        /// <para>
        /// For more information about managed policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// policies and inline policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// IAM resource-listing operations return a subset of the available attributes for the
        /// resource. For example, this operation does not return tags, even though they are an
        /// attribute of the returned object. To view all of the information for a customer manged
        /// policy, see <a>GetPolicy</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// 
        /// <returns>The response from the ListPolicies service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListPolicies">REST API Reference for ListPolicies Operation</seealso>
        ListPoliciesResponse ListPolicies();

        /// <summary>
        /// Lists all the managed policies that are available in your Amazon Web Services account,
        /// including your own customer-defined managed policies and all Amazon Web Services managed
        /// policies.
        /// 
        ///  
        /// <para>
        /// You can filter the list of policies that is returned using the optional <code>OnlyAttached</code>,
        /// <code>Scope</code>, and <code>PathPrefix</code> parameters. For example, to list only
        /// the customer managed policies in your Amazon Web Services account, set <code>Scope</code>
        /// to <code>Local</code>. To list only Amazon Web Services managed policies, set <code>Scope</code>
        /// to <code>AWS</code>.
        /// </para>
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        ///  
        /// <para>
        /// For more information about managed policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// policies and inline policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// IAM resource-listing operations return a subset of the available attributes for the
        /// resource. For example, this operation does not return tags, even though they are an
        /// attribute of the returned object. To view all of the information for a customer manged
        /// policy, see <a>GetPolicy</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicies service method.</param>
        /// 
        /// <returns>The response from the ListPolicies service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListPolicies">REST API Reference for ListPolicies Operation</seealso>
        ListPoliciesResponse ListPolicies(ListPoliciesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPolicies operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListPolicies">REST API Reference for ListPolicies Operation</seealso>
        IAsyncResult BeginListPolicies(ListPoliciesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPolicies.</param>
        /// 
        /// <returns>Returns a  ListPoliciesResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListPolicies">REST API Reference for ListPolicies Operation</seealso>
        ListPoliciesResponse EndListPolicies(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPoliciesGrantingServiceAccess


        /// <summary>
        /// Retrieves a list of policies that the IAM identity (user, group, or role) can use
        /// to access each specified service.
        /// 
        ///  <note> 
        /// <para>
        /// This operation does not use other policy types when determining whether a resource
        /// could access a service. These other policy types include resource-based policies,
        /// access control lists, Organizations policies, IAM permissions boundaries, and STS
        /// assume role policies. It only applies permissions policy logic. For more about the
        /// evaluation of policy types, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_evaluation-logic.html#policy-eval-basics">Evaluating
        /// policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The list of policies returned by the operation depends on the ARN of the identity
        /// that you provide.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>User</b> – The list of policies includes the managed and inline policies that
        /// are attached to the user directly. The list also includes any additional managed and
        /// inline policies that are attached to the group to which the user belongs. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Group</b> – The list of policies includes only the managed and inline policies
        /// that are attached to the group directly. Policies that are attached to the group’s
        /// user are not included.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Role</b> – The list of policies includes only the managed and inline policies
        /// that are attached to the role.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For each managed policy, this operation returns the ARN and policy name. For each
        /// inline policy, it returns the policy name and the entity to which it is attached.
        /// Inline policies do not have an ARN. For more information about these policy types,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_managed-vs-inline.html">Managed
        /// policies and inline policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Policies that are attached to users and roles as permissions boundaries are not returned.
        /// To view which managed policy is currently used to set the permissions boundary for
        /// a user or role, use the <a>GetUser</a> or <a>GetRole</a> operations.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPoliciesGrantingServiceAccess service method.</param>
        /// 
        /// <returns>The response from the ListPoliciesGrantingServiceAccess service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListPoliciesGrantingServiceAccess">REST API Reference for ListPoliciesGrantingServiceAccess Operation</seealso>
        ListPoliciesGrantingServiceAccessResponse ListPoliciesGrantingServiceAccess(ListPoliciesGrantingServiceAccessRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPoliciesGrantingServiceAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPoliciesGrantingServiceAccess operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPoliciesGrantingServiceAccess
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListPoliciesGrantingServiceAccess">REST API Reference for ListPoliciesGrantingServiceAccess Operation</seealso>
        IAsyncResult BeginListPoliciesGrantingServiceAccess(ListPoliciesGrantingServiceAccessRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPoliciesGrantingServiceAccess operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPoliciesGrantingServiceAccess.</param>
        /// 
        /// <returns>Returns a  ListPoliciesGrantingServiceAccessResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListPoliciesGrantingServiceAccess">REST API Reference for ListPoliciesGrantingServiceAccess Operation</seealso>
        ListPoliciesGrantingServiceAccessResponse EndListPoliciesGrantingServiceAccess(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPolicyTags


        /// <summary>
        /// Lists the tags that are attached to the specified IAM customer managed policy. The
        /// returned list of tags is sorted by tag key. For more information about tagging, see
        /// <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging IAM
        /// resources</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicyTags service method.</param>
        /// 
        /// <returns>The response from the ListPolicyTags service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListPolicyTags">REST API Reference for ListPolicyTags Operation</seealso>
        ListPolicyTagsResponse ListPolicyTags(ListPolicyTagsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPolicyTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPolicyTags operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPolicyTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListPolicyTags">REST API Reference for ListPolicyTags Operation</seealso>
        IAsyncResult BeginListPolicyTags(ListPolicyTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPolicyTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPolicyTags.</param>
        /// 
        /// <returns>Returns a  ListPolicyTagsResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListPolicyTags">REST API Reference for ListPolicyTags Operation</seealso>
        ListPolicyTagsResponse EndListPolicyTags(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPolicyVersions


        /// <summary>
        /// Lists information about the versions of the specified managed policy, including the
        /// version that is currently set as the policy's default version.
        /// 
        ///  
        /// <para>
        /// For more information about managed policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// policies and inline policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicyVersions service method.</param>
        /// 
        /// <returns>The response from the ListPolicyVersions service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListPolicyVersions">REST API Reference for ListPolicyVersions Operation</seealso>
        ListPolicyVersionsResponse ListPolicyVersions(ListPolicyVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPolicyVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPolicyVersions operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPolicyVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListPolicyVersions">REST API Reference for ListPolicyVersions Operation</seealso>
        IAsyncResult BeginListPolicyVersions(ListPolicyVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPolicyVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPolicyVersions.</param>
        /// 
        /// <returns>Returns a  ListPolicyVersionsResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListPolicyVersions">REST API Reference for ListPolicyVersions Operation</seealso>
        ListPolicyVersionsResponse EndListPolicyVersions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRolePolicies


        /// <summary>
        /// Lists the names of the inline policies that are embedded in the specified IAM role.
        /// 
        ///  
        /// <para>
        /// An IAM role can also have managed policies attached to it. To list the managed policies
        /// that are attached to a role, use <a>ListAttachedRolePolicies</a>. For more information
        /// about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// policies and inline policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters. If there are no inline policies embedded with the specified role, the
        /// operation returns an empty list.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRolePolicies service method.</param>
        /// 
        /// <returns>The response from the ListRolePolicies service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListRolePolicies">REST API Reference for ListRolePolicies Operation</seealso>
        ListRolePoliciesResponse ListRolePolicies(ListRolePoliciesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRolePolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRolePolicies operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRolePolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListRolePolicies">REST API Reference for ListRolePolicies Operation</seealso>
        IAsyncResult BeginListRolePolicies(ListRolePoliciesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRolePolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRolePolicies.</param>
        /// 
        /// <returns>Returns a  ListRolePoliciesResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListRolePolicies">REST API Reference for ListRolePolicies Operation</seealso>
        ListRolePoliciesResponse EndListRolePolicies(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRoles


        /// <summary>
        /// Lists the IAM roles that have the specified path prefix. If there are none, the operation
        /// returns an empty list. For more information about roles, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html">Working
        /// with roles</a>.
        /// 
        ///  <note> 
        /// <para>
        /// IAM resource-listing operations return a subset of the available attributes for the
        /// resource. For example, this operation does not return tags, even though they are an
        /// attribute of the returned object. To view all of the information for a role, see <a>GetRole</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListRoles service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListRoles">REST API Reference for ListRoles Operation</seealso>
        ListRolesResponse ListRoles();

        /// <summary>
        /// Lists the IAM roles that have the specified path prefix. If there are none, the operation
        /// returns an empty list. For more information about roles, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html">Working
        /// with roles</a>.
        /// 
        ///  <note> 
        /// <para>
        /// IAM resource-listing operations return a subset of the available attributes for the
        /// resource. For example, this operation does not return tags, even though they are an
        /// attribute of the returned object. To view all of the information for a role, see <a>GetRole</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRoles service method.</param>
        /// 
        /// <returns>The response from the ListRoles service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListRoles">REST API Reference for ListRoles Operation</seealso>
        ListRolesResponse ListRoles(ListRolesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRoles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRoles operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRoles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListRoles">REST API Reference for ListRoles Operation</seealso>
        IAsyncResult BeginListRoles(ListRolesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRoles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRoles.</param>
        /// 
        /// <returns>Returns a  ListRolesResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListRoles">REST API Reference for ListRoles Operation</seealso>
        ListRolesResponse EndListRoles(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRoleTags


        /// <summary>
        /// Lists the tags that are attached to the specified role. The returned list of tags
        /// is sorted by tag key. For more information about tagging, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging
        /// IAM resources</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRoleTags service method.</param>
        /// 
        /// <returns>The response from the ListRoleTags service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListRoleTags">REST API Reference for ListRoleTags Operation</seealso>
        ListRoleTagsResponse ListRoleTags(ListRoleTagsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRoleTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRoleTags operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRoleTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListRoleTags">REST API Reference for ListRoleTags Operation</seealso>
        IAsyncResult BeginListRoleTags(ListRoleTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRoleTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRoleTags.</param>
        /// 
        /// <returns>Returns a  ListRoleTagsResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListRoleTags">REST API Reference for ListRoleTags Operation</seealso>
        ListRoleTagsResponse EndListRoleTags(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSAMLProviders


        /// <summary>
        /// Lists the SAML provider resource objects defined in IAM in the account. IAM resource-listing
        /// operations return a subset of the available attributes for the resource. For example,
        /// this operation does not return tags, even though they are an attribute of the returned
        /// object. To view all of the information for a SAML provider, see <a>GetSAMLProvider</a>.
        /// 
        ///  <important> 
        /// <para>
        ///  This operation requires <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version 4</a>.
        /// </para>
        ///  </important>
        /// </summary>
        /// 
        /// <returns>The response from the ListSAMLProviders service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListSAMLProviders">REST API Reference for ListSAMLProviders Operation</seealso>
        ListSAMLProvidersResponse ListSAMLProviders();

        /// <summary>
        /// Lists the SAML provider resource objects defined in IAM in the account. IAM resource-listing
        /// operations return a subset of the available attributes for the resource. For example,
        /// this operation does not return tags, even though they are an attribute of the returned
        /// object. To view all of the information for a SAML provider, see <a>GetSAMLProvider</a>.
        /// 
        ///  <important> 
        /// <para>
        ///  This operation requires <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version 4</a>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSAMLProviders service method.</param>
        /// 
        /// <returns>The response from the ListSAMLProviders service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListSAMLProviders">REST API Reference for ListSAMLProviders Operation</seealso>
        ListSAMLProvidersResponse ListSAMLProviders(ListSAMLProvidersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSAMLProviders operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSAMLProviders operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSAMLProviders
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListSAMLProviders">REST API Reference for ListSAMLProviders Operation</seealso>
        IAsyncResult BeginListSAMLProviders(ListSAMLProvidersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSAMLProviders operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSAMLProviders.</param>
        /// 
        /// <returns>Returns a  ListSAMLProvidersResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListSAMLProviders">REST API Reference for ListSAMLProviders Operation</seealso>
        ListSAMLProvidersResponse EndListSAMLProviders(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSAMLProviderTags


        /// <summary>
        /// Lists the tags that are attached to the specified Security Assertion Markup Language
        /// (SAML) identity provider. The returned list of tags is sorted by tag key. For more
        /// information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_providers_saml.html">About
        /// SAML 2.0-based federation</a>.
        /// 
        ///  
        /// <para>
        /// For more information about tagging, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging
        /// IAM resources</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSAMLProviderTags service method.</param>
        /// 
        /// <returns>The response from the ListSAMLProviderTags service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListSAMLProviderTags">REST API Reference for ListSAMLProviderTags Operation</seealso>
        ListSAMLProviderTagsResponse ListSAMLProviderTags(ListSAMLProviderTagsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSAMLProviderTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSAMLProviderTags operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSAMLProviderTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListSAMLProviderTags">REST API Reference for ListSAMLProviderTags Operation</seealso>
        IAsyncResult BeginListSAMLProviderTags(ListSAMLProviderTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSAMLProviderTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSAMLProviderTags.</param>
        /// 
        /// <returns>Returns a  ListSAMLProviderTagsResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListSAMLProviderTags">REST API Reference for ListSAMLProviderTags Operation</seealso>
        ListSAMLProviderTagsResponse EndListSAMLProviderTags(IAsyncResult asyncResult);

        #endregion
        
        #region  ListServerCertificates


        /// <summary>
        /// Lists the server certificates stored in IAM that have the specified path prefix. If
        /// none exist, the operation returns an empty list.
        /// 
        ///  
        /// <para>
        ///  You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        ///  
        /// <para>
        /// For more information about working with server certificates, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_server-certs.html">Working
        /// with server certificates</a> in the <i>IAM User Guide</i>. This topic also includes
        /// a list of Amazon Web Services services that can use the server certificates that you
        /// manage with IAM.
        /// </para>
        ///  <note> 
        /// <para>
        /// IAM resource-listing operations return a subset of the available attributes for the
        /// resource. For example, this operation does not return tags, even though they are an
        /// attribute of the returned object. To view all of the information for a servercertificate,
        /// see <a>GetServerCertificate</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// 
        /// <returns>The response from the ListServerCertificates service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListServerCertificates">REST API Reference for ListServerCertificates Operation</seealso>
        ListServerCertificatesResponse ListServerCertificates();

        /// <summary>
        /// Lists the server certificates stored in IAM that have the specified path prefix. If
        /// none exist, the operation returns an empty list.
        /// 
        ///  
        /// <para>
        ///  You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        ///  
        /// <para>
        /// For more information about working with server certificates, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_server-certs.html">Working
        /// with server certificates</a> in the <i>IAM User Guide</i>. This topic also includes
        /// a list of Amazon Web Services services that can use the server certificates that you
        /// manage with IAM.
        /// </para>
        ///  <note> 
        /// <para>
        /// IAM resource-listing operations return a subset of the available attributes for the
        /// resource. For example, this operation does not return tags, even though they are an
        /// attribute of the returned object. To view all of the information for a servercertificate,
        /// see <a>GetServerCertificate</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServerCertificates service method.</param>
        /// 
        /// <returns>The response from the ListServerCertificates service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListServerCertificates">REST API Reference for ListServerCertificates Operation</seealso>
        ListServerCertificatesResponse ListServerCertificates(ListServerCertificatesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListServerCertificates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListServerCertificates operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListServerCertificates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListServerCertificates">REST API Reference for ListServerCertificates Operation</seealso>
        IAsyncResult BeginListServerCertificates(ListServerCertificatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListServerCertificates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListServerCertificates.</param>
        /// 
        /// <returns>Returns a  ListServerCertificatesResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListServerCertificates">REST API Reference for ListServerCertificates Operation</seealso>
        ListServerCertificatesResponse EndListServerCertificates(IAsyncResult asyncResult);

        #endregion
        
        #region  ListServerCertificateTags


        /// <summary>
        /// Lists the tags that are attached to the specified IAM server certificate. The returned
        /// list of tags is sorted by tag key. For more information about tagging, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging
        /// IAM resources</a> in the <i>IAM User Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// For certificates in a Region supported by Certificate Manager (ACM), we recommend
        /// that you don't use IAM server certificates. Instead, use ACM to provision, manage,
        /// and deploy your server certificates. For more information about IAM server certificates,
        /// <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_server-certs.html">Working
        /// with server certificates</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServerCertificateTags service method.</param>
        /// 
        /// <returns>The response from the ListServerCertificateTags service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListServerCertificateTags">REST API Reference for ListServerCertificateTags Operation</seealso>
        ListServerCertificateTagsResponse ListServerCertificateTags(ListServerCertificateTagsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListServerCertificateTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListServerCertificateTags operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListServerCertificateTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListServerCertificateTags">REST API Reference for ListServerCertificateTags Operation</seealso>
        IAsyncResult BeginListServerCertificateTags(ListServerCertificateTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListServerCertificateTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListServerCertificateTags.</param>
        /// 
        /// <returns>Returns a  ListServerCertificateTagsResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListServerCertificateTags">REST API Reference for ListServerCertificateTags Operation</seealso>
        ListServerCertificateTagsResponse EndListServerCertificateTags(IAsyncResult asyncResult);

        #endregion
        
        #region  ListServiceSpecificCredentials


        /// <summary>
        /// Returns information about the service-specific credentials associated with the specified
        /// IAM user. If none exists, the operation returns an empty list. The service-specific
        /// credentials returned by this operation are used only for authenticating the IAM user
        /// to a specific service. For more information about using service-specific credentials
        /// to authenticate to an Amazon Web Services service, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/setting-up-gc.html">Set
        /// up service-specific credentials</a> in the CodeCommit User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceSpecificCredentials service method.</param>
        /// 
        /// <returns>The response from the ListServiceSpecificCredentials service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceNotSupportedException">
        /// The specified service does not support service-specific credentials.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListServiceSpecificCredentials">REST API Reference for ListServiceSpecificCredentials Operation</seealso>
        ListServiceSpecificCredentialsResponse ListServiceSpecificCredentials(ListServiceSpecificCredentialsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListServiceSpecificCredentials operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListServiceSpecificCredentials operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListServiceSpecificCredentials
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListServiceSpecificCredentials">REST API Reference for ListServiceSpecificCredentials Operation</seealso>
        IAsyncResult BeginListServiceSpecificCredentials(ListServiceSpecificCredentialsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListServiceSpecificCredentials operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListServiceSpecificCredentials.</param>
        /// 
        /// <returns>Returns a  ListServiceSpecificCredentialsResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListServiceSpecificCredentials">REST API Reference for ListServiceSpecificCredentials Operation</seealso>
        ListServiceSpecificCredentialsResponse EndListServiceSpecificCredentials(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSigningCertificates


        /// <summary>
        /// Returns information about the signing certificates associated with the specified IAM
        /// user. If none exists, the operation returns an empty list.
        /// 
        ///  
        /// <para>
        /// Although each user is limited to a small number of signing certificates, you can still
        /// paginate the results using the <code>MaxItems</code> and <code>Marker</code> parameters.
        /// </para>
        ///  
        /// <para>
        /// If the <code>UserName</code> field is not specified, the user name is determined implicitly
        /// based on the Amazon Web Services access key ID used to sign the request for this operation.
        /// This operation works for access keys under the Amazon Web Services account. Consequently,
        /// you can use this operation to manage Amazon Web Services account root user credentials
        /// even if the Amazon Web Services account has no associated users.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListSigningCertificates service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListSigningCertificates">REST API Reference for ListSigningCertificates Operation</seealso>
        ListSigningCertificatesResponse ListSigningCertificates();

        /// <summary>
        /// Returns information about the signing certificates associated with the specified IAM
        /// user. If none exists, the operation returns an empty list.
        /// 
        ///  
        /// <para>
        /// Although each user is limited to a small number of signing certificates, you can still
        /// paginate the results using the <code>MaxItems</code> and <code>Marker</code> parameters.
        /// </para>
        ///  
        /// <para>
        /// If the <code>UserName</code> field is not specified, the user name is determined implicitly
        /// based on the Amazon Web Services access key ID used to sign the request for this operation.
        /// This operation works for access keys under the Amazon Web Services account. Consequently,
        /// you can use this operation to manage Amazon Web Services account root user credentials
        /// even if the Amazon Web Services account has no associated users.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSigningCertificates service method.</param>
        /// 
        /// <returns>The response from the ListSigningCertificates service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListSigningCertificates">REST API Reference for ListSigningCertificates Operation</seealso>
        ListSigningCertificatesResponse ListSigningCertificates(ListSigningCertificatesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSigningCertificates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSigningCertificates operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSigningCertificates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListSigningCertificates">REST API Reference for ListSigningCertificates Operation</seealso>
        IAsyncResult BeginListSigningCertificates(ListSigningCertificatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSigningCertificates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSigningCertificates.</param>
        /// 
        /// <returns>Returns a  ListSigningCertificatesResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListSigningCertificates">REST API Reference for ListSigningCertificates Operation</seealso>
        ListSigningCertificatesResponse EndListSigningCertificates(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSSHPublicKeys


        /// <summary>
        /// Returns information about the SSH public keys associated with the specified IAM user.
        /// If none exists, the operation returns an empty list.
        /// 
        ///  
        /// <para>
        /// The SSH public keys returned by this operation are used only for authenticating the
        /// IAM user to an CodeCommit repository. For more information about using SSH keys to
        /// authenticate to an CodeCommit repository, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/setting-up-credentials-ssh.html">Set
        /// up CodeCommit for SSH connections</a> in the <i>CodeCommit User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Although each user is limited to a small number of keys, you can still paginate the
        /// results using the <code>MaxItems</code> and <code>Marker</code> parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSSHPublicKeys service method.</param>
        /// 
        /// <returns>The response from the ListSSHPublicKeys service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListSSHPublicKeys">REST API Reference for ListSSHPublicKeys Operation</seealso>
        ListSSHPublicKeysResponse ListSSHPublicKeys(ListSSHPublicKeysRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSSHPublicKeys operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSSHPublicKeys operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSSHPublicKeys
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListSSHPublicKeys">REST API Reference for ListSSHPublicKeys Operation</seealso>
        IAsyncResult BeginListSSHPublicKeys(ListSSHPublicKeysRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSSHPublicKeys operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSSHPublicKeys.</param>
        /// 
        /// <returns>Returns a  ListSSHPublicKeysResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListSSHPublicKeys">REST API Reference for ListSSHPublicKeys Operation</seealso>
        ListSSHPublicKeysResponse EndListSSHPublicKeys(IAsyncResult asyncResult);

        #endregion
        
        #region  ListUserPolicies


        /// <summary>
        /// Lists the names of the inline policies embedded in the specified IAM user.
        /// 
        ///  
        /// <para>
        /// An IAM user can also have managed policies attached to it. To list the managed policies
        /// that are attached to a user, use <a>ListAttachedUserPolicies</a>. For more information
        /// about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// policies and inline policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters. If there are no inline policies embedded with the specified user, the
        /// operation returns an empty list.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUserPolicies service method.</param>
        /// 
        /// <returns>The response from the ListUserPolicies service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListUserPolicies">REST API Reference for ListUserPolicies Operation</seealso>
        ListUserPoliciesResponse ListUserPolicies(ListUserPoliciesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListUserPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUserPolicies operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListUserPolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListUserPolicies">REST API Reference for ListUserPolicies Operation</seealso>
        IAsyncResult BeginListUserPolicies(ListUserPoliciesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListUserPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUserPolicies.</param>
        /// 
        /// <returns>Returns a  ListUserPoliciesResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListUserPolicies">REST API Reference for ListUserPolicies Operation</seealso>
        ListUserPoliciesResponse EndListUserPolicies(IAsyncResult asyncResult);

        #endregion
        
        #region  ListUsers


        /// <summary>
        /// Lists the IAM users that have the specified path prefix. If no path prefix is specified,
        /// the operation returns all users in the Amazon Web Services account. If there are none,
        /// the operation returns an empty list.
        /// 
        ///  <note> 
        /// <para>
        /// IAM resource-listing operations return a subset of the available attributes for the
        /// resource. For example, this operation does not return tags, even though they are an
        /// attribute of the returned object. To view all of the information for a user, see <a>GetUser</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListUsers service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListUsers">REST API Reference for ListUsers Operation</seealso>
        ListUsersResponse ListUsers();

        /// <summary>
        /// Lists the IAM users that have the specified path prefix. If no path prefix is specified,
        /// the operation returns all users in the Amazon Web Services account. If there are none,
        /// the operation returns an empty list.
        /// 
        ///  <note> 
        /// <para>
        /// IAM resource-listing operations return a subset of the available attributes for the
        /// resource. For example, this operation does not return tags, even though they are an
        /// attribute of the returned object. To view all of the information for a user, see <a>GetUser</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsers service method.</param>
        /// 
        /// <returns>The response from the ListUsers service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListUsers">REST API Reference for ListUsers Operation</seealso>
        ListUsersResponse ListUsers(ListUsersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListUsers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUsers operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListUsers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListUsers">REST API Reference for ListUsers Operation</seealso>
        IAsyncResult BeginListUsers(ListUsersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListUsers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUsers.</param>
        /// 
        /// <returns>Returns a  ListUsersResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListUsers">REST API Reference for ListUsers Operation</seealso>
        ListUsersResponse EndListUsers(IAsyncResult asyncResult);

        #endregion
        
        #region  ListUserTags


        /// <summary>
        /// Lists the tags that are attached to the specified IAM user. The returned list of tags
        /// is sorted by tag key. For more information about tagging, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging
        /// IAM resources</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUserTags service method.</param>
        /// 
        /// <returns>The response from the ListUserTags service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListUserTags">REST API Reference for ListUserTags Operation</seealso>
        ListUserTagsResponse ListUserTags(ListUserTagsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListUserTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUserTags operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListUserTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListUserTags">REST API Reference for ListUserTags Operation</seealso>
        IAsyncResult BeginListUserTags(ListUserTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListUserTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListUserTags.</param>
        /// 
        /// <returns>Returns a  ListUserTagsResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListUserTags">REST API Reference for ListUserTags Operation</seealso>
        ListUserTagsResponse EndListUserTags(IAsyncResult asyncResult);

        #endregion
        
        #region  ListVirtualMFADevices


        /// <summary>
        /// Lists the virtual MFA devices defined in the Amazon Web Services account by assignment
        /// status. If you do not specify an assignment status, the operation returns a list of
        /// all virtual MFA devices. Assignment status can be <code>Assigned</code>, <code>Unassigned</code>,
        /// or <code>Any</code>.
        /// 
        ///  <note> 
        /// <para>
        /// IAM resource-listing operations return a subset of the available attributes for the
        /// resource. For example, this operation does not return tags, even though they are an
        /// attribute of the returned object. To view tag information for a virtual MFA device,
        /// see <a>ListMFADeviceTags</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListVirtualMFADevices service method, as returned by IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListVirtualMFADevices">REST API Reference for ListVirtualMFADevices Operation</seealso>
        ListVirtualMFADevicesResponse ListVirtualMFADevices();

        /// <summary>
        /// Lists the virtual MFA devices defined in the Amazon Web Services account by assignment
        /// status. If you do not specify an assignment status, the operation returns a list of
        /// all virtual MFA devices. Assignment status can be <code>Assigned</code>, <code>Unassigned</code>,
        /// or <code>Any</code>.
        /// 
        ///  <note> 
        /// <para>
        /// IAM resource-listing operations return a subset of the available attributes for the
        /// resource. For example, this operation does not return tags, even though they are an
        /// attribute of the returned object. To view tag information for a virtual MFA device,
        /// see <a>ListMFADeviceTags</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVirtualMFADevices service method.</param>
        /// 
        /// <returns>The response from the ListVirtualMFADevices service method, as returned by IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListVirtualMFADevices">REST API Reference for ListVirtualMFADevices Operation</seealso>
        ListVirtualMFADevicesResponse ListVirtualMFADevices(ListVirtualMFADevicesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListVirtualMFADevices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVirtualMFADevices operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVirtualMFADevices
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListVirtualMFADevices">REST API Reference for ListVirtualMFADevices Operation</seealso>
        IAsyncResult BeginListVirtualMFADevices(ListVirtualMFADevicesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListVirtualMFADevices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVirtualMFADevices.</param>
        /// 
        /// <returns>Returns a  ListVirtualMFADevicesResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListVirtualMFADevices">REST API Reference for ListVirtualMFADevices Operation</seealso>
        ListVirtualMFADevicesResponse EndListVirtualMFADevices(IAsyncResult asyncResult);

        #endregion
        
        #region  PutGroupPolicy


        /// <summary>
        /// Adds or updates an inline policy document that is embedded in the specified IAM group.
        /// 
        ///  
        /// <para>
        /// A user can also have managed policies attached to it. To attach a managed policy to
        /// a group, use <a>AttachGroupPolicy</a>. To create a new managed policy, use <a>CreatePolicy</a>.
        /// For information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// policies and inline policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For information about the maximum number of inline policies that you can embed in
        /// a group, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_iam-quotas.html">IAM
        /// and STS quotas</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Because policy documents can be large, you should use POST rather than GET when calling
        /// <code>PutGroupPolicy</code>. For general information about using the Query API with
        /// IAM, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/IAM_UsingQueryAPI.html">Making
        /// query requests</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutGroupPolicy service method.</param>
        /// 
        /// <returns>The response from the PutGroupPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message
        /// describes the specific error.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/PutGroupPolicy">REST API Reference for PutGroupPolicy Operation</seealso>
        PutGroupPolicyResponse PutGroupPolicy(PutGroupPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutGroupPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutGroupPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutGroupPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/PutGroupPolicy">REST API Reference for PutGroupPolicy Operation</seealso>
        IAsyncResult BeginPutGroupPolicy(PutGroupPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutGroupPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutGroupPolicy.</param>
        /// 
        /// <returns>Returns a  PutGroupPolicyResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/PutGroupPolicy">REST API Reference for PutGroupPolicy Operation</seealso>
        PutGroupPolicyResponse EndPutGroupPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  PutRolePermissionsBoundary


        /// <summary>
        /// Adds or updates the policy that is specified as the IAM role's permissions boundary.
        /// You can use an Amazon Web Services managed policy or a customer managed policy to
        /// set the boundary for a role. Use the boundary to control the maximum permissions that
        /// the role can have. Setting a permissions boundary is an advanced feature that can
        /// affect the permissions for the role.
        /// 
        ///  
        /// <para>
        /// You cannot set the boundary for a service-linked role. 
        /// </para>
        ///  <important> 
        /// <para>
        /// Policies used as permissions boundaries do not provide permissions. You must also
        /// attach a permissions policy to the role. To learn how the effective permissions for
        /// a role are evaluated, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_evaluation-logic.html">IAM
        /// JSON policy evaluation logic</a> in the IAM User Guide. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRolePermissionsBoundary service method.</param>
        /// 
        /// <returns>The response from the PutRolePermissionsBoundary service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.PolicyNotAttachableException">
        /// The request failed because Amazon Web Services service role policies can only be attached
        /// to the service-linked role for that service.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.UnmodifiableEntityException">
        /// The request was rejected because only the service that depends on the service-linked
        /// role can modify or delete the role on your behalf. The error message includes the
        /// name of the service that depends on this service-linked role. You must request the
        /// change through that service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/PutRolePermissionsBoundary">REST API Reference for PutRolePermissionsBoundary Operation</seealso>
        PutRolePermissionsBoundaryResponse PutRolePermissionsBoundary(PutRolePermissionsBoundaryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutRolePermissionsBoundary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutRolePermissionsBoundary operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutRolePermissionsBoundary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/PutRolePermissionsBoundary">REST API Reference for PutRolePermissionsBoundary Operation</seealso>
        IAsyncResult BeginPutRolePermissionsBoundary(PutRolePermissionsBoundaryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutRolePermissionsBoundary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutRolePermissionsBoundary.</param>
        /// 
        /// <returns>Returns a  PutRolePermissionsBoundaryResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/PutRolePermissionsBoundary">REST API Reference for PutRolePermissionsBoundary Operation</seealso>
        PutRolePermissionsBoundaryResponse EndPutRolePermissionsBoundary(IAsyncResult asyncResult);

        #endregion
        
        #region  PutRolePolicy


        /// <summary>
        /// Adds or updates an inline policy document that is embedded in the specified IAM role.
        /// 
        ///  
        /// <para>
        /// When you embed an inline policy in a role, the inline policy is used as part of the
        /// role's access (permissions) policy. The role's trust policy is created at the same
        /// time as the role, using <a>CreateRole</a>. You can update a role's trust policy using
        /// <a>UpdateAssumeRolePolicy</a>. For more information about IAM roles, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/roles-toplevel.html">Using
        /// roles to delegate permissions and federate identities</a>.
        /// </para>
        ///  
        /// <para>
        /// A role can also have a managed policy attached to it. To attach a managed policy to
        /// a role, use <a>AttachRolePolicy</a>. To create a new managed policy, use <a>CreatePolicy</a>.
        /// For information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// policies and inline policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For information about the maximum number of inline policies that you can embed with
        /// a role, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_iam-quotas.html">IAM
        /// and STS quotas</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Because policy documents can be large, you should use POST rather than GET when calling
        /// <code>PutRolePolicy</code>. For general information about using the Query API with
        /// IAM, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/IAM_UsingQueryAPI.html">Making
        /// query requests</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRolePolicy service method.</param>
        /// 
        /// <returns>The response from the PutRolePolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message
        /// describes the specific error.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.UnmodifiableEntityException">
        /// The request was rejected because only the service that depends on the service-linked
        /// role can modify or delete the role on your behalf. The error message includes the
        /// name of the service that depends on this service-linked role. You must request the
        /// change through that service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/PutRolePolicy">REST API Reference for PutRolePolicy Operation</seealso>
        PutRolePolicyResponse PutRolePolicy(PutRolePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutRolePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutRolePolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutRolePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/PutRolePolicy">REST API Reference for PutRolePolicy Operation</seealso>
        IAsyncResult BeginPutRolePolicy(PutRolePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutRolePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutRolePolicy.</param>
        /// 
        /// <returns>Returns a  PutRolePolicyResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/PutRolePolicy">REST API Reference for PutRolePolicy Operation</seealso>
        PutRolePolicyResponse EndPutRolePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  PutUserPermissionsBoundary


        /// <summary>
        /// Adds or updates the policy that is specified as the IAM user's permissions boundary.
        /// You can use an Amazon Web Services managed policy or a customer managed policy to
        /// set the boundary for a user. Use the boundary to control the maximum permissions that
        /// the user can have. Setting a permissions boundary is an advanced feature that can
        /// affect the permissions for the user.
        /// 
        ///  <important> 
        /// <para>
        /// Policies that are used as permissions boundaries do not provide permissions. You must
        /// also attach a permissions policy to the user. To learn how the effective permissions
        /// for a user are evaluated, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_evaluation-logic.html">IAM
        /// JSON policy evaluation logic</a> in the IAM User Guide. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutUserPermissionsBoundary service method.</param>
        /// 
        /// <returns>The response from the PutUserPermissionsBoundary service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.PolicyNotAttachableException">
        /// The request failed because Amazon Web Services service role policies can only be attached
        /// to the service-linked role for that service.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/PutUserPermissionsBoundary">REST API Reference for PutUserPermissionsBoundary Operation</seealso>
        PutUserPermissionsBoundaryResponse PutUserPermissionsBoundary(PutUserPermissionsBoundaryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutUserPermissionsBoundary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutUserPermissionsBoundary operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutUserPermissionsBoundary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/PutUserPermissionsBoundary">REST API Reference for PutUserPermissionsBoundary Operation</seealso>
        IAsyncResult BeginPutUserPermissionsBoundary(PutUserPermissionsBoundaryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutUserPermissionsBoundary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutUserPermissionsBoundary.</param>
        /// 
        /// <returns>Returns a  PutUserPermissionsBoundaryResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/PutUserPermissionsBoundary">REST API Reference for PutUserPermissionsBoundary Operation</seealso>
        PutUserPermissionsBoundaryResponse EndPutUserPermissionsBoundary(IAsyncResult asyncResult);

        #endregion
        
        #region  PutUserPolicy


        /// <summary>
        /// Adds or updates an inline policy document that is embedded in the specified IAM user.
        /// 
        ///  
        /// <para>
        /// An IAM user can also have a managed policy attached to it. To attach a managed policy
        /// to a user, use <a>AttachUserPolicy</a>. To create a new managed policy, use <a>CreatePolicy</a>.
        /// For information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// policies and inline policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For information about the maximum number of inline policies that you can embed in
        /// a user, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_iam-quotas.html">IAM
        /// and STS quotas</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Because policy documents can be large, you should use POST rather than GET when calling
        /// <code>PutUserPolicy</code>. For general information about using the Query API with
        /// IAM, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/IAM_UsingQueryAPI.html">Making
        /// query requests</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutUserPolicy service method.</param>
        /// 
        /// <returns>The response from the PutUserPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message
        /// describes the specific error.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/PutUserPolicy">REST API Reference for PutUserPolicy Operation</seealso>
        PutUserPolicyResponse PutUserPolicy(PutUserPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutUserPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutUserPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutUserPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/PutUserPolicy">REST API Reference for PutUserPolicy Operation</seealso>
        IAsyncResult BeginPutUserPolicy(PutUserPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutUserPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutUserPolicy.</param>
        /// 
        /// <returns>Returns a  PutUserPolicyResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/PutUserPolicy">REST API Reference for PutUserPolicy Operation</seealso>
        PutUserPolicyResponse EndPutUserPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  RemoveClientIDFromOpenIDConnectProvider


        /// <summary>
        /// Removes the specified client ID (also known as audience) from the list of client IDs
        /// registered for the specified IAM OpenID Connect (OIDC) provider resource object.
        /// 
        ///  
        /// <para>
        /// This operation is idempotent; it does not fail or return an error if you try to remove
        /// a client ID that does not exist.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveClientIDFromOpenIDConnectProvider service method.</param>
        /// 
        /// <returns>The response from the RemoveClientIDFromOpenIDConnectProvider service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/RemoveClientIDFromOpenIDConnectProvider">REST API Reference for RemoveClientIDFromOpenIDConnectProvider Operation</seealso>
        RemoveClientIDFromOpenIDConnectProviderResponse RemoveClientIDFromOpenIDConnectProvider(RemoveClientIDFromOpenIDConnectProviderRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveClientIDFromOpenIDConnectProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveClientIDFromOpenIDConnectProvider operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveClientIDFromOpenIDConnectProvider
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/RemoveClientIDFromOpenIDConnectProvider">REST API Reference for RemoveClientIDFromOpenIDConnectProvider Operation</seealso>
        IAsyncResult BeginRemoveClientIDFromOpenIDConnectProvider(RemoveClientIDFromOpenIDConnectProviderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveClientIDFromOpenIDConnectProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveClientIDFromOpenIDConnectProvider.</param>
        /// 
        /// <returns>Returns a  RemoveClientIDFromOpenIDConnectProviderResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/RemoveClientIDFromOpenIDConnectProvider">REST API Reference for RemoveClientIDFromOpenIDConnectProvider Operation</seealso>
        RemoveClientIDFromOpenIDConnectProviderResponse EndRemoveClientIDFromOpenIDConnectProvider(IAsyncResult asyncResult);

        #endregion
        
        #region  RemoveRoleFromInstanceProfile


        /// <summary>
        /// Removes the specified IAM role from the specified EC2 instance profile.
        /// 
        ///  <important> 
        /// <para>
        /// Make sure that you do not have any Amazon EC2 instances running with the role you
        /// are about to remove from the instance profile. Removing a role from an instance profile
        /// that is associated with a running instance might break any applications running on
        /// the instance.
        /// </para>
        ///  </important> 
        /// <para>
        ///  For more information about IAM roles, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html">Working
        /// with roles</a>. For more information about instance profiles, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/AboutInstanceProfiles.html">About
        /// instance profiles</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveRoleFromInstanceProfile service method.</param>
        /// 
        /// <returns>The response from the RemoveRoleFromInstanceProfile service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.UnmodifiableEntityException">
        /// The request was rejected because only the service that depends on the service-linked
        /// role can modify or delete the role on your behalf. The error message includes the
        /// name of the service that depends on this service-linked role. You must request the
        /// change through that service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/RemoveRoleFromInstanceProfile">REST API Reference for RemoveRoleFromInstanceProfile Operation</seealso>
        RemoveRoleFromInstanceProfileResponse RemoveRoleFromInstanceProfile(RemoveRoleFromInstanceProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveRoleFromInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveRoleFromInstanceProfile operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveRoleFromInstanceProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/RemoveRoleFromInstanceProfile">REST API Reference for RemoveRoleFromInstanceProfile Operation</seealso>
        IAsyncResult BeginRemoveRoleFromInstanceProfile(RemoveRoleFromInstanceProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveRoleFromInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveRoleFromInstanceProfile.</param>
        /// 
        /// <returns>Returns a  RemoveRoleFromInstanceProfileResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/RemoveRoleFromInstanceProfile">REST API Reference for RemoveRoleFromInstanceProfile Operation</seealso>
        RemoveRoleFromInstanceProfileResponse EndRemoveRoleFromInstanceProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  RemoveUserFromGroup


        /// <summary>
        /// Removes the specified user from the specified group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveUserFromGroup service method.</param>
        /// 
        /// <returns>The response from the RemoveUserFromGroup service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/RemoveUserFromGroup">REST API Reference for RemoveUserFromGroup Operation</seealso>
        RemoveUserFromGroupResponse RemoveUserFromGroup(RemoveUserFromGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveUserFromGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveUserFromGroup operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveUserFromGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/RemoveUserFromGroup">REST API Reference for RemoveUserFromGroup Operation</seealso>
        IAsyncResult BeginRemoveUserFromGroup(RemoveUserFromGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveUserFromGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveUserFromGroup.</param>
        /// 
        /// <returns>Returns a  RemoveUserFromGroupResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/RemoveUserFromGroup">REST API Reference for RemoveUserFromGroup Operation</seealso>
        RemoveUserFromGroupResponse EndRemoveUserFromGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  ResetServiceSpecificCredential


        /// <summary>
        /// Resets the password for a service-specific credential. The new password is Amazon
        /// Web Services generated and cryptographically strong. It cannot be configured by the
        /// user. Resetting the password immediately invalidates the previous password associated
        /// with this user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetServiceSpecificCredential service method.</param>
        /// 
        /// <returns>The response from the ResetServiceSpecificCredential service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ResetServiceSpecificCredential">REST API Reference for ResetServiceSpecificCredential Operation</seealso>
        ResetServiceSpecificCredentialResponse ResetServiceSpecificCredential(ResetServiceSpecificCredentialRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ResetServiceSpecificCredential operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetServiceSpecificCredential operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResetServiceSpecificCredential
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ResetServiceSpecificCredential">REST API Reference for ResetServiceSpecificCredential Operation</seealso>
        IAsyncResult BeginResetServiceSpecificCredential(ResetServiceSpecificCredentialRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ResetServiceSpecificCredential operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetServiceSpecificCredential.</param>
        /// 
        /// <returns>Returns a  ResetServiceSpecificCredentialResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ResetServiceSpecificCredential">REST API Reference for ResetServiceSpecificCredential Operation</seealso>
        ResetServiceSpecificCredentialResponse EndResetServiceSpecificCredential(IAsyncResult asyncResult);

        #endregion
        
        #region  ResyncMFADevice


        /// <summary>
        /// Synchronizes the specified MFA device with its IAM resource object on the Amazon Web
        /// Services servers.
        /// 
        ///  
        /// <para>
        /// For more information about creating and working with virtual MFA devices, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_VirtualMFA.html">Using
        /// a virtual MFA device</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResyncMFADevice service method.</param>
        /// 
        /// <returns>The response from the ResyncMFADevice service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidAuthenticationCodeException">
        /// The request was rejected because the authentication code was not recognized. The error
        /// message describes the specific error.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ResyncMFADevice">REST API Reference for ResyncMFADevice Operation</seealso>
        ResyncMFADeviceResponse ResyncMFADevice(ResyncMFADeviceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ResyncMFADevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResyncMFADevice operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResyncMFADevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ResyncMFADevice">REST API Reference for ResyncMFADevice Operation</seealso>
        IAsyncResult BeginResyncMFADevice(ResyncMFADeviceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ResyncMFADevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResyncMFADevice.</param>
        /// 
        /// <returns>Returns a  ResyncMFADeviceResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ResyncMFADevice">REST API Reference for ResyncMFADevice Operation</seealso>
        ResyncMFADeviceResponse EndResyncMFADevice(IAsyncResult asyncResult);

        #endregion
        
        #region  SetDefaultPolicyVersion


        /// <summary>
        /// Sets the specified version of the specified policy as the policy's default (operative)
        /// version.
        /// 
        ///  
        /// <para>
        /// This operation affects all users, groups, and roles that the policy is attached to.
        /// To list the users, groups, and roles that the policy is attached to, use <a>ListEntitiesForPolicy</a>.
        /// </para>
        ///  
        /// <para>
        /// For information about managed policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// policies and inline policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetDefaultPolicyVersion service method.</param>
        /// 
        /// <returns>The response from the SetDefaultPolicyVersion service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/SetDefaultPolicyVersion">REST API Reference for SetDefaultPolicyVersion Operation</seealso>
        SetDefaultPolicyVersionResponse SetDefaultPolicyVersion(SetDefaultPolicyVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SetDefaultPolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetDefaultPolicyVersion operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetDefaultPolicyVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/SetDefaultPolicyVersion">REST API Reference for SetDefaultPolicyVersion Operation</seealso>
        IAsyncResult BeginSetDefaultPolicyVersion(SetDefaultPolicyVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SetDefaultPolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetDefaultPolicyVersion.</param>
        /// 
        /// <returns>Returns a  SetDefaultPolicyVersionResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/SetDefaultPolicyVersion">REST API Reference for SetDefaultPolicyVersion Operation</seealso>
        SetDefaultPolicyVersionResponse EndSetDefaultPolicyVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  SetSecurityTokenServicePreferences


        /// <summary>
        /// Sets the specified version of the global endpoint token as the token version used
        /// for the Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// By default, Security Token Service (STS) is available as a global service, and all
        /// STS requests go to a single endpoint at <code>https://sts.amazonaws.com</code>. Amazon
        /// Web Services recommends using Regional STS endpoints to reduce latency, build in redundancy,
        /// and increase session token availability. For information about Regional endpoints
        /// for STS, see <a href="https://docs.aws.amazon.com/general/latest/gr/sts.html">Security
        /// Token Service endpoints and quotas</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        ///  
        /// <para>
        /// If you make an STS call to the global endpoint, the resulting session tokens might
        /// be valid in some Regions but not others. It depends on the version that is set in
        /// this operation. Version 1 tokens are valid only in Amazon Web Services Regions that
        /// are available by default. These tokens do not work in manually enabled Regions, such
        /// as Asia Pacific (Hong Kong). Version 2 tokens are valid in all Regions. However, version
        /// 2 tokens are longer and might affect systems where you temporarily store tokens. For
        /// information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_enable-regions.html">Activating
        /// and deactivating STS in an Amazon Web Services Region</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To view the current session token version, see the <code>GlobalEndpointTokenVersion</code>
        /// entry in the response of the <a>GetAccountSummary</a> operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetSecurityTokenServicePreferences service method.</param>
        /// 
        /// <returns>The response from the SetSecurityTokenServicePreferences service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/SetSecurityTokenServicePreferences">REST API Reference for SetSecurityTokenServicePreferences Operation</seealso>
        SetSecurityTokenServicePreferencesResponse SetSecurityTokenServicePreferences(SetSecurityTokenServicePreferencesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SetSecurityTokenServicePreferences operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetSecurityTokenServicePreferences operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetSecurityTokenServicePreferences
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/SetSecurityTokenServicePreferences">REST API Reference for SetSecurityTokenServicePreferences Operation</seealso>
        IAsyncResult BeginSetSecurityTokenServicePreferences(SetSecurityTokenServicePreferencesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SetSecurityTokenServicePreferences operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetSecurityTokenServicePreferences.</param>
        /// 
        /// <returns>Returns a  SetSecurityTokenServicePreferencesResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/SetSecurityTokenServicePreferences">REST API Reference for SetSecurityTokenServicePreferences Operation</seealso>
        SetSecurityTokenServicePreferencesResponse EndSetSecurityTokenServicePreferences(IAsyncResult asyncResult);

        #endregion
        
        #region  SimulateCustomPolicy


        /// <summary>
        /// Simulate how a set of IAM policies and optionally a resource-based policy works with
        /// a list of API operations and Amazon Web Services resources to determine the policies'
        /// effective permissions. The policies are provided as strings.
        /// 
        ///  
        /// <para>
        /// The simulation does not perform the API operations; it only checks the authorization
        /// to determine if the simulated policies allow or deny the operations. You can simulate
        /// resources that don't exist in your account.
        /// </para>
        ///  
        /// <para>
        /// If you want to simulate existing policies that are attached to an IAM user, group,
        /// or role, use <a>SimulatePrincipalPolicy</a> instead.
        /// </para>
        ///  
        /// <para>
        /// Context keys are variables that are maintained by Amazon Web Services and its services
        /// and which provide details about the context of an API query request. You can use the
        /// <code>Condition</code> element of an IAM policy to evaluate context keys. To get the
        /// list of context keys that the policies require for correct simulation, use <a>GetContextKeysForCustomPolicy</a>.
        /// </para>
        ///  
        /// <para>
        /// If the output is long, you can use <code>MaxItems</code> and <code>Marker</code> parameters
        /// to paginate the results.
        /// </para>
        ///  <note> 
        /// <para>
        /// The IAM policy simulator evaluates statements in the identity-based policy and the
        /// inputs that you provide during simulation. The policy simulator results can differ
        /// from your live Amazon Web Services environment. We recommend that you check your policies
        /// against your live Amazon Web Services environment after testing using the policy simulator
        /// to confirm that you have the desired results. For more information about using the
        /// policy simulator, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_testing-policies.html">Testing
        /// IAM policies with the IAM policy simulator </a>in the <i>IAM User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SimulateCustomPolicy service method.</param>
        /// 
        /// <returns>The response from the SimulateCustomPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.PolicyEvaluationException">
        /// The request failed because a provided policy could not be successfully evaluated.
        /// An additional detailed message indicates the source of the failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/SimulateCustomPolicy">REST API Reference for SimulateCustomPolicy Operation</seealso>
        SimulateCustomPolicyResponse SimulateCustomPolicy(SimulateCustomPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SimulateCustomPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SimulateCustomPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSimulateCustomPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/SimulateCustomPolicy">REST API Reference for SimulateCustomPolicy Operation</seealso>
        IAsyncResult BeginSimulateCustomPolicy(SimulateCustomPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SimulateCustomPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSimulateCustomPolicy.</param>
        /// 
        /// <returns>Returns a  SimulateCustomPolicyResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/SimulateCustomPolicy">REST API Reference for SimulateCustomPolicy Operation</seealso>
        SimulateCustomPolicyResponse EndSimulateCustomPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  SimulatePrincipalPolicy


        /// <summary>
        /// Simulate how a set of IAM policies attached to an IAM entity works with a list of
        /// API operations and Amazon Web Services resources to determine the policies' effective
        /// permissions. The entity can be an IAM user, group, or role. If you specify a user,
        /// then the simulation also includes all of the policies that are attached to groups
        /// that the user belongs to. You can simulate resources that don't exist in your account.
        /// 
        ///  
        /// <para>
        /// You can optionally include a list of one or more additional policies specified as
        /// strings to include in the simulation. If you want to simulate only policies specified
        /// as strings, use <a>SimulateCustomPolicy</a> instead.
        /// </para>
        ///  
        /// <para>
        /// You can also optionally include one resource-based policy to be evaluated with each
        /// of the resources included in the simulation for IAM users only.
        /// </para>
        ///  
        /// <para>
        /// The simulation does not perform the API operations; it only checks the authorization
        /// to determine if the simulated policies allow or deny the operations.
        /// </para>
        ///  
        /// <para>
        ///  <b>Note:</b> This operation discloses information about the permissions granted to
        /// other users. If you do not want users to see other user's permissions, then consider
        /// allowing them to use <a>SimulateCustomPolicy</a> instead.
        /// </para>
        ///  
        /// <para>
        /// Context keys are variables maintained by Amazon Web Services and its services that
        /// provide details about the context of an API query request. You can use the <code>Condition</code>
        /// element of an IAM policy to evaluate context keys. To get the list of context keys
        /// that the policies require for correct simulation, use <a>GetContextKeysForPrincipalPolicy</a>.
        /// </para>
        ///  
        /// <para>
        /// If the output is long, you can use the <code>MaxItems</code> and <code>Marker</code>
        /// parameters to paginate the results.
        /// </para>
        ///  <note> 
        /// <para>
        /// The IAM policy simulator evaluates statements in the identity-based policy and the
        /// inputs that you provide during simulation. The policy simulator results can differ
        /// from your live Amazon Web Services environment. We recommend that you check your policies
        /// against your live Amazon Web Services environment after testing using the policy simulator
        /// to confirm that you have the desired results. For more information about using the
        /// policy simulator, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_testing-policies.html">Testing
        /// IAM policies with the IAM policy simulator </a>in the <i>IAM User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SimulatePrincipalPolicy service method.</param>
        /// 
        /// <returns>The response from the SimulatePrincipalPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.PolicyEvaluationException">
        /// The request failed because a provided policy could not be successfully evaluated.
        /// An additional detailed message indicates the source of the failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/SimulatePrincipalPolicy">REST API Reference for SimulatePrincipalPolicy Operation</seealso>
        SimulatePrincipalPolicyResponse SimulatePrincipalPolicy(SimulatePrincipalPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SimulatePrincipalPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SimulatePrincipalPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSimulatePrincipalPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/SimulatePrincipalPolicy">REST API Reference for SimulatePrincipalPolicy Operation</seealso>
        IAsyncResult BeginSimulatePrincipalPolicy(SimulatePrincipalPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SimulatePrincipalPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSimulatePrincipalPolicy.</param>
        /// 
        /// <returns>Returns a  SimulatePrincipalPolicyResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/SimulatePrincipalPolicy">REST API Reference for SimulatePrincipalPolicy Operation</seealso>
        SimulatePrincipalPolicyResponse EndSimulatePrincipalPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  TagInstanceProfile


        /// <summary>
        /// Adds one or more tags to an IAM instance profile. If a tag with the same key name
        /// already exists, then that tag is overwritten with the new value.
        /// 
        ///  
        /// <para>
        /// Each tag consists of a key name and an associated value. By assigning tags to your
        /// resources, you can do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Administrative grouping and discovery</b> - Attach tags to resources to aid in
        /// organization and search. For example, you could search for all resources with the
        /// key name <i>Project</i> and the value <i>MyImportantProject</i>. Or search for all
        /// resources with the key name <i>Cost Center</i> and the value <i>41200</i>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Access control</b> - Include tags in IAM user-based and resource-based policies.
        /// You can use tags to restrict access to only an IAM instance profile that has a specified
        /// tag attached. For examples of policies that show how to use tags to control access,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_tags.html">Control
        /// access using IAM tags</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </li> </ul> <note> <ul> <li> 
        /// <para>
        /// If any one of the tags is invalid or if you exceed the allowed maximum number of tags,
        /// then the entire request fails and the resource is not created. For more information
        /// about tagging, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging
        /// IAM resources</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services always interprets the tag <code>Value</code> as a single string.
        /// If you need to store an array, you can store comma-separated values in the string.
        /// However, you must interpret the value in your code.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagInstanceProfile service method.</param>
        /// 
        /// <returns>The response from the TagInstanceProfile service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ConcurrentModificationException">
        /// The request was rejected because multiple requests to change this object were submitted
        /// simultaneously. Wait a few minutes and submit your request again.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/TagInstanceProfile">REST API Reference for TagInstanceProfile Operation</seealso>
        TagInstanceProfileResponse TagInstanceProfile(TagInstanceProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagInstanceProfile operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagInstanceProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/TagInstanceProfile">REST API Reference for TagInstanceProfile Operation</seealso>
        IAsyncResult BeginTagInstanceProfile(TagInstanceProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagInstanceProfile.</param>
        /// 
        /// <returns>Returns a  TagInstanceProfileResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/TagInstanceProfile">REST API Reference for TagInstanceProfile Operation</seealso>
        TagInstanceProfileResponse EndTagInstanceProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  TagMFADevice


        /// <summary>
        /// Adds one or more tags to an IAM virtual multi-factor authentication (MFA) device.
        /// If a tag with the same key name already exists, then that tag is overwritten with
        /// the new value.
        /// 
        ///  
        /// <para>
        /// A tag consists of a key name and an associated value. By assigning tags to your resources,
        /// you can do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Administrative grouping and discovery</b> - Attach tags to resources to aid in
        /// organization and search. For example, you could search for all resources with the
        /// key name <i>Project</i> and the value <i>MyImportantProject</i>. Or search for all
        /// resources with the key name <i>Cost Center</i> and the value <i>41200</i>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Access control</b> - Include tags in IAM user-based and resource-based policies.
        /// You can use tags to restrict access to only an IAM virtual MFA device that has a specified
        /// tag attached. For examples of policies that show how to use tags to control access,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_tags.html">Control
        /// access using IAM tags</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </li> </ul> <note> <ul> <li> 
        /// <para>
        /// If any one of the tags is invalid or if you exceed the allowed maximum number of tags,
        /// then the entire request fails and the resource is not created. For more information
        /// about tagging, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging
        /// IAM resources</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services always interprets the tag <code>Value</code> as a single string.
        /// If you need to store an array, you can store comma-separated values in the string.
        /// However, you must interpret the value in your code.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagMFADevice service method.</param>
        /// 
        /// <returns>The response from the TagMFADevice service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ConcurrentModificationException">
        /// The request was rejected because multiple requests to change this object were submitted
        /// simultaneously. Wait a few minutes and submit your request again.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/TagMFADevice">REST API Reference for TagMFADevice Operation</seealso>
        TagMFADeviceResponse TagMFADevice(TagMFADeviceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagMFADevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagMFADevice operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagMFADevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/TagMFADevice">REST API Reference for TagMFADevice Operation</seealso>
        IAsyncResult BeginTagMFADevice(TagMFADeviceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagMFADevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagMFADevice.</param>
        /// 
        /// <returns>Returns a  TagMFADeviceResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/TagMFADevice">REST API Reference for TagMFADevice Operation</seealso>
        TagMFADeviceResponse EndTagMFADevice(IAsyncResult asyncResult);

        #endregion
        
        #region  TagOpenIDConnectProvider


        /// <summary>
        /// Adds one or more tags to an OpenID Connect (OIDC)-compatible identity provider. For
        /// more information about these providers, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_providers_oidc.html">About
        /// web identity federation</a>. If a tag with the same key name already exists, then
        /// that tag is overwritten with the new value.
        /// 
        ///  
        /// <para>
        /// A tag consists of a key name and an associated value. By assigning tags to your resources,
        /// you can do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Administrative grouping and discovery</b> - Attach tags to resources to aid in
        /// organization and search. For example, you could search for all resources with the
        /// key name <i>Project</i> and the value <i>MyImportantProject</i>. Or search for all
        /// resources with the key name <i>Cost Center</i> and the value <i>41200</i>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Access control</b> - Include tags in IAM user-based and resource-based policies.
        /// You can use tags to restrict access to only an OIDC provider that has a specified
        /// tag attached. For examples of policies that show how to use tags to control access,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_tags.html">Control
        /// access using IAM tags</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </li> </ul> <note> <ul> <li> 
        /// <para>
        /// If any one of the tags is invalid or if you exceed the allowed maximum number of tags,
        /// then the entire request fails and the resource is not created. For more information
        /// about tagging, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging
        /// IAM resources</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services always interprets the tag <code>Value</code> as a single string.
        /// If you need to store an array, you can store comma-separated values in the string.
        /// However, you must interpret the value in your code.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagOpenIDConnectProvider service method.</param>
        /// 
        /// <returns>The response from the TagOpenIDConnectProvider service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ConcurrentModificationException">
        /// The request was rejected because multiple requests to change this object were submitted
        /// simultaneously. Wait a few minutes and submit your request again.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/TagOpenIDConnectProvider">REST API Reference for TagOpenIDConnectProvider Operation</seealso>
        TagOpenIDConnectProviderResponse TagOpenIDConnectProvider(TagOpenIDConnectProviderRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagOpenIDConnectProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagOpenIDConnectProvider operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagOpenIDConnectProvider
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/TagOpenIDConnectProvider">REST API Reference for TagOpenIDConnectProvider Operation</seealso>
        IAsyncResult BeginTagOpenIDConnectProvider(TagOpenIDConnectProviderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagOpenIDConnectProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagOpenIDConnectProvider.</param>
        /// 
        /// <returns>Returns a  TagOpenIDConnectProviderResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/TagOpenIDConnectProvider">REST API Reference for TagOpenIDConnectProvider Operation</seealso>
        TagOpenIDConnectProviderResponse EndTagOpenIDConnectProvider(IAsyncResult asyncResult);

        #endregion
        
        #region  TagPolicy


        /// <summary>
        /// Adds one or more tags to an IAM customer managed policy. If a tag with the same key
        /// name already exists, then that tag is overwritten with the new value.
        /// 
        ///  
        /// <para>
        /// A tag consists of a key name and an associated value. By assigning tags to your resources,
        /// you can do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Administrative grouping and discovery</b> - Attach tags to resources to aid in
        /// organization and search. For example, you could search for all resources with the
        /// key name <i>Project</i> and the value <i>MyImportantProject</i>. Or search for all
        /// resources with the key name <i>Cost Center</i> and the value <i>41200</i>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Access control</b> - Include tags in IAM user-based and resource-based policies.
        /// You can use tags to restrict access to only an IAM customer managed policy that has
        /// a specified tag attached. For examples of policies that show how to use tags to control
        /// access, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_tags.html">Control
        /// access using IAM tags</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </li> </ul> <note> <ul> <li> 
        /// <para>
        /// If any one of the tags is invalid or if you exceed the allowed maximum number of tags,
        /// then the entire request fails and the resource is not created. For more information
        /// about tagging, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging
        /// IAM resources</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services always interprets the tag <code>Value</code> as a single string.
        /// If you need to store an array, you can store comma-separated values in the string.
        /// However, you must interpret the value in your code.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagPolicy service method.</param>
        /// 
        /// <returns>The response from the TagPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ConcurrentModificationException">
        /// The request was rejected because multiple requests to change this object were submitted
        /// simultaneously. Wait a few minutes and submit your request again.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/TagPolicy">REST API Reference for TagPolicy Operation</seealso>
        TagPolicyResponse TagPolicy(TagPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/TagPolicy">REST API Reference for TagPolicy Operation</seealso>
        IAsyncResult BeginTagPolicy(TagPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagPolicy.</param>
        /// 
        /// <returns>Returns a  TagPolicyResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/TagPolicy">REST API Reference for TagPolicy Operation</seealso>
        TagPolicyResponse EndTagPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  TagRole


        /// <summary>
        /// Adds one or more tags to an IAM role. The role can be a regular role or a service-linked
        /// role. If a tag with the same key name already exists, then that tag is overwritten
        /// with the new value.
        /// 
        ///  
        /// <para>
        /// A tag consists of a key name and an associated value. By assigning tags to your resources,
        /// you can do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Administrative grouping and discovery</b> - Attach tags to resources to aid in
        /// organization and search. For example, you could search for all resources with the
        /// key name <i>Project</i> and the value <i>MyImportantProject</i>. Or search for all
        /// resources with the key name <i>Cost Center</i> and the value <i>41200</i>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Access control</b> - Include tags in IAM user-based and resource-based policies.
        /// You can use tags to restrict access to only an IAM role that has a specified tag attached.
        /// You can also restrict access to only those resources that have a certain tag attached.
        /// For examples of policies that show how to use tags to control access, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_tags.html">Control
        /// access using IAM tags</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Cost allocation</b> - Use tags to help track which individuals and teams are using
        /// which Amazon Web Services resources.
        /// </para>
        ///  </li> </ul> <note> <ul> <li> 
        /// <para>
        /// If any one of the tags is invalid or if you exceed the allowed maximum number of tags,
        /// then the entire request fails and the resource is not created. For more information
        /// about tagging, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging
        /// IAM resources</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services always interprets the tag <code>Value</code> as a single string.
        /// If you need to store an array, you can store comma-separated values in the string.
        /// However, you must interpret the value in your code.
        /// </para>
        ///  </li> </ul> </note> 
        /// <para>
        /// For more information about tagging, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging
        /// IAM identities</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagRole service method.</param>
        /// 
        /// <returns>The response from the TagRole service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ConcurrentModificationException">
        /// The request was rejected because multiple requests to change this object were submitted
        /// simultaneously. Wait a few minutes and submit your request again.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/TagRole">REST API Reference for TagRole Operation</seealso>
        TagRoleResponse TagRole(TagRoleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagRole operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagRole
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/TagRole">REST API Reference for TagRole Operation</seealso>
        IAsyncResult BeginTagRole(TagRoleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagRole operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagRole.</param>
        /// 
        /// <returns>Returns a  TagRoleResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/TagRole">REST API Reference for TagRole Operation</seealso>
        TagRoleResponse EndTagRole(IAsyncResult asyncResult);

        #endregion
        
        #region  TagSAMLProvider


        /// <summary>
        /// Adds one or more tags to a Security Assertion Markup Language (SAML) identity provider.
        /// For more information about these providers, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_providers_saml.html">About
        /// SAML 2.0-based federation </a>. If a tag with the same key name already exists, then
        /// that tag is overwritten with the new value.
        /// 
        ///  
        /// <para>
        /// A tag consists of a key name and an associated value. By assigning tags to your resources,
        /// you can do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Administrative grouping and discovery</b> - Attach tags to resources to aid in
        /// organization and search. For example, you could search for all resources with the
        /// key name <i>Project</i> and the value <i>MyImportantProject</i>. Or search for all
        /// resources with the key name <i>Cost Center</i> and the value <i>41200</i>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Access control</b> - Include tags in IAM user-based and resource-based policies.
        /// You can use tags to restrict access to only a SAML identity provider that has a specified
        /// tag attached. For examples of policies that show how to use tags to control access,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_tags.html">Control
        /// access using IAM tags</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </li> </ul> <note> <ul> <li> 
        /// <para>
        /// If any one of the tags is invalid or if you exceed the allowed maximum number of tags,
        /// then the entire request fails and the resource is not created. For more information
        /// about tagging, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging
        /// IAM resources</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services always interprets the tag <code>Value</code> as a single string.
        /// If you need to store an array, you can store comma-separated values in the string.
        /// However, you must interpret the value in your code.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagSAMLProvider service method.</param>
        /// 
        /// <returns>The response from the TagSAMLProvider service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ConcurrentModificationException">
        /// The request was rejected because multiple requests to change this object were submitted
        /// simultaneously. Wait a few minutes and submit your request again.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/TagSAMLProvider">REST API Reference for TagSAMLProvider Operation</seealso>
        TagSAMLProviderResponse TagSAMLProvider(TagSAMLProviderRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagSAMLProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagSAMLProvider operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagSAMLProvider
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/TagSAMLProvider">REST API Reference for TagSAMLProvider Operation</seealso>
        IAsyncResult BeginTagSAMLProvider(TagSAMLProviderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagSAMLProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagSAMLProvider.</param>
        /// 
        /// <returns>Returns a  TagSAMLProviderResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/TagSAMLProvider">REST API Reference for TagSAMLProvider Operation</seealso>
        TagSAMLProviderResponse EndTagSAMLProvider(IAsyncResult asyncResult);

        #endregion
        
        #region  TagServerCertificate


        /// <summary>
        /// Adds one or more tags to an IAM server certificate. If a tag with the same key name
        /// already exists, then that tag is overwritten with the new value.
        /// 
        ///  <note> 
        /// <para>
        /// For certificates in a Region supported by Certificate Manager (ACM), we recommend
        /// that you don't use IAM server certificates. Instead, use ACM to provision, manage,
        /// and deploy your server certificates. For more information about IAM server certificates,
        /// <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_server-certs.html">Working
        /// with server certificates</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// A tag consists of a key name and an associated value. By assigning tags to your resources,
        /// you can do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Administrative grouping and discovery</b> - Attach tags to resources to aid in
        /// organization and search. For example, you could search for all resources with the
        /// key name <i>Project</i> and the value <i>MyImportantProject</i>. Or search for all
        /// resources with the key name <i>Cost Center</i> and the value <i>41200</i>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Access control</b> - Include tags in IAM user-based and resource-based policies.
        /// You can use tags to restrict access to only a server certificate that has a specified
        /// tag attached. For examples of policies that show how to use tags to control access,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_tags.html">Control
        /// access using IAM tags</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Cost allocation</b> - Use tags to help track which individuals and teams are using
        /// which Amazon Web Services resources.
        /// </para>
        ///  </li> </ul> <note> <ul> <li> 
        /// <para>
        /// If any one of the tags is invalid or if you exceed the allowed maximum number of tags,
        /// then the entire request fails and the resource is not created. For more information
        /// about tagging, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging
        /// IAM resources</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services always interprets the tag <code>Value</code> as a single string.
        /// If you need to store an array, you can store comma-separated values in the string.
        /// However, you must interpret the value in your code.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagServerCertificate service method.</param>
        /// 
        /// <returns>The response from the TagServerCertificate service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ConcurrentModificationException">
        /// The request was rejected because multiple requests to change this object were submitted
        /// simultaneously. Wait a few minutes and submit your request again.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/TagServerCertificate">REST API Reference for TagServerCertificate Operation</seealso>
        TagServerCertificateResponse TagServerCertificate(TagServerCertificateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagServerCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagServerCertificate operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagServerCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/TagServerCertificate">REST API Reference for TagServerCertificate Operation</seealso>
        IAsyncResult BeginTagServerCertificate(TagServerCertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagServerCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagServerCertificate.</param>
        /// 
        /// <returns>Returns a  TagServerCertificateResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/TagServerCertificate">REST API Reference for TagServerCertificate Operation</seealso>
        TagServerCertificateResponse EndTagServerCertificate(IAsyncResult asyncResult);

        #endregion
        
        #region  TagUser


        /// <summary>
        /// Adds one or more tags to an IAM user. If a tag with the same key name already exists,
        /// then that tag is overwritten with the new value.
        /// 
        ///  
        /// <para>
        /// A tag consists of a key name and an associated value. By assigning tags to your resources,
        /// you can do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Administrative grouping and discovery</b> - Attach tags to resources to aid in
        /// organization and search. For example, you could search for all resources with the
        /// key name <i>Project</i> and the value <i>MyImportantProject</i>. Or search for all
        /// resources with the key name <i>Cost Center</i> and the value <i>41200</i>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Access control</b> - Include tags in IAM user-based and resource-based policies.
        /// You can use tags to restrict access to only an IAM requesting user that has a specified
        /// tag attached. You can also restrict access to only those resources that have a certain
        /// tag attached. For examples of policies that show how to use tags to control access,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_tags.html">Control
        /// access using IAM tags</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Cost allocation</b> - Use tags to help track which individuals and teams are using
        /// which Amazon Web Services resources.
        /// </para>
        ///  </li> </ul> <note> <ul> <li> 
        /// <para>
        /// If any one of the tags is invalid or if you exceed the allowed maximum number of tags,
        /// then the entire request fails and the resource is not created. For more information
        /// about tagging, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging
        /// IAM resources</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Web Services always interprets the tag <code>Value</code> as a single string.
        /// If you need to store an array, you can store comma-separated values in the string.
        /// However, you must interpret the value in your code.
        /// </para>
        ///  </li> </ul> </note> 
        /// <para>
        /// For more information about tagging, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging
        /// IAM identities</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagUser service method.</param>
        /// 
        /// <returns>The response from the TagUser service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ConcurrentModificationException">
        /// The request was rejected because multiple requests to change this object were submitted
        /// simultaneously. Wait a few minutes and submit your request again.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/TagUser">REST API Reference for TagUser Operation</seealso>
        TagUserResponse TagUser(TagUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagUser operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/TagUser">REST API Reference for TagUser Operation</seealso>
        IAsyncResult BeginTagUser(TagUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagUser.</param>
        /// 
        /// <returns>Returns a  TagUserResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/TagUser">REST API Reference for TagUser Operation</seealso>
        TagUserResponse EndTagUser(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagInstanceProfile


        /// <summary>
        /// Removes the specified tags from the IAM instance profile. For more information about
        /// tagging, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging
        /// IAM resources</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagInstanceProfile service method.</param>
        /// 
        /// <returns>The response from the UntagInstanceProfile service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ConcurrentModificationException">
        /// The request was rejected because multiple requests to change this object were submitted
        /// simultaneously. Wait a few minutes and submit your request again.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UntagInstanceProfile">REST API Reference for UntagInstanceProfile Operation</seealso>
        UntagInstanceProfileResponse UntagInstanceProfile(UntagInstanceProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagInstanceProfile operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagInstanceProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UntagInstanceProfile">REST API Reference for UntagInstanceProfile Operation</seealso>
        IAsyncResult BeginUntagInstanceProfile(UntagInstanceProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagInstanceProfile.</param>
        /// 
        /// <returns>Returns a  UntagInstanceProfileResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UntagInstanceProfile">REST API Reference for UntagInstanceProfile Operation</seealso>
        UntagInstanceProfileResponse EndUntagInstanceProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagMFADevice


        /// <summary>
        /// Removes the specified tags from the IAM virtual multi-factor authentication (MFA)
        /// device. For more information about tagging, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging
        /// IAM resources</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagMFADevice service method.</param>
        /// 
        /// <returns>The response from the UntagMFADevice service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ConcurrentModificationException">
        /// The request was rejected because multiple requests to change this object were submitted
        /// simultaneously. Wait a few minutes and submit your request again.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UntagMFADevice">REST API Reference for UntagMFADevice Operation</seealso>
        UntagMFADeviceResponse UntagMFADevice(UntagMFADeviceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagMFADevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagMFADevice operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagMFADevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UntagMFADevice">REST API Reference for UntagMFADevice Operation</seealso>
        IAsyncResult BeginUntagMFADevice(UntagMFADeviceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagMFADevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagMFADevice.</param>
        /// 
        /// <returns>Returns a  UntagMFADeviceResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UntagMFADevice">REST API Reference for UntagMFADevice Operation</seealso>
        UntagMFADeviceResponse EndUntagMFADevice(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagOpenIDConnectProvider


        /// <summary>
        /// Removes the specified tags from the specified OpenID Connect (OIDC)-compatible identity
        /// provider in IAM. For more information about OIDC providers, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_providers_oidc.html">About
        /// web identity federation</a>. For more information about tagging, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging
        /// IAM resources</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagOpenIDConnectProvider service method.</param>
        /// 
        /// <returns>The response from the UntagOpenIDConnectProvider service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ConcurrentModificationException">
        /// The request was rejected because multiple requests to change this object were submitted
        /// simultaneously. Wait a few minutes and submit your request again.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UntagOpenIDConnectProvider">REST API Reference for UntagOpenIDConnectProvider Operation</seealso>
        UntagOpenIDConnectProviderResponse UntagOpenIDConnectProvider(UntagOpenIDConnectProviderRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagOpenIDConnectProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagOpenIDConnectProvider operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagOpenIDConnectProvider
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UntagOpenIDConnectProvider">REST API Reference for UntagOpenIDConnectProvider Operation</seealso>
        IAsyncResult BeginUntagOpenIDConnectProvider(UntagOpenIDConnectProviderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagOpenIDConnectProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagOpenIDConnectProvider.</param>
        /// 
        /// <returns>Returns a  UntagOpenIDConnectProviderResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UntagOpenIDConnectProvider">REST API Reference for UntagOpenIDConnectProvider Operation</seealso>
        UntagOpenIDConnectProviderResponse EndUntagOpenIDConnectProvider(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagPolicy


        /// <summary>
        /// Removes the specified tags from the customer managed policy. For more information
        /// about tagging, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging
        /// IAM resources</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagPolicy service method.</param>
        /// 
        /// <returns>The response from the UntagPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ConcurrentModificationException">
        /// The request was rejected because multiple requests to change this object were submitted
        /// simultaneously. Wait a few minutes and submit your request again.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UntagPolicy">REST API Reference for UntagPolicy Operation</seealso>
        UntagPolicyResponse UntagPolicy(UntagPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UntagPolicy">REST API Reference for UntagPolicy Operation</seealso>
        IAsyncResult BeginUntagPolicy(UntagPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagPolicy.</param>
        /// 
        /// <returns>Returns a  UntagPolicyResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UntagPolicy">REST API Reference for UntagPolicy Operation</seealso>
        UntagPolicyResponse EndUntagPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagRole


        /// <summary>
        /// Removes the specified tags from the role. For more information about tagging, see
        /// <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging IAM
        /// resources</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagRole service method.</param>
        /// 
        /// <returns>The response from the UntagRole service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ConcurrentModificationException">
        /// The request was rejected because multiple requests to change this object were submitted
        /// simultaneously. Wait a few minutes and submit your request again.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UntagRole">REST API Reference for UntagRole Operation</seealso>
        UntagRoleResponse UntagRole(UntagRoleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagRole operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagRole
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UntagRole">REST API Reference for UntagRole Operation</seealso>
        IAsyncResult BeginUntagRole(UntagRoleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagRole operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagRole.</param>
        /// 
        /// <returns>Returns a  UntagRoleResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UntagRole">REST API Reference for UntagRole Operation</seealso>
        UntagRoleResponse EndUntagRole(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagSAMLProvider


        /// <summary>
        /// Removes the specified tags from the specified Security Assertion Markup Language (SAML)
        /// identity provider in IAM. For more information about these providers, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_providers_oidc.html">About
        /// web identity federation</a>. For more information about tagging, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging
        /// IAM resources</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagSAMLProvider service method.</param>
        /// 
        /// <returns>The response from the UntagSAMLProvider service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ConcurrentModificationException">
        /// The request was rejected because multiple requests to change this object were submitted
        /// simultaneously. Wait a few minutes and submit your request again.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UntagSAMLProvider">REST API Reference for UntagSAMLProvider Operation</seealso>
        UntagSAMLProviderResponse UntagSAMLProvider(UntagSAMLProviderRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagSAMLProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagSAMLProvider operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagSAMLProvider
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UntagSAMLProvider">REST API Reference for UntagSAMLProvider Operation</seealso>
        IAsyncResult BeginUntagSAMLProvider(UntagSAMLProviderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagSAMLProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagSAMLProvider.</param>
        /// 
        /// <returns>Returns a  UntagSAMLProviderResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UntagSAMLProvider">REST API Reference for UntagSAMLProvider Operation</seealso>
        UntagSAMLProviderResponse EndUntagSAMLProvider(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagServerCertificate


        /// <summary>
        /// Removes the specified tags from the IAM server certificate. For more information about
        /// tagging, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging
        /// IAM resources</a> in the <i>IAM User Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// For certificates in a Region supported by Certificate Manager (ACM), we recommend
        /// that you don't use IAM server certificates. Instead, use ACM to provision, manage,
        /// and deploy your server certificates. For more information about IAM server certificates,
        /// <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_server-certs.html">Working
        /// with server certificates</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagServerCertificate service method.</param>
        /// 
        /// <returns>The response from the UntagServerCertificate service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ConcurrentModificationException">
        /// The request was rejected because multiple requests to change this object were submitted
        /// simultaneously. Wait a few minutes and submit your request again.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UntagServerCertificate">REST API Reference for UntagServerCertificate Operation</seealso>
        UntagServerCertificateResponse UntagServerCertificate(UntagServerCertificateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagServerCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagServerCertificate operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagServerCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UntagServerCertificate">REST API Reference for UntagServerCertificate Operation</seealso>
        IAsyncResult BeginUntagServerCertificate(UntagServerCertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagServerCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagServerCertificate.</param>
        /// 
        /// <returns>Returns a  UntagServerCertificateResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UntagServerCertificate">REST API Reference for UntagServerCertificate Operation</seealso>
        UntagServerCertificateResponse EndUntagServerCertificate(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagUser


        /// <summary>
        /// Removes the specified tags from the user. For more information about tagging, see
        /// <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging IAM
        /// resources</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagUser service method.</param>
        /// 
        /// <returns>The response from the UntagUser service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ConcurrentModificationException">
        /// The request was rejected because multiple requests to change this object were submitted
        /// simultaneously. Wait a few minutes and submit your request again.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UntagUser">REST API Reference for UntagUser Operation</seealso>
        UntagUserResponse UntagUser(UntagUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagUser operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UntagUser">REST API Reference for UntagUser Operation</seealso>
        IAsyncResult BeginUntagUser(UntagUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagUser.</param>
        /// 
        /// <returns>Returns a  UntagUserResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UntagUser">REST API Reference for UntagUser Operation</seealso>
        UntagUserResponse EndUntagUser(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAccessKey


        /// <summary>
        /// Changes the status of the specified access key from Active to Inactive, or vice versa.
        /// This operation can be used to disable a user's key as part of a key rotation workflow.
        /// 
        ///  
        /// <para>
        /// If the <code>UserName</code> is not specified, the user name is determined implicitly
        /// based on the Amazon Web Services access key ID used to sign the request. If a temporary
        /// access key is used, then <code>UserName</code> is required. If a long-term key is
        /// assigned to the user, then <code>UserName</code> is not required. This operation works
        /// for access keys under the Amazon Web Services account. Consequently, you can use this
        /// operation to manage Amazon Web Services account root user credentials even if the
        /// Amazon Web Services account has no associated users.
        /// </para>
        ///  
        /// <para>
        /// For information about rotating keys, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/ManagingCredentials.html">Managing
        /// keys and certificates</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccessKey service method.</param>
        /// 
        /// <returns>The response from the UpdateAccessKey service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateAccessKey">REST API Reference for UpdateAccessKey Operation</seealso>
        UpdateAccessKeyResponse UpdateAccessKey(UpdateAccessKeyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccessKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccessKey operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAccessKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateAccessKey">REST API Reference for UpdateAccessKey Operation</seealso>
        IAsyncResult BeginUpdateAccessKey(UpdateAccessKeyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAccessKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAccessKey.</param>
        /// 
        /// <returns>Returns a  UpdateAccessKeyResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateAccessKey">REST API Reference for UpdateAccessKey Operation</seealso>
        UpdateAccessKeyResponse EndUpdateAccessKey(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAccountPasswordPolicy


        /// <summary>
        /// Updates the password policy settings for the Amazon Web Services account.
        /// 
        ///  <note> 
        /// <para>
        /// This operation does not support partial updates. No parameters are required, but if
        /// you do not specify a parameter, that parameter's value reverts to its default value.
        /// See the <b>Request Parameters</b> section for each parameter's default value. Also
        /// note that some parameters do not allow the default parameter to be explicitly set.
        /// Instead, to invoke the default value, do not include that parameter when you invoke
        /// the operation.
        /// </para>
        ///  </note> 
        /// <para>
        ///  For more information about using a password policy, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingPasswordPolicies.html">Managing
        /// an IAM password policy</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the UpdateAccountPasswordPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message
        /// describes the specific error.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateAccountPasswordPolicy">REST API Reference for UpdateAccountPasswordPolicy Operation</seealso>
        UpdateAccountPasswordPolicyResponse UpdateAccountPasswordPolicy();

        /// <summary>
        /// Updates the password policy settings for the Amazon Web Services account.
        /// 
        ///  <note> 
        /// <para>
        /// This operation does not support partial updates. No parameters are required, but if
        /// you do not specify a parameter, that parameter's value reverts to its default value.
        /// See the <b>Request Parameters</b> section for each parameter's default value. Also
        /// note that some parameters do not allow the default parameter to be explicitly set.
        /// Instead, to invoke the default value, do not include that parameter when you invoke
        /// the operation.
        /// </para>
        ///  </note> 
        /// <para>
        ///  For more information about using a password policy, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingPasswordPolicies.html">Managing
        /// an IAM password policy</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountPasswordPolicy service method.</param>
        /// 
        /// <returns>The response from the UpdateAccountPasswordPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message
        /// describes the specific error.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateAccountPasswordPolicy">REST API Reference for UpdateAccountPasswordPolicy Operation</seealso>
        UpdateAccountPasswordPolicyResponse UpdateAccountPasswordPolicy(UpdateAccountPasswordPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccountPasswordPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountPasswordPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAccountPasswordPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateAccountPasswordPolicy">REST API Reference for UpdateAccountPasswordPolicy Operation</seealso>
        IAsyncResult BeginUpdateAccountPasswordPolicy(UpdateAccountPasswordPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAccountPasswordPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAccountPasswordPolicy.</param>
        /// 
        /// <returns>Returns a  UpdateAccountPasswordPolicyResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateAccountPasswordPolicy">REST API Reference for UpdateAccountPasswordPolicy Operation</seealso>
        UpdateAccountPasswordPolicyResponse EndUpdateAccountPasswordPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAssumeRolePolicy


        /// <summary>
        /// Updates the policy that grants an IAM entity permission to assume a role. This is
        /// typically referred to as the "role trust policy". For more information about roles,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/roles-toplevel.html">Using
        /// roles to delegate permissions and federate identities</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssumeRolePolicy service method.</param>
        /// 
        /// <returns>The response from the UpdateAssumeRolePolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message
        /// describes the specific error.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.UnmodifiableEntityException">
        /// The request was rejected because only the service that depends on the service-linked
        /// role can modify or delete the role on your behalf. The error message includes the
        /// name of the service that depends on this service-linked role. You must request the
        /// change through that service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateAssumeRolePolicy">REST API Reference for UpdateAssumeRolePolicy Operation</seealso>
        UpdateAssumeRolePolicyResponse UpdateAssumeRolePolicy(UpdateAssumeRolePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAssumeRolePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssumeRolePolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAssumeRolePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateAssumeRolePolicy">REST API Reference for UpdateAssumeRolePolicy Operation</seealso>
        IAsyncResult BeginUpdateAssumeRolePolicy(UpdateAssumeRolePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAssumeRolePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAssumeRolePolicy.</param>
        /// 
        /// <returns>Returns a  UpdateAssumeRolePolicyResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateAssumeRolePolicy">REST API Reference for UpdateAssumeRolePolicy Operation</seealso>
        UpdateAssumeRolePolicyResponse EndUpdateAssumeRolePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateGroup


        /// <summary>
        /// Updates the name and/or the path of the specified IAM group.
        /// 
        ///  <important> 
        /// <para>
        ///  You should understand the implications of changing a group's path or name. For more
        /// information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_WorkingWithGroupsAndUsers.html">Renaming
        /// users and groups</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </important> <note> 
        /// <para>
        /// The person making the request (the principal), must have permission to change the
        /// role group with the old name and the new name. For example, to change the group named
        /// <code>Managers</code> to <code>MGRs</code>, the principal must have a policy that
        /// allows them to update both groups. If the principal has permission to update the <code>Managers</code>
        /// group, but not the <code>MGRs</code> group, then the update fails. For more information
        /// about permissions, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management</a>. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateGroup service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        UpdateGroupResponse UpdateGroup(UpdateGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        IAsyncResult BeginUpdateGroup(UpdateGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGroup.</param>
        /// 
        /// <returns>Returns a  UpdateGroupResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        UpdateGroupResponse EndUpdateGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateLoginProfile


        /// <summary>
        /// Changes the password for the specified IAM user. You can use the CLI, the Amazon Web
        /// Services API, or the <b>Users</b> page in the IAM console to change the password for
        /// any IAM user. Use <a>ChangePassword</a> to change your own password in the <b>My Security
        /// Credentials</b> page in the Amazon Web Services Management Console.
        /// 
        ///  
        /// <para>
        /// For more information about modifying passwords, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingLogins.html">Managing
        /// passwords</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLoginProfile service method.</param>
        /// 
        /// <returns>The response from the UpdateLoginProfile service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityTemporarilyUnmodifiableException">
        /// The request was rejected because it referenced an entity that is temporarily unmodifiable,
        /// such as a user name that was deleted and then recreated. The error indicates that
        /// the request is likely to succeed if you try again after waiting several minutes. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.PasswordPolicyViolationException">
        /// The request was rejected because the provided password did not meet the requirements
        /// imposed by the account password policy.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateLoginProfile">REST API Reference for UpdateLoginProfile Operation</seealso>
        UpdateLoginProfileResponse UpdateLoginProfile(UpdateLoginProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLoginProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLoginProfile operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLoginProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateLoginProfile">REST API Reference for UpdateLoginProfile Operation</seealso>
        IAsyncResult BeginUpdateLoginProfile(UpdateLoginProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLoginProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLoginProfile.</param>
        /// 
        /// <returns>Returns a  UpdateLoginProfileResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateLoginProfile">REST API Reference for UpdateLoginProfile Operation</seealso>
        UpdateLoginProfileResponse EndUpdateLoginProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateOpenIDConnectProviderThumbprint


        /// <summary>
        /// Replaces the existing list of server certificate thumbprints associated with an OpenID
        /// Connect (OIDC) provider resource object with a new list of thumbprints.
        /// 
        ///  
        /// <para>
        /// The list that you pass with this operation completely replaces the existing list of
        /// thumbprints. (The lists are not merged.)
        /// </para>
        ///  
        /// <para>
        /// Typically, you need to update a thumbprint only when the identity provider certificate
        /// changes, which occurs rarely. However, if the provider's certificate <i>does</i> change,
        /// any attempt to assume an IAM role that specifies the OIDC provider as a principal
        /// fails until the certificate thumbprint is updated.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Web Services secures communication with some OIDC identity providers (IdPs)
        /// through our library of trusted certificate authorities (CAs) instead of using a certificate
        /// thumbprint to verify your IdP server certificate. These OIDC IdPs include Google,
        /// Auth0, and those that use an Amazon S3 bucket to host a JSON Web Key Set (JWKS) endpoint.
        /// In these cases, your legacy thumbprint remains in your configuration, but is no longer
        /// used for validation.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// Trust for the OIDC provider is derived from the provider certificate and is validated
        /// by the thumbprint. Therefore, it is best to limit access to the <code>UpdateOpenIDConnectProviderThumbprint</code>
        /// operation to highly privileged users.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOpenIDConnectProviderThumbprint service method.</param>
        /// 
        /// <returns>The response from the UpdateOpenIDConnectProviderThumbprint service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateOpenIDConnectProviderThumbprint">REST API Reference for UpdateOpenIDConnectProviderThumbprint Operation</seealso>
        UpdateOpenIDConnectProviderThumbprintResponse UpdateOpenIDConnectProviderThumbprint(UpdateOpenIDConnectProviderThumbprintRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateOpenIDConnectProviderThumbprint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateOpenIDConnectProviderThumbprint operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateOpenIDConnectProviderThumbprint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateOpenIDConnectProviderThumbprint">REST API Reference for UpdateOpenIDConnectProviderThumbprint Operation</seealso>
        IAsyncResult BeginUpdateOpenIDConnectProviderThumbprint(UpdateOpenIDConnectProviderThumbprintRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateOpenIDConnectProviderThumbprint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateOpenIDConnectProviderThumbprint.</param>
        /// 
        /// <returns>Returns a  UpdateOpenIDConnectProviderThumbprintResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateOpenIDConnectProviderThumbprint">REST API Reference for UpdateOpenIDConnectProviderThumbprint Operation</seealso>
        UpdateOpenIDConnectProviderThumbprintResponse EndUpdateOpenIDConnectProviderThumbprint(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateRole


        /// <summary>
        /// Updates the description or maximum session duration setting of a role.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRole service method.</param>
        /// 
        /// <returns>The response from the UpdateRole service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.UnmodifiableEntityException">
        /// The request was rejected because only the service that depends on the service-linked
        /// role can modify or delete the role on your behalf. The error message includes the
        /// name of the service that depends on this service-linked role. You must request the
        /// change through that service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateRole">REST API Reference for UpdateRole Operation</seealso>
        UpdateRoleResponse UpdateRole(UpdateRoleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRole operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRole
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateRole">REST API Reference for UpdateRole Operation</seealso>
        IAsyncResult BeginUpdateRole(UpdateRoleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRole operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRole.</param>
        /// 
        /// <returns>Returns a  UpdateRoleResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateRole">REST API Reference for UpdateRole Operation</seealso>
        UpdateRoleResponse EndUpdateRole(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateRoleDescription


        /// <summary>
        /// Use <a>UpdateRole</a> instead.
        /// 
        ///  
        /// <para>
        /// Modifies only the description of a role. This operation performs the same function
        /// as the <code>Description</code> parameter in the <code>UpdateRole</code> operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoleDescription service method.</param>
        /// 
        /// <returns>The response from the UpdateRoleDescription service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.UnmodifiableEntityException">
        /// The request was rejected because only the service that depends on the service-linked
        /// role can modify or delete the role on your behalf. The error message includes the
        /// name of the service that depends on this service-linked role. You must request the
        /// change through that service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateRoleDescription">REST API Reference for UpdateRoleDescription Operation</seealso>
        UpdateRoleDescriptionResponse UpdateRoleDescription(UpdateRoleDescriptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRoleDescription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoleDescription operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRoleDescription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateRoleDescription">REST API Reference for UpdateRoleDescription Operation</seealso>
        IAsyncResult BeginUpdateRoleDescription(UpdateRoleDescriptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRoleDescription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRoleDescription.</param>
        /// 
        /// <returns>Returns a  UpdateRoleDescriptionResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateRoleDescription">REST API Reference for UpdateRoleDescription Operation</seealso>
        UpdateRoleDescriptionResponse EndUpdateRoleDescription(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSAMLProvider


        /// <summary>
        /// Updates the metadata document for an existing SAML provider resource object.
        /// 
        ///  <note> 
        /// <para>
        /// This operation requires <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version 4</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSAMLProvider service method.</param>
        /// 
        /// <returns>The response from the UpdateSAMLProvider service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateSAMLProvider">REST API Reference for UpdateSAMLProvider Operation</seealso>
        UpdateSAMLProviderResponse UpdateSAMLProvider(UpdateSAMLProviderRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSAMLProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSAMLProvider operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSAMLProvider
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateSAMLProvider">REST API Reference for UpdateSAMLProvider Operation</seealso>
        IAsyncResult BeginUpdateSAMLProvider(UpdateSAMLProviderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSAMLProvider operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSAMLProvider.</param>
        /// 
        /// <returns>Returns a  UpdateSAMLProviderResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateSAMLProvider">REST API Reference for UpdateSAMLProvider Operation</seealso>
        UpdateSAMLProviderResponse EndUpdateSAMLProvider(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateServerCertificate


        /// <summary>
        /// Updates the name and/or the path of the specified server certificate stored in IAM.
        /// 
        ///  
        /// <para>
        /// For more information about working with server certificates, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_server-certs.html">Working
        /// with server certificates</a> in the <i>IAM User Guide</i>. This topic also includes
        /// a list of Amazon Web Services services that can use the server certificates that you
        /// manage with IAM.
        /// </para>
        ///  <important> 
        /// <para>
        /// You should understand the implications of changing a server certificate's path or
        /// name. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_server-certs_manage.html#RenamingServerCerts">Renaming
        /// a server certificate</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </important> <note> 
        /// <para>
        /// The person making the request (the principal), must have permission to change the
        /// server certificate with the old name and the new name. For example, to change the
        /// certificate named <code>ProductionCert</code> to <code>ProdCert</code>, the principal
        /// must have a policy that allows them to update both certificates. If the principal
        /// has permission to update the <code>ProductionCert</code> group, but not the <code>ProdCert</code>
        /// certificate, then the update fails. For more information about permissions, see <a
        /// href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access management</a>
        /// in the <i>IAM User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServerCertificate service method.</param>
        /// 
        /// <returns>The response from the UpdateServerCertificate service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateServerCertificate">REST API Reference for UpdateServerCertificate Operation</seealso>
        UpdateServerCertificateResponse UpdateServerCertificate(UpdateServerCertificateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateServerCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateServerCertificate operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateServerCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateServerCertificate">REST API Reference for UpdateServerCertificate Operation</seealso>
        IAsyncResult BeginUpdateServerCertificate(UpdateServerCertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateServerCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateServerCertificate.</param>
        /// 
        /// <returns>Returns a  UpdateServerCertificateResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateServerCertificate">REST API Reference for UpdateServerCertificate Operation</seealso>
        UpdateServerCertificateResponse EndUpdateServerCertificate(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateServiceSpecificCredential


        /// <summary>
        /// Sets the status of a service-specific credential to <code>Active</code> or <code>Inactive</code>.
        /// Service-specific credentials that are inactive cannot be used for authentication to
        /// the service. This operation can be used to disable a user's service-specific credential
        /// as part of a credential rotation work flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceSpecificCredential service method.</param>
        /// 
        /// <returns>The response from the UpdateServiceSpecificCredential service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateServiceSpecificCredential">REST API Reference for UpdateServiceSpecificCredential Operation</seealso>
        UpdateServiceSpecificCredentialResponse UpdateServiceSpecificCredential(UpdateServiceSpecificCredentialRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateServiceSpecificCredential operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceSpecificCredential operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateServiceSpecificCredential
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateServiceSpecificCredential">REST API Reference for UpdateServiceSpecificCredential Operation</seealso>
        IAsyncResult BeginUpdateServiceSpecificCredential(UpdateServiceSpecificCredentialRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateServiceSpecificCredential operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateServiceSpecificCredential.</param>
        /// 
        /// <returns>Returns a  UpdateServiceSpecificCredentialResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateServiceSpecificCredential">REST API Reference for UpdateServiceSpecificCredential Operation</seealso>
        UpdateServiceSpecificCredentialResponse EndUpdateServiceSpecificCredential(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSigningCertificate


        /// <summary>
        /// Changes the status of the specified user signing certificate from active to disabled,
        /// or vice versa. This operation can be used to disable an IAM user's signing certificate
        /// as part of a certificate rotation work flow.
        /// 
        ///  
        /// <para>
        /// If the <code>UserName</code> field is not specified, the user name is determined implicitly
        /// based on the Amazon Web Services access key ID used to sign the request. This operation
        /// works for access keys under the Amazon Web Services account. Consequently, you can
        /// use this operation to manage Amazon Web Services account root user credentials even
        /// if the Amazon Web Services account has no associated users.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSigningCertificate service method.</param>
        /// 
        /// <returns>The response from the UpdateSigningCertificate service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateSigningCertificate">REST API Reference for UpdateSigningCertificate Operation</seealso>
        UpdateSigningCertificateResponse UpdateSigningCertificate(UpdateSigningCertificateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSigningCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSigningCertificate operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSigningCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateSigningCertificate">REST API Reference for UpdateSigningCertificate Operation</seealso>
        IAsyncResult BeginUpdateSigningCertificate(UpdateSigningCertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSigningCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSigningCertificate.</param>
        /// 
        /// <returns>Returns a  UpdateSigningCertificateResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateSigningCertificate">REST API Reference for UpdateSigningCertificate Operation</seealso>
        UpdateSigningCertificateResponse EndUpdateSigningCertificate(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSSHPublicKey


        /// <summary>
        /// Sets the status of an IAM user's SSH public key to active or inactive. SSH public
        /// keys that are inactive cannot be used for authentication. This operation can be used
        /// to disable a user's SSH public key as part of a key rotation work flow.
        /// 
        ///  
        /// <para>
        /// The SSH public key affected by this operation is used only for authenticating the
        /// associated IAM user to an CodeCommit repository. For more information about using
        /// SSH keys to authenticate to an CodeCommit repository, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/setting-up-credentials-ssh.html">Set
        /// up CodeCommit for SSH connections</a> in the <i>CodeCommit User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSSHPublicKey service method.</param>
        /// 
        /// <returns>The response from the UpdateSSHPublicKey service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateSSHPublicKey">REST API Reference for UpdateSSHPublicKey Operation</seealso>
        UpdateSSHPublicKeyResponse UpdateSSHPublicKey(UpdateSSHPublicKeyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSSHPublicKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSSHPublicKey operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSSHPublicKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateSSHPublicKey">REST API Reference for UpdateSSHPublicKey Operation</seealso>
        IAsyncResult BeginUpdateSSHPublicKey(UpdateSSHPublicKeyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSSHPublicKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSSHPublicKey.</param>
        /// 
        /// <returns>Returns a  UpdateSSHPublicKeyResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateSSHPublicKey">REST API Reference for UpdateSSHPublicKey Operation</seealso>
        UpdateSSHPublicKeyResponse EndUpdateSSHPublicKey(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateUser


        /// <summary>
        /// Updates the name and/or the path of the specified IAM user.
        /// 
        ///  <important> 
        /// <para>
        ///  You should understand the implications of changing an IAM user's path or name. For
        /// more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_users_manage.html#id_users_renaming">Renaming
        /// an IAM user</a> and <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_groups_manage_rename.html">Renaming
        /// an IAM group</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </important> <note> 
        /// <para>
        ///  To change a user name, the requester must have appropriate permissions on both the
        /// source object and the target object. For example, to change Bob to Robert, the entity
        /// making the request must have permission on Bob and Robert, or must have permission
        /// on all (*). For more information about permissions, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/PermissionsAndPolicies.html">Permissions
        /// and policies</a>. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser service method.</param>
        /// 
        /// <returns>The response from the UpdateUser service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ConcurrentModificationException">
        /// The request was rejected because multiple requests to change this object were submitted
        /// simultaneously. Wait a few minutes and submit your request again.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityTemporarilyUnmodifiableException">
        /// The request was rejected because it referenced an entity that is temporarily unmodifiable,
        /// such as a user name that was deleted and then recreated. The error indicates that
        /// the request is likely to succeed if you try again after waiting several minutes. The
        /// error message describes the entity.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        UpdateUserResponse UpdateUser(UpdateUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        IAsyncResult BeginUpdateUser(UpdateUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateUser.</param>
        /// 
        /// <returns>Returns a  UpdateUserResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        UpdateUserResponse EndUpdateUser(IAsyncResult asyncResult);

        #endregion
        
        #region  UploadServerCertificate


        /// <summary>
        /// Uploads a server certificate entity for the Amazon Web Services account. The server
        /// certificate entity includes a public key certificate, a private key, and an optional
        /// certificate chain, which should all be PEM-encoded.
        /// 
        ///  
        /// <para>
        /// We recommend that you use <a href="https://docs.aws.amazon.com/acm/">Certificate Manager</a>
        /// to provision, manage, and deploy your server certificates. With ACM you can request
        /// a certificate, deploy it to Amazon Web Services resources, and let ACM handle certificate
        /// renewals for you. Certificates provided by ACM are free. For more information about
        /// using ACM, see the <a href="https://docs.aws.amazon.com/acm/latest/userguide/">Certificate
        /// Manager User Guide</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information about working with server certificates, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_server-certs.html">Working
        /// with server certificates</a> in the <i>IAM User Guide</i>. This topic includes a list
        /// of Amazon Web Services services that can use the server certificates that you manage
        /// with IAM.
        /// </para>
        ///  
        /// <para>
        /// For information about the number of server certificates you can upload, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_iam-quotas.html">IAM
        /// and STS quotas</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Because the body of the public key certificate, private key, and the certificate chain
        /// can be large, you should use POST rather than GET when calling <code>UploadServerCertificate</code>.
        /// For information about setting up signatures and authorization through the API, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/signing_aws_api_requests.html">Signing
        /// Amazon Web Services API requests</a> in the <i>Amazon Web Services General Reference</i>.
        /// For general information about using the Query API with IAM, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/programming.html">Calling
        /// the API by making HTTP query requests</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UploadServerCertificate service method.</param>
        /// 
        /// <returns>The response from the UploadServerCertificate service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ConcurrentModificationException">
        /// The request was rejected because multiple requests to change this object were submitted
        /// simultaneously. Wait a few minutes and submit your request again.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.KeyPairMismatchException">
        /// The request was rejected because the public key certificate and the private key do
        /// not match.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.MalformedCertificateException">
        /// The request was rejected because the certificate was malformed or expired. The error
        /// message describes the specific error.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UploadServerCertificate">REST API Reference for UploadServerCertificate Operation</seealso>
        UploadServerCertificateResponse UploadServerCertificate(UploadServerCertificateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UploadServerCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UploadServerCertificate operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUploadServerCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UploadServerCertificate">REST API Reference for UploadServerCertificate Operation</seealso>
        IAsyncResult BeginUploadServerCertificate(UploadServerCertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UploadServerCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUploadServerCertificate.</param>
        /// 
        /// <returns>Returns a  UploadServerCertificateResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UploadServerCertificate">REST API Reference for UploadServerCertificate Operation</seealso>
        UploadServerCertificateResponse EndUploadServerCertificate(IAsyncResult asyncResult);

        #endregion
        
        #region  UploadSigningCertificate


        /// <summary>
        /// Uploads an X.509 signing certificate and associates it with the specified IAM user.
        /// Some Amazon Web Services services require you to use certificates to validate requests
        /// that are signed with a corresponding private key. When you upload the certificate,
        /// its default status is <code>Active</code>.
        /// 
        ///  
        /// <para>
        /// For information about when you would use an X.509 signing certificate, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_server-certs.html">Managing
        /// server certificates in IAM</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If the <code>UserName</code> is not specified, the IAM user name is determined implicitly
        /// based on the Amazon Web Services access key ID used to sign the request. This operation
        /// works for access keys under the Amazon Web Services account. Consequently, you can
        /// use this operation to manage Amazon Web Services account root user credentials even
        /// if the Amazon Web Services account has no associated users.
        /// </para>
        ///  <note> 
        /// <para>
        /// Because the body of an X.509 certificate can be large, you should use POST rather
        /// than GET when calling <code>UploadSigningCertificate</code>. For information about
        /// setting up signatures and authorization through the API, see <a href="https://docs.aws.amazon.com/general/latest/gr/signing_aws_api_requests.html">Signing
        /// Amazon Web Services API requests</a> in the <i>Amazon Web Services General Reference</i>.
        /// For general information about using the Query API with IAM, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/IAM_UsingQueryAPI.html">Making
        /// query requests</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UploadSigningCertificate service method.</param>
        /// 
        /// <returns>The response from the UploadSigningCertificate service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.DuplicateCertificateException">
        /// The request was rejected because the same certificate is associated with an IAM user
        /// in the account.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.EntityAlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidCertificateException">
        /// The request was rejected because the certificate is invalid.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.MalformedCertificateException">
        /// The request was rejected because the certificate was malformed or expired. The error
        /// message describes the specific error.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UploadSigningCertificate">REST API Reference for UploadSigningCertificate Operation</seealso>
        UploadSigningCertificateResponse UploadSigningCertificate(UploadSigningCertificateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UploadSigningCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UploadSigningCertificate operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUploadSigningCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UploadSigningCertificate">REST API Reference for UploadSigningCertificate Operation</seealso>
        IAsyncResult BeginUploadSigningCertificate(UploadSigningCertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UploadSigningCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUploadSigningCertificate.</param>
        /// 
        /// <returns>Returns a  UploadSigningCertificateResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UploadSigningCertificate">REST API Reference for UploadSigningCertificate Operation</seealso>
        UploadSigningCertificateResponse EndUploadSigningCertificate(IAsyncResult asyncResult);

        #endregion
        
        #region  UploadSSHPublicKey


        /// <summary>
        /// Uploads an SSH public key and associates it with the specified IAM user.
        /// 
        ///  
        /// <para>
        /// The SSH public key uploaded by this operation can be used only for authenticating
        /// the associated IAM user to an CodeCommit repository. For more information about using
        /// SSH keys to authenticate to an CodeCommit repository, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/setting-up-credentials-ssh.html">Set
        /// up CodeCommit for SSH connections</a> in the <i>CodeCommit User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UploadSSHPublicKey service method.</param>
        /// 
        /// <returns>The response from the UploadSSHPublicKey service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.DuplicateSSHPublicKeyException">
        /// The request was rejected because the SSH public key is already associated with the
        /// specified IAM user.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidPublicKeyException">
        /// The request was rejected because the public key is malformed or otherwise invalid.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Amazon Web Services account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.UnrecognizedPublicKeyEncodingException">
        /// The request was rejected because the public key encoding format is unsupported or
        /// unrecognized.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UploadSSHPublicKey">REST API Reference for UploadSSHPublicKey Operation</seealso>
        UploadSSHPublicKeyResponse UploadSSHPublicKey(UploadSSHPublicKeyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UploadSSHPublicKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UploadSSHPublicKey operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUploadSSHPublicKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UploadSSHPublicKey">REST API Reference for UploadSSHPublicKey Operation</seealso>
        IAsyncResult BeginUploadSSHPublicKey(UploadSSHPublicKeyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UploadSSHPublicKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUploadSSHPublicKey.</param>
        /// 
        /// <returns>Returns a  UploadSSHPublicKeyResult from IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UploadSSHPublicKey">REST API Reference for UploadSSHPublicKey Operation</seealso>
        UploadSSHPublicKeyResponse EndUploadSSHPublicKey(IAsyncResult asyncResult);

        #endregion
        
    }
}