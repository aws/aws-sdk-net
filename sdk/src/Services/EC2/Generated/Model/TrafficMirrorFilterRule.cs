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
    /// Describes the Traffic Mirror rule.
    /// </summary>
    public partial class TrafficMirrorFilterRule
    {
        private string _description;
        private string _destinationCidrBlock;
        private TrafficMirrorPortRange _destinationPortRange;
        private int? _protocol;
        private TrafficMirrorRuleAction _ruleAction;
        private int? _ruleNumber;
        private string _sourceCidrBlock;
        private TrafficMirrorPortRange _sourcePortRange;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private TrafficDirection _trafficDirection;
        private string _trafficMirrorFilterId;
        private string _trafficMirrorFilterRuleId;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the Traffic Mirror rule.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationCidrBlock. 
        /// <para>
        /// The destination CIDR block assigned to the Traffic Mirror rule.
        /// </para>
        /// </summary>
        public string DestinationCidrBlock
        {
            get { return this._destinationCidrBlock; }
            set { this._destinationCidrBlock = value; }
        }

        // Check to see if DestinationCidrBlock property is set
        internal bool IsSetDestinationCidrBlock()
        {
            return this._destinationCidrBlock != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationPortRange. 
        /// <para>
        /// The destination port range assigned to the Traffic Mirror rule.
        /// </para>
        /// </summary>
        public TrafficMirrorPortRange DestinationPortRange
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
        /// The protocol assigned to the Traffic Mirror rule.
        /// </para>
        /// </summary>
        public int? Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this._protocol.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RuleAction. 
        /// <para>
        /// The action assigned to the Traffic Mirror rule.
        /// </para>
        /// </summary>
        public TrafficMirrorRuleAction RuleAction
        {
            get { return this._ruleAction; }
            set { this._ruleAction = value; }
        }

        // Check to see if RuleAction property is set
        internal bool IsSetRuleAction()
        {
            return this._ruleAction != null;
        }

        /// <summary>
        /// Gets and sets the property RuleNumber. 
        /// <para>
        /// The rule number of the Traffic Mirror rule.
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
        /// Gets and sets the property SourceCidrBlock. 
        /// <para>
        /// The source CIDR block assigned to the Traffic Mirror rule.
        /// </para>
        /// </summary>
        public string SourceCidrBlock
        {
            get { return this._sourceCidrBlock; }
            set { this._sourceCidrBlock = value; }
        }

        // Check to see if SourceCidrBlock property is set
        internal bool IsSetSourceCidrBlock()
        {
            return this._sourceCidrBlock != null;
        }

        /// <summary>
        /// Gets and sets the property SourcePortRange. 
        /// <para>
        /// The source port range assigned to the Traffic Mirror rule.
        /// </para>
        /// </summary>
        public TrafficMirrorPortRange SourcePortRange
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags on Traffic Mirroring filter rules.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
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
        /// Gets and sets the property TrafficDirection. 
        /// <para>
        /// The traffic direction assigned to the Traffic Mirror rule.
        /// </para>
        /// </summary>
        public TrafficDirection TrafficDirection
        {
            get { return this._trafficDirection; }
            set { this._trafficDirection = value; }
        }

        // Check to see if TrafficDirection property is set
        internal bool IsSetTrafficDirection()
        {
            return this._trafficDirection != null;
        }

        /// <summary>
        /// Gets and sets the property TrafficMirrorFilterId. 
        /// <para>
        /// The ID of the Traffic Mirror filter that the rule is associated with.
        /// </para>
        /// </summary>
        public string TrafficMirrorFilterId
        {
            get { return this._trafficMirrorFilterId; }
            set { this._trafficMirrorFilterId = value; }
        }

        // Check to see if TrafficMirrorFilterId property is set
        internal bool IsSetTrafficMirrorFilterId()
        {
            return this._trafficMirrorFilterId != null;
        }

        /// <summary>
        /// Gets and sets the property TrafficMirrorFilterRuleId. 
        /// <para>
        /// The ID of the Traffic Mirror rule.
        /// </para>
        /// </summary>
        public string TrafficMirrorFilterRuleId
        {
            get { return this._trafficMirrorFilterRuleId; }
            set { this._trafficMirrorFilterRuleId = value; }
        }

        // Check to see if TrafficMirrorFilterRuleId property is set
        internal bool IsSetTrafficMirrorFilterRuleId()
        {
            return this._trafficMirrorFilterRuleId != null;
        }

    }
}