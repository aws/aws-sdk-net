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
 * Do not modify this file. This file is generated from the grafana-2020-08-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ManagedGrafana.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateWorkspace operation.
    /// Modifies an existing Amazon Managed Grafana workspace. If you use this operation and
    /// omit any optional parameters, the existing values of those parameters are not changed.
    /// 
    ///  
    /// <para>
    /// To modify the user authentication methods that the workspace uses, such as SAML or
    /// IAM Identity Center, use <a href="https://docs.aws.amazon.com/grafana/latest/APIReference/API_UpdateWorkspaceAuthentication.html">UpdateWorkspaceAuthentication</a>.
    /// </para>
    ///  
    /// <para>
    /// To modify which users in the workspace have the <code>Admin</code> and <code>Editor</code>
    /// Grafana roles, use <a href="https://docs.aws.amazon.com/grafana/latest/APIReference/API_UpdatePermissions.html">UpdatePermissions</a>.
    /// </para>
    /// </summary>
    public partial class UpdateWorkspaceRequest : AmazonManagedGrafanaRequest
    {
        private AccountAccessType _accountAccessType;
        private NetworkAccessConfiguration _networkAccessControl;
        private string _organizationRoleName;
        private PermissionType _permissionType;
        private bool? _removeNetworkAccessConfiguration;
        private bool? _removeVpcConfiguration;
        private string _stackSetName;
        private VpcConfiguration _vpcConfiguration;
        private List<string> _workspaceDataSources = new List<string>();
        private string _workspaceDescription;
        private string _workspaceId;
        private string _workspaceName;
        private List<string> _workspaceNotificationDestinations = new List<string>();
        private List<string> _workspaceOrganizationalUnits = new List<string>();
        private string _workspaceRoleArn;

        /// <summary>
        /// Gets and sets the property AccountAccessType. 
        /// <para>
        /// Specifies whether the workspace can access Amazon Web Services resources in this Amazon
        /// Web Services account only, or whether it can also access Amazon Web Services resources
        /// in other accounts in the same organization. If you specify <code>ORGANIZATION</code>,
        /// you must specify which organizational units the workspace can access in the <code>workspaceOrganizationalUnits</code>
        /// parameter.
        /// </para>
        /// </summary>
        public AccountAccessType AccountAccessType
        {
            get { return this._accountAccessType; }
            set { this._accountAccessType = value; }
        }

        // Check to see if AccountAccessType property is set
        internal bool IsSetAccountAccessType()
        {
            return this._accountAccessType != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkAccessControl. 
        /// <para>
        /// The configuration settings for network access to your workspace.
        /// </para>
        ///  
        /// <para>
        /// When this is configured, only listed IP addresses and VPC endpoints will be able to
        /// access your workspace. Standard Grafana authentication and authorization will still
        /// be required.
        /// </para>
        ///  
        /// <para>
        /// If this is not configured, or is removed, then all IP addresses and VPC endpoints
        /// will be allowed. Standard Grafana authentication and authorization will still be required.
        /// </para>
        /// </summary>
        public NetworkAccessConfiguration NetworkAccessControl
        {
            get { return this._networkAccessControl; }
            set { this._networkAccessControl = value; }
        }

        // Check to see if NetworkAccessControl property is set
        internal bool IsSetNetworkAccessControl()
        {
            return this._networkAccessControl != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationRoleName. 
        /// <para>
        /// The name of an IAM role that already exists to use to access resources through Organizations.
        /// This can only be used with a workspace that has the <code>permissionType</code> set
        /// to <code>CUSTOMER_MANAGED</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=2048)]
        public string OrganizationRoleName
        {
            get { return this._organizationRoleName; }
            set { this._organizationRoleName = value; }
        }

        // Check to see if OrganizationRoleName property is set
        internal bool IsSetOrganizationRoleName()
        {
            return this._organizationRoleName != null;
        }

        /// <summary>
        /// Gets and sets the property PermissionType. 
        /// <para>
        /// Use this parameter if you want to change a workspace from <code>SERVICE_MANAGED</code>
        /// to <code>CUSTOMER_MANAGED</code>. This allows you to manage the permissions that the
        /// workspace uses to access datasources and notification channels. If the workspace is
        /// in a member Amazon Web Services account of an organization, and that account is not
        /// a delegated administrator account, and you want the workspace to access data sources
        /// in other Amazon Web Services accounts in the organization, you must choose <code>CUSTOMER_MANAGED</code>.
        /// </para>
        ///  
        /// <para>
        /// If you specify this as <code>CUSTOMER_MANAGED</code>, you must also specify a <code>workspaceRoleArn</code>
        /// that the workspace will use for accessing Amazon Web Services resources.
        /// </para>
        ///  
        /// <para>
        /// For more information on the role and permissions needed, see <a href="https://docs.aws.amazon.com/grafana/latest/userguide/AMG-manage-permissions.html">Amazon
        /// Managed Grafana permissions and policies for Amazon Web Services data sources and
        /// notification channels</a> 
        /// </para>
        ///  <note> 
        /// <para>
        /// Do not use this to convert a <code>CUSTOMER_MANAGED</code> workspace to <code>SERVICE_MANAGED</code>.
        /// Do not include this parameter if you want to leave the workspace as <code>SERVICE_MANAGED</code>.
        /// </para>
        ///  
        /// <para>
        /// You can convert a <code>CUSTOMER_MANAGED</code> workspace to <code>SERVICE_MANAGED</code>
        /// using the Amazon Managed Grafana console. For more information, see <a href="https://docs.aws.amazon.com/grafana/latest/userguide/AMG-datasource-and-notification.html">Managing
        /// permissions for data sources and notification channels</a>.
        /// </para>
        ///  </note>
        /// </summary>
        public PermissionType PermissionType
        {
            get { return this._permissionType; }
            set { this._permissionType = value; }
        }

        // Check to see if PermissionType property is set
        internal bool IsSetPermissionType()
        {
            return this._permissionType != null;
        }

        /// <summary>
        /// Gets and sets the property RemoveNetworkAccessConfiguration. 
        /// <para>
        /// Whether to remove the network access configuration from the workspace.
        /// </para>
        ///  
        /// <para>
        /// Setting this to <code>true</code> and providing a <code>networkAccessControl</code>
        /// to set will return an error.
        /// </para>
        ///  
        /// <para>
        /// If you remove this configuration by setting this to <code>true</code>, then all IP
        /// addresses and VPC endpoints will be allowed. Standard Grafana authentication and authorization
        /// will still be required.
        /// </para>
        /// </summary>
        public bool RemoveNetworkAccessConfiguration
        {
            get { return this._removeNetworkAccessConfiguration.GetValueOrDefault(); }
            set { this._removeNetworkAccessConfiguration = value; }
        }

        // Check to see if RemoveNetworkAccessConfiguration property is set
        internal bool IsSetRemoveNetworkAccessConfiguration()
        {
            return this._removeNetworkAccessConfiguration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RemoveVpcConfiguration. 
        /// <para>
        /// Whether to remove the VPC configuration from the workspace.
        /// </para>
        ///  
        /// <para>
        /// Setting this to <code>true</code> and providing a <code>vpcConfiguration</code> to
        /// set will return an error.
        /// </para>
        /// </summary>
        public bool RemoveVpcConfiguration
        {
            get { return this._removeVpcConfiguration.GetValueOrDefault(); }
            set { this._removeVpcConfiguration = value; }
        }

        // Check to see if RemoveVpcConfiguration property is set
        internal bool IsSetRemoveVpcConfiguration()
        {
            return this._removeVpcConfiguration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StackSetName. 
        /// <para>
        /// The name of the CloudFormation stack set to use to generate IAM roles to be used for
        /// this workspace.
        /// </para>
        /// </summary>
        public string StackSetName
        {
            get { return this._stackSetName; }
            set { this._stackSetName = value; }
        }

        // Check to see if StackSetName property is set
        internal bool IsSetStackSetName()
        {
            return this._stackSetName != null;
        }

        /// <summary>
        /// Gets and sets the property VpcConfiguration. 
        /// <para>
        /// The configuration settings for an Amazon VPC that contains data sources for your Grafana
        /// workspace to connect to.
        /// </para>
        /// </summary>
        public VpcConfiguration VpcConfiguration
        {
            get { return this._vpcConfiguration; }
            set { this._vpcConfiguration = value; }
        }

        // Check to see if VpcConfiguration property is set
        internal bool IsSetVpcConfiguration()
        {
            return this._vpcConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceDataSources. 
        /// <para>
        /// This parameter is for internal use only, and should not be used.
        /// </para>
        /// </summary>
        public List<string> WorkspaceDataSources
        {
            get { return this._workspaceDataSources; }
            set { this._workspaceDataSources = value; }
        }

        // Check to see if WorkspaceDataSources property is set
        internal bool IsSetWorkspaceDataSources()
        {
            return this._workspaceDataSources != null && this._workspaceDataSources.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property WorkspaceDescription. 
        /// <para>
        /// A description for the workspace. This is used only to help you identify this workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=2048)]
        public string WorkspaceDescription
        {
            get { return this._workspaceDescription; }
            set { this._workspaceDescription = value; }
        }

        // Check to see if WorkspaceDescription property is set
        internal bool IsSetWorkspaceDescription()
        {
            return this._workspaceDescription != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceId. 
        /// <para>
        /// The ID of the workspace to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string WorkspaceId
        {
            get { return this._workspaceId; }
            set { this._workspaceId = value; }
        }

        // Check to see if WorkspaceId property is set
        internal bool IsSetWorkspaceId()
        {
            return this._workspaceId != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceName. 
        /// <para>
        /// A new name for the workspace to update.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string WorkspaceName
        {
            get { return this._workspaceName; }
            set { this._workspaceName = value; }
        }

        // Check to see if WorkspaceName property is set
        internal bool IsSetWorkspaceName()
        {
            return this._workspaceName != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceNotificationDestinations. 
        /// <para>
        /// Specify the Amazon Web Services notification channels that you plan to use in this
        /// workspace. Specifying these data sources here enables Amazon Managed Grafana to create
        /// IAM roles and permissions that allow Amazon Managed Grafana to use these channels.
        /// </para>
        /// </summary>
        public List<string> WorkspaceNotificationDestinations
        {
            get { return this._workspaceNotificationDestinations; }
            set { this._workspaceNotificationDestinations = value; }
        }

        // Check to see if WorkspaceNotificationDestinations property is set
        internal bool IsSetWorkspaceNotificationDestinations()
        {
            return this._workspaceNotificationDestinations != null && this._workspaceNotificationDestinations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property WorkspaceOrganizationalUnits. 
        /// <para>
        /// Specifies the organizational units that this workspace is allowed to use data sources
        /// from, if this workspace is in an account that is part of an organization.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public List<string> WorkspaceOrganizationalUnits
        {
            get { return this._workspaceOrganizationalUnits; }
            set { this._workspaceOrganizationalUnits = value; }
        }

        // Check to see if WorkspaceOrganizationalUnits property is set
        internal bool IsSetWorkspaceOrganizationalUnits()
        {
            return this._workspaceOrganizationalUnits != null && this._workspaceOrganizationalUnits.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property WorkspaceRoleArn. 
        /// <para>
        /// Specifies an IAM role that grants permissions to Amazon Web Services resources that
        /// the workspace accesses, such as data sources and notification channels. If this workspace
        /// has <code>permissionType</code> <code>CUSTOMER_MANAGED</code>, then this role is required.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=2048)]
        public string WorkspaceRoleArn
        {
            get { return this._workspaceRoleArn; }
            set { this._workspaceRoleArn = value; }
        }

        // Check to see if WorkspaceRoleArn property is set
        internal bool IsSetWorkspaceRoleArn()
        {
            return this._workspaceRoleArn != null;
        }

    }
}