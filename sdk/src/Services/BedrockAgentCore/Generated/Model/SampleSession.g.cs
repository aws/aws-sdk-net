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
    /// A session affected by an insight or root cause. Use the session ID to find the per-session
    /// evaluation results in CloudWatch Logs.
    /// </summary>
    public partial class SampleSession
    {
        /// <summary>
        /// Gets and sets the property Findings. 
        /// <para>
        /// The failures found in the session that belong to the insight or root cause, up to
        /// 10.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<SessionFinding> Findings { get; set; } = AWSConfigs.InitializeCollections ? new List<SessionFinding>() : null;

        /// <summary>
        /// Checks to see if the Findings property is set.
        /// </summary>
        internal bool IsSetFindings() => this.Findings != null && (this.Findings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LastSeenAt. 
        /// <para>
        /// The latest timestamp observed for the session in the batch evaluation input.
        /// </para>
        /// </summary>
        public DateTime? LastSeenAt { get; set; }

        /// <summary>
        /// Checks to see if the LastSeenAt property is set.
        /// </summary>
        internal bool IsSetLastSeenAt() => this.LastSeenAt.HasValue;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The unique identifier of the session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;
    }
}
