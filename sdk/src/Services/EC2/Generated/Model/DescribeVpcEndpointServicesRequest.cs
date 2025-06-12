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
    /// Container for the parameters to the DescribeVpcEndpointServices operation.
    /// Describes available services to which you can create a VPC endpoint.
    /// 
    ///  
    /// <para>
    /// When the service provider and the consumer have different accounts in multiple Availability
    /// Zones, and the consumer views the VPC endpoint service information, the response only
    /// includes the common Availability Zones. For example, when the service provider account
    /// uses <c>us-east-1a</c> and <c>us-east-1c</c> and the consumer uses <c>us-east-1a</c>
    /// and <c>us-east-1b</c>, the response includes the VPC endpoint services in the common
    /// Availability Zone, <c>us-east-1a</c>.
    /// </para>
    /// </summary>
    public partial class DescribeVpcEndpointServicesRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private int? _maxResults;
        private string _nextToken;
        private List<string> _serviceNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _serviceRegions = AWSConfigs.InitializeCollections ? new List<string>() : null;

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
        ///  <c>owner</c> - The ID or alias of the Amazon Web Services account that owns the service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>service-name</c> - The name of the service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>service-region</c> - The Region of the service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>service-type</c> - The type of service (<c>Interface</c> | <c>Gateway</c> | <c>GatewayLoadBalancer</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>supported-ip-address-types</c> - The IP address type (<c>ipv4</c> | <c>ipv6</c>).
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
        /// The maximum number of items to return for this request. The request returns a token
        /// that you can specify in a subsequent call to get the next set of results.
        /// </para>
        ///  
        /// <para>
        /// Constraint: If the value is greater than 1,000, we return only 1,000 items.
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
        /// The token for the next set of items to return. (You received this token from a prior
        /// call.)
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
        /// Gets and sets the property ServiceNames. 
        /// <para>
        /// The service names.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ServiceNames
        {
            get { return this._serviceNames; }
            set { this._serviceNames = value; }
        }

        // Check to see if ServiceNames property is set
        internal bool IsSetServiceNames()
        {
            return this._serviceNames != null && (this._serviceNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ServiceRegions. 
        /// <para>
        /// The service Regions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ServiceRegions
        {
            get { return this._serviceRegions; }
            set { this._serviceRegions = value; }
        }

        // Check to see if ServiceRegions property is set
        internal bool IsSetServiceRegions()
        {
            return this._serviceRegions != null && (this._serviceRegions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}