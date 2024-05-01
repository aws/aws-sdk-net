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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
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
namespace Amazon.Route53.Model
{
    /// <summary>
    /// A complex type that lists the coordinates for a geoproximity resource record.
    /// </summary>
    public partial class Coordinates
    {
        private string _latitude;
        private string _longitude;

        /// <summary>
        /// Gets and sets the property Latitude. 
        /// <para>
        ///  Specifies a coordinate of the north–south position of a geographic point on the surface
        /// of the Earth (-90 - 90). 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=6)]
        public string Latitude
        {
            get { return this._latitude; }
            set { this._latitude = value; }
        }

        // Check to see if Latitude property is set
        internal bool IsSetLatitude()
        {
            return this._latitude != null;
        }

        /// <summary>
        /// Gets and sets the property Longitude. 
        /// <para>
        ///  Specifies a coordinate of the east–west position of a geographic point on the surface
        /// of the Earth (-180 - 180). 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=7)]
        public string Longitude
        {
            get { return this._longitude; }
            set { this._longitude = value; }
        }

        // Check to see if Longitude property is set
        internal bool IsSetLongitude()
        {
            return this._longitude != null;
        }

    }
}