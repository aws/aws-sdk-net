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
    /// This is the response object from the TranslateDocument operation.
    /// </summary>
    public partial class TranslateDocumentResponse : AmazonWebServiceResponse
    {
        private TranslationSettings _appliedSettings;
        private List<AppliedTerminology> _appliedTerminologies = AWSConfigs.InitializeCollections ? new List<AppliedTerminology>() : null;
        private string _sourceLanguageCode;
        private string _targetLanguageCode;
        private TranslatedDocument _translatedDocument;

        /// <summary>
        /// Gets and sets the property AppliedSettings.
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
        /// to produce the translated text document.
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
            return this._appliedTerminologies != null && (this._appliedTerminologies.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SourceLanguageCode. 
        /// <para>
        /// The language code of the source document.
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
        /// The language code of the translated document. 
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
        /// Gets and sets the property TranslatedDocument. 
        /// <para>
        /// The document containing the translated content. The document format matches the source
        /// document format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TranslatedDocument TranslatedDocument
        {
            get { return this._translatedDocument; }
            set { this._translatedDocument = value; }
        }

        // Check to see if TranslatedDocument property is set
        internal bool IsSetTranslatedDocument()
        {
            return this._translatedDocument != null;
        }

    }
}