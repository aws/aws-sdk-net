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
    /// Time breakdown for the sequence.
    /// </summary>
    public partial class WaypointOptimizationTimeBreakdown
    {
        /// <summary>
        /// Gets and sets the property RestDuration. 
        /// <para>
        /// Resting phase of the cycle.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>seconds</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 0, Max = 4294967295)]
        public long? RestDuration { get; set; }

        /// <summary>
        /// Checks to see if the RestDuration property is set.
        /// </summary>
        internal bool IsSetRestDuration() => this.RestDuration.HasValue;

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
        [AWSProperty(Required = true, Sensitive = true, Min = 0, Max = 4294967295)]
        public long? ServiceDuration { get; set; }

        /// <summary>
        /// Checks to see if the ServiceDuration property is set.
        /// </summary>
        internal bool IsSetServiceDuration() => this.ServiceDuration.HasValue;

        /// <summary>
        /// Gets and sets the property TravelDuration. 
        /// <para>
        /// Traveling phase of the cycle.
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
        /// Waiting phase of the cycle.
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
