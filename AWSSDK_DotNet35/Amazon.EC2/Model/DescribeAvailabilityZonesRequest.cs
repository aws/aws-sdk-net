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
    /// Container for the parameters to the DescribeAvailabilityZones operation.
    /// <para>Describes one or more of the Availability Zones that are available to you. The results include zones only for the region you're
    /// currently using. If there is an event impacting an Availability Zone, you can use this request to view the state and any provided message
    /// for that Availability Zone.</para> <para>For more information, see <a
    /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-regions-availability-zones.html" >Regions and Availability Zones</a> in the
    /// <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
    /// </summary>
    public partial class DescribeAvailabilityZonesRequest : AmazonEC2Request
    {
        private List<string> zoneNames = new List<string>();
        private List<Filter> filters = new List<Filter>();


        /// <summary>
        /// The names of one or more Availability Zones.
        ///  
        /// </summary>
        public List<string> ZoneNames
        {
            get { return this.zoneNames; }
            set { this.zoneNames = value; }
        }

        // Check to see if ZoneNames property is set
        internal bool IsSetZoneNames()
        {
            return this.zoneNames.Count > 0;
        }

        /// <summary>
        /// One or more filters. <ul> <li> <c>message</c> - Information about the Availability Zone. </li> <li> <c>region-name</c> - The name of the
        /// region for the Availability Zone (for example, <c>us-east-1</c>). </li> <li> <c>state</c> - The state of the Availability Zone
        /// (<c>available</c> | <c>impaired</c> | <c>unavailable</c>). </li> <li> <c>zone-name</c> - The name of the Availability Zone (for example,
        /// <c>us-east-1a</c>). </li> </ul>
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
    
