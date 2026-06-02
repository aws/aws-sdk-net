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
    /// Ground truth data for a single conversation turn.
    /// </summary>
    public partial class GroundTruthTurn
    {
        private EvaluationContent _expectedResponse;
        private GroundTruthTurnInput _input;

        /// <summary>
        /// Gets and sets the property ExpectedResponse. 
        /// <para>
        /// The expected response for this conversation turn.
        /// </para>
        /// </summary>
        public EvaluationContent ExpectedResponse
        {
            get { return this._expectedResponse; }
            set { this._expectedResponse = value; }
        }

        // Check to see if ExpectedResponse property is set
        internal bool IsSetExpectedResponse()
        {
            return this._expectedResponse != null;
        }

        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        /// The input for this conversation turn.
        /// </para>
        /// </summary>
        public GroundTruthTurnInput Input
        {
            get { return this._input; }
            set { this._input = value; }
        }

        // Check to see if Input property is set
        internal bool IsSetInput()
        {
            return this._input != null;
        }

    }
}