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
    /// Settings that configure the translation output.
    /// </summary>
    public partial class TranslationSettings
    {
        private Formality _formality;
        private Profanity _profanity;

        /// <summary>
        /// Gets and sets the property Formality.
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
        /// Amazon Translate does not detect profanity in all of its supported languages. For
        /// languages that support profanity detection, see <a href="https://docs.aws.amazon.com/translate/latest/dg/what-is.html#what-is-languages">Supported
        /// Languages and Language Codes in the Amazon Translate Developer Guide</a>.
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