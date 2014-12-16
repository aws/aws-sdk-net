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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */

using System;
using System.IO;
using System.Collections.Generic;
using Amazon.IdentityManagement.Model;

namespace Amazon.IdentityManagement.Resources
{

    #region IAccessKey

    /// <summary>
    /// This interface represents the AccessKey resource.
    /// </summary>
    public interface IAccessKey
    {
        /// <summary>
        /// Gets the value of the UserName identifier for this resource. 
        /// </summary>        
        string UserName { get; }

        /// <summary>
        /// Gets the value of the Id identifier for this resource. 
        /// </summary>        
        string Id { get; }

        /// <summary>
        /// Gets the value of the property CreateDate. 
        /// <para>
        /// The date when the access key was created.
        /// </para>
        /// </summary>
        DateTime CreateDate { get; }

        /// <summary>
        /// Gets the value of the property SecretAccessKey. 
        /// <para>
        /// The secret key used to sign requests.
        /// </para>
        /// </summary>
        string SecretAccessKey { get; }

        /// <summary>
        /// Gets the value of the property Status. 
        /// <para>
        ///  The status of the access key. <code>Active</code> means the key is valid for API
        /// calls, while <code>Inactive</code> means it is not. 
        /// </para>
        /// </summary>
        StatusType Status { get; }


        # region Actions

        /// <summary>
        /// Calls the Activate operation on the AccessKey resource.
        /// </summary>
        /// <para>
        /// This method internally calls the UpdateAccessKey operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccessKey operation.</param>
        void Activate(UpdateAccessKeyRequest request);

        /// <summary>
        /// Calls the Deactivate operation on the AccessKey resource.
        /// </summary>
        /// <para>
        /// This method internally calls the UpdateAccessKey operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccessKey operation.</param>
        void Deactivate(UpdateAccessKeyRequest request);

        /// <summary>
        /// Calls the Delete operation on the AccessKey resource.
        /// </summary>
        /// <para>
        /// This method internally calls the DeleteAccessKey operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessKey operation.</param>
        void Delete(DeleteAccessKeyRequest request);

        /// <summary>
        /// Calls the Delete operation on the AccessKey resource.
        /// </summary>
        /// <para>
        /// This method internally calls the DeleteAccessKey operation on the service.
        /// </para>
        void Delete();


        #endregion

    }    
    #endregion

    #region IAccountAlias

    /// <summary>
    /// This interface represents the AccountAlias resource.
    /// </summary>
    public interface IAccountAlias
    {
        /// <summary>
        /// Gets the value of the Name identifier for this resource. 
        /// </summary>        
        string Name { get; }


        # region Actions

        /// <summary>
        /// Calls the Delete operation on the AccountAlias resource.
        /// </summary>
        /// <para>
        /// This method internally calls the DeleteAccountAlias operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountAlias operation.</param>
        void Delete(DeleteAccountAliasRequest request);

        /// <summary>
        /// Calls the Delete operation on the AccountAlias resource.
        /// </summary>
        /// <para>
        /// This method internally calls the DeleteAccountAlias operation on the service.
        /// </para>
        void Delete();


        #endregion

    }    
    #endregion

    #region IAccountPasswordPolicy

    /// <summary>
    /// This interface represents the AccountPasswordPolicy resource.
    /// </summary>
    public interface IAccountPasswordPolicy
    {
        /// <summary>
        /// Gets the value of the property AllowUsersToChangePassword. 
        /// <para>
        /// Specifies whether IAM users are allowed to change their own password.
        /// </para>
        /// </summary>
        bool AllowUsersToChangePassword { get; }

        /// <summary>
        /// Gets the value of the property ExpirePasswords. 
        /// <para>
        /// Specifies whether IAM users are required to change their password after a specified
        /// number of days.
        /// </para>
        /// </summary>
        bool ExpirePasswords { get; }

        /// <summary>
        /// Gets the value of the property HardExpiry. 
        /// <para>
        /// Specifies whether IAM users are prevented from setting a new password after their
        /// password has expired.
        /// </para>
        /// </summary>
        bool HardExpiry { get; }

        /// <summary>
        /// Gets the value of the property MaxPasswordAge. 
        /// <para>
        /// The number of days that an IAM user password is valid.
        /// </para>
        /// </summary>
        int MaxPasswordAge { get; }

        /// <summary>
        /// Gets the value of the property MinimumPasswordLength. 
        /// <para>
        /// Minimum length to require for IAM user passwords.
        /// </para>
        /// </summary>
        int MinimumPasswordLength { get; }

        /// <summary>
        /// Gets the value of the property PasswordReusePrevention. 
        /// <para>
        /// Specifies the number of previous passwords that IAM users are prevented from reusing.
        /// </para>
        /// </summary>
        int PasswordReusePrevention { get; }

        /// <summary>
        /// Gets the value of the property RequireLowercaseCharacters. 
        /// <para>
        /// Specifies whether to require lowercase characters for IAM user passwords.
        /// </para>
        /// </summary>
        bool RequireLowercaseCharacters { get; }

        /// <summary>
        /// Gets the value of the property RequireNumbers. 
        /// <para>
        /// Specifies whether to require numbers for IAM user passwords.
        /// </para>
        /// </summary>
        bool RequireNumbers { get; }

        /// <summary>
        /// Gets the value of the property RequireSymbols. 
        /// <para>
        /// Specifies whether to require symbols for IAM user passwords.
        /// </para>
        /// </summary>
        bool RequireSymbols { get; }

        /// <summary>
        /// Gets the value of the property RequireUppercaseCharacters. 
        /// <para>
        /// Specifies whether to require uppercase characters for IAM user passwords.
        /// </para>
        /// </summary>
        bool RequireUppercaseCharacters { get; }


        # region Actions

        /// <summary>
        /// Calls the Delete operation on the AccountPasswordPolicy resource.
        /// </summary>
        /// <para>
        /// This method internally calls the DeleteAccountPasswordPolicy operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountPasswordPolicy operation.</param>
        void Delete(DeleteAccountPasswordPolicyRequest request);

        /// <summary>
        /// Calls the Delete operation on the AccountPasswordPolicy resource.
        /// </summary>
        /// <para>
        /// This method internally calls the DeleteAccountPasswordPolicy operation on the service.
        /// </para>
        void Delete();

        /// <summary>
        /// Calls the Update operation on the AccountPasswordPolicy resource.
        /// </summary>
        /// <para>
        /// This method internally calls the UpdateAccountPasswordPolicy operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountPasswordPolicy operation.</param>
        void Update(UpdateAccountPasswordPolicyRequest request);


        #endregion

    }    
    #endregion

    #region IAccountSummary

