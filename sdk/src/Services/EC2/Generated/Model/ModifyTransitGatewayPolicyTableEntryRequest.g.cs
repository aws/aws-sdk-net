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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyTransitGatewayPolicyTableEntry operation.
    /// Modifies the specified transit gateway policy table entry.
    /// </summary>
    public partial class ModifyTransitGatewayPolicyTableEntryRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property PolicyRule. 
        /// <para>
        /// The updated matching criteria for the policy table entry. Unspecified fields retain
        /// their current values.
        /// </para>
        /// </summary>
        public TransitGatewayRequestPolicyRule PolicyRule { get; set; }

        /// <summary>
        /// Checks to see if the PolicyRule property is set.
        /// </summary>
        internal bool IsSetPolicyRule() => this.PolicyRule != null;

        /// <summary>
        /// Gets and sets the property PolicyRuleNumber. 
        /// <para>
        /// The rule number of the policy table entry to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PolicyRuleNumber { get; set; }

        /// <summary>
        /// Checks to see if the PolicyRuleNumber property is set.
        /// </summary>
        internal bool IsSetPolicyRuleNumber() => this.PolicyRuleNumber != null;

        /// <summary>
        /// Gets and sets the property TargetRouteTableId. 
        /// <para>
        /// The ID of the transit gateway route table to use for traffic matching this rule.
        /// </para>
        /// </summary>
        public string TargetRouteTableId { get; set; }

        /// <summary>
        /// Checks to see if the TargetRouteTableId property is set.
        /// </summary>
        internal bool IsSetTargetRouteTableId() => this.TargetRouteTableId != null;

        /// <summary>
        /// Gets and sets the property TransitGatewayPolicyTableId. 
        /// <para>
        /// The ID of the transit gateway policy table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TransitGatewayPolicyTableId { get; set; }

        /// <summary>
        /// Checks to see if the TransitGatewayPolicyTableId property is set.
        /// </summary>
        internal bool IsSetTransitGatewayPolicyTableId() => this.TransitGatewayPolicyTableId != null;
    }
}
