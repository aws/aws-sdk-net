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
    /// This contains information such as distance and duration from one waypoint to the next
    /// waypoint in the sequence.
    /// </summary>
    public partial class WaypointOptimizationConnection
    {
        /// <summary>
        /// Gets and sets the property Distance. 
        /// <para>
        /// Distance of the step.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 0, Max = 4294967295)]
        public long? Distance { get; set; }

        /// <summary>
        /// Checks to see if the Distance property is set.
        /// </summary>
        internal bool IsSetDistance() => this.Distance.HasValue;

        /// <summary>
        /// Gets and sets the property From. 
        /// <para>
        /// contains the ID of the starting waypoint in this connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string From { get; set; }

        /// <summary>
        /// Checks to see if the From property is set.
        /// </summary>
        internal bool IsSetFrom() => this.From != null;

        /// <summary>
        /// Gets and sets the property RestDuration. 
        /// <para>
        /// Resting time before the driver can continue driving.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 0, Max = 4294967295)]
        public long? RestDuration { get; set; }

        /// <summary>
        /// Checks to see if the RestDuration property is set.
        /// </summary>
        internal bool IsSetRestDuration() => this.RestDuration.HasValue;

        /// <summary>
        /// Gets and sets the property To. 
        /// <para>
        /// Contains the ID of the ending waypoint in this connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string To { get; set; }

        /// <summary>
        /// Checks to see if the To property is set.
        /// </summary>
        internal bool IsSetTo() => this.To != null;

        /// <summary>
        /// Gets and sets the property TravelDuration. 
        /// <para>
        /// Total duration.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>seconds</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 0, Max = 4294967295)]
        public long? TravelDuration { get; set; }

        /// <summary>
        /// Checks to see if the TravelDuration property is set.
        /// </summary>
        internal bool IsSetTravelDuration() => this.TravelDuration.HasValue;

        /// <summary>
        /// Gets and sets the property WaitDuration. 
        /// <para>
        /// Duration of a wait step.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>seconds</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 0, Max = 4294967295)]
        public long? WaitDuration { get; set; }

        /// <summary>
        /// Checks to see if the WaitDuration property is set.
        /// </summary>
        internal bool IsSetWaitDuration() => this.WaitDuration.HasValue;
    }
}
