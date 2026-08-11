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
    /// Contains the configuration for reusing agent traces from an online evaluation configuration
    /// for recommendation analysis. Because online evaluation is a continuous stream, a time
    /// range specifies which evaluated sessions the recommendation includes.
    /// </summary>
    public partial class OnlineEvaluationTraceConfig
    {
        private DateTime? _endTime;
        private string _onlineEvaluationConfigArn;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end time of the time range. Only sessions evaluated before this timestamp are
        /// included.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OnlineEvaluationConfigArn. 
        /// <para>
        /// The ARN of the online evaluation configuration to reuse sessions from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string OnlineEvaluationConfigArn
        {
            get { return this._onlineEvaluationConfigArn; }
            set { this._onlineEvaluationConfigArn = value; }
        }

        // Check to see if OnlineEvaluationConfigArn property is set
        internal bool IsSetOnlineEvaluationConfigArn()
        {
            return this._onlineEvaluationConfigArn != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time of the time range. Only sessions evaluated at or after this timestamp
        /// are included.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}