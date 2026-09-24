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
    /// A structure containing information about an Amazon Managed Grafana workspace in your
    /// account.
    /// </summary>
    public partial class WorkspaceDescription
    {
        /// <summary>
        /// Gets and sets the property AccountAccessType. 
        /// <para>
        /// Specifies whether the workspace can access Amazon Web Services resources in this Amazon
        /// Web Services account only, or whether it can also access Amazon Web Services resources
        /// in other accounts in the same organization. If this is <c>ORGANIZATION</c>, the <c>workspaceOrganizationalUnits</c>
        /// parameter specifies which organizational units the workspace can access.
        /// </para>
        /// </summary>
        public AccountAccessType AccountAccessType { get; set; }

        /// <summary>
        /// Checks to see if the AccountAccessType property is set.
        /// </summary>
        internal bool IsSetAccountAccessType() => this.AccountAccessType != null;

        /// <summary>
        /// Gets and sets the property Authentication. 
        /// <para>
        /// A structure that describes whether the workspace uses SAML, IAM Identity Center, or
        /// both methods for user authentication.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AuthenticationSummary Authentication { get; set; }

        /// <summary>
        /// Checks to see if the Authentication property is set.
        /// </summary>
        internal bool IsSetAuthentication() => this.Authentication != null;

        /// <summary>
        /// Gets and sets the property Created. 
        /// <para>
        /// The date that the workspace was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Checks to see if the Created property is set.
        /// </summary>
        internal bool IsSetCreated() => this.Created.HasValue;

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
        /// console, and the <c>permissionType</c> is <c>SERVICE_MANAGED</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> DataSources { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DataSources property is set.
        /// </summary>
        internal bool IsSetDataSources() => this.DataSources != null && (this.DataSources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DegradedWorkspaceReason. 
        /// <para>
        /// If the workspace is in the <c>DEGRADED</c> status, this field describes the reason
        /// the workspace is degraded.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string DegradedWorkspaceReason { get; set; }

        /// <summary>
        /// Checks to see if the DegradedWorkspaceReason property is set.
        /// </summary>
        internal bool IsSetDegradedWorkspaceReason() => this.DegradedWorkspaceReason != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The user-defined description of the workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The URL that users can use to access the Grafana console in the workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string Endpoint { get; set; }

        /// <summary>
        /// Checks to see if the Endpoint property is set.
        /// </summary>
        internal bool IsSetEndpoint() => this.Endpoint != null;

        /// <summary>
        /// Gets and sets the property FreeTrialConsumed. 
        /// <para>
        /// Specifies whether this workspace has already fully used its free trial for Grafana
        /// Enterprise.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Managed Grafana workspaces no longer support Grafana Enterprise free trials.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? FreeTrialConsumed { get; set; }

        /// <summary>
        /// Checks to see if the FreeTrialConsumed property is set.
        /// </summary>
        internal bool IsSetFreeTrialConsumed() => this.FreeTrialConsumed.HasValue;

        /// <summary>
        /// Gets and sets the property FreeTrialExpiration. 
        /// <para>
        /// If this workspace is currently in the free trial period for Grafana Enterprise, this
        /// value specifies when that free trial ends.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Managed Grafana workspaces no longer support Grafana Enterprise free trials.
        /// </para>
        ///  </note>
        /// </summary>
        public DateTime? FreeTrialExpiration { get; set; }

        /// <summary>
        /// Checks to see if the FreeTrialExpiration property is set.
        /// </summary>
        internal bool IsSetFreeTrialExpiration() => this.FreeTrialExpiration.HasValue;

        /// <summary>
        /// Gets and sets the property GrafanaToken. 
        /// <para>
        /// The token that ties this workspace to a Grafana Labs account. For more information,
        /// see <a href="https://docs.aws.amazon.com/grafana/latest/userguide/upgrade-to-Grafana-Enterprise.html#AMG-workspace-register-enterprise">Link
        /// your account with Grafana Labs</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 36)]
        public string GrafanaToken { get; set; }

        /// <summary>
        /// Checks to see if the GrafanaToken property is set.
        /// </summary>
        internal bool IsSetGrafanaToken() => this.GrafanaToken != null;

        /// <summary>
        /// Gets and sets the property GrafanaVersion. 
        /// <para>
        /// The version of Grafana supported in this workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string GrafanaVersion { get; set; }

        /// <summary>
        /// Checks to see if the GrafanaVersion property is set.
        /// </summary>
        internal bool IsSetGrafanaVersion() => this.GrafanaVersion != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique ID of this workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// The type of IP addresses supported for connection to the workspace. Valid values are
        /// <c>IPv4</c> and <c>DualStack</c>.
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
        /// The ID or ARN of the Key Management Service key used for encrypting workspace data.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property LicenseExpiration. 
        /// <para>
        /// If this workspace has a full Grafana Enterprise license purchased through Amazon Web
        /// Services Marketplace, this specifies when the license ends and will need to be renewed.
        /// Purchasing the Enterprise plugins option through Amazon Managed Grafana does not have
        /// an expiration. It is valid until the license is removed.
        /// </para>
        /// </summary>
        public DateTime? LicenseExpiration { get; set; }

        /// <summary>
        /// Checks to see if the LicenseExpiration property is set.
        /// </summary>
        internal bool IsSetLicenseExpiration() => this.LicenseExpiration.HasValue;

        /// <summary>
        /// Gets and sets the property LicenseType. 
        /// <para>
        /// Specifies whether this workspace has a full Grafana Enterprise license.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Managed Grafana workspaces no longer support Grafana Enterprise free trials.
        /// </para>
        ///  </note>
        /// </summary>
        public LicenseType LicenseType { get; set; }

        /// <summary>
        /// Checks to see if the LicenseType property is set.
        /// </summary>
        internal bool IsSetLicenseType() => this.LicenseType != null;

        /// <summary>
        /// Gets and sets the property Modified. 
        /// <para>
        /// The most recent date that the workspace was modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? Modified { get; set; }

        /// <summary>
        /// Checks to see if the Modified property is set.
        /// </summary>
        internal bool IsSetModified() => this.Modified.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NetworkAccessControl. 
        /// <para>
        /// The configuration settings for network access to your workspace.
        /// </para>
        /// </summary>
        public NetworkAccessConfiguration NetworkAccessControl { get; set; }

        /// <summary>
        /// Checks to see if the NetworkAccessControl property is set.
        /// </summary>
        internal bool IsSetNetworkAccessControl() => this.NetworkAccessControl != null;

        /// <summary>
        /// Gets and sets the property NotificationDestinations. 
        /// <para>
        /// The Amazon Web Services notification channels that Amazon Managed Grafana can automatically
        /// create IAM roles and permissions for, to allow Amazon Managed Grafana to use these
        /// channels.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> NotificationDestinations { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the NotificationDestinations property is set.
        /// </summary>
        internal bool IsSetNotificationDestinations() => this.NotificationDestinations != null && (this.NotificationDestinations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OrganizationRoleName. 
        /// <para>
        /// The name of the IAM role that is used to access resources through Organizations.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 2048)]
        public string OrganizationRoleName { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationRoleName property is set.
        /// </summary>
        internal bool IsSetOrganizationRoleName() => this.OrganizationRoleName != null;

        /// <summary>
        /// Gets and sets the property OrganizationalUnits. 
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
        public List<string> OrganizationalUnits { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the OrganizationalUnits property is set.
        /// </summary>
        internal bool IsSetOrganizationalUnits() => this.OrganizationalUnits != null && (this.OrganizationalUnits.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PermissionType. 
        /// <para>
        /// If this is <c>SERVICE_MANAGED</c>, and the workplace was created through the Amazon
        /// Managed Grafana console, then Amazon Managed Grafana automatically creates the IAM
        /// roles and provisions the permissions that the workspace needs to use Amazon Web Services
        /// data sources and notification channels.
        /// </para>
        ///  
        /// <para>
        /// If this is <c>CUSTOMER_MANAGED</c>, you must manage those roles and permissions yourself.
        /// </para>
        ///  
        /// <para>
        /// If you are working with a workspace in a member account of an organization and that
        /// account is not a delegated administrator account, and you want the workspace to access
        /// data sources in other Amazon Web Services accounts in the organization, this parameter
        /// must be set to <c>CUSTOMER_MANAGED</c>.
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
        public PermissionType PermissionType { get; set; }

        /// <summary>
        /// Checks to see if the PermissionType property is set.
        /// </summary>
        internal bool IsSetPermissionType() => this.PermissionType != null;

        /// <summary>
        /// Gets and sets the property StackSetName. 
        /// <para>
        /// The name of the CloudFormation stack set that is used to generate IAM roles to be
        /// used for this workspace.
        /// </para>
        /// </summary>
        public string StackSetName { get; set; }

        /// <summary>
        /// Checks to see if the StackSetName property is set.
        /// </summary>
        internal bool IsSetStackSetName() => this.StackSetName != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the workspace.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public WorkspaceStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

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
        /// The configuration for connecting to data sources in a private VPC (Amazon Virtual
        /// Private Cloud).
        /// </para>
        /// </summary>
        public VpcConfiguration VpcConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfiguration property is set.
        /// </summary>
        internal bool IsSetVpcConfiguration() => this.VpcConfiguration != null;

        /// <summary>
        /// Gets and sets the property WorkspaceRoleArn. 
        /// <para>
        /// The IAM role that grants permissions to the Amazon Web Services resources that the
        /// workspace will view data from. This role must already exist.
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
