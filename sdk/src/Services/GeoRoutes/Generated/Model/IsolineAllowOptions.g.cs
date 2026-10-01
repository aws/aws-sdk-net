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
    /// Special road types or features that should be considered available for routing. For
    /// example, this attribute can be used to allow the use of HOV (high-occupancy vehicle)
    /// or HOT (high-occupancy toll) lanes, even if they would otherwise not be.
    /// </summary>
    public partial class IsolineAllowOptions
    {
        /// <summary>
        /// Gets and sets the property Hot. 
        /// <para>
        /// When true, allows the use of HOT (high-occupancy toll) lanes, which may affect travel
        /// times and reachable areas.
        /// </para>
        ///  
        /// <para>
        /// Default value: <c>false</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public bool? Hot { get; set; }

        /// <summary>
        /// Checks to see if the Hot property is set.
        /// </summary>
        internal bool IsSetHot() => this.Hot.HasValue;

        /// <summary>
        /// Gets and sets the property Hov. 
        /// <para>
        /// When true, allows the use of HOV (high-occupancy vehicle) lanes, which may affect
        /// travel times and reachable areas.
        /// </para>
        ///  
        /// <para>
        /// Default value: <c>false</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public bool? Hov { get; set; }

        /// <summary>
        /// Checks to see if the Hov property is set.
        /// </summary>
        internal bool IsSetHov() => this.Hov.HasValue;
    }
}
