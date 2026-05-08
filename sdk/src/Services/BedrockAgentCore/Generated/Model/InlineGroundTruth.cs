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
    /// Inline ground truth data containing assertions, expected trajectories, and per-turn
    /// expected responses.
    /// </summary>
    public partial class InlineGroundTruth
    {
        private List<EvaluationContent> _assertions = AWSConfigs.InitializeCollections ? new List<EvaluationContent>() : null;
        private EvaluationExpectedTrajectory _expectedTrajectory;
        private List<GroundTruthTurn> _turns = AWSConfigs.InitializeCollections ? new List<GroundTruthTurn>() : null;

        /// <summary>
        /// Gets and sets the property Assertions. 
        /// <para>
        /// assertions for evaluation, reuses common model EvaluationContentList
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<EvaluationContent> Assertions
        {
            get { return this._assertions; }
            set { this._assertions = value; }
        }

        // Check to see if Assertions property is set
        internal bool IsSetAssertions()
        {
            return this._assertions != null && (this._assertions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ExpectedTrajectory. 
        /// <para>
        /// expectedTrajectory for evaluation, reuses common model EvaluationExpectedTrajectory
        /// </para>
        /// </summary>
        public EvaluationExpectedTrajectory ExpectedTrajectory
        {
            get { return this._expectedTrajectory; }
            set { this._expectedTrajectory = value; }
        }

        // Check to see if ExpectedTrajectory property is set
        internal bool IsSetExpectedTrajectory()
        {
            return this._expectedTrajectory != null;
        }

        /// <summary>
        /// Gets and sets the property Turns. 
        /// <para>
        /// A list of per-turn ground truth data, each containing an input prompt and expected
        /// response.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<GroundTruthTurn> Turns
        {
            get { return this._turns; }
            set { this._turns = value; }
        }

        // Check to see if Turns property is set
        internal bool IsSetTurns()
        {
            return this._turns != null && (this._turns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}