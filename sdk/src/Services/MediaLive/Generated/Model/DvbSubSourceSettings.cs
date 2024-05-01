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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
        private DvbSubOcrLanguage _ocrLanguage;
        private int? _pid;

        /// <summary>
        /// Gets and sets the property OcrLanguage. If you will configure a WebVTT caption description
        /// that references this caption selector, use this field toprovide the language to consider
        /// when translating the image-based source to text.
        /// </summary>
        public DvbSubOcrLanguage OcrLanguage
        {
            get { return this._ocrLanguage; }
            set { this._ocrLanguage = value; }
        }

        // Check to see if OcrLanguage property is set
        internal bool IsSetOcrLanguage()
        {
            return this._ocrLanguage != null;
        }

        /// <summary>
        /// Gets and sets the property Pid. When using DVB-Sub with Burn-In or SMPTE-TT, use this
        /// PID for the source content. Unused for DVB-Sub passthrough. All DVB-Sub content is
        /// passed through, regardless of selectors.
        /// </summary>
        [AWSProperty(Min=1)]
        public int? Pid
        {
            get { return this._pid; }
            set { this._pid = value; }
        }

        // Check to see if Pid property is set
        internal bool IsSetPid()
        {
            return this._pid.HasValue; 
        }

    }
}