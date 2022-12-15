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
    /// This is the response object from the TranslateText operation.
    /// </summary>
    public partial class TranslateTextResponse : AmazonWebServiceResponse
    {
        private TranslationSettings _appliedSettings;
        private List<AppliedTerminology> _appliedTerminologies = new List<AppliedTerminology>();
        private string _sourceLanguageCode;
        private string _targetLanguageCode;
        private string _translatedText;

        /// <summary>
        /// Gets and sets the property AppliedSettings. 
        /// <para>
        /// Settings that configure the translation output.
        /// </para>
        /// </summary>
        public TranslationSettings AppliedSettings
        {
            get { return this._appliedSettings; }
            set { this._appliedSettings = value; }
        }

        // Check to see if AppliedSettings property is set
        internal bool IsSetAppliedSettings()
        {
            return this._appliedSettings != null;
        }

        /// <summary>
        /// Gets and sets the property AppliedTerminologies. 
        /// <para>
        /// The names of the custom terminologies applied to the input text by Amazon Translate
        /// for the translated text response.
        /// </para>
        /// </summary>
        public List<AppliedTerminology> AppliedTerminologies
        {
            get { return this._appliedTerminologies; }
            set { this._appliedTerminologies = value; }
        }

        // Check to see if AppliedTerminologies property is set
        internal bool IsSetAppliedTerminologies()
        {
            return this._appliedTerminologies != null && this._appliedTerminologies.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SourceLanguageCode. 
        /// <para>
        /// The language code for the language of the source text.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=5)]
        public string SourceLanguageCode
        {
            get { return this._sourceLanguageCode; }
            set { this._sourceLanguageCode = value; }
        }

        // Check to see if SourceLanguageCode property is set
        internal bool IsSetSourceLanguageCode()
        {
            return this._sourceLanguageCode != null;
        }

        /// <summary>
        /// Gets and sets the property TargetLanguageCode. 
        /// <para>
        /// The language code for the language of the target text. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=5)]
        public string TargetLanguageCode
        {
            get { return this._targetLanguageCode; }
            set { this._targetLanguageCode = value; }
        }

        // Check to see if TargetLanguageCode property is set
        internal bool IsSetTargetLanguageCode()
        {
            return this._targetLanguageCode != null;
        }

        /// <summary>
        /// Gets and sets the property TranslatedText. 
        /// <para>
        /// The translated text.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=20000)]
        public string TranslatedText
        {
            get { return this._translatedText; }
            set { this._translatedText = value; }
        }

        // Check to see if TranslatedText property is set
        internal bool IsSetTranslatedText()
        {
            return this._translatedText != null;
        }

    }
}