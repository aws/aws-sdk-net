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
    /// CloudWatch Logs destination for batch evaluation results.
    /// </summary>
    public partial class CloudWatchOutputConfig
    {
        /// <summary>
        /// Gets and sets the property LogGroupName. 
        /// <para>
        /// The name of the CloudWatch log group where evaluation results will be written. This
        /// value doesn't apply when <c>resultDestination</c> is <c>SOURCE_LOG_GROUP</c>, because
        /// results are written back to the trace source log group. The name can't be under the
        /// service-reserved <c>/aws/bedrock-agentcore/evaluations/</c> namespace, apart from
        /// the service-managed default group.
        /// </para>
        /// </summary>
        public string LogGroupName { get; set; }

        /// <summary>
        /// Checks to see if the LogGroupName property is set.
        /// </summary>
        internal bool IsSetLogGroupName() => this.LogGroupName != null;

        /// <summary>
        /// Gets and sets the property LogStreamName. 
        /// <para>
        /// The name of the CloudWatch log stream where evaluation results will be written.
        /// </para>
        /// </summary>
        public string LogStreamName { get; set; }

        /// <summary>
        /// Checks to see if the LogStreamName property is set.
        /// </summary>
        internal bool IsSetLogStreamName() => this.LogStreamName != null;

        /// <summary>
        /// Gets and sets the property MetricsNamespace. 
        /// <para>
        /// The CloudWatch metrics namespace where evaluation result metrics are published. If
        /// you omit this value, the service publishes metrics to <c>Bedrock-AgentCore/Evaluations</c>.
        /// This value can't begin with <c>AWS/</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string MetricsNamespace { get; set; }

        /// <summary>
        /// Checks to see if the MetricsNamespace property is set.
        /// </summary>
        internal bool IsSetMetricsNamespace() => this.MetricsNamespace != null;

        /// <summary>
        /// Gets and sets the property ResultDestination. 
        /// <para>
        /// The destination where evaluation results are written. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DEDICATED_LOG_GROUP</c> (default) – Writes results to a dedicated result log group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SOURCE_LOG_GROUP</c> – Writes results back to the log group that the agent traces
        /// were read from. If you use this value, don't specify <c>logGroupName</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ResultDestination ResultDestination { get; set; }

        /// <summary>
        /// Checks to see if the ResultDestination property is set.
        /// </summary>
        internal bool IsSetResultDestination() => this.ResultDestination != null;
    }
}
