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

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// Metadata for a specific session in a batch evaluation, including ground truth data
    /// and test scenario identifiers.
    /// </summary>
    public partial class SessionMetadataShape
    {
        /// <summary>
        /// Gets and sets the property GroundTruth. 
        /// <para>
        /// The ground truth data for this session, including expected responses and assertions.
        /// </para>
        /// </summary>
        public GroundTruthSource GroundTruth { get; set; }

        /// <summary>
        /// Checks to see if the GroundTruth property is set.
        /// </summary>
        internal bool IsSetGroundTruth() => this.GroundTruth != null;

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// Additional key-value metadata associated with this session.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Metadata { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Metadata property is set.
        /// </summary>
        internal bool IsSetMetadata() => this.Metadata != null && (this.Metadata.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The unique identifier of the session this metadata applies to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;

        /// <summary>
        /// Gets and sets the property TestScenarioId. 
        /// <para>
        /// An optional test scenario identifier for categorizing and tracking evaluation results.
        /// </para>
        /// </summary>
        public string TestScenarioId { get; set; }

        /// <summary>
        /// Checks to see if the TestScenarioId property is set.
        /// </summary>
        internal bool IsSetTestScenarioId() => this.TestScenarioId != null;
    }
}
