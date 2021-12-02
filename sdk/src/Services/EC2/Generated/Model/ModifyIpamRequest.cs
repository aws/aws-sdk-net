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
    /// Container for the parameters to the ModifyIpam operation.
    /// Modify the configurations of an IPAM.
    /// </summary>
    public partial class ModifyIpamRequest : AmazonEC2Request
    {
        private List<AddIpamOperatingRegion> _addOperatingRegions = new List<AddIpamOperatingRegion>();
        private string _description;
        private string _ipamId;
        private List<RemoveIpamOperatingRegion> _removeOperatingRegions = new List<RemoveIpamOperatingRegion>();

        /// <summary>
        /// Gets and sets the property AddOperatingRegions. 
        /// <para>
        /// Choose the operating Regions for the IPAM. Operating Regions are Amazon Web Services
        /// Regions where the IPAM is allowed to manage IP address CIDRs. IPAM only discovers
        /// and monitors resources in the Amazon Web Services Regions you select as operating
        /// Regions.
        /// </para>
        ///  
        /// <para>
        /// For more information about operating Regions, see <a href="/vpc/latest/ipam/create-ipam.html">Create
        /// an IPAM</a> in the <i>Amazon VPC IPAM User Guide</i>.
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
        /// The description of the IPAM you want to modify.
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
        /// Gets and sets the property IpamId. 
        /// <para>
        /// The ID of the IPAM you want to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IpamId
        {
            get { return this._ipamId; }
            set { this._ipamId = value; }
        }

        // Check to see if IpamId property is set
        internal bool IsSetIpamId()
        {
            return this._ipamId != null;
        }

        /// <summary>
        /// Gets and sets the property RemoveOperatingRegions. 
        /// <para>
        /// The operating Regions to remove.
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