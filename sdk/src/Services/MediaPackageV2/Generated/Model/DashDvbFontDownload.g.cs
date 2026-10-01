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

namespace Amazon.MediaPackageV2.Model
{
    /// <summary>
    /// For use with DVB-DASH profiles only. The settings for font downloads that you want
    /// Elemental MediaPackage to pass through to the manifest.
    /// </summary>
    public partial class DashDvbFontDownload
    {
        /// <summary>
        /// Gets and sets the property FontFamily. 
        /// <para>
        /// The <c>fontFamily</c> name for subtitles, as described in <a href="https://tech.ebu.ch/publications/tech3380">EBU-TT-D
        /// Subtitling Distribution Format</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string FontFamily { get; set; }

        /// <summary>
        /// Checks to see if the FontFamily property is set.
        /// </summary>
        internal bool IsSetFontFamily() => this.FontFamily != null;

        /// <summary>
        /// Gets and sets the property MimeType. 
        /// <para>
        /// The <c>mimeType</c> of the resource that's at the font download URL.
        /// </para>
        ///  
        /// <para>
        /// For information about font MIME types, see the <a href="https://dvb.org/wp-content/uploads/2021/06/A168r4_MPEG-DASH-Profile-for-Transport-of-ISO-BMFF-Based-DVB-Services_Draft-ts_103-285-v140_November_2021.pdf">MPEG-DASH
        /// Profile for Transport of ISO BMFF Based DVB Services over IP Based Networks</a> document.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string MimeType { get; set; }

        /// <summary>
        /// Checks to see if the MimeType property is set.
        /// </summary>
        internal bool IsSetMimeType() => this.MimeType != null;

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The URL for downloading fonts for subtitles.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Url { get; set; }

        /// <summary>
        /// Checks to see if the Url property is set.
        /// </summary>
        internal bool IsSetUrl() => this.Url != null;
    }
}
