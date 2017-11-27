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
    /// Output groups for this Live Event. Output groups contain information about where streams
    /// should be distributed.
    /// </summary>
    public partial class CaptionDescription
    {
        private string _captionSelectorName;
        private CaptionDestinationSettings _destinationSettings;
        private string _languageCode;
        private string _languageDescription;
        private string _name;

        /// <summary>
        /// Gets and sets the property CaptionSelectorName. Specifies which input caption selector
        /// to use as a caption source when generating output captions. This field should match
        /// a captionSelector name.
        /// </summary>
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
        /// Gets and sets the property DestinationSettings. Additional settings for captions destination
        /// that depend on the destination type.
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
        /// Gets and sets the property LanguageCode. ISO 639-2 three-digit code: http://www.loc.gov/standards/iso639-2/
        /// </summary>
        public string LanguageCode
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
        /// captions available for players (eg. English, or Spanish).
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

        /// <summary>
        /// Gets and sets the property Name. Name of the caption description.  Used to associate
        /// a caption description with an output.  Names must be unique within an event.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}