    /// <summary>
    /// This interface represents the AccountSummary resource.
    /// </summary>
    public interface IAccountSummary
    {
        /// <summary>
        /// Gets the value of the property SummaryMap. 
        /// <para>
        /// A set of key value pairs containing account-level information.
        /// </para>
        ///  
        /// <para>
        ///  <code>SummaryMap</code> contains the following keys: <ul> <li>
        /// <para>
        /// <code>AccessKeysPerUserQuota</code> - Maximum number of access keys that can be created
        /// per user
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>AccountMFAEnabled</code> - 1 if the root account has an MFA device assigned
        /// to it, 0 otherwise
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>AssumeRolePolicySizeQuota</code> - Maximum allowed size for assume role policy
        /// documents (in kilobytes)
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>GroupPolicySizeQuota</code> - Maximum allowed size for Group policy documents
        /// (in kilobytes)
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>Groups</code> - Number of Groups for the AWS account
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>GroupsPerUserQuota</code> - Maximum number of groups an IAM user can belong
        /// to
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>GroupsQuota</code> - Maximum groups allowed for the AWS account
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>InstanceProfiles</code> - Number of instance profiles for the AWS account
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>InstanceProfilesQuota</code> - Maximum instance profiles allowed for the AWS
        /// account
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>MFADevices</code> - Number of MFA devices, either assigned or unassigned
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>MFADevicesInUse</code> - Number of MFA devices that have been assigned to an
        /// IAM user or to the root account
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>RolePolicySizeQuota</code> - Maximum allowed size for role policy documents
        /// (in kilobytes)
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>Roles</code> - Number of roles for the AWS account
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>RolesQuota</code> - Maximum roles allowed for the AWS account
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>ServerCertificates</code> - Number of server certificates for the AWS account
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>ServerCertificatesQuota</code> - Maximum server certificates allowed for the
        /// AWS account
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>SigningCertificatesPerUserQuota</code> - Maximum number of X509 certificates
        /// allowed for a user
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>UserPolicySizeQuota</code> - Maximum allowed size for user policy documents
        /// (in kilobytes)
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>Users</code> - Number of users for the AWS account
        /// </para>
        /// </li> <li>
        /// <para>
        /// <code>UsersQuota</code> - Maximum users allowed for the AWS account
        /// </para>
        /// </li> </ul> 
        /// </para>
        /// </summary>
        Dictionary<string, int> SummaryMap { get; }


        # region Actions


        #endregion

    }    
    #endregion

    #region IGroup

    /// <summary>
    /// This interface represents the Group resource.
    /// </summary>
    public interface IGroup
    {
        /// <summary>
        /// Gets the value of the Name identifier for this resource. 
        /// </summary>        
        string Name { get; }

        /// <summary>
        /// Gets the value of the property Arn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) specifying the group. For more information about ARNs
        /// and how to use them in policies, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">IAM
        /// Identifiers</a> in the <i>Using IAM</i> guide. 
        /// </para>
        /// </summary>
        string Arn { get; }

        /// <summary>
        /// Gets the value of the property CreateDate. 
        /// <para>
        /// The date when the group was created.
        /// </para>
        /// </summary>
        DateTime CreateDate { get; }

        /// <summary>
        /// Gets the value of the property GroupId. 
        /// <para>
        ///  The stable and unique string identifying the group. For more information about IDs,
        /// see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">IAM
        /// Identifiers</a> in the <i>Using IAM</i> guide. 
        /// </para>
        /// </summary>
        string GroupId { get; }

        /// <summary>
        /// Gets the value of the property Path. 
        /// <para>
        /// The path to the group. For more information about paths, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">IAM
        /// Identifiers</a> in the <i>Using IAM</i> guide. 
        /// </para>
        /// </summary>
        string Path { get; }


        # region Actions

        /// <summary>
        /// Calls the AddUser operation on the Group resource.
        /// </summary>
        /// <para>
        /// This method internally calls the AddUserToGroup operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the AddUserToGroup operation.</param>
        void AddUser(AddUserToGroupRequest request);

        /// <summary>
        /// Calls the AddUser operation on the Group resource.
        /// </summary>
        /// <para>
        /// This method internally calls the AddUserToGroup operation on the service.
        /// </para>
        /// <param name="userName">The name of the user to add.</param>
        void AddUser(string userName);

        /// <summary>
        /// Calls the Create operation on the Group resource.
        /// </summary>
        /// <para>
        /// This method internally calls the CreateGroup operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup operation.</param>
        void Create(CreateGroupRequest request);

        /// <summary>
        /// Calls the Create operation on the Group resource.
        /// </summary>
        /// <para>
        /// This method internally calls the CreateGroup operation on the service.
        /// </para>
        void Create();

        /// <summary>
        /// Calls the CreatePolicy operation on the Group resource.
        /// </summary>
        /// <para>
        /// This method internally calls the PutGroupPolicy operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the PutGroupPolicy operation.</param>
        /// <returns>An instance of GroupPolicy resource.</returns>
        IGroupPolicy CreatePolicy(PutGroupPolicyRequest request);

        /// <summary>
        /// Calls the CreatePolicy operation on the Group resource.
        /// </summary>
        /// <para>
        /// This method internally calls the PutGroupPolicy operation on the service.
        /// </para>
        /// <returns>An instance of GroupPolicy resource.</returns>
        /// <param name="policyDocument">The policy document.</param>
        /// <param name="policyName">The name of the policy document.</param>
        IGroupPolicy CreatePolicy(string policyDocument, string policyName);

        /// <summary>
        /// Calls the Delete operation on the Group resource.
        /// </summary>
        /// <para>
        /// This method internally calls the DeleteGroup operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup operation.</param>
        void Delete(DeleteGroupRequest request);

        /// <summary>
        /// Calls the Delete operation on the Group resource.
        /// </summary>
        /// <para>
        /// This method internally calls the DeleteGroup operation on the service.
        /// </para>
        void Delete();

        /// <summary>
        /// Calls the RemoveUser operation on the Group resource.
        /// </summary>
        /// <para>
        /// This method internally calls the RemoveUserFromGroup operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the RemoveUserFromGroup operation.</param>
        void RemoveUser(RemoveUserFromGroupRequest request);

        /// <summary>
        /// Calls the RemoveUser operation on the Group resource.
        /// </summary>
        /// <para>
        /// This method internally calls the RemoveUserFromGroup operation on the service.
        /// </para>
        /// <param name="userName">The name of the user to remove.</param>
        void RemoveUser(string userName);

        /// <summary>
        /// Calls the Update operation on the Group resource.
        /// </summary>
        /// <para>
        /// This method internally calls the UpdateGroup operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup operation.</param>
        /// <returns>An instance of Group resource.</returns>
        IGroup Update(UpdateGroupRequest request);


