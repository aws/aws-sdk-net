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
using Amazon.Runtime.Resources;
using Amazon.IdentityManagement.Model;

namespace Amazon.IdentityManagement.Resources.Internal
{

    #region AccessKey

    internal class AccessKey : Resource<IAmazonIdentityManagementService>, IAccessKey
    {
        public string UserName { get; private set; }

        public string Id { get; private set; }

        private DateTime _createDate;
        public DateTime CreateDate
        {
            get
            {
                this.CheckIfLoaded();
                return _createDate;
            }
        }

        private string _secretAccessKey;
        public string SecretAccessKey
        {
            get
            {
                this.CheckIfLoaded();
                return _secretAccessKey;
            }
        }

        private StatusType _status;
        public StatusType Status
        {
            get
            {
                this.CheckIfLoaded();
                return _status;
            }
        }

        public AccessKey(Model.AccessKey model, IAmazonIdentityManagementService client)
            : base (client)
        {
            this.IsLoaded = true;
            this.UserName = model.UserName;
            this.Id = model.AccessKeyId;
            CopyFrom(model);
        }

        private void CopyFrom(Model.AccessKey model)
        {
            _createDate = model.CreateDate;
            _secretAccessKey = model.SecretAccessKey;
            _status = model.Status;
        }

        public AccessKey(string userName, string id, IAmazonIdentityManagementService client)
            : base (client)
        {
            this.IsLoaded = false;
            this.UserName = userName;
            this.Id = id;

        }

        # region Actions

        public void Activate(UpdateAccessKeyRequest request)
        {
            request.UserName = this.UserName;
            request.AccessKeyId = this.Id;
            request.Status = "Active";
            ResourcesUtilities.Invoke(request, this.Client.UpdateAccessKey, "Activate");
        }

        public void Deactivate(UpdateAccessKeyRequest request)
        {
            request.UserName = this.UserName;
            request.AccessKeyId = this.Id;
            request.Status = "Inactive";
            ResourcesUtilities.Invoke(request, this.Client.UpdateAccessKey, "Deactivate");
        }

        public void Delete(DeleteAccessKeyRequest request)
        {
            request.UserName = this.UserName;
            request.AccessKeyId = this.Id;
            ResourcesUtilities.Invoke(request, this.Client.DeleteAccessKey, "Delete");
        }

        public void Delete()
        {
            var request = new DeleteAccessKeyRequest();
            Delete(request);
         }

        #endregion

    }

    #endregion

    #region AccountAlias

    internal class AccountAlias : Resource<IAmazonIdentityManagementService>, IAccountAlias
    {
        public string Name { get; private set; }

        public AccountAlias(string name, IAmazonIdentityManagementService client)
            : base (client)
        {
            this.IsLoaded = false;
            this.Name = name;

        }

        # region Actions

        public void Delete(DeleteAccountAliasRequest request)
        {
            request.AccountAlias = this.Name;
            ResourcesUtilities.Invoke(request, this.Client.DeleteAccountAlias, "Delete");
        }

        public void Delete()
        {
            var request = new DeleteAccountAliasRequest();
            Delete(request);
         }

        #endregion

    }

    #endregion

    #region AccountPasswordPolicy

    internal class AccountPasswordPolicy : Resource<IAmazonIdentityManagementService>, IAccountPasswordPolicy
    {
        private bool _allowUsersToChangePassword;
        public bool AllowUsersToChangePassword
        {
            get
            {
                this.CheckIfLoaded();
                return _allowUsersToChangePassword;
            }
        }

        private bool _expirePasswords;
        public bool ExpirePasswords
        {
            get
            {
                this.CheckIfLoaded();
                return _expirePasswords;
            }
        }

        private bool _hardExpiry;
        public bool HardExpiry
        {
            get
            {
                this.CheckIfLoaded();
                return _hardExpiry;
            }
        }

        private int _maxPasswordAge;
        public int MaxPasswordAge
        {
            get
            {
                this.CheckIfLoaded();
                return _maxPasswordAge;
            }
        }

        private int _minimumPasswordLength;
        public int MinimumPasswordLength
        {
            get
            {
                this.CheckIfLoaded();
                return _minimumPasswordLength;
            }
        }

        private int _passwordReusePrevention;
        public int PasswordReusePrevention
        {
            get
            {
                this.CheckIfLoaded();
                return _passwordReusePrevention;
            }
        }

        private bool _requireLowercaseCharacters;
        public bool RequireLowercaseCharacters
        {
            get
            {
                this.CheckIfLoaded();
                return _requireLowercaseCharacters;
            }
        }

        private bool _requireNumbers;
        public bool RequireNumbers
        {
            get
            {
                this.CheckIfLoaded();
                return _requireNumbers;
            }
        }

        private bool _requireSymbols;
        public bool RequireSymbols
        {
            get
            {
                this.CheckIfLoaded();
                return _requireSymbols;
            }
        }

        private bool _requireUppercaseCharacters;
        public bool RequireUppercaseCharacters
        {
            get
            {
                this.CheckIfLoaded();
                return _requireUppercaseCharacters;
            }
        }

        public AccountPasswordPolicy(Model.PasswordPolicy model, IAmazonIdentityManagementService client)
            : base (client)
        {
            this.IsLoaded = true;
            CopyFrom(model);
        }

