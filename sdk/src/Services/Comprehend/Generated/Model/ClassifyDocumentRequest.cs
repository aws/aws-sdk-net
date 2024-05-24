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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Container for the parameters to the ClassifyDocument operation.
    /// Creates a classification request to analyze a single document in real-time. <c>ClassifyDocument</c>
    /// supports the following model types:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Custom classifier - a custom model that you have created and trained. For input, you
    /// can provide plain text, a single-page document (PDF, Word, or image), or Amazon Textract
    /// API output. For more information, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/how-document-classification.html">Custom
    /// classification</a> in the <i>Amazon Comprehend Developer Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Prompt safety classifier - Amazon Comprehend provides a pre-trained model for classifying
    /// input prompts for generative AI applications. For input, you provide English plain
    /// text input. For prompt safety classification, the response includes only the <c>Classes</c>
    /// field. For more information about prompt safety classifiers, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/trust-safety.html#prompt-classification">Prompt
    /// safety classification</a> in the <i>Amazon Comprehend Developer Guide</i>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If the system detects errors while processing a page in the input document, the API
    /// response includes an <c>Errors</c> field that describes the errors.
    /// </para>
    ///  
    /// <para>
    /// If the system detects a document-level error in your input document, the API returns
    /// an <c>InvalidRequestException</c> error response. For details about this exception,
    /// see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/idp-inputs-sync-err.html">
    /// Errors in semi-structured documents</a> in the Comprehend Developer Guide. 
    /// </para>
    /// </summary>
    public partial class ClassifyDocumentRequest : AmazonComprehendRequest
    {
        private MemoryStream _bytes;
        private DocumentReaderConfig _documentReaderConfig;
        private string _endpointArn;
        private string _text;

        /// <summary>
        /// Gets and sets the property Bytes. 
        /// <para>
        /// Use the <c>Bytes</c> parameter to input a text, PDF, Word or image file.
        /// </para>
        ///  
        /// <para>
        /// When you classify a document using a custom model, you can also use the <c>Bytes</c>
        /// parameter to input an Amazon Textract <c>DetectDocumentText</c> or <c>AnalyzeDocument</c>
        /// output file.
        /// </para>
        ///  
        /// <para>
        /// To classify a document using the prompt safety classifier, use the <c>Text</c> parameter
        /// for input.
        /// </para>
        ///  
        /// <para>
        /// Provide the input document as a sequence of base64-encoded bytes. If your code uses
        /// an Amazon Web Services SDK to classify documents, the SDK may encode the document
        /// file bytes for you. 
        /// </para>
        ///  
        /// <para>
        /// The maximum length of this field depends on the input document type. For details,
        /// see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/idp-inputs-sync.html">
        /// Inputs for real-time custom analysis</a> in the Comprehend Developer Guide. 
        /// </para>
        ///  
        /// <para>
        /// If you use the <c>Bytes</c> parameter, do not use the <c>Text</c> parameter.
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
        /// The Amazon Resource Number (ARN) of the endpoint. 
        /// </para>
        ///  
        /// <para>
        /// For prompt safety classification, Amazon Comprehend provides the endpoint ARN. For
        /// more information about prompt safety classifiers, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/trust-safety.html#prompt-classification">Prompt
        /// safety classification</a> in the <i>Amazon Comprehend Developer Guide</i> 
        /// </para>
        ///  
        /// <para>
        /// For custom classification, you create an endpoint for your custom model. For more
        /// information, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/using-endpoints.html">Using
        /// Amazon Comprehend endpoints</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
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
        /// Gets and sets the property Text. 
        /// <para>
        /// The document text to be analyzed. If you enter text using this parameter, do not use
        /// the <c>Bytes</c> parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1)]
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