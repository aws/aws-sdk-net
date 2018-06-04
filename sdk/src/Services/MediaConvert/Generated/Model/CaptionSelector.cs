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
    /// Set up captions in your outputs by first selecting them from your input here.
    /// </summary>
    public partial class CaptionSelector
    {
        private LanguageCode _languageCode;
        private CaptionSourceSettings _sourceSettings;

        /// <summary>
        /// Gets and sets the property LanguageCode. The specific language to extract from source.
        /// If input is SCTE-27, complete this field and/or PID to select the caption language
        /// to extract. If input is DVB-Sub and output is Burn-in or SMPTE-TT, complete this field
        /// and/or PID to select the caption language to extract. If input is DVB-Sub that is
        /// being passed through, omit this field (and PID field); there is no way to extract
        /// a specific language with pass-through captions.
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
        /// Gets and sets the property SourceSettings.
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