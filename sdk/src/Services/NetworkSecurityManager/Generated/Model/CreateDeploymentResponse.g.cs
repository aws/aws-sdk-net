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
    /// This is the response object from the CreateDeployment operation.
    /// </summary>
    public partial class CreateDeploymentResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AssociatedPolicyList. 
        /// <para>
        /// The policies associated with the deployment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2)]
        public List<AssociatedPolicy> AssociatedPolicyList { get; set; } = AWSConfigs.InitializeCollections ? new List<AssociatedPolicy>() : null;

        /// <summary>
        /// Checks to see if the AssociatedPolicyList property is set.
        /// </summary>
        internal bool IsSetAssociatedPolicyList() => this.AssociatedPolicyList != null && (this.AssociatedPolicyList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AssociatedScopeList. 
        /// <para>
        /// The scope associated with the deployment. A deployment has exactly one scope.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1)]
        public List<AssociatedScope> AssociatedScopeList { get; set; } = AWSConfigs.InitializeCollections ? new List<AssociatedScope>() : null;

        /// <summary>
        /// Checks to see if the AssociatedScopeList property is set.
        /// </summary>
        internal bool IsSetAssociatedScopeList() => this.AssociatedScopeList != null && (this.AssociatedScopeList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DeploymentArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 1010)]
        public string DeploymentArn { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentArn property is set.
        /// </summary>
        internal bool IsSetDeploymentArn() => this.DeploymentArn != null;

        /// <summary>
        /// Gets and sets the property DeploymentConfiguration. 
        /// <para>
        /// The configuration settings for the deployment.
        /// </para>
        /// </summary>
        public DeploymentConfiguration DeploymentConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentConfiguration property is set.
        /// </summary>
        internal bool IsSetDeploymentConfiguration() => this.DeploymentConfiguration != null;

        /// <summary>
        /// Gets and sets the property DeploymentCoverage. 
        /// <para>
        /// The coverage information for the deployment. For each firewall type, it shows which
        /// policies have that firewall type and which in-scope resource types the firewall type
        /// protects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10)]
        public List<DeploymentCoverageEntry> DeploymentCoverage { get; set; } = AWSConfigs.InitializeCollections ? new List<DeploymentCoverageEntry>() : null;

        /// <summary>
        /// Checks to see if the DeploymentCoverage property is set.
        /// </summary>
        internal bool IsSetDeploymentCoverage() => this.DeploymentCoverage != null && (this.DeploymentCoverage.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DeploymentDescription. 
        /// <para>
        /// A description of the deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 256)]
        public string DeploymentDescription { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentDescription property is set.
        /// </summary>
        internal bool IsSetDeploymentDescription() => this.DeploymentDescription != null;

        /// <summary>
        /// Gets and sets the property DeploymentId. 
        /// <para>
        /// The service-generated id of the deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string DeploymentId { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentId property is set.
        /// </summary>
        internal bool IsSetDeploymentId() => this.DeploymentId != null;

        /// <summary>
        /// Gets and sets the property DeploymentName. 
        /// <para>
        /// The name of the deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string DeploymentName { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentName property is set.
        /// </summary>
        internal bool IsSetDeploymentName() => this.DeploymentName != null;

        /// <summary>
        /// Gets and sets the property HasPublishedVersion. 
        /// <para>
        /// Specifies whether a published version of the resource exists.
        /// </para>
        /// </summary>
        public bool? HasPublishedVersion { get; set; }

        /// <summary>
        /// Checks to see if the HasPublishedVersion property is set.
        /// </summary>
        internal bool IsSetHasPublishedVersion() => this.HasPublishedVersion.HasValue;

        /// <summary>
        /// Gets and sets the property IsSnapshot. 
        /// <para>
        /// Specifies whether the resource is a snapshot of a published version.
        /// </para>
        /// </summary>
        public bool? IsSnapshot { get; set; }

        /// <summary>
        /// Checks to see if the IsSnapshot property is set.
        /// </summary>
        internal bool IsSetIsSnapshot() => this.IsSnapshot.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the resource: <c>DRAFT</c> (unpublished, editable) or <c>ACTIVE</c>
        /// (published, in use).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EntityStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdateToken. 
        /// <para>
        /// A token used for optimistic concurrency control. Each read and write returns an <c>updateToken</c>.
        /// Provide the most recent value on your next update to detect and prevent conflicting
        /// concurrent modifications.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string UpdateToken { get; set; }

        /// <summary>
        /// Checks to see if the UpdateToken property is set.
        /// </summary>
        internal bool IsSetUpdateToken() => this.UpdateToken != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The time when the resource was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;

        /// <summary>
        /// Gets and sets the property Warnings. 
        /// <para>
        /// Warnings about potential issues, such as a policy that has no applicable resources
        /// in the deployment's scope.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 100)]
        public List<DeploymentWarningEntry> Warnings { get; set; } = AWSConfigs.InitializeCollections ? new List<DeploymentWarningEntry>() : null;

        /// <summary>
        /// Checks to see if the Warnings property is set.
        /// </summary>
        internal bool IsSetWarnings() => this.Warnings != null && (this.Warnings.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
