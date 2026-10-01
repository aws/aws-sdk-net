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

namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// Defines a resiliency policy.
    /// 
    ///  <note> 
    /// <para>
    /// Resilience Hub allows you to provide a value of zero for <c>rtoInSecs</c> and <c>rpoInSecs</c>
    /// of your resiliency policy. But, while assessing your application, the lowest possible
    /// assessment result is near zero. Hence, if you provide value zero for <c>rtoInSecs</c>
    /// and <c>rpoInSecs</c>, the estimated workload RTO and estimated workload RPO result
    /// will be near zero and the <b>Compliance status</b> for your application will be set
    /// to <b>Policy breached</b>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ResiliencyPolicy
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// Date and time when the resiliency policy was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DataLocationConstraint. 
        /// <para>
        /// Specifies a high-level geographical location constraint for where your resilience
        /// policy data can be stored.
        /// </para>
        /// </summary>
        public DataLocationConstraint DataLocationConstraint { get; set; }

        /// <summary>
        /// Checks to see if the DataLocationConstraint property is set.
        /// </summary>
        internal bool IsSetDataLocationConstraint() => this.DataLocationConstraint != null;

        /// <summary>
        /// Gets and sets the property EstimatedCostTier. 
        /// <para>
        /// Specifies the estimated cost tier of the resiliency policy.
        /// </para>
        /// </summary>
        public EstimatedCostTier EstimatedCostTier { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedCostTier property is set.
        /// </summary>
        internal bool IsSetEstimatedCostTier() => this.EstimatedCostTier != null;

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// The resiliency policy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, FailurePolicy> Policy { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, FailurePolicy>() : null;

        /// <summary>
        /// Checks to see if the Policy property is set.
        /// </summary>
        internal bool IsSetPolicy() => this.Policy != null && (this.Policy.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PolicyArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the resiliency policy. The format for this ARN is: arn:<c>partition</c>:resiliencehub:<c>region</c>:<c>account</c>:resiliency-policy/<c>policy-id</c>.
        /// For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">
        /// Amazon Resource Names (ARNs)</a> in the <i>Amazon Web Services General Reference</i>
        /// guide.
        /// </para>
        /// </summary>
        public string PolicyArn { get; set; }

        /// <summary>
        /// Checks to see if the PolicyArn property is set.
        /// </summary>
        internal bool IsSetPolicyArn() => this.PolicyArn != null;

        /// <summary>
        /// Gets and sets the property PolicyDescription. 
        /// <para>
        /// Description of the resiliency policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public string PolicyDescription { get; set; }

        /// <summary>
        /// Checks to see if the PolicyDescription property is set.
        /// </summary>
        internal bool IsSetPolicyDescription() => this.PolicyDescription != null;

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// The name of the policy
        /// </para>
        /// </summary>
        public string PolicyName { get; set; }

        /// <summary>
        /// Checks to see if the PolicyName property is set.
        /// </summary>
        internal bool IsSetPolicyName() => this.PolicyName != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags assigned to the resource. A tag is a label that you assign to an Amazon Web Services
        /// resource. Each tag consists of a key/value pair.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tier. 
        /// <para>
        /// The tier for this resiliency policy, ranging from the highest severity (<c>MissionCritical</c>)
        /// to lowest (<c>NonCritical</c>).
        /// </para>
        /// </summary>
        public ResiliencyPolicyTier Tier { get; set; }

        /// <summary>
        /// Checks to see if the Tier property is set.
        /// </summary>
        internal bool IsSetTier() => this.Tier != null;
    }
}
