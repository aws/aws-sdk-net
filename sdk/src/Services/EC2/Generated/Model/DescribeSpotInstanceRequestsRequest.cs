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
    /// Container for the parameters to the DescribeSpotInstanceRequests operation.
    /// Describes the specified Spot Instance requests.
    /// 
    ///  
    /// <para>
    /// You can use <c>DescribeSpotInstanceRequests</c> to find a running Spot Instance by
    /// examining the response. If the status of the Spot Instance is <c>fulfilled</c>, the
    /// instance ID appears in the response and contains the identifier of the instance. Alternatively,
    /// you can use <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeInstances">DescribeInstances</a>
    /// with a filter to look for instances where the instance lifecycle is <c>spot</c>.
    /// </para>
    ///  
    /// <para>
    /// We recommend that you set <c>MaxResults</c> to a value between 5 and 1000 to limit
    /// the number of items returned. This paginates the output, which makes the list more
    /// manageable and returns the items faster. If the list of items exceeds your <c>MaxResults</c>
    /// value, then that number of items is returned along with a <c>NextToken</c> value that
    /// can be passed to a subsequent <c>DescribeSpotInstanceRequests</c> request to retrieve
    /// the remaining items.
    /// </para>
    ///  
    /// <para>
    /// Spot Instance requests are deleted four hours after they are canceled and their instances
    /// are terminated.
    /// </para>
    /// </summary>
    public partial class DescribeSpotInstanceRequestsRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private int? _maxResults;
        private string _nextToken;
        private List<string> _spotInstanceRequestIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

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
        /// The filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>availability-zone-group</c> - The Availability Zone group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>create-time</c> - The time stamp when the Spot Instance request was created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>fault-code</c> - The fault code related to the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>fault-message</c> - The fault message related to the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>instance-id</c> - The ID of the instance that fulfilled the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>launch-group</c> - The Spot Instance launch group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>launch.block-device-mapping.delete-on-termination</c> - Indicates whether the
        /// EBS volume is deleted on instance termination.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>launch.block-device-mapping.device-name</c> - The device name for the volume in
        /// the block device mapping (for example, <c>/dev/sdh</c> or <c>xvdh</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>launch.block-device-mapping.snapshot-id</c> - The ID of the snapshot for the EBS
        /// volume.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>launch.block-device-mapping.volume-size</c> - The size of the EBS volume, in GiB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>launch.block-device-mapping.volume-type</c> - The type of EBS volume: <c>gp2</c>
        /// or <c>gp3</c> for General Purpose SSD, <c>io1</c> or <c>io2</c> for Provisioned IOPS
        /// SSD, <c>st1</c> for Throughput Optimized HDD, <c>sc1</c> for Cold HDD, or <c>standard</c>
        /// for Magnetic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>launch.group-id</c> - The ID of the security group for the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>launch.group-name</c> - The name of the security group for the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>launch.image-id</c> - The ID of the AMI.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>launch.instance-type</c> - The type of instance (for example, <c>m3.medium</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>launch.kernel-id</c> - The kernel ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>launch.key-name</c> - The name of the key pair the instance launched with.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>launch.monitoring-enabled</c> - Whether detailed monitoring is enabled for the
        /// Spot Instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>launch.ramdisk-id</c> - The RAM disk ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>launched-availability-zone</c> - The Availability Zone in which the request is
        /// launched.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>launched-availability-zone-id</c> - The ID of the Availability Zone in which the
        /// request is launched.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>network-interface.addresses.primary</c> - Indicates whether the IP address is
        /// the primary private IP address.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>network-interface.delete-on-termination</c> - Indicates whether the network interface
        /// is deleted when the instance is terminated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>network-interface.description</c> - A description of the network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>network-interface.device-index</c> - The index of the device for the network interface
        /// attachment on the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>network-interface.group-id</c> - The ID of the security group associated with
        /// the network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>network-interface.network-interface-id</c> - The ID of the network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>network-interface.private-ip-address</c> - The primary private IP address of the
        /// network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>network-interface.subnet-id</c> - The ID of the subnet for the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>product-description</c> - The product description associated with the instance
        /// (<c>Linux/UNIX</c> | <c>Windows</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>spot-instance-request-id</c> - The Spot Instance request ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>spot-price</c> - The maximum hourly price for any Spot Instance launched to fulfill
        /// the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>state</c> - The state of the Spot Instance request (<c>open</c> | <c>active</c>
        /// | <c>closed</c> | <c>cancelled</c> | <c>failed</c>). Spot request status information
        /// can help you track your Amazon EC2 Spot Instance requests. For more information, see
        /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-request-status.html">Spot
        /// request status</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>status-code</c> - The short code describing the most recent evaluation of your
        /// Spot Instance request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>status-message</c> - The message explaining the status of the Spot Instance request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>tag:&lt;key&gt;</c> - The key/value combination of a tag assigned to the resource.
        /// Use the tag key in the filter name and the tag value as the filter value. For example,
        /// to find all resources that have a tag with the key <c>Owner</c> and the value <c>TeamA</c>,
        /// specify <c>tag:Owner</c> for the filter name and <c>TeamA</c> for the filter value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>tag-key</c> - The key of a tag assigned to the resource. Use this filter to find
        /// all resources assigned a tag with a specific key, regardless of the tag value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>type</c> - The type of Spot Instance request (<c>one-time</c> | <c>persistent</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>valid-from</c> - The start date of the request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>valid-until</c> - The end date of the request.
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
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return for this request. To get the next page of items,
        /// make another request with the token returned in the output. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Query-Requests.html#api-pagination">Pagination</a>.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property SpotInstanceRequestIds. 
        /// <para>
        /// The IDs of the Spot Instance requests.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SpotInstanceRequestIds
        {
            get { return this._spotInstanceRequestIds; }
            set { this._spotInstanceRequestIds = value; }
        }

        // Check to see if SpotInstanceRequestIds property is set
        internal bool IsSetSpotInstanceRequestIds()
        {
            return this._spotInstanceRequestIds != null && (this._spotInstanceRequestIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}