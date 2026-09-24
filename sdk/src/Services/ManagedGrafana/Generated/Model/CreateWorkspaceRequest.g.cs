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

namespace Amazon.ManagedGrafana.Model
{
    /// <summary>
    /// Container for the parameters to the CreateWorkspace operation. Creates a <i>workspace</i>.
    /// In a workspace, you can create Grafana dashboards and visualizations to analyze your
    /// metrics, logs, and traces. You don't have to build, package, or deploy any hardware
    /// to run the Grafana server. <para> Don't use <c>CreateWorkspace</c> to modify an existing
    /// workspace. Instead, use <a href="https://docs.aws.amazon.com/grafana/latest/APIReference/API_UpdateWorkspace.html">UpdateWorkspace</a>.
    /// </para>
    /// </summary>
    public partial class CreateWorkspaceRequest : AmazonManagedGrafanaRequest
    {
        /// <summary>
        /// Gets and sets the property AccountAccessType. 
        /// <para>
        /// Specifies whether the workspace can access Amazon Web Services resources in this Amazon
        /// Web Services account only, or whether it can also access Amazon Web Services resources
        /// in other accounts in the same organization. If you specify <c>ORGANIZATION</c>, you
        /// must specify which organizational units the workspace can access in the <c>workspaceOrganizationalUnits</c>
        /// parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AccountAccessType AccountAccessType { get; set; }

        /// <summary>
        /// Checks to see if the AccountAccessType property is set.
        /// </summary>
        internal bool IsSetAccountAccessType() => this.AccountAccessType != null;

