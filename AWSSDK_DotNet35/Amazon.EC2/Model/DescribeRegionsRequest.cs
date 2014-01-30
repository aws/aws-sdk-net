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
    /// Container for the parameters to the DescribeRegions operation.
    /// <para>Describes one or more regions that are currently available to you.</para> <para>For a list of the regions supported by Amazon EC2, see
    /// <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#ec2_region" >Regions and Endpoints</a> .</para>
    /// </summary>
    public partial class DescribeRegionsRequest : AmazonEC2Request
    {
        private List<string> regionNames = new List<string>();
        private List<Filter> filters = new List<Filter>();


        /// <summary>
        /// The names of one or more regions.
        ///  
        /// </summary>
        public List<string> RegionNames
        {
            get { return this.regionNames; }
            set { this.regionNames = value; }
        }

        // Check to see if RegionNames property is set
        internal bool IsSetRegionNames()
        {
            return this.regionNames.Count > 0;
        }

        /// <summary>
        /// One or more filters. <ul> <li> <c>endpoint</c> - The endpoint of the region (for example, <c>ec2.us-east-1.amazonaws.com</c>). </li> <li>
        /// <c>region-name</c> - The name of the region (for example, <c>us-east-1</c>). </li> </ul>
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
    
