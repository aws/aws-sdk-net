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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// Represents a latitude and longitude pair, expressed in geographic coordinate system
    /// degrees (for example, 47.6204, -122.3491).
    /// 
    ///  
    /// <para>
    /// Elevation is currently not supported.
    /// </para>
    /// </summary>
    public partial class Location
    {
        private double? _latitude;
        private double? _longitude;

        /// <summary>
        /// Gets and sets the property Latitude. 
        /// <para>
        /// The latitude.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The longitude.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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