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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateTrafficMirrorFilterRule operation.
    /// Creates a Traffic Mirror filter rule. 
    /// 
    ///  
    /// <para>
    /// A Traffic Mirror rule defines the Traffic Mirror source traffic to mirror.
    /// </para>
    ///  
    /// <para>
    /// You need the Traffic Mirror filter ID when you create the rule.
    /// </para>
    /// </summary>
    public partial class CreateTrafficMirrorFilterRuleRequest : AmazonEC2Request
    {
        private string _clientToken;
        private string _description;
        private string _destinationCidrBlock;
        private TrafficMirrorPortRangeRequest _destinationPortRange;
        private int? _protocol;
        private TrafficMirrorRuleAction _ruleAction;
        private int? _ruleNumber;
        private string _sourceCidrBlock;
        private TrafficMirrorPortRangeRequest _sourcePortRange;
        private TrafficDirection _trafficDirection;
        private string _trafficMirrorFilterId;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">How
        /// to Ensure Idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

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
        /// The destination CIDR block to assign to the Traffic Mirror rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The destination port range.
        /// </para>
        /// </summary>
        public TrafficMirrorPortRangeRequest DestinationPortRange
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
        /// The protocol, for example UDP, to assign to the Traffic Mirror rule.
        /// </para>
        ///  
        /// <para>
        /// For information about the protocol value, see <a href="https://www.iana.org/assignments/protocol-numbers/protocol-numbers.xhtml">Protocol
        /// Numbers</a> on the Internet Assigned Numbers Authority (IANA) website.
        /// </para>
        /// </summary>
        public int Protocol
        {
            get { return this._protocol.GetValueOrDefault(); }
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
        /// The action to take (<code>accept</code> | <code>reject</code>) on the filtered traffic.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The number of the Traffic Mirror rule. This number must be unique for each Traffic
        /// Mirror rule in a given direction. The rules are processed in ascending order by rule
        /// number.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int RuleNumber
        {
            get { return this._ruleNumber.GetValueOrDefault(); }
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
        /// The source CIDR block to assign to the Traffic Mirror rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The source port range.
        /// </para>
        /// </summary>
        public TrafficMirrorPortRangeRequest SourcePortRange
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
        /// Gets and sets the property TrafficDirection. 
        /// <para>
        /// The type of traffic (<code>ingress</code> | <code>egress</code>).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The ID of the filter that this rule is associated with.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}