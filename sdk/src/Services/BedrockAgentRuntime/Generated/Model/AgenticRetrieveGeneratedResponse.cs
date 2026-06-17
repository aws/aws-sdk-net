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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// The generated response synthesized from retrieved results.
    /// </summary>
    public partial class AgenticRetrieveGeneratedResponse
    {
        private string _answer;
        private List<AgenticRetrieveCitation> _citations = AWSConfigs.InitializeCollections ? new List<AgenticRetrieveCitation>() : null;

        /// <summary>
        /// Gets and sets the property Answer. 
        /// <para>
        /// The generated answer text.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Answer
        {
            get { return this._answer; }
            set { this._answer = value; }
        }

        // Check to see if Answer property is set
        internal bool IsSetAnswer()
        {
            return this._answer != null;
        }

        /// <summary>
        /// Gets and sets the property Citations. 
        /// <para>
        /// Citations mapping spans of the answer to supporting results.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AgenticRetrieveCitation> Citations
        {
            get { return this._citations; }
            set { this._citations = value; }
        }

        // Check to see if Citations property is set
        internal bool IsSetCitations()
        {
            return this._citations != null && (this._citations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}