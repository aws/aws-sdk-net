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

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// This object holds groups of settings related to captions for one output. For each
    /// output that has captions, include one instance of CaptionDescriptions.
    /// </summary>
    public partial class CaptionDescription
    {
        /// <summary>
        /// Gets and sets the property CaptionSelectorName. Specifies which "Caption Selector":#inputs-caption_selector
        /// to use from each input when generating captions. The name should be of the format
        /// "Caption Selector &lt;N&gt;", which denotes that the Nth Caption Selector will be
        /// used from each input.
        /// </summary>
        [AWSProperty(Min = 1)]
        public string CaptionSelectorName { get; set; }

        /// <summary>
        /// Checks to see if the CaptionSelectorName property is set.
        /// </summary>
        internal bool IsSetCaptionSelectorName() => this.CaptionSelectorName != null;

        /// <summary>
        /// Gets and sets the property CustomLanguageCode. Specify the language for this captions
        /// output track. For most captions output formats, the encoder puts this language information
        /// in the output captions metadata. If your output captions format is DVB-Sub or Burn
        /// in, the encoder uses this language information when automatically selecting the font
        /// script for rendering the captions text. For all outputs, you can use an ISO 639-2
        /// or ISO 639-3 code. For streaming outputs, you can also use any other code in the full
        /// RFC-5646 specification. Streaming outputs are those that are in one of the following
        /// output groups: CMAF, DASH ISO, Apple HLS, or Microsoft Smooth Streaming.
        /// </summary>
        public string CustomLanguageCode { get; set; }

        /// <summary>
        /// Checks to see if the CustomLanguageCode property is set.
        /// </summary>
        internal bool IsSetCustomLanguageCode() => this.CustomLanguageCode != null;

        /// <summary>
        /// Gets and sets the property DestinationSettings. Settings related to one captions tab
        /// on the MediaConvert console. Usually, one captions tab corresponds to one output captions
        /// track. Depending on your output captions format, one tab might correspond to a set
        /// of output captions tracks. For more information, see https://docs.aws.amazon.com/mediaconvert/latest/ug/including-captions.html.
        /// </summary>
        public CaptionDestinationSettings DestinationSettings { get; set; }

        /// <summary>
        /// Checks to see if the DestinationSettings property is set.
        /// </summary>
        internal bool IsSetDestinationSettings() => this.DestinationSettings != null;

        /// <summary>
        /// Gets and sets the property LanguageCode. Specify the language of this captions output
        /// track. For most captions output formats, the encoder puts this language information
        /// in the output captions metadata. If your output captions format is DVB-Sub or Burn
        /// in, the encoder uses this language information to choose the font language for rendering
        /// the captions text.
        /// </summary>
        public LanguageCode LanguageCode { get; set; }

        /// <summary>
        /// Checks to see if the LanguageCode property is set.
        /// </summary>
        internal bool IsSetLanguageCode() => this.LanguageCode != null;

        /// <summary>
        /// Gets and sets the property LanguageDescription. Specify a label for this set of output
        /// captions. For example, "English", "Director commentary", or "track_2". For streaming
        /// outputs, MediaConvert passes this information into destination manifests for display
        /// on the end-viewer's player device. For outputs in other output groups, the service
        /// ignores this setting.
        /// </summary>
        public string LanguageDescription { get; set; }

        /// <summary>
        /// Checks to see if the LanguageDescription property is set.
        /// </summary>
        internal bool IsSetLanguageDescription() => this.LanguageDescription != null;
    }
}
