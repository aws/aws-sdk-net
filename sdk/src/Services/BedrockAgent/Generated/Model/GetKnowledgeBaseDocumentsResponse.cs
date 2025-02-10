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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// This is the response object from the GetKnowledgeBaseDocuments operation.
    /// </summary>
    public partial class GetKnowledgeBaseDocumentsResponse : AmazonWebServiceResponse
    {
        private List<KnowledgeBaseDocumentDetail> _documentDetails = AWSConfigs.InitializeCollections ? new List<KnowledgeBaseDocumentDetail>() : null;

        /// <summary>
        /// Gets and sets the property DocumentDetails. 
        /// <para>
        /// A list of objects, each of which contains information about the documents that were
        /// retrieved.
        /// </para>
        /// </summary>
        public List<KnowledgeBaseDocumentDetail> DocumentDetails
        {
            get { return this._documentDetails; }
            set { this._documentDetails = value; }
        }

        // Check to see if DocumentDetails property is set
        internal bool IsSetDocumentDetails()
        {
            return this._documentDetails != null && (this._documentDetails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}