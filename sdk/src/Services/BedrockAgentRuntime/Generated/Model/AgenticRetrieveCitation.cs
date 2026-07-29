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
    /// A citation mapping a span of the generated answer to supporting results.
    /// </summary>
    public partial class AgenticRetrieveCitation
    {
        private int? _endIndex;
        private List<AgenticRetrieveCitationReference> _references = AWSConfigs.InitializeCollections ? new List<AgenticRetrieveCitationReference>() : null;
        private int? _startIndex;

        /// <summary>
        /// Gets and sets the property EndIndex. 
        /// <para>
        /// Character offset end (exclusive) in the answer text.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? EndIndex
        {
            get { return this._endIndex; }
            set { this._endIndex = value; }
        }

        // Check to see if EndIndex property is set
        internal bool IsSetEndIndex()
        {
            return this._endIndex.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property References. 
        /// <para>
        /// References to results that support this span.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AgenticRetrieveCitationReference> References
        {
            get { return this._references; }
            set { this._references = value; }
        }

        // Check to see if References property is set
        internal bool IsSetReferences()
        {
            return this._references != null && (this._references.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StartIndex. 
        /// <para>
        /// Character offset start in the answer text.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? StartIndex
        {
            get { return this._startIndex; }
            set { this._startIndex = value; }
        }

        // Check to see if StartIndex property is set
        internal bool IsSetStartIndex()
        {
            return this._startIndex.HasValue; 
        }

    }
}