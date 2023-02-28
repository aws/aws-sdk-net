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
    /// Container for the parameters to the DescribeSpotInstanceRequests operation.
    /// Describes the specified Spot Instance requests.
    /// 
    ///  
    /// <para>
    /// You can use <code>DescribeSpotInstanceRequests</code> to find a running Spot Instance
    /// by examining the response. If the status of the Spot Instance is <code>fulfilled</code>,
    /// the instance ID appears in the response and contains the identifier of the instance.
    /// Alternatively, you can use <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeInstances">DescribeInstances</a>
    /// with a filter to look for instances where the instance lifecycle is <code>spot</code>.
    /// </para>
    ///  
    /// <para>
    /// We recommend that you set <code>MaxResults</code> to a value between 5 and 1000 to
    /// limit the number of items returned. This paginates the output, which makes the list
    /// more manageable and returns the items faster. If the list of items exceeds your <code>MaxResults</code>
    /// value, then that number of items is returned along with a <code>NextToken</code> value
    /// that can be passed to a subsequent <code>DescribeSpotInstanceRequests</code> request
    /// to retrieve the remaining items.
    /// </para>
    ///  
    /// <para>
    /// Spot Instance requests are deleted four hours after they are canceled and their instances
    /// are terminated.
    /// </para>
    /// </summary>
    public partial class DescribeSpotInstanceRequestsRequest : AmazonEC2Request
    {
        private List<Filter> _filters = new List<Filter>();
        private int? _maxResults;
        private string _nextToken;
        private List<string> _spotInstanceRequestIds = new List<string>();

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>availability-zone-group</code> - The Availability Zone group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>create-time</code> - The time stamp when the Spot Instance request was created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>fault-code</code> - The fault code related to the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>fault-message</code> - The fault message related to the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>instance-id</code> - The ID of the instance that fulfilled the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>launch-group</code> - The Spot Instance launch group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>launch.block-device-mapping.delete-on-termination</code> - Indicates whether
        /// the EBS volume is deleted on instance termination.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>launch.block-device-mapping.device-name</code> - The device name for the volume
        /// in the block device mapping (for example, <code>/dev/sdh</code> or <code>xvdh</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>launch.block-device-mapping.snapshot-id</code> - The ID of the snapshot for
        /// the EBS volume.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>launch.block-device-mapping.volume-size</code> - The size of the EBS volume,
        /// in GiB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>launch.block-device-mapping.volume-type</code> - The type of EBS volume: <code>gp2</code>
        /// for General Purpose SSD, <code>io1</code> or <code>io2</code> for Provisioned IOPS
        /// SSD, <code>st1</code> for Throughput Optimized HDD, <code>sc1</code>for Cold HDD,
        /// or <code>standard</code> for Magnetic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>launch.group-id</code> - The ID of the security group for the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>launch.group-name</code> - The name of the security group for the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>launch.image-id</code> - The ID of the AMI.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>launch.instance-type</code> - The type of instance (for example, <code>m3.medium</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>launch.kernel-id</code> - The kernel ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>launch.key-name</code> - The name of the key pair the instance launched with.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>launch.monitoring-enabled</code> - Whether detailed monitoring is enabled for
        /// the Spot Instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>launch.ramdisk-id</code> - The RAM disk ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>launched-availability-zone</code> - The Availability Zone in which the request
        /// is launched.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>network-interface.addresses.primary</code> - Indicates whether the IP address
        /// is the primary private IP address.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>network-interface.delete-on-termination</code> - Indicates whether the network
        /// interface is deleted when the instance is terminated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>network-interface.description</code> - A description of the network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>network-interface.device-index</code> - The index of the device for the network
        /// interface attachment on the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>network-interface.group-id</code> - The ID of the security group associated
        /// with the network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>network-interface.network-interface-id</code> - The ID of the network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>network-interface.private-ip-address</code> - The primary private IP address
        /// of the network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>network-interface.subnet-id</code> - The ID of the subnet for the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>product-description</code> - The product description associated with the instance
        /// (<code>Linux/UNIX</code> | <code>Windows</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>spot-instance-request-id</code> - The Spot Instance request ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>spot-price</code> - The maximum hourly price for any Spot Instance launched
        /// to fulfill the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>state</code> - The state of the Spot Instance request (<code>open</code> |
        /// <code>active</code> | <code>closed</code> | <code>cancelled</code> | <code>failed</code>).
        /// Spot request status information can help you track your Amazon EC2 Spot Instance requests.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-request-status.html">Spot
        /// request status</a> in the <i>Amazon EC2 User Guide for Linux Instances</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>status-code</code> - The short code describing the most recent evaluation of
        /// your Spot Instance request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>status-message</code> - The message explaining the status of the Spot Instance
        /// request.
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
        /// to find all resources assigned a tag with a specific key, regardless of the tag value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>type</code> - The type of Spot Instance request (<code>one-time</code> | <code>persistent</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>valid-from</code> - The start date of the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>valid-until</code> - The end date of the request.
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
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return for this request. To get the next page of items,
        /// make another request with the token returned in the output. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Query-Requests.html#api-pagination">Pagination</a>.
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

        /// <summary>
        /// Gets and sets the property SpotInstanceRequestIds. 
        /// <para>
        /// One or more Spot Instance request IDs.
        /// </para>
        /// </summary>
        public List<string> SpotInstanceRequestIds
        {
            get { return this._spotInstanceRequestIds; }
            set { this._spotInstanceRequestIds = value; }
        }

        // Check to see if SpotInstanceRequestIds property is set
        internal bool IsSetSpotInstanceRequestIds()
        {
            return this._spotInstanceRequestIds != null && this._spotInstanceRequestIds.Count > 0; 
        }

    }
}