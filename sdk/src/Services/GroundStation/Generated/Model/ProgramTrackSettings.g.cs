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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Program track settings for an antenna during a contact.
    /// </summary>
    public partial class ProgramTrackSettings
    {
        /// <summary>
        /// Gets and sets the property AzEl. 
        /// <para>
        /// Program track settings for <a>AzElEphemeris</a>.
        /// </para>
        /// </summary>
        public AzElProgramTrackSettings AzEl { get; set; }

        /// <summary>
        /// Checks to see if the AzEl property is set.
        /// </summary>
        internal bool IsSetAzEl() => this.AzEl != null;

        /// <summary>
        /// Gets and sets the property Oem. 
        /// <para>
        /// Program track settings for <a>OEMEphemeris</a>.
        /// </para>
        /// </summary>
        public OemProgramTrackSettings Oem { get; set; }

        /// <summary>
        /// Checks to see if the Oem property is set.
        /// </summary>
        internal bool IsSetOem() => this.Oem != null;

        /// <summary>
        /// Gets and sets the property Tle. 
        /// <para>
        /// Program track settings for <a>TLEEphemeris</a>.
        /// </para>
        /// </summary>
        public TleProgramTrackSettings Tle { get; set; }

        /// <summary>
        /// Checks to see if the Tle property is set.
        /// </summary>
        internal bool IsSetTle() => this.Tle != null;
    }
}
