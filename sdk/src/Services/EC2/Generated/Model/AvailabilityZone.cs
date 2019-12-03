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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
    /// Describes an Availability Zone or Local Zone.
    /// </summary>
    public partial class AvailabilityZone
    {
        private string _groupName;
        private List<AvailabilityZoneMessage> _messages = new List<AvailabilityZoneMessage>();
        private string _networkBorderGroup;
        private AvailabilityZoneOptInStatus _optInStatus;
        private string _regionName;
        private AvailabilityZoneState _state;
        private string _zoneId;
        private string _zoneName;

        /// <summary>
        /// Gets and sets the property GroupName. 
        /// <para>
        ///  For Availability Zones, this parameter has the same value as the Region name.
        /// </para>
        ///  
        /// <para>
        /// For Local Zones, the name of the associated group, for example <code>us-west-2-lax-1</code>.
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
        /// Any messages about the Availability Zone or Local Zone.
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
        /// The name of the location from which the address is advertised.
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
        ///  For Availability Zones, this parameter always has the value of <code>opt-in-not-required</code>.
        /// </para>
        ///  
        /// <para>
        /// For Local Zones, this parameter is the opt in status. The possible values are <code>opted-in</code>,
        /// and <code>not-opted-in</code>.
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
        /// The state of the Availability Zone or Local Zone.
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
        /// The ID of the Availability Zone or Local Zone.
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
        /// The name of the Availability Zone or Local Zone.
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

    }
}