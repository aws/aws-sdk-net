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
    /// A resource discovery is an IPAM component that enables IPAM to manage and monitor
    /// resources that belong to the owning account.
    /// </summary>
    public partial class IpamResourceDiscovery
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The resource discovery description.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property IpamResourceDiscoveryArn. 
        /// <para>
        /// The resource discovery Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        public string IpamResourceDiscoveryArn { get; set; }

        /// <summary>
        /// Checks to see if the IpamResourceDiscoveryArn property is set.
        /// </summary>
        internal bool IsSetIpamResourceDiscoveryArn() => this.IpamResourceDiscoveryArn != null;

        /// <summary>
        /// Gets and sets the property IpamResourceDiscoveryId. 
        /// <para>
        /// The resource discovery ID.
        /// </para>
        /// </summary>
        public string IpamResourceDiscoveryId { get; set; }

        /// <summary>
        /// Checks to see if the IpamResourceDiscoveryId property is set.
        /// </summary>
        internal bool IsSetIpamResourceDiscoveryId() => this.IpamResourceDiscoveryId != null;

        /// <summary>
        /// Gets and sets the property IpamResourceDiscoveryRegion. 
        /// <para>
        /// The resource discovery Region.
        /// </para>
        /// </summary>
        public string IpamResourceDiscoveryRegion { get; set; }

        /// <summary>
        /// Checks to see if the IpamResourceDiscoveryRegion property is set.
        /// </summary>
        internal bool IsSetIpamResourceDiscoveryRegion() => this.IpamResourceDiscoveryRegion != null;

        /// <summary>
        /// Gets and sets the property IsDefault. 
        /// <para>
        /// Defines if the resource discovery is the default. The default resource discovery is
        /// the resource discovery automatically created when you create an IPAM.
        /// </para>
        /// </summary>
        public bool? IsDefault { get; set; }

        /// <summary>
        /// Checks to see if the IsDefault property is set.
        /// </summary>
        internal bool IsSetIsDefault() => this.IsDefault.HasValue;

        /// <summary>
        /// Gets and sets the property OperatingRegions. 
        /// <para>
        /// The operating Regions for the resource discovery. Operating Regions are Amazon Web
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
        public List<IpamOperatingRegion> OperatingRegions { get; set; } = AWSConfigs.InitializeCollections ? new List<IpamOperatingRegion>() : null;

        /// <summary>
        /// Checks to see if the OperatingRegions property is set.
        /// </summary>
        internal bool IsSetOperatingRegions() => this.OperatingRegions != null && (this.OperatingRegions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OrganizationalUnitExclusions. 
        /// <para>
        /// If your IPAM is integrated with Amazon Web Services Organizations and you add an organizational
        /// unit (OU) exclusion, IPAM will not manage the IP addresses in accounts in that OU
        /// exclusion.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IpamOrganizationalUnitExclusion> OrganizationalUnitExclusions { get; set; } = AWSConfigs.InitializeCollections ? new List<IpamOrganizationalUnitExclusion>() : null;

        /// <summary>
        /// Checks to see if the OrganizationalUnitExclusions property is set.
        /// </summary>
        internal bool IsSetOrganizationalUnitExclusions() => this.OrganizationalUnitExclusions != null && (this.OrganizationalUnitExclusions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The ID of the owner.
        /// </para>
        /// </summary>
        public string OwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerId property is set.
        /// </summary>
        internal bool IsSetOwnerId() => this.OwnerId != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The lifecycle state of the resource discovery.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>create-in-progress</c> - Resource discovery is being created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>create-complete</c> - Resource discovery creation is complete.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>create-failed</c> - Resource discovery creation has failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>modify-in-progress</c> - Resource discovery is being modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>modify-complete</c> - Resource discovery modification is complete.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>modify-failed</c> - Resource discovery modification has failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>delete-in-progress</c> - Resource discovery is being deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>delete-complete</c> - Resource discovery deletion is complete.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>delete-failed</c> - Resource discovery deletion has failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>isolate-in-progress</c> - Amazon Web Services account that created the resource
        /// discovery has been removed and the resource discovery is being isolated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>isolate-complete</c> - Resource discovery isolation is complete.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>restore-in-progress</c> - Amazon Web Services account that created the resource
        /// discovery and was isolated has been restored.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public IpamResourceDiscoveryState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A tag is a label that you assign to an Amazon Web Services resource. Each tag consists
        /// of a key and an optional value. You can use tags to search and filter your resources
        /// or track your Amazon Web Services costs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
