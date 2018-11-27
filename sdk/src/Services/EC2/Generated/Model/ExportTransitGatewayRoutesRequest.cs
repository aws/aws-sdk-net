/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ExportTransitGatewayRoutes operation.
    /// Exports routes from the specified transit gateway route table to the specified S3
    /// bucket. By default, all routes are exported. Alternatively, you can filter by CIDR
    /// range.
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
        ///  <code>transit-gateway-route-destination-cidr-block</code> - The CIDR range.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>transit-gateway-route-state</code> - The state of the route (<code>active</code>
        /// | <code>blackhole</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>transit-gateway-route-transit-gateway-attachment-id</code> - The ID of the
        /// attachment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>transit-gateway-route-type</code> - The route type (<code>static</code> | <code>propagated</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>transit-gateway-route-vpn-connection-id</code> - The ID of the VPN connection.
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