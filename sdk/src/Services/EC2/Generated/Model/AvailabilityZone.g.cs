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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Describes Availability Zones, Local Zones, and Wavelength Zones.
    /// </summary>
    public partial class AvailabilityZone
    {
        /// <summary>
        /// Gets and sets the property Geography. 
        /// <para>
        /// The geography information for the Availability Zone or Local Zone. The geography is
        /// returned as a list.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AvailabilityZoneGeography> Geography { get; set; } = AWSConfigs.InitializeCollections ? new List<AvailabilityZoneGeography>() : null;

        /// <summary>
        /// Checks to see if the Geography property is set.
        /// </summary>
        internal bool IsSetGeography() => this.Geography != null && (this.Geography.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GroupLongName. 
        /// <para>
        /// The long name of the Availability Zone group, Local Zone group, or Wavelength Zone
        /// group.
        /// </para>
        /// </summary>
        public string GroupLongName { get; set; }

        /// <summary>
        /// Checks to see if the GroupLongName property is set.
        /// </summary>
        internal bool IsSetGroupLongName() => this.GroupLongName != null;

        /// <summary>
        /// Gets and sets the property GroupName. 
        /// <para>
        /// The name of the zone group. For example:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Availability Zones - <c>us-east-1-zg-1</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Local Zones - <c>us-west-2-lax-1</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Wavelength Zones - <c>us-east-1-wl1-bos-wlz-1</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// Checks to see if the GroupName property is set.
        /// </summary>
        internal bool IsSetGroupName() => this.GroupName != null;

        /// <summary>
        /// Gets and sets the property Messages. 
        /// <para>
        /// Any messages about the Availability Zone, Local Zone, or Wavelength Zone.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AvailabilityZoneMessage> Messages { get; set; } = AWSConfigs.InitializeCollections ? new List<AvailabilityZoneMessage>() : null;

        /// <summary>
        /// Checks to see if the Messages property is set.
        /// </summary>
        internal bool IsSetMessages() => this.Messages != null && (this.Messages.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NetworkBorderGroup. 
        /// <para>
        /// The name of the network border group.
        /// </para>
        /// </summary>
        public string NetworkBorderGroup { get; set; }

        /// <summary>
        /// Checks to see if the NetworkBorderGroup property is set.
        /// </summary>
        internal bool IsSetNetworkBorderGroup() => this.NetworkBorderGroup != null;

        /// <summary>
        /// Gets and sets the property OptInStatus. 
        /// <para>
        /// For Availability Zones, this parameter always has the value of <c>opt-in-not-required</c>.
        /// </para>
        ///  
        /// <para>
        /// For Local Zones and Wavelength Zones, this parameter is the opt-in status. The possible
        /// values are <c>opted-in</c> and <c>not-opted-in</c>.
        /// </para>
        /// </summary>
        public AvailabilityZoneOptInStatus OptInStatus { get; set; }

        /// <summary>
        /// Checks to see if the OptInStatus property is set.
        /// </summary>
        internal bool IsSetOptInStatus() => this.OptInStatus != null;

        /// <summary>
        /// Gets and sets the property ParentZoneId. 
        /// <para>
        /// The ID of the zone that handles some of the Local Zone or Wavelength Zone control
        /// plane operations, such as API calls.
        /// </para>
        /// </summary>
        public string ParentZoneId { get; set; }

        /// <summary>
        /// Checks to see if the ParentZoneId property is set.
        /// </summary>
        internal bool IsSetParentZoneId() => this.ParentZoneId != null;

        /// <summary>
        /// Gets and sets the property ParentZoneName. 
        /// <para>
        /// The name of the zone that handles some of the Local Zone or Wavelength Zone control
        /// plane operations, such as API calls.
        /// </para>
        /// </summary>
        public string ParentZoneName { get; set; }

        /// <summary>
        /// Checks to see if the ParentZoneName property is set.
        /// </summary>
        internal bool IsSetParentZoneName() => this.ParentZoneName != null;

        /// <summary>
        /// Gets and sets the property RegionName. 
        /// <para>
        /// The name of the Region.
        /// </para>
        /// </summary>
        public string RegionName { get; set; }

        /// <summary>
        /// Checks to see if the RegionName property is set.
        /// </summary>
        internal bool IsSetRegionName() => this.RegionName != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the Availability Zone, Local Zone, or Wavelength Zone. The possible values
        /// are <c>available</c>, <c>unavailable</c>, and <c>constrained</c>.
        /// </para>
        /// </summary>
        public AvailabilityZoneState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property SubGeography. 
        /// <para>
        /// The sub-geography information for the Availability Zone or Local Zone. The sub-geography
        /// is returned as a list.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AvailabilityZoneSubGeography> SubGeography { get; set; } = AWSConfigs.InitializeCollections ? new List<AvailabilityZoneSubGeography>() : null;

        /// <summary>
        /// Checks to see if the SubGeography property is set.
        /// </summary>
        internal bool IsSetSubGeography() => this.SubGeography != null && (this.SubGeography.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ZoneId. 
        /// <para>
        /// The ID of the Availability Zone, Local Zone, or Wavelength Zone.
        /// </para>
        /// </summary>
        public string ZoneId { get; set; }

        /// <summary>
        /// Checks to see if the ZoneId property is set.
        /// </summary>
        internal bool IsSetZoneId() => this.ZoneId != null;

        /// <summary>
        /// Gets and sets the property ZoneName. 
        /// <para>
        /// The name of the Availability Zone, Local Zone, or Wavelength Zone.
        /// </para>
        /// </summary>
        public string ZoneName { get; set; }

        /// <summary>
        /// Checks to see if the ZoneName property is set.
        /// </summary>
        internal bool IsSetZoneName() => this.ZoneName != null;

        /// <summary>
        /// Gets and sets the property ZoneType. 
        /// <para>
        /// The type of zone.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>availability-zone</c> | <c>local-zone</c> | <c>wavelength-zone</c>
        /// 
        /// </para>
        /// </summary>
        public string ZoneType { get; set; }

        /// <summary>
        /// Checks to see if the ZoneType property is set.
        /// </summary>
        internal bool IsSetZoneType() => this.ZoneType != null;
    }
}
