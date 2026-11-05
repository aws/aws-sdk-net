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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Details for an Amazon EMR Studio including ID, creation time, name, and so on.
    /// </summary>
    public partial class Studio
    {
        /// <summary>
        /// Gets and sets the property AuthMode. 
        /// <para>
        /// Specifies whether the Amazon EMR Studio authenticates users with IAM or IAM Identity
        /// Center.
        /// </para>
        /// </summary>
        public AuthMode AuthMode { get; set; }

        /// <summary>
        /// Checks to see if the AuthMode property is set.
        /// </summary>
        internal bool IsSetAuthMode() => this.AuthMode != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time the Amazon EMR Studio was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DefaultS3Location. 
        /// <para>
        /// The Amazon S3 location to back up Amazon EMR Studio Workspaces and notebook files.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10280)]
        public string DefaultS3Location { get; set; }

        /// <summary>
        /// Checks to see if the DefaultS3Location property is set.
        /// </summary>
        internal bool IsSetDefaultS3Location() => this.DefaultS3Location != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The detailed description of the Amazon EMR Studio.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EncryptionKeyArn. 
        /// <para>
        /// The KMS key identifier (ARN) used to encrypt Amazon EMR Studio workspace and notebook
        /// files when backed up to Amazon S3.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10280)]
        public string EncryptionKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionKeyArn property is set.
        /// </summary>
        internal bool IsSetEncryptionKeyArn() => this.EncryptionKeyArn != null;

        /// <summary>
        /// Gets and sets the property EngineSecurityGroupId. 
        /// <para>
        /// The ID of the Engine security group associated with the Amazon EMR Studio. The Engine
        /// security group allows inbound network traffic from resources in the Workspace security
        /// group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string EngineSecurityGroupId { get; set; }

        /// <summary>
        /// Checks to see if the EngineSecurityGroupId property is set.
        /// </summary>
        internal bool IsSetEngineSecurityGroupId() => this.EngineSecurityGroupId != null;

        /// <summary>
        /// Gets and sets the property IdcInstanceArn. 
        /// <para>
        ///  The ARN of the IAM Identity Center instance the Studio application belongs to. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string IdcInstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the IdcInstanceArn property is set.
        /// </summary>
        internal bool IsSetIdcInstanceArn() => this.IdcInstanceArn != null;

        /// <summary>
        /// Gets and sets the property IdcUserAssignment. 
        /// <para>
        ///  Indicates whether the Studio has <c>REQUIRED</c> or <c>OPTIONAL</c> IAM Identity
        /// Center user assignment. If the value is set to <c>REQUIRED</c>, users must be explicitly
        /// assigned to the Studio application to access the Studio. 
        /// </para>
        /// </summary>
        public IdcUserAssignment IdcUserAssignment { get; set; }

        /// <summary>
        /// Checks to see if the IdcUserAssignment property is set.
        /// </summary>
        internal bool IsSetIdcUserAssignment() => this.IdcUserAssignment != null;

        /// <summary>
        /// Gets and sets the property IdpAuthUrl. 
        /// <para>
        /// Your identity provider's authentication endpoint. Amazon EMR Studio redirects federated
        /// users to this endpoint for authentication when logging in to a Studio with the Studio
        /// URL.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10280)]
        public string IdpAuthUrl { get; set; }

        /// <summary>
        /// Checks to see if the IdpAuthUrl property is set.
        /// </summary>
        internal bool IsSetIdpAuthUrl() => this.IdpAuthUrl != null;

        /// <summary>
        /// Gets and sets the property IdpRelayStateParameterName. 
        /// <para>
        /// The name of your identity provider's <c>RelayState</c> parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string IdpRelayStateParameterName { get; set; }

        /// <summary>
        /// Checks to see if the IdpRelayStateParameterName property is set.
        /// </summary>
        internal bool IsSetIdpRelayStateParameterName() => this.IdpRelayStateParameterName != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the Amazon EMR Studio.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ServiceRole. 
        /// <para>
        /// The name of the IAM role assumed by the Amazon EMR Studio.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10280)]
        public string ServiceRole { get; set; }

        /// <summary>
        /// Checks to see if the ServiceRole property is set.
        /// </summary>
        internal bool IsSetServiceRole() => this.ServiceRole != null;

        /// <summary>
        /// Gets and sets the property StudioArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon EMR Studio.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string StudioArn { get; set; }

        /// <summary>
        /// Checks to see if the StudioArn property is set.
        /// </summary>
        internal bool IsSetStudioArn() => this.StudioArn != null;

        /// <summary>
        /// Gets and sets the property StudioId. 
        /// <para>
        /// The ID of the Amazon EMR Studio.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string StudioId { get; set; }

        /// <summary>
        /// Checks to see if the StudioId property is set.
        /// </summary>
        internal bool IsSetStudioId() => this.StudioId != null;

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// The list of IDs of the subnets associated with the Amazon EMR Studio.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SubnetIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SubnetIds property is set.
        /// </summary>
        internal bool IsSetSubnetIds() => this.SubnetIds != null && (this.SubnetIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags associated with the Amazon EMR Studio.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TrustedIdentityPropagationEnabled. 
        /// <para>
        ///  Indicates whether the Studio has Trusted identity propagation enabled. The default
        /// value is <c>false</c>. 
        /// </para>
        /// </summary>
        public bool? TrustedIdentityPropagationEnabled { get; set; }

        /// <summary>
        /// Checks to see if the TrustedIdentityPropagationEnabled property is set.
        /// </summary>
        internal bool IsSetTrustedIdentityPropagationEnabled() => this.TrustedIdentityPropagationEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The unique access URL of the Amazon EMR Studio.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10280)]
        public string Url { get; set; }

        /// <summary>
        /// Checks to see if the Url property is set.
        /// </summary>
        internal bool IsSetUrl() => this.Url != null;

        /// <summary>
        /// Gets and sets the property UserRole. 
        /// <para>
        /// The name of the IAM role assumed by users logged in to the Amazon EMR Studio. A Studio
        /// only requires a <c>UserRole</c> when you use IAM authentication.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10280)]
        public string UserRole { get; set; }

        /// <summary>
        /// Checks to see if the UserRole property is set.
        /// </summary>
        internal bool IsSetUserRole() => this.UserRole != null;

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC associated with the Amazon EMR Studio.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;

        /// <summary>
        /// Gets and sets the property WorkspaceSecurityGroupId. 
        /// <para>
        /// The ID of the Workspace security group associated with the Amazon EMR Studio. The
        /// Workspace security group allows outbound network traffic to resources in the Engine
        /// security group and to the internet.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string WorkspaceSecurityGroupId { get; set; }

        /// <summary>
        /// Checks to see if the WorkspaceSecurityGroupId property is set.
        /// </summary>
        internal bool IsSetWorkspaceSecurityGroupId() => this.WorkspaceSecurityGroupId != null;
    }
}
