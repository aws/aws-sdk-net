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
    /// IPAM is a VPC feature that you can use to automate your IP address management workflows
    /// including assigning, tracking, troubleshooting, and auditing IP addresses across Amazon
    /// Web Services Regions and accounts throughout your Amazon Web Services Organization.
    /// For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/what-is-it-ipam.html">What
    /// is IPAM?</a> in the <i>Amazon VPC IPAM User Guide</i>.
    /// </summary>
    public partial class Ipam
    {
        /// <summary>
        /// Gets and sets the property DefaultResourceDiscoveryAssociationId. 
        /// <para>
        /// The IPAM's default resource discovery association ID.
        /// </para>
        /// </summary>
        public string DefaultResourceDiscoveryAssociationId { get; set; }

        /// <summary>
        /// Checks to see if the DefaultResourceDiscoveryAssociationId property is set.
        /// </summary>
        internal bool IsSetDefaultResourceDiscoveryAssociationId() => this.DefaultResourceDiscoveryAssociationId != null;

        /// <summary>
        /// Gets and sets the property DefaultResourceDiscoveryId. 
        /// <para>
        /// The IPAM's default resource discovery ID.
        /// </para>
        /// </summary>
        public string DefaultResourceDiscoveryId { get; set; }

        /// <summary>
        /// Checks to see if the DefaultResourceDiscoveryId property is set.
        /// </summary>
        internal bool IsSetDefaultResourceDiscoveryId() => this.DefaultResourceDiscoveryId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description for the IPAM.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EnablePrivateGua. 
        /// <para>
        /// Enable this option to use your own GUA ranges as private IPv6 addresses. This option
        /// is disabled by default.
        /// </para>
        /// </summary>
        public bool? EnablePrivateGua { get; set; }

        /// <summary>
        /// Checks to see if the EnablePrivateGua property is set.
        /// </summary>
        internal bool IsSetEnablePrivateGua() => this.EnablePrivateGua.HasValue;

        /// <summary>
        /// Gets and sets the property IpamArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IPAM.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1283)]
        public string IpamArn { get; set; }

        /// <summary>
        /// Checks to see if the IpamArn property is set.
        /// </summary>
        internal bool IsSetIpamArn() => this.IpamArn != null;

        /// <summary>
        /// Gets and sets the property IpamId. 
        /// <para>
        /// The ID of the IPAM.
        /// </para>
        /// </summary>
        public string IpamId { get; set; }

        /// <summary>
        /// Checks to see if the IpamId property is set.
        /// </summary>
        internal bool IsSetIpamId() => this.IpamId != null;

        /// <summary>
        /// Gets and sets the property IpamRegion. 
        /// <para>
        /// The Amazon Web Services Region of the IPAM.
        /// </para>
        /// </summary>
        public string IpamRegion { get; set; }

        /// <summary>
        /// Checks to see if the IpamRegion property is set.
        /// </summary>
        internal bool IsSetIpamRegion() => this.IpamRegion != null;

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
        public IpamMeteredAccount MeteredAccount { get; set; }

        /// <summary>
        /// Checks to see if the MeteredAccount property is set.
        /// </summary>
        internal bool IsSetMeteredAccount() => this.MeteredAccount != null;

        /// <summary>
        /// Gets and sets the property OperatingRegions. 
        /// <para>
        /// The operating Regions for an IPAM. Operating Regions are Amazon Web Services Regions
        /// where the IPAM is allowed to manage IP address CIDRs. IPAM only discovers and monitors
        /// resources in the Amazon Web Services Regions you select as operating Regions.
        /// </para>
        ///  
        /// <para>
        /// For more information about operating Regions, see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/create-ipam.html">Create
        /// an IPAM</a> in the <i>Amazon VPC IPAM User Guide</i>.
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
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The Amazon Web Services account ID of the owner of the IPAM.
        /// </para>
        /// </summary>
        public string OwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerId property is set.
        /// </summary>
        internal bool IsSetOwnerId() => this.OwnerId != null;

        /// <summary>
        /// Gets and sets the property PrivateDefaultScopeId. 
        /// <para>
        /// The ID of the IPAM's default private scope.
        /// </para>
        /// </summary>
        public string PrivateDefaultScopeId { get; set; }

        /// <summary>
        /// Checks to see if the PrivateDefaultScopeId property is set.
        /// </summary>
        internal bool IsSetPrivateDefaultScopeId() => this.PrivateDefaultScopeId != null;

        /// <summary>
        /// Gets and sets the property PublicDefaultScopeId. 
        /// <para>
        /// The ID of the IPAM's default public scope.
        /// </para>
        /// </summary>
        public string PublicDefaultScopeId { get; set; }

        /// <summary>
        /// Checks to see if the PublicDefaultScopeId property is set.
        /// </summary>
        internal bool IsSetPublicDefaultScopeId() => this.PublicDefaultScopeId != null;

        /// <summary>
        /// Gets and sets the property ResourceDiscoveryAssociationCount. 
        /// <para>
        /// The IPAM's resource discovery association count.
        /// </para>
        /// </summary>
        public int? ResourceDiscoveryAssociationCount { get; set; }

        /// <summary>
        /// Checks to see if the ResourceDiscoveryAssociationCount property is set.
        /// </summary>
        internal bool IsSetResourceDiscoveryAssociationCount() => this.ResourceDiscoveryAssociationCount.HasValue;

        /// <summary>
        /// Gets and sets the property ScopeCount. 
        /// <para>
        /// The number of scopes in the IPAM. The scope quota is 5. For more information on quotas,
        /// see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/quotas-ipam.html">Quotas
        /// in IPAM</a> in the <i>Amazon VPC IPAM User Guide</i>. 
        /// </para>
        /// </summary>
        public int? ScopeCount { get; set; }

        /// <summary>
        /// Checks to see if the ScopeCount property is set.
        /// </summary>
        internal bool IsSetScopeCount() => this.ScopeCount.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the IPAM.
        /// </para>
        /// </summary>
        public IpamState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StateMessage. 
        /// <para>
        /// The state message.
        /// </para>
        /// </summary>
        public string StateMessage { get; set; }

        /// <summary>
        /// Checks to see if the StateMessage property is set.
        /// </summary>
        internal bool IsSetStateMessage() => this.StateMessage != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The key/value combination of a tag assigned to the resource. Use the tag key in the
        /// filter name and the tag value as the filter value. For example, to find all resources
        /// that have a tag with the key <c>Owner</c> and the value <c>TeamA</c>, specify <c>tag:Owner</c>
        /// for the filter name and <c>TeamA</c> for the filter value.
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

        /// <summary>
        /// Gets and sets the property Tier. 
        /// <para>
        /// IPAM is offered in a Free Tier and an Advanced Tier. For more information about the
        /// features available in each tier and the costs associated with the tiers, see <a href="http://aws.amazon.com/vpc/pricing/">Amazon
        /// VPC pricing > IPAM tab</a>.
        /// </para>
        /// </summary>
        public IpamTier Tier { get; set; }

        /// <summary>
        /// Checks to see if the Tier property is set.
        /// </summary>
        internal bool IsSetTier() => this.Tier != null;
    }
}
