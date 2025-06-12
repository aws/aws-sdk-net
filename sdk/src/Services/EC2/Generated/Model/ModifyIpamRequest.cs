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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyIpam operation.
    /// Modify the configurations of an IPAM.
    /// </summary>
    public partial class ModifyIpamRequest : AmazonEC2Request
    {
        private List<AddIpamOperatingRegion> _addOperatingRegions = AWSConfigs.InitializeCollections ? new List<AddIpamOperatingRegion>() : null;
        private string _description;
        private bool? _dryRun;
        private bool? _enablePrivateGua;
        private string _ipamId;
        private IpamMeteredAccount _meteredAccount;
        private List<RemoveIpamOperatingRegion> _removeOperatingRegions = AWSConfigs.InitializeCollections ? new List<RemoveIpamOperatingRegion>() : null;
        private IpamTier _tier;

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
        /// For more information about operating Regions, see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/create-ipam.html">Create
        /// an IPAM</a> in the <i>Amazon VPC IPAM User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._addOperatingRegions != null && (this._addOperatingRegions.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property DryRun. 
        /// <para>
        /// A check for whether you have the required permissions for the action without actually
        /// making the request and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnablePrivateGua. 
        /// <para>
        /// Enable this option to use your own GUA ranges as private IPv6 addresses. This option
        /// is disabled by default.
        /// </para>
        /// </summary>
        public bool? EnablePrivateGua
        {
            get { return this._enablePrivateGua; }
            set { this._enablePrivateGua = value; }
        }

        // Check to see if EnablePrivateGua property is set
        internal bool IsSetEnablePrivateGua()
        {
            return this._enablePrivateGua.HasValue; 
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
        /// Gets and sets the property MeteredAccount. 
        /// <para>
        /// A metered account is an Amazon Web Services account that is charged for active IP
        /// addresses managed in IPAM. For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/ipam-enable-cost-distro.html">Enable
        /// cost distribution</a> in the <i>Amazon VPC IPAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ipam-owner</c> (default): The Amazon Web Services account which owns the IPAM
        /// is charged for all active IP addresses managed in IPAM.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>resource-owner</c>: The Amazon Web Services account that owns the IP address is
        /// charged for the active IP address.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public IpamMeteredAccount MeteredAccount
        {
            get { return this._meteredAccount; }
            set { this._meteredAccount = value; }
        }

        // Check to see if MeteredAccount property is set
        internal bool IsSetMeteredAccount()
        {
            return this._meteredAccount != null;
        }

        /// <summary>
        /// Gets and sets the property RemoveOperatingRegions. 
        /// <para>
        /// The operating Regions to remove.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._removeOperatingRegions != null && (this._removeOperatingRegions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tier. 
        /// <para>
        /// IPAM is offered in a Free Tier and an Advanced Tier. For more information about the
        /// features available in each tier and the costs associated with the tiers, see <a href="http://aws.amazon.com/vpc/pricing/">Amazon
        /// VPC pricing &gt; IPAM tab</a>.
        /// </para>
        /// </summary>
        public IpamTier Tier
        {
            get { return this._tier; }
            set { this._tier = value; }
        }

        // Check to see if Tier property is set
        internal bool IsSetTier()
        {
            return this._tier != null;
        }

    }
}