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
    /// Ephemeris data.
    /// </summary>
    public partial class EphemerisData
    {
        private OEMEphemeris _oem;
        private TLEEphemeris _tle;

        /// <summary>
        /// Gets and sets the property Oem.
        /// </summary>
        public OEMEphemeris Oem
        {
            get { return this._oem; }
            set { this._oem = value; }
        }

        // Check to see if Oem property is set
        internal bool IsSetOem()
        {
            return this._oem != null;
        }

        /// <summary>
        /// Gets and sets the property Tle.
        /// </summary>
        public TLEEphemeris Tle
        {
            get { return this._tle; }
            set { this._tle = value; }
        }

        // Check to see if Tle property is set
        internal bool IsSetTle()
        {
            return this._tle != null;
        }

    }
}