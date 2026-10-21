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
    /// Describes an entry in a transit gateway policy table.
    /// </summary>
    public partial class AnalysisTransitGatewayPolicyTableEntry
    {
        private string _destinationCidr;
        private PortRange _destinationPortRange;
        private string _protocol;
        private int? _ruleNumber;
        private string _sourceCidr;
        private PortRange _sourcePortRange;
        private string _targetRouteTableId;

        /// <summary>
        /// Gets and sets the property DestinationCidr. 
        /// <para>
        /// The destination CIDR block. If this value is not present, the entry matches any destination
        /// address.
        /// </para>
        /// </summary>
        public string DestinationCidr
        {
            get { return this._destinationCidr; }
            set { this._destinationCidr = value; }
        }

        // Check to see if DestinationCidr property is set
        internal bool IsSetDestinationCidr()
        {
            return this._destinationCidr != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationPortRange. 
        /// <para>
        /// The destination port range. If this value is not present, the entry matches any destination
        /// port.
        /// </para>
        /// </summary>
        public PortRange DestinationPortRange
        {
            get { return this._destinationPortRange; }
            set { this._destinationPortRange = value; }
        }

        // Check to see if DestinationPortRange property is set
        internal bool IsSetDestinationPortRange()
        {
            return this._destinationPortRange != null;
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol number. A value of <c>-1</c> means that the entry matches all protocols.
        /// </para>
        /// </summary>
        public string Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this._protocol != null;
        }

        /// <summary>
        /// Gets and sets the property RuleNumber. 
        /// <para>
        /// The rule number for the policy table entry. Entries are evaluated in ascending order
        /// of rule number.
        /// </para>
        /// </summary>
        public int? RuleNumber
        {
            get { return this._ruleNumber; }
            set { this._ruleNumber = value; }
        }

        // Check to see if RuleNumber property is set
        internal bool IsSetRuleNumber()
        {
            return this._ruleNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceCidr. 
        /// <para>
        /// The source CIDR block. If this value is not present, the entry matches any source
        /// address.
        /// </para>
        /// </summary>
        public string SourceCidr
        {
            get { return this._sourceCidr; }
            set { this._sourceCidr = value; }
        }

        // Check to see if SourceCidr property is set
        internal bool IsSetSourceCidr()
        {
            return this._sourceCidr != null;
        }

        /// <summary>
        /// Gets and sets the property SourcePortRange. 
        /// <para>
        /// The source port range. If this value is not present, the entry matches any source
        /// port.
        /// </para>
        /// </summary>
        public PortRange SourcePortRange
        {
            get { return this._sourcePortRange; }
            set { this._sourcePortRange = value; }
        }

        // Check to see if SourcePortRange property is set
        internal bool IsSetSourcePortRange()
        {
            return this._sourcePortRange != null;
        }

        /// <summary>
        /// Gets and sets the property TargetRouteTableId. 
        /// <para>
        /// The ID of the transit gateway route table to which the entry routes matching traffic.
        /// </para>
        /// </summary>
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

    }
}