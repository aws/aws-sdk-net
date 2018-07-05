/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// GPS point location dimension
    /// </summary>
    public partial class GPSPointDimension
    {
        private GPSCoordinates _coordinates;
        private double? _rangeInKilometers;

        /// <summary>
        /// Gets and sets the property Coordinates. Coordinate to measure distance from.
        /// </summary>
        public GPSCoordinates Coordinates
        {
            get { return this._coordinates; }
            set { this._coordinates = value; }
        }

        // Check to see if Coordinates property is set
        internal bool IsSetCoordinates()
        {
            return this._coordinates != null;
        }

        /// <summary>
        /// Gets and sets the property RangeInKilometers. Range in kilometers from the coordinate.
        /// </summary>
        public double RangeInKilometers
        {
            get { return this._rangeInKilometers.GetValueOrDefault(); }
            set { this._rangeInKilometers = value; }
        }

        // Check to see if RangeInKilometers property is set
        internal bool IsSetRangeInKilometers()
        {
            return this._rangeInKilometers.HasValue; 
        }

    }
}