        #endregion

        #region Enumerable collections

        /// <summary>
        /// Gets the Policies associated with this Group.        
        /// <para>
        /// NOTE : This method calls a service operation that supports paging. Enumerating through the
        /// result of this method can potentially make multiple service operation calls.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupPoliciesEnumerator operation.</param>
        /// <returns>Returns an enumerable collection of Policies.</returns>
        IEnumerable<IGroupPolicy> GetPolicies(ListGroupPoliciesRequest request);

        /// <summary>
        /// Gets the Policies associated with this Group.        
        /// <para>
        /// NOTE : This method calls a service operation that supports paging. Enumerating through the
        /// result of this method can potentially make multiple service operation calls.
        /// </para>
        /// </summary>
        /// <returns>Returns an enumerable collection of Policies.</returns>
        IEnumerable<IGroupPolicy> GetPolicies();

        /// <summary>
        /// Gets the Users associated with this Group.        
        /// <para>
        /// NOTE : This method calls a service operation that supports paging. Enumerating through the
        /// result of this method can potentially make multiple service operation calls.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGroupEnumerator operation.</param>
        /// <returns>Returns an enumerable collection of Users.</returns>
        IEnumerable<IUser> GetUsers(GetGroupRequest request);

        /// <summary>
        /// Gets the Users associated with this Group.        
        /// <para>
        /// NOTE : This method calls a service operation that supports paging. Enumerating through the
        /// result of this method can potentially make multiple service operation calls.
        /// </para>
        /// </summary>
        /// <returns>Returns an enumerable collection of Users.</returns>
        IEnumerable<IUser> GetUsers();


        #endregion

        #region Subresources

        /// <summary>
        /// Gets a GroupPolicy associated with this Group resource using its identifier.
        /// <para>
        /// This method does not make a service call, it returns a resource instance
        /// only with its identifier properties initialized. Accessing any non-identifier 
        /// properties or operations on the resource that in turn access any non-identifier 
        /// properties will cause the resource to make a service call to load its data.
        /// </para>
        /// <para>
        /// NOTE : This method does not make a service call when the resource is initally
        /// constructed. If you pass invalid identifiers to this method, it will return a resource
        /// that may not exist on the server. In this case an exception will be thrown when 
        /// the resource tries to load itself due to conditions listed in the previous section.
        /// </para>
        /// </summary>
        /// <param name="name">The name of the GroupPolicy.</param>
        /// <returns>Returns an instance of GroupPolicy.</returns>
        IGroupPolicy GetGroupPolicyByName(string name);


        #endregion
    }    
    #endregion

    #region IGroupPolicy

    /// <summary>
    /// This interface represents the GroupPolicy resource.
    /// </summary>
    public interface IGroupPolicy
    {
        /// <summary>
        /// Gets the value of the GroupName identifier for this resource. 
        /// </summary>        
        string GroupName { get; }

        /// <summary>
        /// Gets the value of the Name identifier for this resource. 
        /// </summary>        
        string Name { get; }

        /// <summary>
        /// Gets the value of the property PolicyDocument. 
        /// <para>
        /// The policy document.
        /// </para>
        /// </summary>
        string PolicyDocument { get; }


        # region Actions

        /// <summary>
        /// Calls the Delete operation on the GroupPolicy resource.
        /// </summary>
        /// <para>
        /// This method internally calls the DeleteGroupPolicy operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroupPolicy operation.</param>
        void Delete(DeleteGroupPolicyRequest request);

        /// <summary>
        /// Calls the Delete operation on the GroupPolicy resource.
        /// </summary>
        /// <para>
        /// This method internally calls the DeleteGroupPolicy operation on the service.
        /// </para>
        void Delete();

        /// <summary>
        /// Calls the Put operation on the GroupPolicy resource.
        /// </summary>
        /// <para>
        /// This method internally calls the PutGroupPolicy operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the PutGroupPolicy operation.</param>
        void Put(PutGroupPolicyRequest request);

        /// <summary>
        /// Calls the Put operation on the GroupPolicy resource.
        /// </summary>
        /// <para>
        /// This method internally calls the PutGroupPolicy operation on the service.
        /// </para>
        /// <param name="policyDocument">The policy document.</param>
        void Put(string policyDocument);


        #endregion

    }    
    #endregion

    #region IInstanceProfile

    /// <summary>
    /// This interface represents the InstanceProfile resource.
    /// </summary>
    public interface IInstanceProfile
    {
        /// <summary>
        /// Gets the value of the Name identifier for this resource. 
        /// </summary>        
        string Name { get; }

        /// <summary>
        /// Gets the value of the property Arn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) specifying the instance profile. For more information
        /// about ARNs and how to use them in policies, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">IAM
        /// Identifiers</a> in the <i>Using IAM</i> guide. 
        /// </para>
        /// </summary>
        string Arn { get; }

        /// <summary>
        /// Gets the value of the property CreateDate. 
        /// <para>
        /// The date when the instance profile was created.
        /// </para>
        /// </summary>
        DateTime CreateDate { get; }

        /// <summary>
        /// Gets the value of the property InstanceProfileId. 
        /// <para>
        ///  The stable and unique string identifying the instance profile. For more information
        /// about IDs, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">IAM
        /// Identifiers</a> in the <i>Using IAM</i> guide. 
        /// </para>
        /// </summary>
        string InstanceProfileId { get; }

        /// <summary>
        /// Gets the value of the property Path. 
        /// <para>
        ///  The path to the instance profile. For more information about paths, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">IAM
        /// Identifiers</a> in the <i>Using IAM</i> guide. 
        /// </para>
        /// </summary>
        string Path { get; }

        /// <summary>
        /// Gets the value of the property Roles. 
        /// <para>
        /// The role associated with the instance profile.
        /// </para>
        /// </summary>
        List<IRole> Roles { get; }


        # region Actions

        /// <summary>
        /// Calls the AddRole operation on the InstanceProfile resource.
        /// </summary>
        /// <para>
        /// This method internally calls the AddRoleToInstanceProfile operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the AddRoleToInstanceProfile operation.</param>
        void AddRole(AddRoleToInstanceProfileRequest request);

        /// <summary>
        /// Calls the AddRole operation on the InstanceProfile resource.
        /// </summary>
        /// <para>
        /// This method internally calls the AddRoleToInstanceProfile operation on the service.
        /// </para>
        /// <param name="roleName">The name of the role to add.</param>
        void AddRole(string roleName);

        /// <summary>
        /// Calls the Delete operation on the InstanceProfile resource.
        /// </summary>
        /// <para>
        /// This method internally calls the DeleteInstanceProfile operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstanceProfile operation.</param>
        void Delete(DeleteInstanceProfileRequest request);

