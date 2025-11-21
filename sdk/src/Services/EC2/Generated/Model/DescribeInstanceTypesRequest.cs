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
    /// Container for the parameters to the DescribeInstanceTypes operation.
    /// Describes the specified instance types. By default, all instance types for the current
    /// Region are described. Alternatively, you can filter the results.
    /// </summary>
    public partial class DescribeInstanceTypesRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private List<string> _instanceTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
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
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters. Filter names and values are case-sensitive.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>auto-recovery-supported</c> - Indicates whether Amazon CloudWatch action based
        /// recovery is supported (<c>true</c> | <c>false</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>bare-metal</c> - Indicates whether it is a bare metal instance type (<c>true</c>
        /// | <c>false</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>burstable-performance-supported</c> - Indicates whether the instance type is a
        /// burstable performance T instance type (<c>true</c> | <c>false</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>current-generation</c> - Indicates whether this instance type is the latest generation
        /// instance type of an instance family (<c>true</c> | <c>false</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>dedicated-hosts-supported</c> - Indicates whether the instance type supports Dedicated
        /// Hosts. (<c>true</c> | <c>false</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ebs-info.attachment-limit-type</c> - The type of Amazon EBS volume attachment
        /// limit (<c>shared</c> | <c>dedicated</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ebs-info.maximum-ebs-attachments</c> - The maximum number of Amazon EBS volumes
        /// that can be attached to the instance type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ebs-info.ebs-optimized-info.baseline-bandwidth-in-mbps</c> - The baseline bandwidth
        /// performance for an EBS-optimized instance type, in Mbps.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ebs-info.ebs-optimized-info.baseline-iops</c> - The baseline input/output storage
        /// operations per second for an EBS-optimized instance type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ebs-info.ebs-optimized-info.baseline-throughput-in-mbps</c> - The baseline throughput
        /// performance for an EBS-optimized instance type, in MB/s.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ebs-info.ebs-optimized-info.maximum-bandwidth-in-mbps</c> - The maximum bandwidth
        /// performance for an EBS-optimized instance type, in Mbps.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ebs-info.ebs-optimized-info.maximum-iops</c> - The maximum input/output storage
        /// operations per second for an EBS-optimized instance type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ebs-info.ebs-optimized-info.maximum-throughput-in-mbps</c> - The maximum throughput
        /// performance for an EBS-optimized instance type, in MB/s.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ebs-info.ebs-optimized-support</c> - Indicates whether the instance type is EBS-optimized
        /// (<c>supported</c> | <c>unsupported</c> | <c>default</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ebs-info.encryption-support</c> - Indicates whether EBS encryption is supported
        /// (<c>supported</c> | <c>unsupported</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ebs-info.nvme-support</c> - Indicates whether non-volatile memory express (NVMe)
        /// is supported for EBS volumes (<c>required</c> | <c>supported</c> | <c>unsupported</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>free-tier-eligible</c> - A Boolean that indicates whether this instance type can
        /// be used under the Amazon Web Services Free Tier (<c>true</c> | <c>false</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>hibernation-supported</c> - Indicates whether On-Demand hibernation is supported
        /// (<c>true</c> | <c>false</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>hypervisor</c> - The hypervisor (<c>nitro</c> | <c>xen</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>instance-storage-info.disk.count</c> - The number of local disks.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>instance-storage-info.disk.size-in-gb</c> - The storage size of each instance
        /// storage disk, in GB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>instance-storage-info.disk.type</c> - The storage technology for the local instance
        /// storage disks (<c>hdd</c> | <c>ssd</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>instance-storage-info.encryption-support</c> - Indicates whether data is encrypted
        /// at rest (<c>required</c> | <c>supported</c> | <c>unsupported</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>instance-storage-info.nvme-support</c> - Indicates whether non-volatile memory
        /// express (NVMe) is supported for instance store (<c>required</c> | <c>supported</c>
        /// | <c>unsupported</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>instance-storage-info.total-size-in-gb</c> - The total amount of storage available
        /// from all local instance storage, in GB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>instance-storage-supported</c> - Indicates whether the instance type has local
        /// instance storage (<c>true</c> | <c>false</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>instance-type</c> - The instance type (for example <c>c5.2xlarge</c> or c5*).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>memory-info.size-in-mib</c> - The memory size.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>network-info.bandwidth-weightings</c> - For instances that support bandwidth weighting
        /// to boost performance (<c>default</c>, <c>vpc-1</c>, <c>ebs-1</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>network-info.efa-info.maximum-efa-interfaces</c> - The maximum number of Elastic
        /// Fabric Adapters (EFAs) per instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>network-info.efa-supported</c> - Indicates whether the instance type supports
        /// Elastic Fabric Adapter (EFA) (<c>true</c> | <c>false</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>network-info.ena-support</c> - Indicates whether Elastic Network Adapter (ENA)
        /// is supported or required (<c>required</c> | <c>supported</c> | <c>unsupported</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>network-info.flexible-ena-queues-support</c> - Indicates whether an instance supports
        /// flexible ENA queues (<c>supported</c> | <c>unsupported</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>network-info.encryption-in-transit-supported</c> - Indicates whether the instance
        /// type automatically encrypts in-transit traffic between instances (<c>true</c> | <c>false</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>network-info.ipv4-addresses-per-interface</c> - The maximum number of private
        /// IPv4 addresses per network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>network-info.ipv6-addresses-per-interface</c> - The maximum number of private
        /// IPv6 addresses per network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>network-info.ipv6-supported</c> - Indicates whether the instance type supports
        /// IPv6 (<c>true</c> | <c>false</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>network-info.maximum-network-cards</c> - The maximum number of network cards per
        /// instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>network-info.maximum-network-interfaces</c> - The maximum number of network interfaces
        /// per instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>network-info.network-performance</c> - The network performance (for example, "25
        /// Gigabit").
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>nitro-enclaves-support</c> - Indicates whether Nitro Enclaves is supported (<c>supported</c>
        /// | <c>unsupported</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>nitro-tpm-support</c> - Indicates whether NitroTPM is supported (<c>supported</c>
        /// | <c>unsupported</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>nitro-tpm-info.supported-versions</c> - The supported NitroTPM version (<c>2.0</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>processor-info.supported-architecture</c> - The CPU architecture (<c>arm64</c>
        /// | <c>i386</c> | <c>x86_64</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>processor-info.sustained-clock-speed-in-ghz</c> - The CPU clock speed, in GHz.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>processor-info.supported-features</c> - The supported CPU features (<c>amd-sev-snp</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>reboot-migration-support</c> - Indicates whether enabling reboot migration is
        /// supported (<c>supported</c> | <c>unsupported</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>supported-boot-mode</c> - The boot mode (<c>legacy-bios</c> | <c>uefi</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>supported-root-device-type</c> - The root device type (<c>ebs</c> | <c>instance-store</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>supported-usage-class</c> - The usage class (<c>on-demand</c> | <c>spot</c> |
        /// <c>capacity-block</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>supported-virtualization-type</c> - The virtualization type (<c>hvm</c> | <c>paravirtual</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>vcpu-info.default-cores</c> - The default number of cores for the instance type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>vcpu-info.default-threads-per-core</c> - The default number of threads per core
        /// for the instance type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>vcpu-info.default-vcpus</c> - The default number of vCPUs for the instance type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>vcpu-info.valid-cores</c> - The number of cores that can be configured for the
        /// instance type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>vcpu-info.valid-threads-per-core</c> - The number of threads per core that can
        /// be configured for the instance type. For example, "1" or "1,2".
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InstanceTypes. 
        /// <para>
        /// The instance types.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._instanceTypes != null && (this._instanceTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        public int? MaxResults
        {
            get { return this._maxResults; }
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