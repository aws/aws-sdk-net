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
    /// Summary statistics for a single evaluator within a batch evaluation.
    /// </summary>
    public partial class EvaluatorSummary
    {
        private string _evaluatorId;
        private EvaluatorStatistics _statistics;
        private int? _totalEvaluated;
        private int? _totalFailed;

        /// <summary>
        /// Gets and sets the property EvaluatorId. 
        /// <para>
        /// The unique identifier of the evaluator.
        /// </para>
        /// </summary>
        public string EvaluatorId
        {
            get { return this._evaluatorId; }
            set { this._evaluatorId = value; }
        }

        // Check to see if EvaluatorId property is set
        internal bool IsSetEvaluatorId()
        {
            return this._evaluatorId != null;
        }

        /// <summary>
        /// Gets and sets the property Statistics. 
        /// <para>
        /// The aggregated statistics for this evaluator.
        /// </para>
        /// </summary>
        public EvaluatorStatistics Statistics
        {
            get { return this._statistics; }
            set { this._statistics = value; }
        }

        // Check to see if Statistics property is set
        internal bool IsSetStatistics()
        {
            return this._statistics != null;
        }

        /// <summary>
        /// Gets and sets the property TotalEvaluated. 
        /// <para>
        /// The total number of sessions evaluated by this evaluator.
        /// </para>
        /// </summary>
        public int? TotalEvaluated
        {
            get { return this._totalEvaluated; }
            set { this._totalEvaluated = value; }
        }

        // Check to see if TotalEvaluated property is set
        internal bool IsSetTotalEvaluated()
        {
            return this._totalEvaluated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalFailed. 
        /// <para>
        /// The total number of sessions that failed evaluation by this evaluator.
        /// </para>
        /// </summary>
        public int? TotalFailed
        {
            get { return this._totalFailed; }
            set { this._totalFailed = value; }
        }

        // Check to see if TotalFailed property is set
        internal bool IsSetTotalFailed()
        {
            return this._totalFailed.HasValue; 
        }

    }
}