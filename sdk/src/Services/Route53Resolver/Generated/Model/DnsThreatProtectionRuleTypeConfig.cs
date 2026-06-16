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
 * Do not modify this file. This file is generated from the route53resolver-2018-04-01.normal.json service model.
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
namespace Amazon.Route53Resolver.Model
{
    /// <summary>
    /// The configuration for a DNS threat protection rule type within the rule type framework.
    /// </summary>
    public partial class DnsThreatProtectionRuleTypeConfig
    {
        private ConfidenceThreshold _confidenceThreshold;
        private string _value;

        /// <summary>
        /// Gets and sets the property ConfidenceThreshold. 
        /// <para>
        /// The confidence threshold for DNS Firewall Advanced. You must provide this value when
        /// you create or update a DNS Firewall Advanced rule. The confidence level values mean:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>LOW</c>: Provides the highest detection rate for threats, but also increases false
        /// positives.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MEDIUM</c>: Provides a balance between detecting threats and false positives.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HIGH</c>: Detects only the most well corroborated threats with a low rate of false
        /// positives.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConfidenceThreshold ConfidenceThreshold
        {
            get { return this._confidenceThreshold; }
            set { this._confidenceThreshold = value; }
        }

        // Check to see if ConfidenceThreshold property is set
        internal bool IsSetConfidenceThreshold()
        {
            return this._confidenceThreshold != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The type of DNS threat protection. Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DGA</c>: Domain generation algorithms detection. DGAs are used by attackers to
        /// generate a large number of domains to launch malware attacks.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DNS_TUNNELING</c>: DNS tunneling detection. DNS tunneling is used by attackers
        /// to exfiltrate data from the client by using the DNS tunnel without making a network
        /// connection to the client.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DICTIONARY_DGA</c>: Dictionary-based domain generation algorithms detection. Dictionary
        /// DGAs use wordlists to generate domains that appear more legitimate, making them harder
        /// to detect than traditional DGAs.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}