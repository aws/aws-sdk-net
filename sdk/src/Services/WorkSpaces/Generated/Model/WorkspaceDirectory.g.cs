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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Describes a directory that is used with Amazon WorkSpaces.
    /// </summary>
    public partial class WorkspaceDirectory
    {
        /// <summary>
        /// Gets and sets the property ActiveDirectoryConfig. 
        /// <para>
        /// Information about the Active Directory config.
        /// </para>
        /// </summary>
        public ActiveDirectoryConfig ActiveDirectoryConfig { get; set; }

        /// <summary>
        /// Checks to see if the ActiveDirectoryConfig property is set.
        /// </summary>
        internal bool IsSetActiveDirectoryConfig() => this.ActiveDirectoryConfig != null;

        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// The directory alias.
        /// </para>
        /// </summary>
        public string Alias { get; set; }

        /// <summary>
        /// Checks to see if the Alias property is set.
        /// </summary>
        internal bool IsSetAlias() => this.Alias != null;

        /// <summary>
        /// Gets and sets the property CertificateBasedAuthProperties. 
        /// <para>
        /// The certificate-based authentication properties used to authenticate SAML 2.0 Identity
        /// Provider (IdP) user identities to Active Directory for WorkSpaces login.
        /// </para>
        /// </summary>
        public CertificateBasedAuthProperties CertificateBasedAuthProperties { get; set; }

        /// <summary>
        /// Checks to see if the CertificateBasedAuthProperties property is set.
        /// </summary>
        internal bool IsSetCertificateBasedAuthProperties() => this.CertificateBasedAuthProperties != null;

        /// <summary>
        /// Gets and sets the property CustomerUserName. 
        /// <para>
        /// The user name for the service account.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string CustomerUserName { get; set; }

        /// <summary>
        /// Checks to see if the CustomerUserName property is set.
        /// </summary>
        internal bool IsSetCustomerUserName() => this.CustomerUserName != null;

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The directory identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 65)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// Checks to see if the DirectoryId property is set.
        /// </summary>
        internal bool IsSetDirectoryId() => this.DirectoryId != null;

        /// <summary>
        /// Gets and sets the property DirectoryName. 
        /// <para>
        /// The name of the directory.
        /// </para>
        /// </summary>
        public string DirectoryName { get; set; }

        /// <summary>
        /// Checks to see if the DirectoryName property is set.
        /// </summary>
        internal bool IsSetDirectoryName() => this.DirectoryName != null;

        /// <summary>
        /// Gets and sets the property DirectoryType. 
        /// <para>
        /// The directory type.
        /// </para>
        /// </summary>
        public WorkspaceDirectoryType DirectoryType { get; set; }

        /// <summary>
        /// Checks to see if the DirectoryType property is set.
        /// </summary>
        internal bool IsSetDirectoryType() => this.DirectoryType != null;

        /// <summary>
        /// Gets and sets the property DnsIpAddresses. 
        /// <para>
        /// The IP addresses of the DNS servers for the directory.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DnsIpAddresses { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DnsIpAddresses property is set.
        /// </summary>
        internal bool IsSetDnsIpAddresses() => this.DnsIpAddresses != null && (this.DnsIpAddresses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DnsIpv6Addresses. 
        /// <para>
        /// The IPv6 addresses of the DNS servers for the directory.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DnsIpv6Addresses { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DnsIpv6Addresses property is set.
        /// </summary>
        internal bool IsSetDnsIpv6Addresses() => this.DnsIpv6Addresses != null && (this.DnsIpv6Addresses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EndpointEncryptionMode. 
        /// <para>
        /// Endpoint encryption mode that allows you to configure the specified directory between
        /// Standard TLS and FIPS 140-2 validated mode.
        /// </para>
        /// </summary>
        public EndpointEncryptionMode EndpointEncryptionMode { get; set; }

        /// <summary>
        /// Checks to see if the EndpointEncryptionMode property is set.
        /// </summary>
        internal bool IsSetEndpointEncryptionMode() => this.EndpointEncryptionMode != null;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// The error message returned.
        /// </para>
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property IDCConfig. 
        /// <para>
        /// Specifies details about identity center configurations.
        /// </para>
        /// </summary>
        public IDCConfig IDCConfig { get; set; }

        /// <summary>
        /// Checks to see if the IDCConfig property is set.
        /// </summary>
        internal bool IsSetIDCConfig() => this.IDCConfig != null;

        /// <summary>
        /// Gets and sets the property IamRoleId. 
        /// <para>
        /// The identifier of the IAM role. This is the role that allows Amazon WorkSpaces to
        /// make calls to other services, such as Amazon EC2, on your behalf.
        /// </para>
        /// </summary>
        public string IamRoleId { get; set; }

        /// <summary>
        /// Checks to see if the IamRoleId property is set.
        /// </summary>
        internal bool IsSetIamRoleId() => this.IamRoleId != null;

        /// <summary>
        /// Gets and sets the property IpGroupIds. 
        /// <para>
        /// The identifiers of the IP access control groups associated with the directory.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> IpGroupIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the IpGroupIds property is set.
        /// </summary>
        internal bool IsSetIpGroupIds() => this.IpGroupIds != null && (this.IpGroupIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MicrosoftEntraConfig. 
        /// <para>
        /// Specifies details about Microsoft Entra configurations.
        /// </para>
        /// </summary>
        public MicrosoftEntraConfig MicrosoftEntraConfig { get; set; }

        /// <summary>
        /// Checks to see if the MicrosoftEntraConfig property is set.
        /// </summary>
        internal bool IsSetMicrosoftEntraConfig() => this.MicrosoftEntraConfig != null;

        /// <summary>
        /// Gets and sets the property RegistrationCode. 
        /// <para>
        /// The registration code for the directory. This is the code that users enter in their
        /// Amazon WorkSpaces client application to connect to the directory.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public string RegistrationCode { get; set; }

        /// <summary>
        /// Checks to see if the RegistrationCode property is set.
        /// </summary>
        internal bool IsSetRegistrationCode() => this.RegistrationCode != null;

        /// <summary>
        /// Gets and sets the property SamlProperties. 
        /// <para>
        /// Describes the enablement status, user access URL, and relay state parameter name that
        /// are used for configuring federation with an SAML 2.0 identity provider.
        /// </para>
        /// </summary>
        public SamlProperties SamlProperties { get; set; }

        /// <summary>
        /// Checks to see if the SamlProperties property is set.
        /// </summary>
        internal bool IsSetSamlProperties() => this.SamlProperties != null;

        /// <summary>
        /// Gets and sets the property SelfservicePermissions. 
        /// <para>
        /// The default self-service permissions for WorkSpaces in the directory.
        /// </para>
        /// </summary>
        public SelfservicePermissions SelfservicePermissions { get; set; }

        /// <summary>
        /// Checks to see if the SelfservicePermissions property is set.
        /// </summary>
        internal bool IsSetSelfservicePermissions() => this.SelfservicePermissions != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the directory's registration with Amazon WorkSpaces. After a directory
        /// is deregistered, the <c>DEREGISTERED</c> state is returned very briefly before the
        /// directory metadata is cleaned up, so this state is rarely returned. To confirm that
        /// a directory is deregistered, check for the directory ID by using <a href="https://docs.aws.amazon.com/workspaces/latest/api/API_DescribeWorkspaceDirectories.html">
        /// DescribeWorkspaceDirectories</a>. If the directory ID isn't returned, then the directory
        /// has been successfully deregistered.
        /// </para>
        /// </summary>
        public WorkspaceDirectoryState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StreamingProperties. 
        /// <para>
        /// The streaming properties to configure.
        /// </para>
        /// </summary>
        public StreamingProperties StreamingProperties { get; set; }

        /// <summary>
        /// Checks to see if the StreamingProperties property is set.
        /// </summary>
        internal bool IsSetStreamingProperties() => this.StreamingProperties != null;

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// The identifiers of the subnets used with the directory.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2)]
        public List<string> SubnetIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SubnetIds property is set.
        /// </summary>
        internal bool IsSetSubnetIds() => this.SubnetIds != null && (this.SubnetIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tenancy. 
        /// <para>
        /// Specifies whether the directory is dedicated or shared. To use Bring Your Own License
        /// (BYOL), this value must be set to <c>DEDICATED</c>. For more information, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/byol-windows-images.html">Bring
        /// Your Own Windows Desktop Images</a>.
        /// </para>
        /// </summary>
        public Tenancy Tenancy { get; set; }

        /// <summary>
        /// Checks to see if the Tenancy property is set.
        /// </summary>
        internal bool IsSetTenancy() => this.Tenancy != null;

        /// <summary>
        /// Gets and sets the property UserIdentityType. 
        /// <para>
        /// Indicates the identity type of the specifired user.
        /// </para>
        /// </summary>
        public UserIdentityType UserIdentityType { get; set; }

        /// <summary>
        /// Checks to see if the UserIdentityType property is set.
        /// </summary>
        internal bool IsSetUserIdentityType() => this.UserIdentityType != null;

        /// <summary>
        /// Gets and sets the property WorkspaceAccessProperties. 
        /// <para>
        /// The devices and operating systems that users can use to access WorkSpaces.
        /// </para>
        /// </summary>
        public WorkspaceAccessProperties WorkspaceAccessProperties { get; set; }

        /// <summary>
        /// Checks to see if the WorkspaceAccessProperties property is set.
        /// </summary>
        internal bool IsSetWorkspaceAccessProperties() => this.WorkspaceAccessProperties != null;

        /// <summary>
        /// Gets and sets the property WorkspaceCreationProperties. 
        /// <para>
        /// The default creation properties for all WorkSpaces in the directory.
        /// </para>
        /// </summary>
        public DefaultWorkspaceCreationProperties WorkspaceCreationProperties { get; set; }

        /// <summary>
        /// Checks to see if the WorkspaceCreationProperties property is set.
        /// </summary>
        internal bool IsSetWorkspaceCreationProperties() => this.WorkspaceCreationProperties != null;

        /// <summary>
        /// Gets and sets the property WorkspaceDirectoryDescription. 
        /// <para>
        /// The description of the WorkSpace directory
        /// </para>
        /// </summary>
        public string WorkspaceDirectoryDescription { get; set; }

        /// <summary>
        /// Checks to see if the WorkspaceDirectoryDescription property is set.
        /// </summary>
        internal bool IsSetWorkspaceDirectoryDescription() => this.WorkspaceDirectoryDescription != null;

        /// <summary>
        /// Gets and sets the property WorkspaceDirectoryName. 
        /// <para>
        /// The name fo the WorkSpace directory.
        /// </para>
        /// </summary>
        public string WorkspaceDirectoryName { get; set; }

        /// <summary>
        /// Checks to see if the WorkspaceDirectoryName property is set.
        /// </summary>
        internal bool IsSetWorkspaceDirectoryName() => this.WorkspaceDirectoryName != null;

        /// <summary>
        /// Gets and sets the property WorkspaceSecurityGroupId. 
        /// <para>
        /// The identifier of the security group that is assigned to new WorkSpaces.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 11, Max = 20)]
        public string WorkspaceSecurityGroupId { get; set; }

        /// <summary>
        /// Checks to see if the WorkspaceSecurityGroupId property is set.
        /// </summary>
        internal bool IsSetWorkspaceSecurityGroupId() => this.WorkspaceSecurityGroupId != null;

        /// <summary>
        /// Gets and sets the property WorkspaceType. 
        /// <para>
        /// Indicates whether the directory's WorkSpace type is personal or pools.
        /// </para>
        /// </summary>
        public WorkspaceType WorkspaceType { get; set; }

        /// <summary>
        /// Checks to see if the WorkspaceType property is set.
        /// </summary>
        internal bool IsSetWorkspaceType() => this.WorkspaceType != null;
    }
}
