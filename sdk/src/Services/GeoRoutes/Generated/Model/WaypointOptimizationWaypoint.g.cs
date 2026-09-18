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

namespace Amazon.GeoRoutes.Model
{
    /// <summary>
    /// Waypoint between the Origin and Destination.
    /// </summary>
    public partial class WaypointOptimizationWaypoint
    {
        /// <summary>
        /// Gets and sets the property AccessHours. 
        /// <para>
        /// Access hours corresponding to when a waypoint can be visited.
        /// </para>
        /// </summary>
        public WaypointOptimizationAccessHours AccessHours { get; set; }

        /// <summary>
        /// Checks to see if the AccessHours property is set.
        /// </summary>
        internal bool IsSetAccessHours() => this.AccessHours != null;

        /// <summary>
        /// Gets and sets the property AppointmentTime. 
        /// <para>
        /// Appointment time at the waypoint.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string AppointmentTime { get; set; }

        /// <summary>
        /// Checks to see if the AppointmentTime property is set.
        /// </summary>
        internal bool IsSetAppointmentTime() => this.AppointmentTime != null;

        /// <summary>
        /// Gets and sets the property Before. 
        /// <para>
        /// Constraint defining what waypoints are to be visited after this waypoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> Before { get; set; } = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Checks to see if the Before property is set.
        /// </summary>
        internal bool IsSetBefore() => this.Before != null && (this.Before.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Heading. 
        /// <para>
        /// GPS Heading at the position.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 360)]
        public double? Heading { get; set; }

        /// <summary>
        /// Checks to see if the Heading property is set.
        /// </summary>
        internal bool IsSetHeading() => this.Heading.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The waypoint Id.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Position. 
        /// <para>
        /// Position in World Geodetic System (WGS 84) format: [longitude, latitude].
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 2, Max = 2)]
        public List<double> Position { get; set; } = AWSConfigs.InitializeCollections ? new List<double>() : null;

        /// <summary>
        /// Checks to see if the Position property is set.
        /// </summary>
        internal bool IsSetPosition() => this.Position != null && (this.Position.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ServiceDuration. 
        /// <para>
        /// Service time spent at the waypoint. At an appointment, the service time should be
        /// the appointment duration.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>seconds</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 4294967295)]
        public long? ServiceDuration { get; set; }

        /// <summary>
        /// Checks to see if the ServiceDuration property is set.
        /// </summary>
        internal bool IsSetServiceDuration() => this.ServiceDuration.HasValue;

        /// <summary>
        /// Gets and sets the property SideOfStreet. 
        /// <para>
        /// Options to configure matching the provided position to a side of the street.
        /// </para>
        /// </summary>
        public WaypointOptimizationSideOfStreetOptions SideOfStreet { get; set; }

        /// <summary>
        /// Checks to see if the SideOfStreet property is set.
        /// </summary>
        internal bool IsSetSideOfStreet() => this.SideOfStreet != null;
    }
}
