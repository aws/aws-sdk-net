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
    /// Container for the parameters to the DescribeTransitGatewayPeeringAttachments operation.
    /// Describes your transit gateway peering attachments.
    /// </summary>
    public partial class DescribeTransitGatewayPeeringAttachmentsRequest : AmazonEC2Request
    {
        private List<Filter> _filters = new List<Filter>();
        private int? _maxResults;
        private string _nextToken;
        private List<string> _transitGatewayAttachmentIds = new List<string>();

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters. The possible values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>transit-gateway-attachment-id</code> - The ID of the transit gateway attachment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>local-owner-id</code> - The ID of your AWS account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>remote-owner-id</code> - The ID of the AWS account in the remote Region that
        /// owns the transit gateway.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>state</code> - The state of the peering attachment. Valid values are <code>available</code>
        /// | <code>deleted</code> | <code>deleting</code> | <code>failed</code> | <code>failing</code>
        /// | <code>initiatingRequest</code> | <code>modifying</code> | <code>pendingAcceptance</code>
        /// | <code>pending</code> | <code>rollingBack</code> | <code>rejected</code> | <code>rejecting</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>tag</code>:&lt;key&gt; - The key/value combination of a tag assigned to the
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
        ///  <code>transit-gateway-id</code> - The ID of the transit gateway.
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
        /// The maximum number of results to return with a single call. To retrieve the remaining
        /// results, make another call with the returned <code>nextToken</code> value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=1000)]
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
        /// </summary>
        public List<string> TransitGatewayAttachmentIds
        {
            get { return this._transitGatewayAttachmentIds; }
            set { this._transitGatewayAttachmentIds = value; }
        }

        // Check to see if TransitGatewayAttachmentIds property is set
        internal bool IsSetTransitGatewayAttachmentIds()
        {
            return this._transitGatewayAttachmentIds != null && this._transitGatewayAttachmentIds.Count > 0; 
        }

    }
}