        private void CopyFrom(Model.PasswordPolicy model)
        {
            _allowUsersToChangePassword = model.AllowUsersToChangePassword;
            _expirePasswords = model.ExpirePasswords;
            _hardExpiry = model.HardExpiry;
            _maxPasswordAge = model.MaxPasswordAge;
            _minimumPasswordLength = model.MinimumPasswordLength;
            _passwordReusePrevention = model.PasswordReusePrevention;
            _requireLowercaseCharacters = model.RequireLowercaseCharacters;
            _requireNumbers = model.RequireNumbers;
            _requireSymbols = model.RequireSymbols;
            _requireUppercaseCharacters = model.RequireUppercaseCharacters;
        }

      
        protected override void LoadResource()
        {
            var request = new GetAccountPasswordPolicyRequest();

            var response = this.Client.GetAccountPasswordPolicy(request);
            this.CopyFrom(response.PasswordPolicy);
        }

        public AccountPasswordPolicy(IAmazonIdentityManagementService client)
            : base (client)
        {
            this.IsLoaded = false;

        }

        # region Actions

        public void Delete(DeleteAccountPasswordPolicyRequest request)
        {
            ResourcesUtilities.Invoke(request, this.Client.DeleteAccountPasswordPolicy, "Delete");
        }

        public void Delete()
        {
            var request = new DeleteAccountPasswordPolicyRequest();
            Delete(request);
         }

        public void Update(UpdateAccountPasswordPolicyRequest request)
        {
            ResourcesUtilities.Invoke(request, this.Client.UpdateAccountPasswordPolicy, "Update");
        }

        #endregion

    }

    #endregion

    #region AccountSummary

    internal class AccountSummary : Resource<IAmazonIdentityManagementService>, IAccountSummary
    {
        private Dictionary<string, int> _summaryMap;
        public Dictionary<string, int> SummaryMap
        {
            get
            {
                this.CheckIfLoaded();
                return _summaryMap;
            }
        }

        public AccountSummary(Model.GetAccountSummaryResponse model, IAmazonIdentityManagementService client)
            : base (client)
        {
            this.IsLoaded = true;
            CopyFrom(model);
        }

        private void CopyFrom(Model.GetAccountSummaryResponse model)
        {
            _summaryMap = model.SummaryMap;
        }

      
        protected override void LoadResource()
        {
            var request = new GetAccountSummaryRequest();

            var response = this.Client.GetAccountSummary(request);
            this.CopyFrom(response);
        }

        public AccountSummary(IAmazonIdentityManagementService client)
            : base (client)
        {
            this.IsLoaded = false;

        }

        # region Actions

        #endregion

    }

    #endregion

    #region Group

    internal class Group : Resource<IAmazonIdentityManagementService>, IGroup
    {
        public string Name { get; private set; }

        private string _arn;
        public string Arn
        {
            get
            {
                this.CheckIfLoaded();
                return _arn;
            }
        }

        private DateTime _createDate;
        public DateTime CreateDate
        {
            get
            {
                this.CheckIfLoaded();
                return _createDate;
            }
        }

        private string _groupId;
        public string GroupId
        {
            get
            {
                this.CheckIfLoaded();
                return _groupId;
            }
        }

        private string _path;
        public string Path
        {
            get
            {
                this.CheckIfLoaded();
                return _path;
            }
        }

        public Group(Model.Group model, IAmazonIdentityManagementService client)
            : base (client)
        {
            this.IsLoaded = true;
            this.Name = model.GroupName;
            CopyFrom(model);
        }

        private void CopyFrom(Model.Group model)
        {
            _arn = model.Arn;
            _createDate = model.CreateDate;
            _groupId = model.GroupId;
            _path = model.Path;
        }

      
        protected override void LoadResource()
        {
            var request = new GetGroupRequest();
            request.GroupName = this.Name;

            var response = this.Client.GetGroup(request);
            this.CopyFrom(response.Group);
        }

        public Group(string name, IAmazonIdentityManagementService client)
            : base (client)
        {
            this.IsLoaded = false;
            this.Name = name;

        }

        # region Actions

        public void AddUser(AddUserToGroupRequest request)
        {
            request.GroupName = this.Name;
            ResourcesUtilities.Invoke(request, this.Client.AddUserToGroup, "AddUser");
        }

        public void AddUser(string userName)
        {
            var request = new AddUserToGroupRequest();
            request.UserName = userName;
            AddUser(request);
         }

        public void Create(CreateGroupRequest request)
        {
            request.GroupName = this.Name;
            ResourcesUtilities.Invoke(request, this.Client.CreateGroup, "Create");
        }

        public void Create()
        {
            var request = new CreateGroupRequest();
            Create(request);
         }

        public IGroupPolicy CreatePolicy(PutGroupPolicyRequest request)
        {
            request.GroupName = this.Name;
            var response = ResourcesUtilities.Invoke(request, this.Client.PutGroupPolicy, "CreatePolicy");
            return new Internal.GroupPolicy(groupName : this.Name, name : request.PolicyName, client : this.Client);
            
        }

        public IGroupPolicy CreatePolicy(string policyDocument, string policyName)
        {
            var request = new PutGroupPolicyRequest();
            request.PolicyDocument = policyDocument;
            request.PolicyName = policyName;
            return CreatePolicy(request);
         }

        public void Delete(DeleteGroupRequest request)
        {
            request.GroupName = this.Name;
            ResourcesUtilities.Invoke(request, this.Client.DeleteGroup, "Delete");
        }

        public void Delete()
        {
            var request = new DeleteGroupRequest();
            Delete(request);
         }

        public void RemoveUser(RemoveUserFromGroupRequest request)
        {
            request.GroupName = this.Name;
            ResourcesUtilities.Invoke(request, this.Client.RemoveUserFromGroup, "RemoveUser");
        }

        public void RemoveUser(string userName)
        {
            var request = new RemoveUserFromGroupRequest();
            request.UserName = userName;
            RemoveUser(request);
         }

