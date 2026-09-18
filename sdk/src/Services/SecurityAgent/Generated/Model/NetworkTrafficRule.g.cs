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

namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// A rule that controls network traffic during penetration testing by allowing or denying
    /// traffic to specific URL patterns.
    /// </summary>
    public partial class NetworkTrafficRule
    {
        /// <summary>
        /// Gets and sets the property Effect. 
        /// <para>
        /// The effect of the rule. Valid values are ALLOW and DENY.
        /// </para>
        /// </summary>
        public NetworkTrafficRuleEffect Effect { get; set; }

        /// <summary>
        /// Checks to see if the Effect property is set.
        /// </summary>
        internal bool IsSetEffect() => this.Effect != null;

        /// <summary>
        /// Gets and sets the property NetworkTrafficRuleType. 
        /// <para>
        /// The type of the network traffic rule. Currently, only URL is supported.
        /// </para>
        /// </summary>
        public NetworkTrafficRuleType NetworkTrafficRuleType { get; set; }

        /// <summary>
        /// Checks to see if the NetworkTrafficRuleType property is set.
        /// </summary>
        internal bool IsSetNetworkTrafficRuleType() => this.NetworkTrafficRuleType != null;

        /// <summary>
        /// Gets and sets the property Pattern. 
        /// <para>
        /// The URL pattern to match for the rule.
        /// </para>
        /// </summary>
        public string Pattern { get; set; }

        /// <summary>
        /// Checks to see if the Pattern property is set.
        /// </summary>
        internal bool IsSetPattern() => this.Pattern != null;
    }
}
