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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.IdentityManagement.Model;

#pragma warning disable CS1570
namespace Amazon.IdentityManagement
{
    /// <summary>
    /// <para>Interface for accessing IdentityManagementService</para>
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

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IIdentityManagementPaginatorFactory Paginators { get; }

        
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<AddClientIDToOpenIDConnectProviderResponse> AddClientIDToOpenIDConnectProviderAsync(AddClientIDToOpenIDConnectProviderRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// The caller of this operation must be granted the <c>PassRole</c> permission on the
        /// IAM role by a permissions policy.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// When using the <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_iam-condition-keys.html#available-keys-for-iam">iam:AssociatedResourceArn</a>
        /// condition in a policy to restrict the <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use_passrole.html">PassRole</a>
        /// IAM action, special considerations apply if the policy is intended to define access
        /// for the <c>AddRoleToInstanceProfile</c> action. In this case, you cannot specify a
        /// Region or instance ID in the EC2 instance ARN. The ARN value must be <c>arn:aws:ec2:*:CallerAccountId:instance/*</c>.
        /// Using any other ARN value may lead to unexpected evaluation results.
        /// </para>
        ///  </important> 
        /// <para>
        ///  For more information about roles, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles.html">IAM
        /// roles</a> in the <i>IAM User Guide</i>. For more information about instance profiles,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use_switch-role-ec2_instance-profiles.html">Using
        /// instance profiles</a> in the <i>IAM User Guide</i>.
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
        /// The request was rejected because service-linked roles are protected Amazon Web Services
        /// resources. Only the service that depends on the service-linked role can modify or
        /// delete the role on your behalf. The error message includes the name of the service
        /// that depends on this service-linked role. You must request the change through that
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/AddRoleToInstanceProfile">REST API Reference for AddRoleToInstanceProfile Operation</seealso>
        AddRoleToInstanceProfileResponse AddRoleToInstanceProfile(AddRoleToInstanceProfileRequest request);



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
        /// The caller of this operation must be granted the <c>PassRole</c> permission on the
        /// IAM role by a permissions policy.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// When using the <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_iam-condition-keys.html#available-keys-for-iam">iam:AssociatedResourceArn</a>
        /// condition in a policy to restrict the <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use_passrole.html">PassRole</a>
        /// IAM action, special considerations apply if the policy is intended to define access
        /// for the <c>AddRoleToInstanceProfile</c> action. In this case, you cannot specify a
        /// Region or instance ID in the EC2 instance ARN. The ARN value must be <c>arn:aws:ec2:*:CallerAccountId:instance/*</c>.
        /// Using any other ARN value may lead to unexpected evaluation results.
        /// </para>
        ///  </important> 
        /// <para>
        ///  For more information about roles, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles.html">IAM
        /// roles</a> in the <i>IAM User Guide</i>. For more information about instance profiles,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use_switch-role-ec2_instance-profiles.html">Using
        /// instance profiles</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddRoleToInstanceProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// The request was rejected because service-linked roles are protected Amazon Web Services
        /// resources. Only the service that depends on the service-linked role can modify or
        /// delete the role on your behalf. The error message includes the name of the service
        /// that depends on this service-linked role. You must request the change through that
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/AddRoleToInstanceProfile">REST API Reference for AddRoleToInstanceProfile Operation</seealso>
        Task<AddRoleToInstanceProfileResponse> AddRoleToInstanceProfileAsync(AddRoleToInstanceProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Adds the specified user to the specified group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddUserToGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<AddUserToGroupResponse> AddUserToGroupAsync(AddUserToGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AttachGroupPolicy


        /// <summary>
        /// Attaches the specified managed policy to the specified IAM group.
        /// 
        ///  
        /// <para>
        /// You use this operation to attach a managed policy to a group. To embed an inline policy
        /// in a group, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_PutGroupPolicy.html">
        /// <c>PutGroupPolicy</c> </a>.
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
        /// Attaches the specified managed policy to the specified IAM group.
        /// 
        ///  
        /// <para>
        /// You use this operation to attach a managed policy to a group. To embed an inline policy
        /// in a group, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_PutGroupPolicy.html">
        /// <c>PutGroupPolicy</c> </a>.
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<AttachGroupPolicyResponse> AttachGroupPolicyAsync(AttachGroupPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// is created at the same time as the role, using <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_CreateRole.html">
        /// <c>CreateRole</c> </a>. You can update a role's trust policy using <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_UpdateAssumeRolePolicy.html">
        /// <c>UpdateAssumerolePolicy</c> </a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Use this operation to attach a <i>managed</i> policy to a role. To embed an inline
        /// policy in a role, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_PutRolePolicy.html">
        /// <c>PutRolePolicy</c> </a>. For more information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
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
        /// The request was rejected because service-linked roles are protected Amazon Web Services
        /// resources. Only the service that depends on the service-linked role can modify or
        /// delete the role on your behalf. The error message includes the name of the service
        /// that depends on this service-linked role. You must request the change through that
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/AttachRolePolicy">REST API Reference for AttachRolePolicy Operation</seealso>
        AttachRolePolicyResponse AttachRolePolicy(AttachRolePolicyRequest request);



        /// <summary>
        /// Attaches the specified managed policy to the specified IAM role. When you attach a
        /// managed policy to a role, the managed policy becomes part of the role's permission
        /// (access) policy.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot use a managed policy as the role's trust policy. The role's trust policy
        /// is created at the same time as the role, using <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_CreateRole.html">
        /// <c>CreateRole</c> </a>. You can update a role's trust policy using <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_UpdateAssumeRolePolicy.html">
        /// <c>UpdateAssumerolePolicy</c> </a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Use this operation to attach a <i>managed</i> policy to a role. To embed an inline
        /// policy in a role, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_PutRolePolicy.html">
        /// <c>PutRolePolicy</c> </a>. For more information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// policies and inline policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// As a best practice, you can validate your IAM policies. To learn more, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_policy-validator.html">Validating
        /// IAM policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachRolePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// The request was rejected because service-linked roles are protected Amazon Web Services
        /// resources. Only the service that depends on the service-linked role can modify or
        /// delete the role on your behalf. The error message includes the name of the service
        /// that depends on this service-linked role. You must request the change through that
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/AttachRolePolicy">REST API Reference for AttachRolePolicy Operation</seealso>
        Task<AttachRolePolicyResponse> AttachRolePolicyAsync(AttachRolePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AttachUserPolicy


        /// <summary>
        /// Attaches the specified managed policy to the specified user.
        /// 
        ///  
        /// <para>
        /// You use this operation to attach a <i>managed</i> policy to a user. To embed an inline
        /// policy in a user, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_PutUserPolicy.html">
        /// <c>PutUserPolicy</c> </a>.
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
        /// Attaches the specified managed policy to the specified user.
        /// 
        ///  
        /// <para>
        /// You use this operation to attach a <i>managed</i> policy to a user. To embed an inline
        /// policy in a user, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_PutUserPolicy.html">
        /// <c>PutUserPolicy</c> </a>.
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<AttachUserPolicyResponse> AttachUserPolicyAsync(AttachUserPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_UpdateLoginProfile.html">UpdateLoginProfile</a>
        /// to use the CLI, the Amazon Web Services API, or the <b>Users</b> page in the IAM console
        /// to change the password for any IAM user. For more information about modifying passwords,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingLogins.html">Managing
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
        /// Changes the password of the IAM user who is calling this operation. This operation
        /// can be performed using the CLI, the Amazon Web Services API, or the <b>My Security
        /// Credentials</b> page in the Amazon Web Services Management Console. The Amazon Web
        /// Services account root user password is not affected by this operation.
        /// 
        ///  
        /// <para>
        /// Use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_UpdateLoginProfile.html">UpdateLoginProfile</a>
        /// to use the CLI, the Amazon Web Services API, or the <b>Users</b> page in the IAM console
        /// to change the password for any IAM user. For more information about modifying passwords,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingLogins.html">Managing
        /// passwords</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ChangePassword service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ChangePasswordResponse> ChangePasswordAsync(ChangePasswordRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateAccessKey


        /// <summary>
        /// Creates a new Amazon Web Services secret access key and corresponding Amazon Web
        /// Services access key ID for the specified user. The default status for new keys is
        /// <c>Active</c>.
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
        /// <c>Active</c>.
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
        /// Creates a new Amazon Web Services secret access key and corresponding Amazon Web
        /// Services access key ID for the specified user. The default status for new keys is
        /// <c>Active</c>.
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateAccessKeyResponse> CreateAccessKeyAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Creates a new Amazon Web Services secret access key and corresponding Amazon Web
        /// Services access key ID for the specified user. The default status for new keys is
        /// <c>Active</c>.
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateAccessKeyResponse> CreateAccessKeyAsync(CreateAccessKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateAccountAlias


        /// <summary>
        /// Creates an alias for your Amazon Web Services account. For information about using
        /// an Amazon Web Services account alias, see <a href="https://docs.aws.amazon.com/signin/latest/userguide/CreateAccountAlias.html">Creating,
        /// deleting, and listing an Amazon Web Services account alias</a> in the <i>Amazon Web
        /// Services Sign-In User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccountAlias service method.</param>
        /// 
        /// <returns>The response from the CreateAccountAlias service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ConcurrentModificationException">
        /// The request was rejected because multiple requests to change this object were submitted
        /// simultaneously. Wait a few minutes and submit your request again.
        /// </exception>
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
        /// Creates an alias for your Amazon Web Services account. For information about using
        /// an Amazon Web Services account alias, see <a href="https://docs.aws.amazon.com/signin/latest/userguide/CreateAccountAlias.html">Creating,
        /// deleting, and listing an Amazon Web Services account alias</a> in the <i>Amazon Web
        /// Services Sign-In User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccountAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAccountAlias service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ConcurrentModificationException">
        /// The request was rejected because multiple requests to change this object were submitted
        /// simultaneously. Wait a few minutes and submit your request again.
        /// </exception>
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
        Task<CreateAccountAliasResponse> CreateAccountAliasAsync(CreateAccountAliasRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates a new group.
        /// 
        ///  
        /// <para>
        ///  For information about the number of groups you can create, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_iam-quotas.html">IAM
        /// and STS quotas</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateGroupResponse> CreateGroupAsync(CreateGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateInstanceProfileResponse> CreateInstanceProfileAsync(CreateInstanceProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateLoginProfile


        /// <summary>
        /// Creates a password for the specified IAM user. A password allows an IAM user to access
        /// Amazon Web Services services through the Amazon Web Services Management Console.
        /// 
        ///  
        /// <para>
        /// You can use the CLI, the Amazon Web Services API, or the <b>Users</b> page in the
        /// IAM console to create a password for any IAM user. Use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ChangePassword.html">ChangePassword</a>
        /// to update your own existing password in the <b>My Security Credentials</b> page in
        /// the Amazon Web Services Management Console.
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
        /// Creates a password for the specified IAM user. A password allows an IAM user to access
        /// Amazon Web Services services through the Amazon Web Services Management Console.
        /// 
        ///  
        /// <para>
        /// You can use the CLI, the Amazon Web Services API, or the <b>Users</b> page in the
        /// IAM console to create a password for any IAM user. Use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ChangePassword.html">ChangePassword</a>
        /// to update your own existing password in the <b>My Security Credentials</b> page in
        /// the Amazon Web Services Management Console.
        /// </para>
        ///  
        /// <para>
        /// For more information about managing passwords, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingLogins.html">Managing
        /// passwords</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLoginProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateLoginProfileResponse> CreateLoginProfileAsync(CreateLoginProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// A list of tags that are attached to the specified IAM OIDC provider
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
        /// Amazon Web Services secures communication with OIDC identity providers (IdPs) using
        /// our library of trusted root certificate authorities (CAs) to verify the JSON Web Key
        /// Set (JWKS) endpoint's TLS certificate. If your OIDC IdP relies on a certificate that
        /// is not signed by one of these trusted CAs, only then we secure communication using
        /// the thumbprints set in the IdP's configuration.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// The trust for the OIDC provider is derived from the IAM provider that this operation
        /// creates. Therefore, it is best to limit access to the <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_CreateOpenIDConnectProvider.html">CreateOpenIDConnectProvider</a>
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
        /// <exception cref="Amazon.IdentityManagement.Model.OpenIdIdpCommunicationErrorException">
        /// The request failed because IAM cannot connect to the OpenID Connect identity provider
        /// URL.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateOpenIDConnectProvider">REST API Reference for CreateOpenIDConnectProvider Operation</seealso>
        CreateOpenIDConnectProviderResponse CreateOpenIDConnectProvider(CreateOpenIDConnectProviderRequest request);



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
        /// A list of tags that are attached to the specified IAM OIDC provider
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
        /// Amazon Web Services secures communication with OIDC identity providers (IdPs) using
        /// our library of trusted root certificate authorities (CAs) to verify the JSON Web Key
        /// Set (JWKS) endpoint's TLS certificate. If your OIDC IdP relies on a certificate that
        /// is not signed by one of these trusted CAs, only then we secure communication using
        /// the thumbprints set in the IdP's configuration.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// The trust for the OIDC provider is derived from the IAM provider that this operation
        /// creates. Therefore, it is best to limit access to the <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_CreateOpenIDConnectProvider.html">CreateOpenIDConnectProvider</a>
        /// operation to highly privileged users.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOpenIDConnectProvider service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// <exception cref="Amazon.IdentityManagement.Model.OpenIdIdpCommunicationErrorException">
        /// The request failed because IAM cannot connect to the OpenID Connect identity provider
        /// URL.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateOpenIDConnectProvider">REST API Reference for CreateOpenIDConnectProvider Operation</seealso>
        Task<CreateOpenIDConnectProviderResponse> CreateOpenIDConnectProviderAsync(CreateOpenIDConnectProviderRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreatePolicy


        /// <summary>
        /// Creates a new managed policy for your Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// This operation creates a policy version with a version identifier of <c>v1</c> and
        /// sets v1 as the policy's default version. For more information about policy versions,
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
        /// Creates a new managed policy for your Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// This operation creates a policy version with a version identifier of <c>v1</c> and
        /// sets v1 as the policy's default version. For more information about policy versions,
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreatePolicyResponse> CreatePolicyAsync(CreatePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreatePolicyVersion


        /// <summary>
        /// Creates a new version of the specified managed policy. To update a managed policy,
        /// you create a new policy version. A managed policy can have up to five versions. If
        /// the policy has five versions, you must delete an existing version using <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DeletePolicyVersion.html">DeletePolicyVersion</a>
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
        /// Creates a new version of the specified managed policy. To update a managed policy,
        /// you create a new policy version. A managed policy can have up to five versions. If
        /// the policy has five versions, you must delete an existing version using <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DeletePolicyVersion.html">DeletePolicyVersion</a>
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreatePolicyVersionResponse> CreatePolicyVersionAsync(CreatePolicyVersionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateRole


        /// <summary>
        /// Creates a new role for your Amazon Web Services account.
        /// 
        ///  
        /// <para>
        ///  For more information about roles, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles.html">IAM
        /// roles</a> in the <i>IAM User Guide</i>. For information about quotas for role names
        /// and the number of roles you can create, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_iam-quotas.html">IAM
        /// and STS quotas</a> in the <i>IAM User Guide</i>.
        /// </para>
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
        /// Creates a new role for your Amazon Web Services account.
        /// 
        ///  
        /// <para>
        ///  For more information about roles, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles.html">IAM
        /// roles</a> in the <i>IAM User Guide</i>. For information about quotas for role names
        /// and the number of roles you can create, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_iam-quotas.html">IAM
        /// and STS quotas</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRole service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateRoleResponse> CreateRoleAsync(CreateRoleRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateSAMLProviderResponse> CreateSAMLProviderAsync(CreateSAMLProviderRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateServiceLinkedRoleResponse> CreateServiceLinkedRoleAsync(CreateServiceLinkedRoleRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// You can create service-specific credentials for Amazon Bedrock, CodeCommit and Amazon
        /// Keyspaces (for Apache Cassandra).
        /// </para>
        ///  
        /// <para>
        /// You can reset the password to a new service-generated value by calling <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ResetServiceSpecificCredential.html">ResetServiceSpecificCredential</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information about service-specific credentials, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_bedrock.html">Service-specific
        /// credentials for IAM users</a> in the <i>IAM User Guide</i>.
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
        /// You can create service-specific credentials for Amazon Bedrock, CodeCommit and Amazon
        /// Keyspaces (for Apache Cassandra).
        /// </para>
        ///  
        /// <para>
        /// You can reset the password to a new service-generated value by calling <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ResetServiceSpecificCredential.html">ResetServiceSpecificCredential</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information about service-specific credentials, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_bedrock.html">Service-specific
        /// credentials for IAM users</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceSpecificCredential service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateServiceSpecificCredentialResponse> CreateServiceSpecificCredentialAsync(CreateServiceSpecificCredentialRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates a new IAM user for your Amazon Web Services account.
        /// 
        ///  
        /// <para>
        ///  For information about quotas for the number of IAM users you can create, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_iam-quotas.html">IAM
        /// and STS quotas</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateUserResponse> CreateUserAsync(CreateUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateVirtualMFADevice


        /// <summary>
        /// Creates a new virtual MFA device for the Amazon Web Services account. After creating
        /// the virtual MFA, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_EnableMFADevice.html">EnableMFADevice</a>
        /// to attach the MFA device to an IAM user. For more information about creating and working
        /// with virtual MFA devices, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_VirtualMFA.html">Using
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
        /// Creates a new virtual MFA device for the Amazon Web Services account. After creating
        /// the virtual MFA, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_EnableMFADevice.html">EnableMFADevice</a>
        /// to attach the MFA device to an IAM user. For more information about creating and working
        /// with virtual MFA devices, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_VirtualMFA.html">Using
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateVirtualMFADeviceResponse> CreateVirtualMFADeviceAsync(CreateVirtualMFADeviceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <exception cref="Amazon.IdentityManagement.Model.ConcurrentModificationException">
        /// The request was rejected because multiple requests to change this object were submitted
        /// simultaneously. Wait a few minutes and submit your request again.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeactivateMFADevice">REST API Reference for DeactivateMFADevice Operation</seealso>
        DeactivateMFADeviceResponse DeactivateMFADevice(DeactivateMFADeviceRequest request);



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeactivateMFADevice service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ConcurrentModificationException">
        /// The request was rejected because multiple requests to change this object were submitted
        /// simultaneously. Wait a few minutes and submit your request again.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeactivateMFADevice">REST API Reference for DeactivateMFADevice Operation</seealso>
        Task<DeactivateMFADeviceResponse> DeactivateMFADeviceAsync(DeactivateMFADeviceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteAccessKeyResponse> DeleteAccessKeyAsync(DeleteAccessKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteAccountAlias


        /// <summary>
        /// Deletes the specified Amazon Web Services account alias. For information about using
        /// an Amazon Web Services account alias, see <a href="https://docs.aws.amazon.com/signin/latest/userguide/CreateAccountAlias.html">Creating,
        /// deleting, and listing an Amazon Web Services account alias</a> in the <i>Amazon Web
        /// Services Sign-In User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountAlias service method.</param>
        /// 
        /// <returns>The response from the DeleteAccountAlias service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ConcurrentModificationException">
        /// The request was rejected because multiple requests to change this object were submitted
        /// simultaneously. Wait a few minutes and submit your request again.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteAccountAlias">REST API Reference for DeleteAccountAlias Operation</seealso>
        DeleteAccountAliasResponse DeleteAccountAlias(DeleteAccountAliasRequest request);



        /// <summary>
        /// Deletes the specified Amazon Web Services account alias. For information about using
        /// an Amazon Web Services account alias, see <a href="https://docs.aws.amazon.com/signin/latest/userguide/CreateAccountAlias.html">Creating,
        /// deleting, and listing an Amazon Web Services account alias</a> in the <i>Amazon Web
        /// Services Sign-In User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAccountAlias service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ConcurrentModificationException">
        /// The request was rejected because multiple requests to change this object were submitted
        /// simultaneously. Wait a few minutes and submit your request again.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteAccountAlias">REST API Reference for DeleteAccountAlias Operation</seealso>
        Task<DeleteAccountAliasResponse> DeleteAccountAliasAsync(DeleteAccountAliasRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes the password policy for the Amazon Web Services account. There are no parameters.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteAccountPasswordPolicyResponse> DeleteAccountPasswordPolicyAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Deletes the password policy for the Amazon Web Services account. There are no parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountPasswordPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteAccountPasswordPolicyResponse> DeleteAccountPasswordPolicyAsync(DeleteAccountPasswordPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes the specified IAM group. The group must not contain any users or have any
        /// attached policies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteGroupResponse> DeleteGroupAsync(DeleteGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteGroupPolicy


        /// <summary>
        /// Deletes the specified inline policy that is embedded in the specified IAM group.
        /// 
        ///  
        /// <para>
        /// A group can also have managed policies attached to it. To detach a managed policy
        /// from a group, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DetachGroupPolicy.html">DetachGroupPolicy</a>.
        /// For more information about policies, refer to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
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
        /// Deletes the specified inline policy that is embedded in the specified IAM group.
        /// 
        ///  
        /// <para>
        /// A group can also have managed policies attached to it. To detach a managed policy
        /// from a group, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DetachGroupPolicy.html">DetachGroupPolicy</a>.
        /// For more information about policies, refer to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// policies and inline policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroupPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteGroupPolicyResponse> DeleteGroupPolicyAsync(DeleteGroupPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// For more information about instance profiles, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use_switch-role-ec2_instance-profiles.html">Using
        /// instance profiles</a> in the <i>IAM User Guide</i>.
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
        /// For more information about instance profiles, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use_switch-role-ec2_instance-profiles.html">Using
        /// instance profiles</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstanceProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteInstanceProfileResponse> DeleteInstanceProfileAsync(DeleteInstanceProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteLoginProfile


        /// <summary>
        /// Deletes the password for the specified IAM user or root user, For more information,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_passwords_admin-change-user.html">Managing
        /// passwords for IAM users</a>.
        /// 
        ///  
        /// <para>
        /// You can use the CLI, the Amazon Web Services API, or the <b>Users</b> page in the
        /// IAM console to delete a password for any IAM user. You can use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ChangePassword.html">ChangePassword</a>
        /// to update, but not delete, your own password in the <b>My Security Credentials</b>
        /// page in the Amazon Web Services Management Console.
        /// </para>
        ///  <important> 
        /// <para>
        /// Deleting a user's password does not prevent a user from accessing Amazon Web Services
        /// through the command line interface or the API. To prevent all user access, you must
        /// also either make any access keys inactive or delete them. For more information about
        /// making keys inactive or deleting them, see <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_UpdateAccessKey.html">UpdateAccessKey</a>
        /// and <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DeleteAccessKey.html">DeleteAccessKey</a>.
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
        /// Deletes the password for the specified IAM user or root user, For more information,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_passwords_admin-change-user.html">Managing
        /// passwords for IAM users</a>.
        /// 
        ///  
        /// <para>
        /// You can use the CLI, the Amazon Web Services API, or the <b>Users</b> page in the
        /// IAM console to delete a password for any IAM user. You can use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ChangePassword.html">ChangePassword</a>
        /// to update, but not delete, your own password in the <b>My Security Credentials</b>
        /// page in the Amazon Web Services Management Console.
        /// </para>
        ///  <important> 
        /// <para>
        /// Deleting a user's password does not prevent a user from accessing Amazon Web Services
        /// through the command line interface or the API. To prevent all user access, you must
        /// also either make any access keys inactive or delete them. For more information about
        /// making keys inactive or deleting them, see <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_UpdateAccessKey.html">UpdateAccessKey</a>
        /// and <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DeleteAccessKey.html">DeleteAccessKey</a>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoginProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteLoginProfileResponse> DeleteLoginProfileAsync(DeleteLoginProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteOpenIDConnectProviderResponse> DeleteOpenIDConnectProviderAsync(DeleteOpenIDConnectProviderRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// using <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DetachUserPolicy.html">DetachUserPolicy</a>,
        /// <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DetachGroupPolicy.html">DetachGroupPolicy</a>,
        /// or <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DetachRolePolicy.html">DetachRolePolicy</a>.
        /// To list all the users, groups, and roles that a policy is attached to, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ListEntitiesForPolicy.html">ListEntitiesForPolicy</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Delete all versions of the policy using <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DeletePolicyVersion.html">DeletePolicyVersion</a>.
        /// To list the policy's versions, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ListPolicyVersions.html">ListPolicyVersions</a>.
        /// You cannot use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DeletePolicyVersion.html">DeletePolicyVersion</a>
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
        /// using <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DetachUserPolicy.html">DetachUserPolicy</a>,
        /// <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DetachGroupPolicy.html">DetachGroupPolicy</a>,
        /// or <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DetachRolePolicy.html">DetachRolePolicy</a>.
        /// To list all the users, groups, and roles that a policy is attached to, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ListEntitiesForPolicy.html">ListEntitiesForPolicy</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Delete all versions of the policy using <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DeletePolicyVersion.html">DeletePolicyVersion</a>.
        /// To list the policy's versions, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ListPolicyVersions.html">ListPolicyVersions</a>.
        /// You cannot use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DeletePolicyVersion.html">DeletePolicyVersion</a>
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeletePolicyResponse> DeletePolicyAsync(DeletePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeletePolicyVersion


        /// <summary>
        /// Deletes the specified version from the specified managed policy.
        /// 
        ///  
        /// <para>
        /// You cannot delete the default version from a policy using this operation. To delete
        /// the default version from a policy, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DeletePolicy.html">DeletePolicy</a>.
        /// To find out which version of a policy is marked as the default version, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ListPolicyVersions.html">ListPolicyVersions</a>.
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
        /// Deletes the specified version from the specified managed policy.
        /// 
        ///  
        /// <para>
        /// You cannot delete the default version from a policy using this operation. To delete
        /// the default version from a policy, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DeletePolicy.html">DeletePolicy</a>.
        /// To find out which version of a policy is marked as the default version, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ListPolicyVersions.html">ListPolicyVersions</a>.
        /// </para>
        ///  
        /// <para>
        /// For information about versions for managed policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-versions.html">Versioning
        /// for managed policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicyVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeletePolicyVersionResponse> DeletePolicyVersionAsync(DeletePolicyVersionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Inline policies (<a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DeleteRolePolicy.html">DeleteRolePolicy</a>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Attached managed policies (<a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DetachRolePolicy.html">DetachRolePolicy</a>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Instance profile (<a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_RemoveRoleFromInstanceProfile.html">RemoveRoleFromInstanceProfile</a>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Optional – Delete instance profile after detaching from role for resource clean up
        /// (<a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DeleteInstanceProfile.html">DeleteInstanceProfile</a>)
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
        /// The request was rejected because service-linked roles are protected Amazon Web Services
        /// resources. Only the service that depends on the service-linked role can modify or
        /// delete the role on your behalf. The error message includes the name of the service
        /// that depends on this service-linked role. You must request the change through that
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteRole">REST API Reference for DeleteRole Operation</seealso>
        DeleteRoleResponse DeleteRole(DeleteRoleRequest request);



        /// <summary>
        /// Deletes the specified role. Unlike the Amazon Web Services Management Console, when
        /// you delete a role programmatically, you must delete the items attached to the role
        /// manually, or the deletion fails. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_manage_delete.html#roles-managingrole-deleting-cli">Deleting
        /// an IAM role</a>. Before attempting to delete a role, remove the following attached
        /// items: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Inline policies (<a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DeleteRolePolicy.html">DeleteRolePolicy</a>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Attached managed policies (<a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DetachRolePolicy.html">DetachRolePolicy</a>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Instance profile (<a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_RemoveRoleFromInstanceProfile.html">RemoveRoleFromInstanceProfile</a>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Optional – Delete instance profile after detaching from role for resource clean up
        /// (<a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DeleteInstanceProfile.html">DeleteInstanceProfile</a>)
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// The request was rejected because service-linked roles are protected Amazon Web Services
        /// resources. Only the service that depends on the service-linked role can modify or
        /// delete the role on your behalf. The error message includes the name of the service
        /// that depends on this service-linked role. You must request the change through that
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteRole">REST API Reference for DeleteRole Operation</seealso>
        Task<DeleteRoleResponse> DeleteRoleAsync(DeleteRoleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteRolePermissionsBoundary


        /// <summary>
        /// Deletes the permissions boundary for the specified IAM role. 
        /// 
        ///  
        /// <para>
        /// You cannot set the boundary for a service-linked role.
        /// </para>
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
        /// The request was rejected because service-linked roles are protected Amazon Web Services
        /// resources. Only the service that depends on the service-linked role can modify or
        /// delete the role on your behalf. The error message includes the name of the service
        /// that depends on this service-linked role. You must request the change through that
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteRolePermissionsBoundary">REST API Reference for DeleteRolePermissionsBoundary Operation</seealso>
        DeleteRolePermissionsBoundaryResponse DeleteRolePermissionsBoundary(DeleteRolePermissionsBoundaryRequest request);



        /// <summary>
        /// Deletes the permissions boundary for the specified IAM role. 
        /// 
        ///  
        /// <para>
        /// You cannot set the boundary for a service-linked role.
        /// </para>
        ///  <important> 
        /// <para>
        /// Deleting the permissions boundary for a role might increase its permissions. For example,
        /// it might allow anyone who assumes the role to perform all the actions granted in its
        /// permissions policies.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRolePermissionsBoundary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// The request was rejected because service-linked roles are protected Amazon Web Services
        /// resources. Only the service that depends on the service-linked role can modify or
        /// delete the role on your behalf. The error message includes the name of the service
        /// that depends on this service-linked role. You must request the change through that
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteRolePermissionsBoundary">REST API Reference for DeleteRolePermissionsBoundary Operation</seealso>
        Task<DeleteRolePermissionsBoundaryResponse> DeleteRolePermissionsBoundaryAsync(DeleteRolePermissionsBoundaryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteRolePolicy


        /// <summary>
        /// Deletes the specified inline policy that is embedded in the specified IAM role.
        /// 
        ///  
        /// <para>
        /// A role can also have managed policies attached to it. To detach a managed policy from
        /// a role, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DetachRolePolicy.html">DetachRolePolicy</a>.
        /// For more information about policies, refer to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
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
        /// The request was rejected because service-linked roles are protected Amazon Web Services
        /// resources. Only the service that depends on the service-linked role can modify or
        /// delete the role on your behalf. The error message includes the name of the service
        /// that depends on this service-linked role. You must request the change through that
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteRolePolicy">REST API Reference for DeleteRolePolicy Operation</seealso>
        DeleteRolePolicyResponse DeleteRolePolicy(DeleteRolePolicyRequest request);



        /// <summary>
        /// Deletes the specified inline policy that is embedded in the specified IAM role.
        /// 
        ///  
        /// <para>
        /// A role can also have managed policies attached to it. To detach a managed policy from
        /// a role, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DetachRolePolicy.html">DetachRolePolicy</a>.
        /// For more information about policies, refer to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// policies and inline policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRolePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// The request was rejected because service-linked roles are protected Amazon Web Services
        /// resources. Only the service that depends on the service-linked role can modify or
        /// delete the role on your behalf. The error message includes the name of the service
        /// that depends on this service-linked role. You must request the change through that
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteRolePolicy">REST API Reference for DeleteRolePolicy Operation</seealso>
        Task<DeleteRolePolicyResponse> DeleteRolePolicyAsync(DeleteRolePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteSAMLProviderResponse> DeleteSAMLProviderAsync(DeleteSAMLProviderRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteServerCertificateResponse> DeleteServerCertificateAsync(DeleteServerCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteServiceLinkedRole


        /// <summary>
        /// Submits a service-linked role deletion request and returns a <c>DeletionTaskId</c>,
        /// which you can use to check the status of the deletion. Before you call this operation,
        /// confirm that the role has no active sessions and that any resources used by the role
        /// in the linked service are deleted. If you call this operation more than once for the
        /// same service-linked role and an earlier deletion task is not complete, then the <c>DeletionTaskId</c>
        /// of the earlier request is returned.
        /// 
        ///  
        /// <para>
        /// If you submit a deletion request for a service-linked role whose linked service is
        /// still accessing a resource, then the deletion task fails. If it fails, the <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetServiceLinkedRoleDeletionStatus.html">GetServiceLinkedRoleDeletionStatus</a>
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
        /// Submits a service-linked role deletion request and returns a <c>DeletionTaskId</c>,
        /// which you can use to check the status of the deletion. Before you call this operation,
        /// confirm that the role has no active sessions and that any resources used by the role
        /// in the linked service are deleted. If you call this operation more than once for the
        /// same service-linked role and an earlier deletion task is not complete, then the <c>DeletionTaskId</c>
        /// of the earlier request is returned.
        /// 
        ///  
        /// <para>
        /// If you submit a deletion request for a service-linked role whose linked service is
        /// still accessing a resource, then the deletion task fails. If it fails, the <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetServiceLinkedRoleDeletionStatus.html">GetServiceLinkedRoleDeletionStatus</a>
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteServiceLinkedRoleResponse> DeleteServiceLinkedRoleAsync(DeleteServiceLinkedRoleRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes the specified service-specific credential.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceSpecificCredential service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteServiceSpecificCredential service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteServiceSpecificCredential">REST API Reference for DeleteServiceSpecificCredential Operation</seealso>
        Task<DeleteServiceSpecificCredentialResponse> DeleteServiceSpecificCredentialAsync(DeleteServiceSpecificCredentialRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <exception cref="Amazon.IdentityManagement.Model.ConcurrentModificationException">
        /// The request was rejected because multiple requests to change this object were submitted
        /// simultaneously. Wait a few minutes and submit your request again.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteSigningCertificate">REST API Reference for DeleteSigningCertificate Operation</seealso>
        DeleteSigningCertificateResponse DeleteSigningCertificate(DeleteSigningCertificateRequest request);



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSigningCertificate service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ConcurrentModificationException">
        /// The request was rejected because multiple requests to change this object were submitted
        /// simultaneously. Wait a few minutes and submit your request again.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteSigningCertificate">REST API Reference for DeleteSigningCertificate Operation</seealso>
        Task<DeleteSigningCertificateResponse> DeleteSigningCertificateAsync(DeleteSigningCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSSHPublicKey service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteSSHPublicKey">REST API Reference for DeleteSSHPublicKey Operation</seealso>
        Task<DeleteSSHPublicKeyResponse> DeleteSSHPublicKeyAsync(DeleteSSHPublicKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Password (<a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DeleteLoginProfile.html">DeleteLoginProfile</a>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Access keys (<a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DeleteAccessKey.html">DeleteAccessKey</a>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Signing certificate (<a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DeleteSigningCertificate.html">DeleteSigningCertificate</a>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSH public key (<a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DeleteSSHPublicKey.html">DeleteSSHPublicKey</a>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Git credentials (<a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DeleteServiceSpecificCredential.html">DeleteServiceSpecificCredential</a>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Multi-factor authentication (MFA) device (<a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DeactivateMFADevice.html">DeactivateMFADevice</a>,
        /// <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DeleteVirtualMFADevice.html">DeleteVirtualMFADevice</a>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Inline policies (<a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DeleteUserPolicy.html">DeleteUserPolicy</a>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Attached managed policies (<a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DetachUserPolicy.html">DetachUserPolicy</a>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Group memberships (<a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_RemoveUserFromGroup.html">RemoveUserFromGroup</a>)
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
        /// Deletes the specified IAM user. Unlike the Amazon Web Services Management Console,
        /// when you delete a user programmatically, you must delete the items attached to the
        /// user manually, or the deletion fails. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_users_manage.html#id_users_deleting_cli">Deleting
        /// an IAM user</a>. Before attempting to delete a user, remove the following items:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Password (<a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DeleteLoginProfile.html">DeleteLoginProfile</a>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Access keys (<a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DeleteAccessKey.html">DeleteAccessKey</a>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Signing certificate (<a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DeleteSigningCertificate.html">DeleteSigningCertificate</a>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SSH public key (<a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DeleteSSHPublicKey.html">DeleteSSHPublicKey</a>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Git credentials (<a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DeleteServiceSpecificCredential.html">DeleteServiceSpecificCredential</a>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Multi-factor authentication (MFA) device (<a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DeactivateMFADevice.html">DeactivateMFADevice</a>,
        /// <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DeleteVirtualMFADevice.html">DeleteVirtualMFADevice</a>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Inline policies (<a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DeleteUserPolicy.html">DeleteUserPolicy</a>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Attached managed policies (<a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DetachUserPolicy.html">DetachUserPolicy</a>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Group memberships (<a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_RemoveUserFromGroup.html">RemoveUserFromGroup</a>)
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteUserPermissionsBoundaryResponse> DeleteUserPermissionsBoundaryAsync(DeleteUserPermissionsBoundaryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteUserPolicy


        /// <summary>
        /// Deletes the specified inline policy that is embedded in the specified IAM user.
        /// 
        ///  
        /// <para>
        /// A user can also have managed policies attached to it. To detach a managed policy from
        /// a user, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DetachUserPolicy.html">DetachUserPolicy</a>.
        /// For more information about policies, refer to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
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
        /// Deletes the specified inline policy that is embedded in the specified IAM user.
        /// 
        ///  
        /// <para>
        /// A user can also have managed policies attached to it. To detach a managed policy from
        /// a user, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DetachUserPolicy.html">DetachUserPolicy</a>.
        /// For more information about policies, refer to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// policies and inline policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteUserPolicyResponse> DeleteUserPolicyAsync(DeleteUserPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteVirtualMFADevice


        /// <summary>
        /// Deletes a virtual MFA device.
        /// 
        ///  <note> 
        /// <para>
        ///  You must deactivate a user's virtual MFA device before you can delete it. For information
        /// about deactivating MFA devices, see <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DeactivateMFADevice.html">DeactivateMFADevice</a>.
        /// 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVirtualMFADevice service method.</param>
        /// 
        /// <returns>The response from the DeleteVirtualMFADevice service method, as returned by IdentityManagementService.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteVirtualMFADevice">REST API Reference for DeleteVirtualMFADevice Operation</seealso>
        DeleteVirtualMFADeviceResponse DeleteVirtualMFADevice(DeleteVirtualMFADeviceRequest request);



        /// <summary>
        /// Deletes a virtual MFA device.
        /// 
        ///  <note> 
        /// <para>
        ///  You must deactivate a user's virtual MFA device before you can delete it. For information
        /// about deactivating MFA devices, see <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DeactivateMFADevice.html">DeactivateMFADevice</a>.
        /// 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVirtualMFADevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVirtualMFADevice service method, as returned by IdentityManagementService.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteVirtualMFADevice">REST API Reference for DeleteVirtualMFADevice Operation</seealso>
        Task<DeleteVirtualMFADeviceResponse> DeleteVirtualMFADeviceAsync(DeleteVirtualMFADeviceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DetachGroupPolicy


        /// <summary>
        /// Removes the specified managed policy from the specified IAM group.
        /// 
        ///  
        /// <para>
        /// A group can also have inline policies embedded with it. To delete an inline policy,
        /// use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DeleteGroupPolicy.html">DeleteGroupPolicy</a>.
        /// For information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
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
        /// Removes the specified managed policy from the specified IAM group.
        /// 
        ///  
        /// <para>
        /// A group can also have inline policies embedded with it. To delete an inline policy,
        /// use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DeleteGroupPolicy.html">DeleteGroupPolicy</a>.
        /// For information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// policies and inline policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachGroupPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DetachGroupPolicyResponse> DetachGroupPolicyAsync(DetachGroupPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DetachRolePolicy


        /// <summary>
        /// Removes the specified managed policy from the specified role.
        /// 
        ///  
        /// <para>
        /// A role can also have inline policies embedded with it. To delete an inline policy,
        /// use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DeleteRolePolicy.html">DeleteRolePolicy</a>.
        /// For information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
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
        /// The request was rejected because service-linked roles are protected Amazon Web Services
        /// resources. Only the service that depends on the service-linked role can modify or
        /// delete the role on your behalf. The error message includes the name of the service
        /// that depends on this service-linked role. You must request the change through that
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DetachRolePolicy">REST API Reference for DetachRolePolicy Operation</seealso>
        DetachRolePolicyResponse DetachRolePolicy(DetachRolePolicyRequest request);



        /// <summary>
        /// Removes the specified managed policy from the specified role.
        /// 
        ///  
        /// <para>
        /// A role can also have inline policies embedded with it. To delete an inline policy,
        /// use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DeleteRolePolicy.html">DeleteRolePolicy</a>.
        /// For information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// policies and inline policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachRolePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// The request was rejected because service-linked roles are protected Amazon Web Services
        /// resources. Only the service that depends on the service-linked role can modify or
        /// delete the role on your behalf. The error message includes the name of the service
        /// that depends on this service-linked role. You must request the change through that
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DetachRolePolicy">REST API Reference for DetachRolePolicy Operation</seealso>
        Task<DetachRolePolicyResponse> DetachRolePolicyAsync(DetachRolePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DetachUserPolicy


        /// <summary>
        /// Removes the specified managed policy from the specified user.
        /// 
        ///  
        /// <para>
        /// A user can also have inline policies embedded with it. To delete an inline policy,
        /// use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DeleteUserPolicy.html">DeleteUserPolicy</a>.
        /// For information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
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
        /// Removes the specified managed policy from the specified user.
        /// 
        ///  
        /// <para>
        /// A user can also have inline policies embedded with it. To delete an inline policy,
        /// use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DeleteUserPolicy.html">DeleteUserPolicy</a>.
        /// For information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// policies and inline policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachUserPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DetachUserPolicyResponse> DetachUserPolicyAsync(DetachUserPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisableOrganizationsRootCredentialsManagement


        /// <summary>
        /// Disables the management of privileged root user credentials across member accounts
        /// in your organization. When you disable this feature, the management account and the
        /// delegated administrator for IAM can no longer manage root user credentials for member
        /// accounts in your organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableOrganizationsRootCredentialsManagement service method.</param>
        /// 
        /// <returns>The response from the DisableOrganizationsRootCredentialsManagement service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.AccountNotManagementOrDelegatedAdministratorException">
        /// The request was rejected because the account making the request is not the management
        /// account or delegated administrator account for <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_root-user.html#id_root-user-access-management">centralized
        /// root access</a>.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.OrganizationNotFoundException">
        /// The request was rejected because no organization is associated with your account.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.OrganizationNotInAllFeaturesModeException">
        /// The request was rejected because your organization does not have All features enabled.
        /// For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_getting-started_concepts.html#feature-set">Available
        /// feature sets</a> in the <i>Organizations User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceAccessNotEnabledException">
        /// The request was rejected because trusted access is not enabled for IAM in Organizations.
        /// For details, see IAM and Organizations in the <i>Organizations User Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DisableOrganizationsRootCredentialsManagement">REST API Reference for DisableOrganizationsRootCredentialsManagement Operation</seealso>
        DisableOrganizationsRootCredentialsManagementResponse DisableOrganizationsRootCredentialsManagement(DisableOrganizationsRootCredentialsManagementRequest request);



        /// <summary>
        /// Disables the management of privileged root user credentials across member accounts
        /// in your organization. When you disable this feature, the management account and the
        /// delegated administrator for IAM can no longer manage root user credentials for member
        /// accounts in your organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableOrganizationsRootCredentialsManagement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableOrganizationsRootCredentialsManagement service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.AccountNotManagementOrDelegatedAdministratorException">
        /// The request was rejected because the account making the request is not the management
        /// account or delegated administrator account for <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_root-user.html#id_root-user-access-management">centralized
        /// root access</a>.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.OrganizationNotFoundException">
        /// The request was rejected because no organization is associated with your account.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.OrganizationNotInAllFeaturesModeException">
        /// The request was rejected because your organization does not have All features enabled.
        /// For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_getting-started_concepts.html#feature-set">Available
        /// feature sets</a> in the <i>Organizations User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceAccessNotEnabledException">
        /// The request was rejected because trusted access is not enabled for IAM in Organizations.
        /// For details, see IAM and Organizations in the <i>Organizations User Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DisableOrganizationsRootCredentialsManagement">REST API Reference for DisableOrganizationsRootCredentialsManagement Operation</seealso>
        Task<DisableOrganizationsRootCredentialsManagementResponse> DisableOrganizationsRootCredentialsManagementAsync(DisableOrganizationsRootCredentialsManagementRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisableOrganizationsRootSessions


        /// <summary>
        /// Disables root user sessions for privileged tasks across member accounts in your organization.
        /// When you disable this feature, the management account and the delegated administrator
        /// for IAM can no longer perform privileged tasks on member accounts in your organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableOrganizationsRootSessions service method.</param>
        /// 
        /// <returns>The response from the DisableOrganizationsRootSessions service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.AccountNotManagementOrDelegatedAdministratorException">
        /// The request was rejected because the account making the request is not the management
        /// account or delegated administrator account for <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_root-user.html#id_root-user-access-management">centralized
        /// root access</a>.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.OrganizationNotFoundException">
        /// The request was rejected because no organization is associated with your account.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.OrganizationNotInAllFeaturesModeException">
        /// The request was rejected because your organization does not have All features enabled.
        /// For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_getting-started_concepts.html#feature-set">Available
        /// feature sets</a> in the <i>Organizations User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceAccessNotEnabledException">
        /// The request was rejected because trusted access is not enabled for IAM in Organizations.
        /// For details, see IAM and Organizations in the <i>Organizations User Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DisableOrganizationsRootSessions">REST API Reference for DisableOrganizationsRootSessions Operation</seealso>
        DisableOrganizationsRootSessionsResponse DisableOrganizationsRootSessions(DisableOrganizationsRootSessionsRequest request);



        /// <summary>
        /// Disables root user sessions for privileged tasks across member accounts in your organization.
        /// When you disable this feature, the management account and the delegated administrator
        /// for IAM can no longer perform privileged tasks on member accounts in your organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableOrganizationsRootSessions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableOrganizationsRootSessions service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.AccountNotManagementOrDelegatedAdministratorException">
        /// The request was rejected because the account making the request is not the management
        /// account or delegated administrator account for <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_root-user.html#id_root-user-access-management">centralized
        /// root access</a>.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.OrganizationNotFoundException">
        /// The request was rejected because no organization is associated with your account.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.OrganizationNotInAllFeaturesModeException">
        /// The request was rejected because your organization does not have All features enabled.
        /// For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_getting-started_concepts.html#feature-set">Available
        /// feature sets</a> in the <i>Organizations User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceAccessNotEnabledException">
        /// The request was rejected because trusted access is not enabled for IAM in Organizations.
        /// For details, see IAM and Organizations in the <i>Organizations User Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DisableOrganizationsRootSessions">REST API Reference for DisableOrganizationsRootSessions Operation</seealso>
        Task<DisableOrganizationsRootSessionsResponse> DisableOrganizationsRootSessionsAsync(DisableOrganizationsRootSessionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Enables the specified MFA device and associates it with the specified IAM user. When
        /// enabled, the MFA device is required for every subsequent login by the IAM user associated
        /// with the device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableMFADevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableMFADevice service method, as returned by IdentityManagementService.</returns>
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
        Task<EnableMFADeviceResponse> EnableMFADeviceAsync(EnableMFADeviceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  EnableOrganizationsRootCredentialsManagement


        /// <summary>
        /// Enables the management of privileged root user credentials across member accounts
        /// in your organization. When you enable root credentials management for <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_root-user.html#id_root-user-access-management">centralized
        /// root access</a>, the management account and the delegated administrator for IAM can
        /// manage root user credentials for member accounts in your organization.
        /// 
        ///  
        /// <para>
        /// Before you enable centralized root access, you must have an account configured with
        /// the following settings:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must manage your Amazon Web Services accounts in <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_introduction.html">Organizations</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Enable trusted access for Identity and Access Management in Organizations. For details,
        /// see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/services-that-can-integrate-iam.html">IAM
        /// and Organizations</a> in the <i>Organizations User Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableOrganizationsRootCredentialsManagement service method.</param>
        /// 
        /// <returns>The response from the EnableOrganizationsRootCredentialsManagement service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.AccountNotManagementOrDelegatedAdministratorException">
        /// The request was rejected because the account making the request is not the management
        /// account or delegated administrator account for <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_root-user.html#id_root-user-access-management">centralized
        /// root access</a>.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.CallerIsNotManagementAccountException">
        /// The request was rejected because the account making the request is not the management
        /// account for the organization.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.OrganizationNotFoundException">
        /// The request was rejected because no organization is associated with your account.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.OrganizationNotInAllFeaturesModeException">
        /// The request was rejected because your organization does not have All features enabled.
        /// For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_getting-started_concepts.html#feature-set">Available
        /// feature sets</a> in the <i>Organizations User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceAccessNotEnabledException">
        /// The request was rejected because trusted access is not enabled for IAM in Organizations.
        /// For details, see IAM and Organizations in the <i>Organizations User Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/EnableOrganizationsRootCredentialsManagement">REST API Reference for EnableOrganizationsRootCredentialsManagement Operation</seealso>
        EnableOrganizationsRootCredentialsManagementResponse EnableOrganizationsRootCredentialsManagement(EnableOrganizationsRootCredentialsManagementRequest request);



        /// <summary>
        /// Enables the management of privileged root user credentials across member accounts
        /// in your organization. When you enable root credentials management for <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_root-user.html#id_root-user-access-management">centralized
        /// root access</a>, the management account and the delegated administrator for IAM can
        /// manage root user credentials for member accounts in your organization.
        /// 
        ///  
        /// <para>
        /// Before you enable centralized root access, you must have an account configured with
        /// the following settings:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must manage your Amazon Web Services accounts in <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_introduction.html">Organizations</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Enable trusted access for Identity and Access Management in Organizations. For details,
        /// see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/services-that-can-integrate-iam.html">IAM
        /// and Organizations</a> in the <i>Organizations User Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableOrganizationsRootCredentialsManagement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableOrganizationsRootCredentialsManagement service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.AccountNotManagementOrDelegatedAdministratorException">
        /// The request was rejected because the account making the request is not the management
        /// account or delegated administrator account for <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_root-user.html#id_root-user-access-management">centralized
        /// root access</a>.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.CallerIsNotManagementAccountException">
        /// The request was rejected because the account making the request is not the management
        /// account for the organization.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.OrganizationNotFoundException">
        /// The request was rejected because no organization is associated with your account.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.OrganizationNotInAllFeaturesModeException">
        /// The request was rejected because your organization does not have All features enabled.
        /// For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_getting-started_concepts.html#feature-set">Available
        /// feature sets</a> in the <i>Organizations User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceAccessNotEnabledException">
        /// The request was rejected because trusted access is not enabled for IAM in Organizations.
        /// For details, see IAM and Organizations in the <i>Organizations User Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/EnableOrganizationsRootCredentialsManagement">REST API Reference for EnableOrganizationsRootCredentialsManagement Operation</seealso>
        Task<EnableOrganizationsRootCredentialsManagementResponse> EnableOrganizationsRootCredentialsManagementAsync(EnableOrganizationsRootCredentialsManagementRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  EnableOrganizationsRootSessions


        /// <summary>
        /// Allows the management account or delegated administrator to perform privileged tasks
        /// on member accounts in your organization. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_root-user.html#id_root-user-access-management">Centrally
        /// manage root access for member accounts</a> in the <i>Identity and Access Management
        /// User Guide</i>.
        /// 
        ///  
        /// <para>
        /// Before you enable this feature, you must have an account configured with the following
        /// settings:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must manage your Amazon Web Services accounts in <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_introduction.html">Organizations</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Enable trusted access for Identity and Access Management in Organizations. For details,
        /// see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/services-that-can-integrate-ra.html">IAM
        /// and Organizations</a> in the <i>Organizations User Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableOrganizationsRootSessions service method.</param>
        /// 
        /// <returns>The response from the EnableOrganizationsRootSessions service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.AccountNotManagementOrDelegatedAdministratorException">
        /// The request was rejected because the account making the request is not the management
        /// account or delegated administrator account for <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_root-user.html#id_root-user-access-management">centralized
        /// root access</a>.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.CallerIsNotManagementAccountException">
        /// The request was rejected because the account making the request is not the management
        /// account for the organization.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.OrganizationNotFoundException">
        /// The request was rejected because no organization is associated with your account.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.OrganizationNotInAllFeaturesModeException">
        /// The request was rejected because your organization does not have All features enabled.
        /// For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_getting-started_concepts.html#feature-set">Available
        /// feature sets</a> in the <i>Organizations User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceAccessNotEnabledException">
        /// The request was rejected because trusted access is not enabled for IAM in Organizations.
        /// For details, see IAM and Organizations in the <i>Organizations User Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/EnableOrganizationsRootSessions">REST API Reference for EnableOrganizationsRootSessions Operation</seealso>
        EnableOrganizationsRootSessionsResponse EnableOrganizationsRootSessions(EnableOrganizationsRootSessionsRequest request);



        /// <summary>
        /// Allows the management account or delegated administrator to perform privileged tasks
        /// on member accounts in your organization. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_root-user.html#id_root-user-access-management">Centrally
        /// manage root access for member accounts</a> in the <i>Identity and Access Management
        /// User Guide</i>.
        /// 
        ///  
        /// <para>
        /// Before you enable this feature, you must have an account configured with the following
        /// settings:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must manage your Amazon Web Services accounts in <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_introduction.html">Organizations</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Enable trusted access for Identity and Access Management in Organizations. For details,
        /// see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/services-that-can-integrate-ra.html">IAM
        /// and Organizations</a> in the <i>Organizations User Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableOrganizationsRootSessions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableOrganizationsRootSessions service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.AccountNotManagementOrDelegatedAdministratorException">
        /// The request was rejected because the account making the request is not the management
        /// account or delegated administrator account for <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_root-user.html#id_root-user-access-management">centralized
        /// root access</a>.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.CallerIsNotManagementAccountException">
        /// The request was rejected because the account making the request is not the management
        /// account for the organization.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.OrganizationNotFoundException">
        /// The request was rejected because no organization is associated with your account.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.OrganizationNotInAllFeaturesModeException">
        /// The request was rejected because your organization does not have All features enabled.
        /// For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_getting-started_concepts.html#feature-set">Available
        /// feature sets</a> in the <i>Organizations User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceAccessNotEnabledException">
        /// The request was rejected because trusted access is not enabled for IAM in Organizations.
        /// For details, see IAM and Organizations in the <i>Organizations User Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/EnableOrganizationsRootSessions">REST API Reference for EnableOrganizationsRootSessions Operation</seealso>
        Task<EnableOrganizationsRootSessionsResponse> EnableOrganizationsRootSessionsAsync(EnableOrganizationsRootSessionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Generates a credential report for the Amazon Web Services account. For more information
        /// about the credential report, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/credential-reports.html">Getting
        /// credential reports</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GenerateCredentialReportResponse> GenerateCredentialReportAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Generates a credential report for the Amazon Web Services account. For more information
        /// about the credential report, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/credential-reports.html">Getting
        /// credential reports</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateCredentialReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GenerateCredentialReportResponse> GenerateCredentialReportAsync(GenerateCredentialReportRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// This operation returns a <c>JobId</c>. Use this parameter in the <c> <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetOrganizationsAccessReport.html">GetOrganizationsAccessReport</a>
        /// </c> operation to check the status of the report generation. To check the status of
        /// this request, use the <c>JobId</c> parameter in the <c> <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetOrganizationsAccessReport.html">GetOrganizationsAccessReport</a>
        /// </c> operation and test the <c>JobStatus</c> response parameter. When the job is complete,
        /// you can retrieve the report.
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
        /// This operation returns a <c>JobId</c>. Use this parameter in the <c> <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetOrganizationsAccessReport.html">GetOrganizationsAccessReport</a>
        /// </c> operation to check the status of the report generation. To check the status of
        /// this request, use the <c>JobId</c> parameter in the <c> <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetOrganizationsAccessReport.html">GetOrganizationsAccessReport</a>
        /// </c> operation and test the <c>JobStatus</c> response parameter. When the job is complete,
        /// you can retrieve the report.
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GenerateOrganizationsAccessReport service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ReportGenerationLimitExceededException">
        /// The request failed because the maximum number of concurrent requests for this account
        /// are already running.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GenerateOrganizationsAccessReport">REST API Reference for GenerateOrganizationsAccessReport Operation</seealso>
        Task<GenerateOrganizationsAccessReportResponse> GenerateOrganizationsAccessReportAsync(GenerateOrganizationsAccessReportRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GenerateServiceLastAccessedDetails


        /// <summary>
        /// Generates a report that includes details about when an IAM resource (user, group,
        /// role, or policy) was last used in an attempt to access Amazon Web Services services.
        /// Recent activity usually appears within four hours. IAM reports activity for at least
        /// the last 400 days, or less if your Region began supporting this feature within the
        /// last year. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_access-advisor.html#access-advisor_tracking-period">Regions
        /// where data is tracked</a>. For more information about services and actions for which
        /// action last accessed information is displayed, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_access-advisor-action-last-accessed.html">IAM
        /// action last accessed information services and actions</a>.
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
        /// The <c>GenerateServiceLastAccessedDetails</c> operation returns a <c>JobId</c>. Use
        /// this parameter in the following operations to retrieve the following details from
        /// your report: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetServiceLastAccessedDetails.html">GetServiceLastAccessedDetails</a>
        /// – Use this operation for users, groups, roles, or policies to list every Amazon Web
        /// Services service that the resource could access using permissions policies. For each
        /// service, the response includes information about the most recent access attempt.
        /// </para>
        ///  
        /// <para>
        /// The <c>JobId</c> returned by <c>GenerateServiceLastAccessedDetail</c> must be used
        /// by the same role within a session, or by the same user when used to call <c>GetServiceLastAccessedDetail</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetServiceLastAccessedDetailsWithEntities.html">GetServiceLastAccessedDetailsWithEntities</a>
        /// – Use this operation for groups and policies to list information about the associated
        /// entities (users or roles) that attempted to access a specific Amazon Web Services
        /// service. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To check the status of the <c>GenerateServiceLastAccessedDetails</c> request, use
        /// the <c>JobId</c> parameter in the same operations and test the <c>JobStatus</c> response
        /// parameter.
        /// </para>
        ///  
        /// <para>
        /// For additional information about the permissions policies that allow an identity (user,
        /// group, or role) to access specific services, use the <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ListPoliciesGrantingServiceAccess.html">ListPoliciesGrantingServiceAccess</a>
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
        /// Generates a report that includes details about when an IAM resource (user, group,
        /// role, or policy) was last used in an attempt to access Amazon Web Services services.
        /// Recent activity usually appears within four hours. IAM reports activity for at least
        /// the last 400 days, or less if your Region began supporting this feature within the
        /// last year. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_access-advisor.html#access-advisor_tracking-period">Regions
        /// where data is tracked</a>. For more information about services and actions for which
        /// action last accessed information is displayed, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_access-advisor-action-last-accessed.html">IAM
        /// action last accessed information services and actions</a>.
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
        /// The <c>GenerateServiceLastAccessedDetails</c> operation returns a <c>JobId</c>. Use
        /// this parameter in the following operations to retrieve the following details from
        /// your report: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetServiceLastAccessedDetails.html">GetServiceLastAccessedDetails</a>
        /// – Use this operation for users, groups, roles, or policies to list every Amazon Web
        /// Services service that the resource could access using permissions policies. For each
        /// service, the response includes information about the most recent access attempt.
        /// </para>
        ///  
        /// <para>
        /// The <c>JobId</c> returned by <c>GenerateServiceLastAccessedDetail</c> must be used
        /// by the same role within a session, or by the same user when used to call <c>GetServiceLastAccessedDetail</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetServiceLastAccessedDetailsWithEntities.html">GetServiceLastAccessedDetailsWithEntities</a>
        /// – Use this operation for groups and policies to list information about the associated
        /// entities (users or roles) that attempted to access a specific Amazon Web Services
        /// service. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To check the status of the <c>GenerateServiceLastAccessedDetails</c> request, use
        /// the <c>JobId</c> parameter in the same operations and test the <c>JobStatus</c> response
        /// parameter.
        /// </para>
        ///  
        /// <para>
        /// For additional information about the permissions policies that allow an identity (user,
        /// group, or role) to access specific services, use the <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ListPoliciesGrantingServiceAccess.html">ListPoliciesGrantingServiceAccess</a>
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GenerateServiceLastAccessedDetailsResponse> GenerateServiceLastAccessedDetailsAsync(GenerateServiceLastAccessedDetailsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetAccessKeyLastUsed">REST API Reference for GetAccessKeyLastUsed Operation</seealso>
        GetAccessKeyLastUsedResponse GetAccessKeyLastUsed(GetAccessKeyLastUsedRequest request);



        /// <summary>
        /// Retrieves information about when the specified access key was last used. The information
        /// includes the date and time of last use, along with the Amazon Web Services service
        /// and Region that were specified in the last request made with that key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessKeyLastUsed service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccessKeyLastUsed service method, as returned by IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetAccessKeyLastUsed">REST API Reference for GetAccessKeyLastUsed Operation</seealso>
        Task<GetAccessKeyLastUsedResponse> GetAccessKeyLastUsedAsync(GetAccessKeyLastUsedRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// text. For example, if you use Java, you can use the <c>decode</c> method of the <c>java.net.URLDecoder</c>
        /// utility class in the Java SDK. Other languages and SDKs provide similar functionality,
        /// and some SDKs do this decoding automatically.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can optionally filter the results using the <c>Filter</c> parameter. You can paginate
        /// the results using the <c>MaxItems</c> and <c>Marker</c> parameters.
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
        /// Retrieves information about all IAM users, groups, roles, and policies in your Amazon
        /// Web Services account, including their relationships to one another. Use this operation
        /// to obtain a snapshot of the configuration of IAM permissions (users, groups, roles,
        /// and policies) in your account.
        /// 
        ///  <note> 
        /// <para>
        /// Policies returned by this operation are URL-encoded compliant with <a href="https://tools.ietf.org/html/rfc3986">RFC
        /// 3986</a>. You can use a URL decoding method to convert the policy back to plain JSON
        /// text. For example, if you use Java, you can use the <c>decode</c> method of the <c>java.net.URLDecoder</c>
        /// utility class in the Java SDK. Other languages and SDKs provide similar functionality,
        /// and some SDKs do this decoding automatically.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can optionally filter the results using the <c>Filter</c> parameter. You can paginate
        /// the results using the <c>MaxItems</c> and <c>Marker</c> parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountAuthorizationDetails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccountAuthorizationDetails service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetAccountAuthorizationDetails">REST API Reference for GetAccountAuthorizationDetails Operation</seealso>
        Task<GetAccountAuthorizationDetailsResponse> GetAccountAuthorizationDetailsAsync(GetAccountAuthorizationDetailsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Retrieves the password policy for the Amazon Web Services account. This tells you
        /// the complexity requirements and mandatory rotation periods for the IAM user passwords
        /// in your account. For more information about using a password policy, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingPasswordPolicies.html">Managing
        /// an IAM password policy</a>.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetAccountPasswordPolicyResponse> GetAccountPasswordPolicyAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Retrieves the password policy for the Amazon Web Services account. This tells you
        /// the complexity requirements and mandatory rotation periods for the IAM user passwords
        /// in your account. For more information about using a password policy, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingPasswordPolicies.html">Managing
        /// an IAM password policy</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountPasswordPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetAccountPasswordPolicyResponse> GetAccountPasswordPolicyAsync(GetAccountPasswordPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Retrieves information about IAM entity usage and IAM quotas in the Amazon Web Services
        /// account.
        /// 
        ///  
        /// <para>
        ///  For information about IAM quotas, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_iam-quotas.html">IAM
        /// and STS quotas</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccountSummary service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetAccountSummary">REST API Reference for GetAccountSummary Operation</seealso>
        Task<GetAccountSummaryResponse> GetAccountSummaryAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccountSummary service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetAccountSummary">REST API Reference for GetAccountSummary Operation</seealso>
        Task<GetAccountSummaryResponse> GetAccountSummaryAsync(GetAccountSummaryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetContextKeysForCustomPolicy


        /// <summary>
        /// Gets a list of all of the context keys referenced in the input policies. The policies
        /// are supplied as a list of one or more strings. To get the context keys from policies
        /// associated with an IAM user, group, or role, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetContextKeysForPrincipalPolicy.html">GetContextKeysForPrincipalPolicy</a>.
        /// 
        ///  
        /// <para>
        /// Context keys are variables maintained by Amazon Web Services and its services that
        /// provide details about the context of an API query request. Context keys can be evaluated
        /// by testing against a value specified in an IAM policy. Use <c>GetContextKeysForCustomPolicy</c>
        /// to understand what key names and values you must supply when you call <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_SimulateCustomPolicy.html">SimulateCustomPolicy</a>.
        /// Note that all parameters are shown in unencoded form here for clarity but must be
        /// URL encoded to be included as a part of a real HTML request.
        /// </para>
        /// </summary>
        /// <param name="policyInputList">A list of policies for which you want the list of context keys referenced in those policies. Each document is specified as a string containing the complete, valid JSON text of an IAM policy. The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> used to validate this parameter is a string of characters consisting of the following: <ul> <li> Any printable ASCII character ranging from the space character (<c>\u0020</c>) through the end of the ASCII character range </li> <li> The printable characters in the Basic Latin and Latin-1 Supplement character set (through <c>\u00FF</c>) </li> <li> The special characters tab (<c>\u0009</c>), line feed (<c>\u000A</c>), and carriage return (<c>\u000D</c>) </li> </ul></param>
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
        /// associated with an IAM user, group, or role, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetContextKeysForPrincipalPolicy.html">GetContextKeysForPrincipalPolicy</a>.
        /// 
        ///  
        /// <para>
        /// Context keys are variables maintained by Amazon Web Services and its services that
        /// provide details about the context of an API query request. Context keys can be evaluated
        /// by testing against a value specified in an IAM policy. Use <c>GetContextKeysForCustomPolicy</c>
        /// to understand what key names and values you must supply when you call <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_SimulateCustomPolicy.html">SimulateCustomPolicy</a>.
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
        /// Gets a list of all of the context keys referenced in the input policies. The policies
        /// are supplied as a list of one or more strings. To get the context keys from policies
        /// associated with an IAM user, group, or role, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetContextKeysForPrincipalPolicy.html">GetContextKeysForPrincipalPolicy</a>.
        /// 
        ///  
        /// <para>
        /// Context keys are variables maintained by Amazon Web Services and its services that
        /// provide details about the context of an API query request. Context keys can be evaluated
        /// by testing against a value specified in an IAM policy. Use <c>GetContextKeysForCustomPolicy</c>
        /// to understand what key names and values you must supply when you call <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_SimulateCustomPolicy.html">SimulateCustomPolicy</a>.
        /// Note that all parameters are shown in unencoded form here for clarity but must be
        /// URL encoded to be included as a part of a real HTML request.
        /// </para>
        /// </summary>
        /// <param name="policyInputList">A list of policies for which you want the list of context keys referenced in those policies. Each document is specified as a string containing the complete, valid JSON text of an IAM policy. The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> used to validate this parameter is a string of characters consisting of the following: <ul> <li> Any printable ASCII character ranging from the space character (<c>\u0020</c>) through the end of the ASCII character range </li> <li> The printable characters in the Basic Latin and Latin-1 Supplement character set (through <c>\u00FF</c>) </li> <li> The special characters tab (<c>\u0009</c>), line feed (<c>\u000A</c>), and carriage return (<c>\u000D</c>) </li> </ul></param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetContextKeysForCustomPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetContextKeysForCustomPolicy">REST API Reference for GetContextKeysForCustomPolicy Operation</seealso>
        Task<GetContextKeysForCustomPolicyResponse> GetContextKeysForCustomPolicyAsync(List<string> policyInputList, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Gets a list of all of the context keys referenced in the input policies. The policies
        /// are supplied as a list of one or more strings. To get the context keys from policies
        /// associated with an IAM user, group, or role, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetContextKeysForPrincipalPolicy.html">GetContextKeysForPrincipalPolicy</a>.
        /// 
        ///  
        /// <para>
        /// Context keys are variables maintained by Amazon Web Services and its services that
        /// provide details about the context of an API query request. Context keys can be evaluated
        /// by testing against a value specified in an IAM policy. Use <c>GetContextKeysForCustomPolicy</c>
        /// to understand what key names and values you must supply when you call <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_SimulateCustomPolicy.html">SimulateCustomPolicy</a>.
        /// Note that all parameters are shown in unencoded form here for clarity but must be
        /// URL encoded to be included as a part of a real HTML request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContextKeysForCustomPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetContextKeysForCustomPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetContextKeysForCustomPolicy">REST API Reference for GetContextKeysForCustomPolicy Operation</seealso>
        Task<GetContextKeysForCustomPolicyResponse> GetContextKeysForCustomPolicyAsync(GetContextKeysForCustomPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// strings. If you want to include <i>only</i> a list of policies by string, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetContextKeysForCustomPolicy.html">GetContextKeysForCustomPolicy</a>
        /// instead.
        /// </para>
        ///  
        /// <para>
        ///  <b>Note:</b> This operation discloses information about the permissions granted to
        /// other users. If you do not want users to see other user's permissions, then consider
        /// allowing them to use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetContextKeysForCustomPolicy.html">GetContextKeysForCustomPolicy</a>
        /// instead.
        /// </para>
        ///  
        /// <para>
        /// Context keys are variables maintained by Amazon Web Services and its services that
        /// provide details about the context of an API query request. Context keys can be evaluated
        /// by testing against a value in an IAM policy. Use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetContextKeysForPrincipalPolicy.html">GetContextKeysForPrincipalPolicy</a>
        /// to understand what key names and values you must supply when you call <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_SimulatePrincipalPolicy.html">SimulatePrincipalPolicy</a>.
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
        /// strings. If you want to include <i>only</i> a list of policies by string, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetContextKeysForCustomPolicy.html">GetContextKeysForCustomPolicy</a>
        /// instead.
        /// </para>
        ///  
        /// <para>
        ///  <b>Note:</b> This operation discloses information about the permissions granted to
        /// other users. If you do not want users to see other user's permissions, then consider
        /// allowing them to use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetContextKeysForCustomPolicy.html">GetContextKeysForCustomPolicy</a>
        /// instead.
        /// </para>
        ///  
        /// <para>
        /// Context keys are variables maintained by Amazon Web Services and its services that
        /// provide details about the context of an API query request. Context keys can be evaluated
        /// by testing against a value in an IAM policy. Use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetContextKeysForPrincipalPolicy.html">GetContextKeysForPrincipalPolicy</a>
        /// to understand what key names and values you must supply when you call <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_SimulatePrincipalPolicy.html">SimulatePrincipalPolicy</a>.
        /// </para>
        /// </summary>
        /// <param name="policySourceArn">The ARN of a user, group, or role whose policies contain the context keys that you want listed. If you specify a user, the list includes context keys that are found in all policies that are attached to the user. The list also includes all groups that the user is a member of. If you pick a group or a role, then it includes only those context keys that are found in policies attached to that entity. Note that all parameters are shown in unencoded form here for clarity, but must be URL encoded to be included as a part of a real HTML request. For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon Resource Names (ARNs)</a> in the <i>Amazon Web Services General Reference</i>.</param>
        /// <param name="policyInputList">An optional list of additional policies for which you want the list of context keys that are referenced. The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> used to validate this parameter is a string of characters consisting of the following: <ul> <li> Any printable ASCII character ranging from the space character (<c>\u0020</c>) through the end of the ASCII character range </li> <li> The printable characters in the Basic Latin and Latin-1 Supplement character set (through <c>\u00FF</c>) </li> <li> The special characters tab (<c>\u0009</c>), line feed (<c>\u000A</c>), and carriage return (<c>\u000D</c>) </li> </ul></param>
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
        /// strings. If you want to include <i>only</i> a list of policies by string, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetContextKeysForCustomPolicy.html">GetContextKeysForCustomPolicy</a>
        /// instead.
        /// </para>
        ///  
        /// <para>
        ///  <b>Note:</b> This operation discloses information about the permissions granted to
        /// other users. If you do not want users to see other user's permissions, then consider
        /// allowing them to use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetContextKeysForCustomPolicy.html">GetContextKeysForCustomPolicy</a>
        /// instead.
        /// </para>
        ///  
        /// <para>
        /// Context keys are variables maintained by Amazon Web Services and its services that
        /// provide details about the context of an API query request. Context keys can be evaluated
        /// by testing against a value in an IAM policy. Use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetContextKeysForPrincipalPolicy.html">GetContextKeysForPrincipalPolicy</a>
        /// to understand what key names and values you must supply when you call <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_SimulatePrincipalPolicy.html">SimulatePrincipalPolicy</a>.
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
        /// Gets a list of all of the context keys referenced in all the IAM policies that are
        /// attached to the specified IAM entity. The entity can be an IAM user, group, or role.
        /// If you specify a user, then the request also includes all of the policies attached
        /// to groups that the user is a member of.
        /// 
        ///  
        /// <para>
        /// You can optionally include a list of one or more additional policies, specified as
        /// strings. If you want to include <i>only</i> a list of policies by string, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetContextKeysForCustomPolicy.html">GetContextKeysForCustomPolicy</a>
        /// instead.
        /// </para>
        ///  
        /// <para>
        ///  <b>Note:</b> This operation discloses information about the permissions granted to
        /// other users. If you do not want users to see other user's permissions, then consider
        /// allowing them to use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetContextKeysForCustomPolicy.html">GetContextKeysForCustomPolicy</a>
        /// instead.
        /// </para>
        ///  
        /// <para>
        /// Context keys are variables maintained by Amazon Web Services and its services that
        /// provide details about the context of an API query request. Context keys can be evaluated
        /// by testing against a value in an IAM policy. Use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetContextKeysForPrincipalPolicy.html">GetContextKeysForPrincipalPolicy</a>
        /// to understand what key names and values you must supply when you call <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_SimulatePrincipalPolicy.html">SimulatePrincipalPolicy</a>.
        /// </para>
        /// </summary>
        /// <param name="policySourceArn">The ARN of a user, group, or role whose policies contain the context keys that you want listed. If you specify a user, the list includes context keys that are found in all policies that are attached to the user. The list also includes all groups that the user is a member of. If you pick a group or a role, then it includes only those context keys that are found in policies attached to that entity. Note that all parameters are shown in unencoded form here for clarity, but must be URL encoded to be included as a part of a real HTML request. For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon Resource Names (ARNs)</a> in the <i>Amazon Web Services General Reference</i>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetContextKeysForPrincipalPolicyResponse> GetContextKeysForPrincipalPolicyAsync(string policySourceArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets a list of all of the context keys referenced in all the IAM policies that are
        /// attached to the specified IAM entity. The entity can be an IAM user, group, or role.
        /// If you specify a user, then the request also includes all of the policies attached
        /// to groups that the user is a member of.
        /// 
        ///  
        /// <para>
        /// You can optionally include a list of one or more additional policies, specified as
        /// strings. If you want to include <i>only</i> a list of policies by string, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetContextKeysForCustomPolicy.html">GetContextKeysForCustomPolicy</a>
        /// instead.
        /// </para>
        ///  
        /// <para>
        ///  <b>Note:</b> This operation discloses information about the permissions granted to
        /// other users. If you do not want users to see other user's permissions, then consider
        /// allowing them to use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetContextKeysForCustomPolicy.html">GetContextKeysForCustomPolicy</a>
        /// instead.
        /// </para>
        ///  
        /// <para>
        /// Context keys are variables maintained by Amazon Web Services and its services that
        /// provide details about the context of an API query request. Context keys can be evaluated
        /// by testing against a value in an IAM policy. Use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetContextKeysForPrincipalPolicy.html">GetContextKeysForPrincipalPolicy</a>
        /// to understand what key names and values you must supply when you call <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_SimulatePrincipalPolicy.html">SimulatePrincipalPolicy</a>.
        /// </para>
        /// </summary>
        /// <param name="policySourceArn">The ARN of a user, group, or role whose policies contain the context keys that you want listed. If you specify a user, the list includes context keys that are found in all policies that are attached to the user. The list also includes all groups that the user is a member of. If you pick a group or a role, then it includes only those context keys that are found in policies attached to that entity. Note that all parameters are shown in unencoded form here for clarity, but must be URL encoded to be included as a part of a real HTML request. For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon Resource Names (ARNs)</a> in the <i>Amazon Web Services General Reference</i>.</param>
        /// <param name="policyInputList">An optional list of additional policies for which you want the list of context keys that are referenced. The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> used to validate this parameter is a string of characters consisting of the following: <ul> <li> Any printable ASCII character ranging from the space character (<c>\u0020</c>) through the end of the ASCII character range </li> <li> The printable characters in the Basic Latin and Latin-1 Supplement character set (through <c>\u00FF</c>) </li> <li> The special characters tab (<c>\u0009</c>), line feed (<c>\u000A</c>), and carriage return (<c>\u000D</c>) </li> </ul></param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetContextKeysForPrincipalPolicyResponse> GetContextKeysForPrincipalPolicyAsync(string policySourceArn, List<string> policyInputList, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Gets a list of all of the context keys referenced in all the IAM policies that are
        /// attached to the specified IAM entity. The entity can be an IAM user, group, or role.
        /// If you specify a user, then the request also includes all of the policies attached
        /// to groups that the user is a member of.
        /// 
        ///  
        /// <para>
        /// You can optionally include a list of one or more additional policies, specified as
        /// strings. If you want to include <i>only</i> a list of policies by string, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetContextKeysForCustomPolicy.html">GetContextKeysForCustomPolicy</a>
        /// instead.
        /// </para>
        ///  
        /// <para>
        ///  <b>Note:</b> This operation discloses information about the permissions granted to
        /// other users. If you do not want users to see other user's permissions, then consider
        /// allowing them to use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetContextKeysForCustomPolicy.html">GetContextKeysForCustomPolicy</a>
        /// instead.
        /// </para>
        ///  
        /// <para>
        /// Context keys are variables maintained by Amazon Web Services and its services that
        /// provide details about the context of an API query request. Context keys can be evaluated
        /// by testing against a value in an IAM policy. Use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetContextKeysForPrincipalPolicy.html">GetContextKeysForPrincipalPolicy</a>
        /// to understand what key names and values you must supply when you call <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_SimulatePrincipalPolicy.html">SimulatePrincipalPolicy</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetContextKeysForPrincipalPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetContextKeysForPrincipalPolicyResponse> GetContextKeysForPrincipalPolicyAsync(GetContextKeysForPrincipalPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// generate a new credential report, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GenerateCredentialReport.html">GenerateCredentialReport</a>.
        /// For more information about credential report expiration, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/credential-reports.html">Getting
        /// credential reports</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.CredentialReportNotPresentException">
        /// The request was rejected because the credential report does not exist. To generate
        /// a credential report, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GenerateCredentialReport.html">GenerateCredentialReport</a>.
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
        /// generate a new credential report, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GenerateCredentialReport.html">GenerateCredentialReport</a>.
        /// For more information about credential report expiration, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/credential-reports.html">Getting
        /// credential reports</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.CredentialReportNotPresentException">
        /// The request was rejected because the credential report does not exist. To generate
        /// a credential report, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GenerateCredentialReport.html">GenerateCredentialReport</a>.
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
        /// Retrieves a credential report for the Amazon Web Services account. For more information
        /// about the credential report, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/credential-reports.html">Getting
        /// credential reports</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCredentialReport service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.CredentialReportExpiredException">
        /// The request was rejected because the most recent credential report has expired. To
        /// generate a new credential report, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GenerateCredentialReport.html">GenerateCredentialReport</a>.
        /// For more information about credential report expiration, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/credential-reports.html">Getting
        /// credential reports</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.CredentialReportNotPresentException">
        /// The request was rejected because the credential report does not exist. To generate
        /// a credential report, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GenerateCredentialReport.html">GenerateCredentialReport</a>.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.CredentialReportNotReadyException">
        /// The request was rejected because the credential report is still being generated.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetCredentialReport">REST API Reference for GetCredentialReport Operation</seealso>
        Task<GetCredentialReportResponse> GetCredentialReportAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Retrieves a credential report for the Amazon Web Services account. For more information
        /// about the credential report, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/credential-reports.html">Getting
        /// credential reports</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCredentialReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCredentialReport service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.CredentialReportExpiredException">
        /// The request was rejected because the most recent credential report has expired. To
        /// generate a new credential report, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GenerateCredentialReport.html">GenerateCredentialReport</a>.
        /// For more information about credential report expiration, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/credential-reports.html">Getting
        /// credential reports</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.CredentialReportNotPresentException">
        /// The request was rejected because the credential report does not exist. To generate
        /// a credential report, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GenerateCredentialReport.html">GenerateCredentialReport</a>.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.CredentialReportNotReadyException">
        /// The request was rejected because the credential report is still being generated.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetCredentialReport">REST API Reference for GetCredentialReport Operation</seealso>
        Task<GetCredentialReportResponse> GetCredentialReportAsync(GetCredentialReportRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetGroup


        /// <summary>
        /// Returns a list of IAM users that are in the specified IAM group. You can paginate
        /// the results using the <c>MaxItems</c> and <c>Marker</c> parameters.
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
        /// Returns a list of IAM users that are in the specified IAM group. You can paginate
        /// the results using the <c>MaxItems</c> and <c>Marker</c> parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetGroupResponse> GetGroupAsync(GetGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// text. For example, if you use Java, you can use the <c>decode</c> method of the <c>java.net.URLDecoder</c>
        /// utility class in the Java SDK. Other languages and SDKs provide similar functionality,
        /// and some SDKs do this decoding automatically.
        /// </para>
        ///  </note> 
        /// <para>
        /// An IAM group can also have managed policies attached to it. To retrieve a managed
        /// policy document that is attached to a group, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetPolicy.html">GetPolicy</a>
        /// to determine the policy's default version, then use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetPolicyVersion.html">GetPolicyVersion</a>
        /// to retrieve the policy document.
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
        /// Retrieves the specified inline policy document that is embedded in the specified IAM
        /// group.
        /// 
        ///  <note> 
        /// <para>
        /// Policies returned by this operation are URL-encoded compliant with <a href="https://tools.ietf.org/html/rfc3986">RFC
        /// 3986</a>. You can use a URL decoding method to convert the policy back to plain JSON
        /// text. For example, if you use Java, you can use the <c>decode</c> method of the <c>java.net.URLDecoder</c>
        /// utility class in the Java SDK. Other languages and SDKs provide similar functionality,
        /// and some SDKs do this decoding automatically.
        /// </para>
        ///  </note> 
        /// <para>
        /// An IAM group can also have managed policies attached to it. To retrieve a managed
        /// policy document that is attached to a group, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetPolicy.html">GetPolicy</a>
        /// to determine the policy's default version, then use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetPolicyVersion.html">GetPolicyVersion</a>
        /// to retrieve the policy document.
        /// </para>
        ///  
        /// <para>
        /// For more information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// policies and inline policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroupPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetGroupPolicyResponse> GetGroupPolicyAsync(GetGroupPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetInstanceProfile


        /// <summary>
        /// Retrieves information about the specified instance profile, including the instance
        /// profile's path, GUID, ARN, and role. For more information about instance profiles,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use_switch-role-ec2_instance-profiles.html">Using
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
        /// Retrieves information about the specified instance profile, including the instance
        /// profile's path, GUID, ARN, and role. For more information about instance profiles,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use_switch-role-ec2_instance-profiles.html">Using
        /// instance profiles</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetInstanceProfileResponse> GetInstanceProfileAsync(GetInstanceProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetLoginProfile


        /// <summary>
        /// Retrieves the user name for the specified IAM user. A login profile is created when
        /// you create a password for the user to access the Amazon Web Services Management Console.
        /// If the user does not exist or does not have a password, the operation returns a 404
        /// (<c>NoSuchEntity</c>) error.
        /// 
        ///  
        /// <para>
        /// If you create an IAM user with access to the console, the <c>CreateDate</c> reflects
        /// the date you created the initial password for the user.
        /// </para>
        ///  
        /// <para>
        /// If you create an IAM user with programmatic access, and then later add a password
        /// for the user to access the Amazon Web Services Management Console, the <c>CreateDate</c>
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
        /// Retrieves the user name for the specified IAM user. A login profile is created when
        /// you create a password for the user to access the Amazon Web Services Management Console.
        /// If the user does not exist or does not have a password, the operation returns a 404
        /// (<c>NoSuchEntity</c>) error.
        /// 
        ///  
        /// <para>
        /// If you create an IAM user with access to the console, the <c>CreateDate</c> reflects
        /// the date you created the initial password for the user.
        /// </para>
        ///  
        /// <para>
        /// If you create an IAM user with programmatic access, and then later add a password
        /// for the user to access the Amazon Web Services Management Console, the <c>CreateDate</c>
        /// reflects the initial password creation date. A user with programmatic access does
        /// not have a login profile unless you create a password for the user to access the Amazon
        /// Web Services Management Console.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLoginProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetLoginProfileResponse> GetLoginProfileAsync(GetLoginProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetMFADevice


        /// <summary>
        /// Retrieves information about an MFA device for a specified user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMFADevice service method.</param>
        /// 
        /// <returns>The response from the GetMFADevice service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetMFADevice">REST API Reference for GetMFADevice Operation</seealso>
        GetMFADeviceResponse GetMFADevice(GetMFADeviceRequest request);



        /// <summary>
        /// Retrieves information about an MFA device for a specified user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMFADevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMFADevice service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetMFADevice">REST API Reference for GetMFADevice Operation</seealso>
        Task<GetMFADeviceResponse> GetMFADeviceAsync(GetMFADeviceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns information about the specified OpenID Connect (OIDC) provider resource object
        /// in IAM.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOpenIDConnectProvider service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetOpenIDConnectProviderResponse> GetOpenIDConnectProviderAsync(GetOpenIDConnectProviderRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetOrganizationsAccessReport


        /// <summary>
        /// Retrieves the service last accessed data report for Organizations that was previously
        /// generated using the <c> <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GenerateOrganizationsAccessReport.html">GenerateOrganizationsAccessReport</a>
        /// </c> operation. This operation retrieves the status of your report job and the report
        /// contents.
        /// 
        ///  
        /// <para>
        /// Depending on the parameters that you passed when you generated the report, the data
        /// returned could include different information. For details, see <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GenerateOrganizationsAccessReport.html">GenerateOrganizationsAccessReport</a>.
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
        /// For each service that principals in an account (root user, IAM users, or IAM roles)
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
        /// Retrieves the service last accessed data report for Organizations that was previously
        /// generated using the <c> <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GenerateOrganizationsAccessReport.html">GenerateOrganizationsAccessReport</a>
        /// </c> operation. This operation retrieves the status of your report job and the report
        /// contents.
        /// 
        ///  
        /// <para>
        /// Depending on the parameters that you passed when you generated the report, the data
        /// returned could include different information. For details, see <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GenerateOrganizationsAccessReport.html">GenerateOrganizationsAccessReport</a>.
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
        /// For each service that principals in an account (root user, IAM users, or IAM roles)
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetOrganizationsAccessReport service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetOrganizationsAccessReport">REST API Reference for GetOrganizationsAccessReport Operation</seealso>
        Task<GetOrganizationsAccessReportResponse> GetOrganizationsAccessReportAsync(GetOrganizationsAccessReportRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetPolicy


        /// <summary>
        /// Retrieves information about the specified managed policy, including the policy's default
        /// version and the total number of IAM users, groups, and roles to which the policy is
        /// attached. To retrieve the list of the specific users, groups, and roles that the policy
        /// is attached to, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ListEntitiesForPolicy.html">ListEntitiesForPolicy</a>.
        /// This operation returns metadata about the policy. To retrieve the actual policy document
        /// for a specific version of the policy, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetPolicyVersion.html">GetPolicyVersion</a>.
        /// 
        ///  
        /// <para>
        /// This operation retrieves information about managed policies. To retrieve information
        /// about an inline policy that is embedded with an IAM user, group, or role, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetUserPolicy.html">GetUserPolicy</a>,
        /// <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetGroupPolicy.html">GetGroupPolicy</a>,
        /// or <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetRolePolicy.html">GetRolePolicy</a>.
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
        /// Retrieves information about the specified managed policy, including the policy's default
        /// version and the total number of IAM users, groups, and roles to which the policy is
        /// attached. To retrieve the list of the specific users, groups, and roles that the policy
        /// is attached to, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ListEntitiesForPolicy.html">ListEntitiesForPolicy</a>.
        /// This operation returns metadata about the policy. To retrieve the actual policy document
        /// for a specific version of the policy, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetPolicyVersion.html">GetPolicyVersion</a>.
        /// 
        ///  
        /// <para>
        /// This operation retrieves information about managed policies. To retrieve information
        /// about an inline policy that is embedded with an IAM user, group, or role, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetUserPolicy.html">GetUserPolicy</a>,
        /// <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetGroupPolicy.html">GetGroupPolicy</a>,
        /// or <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetRolePolicy.html">GetRolePolicy</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// policies and inline policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetPolicyResponse> GetPolicyAsync(GetPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// text. For example, if you use Java, you can use the <c>decode</c> method of the <c>java.net.URLDecoder</c>
        /// utility class in the Java SDK. Other languages and SDKs provide similar functionality,
        /// and some SDKs do this decoding automatically.
        /// </para>
        ///  </note> 
        /// <para>
        /// To list the available versions for a policy, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ListPolicyVersions.html">ListPolicyVersions</a>.
        /// </para>
        ///  
        /// <para>
        /// This operation retrieves information about managed policies. To retrieve information
        /// about an inline policy that is embedded in a user, group, or role, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetUserPolicy.html">GetUserPolicy</a>,
        /// <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetGroupPolicy.html">GetGroupPolicy</a>,
        /// or <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetRolePolicy.html">GetRolePolicy</a>.
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
        /// Retrieves information about the specified version of the specified managed policy,
        /// including the policy document.
        /// 
        ///  <note> 
        /// <para>
        /// Policies returned by this operation are URL-encoded compliant with <a href="https://tools.ietf.org/html/rfc3986">RFC
        /// 3986</a>. You can use a URL decoding method to convert the policy back to plain JSON
        /// text. For example, if you use Java, you can use the <c>decode</c> method of the <c>java.net.URLDecoder</c>
        /// utility class in the Java SDK. Other languages and SDKs provide similar functionality,
        /// and some SDKs do this decoding automatically.
        /// </para>
        ///  </note> 
        /// <para>
        /// To list the available versions for a policy, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ListPolicyVersions.html">ListPolicyVersions</a>.
        /// </para>
        ///  
        /// <para>
        /// This operation retrieves information about managed policies. To retrieve information
        /// about an inline policy that is embedded in a user, group, or role, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetUserPolicy.html">GetUserPolicy</a>,
        /// <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetGroupPolicy.html">GetGroupPolicy</a>,
        /// or <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetRolePolicy.html">GetRolePolicy</a>.
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetPolicyVersionResponse> GetPolicyVersionAsync(GetPolicyVersionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetRole


        /// <summary>
        /// Retrieves information about the specified role, including the role's path, GUID, ARN,
        /// and the role's trust policy that grants permission to assume the role. For more information
        /// about roles, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles.html">IAM
        /// roles</a> in the <i>IAM User Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// Policies returned by this operation are URL-encoded compliant with <a href="https://tools.ietf.org/html/rfc3986">RFC
        /// 3986</a>. You can use a URL decoding method to convert the policy back to plain JSON
        /// text. For example, if you use Java, you can use the <c>decode</c> method of the <c>java.net.URLDecoder</c>
        /// utility class in the Java SDK. Other languages and SDKs provide similar functionality,
        /// and some SDKs do this decoding automatically.
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
        /// Retrieves information about the specified role, including the role's path, GUID, ARN,
        /// and the role's trust policy that grants permission to assume the role. For more information
        /// about roles, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles.html">IAM
        /// roles</a> in the <i>IAM User Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// Policies returned by this operation are URL-encoded compliant with <a href="https://tools.ietf.org/html/rfc3986">RFC
        /// 3986</a>. You can use a URL decoding method to convert the policy back to plain JSON
        /// text. For example, if you use Java, you can use the <c>decode</c> method of the <c>java.net.URLDecoder</c>
        /// utility class in the Java SDK. Other languages and SDKs provide similar functionality,
        /// and some SDKs do this decoding automatically.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRole service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetRoleResponse> GetRoleAsync(GetRoleRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// text. For example, if you use Java, you can use the <c>decode</c> method of the <c>java.net.URLDecoder</c>
        /// utility class in the Java SDK. Other languages and SDKs provide similar functionality,
        /// and some SDKs do this decoding automatically.
        /// </para>
        ///  </note> 
        /// <para>
        /// An IAM role can also have managed policies attached to it. To retrieve a managed policy
        /// document that is attached to a role, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetPolicy.html">GetPolicy</a>
        /// to determine the policy's default version, then use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetPolicyVersion.html">GetPolicyVersion</a>
        /// to retrieve the policy document.
        /// </para>
        ///  
        /// <para>
        /// For more information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// policies and inline policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  For more information about roles, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles.html">IAM
        /// roles</a> in the <i>IAM User Guide</i>.
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
        /// Retrieves the specified inline policy document that is embedded with the specified
        /// IAM role.
        /// 
        ///  <note> 
        /// <para>
        /// Policies returned by this operation are URL-encoded compliant with <a href="https://tools.ietf.org/html/rfc3986">RFC
        /// 3986</a>. You can use a URL decoding method to convert the policy back to plain JSON
        /// text. For example, if you use Java, you can use the <c>decode</c> method of the <c>java.net.URLDecoder</c>
        /// utility class in the Java SDK. Other languages and SDKs provide similar functionality,
        /// and some SDKs do this decoding automatically.
        /// </para>
        ///  </note> 
        /// <para>
        /// An IAM role can also have managed policies attached to it. To retrieve a managed policy
        /// document that is attached to a role, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetPolicy.html">GetPolicy</a>
        /// to determine the policy's default version, then use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetPolicyVersion.html">GetPolicyVersion</a>
        /// to retrieve the policy document.
        /// </para>
        ///  
        /// <para>
        /// For more information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// policies and inline policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  For more information about roles, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles.html">IAM
        /// roles</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRolePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetRolePolicyResponse> GetRolePolicyAsync(GetRolePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetSAMLProviderResponse> GetSAMLProviderAsync(GetSAMLProviderRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetServerCertificateResponse> GetServerCertificateAsync(GetServerCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetServiceLastAccessedDetails


        /// <summary>
        /// Retrieves a service last accessed report that was created using the <c>GenerateServiceLastAccessedDetails</c>
        /// operation. You can use the <c>JobId</c> parameter in <c>GetServiceLastAccessedDetails</c>
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
        /// If the operation fails, the <c>GetServiceLastAccessedDetails</c> operation returns
        /// the reason that it failed.
        /// </para>
        ///  
        /// <para>
        /// The <c>GetServiceLastAccessedDetails</c> operation returns a list of services. This
        /// list includes the number of entities that have attempted to access the service and
        /// the date and time of the last attempt. It also returns the ARN of the following entity,
        /// depending on the resource ARN that you used to generate the report:
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
        /// If you specified <c>ACTION_LEVEL</c> granularity when you generated the report, this
        /// operation returns service and action last accessed data. This includes the most recent
        /// access attempt for each tracked action within a service. Otherwise, this operation
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
        /// Retrieves a service last accessed report that was created using the <c>GenerateServiceLastAccessedDetails</c>
        /// operation. You can use the <c>JobId</c> parameter in <c>GetServiceLastAccessedDetails</c>
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
        /// If the operation fails, the <c>GetServiceLastAccessedDetails</c> operation returns
        /// the reason that it failed.
        /// </para>
        ///  
        /// <para>
        /// The <c>GetServiceLastAccessedDetails</c> operation returns a list of services. This
        /// list includes the number of entities that have attempted to access the service and
        /// the date and time of the last attempt. It also returns the ARN of the following entity,
        /// depending on the resource ARN that you used to generate the report:
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
        /// If you specified <c>ACTION_LEVEL</c> granularity when you generated the report, this
        /// operation returns service and action last accessed data. This includes the most recent
        /// access attempt for each tracked action within a service. Otherwise, this operation
        /// returns only service data.
        /// </para>
        ///  
        /// <para>
        /// For more information about service and action last accessed data, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_access-advisor.html">Reducing
        /// permissions using service last accessed data</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceLastAccessedDetails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetServiceLastAccessedDetailsResponse> GetServiceLastAccessedDetailsAsync(GetServiceLastAccessedDetailsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetServiceLastAccessedDetailsWithEntities


        /// <summary>
        /// After you generate a group or policy report using the <c>GenerateServiceLastAccessedDetails</c>
        /// operation, you can use the <c>JobId</c> parameter in <c>GetServiceLastAccessedDetailsWithEntities</c>.
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
        /// If the operation fails, the <c>GetServiceLastAccessedDetailsWithEntities</c> operation
        /// returns the reason that it failed.
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
        /// After you generate a group or policy report using the <c>GenerateServiceLastAccessedDetails</c>
        /// operation, you can use the <c>JobId</c> parameter in <c>GetServiceLastAccessedDetailsWithEntities</c>.
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
        /// If the operation fails, the <c>GetServiceLastAccessedDetailsWithEntities</c> operation
        /// returns the reason that it failed.
        /// </para>
        ///  
        /// <para>
        /// By default, the list of associated entities is sorted by date, with the most recent
        /// access listed first.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceLastAccessedDetailsWithEntities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetServiceLastAccessedDetailsWithEntitiesResponse> GetServiceLastAccessedDetailsWithEntitiesAsync(GetServiceLastAccessedDetailsWithEntitiesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetServiceLinkedRoleDeletionStatus


        /// <summary>
        /// Retrieves the status of your service-linked role deletion. After you use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DeleteServiceLinkedRole.html">DeleteServiceLinkedRole</a>
        /// to submit a service-linked role for deletion, you can use the <c>DeletionTaskId</c>
        /// parameter in <c>GetServiceLinkedRoleDeletionStatus</c> to check the status of the
        /// deletion. If the deletion fails, this operation returns the reason that it failed,
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
        /// Retrieves the status of your service-linked role deletion. After you use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_DeleteServiceLinkedRole.html">DeleteServiceLinkedRole</a>
        /// to submit a service-linked role for deletion, you can use the <c>DeletionTaskId</c>
        /// parameter in <c>GetServiceLinkedRoleDeletionStatus</c> to check the status of the
        /// deletion. If the deletion fails, this operation returns the reason that it failed,
        /// if that information is returned by the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceLinkedRoleDeletionStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetServiceLinkedRoleDeletionStatusResponse> GetServiceLinkedRoleDeletionStatusAsync(GetServiceLinkedRoleDeletionStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetSSHPublicKeyResponse> GetSSHPublicKeyAsync(GetSSHPublicKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Retrieves information about the specified IAM user, including the user's creation
        /// date, path, unique ID, and ARN.
        /// 
        ///  
        /// <para>
        /// If you do not specify a user name, IAM determines the user name implicitly based on
        /// the Amazon Web Services access key ID used to sign the request to this operation.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetUserResponse> GetUserAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetUserResponse> GetUserAsync(GetUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// text. For example, if you use Java, you can use the <c>decode</c> method of the <c>java.net.URLDecoder</c>
        /// utility class in the Java SDK. Other languages and SDKs provide similar functionality,
        /// and some SDKs do this decoding automatically.
        /// </para>
        ///  </note> 
        /// <para>
        /// An IAM user can also have managed policies attached to it. To retrieve a managed policy
        /// document that is attached to a user, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetPolicy.html">GetPolicy</a>
        /// to determine the policy's default version. Then use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetPolicyVersion.html">GetPolicyVersion</a>
        /// to retrieve the policy document.
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
        /// Retrieves the specified inline policy document that is embedded in the specified IAM
        /// user.
        /// 
        ///  <note> 
        /// <para>
        /// Policies returned by this operation are URL-encoded compliant with <a href="https://tools.ietf.org/html/rfc3986">RFC
        /// 3986</a>. You can use a URL decoding method to convert the policy back to plain JSON
        /// text. For example, if you use Java, you can use the <c>decode</c> method of the <c>java.net.URLDecoder</c>
        /// utility class in the Java SDK. Other languages and SDKs provide similar functionality,
        /// and some SDKs do this decoding automatically.
        /// </para>
        ///  </note> 
        /// <para>
        /// An IAM user can also have managed policies attached to it. To retrieve a managed policy
        /// document that is attached to a user, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetPolicy.html">GetPolicy</a>
        /// to determine the policy's default version. Then use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetPolicyVersion.html">GetPolicyVersion</a>
        /// to retrieve the policy document.
        /// </para>
        ///  
        /// <para>
        /// For more information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// policies and inline policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUserPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetUserPolicyResponse> GetUserPolicyAsync(GetUserPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAccessKeys


        /// <summary>
        /// Returns information about the access key IDs associated with the specified IAM user.
        /// If there is none, the operation returns an empty list.
        /// 
        ///  
        /// <para>
        /// Although each user is limited to a small number of keys, you can still paginate the
        /// results using the <c>MaxItems</c> and <c>Marker</c> parameters.
        /// </para>
        ///  
        /// <para>
        /// If the <c>UserName</c> is not specified, the user name is determined implicitly based
        /// on the Amazon Web Services access key ID used to sign the request. If a temporary
        /// access key is used, then <c>UserName</c> is required. If a long-term key is assigned
        /// to the user, then <c>UserName</c> is not required.
        /// </para>
        ///  
        /// <para>
        /// This operation works for access keys under the Amazon Web Services account. If the
        /// Amazon Web Services account has no associated users, the root user returns it's own
        /// access key IDs by running this command.
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
        /// results using the <c>MaxItems</c> and <c>Marker</c> parameters.
        /// </para>
        ///  
        /// <para>
        /// If the <c>UserName</c> is not specified, the user name is determined implicitly based
        /// on the Amazon Web Services access key ID used to sign the request. If a temporary
        /// access key is used, then <c>UserName</c> is required. If a long-term key is assigned
        /// to the user, then <c>UserName</c> is not required.
        /// </para>
        ///  
        /// <para>
        /// This operation works for access keys under the Amazon Web Services account. If the
        /// Amazon Web Services account has no associated users, the root user returns it's own
        /// access key IDs by running this command.
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
        /// Returns information about the access key IDs associated with the specified IAM user.
        /// If there is none, the operation returns an empty list.
        /// 
        ///  
        /// <para>
        /// Although each user is limited to a small number of keys, you can still paginate the
        /// results using the <c>MaxItems</c> and <c>Marker</c> parameters.
        /// </para>
        ///  
        /// <para>
        /// If the <c>UserName</c> is not specified, the user name is determined implicitly based
        /// on the Amazon Web Services access key ID used to sign the request. If a temporary
        /// access key is used, then <c>UserName</c> is required. If a long-term key is assigned
        /// to the user, then <c>UserName</c> is not required.
        /// </para>
        ///  
        /// <para>
        /// This operation works for access keys under the Amazon Web Services account. If the
        /// Amazon Web Services account has no associated users, the root user returns it's own
        /// access key IDs by running this command.
        /// </para>
        ///  <note> 
        /// <para>
        /// To ensure the security of your Amazon Web Services account, the secret access key
        /// is accessible only during key and user creation.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListAccessKeysResponse> ListAccessKeysAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Returns information about the access key IDs associated with the specified IAM user.
        /// If there is none, the operation returns an empty list.
        /// 
        ///  
        /// <para>
        /// Although each user is limited to a small number of keys, you can still paginate the
        /// results using the <c>MaxItems</c> and <c>Marker</c> parameters.
        /// </para>
        ///  
        /// <para>
        /// If the <c>UserName</c> is not specified, the user name is determined implicitly based
        /// on the Amazon Web Services access key ID used to sign the request. If a temporary
        /// access key is used, then <c>UserName</c> is required. If a long-term key is assigned
        /// to the user, then <c>UserName</c> is not required.
        /// </para>
        ///  
        /// <para>
        /// This operation works for access keys under the Amazon Web Services account. If the
        /// Amazon Web Services account has no associated users, the root user returns it's own
        /// access key IDs by running this command.
        /// </para>
        ///  <note> 
        /// <para>
        /// To ensure the security of your Amazon Web Services account, the secret access key
        /// is accessible only during key and user creation.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessKeys service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListAccessKeysResponse> ListAccessKeysAsync(ListAccessKeysRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAccountAliases


        /// <summary>
        /// Lists the account alias associated with the Amazon Web Services account (Note: you
        /// can have only one). For information about using an Amazon Web Services account alias,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/console_account-alias.html#CreateAccountAlias">Creating,
        /// deleting, and listing an Amazon Web Services account alias</a> in the <i>IAM User
        /// Guide</i>.
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
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/console_account-alias.html#CreateAccountAlias">Creating,
        /// deleting, and listing an Amazon Web Services account alias</a> in the <i>IAM User
        /// Guide</i>.
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
        /// Lists the account alias associated with the Amazon Web Services account (Note: you
        /// can have only one). For information about using an Amazon Web Services account alias,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/console_account-alias.html#CreateAccountAlias">Creating,
        /// deleting, and listing an Amazon Web Services account alias</a> in the <i>IAM User
        /// Guide</i>.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAccountAliases service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListAccountAliases">REST API Reference for ListAccountAliases Operation</seealso>
        Task<ListAccountAliasesResponse> ListAccountAliasesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Lists the account alias associated with the Amazon Web Services account (Note: you
        /// can have only one). For information about using an Amazon Web Services account alias,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/console_account-alias.html#CreateAccountAlias">Creating,
        /// deleting, and listing an Amazon Web Services account alias</a> in the <i>IAM User
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccountAliases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAccountAliases service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListAccountAliases">REST API Reference for ListAccountAliases Operation</seealso>
        Task<ListAccountAliasesResponse> ListAccountAliasesAsync(ListAccountAliasesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAttachedGroupPolicies


        /// <summary>
        /// Lists all managed policies that are attached to the specified IAM group.
        /// 
        ///  
        /// <para>
        /// An IAM group can also have inline policies embedded with it. To list the inline policies
        /// for a group, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ListGroupPolicies.html">ListGroupPolicies</a>.
        /// For information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// policies and inline policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.
        /// You can use the <c>PathPrefix</c> parameter to limit the list of policies to only
        /// those matching the specified path prefix. If there are no policies attached to the
        /// specified group (or none that match the specified path prefix), the operation returns
        /// an empty list.
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
        /// Lists all managed policies that are attached to the specified IAM group.
        /// 
        ///  
        /// <para>
        /// An IAM group can also have inline policies embedded with it. To list the inline policies
        /// for a group, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ListGroupPolicies.html">ListGroupPolicies</a>.
        /// For information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// policies and inline policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.
        /// You can use the <c>PathPrefix</c> parameter to limit the list of policies to only
        /// those matching the specified path prefix. If there are no policies attached to the
        /// specified group (or none that match the specified path prefix), the operation returns
        /// an empty list.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedGroupPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListAttachedGroupPoliciesResponse> ListAttachedGroupPoliciesAsync(ListAttachedGroupPoliciesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAttachedRolePolicies


        /// <summary>
        /// Lists all managed policies that are attached to the specified IAM role.
        /// 
        ///  
        /// <para>
        /// An IAM role can also have inline policies embedded with it. To list the inline policies
        /// for a role, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ListRolePolicies.html">ListRolePolicies</a>.
        /// For information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// policies and inline policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.
        /// You can use the <c>PathPrefix</c> parameter to limit the list of policies to only
        /// those matching the specified path prefix. If there are no policies attached to the
        /// specified role (or none that match the specified path prefix), the operation returns
        /// an empty list.
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
        /// Lists all managed policies that are attached to the specified IAM role.
        /// 
        ///  
        /// <para>
        /// An IAM role can also have inline policies embedded with it. To list the inline policies
        /// for a role, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ListRolePolicies.html">ListRolePolicies</a>.
        /// For information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// policies and inline policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.
        /// You can use the <c>PathPrefix</c> parameter to limit the list of policies to only
        /// those matching the specified path prefix. If there are no policies attached to the
        /// specified role (or none that match the specified path prefix), the operation returns
        /// an empty list.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedRolePolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListAttachedRolePoliciesResponse> ListAttachedRolePoliciesAsync(ListAttachedRolePoliciesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAttachedUserPolicies


        /// <summary>
        /// Lists all managed policies that are attached to the specified IAM user.
        /// 
        ///  
        /// <para>
        /// An IAM user can also have inline policies embedded with it. To list the inline policies
        /// for a user, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ListUserPolicies.html">ListUserPolicies</a>.
        /// For information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// policies and inline policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.
        /// You can use the <c>PathPrefix</c> parameter to limit the list of policies to only
        /// those matching the specified path prefix. If there are no policies attached to the
        /// specified group (or none that match the specified path prefix), the operation returns
        /// an empty list.
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
        /// Lists all managed policies that are attached to the specified IAM user.
        /// 
        ///  
        /// <para>
        /// An IAM user can also have inline policies embedded with it. To list the inline policies
        /// for a user, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ListUserPolicies.html">ListUserPolicies</a>.
        /// For information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// policies and inline policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.
        /// You can use the <c>PathPrefix</c> parameter to limit the list of policies to only
        /// those matching the specified path prefix. If there are no policies attached to the
        /// specified group (or none that match the specified path prefix), the operation returns
        /// an empty list.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedUserPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListAttachedUserPoliciesResponse> ListAttachedUserPoliciesAsync(ListAttachedUserPoliciesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListEntitiesForPolicy


        /// <summary>
        /// Lists all IAM users, groups, and roles that the specified managed policy is attached
        /// to.
        /// 
        ///  
        /// <para>
        /// You can use the optional <c>EntityFilter</c> parameter to limit the results to a particular
        /// type of entity (users, groups, or roles). For example, to list only the roles that
        /// are attached to the specified policy, set <c>EntityFilter</c> to <c>Role</c>.
        /// </para>
        ///  
        /// <para>
        /// You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.
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
        /// Lists all IAM users, groups, and roles that the specified managed policy is attached
        /// to.
        /// 
        ///  
        /// <para>
        /// You can use the optional <c>EntityFilter</c> parameter to limit the results to a particular
        /// type of entity (users, groups, or roles). For example, to list only the roles that
        /// are attached to the specified policy, set <c>EntityFilter</c> to <c>Role</c>.
        /// </para>
        ///  
        /// <para>
        /// You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEntitiesForPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListEntitiesForPolicyResponse> ListEntitiesForPolicyAsync(ListEntitiesForPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListGroupPolicies


        /// <summary>
        /// Lists the names of the inline policies that are embedded in the specified IAM group.
        /// 
        ///  
        /// <para>
        /// An IAM group can also have managed policies attached to it. To list the managed policies
        /// that are attached to a group, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ListAttachedGroupPolicies.html">ListAttachedGroupPolicies</a>.
        /// For more information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// policies and inline policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.
        /// If there are no inline policies embedded with the specified group, the operation returns
        /// an empty list.
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
        /// Lists the names of the inline policies that are embedded in the specified IAM group.
        /// 
        ///  
        /// <para>
        /// An IAM group can also have managed policies attached to it. To list the managed policies
        /// that are attached to a group, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ListAttachedGroupPolicies.html">ListAttachedGroupPolicies</a>.
        /// For more information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// policies and inline policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.
        /// If there are no inline policies embedded with the specified group, the operation returns
        /// an empty list.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListGroupPoliciesResponse> ListGroupPoliciesAsync(ListGroupPoliciesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListGroups


        /// <summary>
        /// Lists the IAM groups that have the specified path prefix.
        /// 
        ///  
        /// <para>
        ///  You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.
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
        ///  You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.
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
        /// Lists the IAM groups that have the specified path prefix.
        /// 
        ///  
        /// <para>
        ///  You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGroups service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListGroups">REST API Reference for ListGroups Operation</seealso>
        Task<ListGroupsResponse> ListGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Lists the IAM groups that have the specified path prefix.
        /// 
        ///  
        /// <para>
        ///  You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGroups service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListGroups">REST API Reference for ListGroups Operation</seealso>
        Task<ListGroupsResponse> ListGroupsAsync(ListGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListGroupsForUser


        /// <summary>
        /// Lists the IAM groups that the specified IAM user belongs to.
        /// 
        ///  
        /// <para>
        /// You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.
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
        /// Lists the IAM groups that the specified IAM user belongs to.
        /// 
        ///  
        /// <para>
        /// You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupsForUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListGroupsForUserResponse> ListGroupsForUserAsync(ListGroupsForUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListInstanceProfiles


        /// <summary>
        /// Lists the instance profiles that have the specified path prefix. If there are none,
        /// the operation returns an empty list. For more information about instance profiles,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use_switch-role-ec2_instance-profiles.html">Using
        /// instance profiles</a> in the <i>IAM User Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// IAM resource-listing operations return a subset of the available attributes for the
        /// resource. For example, this operation does not return tags, even though they are an
        /// attribute of the returned object. To view all of the information for an instance profile,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetInstanceProfile.html">GetInstanceProfile</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.
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
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use_switch-role-ec2_instance-profiles.html">Using
        /// instance profiles</a> in the <i>IAM User Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// IAM resource-listing operations return a subset of the available attributes for the
        /// resource. For example, this operation does not return tags, even though they are an
        /// attribute of the returned object. To view all of the information for an instance profile,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetInstanceProfile.html">GetInstanceProfile</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.
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
        /// Lists the instance profiles that have the specified path prefix. If there are none,
        /// the operation returns an empty list. For more information about instance profiles,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use_switch-role-ec2_instance-profiles.html">Using
        /// instance profiles</a> in the <i>IAM User Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// IAM resource-listing operations return a subset of the available attributes for the
        /// resource. For example, this operation does not return tags, even though they are an
        /// attribute of the returned object. To view all of the information for an instance profile,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetInstanceProfile.html">GetInstanceProfile</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInstanceProfiles service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListInstanceProfiles">REST API Reference for ListInstanceProfiles Operation</seealso>
        Task<ListInstanceProfilesResponse> ListInstanceProfilesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Lists the instance profiles that have the specified path prefix. If there are none,
        /// the operation returns an empty list. For more information about instance profiles,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use_switch-role-ec2_instance-profiles.html">Using
        /// instance profiles</a> in the <i>IAM User Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// IAM resource-listing operations return a subset of the available attributes for the
        /// resource. For example, this operation does not return tags, even though they are an
        /// attribute of the returned object. To view all of the information for an instance profile,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetInstanceProfile.html">GetInstanceProfile</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInstanceProfiles service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListInstanceProfiles">REST API Reference for ListInstanceProfiles Operation</seealso>
        Task<ListInstanceProfilesResponse> ListInstanceProfilesAsync(ListInstanceProfilesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListInstanceProfilesForRole


        /// <summary>
        /// Lists the instance profiles that have the specified associated IAM role. If there
        /// are none, the operation returns an empty list. For more information about instance
        /// profiles, go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use_switch-role-ec2_instance-profiles.html">Using
        /// instance profiles</a> in the <i>IAM User Guide</i>.
        /// 
        ///  
        /// <para>
        /// You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.
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
        /// Lists the instance profiles that have the specified associated IAM role. If there
        /// are none, the operation returns an empty list. For more information about instance
        /// profiles, go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use_switch-role-ec2_instance-profiles.html">Using
        /// instance profiles</a> in the <i>IAM User Guide</i>.
        /// 
        ///  
        /// <para>
        /// You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceProfilesForRole service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListInstanceProfilesForRoleResponse> ListInstanceProfilesForRoleAsync(ListInstanceProfilesForRoleRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists the tags that are attached to the specified IAM instance profile. The returned
        /// list of tags is sorted by tag key. For more information about tagging, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging
        /// IAM resources</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceProfileTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListInstanceProfileTagsResponse> ListInstanceProfileTagsAsync(ListInstanceProfileTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.
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
        /// You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.
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
        /// Lists the MFA devices for an IAM user. If the request includes a IAM user name, then
        /// this operation lists all the MFA devices associated with the specified user. If you
        /// do not specify a user name, IAM determines the user name implicitly based on the Amazon
        /// Web Services access key ID signing the request for this operation.
        /// 
        ///  
        /// <para>
        /// You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListMFADevicesResponse> ListMFADevicesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Lists the MFA devices for an IAM user. If the request includes a IAM user name, then
        /// this operation lists all the MFA devices associated with the specified user. If you
        /// do not specify a user name, IAM determines the user name implicitly based on the Amazon
        /// Web Services access key ID signing the request for this operation.
        /// 
        ///  
        /// <para>
        /// You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMFADevices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListMFADevicesResponse> ListMFADevicesAsync(ListMFADevicesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists the tags that are attached to the specified IAM virtual multi-factor authentication
        /// (MFA) device. The returned list of tags is sorted by tag key. For more information
        /// about tagging, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging
        /// IAM resources</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMFADeviceTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListMFADeviceTagsResponse> ListMFADeviceTagsAsync(ListMFADeviceTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetOpenIDConnectProvider.html">GetOpenIDConnectProvider</a>.
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
        /// Lists information about the IAM OpenID Connect (OIDC) provider resource objects defined
        /// in the Amazon Web Services account.
        /// 
        ///  <note> 
        /// <para>
        /// IAM resource-listing operations return a subset of the available attributes for the
        /// resource. For example, this operation does not return tags, even though they are an
        /// attribute of the returned object. To view all of the information for an OIDC provider,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetOpenIDConnectProvider.html">GetOpenIDConnectProvider</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOpenIDConnectProviders service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOpenIDConnectProviders service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListOpenIDConnectProviders">REST API Reference for ListOpenIDConnectProviders Operation</seealso>
        Task<ListOpenIDConnectProvidersResponse> ListOpenIDConnectProvidersAsync(ListOpenIDConnectProvidersRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListOpenIDConnectProviderTagsResponse> ListOpenIDConnectProviderTagsAsync(ListOpenIDConnectProviderTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListOrganizationsFeatures


        /// <summary>
        /// Lists the centralized root access features enabled for your organization. For more
        /// information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_root-user.html#id_root-user-access-management">Centrally
        /// manage root access for member accounts</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationsFeatures service method.</param>
        /// 
        /// <returns>The response from the ListOrganizationsFeatures service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.AccountNotManagementOrDelegatedAdministratorException">
        /// The request was rejected because the account making the request is not the management
        /// account or delegated administrator account for <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_root-user.html#id_root-user-access-management">centralized
        /// root access</a>.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.OrganizationNotFoundException">
        /// The request was rejected because no organization is associated with your account.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.OrganizationNotInAllFeaturesModeException">
        /// The request was rejected because your organization does not have All features enabled.
        /// For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_getting-started_concepts.html#feature-set">Available
        /// feature sets</a> in the <i>Organizations User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceAccessNotEnabledException">
        /// The request was rejected because trusted access is not enabled for IAM in Organizations.
        /// For details, see IAM and Organizations in the <i>Organizations User Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListOrganizationsFeatures">REST API Reference for ListOrganizationsFeatures Operation</seealso>
        ListOrganizationsFeaturesResponse ListOrganizationsFeatures(ListOrganizationsFeaturesRequest request);



        /// <summary>
        /// Lists the centralized root access features enabled for your organization. For more
        /// information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_root-user.html#id_root-user-access-management">Centrally
        /// manage root access for member accounts</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationsFeatures service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOrganizationsFeatures service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.AccountNotManagementOrDelegatedAdministratorException">
        /// The request was rejected because the account making the request is not the management
        /// account or delegated administrator account for <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_root-user.html#id_root-user-access-management">centralized
        /// root access</a>.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.OrganizationNotFoundException">
        /// The request was rejected because no organization is associated with your account.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.OrganizationNotInAllFeaturesModeException">
        /// The request was rejected because your organization does not have All features enabled.
        /// For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_getting-started_concepts.html#feature-set">Available
        /// feature sets</a> in the <i>Organizations User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceAccessNotEnabledException">
        /// The request was rejected because trusted access is not enabled for IAM in Organizations.
        /// For details, see IAM and Organizations in the <i>Organizations User Guide</i>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListOrganizationsFeatures">REST API Reference for ListOrganizationsFeatures Operation</seealso>
        Task<ListOrganizationsFeaturesResponse> ListOrganizationsFeaturesAsync(ListOrganizationsFeaturesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListPolicies


        /// <summary>
        /// Lists all the managed policies that are available in your Amazon Web Services account,
        /// including your own customer-defined managed policies and all Amazon Web Services managed
        /// policies.
        /// 
        ///  
        /// <para>
        /// You can filter the list of policies that is returned using the optional <c>OnlyAttached</c>,
        /// <c>Scope</c>, and <c>PathPrefix</c> parameters. For example, to list only the customer
        /// managed policies in your Amazon Web Services account, set <c>Scope</c> to <c>Local</c>.
        /// To list only Amazon Web Services managed policies, set <c>Scope</c> to <c>AWS</c>.
        /// </para>
        ///  
        /// <para>
        /// You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.
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
        /// policy, see <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetPolicy.html">GetPolicy</a>.
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
        /// You can filter the list of policies that is returned using the optional <c>OnlyAttached</c>,
        /// <c>Scope</c>, and <c>PathPrefix</c> parameters. For example, to list only the customer
        /// managed policies in your Amazon Web Services account, set <c>Scope</c> to <c>Local</c>.
        /// To list only Amazon Web Services managed policies, set <c>Scope</c> to <c>AWS</c>.
        /// </para>
        ///  
        /// <para>
        /// You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.
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
        /// policy, see <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetPolicy.html">GetPolicy</a>.
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
        /// Lists all the managed policies that are available in your Amazon Web Services account,
        /// including your own customer-defined managed policies and all Amazon Web Services managed
        /// policies.
        /// 
        ///  
        /// <para>
        /// You can filter the list of policies that is returned using the optional <c>OnlyAttached</c>,
        /// <c>Scope</c>, and <c>PathPrefix</c> parameters. For example, to list only the customer
        /// managed policies in your Amazon Web Services account, set <c>Scope</c> to <c>Local</c>.
        /// To list only Amazon Web Services managed policies, set <c>Scope</c> to <c>AWS</c>.
        /// </para>
        ///  
        /// <para>
        /// You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.
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
        /// policy, see <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetPolicy.html">GetPolicy</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPolicies service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListPolicies">REST API Reference for ListPolicies Operation</seealso>
        Task<ListPoliciesResponse> ListPoliciesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Lists all the managed policies that are available in your Amazon Web Services account,
        /// including your own customer-defined managed policies and all Amazon Web Services managed
        /// policies.
        /// 
        ///  
        /// <para>
        /// You can filter the list of policies that is returned using the optional <c>OnlyAttached</c>,
        /// <c>Scope</c>, and <c>PathPrefix</c> parameters. For example, to list only the customer
        /// managed policies in your Amazon Web Services account, set <c>Scope</c> to <c>Local</c>.
        /// To list only Amazon Web Services managed policies, set <c>Scope</c> to <c>AWS</c>.
        /// </para>
        ///  
        /// <para>
        /// You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.
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
        /// policy, see <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetPolicy.html">GetPolicy</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPolicies service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListPolicies">REST API Reference for ListPolicies Operation</seealso>
        Task<ListPoliciesResponse> ListPoliciesAsync(ListPoliciesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// a user or role, use the <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetUser.html">GetUser</a>
        /// or <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetRole.html">GetRole</a>
        /// operations.
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
        /// a user or role, use the <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetUser.html">GetUser</a>
        /// or <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetRole.html">GetRole</a>
        /// operations.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPoliciesGrantingServiceAccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListPoliciesGrantingServiceAccessResponse> ListPoliciesGrantingServiceAccessAsync(ListPoliciesGrantingServiceAccessRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists the tags that are attached to the specified IAM customer managed policy. The
        /// returned list of tags is sorted by tag key. For more information about tagging, see
        /// <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging IAM
        /// resources</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicyTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListPolicyTagsResponse> ListPolicyTagsAsync(ListPolicyTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListPolicyVersionsResponse> ListPolicyVersionsAsync(ListPolicyVersionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListRolePolicies


        /// <summary>
        /// Lists the names of the inline policies that are embedded in the specified IAM role.
        /// 
        ///  
        /// <para>
        /// An IAM role can also have managed policies attached to it. To list the managed policies
        /// that are attached to a role, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ListAttachedRolePolicies.html">ListAttachedRolePolicies</a>.
        /// For more information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// policies and inline policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.
        /// If there are no inline policies embedded with the specified role, the operation returns
        /// an empty list.
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
        /// Lists the names of the inline policies that are embedded in the specified IAM role.
        /// 
        ///  
        /// <para>
        /// An IAM role can also have managed policies attached to it. To list the managed policies
        /// that are attached to a role, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ListAttachedRolePolicies.html">ListAttachedRolePolicies</a>.
        /// For more information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// policies and inline policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.
        /// If there are no inline policies embedded with the specified role, the operation returns
        /// an empty list.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRolePolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListRolePoliciesResponse> ListRolePoliciesAsync(ListRolePoliciesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListRoles


        /// <summary>
        /// Lists the IAM roles that have the specified path prefix. If there are none, the operation
        /// returns an empty list. For more information about roles, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles.html">IAM
        /// roles</a> in the <i>IAM User Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// IAM resource-listing operations return a subset of the available attributes for the
        /// resource. This operation does not return the following attributes, even though they
        /// are an attribute of the returned object:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// PermissionsBoundary
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RoleLastUsed
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tags
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To view all of the information for a role, see <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetRole.html">GetRole</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.
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
        /// returns an empty list. For more information about roles, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles.html">IAM
        /// roles</a> in the <i>IAM User Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// IAM resource-listing operations return a subset of the available attributes for the
        /// resource. This operation does not return the following attributes, even though they
        /// are an attribute of the returned object:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// PermissionsBoundary
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RoleLastUsed
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tags
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To view all of the information for a role, see <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetRole.html">GetRole</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.
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
        /// Lists the IAM roles that have the specified path prefix. If there are none, the operation
        /// returns an empty list. For more information about roles, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles.html">IAM
        /// roles</a> in the <i>IAM User Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// IAM resource-listing operations return a subset of the available attributes for the
        /// resource. This operation does not return the following attributes, even though they
        /// are an attribute of the returned object:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// PermissionsBoundary
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RoleLastUsed
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tags
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To view all of the information for a role, see <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetRole.html">GetRole</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRoles service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListRoles">REST API Reference for ListRoles Operation</seealso>
        Task<ListRolesResponse> ListRolesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Lists the IAM roles that have the specified path prefix. If there are none, the operation
        /// returns an empty list. For more information about roles, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles.html">IAM
        /// roles</a> in the <i>IAM User Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// IAM resource-listing operations return a subset of the available attributes for the
        /// resource. This operation does not return the following attributes, even though they
        /// are an attribute of the returned object:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// PermissionsBoundary
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RoleLastUsed
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tags
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To view all of the information for a role, see <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetRole.html">GetRole</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRoles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRoles service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListRoles">REST API Reference for ListRoles Operation</seealso>
        Task<ListRolesResponse> ListRolesAsync(ListRolesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists the tags that are attached to the specified role. The returned list of tags
        /// is sorted by tag key. For more information about tagging, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging
        /// IAM resources</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRoleTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListRoleTagsResponse> ListRoleTagsAsync(ListRoleTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListSAMLProviders


        /// <summary>
        /// Lists the SAML provider resource objects defined in IAM in the account. IAM resource-listing
        /// operations return a subset of the available attributes for the resource. For example,
        /// this operation does not return tags, even though they are an attribute of the returned
        /// object. To view all of the information for a SAML provider, see <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetSAMLProvider.html">GetSAMLProvider</a>.
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
        /// object. To view all of the information for a SAML provider, see <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetSAMLProvider.html">GetSAMLProvider</a>.
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
        /// Lists the SAML provider resource objects defined in IAM in the account. IAM resource-listing
        /// operations return a subset of the available attributes for the resource. For example,
        /// this operation does not return tags, even though they are an attribute of the returned
        /// object. To view all of the information for a SAML provider, see <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetSAMLProvider.html">GetSAMLProvider</a>.
        /// 
        ///  <important> 
        /// <para>
        ///  This operation requires <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version 4</a>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSAMLProviders service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListSAMLProviders">REST API Reference for ListSAMLProviders Operation</seealso>
        Task<ListSAMLProvidersResponse> ListSAMLProvidersAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Lists the SAML provider resource objects defined in IAM in the account. IAM resource-listing
        /// operations return a subset of the available attributes for the resource. For example,
        /// this operation does not return tags, even though they are an attribute of the returned
        /// object. To view all of the information for a SAML provider, see <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetSAMLProvider.html">GetSAMLProvider</a>.
        /// 
        ///  <important> 
        /// <para>
        ///  This operation requires <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version 4</a>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSAMLProviders service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSAMLProviders service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListSAMLProviders">REST API Reference for ListSAMLProviders Operation</seealso>
        Task<ListSAMLProvidersResponse> ListSAMLProvidersAsync(ListSAMLProvidersRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListSAMLProviderTagsResponse> ListSAMLProviderTagsAsync(ListSAMLProviderTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListServerCertificates


        /// <summary>
        /// Lists the server certificates stored in IAM that have the specified path prefix. If
        /// none exist, the operation returns an empty list.
        /// 
        ///  
        /// <para>
        ///  You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.
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
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetServerCertificate.html">GetServerCertificate</a>.
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
        ///  You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.
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
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetServerCertificate.html">GetServerCertificate</a>.
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
        /// Lists the server certificates stored in IAM that have the specified path prefix. If
        /// none exist, the operation returns an empty list.
        /// 
        ///  
        /// <para>
        ///  You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.
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
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetServerCertificate.html">GetServerCertificate</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListServerCertificates service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListServerCertificates">REST API Reference for ListServerCertificates Operation</seealso>
        Task<ListServerCertificatesResponse> ListServerCertificatesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Lists the server certificates stored in IAM that have the specified path prefix. If
        /// none exist, the operation returns an empty list.
        /// 
        ///  
        /// <para>
        ///  You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.
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
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetServerCertificate.html">GetServerCertificate</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServerCertificates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListServerCertificates service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListServerCertificates">REST API Reference for ListServerCertificates Operation</seealso>
        Task<ListServerCertificatesResponse> ListServerCertificatesAsync(ListServerCertificatesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListServerCertificateTagsResponse> ListServerCertificateTagsAsync(ListServerCertificateTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Returns information about the service-specific credentials associated with the specified
        /// IAM user. If none exists, the operation returns an empty list. The service-specific
        /// credentials returned by this operation are used only for authenticating the IAM user
        /// to a specific service. For more information about using service-specific credentials
        /// to authenticate to an Amazon Web Services service, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/setting-up-gc.html">Set
        /// up service-specific credentials</a> in the CodeCommit User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceSpecificCredentials service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListServiceSpecificCredentialsResponse> ListServiceSpecificCredentialsAsync(ListServiceSpecificCredentialsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListSigningCertificates


        /// <summary>
        /// Returns information about the signing certificates associated with the specified IAM
        /// user. If none exists, the operation returns an empty list.
        /// 
        ///  
        /// <para>
        /// Although each user is limited to a small number of signing certificates, you can still
        /// paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.
        /// </para>
        ///  
        /// <para>
        /// If the <c>UserName</c> field is not specified, the user name is determined implicitly
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
        /// paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.
        /// </para>
        ///  
        /// <para>
        /// If the <c>UserName</c> field is not specified, the user name is determined implicitly
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
        /// Returns information about the signing certificates associated with the specified IAM
        /// user. If none exists, the operation returns an empty list.
        /// 
        ///  
        /// <para>
        /// Although each user is limited to a small number of signing certificates, you can still
        /// paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.
        /// </para>
        ///  
        /// <para>
        /// If the <c>UserName</c> field is not specified, the user name is determined implicitly
        /// based on the Amazon Web Services access key ID used to sign the request for this operation.
        /// This operation works for access keys under the Amazon Web Services account. Consequently,
        /// you can use this operation to manage Amazon Web Services account root user credentials
        /// even if the Amazon Web Services account has no associated users.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListSigningCertificatesResponse> ListSigningCertificatesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Returns information about the signing certificates associated with the specified IAM
        /// user. If none exists, the operation returns an empty list.
        /// 
        ///  
        /// <para>
        /// Although each user is limited to a small number of signing certificates, you can still
        /// paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.
        /// </para>
        ///  
        /// <para>
        /// If the <c>UserName</c> field is not specified, the user name is determined implicitly
        /// based on the Amazon Web Services access key ID used to sign the request for this operation.
        /// This operation works for access keys under the Amazon Web Services account. Consequently,
        /// you can use this operation to manage Amazon Web Services account root user credentials
        /// even if the Amazon Web Services account has no associated users.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSigningCertificates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListSigningCertificatesResponse> ListSigningCertificatesAsync(ListSigningCertificatesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// results using the <c>MaxItems</c> and <c>Marker</c> parameters.
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
        /// results using the <c>MaxItems</c> and <c>Marker</c> parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSSHPublicKeys service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSSHPublicKeys service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListSSHPublicKeys">REST API Reference for ListSSHPublicKeys Operation</seealso>
        Task<ListSSHPublicKeysResponse> ListSSHPublicKeysAsync(ListSSHPublicKeysRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListUserPolicies


        /// <summary>
        /// Lists the names of the inline policies embedded in the specified IAM user.
        /// 
        ///  
        /// <para>
        /// An IAM user can also have managed policies attached to it. To list the managed policies
        /// that are attached to a user, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ListAttachedUserPolicies.html">ListAttachedUserPolicies</a>.
        /// For more information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// policies and inline policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.
        /// If there are no inline policies embedded with the specified user, the operation returns
        /// an empty list.
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
        /// Lists the names of the inline policies embedded in the specified IAM user.
        /// 
        ///  
        /// <para>
        /// An IAM user can also have managed policies attached to it. To list the managed policies
        /// that are attached to a user, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ListAttachedUserPolicies.html">ListAttachedUserPolicies</a>.
        /// For more information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// policies and inline policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.
        /// If there are no inline policies embedded with the specified user, the operation returns
        /// an empty list.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUserPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListUserPoliciesResponse> ListUserPoliciesAsync(ListUserPoliciesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// resource. This operation does not return the following attributes, even though they
        /// are an attribute of the returned object:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// PermissionsBoundary
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tags
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To view all of the information for a user, see <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetUser.html">GetUser</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.
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
        /// resource. This operation does not return the following attributes, even though they
        /// are an attribute of the returned object:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// PermissionsBoundary
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tags
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To view all of the information for a user, see <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetUser.html">GetUser</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.
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
        /// Lists the IAM users that have the specified path prefix. If no path prefix is specified,
        /// the operation returns all users in the Amazon Web Services account. If there are none,
        /// the operation returns an empty list.
        /// 
        ///  <note> 
        /// <para>
        /// IAM resource-listing operations return a subset of the available attributes for the
        /// resource. This operation does not return the following attributes, even though they
        /// are an attribute of the returned object:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// PermissionsBoundary
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tags
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To view all of the information for a user, see <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetUser.html">GetUser</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListUsers service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListUsers">REST API Reference for ListUsers Operation</seealso>
        Task<ListUsersResponse> ListUsersAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Lists the IAM users that have the specified path prefix. If no path prefix is specified,
        /// the operation returns all users in the Amazon Web Services account. If there are none,
        /// the operation returns an empty list.
        /// 
        ///  <note> 
        /// <para>
        /// IAM resource-listing operations return a subset of the available attributes for the
        /// resource. This operation does not return the following attributes, even though they
        /// are an attribute of the returned object:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// PermissionsBoundary
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tags
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To view all of the information for a user, see <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetUser.html">GetUser</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListUsers service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListUsers">REST API Reference for ListUsers Operation</seealso>
        Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists the tags that are attached to the specified IAM user. The returned list of tags
        /// is sorted by tag key. For more information about tagging, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging
        /// IAM resources</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUserTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListUserTagsResponse> ListUserTagsAsync(ListUserTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListVirtualMFADevices


        /// <summary>
        /// Lists the virtual MFA devices defined in the Amazon Web Services account by assignment
        /// status. If you do not specify an assignment status, the operation returns a list of
        /// all virtual MFA devices. Assignment status can be <c>Assigned</c>, <c>Unassigned</c>,
        /// or <c>Any</c>.
        /// 
        ///  <note> 
        /// <para>
        /// IAM resource-listing operations return a subset of the available attributes for the
        /// resource. For example, this operation does not return tags, even though they are an
        /// attribute of the returned object. To view tag information for a virtual MFA device,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ListMFADeviceTags.html">ListMFADeviceTags</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListVirtualMFADevices service method, as returned by IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListVirtualMFADevices">REST API Reference for ListVirtualMFADevices Operation</seealso>
        ListVirtualMFADevicesResponse ListVirtualMFADevices();


        /// <summary>
        /// Lists the virtual MFA devices defined in the Amazon Web Services account by assignment
        /// status. If you do not specify an assignment status, the operation returns a list of
        /// all virtual MFA devices. Assignment status can be <c>Assigned</c>, <c>Unassigned</c>,
        /// or <c>Any</c>.
        /// 
        ///  <note> 
        /// <para>
        /// IAM resource-listing operations return a subset of the available attributes for the
        /// resource. For example, this operation does not return tags, even though they are an
        /// attribute of the returned object. To view tag information for a virtual MFA device,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ListMFADeviceTags.html">ListMFADeviceTags</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVirtualMFADevices service method.</param>
        /// 
        /// <returns>The response from the ListVirtualMFADevices service method, as returned by IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListVirtualMFADevices">REST API Reference for ListVirtualMFADevices Operation</seealso>
        ListVirtualMFADevicesResponse ListVirtualMFADevices(ListVirtualMFADevicesRequest request);


        /// <summary>
        /// Lists the virtual MFA devices defined in the Amazon Web Services account by assignment
        /// status. If you do not specify an assignment status, the operation returns a list of
        /// all virtual MFA devices. Assignment status can be <c>Assigned</c>, <c>Unassigned</c>,
        /// or <c>Any</c>.
        /// 
        ///  <note> 
        /// <para>
        /// IAM resource-listing operations return a subset of the available attributes for the
        /// resource. For example, this operation does not return tags, even though they are an
        /// attribute of the returned object. To view tag information for a virtual MFA device,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ListMFADeviceTags.html">ListMFADeviceTags</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVirtualMFADevices service method, as returned by IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListVirtualMFADevices">REST API Reference for ListVirtualMFADevices Operation</seealso>
        Task<ListVirtualMFADevicesResponse> ListVirtualMFADevicesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Lists the virtual MFA devices defined in the Amazon Web Services account by assignment
        /// status. If you do not specify an assignment status, the operation returns a list of
        /// all virtual MFA devices. Assignment status can be <c>Assigned</c>, <c>Unassigned</c>,
        /// or <c>Any</c>.
        /// 
        ///  <note> 
        /// <para>
        /// IAM resource-listing operations return a subset of the available attributes for the
        /// resource. For example, this operation does not return tags, even though they are an
        /// attribute of the returned object. To view tag information for a virtual MFA device,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ListMFADeviceTags.html">ListMFADeviceTags</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can paginate the results using the <c>MaxItems</c> and <c>Marker</c> parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVirtualMFADevices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVirtualMFADevices service method, as returned by IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListVirtualMFADevices">REST API Reference for ListVirtualMFADevices Operation</seealso>
        Task<ListVirtualMFADevicesResponse> ListVirtualMFADevicesAsync(ListVirtualMFADevicesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutGroupPolicy


        /// <summary>
        /// Adds or updates an inline policy document that is embedded in the specified IAM group.
        /// 
        ///  
        /// <para>
        /// A user can also have managed policies attached to it. To attach a managed policy to
        /// a group, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_AttachGroupPolicy.html">
        /// <c>AttachGroupPolicy</c> </a>. To create a new managed policy, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_CreatePolicy.html">
        /// <c>CreatePolicy</c> </a>. For information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
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
        /// <c>PutGroupPolicy</c>. For general information about using the Query API with IAM,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/IAM_UsingQueryAPI.html">Making
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
        /// Adds or updates an inline policy document that is embedded in the specified IAM group.
        /// 
        ///  
        /// <para>
        /// A user can also have managed policies attached to it. To attach a managed policy to
        /// a group, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_AttachGroupPolicy.html">
        /// <c>AttachGroupPolicy</c> </a>. To create a new managed policy, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_CreatePolicy.html">
        /// <c>CreatePolicy</c> </a>. For information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
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
        /// <c>PutGroupPolicy</c>. For general information about using the Query API with IAM,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/IAM_UsingQueryAPI.html">Making
        /// query requests</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutGroupPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<PutGroupPolicyResponse> PutGroupPolicyAsync(PutGroupPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// The request was rejected because service-linked roles are protected Amazon Web Services
        /// resources. Only the service that depends on the service-linked role can modify or
        /// delete the role on your behalf. The error message includes the name of the service
        /// that depends on this service-linked role. You must request the change through that
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/PutRolePermissionsBoundary">REST API Reference for PutRolePermissionsBoundary Operation</seealso>
        PutRolePermissionsBoundaryResponse PutRolePermissionsBoundary(PutRolePermissionsBoundaryRequest request);



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// The request was rejected because service-linked roles are protected Amazon Web Services
        /// resources. Only the service that depends on the service-linked role can modify or
        /// delete the role on your behalf. The error message includes the name of the service
        /// that depends on this service-linked role. You must request the change through that
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/PutRolePermissionsBoundary">REST API Reference for PutRolePermissionsBoundary Operation</seealso>
        Task<PutRolePermissionsBoundaryResponse> PutRolePermissionsBoundaryAsync(PutRolePermissionsBoundaryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutRolePolicy


        /// <summary>
        /// Adds or updates an inline policy document that is embedded in the specified IAM role.
        /// 
        ///  
        /// <para>
        /// When you embed an inline policy in a role, the inline policy is used as part of the
        /// role's access (permissions) policy. The role's trust policy is created at the same
        /// time as the role, using <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_CreateRole.html">
        /// <c>CreateRole</c> </a>. You can update a role's trust policy using <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_UpdateAssumeRolePolicy.html">
        /// <c>UpdateAssumeRolePolicy</c> </a>. For more information about roles, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/roles-toplevel.html">IAM
        /// roles</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// A role can also have a managed policy attached to it. To attach a managed policy to
        /// a role, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_AttachRolePolicy.html">
        /// <c>AttachRolePolicy</c> </a>. To create a new managed policy, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_CreatePolicy.html">
        /// <c>CreatePolicy</c> </a>. For information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
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
        /// <c>PutRolePolicy</c>. For general information about using the Query API with IAM,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/IAM_UsingQueryAPI.html">Making
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
        /// The request was rejected because service-linked roles are protected Amazon Web Services
        /// resources. Only the service that depends on the service-linked role can modify or
        /// delete the role on your behalf. The error message includes the name of the service
        /// that depends on this service-linked role. You must request the change through that
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/PutRolePolicy">REST API Reference for PutRolePolicy Operation</seealso>
        PutRolePolicyResponse PutRolePolicy(PutRolePolicyRequest request);



        /// <summary>
        /// Adds or updates an inline policy document that is embedded in the specified IAM role.
        /// 
        ///  
        /// <para>
        /// When you embed an inline policy in a role, the inline policy is used as part of the
        /// role's access (permissions) policy. The role's trust policy is created at the same
        /// time as the role, using <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_CreateRole.html">
        /// <c>CreateRole</c> </a>. You can update a role's trust policy using <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_UpdateAssumeRolePolicy.html">
        /// <c>UpdateAssumeRolePolicy</c> </a>. For more information about roles, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/roles-toplevel.html">IAM
        /// roles</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// A role can also have a managed policy attached to it. To attach a managed policy to
        /// a role, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_AttachRolePolicy.html">
        /// <c>AttachRolePolicy</c> </a>. To create a new managed policy, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_CreatePolicy.html">
        /// <c>CreatePolicy</c> </a>. For information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
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
        /// <c>PutRolePolicy</c>. For general information about using the Query API with IAM,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/IAM_UsingQueryAPI.html">Making
        /// query requests</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRolePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// The request was rejected because service-linked roles are protected Amazon Web Services
        /// resources. Only the service that depends on the service-linked role can modify or
        /// delete the role on your behalf. The error message includes the name of the service
        /// that depends on this service-linked role. You must request the change through that
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/PutRolePolicy">REST API Reference for PutRolePolicy Operation</seealso>
        Task<PutRolePolicyResponse> PutRolePolicyAsync(PutRolePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<PutUserPermissionsBoundaryResponse> PutUserPermissionsBoundaryAsync(PutUserPermissionsBoundaryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutUserPolicy


        /// <summary>
        /// Adds or updates an inline policy document that is embedded in the specified IAM user.
        /// 
        ///  
        /// <para>
        /// An IAM user can also have a managed policy attached to it. To attach a managed policy
        /// to a user, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_AttachUserPolicy.html">
        /// <c>AttachUserPolicy</c> </a>. To create a new managed policy, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_CreatePolicy.html">
        /// <c>CreatePolicy</c> </a>. For information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
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
        /// <c>PutUserPolicy</c>. For general information about using the Query API with IAM,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/IAM_UsingQueryAPI.html">Making
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
        /// Adds or updates an inline policy document that is embedded in the specified IAM user.
        /// 
        ///  
        /// <para>
        /// An IAM user can also have a managed policy attached to it. To attach a managed policy
        /// to a user, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_AttachUserPolicy.html">
        /// <c>AttachUserPolicy</c> </a>. To create a new managed policy, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_CreatePolicy.html">
        /// <c>CreatePolicy</c> </a>. For information about policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
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
        /// <c>PutUserPolicy</c>. For general information about using the Query API with IAM,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/IAM_UsingQueryAPI.html">Making
        /// query requests</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutUserPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<PutUserPolicyResponse> PutUserPolicyAsync(PutUserPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<RemoveClientIDFromOpenIDConnectProviderResponse> RemoveClientIDFromOpenIDConnectProviderAsync(RemoveClientIDFromOpenIDConnectProviderRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RemoveRoleFromInstanceProfile


        /// <summary>
        /// Removes the specified IAM role from the specified Amazon EC2 instance profile.
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
        ///  For more information about roles, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles.html">IAM
        /// roles</a> in the <i>IAM User Guide</i>. For more information about instance profiles,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use_switch-role-ec2_instance-profiles.html">Using
        /// instance profiles</a> in the <i>IAM User Guide</i>.
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
        /// The request was rejected because service-linked roles are protected Amazon Web Services
        /// resources. Only the service that depends on the service-linked role can modify or
        /// delete the role on your behalf. The error message includes the name of the service
        /// that depends on this service-linked role. You must request the change through that
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/RemoveRoleFromInstanceProfile">REST API Reference for RemoveRoleFromInstanceProfile Operation</seealso>
        RemoveRoleFromInstanceProfileResponse RemoveRoleFromInstanceProfile(RemoveRoleFromInstanceProfileRequest request);



        /// <summary>
        /// Removes the specified IAM role from the specified Amazon EC2 instance profile.
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
        ///  For more information about roles, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles.html">IAM
        /// roles</a> in the <i>IAM User Guide</i>. For more information about instance profiles,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_use_switch-role-ec2_instance-profiles.html">Using
        /// instance profiles</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveRoleFromInstanceProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// The request was rejected because service-linked roles are protected Amazon Web Services
        /// resources. Only the service that depends on the service-linked role can modify or
        /// delete the role on your behalf. The error message includes the name of the service
        /// that depends on this service-linked role. You must request the change through that
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/RemoveRoleFromInstanceProfile">REST API Reference for RemoveRoleFromInstanceProfile Operation</seealso>
        Task<RemoveRoleFromInstanceProfileResponse> RemoveRoleFromInstanceProfileAsync(RemoveRoleFromInstanceProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Removes the specified user from the specified group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveUserFromGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<RemoveUserFromGroupResponse> RemoveUserFromGroupAsync(RemoveUserFromGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Resets the password for a service-specific credential. The new password is Amazon
        /// Web Services generated and cryptographically strong. It cannot be configured by the
        /// user. Resetting the password immediately invalidates the previous password associated
        /// with this user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetServiceSpecificCredential service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResetServiceSpecificCredential service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ResetServiceSpecificCredential">REST API Reference for ResetServiceSpecificCredential Operation</seealso>
        Task<ResetServiceSpecificCredentialResponse> ResetServiceSpecificCredentialAsync(ResetServiceSpecificCredentialRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <exception cref="Amazon.IdentityManagement.Model.ConcurrentModificationException">
        /// The request was rejected because multiple requests to change this object were submitted
        /// simultaneously. Wait a few minutes and submit your request again.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ResyncMFADevice">REST API Reference for ResyncMFADevice Operation</seealso>
        ResyncMFADeviceResponse ResyncMFADevice(ResyncMFADeviceRequest request);



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResyncMFADevice service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ConcurrentModificationException">
        /// The request was rejected because multiple requests to change this object were submitted
        /// simultaneously. Wait a few minutes and submit your request again.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ResyncMFADevice">REST API Reference for ResyncMFADevice Operation</seealso>
        Task<ResyncMFADeviceResponse> ResyncMFADeviceAsync(ResyncMFADeviceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SetDefaultPolicyVersion


        /// <summary>
        /// Sets the specified version of the specified policy as the policy's default (operative)
        /// version.
        /// 
        ///  
        /// <para>
        /// This operation affects all users, groups, and roles that the policy is attached to.
        /// To list the users, groups, and roles that the policy is attached to, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ListEntitiesForPolicy.html">ListEntitiesForPolicy</a>.
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
        /// Sets the specified version of the specified policy as the policy's default (operative)
        /// version.
        /// 
        ///  
        /// <para>
        /// This operation affects all users, groups, and roles that the policy is attached to.
        /// To list the users, groups, and roles that the policy is attached to, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ListEntitiesForPolicy.html">ListEntitiesForPolicy</a>.
        /// </para>
        ///  
        /// <para>
        /// For information about managed policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// policies and inline policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetDefaultPolicyVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<SetDefaultPolicyVersionResponse> SetDefaultPolicyVersionAsync(SetDefaultPolicyVersionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SetSecurityTokenServicePreferences


        /// <summary>
        /// Sets the specified version of the global endpoint token as the token version used
        /// for the Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// By default, Security Token Service (STS) is available as a global service, and all
        /// STS requests go to a single endpoint at <c>https://sts.amazonaws.com</c>. Amazon Web
        /// Services recommends using Regional STS endpoints to reduce latency, build in redundancy,
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
        /// To view the current session token version, see the <c>GlobalEndpointTokenVersion</c>
        /// entry in the response of the <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetAccountSummary.html">GetAccountSummary</a>
        /// operation.
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
        /// Sets the specified version of the global endpoint token as the token version used
        /// for the Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// By default, Security Token Service (STS) is available as a global service, and all
        /// STS requests go to a single endpoint at <c>https://sts.amazonaws.com</c>. Amazon Web
        /// Services recommends using Regional STS endpoints to reduce latency, build in redundancy,
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
        /// To view the current session token version, see the <c>GlobalEndpointTokenVersion</c>
        /// entry in the response of the <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetAccountSummary.html">GetAccountSummary</a>
        /// operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetSecurityTokenServicePreferences service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetSecurityTokenServicePreferences service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/SetSecurityTokenServicePreferences">REST API Reference for SetSecurityTokenServicePreferences Operation</seealso>
        Task<SetSecurityTokenServicePreferencesResponse> SetSecurityTokenServicePreferencesAsync(SetSecurityTokenServicePreferencesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// or role, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_SimulatePrincipalPolicy.html">SimulatePrincipalPolicy</a>
        /// instead.
        /// </para>
        ///  
        /// <para>
        /// Context keys are variables that are maintained by Amazon Web Services and its services
        /// and which provide details about the context of an API query request. You can use the
        /// <c>Condition</c> element of an IAM policy to evaluate context keys. To get the list
        /// of context keys that the policies require for correct simulation, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetContextKeysForCustomPolicy.html">GetContextKeysForCustomPolicy</a>.
        /// </para>
        ///  
        /// <para>
        /// If the output is long, you can use <c>MaxItems</c> and <c>Marker</c> parameters to
        /// paginate the results.
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
        /// or role, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_SimulatePrincipalPolicy.html">SimulatePrincipalPolicy</a>
        /// instead.
        /// </para>
        ///  
        /// <para>
        /// Context keys are variables that are maintained by Amazon Web Services and its services
        /// and which provide details about the context of an API query request. You can use the
        /// <c>Condition</c> element of an IAM policy to evaluate context keys. To get the list
        /// of context keys that the policies require for correct simulation, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetContextKeysForCustomPolicy.html">GetContextKeysForCustomPolicy</a>.
        /// </para>
        ///  
        /// <para>
        /// If the output is long, you can use <c>MaxItems</c> and <c>Marker</c> parameters to
        /// paginate the results.
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<SimulateCustomPolicyResponse> SimulateCustomPolicyAsync(SimulateCustomPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// as strings, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_SimulateCustomPolicy.html">SimulateCustomPolicy</a>
        /// instead.
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
        /// allowing them to use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_SimulateCustomPolicy.html">SimulateCustomPolicy</a>
        /// instead.
        /// </para>
        ///  
        /// <para>
        /// Context keys are variables maintained by Amazon Web Services and its services that
        /// provide details about the context of an API query request. You can use the <c>Condition</c>
        /// element of an IAM policy to evaluate context keys. To get the list of context keys
        /// that the policies require for correct simulation, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetContextKeysForPrincipalPolicy.html">GetContextKeysForPrincipalPolicy</a>.
        /// </para>
        ///  
        /// <para>
        /// If the output is long, you can use the <c>MaxItems</c> and <c>Marker</c> parameters
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
        /// as strings, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_SimulateCustomPolicy.html">SimulateCustomPolicy</a>
        /// instead.
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
        /// allowing them to use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_SimulateCustomPolicy.html">SimulateCustomPolicy</a>
        /// instead.
        /// </para>
        ///  
        /// <para>
        /// Context keys are variables maintained by Amazon Web Services and its services that
        /// provide details about the context of an API query request. You can use the <c>Condition</c>
        /// element of an IAM policy to evaluate context keys. To get the list of context keys
        /// that the policies require for correct simulation, use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetContextKeysForPrincipalPolicy.html">GetContextKeysForPrincipalPolicy</a>.
        /// </para>
        ///  
        /// <para>
        /// If the output is long, you can use the <c>MaxItems</c> and <c>Marker</c> parameters
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
        /// <param name="request">Container for the necessary parameters to execute the SimulatePrincipalPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<SimulatePrincipalPolicyResponse> SimulatePrincipalPolicyAsync(SimulatePrincipalPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Amazon Web Services always interprets the tag <c>Value</c> as a single string. If
        /// you need to store an array, you can store comma-separated values in the string. However,
        /// you must interpret the value in your code.
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
        /// Amazon Web Services always interprets the tag <c>Value</c> as a single string. If
        /// you need to store an array, you can store comma-separated values in the string. However,
        /// you must interpret the value in your code.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagInstanceProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<TagInstanceProfileResponse> TagInstanceProfileAsync(TagInstanceProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Amazon Web Services always interprets the tag <c>Value</c> as a single string. If
        /// you need to store an array, you can store comma-separated values in the string. However,
        /// you must interpret the value in your code.
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
        /// Amazon Web Services always interprets the tag <c>Value</c> as a single string. If
        /// you need to store an array, you can store comma-separated values in the string. However,
        /// you must interpret the value in your code.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagMFADevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<TagMFADeviceResponse> TagMFADeviceAsync(TagMFADeviceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ///  <b>Access control</b> - Include tags in IAM identity-based and resource-based policies.
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
        /// Amazon Web Services always interprets the tag <c>Value</c> as a single string. If
        /// you need to store an array, you can store comma-separated values in the string. However,
        /// you must interpret the value in your code.
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
        ///  <b>Access control</b> - Include tags in IAM identity-based and resource-based policies.
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
        /// Amazon Web Services always interprets the tag <c>Value</c> as a single string. If
        /// you need to store an array, you can store comma-separated values in the string. However,
        /// you must interpret the value in your code.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagOpenIDConnectProvider service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<TagOpenIDConnectProviderResponse> TagOpenIDConnectProviderAsync(TagOpenIDConnectProviderRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Amazon Web Services always interprets the tag <c>Value</c> as a single string. If
        /// you need to store an array, you can store comma-separated values in the string. However,
        /// you must interpret the value in your code.
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
        /// Amazon Web Services always interprets the tag <c>Value</c> as a single string. If
        /// you need to store an array, you can store comma-separated values in the string. However,
        /// you must interpret the value in your code.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<TagPolicyResponse> TagPolicyAsync(TagPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Amazon Web Services always interprets the tag <c>Value</c> as a single string. If
        /// you need to store an array, you can store comma-separated values in the string. However,
        /// you must interpret the value in your code.
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
        /// Amazon Web Services always interprets the tag <c>Value</c> as a single string. If
        /// you need to store an array, you can store comma-separated values in the string. However,
        /// you must interpret the value in your code.
        /// </para>
        ///  </li> </ul> </note> 
        /// <para>
        /// For more information about tagging, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging
        /// IAM identities</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagRole service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<TagRoleResponse> TagRoleAsync(TagRoleRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Amazon Web Services always interprets the tag <c>Value</c> as a single string. If
        /// you need to store an array, you can store comma-separated values in the string. However,
        /// you must interpret the value in your code.
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
        /// Amazon Web Services always interprets the tag <c>Value</c> as a single string. If
        /// you need to store an array, you can store comma-separated values in the string. However,
        /// you must interpret the value in your code.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagSAMLProvider service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<TagSAMLProviderResponse> TagSAMLProviderAsync(TagSAMLProviderRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Amazon Web Services always interprets the tag <c>Value</c> as a single string. If
        /// you need to store an array, you can store comma-separated values in the string. However,
        /// you must interpret the value in your code.
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
        /// Amazon Web Services always interprets the tag <c>Value</c> as a single string. If
        /// you need to store an array, you can store comma-separated values in the string. However,
        /// you must interpret the value in your code.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagServerCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<TagServerCertificateResponse> TagServerCertificateAsync(TagServerCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ///  <b>Access control</b> - Include tags in IAM identity-based and resource-based policies.
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
        /// Amazon Web Services always interprets the tag <c>Value</c> as a single string. If
        /// you need to store an array, you can store comma-separated values in the string. However,
        /// you must interpret the value in your code.
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
        ///  <b>Access control</b> - Include tags in IAM identity-based and resource-based policies.
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
        /// Amazon Web Services always interprets the tag <c>Value</c> as a single string. If
        /// you need to store an array, you can store comma-separated values in the string. However,
        /// you must interpret the value in your code.
        /// </para>
        ///  </li> </ul> </note> 
        /// <para>
        /// For more information about tagging, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging
        /// IAM identities</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<TagUserResponse> TagUserAsync(TagUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Removes the specified tags from the IAM instance profile. For more information about
        /// tagging, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging
        /// IAM resources</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagInstanceProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UntagInstanceProfileResponse> UntagInstanceProfileAsync(UntagInstanceProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Removes the specified tags from the IAM virtual multi-factor authentication (MFA)
        /// device. For more information about tagging, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging
        /// IAM resources</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagMFADevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UntagMFADeviceResponse> UntagMFADeviceAsync(UntagMFADeviceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Removes the specified tags from the specified OpenID Connect (OIDC)-compatible identity
        /// provider in IAM. For more information about OIDC providers, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_providers_oidc.html">About
        /// web identity federation</a>. For more information about tagging, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging
        /// IAM resources</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagOpenIDConnectProvider service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UntagOpenIDConnectProviderResponse> UntagOpenIDConnectProviderAsync(UntagOpenIDConnectProviderRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Removes the specified tags from the customer managed policy. For more information
        /// about tagging, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging
        /// IAM resources</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UntagPolicyResponse> UntagPolicyAsync(UntagPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Removes the specified tags from the role. For more information about tagging, see
        /// <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging IAM
        /// resources</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagRole service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UntagRoleResponse> UntagRoleAsync(UntagRoleRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Removes the specified tags from the specified Security Assertion Markup Language (SAML)
        /// identity provider in IAM. For more information about these providers, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_providers_oidc.html">About
        /// web identity federation</a>. For more information about tagging, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging
        /// IAM resources</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagSAMLProvider service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UntagSAMLProviderResponse> UntagSAMLProviderAsync(UntagSAMLProviderRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UntagServerCertificateResponse> UntagServerCertificateAsync(UntagServerCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Removes the specified tags from the user. For more information about tagging, see
        /// <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging IAM
        /// resources</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UntagUserResponse> UntagUserAsync(UntagUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateAccessKey


        /// <summary>
        /// Changes the status of the specified access key from Active to Inactive, or vice versa.
        /// This operation can be used to disable a user's key as part of a key rotation workflow.
        /// 
        ///  
        /// <para>
        /// If the <c>UserName</c> is not specified, the user name is determined implicitly based
        /// on the Amazon Web Services access key ID used to sign the request. If a temporary
        /// access key is used, then <c>UserName</c> is required. If a long-term key is assigned
        /// to the user, then <c>UserName</c> is not required. This operation works for access
        /// keys under the Amazon Web Services account. Consequently, you can use this operation
        /// to manage Amazon Web Services account root user credentials even if the Amazon Web
        /// Services account has no associated users.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateAccessKey">REST API Reference for UpdateAccessKey Operation</seealso>
        UpdateAccessKeyResponse UpdateAccessKey(UpdateAccessKeyRequest request);



        /// <summary>
        /// Changes the status of the specified access key from Active to Inactive, or vice versa.
        /// This operation can be used to disable a user's key as part of a key rotation workflow.
        /// 
        ///  
        /// <para>
        /// If the <c>UserName</c> is not specified, the user name is determined implicitly based
        /// on the Amazon Web Services access key ID used to sign the request. If a temporary
        /// access key is used, then <c>UserName</c> is required. If a long-term key is assigned
        /// to the user, then <c>UserName</c> is not required. This operation works for access
        /// keys under the Amazon Web Services account. Consequently, you can use this operation
        /// to manage Amazon Web Services account root user credentials even if the Amazon Web
        /// Services account has no associated users.
        /// </para>
        ///  
        /// <para>
        /// For information about rotating keys, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/ManagingCredentials.html">Managing
        /// keys and certificates</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccessKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAccessKey service method, as returned by IdentityManagementService.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateAccessKey">REST API Reference for UpdateAccessKey Operation</seealso>
        Task<UpdateAccessKeyResponse> UpdateAccessKeyAsync(UpdateAccessKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateAccountPasswordPolicyResponse> UpdateAccountPasswordPolicyAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateAccountPasswordPolicyResponse> UpdateAccountPasswordPolicyAsync(UpdateAccountPasswordPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// The request was rejected because service-linked roles are protected Amazon Web Services
        /// resources. Only the service that depends on the service-linked role can modify or
        /// delete the role on your behalf. The error message includes the name of the service
        /// that depends on this service-linked role. You must request the change through that
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateAssumeRolePolicy">REST API Reference for UpdateAssumeRolePolicy Operation</seealso>
        UpdateAssumeRolePolicyResponse UpdateAssumeRolePolicy(UpdateAssumeRolePolicyRequest request);



        /// <summary>
        /// Updates the policy that grants an IAM entity permission to assume a role. This is
        /// typically referred to as the "role trust policy". For more information about roles,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/roles-toplevel.html">Using
        /// roles to delegate permissions and federate identities</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssumeRolePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// The request was rejected because service-linked roles are protected Amazon Web Services
        /// resources. Only the service that depends on the service-linked role can modify or
        /// delete the role on your behalf. The error message includes the name of the service
        /// that depends on this service-linked role. You must request the change through that
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateAssumeRolePolicy">REST API Reference for UpdateAssumeRolePolicy Operation</seealso>
        Task<UpdateAssumeRolePolicyResponse> UpdateAssumeRolePolicyAsync(UpdateAssumeRolePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <c>Managers</c> to <c>MGRs</c>, the principal must have a policy that allows them
        /// to update both groups. If the principal has permission to update the <c>Managers</c>
        /// group, but not the <c>MGRs</c> group, then the update fails. For more information
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
        /// <c>Managers</c> to <c>MGRs</c>, the principal must have a policy that allows them
        /// to update both groups. If the principal has permission to update the <c>Managers</c>
        /// group, but not the <c>MGRs</c> group, then the update fails. For more information
        /// about permissions, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management</a>. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateGroupResponse> UpdateGroupAsync(UpdateGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateLoginProfile


        /// <summary>
        /// Changes the password for the specified IAM user. You can use the CLI, the Amazon Web
        /// Services API, or the <b>Users</b> page in the IAM console to change the password for
        /// any IAM user. Use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ChangePassword.html">ChangePassword</a>
        /// to change your own password in the <b>My Security Credentials</b> page in the Amazon
        /// Web Services Management Console.
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
        /// Changes the password for the specified IAM user. You can use the CLI, the Amazon Web
        /// Services API, or the <b>Users</b> page in the IAM console to change the password for
        /// any IAM user. Use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ChangePassword.html">ChangePassword</a>
        /// to change your own password in the <b>My Security Credentials</b> page in the Amazon
        /// Web Services Management Console.
        /// 
        ///  
        /// <para>
        /// For more information about modifying passwords, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingLogins.html">Managing
        /// passwords</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLoginProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateLoginProfileResponse> UpdateLoginProfileAsync(UpdateLoginProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Amazon Web Services secures communication with OIDC identity providers (IdPs) using
        /// our library of trusted root certificate authorities (CAs) to verify the JSON Web Key
        /// Set (JWKS) endpoint's TLS certificate. If your OIDC IdP relies on a certificate that
        /// is not signed by one of these trusted CAs, only then we secure communication using
        /// the thumbprints set in the IdP's configuration.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// Trust for the OIDC provider is derived from the provider certificate and is validated
        /// by the thumbprint. Therefore, it is best to limit access to the <c>UpdateOpenIDConnectProviderThumbprint</c>
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
        /// Amazon Web Services secures communication with OIDC identity providers (IdPs) using
        /// our library of trusted root certificate authorities (CAs) to verify the JSON Web Key
        /// Set (JWKS) endpoint's TLS certificate. If your OIDC IdP relies on a certificate that
        /// is not signed by one of these trusted CAs, only then we secure communication using
        /// the thumbprints set in the IdP's configuration.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// Trust for the OIDC provider is derived from the provider certificate and is validated
        /// by the thumbprint. Therefore, it is best to limit access to the <c>UpdateOpenIDConnectProviderThumbprint</c>
        /// operation to highly privileged users.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOpenIDConnectProviderThumbprint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateOpenIDConnectProviderThumbprintResponse> UpdateOpenIDConnectProviderThumbprintAsync(UpdateOpenIDConnectProviderThumbprintRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// The request was rejected because service-linked roles are protected Amazon Web Services
        /// resources. Only the service that depends on the service-linked role can modify or
        /// delete the role on your behalf. The error message includes the name of the service
        /// that depends on this service-linked role. You must request the change through that
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateRole">REST API Reference for UpdateRole Operation</seealso>
        UpdateRoleResponse UpdateRole(UpdateRoleRequest request);



        /// <summary>
        /// Updates the description or maximum session duration setting of a role.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRole service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// The request was rejected because service-linked roles are protected Amazon Web Services
        /// resources. Only the service that depends on the service-linked role can modify or
        /// delete the role on your behalf. The error message includes the name of the service
        /// that depends on this service-linked role. You must request the change through that
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateRole">REST API Reference for UpdateRole Operation</seealso>
        Task<UpdateRoleResponse> UpdateRoleAsync(UpdateRoleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateRoleDescription


        /// <summary>
        /// Use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_UpdateRole.html">UpdateRole</a>
        /// instead.
        /// 
        ///  
        /// <para>
        /// Modifies only the description of a role. This operation performs the same function
        /// as the <c>Description</c> parameter in the <c>UpdateRole</c> operation.
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
        /// The request was rejected because service-linked roles are protected Amazon Web Services
        /// resources. Only the service that depends on the service-linked role can modify or
        /// delete the role on your behalf. The error message includes the name of the service
        /// that depends on this service-linked role. You must request the change through that
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateRoleDescription">REST API Reference for UpdateRoleDescription Operation</seealso>
        UpdateRoleDescriptionResponse UpdateRoleDescription(UpdateRoleDescriptionRequest request);



        /// <summary>
        /// Use <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_UpdateRole.html">UpdateRole</a>
        /// instead.
        /// 
        ///  
        /// <para>
        /// Modifies only the description of a role. This operation performs the same function
        /// as the <c>Description</c> parameter in the <c>UpdateRole</c> operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoleDescription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// The request was rejected because service-linked roles are protected Amazon Web Services
        /// resources. Only the service that depends on the service-linked role can modify or
        /// delete the role on your behalf. The error message includes the name of the service
        /// that depends on this service-linked role. You must request the change through that
        /// service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateRoleDescription">REST API Reference for UpdateRoleDescription Operation</seealso>
        Task<UpdateRoleDescriptionResponse> UpdateRoleDescriptionAsync(UpdateRoleDescriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateSAMLProvider


        /// <summary>
        /// Updates the metadata document, SAML encryption settings, and private keys for an existing
        /// SAML provider. To rotate private keys, add your new private key and then remove the
        /// old key in a separate request.
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
        /// Updates the metadata document, SAML encryption settings, and private keys for an existing
        /// SAML provider. To rotate private keys, add your new private key and then remove the
        /// old key in a separate request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSAMLProvider service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateSAMLProviderResponse> UpdateSAMLProviderAsync(UpdateSAMLProviderRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// certificate named <c>ProductionCert</c> to <c>ProdCert</c>, the principal must have
        /// a policy that allows them to update both certificates. If the principal has permission
        /// to update the <c>ProductionCert</c> group, but not the <c>ProdCert</c> certificate,
        /// then the update fails. For more information about permissions, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management</a> in the <i>IAM User Guide</i>.
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
        /// certificate named <c>ProductionCert</c> to <c>ProdCert</c>, the principal must have
        /// a policy that allows them to update both certificates. If the principal has permission
        /// to update the <c>ProductionCert</c> group, but not the <c>ProdCert</c> certificate,
        /// then the update fails. For more information about permissions, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access
        /// management</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServerCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateServerCertificateResponse> UpdateServerCertificateAsync(UpdateServerCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateServiceSpecificCredential


        /// <summary>
        /// Sets the status of a service-specific credential to <c>Active</c> or <c>Inactive</c>.
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
        /// Sets the status of a service-specific credential to <c>Active</c> or <c>Inactive</c>.
        /// Service-specific credentials that are inactive cannot be used for authentication to
        /// the service. This operation can be used to disable a user's service-specific credential
        /// as part of a credential rotation work flow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceSpecificCredential service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateServiceSpecificCredential service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateServiceSpecificCredential">REST API Reference for UpdateServiceSpecificCredential Operation</seealso>
        Task<UpdateServiceSpecificCredentialResponse> UpdateServiceSpecificCredentialAsync(UpdateServiceSpecificCredentialRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateSigningCertificate


        /// <summary>
        /// Changes the status of the specified user signing certificate from active to disabled,
        /// or vice versa. This operation can be used to disable an IAM user's signing certificate
        /// as part of a certificate rotation work flow.
        /// 
        ///  
        /// <para>
        /// If the <c>UserName</c> field is not specified, the user name is determined implicitly
        /// based on the Amazon Web Services access key ID used to sign the request. This operation
        /// works for access keys under the Amazon Web Services account. Consequently, you can
        /// use this operation to manage Amazon Web Services account root user credentials even
        /// if the Amazon Web Services account has no associated users.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSigningCertificate service method.</param>
        /// 
        /// <returns>The response from the UpdateSigningCertificate service method, as returned by IdentityManagementService.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateSigningCertificate">REST API Reference for UpdateSigningCertificate Operation</seealso>
        UpdateSigningCertificateResponse UpdateSigningCertificate(UpdateSigningCertificateRequest request);



        /// <summary>
        /// Changes the status of the specified user signing certificate from active to disabled,
        /// or vice versa. This operation can be used to disable an IAM user's signing certificate
        /// as part of a certificate rotation work flow.
        /// 
        ///  
        /// <para>
        /// If the <c>UserName</c> field is not specified, the user name is determined implicitly
        /// based on the Amazon Web Services access key ID used to sign the request. This operation
        /// works for access keys under the Amazon Web Services account. Consequently, you can
        /// use this operation to manage Amazon Web Services account root user credentials even
        /// if the Amazon Web Services account has no associated users.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSigningCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSigningCertificate service method, as returned by IdentityManagementService.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateSigningCertificate">REST API Reference for UpdateSigningCertificate Operation</seealso>
        Task<UpdateSigningCertificateResponse> UpdateSigningCertificateAsync(UpdateSigningCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateSSHPublicKey">REST API Reference for UpdateSSHPublicKey Operation</seealso>
        UpdateSSHPublicKeyResponse UpdateSSHPublicKey(UpdateSSHPublicKeyRequest request);



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSSHPublicKey service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateSSHPublicKey">REST API Reference for UpdateSSHPublicKey Operation</seealso>
        Task<UpdateSSHPublicKeyResponse> UpdateSSHPublicKeyAsync(UpdateSSHPublicKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateUserResponse> UpdateUserAsync(UpdateUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// can be large, you should use POST rather than GET when calling <c>UploadServerCertificate</c>.
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
        /// can be large, you should use POST rather than GET when calling <c>UploadServerCertificate</c>.
        /// For information about setting up signatures and authorization through the API, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/signing_aws_api_requests.html">Signing
        /// Amazon Web Services API requests</a> in the <i>Amazon Web Services General Reference</i>.
        /// For general information about using the Query API with IAM, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/programming.html">Calling
        /// the API by making HTTP query requests</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UploadServerCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UploadServerCertificateResponse> UploadServerCertificateAsync(UploadServerCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UploadSigningCertificate


        /// <summary>
        /// Uploads an X.509 signing certificate and associates it with the specified IAM user.
        /// Some Amazon Web Services services require you to use certificates to validate requests
        /// that are signed with a corresponding private key. When you upload the certificate,
        /// its default status is <c>Active</c>.
        /// 
        ///  
        /// <para>
        /// For information about when you would use an X.509 signing certificate, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_server-certs.html">Managing
        /// server certificates in IAM</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If the <c>UserName</c> is not specified, the IAM user name is determined implicitly
        /// based on the Amazon Web Services access key ID used to sign the request. This operation
        /// works for access keys under the Amazon Web Services account. Consequently, you can
        /// use this operation to manage Amazon Web Services account root user credentials even
        /// if the Amazon Web Services account has no associated users.
        /// </para>
        ///  <note> 
        /// <para>
        /// Because the body of an X.509 certificate can be large, you should use POST rather
        /// than GET when calling <c>UploadSigningCertificate</c>. For information about setting
        /// up signatures and authorization through the API, see <a href="https://docs.aws.amazon.com/general/latest/gr/signing_aws_api_requests.html">Signing
        /// Amazon Web Services API requests</a> in the <i>Amazon Web Services General Reference</i>.
        /// For general information about using the Query API with IAM, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/IAM_UsingQueryAPI.html">Making
        /// query requests</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UploadSigningCertificate service method.</param>
        /// 
        /// <returns>The response from the UploadSigningCertificate service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ConcurrentModificationException">
        /// The request was rejected because multiple requests to change this object were submitted
        /// simultaneously. Wait a few minutes and submit your request again.
        /// </exception>
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
        /// Uploads an X.509 signing certificate and associates it with the specified IAM user.
        /// Some Amazon Web Services services require you to use certificates to validate requests
        /// that are signed with a corresponding private key. When you upload the certificate,
        /// its default status is <c>Active</c>.
        /// 
        ///  
        /// <para>
        /// For information about when you would use an X.509 signing certificate, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_server-certs.html">Managing
        /// server certificates in IAM</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If the <c>UserName</c> is not specified, the IAM user name is determined implicitly
        /// based on the Amazon Web Services access key ID used to sign the request. This operation
        /// works for access keys under the Amazon Web Services account. Consequently, you can
        /// use this operation to manage Amazon Web Services account root user credentials even
        /// if the Amazon Web Services account has no associated users.
        /// </para>
        ///  <note> 
        /// <para>
        /// Because the body of an X.509 certificate can be large, you should use POST rather
        /// than GET when calling <c>UploadSigningCertificate</c>. For information about setting
        /// up signatures and authorization through the API, see <a href="https://docs.aws.amazon.com/general/latest/gr/signing_aws_api_requests.html">Signing
        /// Amazon Web Services API requests</a> in the <i>Amazon Web Services General Reference</i>.
        /// For general information about using the Query API with IAM, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/IAM_UsingQueryAPI.html">Making
        /// query requests</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UploadSigningCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UploadSigningCertificate service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ConcurrentModificationException">
        /// The request was rejected because multiple requests to change this object were submitted
        /// simultaneously. Wait a few minutes and submit your request again.
        /// </exception>
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
        Task<UploadSigningCertificateResponse> UploadSigningCertificateAsync(UploadSigningCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UploadSSHPublicKeyResponse> UploadSSHPublicKeyAsync(UploadSSHPublicKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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