        public IGroup Update(UpdateGroupRequest request)
        {
            request.GroupName = this.Name;
            var response = ResourcesUtilities.Invoke(request, this.Client.UpdateGroup, "Update");
            return new Internal.Group(name : request.NewGroupName, client : this.Client);
            
        }

        #endregion

        #region HasMany
        public IEnumerable<IGroupPolicy> GetPolicies(ListGroupPoliciesRequest request)
        {
            request.GroupName = this.Name;
        
            foreach (var item in ResourcesUtilities.InvokePaginator(request, this.Client.ListGroupPoliciesEnumerator, "Policies"))
            {            
                yield return new Internal.GroupPolicy(groupName : this.Name, name : item, client : this.Client);    
            }

        }

        public IEnumerable<IGroupPolicy> GetPolicies()
        {
            var request = new ListGroupPoliciesRequest();
            return GetPolicies(request);
         }

        public IEnumerable<IUser> GetUsers(GetGroupRequest request)
        {
            request.GroupName = this.Name;
        
            foreach (var item in ResourcesUtilities.InvokePaginator(request, this.Client.GetGroupEnumerator, "Users"))
            {            
                yield return new Internal.User(model : item, client : this.Client);    
            }

        }

        public IEnumerable<IUser> GetUsers()
        {
            var request = new GetGroupRequest();
            return GetUsers(request);
         }


        #endregion

        #region Subresource

        public IGroupPolicy GetGroupPolicyByName(string name)
        {
            return new Internal.GroupPolicy(groupName : this.Name, name : name, client : this.Client);
        }

        #endregion
    }

    #endregion

    #region GroupPolicy

    internal class GroupPolicy : Resource<IAmazonIdentityManagementService>, IGroupPolicy
    {
        public string GroupName { get; private set; }

        public string Name { get; private set; }

        private string _policyDocument;
        public string PolicyDocument
        {
            get
            {
                this.CheckIfLoaded();
                return _policyDocument;
            }
        }

        public GroupPolicy(Model.GetGroupPolicyResponse model, IAmazonIdentityManagementService client)
            : base (client)
        {
            this.IsLoaded = true;
            this.GroupName = model.GroupName;
            this.Name = model.PolicyName;
            CopyFrom(model);
        }

        private void CopyFrom(Model.GetGroupPolicyResponse model)
        {
            _policyDocument = model.PolicyDocument;
        }

      
        protected override void LoadResource()
        {
            var request = new GetGroupPolicyRequest();
            request.GroupName = this.GroupName;
            request.PolicyName = this.Name;

            var response = this.Client.GetGroupPolicy(request);
            this.CopyFrom(response);
        }

        public GroupPolicy(string groupName, string name, IAmazonIdentityManagementService client)
            : base (client)
        {
            this.IsLoaded = false;
            this.GroupName = groupName;
            this.Name = name;

        }

        # region Actions

        public void Delete(DeleteGroupPolicyRequest request)
        {
            request.GroupName = this.GroupName;
            request.PolicyName = this.Name;
            ResourcesUtilities.Invoke(request, this.Client.DeleteGroupPolicy, "Delete");
        }

        public void Delete()
        {
            var request = new DeleteGroupPolicyRequest();
            Delete(request);
         }

        public void Put(PutGroupPolicyRequest request)
        {
            request.GroupName = this.GroupName;
            request.PolicyName = this.Name;
            ResourcesUtilities.Invoke(request, this.Client.PutGroupPolicy, "Put");
        }

        public void Put(string policyDocument)
        {
            var request = new PutGroupPolicyRequest();
            request.PolicyDocument = policyDocument;
            Put(request);
         }

        #endregion

    }

    #endregion

    #region InstanceProfile

    internal class InstanceProfile : Resource<IAmazonIdentityManagementService>, IInstanceProfile
    {
        public string Name { get; private set; }

        private string _arn;
        public string Arn
        {
            get
            {
                this.CheckIfLoaded();
                return _arn;
            }
        }

        private DateTime _createDate;
        public DateTime CreateDate
        {
            get
            {
                this.CheckIfLoaded();
                return _createDate;
            }
        }

        private string _instanceProfileId;
        public string InstanceProfileId
        {
            get
            {
                this.CheckIfLoaded();
                return _instanceProfileId;
            }
        }

        private string _path;
        public string Path
        {
            get
            {
                this.CheckIfLoaded();
                return _path;
            }
        }

        private List<IRole> _roles;
        public List<IRole> Roles
        {
            get
            {
                this.CheckIfLoaded();
                return _roles;
            }
        }

        public InstanceProfile(Model.InstanceProfile model, IAmazonIdentityManagementService client)
            : base (client)
        {
            this.IsLoaded = true;
            this.Name = model.InstanceProfileName;
            CopyFrom(model);
        }

        private void CopyFrom(Model.InstanceProfile model)
        {
            _arn = model.Arn;
            _createDate = model.CreateDate;
            _instanceProfileId = model.InstanceProfileId;
            _path = model.Path;
    
            _roles = new List<IRole>();
            foreach(var item in model.Roles)
                _roles.Add(new Role(item, this.Client));
        }

      
        protected override void LoadResource()
        {
            var request = new GetInstanceProfileRequest();
            request.InstanceProfileName = this.Name;

            var response = this.Client.GetInstanceProfile(request);
            this.CopyFrom(response.InstanceProfile);
        }

        public InstanceProfile(string name, IAmazonIdentityManagementService client)
            : base (client)
        {
            this.IsLoaded = false;
            this.Name = name;

        }

        # region Actions

