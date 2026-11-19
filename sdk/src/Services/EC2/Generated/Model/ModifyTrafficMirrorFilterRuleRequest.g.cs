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
    /// Container for the parameters to the ModifyTrafficMirrorFilterRule operation. Modifies
    /// the specified Traffic Mirror rule. <para> <c>DestinationCidrBlock</c> and <c>SourceCidrBlock</c>
    /// must both be an IPv4 range or an IPv6 range. </para>
    /// </summary>
    public partial class ModifyTrafficMirrorFilterRuleRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description to assign to the Traffic Mirror rule.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DestinationCidrBlock. 
        /// <para>
        /// The destination CIDR block to assign to the Traffic Mirror rule.
        /// </para>
        /// </summary>
        public string DestinationCidrBlock { get; set; }

        /// <summary>
        /// Checks to see if the DestinationCidrBlock property is set.
        /// </summary>
        internal bool IsSetDestinationCidrBlock() => this.DestinationCidrBlock != null;

        /// <summary>
        /// Gets and sets the property DestinationPortRange. 
        /// <para>
        /// The destination ports that are associated with the Traffic Mirror rule.
        /// </para>
        /// </summary>
        public TrafficMirrorPortRangeRequest DestinationPortRange { get; set; }

        /// <summary>
        /// Checks to see if the DestinationPortRange property is set.
        /// </summary>
        internal bool IsSetDestinationPortRange() => this.DestinationPortRange != null;

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
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol, for example TCP, to assign to the Traffic Mirror rule.
        /// </para>
        /// </summary>
        public int? Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol.HasValue;

        /// <summary>
        /// Gets and sets the property RemoveFields. 
        /// <para>
        /// The properties that you want to remove from the Traffic Mirror filter rule.
        /// </para>
        ///  
        /// <para>
        /// When you remove a property from a Traffic Mirror filter rule, the property is set
        /// to the default.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RemoveFields { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RemoveFields property is set.
        /// </summary>
        internal bool IsSetRemoveFields() => this.RemoveFields != null && (this.RemoveFields.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RuleAction. 
        /// <para>
        /// The action to assign to the rule.
        /// </para>
        /// </summary>
        public TrafficMirrorRuleAction RuleAction { get; set; }

        /// <summary>
        /// Checks to see if the RuleAction property is set.
        /// </summary>
        internal bool IsSetRuleAction() => this.RuleAction != null;

        /// <summary>
        /// Gets and sets the property RuleNumber. 
        /// <para>
        /// The number of the Traffic Mirror rule. This number must be unique for each Traffic
        /// Mirror rule in a given direction. The rules are processed in ascending order by rule
        /// number.
        /// </para>
        /// </summary>
        public int? RuleNumber { get; set; }

        /// <summary>
        /// Checks to see if the RuleNumber property is set.
        /// </summary>
        internal bool IsSetRuleNumber() => this.RuleNumber.HasValue;

        /// <summary>
        /// Gets and sets the property SourceCidrBlock. 
        /// <para>
        /// The source CIDR block to assign to the Traffic Mirror rule.
        /// </para>
        /// </summary>
        public string SourceCidrBlock { get; set; }

        /// <summary>
        /// Checks to see if the SourceCidrBlock property is set.
        /// </summary>
        internal bool IsSetSourceCidrBlock() => this.SourceCidrBlock != null;

        /// <summary>
        /// Gets and sets the property SourcePortRange. 
        /// <para>
        /// The port range to assign to the Traffic Mirror rule.
        /// </para>
        /// </summary>
        public TrafficMirrorPortRangeRequest SourcePortRange { get; set; }

        /// <summary>
        /// Checks to see if the SourcePortRange property is set.
        /// </summary>
        internal bool IsSetSourcePortRange() => this.SourcePortRange != null;

        /// <summary>
        /// Gets and sets the property TrafficDirection. 
        /// <para>
        /// The type of traffic to assign to the rule.
        /// </para>
        /// </summary>
        public TrafficDirection TrafficDirection { get; set; }

        /// <summary>
        /// Checks to see if the TrafficDirection property is set.
        /// </summary>
        internal bool IsSetTrafficDirection() => this.TrafficDirection != null;

        /// <summary>
        /// Gets and sets the property TrafficMirrorFilterRuleId. 
        /// <para>
        /// The ID of the Traffic Mirror rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TrafficMirrorFilterRuleId { get; set; }

        /// <summary>
        /// Checks to see if the TrafficMirrorFilterRuleId property is set.
        /// </summary>
        internal bool IsSetTrafficMirrorFilterRuleId() => this.TrafficMirrorFilterRuleId != null;
    }
}
