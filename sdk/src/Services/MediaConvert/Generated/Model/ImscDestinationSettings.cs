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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
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
namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Settings related to IMSC captions. IMSC is a sidecar format that holds captions in
    /// a file that is separate from the video container. Set up sidecar captions in the same
    /// output group, but different output from your video. For more information, see https://docs.aws.amazon.com/mediaconvert/latest/ug/ttml-and-webvtt-output-captions.html.
    /// </summary>
    public partial class ImscDestinationSettings
    {
        private ImscAccessibilitySubs _accessibility;
        private ImscStylePassthrough _stylePassthrough;

        /// <summary>
        /// Gets and sets the property Accessibility. If the IMSC captions track is intended to
        /// provide accessibility for people who are deaf or hard of hearing: Set Accessibility
        /// subtitles to Enabled. When you do, MediaConvert adds accessibility attributes to your
        /// output HLS or DASH manifest. For HLS manifests, MediaConvert adds the following accessibility
        /// attributes under EXT-X-MEDIA for this track: CHARACTERISTICS="public.accessibility.describes-spoken-dialog,public.accessibility.describes-music-and-sound"
        /// and AUTOSELECT="YES". For DASH manifests, MediaConvert adds the following in the adaptation
        /// set for this track: <Accessibility schemeIdUri="urn:mpeg:dash:role:2011" value="caption"/>.
        /// If the captions track is not intended to provide such accessibility: Keep the default
        /// value, Disabled. When you do, for DASH manifests, MediaConvert instead adds the following
        /// in the adaptation set for this track: <Role schemeIDUri="urn:mpeg:dash:role:2011"
        /// value="subtitle"/>.
        /// </summary>
        public ImscAccessibilitySubs Accessibility
        {
            get { return this._accessibility; }
            set { this._accessibility = value; }
        }

        // Check to see if Accessibility property is set
        internal bool IsSetAccessibility()
        {
            return this._accessibility != null;
        }

        /// <summary>
        /// Gets and sets the property StylePassthrough. Keep this setting enabled to have MediaConvert
        /// use the font style and position information from the captions source in the output.
        /// This option is available only when your input captions are IMSC, SMPTE-TT, or TTML.
        /// Disable this setting for simplified output captions.
        /// </summary>
        public ImscStylePassthrough StylePassthrough
        {
            get { return this._stylePassthrough; }
            set { this._stylePassthrough = value; }
        }

        // Check to see if StylePassthrough property is set
        internal bool IsSetStylePassthrough()
        {
            return this._stylePassthrough != null;
        }

    }
}