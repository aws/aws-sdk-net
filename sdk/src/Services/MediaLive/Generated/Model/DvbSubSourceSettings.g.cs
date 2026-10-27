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
    /// Dvb Sub Source Settings
    /// </summary>
    public partial class DvbSubSourceSettings
    {
        /// <summary>
        /// Gets and sets the property OcrLanguage. If you will configure a WebVTT caption description
        /// that references this caption selector, use this field to provide the language to consider
        /// when translating the image-based source to text.
        /// </summary>
        public DvbSubOcrLanguage OcrLanguage { get; set; }

        /// <summary>
        /// Checks to see if the OcrLanguage property is set.
        /// </summary>
        internal bool IsSetOcrLanguage() => this.OcrLanguage != null;

        /// <summary>
        /// Gets and sets the property Pid. When using DVB-Sub with Burn-In or SMPTE-TT, use this
        /// PID for the source content. Unused for DVB-Sub passthrough. All DVB-Sub content is
        /// passed through, regardless of selectors.
        /// </summary>
        public int? Pid { get; set; }

        /// <summary>
        /// Checks to see if the Pid property is set.
        /// </summary>
        internal bool IsSetPid() => this.Pid.HasValue;
    }
}
