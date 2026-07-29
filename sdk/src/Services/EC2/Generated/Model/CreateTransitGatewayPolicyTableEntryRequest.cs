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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
    /// Container for the parameters to the CreateTransitGatewayPolicyTableEntry operation.
    /// Creates an entry in a transit gateway policy table to route matching traffic to a
    /// specified route table.
    /// </summary>
    public partial class CreateTransitGatewayPolicyTableEntryRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private TransitGatewayRequestPolicyRule _policyRule;
        private string _policyRuleNumber;
        private string _targetRouteTableId;
        private string _transitGatewayPolicyTableId;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PolicyRule. 
        /// <para>
        /// The matching criteria for the policy table entry.
        /// </para>
        /// </summary>
        public TransitGatewayRequestPolicyRule PolicyRule
        {
            get { return this._policyRule; }
            set { this._policyRule = value; }
        }

        // Check to see if PolicyRule property is set
        internal bool IsSetPolicyRule()
        {
            return this._policyRule != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyRuleNumber. 
        /// <para>
        /// The rule number for the policy table entry. Lower rule numbers are evaluated first
        /// and take precedence.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PolicyRuleNumber
        {
            get { return this._policyRuleNumber; }
            set { this._policyRuleNumber = value; }
        }

        // Check to see if PolicyRuleNumber property is set
        internal bool IsSetPolicyRuleNumber()
        {
            return this._policyRuleNumber != null;
        }

        /// <summary>
        /// Gets and sets the property TargetRouteTableId. 
        /// <para>
        /// The ID of the transit gateway route table to use for traffic matching this rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TargetRouteTableId
        {
            get { return this._targetRouteTableId; }
            set { this._targetRouteTableId = value; }
        }

        // Check to see if TargetRouteTableId property is set
        internal bool IsSetTargetRouteTableId()
        {
            return this._targetRouteTableId != null;
        }

        /// <summary>
        /// Gets and sets the property TransitGatewayPolicyTableId. 
        /// <para>
        /// The ID of the transit gateway policy table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TransitGatewayPolicyTableId
        {
            get { return this._transitGatewayPolicyTableId; }
            set { this._transitGatewayPolicyTableId = value; }
        }

        // Check to see if TransitGatewayPolicyTableId property is set
        internal bool IsSetTransitGatewayPolicyTableId()
        {
            return this._transitGatewayPolicyTableId != null;
        }

    }
}