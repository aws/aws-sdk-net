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
    /// This is the response object from the AnalyzeDocument operation.
    /// </summary>
    public partial class AnalyzeDocumentResponse : AmazonWebServiceResponse
    {
        private string _analyzeDocumentModelVersion;
        private List<Block> _blocks = new List<Block>();
        private DocumentMetadata _documentMetadata;
        private HumanLoopActivationOutput _humanLoopActivationOutput;

        /// <summary>
        /// Gets and sets the property AnalyzeDocumentModelVersion. 
        /// <para>
        /// The version of the model used to analyze the document.
        /// </para>
        /// </summary>
        public string AnalyzeDocumentModelVersion
        {
            get { return this._analyzeDocumentModelVersion; }
            set { this._analyzeDocumentModelVersion = value; }
        }

        // Check to see if AnalyzeDocumentModelVersion property is set
        internal bool IsSetAnalyzeDocumentModelVersion()
        {
            return this._analyzeDocumentModelVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Blocks. 
        /// <para>
        /// The items that are detected and analyzed by <code>AnalyzeDocument</code>.
        /// </para>
        /// </summary>
        public List<Block> Blocks
        {
            get { return this._blocks; }
            set { this._blocks = value; }
        }

        // Check to see if Blocks property is set
        internal bool IsSetBlocks()
        {
            return this._blocks != null && this._blocks.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DocumentMetadata. 
        /// <para>
        /// Metadata about the analyzed document. An example is the number of pages.
        /// </para>
        /// </summary>
        public DocumentMetadata DocumentMetadata
        {
            get { return this._documentMetadata; }
            set { this._documentMetadata = value; }
        }

        // Check to see if DocumentMetadata property is set
        internal bool IsSetDocumentMetadata()
        {
            return this._documentMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property HumanLoopActivationOutput. 
        /// <para>
        /// Shows the results of the human in the loop evaluation.
        /// </para>
        /// </summary>
        public HumanLoopActivationOutput HumanLoopActivationOutput
        {
            get { return this._humanLoopActivationOutput; }
            set { this._humanLoopActivationOutput = value; }
        }

        // Check to see if HumanLoopActivationOutput property is set
        internal bool IsSetHumanLoopActivationOutput()
        {
            return this._humanLoopActivationOutput != null;
        }

    }
}