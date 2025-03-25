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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
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
namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// Specifies the configuration for audio stream metrics monitoring.
    /// </summary>
    public partial class AudioMonitoringSetting
    {
        private SilentAudio _silentAudio;

        /// <summary>
        /// Gets and sets the property SilentAudio. 
        /// <para>
        ///  Detects periods of silence. 
        /// </para>
        /// </summary>
        public SilentAudio SilentAudio
        {
            get { return this._silentAudio; }
            set { this._silentAudio = value; }
        }

        // Check to see if SilentAudio property is set
        internal bool IsSetSilentAudio()
        {
            return this._silentAudio != null;
        }

    }
}