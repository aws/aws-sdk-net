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
    /// Container for the parameters to the DescribeTransitGatewayPeeringAttachments operation.
    /// Describes your transit gateway peering attachments.
    /// </summary>
    public partial class DescribeTransitGatewayPeeringAttachmentsRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private int? _maxResults;
        private string _nextToken;
        private List<string> _transitGatewayAttachmentIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

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
        /// One or more filters. The possible values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>transit-gateway-attachment-id</c> - The ID of the transit gateway attachment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>local-owner-id</c> - The ID of your Amazon Web Services account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>remote-owner-id</c> - The ID of the Amazon Web Services account in the remote
        /// Region that owns the transit gateway.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>state</c> - The state of the peering attachment. Valid values are <c>available</c>
        /// | <c>deleted</c> | <c>deleting</c> | <c>failed</c> | <c>failing</c> | <c>initiatingRequest</c>
        /// | <c>modifying</c> | <c>pendingAcceptance</c> | <c>pending</c> | <c>rollingBack</c>
        /// | <c>rejected</c> | <c>rejecting</c>).
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
        /// all resources that have a tag with a specific key, regardless of the tag value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>transit-gateway-id</c> - The ID of the transit gateway.
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
        /// Gets and sets the property TransitGatewayAttachmentIds. 
        /// <para>
        /// One or more IDs of the transit gateway peering attachments.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TransitGatewayAttachmentIds
        {
            get { return this._transitGatewayAttachmentIds; }
            set { this._transitGatewayAttachmentIds = value; }
        }

        // Check to see if TransitGatewayAttachmentIds property is set
        internal bool IsSetTransitGatewayAttachmentIds()
        {
            return this._transitGatewayAttachmentIds != null && (this._transitGatewayAttachmentIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}