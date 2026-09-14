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

namespace Amazon.ObservabilityAdmin.Model
{
    /// <summary>
    /// This is the response object from the GetCentralizationRuleForOrganization operation.
    /// </summary>
    public partial class GetCentralizationRuleForOrganizationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CentralizationRule. 
        /// <para>
        /// The configuration details for the organization centralization rule.
        /// </para>
        /// </summary>
        public CentralizationRule CentralizationRule { get; set; }

        /// <summary>
        /// Checks to see if the CentralizationRule property is set.
        /// </summary>
        internal bool IsSetCentralizationRule() => this.CentralizationRule != null;

        /// <summary>
        /// Gets and sets the property CreatedRegion. 
        /// <para>
        /// The Amazon Web Services region where the organization centralization rule was created.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string CreatedRegion { get; set; }

        /// <summary>
        /// Checks to see if the CreatedRegion property is set.
        /// </summary>
        internal bool IsSetCreatedRegion() => this.CreatedRegion != null;

        /// <summary>
        /// Gets and sets the property CreatedTimeStamp. 
        /// <para>
        /// The timestamp when the organization centralization rule was created.
        /// </para>
        /// </summary>
        public long? CreatedTimeStamp { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTimeStamp property is set.
        /// </summary>
        internal bool IsSetCreatedTimeStamp() => this.CreatedTimeStamp.HasValue;

        /// <summary>
        /// Gets and sets the property CreatorAccountId. 
        /// <para>
        /// The Amazon Web Services Account that created the organization centralization rule.
        /// </para>
        /// </summary>
        public string CreatorAccountId { get; set; }

        /// <summary>
        /// Checks to see if the CreatorAccountId property is set.
        /// </summary>
        internal bool IsSetCreatorAccountId() => this.CreatorAccountId != null;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason why an organization centralization rule is marked UNHEALTHY.
        /// </para>
        /// </summary>
        public CentralizationFailureReason FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property LastUpdateTimeStamp. 
        /// <para>
        /// The timestamp when the organization centralization rule was last updated.
        /// </para>
        /// </summary>
        public long? LastUpdateTimeStamp { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdateTimeStamp property is set.
        /// </summary>
        internal bool IsSetLastUpdateTimeStamp() => this.LastUpdateTimeStamp.HasValue;

        /// <summary>
        /// Gets and sets the property RuleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the organization centralization rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1011)]
        public string RuleArn { get; set; }

        /// <summary>
        /// Checks to see if the RuleArn property is set.
        /// </summary>
        internal bool IsSetRuleArn() => this.RuleArn != null;

        /// <summary>
        /// Gets and sets the property RuleHealth. 
        /// <para>
        /// The health status of the organization centralization rule.
        /// </para>
        /// </summary>
        public RuleHealth RuleHealth { get; set; }

        /// <summary>
        /// Checks to see if the RuleHealth property is set.
        /// </summary>
        internal bool IsSetRuleHealth() => this.RuleHealth != null;

        /// <summary>
        /// Gets and sets the property RuleName. 
        /// <para>
        /// The name of the organization centralization rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string RuleName { get; set; }

        /// <summary>
        /// Checks to see if the RuleName property is set.
        /// </summary>
        internal bool IsSetRuleName() => this.RuleName != null;

        /// <summary>
        /// Gets and sets the property TagPropagationFailureReason. 
        /// <para>
        /// The reason tag propagation is unhealthy for this rule. Only present when <c>TagPropagationStatus</c>
        /// is <c>Unhealthy</c>.
        /// </para>
        /// </summary>
        public TagPropagationFailureReason TagPropagationFailureReason { get; set; }

        /// <summary>
        /// Checks to see if the TagPropagationFailureReason property is set.
        /// </summary>
        internal bool IsSetTagPropagationFailureReason() => this.TagPropagationFailureReason != null;

        /// <summary>
        /// Gets and sets the property TagPropagationStatus. 
        /// <para>
        /// The health status of tag propagation for this rule. This status is independent of
        /// the overall <c>RuleHealth</c> for log delivery. Returns <c>Healthy</c> when the most
        /// recent tag-propagation attempt succeeded, or <c>Unhealthy</c> when the most recent
        /// attempt failed.
        /// </para>
        /// </summary>
        public TagPropagationStatus TagPropagationStatus { get; set; }

        /// <summary>
        /// Checks to see if the TagPropagationStatus property is set.
        /// </summary>
        internal bool IsSetTagPropagationStatus() => this.TagPropagationStatus != null;
    }
}
