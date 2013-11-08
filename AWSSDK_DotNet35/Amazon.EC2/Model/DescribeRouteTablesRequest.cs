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
    /// <para> Gives you information about your route tables. You can filter the results to return information only about tables that match criteria
    /// you specify. For example, you could get information only about a table associated with a particular subnet. You can specify multiple values
    /// for the filter. The table must match at least one of the specified values for it to be included in the results. </para> <para> You can
    /// specify multiple filters (e.g., the table has a particular route, and is associated with a particular subnet). The result includes
    /// information for a particular table only if it matches all your filters. If there's no match, no special message is returned; the response is
    /// simply empty. </para> <para> You can use wildcards with the filter values: an asterisk matches zero or more characters, and <c>?</c> matches
    /// exactly one character. You can escape special characters using a backslash before the character. For example, a value of <c>\*amazon\?\\</c>
    /// searches for the literal string <c>*amazon?\</c> .
    /// </para>
    /// </summary>
    public partial class DescribeRouteTablesRequest : AmazonEC2Request
    {
        private List<string> routeTableIds = new List<string>();
        private List<Filter> filters = new List<Filter>();


        /// <summary>
        /// One or more route table IDs.
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
        /// A list of filters used to match properties for Route Tables. For a complete reference to the available filter keys for this operation, see
        /// the <a href="http://docs.amazonwebservices.com/AWSEC2/latest/APIReference/">Amazon EC2 API reference</a>.
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
    