        /// <summary>
        /// Gets and sets the property AuthenticationProviders. 
        /// <para>
        /// Specifies whether this workspace uses SAML 2.0, IAM Identity Center, or both to authenticate
        /// users for using the Grafana console within a workspace. For more information, see
        /// <a href="https://docs.aws.amazon.com/grafana/latest/userguide/authentication-in-AMG.html">User
        /// authentication in Amazon Managed Grafana</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> AuthenticationProviders { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AuthenticationProviders property is set.
        /// </summary>
        internal bool IsSetAuthenticationProviders() => this.AuthenticationProviders != null && (this.AuthenticationProviders.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive, user-provided identifier to ensure the idempotency of the
        /// request.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The configuration string for the workspace that you create. For more information about
        /// the format and configuration options available, see <a href="https://docs.aws.amazon.com/grafana/latest/userguide/AMG-configure-workspace.html">Working
        /// in your Grafana workspace</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 65536)]
        public string Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

        /// <summary>
        /// Gets and sets the property GrafanaVersion. 
        /// <para>
        /// Specifies the version of Grafana to support in the new workspace. If not specified,
        /// defaults to the latest version (for example, 10.4).
        /// </para>
        ///  
        /// <para>
        /// To get a list of supported versions, use the <c>ListVersions</c> operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string GrafanaVersion { get; set; }

        /// <summary>
        /// Checks to see if the GrafanaVersion property is set.
        /// </summary>
        internal bool IsSetGrafanaVersion() => this.GrafanaVersion != null;

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// Specifies whether the workspace supports IPv4 only, or IPv4 and IPv6. Valid values
        /// are <c>IPv4</c> and <c>DualStack</c>. For more information about IP address types,
        /// see <a href="https://docs.aws.amazon.com/grafana/latest/userguide/AMG-configure-nac.html">Network
        /// access control</a>.
        /// </para>
        /// </summary>
        public IPAddressType IpAddressType { get; set; }

        /// <summary>
        /// Checks to see if the IpAddressType property is set.
        /// </summary>
        internal bool IsSetIpAddressType() => this.IpAddressType != null;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ID or ARN of the Key Management Service key to use for encrypting workspace data.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property NetworkAccessControl. 
        /// <para>
        /// Configuration for network access to your workspace.
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
        public NetworkAccessConfiguration NetworkAccessControl { get; set; }

        /// <summary>
        /// Checks to see if the NetworkAccessControl property is set.
        /// </summary>
        internal bool IsSetNetworkAccessControl() => this.NetworkAccessControl != null;

        /// <summary>
        /// Gets and sets the property OrganizationRoleName. 
        /// <para>
        /// The name of an IAM role that already exists to use with Organizations to access Amazon
        /// Web Services data sources and notification channels in other accounts in an organization.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 2048)]
        public string OrganizationRoleName { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationRoleName property is set.
        /// </summary>
        internal bool IsSetOrganizationRoleName() => this.OrganizationRoleName != null;

        /// <summary>
        /// Gets and sets the property PermissionType. 
        /// <para>
        /// When creating a workspace through the Amazon Web Services API, CLI or Amazon Web Services
        /// CloudFormation, you must manage IAM roles and provision the permissions that the workspace
        /// needs to use Amazon Web Services data sources and notification channels.
        /// </para>
        ///  
        /// <para>
        /// You must also specify a <c>workspaceRoleArn</c> for a role that you will manage for
        /// the workspace to use when accessing those datasources and notification channels.
        /// </para>
        ///  
        /// <para>
        /// The ability for Amazon Managed Grafana to create and update IAM roles on behalf of
        /// the user is supported only in the Amazon Managed Grafana console, where this value
        /// may be set to <c>SERVICE_MANAGED</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Use only the <c>CUSTOMER_MANAGED</c> permission type when creating a workspace with
        /// the API, CLI or Amazon Web Services CloudFormation. 
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/grafana/latest/userguide/AMG-manage-permissions.html">Amazon
        /// Managed Grafana permissions and policies for Amazon Web Services data sources and
        /// notification channels</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PermissionType PermissionType { get; set; }

        /// <summary>
        /// Checks to see if the PermissionType property is set.
        /// </summary>
        internal bool IsSetPermissionType() => this.PermissionType != null;

        /// <summary>
        /// Gets and sets the property StackSetName. 
        /// <para>
        /// The name of the CloudFormation stack set to use to generate IAM roles to be used for
        /// this workspace.
        /// </para>
        /// </summary>
        public string StackSetName { get; set; }

        /// <summary>
        /// Checks to see if the StackSetName property is set.
        /// </summary>
        internal bool IsSetStackSetName() => this.StackSetName != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of tags associated with the workspace.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VpcConfiguration. 
        /// <para>
        /// The configuration settings for an Amazon VPC that contains data sources for your Grafana
        /// workspace to connect to.
        /// </para>
        ///  <note> 
        /// <para>
        /// Connecting to a private VPC is not yet available in the Asia Pacific (Seoul) Region
        /// (ap-northeast-2).
        /// </para>
        ///  </note>
        /// </summary>
        public VpcConfiguration VpcConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfiguration property is set.
        /// </summary>
        internal bool IsSetVpcConfiguration() => this.VpcConfiguration != null;

        /// <summary>
        /// Gets and sets the property WorkspaceDataSources. 
        /// <para>
        /// This parameter is for internal use only, and should not be used.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> WorkspaceDataSources { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the WorkspaceDataSources property is set.
        /// </summary>
        internal bool IsSetWorkspaceDataSources() => this.WorkspaceDataSources != null && (this.WorkspaceDataSources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WorkspaceDescription. 
        /// <para>
        /// A description for the workspace. This is used only to help you identify this workspace.
        /// </para>
        ///  
        /// <para>
        /// Pattern: <c>^[\\p{L}\\p{Z}\\p{N}\\p{P}]{0,2048}$</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 2048)]
        public string WorkspaceDescription { get; set; }

        /// <summary>
        /// Checks to see if the WorkspaceDescription property is set.
        /// </summary>
        internal bool IsSetWorkspaceDescription() => this.WorkspaceDescription != null;

        /// <summary>
        /// Gets and sets the property WorkspaceName. 
        /// <para>
        /// The name for the workspace. It does not have to be unique.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string WorkspaceName { get; set; }

        /// <summary>
        /// Checks to see if the WorkspaceName property is set.
        /// </summary>
        internal bool IsSetWorkspaceName() => this.WorkspaceName != null;

        /// <summary>
        /// Gets and sets the property WorkspaceNotificationDestinations. 
        /// <para>
        /// Specify the Amazon Web Services notification channels that you plan to use in this
        /// workspace. Specifying these data sources here enables Amazon Managed Grafana to create
        /// IAM roles and permissions that allow Amazon Managed Grafana to use these channels.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> WorkspaceNotificationDestinations { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the WorkspaceNotificationDestinations property is set.
        /// </summary>
        internal bool IsSetWorkspaceNotificationDestinations() => this.WorkspaceNotificationDestinations != null && (this.WorkspaceNotificationDestinations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WorkspaceOrganizationalUnits. 
        /// <para>
        /// Specifies the organizational units that this workspace is allowed to use data sources
        /// from, if this workspace is in an account that is part of an organization.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public List<string> WorkspaceOrganizationalUnits { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the WorkspaceOrganizationalUnits property is set.
        /// </summary>
        internal bool IsSetWorkspaceOrganizationalUnits() => this.WorkspaceOrganizationalUnits != null && (this.WorkspaceOrganizationalUnits.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WorkspaceRoleArn. 
        /// <para>
        /// Specified the IAM role that grants permissions to the Amazon Web Services resources
        /// that the workspace will view data from, including both data sources and notification
        /// channels. You are responsible for managing the permissions for this role as new data
        /// sources or notification channels are added. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 2048)]
        public string WorkspaceRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the WorkspaceRoleArn property is set.
        /// </summary>
        internal bool IsSetWorkspaceRoleArn() => this.WorkspaceRoleArn != null;
    }
}
