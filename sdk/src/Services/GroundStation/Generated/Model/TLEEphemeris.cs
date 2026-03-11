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
    /// Two-line element set (TLE) ephemeris.
    /// 
    ///  
    /// <para>
    ///  For more detail about providing Two-line element sets to AWS Ground Station, see
    /// the <a href="https://docs.aws.amazon.com/ground-station/latest/ug/providing-tle-ephemeris-data.html">TLE
    /// section</a> of the AWS Ground Station user guide. 
    /// </para>
    /// </summary>
    public partial class TLEEphemeris
    {
        private S3Object _s3Object;
        private List<TLEData> _tleData = AWSConfigs.InitializeCollections ? new List<TLEData>() : null;

        /// <summary>
        /// Gets and sets the property S3Object. 
        /// <para>
        /// The Amazon S3 object that contains the ephemeris data.
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

        /// <summary>
        /// Gets and sets the property TleData. 
        /// <para>
        /// TLE data that you provide directly instead of using an Amazon S3 object.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public List<TLEData> TleData
        {
            get { return this._tleData; }
            set { this._tleData = value; }
        }

        // Check to see if TleData property is set
        internal bool IsSetTleData()
        {
            return this._tleData != null && (this._tleData.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}