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
    /// Filter configuration for narrowing down CloudWatch Logs sessions for evaluation.
    /// </summary>
    public partial class CloudWatchFilterConfig
    {
        /// <summary>
        /// Gets and sets the property SessionIds. 
        /// <para>
        /// A list of specific session IDs to evaluate. If specified, only these sessions are
        /// included in the evaluation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 500)]
        public List<string> SessionIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SessionIds property is set.
        /// </summary>
        internal bool IsSetSessionIds() => this.SessionIds != null && (this.SessionIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SessionTraceIds. 
        /// <para>
        /// A list of session and trace ID pairs that restrict evaluation to specific traces within
        /// a session. If specified, only the listed traces are evaluated instead of the entire
        /// session.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public List<SessionTraceIds> SessionTraceIds { get; set; } = AWSConfigs.InitializeCollections ? new List<SessionTraceIds>() : null;

        /// <summary>
        /// Checks to see if the SessionTraceIds property is set.
        /// </summary>
        internal bool IsSetSessionTraceIds() => this.SessionTraceIds != null && (this.SessionTraceIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TimeRange. 
        /// <para>
        /// The time range filter for selecting sessions to evaluate.
        /// </para>
        /// </summary>
        public SessionFilterConfig TimeRange { get; set; }

        /// <summary>
        /// Checks to see if the TimeRange property is set.
        /// </summary>
        internal bool IsSetTimeRange() => this.TimeRange != null;
    }
}
