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

namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Describes a directory that is used with Amazon WorkSpaces.
    /// </summary>
    public partial class WorkspaceDirectory
    {
        private string _alias;
        private string _customerUserName;
        private string _directoryId;
        private string _directoryName;
        private WorkspaceDirectoryType _directoryType;
        private List<string> _dnsIpAddresses = new List<string>();
        private string _iamRoleId;
        private List<string> _ipGroupIds = new List<string>();
        private string _registrationCode;
        private SelfservicePermissions _selfservicePermissions;
        private WorkspaceDirectoryState _state;
        private List<string> _subnetIds = new List<string>();
        private Tenancy _tenancy;
        private WorkspaceAccessProperties _workspaceAccessProperties;
        private DefaultWorkspaceCreationProperties _workspaceCreationProperties;
        private string _workspaceSecurityGroupId;

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
        /// </summary>
        public List<string> DnsIpAddresses
        {
            get { return this._dnsIpAddresses; }
            set { this._dnsIpAddresses = value; }
        }

        // Check to see if DnsIpAddresses property is set
        internal bool IsSetDnsIpAddresses()
        {
            return this._dnsIpAddresses != null && this._dnsIpAddresses.Count > 0; 
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
        /// Gets and sets the property IpGroupIds. 
        /// <para>
        /// The identifiers of the IP access control groups associated with the directory.
        /// </para>
        /// </summary>
        public List<string> IpGroupIds
        {
            get { return this._ipGroupIds; }
            set { this._ipGroupIds = value; }
        }

        // Check to see if IpGroupIds property is set
        internal bool IsSetIpGroupIds()
        {
            return this._ipGroupIds != null && this._ipGroupIds.Count > 0; 
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
        /// is deregistered, the <code>DEREGISTERED</code> state is returned very briefly before
        /// the directory metadata is cleaned up, so this state is rarely returned. To confirm
        /// that a directory is deregistered, check for the directory ID by using <a href="https://docs.aws.amazon.com/workspaces/latest/api/API_DescribeWorkspaceDirectories.html">
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
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// The identifiers of the subnets used with the directory.
        /// </para>
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
            return this._subnetIds != null && this._subnetIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tenancy. 
        /// <para>
        /// Specifies whether the directory is dedicated or shared. To use Bring Your Own License
        /// (BYOL), this value must be set to <code>DEDICATED</code>. For more information, see
        /// <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/byol-windows-images.html">Bring
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

    }
}