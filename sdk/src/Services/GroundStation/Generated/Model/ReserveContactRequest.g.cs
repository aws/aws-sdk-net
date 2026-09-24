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

namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Container for the parameters to the ReserveContact operation. Reserves a contact using
    /// specified parameters.
    /// </summary>
    public partial class ReserveContactRequest : AmazonGroundStationRequest
    {
        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// End time of a contact in UTC.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property GroundStation. 
        /// <para>
        /// Name of a ground station.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 4, Max = 97)]
        public string GroundStation { get; set; }

        /// <summary>
        /// Checks to see if the GroundStation property is set.
        /// </summary>
        internal bool IsSetGroundStation() => this.GroundStation != null;

        /// <summary>
        /// Gets and sets the property MissionProfileArn. 
        /// <para>
        /// ARN of a mission profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 89, Max = 138)]
        public string MissionProfileArn { get; set; }

        /// <summary>
        /// Checks to see if the MissionProfileArn property is set.
        /// </summary>
        internal bool IsSetMissionProfileArn() => this.MissionProfileArn != null;

        /// <summary>
        /// Gets and sets the property SatelliteArn. 
        /// <para>
        /// ARN of a satellite
        /// </para>
        /// </summary>
        [AWSProperty(Min = 82, Max = 132)]
        public string SatelliteArn { get; set; }

        /// <summary>
        /// Checks to see if the SatelliteArn property is set.
        /// </summary>
        internal bool IsSetSatelliteArn() => this.SatelliteArn != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// Start time of a contact in UTC.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags assigned to a contact.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TrackingOverrides. 
        /// <para>
        /// Tracking configuration overrides for the contact.
        /// </para>
        /// </summary>
        public TrackingOverrides TrackingOverrides { get; set; }

        /// <summary>
        /// Checks to see if the TrackingOverrides property is set.
        /// </summary>
        internal bool IsSetTrackingOverrides() => this.TrackingOverrides != null;
    }
}
