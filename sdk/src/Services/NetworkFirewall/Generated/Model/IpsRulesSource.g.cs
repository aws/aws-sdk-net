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

namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// The source of the rules for an IPS engine rule group.
    /// </summary>
    public partial class IpsRulesSource
    {
        /// <summary>
        /// Gets and sets the property RulesString. 
        /// <para>
        /// IPS engine rules, provided as a single Suricata-compatible rule string. For the rule
        /// format, see <a href="https://suricata.readthedocs.io/en/suricata-8.0.3/rules/intro.html">Rules
        /// Format</a> on the Suricata website.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2000000)]
        public string RulesString { get; set; }

        /// <summary>
        /// Checks to see if the RulesString property is set.
        /// </summary>
        internal bool IsSetRulesString() => this.RulesString != null;
    }
}
