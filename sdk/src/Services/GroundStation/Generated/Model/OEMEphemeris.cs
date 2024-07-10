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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
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
namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Ephemeris data in Orbit Ephemeris Message (OEM) format. 
    /// 
    ///  
    /// <para>
    ///  Position, velocity, and acceleration units must be represented in <c>km</c>, <c>km/s</c>,
    /// and <c>km/s**2</c>, respectively, in ephemeris data lines. Covariance matrix line
    /// units must be represented in <c>km**2</c> if computed from two positions, <c>km**2/s</c>
    /// if computed from one position and one velocity, and <c>km**2/s**2</c> if computed
    /// from two velocities. Consult section 7.7.2 of The Consultative Committee for Space
    /// Data Systems (CCSDS) <a href="https://public.ccsds.org/Pubs/502x0b3e1.pdf">Recommended
    /// Standard for Orbit Data Messages</a> for more information. 
    /// </para>
    /// </summary>
    public partial class OEMEphemeris
    {
        private string _oemData;
        private S3Object _s3Object;

        /// <summary>
        /// Gets and sets the property OemData. 
        /// <para>
        /// The data for an OEM ephemeris, supplied directly in the request rather than through
        /// an S3 object.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string OemData
        {
            get { return this._oemData; }
            set { this._oemData = value; }
        }

        // Check to see if OemData property is set
        internal bool IsSetOemData()
        {
            return this._oemData != null;
        }

        /// <summary>
        /// Gets and sets the property S3Object. 
        /// <para>
        /// Identifies the S3 object to be used as the ephemeris.
        /// </para>
        /// </summary>
        public S3Object S3Object
        {
            get { return this._s3Object; }
            set { this._s3Object = value; }
        }

        // Check to see if S3Object property is set
        internal bool IsSetS3Object()
        {
            return this._s3Object != null;
        }

    }
}