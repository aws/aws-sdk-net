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
 * Do not modify this file. This file is generated from the geo-routes-2020-11-19.normal.json service model.
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
namespace Amazon.GeoRoutes.Model
{
    /// <summary>
    /// Destination related options.
    /// </summary>
    public partial class WaypointOptimizationDestinationOptions
    {
        private WaypointOptimizationAccessHours _accessHours;
        private string _appointmentTime;
        private double? _heading;
        private string _id;
        private long? _serviceDuration;
        private WaypointOptimizationSideOfStreetOptions _sideOfStreet;

        /// <summary>
        /// Gets and sets the property AccessHours. 
        /// <para>
        /// Access hours corresponding to when a waypoint can be visited.
        /// </para>
        /// </summary>
        public WaypointOptimizationAccessHours AccessHours
        {
            get { return this._accessHours; }
            set { this._accessHours = value; }
        }

        // Check to see if AccessHours property is set
        internal bool IsSetAccessHours()
        {
            return this._accessHours != null;
        }

        /// <summary>
        /// Gets and sets the property AppointmentTime. 
        /// <para>
        /// Appointment time at the destination.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string AppointmentTime
        {
            get { return this._appointmentTime; }
            set { this._appointmentTime = value; }
        }

        // Check to see if AppointmentTime property is set
        internal bool IsSetAppointmentTime()
        {
            return this._appointmentTime != null;
        }

        /// <summary>
        /// Gets and sets the property Heading. 
        /// <para>
        /// GPS Heading at the position.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=360)]
        public double? Heading
        {
            get { return this._heading; }
            set { this._heading = value; }
        }

        // Check to see if Heading property is set
        internal bool IsSetHeading()
        {
            return this._heading.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The waypoint Id.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceDuration. 
        /// <para>
        /// Service time spent at the destination. At an appointment, the service time should
        /// be the appointment duration.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>seconds</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=4294967295)]
        public long? ServiceDuration
        {
            get { return this._serviceDuration; }
            set { this._serviceDuration = value; }
        }

        // Check to see if ServiceDuration property is set
        internal bool IsSetServiceDuration()
        {
            return this._serviceDuration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SideOfStreet. 
        /// <para>
        /// Options to configure matching the provided position to a side of the street.
        /// </para>
        /// </summary>
        public WaypointOptimizationSideOfStreetOptions SideOfStreet
        {
            get { return this._sideOfStreet; }
            set { this._sideOfStreet = value; }
        }

        // Check to see if SideOfStreet property is set
        internal bool IsSetSideOfStreet()
        {
            return this._sideOfStreet != null;
        }

    }
}