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
    /// Container for the parameters to the DescribeAvailabilityZones operation.
    /// Describes the Availability Zones, Local Zones, and Wavelength Zones that are available
    /// to you. If there is an event impacting a zone, you can use this request to view the
    /// state and any provided messages for that zone.
    /// 
    ///  
    /// <para>
    /// For more information about Availability Zones, Local Zones, and Wavelength Zones,
    /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-regions-availability-zones.html">Regions
    /// and zones</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// The order of the elements in the response, including those within nested structures,
    /// might vary. Applications should not assume the elements appear in a particular order.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DescribeAvailabilityZonesRequest : AmazonEC2Request
    {
        private bool? _allAvailabilityZones;
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private List<string> _zoneIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _zoneNames = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AllAvailabilityZones. 
        /// <para>
        /// Include all Availability Zones, Local Zones, and Wavelength Zones regardless of your
        /// opt-in status.
        /// </para>
        ///  
        /// <para>
        /// If you do not use this parameter, the results include only the zones for the Regions
        /// where you have chosen the option to opt in.
        /// </para>
        /// </summary>
        public bool AllAvailabilityZones
        {
            get { return this._allAvailabilityZones.GetValueOrDefault(); }
            set { this._allAvailabilityZones = value; }
        }

        // Check to see if AllAvailabilityZones property is set
        internal bool IsSetAllAvailabilityZones()
        {
            return this._allAvailabilityZones.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>group-name</c> - For Availability Zones, use the Region name. For Local Zones,
        /// use the name of the group associated with the Local Zone (for example, <c>us-west-2-lax-1</c>)
        /// For Wavelength Zones, use the name of the group associated with the Wavelength Zone
        /// (for example, <c>us-east-1-wl1</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>message</c> - The Zone message.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>opt-in-status</c> - The opt-in status (<c>opted-in</c> | <c>not-opted-in</c> |
        /// <c>opt-in-not-required</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>parent-zone-id</c> - The ID of the zone that handles some of the Local Zone and
        /// Wavelength Zone control plane operations, such as API calls.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>parent-zone-name</c> - The ID of the zone that handles some of the Local Zone
        /// and Wavelength Zone control plane operations, such as API calls.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>region-name</c> - The name of the Region for the Zone (for example, <c>us-east-1</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>state</c> - The state of the Availability Zone, the Local Zone, or the Wavelength
        /// Zone (<c>available</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>zone-id</c> - The ID of the Availability Zone (for example, <c>use1-az1</c>),
        /// the Local Zone (for example, <c>usw2-lax1-az1</c>), or the Wavelength Zone (for example,
        /// <c>us-east-1-wl1-bos-wlz-1</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>zone-name</c> - The name of the Availability Zone (for example, <c>us-east-1a</c>),
        /// the Local Zone (for example, <c>us-west-2-lax-1a</c>), or the Wavelength Zone (for
        /// example, <c>us-east-1-wl1-bos-wlz-1</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>zone-type</c> - The type of zone (<c>availability-zone</c> | <c>local-zone</c>
        /// | <c>wavelength-zone</c>).
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
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ZoneIds. 
        /// <para>
        /// The IDs of the Availability Zones, Local Zones, and Wavelength Zones.
        /// </para>
        /// </summary>
        public List<string> ZoneIds
        {
            get { return this._zoneIds; }
            set { this._zoneIds = value; }
        }

        // Check to see if ZoneIds property is set
        internal bool IsSetZoneIds()
        {
            return this._zoneIds != null && (this._zoneIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ZoneNames. 
        /// <para>
        /// The names of the Availability Zones, Local Zones, and Wavelength Zones.
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
            return this._zoneNames != null && (this._zoneNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}