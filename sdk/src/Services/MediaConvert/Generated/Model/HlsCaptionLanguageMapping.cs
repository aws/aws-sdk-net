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
    /// Caption Language Mapping
    /// </summary>
    public partial class HlsCaptionLanguageMapping
    {
        private int? _captionChannel;
        private string _customLanguageCode;
        private LanguageCode _languageCode;
        private string _languageDescription;

        /// <summary>
        /// Gets and sets the property CaptionChannel. Caption channel.
        /// </summary>
        [AWSProperty(Min=-2147483648, Max=2147483647)]
        public int? CaptionChannel
        {
            get { return this._captionChannel; }
            set { this._captionChannel = value; }
        }

        // Check to see if CaptionChannel property is set
        internal bool IsSetCaptionChannel()
        {
            return this._captionChannel.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CustomLanguageCode. Specify the language for this captions
        /// channel, using the ISO 639-2 or ISO 639-3 three-letter language code
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
        /// Gets and sets the property LanguageCode. Specify the language, using the ISO 639-2
        /// three-letter code listed at https://www.loc.gov/standards/iso639-2/php/code_list.php.
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
        /// Gets and sets the property LanguageDescription. Caption language description.
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