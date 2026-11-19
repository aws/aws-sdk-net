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
    /// Describes a transit gateway policy table entry
    /// </summary>
    public partial class TransitGatewayPolicyTableEntry
    {
        /// <summary>
        /// Gets and sets the property PolicyRule. 
        /// <para>
        /// The policy rule associated with the transit gateway policy table.
        /// </para>
        /// </summary>
        public TransitGatewayPolicyRule PolicyRule { get; set; }

        /// <summary>
        /// Checks to see if the PolicyRule property is set.
        /// </summary>
        internal bool IsSetPolicyRule() => this.PolicyRule != null;

        /// <summary>
        /// Gets and sets the property PolicyRuleNumber. 
        /// <para>
        /// The rule number for the transit gateway policy table entry.
        /// </para>
        /// </summary>
        public string PolicyRuleNumber { get; set; }

        /// <summary>
        /// Checks to see if the PolicyRuleNumber property is set.
        /// </summary>
        internal bool IsSetPolicyRuleNumber() => this.PolicyRuleNumber != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the transit gateway policy table entry.
        /// </para>
        /// </summary>
        public TransitGatewayPolicyTableEntryState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property TargetRouteTableId. 
        /// <para>
        /// The ID of the target route table.
        /// </para>
        /// </summary>
        public string TargetRouteTableId { get; set; }

        /// <summary>
        /// Checks to see if the TargetRouteTableId property is set.
        /// </summary>
        internal bool IsSetTargetRouteTableId() => this.TargetRouteTableId != null;
    }
}
