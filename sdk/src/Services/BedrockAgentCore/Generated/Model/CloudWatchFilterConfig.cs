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
    /// Filter configuration for narrowing down CloudWatch Logs sessions for evaluation.
    /// </summary>
    public partial class CloudWatchFilterConfig
    {
        private List<string> _sessionIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private SessionFilterConfig _timeRange;

        /// <summary>
        /// Gets and sets the property SessionIds. 
        /// <para>
        /// A list of specific session IDs to evaluate. If specified, only these sessions are
        /// included in the evaluation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public List<string> SessionIds
        {
            get { return this._sessionIds; }
            set { this._sessionIds = value; }
        }

        // Check to see if SessionIds property is set
        internal bool IsSetSessionIds()
        {
            return this._sessionIds != null && (this._sessionIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TimeRange. 
        /// <para>
        /// The time range filter for selecting sessions to evaluate.
        /// </para>
        /// </summary>
        public SessionFilterConfig TimeRange
        {
            get { return this._timeRange; }
            set { this._timeRange = value; }
        }

        // Check to see if TimeRange property is set
        internal bool IsSetTimeRange()
        {
            return this._timeRange != null;
        }

    }
}