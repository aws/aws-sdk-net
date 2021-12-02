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
    /// Container for the parameters to the ModifyIpamPool operation.
    /// Modify the configurations of an IPAM pool.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="/vpc/latest/ipam/mod-pool-ipam.html">Modify a pool</a>
    /// in the <i>Amazon VPC IPAM User Guide</i>. 
    /// </para>
    /// </summary>
    public partial class ModifyIpamPoolRequest : AmazonEC2Request
    {
        private List<RequestIpamResourceTag> _addAllocationResourceTags = new List<RequestIpamResourceTag>();
        private int? _allocationDefaultNetmaskLength;
        private int? _allocationMaxNetmaskLength;
        private int? _allocationMinNetmaskLength;
        private bool? _autoImport;
        private bool? _clearAllocationDefaultNetmaskLength;
        private string _description;
        private string _ipamPoolId;
        private List<RequestIpamResourceTag> _removeAllocationResourceTags = new List<RequestIpamResourceTag>();

        /// <summary>
        /// Gets and sets the property AddAllocationResourceTags. 
        /// <para>
        /// Add tag allocation rules to a pool. For more information about allocation rules, see
        /// <a href="/vpc/latest/ipam/create-top-ipam.html">Create a top-level pool</a> in the
        /// <i>Amazon VPC IPAM User Guide</i>.
        /// </para>
        /// </summary>
        public List<RequestIpamResourceTag> AddAllocationResourceTags
        {
            get { return this._addAllocationResourceTags; }
            set { this._addAllocationResourceTags = value; }
        }

        // Check to see if AddAllocationResourceTags property is set
        internal bool IsSetAddAllocationResourceTags()
        {
            return this._addAllocationResourceTags != null && this._addAllocationResourceTags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AllocationDefaultNetmaskLength. 
        /// <para>
        /// The default netmask length for allocations added to this pool. If, for example, the
        /// CIDR assigned to this pool is 10.0.0.0/8 and you enter 16 here, new allocations will
        /// default to 10.0.0.0/16.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public int AllocationDefaultNetmaskLength
        {
            get { return this._allocationDefaultNetmaskLength.GetValueOrDefault(); }
            set { this._allocationDefaultNetmaskLength = value; }
        }

        // Check to see if AllocationDefaultNetmaskLength property is set
        internal bool IsSetAllocationDefaultNetmaskLength()
        {
            return this._allocationDefaultNetmaskLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AllocationMaxNetmaskLength. 
        /// <para>
        /// The maximum netmask length possible for CIDR allocations in this IPAM pool to be compliant.
        /// Possible netmask lengths for IPv4 addresses are 0 - 32. Possible netmask lengths for
        /// IPv6 addresses are 0 - 128.The maximum netmask length must be greater than the minimum
        /// netmask length.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public int AllocationMaxNetmaskLength
        {
            get { return this._allocationMaxNetmaskLength.GetValueOrDefault(); }
            set { this._allocationMaxNetmaskLength = value; }
        }

        // Check to see if AllocationMaxNetmaskLength property is set
        internal bool IsSetAllocationMaxNetmaskLength()
        {
            return this._allocationMaxNetmaskLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AllocationMinNetmaskLength. 
        /// <para>
        /// The minimum netmask length required for CIDR allocations in this IPAM pool to be compliant.
        /// Possible netmask lengths for IPv4 addresses are 0 - 32. Possible netmask lengths for
        /// IPv6 addresses are 0 - 128. The minimum netmask length must be less than the maximum
        /// netmask length.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public int AllocationMinNetmaskLength
        {
            get { return this._allocationMinNetmaskLength.GetValueOrDefault(); }
            set { this._allocationMinNetmaskLength = value; }
        }

        // Check to see if AllocationMinNetmaskLength property is set
        internal bool IsSetAllocationMinNetmaskLength()
        {
            return this._allocationMinNetmaskLength.HasValue; 
        }

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
        public bool AutoImport
        {
            get { return this._autoImport.GetValueOrDefault(); }
            set { this._autoImport = value; }
        }

        // Check to see if AutoImport property is set
        internal bool IsSetAutoImport()
        {
            return this._autoImport.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ClearAllocationDefaultNetmaskLength. 
        /// <para>
        /// Clear the default netmask length allocation rule for this pool.
        /// </para>
        /// </summary>
        public bool ClearAllocationDefaultNetmaskLength
        {
            get { return this._clearAllocationDefaultNetmaskLength.GetValueOrDefault(); }
            set { this._clearAllocationDefaultNetmaskLength = value; }
        }

        // Check to see if ClearAllocationDefaultNetmaskLength property is set
        internal bool IsSetClearAllocationDefaultNetmaskLength()
        {
            return this._clearAllocationDefaultNetmaskLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the IPAM pool you want to modify.
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
        /// Gets and sets the property IpamPoolId. 
        /// <para>
        /// The ID of the IPAM pool you want to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IpamPoolId
        {
            get { return this._ipamPoolId; }
            set { this._ipamPoolId = value; }
        }

        // Check to see if IpamPoolId property is set
        internal bool IsSetIpamPoolId()
        {
            return this._ipamPoolId != null;
        }

        /// <summary>
        /// Gets and sets the property RemoveAllocationResourceTags. 
        /// <para>
        /// Remove tag allocation rules from a pool.
        /// </para>
        /// </summary>
        public List<RequestIpamResourceTag> RemoveAllocationResourceTags
        {
            get { return this._removeAllocationResourceTags; }
            set { this._removeAllocationResourceTags = value; }
        }

        // Check to see if RemoveAllocationResourceTags property is set
        internal bool IsSetRemoveAllocationResourceTags()
        {
            return this._removeAllocationResourceTags != null && this._removeAllocationResourceTags.Count > 0; 
        }

    }
}