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
    /// <c>DetectDocumentText</c> API to extract the text. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <c>DocumentReaderConfig</c> does not apply to plain text files or Word files.
    /// </para>
    ///  
    /// <para>
    ///  For image files and PDF documents, you can override these default actions using the
    /// fields listed below. For more information, see <a href="https://docs.aws.amazon.com/comprehend/latest/dg/idp-set-textract-options.html">
    /// Setting text extraction options</a> in the Comprehend Developer Guide. 
    /// </para>
    /// </summary>
    public partial class DocumentReaderConfig
    {
        private DocumentReadAction _documentReadAction;
        private DocumentReadMode _documentReadMode;
        private List<string> _featureTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property DocumentReadAction. 
        /// <para>
        /// This field defines the Amazon Textract API operation that Amazon Comprehend uses to
        /// extract text from PDF files and image files. Enter one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>TEXTRACT_DETECT_DOCUMENT_TEXT</c> - The Amazon Comprehend service uses the <c>DetectDocumentText</c>
        /// API operation. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TEXTRACT_ANALYZE_DOCUMENT</c> - The Amazon Comprehend service uses the <c>AnalyzeDocument</c>
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
        ///  <c>SERVICE_DEFAULT</c> - use the Amazon Comprehend service defaults for PDF files.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FORCE_DOCUMENT_READ_ACTION</c> - Amazon Comprehend uses the Textract API specified
        /// by DocumentReadAction for all PDF files, including digital PDF files. 
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
        /// Specifies the type of Amazon Textract features to apply. If you chose <c>TEXTRACT_ANALYZE_DOCUMENT</c>
        /// as the read action, you must specify one or both of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>TABLES</c> - Returns additional information about any tables that are detected
        /// in the input document. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FORMS</c> - Returns additional information about any forms that are detected in
        /// the input document. 
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._featureTypes != null && (this._featureTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}