        /// <summary>
        /// Calls the Delete operation on the InstanceProfile resource.
        /// </summary>
        /// <para>
        /// This method internally calls the DeleteInstanceProfile operation on the service.
        /// </para>
        void Delete();

        /// <summary>
        /// Calls the RemoveRole operation on the InstanceProfile resource.
        /// </summary>
        /// <para>
        /// This method internally calls the RemoveRoleFromInstanceProfile operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the RemoveRoleFromInstanceProfile operation.</param>
        void RemoveRole(RemoveRoleFromInstanceProfileRequest request);

        /// <summary>
        /// Calls the RemoveRole operation on the InstanceProfile resource.
        /// </summary>
        /// <para>
        /// This method internally calls the RemoveRoleFromInstanceProfile operation on the service.
        /// </para>
        /// <param name="roleName">The name of the role to remove.</param>
        void RemoveRole(string roleName);


        #endregion

    }    
    #endregion

    #region ILoginProfile

    /// <summary>
    /// This interface represents the LoginProfile resource.
    /// </summary>
    public interface ILoginProfile
    {
        /// <summary>
        /// Gets the value of the UserName identifier for this resource. 
        /// </summary>        
        string UserName { get; }

        /// <summary>
        /// Gets the value of the property CreateDate. 
        /// <para>
        /// The date when the password for the user was created.
        /// </para>
        /// </summary>
        DateTime CreateDate { get; }

        /// <summary>
        /// Gets the value of the property PasswordResetRequired. 
        /// <para>
        /// Specifies whether the user is required to set a new password on next sign-in.
        /// </para>
        /// </summary>
        bool PasswordResetRequired { get; }


        # region Actions

        /// <summary>
        /// Calls the Create operation on the LoginProfile resource.
        /// </summary>
        /// <para>
        /// This method internally calls the CreateLoginProfile operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the CreateLoginProfile operation.</param>
        void Create(CreateLoginProfileRequest request);

        /// <summary>
        /// Calls the Delete operation on the LoginProfile resource.
        /// </summary>
        /// <para>
        /// This method internally calls the DeleteLoginProfile operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoginProfile operation.</param>
        void Delete(DeleteLoginProfileRequest request);

        /// <summary>
        /// Calls the Delete operation on the LoginProfile resource.
        /// </summary>
        /// <para>
        /// This method internally calls the DeleteLoginProfile operation on the service.
        /// </para>
        void Delete();

        /// <summary>
        /// Calls the Update operation on the LoginProfile resource.
        /// </summary>
        /// <para>
        /// This method internally calls the UpdateLoginProfile operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLoginProfile operation.</param>
        void Update(UpdateLoginProfileRequest request);


        #endregion

    }    
    #endregion

    #region IMfaDevice

    /// <summary>
    /// This interface represents the MfaDevice resource.
    /// </summary>
    public interface IMfaDevice
    {
        /// <summary>
        /// Gets the value of the UserName identifier for this resource. 
        /// </summary>        
        string UserName { get; }

        /// <summary>
        /// Gets the value of the SerialNumber identifier for this resource. 
        /// </summary>        
        string SerialNumber { get; }

        /// <summary>
        /// Gets the value of the property EnableDate. 
        /// <para>
        /// The date when the MFA device was enabled for the user.
        /// </para>
        /// </summary>
        DateTime EnableDate { get; }


        # region Actions

        /// <summary>
        /// Calls the Deactivate operation on the MfaDevice resource.
        /// </summary>
        /// <para>
        /// This method internally calls the DeactivateMFADevice operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the DeactivateMFADevice operation.</param>
        void Deactivate(DeactivateMFADeviceRequest request);

        /// <summary>
        /// Calls the Deactivate operation on the MfaDevice resource.
        /// </summary>
        /// <para>
        /// This method internally calls the DeactivateMFADevice operation on the service.
        /// </para>
        void Deactivate();

        /// <summary>
        /// Calls the Enable operation on the MfaDevice resource.
        /// </summary>
        /// <para>
        /// This method internally calls the EnableMFADevice operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the EnableMFADevice operation.</param>
        void Enable(EnableMFADeviceRequest request);

        /// <summary>
        /// Calls the Resync operation on the MfaDevice resource.
        /// </summary>
        /// <para>
        /// This method internally calls the ResyncMFADevice operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the ResyncMFADevice operation.</param>
        void Resync(ResyncMFADeviceRequest request);


        #endregion

    }    
    #endregion

    #region IRole

    /// <summary>
    /// This interface represents the Role resource.
    /// </summary>
    public interface IRole
    {
        /// <summary>
        /// Gets the value of the Name identifier for this resource. 
        /// </summary>        
        string Name { get; }

        /// <summary>
        /// Gets the value of the property Arn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) specifying the role. For more information about ARNs
        /// and how to use them in policies, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">IAM
        /// Identifiers</a> in the <i>Using IAM</i> guide. 
        /// </para>
        /// </summary>
        string Arn { get; }

        /// <summary>
        /// Gets the value of the property AssumeRolePolicyDocument. 
        /// <para>
        /// The policy that grants an entity permission to assume the role.
        /// </para>
        ///  
        /// <para>
        ///  The returned policy is URL-encoded according to RFC 3986. For more information about
        /// RFC 3986, go to <a href="http://www.faqs.org/rfcs/rfc3986.html">http://www.faqs.org/rfcs/rfc3986.html</a>.
        /// 
        /// </para>
        /// </summary>
        string AssumeRolePolicyDocument { get; }

        /// <summary>
        /// Gets the value of the property CreateDate. 
        /// <para>
        /// The date when the role was created.
        /// </para>
        /// </summary>
        DateTime CreateDate { get; }

        /// <summary>
        /// Gets the value of the property Path. 
        /// <para>
        ///  The path to the role. For more information about paths, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">IAM
        /// Identifiers</a> in the <i>Using IAM</i> guide. 
        /// </para>
        /// </summary>
        string Path { get; }

        /// <summary>
        /// Gets the value of the property RoleId. 
        /// <para>
        ///  The stable and unique string identifying the role. For more information about IDs,
        /// see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">IAM
        /// Identifiers</a> in the <i>Using IAM</i> guide. 
        /// </para>
        /// </summary>
        string RoleId { get; }


        # region Actions

        /// <summary>
        /// Calls the Delete operation on the Role resource.
        /// </summary>
        /// <para>
        /// This method internally calls the DeleteRole operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRole operation.</param>
        void Delete(DeleteRoleRequest request);

        /// <summary>
        /// Calls the Delete operation on the Role resource.
        /// </summary>
        /// <para>
        /// This method internally calls the DeleteRole operation on the service.
        /// </para>
        void Delete();

