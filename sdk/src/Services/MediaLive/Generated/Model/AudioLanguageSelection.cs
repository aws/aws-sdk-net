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
    /// Audio Language Selection
    /// </summary>
    public partial class AudioLanguageSelection
    {
        private string _languageCode;
        private AudioLanguageSelectionPolicy _languageSelectionPolicy;

        /// <summary>
        /// Gets and sets the property LanguageCode. Selects a specific three-letter language
        /// code from within an audio source.
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property LanguageSelectionPolicy. When set to "strict", the transport
        /// stream demux strictly identifies audio streams by their language descriptor. If a
        /// PMT update occurs such that an audio stream matching the initially selected language
        /// is no longer present then mute will be encoded until the language returns. If "loose",
        /// then on a PMT update the demux will choose another audio stream in the program with
        /// the same stream type if it can't find one with the same language.
        /// </summary>
        public AudioLanguageSelectionPolicy LanguageSelectionPolicy
        {
            get { return this._languageSelectionPolicy; }
            set { this._languageSelectionPolicy = value; }
        }

        // Check to see if LanguageSelectionPolicy property is set
        internal bool IsSetLanguageSelectionPolicy()
        {
            return this._languageSelectionPolicy != null;
        }

    }
}