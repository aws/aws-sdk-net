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
    /// Container for the parameters to the UpdateWorkspace operation. Modifies an existing
    /// Amazon Managed Grafana workspace. If you use this operation and omit any optional
    /// parameters, the existing values of those parameters are not changed. <para> To modify
    /// the user authentication methods that the workspace uses, such as SAML or IAM Identity
    /// Center, use <a href="https://docs.aws.amazon.com/grafana/latest/APIReference/API_UpdateWorkspaceAuthentication.html">UpdateWorkspaceAuthentication</a>.
    /// </para> <para> To modify which users in the workspace have the <c>Admin</c> and <c>Editor</c>
    /// Grafana roles, use <a href="https://docs.aws.amazon.com/grafana/latest/APIReference/API_UpdatePermissions.html">UpdatePermissions</a>.
    /// </para>
    /// </summary>
    public partial class UpdateWorkspaceRequest : AmazonManagedGrafanaRequest
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
        public AccountAccessType AccountAccessType { get; set; }

        /// <summary>
        /// Checks to see if the AccountAccessType property is set.
        /// </summary>
        internal bool IsSetAccountAccessType() => this.AccountAccessType != null;

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
        public NetworkAccessConfiguration NetworkAccessControl { get; set; }

        /// <summary>
        /// Checks to see if the NetworkAccessControl property is set.
        /// </summary>
        internal bool IsSetNetworkAccessControl() => this.NetworkAccessControl != null;

        /// <summary>
        /// Gets and sets the property OrganizationRoleName. 
        /// <para>
        /// The name of an IAM role that already exists to use to access resources through Organizations.
        /// This can only be used with a workspace that has the <c>permissionType</c> set to <c>CUSTOMER_MANAGED</c>.
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
        /// Use this parameter if you want to change a workspace from <c>SERVICE_MANAGED</c> to
        /// <c>CUSTOMER_MANAGED</c>. This allows you to manage the permissions that the workspace
        /// uses to access datasources and notification channels. If the workspace is in a member
        /// Amazon Web Services account of an organization, and that account is not a delegated
        /// administrator account, and you want the workspace to access data sources in other
        /// Amazon Web Services accounts in the organization, you must choose <c>CUSTOMER_MANAGED</c>.
        /// </para>
        ///  
        /// <para>
        /// If you specify this as <c>CUSTOMER_MANAGED</c>, you must also specify a <c>workspaceRoleArn</c>
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
        /// Do not use this to convert a <c>CUSTOMER_MANAGED</c> workspace to <c>SERVICE_MANAGED</c>.
        /// Do not include this parameter if you want to leave the workspace as <c>SERVICE_MANAGED</c>.
        /// </para>
        ///  
        /// <para>
        /// You can convert a <c>CUSTOMER_MANAGED</c> workspace to <c>SERVICE_MANAGED</c> using
        /// the Amazon Managed Grafana console. For more information, see <a href="https://docs.aws.amazon.com/grafana/latest/userguide/AMG-datasource-and-notification.html">Managing
        /// permissions for data sources and notification channels</a>.
        /// </para>
        ///  </note>
        /// </summary>
        public PermissionType PermissionType { get; set; }

        /// <summary>
        /// Checks to see if the PermissionType property is set.
        /// </summary>
        internal bool IsSetPermissionType() => this.PermissionType != null;

        /// <summary>
        /// Gets and sets the property RemoveNetworkAccessConfiguration. 
        /// <para>
        /// Whether to remove the network access configuration from the workspace.
        /// </para>
        ///  
        /// <para>
        /// Setting this to <c>true</c> and providing a <c>networkAccessControl</c> to set will
        /// return an error.
        /// </para>
        ///  
        /// <para>
        /// If you remove this configuration by setting this to <c>true</c>, then all IP addresses
        /// and VPC endpoints will be allowed. Standard Grafana authentication and authorization
        /// will still be required.
        /// </para>
        /// </summary>
        public bool? RemoveNetworkAccessConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the RemoveNetworkAccessConfiguration property is set.
        /// </summary>
        internal bool IsSetRemoveNetworkAccessConfiguration() => this.RemoveNetworkAccessConfiguration.HasValue;

        /// <summary>
        /// Gets and sets the property RemoveVpcConfiguration. 
        /// <para>
        /// Whether to remove the VPC configuration from the workspace.
        /// </para>
        ///  
        /// <para>
        /// Setting this to <c>true</c> and providing a <c>vpcConfiguration</c> to set will return
        /// an error.
        /// </para>
        /// </summary>
        public bool? RemoveVpcConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the RemoveVpcConfiguration property is set.
        /// </summary>
        internal bool IsSetRemoveVpcConfiguration() => this.RemoveVpcConfiguration.HasValue;

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
        /// Gets and sets the property VpcConfiguration. 
        /// <para>
        /// The configuration settings for an Amazon VPC that contains data sources for your Grafana
        /// workspace to connect to.
        /// </para>
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
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 2048)]
        public string WorkspaceDescription { get; set; }

        /// <summary>
        /// Checks to see if the WorkspaceDescription property is set.
        /// </summary>
        internal bool IsSetWorkspaceDescription() => this.WorkspaceDescription != null;

        /// <summary>
        /// Gets and sets the property WorkspaceId. 
        /// <para>
        /// The ID of the workspace to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// Checks to see if the WorkspaceId property is set.
        /// </summary>
        internal bool IsSetWorkspaceId() => this.WorkspaceId != null;

        /// <summary>
        /// Gets and sets the property WorkspaceName. 
        /// <para>
        /// A new name for the workspace to update.
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
        /// Specifies an IAM role that grants permissions to Amazon Web Services resources that
        /// the workspace accesses, such as data sources and notification channels. If this workspace
        /// has <c>permissionType</c> <c>CUSTOMER_MANAGED</c>, then this role is required.
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
