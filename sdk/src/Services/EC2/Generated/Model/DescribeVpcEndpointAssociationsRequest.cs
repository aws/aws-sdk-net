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
    /// Container for the parameters to the DescribeVpcEndpointAssociations operation.
    /// Describes the VPC resources, VPC endpoint services, Amazon Lattice services, or service
    /// networks associated with the VPC endpoint.
    /// </summary>
    public partial class DescribeVpcEndpointAssociationsRequest : AmazonEC2Request
    {
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private int? _maxResults;
        private string _nextToken;
        private List<string> _vpcEndpointIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>vpc-endpoint-id</c> - The ID of the VPC endpoint.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>associated-resource-accessibility</c> - The association state. When the state
        /// is <c>accessible</c>, it returns <c>AVAILABLE</c>. When the state is <c>inaccessible</c>,
        /// it returns <c>PENDING</c> or <c>FAILED</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>association-id</c> - The ID of the VPC endpoint association.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>associated-resource-id</c> - The ID of the associated resource configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>service-network-arn</c> - The Amazon Resource Name (ARN) of the associated service
        /// network. Only VPC endpoints of type service network will be returned.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>resource-configuration-group-arn</c> - The Amazon Resource Name (ARN) of the resource
        /// configuration of type GROUP.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>service-network-resource-association-id</c> - The ID of the association.
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
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum page size.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// The pagination token.
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
        /// Gets and sets the property VpcEndpointIds. 
        /// <para>
        /// The IDs of the VPC endpoints.
        /// </para>
        /// </summary>
        public List<string> VpcEndpointIds
        {
            get { return this._vpcEndpointIds; }
            set { this._vpcEndpointIds = value; }
        }

        // Check to see if VpcEndpointIds property is set
        internal bool IsSetVpcEndpointIds()
        {
            return this._vpcEndpointIds != null && (this._vpcEndpointIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}