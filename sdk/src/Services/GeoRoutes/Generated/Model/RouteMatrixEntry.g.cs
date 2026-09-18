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
    /// The calculated route matrix containing the results for all pairs of Origins to Destination
    /// positions. Each row corresponds to one entry in Origins. Each entry in the row corresponds
    /// to the route from that entry in Origins to an entry in Destination positions.
    /// </summary>
    public partial class RouteMatrixEntry
    {
        /// <summary>
        /// Gets and sets the property Distance. 
        /// <para>
        /// The total distance of travel for the route.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 0, Max = 4294967295)]
        public long? Distance { get; set; }

        /// <summary>
        /// Checks to see if the Distance property is set.
        /// </summary>
        internal bool IsSetDistance() => this.Distance.HasValue;

        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        /// The expected duration of travel for the route.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>seconds</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 0, Max = 4294967295)]
        public long? Duration { get; set; }

        /// <summary>
        /// Checks to see if the Duration property is set.
        /// </summary>
        internal bool IsSetDuration() => this.Duration.HasValue;

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// Error code that occurred during calculation of the route.
        /// </para>
        /// </summary>
        public RouteMatrixErrorCode Error { get; set; }

        /// <summary>
        /// Checks to see if the Error property is set.
        /// </summary>
        internal bool IsSetError() => this.Error != null;
    }
}
