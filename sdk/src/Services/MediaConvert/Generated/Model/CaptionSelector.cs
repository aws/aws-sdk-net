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
    /// Use captions selectors to specify the captions data from your input that you use in
    /// your outputs. You can use up to 100 captions selectors per input.
    /// </summary>
    public partial class CaptionSelector
    {
        private string _customLanguageCode;
        private LanguageCode _languageCode;
        private CaptionSourceSettings _sourceSettings;

        /// <summary>
        /// Gets and sets the property CustomLanguageCode. The specific language to extract from
        /// source, using the ISO 639-2 or ISO 639-3 three-letter language code. If input is SCTE-27,
        /// complete this field and/or PID to select the caption language to extract. If input
        /// is DVB-Sub and output is Burn-in, complete this field and/or PID to select the caption
        /// language to extract. If input is DVB-Sub that is being passed through, omit this field
        /// (and PID field); there is no way to extract a specific language with pass-through
        /// captions.
        /// </summary>
        [AWSProperty(Min=3, Max=3)]
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
        /// Gets and sets the property LanguageCode. The specific language to extract from source.
        /// If input is SCTE-27, complete this field and/or PID to select the caption language
        /// to extract. If input is DVB-Sub and output is Burn-in, complete this field and/or
        /// PID to select the caption language to extract. If input is DVB-Sub that is being passed
        /// through, omit this field (and PID field); there is no way to extract a specific language
        /// with pass-through captions.
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
        /// Gets and sets the property SourceSettings. If your input captions are SCC, TTML, STL,
        /// SMI, SRT, or IMSC in an xml file, specify the URI of the input captions source file.
        /// If your input captions are IMSC in an IMF package, use TrackSourceSettings instead
        /// of FileSoureSettings.
        /// </summary>
        public CaptionSourceSettings SourceSettings
        {
            get { return this._sourceSettings; }
            set { this._sourceSettings = value; }
        }

        // Check to see if SourceSettings property is set
        internal bool IsSetSourceSettings()
        {
            return this._sourceSettings != null;
        }

    }
}