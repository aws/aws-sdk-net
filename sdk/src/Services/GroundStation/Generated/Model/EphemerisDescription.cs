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
    /// Description of ephemeris.
    /// </summary>
    public partial class EphemerisDescription
    {
        private string _ephemerisData;
        private S3Object _sources3Object;

        /// <summary>
        /// Gets and sets the property EphemerisData. 
        /// <para>
        /// Supplied ephemeris data.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string EphemerisData
        {
            get { return this._ephemerisData; }
            set { this._ephemerisData = value; }
        }

        // Check to see if EphemerisData property is set
        internal bool IsSetEphemerisData()
        {
            return this._ephemerisData != null;
        }

        /// <summary>
        /// Gets and sets the property SourceS3Object. 
        /// <para>
        /// Source S3 object used for the ephemeris.
        /// </para>
        /// </summary>
        public S3Object SourceS3Object
        {
            get { return this._sources3Object; }
            set { this._sources3Object = value; }
        }

        // Check to see if SourceS3Object property is set
        internal bool IsSetSourceS3Object()
        {
            return this._sources3Object != null;
        }

    }
}