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
 * Do not modify this file. This file is generated from the textract-2018-06-27.normal.json service model.
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
namespace Amazon.Textract.Model
{
    /// <summary>
    /// Container for the parameters to the DetectDocumentText operation.
    /// Detects text in the input document. Amazon Textract can detect lines of text and the
    /// words that make up a line of text. The input document must be in one of the following
    /// image formats: JPEG, PNG, PDF, or TIFF. <c>DetectDocumentText</c> returns the detected
    /// text in an array of <a>Block</a> objects. 
    /// 
    ///  
    /// <para>
    /// Each document page has as an associated <c>Block</c> of type PAGE. Each PAGE <c>Block</c>
    /// object is the parent of LINE <c>Block</c> objects that represent the lines of detected
    /// text on a page. A LINE <c>Block</c> object is a parent for each word that makes up
    /// the line. Words are represented by <c>Block</c> objects of type WORD.
    /// </para>
    ///  
    /// <para>
    ///  <c>DetectDocumentText</c> is a synchronous operation. To analyze documents asynchronously,
    /// use <a>StartDocumentTextDetection</a>.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/textract/latest/dg/how-it-works-detecting.html">Document
    /// Text Detection</a>.
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
        /// must be an image in JPEG or PNG format.
        /// </para>
        ///  
        /// <para>
        /// If you're using an AWS SDK to call Amazon Textract, you might not need to base64-encode
        /// image bytes that are passed using the <c>Bytes</c> field. 
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

    }
}