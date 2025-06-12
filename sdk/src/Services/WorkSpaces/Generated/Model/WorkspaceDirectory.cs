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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
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
        private ActiveDirectoryConfig _activeDirectoryConfig;
        private string _alias;
        private CertificateBasedAuthProperties _certificateBasedAuthProperties;
        private string _customerUserName;
        private string _directoryId;
        private string _directoryName;
        private WorkspaceDirectoryType _directoryType;
        private List<string> _dnsIpAddresses = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private EndpointEncryptionMode _endpointEncryptionMode;
        private string _errorMessage;
        private string _iamRoleId;
        private IDCConfig _idcConfig;
        private List<string> _ipGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private MicrosoftEntraConfig _microsoftEntraConfig;
        private string _registrationCode;
        private SamlProperties _samlProperties;
        private SelfservicePermissions _selfservicePermissions;
        private WorkspaceDirectoryState _state;
        private StreamingProperties _streamingProperties;
        private List<string> _subnetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Tenancy _tenancy;
        private UserIdentityType _userIdentityType;
        private WorkspaceAccessProperties _workspaceAccessProperties;
        private DefaultWorkspaceCreationProperties _workspaceCreationProperties;
        private string _workspaceDirectoryDescription;
        private string _workspaceDirectoryName;
        private string _workspaceSecurityGroupId;
        private WorkspaceType _workspaceType;

        /// <summary>
        /// Gets and sets the property ActiveDirectoryConfig. 
        /// <para>
        /// Information about the Active Directory config.
        /// </para>
        /// </summary>
        public ActiveDirectoryConfig ActiveDirectoryConfig
        {
            get { return this._activeDirectoryConfig; }
            set { this._activeDirectoryConfig = value; }
        }

        // Check to see if ActiveDirectoryConfig property is set
        internal bool IsSetActiveDirectoryConfig()
        {
            return this._activeDirectoryConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// The directory alias.
        /// </para>
        /// </summary>
        public string Alias
        {
            get { return this._alias; }
            set { this._alias = value; }
        }

        // Check to see if Alias property is set
        internal bool IsSetAlias()
        {
            return this._alias != null;
        }

        /// <summary>
        /// Gets and sets the property CertificateBasedAuthProperties. 
        /// <para>
        /// The certificate-based authentication properties used to authenticate SAML 2.0 Identity
        /// Provider (IdP) user identities to Active Directory for WorkSpaces login.
        /// </para>
        /// </summary>
        public CertificateBasedAuthProperties CertificateBasedAuthProperties
        {
            get { return this._certificateBasedAuthProperties; }
            set { this._certificateBasedAuthProperties = value; }
        }

        // Check to see if CertificateBasedAuthProperties property is set
        internal bool IsSetCertificateBasedAuthProperties()
        {
            return this._certificateBasedAuthProperties != null;
        }

        /// <summary>
        /// Gets and sets the property CustomerUserName. 
        /// <para>
        /// The user name for the service account.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string CustomerUserName
        {
            get { return this._customerUserName; }
            set { this._customerUserName = value; }
        }

        // Check to see if CustomerUserName property is set
        internal bool IsSetCustomerUserName()
        {
            return this._customerUserName != null;
        }

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The directory identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=65)]
        public string DirectoryId
        {
            get { return this._directoryId; }
            set { this._directoryId = value; }
        }

        // Check to see if DirectoryId property is set
        internal bool IsSetDirectoryId()
        {
            return this._directoryId != null;
        }

        /// <summary>
        /// Gets and sets the property DirectoryName. 
        /// <para>
        /// The name of the directory.
        /// </para>
        /// </summary>
        public string DirectoryName
        {
            get { return this._directoryName; }
            set { this._directoryName = value; }
        }

        // Check to see if DirectoryName property is set
        internal bool IsSetDirectoryName()
        {
            return this._directoryName != null;
        }

        /// <summary>
        /// Gets and sets the property DirectoryType. 
        /// <para>
        /// The directory type.
        /// </para>
        /// </summary>
        public WorkspaceDirectoryType DirectoryType
        {
            get { return this._directoryType; }
            set { this._directoryType = value; }
        }

        // Check to see if DirectoryType property is set
        internal bool IsSetDirectoryType()
        {
            return this._directoryType != null;
        }

        /// <summary>
        /// Gets and sets the property DnsIpAddresses. 
        /// <para>
        /// The IP addresses of the DNS servers for the directory.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DnsIpAddresses
        {
            get { return this._dnsIpAddresses; }
            set { this._dnsIpAddresses = value; }
        }

        // Check to see if DnsIpAddresses property is set
        internal bool IsSetDnsIpAddresses()
        {
            return this._dnsIpAddresses != null && (this._dnsIpAddresses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EndpointEncryptionMode. 
        /// <para>
        /// Endpoint encryption mode that allows you to configure the specified directory between
        /// Standard TLS and FIPS 140-2 validated mode.
        /// </para>
        /// </summary>
        public EndpointEncryptionMode EndpointEncryptionMode
        {
            get { return this._endpointEncryptionMode; }
            set { this._endpointEncryptionMode = value; }
        }

        // Check to see if EndpointEncryptionMode property is set
        internal bool IsSetEndpointEncryptionMode()
        {
            return this._endpointEncryptionMode != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// The error message returned.
        /// </para>
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property IamRoleId. 
        /// <para>
        /// The identifier of the IAM role. This is the role that allows Amazon WorkSpaces to
        /// make calls to other services, such as Amazon EC2, on your behalf.
        /// </para>
        /// </summary>
        public string IamRoleId
        {
            get { return this._iamRoleId; }
            set { this._iamRoleId = value; }
        }

        // Check to see if IamRoleId property is set
        internal bool IsSetIamRoleId()
        {
            return this._iamRoleId != null;
        }

        /// <summary>
        /// Gets and sets the property IDCConfig. 
        /// <para>
        /// Specifies details about identity center configurations.
        /// </para>
        /// </summary>
        public IDCConfig IDCConfig
        {
            get { return this._idcConfig; }
            set { this._idcConfig = value; }
        }

        // Check to see if IDCConfig property is set
        internal bool IsSetIDCConfig()
        {
            return this._idcConfig != null;
        }

        /// <summary>
        /// Gets and sets the property IpGroupIds. 
        /// <para>
        /// The identifiers of the IP access control groups associated with the directory.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> IpGroupIds
        {
            get { return this._ipGroupIds; }
            set { this._ipGroupIds = value; }
        }

        // Check to see if IpGroupIds property is set
        internal bool IsSetIpGroupIds()
        {
            return this._ipGroupIds != null && (this._ipGroupIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MicrosoftEntraConfig. 
        /// <para>
        /// Specifies details about Microsoft Entra configurations.
        /// </para>
        /// </summary>
        public MicrosoftEntraConfig MicrosoftEntraConfig
        {
            get { return this._microsoftEntraConfig; }
            set { this._microsoftEntraConfig = value; }
        }

        // Check to see if MicrosoftEntraConfig property is set
        internal bool IsSetMicrosoftEntraConfig()
        {
            return this._microsoftEntraConfig != null;
        }

        /// <summary>
        /// Gets and sets the property RegistrationCode. 
        /// <para>
        /// The registration code for the directory. This is the code that users enter in their
        /// Amazon WorkSpaces client application to connect to the directory.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public string RegistrationCode
        {
            get { return this._registrationCode; }
            set { this._registrationCode = value; }
        }

        // Check to see if RegistrationCode property is set
        internal bool IsSetRegistrationCode()
        {
            return this._registrationCode != null;
        }

        /// <summary>
        /// Gets and sets the property SamlProperties. 
        /// <para>
        /// Describes the enablement status, user access URL, and relay state parameter name that
        /// are used for configuring federation with an SAML 2.0 identity provider.
        /// </para>
        /// </summary>
        public SamlProperties SamlProperties
        {
            get { return this._samlProperties; }
            set { this._samlProperties = value; }
        }

        // Check to see if SamlProperties property is set
        internal bool IsSetSamlProperties()
        {
            return this._samlProperties != null;
        }

        /// <summary>
        /// Gets and sets the property SelfservicePermissions. 
        /// <para>
        /// The default self-service permissions for WorkSpaces in the directory.
        /// </para>
        /// </summary>
        public SelfservicePermissions SelfservicePermissions
        {
            get { return this._selfservicePermissions; }
            set { this._selfservicePermissions = value; }
        }

        // Check to see if SelfservicePermissions property is set
        internal bool IsSetSelfservicePermissions()
        {
            return this._selfservicePermissions != null;
        }

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
        public WorkspaceDirectoryState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property StreamingProperties. 
        /// <para>
        /// The streaming properties to configure.
        /// </para>
        /// </summary>
        public StreamingProperties StreamingProperties
        {
            get { return this._streamingProperties; }
            set { this._streamingProperties = value; }
        }

        // Check to see if StreamingProperties property is set
        internal bool IsSetStreamingProperties()
        {
            return this._streamingProperties != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// The identifiers of the subnets used with the directory.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=2)]
        public List<string> SubnetIds
        {
            get { return this._subnetIds; }
            set { this._subnetIds = value; }
        }

        // Check to see if SubnetIds property is set
        internal bool IsSetSubnetIds()
        {
            return this._subnetIds != null && (this._subnetIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tenancy. 
        /// <para>
        /// Specifies whether the directory is dedicated or shared. To use Bring Your Own License
        /// (BYOL), this value must be set to <c>DEDICATED</c>. For more information, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/byol-windows-images.html">Bring
        /// Your Own Windows Desktop Images</a>.
        /// </para>
        /// </summary>
        public Tenancy Tenancy
        {
            get { return this._tenancy; }
            set { this._tenancy = value; }
        }

        // Check to see if Tenancy property is set
        internal bool IsSetTenancy()
        {
            return this._tenancy != null;
        }

        /// <summary>
        /// Gets and sets the property UserIdentityType. 
        /// <para>
        /// Indicates the identity type of the specifired user.
        /// </para>
        /// </summary>
        public UserIdentityType UserIdentityType
        {
            get { return this._userIdentityType; }
            set { this._userIdentityType = value; }
        }

        // Check to see if UserIdentityType property is set
        internal bool IsSetUserIdentityType()
        {
            return this._userIdentityType != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceAccessProperties. 
        /// <para>
        /// The devices and operating systems that users can use to access WorkSpaces.
        /// </para>
        /// </summary>
        public WorkspaceAccessProperties WorkspaceAccessProperties
        {
            get { return this._workspaceAccessProperties; }
            set { this._workspaceAccessProperties = value; }
        }

        // Check to see if WorkspaceAccessProperties property is set
        internal bool IsSetWorkspaceAccessProperties()
        {
            return this._workspaceAccessProperties != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceCreationProperties. 
        /// <para>
        /// The default creation properties for all WorkSpaces in the directory.
        /// </para>
        /// </summary>
        public DefaultWorkspaceCreationProperties WorkspaceCreationProperties
        {
            get { return this._workspaceCreationProperties; }
            set { this._workspaceCreationProperties = value; }
        }

        // Check to see if WorkspaceCreationProperties property is set
        internal bool IsSetWorkspaceCreationProperties()
        {
            return this._workspaceCreationProperties != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceDirectoryDescription. 
        /// <para>
        /// The description of the WorkSpace directory
        /// </para>
        /// </summary>
        public string WorkspaceDirectoryDescription
        {
            get { return this._workspaceDirectoryDescription; }
            set { this._workspaceDirectoryDescription = value; }
        }

        // Check to see if WorkspaceDirectoryDescription property is set
        internal bool IsSetWorkspaceDirectoryDescription()
        {
            return this._workspaceDirectoryDescription != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceDirectoryName. 
        /// <para>
        /// The name fo the WorkSpace directory.
        /// </para>
        /// </summary>
        public string WorkspaceDirectoryName
        {
            get { return this._workspaceDirectoryName; }
            set { this._workspaceDirectoryName = value; }
        }

        // Check to see if WorkspaceDirectoryName property is set
        internal bool IsSetWorkspaceDirectoryName()
        {
            return this._workspaceDirectoryName != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceSecurityGroupId. 
        /// <para>
        /// The identifier of the security group that is assigned to new WorkSpaces.
        /// </para>
        /// </summary>
        [AWSProperty(Min=11, Max=20)]
        public string WorkspaceSecurityGroupId
        {
            get { return this._workspaceSecurityGroupId; }
            set { this._workspaceSecurityGroupId = value; }
        }

        // Check to see if WorkspaceSecurityGroupId property is set
        internal bool IsSetWorkspaceSecurityGroupId()
        {
            return this._workspaceSecurityGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceType. 
        /// <para>
        /// Indicates whether the directory's WorkSpace type is personal or pools.
        /// </para>
        /// </summary>
        public WorkspaceType WorkspaceType
        {
            get { return this._workspaceType; }
            set { this._workspaceType = value; }
        }

        // Check to see if WorkspaceType property is set
        internal bool IsSetWorkspaceType()
        {
            return this._workspaceType != null;
        }

    }
}