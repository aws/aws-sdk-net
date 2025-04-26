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
    /// Add an array item for each language. Follow the order of the caption descriptions.
    /// For example, if the first caption description is for German, then the first array
    /// item must be for German, and its caption channel must be set to 1. The second array
    /// item must be 2, and so on.
    /// </summary>
    public partial class CmafIngestCaptionLanguageMapping
    {
        private int? _captionChannel;
        private string _languageCode;

        /// <summary>
        /// Gets and sets the property CaptionChannel. A number for the channel for this caption,
        /// 1 to 4.
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
        /// Gets and sets the property LanguageCode. Language code for the language of the caption
        /// in this channel.  For example, ger/deu. See http://www.loc.gov/standards/iso639-2
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

    }
}