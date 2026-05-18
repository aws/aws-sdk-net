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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// An inline custom instruction with text content and optional file upload metadata.
    /// </summary>
    public partial class InlineCustomInstruction
    {
        private string _instructionText;
        private UploadedDocumentMetadata _uploadedDocumentMetadata;

        /// <summary>
        /// Gets and sets the property InstructionText. 
        /// <para>
        /// The instruction text content.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=0, Max=50000)]
        public string InstructionText
        {
            get { return this._instructionText; }
            set { this._instructionText = value; }
        }

        // Check to see if InstructionText property is set
        internal bool IsSetInstructionText()
        {
            return this._instructionText != null;
        }

        /// <summary>
        /// Gets and sets the property UploadedDocumentMetadata. 
        /// <para>
        /// Metadata about an uploaded document associated with this instruction.
        /// </para>
        /// </summary>
        public UploadedDocumentMetadata UploadedDocumentMetadata
        {
            get { return this._uploadedDocumentMetadata; }
            set { this._uploadedDocumentMetadata = value; }
        }

        // Check to see if UploadedDocumentMetadata property is set
        internal bool IsSetUploadedDocumentMetadata()
        {
            return this._uploadedDocumentMetadata != null;
        }

    }
}