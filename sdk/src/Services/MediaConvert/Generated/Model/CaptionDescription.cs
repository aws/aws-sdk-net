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
    /// This object holds groups of settings related to captions for one output. For each
    /// output that has captions, include one instance of CaptionDescriptions.
    /// </summary>
    public partial class CaptionDescription
    {
        private string _captionSelectorName;
        private string _customLanguageCode;
        private CaptionDestinationSettings _destinationSettings;
        private LanguageCode _languageCode;
        private string _languageDescription;

        /// <summary>
        /// Gets and sets the property CaptionSelectorName. Specifies which "Caption Selector":#inputs-caption_selector
        /// to use from each input when generating captions. The name should be of the format
        /// "Caption Selector <N>", which denotes that the Nth Caption Selector will be used from
        /// each input.
        /// </summary>
        [AWSProperty(Min=1)]
        public string CaptionSelectorName
        {
            get { return this._captionSelectorName; }
            set { this._captionSelectorName = value; }
        }

        // Check to see if CaptionSelectorName property is set
        internal bool IsSetCaptionSelectorName()
        {
            return this._captionSelectorName != null;
        }

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
        public string CustomLanguageCode
        {
            get { return this._customLanguageCode; }
            set { this._customLanguageCode = value; }
        }

        // Check to see if CustomLanguageCode property is set
        internal bool IsSetCustomLanguageCode()
        {
            return this._customLanguageCode != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationSettings. Settings related to one captions tab
        /// on the MediaConvert console. Usually, one captions tab corresponds to one output captions
        /// track. Depending on your output captions format, one tab might correspond to a set
        /// of output captions tracks. For more information, see https://docs.aws.amazon.com/mediaconvert/latest/ug/including-captions.html.
        /// </summary>
        public CaptionDestinationSettings DestinationSettings
        {
            get { return this._destinationSettings; }
            set { this._destinationSettings = value; }
        }

        // Check to see if DestinationSettings property is set
        internal bool IsSetDestinationSettings()
        {
            return this._destinationSettings != null;
        }

        /// <summary>
        /// Gets and sets the property LanguageCode. Specify the language of this captions output
        /// track. For most captions output formats, the encoder puts this language information
        /// in the output captions metadata. If your output captions format is DVB-Sub or Burn
        /// in, the encoder uses this language information to choose the font language for rendering
        /// the captions text.
        /// </summary>
        public LanguageCode LanguageCode
        {
            get { return this._languageCode; }
            set { this._languageCode = value; }
        }

        // Check to see if LanguageCode property is set
        internal bool IsSetLanguageCode()
        {
            return this._languageCode != null;
        }

        /// <summary>
        /// Gets and sets the property LanguageDescription. Specify a label for this set of output
        /// captions. For example, "English", "Director commentary", or "track_2". For streaming
        /// outputs, MediaConvert passes this information into destination manifests for display
        /// on the end-viewer's player device. For outputs in other output groups, the service
        /// ignores this setting.
        /// </summary>
        public string LanguageDescription
        {
            get { return this._languageDescription; }
            set { this._languageDescription = value; }
        }

        // Check to see if LanguageDescription property is set
        internal bool IsSetLanguageDescription()
        {
            return this._languageDescription != null;
        }

    }
}