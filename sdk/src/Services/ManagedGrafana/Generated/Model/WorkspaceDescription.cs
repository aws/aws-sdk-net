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
    /// A structure containing information about an Amazon Managed Grafana workspace in your
    /// account.
    /// </summary>
    public partial class WorkspaceDescription
    {
        private AccountAccessType _accountAccessType;
        private AuthenticationSummary _authentication;
        private DateTime? _created;
        private List<string> _dataSources = new List<string>();
        private string _description;
        private string _endpoint;
        private bool? _freeTrialConsumed;
        private DateTime? _freeTrialExpiration;
        private string _grafanaVersion;
        private string _id;
        private DateTime? _licenseExpiration;
        private LicenseType _licenseType;
        private DateTime? _modified;
        private string _name;
        private NetworkAccessConfiguration _networkAccessControl;
        private List<string> _notificationDestinations = new List<string>();
        private List<string> _organizationalUnits = new List<string>();
        private string _organizationRoleName;
        private PermissionType _permissionType;
        private string _stackSetName;
        private WorkspaceStatus _status;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private VpcConfiguration _vpcConfiguration;
        private string _workspaceRoleArn;

        /// <summary>
        /// Gets and sets the property AccountAccessType. 
        /// <para>
        /// Specifies whether the workspace can access Amazon Web Services resources in this Amazon
        /// Web Services account only, or whether it can also access Amazon Web Services resources
        /// in other accounts in the same organization. If this is <code>ORGANIZATION</code>,
        /// the <code>workspaceOrganizationalUnits</code> parameter specifies which organizational
        /// units the workspace can access.
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
        /// Gets and sets the property Authentication. 
        /// <para>
        /// A structure that describes whether the workspace uses SAML, IAM Identity Center, or
        /// both methods for user authentication.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AuthenticationSummary Authentication
        {
            get { return this._authentication; }
            set { this._authentication = value; }
        }

        // Check to see if Authentication property is set
        internal bool IsSetAuthentication()
        {
            return this._authentication != null;
        }

        /// <summary>
        /// Gets and sets the property Created. 
        /// <para>
        /// The date that the workspace was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime Created
        {
            get { return this._created.GetValueOrDefault(); }
            set { this._created = value; }
        }

        // Check to see if Created property is set
        internal bool IsSetCreated()
        {
            return this._created.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataSources. 
        /// <para>
        /// Specifies the Amazon Web Services data sources that have been configured to have IAM
        /// roles and permissions created to allow Amazon Managed Grafana to read data from these
        /// sources.
        /// </para>
        ///  
        /// <para>
        /// This list is only used when the workspace was created through the Amazon Web Services
        /// console, and the <code>permissionType</code> is <code>SERVICE_MANAGED</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> DataSources
        {
            get { return this._dataSources; }
            set { this._dataSources = value; }
        }

        // Check to see if DataSources property is set
        internal bool IsSetDataSources()
        {
            return this._dataSources != null && this._dataSources.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The user-defined description of the workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=2048)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The URL that users can use to access the Grafana console in the workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string Endpoint
        {
            get { return this._endpoint; }
            set { this._endpoint = value; }
        }

        // Check to see if Endpoint property is set
        internal bool IsSetEndpoint()
        {
            return this._endpoint != null;
        }

        /// <summary>
        /// Gets and sets the property FreeTrialConsumed. 
        /// <para>
        /// Specifies whether this workspace has already fully used its free trial for Grafana
        /// Enterprise.
        /// </para>
        /// </summary>
        public bool FreeTrialConsumed
        {
            get { return this._freeTrialConsumed.GetValueOrDefault(); }
            set { this._freeTrialConsumed = value; }
        }

        // Check to see if FreeTrialConsumed property is set
        internal bool IsSetFreeTrialConsumed()
        {
            return this._freeTrialConsumed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FreeTrialExpiration. 
        /// <para>
        /// If this workspace is currently in the free trial period for Grafana Enterprise, this
        /// value specifies when that free trial ends.
        /// </para>
        /// </summary>
        public DateTime FreeTrialExpiration
        {
            get { return this._freeTrialExpiration.GetValueOrDefault(); }
            set { this._freeTrialExpiration = value; }
        }

        // Check to see if FreeTrialExpiration property is set
        internal bool IsSetFreeTrialExpiration()
        {
            return this._freeTrialExpiration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GrafanaVersion. 
        /// <para>
        /// The version of Grafana supported in this workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string GrafanaVersion
        {
            get { return this._grafanaVersion; }
            set { this._grafanaVersion = value; }
        }

        // Check to see if GrafanaVersion property is set
        internal bool IsSetGrafanaVersion()
        {
            return this._grafanaVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique ID of this workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseExpiration. 
        /// <para>
        /// If this workspace has a full Grafana Enterprise license, this specifies when the license
        /// ends and will need to be renewed.
        /// </para>
        /// </summary>
        public DateTime LicenseExpiration
        {
            get { return this._licenseExpiration.GetValueOrDefault(); }
            set { this._licenseExpiration = value; }
        }

        // Check to see if LicenseExpiration property is set
        internal bool IsSetLicenseExpiration()
        {
            return this._licenseExpiration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LicenseType. 
        /// <para>
        /// Specifies whether this workspace has a full Grafana Enterprise license or a free trial
        /// license.
        /// </para>
        /// </summary>
        public LicenseType LicenseType
        {
            get { return this._licenseType; }
            set { this._licenseType = value; }
        }

        // Check to see if LicenseType property is set
        internal bool IsSetLicenseType()
        {
            return this._licenseType != null;
        }

        /// <summary>
        /// Gets and sets the property Modified. 
        /// <para>
        /// The most recent date that the workspace was modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime Modified
        {
            get { return this._modified.GetValueOrDefault(); }
            set { this._modified = value; }
        }

        // Check to see if Modified property is set
        internal bool IsSetModified()
        {
            return this._modified.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkAccessControl. 
        /// <para>
        /// The configuration settings for network access to your workspace.
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
        /// Gets and sets the property NotificationDestinations. 
        /// <para>
        /// The Amazon Web Services notification channels that Amazon Managed Grafana can automatically
        /// create IAM roles and permissions for, to allow Amazon Managed Grafana to use these
        /// channels.
        /// </para>
        /// </summary>
        public List<string> NotificationDestinations
        {
            get { return this._notificationDestinations; }
            set { this._notificationDestinations = value; }
        }

        // Check to see if NotificationDestinations property is set
        internal bool IsSetNotificationDestinations()
        {
            return this._notificationDestinations != null && this._notificationDestinations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OrganizationalUnits. 
        /// <para>
        /// Specifies the organizational units that this workspace is allowed to use data sources
        /// from, if this workspace is in an account that is part of an organization.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public List<string> OrganizationalUnits
        {
            get { return this._organizationalUnits; }
            set { this._organizationalUnits = value; }
        }

        // Check to see if OrganizationalUnits property is set
        internal bool IsSetOrganizationalUnits()
        {
            return this._organizationalUnits != null && this._organizationalUnits.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OrganizationRoleName. 
        /// <para>
        /// The name of the IAM role that is used to access resources through Organizations.
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
        /// If this is <code>SERVICE_MANAGED</code>, and the workplace was created through the
        /// Amazon Managed Grafana console, then Amazon Managed Grafana automatically creates
        /// the IAM roles and provisions the permissions that the workspace needs to use Amazon
        /// Web Services data sources and notification channels.
        /// </para>
        ///  
        /// <para>
        /// If this is <code>CUSTOMER_MANAGED</code>, you must manage those roles and permissions
        /// yourself.
        /// </para>
        ///  
        /// <para>
        /// If you are working with a workspace in a member account of an organization and that
        /// account is not a delegated administrator account, and you want the workspace to access
        /// data sources in other Amazon Web Services accounts in the organization, this parameter
        /// must be set to <code>CUSTOMER_MANAGED</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information about converting between customer and service managed, see <a
        /// href="https://docs.aws.amazon.com/grafana/latest/userguide/AMG-datasource-and-notification.html">Managing
        /// permissions for data sources and notification channels</a>. For more information about
        /// the roles and permissions that must be managed for customer managed workspaces, see
        /// <a href="https://docs.aws.amazon.com/grafana/latest/userguide/AMG-manage-permissions.html">Amazon
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
        /// Gets and sets the property StackSetName. 
        /// <para>
        /// The name of the CloudFormation stack set that is used to generate IAM roles to be
        /// used for this workspace.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public WorkspaceStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of tags associated with the workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VpcConfiguration. 
        /// <para>
        /// The configuration for connecting to data sources in a private VPC (Amazon Virtual
        /// Private Cloud).
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
        /// Gets and sets the property WorkspaceRoleArn. 
        /// <para>
        /// The IAM role that grants permissions to the Amazon Web Services resources that the
        /// workspace will view data from. This role must already exist.
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