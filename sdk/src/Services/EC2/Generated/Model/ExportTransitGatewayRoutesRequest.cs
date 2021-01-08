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
    /// Container for the parameters to the ExportTransitGatewayRoutes operation.
    /// Exports routes from the specified transit gateway route table to the specified S3
    /// bucket. By default, all routes are exported. Alternatively, you can filter by CIDR
    /// range.
    /// 
    ///  
    /// <para>
    /// The routes are saved to the specified bucket in a JSON file. For more information,
    /// see <a href="https://docs.aws.amazon.com/vpc/latest/tgw/tgw-route-tables.html#tgw-export-route-tables">Export
    /// Route Tables to Amazon S3</a> in <i>Transit Gateways</i>.
    /// </para>
    /// </summary>
    public partial class ExportTransitGatewayRoutesRequest : AmazonEC2Request
    {
        private List<Filter> _filters = new List<Filter>();
        private string _s3Bucket;
        private string _transitGatewayRouteTableId;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters. The possible values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>attachment.transit-gateway-attachment-id</code> - The id of the transit gateway
        /// attachment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>attachment.resource-id</code> - The resource id of the transit gateway attachment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>route-search.exact-match</code> - The exact match of the specified filter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>route-search.longest-prefix-match</code> - The longest prefix that matches
        /// the route.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>route-search.subnet-of-match</code> - The routes with a subnet that match the
        /// specified CIDR filter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>route-search.supernet-of-match</code> - The routes with a CIDR that encompass
        /// the CIDR filter. For example, if you have 10.0.1.0/29 and 10.0.1.0/31 routes in your
        /// route table and you specify supernet-of-match as 10.0.1.0/30, then the result returns
        /// 10.0.1.0/29.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>state</code> - The state of the route (<code>active</code> | <code>blackhole</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>transit-gateway-route-destination-cidr-block</code> - The CIDR range.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>type</code> - The type of route (<code>propagated</code> | <code>static</code>).
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