        /// <summary>
        /// Calls the UpdateAssumeRolePolicy operation on the Role resource.
        /// </summary>
        /// <para>
        /// This method internally calls the UpdateAssumeRolePolicy operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssumeRolePolicy operation.</param>
        void UpdateAssumeRolePolicy(UpdateAssumeRolePolicyRequest request);


        #endregion

        #region Enumerable collections

        /// <summary>
        /// Gets the InstanceProfiles associated with this Role.        
        /// <para>
        /// NOTE : This method calls a service operation that supports paging. Enumerating through the
        /// result of this method can potentially make multiple service operation calls.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceProfilesForRoleEnumerator operation.</param>
        /// <returns>Returns an enumerable collection of InstanceProfiles.</returns>
        IEnumerable<IInstanceProfile> GetInstanceProfiles(ListInstanceProfilesForRoleRequest request);

        /// <summary>
        /// Gets the InstanceProfiles associated with this Role.        
        /// <para>
        /// NOTE : This method calls a service operation that supports paging. Enumerating through the
        /// result of this method can potentially make multiple service operation calls.
        /// </para>
        /// </summary>
        /// <returns>Returns an enumerable collection of InstanceProfiles.</returns>
        IEnumerable<IInstanceProfile> GetInstanceProfiles();

        /// <summary>
        /// Gets the Policies associated with this Role.        
        /// <para>
        /// NOTE : This method calls a service operation that supports paging. Enumerating through the
        /// result of this method can potentially make multiple service operation calls.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRolePoliciesEnumerator operation.</param>
        /// <returns>Returns an enumerable collection of Policies.</returns>
        IEnumerable<IRolePolicy> GetPolicies(ListRolePoliciesRequest request);

        /// <summary>
        /// Gets the Policies associated with this Role.        
        /// <para>
        /// NOTE : This method calls a service operation that supports paging. Enumerating through the
        /// result of this method can potentially make multiple service operation calls.
        /// </para>
        /// </summary>
        /// <returns>Returns an enumerable collection of Policies.</returns>
        IEnumerable<IRolePolicy> GetPolicies();


        #endregion

        #region Subresources

        /// <summary>
        /// Gets a RolePolicy associated with this Role resource using its identifier.
        /// <para>
        /// This method does not make a service call, it returns a resource instance
        /// only with its identifier properties initialized. Accessing any non-identifier 
        /// properties or operations on the resource that in turn access any non-identifier 
        /// properties will cause the resource to make a service call to load its data.
        /// </para>
        /// <para>
        /// NOTE : This method does not make a service call when the resource is initally
        /// constructed. If you pass invalid identifiers to this method, it will return a resource
        /// that may not exist on the server. In this case an exception will be thrown when 
        /// the resource tries to load itself due to conditions listed in the previous section.
        /// </para>
        /// </summary>
        /// <param name="name">The name of the RolePolicy.</param>
        /// <returns>Returns an instance of RolePolicy.</returns>
        IRolePolicy GetRolePolicyByName(string name);


        #endregion
    }    
    #endregion

    #region IRolePolicy

    /// <summary>
    /// This interface represents the RolePolicy resource.
    /// </summary>
    public interface IRolePolicy
    {
        /// <summary>
        /// Gets the value of the RoleName identifier for this resource. 
        /// </summary>        
        string RoleName { get; }

        /// <summary>
        /// Gets the value of the Name identifier for this resource. 
        /// </summary>        
        string Name { get; }

        /// <summary>
        /// Gets the value of the property PolicyDocument. 
        /// <para>
        /// The policy document.
        /// </para>
        /// </summary>
        string PolicyDocument { get; }


        # region Actions

        /// <summary>
        /// Calls the Delete operation on the RolePolicy resource.
        /// </summary>
        /// <para>
        /// This method internally calls the DeleteRolePolicy operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRolePolicy operation.</param>
        void Delete(DeleteRolePolicyRequest request);

        /// <summary>
        /// Calls the Delete operation on the RolePolicy resource.
        /// </summary>
        /// <para>
        /// This method internally calls the DeleteRolePolicy operation on the service.
        /// </para>
        void Delete();

        /// <summary>
        /// Calls the Put operation on the RolePolicy resource.
        /// </summary>
        /// <para>
        /// This method internally calls the PutRolePolicy operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the PutRolePolicy operation.</param>
        void Put(PutRolePolicyRequest request);

        /// <summary>
        /// Calls the Put operation on the RolePolicy resource.
        /// </summary>
        /// <para>
        /// This method internally calls the PutRolePolicy operation on the service.
        /// </para>
        /// <param name="policyDocument">The policy document.</param>
        void Put(string policyDocument);


        #endregion

    }    
    #endregion

    #region ISamlProvider

    /// <summary>
    /// This interface represents the SamlProvider resource.
    /// </summary>
    public interface ISamlProvider
    {
        /// <summary>
        /// Gets the value of the Arn identifier for this resource. 
        /// </summary>        
        string Arn { get; }

        /// <summary>
        /// Gets the value of the property CreateDate. 
        /// <para>
        /// The date and time when the SAML provider was created.
        /// </para>
        /// </summary>
        DateTime CreateDate { get; }

        /// <summary>
        /// Gets the value of the property SAMLMetadataDocument. 
        /// <para>
        /// The XML metadata document that includes information about an identity provider.
        /// </para>
        /// </summary>
        string SAMLMetadataDocument { get; }

        /// <summary>
        /// Gets the value of the property ValidUntil. 
        /// <para>
        /// The expiration date and time for the SAML provider.
        /// </para>
        /// </summary>
        DateTime ValidUntil { get; }


        # region Actions

        /// <summary>
        /// Calls the Delete operation on the SamlProvider resource.
        /// </summary>
        /// <para>
        /// This method internally calls the DeleteSAMLProvider operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSAMLProvider operation.</param>
        void Delete(DeleteSAMLProviderRequest request);

        /// <summary>
        /// Calls the Delete operation on the SamlProvider resource.
        /// </summary>
        /// <para>
        /// This method internally calls the DeleteSAMLProvider operation on the service.
        /// </para>
        void Delete();

        /// <summary>
        /// Calls the Update operation on the SamlProvider resource.
        /// </summary>
        /// <para>
        /// This method internally calls the UpdateSAMLProvider operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSAMLProvider operation.</param>
        void Update(UpdateSAMLProviderRequest request);


        #endregion

    }    
    #endregion

    #region IServerCertificate

    /// <summary>
    /// This interface represents the ServerCertificate resource.
    /// </summary>
    public interface IServerCertificate
    {
        /// <summary>
        /// Gets the value of the Name identifier for this resource. 
        /// </summary>        
        string Name { get; }

