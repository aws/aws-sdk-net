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
    /// Summarizes the CIDR blocks used by the IP set references in a firewall. Network Firewall
    /// calculates the number of CIDRs by taking an aggregated count of all CIDRs used by
    /// the IP sets you are referencing.
    /// </summary>
    public partial class CIDRSummary
    {
        private int? _availableCIDRCount;
        private Dictionary<string, IPSetMetadata> _ipSetReferences = AWSConfigs.InitializeCollections ? new Dictionary<string, IPSetMetadata>() : null;
        private int? _utilizedCIDRCount;

        /// <summary>
        /// Gets and sets the property AvailableCIDRCount. 
        /// <para>
        /// The number of CIDR blocks available for use by the IP set references in a firewall.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000000)]
        public int? AvailableCIDRCount
        {
            get { return this._availableCIDRCount; }
            set { this._availableCIDRCount = value; }
        }

        // Check to see if AvailableCIDRCount property is set
        internal bool IsSetAvailableCIDRCount()
        {
            return this._availableCIDRCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IPSetReferences. 
        /// <para>
        /// The list of the IP set references used by a firewall.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, IPSetMetadata> IPSetReferences
        {
            get { return this._ipSetReferences; }
            set { this._ipSetReferences = value; }
        }

        // Check to see if IPSetReferences property is set
        internal bool IsSetIPSetReferences()
        {
            return this._ipSetReferences != null && (this._ipSetReferences.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UtilizedCIDRCount. 
        /// <para>
        /// The number of CIDR blocks used by the IP set references in a firewall.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000000)]
        public int? UtilizedCIDRCount
        {
            get { return this._utilizedCIDRCount; }
            set { this._utilizedCIDRCount = value; }
        }

        // Check to see if UtilizedCIDRCount property is set
        internal bool IsSetUtilizedCIDRCount()
        {
            return this._utilizedCIDRCount.HasValue; 
        }

    }
}