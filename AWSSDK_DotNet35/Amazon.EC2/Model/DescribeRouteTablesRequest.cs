/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para>Describes one or more of your route tables.</para> <para>For more information about route tables, see <a
    /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html" >Route Tables</a> in the <i>Amazon Virtual Private Cloud
    /// User Guide</i> .</para>
    /// </summary>
    public partial class DescribeRouteTablesRequest : AmazonEC2Request
    {
        private List<string> routeTableIds = new List<string>();
        private List<Filter> filters = new List<Filter>();


        /// <summary>
        /// One or more route table IDs. Default: Describes all your route tables.
        ///  
        /// </summary>
        public List<string> RouteTableIds
        {
            get { return this.routeTableIds; }
            set { this.routeTableIds = value; }
        }

        // Check to see if RouteTableIds property is set
        internal bool IsSetRouteTableIds()
        {
            return this.routeTableIds.Count > 0;
        }

        /// <summary>
        /// One or more filters. <ul> <li> <c>association.route-table-association-id</c> - The ID of an association ID for the route table. </li> <li>
        /// <c>association.route-table-id</c> - The ID of the route table involved in the association. </li> <li> <c>association.subnet-id</c> - The ID
        /// of the subnet involved in the association. </li> <li> <c>association.main</c> - Indicates whether the route table is the main route table
        /// for the VPC. </li> <li> <c>route-table-id</c> - The ID of the route table. </li> <li> <c>route.destination-cidr-block</c> - The CIDR range
        /// specified in a route in the table. </li> <li> <c>route.gateway-id</c> - The ID of a gateway specified in a route in the table. </li> <li>
        /// <c>route.instance-id</c> - The ID of an instance specified in a route in the table. </li> <li> <c>route.origin</c> - Describes how the route
        /// was created (<c>CreateRouteTable</c> | <c>CreateRoute</c> | <c>EnableVgwRoutePropagation</c>). </li> <li> <c>route.state</c> - The state of
        /// a route in the route table (<c>active</c> | <c>blackhole</c>). The blackhole state indicates that the route's target isn't available (for
        /// example, the specified gateway isn't attached to the VPC, the specified NAT instance has been terminated, and so on). </li> <li>
        /// <c>tag</c>:<i>key</i>=<i>value</i> - The key/value combination of a tag assigned to the resource. </li> <li> <c>tag-key</c> - The key of a
        /// tag assigned to the resource. This filter is independent of the <c>tag-value</c> filter. For example, if you use both the filter
        /// "tag-key=Purpose" and the filter "tag-value=X", you get any resources assigned both the tag key Purpose (regardless of what the tag's value
        /// is), and the tag value X (regardless of what the tag's key is). If you want to list only resources where Purpose is X, see the
        /// <c>tag</c>:<i>key</i>=<i>value</i> filter. </li> <li> <c>tag-value</c> - The value of a tag assigned to the resource. This filter is
        /// independent of the <c>tag-key</c> filter. </li> <li> <c>vpc-id</c> - The ID of the VPC for the route table. </li> </ul>
        ///  
        /// </summary>
        public List<Filter> Filters
        {
            get { return this.filters; }
            set { this.filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this.filters.Count > 0;
        }

    }
}
    
