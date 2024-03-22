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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// An object containing a segment of the generated response that is based on a source
    /// in the knowledge base, alongside information about the source.
    /// </summary>
    public partial class Citation
    {
        private GeneratedResponsePart _generatedResponsePart;
        private List<RetrievedReference> _retrievedReferences = AWSConfigs.InitializeCollections ? new List<RetrievedReference>() : null;

        /// <summary>
        /// Gets and sets the property GeneratedResponsePart. 
        /// <para>
        /// Contains the generated response and metadata 
        /// </para>
        /// </summary>
        public GeneratedResponsePart GeneratedResponsePart
        {
            get { return this._generatedResponsePart; }
            set { this._generatedResponsePart = value; }
        }

        // Check to see if GeneratedResponsePart property is set
        internal bool IsSetGeneratedResponsePart()
        {
            return this._generatedResponsePart != null;
        }

        /// <summary>
        /// Gets and sets the property RetrievedReferences. 
        /// <para>
        /// Contains metadata about the sources cited for the generated response.
        /// </para>
        /// </summary>
        public List<RetrievedReference> RetrievedReferences
        {
            get { return this._retrievedReferences; }
            set { this._retrievedReferences = value; }
        }

        // Check to see if RetrievedReferences property is set
        internal bool IsSetRetrievedReferences()
        {
            return this._retrievedReferences != null && (this._retrievedReferences.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}