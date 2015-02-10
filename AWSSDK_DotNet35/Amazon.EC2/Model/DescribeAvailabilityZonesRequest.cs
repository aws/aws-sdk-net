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
    /// Container for the parameters to the DescribeAvailabilityZones operation.
    /// Describes one or more of the Availability Zones that are available to you. The results
    /// include zones only for the region you're currently using. If there is an event impacting
    /// an Availability Zone, you can use this request to view the state and any provided
    /// message for that Availability Zone.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-regions-availability-zones.html">Regions
    /// and Availability Zones</a> in the <i>Amazon Elastic Compute Cloud User Guide for Linux</i>.
    /// </para>
    /// </summary>
    public partial class DescribeAvailabilityZonesRequest : AmazonEC2Request
    {
        private List<Filter> _filters = new List<Filter>();
        private List<string> _zoneNames = new List<string>();

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// <code>message</code> - Information about the Availability Zone.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>region-name</code> - The name of the region for the Availability Zone (for example,
        /// <code>us-east-1</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>state</code> - The state of the Availability Zone (<code>available</code> |
        /// <code>impaired</code> | <code>unavailable</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>zone-name</code> - The name of the Availability Zone (for example, <code>us-east-1a</code>).
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
        /// Gets and sets the property ZoneNames. 
        /// <para>
        /// The names of one or more Availability Zones.
        /// </para>
        /// </summary>
        public List<string> ZoneNames
        {
            get { return this._zoneNames; }
            set { this._zoneNames = value; }
        }

        // Check to see if ZoneNames property is set
        internal bool IsSetZoneNames()
        {
            return this._zoneNames != null && this._zoneNames.Count > 0; 
        }

    }
}