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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// The configuration for writing evaluation results to CloudWatch logs with embedded
    /// metric format (EMF) for monitoring.
    /// </summary>
    public partial class CloudWatchOutputConfig
    {
        private string _logGroupName;
        private string _metricsNamespace;
        private ResultDestination _resultDestination;

        /// <summary>
        /// Gets and sets the property LogGroupName. 
        /// <para>
        ///  The name of the CloudWatch log group where evaluation results will be written. An
        /// existing log group is used as-is; otherwise the service creates it, which requires
        /// the evaluation execution role to grant <c>logs:CreateLogGroup</c> on the log group.
        /// Don't specify this value when <c>resultDestination</c> is <c>SOURCE_LOG_GROUP</c>.
        /// The name can't be under the service-reserved <c>/aws/bedrock-agentcore/evaluations/</c>
        /// namespace, apart from this configuration's own service-managed default group. 
        /// </para>
        /// </summary>
        public string LogGroupName
        {
            get { return this._logGroupName; }
            set { this._logGroupName = value; }
        }

        // Check to see if LogGroupName property is set
        internal bool IsSetLogGroupName()
        {
            return this._logGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property MetricsNamespace. 
        /// <para>
        ///  The CloudWatch metrics namespace where evaluation result metrics are published. If
        /// you omit this value, the service publishes metrics to <c>Bedrock-AgentCore/Evaluations</c>.
        /// This value can't begin with <c>AWS/</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string MetricsNamespace
        {
            get { return this._metricsNamespace; }
            set { this._metricsNamespace = value; }
        }

        // Check to see if MetricsNamespace property is set
        internal bool IsSetMetricsNamespace()
        {
            return this._metricsNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property ResultDestination. 
        /// <para>
        ///  The destination where evaluation results are written. Valid values: 
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
        public ResultDestination ResultDestination
        {
            get { return this._resultDestination; }
            set { this._resultDestination = value; }
        }

        // Check to see if ResultDestination property is set
        internal bool IsSetResultDestination()
        {
            return this._resultDestination != null;
        }

    }
}