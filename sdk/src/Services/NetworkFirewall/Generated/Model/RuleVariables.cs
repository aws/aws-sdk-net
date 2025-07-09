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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
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
    /// Settings that are available for use in the rules in the <a>RuleGroup</a> where this
    /// is defined. See <a>CreateRuleGroup</a> or <a>UpdateRuleGroup</a> for usage.
    /// </summary>
    public partial class RuleVariables
    {
        private Dictionary<string, IPSet> _ipSets = AWSConfigs.InitializeCollections ? new Dictionary<string, IPSet>() : null;
        private Dictionary<string, PortSet> _portSets = AWSConfigs.InitializeCollections ? new Dictionary<string, PortSet>() : null;

        /// <summary>
        /// Gets and sets the property IPSets. 
        /// <para>
        /// A list of IP addresses and address ranges, in CIDR notation. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, IPSet> IPSets
        {
            get { return this._ipSets; }
            set { this._ipSets = value; }
        }

        // Check to see if IPSets property is set
        internal bool IsSetIPSets()
        {
            return this._ipSets != null && (this._ipSets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PortSets. 
        /// <para>
        /// A list of port ranges. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, PortSet> PortSets
        {
            get { return this._portSets; }
            set { this._portSets = value; }
        }

        // Check to see if PortSets property is set
        internal bool IsSetPortSets()
        {
            return this._portSets != null && (this._portSets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}