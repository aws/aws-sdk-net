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
using System.Collections.Generic;

using Amazon.Runtime.Resources;
using Amazon.IdentityManagement;
using Amazon.IdentityManagement.Model;

namespace Amazon.IdentityManagement.Resources
{
    /// <summary>    
    /// A service is the entry point for using the Resource API. This class allows you to 
    /// access the top-level resources and operations associated with the
    /// AWS Identity and Access Management service.
    /// </summary>
    public class IdentityManagementService : Service<IAmazonIdentityManagementService>
    {

        #region Constructors

        /// <summary>
        /// Constructs IdentityManagementService with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public IdentityManagementService() : base(new AmazonIdentityManagementServiceClient()) {}

        /// <summary>
        /// Constructs IdentityManagementService with an instance of AmazonIdentityManagementServiceClient.
        /// </summary>     
        /// <param name="client">The AmazonIdentityManagementServiceClient to use for requests.</param>   
        public IdentityManagementService(IAmazonIdentityManagementService client)
            : base(client)
        {
            this.ShouldDisposeClient = false;
        }

        #endregion
 
        # region Methods for service-level operations

        /// <summary>
        /// Calls the ChangePassword operation on the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ChangePassword operation.</param>
        public void ChangePassword(ChangePasswordRequest request)
        {
            ResourcesUtilities.Invoke(request, this.Client.ChangePassword, "ChangePassword");
        }

        /// <summary>
        /// Calls the CreateAccountAlias operation on the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccountAlias operation.</param>
        /// <returns>An instance of the AccountAlias resource.</returns>
        public IAccountAlias CreateAccountAlias(CreateAccountAliasRequest request)
        {
            var response = ResourcesUtilities.Invoke(request, this.Client.CreateAccountAlias, "CreateAccountAlias");
            return new Internal.AccountAlias(name : request.AccountAlias, client : this.Client);
            
        }

        /// <summary>
        /// Calls the UpdateAccountPasswordPolicy operation on the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountPasswordPolicy operation.</param>
        /// <returns>An instance of the AccountPasswordPolicy resource.</returns>
        public IAccountPasswordPolicy CreateAccountPasswordPolicy(UpdateAccountPasswordPolicyRequest request)
        {
            var response = ResourcesUtilities.Invoke(request, this.Client.UpdateAccountPasswordPolicy, "CreateAccountPasswordPolicy");
            return new Internal.AccountPasswordPolicy(client : this.Client);
            
        }

        /// <summary>
        /// Calls the CreateGroup operation on the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup operation.</param>
        /// <returns>An instance of the Group resource.</returns>
        public IGroup CreateGroup(CreateGroupRequest request)
        {
            var response = ResourcesUtilities.Invoke(request, this.Client.CreateGroup, "CreateGroup");
            return new Internal.Group(model : response.Group, client : this.Client);
            
        }
        /// <summary>
        /// Calls the CreateGroup on the service.
        /// </summary>
        /// <param name="groupName">The name of the group to create. Do not include the path in this value.</param>
        /// <returns>An IGroup associated with the service.</returns>
        public IGroup CreateGroup(string groupName)
        {
            var request = new CreateGroupRequest();
            request.GroupName = groupName;
            return CreateGroup(request);
         }


        /// <summary>
        /// Calls the CreateInstanceProfile operation on the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInstanceProfile operation.</param>
        /// <returns>An instance of the InstanceProfile resource.</returns>
        public IInstanceProfile CreateInstanceProfile(CreateInstanceProfileRequest request)
        {
            var response = ResourcesUtilities.Invoke(request, this.Client.CreateInstanceProfile, "CreateInstanceProfile");
            return new Internal.InstanceProfile(model : response.InstanceProfile, client : this.Client);
            
        }

        /// <summary>
        /// Calls the CreateRole operation on the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRole operation.</param>
        /// <returns>An instance of the Role resource.</returns>
        public IRole CreateRole(CreateRoleRequest request)
        {
            var response = ResourcesUtilities.Invoke(request, this.Client.CreateRole, "CreateRole");
            return new Internal.Role(model : response.Role, client : this.Client);
            
        }
        /// <summary>
        /// Calls the CreateRole on the service.
        /// </summary>
        /// <param name="roleName">The name of the role to create.</param>
        /// <returns>An IRole associated with the service.</returns>
        public IRole CreateRole(string roleName)
        {
            var request = new CreateRoleRequest();
            request.RoleName = roleName;
            return CreateRole(request);
         }


