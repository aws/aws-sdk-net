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

namespace Amazon.ChimeSDKVoice.Model
{
    /// <summary>
    /// A representation of an asynchronous request to perform voice tone analysis on a Voice
    /// Connector call.
    /// </summary>
    public partial class VoiceToneAnalysisTask
    {
        /// <summary>
        /// Gets and sets the property CallDetails. 
        /// <para>
        /// The call details of a voice tone analysis task.
        /// </para>
        /// </summary>
        public CallDetails CallDetails { get; set; }

        /// <summary>
        /// Checks to see if the CallDetails property is set.
        /// </summary>
        internal bool IsSetCallDetails() => this.CallDetails != null;

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The time at which a voice tone analysis task was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTimestamp property is set.
        /// </summary>
        internal bool IsSetCreatedTimestamp() => this.CreatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property StartedTimestamp. 
        /// <para>
        /// The time at which a voice tone analysis task started.
        /// </para>
        /// </summary>
        public DateTime? StartedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the StartedTimestamp property is set.
        /// </summary>
        internal bool IsSetStartedTimestamp() => this.StartedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The status of a voice tone analysis task.
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property UpdatedTimestamp. 
        /// <para>
        /// The time at which a voice tone analysis task was updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedTimestamp property is set.
        /// </summary>
        internal bool IsSetUpdatedTimestamp() => this.UpdatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property VoiceToneAnalysisTaskId. 
        /// <para>
        /// The ID of the voice tone analysis task.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string VoiceToneAnalysisTaskId { get; set; }

        /// <summary>
        /// Checks to see if the VoiceToneAnalysisTaskId property is set.
        /// </summary>
        internal bool IsSetVoiceToneAnalysisTaskId() => this.VoiceToneAnalysisTaskId != null;

        /// <summary>
        /// Gets and sets the property VoiceToneAnalysisTaskStatus. 
        /// <para>
        /// The status of a voice tone analysis task, <c>IN_QUEUE</c>, <c>IN_PROGRESS</c>, <c>PARTIAL_SUCCESS</c>,
        /// <c>SUCCEEDED</c>, <c>FAILED</c>, or <c>STOPPED</c>.
        /// </para>
        /// </summary>
        public string VoiceToneAnalysisTaskStatus { get; set; }

        /// <summary>
        /// Checks to see if the VoiceToneAnalysisTaskStatus property is set.
        /// </summary>
        internal bool IsSetVoiceToneAnalysisTaskStatus() => this.VoiceToneAnalysisTaskStatus != null;
    }
}
