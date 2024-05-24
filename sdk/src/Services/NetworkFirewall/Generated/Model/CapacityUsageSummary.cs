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
    /// The capacity usage summary of the resources used by the <a>ReferenceSets</a> in a
    /// firewall.
    /// </summary>
    public partial class CapacityUsageSummary
    {
        private CIDRSummary _cidRs;

        /// <summary>
        /// Gets and sets the property CIDRs. 
        /// <para>
        /// Describes the capacity usage of the CIDR blocks used by the IP set references in a
        /// firewall.
        /// </para>
        /// </summary>
        public CIDRSummary CIDRs
        {
            get { return this._cidRs; }
            set { this._cidRs = value; }
        }

        // Check to see if CIDRs property is set
        internal bool IsSetCIDRs()
        {
            return this._cidRs != null;
        }

    }
}