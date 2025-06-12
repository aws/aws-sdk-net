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
    /// Container for the parameters to the ExportTransitGatewayRoutes operation.
    /// Exports routes from the specified transit gateway route table to the specified S3
    /// bucket. By default, all routes are exported. Alternatively, you can filter by CIDR
    /// range.
    /// 
    ///  
    /// <para>
    /// The routes are saved to the specified bucket in a JSON file. For more information,
    /// see <a href="https://docs.aws.amazon.com/vpc/latest/tgw/tgw-route-tables.html#tgw-export-route-tables">Export
    /// route tables to Amazon S3</a> in the <i>Amazon Web Services Transit Gateways Guide</i>.
    /// </para>
    /// </summary>
    public partial class ExportTransitGatewayRoutesRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private string _s3Bucket;
        private string _transitGatewayRouteTableId;

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
        ///  <c>attachment.transit-gateway-attachment-id</c> - The id of the transit gateway attachment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>attachment.resource-id</c> - The resource id of the transit gateway attachment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>route-search.exact-match</c> - The exact match of the specified filter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>route-search.longest-prefix-match</c> - The longest prefix that matches the route.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>route-search.subnet-of-match</c> - The routes with a subnet that match the specified
        /// CIDR filter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>route-search.supernet-of-match</c> - The routes with a CIDR that encompass the
        /// CIDR filter. For example, if you have 10.0.1.0/29 and 10.0.1.0/31 routes in your route
        /// table and you specify supernet-of-match as 10.0.1.0/30, then the result returns 10.0.1.0/29.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>state</c> - The state of the route (<c>active</c> | <c>blackhole</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>transit-gateway-route-destination-cidr-block</c> - The CIDR range.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>type</c> - The type of route (<c>propagated</c> | <c>static</c>).
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
        /// Gets and sets the property S3Bucket. 
        /// <para>
        /// The name of the S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string S3Bucket
        {
            get { return this._s3Bucket; }
            set { this._s3Bucket = value; }
        }

        // Check to see if S3Bucket property is set
        internal bool IsSetS3Bucket()
        {
            return this._s3Bucket != null;
        }

        /// <summary>
        /// Gets and sets the property TransitGatewayRouteTableId. 
        /// <para>
        /// The ID of the route table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TransitGatewayRouteTableId
        {
            get { return this._transitGatewayRouteTableId; }
            set { this._transitGatewayRouteTableId = value; }
        }

        // Check to see if TransitGatewayRouteTableId property is set
        internal bool IsSetTransitGatewayRouteTableId()
        {
            return this._transitGatewayRouteTableId != null;
        }

    }
}