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
    /// Maps a caption channel to an ISO 693-2 language code (http://www.loc.gov/standards/iso639-2),
    /// with an optional description.
    /// </summary>
    public partial class CaptionLanguageMapping
    {
        private int? _captionChannel;
        private string _languageCode;
        private string _languageDescription;

        /// <summary>
        /// Gets and sets the property CaptionChannel. The closed caption channel being described
        /// by this CaptionLanguageMapping.  Each channel mapping must have a unique channel number
        /// (maximum of 4)
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4)]
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
        /// Gets and sets the property LanguageCode. Three character ISO 639-2 language code (see
        /// http://www.loc.gov/standards/iso639-2)
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=3)]
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
        /// Gets and sets the property LanguageDescription. Textual description of language
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
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