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
    /// Container for the parameters to the DescribeAddresses operation.
    /// Describes the specified Elastic IP addresses or all of your Elastic IP addresses.
    /// </summary>
    public partial class DescribeAddressesRequest : AmazonEC2Request
    {
        private List<string> _allocationIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _dryRun;
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private List<string> _publicIps = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AllocationIds. 
        /// <para>
        /// Information about the allocation IDs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AllocationIds
        {
            get { return this._allocationIds; }
            set { this._allocationIds = value; }
        }

        // Check to see if AllocationIds property is set
        internal bool IsSetAllocationIds()
        {
            return this._allocationIds != null && (this._allocationIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        ///  <c>allocation-id</c> - The allocation ID for the address.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>association-id</c> - The association ID for the address.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>instance-id</c> - The ID of the instance the address is associated with, if any.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>network-border-group</c> - A unique set of Availability Zones, Local Zones, or
        /// Wavelength Zones from where Amazon Web Services advertises IP addresses. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>network-interface-id</c> - The ID of the network interface that the address is
        /// associated with, if any.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>network-interface-owner-id</c> - The Amazon Web Services account ID of the owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>private-ip-address</c> - The private IP address associated with the Elastic IP
        /// address.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>public-ip</c> - The Elastic IP address, or the carrier IP address.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>tag</c>:&lt;key&gt; - The key/value combination of a tag assigned to the resource.
        /// Use the tag key in the filter name and the tag value as the filter value. For example,
        /// to find all resources that have a tag with the key <c>Owner</c> and the value <c>TeamA</c>,
        /// specify <c>tag:Owner</c> for the filter name and <c>TeamA</c> for the filter value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>tag-key</c> - The key of a tag assigned to the resource. Use this filter to find
        /// all resources assigned a tag with a specific key, regardless of the tag value.
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
        /// Gets and sets the property PublicIps. 
        /// <para>
        /// One or more Elastic IP addresses.
        /// </para>
        ///  
        /// <para>
        /// Default: Describes all your Elastic IP addresses.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PublicIps
        {
            get { return this._publicIps; }
            set { this._publicIps = value; }
        }

        // Check to see if PublicIps property is set
        internal bool IsSetPublicIps()
        {
            return this._publicIps != null && (this._publicIps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}