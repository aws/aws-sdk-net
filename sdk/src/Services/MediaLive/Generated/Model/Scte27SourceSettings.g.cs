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

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Scte27 Source Settings
    /// </summary>
    public partial class Scte27SourceSettings
    {
        /// <summary>
        /// Gets and sets the property OcrLanguage. If you will configure a WebVTT caption description
        /// that references this caption selector, use this field to provide the language to consider
        /// when translating the image-based source to text.
        /// </summary>
        public Scte27OcrLanguage OcrLanguage { get; set; }

        /// <summary>
        /// Checks to see if the OcrLanguage property is set.
        /// </summary>
        internal bool IsSetOcrLanguage() => this.OcrLanguage != null;

        /// <summary>
        /// Gets and sets the property Pid. The pid field is used in conjunction with the caption
        /// selector languageCode field as follows: - Specify PID and Language: Extracts captions
        /// from that PID; the language is "informational". - Specify PID and omit Language: Extracts
        /// the specified PID. - Omit PID and specify Language: Extracts the specified language,
        /// whichever PID that happens to be. - Omit PID and omit Language: Valid only if source
        /// is DVB-Sub that is being passed through; all languages will be passed through.
        /// </summary>
        public int? Pid { get; set; }

        /// <summary>
        /// Checks to see if the Pid property is set.
        /// </summary>
        internal bool IsSetPid() => this.Pid.HasValue;
    }
}
