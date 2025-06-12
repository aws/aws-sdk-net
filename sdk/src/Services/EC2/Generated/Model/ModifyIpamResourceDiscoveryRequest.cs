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
    /// Container for the parameters to the ModifyIpamResourceDiscovery operation.
    /// Modifies a resource discovery. A resource discovery is an IPAM component that enables
    /// IPAM to manage and monitor resources that belong to the owning account.
    /// </summary>
    public partial class ModifyIpamResourceDiscoveryRequest : AmazonEC2Request
    {
        private List<AddIpamOperatingRegion> _addOperatingRegions = AWSConfigs.InitializeCollections ? new List<AddIpamOperatingRegion>() : null;
        private List<AddIpamOrganizationalUnitExclusion> _addOrganizationalUnitExclusions = AWSConfigs.InitializeCollections ? new List<AddIpamOrganizationalUnitExclusion>() : null;
        private string _description;
        private bool? _dryRun;
        private string _ipamResourceDiscoveryId;
        private List<RemoveIpamOperatingRegion> _removeOperatingRegions = AWSConfigs.InitializeCollections ? new List<RemoveIpamOperatingRegion>() : null;
        private List<RemoveIpamOrganizationalUnitExclusion> _removeOrganizationalUnitExclusions = AWSConfigs.InitializeCollections ? new List<RemoveIpamOrganizationalUnitExclusion>() : null;

        /// <summary>
        /// Gets and sets the property AddOperatingRegions. 
        /// <para>
        /// Add operating Regions to the resource discovery. Operating Regions are Amazon Web
        /// Services Regions where the IPAM is allowed to manage IP address CIDRs. IPAM only discovers
        /// and monitors resources in the Amazon Web Services Regions you select as operating
        /// Regions.
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
        /// Gets and sets the property AddOrganizationalUnitExclusions. 
        /// <para>
        /// Add an Organizational Unit (OU) exclusion to your IPAM. If your IPAM is integrated
        /// with Amazon Web Services Organizations and you add an organizational unit (OU) exclusion,
        /// IPAM will not manage the IP addresses in accounts in that OU exclusion. There is a
        /// limit on the number of exclusions you can create. For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/quotas-ipam.html">Quotas
        /// for your IPAM</a> in the <i>Amazon VPC IPAM User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The resulting set of exclusions must not result in "overlap", meaning two or more
        /// OU exclusions must not exclude the same OU. For more information and examples, see
        /// the Amazon Web Services CLI request process in <a href="https://docs.aws.amazon.com/vpc/latest/ipam/exclude-ous.html#exclude-ous-create-delete">Add
        /// or remove OU exclusions </a> in the <i>Amazon VPC User Guide</i>.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<AddIpamOrganizationalUnitExclusion> AddOrganizationalUnitExclusions
        {
            get { return this._addOrganizationalUnitExclusions; }
            set { this._addOrganizationalUnitExclusions = value; }
        }

        // Check to see if AddOrganizationalUnitExclusions property is set
        internal bool IsSetAddOrganizationalUnitExclusions()
        {
            return this._addOrganizationalUnitExclusions != null && (this._addOrganizationalUnitExclusions.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property RemoveOrganizationalUnitExclusions. 
        /// <para>
        /// Remove an Organizational Unit (OU) exclusion to your IPAM. If your IPAM is integrated
        /// with Amazon Web Services Organizations and you add an organizational unit (OU) exclusion,
        /// IPAM will not manage the IP addresses in accounts in that OU exclusion. There is a
        /// limit on the number of exclusions you can create. For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/quotas-ipam.html">Quotas
        /// for your IPAM</a> in the <i>Amazon VPC IPAM User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The resulting set of exclusions must not result in "overlap", meaning two or more
        /// OU exclusions must not exclude the same OU. For more information and examples, see
        /// the Amazon Web Services CLI request process in <a href="https://docs.aws.amazon.com/vpc/latest/ipam/exclude-ous.html#exclude-ous-create-delete">Add
        /// or remove OU exclusions </a> in the <i>Amazon VPC User Guide</i>.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<RemoveIpamOrganizationalUnitExclusion> RemoveOrganizationalUnitExclusions
        {
            get { return this._removeOrganizationalUnitExclusions; }
            set { this._removeOrganizationalUnitExclusions = value; }
        }

        // Check to see if RemoveOrganizationalUnitExclusions property is set
        internal bool IsSetRemoveOrganizationalUnitExclusions()
        {
            return this._removeOrganizationalUnitExclusions != null && (this._removeOrganizationalUnitExclusions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}