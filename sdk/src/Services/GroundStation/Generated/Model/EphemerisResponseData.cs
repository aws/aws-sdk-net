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
    /// Ephemeris data for a contact.
    /// </summary>
    public partial class EphemerisResponseData
    {
        private string _ephemerisId;
        private EphemerisType _ephemerisType;

        /// <summary>
        /// Gets and sets the property EphemerisId. 
        /// <para>
        /// Unique identifier of the ephemeris. Appears only for custom ephemerides.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string EphemerisId
        {
            get { return this._ephemerisId; }
            set { this._ephemerisId = value; }
        }

        // Check to see if EphemerisId property is set
        internal bool IsSetEphemerisId()
        {
            return this._ephemerisId != null;
        }

        /// <summary>
        /// Gets and sets the property EphemerisType. 
        /// <para>
        /// Type of ephemeris.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EphemerisType EphemerisType
        {
            get { return this._ephemerisType; }
            set { this._ephemerisType = value; }
        }

        // Check to see if EphemerisType property is set
        internal bool IsSetEphemerisType()
        {
            return this._ephemerisType != null;
        }

    }
}