        public void AddRole(AddRoleToInstanceProfileRequest request)
        {
            request.InstanceProfileName = this.Name;
            ResourcesUtilities.Invoke(request, this.Client.AddRoleToInstanceProfile, "AddRole");
        }

        public void AddRole(string roleName)
        {
            var request = new AddRoleToInstanceProfileRequest();
            request.RoleName = roleName;
            AddRole(request);
         }

        public void Delete(DeleteInstanceProfileRequest request)
        {
            request.InstanceProfileName = this.Name;
            ResourcesUtilities.Invoke(request, this.Client.DeleteInstanceProfile, "Delete");
        }

        public void Delete()
        {
            var request = new DeleteInstanceProfileRequest();
            Delete(request);
         }

        public void RemoveRole(RemoveRoleFromInstanceProfileRequest request)
        {
            request.InstanceProfileName = this.Name;
            ResourcesUtilities.Invoke(request, this.Client.RemoveRoleFromInstanceProfile, "RemoveRole");
        }

        public void RemoveRole(string roleName)
        {
            var request = new RemoveRoleFromInstanceProfileRequest();
            request.RoleName = roleName;
            RemoveRole(request);
         }

        #endregion

    }

    #endregion

    #region LoginProfile

    internal class LoginProfile : Resource<IAmazonIdentityManagementService>, ILoginProfile
    {
        public string UserName { get; private set; }

        private DateTime _createDate;
        public DateTime CreateDate
        {
            get
            {
                this.CheckIfLoaded();
                return _createDate;
            }
        }

        private bool _passwordResetRequired;
        public bool PasswordResetRequired
        {
            get
            {
                this.CheckIfLoaded();
                return _passwordResetRequired;
            }
        }

        public LoginProfile(Model.LoginProfile model, IAmazonIdentityManagementService client)
            : base (client)
        {
            this.IsLoaded = true;
            this.UserName = model.UserName;
            CopyFrom(model);
        }

        private void CopyFrom(Model.LoginProfile model)
        {
            _createDate = model.CreateDate;
            _passwordResetRequired = model.PasswordResetRequired;
        }

      
        protected override void LoadResource()
        {
            var request = new GetLoginProfileRequest();
            request.UserName = this.UserName;

            var response = this.Client.GetLoginProfile(request);
            this.CopyFrom(response.LoginProfile);
        }

        public LoginProfile(string userName, IAmazonIdentityManagementService client)
            : base (client)
        {
            this.IsLoaded = false;
            this.UserName = userName;

        }

        # region Actions

        public void Create(CreateLoginProfileRequest request)
        {
            request.UserName = this.UserName;
            ResourcesUtilities.Invoke(request, this.Client.CreateLoginProfile, "Create");
        }

        public void Delete(DeleteLoginProfileRequest request)
        {
            request.UserName = this.UserName;
            ResourcesUtilities.Invoke(request, this.Client.DeleteLoginProfile, "Delete");
        }

        public void Delete()
        {
            var request = new DeleteLoginProfileRequest();
            Delete(request);
         }

        public void Update(UpdateLoginProfileRequest request)
        {
            request.UserName = this.UserName;
            ResourcesUtilities.Invoke(request, this.Client.UpdateLoginProfile, "Update");
        }

        #endregion

    }

    #endregion

    #region MfaDevice

    internal class MfaDevice : Resource<IAmazonIdentityManagementService>, IMfaDevice
    {
        public string UserName { get; private set; }

        public string SerialNumber { get; private set; }

        private DateTime _enableDate;
        public DateTime EnableDate
        {
            get
            {
                this.CheckIfLoaded();
                return _enableDate;
            }
        }

        public MfaDevice(Model.MFADevice model, IAmazonIdentityManagementService client)
            : base (client)
        {
            this.IsLoaded = true;
            this.UserName = model.UserName;
            this.SerialNumber = model.SerialNumber;
            CopyFrom(model);
        }

        private void CopyFrom(Model.MFADevice model)
        {
            _enableDate = model.EnableDate;
        }

        public MfaDevice(string userName, string serialNumber, IAmazonIdentityManagementService client)
            : base (client)
        {
            this.IsLoaded = false;
            this.UserName = userName;
            this.SerialNumber = serialNumber;

        }

        # region Actions

        public void Deactivate(DeactivateMFADeviceRequest request)
        {
            request.UserName = this.UserName;
            request.SerialNumber = this.SerialNumber;
            ResourcesUtilities.Invoke(request, this.Client.DeactivateMFADevice, "Deactivate");
        }

        public void Deactivate()
        {
            var request = new DeactivateMFADeviceRequest();
            Deactivate(request);
         }

        public void Enable(EnableMFADeviceRequest request)
        {
            request.UserName = this.UserName;
            request.SerialNumber = this.SerialNumber;
            ResourcesUtilities.Invoke(request, this.Client.EnableMFADevice, "Enable");
        }

        public void Resync(ResyncMFADeviceRequest request)
        {
            request.UserName = this.UserName;
            request.SerialNumber = this.SerialNumber;
            ResourcesUtilities.Invoke(request, this.Client.ResyncMFADevice, "Resync");
        }

        #endregion

    }

    #endregion

    #region Role

    internal class Role : Resource<IAmazonIdentityManagementService>, IRole
    {
        public string Name { get; private set; }

        private string _arn;
        public string Arn
        {
            get
            {
                this.CheckIfLoaded();
                return _arn;
            }
        }

        private string _assumeRolePolicyDocument;
        public string AssumeRolePolicyDocument
        {
            get
            {
                this.CheckIfLoaded();
                return _assumeRolePolicyDocument;
            }
        }

        private DateTime _createDate;
        public DateTime CreateDate
        {
            get
            {
                this.CheckIfLoaded();
                return _createDate;
            }
        }

