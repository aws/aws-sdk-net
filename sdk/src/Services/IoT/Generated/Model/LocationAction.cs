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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// The Amazon Location rule action sends device location updates from an MQTT message
    /// to an Amazon Location tracker resource.
    /// </summary>
    public partial class LocationAction
    {
        private string _deviceId;
        private string _latitude;
        private string _longitude;
        private string _roleArn;
        private LocationTimestamp _timestamp;
        private string _trackerName;

        /// <summary>
        /// Gets and sets the property DeviceId. 
        /// <para>
        /// The unique ID of the device providing the location data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DeviceId
        {
            get { return this._deviceId; }
            set { this._deviceId = value; }
        }

        // Check to see if DeviceId property is set
        internal bool IsSetDeviceId()
        {
            return this._deviceId != null;
        }

        /// <summary>
        /// Gets and sets the property Latitude. 
        /// <para>
        /// A string that evaluates to a double value that represents the latitude of the device's
        /// location.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Latitude
        {
            get { return this._latitude; }
            set { this._latitude = value; }
        }

        // Check to see if Latitude property is set
        internal bool IsSetLatitude()
        {
            return this._latitude != null;
        }

        /// <summary>
        /// Gets and sets the property Longitude. 
        /// <para>
        /// A string that evaluates to a double value that represents the longitude of the device's
        /// location.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Longitude
        {
            get { return this._longitude; }
            set { this._longitude = value; }
        }

        // Check to see if Longitude property is set
        internal bool IsSetLongitude()
        {
            return this._longitude != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The IAM role that grants permission to write to the Amazon Location resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The time that the location data was sampled. The default value is the time the MQTT
        /// message was processed.
        /// </para>
        /// </summary>
        public LocationTimestamp Timestamp
        {
            get { return this._timestamp; }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp != null;
        }

        /// <summary>
        /// Gets and sets the property TrackerName. 
        /// <para>
        /// The name of the tracker resource in Amazon Location in which the location is updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TrackerName
        {
            get { return this._trackerName; }
            set { this._trackerName = value; }
        }

        // Check to see if TrackerName property is set
        internal bool IsSetTrackerName()
        {
            return this._trackerName != null;
        }

    }
}