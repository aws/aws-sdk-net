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
    /// Container for the parameters to the ModifyIpamResourceDiscovery operation.
    /// Modifies a resource discovery. A resource discovery is an IPAM component that enables
    /// IPAM Service to manage and monitor resources that belong to the owning account.
    /// </summary>
    public partial class ModifyIpamResourceDiscoveryRequest : AmazonEC2Request
    {
        private List<AddIpamOperatingRegion> _addOperatingRegions = new List<AddIpamOperatingRegion>();
        private string _description;
        private string _ipamResourceDiscoveryId;
        private List<RemoveIpamOperatingRegion> _removeOperatingRegions = new List<RemoveIpamOperatingRegion>();

        /// <summary>
        /// Gets and sets the property AddOperatingRegions. 
        /// <para>
        /// Add operating Regions to the resource discovery. Operating Regions are Amazon Web
        /// Services Regions where the IPAM is allowed to manage IP address CIDRs. IPAM only discovers
        /// and monitors resources in the Amazon Web Services Regions you select as operating
        /// Regions.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<AddIpamOperatingRegion> AddOperatingRegions
        {
            get { return this._addOperatingRegions; }
            set { this._addOperatingRegions = value; }
        }

        // Check to see if AddOperatingRegions property is set
        internal bool IsSetAddOperatingRegions()
        {
            return this._addOperatingRegions != null && this._addOperatingRegions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A resource discovery description.
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
        /// Gets and sets the property IpamResourceDiscoveryId. 
        /// <para>
        /// A resource discovery ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IpamResourceDiscoveryId
        {
            get { return this._ipamResourceDiscoveryId; }
            set { this._ipamResourceDiscoveryId = value; }
        }

        // Check to see if IpamResourceDiscoveryId property is set
        internal bool IsSetIpamResourceDiscoveryId()
        {
            return this._ipamResourceDiscoveryId != null;
        }

        /// <summary>
        /// Gets and sets the property RemoveOperatingRegions. 
        /// <para>
        /// Remove operating Regions.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<RemoveIpamOperatingRegion> RemoveOperatingRegions
        {
            get { return this._removeOperatingRegions; }
            set { this._removeOperatingRegions = value; }
        }

        // Check to see if RemoveOperatingRegions property is set
        internal bool IsSetRemoveOperatingRegions()
        {
            return this._removeOperatingRegions != null && this._removeOperatingRegions.Count > 0; 
        }

    }
}