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
    /// Container for the parameters to the CreateIpam operation. Create an IPAM. Amazon VPC
    /// IP Address Manager (IPAM) is a VPC feature that you can use to automate your IP address
    /// management workflows including assigning, tracking, troubleshooting, and auditing
    /// IP addresses across Amazon Web Services Regions and accounts throughout your Amazon
    /// Web Services Organization. <para> For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/create-ipam.html">Create
    /// an IPAM</a> in the <i>Amazon VPC IPAM User Guide</i>. </para>
    /// </summary>
    public partial class CreateIpamRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. For more information, see <a href="https://docs.aws.amazon.com/ec2/latest/devguide/ec2-api-idempotency.html">Ensuring
        /// idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the IPAM.
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
        /// The operating Regions for the IPAM. Operating Regions are Amazon Web Services Regions
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
        [AWSProperty(Min = 0, Max = 50)]
        public List<AddIpamOperatingRegion> OperatingRegions { get; set; } = AWSConfigs.InitializeCollections ? new List<AddIpamOperatingRegion>() : null;

        /// <summary>
        /// Checks to see if the OperatingRegions property is set.
        /// </summary>
        internal bool IsSetOperatingRegions() => this.OperatingRegions != null && (this.OperatingRegions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
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
        public List<TagSpecification> TagSpecifications { get; set; } = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

        /// <summary>
        /// Checks to see if the TagSpecifications property is set.
        /// </summary>
        internal bool IsSetTagSpecifications() => this.TagSpecifications != null && (this.TagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections);

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
