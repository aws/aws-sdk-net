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
    /// Container for the parameters to the CreateDeployment operation. Creates a deployment.
    /// A deployment applies one or more policies to the accounts and resources selected by
    /// a scope. Use <c>isPublished</c> to create the deployment in published (<c>ACTIVE</c>)
    /// or draft (<c>DRAFT</c>) state. The response includes coverage information and any
    /// warnings about the deployment.
    /// </summary>
    public partial class CreateDeploymentRequest : AmazonNetworkSecurityManagerRequest
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
        public List<PolicyReference> AssociatedPolicyList { get; set; } = AWSConfigs.InitializeCollections ? new List<PolicyReference>() : null;

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
        public List<ScopeReference> AssociatedScopeList { get; set; } = AWSConfigs.InitializeCollections ? new List<ScopeReference>() : null;

        /// <summary>
        /// Checks to see if the AssociatedScopeList property is set.
        /// </summary>
        internal bool IsSetAssociatedScopeList() => this.AssociatedScopeList != null && (this.AssociatedScopeList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive token that you provide to ensure that the operation completes
        /// no more than one time. If you retry a request with the same client token and the same
        /// parameters, the service returns the result of the original successful request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DeploymentConfiguration. 
        /// <para>
        /// The configuration settings for the deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DeploymentConfiguration DeploymentConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentConfiguration property is set.
        /// </summary>
        internal bool IsSetDeploymentConfiguration() => this.DeploymentConfiguration != null;

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
        /// Gets and sets the property IsPublished. 
        /// <para>
        /// Specifies whether to publish the resource. When <c>true</c>, the resource is saved
        /// in published (<c>ACTIVE</c>) state. When <c>false</c>, it is saved as a draft (<c>DRAFT</c>).
        /// Default: <c>true</c>.
        /// </para>
        /// </summary>
        public bool? IsPublished { get; set; }

        /// <summary>
        /// Checks to see if the IsPublished property is set.
        /// </summary>
        internal bool IsSetIsPublished() => this.IsPublished.HasValue;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to add to the resource when it is created.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
