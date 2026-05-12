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
    /// Represents a source document that was processed during a build workflow. Contains
    /// the document content, metadata, and a hash for verification.
    /// </summary>
    public partial class AutomatedReasoningPolicySourceDocument
    {
        private MemoryStream _document;
        private AutomatedReasoningPolicyBuildDocumentContentType _documentContentType;
        private string _documentDescription;
        private string _documentHash;
        private string _documentName;

        /// <summary>
        /// Gets and sets the property Document. 
        /// <para>
        /// The raw content of the source document as a binary blob.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=5000000)]
        public MemoryStream Document
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
        /// Gets and sets the property DocumentContentType. 
        /// <para>
        /// The MIME type of the document (e.g., application/pdf, text/plain).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AutomatedReasoningPolicyBuildDocumentContentType DocumentContentType
        {
            get { return this._documentContentType; }
            set { this._documentContentType = value; }
        }

        // Check to see if DocumentContentType property is set
        internal bool IsSetDocumentContentType()
        {
            return this._documentContentType != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentDescription. 
        /// <para>
        /// An optional description providing context about the document's content and purpose.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=4000)]
        public string DocumentDescription
        {
            get { return this._documentDescription; }
            set { this._documentDescription = value; }
        }

        // Check to see if DocumentDescription property is set
        internal bool IsSetDocumentDescription()
        {
            return this._documentDescription != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentHash. 
        /// <para>
        /// A SHA-256 hash of the document content, used for verification and integrity checking.
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
        /// Gets and sets the property DocumentName. 
        /// <para>
        /// The name of the source document for identification purposes.
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