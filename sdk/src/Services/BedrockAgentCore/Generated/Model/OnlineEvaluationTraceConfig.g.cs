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
    /// Contains the configuration for reusing agent traces from an online evaluation configuration
    /// for recommendation analysis. Because online evaluation is a continuous stream, a time
    /// range specifies which evaluated sessions the recommendation includes.
    /// </summary>
    public partial class OnlineEvaluationTraceConfig
    {
        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end time of the time range. Only sessions evaluated before this timestamp are
        /// included.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property OnlineEvaluationConfigArn. 
        /// <para>
        /// The ARN of the online evaluation configuration to reuse sessions from.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string OnlineEvaluationConfigArn { get; set; }

        /// <summary>
        /// Checks to see if the OnlineEvaluationConfigArn property is set.
        /// </summary>
        internal bool IsSetOnlineEvaluationConfigArn() => this.OnlineEvaluationConfigArn != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time of the time range. Only sessions evaluated at or after this timestamp
        /// are included.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;
    }
}