        /// <summary>
        /// Gets the value of the property CertificateBody. 
        /// <para>
        /// The contents of the public key certificate.
        /// </para>
        /// </summary>
        string CertificateBody { get; }

        /// <summary>
        /// Gets the value of the property CertificateChain. 
        /// <para>
        /// The contents of the public key certificate chain.
        /// </para>
        /// </summary>
        string CertificateChain { get; }

        /// <summary>
        /// Gets the value of the property ServerCertificateMetadata. 
        /// <para>
        /// The meta information of the server certificate, such as its name, path, ID, and ARN.
        /// </para>
        /// </summary>
        ServerCertificateMetadata ServerCertificateMetadata { get; }


        # region Actions

        /// <summary>
        /// Calls the Delete operation on the ServerCertificate resource.
        /// </summary>
        /// <para>
        /// This method internally calls the DeleteServerCertificate operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServerCertificate operation.</param>
        void Delete(DeleteServerCertificateRequest request);

        /// <summary>
        /// Calls the Delete operation on the ServerCertificate resource.
        /// </summary>
        /// <para>
        /// This method internally calls the DeleteServerCertificate operation on the service.
        /// </para>
        void Delete();

        /// <summary>
        /// Calls the Update operation on the ServerCertificate resource.
        /// </summary>
        /// <para>
        /// This method internally calls the UpdateServerCertificate operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServerCertificate operation.</param>
        /// <returns>An instance of ServerCertificate resource.</returns>
        IServerCertificate Update(UpdateServerCertificateRequest request);


        #endregion

    }    
    #endregion

    #region ISigningCertificate

    /// <summary>
    /// This interface represents the SigningCertificate resource.
    /// </summary>
    public interface ISigningCertificate
    {
        /// <summary>
        /// Gets the value of the Id identifier for this resource. 
        /// </summary>        
        string Id { get; }

        /// <summary>
        /// Gets the value of the property CertificateBody. 
        /// <para>
        /// The contents of the signing certificate.
        /// </para>
        /// </summary>
        string CertificateBody { get; }

        /// <summary>
        /// Gets the value of the property Status. 
        /// <para>
        /// The status of the signing certificate. <code>Active</code> means the key is valid
        /// for API calls, while <code>Inactive</code> means it is not.
        /// </para>
        /// </summary>
        StatusType Status { get; }

        /// <summary>
        /// Gets the value of the property UploadDate. 
        /// <para>
        /// The date when the signing certificate was uploaded.
        /// </para>
        /// </summary>
        DateTime UploadDate { get; }

        /// <summary>
        /// Gets the value of the property UserName. 
        /// <para>
        /// The name of the user the signing certificate is associated with.
        /// </para>
        /// </summary>
        string UserName { get; }


        # region Actions

        /// <summary>
        /// Calls the Activate operation on the SigningCertificate resource.
        /// </summary>
        /// <para>
        /// This method internally calls the UpdateSigningCertificate operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSigningCertificate operation.</param>
        void Activate(UpdateSigningCertificateRequest request);

        /// <summary>
        /// Calls the Deactivate operation on the SigningCertificate resource.
        /// </summary>
        /// <para>
        /// This method internally calls the UpdateSigningCertificate operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSigningCertificate operation.</param>
        void Deactivate(UpdateSigningCertificateRequest request);

        /// <summary>
        /// Calls the Delete operation on the SigningCertificate resource.
        /// </summary>
        /// <para>
        /// This method internally calls the DeleteSigningCertificate operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSigningCertificate operation.</param>
        void Delete(DeleteSigningCertificateRequest request);

        /// <summary>
        /// Calls the Delete operation on the SigningCertificate resource.
        /// </summary>
        /// <para>
        /// This method internally calls the DeleteSigningCertificate operation on the service.
        /// </para>
        /// <param name="userName">The name of the user the signing certificate belongs to.</param>
        void Delete(string userName);


        #endregion

    }    
    #endregion

    #region IUser

    /// <summary>
    /// This interface represents the User resource.
    /// </summary>
    public interface IUser
    {
        /// <summary>
        /// Gets the value of the Name identifier for this resource. 
        /// </summary>        
        string Name { get; }

        /// <summary>
        /// Gets the value of the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies the user. For more information about
        /// ARNs and how to use ARNs in policies, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">IAM
        /// Identifiers</a> in the <i>Using IAM</i> guide. 
        /// </para>
        /// </summary>
        string Arn { get; }

        /// <summary>
        /// Gets the value of the property CreateDate. 
        /// <para>
        /// The date and time, in <a href="http://www.iso.org/iso/iso8601">ISO 8601 date-time
        /// format</a>, when the user was created.
        /// </para>
        /// </summary>
        DateTime CreateDate { get; }

        /// <summary>
        /// Gets the value of the property PasswordLastUsed. 
        /// <para>
        /// The date and time, in <a href="http://www.iso.org/iso/iso8601">ISO 8601 date-time
        /// format</a>, when the user's password was last used to sign in to an AWS website. For
        /// a list of AWS websites that capture a user's last sign-in time, see the <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/credential-reports.html">Credential
        /// Reports</a> topic in the <i>Using IAM</i> guide. If a password is used more than once
        /// in a five-minute span, only the first use is returned in this field. When the user
        /// does not have a password, this field is null (not present). When a user's password
        /// exists but has never been used, or when there is no sign-in data associated with the
        /// user, this field is null (not present). 
        /// </para>
        ///  
        /// <para>
        /// This value is returned only in the <a>GetUser</a> and <a>ListUsers</a> actions. 
        /// </para>
        /// </summary>
        DateTime PasswordLastUsed { get; }

        /// <summary>
        /// Gets the value of the property Path. 
        /// <para>
        /// The path to the user. For more information about paths, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">IAM
        /// Identifiers</a> in the <i>Using IAM</i> guide.
        /// </para>
        /// </summary>
        string Path { get; }

        /// <summary>
        /// Gets the value of the property UserId. 
        /// <para>
        /// The stable and unique string identifying the user. For more information about IDs,
        /// see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">IAM
        /// Identifiers</a> in the <i>Using IAM</i> guide.
        /// </para>
        /// </summary>
        string UserId { get; }


        # region Actions

        /// <summary>
        /// Calls the AddGroup operation on the User resource.
        /// </summary>
        /// <para>
        /// This method internally calls the AddUserToGroup operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the AddUserToGroup operation.</param>
        void AddGroup(AddUserToGroupRequest request);

        /// <summary>
        /// Calls the AddGroup operation on the User resource.
        /// </summary>
        /// <para>
        /// This method internally calls the AddUserToGroup operation on the service.
        /// </para>
        /// <param name="groupName">The name of the group to update.</param>
        void AddGroup(string groupName);

