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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Translate.Model
{
    /// <summary>
    /// Container for the parameters to the TranslateDocument operation.
    /// Translates the input document from the source language to the target language. This
    /// synchronous operation supports text, HTML, or Word documents as the input document.
    /// <c>TranslateDocument</c> supports translations from English to any supported language,
    /// and from any supported language to English. Therefore, specify either the source language
    /// code or the target language code as “en” (English). 
    /// 
    ///  
    /// <para>
    ///  If you set the <c>Formality</c> parameter, the request will fail if the target language
    /// does not support formality. For a list of target languages that support formality,
    /// see <a href="https://docs.aws.amazon.com/translate/latest/dg/customizing-translations-formality.html">Setting
    /// formality</a>. 
    /// </para>
    /// </summary>
    public partial class TranslateDocumentRequest : AmazonTranslateRequest
    {
        private Document _document;
        private TranslationSettings _settings;
        private string _sourceLanguageCode;
        private string _targetLanguageCode;
        private List<string> _terminologyNames = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Document. 
        /// <para>
        /// The content and content type for the document to be translated. The document size
        /// must not exceed 100 KB.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Document Document
        {
            get { return this._document; }
            set { this._document = value; }
        }

        // Check to see if Document property is set
        internal bool IsSetDocument()
        {
            return this._document != null;
        }

        /// <summary>
        /// Gets and sets the property Settings. 
        /// <para>
        /// Settings to configure your translation output. You can configure the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Brevity: not supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Formality: sets the formality level of the output text.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Profanity: masks profane words and phrases in your translation output.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public TranslationSettings Settings
        {
            get { return this._settings; }
            set { this._settings = value; }
        }

        // Check to see if Settings property is set
        internal bool IsSetSettings()
        {
            return this._settings != null;
        }

        /// <summary>
        /// Gets and sets the property SourceLanguageCode. 
        /// <para>
        /// The language code for the language of the source text. For a list of supported language
        /// codes, see <a href="https://docs.aws.amazon.com/translate/latest/dg/what-is-languages.html">Supported
        /// languages</a>.
        /// </para>
        ///  
        /// <para>
        /// To have Amazon Translate determine the source language of your text, you can specify
        /// <c>auto</c> in the <c>SourceLanguageCode</c> field. If you specify <c>auto</c>, Amazon
        /// Translate will call <a href="https://docs.aws.amazon.com/comprehend/latest/dg/comprehend-general.html">Amazon
        /// Comprehend</a> to determine the source language.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you specify <c>auto</c>, you must send the <c>TranslateDocument</c> request in
        /// a region that supports Amazon Comprehend. Otherwise, the request returns an error
        /// indicating that autodetect is not supported. 
        /// </para>
        ///  </note>
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
        /// The language code requested for the translated document. For a list of supported language
        /// codes, see <a href="https://docs.aws.amazon.com/translate/latest/dg/what-is-languages.html">Supported
        /// languages</a>.
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
        /// Gets and sets the property TerminologyNames. 
        /// <para>
        /// The name of a terminology list file to add to the translation job. This file provides
        /// source terms and the desired translation for each term. A terminology list can contain
        /// a maximum of 256 terms. You can use one custom terminology resource in your translation
        /// request.
        /// </para>
        ///  
        /// <para>
        /// Use the <a>ListTerminologies</a> operation to get the available terminology lists.
        /// </para>
        ///  
        /// <para>
        /// For more information about custom terminology lists, see <a href="https://docs.aws.amazon.com/translate/latest/dg/how-custom-terminology.html">Custom
        /// terminology</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TerminologyNames
        {
            get { return this._terminologyNames; }
            set { this._terminologyNames = value; }
        }

        // Check to see if TerminologyNames property is set
        internal bool IsSetTerminologyNames()
        {
            return this._terminologyNames != null && (this._terminologyNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}