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
    /// Configuration for the data source used in evaluation.
    /// </summary>
    public partial class DataSourceConfig
    {
        /// <summary>
        /// Gets and sets the property CloudWatchLogs. 
        /// <para>
        /// Configuration for pulling agent session traces from CloudWatch Logs.
        /// </para>
        /// </summary>
        public CloudWatchLogsSource CloudWatchLogs { get; set; }

        /// <summary>
        /// Checks to see if the CloudWatchLogs property is set.
        /// </summary>
        internal bool IsSetCloudWatchLogs() => this.CloudWatchLogs != null;

        /// <summary>
        /// Gets and sets the property OnlineEvaluationConfigSource. Reference an existing OnlineEvaluationConfig
        /// as session source
        /// </summary>
        public OnlineEvaluationConfigSource OnlineEvaluationConfigSource { get; set; }

        /// <summary>
        /// Checks to see if the OnlineEvaluationConfigSource property is set.
        /// </summary>
        internal bool IsSetOnlineEvaluationConfigSource() => this.OnlineEvaluationConfigSource != null;
    }
}
