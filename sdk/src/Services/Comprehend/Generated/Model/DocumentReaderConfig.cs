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
    /// The input properties for a topic detection job.
    /// </summary>
    public partial class DocumentReaderConfig
    {
        private DocumentReadAction _documentReadAction;
        private DocumentReadMode _documentReadMode;
        private List<string> _featureTypes = new List<string>();

        /// <summary>
        /// Gets and sets the property DocumentReadAction. 
        /// <para>
        /// This enum field will start with two values which will apply to PDFs:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>TEXTRACT_DETECT_DOCUMENT_TEXT</code> - The service calls DetectDocumentText
        /// for PDF documents per page.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TEXTRACT_ANALYZE_DOCUMENT</code> - The service calls AnalyzeDocument for PDF
        /// documents per page.
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
        /// This enum field provides two values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>SERVICE_DEFAULT</code> - use service defaults for Document reading. For Digital
        /// PDF it would mean using an internal parser instead of Textract APIs
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FORCE_DOCUMENT_READ_ACTION</code> - Always use specified action for DocumentReadAction,
        /// including Digital PDF. 
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
        /// Specifies how the text in an input file should be processed:
        /// </para>
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