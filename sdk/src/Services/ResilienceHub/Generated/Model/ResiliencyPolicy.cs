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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
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
        private DateTime? _creationTime;
        private DataLocationConstraint _dataLocationConstraint;
        private EstimatedCostTier _estimatedCostTier;
        private Dictionary<string, FailurePolicy> _policy = AWSConfigs.InitializeCollections ? new Dictionary<string, FailurePolicy>() : null;
        private string _policyArn;
        private string _policyDescription;
        private string _policyName;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private ResiliencyPolicyTier _tier;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// Date and time when the resiliency policy was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataLocationConstraint. 
        /// <para>
        /// Specifies a high-level geographical location constraint for where your resilience
        /// policy data can be stored.
        /// </para>
        /// </summary>
        public DataLocationConstraint DataLocationConstraint
        {
            get { return this._dataLocationConstraint; }
            set { this._dataLocationConstraint = value; }
        }

        // Check to see if DataLocationConstraint property is set
        internal bool IsSetDataLocationConstraint()
        {
            return this._dataLocationConstraint != null;
        }

        /// <summary>
        /// Gets and sets the property EstimatedCostTier. 
        /// <para>
        /// Specifies the estimated cost tier of the resiliency policy.
        /// </para>
        /// </summary>
        public EstimatedCostTier EstimatedCostTier
        {
            get { return this._estimatedCostTier; }
            set { this._estimatedCostTier = value; }
        }

        // Check to see if EstimatedCostTier property is set
        internal bool IsSetEstimatedCostTier()
        {
            return this._estimatedCostTier != null;
        }

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// The resiliency policy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, FailurePolicy> Policy
        {
            get { return this._policy; }
            set { this._policy = value; }
        }

        // Check to see if Policy property is set
        internal bool IsSetPolicy()
        {
            return this._policy != null && (this._policy.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PolicyArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the resiliency policy. The format for this ARN is: arn:<c>partition</c>:resiliencehub:<c>region</c>:<c>account</c>:resiliency-policy/<c>policy-id</c>.
        /// For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">
        /// Amazon Resource Names (ARNs)</a> in the <i>Amazon Web Services General Reference</i>
        /// guide.
        /// </para>
        /// </summary>
        public string PolicyArn
        {
            get { return this._policyArn; }
            set { this._policyArn = value; }
        }

        // Check to see if PolicyArn property is set
        internal bool IsSetPolicyArn()
        {
            return this._policyArn != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyDescription. 
        /// <para>
        /// Description of the resiliency policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public string PolicyDescription
        {
            get { return this._policyDescription; }
            set { this._policyDescription = value; }
        }

        // Check to see if PolicyDescription property is set
        internal bool IsSetPolicyDescription()
        {
            return this._policyDescription != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// The name of the policy
        /// </para>
        /// </summary>
        public string PolicyName
        {
            get { return this._policyName; }
            set { this._policyName = value; }
        }

        // Check to see if PolicyName property is set
        internal bool IsSetPolicyName()
        {
            return this._policyName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags assigned to the resource. A tag is a label that you assign to an Amazon Web Services
        /// resource. Each tag consists of a key/value pair.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tier. 
        /// <para>
        /// The tier for this resiliency policy, ranging from the highest severity (<c>MissionCritical</c>)
        /// to lowest (<c>NonCritical</c>).
        /// </para>
        /// </summary>
        public ResiliencyPolicyTier Tier
        {
            get { return this._tier; }
            set { this._tier = value; }
        }

        // Check to see if Tier property is set
        internal bool IsSetTier()
        {
            return this._tier != null;
        }

    }
}