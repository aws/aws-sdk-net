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
    /// Summary statistics for a single evaluator within a batch evaluation.
    /// </summary>
    public partial class EvaluatorSummary
    {
        /// <summary>
        /// Gets and sets the property EvaluatorId. 
        /// <para>
        /// The unique identifier of the evaluator.
        /// </para>
        /// </summary>
        public string EvaluatorId { get; set; }

        /// <summary>
        /// Checks to see if the EvaluatorId property is set.
        /// </summary>
        internal bool IsSetEvaluatorId() => this.EvaluatorId != null;

        /// <summary>
        /// Gets and sets the property Statistics. 
        /// <para>
        /// The aggregated statistics for this evaluator.
        /// </para>
        /// </summary>
        public EvaluatorStatistics Statistics { get; set; }

        /// <summary>
        /// Checks to see if the Statistics property is set.
        /// </summary>
        internal bool IsSetStatistics() => this.Statistics != null;

        /// <summary>
        /// Gets and sets the property TotalEvaluated. 
        /// <para>
        /// The total number of sessions evaluated by this evaluator.
        /// </para>
        /// </summary>
        public int? TotalEvaluated { get; set; }

        /// <summary>
        /// Checks to see if the TotalEvaluated property is set.
        /// </summary>
        internal bool IsSetTotalEvaluated() => this.TotalEvaluated.HasValue;

        /// <summary>
        /// Gets and sets the property TotalFailed. 
        /// <para>
        /// The total number of sessions that failed evaluation by this evaluator.
        /// </para>
        /// </summary>
        public int? TotalFailed { get; set; }

        /// <summary>
        /// Checks to see if the TotalFailed property is set.
        /// </summary>
        internal bool IsSetTotalFailed() => this.TotalFailed.HasValue;
    }
}