        /// <summary>
        /// Calls the CreateAccessKey operation on the User resource.
        /// </summary>
        /// <para>
        /// This method internally calls the CreateAccessKey operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessKey operation.</param>
        /// <returns>An instance of AccessKey resource.</returns>
        IAccessKey CreateAccessKey(CreateAccessKeyRequest request);

        /// <summary>
        /// Calls the CreateAccessKey operation on the User resource.
        /// </summary>
        /// <para>
        /// This method internally calls the CreateAccessKey operation on the service.
        /// </para>
        /// <returns>An instance of AccessKey resource.</returns>
        IAccessKey CreateAccessKey();

        /// <summary>
        /// Calls the CreatePolicy operation on the User resource.
        /// </summary>
        /// <para>
        /// This method internally calls the PutUserPolicy operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the PutUserPolicy operation.</param>
        /// <returns>An instance of UserPolicy resource.</returns>
        IUserPolicy CreatePolicy(PutUserPolicyRequest request);

        /// <summary>
        /// Calls the CreatePolicy operation on the User resource.
        /// </summary>
        /// <para>
        /// This method internally calls the PutUserPolicy operation on the service.
        /// </para>
        /// <returns>An instance of UserPolicy resource.</returns>
        /// <param name="policyDocument">The policy document.</param>
        /// <param name="policyName">The name of the policy document.</param>
        IUserPolicy CreatePolicy(string policyDocument, string policyName);

        /// <summary>
        /// Calls the Delete operation on the User resource.
        /// </summary>
        /// <para>
        /// This method internally calls the DeleteUser operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser operation.</param>
        void Delete(DeleteUserRequest request);

        /// <summary>
        /// Calls the Delete operation on the User resource.
        /// </summary>
        /// <para>
        /// This method internally calls the DeleteUser operation on the service.
        /// </para>
        void Delete();

        /// <summary>
        /// Calls the EnableMfa operation on the User resource.
        /// </summary>
        /// <para>
        /// This method internally calls the EnableMFADevice operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the EnableMFADevice operation.</param>
        /// <returns>An instance of MfaDevice resource.</returns>
        IMfaDevice EnableMfa(EnableMFADeviceRequest request);

        /// <summary>
        /// Calls the RemoveGroup operation on the User resource.
        /// </summary>
        /// <para>
        /// This method internally calls the RemoveUserFromGroup operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the RemoveUserFromGroup operation.</param>
        void RemoveGroup(RemoveUserFromGroupRequest request);

        /// <summary>
        /// Calls the RemoveGroup operation on the User resource.
        /// </summary>
        /// <para>
        /// This method internally calls the RemoveUserFromGroup operation on the service.
        /// </para>
        /// <param name="groupName">The name of the group to update.</param>
        void RemoveGroup(string groupName);

        /// <summary>
        /// Calls the Update operation on the User resource.
        /// </summary>
        /// <para>
        /// This method internally calls the UpdateUser operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser operation.</param>
        /// <returns>An instance of User resource.</returns>
        IUser Update(UpdateUserRequest request);


        #endregion

        #region Enumerable collections

        /// <summary>
        /// Gets the AccessKeys associated with this User.        
        /// <para>
        /// NOTE : This method calls a service operation that supports paging. Enumerating through the
        /// result of this method can potentially make multiple service operation calls.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessKeysEnumerator operation.</param>
        /// <returns>Returns an enumerable collection of AccessKeys.</returns>
        IEnumerable<IAccessKey> GetAccessKeys(ListAccessKeysRequest request);

        /// <summary>
        /// Gets the AccessKeys associated with this User.        
        /// <para>
        /// NOTE : This method calls a service operation that supports paging. Enumerating through the
        /// result of this method can potentially make multiple service operation calls.
        /// </para>
        /// </summary>
        /// <returns>Returns an enumerable collection of AccessKeys.</returns>
        IEnumerable<IAccessKey> GetAccessKeys();

        /// <summary>
        /// Gets the Groups associated with this User.        
        /// <para>
        /// NOTE : This method calls a service operation that supports paging. Enumerating through the
        /// result of this method can potentially make multiple service operation calls.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupsForUserEnumerator operation.</param>
        /// <returns>Returns an enumerable collection of Groups.</returns>
        IEnumerable<IGroup> GetGroups(ListGroupsForUserRequest request);

        /// <summary>
        /// Gets the Groups associated with this User.        
        /// <para>
        /// NOTE : This method calls a service operation that supports paging. Enumerating through the
        /// result of this method can potentially make multiple service operation calls.
        /// </para>
        /// </summary>
        /// <returns>Returns an enumerable collection of Groups.</returns>
        IEnumerable<IGroup> GetGroups();

        /// <summary>
        /// Gets the MfaDevices associated with this User.        
        /// <para>
        /// NOTE : This method calls a service operation that supports paging. Enumerating through the
        /// result of this method can potentially make multiple service operation calls.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMFADevicesEnumerator operation.</param>
        /// <returns>Returns an enumerable collection of MfaDevices.</returns>
        IEnumerable<IMfaDevice> GetMfaDevices(ListMFADevicesRequest request);

        /// <summary>
        /// Gets the MfaDevices associated with this User.        
        /// <para>
        /// NOTE : This method calls a service operation that supports paging. Enumerating through the
        /// result of this method can potentially make multiple service operation calls.
        /// </para>
        /// </summary>
        /// <returns>Returns an enumerable collection of MfaDevices.</returns>
        IEnumerable<IMfaDevice> GetMfaDevices();

        /// <summary>
        /// Gets the Policies associated with this User.        
        /// <para>
        /// NOTE : This method calls a service operation that supports paging. Enumerating through the
        /// result of this method can potentially make multiple service operation calls.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUserPoliciesEnumerator operation.</param>
        /// <returns>Returns an enumerable collection of Policies.</returns>
        IEnumerable<IUserPolicy> GetPolicies(ListUserPoliciesRequest request);

        /// <summary>
        /// Gets the Policies associated with this User.        
        /// <para>
        /// NOTE : This method calls a service operation that supports paging. Enumerating through the
        /// result of this method can potentially make multiple service operation calls.
        /// </para>
        /// </summary>
        /// <returns>Returns an enumerable collection of Policies.</returns>
        IEnumerable<IUserPolicy> GetPolicies();


        #endregion

        #region Subresources

