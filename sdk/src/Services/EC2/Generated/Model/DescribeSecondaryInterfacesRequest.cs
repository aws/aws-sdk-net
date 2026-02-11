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
    /// Container for the parameters to the DescribeSecondaryInterfaces operation.
    /// Describes one or more of your secondary interfaces.
    /// </summary>
    public partial class DescribeSecondaryInterfacesRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private int? _maxResults;
        private string _nextToken;
        private List<string> _secondaryInterfaceIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

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
        ///  <c>attachment.attachment-id</c> - The ID of the secondary interface attachment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>attachment.instance-id</c> - The ID of the instance to which the secondary interface
        /// is attached.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>attachment.instance-owner-id</c> - The ID of the Amazon Web Services account that
        /// owns the instance to which the secondary interface is attached.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>attachment.status</c> - The attachment status (<c>attaching</c> | <c>attached</c>
        /// | <c>detaching</c> | <c>detached</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>private-ipv4-addresses.private-ip-address</c> - The private IPv4 address associated
        /// with the secondary interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>owner-id</c> - The ID of the Amazon Web Services account that owns the secondary
        /// interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>secondary-interface-arn</c> - The ARN of the secondary interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>secondary-interface-id</c> - The ID of the secondary interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>secondary-interface-type</c> - The type of secondary interface (<c>secondary</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>secondary-network-id</c> - The ID of the secondary network.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>secondary-network-type</c> - The type of the secondary network (<c>rdma</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>secondary-subnet-id</c> - The ID of the secondary subnet.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>status</c> - The status of the secondary interface (<c>available</c> | <c>in-use</c>).
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
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return with a single call. To retrieve the remaining
        /// results, make another call with the returned <c>nextToken</c> value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=1000)]
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
        /// The token for the next page of results.
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
        /// Gets and sets the property SecondaryInterfaceIds. 
        /// <para>
        /// The IDs of the secondary interfaces.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecondaryInterfaceIds
        {
            get { return this._secondaryInterfaceIds; }
            set { this._secondaryInterfaceIds = value; }
        }

        // Check to see if SecondaryInterfaceIds property is set
        internal bool IsSetSecondaryInterfaceIds()
        {
            return this._secondaryInterfaceIds != null && (this._secondaryInterfaceIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}