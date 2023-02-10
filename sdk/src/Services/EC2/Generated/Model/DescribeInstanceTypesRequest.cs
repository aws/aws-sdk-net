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
    /// Container for the parameters to the DescribeInstanceTypes operation.
    /// Describes the details of the instance types that are offered in a location. The results
    /// can be filtered by the attributes of the instance types.
    /// </summary>
    public partial class DescribeInstanceTypesRequest : AmazonEC2Request
    {
        private List<Filter> _filters = new List<Filter>();
        private List<string> _instanceTypes = new List<string>();
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters. Filter names and values are case-sensitive.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>auto-recovery-supported</code> - Indicates whether auto recovery is supported
        /// (<code>true</code> | <code>false</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>bare-metal</code> - Indicates whether it is a bare metal instance type (<code>true</code>
        /// | <code>false</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>burstable-performance-supported</code> - Indicates whether it is a burstable
        /// performance instance type (<code>true</code> | <code>false</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>current-generation</code> - Indicates whether this instance type is the latest
        /// generation instance type of an instance family (<code>true</code> | <code>false</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ebs-info.ebs-optimized-info.baseline-bandwidth-in-mbps</code> - The baseline
        /// bandwidth performance for an EBS-optimized instance type, in Mbps.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ebs-info.ebs-optimized-info.baseline-iops</code> - The baseline input/output
        /// storage operations per second for an EBS-optimized instance type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ebs-info.ebs-optimized-info.baseline-throughput-in-mbps</code> - The baseline
        /// throughput performance for an EBS-optimized instance type, in MB/s.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ebs-info.ebs-optimized-info.maximum-bandwidth-in-mbps</code> - The maximum
        /// bandwidth performance for an EBS-optimized instance type, in Mbps.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ebs-info.ebs-optimized-info.maximum-iops</code> - The maximum input/output
        /// storage operations per second for an EBS-optimized instance type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ebs-info.ebs-optimized-info.maximum-throughput-in-mbps</code> - The maximum
        /// throughput performance for an EBS-optimized instance type, in MB/s.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ebs-info.ebs-optimized-support</code> - Indicates whether the instance type
        /// is EBS-optimized (<code>supported</code> | <code>unsupported</code> | <code>default</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ebs-info.encryption-support</code> - Indicates whether EBS encryption is supported
        /// (<code>supported</code> | <code>unsupported</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ebs-info.nvme-support</code> - Indicates whether non-volatile memory express
        /// (NVMe) is supported for EBS volumes (<code>required</code> | <code>supported</code>
        /// | <code>unsupported</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>free-tier-eligible</code> - Indicates whether the instance type is eligible
        /// to use in the free tier (<code>true</code> | <code>false</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>hibernation-supported</code> - Indicates whether On-Demand hibernation is supported
        /// (<code>true</code> | <code>false</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>hypervisor</code> - The hypervisor (<code>nitro</code> | <code>xen</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>instance-storage-info.disk.count</code> - The number of local disks.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>instance-storage-info.disk.size-in-gb</code> - The storage size of each instance
        /// storage disk, in GB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>instance-storage-info.disk.type</code> - The storage technology for the local
        /// instance storage disks (<code>hdd</code> | <code>ssd</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>instance-storage-info.encryption-support</code> - Indicates whether data is
        /// encrypted at rest (<code>required</code> | <code>supported</code> | <code>unsupported</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>instance-storage-info.nvme-support</code> - Indicates whether non-volatile
        /// memory express (NVMe) is supported for instance store (<code>required</code> | <code>supported</code>
        /// | <code>unsupported</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>instance-storage-info.total-size-in-gb</code> - The total amount of storage
        /// available from all local instance storage, in GB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>instance-storage-supported</code> - Indicates whether the instance type has
        /// local instance storage (<code>true</code> | <code>false</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>instance-type</code> - The instance type (for example <code>c5.2xlarge</code>
        /// or c5*).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>memory-info.size-in-mib</code> - The memory size.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>network-info.efa-info.maximum-efa-interfaces</code> - The maximum number of
        /// Elastic Fabric Adapters (EFAs) per instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>network-info.efa-supported</code> - Indicates whether the instance type supports
        /// Elastic Fabric Adapter (EFA) (<code>true</code> | <code>false</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>network-info.ena-support</code> - Indicates whether Elastic Network Adapter
        /// (ENA) is supported or required (<code>required</code> | <code>supported</code> | <code>unsupported</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>network-info.encryption-in-transit-supported</code> - Indicates whether the
        /// instance type automatically encrypts in-transit traffic between instances (<code>true</code>
        /// | <code>false</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>network-info.ipv4-addresses-per-interface</code> - The maximum number of private
        /// IPv4 addresses per network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>network-info.ipv6-addresses-per-interface</code> - The maximum number of private
        /// IPv6 addresses per network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>network-info.ipv6-supported</code> - Indicates whether the instance type supports
        /// IPv6 (<code>true</code> | <code>false</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>network-info.maximum-network-cards</code> - The maximum number of network cards
        /// per instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>network-info.maximum-network-interfaces</code> - The maximum number of network
        /// interfaces per instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>network-info.network-performance</code> - The network performance (for example,
        /// "25 Gigabit").
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>processor-info.supported-architecture</code> - The CPU architecture (<code>arm64</code>
        /// | <code>i386</code> | <code>x86_64</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>processor-info.sustained-clock-speed-in-ghz</code> - The CPU clock speed, in
        /// GHz.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>supported-boot-mode</code> - The boot mode (<code>legacy-bios</code> | <code>uefi</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>supported-root-device-type</code> - The root device type (<code>ebs</code>
        /// | <code>instance-store</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>supported-usage-class</code> - The usage class (<code>on-demand</code> | <code>spot</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>supported-virtualization-type</code> - The virtualization type (<code>hvm</code>
        /// | <code>paravirtual</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>vcpu-info.default-cores</code> - The default number of cores for the instance
        /// type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>vcpu-info.default-threads-per-core</code> - The default number of threads per
        /// core for the instance type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>vcpu-info.default-vcpus</code> - The default number of vCPUs for the instance
        /// type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>vcpu-info.valid-cores</code> - The number of cores that can be configured for
        /// the instance type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>vcpu-info.valid-threads-per-core</code> - The number of threads per core that
        /// can be configured for the instance type. For example, "1" or "1,2".
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InstanceTypes. 
        /// <para>
        /// The instance types. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html">Instance
        /// types</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> InstanceTypes
        {
            get { return this._instanceTypes; }
            set { this._instanceTypes = value; }
        }

        // Check to see if InstanceTypes property is set
        internal bool IsSetInstanceTypes()
        {
            return this._instanceTypes != null && this._instanceTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return for this request. To get the next page of items,
        /// make another request with the token returned in the output. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Query-Requests.html#api-pagination">Pagination</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=100)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token returned from a previous paginated request. Pagination continues from the
        /// end of the items returned by the previous request.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}