        private string _path;
        public string Path
        {
            get
            {
                this.CheckIfLoaded();
                return _path;
            }
        }

        private string _roleId;
        public string RoleId
        {
            get
            {
                this.CheckIfLoaded();
                return _roleId;
            }
        }

        public Role(Model.Role model, IAmazonIdentityManagementService client)
            : base (client)
        {
            this.IsLoaded = true;
            this.Name = model.RoleName;
            CopyFrom(model);
        }

        private void CopyFrom(Model.Role model)
        {
            _arn = model.Arn;
            _assumeRolePolicyDocument = model.AssumeRolePolicyDocument;
            _createDate = model.CreateDate;
            _path = model.Path;
            _roleId = model.RoleId;
        }

      
        protected override void LoadResource()
        {
            var request = new GetRoleRequest();
            request.RoleName = this.Name;

            var response = this.Client.GetRole(request);
            this.CopyFrom(response.Role);
        }

        public Role(string name, IAmazonIdentityManagementService client)
            : base (client)
        {
            this.IsLoaded = false;
            this.Name = name;

        }

        # region Actions

        public void Delete(DeleteRoleRequest request)
        {
            request.RoleName = this.Name;
            ResourcesUtilities.Invoke(request, this.Client.DeleteRole, "Delete");
        }

        public void Delete()
        {
            var request = new DeleteRoleRequest();
            Delete(request);
         }

        public void UpdateAssumeRolePolicy(UpdateAssumeRolePolicyRequest request)
        {
            request.RoleName = this.Name;
            ResourcesUtilities.Invoke(request, this.Client.UpdateAssumeRolePolicy, "UpdateAssumeRolePolicy");
        }

        #endregion

        #region HasMany
        public IEnumerable<IInstanceProfile> GetInstanceProfiles(ListInstanceProfilesForRoleRequest request)
        {
            request.RoleName = this.Name;
        
            foreach (var item in ResourcesUtilities.InvokePaginator(request, this.Client.ListInstanceProfilesForRoleEnumerator, "InstanceProfiles"))
            {            
                yield return new Internal.InstanceProfile(model : item, client : this.Client);    
            }

        }

        public IEnumerable<IInstanceProfile> GetInstanceProfiles()
        {
            var request = new ListInstanceProfilesForRoleRequest();
            return GetInstanceProfiles(request);
         }

        public IEnumerable<IRolePolicy> GetPolicies(ListRolePoliciesRequest request)
        {
            request.RoleName = this.Name;
        
            foreach (var item in ResourcesUtilities.InvokePaginator(request, this.Client.ListRolePoliciesEnumerator, "Policies"))
            {            
                yield return new Internal.RolePolicy(roleName : this.Name, name : item, client : this.Client);    
            }

        }

        public IEnumerable<IRolePolicy> GetPolicies()
        {
            var request = new ListRolePoliciesRequest();
            return GetPolicies(request);
         }


        #endregion

        #region Subresource

        public IRolePolicy GetRolePolicyByName(string name)
        {
            return new Internal.RolePolicy(roleName : this.Name, name : name, client : this.Client);
        }

        #endregion
    }

    #endregion

    #region RolePolicy

    internal class RolePolicy : Resource<IAmazonIdentityManagementService>, IRolePolicy
    {
        public string RoleName { get; private set; }

        public string Name { get; private set; }

        private string _policyDocument;
        public string PolicyDocument
        {
            get
            {
                this.CheckIfLoaded();
                return _policyDocument;
            }
        }

        public RolePolicy(Model.GetRolePolicyResponse model, IAmazonIdentityManagementService client)
            : base (client)
        {
            this.IsLoaded = true;
            this.RoleName = model.RoleName;
            this.Name = model.PolicyName;
            CopyFrom(model);
        }

        private void CopyFrom(Model.GetRolePolicyResponse model)
        {
            _policyDocument = model.PolicyDocument;
        }

      
        protected override void LoadResource()
        {
            var request = new GetRolePolicyRequest();
            request.RoleName = this.RoleName;
            request.PolicyName = this.Name;

            var response = this.Client.GetRolePolicy(request);
            this.CopyFrom(response);
        }

        public RolePolicy(string roleName, string name, IAmazonIdentityManagementService client)
            : base (client)
        {
            this.IsLoaded = false;
            this.RoleName = roleName;
            this.Name = name;

        }

        # region Actions

        public void Delete(DeleteRolePolicyRequest request)
        {
            request.RoleName = this.RoleName;
            request.PolicyName = this.Name;
            ResourcesUtilities.Invoke(request, this.Client.DeleteRolePolicy, "Delete");
        }

        public void Delete()
        {
            var request = new DeleteRolePolicyRequest();
            Delete(request);
         }

        public void Put(PutRolePolicyRequest request)
        {
            request.RoleName = this.RoleName;
            request.PolicyName = this.Name;
            ResourcesUtilities.Invoke(request, this.Client.PutRolePolicy, "Put");
        }

        public void Put(string policyDocument)
        {
            var request = new PutRolePolicyRequest();
            request.PolicyDocument = policyDocument;
            Put(request);
         }

        #endregion

    }

    #endregion

    #region SamlProvider

    internal class SamlProvider : Resource<IAmazonIdentityManagementService>, ISamlProvider
    {
        public string Arn { get; private set; }

        private DateTime _createDate;
        public DateTime CreateDate
        {
            get
            {
                this.CheckIfLoaded();
                return _createDate;
            }
        }

        private string _sAMLMetadataDocument;
        public string SAMLMetadataDocument
        {
            get
            {
                this.CheckIfLoaded();
                return _sAMLMetadataDocument;
            }
        }

