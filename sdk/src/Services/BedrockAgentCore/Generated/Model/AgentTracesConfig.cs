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
    /// The configuration specifying where to read agent traces from for recommendation analysis.
    /// </summary>
    public partial class AgentTracesConfig
    {
        private BatchEvaluationTraceConfig _batchEvaluation;
        private CloudWatchLogsTraceConfig _cloudwatchLogs;
        private List<Amazon.Runtime.Documents.Document> _sessionSpans = AWSConfigs.InitializeCollections ? new List<Amazon.Runtime.Documents.Document>() : null;

        /// <summary>
        /// Gets and sets the property BatchEvaluation. 
        /// <para>
        /// Use a completed batch evaluation as the source of agent traces.
        /// </para>
        /// </summary>
        public BatchEvaluationTraceConfig BatchEvaluation
        {
            get { return this._batchEvaluation; }
            set { this._batchEvaluation = value; }
        }

        // Check to see if BatchEvaluation property is set
        internal bool IsSetBatchEvaluation()
        {
            return this._batchEvaluation != null;
        }

        /// <summary>
        /// Gets and sets the property CloudwatchLogs. 
        /// <para>
        /// Agent traces read from CloudWatch Logs.
        /// </para>
        /// </summary>
        public CloudWatchLogsTraceConfig CloudwatchLogs
        {
            get { return this._cloudwatchLogs; }
            set { this._cloudwatchLogs = value; }
        }

        // Check to see if CloudwatchLogs property is set
        internal bool IsSetCloudwatchLogs()
        {
            return this._cloudwatchLogs != null;
        }

        /// <summary>
        /// Gets and sets the property SessionSpans. 
        /// <para>
        /// Agent traces provided as inline session spans in OpenTelemetry format.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=1000)]
        public List<Amazon.Runtime.Documents.Document> SessionSpans
        {
            get { return this._sessionSpans; }
            set { this._sessionSpans = value; }
        }

        // Check to see if SessionSpans property is set
        internal bool IsSetSessionSpans()
        {
            return this._sessionSpans != null && (this._sessionSpans.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}