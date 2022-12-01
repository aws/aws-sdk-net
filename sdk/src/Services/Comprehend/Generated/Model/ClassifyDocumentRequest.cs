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
    /// Container for the parameters to the ClassifyDocument operation.
    /// Creates a new document classification request to analyze a single document in real-time,
    /// using a previously created and trained custom model and an endpoint.
    /// 
    ///  
    /// <para>
    /// You can input plain text or you can upload a single-page input document (text, PDF,
    /// Word, or image). 
    /// </para>
    ///  
    /// <para>
    /// If the system detects errors while processing a page in the input document, the API
    /// response includes an entry in <code>Errors</code> that describes the errors.
    /// </para>
    ///  
    /// <para>
    /// If the system detects a document-level error in your input document, the API returns
    /// an <code>InvalidRequestException</code> error response. For details about this exception,
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
        /// Use the <code>Bytes</code> parameter to input a text, PDF, Word or image file. You
        /// can also use the <code>Bytes</code> parameter to input an Amazon Textract <code>DetectDocumentText</code>
        /// or <code>AnalyzeDocument</code> output file.
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
        /// The Amazon Resource Number (ARN) of the endpoint. For information about endpoints,
        /// see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/manage-endpoints.html">Managing
        /// endpoints</a>.
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
        /// the <code>Bytes</code> parameter.
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