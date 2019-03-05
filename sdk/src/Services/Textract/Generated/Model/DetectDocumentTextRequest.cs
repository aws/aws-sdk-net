/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the textract-2018-06-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Textract.Model
{
    /// <summary>
    /// Container for the parameters to the DetectDocumentText operation.
    /// Detects text in the input document. Amazon Textract can detect lines of text and the
    /// words that make up a line of text. The input document must be an image in JPG or PNG
    /// format. <code>DetectDocumentText</code> returns the detected text in an array of <a>Block</a>
    /// objects. For more information, see <a>how-it-works-detecting</a>.
    /// 
    ///  
    /// <para>
    ///  <code>DetectDocumentText</code> is a synchronous operation. To analyze documents
    /// asynchronously, use <a>StartDocumentTextDetection</a>.
    /// </para>
    /// </summary>
    public partial class DetectDocumentTextRequest : AmazonTextractRequest
    {
        private Document _document;

        /// <summary>
        /// Gets and sets the property Document. 
        /// <para>
        /// The input document as base64-encoded bytes or an Amazon S3 object. If you use the
        /// AWS CLI to call Amazon Textract operations, you can't pass image bytes. The document
        /// must be an image in JPG or PNG format.
        /// </para>
        /// </summary>
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

    }
}