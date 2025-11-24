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
    /// Azimuth elevation ephemeris data.
    /// 
    ///  
    /// <para>
    ///  Use this ephemeris type to provide pointing angles directly, rather than satellite
    /// orbital elements. Use this when you need precise antenna pointing but have imprecise
    /// or unknown satellite trajectory information. 
    /// </para>
    ///  
    /// <para>
    ///  The azimuth elevation data specifies the antenna pointing direction at specific times
    /// relative to a ground station location. AWS Ground Station uses 4th order Lagrange
    /// interpolation to compute pointing angles between the provided data points. 
    /// </para>
    ///  
    /// <para>
    ///  AWS Ground Station automatically filters interpolated pointing angles, including
    /// only those that are above the site mask elevation of the specified ground station.
    /// 
    /// </para>
    ///  
    /// <para>
    ///  For more detail about providing azimuth elevation ephemerides to AWS Ground Station,
    /// see the <a href="https://docs.aws.amazon.com/ground-station/latest/ug/providing-azimuth-elevation-ephemeris-data.html">azimuth
    /// elevation ephemeris section</a> of the AWS Ground Station User Guide. 
    /// </para>
    /// </summary>
    public partial class AzElEphemeris
    {
        private AzElSegmentsData _data;
        private string _groundStation;

        /// <summary>
        /// Gets and sets the property Data. 
        /// <para>
        /// Azimuth elevation segment data.
        /// </para>
        ///  
        /// <para>
        /// You can provide data inline in the request or through an Amazon S3 object reference.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AzElSegmentsData Data
        {
            get { return this._data; }
            set { this._data = value; }
        }

        // Check to see if Data property is set
        internal bool IsSetData()
        {
            return this._data != null;
        }

        /// <summary>
        /// Gets and sets the property GroundStation. 
        /// <para>
        /// The ground station name for which you're providing azimuth elevation data.
        /// </para>
        ///  
        /// <para>
        /// This ephemeris is specific to this ground station and can't be used at other locations.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=4, Max=500)]
        public string GroundStation
        {
            get { return this._groundStation; }
            set { this._groundStation = value; }
        }

        // Check to see if GroundStation property is set
        internal bool IsSetGroundStation()
        {
            return this._groundStation != null;
        }

    }
}