        private DateTime _validUntil;
        public DateTime ValidUntil
        {
            get
            {
                this.CheckIfLoaded();
                return _validUntil;
            }
        }

        private void CopyFrom(Model.GetSAMLProviderResponse model)
        {
            _createDate = model.CreateDate;
            _sAMLMetadataDocument = model.SAMLMetadataDocument;
            _validUntil = model.ValidUntil;
        }

      
        protected override void LoadResource()
        {
            var request = new GetSAMLProviderRequest();
            request.SAMLProviderArn = this.Arn;

            var response = this.Client.GetSAMLProvider(request);
            this.CopyFrom(response);
        }

        public SamlProvider(string arn, IAmazonIdentityManagementService client)
            : base (client)
        {
            this.IsLoaded = false;
            this.Arn = arn;

        }

        # region Actions

        public void Delete(DeleteSAMLProviderRequest request)
        {
            request.SAMLProviderArn = this.Arn;
            ResourcesUtilities.Invoke(request, this.Client.DeleteSAMLProvider, "Delete");
        }

        public void Delete()
        {
            var request = new DeleteSAMLProviderRequest();
            Delete(request);
         }

        public void Update(UpdateSAMLProviderRequest request)
        {
            request.SAMLProviderArn = this.Arn;
            ResourcesUtilities.Invoke(request, this.Client.UpdateSAMLProvider, "Update");
        }

        #endregion

    }

    #endregion

    #region ServerCertificate

    internal class ServerCertificate : Resource<IAmazonIdentityManagementService>, IServerCertificate
    {
        public string Name { get; private set; }

        private string _certificateBody;
        public string CertificateBody
        {
            get
            {
                this.CheckIfLoaded();
                return _certificateBody;
            }
        }

        private string _certificateChain;
        public string CertificateChain
        {
            get
            {
                this.CheckIfLoaded();
                return _certificateChain;
            }
        }

        private ServerCertificateMetadata _serverCertificateMetadata;
        public ServerCertificateMetadata ServerCertificateMetadata
        {
            get
            {
                this.CheckIfLoaded();
                return _serverCertificateMetadata;
            }
        }

        private void CopyFrom(Model.ServerCertificate model)
        {
            _certificateBody = model.CertificateBody;
            _certificateChain = model.CertificateChain;
            _serverCertificateMetadata = model.ServerCertificateMetadata;
        }

      
        protected override void LoadResource()
        {
            var request = new GetServerCertificateRequest();
            request.ServerCertificateName = this.Name;

            var response = this.Client.GetServerCertificate(request);
            this.CopyFrom(response.ServerCertificate);
        }

        public ServerCertificate(string name, IAmazonIdentityManagementService client)
            : base (client)
        {
            this.IsLoaded = false;
            this.Name = name;

        }

        # region Actions

        public void Delete(DeleteServerCertificateRequest request)
        {
            request.ServerCertificateName = this.Name;
            ResourcesUtilities.Invoke(request, this.Client.DeleteServerCertificate, "Delete");
        }

        public void Delete()
        {
            var request = new DeleteServerCertificateRequest();
            Delete(request);
         }

        public IServerCertificate Update(UpdateServerCertificateRequest request)
        {
            request.ServerCertificateName = this.Name;
            var response = ResourcesUtilities.Invoke(request, this.Client.UpdateServerCertificate, "Update");
            return new Internal.ServerCertificate(name : request.NewServerCertificateName, client : this.Client);
            
        }

        #endregion

    }

    #endregion

    #region SigningCertificate

    internal class SigningCertificate : Resource<IAmazonIdentityManagementService>, ISigningCertificate
    {
        public string Id { get; private set; }

        private string _certificateBody;
        public string CertificateBody
        {
            get
            {
                this.CheckIfLoaded();
                return _certificateBody;
            }
        }

        private StatusType _status;
        public StatusType Status
        {
            get
            {
                this.CheckIfLoaded();
                return _status;
            }
        }

        private DateTime _uploadDate;
        public DateTime UploadDate
        {
            get
            {
                this.CheckIfLoaded();
                return _uploadDate;
            }
        }

        private string _userName;
        public string UserName
        {
            get
            {
                this.CheckIfLoaded();
                return _userName;
            }
        }

        public SigningCertificate(Model.SigningCertificate model, IAmazonIdentityManagementService client)
            : base (client)
        {
            this.IsLoaded = true;
            this.Id = model.CertificateId;
            CopyFrom(model);
        }

        private void CopyFrom(Model.SigningCertificate model)
        {
            _certificateBody = model.CertificateBody;
            _status = model.Status;
            _uploadDate = model.UploadDate;
            _userName = model.UserName;
        }

        public SigningCertificate(string id, IAmazonIdentityManagementService client)
            : base (client)
        {
            this.IsLoaded = false;
            this.Id = id;

        }

        # region Actions

        public void Activate(UpdateSigningCertificateRequest request)
        {
            request.CertificateId = this.Id;
            request.Status = "Active";
            ResourcesUtilities.Invoke(request, this.Client.UpdateSigningCertificate, "Activate");
        }

        public void Deactivate(UpdateSigningCertificateRequest request)
        {
            request.CertificateId = this.Id;
            request.Status = "Inactive";
            ResourcesUtilities.Invoke(request, this.Client.UpdateSigningCertificate, "Deactivate");
        }

        public void Delete(DeleteSigningCertificateRequest request)
        {
            request.CertificateId = this.Id;
            ResourcesUtilities.Invoke(request, this.Client.DeleteSigningCertificate, "Delete");
        }

        public void Delete(string userName)
        {
            var request = new DeleteSigningCertificateRequest();
            request.UserName = userName;
            Delete(request);
         }

