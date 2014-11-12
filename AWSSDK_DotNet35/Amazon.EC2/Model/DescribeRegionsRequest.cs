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
    /// Container for the parameters to the DescribeRegions operation.
    /// Describes one or more regions that are currently available to you.
    /// 
    ///  
    /// <para>
    /// For a list of the regions supported by Amazon EC2, see <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#ec2_region">Regions
    /// and Endpoints</a>.
    /// </para>
    /// </summary>
    public partial class DescribeRegionsRequest : AmazonEC2Request
    {
        private List<Filter> _filters = new List<Filter>();
        private List<string> _regionNames = new List<string>();

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// <code>endpoint</code> - The endpoint of the region (for example, <code>ec2.us-east-1.amazonaws.com</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>region-name</code> - The name of the region (for example, <code>us-east-1</code>).
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
        /// Gets and sets the property RegionNames. 
        /// <para>
        /// The names of one or more regions.
        /// </para>
        /// </summary>
        public List<string> RegionNames
        {
            get { return this._regionNames; }
            set { this._regionNames = value; }
        }

        // Check to see if RegionNames property is set
        internal bool IsSetRegionNames()
        {
            return this._regionNames != null && this._regionNames.Count > 0; 
        }

    }
}