        /// <summary>
        /// Calls the CreateSAMLProvider operation on the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSAMLProvider operation.</param>
        /// <returns>An instance of the SamlProvider resource.</returns>
        public ISamlProvider CreateSamlProvider(CreateSAMLProviderRequest request)
        {
            var response = ResourcesUtilities.Invoke(request, this.Client.CreateSAMLProvider, "CreateSamlProvider");
            return new Internal.SamlProvider(arn : response.SAMLProviderArn, client : this.Client);
            
        }

        /// <summary>
        /// Calls the UploadServerCertificate operation on the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UploadServerCertificate operation.</param>
        /// <returns>An instance of the ServerCertificate resource.</returns>
        public IServerCertificate CreateServerCertificate(UploadServerCertificateRequest request)
        {
            var response = ResourcesUtilities.Invoke(request, this.Client.UploadServerCertificate, "CreateServerCertificate");
            return new Internal.ServerCertificate(name : request.ServerCertificateName, client : this.Client);
            
        }

        /// <summary>
        /// Calls the UploadSigningCertificate operation on the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UploadSigningCertificate operation.</param>
        /// <returns>An instance of the SigningCertificate resource.</returns>
        public ISigningCertificate CreateSigningCertificate(UploadSigningCertificateRequest request)
        {
            var response = ResourcesUtilities.Invoke(request, this.Client.UploadSigningCertificate, "CreateSigningCertificate");
            return new Internal.SigningCertificate(model : response.Certificate, client : this.Client);
            
        }

        /// <summary>
        /// Calls the CreateUser operation on the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUser operation.</param>
        /// <returns>An instance of the User resource.</returns>
        public IUser CreateUser(CreateUserRequest request)
        {
            var response = ResourcesUtilities.Invoke(request, this.Client.CreateUser, "CreateUser");
            return new Internal.User(model : response.User, client : this.Client);
            
        }
        /// <summary>
        /// Calls the CreateUser on the service.
        /// </summary>
        /// <param name="userName">The name of the user to create.</param>
        /// <returns>An IUser associated with the service.</returns>
        public IUser CreateUser(string userName)
        {
            var request = new CreateUserRequest();
            request.UserName = userName;
            return CreateUser(request);
         }


        /// <summary>
        /// Calls the CreateVirtualMFADevice operation on the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVirtualMFADevice operation.</param>
        /// <returns>An instance of the VirtualMfaDevice resource.</returns>
        public IVirtualMfaDevice CreateVirtualMfaDevice(CreateVirtualMFADeviceRequest request)
        {
            var response = ResourcesUtilities.Invoke(request, this.Client.CreateVirtualMFADevice, "CreateVirtualMfaDevice");
            return new Internal.VirtualMfaDevice(model : response.VirtualMFADevice, client : this.Client);
            
        }

        #endregion

        #region Methods to get resource collections associated with the service
        /// <summary>
        /// Gets the AccountAliases associated with the service.
        /// <para>
        /// NOTE : This method calls a service operation that supports paging. Enumerating through the
        /// result of this method can potentially make multiple service operation calls.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccountAliasesEnumerator operation.</param>
        /// <returns>An IEnumerable&lt;IAccountAlias&gt; that contains the AccountAliases associated with the service.</returns>
        public IEnumerable<IAccountAlias> GetAccountAliases(ListAccountAliasesRequest request)
        {
                    
            foreach (var item in ResourcesUtilities.InvokePaginator(request, this.Client.ListAccountAliasesEnumerator, "AccountAliases"))
            {            
                yield return new Internal.AccountAlias(name : item, client : this.Client);    
            }

        }

        /// <summary>
        /// Gets the AccountAliases associated with the service.
        /// </summary>
        /// <returns>An IEnumerable&lt;IAccountAlias&gt; that contains the AccountAliases associated with the service.</returns>
        public IEnumerable<IAccountAlias> GetAccountAliases()
        {
            var request = new ListAccountAliasesRequest();
            return GetAccountAliases(request);
         }

