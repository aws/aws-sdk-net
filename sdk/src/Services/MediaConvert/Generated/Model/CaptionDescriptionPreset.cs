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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Caption Description for preset
    /// </summary>
    public partial class CaptionDescriptionPreset
    {
        private string _customLanguageCode;
        private CaptionDestinationSettings _destinationSettings;
        private LanguageCode _languageCode;
        private string _languageDescription;

        /// <summary>
        /// Gets and sets the property CustomLanguageCode. Indicates the language of the caption
        /// output track, using the ISO 639-2 or ISO 639-3 three-letter language code
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
        /// Gets and sets the property DestinationSettings.
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
        /// Gets and sets the property LanguageCode. Indicates the language of the caption output
        /// track.
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
        /// Gets and sets the property LanguageDescription. Human readable information to indicate
        /// captions available for players (eg. English, or Spanish). Alphanumeric characters,
        /// spaces, and underscore are legal.
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