        #endregion

    }

    #endregion

    #region User

    internal class User : Resource<IAmazonIdentityManagementService>, IUser
    {
        public string Name { get; private set; }

        private string _arn;
        public string Arn
        {
            get
            {
                this.CheckIfLoaded();
                return _arn;
            }
        }

        private DateTime _createDate;
        public DateTime CreateDate
        {
            get
            {
                this.CheckIfLoaded();
                return _createDate;
            }
        }

        private DateTime _passwordLastUsed;
        public DateTime PasswordLastUsed
        {
            get
            {
                this.CheckIfLoaded();
                return _passwordLastUsed;
            }
        }

        private string _path;
        public string Path
        {
            get
            {
                this.CheckIfLoaded();
                return _path;
            }
        }

        private string _userId;
        public string UserId
        {
            get
            {
                this.CheckIfLoaded();
                return _userId;
            }
        }

        public User(Model.User model, IAmazonIdentityManagementService client)
            : base (client)
        {
            this.IsLoaded = true;
            this.Name = model.UserName;
            CopyFrom(model);
        }

        private void CopyFrom(Model.User model)
        {
            _arn = model.Arn;
            _createDate = model.CreateDate;
            _passwordLastUsed = model.PasswordLastUsed;
            _path = model.Path;
            _userId = model.UserId;
        }

      
        protected override void LoadResource()
        {
            var request = new GetUserRequest();
            request.UserName = this.Name;

            var response = this.Client.GetUser(request);
            this.CopyFrom(response.User);
        }

        public User(string name, IAmazonIdentityManagementService client)
            : base (client)
        {
            this.IsLoaded = false;
            this.Name = name;

        }

        # region Actions

        public void AddGroup(AddUserToGroupRequest request)
        {
            request.UserName = this.Name;
            ResourcesUtilities.Invoke(request, this.Client.AddUserToGroup, "AddGroup");
        }

        public void AddGroup(string groupName)
        {
            var request = new AddUserToGroupRequest();
            request.GroupName = groupName;
            AddGroup(request);
         }

        public IAccessKey CreateAccessKey(CreateAccessKeyRequest request)
        {
            request.UserName = this.Name;
            var response = ResourcesUtilities.Invoke(request, this.Client.CreateAccessKey, "CreateAccessKey");
            return new Internal.AccessKey(model : response.AccessKey, client : this.Client);
            
        }

        public IAccessKey CreateAccessKey()
        {
            var request = new CreateAccessKeyRequest();
            return CreateAccessKey(request);
         }

        public IUserPolicy CreatePolicy(PutUserPolicyRequest request)
        {
            request.UserName = this.Name;
            var response = ResourcesUtilities.Invoke(request, this.Client.PutUserPolicy, "CreatePolicy");
            return new Internal.UserPolicy(userName : this.Name, name : request.PolicyName, client : this.Client);
            
        }

        public IUserPolicy CreatePolicy(string policyDocument, string policyName)
        {
            var request = new PutUserPolicyRequest();
            request.PolicyDocument = policyDocument;
            request.PolicyName = policyName;
            return CreatePolicy(request);
         }

        public void Delete(DeleteUserRequest request)
        {
            request.UserName = this.Name;
            ResourcesUtilities.Invoke(request, this.Client.DeleteUser, "Delete");
        }

        public void Delete()
        {
            var request = new DeleteUserRequest();
            Delete(request);
         }

        public IMfaDevice EnableMfa(EnableMFADeviceRequest request)
        {
            request.UserName = this.Name;
            var response = ResourcesUtilities.Invoke(request, this.Client.EnableMFADevice, "EnableMfa");
            return new Internal.MfaDevice(userName : this.Name, serialNumber : request.SerialNumber, client : this.Client);
            
        }

        public void RemoveGroup(RemoveUserFromGroupRequest request)
        {
            request.UserName = this.Name;
            ResourcesUtilities.Invoke(request, this.Client.RemoveUserFromGroup, "RemoveGroup");
        }

        public void RemoveGroup(string groupName)
        {
            var request = new RemoveUserFromGroupRequest();
            request.GroupName = groupName;
            RemoveGroup(request);
         }

        public IUser Update(UpdateUserRequest request)
        {
            request.UserName = this.Name;
            var response = ResourcesUtilities.Invoke(request, this.Client.UpdateUser, "Update");
            return new Internal.User(name : request.NewUserName, client : this.Client);
            
        }

        #endregion

        #region HasMany
        public IEnumerable<IAccessKey> GetAccessKeys(ListAccessKeysRequest request)
        {
            request.UserName = this.Name;
        
            foreach (var item in ResourcesUtilities.InvokePaginator(request, this.Client.ListAccessKeysEnumerator, "AccessKeys"))
            {            
                yield return new Internal.AccessKey(userName : this.Name, id : item.AccessKeyId, client : this.Client);    
            }

        }

        public IEnumerable<IAccessKey> GetAccessKeys()
        {
            var request = new ListAccessKeysRequest();
            return GetAccessKeys(request);
         }

        public IEnumerable<IGroup> GetGroups(ListGroupsForUserRequest request)
        {
            request.UserName = this.Name;
        
            foreach (var item in ResourcesUtilities.InvokePaginator(request, this.Client.ListGroupsForUserEnumerator, "Groups"))
            {            
                yield return new Internal.Group(model : item, client : this.Client);    
            }

        }

        public IEnumerable<IGroup> GetGroups()
        {
            var request = new ListGroupsForUserRequest();
            return GetGroups(request);
         }

