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
    /// Contains filter criteria for listing events.
    /// </summary>
    public partial class FilterInput
    {
        private BranchFilter _branch;
        private List<EventMetadataFilterExpression> _eventMetadata = AWSConfigs.InitializeCollections ? new List<EventMetadataFilterExpression>() : null;

        /// <summary>
        /// Gets and sets the property Branch. 
        /// <para>
        /// The branch filter criteria to apply when listing events.
        /// </para>
        /// </summary>
        public BranchFilter Branch
        {
            get { return this._branch; }
            set { this._branch = value; }
        }

        // Check to see if Branch property is set
        internal bool IsSetBranch()
        {
            return this._branch != null;
        }

        /// <summary>
        /// Gets and sets the property EventMetadata. 
        /// <para>
        /// Event metadata filter criteria to apply when retrieving events.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<EventMetadataFilterExpression> EventMetadata
        {
            get { return this._eventMetadata; }
            set { this._eventMetadata = value; }
        }

        // Check to see if EventMetadata property is set
        internal bool IsSetEventMetadata()
        {
            return this._eventMetadata != null && (this._eventMetadata.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}