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
    /// The configuration specifying where to read agent traces from for recommendation analysis.
    /// </summary>
    public partial class AgentTracesConfig
    {
        /// <summary>
        /// Gets and sets the property BatchEvaluation. 
        /// <para>
        /// Use a completed batch evaluation as the source of agent traces.
        /// </para>
        /// </summary>
        public BatchEvaluationTraceConfig BatchEvaluation { get; set; }

        /// <summary>
        /// Checks to see if the BatchEvaluation property is set.
        /// </summary>
        internal bool IsSetBatchEvaluation() => this.BatchEvaluation != null;

        /// <summary>
        /// Gets and sets the property CloudwatchLogs. 
        /// <para>
        /// Agent traces read from CloudWatch Logs.
        /// </para>
        /// </summary>
        public CloudWatchLogsTraceConfig CloudwatchLogs { get; set; }

        /// <summary>
        /// Checks to see if the CloudwatchLogs property is set.
        /// </summary>
        internal bool IsSetCloudwatchLogs() => this.CloudwatchLogs != null;

        /// <summary>
        /// Gets and sets the property OnlineEvaluation. 
        /// <para>
        /// Agent traces from an online evaluation configuration over a specified time range.
        /// </para>
        /// </summary>
        public OnlineEvaluationTraceConfig OnlineEvaluation { get; set; }

        /// <summary>
        /// Checks to see if the OnlineEvaluation property is set.
        /// </summary>
        internal bool IsSetOnlineEvaluation() => this.OnlineEvaluation != null;

        /// <summary>
        /// Gets and sets the property SessionSpans. 
        /// <para>
        /// Agent traces provided as inline session spans in OpenTelemetry format.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 20000)]
        public List<Amazon.Runtime.Documents.Document> SessionSpans { get; set; } = AWSConfigs.InitializeCollections ? new List<Amazon.Runtime.Documents.Document>() : null;

        /// <summary>
        /// Checks to see if the SessionSpans property is set.
        /// </summary>
        internal bool IsSetSessionSpans() => this.SessionSpans != null && (this.SessionSpans.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