        /// <summary>
        /// Gets a AccessKey associated with this User resource using its identifier.
        /// <para>
        /// This method does not make a service call, it returns a resource instance
        /// only with its identifier properties initialized. Accessing any non-identifier 
        /// properties or operations on the resource that in turn access any non-identifier 
        /// properties will cause the resource to make a service call to load its data.
        /// </para>
        /// <para>
        /// NOTE : This method does not make a service call when the resource is initally
        /// constructed. If you pass invalid identifiers to this method, it will return a resource
        /// that may not exist on the server. In this case an exception will be thrown when 
        /// the resource tries to load itself due to conditions listed in the previous section.
        /// </para>
        /// </summary>
        /// <param name="id">The id of the AccessKey.</param>
        /// <returns>Returns an instance of AccessKey.</returns>
        IAccessKey GetAccessKeyById(string id);

        /// <summary>
        /// Gets the LoginProfile associated with this User resource.
        /// <para>
        /// This method does not make a service call, it returns a resource instance
        /// only with its identifier properties initialized. Accessing any non-identifier 
        /// properties or operations on the resource that in turn access any non-identifier 
        /// properties will cause the resource to make a service call to load its data.
        /// </para>
        /// <para>
        /// NOTE : This method does not make a service call when the resource is initally
        /// constructed. If you pass invalid identifiers to this method, it will return a resource
        /// that may not exist on the server. In this case an exception will be thrown when 
        /// the resource tries to load itself due to conditions listed in the previous section.
        /// </para>
        /// </summary>
        /// <returns>Returns an instance of LoginProfile.</returns>
        ILoginProfile GetLoginProfile();

        /// <summary>
        /// Gets a MfaDevice associated with this User resource using its identifier.
        /// <para>
        /// This method does not make a service call, it returns a resource instance
        /// only with its identifier properties initialized. Accessing any non-identifier 
        /// properties or operations on the resource that in turn access any non-identifier 
        /// properties will cause the resource to make a service call to load its data.
        /// </para>
        /// <para>
        /// NOTE : This method does not make a service call when the resource is initally
        /// constructed. If you pass invalid identifiers to this method, it will return a resource
        /// that may not exist on the server. In this case an exception will be thrown when 
        /// the resource tries to load itself due to conditions listed in the previous section.
        /// </para>
        /// </summary>
        /// <param name="serialNumber">The serialNumber of the MfaDevice.</param>
        /// <returns>Returns an instance of MfaDevice.</returns>
        IMfaDevice GetMfaDeviceBySerialNumber(string serialNumber);

        /// <summary>
        /// Gets a UserPolicy associated with this User resource using its identifier.
        /// <para>
        /// This method does not make a service call, it returns a resource instance
        /// only with its identifier properties initialized. Accessing any non-identifier 
        /// properties or operations on the resource that in turn access any non-identifier 
        /// properties will cause the resource to make a service call to load its data.
        /// </para>
        /// <para>
        /// NOTE : This method does not make a service call when the resource is initally
        /// constructed. If you pass invalid identifiers to this method, it will return a resource
        /// that may not exist on the server. In this case an exception will be thrown when 
        /// the resource tries to load itself due to conditions listed in the previous section.
        /// </para>
        /// </summary>
        /// <param name="name">The name of the UserPolicy.</param>
        /// <returns>Returns an instance of UserPolicy.</returns>
        IUserPolicy GetUserPolicyByName(string name);


        #endregion
    }    
    #endregion

    #region IUserPolicy

    /// <summary>
    /// This interface represents the UserPolicy resource.
    /// </summary>
    public interface IUserPolicy
    {
        /// <summary>
        /// Gets the value of the UserName identifier for this resource. 
        /// </summary>        
        string UserName { get; }

        /// <summary>
        /// Gets the value of the Name identifier for this resource. 
        /// </summary>        
        string Name { get; }

        /// <summary>
        /// Gets the value of the property PolicyDocument. 
        /// <para>
        /// The policy document.
        /// </para>
        /// </summary>
        string PolicyDocument { get; }


        # region Actions

        /// <summary>
        /// Calls the Delete operation on the UserPolicy resource.
        /// </summary>
        /// <para>
        /// This method internally calls the DeleteUserPolicy operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserPolicy operation.</param>
        void Delete(DeleteUserPolicyRequest request);

        /// <summary>
        /// Calls the Delete operation on the UserPolicy resource.
        /// </summary>
        /// <para>
        /// This method internally calls the DeleteUserPolicy operation on the service.
        /// </para>
        void Delete();

        /// <summary>
        /// Calls the Put operation on the UserPolicy resource.
        /// </summary>
        /// <para>
        /// This method internally calls the PutUserPolicy operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the PutUserPolicy operation.</param>
        void Put(PutUserPolicyRequest request);

        /// <summary>
        /// Calls the Put operation on the UserPolicy resource.
        /// </summary>
        /// <para>
        /// This method internally calls the PutUserPolicy operation on the service.
        /// </para>
        /// <param name="policyDocument">The policy document.</param>
        void Put(string policyDocument);


        #endregion

    }    
    #endregion

    #region IVirtualMfaDevice

    /// <summary>
    /// This interface represents the VirtualMfaDevice resource.
    /// </summary>
    public interface IVirtualMfaDevice
    {
        /// <summary>
        /// Gets the value of the SerialNumber identifier for this resource. 
        /// </summary>        
        string SerialNumber { get; }

        /// <summary>
        /// Gets the value of the property Base32StringSeed. 
        /// <para>
        ///  The Base32 seed defined as specified in <a href="http://www.ietf.org/rfc/rfc3548.txt">RFC3548</a>.
        /// The <code>Base32StringSeed</code> is Base64-encoded. 
        /// </para>
        /// </summary>
        MemoryStream Base32StringSeed { get; }

        /// <summary>
        /// Gets the value of the property EnableDate. 
        /// <para>
        /// The date and time on which the virtual MFA device was enabled.
        /// </para>
        /// </summary>
        DateTime EnableDate { get; }

        /// <summary>
        /// Gets the value of the property QRCodePNG. 
        /// <para>
        ///  A QR code PNG image that encodes <code>otpauth://totp/$virtualMFADeviceName@$AccountName?secret=$Base32String</code>
        /// where <code>$virtualMFADeviceName</code> is one of the create call arguments, <code>AccountName</code>
        /// is the user name if set (otherwise, the account ID otherwise), and <code>Base32String</code>
        /// is the seed in Base32 format. The <code>Base32String</code> value is Base64-encoded.
        /// 
        /// </para>
        /// </summary>
        MemoryStream QRCodePNG { get; }

        /// <summary>
        /// Gets the value of the property User.
        /// </summary>
        IUser User { get; }


        # region Actions

        /// <summary>
        /// Calls the Delete operation on the VirtualMfaDevice resource.
        /// </summary>
        /// <para>
        /// This method internally calls the DeleteVirtualMFADevice operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVirtualMFADevice operation.</param>
        void Delete(DeleteVirtualMFADeviceRequest request);


        #endregion

    }    
    #endregion
}