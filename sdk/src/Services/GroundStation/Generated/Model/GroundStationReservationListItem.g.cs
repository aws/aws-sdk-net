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
    /// Item in a list of ground station reservations.
    /// </summary>
    public partial class GroundStationReservationListItem
    {
        /// <summary>
        /// Gets and sets the property AntennaName. 
        /// <para>
        /// Name of an antenna.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 4, Max = 256)]
        public string AntennaName { get; set; }

        /// <summary>
        /// Checks to see if the AntennaName property is set.
        /// </summary>
        internal bool IsSetAntennaName() => this.AntennaName != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// End time of a ground station reservation in UTC.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property GroundStationId. 
        /// <para>
        /// ID of a ground station.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 4, Max = 97)]
        public string GroundStationId { get; set; }

        /// <summary>
        /// Checks to see if the GroundStationId property is set.
        /// </summary>
        internal bool IsSetGroundStationId() => this.GroundStationId != null;

        /// <summary>
        /// Gets and sets the property ReservationDetails. 
        /// <para>
        /// Details of a ground station reservation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ReservationDetails ReservationDetails { get; set; }

        /// <summary>
        /// Checks to see if the ReservationDetails property is set.
        /// </summary>
        internal bool IsSetReservationDetails() => this.ReservationDetails != null;

        /// <summary>
        /// Gets and sets the property ReservationType. 
        /// <para>
        /// Type of a ground station reservation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ReservationType ReservationType { get; set; }

        /// <summary>
        /// Checks to see if the ReservationType property is set.
        /// </summary>
        internal bool IsSetReservationType() => this.ReservationType != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// Start time of a ground station reservation in UTC.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;
    }
}
