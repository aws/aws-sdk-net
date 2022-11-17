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

namespace Amazon.Textract.Model
{
    /// <summary>
    /// Container for the parameters to the AnalyzeDocument operation.
    /// Analyzes an input document for relationships between detected items. 
    /// 
    ///  
    /// <para>
    /// The types of information returned are as follows: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Form data (key-value pairs). The related information is returned in two <a>Block</a>
    /// objects, each of type <code>KEY_VALUE_SET</code>: a KEY <code>Block</code> object
    /// and a VALUE <code>Block</code> object. For example, <i>Name: Ana Silva Carolina</i>
    /// contains a key and value. <i>Name:</i> is the key. <i>Ana Silva Carolina</i> is the
    /// value.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Table and table cell data. A TABLE <code>Block</code> object contains information
    /// about a detected table. A CELL <code>Block</code> object is returned for each cell
    /// in a table.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Lines and words of text. A LINE <code>Block</code> object contains one or more WORD
    /// <code>Block</code> objects. All lines and words that are detected in the document
    /// are returned (including text that doesn't have a relationship with the value of <code>FeatureTypes</code>).
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Signatures. A SIGNATURE <code>Block</code> object contains the location information
    /// of a signature in a document. If used in conjunction with forms or tables, a signature
    /// can be given a Key-Value pairing or be detected in the cell of a table.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Query. A QUERY Block object contains the query text, alias and link to the associated
    /// Query results block object.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Query Result. A QUERY_RESULT Block object contains the answer to the query and an
    /// ID that connects it to the query asked. This Block also contains a confidence score.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Selection elements such as check boxes and option buttons (radio buttons) can be detected
    /// in form data and in tables. A SELECTION_ELEMENT <code>Block</code> object contains
    /// information about a selection element, including the selection status.
    /// </para>
    ///  
    /// <para>
    /// You can choose which type of analysis to perform by specifying the <code>FeatureTypes</code>
    /// list. 
    /// </para>
    ///  
    /// <para>
    /// The output is returned in a list of <code>Block</code> objects.
    /// </para>
    ///  
    /// <para>
    ///  <code>AnalyzeDocument</code> is a synchronous operation. To analyze documents asynchronously,
    /// use <a>StartDocumentAnalysis</a>.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/textract/latest/dg/how-it-works-analyzing.html">Document
    /// Text Analysis</a>.
    /// </para>
    /// </summary>
    public partial class AnalyzeDocumentRequest : AmazonTextractRequest
    {
        private Document _document;
        private List<string> _featureTypes = new List<string>();
        private HumanLoopConfig _humanLoopConfig;
        private QueriesConfig _queriesConfig;

        /// <summary>
        /// Gets and sets the property Document. 
        /// <para>
        /// The input document as base64-encoded bytes or an Amazon S3 object. If you use the
        /// AWS CLI to call Amazon Textract operations, you can't pass image bytes. The document
        /// must be an image in JPEG, PNG, PDF, or TIFF format.
        /// </para>
        ///  
        /// <para>
        /// If you're using an AWS SDK to call Amazon Textract, you might not need to base64-encode
        /// image bytes that are passed using the <code>Bytes</code> field. 
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

        /// <summary>
        /// Gets and sets the property FeatureTypes. 
        /// <para>
        /// A list of the types of analysis to perform. Add TABLES to the list to return information
        /// about the tables that are detected in the input document. Add FORMS to return detected
        /// form data. Add SIGNATURES to return the locations of detected signatures. To perform
        /// both forms and table analysis, add TABLES and FORMS to <code>FeatureTypes</code>.
        /// To detect signatures within form data and table data, add SIGNATURES to either TABLES
        /// or FORMS. All lines and words detected in the document are included in the response
        /// (including text that isn't related to the value of <code>FeatureTypes</code>). 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property HumanLoopConfig. 
        /// <para>
        /// Sets the configuration for the human in the loop workflow for analyzing documents.
        /// </para>
        /// </summary>
        public HumanLoopConfig HumanLoopConfig
        {
            get { return this._humanLoopConfig; }
            set { this._humanLoopConfig = value; }
        }

        // Check to see if HumanLoopConfig property is set
        internal bool IsSetHumanLoopConfig()
        {
            return this._humanLoopConfig != null;
        }

        /// <summary>
        /// Gets and sets the property QueriesConfig. 
        /// <para>
        /// Contains Queries and the alias for those Queries, as determined by the input. 
        /// </para>
        /// </summary>
        public QueriesConfig QueriesConfig
        {
            get { return this._queriesConfig; }
            set { this._queriesConfig = value; }
        }

        // Check to see if QueriesConfig property is set
        internal bool IsSetQueriesConfig()
        {
            return this._queriesConfig != null;
        }

    }
}