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

namespace Amazon.LocationService.Model
{
    /// <summary>
    /// The result for the calculated route of one <c>DeparturePosition</c> <c>DestinationPosition</c>
    /// pair.
    /// </summary>
    public partial class RouteMatrixEntry
    {
        /// <summary>
        /// Gets and sets the property Distance. 
        /// <para>
        /// The total distance of travel for the route.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0)]
        public double? Distance { get; set; }

        /// <summary>
        /// Checks to see if the Distance property is set.
        /// </summary>
        internal bool IsSetDistance() => this.Distance.HasValue;

        /// <summary>
        /// Gets and sets the property DurationSeconds. 
        /// <para>
        /// The expected duration of travel for the route.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0)]
        public double? DurationSeconds { get; set; }

        /// <summary>
        /// Checks to see if the DurationSeconds property is set.
        /// </summary>
        internal bool IsSetDurationSeconds() => this.DurationSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// An error corresponding to the calculation of a route between the <c>DeparturePosition</c>
        /// and <c>DestinationPosition</c>.
        /// </para>
        /// </summary>
        public RouteMatrixEntryError Error { get; set; }

        /// <summary>
        /// Checks to see if the Error property is set.
        /// </summary>
        internal bool IsSetError() => this.Error != null;
    }
}
