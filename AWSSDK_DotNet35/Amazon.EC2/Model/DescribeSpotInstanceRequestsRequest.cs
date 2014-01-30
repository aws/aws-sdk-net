/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeSpotInstanceRequests operation.
    /// <para>Describes the Spot Instance requests that belong to your account. Spot Instances are instances that Amazon EC2 starts on your behalf
    /// when the maximum price that you specify exceeds the current Spot Price. Amazon EC2 periodically sets the Spot Price based on available Spot
    /// Instance capacity and current Spot Instance requests. For more information about Spot Instances, see <a
    /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances.html" >Spot Instances</a> in the <i>Amazon Elastic Compute
    /// Cloud User Guide</i> .</para> <para>You can use <c>DescribeSpotInstanceRequests</c> to find a running Spot Instance by examining the
    /// response. If the status of the Spot Instance is <c>fulfilled</c> , the instance ID appears in the response and contains the identifier of
    /// the instance. Alternatively, you can use DescribeInstances with a filter to look for instances where the instance lifecycle is <c>spot</c>
    /// .</para>
    /// </summary>
    public partial class DescribeSpotInstanceRequestsRequest : AmazonEC2Request
    {
        private List<string> spotInstanceRequestIds = new List<string>();
        private List<Filter> filters = new List<Filter>();


        /// <summary>
        /// One or more Spot Instance request IDs.
        ///  
        /// </summary>
        public List<string> SpotInstanceRequestIds
        {
            get { return this.spotInstanceRequestIds; }
            set { this.spotInstanceRequestIds = value; }
        }

        // Check to see if SpotInstanceRequestIds property is set
        internal bool IsSetSpotInstanceRequestIds()
        {
            return this.spotInstanceRequestIds.Count > 0;
        }

        /// <summary>
        /// One or more filters. <ul> <li> <c>availability-zone-group</c> - The Availability Zone group. </li> <li> <c>create-time</c> - The time stamp
        /// when the Spot Instance request was created. </li> <li> <c>fault-code</c> - The fault code related to the request. </li> <li>
        /// <c>fault-message</c> - The fault message related to the request. </li> <li> <c>instance-id</c> - The ID of the instance that fulfilled the
        /// request. </li> <li> <c>launch-group</c> - The Spot Instance launch group. </li> <li>
        /// <c>launch.block-device-mapping.delete-on-termination</c> - Indicates whether the Amazon EBS volume is deleted on instance termination. </li>
        /// <li> <c>launch.block-device-mapping.device-name</c> - The device name for the Amazon EBS volume (for example, <c>/dev/sdh</c>). </li> <li>
        /// <c>launch.block-device-mapping.snapshot-id</c> - The ID of the snapshot used for the Amazon EBS volume. </li> <li>
        /// <c>launch.block-device-mapping.volume-size</c> - The size of the Amazon EBS volume, in GiB. </li> <li>
        /// <c>launch.block-device-mapping.volume-type</c> - The type of the Amazon EBS volume (<c>standard</c> | <c>io1</c>). </li> <li>
        /// <c>launch.group-id</c> - The security group for the instance. </li> <li> <c>launch.image-id</c> - The ID of the AMI. </li> <li>
        /// <c>launch.instance-type</c> - The type of instance (for example, <c>m1.small</c>). </li> <li> <c>launch.kernel-id</c> - The kernel ID. </li>
        /// <li> <c>launch.key-name</c> - The name of the key pair the instance launched with. </li> <li> <c>launch.monitoring-enabled</c> - Whether
        /// monitoring is enabled for the Spot Instance. </li> <li> <c>launch.ramdisk-id</c> - The RAM disk ID. </li> <li>
        /// <c>launch.network-interface.network-interface-id</c> - The ID of the network interface. </li> <li>
        /// <c>launch.network-interface.device-index</c> - The index of the device for the network interface attachment on the instance. </li> <li>
        /// <c>launch.network-interface.subnet-id</c> - The ID of the subnet for the instance. </li> <li> <c>launch.network-interface.description</c> -
        /// A description of the network interface. </li> <li> <c>launch.network-interface.private-ip-address</c> - The primary private IP address of
        /// the network interface. </li> <li> <c>launch.network-interface.delete-on-termination</c> - Indicates whether the network interface is deleted
        /// when the instance is terminated. </li> <li> <c>launch.network-interface.group-id</c> - The ID of the security group associated with the
        /// network interface. </li> <li> <c>launch.network-interface.group-name</c> - The name of the security group associated with the network
        /// interface. </li> <li> <c>launch.network-interface.addresses.primary</c> - Indicates whether the IP address is the primary private IP
        /// address. </li> <li> <c>product-description</c> - The product description associated with the instance (<c>Linux/UNIX</c> | <c>Windows</c>).
        /// </li> <li> <c>spot-instance-request-id</c> - The Spot Instance request ID. </li> <li> <c>spot-price</c> - The maximum hourly price for any
        /// Spot Instance launched to fulfill the request. </li> <li> <c>state</c> - The state of the Spot Instance request (<c>open</c> | <c>active</c>
        /// | <c>closed</c> | <c>cancelled</c> | <c>failed</c>). </li> <li> <c>status-code</c> - The short code describing the most recent evaluation of
        /// your Spot Instance request. </li> <li> <c>status-message</c> - The message explaining the status of the Spot Instance request. </li> <li>
        /// <c>tag</c>:<i>key</i>=<i>value</i> - The key/value combination of a tag assigned to the resource. </li> <li> <c>tag-key</c> - The key of a
        /// tag assigned to the resource. This filter is independent of the <c>tag-value</c> filter. For example, if you use both the filter
        /// "tag-key=Purpose" and the filter "tag-value=X", you get any resources assigned both the tag key Purpose (regardless of what the tag's value
        /// is), and the tag value X (regardless of what the tag's key is). If you want to list only resources where Purpose is X, see the
        /// <c>tag</c>:<i>key</i>=<i>value</i> filter. </li> <li> <c>tag-value</c> - The value of a tag assigned to the resource. This filter is
        /// independent of the <c>tag-key</c> filter. </li> <li> <c>type</c> - The type of Spot Instance request (<c>one-time</c> | <c>persistent</c>).
        /// </li> <li> <c>launched-availability-zone</c> - The Availability Zone in which the bid is launched. </li> <li> <c>valid-from</c> - The start
        /// date of the request. </li> <li> <c>valid-until</c> - The end date of the request. </li> </ul>
        ///  
        /// </summary>
        public List<Filter> Filters
        {
            get { return this.filters; }
            set { this.filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this.filters.Count > 0;
        }

    }
}
    