        public IEnumerable<IMfaDevice> GetMfaDevices(ListMFADevicesRequest request)
        {
            request.UserName = this.Name;
        
            foreach (var item in ResourcesUtilities.InvokePaginator(request, this.Client.ListMFADevicesEnumerator, "MfaDevices"))
            {            
                yield return new Internal.MfaDevice(model : item, client : this.Client);    
            }

        }

        public IEnumerable<IMfaDevice> GetMfaDevices()
        {
            var request = new ListMFADevicesRequest();
            return GetMfaDevices(request);
         }

        public IEnumerable<IUserPolicy> GetPolicies(ListUserPoliciesRequest request)
        {
            request.UserName = this.Name;
        
            foreach (var item in ResourcesUtilities.InvokePaginator(request, this.Client.ListUserPoliciesEnumerator, "Policies"))
            {            
                yield return new Internal.UserPolicy(userName : this.Name, name : item, client : this.Client);    
            }

        }

        public IEnumerable<IUserPolicy> GetPolicies()
        {
            var request = new ListUserPoliciesRequest();
            return GetPolicies(request);
         }


        #endregion

        #region Subresource

        public IAccessKey GetAccessKeyById(string id)
        {
            return new Internal.AccessKey(userName : this.Name, id : id, client : this.Client);
        }
        public ILoginProfile GetLoginProfile()
        {
            return new Internal.LoginProfile(userName : this.Name, client : this.Client);
        }
        public IMfaDevice GetMfaDeviceBySerialNumber(string serialNumber)
        {
            return new Internal.MfaDevice(userName : this.Name, serialNumber : serialNumber, client : this.Client);
        }
        public IUserPolicy GetUserPolicyByName(string name)
        {
            return new Internal.UserPolicy(userName : this.Name, name : name, client : this.Client);
        }

        #endregion
    }

    #endregion

    #region UserPolicy

    internal class UserPolicy : Resource<IAmazonIdentityManagementService>, IUserPolicy
    {
        public string UserName { get; private set; }

        public string Name { get; private set; }

        private string _policyDocument;
        public string PolicyDocument
        {
            get
            {
                this.CheckIfLoaded();
                return _policyDocument;
            }
        }

        public UserPolicy(Model.GetUserPolicyResponse model, IAmazonIdentityManagementService client)
            : base (client)
        {
            this.IsLoaded = true;
            this.UserName = model.UserName;
            this.Name = model.PolicyName;
            CopyFrom(model);
        }

        private void CopyFrom(Model.GetUserPolicyResponse model)
        {
            _policyDocument = model.PolicyDocument;
        }

      
        protected override void LoadResource()
        {
            var request = new GetUserPolicyRequest();
            request.UserName = this.UserName;
            request.PolicyName = this.Name;

            var response = this.Client.GetUserPolicy(request);
            this.CopyFrom(response);
        }

        public UserPolicy(string userName, string name, IAmazonIdentityManagementService client)
            : base (client)
        {
            this.IsLoaded = false;
            this.UserName = userName;
            this.Name = name;

        }

        # region Actions

        public void Delete(DeleteUserPolicyRequest request)
        {
            request.UserName = this.UserName;
            request.PolicyName = this.Name;
            ResourcesUtilities.Invoke(request, this.Client.DeleteUserPolicy, "Delete");
        }

        public void Delete()
        {
            var request = new DeleteUserPolicyRequest();
            Delete(request);
         }

        public void Put(PutUserPolicyRequest request)
        {
            request.UserName = this.UserName;
            request.PolicyName = this.Name;
            ResourcesUtilities.Invoke(request, this.Client.PutUserPolicy, "Put");
        }

        public void Put(string policyDocument)
        {
            var request = new PutUserPolicyRequest();
            request.PolicyDocument = policyDocument;
            Put(request);
         }

        #endregion

    }

    #endregion

    #region VirtualMfaDevice

    internal class VirtualMfaDevice : Resource<IAmazonIdentityManagementService>, IVirtualMfaDevice
    {
        public string SerialNumber { get; private set; }

        private MemoryStream _base32StringSeed;
        public MemoryStream Base32StringSeed
        {
            get
            {
                this.CheckIfLoaded();
                return _base32StringSeed;
            }
        }

        private DateTime _enableDate;
        public DateTime EnableDate
        {
            get
            {
                this.CheckIfLoaded();
                return _enableDate;
            }
        }

        private MemoryStream _qRCodePNG;
        public MemoryStream QRCodePNG
        {
            get
            {
                this.CheckIfLoaded();
                return _qRCodePNG;
            }
        }

        private IUser _user;
        public IUser User
        {
            get
            {
                this.CheckIfLoaded();
                return _user;
            }
        }

        public VirtualMfaDevice(Model.VirtualMFADevice model, IAmazonIdentityManagementService client)
            : base (client)
        {
            this.IsLoaded = true;
            this.SerialNumber = model.SerialNumber;
            CopyFrom(model);
        }

        private void CopyFrom(Model.VirtualMFADevice model)
        {
            _base32StringSeed = model.Base32StringSeed;
            _enableDate = model.EnableDate;
            _qRCodePNG = model.QRCodePNG;
    
            _user = new User(model.User, this.Client);
        }

        public VirtualMfaDevice(string serialNumber, IAmazonIdentityManagementService client)
            : base (client)
        {
            this.IsLoaded = false;
            this.SerialNumber = serialNumber;

        }

        # region Actions

        public void Delete(DeleteVirtualMFADeviceRequest request)
        {
            request.SerialNumber = this.SerialNumber;
            ResourcesUtilities.Invoke(request, this.Client.DeleteVirtualMFADevice, "Delete");
        }

        #endregion

    }

    #endregion
}