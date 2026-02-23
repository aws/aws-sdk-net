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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Represents a source document that was analyzed during fidelity report generation,
    /// including the document's metadata and its content broken down into atomic statements.
    /// </summary>
    public partial class AutomatedReasoningPolicyReportSourceDocument
    {
        private List<AutomatedReasoningPolicyAtomicStatement> _atomicStatements = AWSConfigs.InitializeCollections ? new List<AutomatedReasoningPolicyAtomicStatement>() : null;
        private List<AutomatedReasoningPolicyAnnotatedChunk> _documentContent = AWSConfigs.InitializeCollections ? new List<AutomatedReasoningPolicyAnnotatedChunk>() : null;
        private string _documentHash;
        private string _documentId;
        private string _documentName;

        /// <summary>
        /// Gets and sets the property AtomicStatements. 
        /// <para>
        /// The list of atomic statements extracted from this document, representing the fundamental
        /// units of meaning used for grounding.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AutomatedReasoningPolicyAtomicStatement> AtomicStatements
        {
            get { return this._atomicStatements; }
            set { this._atomicStatements = value; }
        }

        // Check to see if AtomicStatements property is set
        internal bool IsSetAtomicStatements()
        {
            return this._atomicStatements != null && (this._atomicStatements.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DocumentContent. 
        /// <para>
        /// The document's content organized into annotated chunks with line number information
        /// for precise referencing.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AutomatedReasoningPolicyAnnotatedChunk> DocumentContent
        {
            get { return this._documentContent; }
            set { this._documentContent = value; }
        }

        // Check to see if DocumentContent property is set
        internal bool IsSetDocumentContent()
        {
            return this._documentContent != null && (this._documentContent.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DocumentHash. 
        /// <para>
        /// A SHA-256 hash of the document content, used for verification and ensuring the document
        /// hasn't changed since analysis.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=64, Max=64)]
        public string DocumentHash
        {
            get { return this._documentHash; }
            set { this._documentHash = value; }
        }

        // Check to see if DocumentHash property is set
        internal bool IsSetDocumentHash()
        {
            return this._documentHash != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentId. 
        /// <para>
        /// A unique identifier for this document within the fidelity report.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=8)]
        public string DocumentId
        {
            get { return this._documentId; }
            set { this._documentId = value; }
        }

        // Check to see if DocumentId property is set
        internal bool IsSetDocumentId()
        {
            return this._documentId != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentName. 
        /// <para>
        /// The name of the source document that was analyzed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=0, Max=256)]
        public string DocumentName
        {
            get { return this._documentName; }
            set { this._documentName = value; }
        }

        // Check to see if DocumentName property is set
        internal bool IsSetDocumentName()
        {
            return this._documentName != null;
        }

    }
}