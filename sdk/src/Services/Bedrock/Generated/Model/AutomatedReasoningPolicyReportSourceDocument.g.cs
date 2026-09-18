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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property AtomicStatements. 
        /// <para>
        /// The list of atomic statements extracted from this document, representing the fundamental
        /// units of meaning used for grounding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<AutomatedReasoningPolicyAtomicStatement> AtomicStatements { get; set; } = AWSConfigs.InitializeCollections ? new List<AutomatedReasoningPolicyAtomicStatement>() : null;

        /// <summary>
        /// Checks to see if the AtomicStatements property is set.
        /// </summary>
        internal bool IsSetAtomicStatements() => this.AtomicStatements != null && (this.AtomicStatements.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DocumentContent. 
        /// <para>
        /// The document's content organized into annotated chunks with line number information
        /// for precise referencing.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<AutomatedReasoningPolicyAnnotatedChunk> DocumentContent { get; set; } = AWSConfigs.InitializeCollections ? new List<AutomatedReasoningPolicyAnnotatedChunk>() : null;

        /// <summary>
        /// Checks to see if the DocumentContent property is set.
        /// </summary>
        internal bool IsSetDocumentContent() => this.DocumentContent != null && (this.DocumentContent.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DocumentHash. 
        /// <para>
        /// A SHA-256 hash of the document content, used for verification and ensuring the document
        /// hasn't changed since analysis.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 64, Max = 64)]
        public string DocumentHash { get; set; }

        /// <summary>
        /// Checks to see if the DocumentHash property is set.
        /// </summary>
        internal bool IsSetDocumentHash() => this.DocumentHash != null;

        /// <summary>
        /// Gets and sets the property DocumentId. 
        /// <para>
        /// A unique identifier for this document within the fidelity report.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 8)]
        public string DocumentId { get; set; }

        /// <summary>
        /// Checks to see if the DocumentId property is set.
        /// </summary>
        internal bool IsSetDocumentId() => this.DocumentId != null;

        /// <summary>
        /// Gets and sets the property DocumentName. 
        /// <para>
        /// The name of the source document that was analyzed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Max = 256)]
        public string DocumentName { get; set; }

        /// <summary>
        /// Checks to see if the DocumentName property is set.
        /// </summary>
        internal bool IsSetDocumentName() => this.DocumentName != null;
    }
}
