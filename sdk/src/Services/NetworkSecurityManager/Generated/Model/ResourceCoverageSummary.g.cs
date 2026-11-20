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

namespace Amazon.NetworkSecurityManager.Model
{
    /// <summary>
    /// Describes how an AWS Network Security Manager entity covers a protected resource.
    /// </summary>
    public partial class ResourceCoverageSummary
    {
        /// <summary>
        /// Gets and sets the property CoverageStatus. 
        /// <para>
        /// Specifies whether the entity contributes to the effective configuration of the resource
        /// for its firewall type. For firewall types that combine policies, such as AWS WAF and
        /// AWS Shield Advanced, every policy that covers the resource is <c>IN_EFFECT</c>. For
        /// firewall types that apply a single policy, only the highest-priority policy is <c>IN_EFFECT</c>
        /// and the others are <c>SUPERSEDED</c>.
        /// </para>
        /// </summary>
        public CoverageStatus CoverageStatus { get; set; }

        /// <summary>
        /// Checks to see if the CoverageStatus property is set.
        /// </summary>
        internal bool IsSetCoverageStatus() => this.CoverageStatus != null;

        /// <summary>
        /// Gets and sets the property DeploymentArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the deployments through which the entity covers
        /// the resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 100)]
        public List<string> DeploymentArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DeploymentArns property is set.
        /// </summary>
        internal bool IsSetDeploymentArns() => this.DeploymentArns != null && (this.DeploymentArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EntityArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the entity that covers the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 1010)]
        public string EntityArn { get; set; }

        /// <summary>
        /// Checks to see if the EntityArn property is set.
        /// </summary>
        internal bool IsSetEntityArn() => this.EntityArn != null;

        /// <summary>
        /// Gets and sets the property EntityType. 
        /// <para>
        /// The type of the entity that covers the resource, such as <c>Policy</c>.
        /// </para>
        /// </summary>
        public ServiceResourceType EntityType { get; set; }

        /// <summary>
        /// Checks to see if the EntityType property is set.
        /// </summary>
        internal bool IsSetEntityType() => this.EntityType != null;

        /// <summary>
        /// Gets and sets the property FirewallType. 
        /// <para>
        /// The firewall type of the policy that covers the resource. This is present when <c>entityType</c>
        /// is <c>Policy</c>.
        /// </para>
        /// </summary>
        public PolicyFirewallType FirewallType { get; set; }

        /// <summary>
        /// Checks to see if the FirewallType property is set.
        /// </summary>
        internal bool IsSetFirewallType() => this.FirewallType != null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the protected resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 1010)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property ResourceOwnerAccountId. 
        /// <para>
        /// The AWS account ID that owns the protected resource. This can differ from the account
        /// that owns the entity.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string ResourceOwnerAccountId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceOwnerAccountId property is set.
        /// </summary>
        internal bool IsSetResourceOwnerAccountId() => this.ResourceOwnerAccountId != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of the protected resource, in AWS CloudFormation format.
        /// </para>
        /// </summary>
        public ScopeResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The time when AWS Network Security Manager last evaluated the coverage.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
