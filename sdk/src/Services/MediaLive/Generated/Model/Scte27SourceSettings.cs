/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Placeholder documentation for Scte27SourceSettings
    /// </summary>
    public partial class Scte27SourceSettings
    {
        private int? _pid;

        /// <summary>
        /// Gets and sets the property Pid. The pid field is used in conjunction with the caption
        /// selector languageCode field as follows:  - Specify PID and Language: Extracts captions
        /// from that PID; the language is "informational".  - Specify PID and omit Language:
        /// Extracts the specified PID.  - Omit PID and specify Language: Extracts the specified
        /// language, whichever PID that happens to be.  - Omit PID and omit Language: Valid only
        /// if source is DVB-Sub that is being passed through; all languages will be passed through.
        /// </summary>
        public int Pid
        {
            get { return this._pid.GetValueOrDefault(); }
            set { this._pid = value; }
        }

        // Check to see if Pid property is set
        internal bool IsSetPid()
        {
            return this._pid.HasValue; 
        }

    }
}