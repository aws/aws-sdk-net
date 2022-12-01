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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Container for the parameters to the DetectEntities operation.
    /// Detects named entities in input text when you use the pre-trained model. Detects custom
    /// entities if you have a custom entity recognition model. 
    /// 
    ///  
    /// <para>
    ///  When detecting named entities using the pre-trained model, use plain text as the
    /// input. For more information about named entities, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/how-entities.html">Entities</a>
    /// in the Comprehend Developer Guide.
    /// </para>
    ///  
    /// <para>
    /// When you use a custom entity recognition model, you can input plain text or you can
    /// upload a single-page input document (text, PDF, Word, or image). 
    /// </para>
    ///  
    /// <para>
    /// If the system detects errors while processing a page in the input document, the API
    /// response includes an entry in <code>Errors</code> for each error. 
    /// </para>
    ///  
    /// <para>
    /// If the system detects a document-level error in your input document, the API returns
    /// an <code>InvalidRequestException</code> error response. For details about this exception,
    /// see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/idp-inputs-sync-err.html">
    /// Errors in semi-structured documents</a> in the Comprehend Developer Guide. 
    /// </para>
    /// </summary>
    public partial class DetectEntitiesRequest : AmazonComprehendRequest
    {
        private MemoryStream _bytes;
        private DocumentReaderConfig _documentReaderConfig;
        private string _endpointArn;
        private LanguageCode _languageCode;
        private string _text;

        /// <summary>
        /// Gets and sets the property Bytes. 
        /// <para>
        /// This field applies only when you use a custom entity recognition model that was trained
        /// with PDF annotations. For other cases, enter your text input in the <code>Text</code>
        /// field.
        /// </para>
        ///  
        /// <para>
        ///  Use the <code>Bytes</code> parameter to input a text, PDF, Word or image file. Using
        /// a plain-text file in the <code>Bytes</code> parameter is equivelent to using the <code>Text</code>
        /// parameter (the <code>Entities</code> field in the response is identical).
        /// </para>
        ///  
        /// <para>
        /// You can also use the <code>Bytes</code> parameter to input an Amazon Textract <code>DetectDocumentText</code>
        /// or <code>AnalyzeDocument</code> output file.
        /// </para>
        ///  
        /// <para>
        /// Provide the input document as a sequence of base64-encoded bytes. If your code uses
        /// an Amazon Web Services SDK to detect entities, the SDK may encode the document file
        /// bytes for you. 
        /// </para>
        ///  
        /// <para>
        /// The maximum length of this field depends on the input document type. For details,
        /// see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/idp-inputs-sync.html">
        /// Inputs for real-time custom analysis</a> in the Comprehend Developer Guide. 
        /// </para>
        ///  
        /// <para>
        /// If you use the <code>Bytes</code> parameter, do not use the <code>Text</code> parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public MemoryStream Bytes
        {
            get { return this._bytes; }
            set { this._bytes = value; }
        }

        // Check to see if Bytes property is set
        internal bool IsSetBytes()
        {
            return this._bytes != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentReaderConfig. 
        /// <para>
        /// Provides configuration parameters to override the default actions for extracting text
        /// from PDF documents and image files.
        /// </para>
        /// </summary>
        public DocumentReaderConfig DocumentReaderConfig
        {
            get { return this._documentReaderConfig; }
            set { this._documentReaderConfig = value; }
        }

        // Check to see if DocumentReaderConfig property is set
        internal bool IsSetDocumentReaderConfig()
        {
            return this._documentReaderConfig != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointArn. 
        /// <para>
        /// The Amazon Resource Name of an endpoint that is associated with a custom entity recognition
        /// model. Provide an endpoint if you want to detect entities by using your own custom
        /// model instead of the default model that is used by Amazon Comprehend.
        /// </para>
        ///  
        /// <para>
        /// If you specify an endpoint, Amazon Comprehend uses the language of your custom model,
        /// and it ignores any language code that you provide in your request.
        /// </para>
        ///  
        /// <para>
        /// For information about endpoints, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/manage-endpoints.html">Managing
        /// endpoints</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string EndpointArn
        {
            get { return this._endpointArn; }
            set { this._endpointArn = value; }
        }

        // Check to see if EndpointArn property is set
        internal bool IsSetEndpointArn()
        {
            return this._endpointArn != null;
        }

        /// <summary>
        /// Gets and sets the property LanguageCode. 
        /// <para>
        /// The language of the input documents. You can specify any of the primary languages
        /// supported by Amazon Comprehend. If your request includes the endpoint for a custom
        /// entity recognition model, Amazon Comprehend uses the language of your custom model,
        /// and it ignores any language code that you specify here.
        /// </para>
        ///  
        /// <para>
        /// All input documents must be in the same language.
        /// </para>
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
        /// Gets and sets the property Text. 
        /// <para>
        /// A UTF-8 text string. The maximum string size is 100 KB. If you enter text using this
        /// parameter, do not use the <code>Bytes</code> parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string Text
        {
            get { return this._text; }
            set { this._text = value; }
        }

        // Check to see if Text property is set
        internal bool IsSetText()
        {
            return this._text != null;
        }

    }
}