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

namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Describes a NAT rule of an attachment.
    /// </summary>
    public partial class NatRule
    {
        /// <summary>
        /// Gets and sets the property MatchSourceCidr. 
        /// <para>
        /// The source CIDR block that the rule matches for traffic from the attachment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string MatchSourceCidr { get; set; }

        /// <summary>
        /// Checks to see if the MatchSourceCidr property is set.
        /// </summary>
        internal bool IsSetMatchSourceCidr() => this.MatchSourceCidr != null;

        /// <summary>
        /// Gets and sets the property NatCidr. 
        /// <para>
        /// The CIDR block that matching source addresses are translated to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string NatCidr { get; set; }

        /// <summary>
        /// Checks to see if the NatCidr property is set.
        /// </summary>
        internal bool IsSetNatCidr() => this.NatCidr != null;

        /// <summary>
        /// Gets and sets the property RuleNumber. 
        /// <para>
        /// The rule number. Rule numbers identify the rules of an attachment and don't set the
        /// order in which rules are evaluated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32766)]
        public int? RuleNumber { get; set; }

        /// <summary>
        /// Checks to see if the RuleNumber property is set.
        /// </summary>
        internal bool IsSetRuleNumber() => this.RuleNumber.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the NAT rule. The possible values are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATING</c>: The rule is being created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MODIFYING</c>: The rule is being modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETING</c>: The rule is being deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACTIVATING</c>: NAT gateway support is being enabled, and the rule is being applied.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACTIVATED</c>: NAT gateway support is enabled, and the rule is applied.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DEACTIVATING</c>: NAT gateway support is being disabled, and the rule is being
        /// removed from use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DEACTIVATED</c>: NAT gateway support is disabled, and the rule isn't applied.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c>: The attachment failed to be created, and the rule isn't applied.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PENDING_ATTACHMENT_ACCEPTANCE</c>: The attachment is pending acceptance. The rule
        /// is applied after the attachment is accepted.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public NatRuleState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
