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
 * Do not modify this file. This file is generated from the privatenetworks-2021-12-03.normal.json service model.
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
namespace Amazon.Private5G.Model
{
    /// <summary>
    /// Information about a position.
    /// </summary>
    public partial class Position
    {
        private double? _elevation;
        private ElevationReference _elevationReference;
        private ElevationUnit _elevationUnit;
        private double? _latitude;
        private double? _longitude;

        /// <summary>
        /// Gets and sets the property Elevation. 
        /// <para>
        /// The elevation of the equipment at this position.
        /// </para>
        /// </summary>
        public double Elevation
        {
            get { return this._elevation.GetValueOrDefault(); }
            set { this._elevation = value; }
        }

        // Check to see if Elevation property is set
        internal bool IsSetElevation()
        {
            return this._elevation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ElevationReference. 
        /// <para>
        /// The reference point from which elevation is reported.
        /// </para>
        /// </summary>
        public ElevationReference ElevationReference
        {
            get { return this._elevationReference; }
            set { this._elevationReference = value; }
        }

        // Check to see if ElevationReference property is set
        internal bool IsSetElevationReference()
        {
            return this._elevationReference != null;
        }

        /// <summary>
        /// Gets and sets the property ElevationUnit. 
        /// <para>
        /// The units used to measure the elevation of the position.
        /// </para>
        /// </summary>
        public ElevationUnit ElevationUnit
        {
            get { return this._elevationUnit; }
            set { this._elevationUnit = value; }
        }

        // Check to see if ElevationUnit property is set
        internal bool IsSetElevationUnit()
        {
            return this._elevationUnit != null;
        }

        /// <summary>
        /// Gets and sets the property Latitude. 
        /// <para>
        /// The latitude of the position.
        /// </para>
        /// </summary>
        public double Latitude
        {
            get { return this._latitude.GetValueOrDefault(); }
            set { this._latitude = value; }
        }

        // Check to see if Latitude property is set
        internal bool IsSetLatitude()
        {
            return this._latitude.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Longitude. 
        /// <para>
        /// The longitude of the position.
        /// </para>
        /// </summary>
        public double Longitude
        {
            get { return this._longitude.GetValueOrDefault(); }
            set { this._longitude = value; }
        }

        // Check to see if Longitude property is set
        internal bool IsSetLongitude()
        {
            return this._longitude.HasValue; 
        }

    }
}