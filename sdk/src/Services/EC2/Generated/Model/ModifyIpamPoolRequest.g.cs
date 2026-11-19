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
    /// Container for the parameters to the ModifyIpamPool operation. Modify the configurations
    /// of an IPAM pool. <para> For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/mod-pool-ipam.html">Modify
    /// a pool</a> in the <i>Amazon VPC IPAM User Guide</i>. </para>
    /// </summary>
    public partial class ModifyIpamPoolRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property AddAllocationResourceTags. 
        /// <para>
        /// Add tag allocation rules to a pool. For more information about allocation rules, see
        /// <a href="https://docs.aws.amazon.com/vpc/latest/ipam/create-top-ipam.html">Create
        /// a top-level pool</a> in the <i>Amazon VPC IPAM User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RequestIpamResourceTag> AddAllocationResourceTags { get; set; } = AWSConfigs.InitializeCollections ? new List<RequestIpamResourceTag>() : null;

        /// <summary>
        /// Checks to see if the AddAllocationResourceTags property is set.
        /// </summary>
        internal bool IsSetAddAllocationResourceTags() => this.AddAllocationResourceTags != null && (this.AddAllocationResourceTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AllocationDefaultNetmaskLength. 
        /// <para>
        /// The default netmask length for allocations added to this pool. If, for example, the
        /// CIDR assigned to this pool is 10.0.0.0/8 and you enter 16 here, new allocations will
        /// default to 10.0.0.0/16.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public int? AllocationDefaultNetmaskLength { get; set; }

        /// <summary>
        /// Checks to see if the AllocationDefaultNetmaskLength property is set.
        /// </summary>
        internal bool IsSetAllocationDefaultNetmaskLength() => this.AllocationDefaultNetmaskLength.HasValue;

        /// <summary>
        /// Gets and sets the property AllocationMaxNetmaskLength. 
        /// <para>
        /// The maximum netmask length possible for CIDR allocations in this IPAM pool to be compliant.
        /// Possible netmask lengths for IPv4 addresses are 0 - 32. Possible netmask lengths for
        /// IPv6 addresses are 0 - 128.The maximum netmask length must be greater than the minimum
        /// netmask length.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public int? AllocationMaxNetmaskLength { get; set; }

        /// <summary>
        /// Checks to see if the AllocationMaxNetmaskLength property is set.
        /// </summary>
        internal bool IsSetAllocationMaxNetmaskLength() => this.AllocationMaxNetmaskLength.HasValue;

        /// <summary>
        /// Gets and sets the property AllocationMinNetmaskLength. 
        /// <para>
        /// The minimum netmask length required for CIDR allocations in this IPAM pool to be compliant.
        /// Possible netmask lengths for IPv4 addresses are 0 - 32. Possible netmask lengths for
        /// IPv6 addresses are 0 - 128. The minimum netmask length must be less than the maximum
        /// netmask length.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public int? AllocationMinNetmaskLength { get; set; }

        /// <summary>
        /// Checks to see if the AllocationMinNetmaskLength property is set.
        /// </summary>
        internal bool IsSetAllocationMinNetmaskLength() => this.AllocationMinNetmaskLength.HasValue;

        /// <summary>
        /// Gets and sets the property AutoImport. 
        /// <para>
        /// If true, IPAM will continuously look for resources within the CIDR range of this pool
        /// and automatically import them as allocations into your IPAM. The CIDRs that will be
        /// allocated for these resources must not already be allocated to other resources in
        /// order for the import to succeed. IPAM will import a CIDR regardless of its compliance
        /// with the pool's allocation rules, so a resource might be imported and subsequently
        /// marked as noncompliant. If IPAM discovers multiple CIDRs that overlap, IPAM will import
        /// the largest CIDR only. If IPAM discovers multiple CIDRs with matching CIDRs, IPAM
        /// will randomly import one of them only. 
        /// </para>
        ///  
        /// <para>
        /// A locale must be set on the pool for this feature to work.
        /// </para>
        /// </summary>
        public bool? AutoImport { get; set; }

        /// <summary>
        /// Checks to see if the AutoImport property is set.
        /// </summary>
        internal bool IsSetAutoImport() => this.AutoImport.HasValue;

        /// <summary>
        /// Gets and sets the property ClearAllocationDefaultNetmaskLength. 
        /// <para>
        /// Clear the default netmask length allocation rule for this pool.
        /// </para>
        /// </summary>
        public bool? ClearAllocationDefaultNetmaskLength { get; set; }

        /// <summary>
        /// Checks to see if the ClearAllocationDefaultNetmaskLength property is set.
        /// </summary>
        internal bool IsSetClearAllocationDefaultNetmaskLength() => this.ClearAllocationDefaultNetmaskLength.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the IPAM pool you want to modify.
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
        /// Gets and sets the property IpamPoolId. 
        /// <para>
        /// The ID of the IPAM pool you want to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string IpamPoolId { get; set; }

        /// <summary>
        /// Checks to see if the IpamPoolId property is set.
        /// </summary>
        internal bool IsSetIpamPoolId() => this.IpamPoolId != null;

        /// <summary>
        /// Gets and sets the property RemoveAllocationResourceTags. 
        /// <para>
        /// Remove tag allocation rules from a pool.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RequestIpamResourceTag> RemoveAllocationResourceTags { get; set; } = AWSConfigs.InitializeCollections ? new List<RequestIpamResourceTag>() : null;

        /// <summary>
        /// Checks to see if the RemoveAllocationResourceTags property is set.
        /// </summary>
        internal bool IsSetRemoveAllocationResourceTags() => this.RemoveAllocationResourceTags != null && (this.RemoveAllocationResourceTags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
