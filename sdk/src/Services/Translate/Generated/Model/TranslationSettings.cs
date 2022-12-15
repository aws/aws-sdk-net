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
 * Do not modify this file. This file is generated from the translate-2017-07-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Translate.Model
{
    /// <summary>
    /// Optional settings that configure the translation output. Use these settings for real
    /// time translations and asynchronous translation jobs.
    /// </summary>
    public partial class TranslationSettings
    {
        private Formality _formality;
        private Profanity _profanity;

        /// <summary>
        /// Gets and sets the property Formality. 
        /// <para>
        /// You can optionally specify the desired level of formality for translations to supported
        /// target languages. The formality setting controls the level of formal language usage
        /// (also known as <a href="https://en.wikipedia.org/wiki/Register_(sociolinguistics)">register</a>)
        /// in the translation output. You can set the value to informal or formal. If you don't
        /// specify a value for formality, or if the target language doesn't support formality,
        /// the translation will ignore the formality setting.
        /// </para>
        ///  
        /// <para>
        ///  If you specify multiple target languages for the job, translate ignores the formality
        /// setting for any unsupported target language.
        /// </para>
        ///  
        /// <para>
        /// For a list of target languages that support formality, see <a href="https://docs.aws.amazon.com/translate/latest/dg/customizing-translations-formality.html#customizing-translations-formality-languages">Supported
        /// languages</a> in the Amazon Translate Developer Guide.
        /// </para>
        /// </summary>
        public Formality Formality
        {
            get { return this._formality; }
            set { this._formality = value; }
        }

        // Check to see if Formality property is set
        internal bool IsSetFormality()
        {
            return this._formality != null;
        }

        /// <summary>
        /// Gets and sets the property Profanity. 
        /// <para>
        /// Enable the profanity setting if you want Amazon Translate to mask profane words and
        /// phrases in your translation output.
        /// </para>
        ///  
        /// <para>
        /// To mask profane words and phrases, Amazon Translate replaces them with the grawlix
        /// string “?$#@$“. This 5-character sequence is used for each profane word or phrase,
        /// regardless of the length or number of words.
        /// </para>
        ///  
        /// <para>
        /// Amazon Translate doesn't detect profanity in all of its supported languages. For languages
        /// that don't support profanity detection, see <a href="https://docs.aws.amazon.com/translate/latest/dg/customizing-translations-profanity.html#customizing-translations-profanity-languages">Unsupported
        /// languages</a> in the Amazon Translate Developer Guide.
        /// </para>
        ///  
        /// <para>
        /// If you specify multiple target languages for the job, all the target languages must
        /// support profanity masking. If any of the target languages don't support profanity
        /// masking, the translation job won't mask profanity for any target language.
        /// </para>
        /// </summary>
        public Profanity Profanity
        {
            get { return this._profanity; }
            set { this._profanity = value; }
        }

        // Check to see if Profanity property is set
        internal bool IsSetProfanity()
        {
            return this._profanity != null;
        }

    }
}