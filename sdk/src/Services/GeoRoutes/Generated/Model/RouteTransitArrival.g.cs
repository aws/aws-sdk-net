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
    /// Details corresponding to the arrival for the leg.
    /// </summary>
    public partial class RouteTransitArrival
    {
        /// <summary>
        /// Gets and sets the property Delay. 
        /// <para>
        /// The delay from the scheduled arrival time.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>seconds</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 4294967295)]
        public long? Delay { get; set; }

        /// <summary>
        /// Checks to see if the Delay property is set.
        /// </summary>
        internal bool IsSetDelay() => this.Delay.HasValue;

        /// <summary>
        /// Gets and sets the property Place. 
        /// <para>
        /// Place details corresponding to the arrival.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RouteTransitPlace Place { get; set; }

        /// <summary>
        /// Checks to see if the Place property is set.
        /// </summary>
        internal bool IsSetPlace() => this.Place != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the arrival.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public RouteTransitTripStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Time. 
        /// <para>
        /// The arrival time.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Time { get; set; }

        /// <summary>
        /// Checks to see if the Time property is set.
        /// </summary>
        internal bool IsSetTime() => this.Time != null;
    }
}
