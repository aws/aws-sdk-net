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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// The Amazon Location rule action sends device location updates from an MQTT message
    /// to an Amazon Location tracker resource.
    /// </summary>
    public partial class LocationAction
    {
        /// <summary>
        /// Gets and sets the property DeviceId. 
        /// <para>
        /// The unique ID of the device providing the location data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DeviceId { get; set; }

        /// <summary>
        /// Checks to see if the DeviceId property is set.
        /// </summary>
        internal bool IsSetDeviceId() => this.DeviceId != null;

        /// <summary>
        /// Gets and sets the property Latitude. 
        /// <para>
        /// A string that evaluates to a double value that represents the latitude of the device's
        /// location.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Latitude { get; set; }

        /// <summary>
        /// Checks to see if the Latitude property is set.
        /// </summary>
        internal bool IsSetLatitude() => this.Latitude != null;

        /// <summary>
        /// Gets and sets the property Longitude. 
        /// <para>
        /// A string that evaluates to a double value that represents the longitude of the device's
        /// location.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Longitude { get; set; }

        /// <summary>
        /// Checks to see if the Longitude property is set.
        /// </summary>
        internal bool IsSetLongitude() => this.Longitude != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The IAM role that grants permission to write to the Amazon Location resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The time that the location data was sampled. The default value is the time the MQTT
        /// message was processed.
        /// </para>
        /// </summary>
        public LocationTimestamp Timestamp { get; set; }

        /// <summary>
        /// Checks to see if the Timestamp property is set.
        /// </summary>
        internal bool IsSetTimestamp() => this.Timestamp != null;

        /// <summary>
        /// Gets and sets the property TrackerName. 
        /// <para>
        /// The name of the tracker resource in Amazon Location in which the location is updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TrackerName { get; set; }

        /// <summary>
        /// Checks to see if the TrackerName property is set.
        /// </summary>
        internal bool IsSetTrackerName() => this.TrackerName != null;
    }
}