        /// <summary>
        /// Gets the Groups associated with the service.
        /// <para>
        /// NOTE : This method calls a service operation that supports paging. Enumerating through the
        /// result of this method can potentially make multiple service operation calls.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGroupsEnumerator operation.</param>
        /// <returns>An IEnumerable&lt;IGroup&gt; that contains the Groups associated with the service.</returns>
        public IEnumerable<IGroup> GetGroups(ListGroupsRequest request)
        {
                    
            foreach (var item in ResourcesUtilities.InvokePaginator(request, this.Client.ListGroupsEnumerator, "Groups"))
            {            
                yield return new Internal.Group(model : item, client : this.Client);    
            }

        }

        /// <summary>
        /// Gets the Groups associated with the service.
        /// </summary>
        /// <returns>An IEnumerable&lt;IGroup&gt; that contains the Groups associated with the service.</returns>
        public IEnumerable<IGroup> GetGroups()
        {
            var request = new ListGroupsRequest();
            return GetGroups(request);
         }

        /// <summary>
        /// Gets the InstanceProfiles associated with the service.
        /// <para>
        /// NOTE : This method calls a service operation that supports paging. Enumerating through the
        /// result of this method can potentially make multiple service operation calls.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceProfilesEnumerator operation.</param>
        /// <returns>An IEnumerable&lt;IInstanceProfile&gt; that contains the InstanceProfiles associated with the service.</returns>
        public IEnumerable<IInstanceProfile> GetInstanceProfiles(ListInstanceProfilesRequest request)
        {
                    
            foreach (var item in ResourcesUtilities.InvokePaginator(request, this.Client.ListInstanceProfilesEnumerator, "InstanceProfiles"))
            {            
                yield return new Internal.InstanceProfile(model : item, client : this.Client);    
            }

        }

        /// <summary>
        /// Gets the InstanceProfiles associated with the service.
        /// </summary>
        /// <returns>An IEnumerable&lt;IInstanceProfile&gt; that contains the InstanceProfiles associated with the service.</returns>
        public IEnumerable<IInstanceProfile> GetInstanceProfiles()
        {
            var request = new ListInstanceProfilesRequest();
            return GetInstanceProfiles(request);
         }

        /// <summary>
        /// Gets the Roles associated with the service.
        /// <para>
        /// NOTE : This method calls a service operation that supports paging. Enumerating through the
        /// result of this method can potentially make multiple service operation calls.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRolesEnumerator operation.</param>
        /// <returns>An IEnumerable&lt;IRole&gt; that contains the Roles associated with the service.</returns>
        public IEnumerable<IRole> GetRoles(ListRolesRequest request)
        {
                    
            foreach (var item in ResourcesUtilities.InvokePaginator(request, this.Client.ListRolesEnumerator, "Roles"))
            {            
                yield return new Internal.Role(model : item, client : this.Client);    
            }

        }

        /// <summary>
        /// Gets the Roles associated with the service.
        /// </summary>
        /// <returns>An IEnumerable&lt;IRole&gt; that contains the Roles associated with the service.</returns>
        public IEnumerable<IRole> GetRoles()
        {
            var request = new ListRolesRequest();
            return GetRoles(request);
         }

        /// <summary>
        /// Gets the SamlProviders associated with the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSAMLProviders operation.</param>
        /// <returns>An IEnumerable&lt;ISamlProvider&gt; that contains the SamlProviders associated with the service.</returns>
        public IEnumerable<ISamlProvider> GetSamlProviders(ListSAMLProvidersRequest request)
        {
                    
            var items = new List<ISamlProvider>();
            foreach (var item in ResourcesUtilities.Invoke(request, this.Client.ListSAMLProviders, "SamlProviders").SAMLProviderList)
            {        
                items.Add(new Internal.SamlProvider(arn : item.Arn, client : this.Client));
            }
            return items;

        }

        /// <summary>
        /// Gets the SamlProviders associated with the service.
        /// </summary>
        /// <returns>An IEnumerable&lt;ISamlProvider&gt; that contains the SamlProviders associated with the service.</returns>
        public IEnumerable<ISamlProvider> GetSamlProviders()
        {
            var request = new ListSAMLProvidersRequest();
            return GetSamlProviders(request);
         }

