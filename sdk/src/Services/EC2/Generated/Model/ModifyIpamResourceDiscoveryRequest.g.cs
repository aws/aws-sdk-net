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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyIpamResourceDiscovery operation. Modifies
    /// a resource discovery. A resource discovery is an IPAM component that enables IPAM
    /// to manage and monitor resources that belong to the owning account.
    /// </summary>
    public partial class ModifyIpamResourceDiscoveryRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property AddOperatingRegions. 
        /// <para>
        /// Add operating Regions to the resource discovery. Operating Regions are Amazon Web
        /// Services Regions where the IPAM is allowed to manage IP address CIDRs. IPAM only discovers
        /// and monitors resources in the Amazon Web Services Regions you select as operating
        /// Regions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<AddIpamOperatingRegion> AddOperatingRegions { get; set; } = AWSConfigs.InitializeCollections ? new List<AddIpamOperatingRegion>() : null;

        /// <summary>
        /// Checks to see if the AddOperatingRegions property is set.
        /// </summary>
        internal bool IsSetAddOperatingRegions() => this.AddOperatingRegions != null && (this.AddOperatingRegions.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<AddIpamOrganizationalUnitExclusion> AddOrganizationalUnitExclusions { get; set; } = AWSConfigs.InitializeCollections ? new List<AddIpamOrganizationalUnitExclusion>() : null;

        /// <summary>
        /// Checks to see if the AddOrganizationalUnitExclusions property is set.
        /// </summary>
        internal bool IsSetAddOrganizationalUnitExclusions() => this.AddOrganizationalUnitExclusions != null && (this.AddOrganizationalUnitExclusions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A resource discovery description.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// A check for whether you have the required permissions for the action without actually
        /// making the request and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property IpamResourceDiscoveryId. 
        /// <para>
        /// A resource discovery ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string IpamResourceDiscoveryId { get; set; }

        /// <summary>
        /// Checks to see if the IpamResourceDiscoveryId property is set.
        /// </summary>
        internal bool IsSetIpamResourceDiscoveryId() => this.IpamResourceDiscoveryId != null;

        /// <summary>
        /// Gets and sets the property RemoveOperatingRegions. 
        /// <para>
        /// Remove operating Regions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<RemoveIpamOperatingRegion> RemoveOperatingRegions { get; set; } = AWSConfigs.InitializeCollections ? new List<RemoveIpamOperatingRegion>() : null;

        /// <summary>
        /// Checks to see if the RemoveOperatingRegions property is set.
        /// </summary>
        internal bool IsSetRemoveOperatingRegions() => this.RemoveOperatingRegions != null && (this.RemoveOperatingRegions.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<RemoveIpamOrganizationalUnitExclusion> RemoveOrganizationalUnitExclusions { get; set; } = AWSConfigs.InitializeCollections ? new List<RemoveIpamOrganizationalUnitExclusion>() : null;

        /// <summary>
        /// Checks to see if the RemoveOrganizationalUnitExclusions property is set.
        /// </summary>
        internal bool IsSetRemoveOrganizationalUnitExclusions() => this.RemoveOrganizationalUnitExclusions != null && (this.RemoveOrganizationalUnitExclusions.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
