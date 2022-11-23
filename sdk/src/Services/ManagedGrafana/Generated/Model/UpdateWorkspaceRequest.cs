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
        private string _organizationRoleName;
        private PermissionType _permissionType;
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
        /// Gets and sets the property OrganizationRoleName. 
        /// <para>
        /// The name of an IAM role that already exists to use to access resources through Organizations.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// If you specify <code>Service Managed</code>, Amazon Managed Grafana automatically
        /// creates the IAM roles and provisions the permissions that the workspace needs to use
        /// Amazon Web Services data sources and notification channels.
        /// </para>
        ///  
        /// <para>
        /// If you specify <code>CUSTOMER_MANAGED</code>, you will manage those roles and permissions
        /// yourself. If you are creating this workspace in a member account of an organization
        /// and that account is not a delegated administrator account, and you want the workspace
        /// to access data sources in other Amazon Web Services accounts in the organization,
        /// you must choose <code>CUSTOMER_MANAGED</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/grafana/latest/userguide/AMG-manage-permissions.html">Amazon
        /// Managed Grafana permissions and policies for Amazon Web Services data sources and
        /// notification channels</a> 
        /// </para>
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
        /// Specify the Amazon Web Services data sources that you want to be queried in this workspace.
        /// Specifying these data sources here enables Amazon Managed Grafana to create IAM roles
        /// and permissions that allow Amazon Managed Grafana to read data from these sources.
        /// You must still add them as data sources in the Grafana console in the workspace.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a data source here, you can still add it as a data source later
        /// in the workspace console. However, you will then have to manually configure permissions
        /// for it.
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
        [AWSProperty(Min=0, Max=2048)]
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
        /// The workspace needs an IAM role that grants permissions to the Amazon Web Services
        /// resources that the workspace will view data from. If you already have a role that
        /// you want to use, specify it here. If you omit this field and you specify some Amazon
        /// Web Services resources in <code>workspaceDataSources</code> or <code>workspaceNotificationDestinations</code>,
        /// a new IAM role with the necessary permissions is automatically created.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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