        /// <summary>
        /// Gets the ServerCertificates associated with the service.
        /// <para>
        /// NOTE : This method calls a service operation that supports paging. Enumerating through the
        /// result of this method can potentially make multiple service operation calls.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServerCertificatesEnumerator operation.</param>
        /// <returns>An IEnumerable&lt;IServerCertificate&gt; that contains the ServerCertificates associated with the service.</returns>
        public IEnumerable<IServerCertificate> GetServerCertificates(ListServerCertificatesRequest request)
        {
                    
            foreach (var item in ResourcesUtilities.InvokePaginator(request, this.Client.ListServerCertificatesEnumerator, "ServerCertificates"))
            {            
                yield return new Internal.ServerCertificate(name : item.ServerCertificateName, client : this.Client);    
            }

        }

        /// <summary>
        /// Gets the ServerCertificates associated with the service.
        /// </summary>
        /// <returns>An IEnumerable&lt;IServerCertificate&gt; that contains the ServerCertificates associated with the service.</returns>
        public IEnumerable<IServerCertificate> GetServerCertificates()
        {
            var request = new ListServerCertificatesRequest();
            return GetServerCertificates(request);
         }

        /// <summary>
        /// Gets the SigningCertificates associated with the service.
        /// <para>
        /// NOTE : This method calls a service operation that supports paging. Enumerating through the
        /// result of this method can potentially make multiple service operation calls.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSigningCertificatesEnumerator operation.</param>
        /// <returns>An IEnumerable&lt;ISigningCertificate&gt; that contains the SigningCertificates associated with the service.</returns>
        public IEnumerable<ISigningCertificate> GetSigningCertificates(ListSigningCertificatesRequest request)
        {
                    
            foreach (var item in ResourcesUtilities.InvokePaginator(request, this.Client.ListSigningCertificatesEnumerator, "SigningCertificates"))
            {            
                yield return new Internal.SigningCertificate(model : item, client : this.Client);    
            }

        }

        /// <summary>
        /// Gets the SigningCertificates associated with the service.
        /// </summary>
        /// <returns>An IEnumerable&lt;ISigningCertificate&gt; that contains the SigningCertificates associated with the service.</returns>
        public IEnumerable<ISigningCertificate> GetSigningCertificates()
        {
            var request = new ListSigningCertificatesRequest();
            return GetSigningCertificates(request);
         }

        /// <summary>
        /// Gets the Users associated with the service.
        /// <para>
        /// NOTE : This method calls a service operation that supports paging. Enumerating through the
        /// result of this method can potentially make multiple service operation calls.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsersEnumerator operation.</param>
        /// <returns>An IEnumerable&lt;IUser&gt; that contains the Users associated with the service.</returns>
        public IEnumerable<IUser> GetUsers(ListUsersRequest request)
        {
                    
            foreach (var item in ResourcesUtilities.InvokePaginator(request, this.Client.ListUsersEnumerator, "Users"))
            {            
                yield return new Internal.User(model : item, client : this.Client);    
            }

        }

        /// <summary>
        /// Gets the Users associated with the service.
        /// </summary>
        /// <returns>An IEnumerable&lt;IUser&gt; that contains the Users associated with the service.</returns>
        public IEnumerable<IUser> GetUsers()
        {
            var request = new ListUsersRequest();
            return GetUsers(request);
         }

        /// <summary>
        /// Gets the VirtualMfaDevices associated with the service.
        /// <para>
        /// NOTE : This method calls a service operation that supports paging. Enumerating through the
        /// result of this method can potentially make multiple service operation calls.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVirtualMFADevicesEnumerator operation.</param>
        /// <returns>An IEnumerable&lt;IVirtualMfaDevice&gt; that contains the VirtualMfaDevices associated with the service.</returns>
        public IEnumerable<IVirtualMfaDevice> GetVirtualMfaDevices(ListVirtualMFADevicesRequest request)
        {
                    
            foreach (var item in ResourcesUtilities.InvokePaginator(request, this.Client.ListVirtualMFADevicesEnumerator, "VirtualMfaDevices"))
            {            
                yield return new Internal.VirtualMfaDevice(model : item, client : this.Client);    
            }

        }

        /// <summary>
        /// Gets the VirtualMfaDevices associated with the service.
        /// </summary>
        /// <returns>An IEnumerable&lt;IVirtualMfaDevice&gt; that contains the VirtualMfaDevices associated with the service.</returns>
        public IEnumerable<IVirtualMfaDevice> GetVirtualMfaDevices()
        {
            var request = new ListVirtualMFADevicesRequest();
            return GetVirtualMfaDevices(request);
         }


