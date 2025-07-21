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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
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
namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// Contains the payload content for an event.
    /// </summary>
    public partial class PayloadType
    {
        private Amazon.Runtime.Documents.Document _blob;
        private Conversational _conversational;

        /// <summary>
        /// Gets and sets the property Blob. 
        /// <para>
        /// The binary content of the payload.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document Blob
        {
            get { return this._blob; }
            set { this._blob = value; }
        }

        // Check to see if Blob property is set
        internal bool IsSetBlob()
        {
            return !this._blob.IsNull();
        }

        /// <summary>
        /// Gets and sets the property Conversational. 
        /// <para>
        /// The conversational content of the payload.
        /// </para>
        /// </summary>
        public Conversational Conversational
        {
            get { return this._conversational; }
            set { this._conversational = value; }
        }

        // Check to see if Conversational property is set
        internal bool IsSetConversational()
        {
            return this._conversational != null;
        }

    }
}