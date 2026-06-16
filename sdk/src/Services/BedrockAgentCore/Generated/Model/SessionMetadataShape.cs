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
    /// Metadata for a specific session in a batch evaluation, including ground truth data
    /// and test scenario identifiers.
    /// </summary>
    public partial class SessionMetadataShape
    {
        private GroundTruthSource _groundTruth;
        private Dictionary<string, string> _metadata = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _sessionId;
        private string _testScenarioId;

        /// <summary>
        /// Gets and sets the property GroundTruth. 
        /// <para>
        /// The ground truth data for this session, including expected responses and assertions.
        /// </para>
        /// </summary>
        public GroundTruthSource GroundTruth
        {
            get { return this._groundTruth; }
            set { this._groundTruth = value; }
        }

        // Check to see if GroundTruth property is set
        internal bool IsSetGroundTruth()
        {
            return this._groundTruth != null;
        }

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// Additional key-value metadata associated with this session.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return this._metadata != null && (this._metadata.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The unique identifier of the session this metadata applies to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SessionId
        {
            get { return this._sessionId; }
            set { this._sessionId = value; }
        }

        // Check to see if SessionId property is set
        internal bool IsSetSessionId()
        {
            return this._sessionId != null;
        }

        /// <summary>
        /// Gets and sets the property TestScenarioId. 
        /// <para>
        /// An optional test scenario identifier for categorizing and tracking evaluation results.
        /// </para>
        /// </summary>
        public string TestScenarioId
        {
            get { return this._testScenarioId; }
            set { this._testScenarioId = value; }
        }

        // Check to see if TestScenarioId property is set
        internal bool IsSetTestScenarioId()
        {
            return this._testScenarioId != null;
        }

    }
}