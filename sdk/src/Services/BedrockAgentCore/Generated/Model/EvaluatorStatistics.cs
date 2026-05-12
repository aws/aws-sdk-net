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
    /// Aggregated statistics for an evaluator.
    /// </summary>
    public partial class EvaluatorStatistics
    {
        private double? _averageScore;

        /// <summary>
        /// Gets and sets the property AverageScore. 
        /// <para>
        /// The average score across all evaluated sessions for this evaluator.
        /// </para>
        /// </summary>
        public double? AverageScore
        {
            get { return this._averageScore; }
            set { this._averageScore = value; }
        }

        // Check to see if AverageScore property is set
        internal bool IsSetAverageScore()
        {
            return this._averageScore.HasValue; 
        }

    }
}