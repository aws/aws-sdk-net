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
    /// Where a dataset generation reads sessions from. Specify exactly one source.
    /// </summary>
    public partial class TraceSourceConfig
    {
        /// <summary>
        /// Gets and sets the property BatchEvaluation. 
        /// <para>
        /// Reads sessions, with their evaluation results, from a batch evaluation.
        /// </para>
        /// </summary>
        public BatchEvaluationSourceConfig BatchEvaluation { get; set; }

        /// <summary>
        /// Checks to see if the BatchEvaluation property is set.
        /// </summary>
        internal bool IsSetBatchEvaluation() => this.BatchEvaluation != null;

        /// <summary>
        /// Gets and sets the property CloudWatchLogs. 
        /// <para>
        /// Reads sessions from CloudWatch Logs log groups.
        /// </para>
        /// </summary>
        public CloudWatchLogsSourceConfig CloudWatchLogs { get; set; }

        /// <summary>
        /// Checks to see if the CloudWatchLogs property is set.
        /// </summary>
        internal bool IsSetCloudWatchLogs() => this.CloudWatchLogs != null;

        /// <summary>
        /// Gets and sets the property OnlineEvaluation. 
        /// <para>
        /// Reads sessions, with their evaluation results, from an online evaluation configuration.
        /// </para>
        /// </summary>
        public OnlineEvaluationSourceConfig OnlineEvaluation { get; set; }

        /// <summary>
        /// Checks to see if the OnlineEvaluation property is set.
        /// </summary>
        internal bool IsSetOnlineEvaluation() => this.OnlineEvaluation != null;
    }
}
