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
    /// Features that are allowed while calculating a route.
    /// </summary>
    public partial class RouteAllowOptions
    {
        /// <summary>
        /// Gets and sets the property Hot. 
        /// <para>
        /// Allow Hot (High Occupancy Toll) lanes while calculating the route.
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
        /// Allow Hov (High Occupancy vehicle) lanes while calculating the route.
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
