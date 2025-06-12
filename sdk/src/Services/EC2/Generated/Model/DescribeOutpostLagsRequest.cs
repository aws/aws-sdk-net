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
    /// Container for the parameters to the DescribeOutpostLags operation.
    /// Describes the Outposts link aggregation groups (LAGs).
    /// 
    ///  <note> 
    /// <para>
    /// LAGs are only available for second-generation Outposts racks at this time.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DescribeOutpostLagsRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private int? _maxResults;
        private string _nextToken;
        private List<string> _outpostLagIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

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
        /// The filters to use for narrowing down the request. The following filters are supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>service-link-virtual-interface-id</c> - The ID of the service link virtual interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>service-link-virtual-interface-arn</c> - The ARN of the service link virtual interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>outpost-id</c> - The Outpost ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>outpost-arn</c> - The Outpost ARN.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>owner-id</c> - The ID of the Amazon Web Services account that owns the service
        /// link virtual interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>vlan</c> - The ID of the address pool.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>local-address</c> - The local address.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>peer-address</c> - The peer address.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>peer-bgp-asn</c> - The peer BGP ASN.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>outpost-lag-id</c> - The Outpost LAG ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>configuration-state</c> - The configuration state of the service link virtual
        /// interface.
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
        /// Gets and sets the property OutpostLagIds. 
        /// <para>
        /// The IDs of the Outpost LAGs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> OutpostLagIds
        {
            get { return this._outpostLagIds; }
            set { this._outpostLagIds = value; }
        }

        // Check to see if OutpostLagIds property is set
        internal bool IsSetOutpostLagIds()
        {
            return this._outpostLagIds != null && (this._outpostLagIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}