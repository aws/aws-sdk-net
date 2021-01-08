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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes Availability Zones, Local Zones, and Wavelength Zones.
    /// </summary>
    public partial class AvailabilityZone
    {
        private string _groupName;
        private List<AvailabilityZoneMessage> _messages = new List<AvailabilityZoneMessage>();
        private string _networkBorderGroup;
        private AvailabilityZoneOptInStatus _optInStatus;
        private string _parentZoneId;
        private string _parentZoneName;
        private string _regionName;
        private AvailabilityZoneState _state;
        private string _zoneId;
        private string _zoneName;
        private string _zoneType;

        /// <summary>
        /// Gets and sets the property GroupName. 
        /// <para>
        ///  For Availability Zones, this parameter has the same value as the Region name.
        /// </para>
        ///  
        /// <para>
        /// For Local Zones, the name of the associated group, for example <code>us-west-2-lax-1</code>.
        /// </para>
        ///  
        /// <para>
        /// For Wavelength Zones, the name of the associated group, for example <code>us-east-1-wl1-bos-wlz-1</code>.
        /// </para>
        /// </summary>
        public string GroupName
        {
            get { return this._groupName; }
            set { this._groupName = value; }
        }

        // Check to see if GroupName property is set
        internal bool IsSetGroupName()
        {
            return this._groupName != null;
        }

        /// <summary>
        /// Gets and sets the property Messages. 
        /// <para>
        /// Any messages about the Availability Zone, Local Zone, or Wavelength Zone.
        /// </para>
        /// </summary>
        public List<AvailabilityZoneMessage> Messages
        {
            get { return this._messages; }
            set { this._messages = value; }
        }

        // Check to see if Messages property is set
        internal bool IsSetMessages()
        {
            return this._messages != null && this._messages.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NetworkBorderGroup. 
        /// <para>
        /// The name of the network border group.
        /// </para>
        /// </summary>
        public string NetworkBorderGroup
        {
            get { return this._networkBorderGroup; }
            set { this._networkBorderGroup = value; }
        }

        // Check to see if NetworkBorderGroup property is set
        internal bool IsSetNetworkBorderGroup()
        {
            return this._networkBorderGroup != null;
        }

        /// <summary>
        /// Gets and sets the property OptInStatus. 
        /// <para>
        /// For Availability Zones, this parameter always has the value of <code>opt-in-not-required</code>.
        /// </para>
        ///  
        /// <para>
        /// For Local Zones and Wavelength Zones, this parameter is the opt-in status. The possible
        /// values are <code>opted-in</code>, and <code>not-opted-in</code>.
        /// </para>
        /// </summary>
        public AvailabilityZoneOptInStatus OptInStatus
        {
            get { return this._optInStatus; }
            set { this._optInStatus = value; }
        }

        // Check to see if OptInStatus property is set
        internal bool IsSetOptInStatus()
        {
            return this._optInStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ParentZoneId. 
        /// <para>
        /// The ID of the zone that handles some of the Local Zone or Wavelength Zone control
        /// plane operations, such as API calls.
        /// </para>
        /// </summary>
        public string ParentZoneId
        {
            get { return this._parentZoneId; }
            set { this._parentZoneId = value; }
        }

        // Check to see if ParentZoneId property is set
        internal bool IsSetParentZoneId()
        {
            return this._parentZoneId != null;
        }

        /// <summary>
        /// Gets and sets the property ParentZoneName. 
        /// <para>
        /// The name of the zone that handles some of the Local Zone or Wavelength Zone control
        /// plane operations, such as API calls.
        /// </para>
        /// </summary>
        public string ParentZoneName
        {
            get { return this._parentZoneName; }
            set { this._parentZoneName = value; }
        }

        // Check to see if ParentZoneName property is set
        internal bool IsSetParentZoneName()
        {
            return this._parentZoneName != null;
        }

        /// <summary>
        /// Gets and sets the property RegionName. 
        /// <para>
        /// The name of the Region.
        /// </para>
        /// </summary>
        public string RegionName
        {
            get { return this._regionName; }
            set { this._regionName = value; }
        }

        // Check to see if RegionName property is set
        internal bool IsSetRegionName()
        {
            return this._regionName != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the Availability Zone, Local Zone, or Wavelength Zone.
        /// </para>
        /// </summary>
        public AvailabilityZoneState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property ZoneId. 
        /// <para>
        /// The ID of the Availability Zone, Local Zone, or Wavelength Zone.
        /// </para>
        /// </summary>
        public string ZoneId
        {
            get { return this._zoneId; }
            set { this._zoneId = value; }
        }

        // Check to see if ZoneId property is set
        internal bool IsSetZoneId()
        {
            return this._zoneId != null;
        }

        /// <summary>
        /// Gets and sets the property ZoneName. 
        /// <para>
        /// The name of the Availability Zone, Local Zone, or Wavelength Zone.
        /// </para>
        /// </summary>
        public string ZoneName
        {
            get { return this._zoneName; }
            set { this._zoneName = value; }
        }

        // Check to see if ZoneName property is set
        internal bool IsSetZoneName()
        {
            return this._zoneName != null;
        }

        /// <summary>
        /// Gets and sets the property ZoneType. 
        /// <para>
        /// The type of zone. The valid values are <code>availability-zone</code>, <code>local-zone</code>,
        /// and <code>wavelength-zone</code>.
        /// </para>
        /// </summary>
        public string ZoneType
        {
            get { return this._zoneType; }
            set { this._zoneType = value; }
        }

        // Check to see if ZoneType property is set
        internal bool IsSetZoneType()
        {
            return this._zoneType != null;
        }

    }
}