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
    /// Provides configuration parameters to override the default actions for extracting text
    /// from PDF documents and image files. 
    /// 
    ///  
    /// <para>
    ///  By default, Amazon Comprehend performs the following actions to extract text from
    /// files, based on the input file type: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Word files</b> - Amazon Comprehend parser extracts the text. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Digital PDF files</b> - Amazon Comprehend parser extracts the text. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Image files and scanned PDF files</b> - Amazon Comprehend uses the Amazon Textract
    /// <code>DetectDocumentText</code> API to extract the text. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <code>DocumentReaderConfig</code> does not apply to plain text files or Word files.
    /// </para>
    ///  
    /// <para>
    ///  For image files and PDF documents, you can override these default actions using the
    /// fields listed below. For more information, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/detecting-cer.html#detecting-cer-pdf">
    /// Setting text extraction options</a>. 
    /// </para>
    /// </summary>
    public partial class DocumentReaderConfig
    {
        private DocumentReadAction _documentReadAction;
        private DocumentReadMode _documentReadMode;
        private List<string> _featureTypes = new List<string>();

        /// <summary>
        /// Gets and sets the property DocumentReadAction. 
        /// <para>
        /// This field defines the Amazon Textract API operation that Amazon Comprehend uses to
        /// extract text from PDF files and image files. Enter one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>TEXTRACT_DETECT_DOCUMENT_TEXT</code> - The Amazon Comprehend service uses the
        /// <code>DetectDocumentText</code> API operation. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TEXTRACT_ANALYZE_DOCUMENT</code> - The Amazon Comprehend service uses the <code>AnalyzeDocument</code>
        /// API operation. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public DocumentReadAction DocumentReadAction
        {
            get { return this._documentReadAction; }
            set { this._documentReadAction = value; }
        }

        // Check to see if DocumentReadAction property is set
        internal bool IsSetDocumentReadAction()
        {
            return this._documentReadAction != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentReadMode. 
        /// <para>
        /// Determines the text extraction actions for PDF files. Enter one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>SERVICE_DEFAULT</code> - use the Amazon Comprehend service defaults for PDF
        /// files.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FORCE_DOCUMENT_READ_ACTION</code> - Amazon Comprehend uses the Textract API
        /// specified by DocumentReadAction for all PDF files, including digital PDF files. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DocumentReadMode DocumentReadMode
        {
            get { return this._documentReadMode; }
            set { this._documentReadMode = value; }
        }

        // Check to see if DocumentReadMode property is set
        internal bool IsSetDocumentReadMode()
        {
            return this._documentReadMode != null;
        }

        /// <summary>
        /// Gets and sets the property FeatureTypes. 
        /// <para>
        /// Specifies the type of Amazon Textract features to apply. If you chose <code>TEXTRACT_ANALYZE_DOCUMENT</code>
        /// as the read action, you must specify one or both of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>TABLES</code> - Returns information about any tables that are detected in the
        /// input document. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FORMS</code> - Returns information and the data from any forms that are detected
        /// in the input document. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public List<string> FeatureTypes
        {
            get { return this._featureTypes; }
            set { this._featureTypes = value; }
        }

        // Check to see if FeatureTypes property is set
        internal bool IsSetFeatureTypes()
        {
            return this._featureTypes != null && this._featureTypes.Count > 0; 
        }

    }
}