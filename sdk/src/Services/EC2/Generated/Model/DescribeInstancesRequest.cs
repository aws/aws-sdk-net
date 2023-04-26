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
    /// Container for the parameters to the DescribeInstances operation.
    /// Describes the specified instances or all instances.
    /// 
    ///  
    /// <para>
    /// If you specify instance IDs, the output includes information for only the specified
    /// instances. If you specify filters, the output includes information for only those
    /// instances that meet the filter criteria. If you do not specify instance IDs or filters,
    /// the output includes information for all instances, which can affect performance. We
    /// recommend that you use pagination to ensure that the operation returns quickly and
    /// successfully.
    /// </para>
    ///  
    /// <para>
    /// If you specify an instance ID that is not valid, an error is returned. If you specify
    /// an instance that you do not own, it is not included in the output.
    /// </para>
    ///  
    /// <para>
    /// Recently terminated instances might appear in the returned results. This interval
    /// is usually less than one hour.
    /// </para>
    ///  
    /// <para>
    /// If you describe instances in the rare case where an Availability Zone is experiencing
    /// a service disruption and you specify instance IDs that are in the affected zone, or
    /// do not specify any instance IDs at all, the call fails. If you describe instances
    /// and specify only instance IDs that are in an unaffected zone, the call works normally.
    /// </para>
    /// </summary>
    public partial class DescribeInstancesRequest : AmazonEC2Request
    {
        private List<Filter> _filters = new List<Filter>();
        private List<string> _instanceIds = new List<string>();
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>affinity</code> - The affinity setting for an instance running on a Dedicated
        /// Host (<code>default</code> | <code>host</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>architecture</code> - The instance architecture (<code>i386</code> | <code>x86_64</code>
        /// | <code>arm64</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>availability-zone</code> - The Availability Zone of the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>block-device-mapping.attach-time</code> - The attach time for an EBS volume
        /// mapped to the instance, for example, <code>2010-09-15T17:15:20.000Z</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>block-device-mapping.delete-on-termination</code> - A Boolean that indicates
        /// whether the EBS volume is deleted on instance termination.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>block-device-mapping.device-name</code> - The device name specified in the
        /// block device mapping (for example, <code>/dev/sdh</code> or <code>xvdh</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>block-device-mapping.status</code> - The status for the EBS volume (<code>attaching</code>
        /// | <code>attached</code> | <code>detaching</code> | <code>detached</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>block-device-mapping.volume-id</code> - The volume ID of the EBS volume.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>capacity-reservation-id</code> - The ID of the Capacity Reservation into which
        /// the instance was launched.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>client-token</code> - The idempotency token you provided when you launched
        /// the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>dns-name</code> - The public DNS name of the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>group-id</code> - The ID of the security group for the instance. EC2-Classic
        /// only.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>group-name</code> - The name of the security group for the instance. EC2-Classic
        /// only.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>hibernation-options.configured</code> - A Boolean that indicates whether the
        /// instance is enabled for hibernation. A value of <code>true</code> means that the instance
        /// is enabled for hibernation. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>host-id</code> - The ID of the Dedicated Host on which the instance is running,
        /// if applicable.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>hypervisor</code> - The hypervisor type of the instance (<code>ovm</code> |
        /// <code>xen</code>). The value <code>xen</code> is used for both Xen and Nitro hypervisors.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>iam-instance-profile.arn</code> - The instance profile associated with the
        /// instance. Specified as an ARN.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>image-id</code> - The ID of the image used to launch the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>instance-id</code> - The ID of the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>instance-lifecycle</code> - Indicates whether this is a Spot Instance or a
        /// Scheduled Instance (<code>spot</code> | <code>scheduled</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>instance-state-code</code> - The state of the instance, as a 16-bit unsigned
        /// integer. The high byte is used for internal purposes and should be ignored. The low
        /// byte is set based on the state represented. The valid values are: 0 (pending), 16
        /// (running), 32 (shutting-down), 48 (terminated), 64 (stopping), and 80 (stopped).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>instance-state-name</code> - The state of the instance (<code>pending</code>
        /// | <code>running</code> | <code>shutting-down</code> | <code>terminated</code> | <code>stopping</code>
        /// | <code>stopped</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>instance-type</code> - The type of instance (for example, <code>t2.micro</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>instance.group-id</code> - The ID of the security group for the instance. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>instance.group-name</code> - The name of the security group for the instance.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ip-address</code> - The public IPv4 address of the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>kernel-id</code> - The kernel ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>key-name</code> - The name of the key pair used when the instance was launched.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>launch-index</code> - When launching multiple instances, this is the index
        /// for the instance in the launch group (for example, 0, 1, 2, and so on). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>launch-time</code> - The time when the instance was launched, in the ISO 8601
        /// format in the UTC time zone (YYYY-MM-DDThh:mm:ss.sssZ), for example, <code>2021-09-29T11:04:43.305Z</code>.
        /// You can use a wildcard (<code>*</code>), for example, <code>2021-09-29T*</code>, which
        /// matches an entire day.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>metadata-options.http-tokens</code> - The metadata request authorization state
        /// (<code>optional</code> | <code>required</code>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>metadata-options.http-put-response-hop-limit</code> - The HTTP metadata request
        /// put response hop limit (integer, possible values <code>1</code> to <code>64</code>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>metadata-options.http-endpoint</code> - The status of access to the HTTP metadata
        /// endpoint on your instance (<code>enabled</code> | <code>disabled</code>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>metadata-options.instance-metadata-tags</code> - The status of access to instance
        /// tags from the instance metadata (<code>enabled</code> | <code>disabled</code>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>monitoring-state</code> - Indicates whether detailed monitoring is enabled
        /// (<code>disabled</code> | <code>enabled</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>network-interface.addresses.private-ip-address</code> - The private IPv4 address
        /// associated with the network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>network-interface.addresses.primary</code> - Specifies whether the IPv4 address
        /// of the network interface is the primary private IPv4 address.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>network-interface.addresses.association.public-ip</code> - The ID of the association
        /// of an Elastic IP address (IPv4) with a network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>network-interface.addresses.association.ip-owner-id</code> - The owner ID of
        /// the private IPv4 address associated with the network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>network-interface.association.public-ip</code> - The address of the Elastic
        /// IP address (IPv4) bound to the network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>network-interface.association.ip-owner-id</code> - The owner of the Elastic
        /// IP address (IPv4) associated with the network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>network-interface.association.allocation-id</code> - The allocation ID returned
        /// when you allocated the Elastic IP address (IPv4) for your network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>network-interface.association.association-id</code> - The association ID returned
        /// when the network interface was associated with an IPv4 address.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>network-interface.attachment.attachment-id</code> - The ID of the interface
        /// attachment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>network-interface.attachment.instance-id</code> - The ID of the instance to
        /// which the network interface is attached.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>network-interface.attachment.instance-owner-id</code> - The owner ID of the
        /// instance to which the network interface is attached.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>network-interface.attachment.device-index</code> - The device index to which
        /// the network interface is attached.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>network-interface.attachment.status</code> - The status of the attachment (<code>attaching</code>
        /// | <code>attached</code> | <code>detaching</code> | <code>detached</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>network-interface.attachment.attach-time</code> - The time that the network
        /// interface was attached to an instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>network-interface.attachment.delete-on-termination</code> - Specifies whether
        /// the attachment is deleted when an instance is terminated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>network-interface.availability-zone</code> - The Availability Zone for the
        /// network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>network-interface.description</code> - The description of the network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>network-interface.group-id</code> - The ID of a security group associated with
        /// the network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>network-interface.group-name</code> - The name of a security group associated
        /// with the network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>network-interface.ipv6-addresses.ipv6-address</code> - The IPv6 address associated
        /// with the network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>network-interface.mac-address</code> - The MAC address of the network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>network-interface.network-interface-id</code> - The ID of the network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>network-interface.owner-id</code> - The ID of the owner of the network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>network-interface.private-dns-name</code> - The private DNS name of the network
        /// interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>network-interface.requester-id</code> - The requester ID for the network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>network-interface.requester-managed</code> - Indicates whether the network
        /// interface is being managed by Amazon Web Services.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>network-interface.status</code> - The status of the network interface (<code>available</code>)
        /// | <code>in-use</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>network-interface.source-dest-check</code> - Whether the network interface
        /// performs source/destination checking. A value of <code>true</code> means that checking
        /// is enabled, and <code>false</code> means that checking is disabled. The value must
        /// be <code>false</code> for the network interface to perform network address translation
        /// (NAT) in your VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>network-interface.subnet-id</code> - The ID of the subnet for the network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>network-interface.vpc-id</code> - The ID of the VPC for the network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>outpost-arn</code> - The Amazon Resource Name (ARN) of the Outpost.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>owner-id</code> - The Amazon Web Services account ID of the instance owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>placement-group-name</code> - The name of the placement group for the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>placement-partition-number</code> - The partition in which the instance is
        /// located.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>platform</code> - The platform. To list only Windows instances, use <code>windows</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>private-dns-name</code> - The private IPv4 DNS name of the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>private-ip-address</code> - The private IPv4 address of the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>product-code</code> - The product code associated with the AMI used to launch
        /// the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>product-code.type</code> - The type of product code (<code>devpay</code> |
        /// <code>marketplace</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ramdisk-id</code> - The RAM disk ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>reason</code> - The reason for the current state of the instance (for example,
        /// shows "User Initiated [date]" when you stop or terminate the instance). Similar to
        /// the state-reason-code filter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>requester-id</code> - The ID of the entity that launched the instance on your
        /// behalf (for example, Amazon Web Services Management Console, Auto Scaling, and so
        /// on).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>reservation-id</code> - The ID of the instance's reservation. A reservation
        /// ID is created any time you launch an instance. A reservation ID has a one-to-one relationship
        /// with an instance launch request, but can be associated with more than one instance
        /// if you launch multiple instances using the same launch request. For example, if you
        /// launch one instance, you get one reservation ID. If you launch ten instances using
        /// the same launch request, you also get one reservation ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>root-device-name</code> - The device name of the root device volume (for example,
        /// <code>/dev/sda1</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>root-device-type</code> - The type of the root device volume (<code>ebs</code>
        /// | <code>instance-store</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>source-dest-check</code> - Indicates whether the instance performs source/destination
        /// checking. A value of <code>true</code> means that checking is enabled, and <code>false</code>
        /// means that checking is disabled. The value must be <code>false</code> for the instance
        /// to perform network address translation (NAT) in your VPC. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>spot-instance-request-id</code> - The ID of the Spot Instance request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>state-reason-code</code> - The reason code for the state change.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>state-reason-message</code> - A message that describes the state change.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>subnet-id</code> - The ID of the subnet for the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>tag:&lt;key&gt;</code> - The key/value combination of a tag assigned to the
        /// resource. Use the tag key in the filter name and the tag value as the filter value.
        /// For example, to find all resources that have a tag with the key <code>Owner</code>
        /// and the value <code>TeamA</code>, specify <code>tag:Owner</code> for the filter name
        /// and <code>TeamA</code> for the filter value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>tag-key</code> - The key of a tag assigned to the resource. Use this filter
        /// to find all resources that have a tag with a specific key, regardless of the tag value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>tenancy</code> - The tenancy of an instance (<code>dedicated</code> | <code>default</code>
        /// | <code>host</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>virtualization-type</code> - The virtualization type of the instance (<code>paravirtual</code>
        /// | <code>hvm</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>vpc-id</code> - The ID of the VPC that the instance is running in.
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
        /// Gets and sets the property InstanceIds. 
        /// <para>
        /// The instance IDs.
        /// </para>
        ///  
        /// <para>
        /// Default: Describes all your instances.
        /// </para>
        /// </summary>
        public List<string> InstanceIds
        {
            get { return this._instanceIds; }
            set { this._instanceIds = value; }
        }

        // Check to see if InstanceIds property is set
        internal bool IsSetInstanceIds()
        {
            return this._instanceIds != null && this._instanceIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return for this request. To get the next page of items,
        /// make another request with the token returned in the output. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Query-Requests.html#api-pagination">Pagination</a>.
        /// </para>
        ///  
        /// <para>
        /// You cannot specify this parameter and the instance IDs parameter in the same request.
        /// </para>
        /// </summary>
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