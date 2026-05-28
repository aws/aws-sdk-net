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
 * Do not modify this file. This file is generated from the elementalinference-2018-11-14.normal.json service model.
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
namespace Amazon.ElementalInference.Model
{
    /// <summary>
    /// A type of OutputConfig, used when the output in a feed is for the smart subtitling
    /// feature. smart subtitling uses automatic speech recognition (ASR) to generate live
    /// TTML subtitles from the audio in your source media.
    /// </summary>
    public partial class SubtitlingConfig
    {
        private AspectRatio _aspectRatio;
        private string _dictionary;
        private TranscriptionLanguage _language;
        private ProfanityFilterMode _profanityFilter;

        /// <summary>
        /// Gets and sets the property AspectRatio. 
        /// <para>
        /// The aspect ratio of the output video, specified as width and height integer values.
        /// Elemental Inference uses the aspect ratio to determine subtitle layout and line lengths.
        /// 
        /// </para>
        /// </summary>
        public AspectRatio AspectRatio
        {
            get { return this._aspectRatio; }
            set { this._aspectRatio = value; }
        }

        // Check to see if AspectRatio property is set
        internal bool IsSetAspectRatio()
        {
            return this._aspectRatio != null;
        }

        /// <summary>
        /// Gets and sets the property Dictionary. 
        /// <para>
        /// The ID of a custom dictionary to improve transcription accuracy for domain-specific
        /// terminology. Use the CreateDictionary operation to create a dictionary. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=19)]
        public string Dictionary
        {
            get { return this._dictionary; }
            set { this._dictionary = value; }
        }

        // Check to see if Dictionary property is set
        internal bool IsSetDictionary()
        {
            return this._dictionary != null;
        }

        /// <summary>
        /// Gets and sets the property Language. 
        /// <para>
        /// The language of the audio in the source media. Elemental Inference uses this setting
        /// to optimize transcription accuracy. Specify the language using an ISO 639-2/T three-letter
        /// code, optionally with a region subtag. Supported values: eng, eng-au, eng-gb, eng-us,
        /// fra, ita, deu, spa, por. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TranscriptionLanguage Language
        {
            get { return this._language; }
            set { this._language = value; }
        }

        // Check to see if Language property is set
        internal bool IsSetLanguage()
        {
            return this._language != null;
        }

        /// <summary>
        /// Gets and sets the property ProfanityFilter. 
        /// <para>
        /// Controls how profanity is handled in the generated subtitles. Valid values: DISABLED
        /// (no filtering, default), CENSOR (replace profanity with asterisks), DROP (remove profanity
        /// from the transcript). 
        /// </para>
        /// </summary>
        public ProfanityFilterMode ProfanityFilter
        {
            get { return this._profanityFilter; }
            set { this._profanityFilter = value; }
        }

        // Check to see if ProfanityFilter property is set
        internal bool IsSetProfanityFilter()
        {
            return this._profanityFilter != null;
        }

    }
}