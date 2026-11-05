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

namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Describes a rule for an IP access control group.
    /// </summary>
    public partial class IpRuleItem
    {
        /// <summary>
        /// Gets and sets the property IpRule. 
        /// <para>
        /// The IP address range, in CIDR notation.
        /// </para>
        /// </summary>
        public string IpRule { get; set; }

        /// <summary>
        /// Checks to see if the IpRule property is set.
        /// </summary>
        internal bool IsSetIpRule() => this.IpRule != null;

        /// <summary>
        /// Gets and sets the property RuleDesc. 
        /// <para>
        /// The description.
        /// </para>
        /// </summary>
        public string RuleDesc { get; set; }

        /// <summary>
        /// Checks to see if the RuleDesc property is set.
        /// </summary>
        internal bool IsSetRuleDesc() => this.RuleDesc != null;
    }
}
