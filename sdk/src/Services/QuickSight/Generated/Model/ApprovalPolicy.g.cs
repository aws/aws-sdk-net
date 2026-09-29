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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A governance approval policy that specifies which principals and governed actions
    /// require approval, and which assets the policy applies to.
    /// </summary>
    public partial class ApprovalPolicy
    {
        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// The list of governed actions that trigger the approval workflow.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public List<string> Actions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Actions property is set.
        /// </summary>
        internal bool IsSetActions() => this.Actions != null && (this.Actions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ApplicableTo. 
        /// <para>
        /// The scoping configuration that determines who the approval policy applies to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ApplicableTo ApplicableTo { get; set; }

        /// <summary>
        /// Checks to see if the ApplicableTo property is set.
        /// </summary>
        internal bool IsSetApplicableTo() => this.ApplicableTo != null;

        /// <summary>
        /// Gets and sets the property ApprovalGroups. 
        /// <para>
        /// The list of group ARNs whose members can approve requests.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public List<string> ApprovalGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ApprovalGroups property is set.
        /// </summary>
        internal bool IsSetApprovalGroups() => this.ApprovalGroups != null && (this.ApprovalGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AssetTypes. 
        /// <para>
        /// The list of asset types that the approval policy applies to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public List<string> AssetTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AssetTypes property is set.
        /// </summary>
        internal bool IsSetAssetTypes() => this.AssetTypes != null && (this.AssetTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time that the approval policy was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the approval policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the approval policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PolicyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the approval policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PolicyArn { get; set; }

        /// <summary>
        /// Checks to see if the PolicyArn property is set.
        /// </summary>
        internal bool IsSetPolicyArn() => this.PolicyArn != null;

        /// <summary>
        /// Gets and sets the property PolicyId. 
        /// <para>
        /// The unique identifier of the approval policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string PolicyId { get; set; }

        /// <summary>
        /// Checks to see if the PolicyId property is set.
        /// </summary>
        internal bool IsSetPolicyId() => this.PolicyId != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time that the approval policy was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