        #endregion

        #region Methods to get individual resources associated with the service

        /// <summary>
        /// Gets a AccountAlias resource associated with the service using 
        /// its identifier.
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
        /// <param name="name">The name of the AccountAlias.</param>
        /// <returns>An instance of AccountAlias resource.</returns>

        public IAccountAlias GetAccountAliasByName(string name)
        {
            return new Internal.AccountAlias(name : name, client : this.Client);
        }

        /// <summary>
        /// Gets a AccountPasswordPolicy resource associated with the service using 
        /// its identifier.
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
        /// <returns>An instance of AccountPasswordPolicy resource.</returns>

        public IAccountPasswordPolicy GetAccountPasswordPolicy()
        {
            return new Internal.AccountPasswordPolicy(client : this.Client);
        }

        /// <summary>
        /// Gets a AccountSummary resource associated with the service using 
        /// its identifier.
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
        /// <returns>An instance of AccountSummary resource.</returns>

        public IAccountSummary GetAccountSummary()
        {
            return new Internal.AccountSummary(client : this.Client);
        }

        /// <summary>
        /// Gets a Group resource associated with the service using 
        /// its identifier.
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
        /// <param name="name">The name of the Group.</param>
        /// <returns>An instance of Group resource.</returns>

        public IGroup GetGroupByName(string name)
        {
            return new Internal.Group(name : name, client : this.Client);
        }

        /// <summary>
        /// Gets a InstanceProfile resource associated with the service using 
        /// its identifier.
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
        /// <param name="name">The name of the InstanceProfile.</param>
        /// <returns>An instance of InstanceProfile resource.</returns>

        public IInstanceProfile GetInstanceProfileByName(string name)
        {
            return new Internal.InstanceProfile(name : name, client : this.Client);
        }

        /// <summary>
        /// Gets a Role resource associated with the service using 
        /// its identifier.
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
        /// <param name="name">The name of the Role.</param>
        /// <returns>An instance of Role resource.</returns>

        public IRole GetRoleByName(string name)
        {
            return new Internal.Role(name : name, client : this.Client);
        }

        /// <summary>
        /// Gets a SamlProvider resource associated with the service using 
        /// its identifier.
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
        /// <param name="arn">The arn of the SamlProvider.</param>
        /// <returns>An instance of SamlProvider resource.</returns>

        public ISamlProvider GetSamlProviderByArn(string arn)
        {
            return new Internal.SamlProvider(arn : arn, client : this.Client);
        }

        /// <summary>
        /// Gets a ServerCertificate resource associated with the service using 
        /// its identifier.
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
        /// <param name="name">The name of the ServerCertificate.</param>
        /// <returns>An instance of ServerCertificate resource.</returns>

        public IServerCertificate GetServerCertificateByName(string name)
        {
            return new Internal.ServerCertificate(name : name, client : this.Client);
        }

        /// <summary>
        /// Gets a SigningCertificate resource associated with the service using 
        /// its identifier.
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
        /// <param name="id">The id of the SigningCertificate.</param>
        /// <returns>An instance of SigningCertificate resource.</returns>

        public ISigningCertificate GetSigningCertificateById(string id)
        {
            return new Internal.SigningCertificate(id : id, client : this.Client);
        }

        /// <summary>
        /// Gets a User resource associated with the service using 
        /// its identifier.
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
        /// <param name="name">The name of the User.</param>
        /// <returns>An instance of User resource.</returns>

        public IUser GetUserByName(string name)
        {
            return new Internal.User(name : name, client : this.Client);
        }

        /// <summary>
        /// Gets a VirtualMfaDevice resource associated with the service using 
        /// its identifier.
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
        /// <param name="serialNumber">The serialnumber of the VirtualMfaDevice.</param>
        /// <returns>An instance of VirtualMfaDevice resource.</returns>

        public IVirtualMfaDevice GetVirtualMfaDeviceBySerialNumber(string serialNumber)
        {
            return new Internal.VirtualMfaDevice(serialNumber : serialNumber, client : this.Client);
        }

        #endregion

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion
    }
}