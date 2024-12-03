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
    /// Geometry defined as an encoded corridor - an encoded polyline with a radius that defines
    /// the width of the corridor.
    /// </summary>
    public partial class PolylineCorridor
    {
        private string _polyline;
        private int? _radius;

        /// <summary>
        /// Gets and sets the property Polyline. 
        /// <para>
        /// An ordered list of positions used to plot a route on a map in a lossy compression
        /// format.
        /// </para>
        ///  <note> 
        /// <para>
        /// LineString and Polyline are mutually exclusive properties.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1)]
        public string Polyline
        {
            get { return this._polyline; }
            set { this._polyline = value; }
        }

        // Check to see if Polyline property is set
        internal bool IsSetPolyline()
        {
            return this._polyline != null;
        }

        /// <summary>
        /// Gets and sets the property Radius. 
        /// <para>
        /// Considers all roads within the provided radius to match the provided destination to.
        /// The roads that are considered are determined by the provided Strategy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>Meters</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? Radius
        {
            get { return this._radius; }
            set { this._radius = value; }
        }

        // Check to see if Radius property is set
        internal bool IsSetRadius()
        {
            return this._radius.HasValue; 
        }

    }
}