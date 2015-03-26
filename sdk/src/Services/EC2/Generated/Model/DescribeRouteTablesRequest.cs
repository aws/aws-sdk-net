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
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
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
    /// Container for the parameters to the DescribeRouteTables operation.
    /// Describes one or more of your route tables.
    /// 
    ///  
    /// <para>
    /// For more information about route tables, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html">Route
    /// Tables</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class DescribeRouteTablesRequest : AmazonEC2Request
    {
        private List<Filter> _filters = new List<Filter>();
        private List<string> _routeTableIds = new List<string>();

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// <code>association.route-table-association-id</code> - The ID of an association ID
        /// for the route table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>association.route-table-id</code> - The ID of the route table involved in the
        /// association.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>association.subnet-id</code> - The ID of the subnet involved in the association.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>association.main</code> - Indicates whether the route table is the main route
        /// table for the VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>route-table-id</code> - The ID of the route table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>route.destination-cidr-block</code> - The CIDR range specified in a route in
        /// the table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>route.gateway-id</code> - The ID of a gateway specified in a route in the table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>route.instance-id</code> - The ID of an instance specified in a route in the
        /// table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>route.origin</code> - Describes how the route was created. <code>CreateRouteTable</code>
        /// indicates that the route was automatically created when the route table was created;
        /// <code>CreateRoute</code> indicates that the route was manually added to the route
        /// table; <code>EnableVgwRoutePropagation</code> indicates that the route was propagated
        /// by route propagation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>route.state</code> - The state of a route in the route table (<code>active</code>
        /// | <code>blackhole</code>). The blackhole state indicates that the route's target isn't
        /// available (for example, the specified gateway isn't attached to the VPC, the specified
        /// NAT instance has been terminated, and so on).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>route.vpc-peering-connection-id</code> - The ID of a VPC peering connection
        /// specified in a route in the table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>tag</code>:<i>key</i>=<i>value</i> - The key/value combination of a tag assigned
        /// to the resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>tag-key</code> - The key of a tag assigned to the resource. This filter is independent
        /// of the <code>tag-value</code> filter. For example, if you use both the filter "tag-key=Purpose"
        /// and the filter "tag-value=X", you get any resources assigned both the tag key Purpose
        /// (regardless of what the tag's value is), and the tag value X (regardless of what the
        /// tag's key is). If you want to list only resources where Purpose is X, see the <code>tag</code>:<i>key</i>=<i>value</i>
        /// filter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>tag-value</code> - The value of a tag assigned to the resource. This filter
        /// is independent of the <code>tag-key</code> filter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>vpc-id</code> - The ID of the VPC for the route table.
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
        /// Gets and sets the property RouteTableIds. 
        /// <para>
        /// One or more route table IDs.
        /// </para>
        ///  
        /// <para>
        /// Default: Describes all your route tables.
        /// </para>
        /// </summary>
        public List<string> RouteTableIds
        {
            get { return this._routeTableIds; }
            set { this._routeTableIds = value; }
        }

        // Check to see if RouteTableIds property is set
        internal bool IsSetRouteTableIds()
        {
            return this._routeTableIds != null && this._routeTableIds.Count > 0; 
        }

    }
}