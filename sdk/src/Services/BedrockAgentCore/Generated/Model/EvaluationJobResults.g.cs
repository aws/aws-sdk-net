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
    /// Aggregated results from a batch evaluation, including session completion counts and
    /// evaluator score summaries.
    /// </summary>
    public partial class EvaluationJobResults
    {
        /// <summary>
        /// Gets and sets the property EvaluatorSummaries. 
        /// <para>
        /// A list of per-evaluator summary statistics.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EvaluatorSummary> EvaluatorSummaries { get; set; } = AWSConfigs.InitializeCollections ? new List<EvaluatorSummary>() : null;

        /// <summary>
        /// Checks to see if the EvaluatorSummaries property is set.
        /// </summary>
        internal bool IsSetEvaluatorSummaries() => this.EvaluatorSummaries != null && (this.EvaluatorSummaries.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NumberOfSessionsCompleted. 
        /// <para>
        /// The number of sessions that have been successfully evaluated.
        /// </para>
        /// </summary>
        public int? NumberOfSessionsCompleted { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfSessionsCompleted property is set.
        /// </summary>
        internal bool IsSetNumberOfSessionsCompleted() => this.NumberOfSessionsCompleted.HasValue;

        /// <summary>
        /// Gets and sets the property NumberOfSessionsFailed. 
        /// <para>
        /// The number of sessions that failed evaluation.
        /// </para>
        /// </summary>
        public int? NumberOfSessionsFailed { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfSessionsFailed property is set.
        /// </summary>
        internal bool IsSetNumberOfSessionsFailed() => this.NumberOfSessionsFailed.HasValue;

        /// <summary>
        /// Gets and sets the property NumberOfSessionsIgnored. 
        /// <para>
        /// The number of sessions that were ignored during evaluation.
        /// </para>
        /// </summary>
        public int? NumberOfSessionsIgnored { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfSessionsIgnored property is set.
        /// </summary>
        internal bool IsSetNumberOfSessionsIgnored() => this.NumberOfSessionsIgnored.HasValue;

        /// <summary>
        /// Gets and sets the property NumberOfSessionsInProgress. 
        /// <para>
        /// The number of sessions currently being evaluated.
        /// </para>
        /// </summary>
        public int? NumberOfSessionsInProgress { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfSessionsInProgress property is set.
        /// </summary>
        internal bool IsSetNumberOfSessionsInProgress() => this.NumberOfSessionsInProgress.HasValue;

        /// <summary>
        /// Gets and sets the property TotalNumberOfSessions. 
        /// <para>
        /// The total number of sessions included in the batch evaluation.
        /// </para>
        /// </summary>
        public int? TotalNumberOfSessions { get; set; }

        /// <summary>
        /// Checks to see if the TotalNumberOfSessions property is set.
        /// </summary>
        internal bool IsSetTotalNumberOfSessions() => this.TotalNumberOfSessions.HasValue;
    }
}
