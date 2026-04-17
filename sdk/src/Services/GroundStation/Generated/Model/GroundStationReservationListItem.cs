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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
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
        private string _antennaName;
        private DateTime? _endTime;
        private string _groundStationId;
        private ReservationDetails _reservationDetails;
        private ReservationType _reservationType;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property AntennaName. 
        /// <para>
        /// Name of an antenna.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=4, Max=256)]
        public string AntennaName
        {
            get { return this._antennaName; }
            set { this._antennaName = value; }
        }

        // Check to see if AntennaName property is set
        internal bool IsSetAntennaName()
        {
            return this._antennaName != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// End time of a ground station reservation in UTC.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GroundStationId. 
        /// <para>
        /// ID of a ground station.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=4, Max=97)]
        public string GroundStationId
        {
            get { return this._groundStationId; }
            set { this._groundStationId = value; }
        }

        // Check to see if GroundStationId property is set
        internal bool IsSetGroundStationId()
        {
            return this._groundStationId != null;
        }

        /// <summary>
        /// Gets and sets the property ReservationDetails. 
        /// <para>
        /// Details of a ground station reservation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ReservationDetails ReservationDetails
        {
            get { return this._reservationDetails; }
            set { this._reservationDetails = value; }
        }

        // Check to see if ReservationDetails property is set
        internal bool IsSetReservationDetails()
        {
            return this._reservationDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ReservationType. 
        /// <para>
        /// Type of a ground station reservation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ReservationType ReservationType
        {
            get { return this._reservationType; }
            set { this._reservationType = value; }
        }

        // Check to see if ReservationType property is set
        internal bool IsSetReservationType()
        {
            return this._reservationType != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// Start time of a ground station reservation in UTC.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}