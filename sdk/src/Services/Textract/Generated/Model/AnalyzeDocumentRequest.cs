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
    /// Container for the parameters to the AnalyzeDocument operation.
    /// Analyzes an input document for relationships in the detected text and tables. 
    /// 
    ///  
    /// <para>
    /// Two types of information are returned: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Words and lines that are related to nearby lines and words. The related information
    /// is returned in two <a>Block</a> objects: a KEY Block object and a VALUE Block object.
    /// For example, <i>Name: Ana Silva Carolina</i> contains a key and value. <i>Name:</i>
    /// is the key. <i>Ana Silva Carolina</i> is the value.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Table and table cell data. A TABLE Block contains information about a detected table.
    /// A CELL block is returned for each cell in a table.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You can choose which type of analysis to perform by specifying the <code>FeatureTypes</code>
    /// list. 
    /// </para>
    ///  
    /// <para>
    /// The output is returned in a list of <code>BLOCK</code> objects (Blocks). For more
    /// information, see <a>how-it-works-analyzing</a>.
    /// </para>
    ///  
    /// <para>
    ///  <code>AnalyzeDocument</code> is a synchronous operation. To analyze documents asynchronously,
    /// use <a>StartDocumentAnalysis</a>.
    /// </para>
    /// </summary>
    public partial class AnalyzeDocumentRequest : AmazonTextractRequest
    {
        private Document _document;
        private List<string> _featureTypes = new List<string>();

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

        /// <summary>
        /// Gets and sets the property FeatureTypes. 
        /// <para>
        /// A list of the types of analysis to perform. Add TABLES to the list to return information
        /// about the tables detected in the input document. Add FORMS to return detected fields
        /// and the associated text. To perform both types of analysis, add TABLES and FORMS to
        /// <code>FeatureTypes</code>.
        /// </para>
        /// </summary>
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