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
 * Do not modify this file. This file is generated from the chime-sdk-voice-2022-08-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ChimeSDKVoice.Model
{
    /// <summary>
    /// A representation of an asynchronous request to perform voice tone analysis on a Voice
    /// Connector call.
    /// </summary>
    public partial class VoiceToneAnalysisTask
    {
        private CallDetails _callDetails;
        private DateTime? _createdTimestamp;
        private DateTime? _startedTimestamp;
        private string _statusMessage;
        private DateTime? _updatedTimestamp;
        private string _voiceToneAnalysisTaskId;
        private string _voiceToneAnalysisTaskStatus;

        /// <summary>
        /// Gets and sets the property CallDetails. 
        /// <para>
        /// The call details of a voice tone analysis task.
        /// </para>
        /// </summary>
        public CallDetails CallDetails
        {
            get { return this._callDetails; }
            set { this._callDetails = value; }
        }

        // Check to see if CallDetails property is set
        internal bool IsSetCallDetails()
        {
            return this._callDetails != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The time at which a voice tone analysis task was created.
        /// </para>
        /// </summary>
        public DateTime CreatedTimestamp
        {
            get { return this._createdTimestamp.GetValueOrDefault(); }
            set { this._createdTimestamp = value; }
        }

        // Check to see if CreatedTimestamp property is set
        internal bool IsSetCreatedTimestamp()
        {
            return this._createdTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartedTimestamp. 
        /// <para>
        /// The time at which a voice tone analysis task started.
        /// </para>
        /// </summary>
        public DateTime StartedTimestamp
        {
            get { return this._startedTimestamp.GetValueOrDefault(); }
            set { this._startedTimestamp = value; }
        }

        // Check to see if StartedTimestamp property is set
        internal bool IsSetStartedTimestamp()
        {
            return this._startedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The status of a voice tone analysis task.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedTimestamp. 
        /// <para>
        /// The time at which a voice tone analysis task was updated.
        /// </para>
        /// </summary>
        public DateTime UpdatedTimestamp
        {
            get { return this._updatedTimestamp.GetValueOrDefault(); }
            set { this._updatedTimestamp = value; }
        }

        // Check to see if UpdatedTimestamp property is set
        internal bool IsSetUpdatedTimestamp()
        {
            return this._updatedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VoiceToneAnalysisTaskId. 
        /// <para>
        /// The ID of the voice tone analysis task.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string VoiceToneAnalysisTaskId
        {
            get { return this._voiceToneAnalysisTaskId; }
            set { this._voiceToneAnalysisTaskId = value; }
        }

        // Check to see if VoiceToneAnalysisTaskId property is set
        internal bool IsSetVoiceToneAnalysisTaskId()
        {
            return this._voiceToneAnalysisTaskId != null;
        }

        /// <summary>
        /// Gets and sets the property VoiceToneAnalysisTaskStatus. 
        /// <para>
        /// The status of a voice tone analysis task, <code>IN_QUEUE</code>, <code>IN_PROGRESS</code>,
        /// <code>PARTIAL_SUCCESS</code>, <code>SUCCEEDED</code>, <code>FAILED</code>, or <code>STOPPED</code>.
        /// </para>
        /// </summary>
        public string VoiceToneAnalysisTaskStatus
        {
            get { return this._voiceToneAnalysisTaskStatus; }
            set { this._voiceToneAnalysisTaskStatus = value; }
        }

        // Check to see if VoiceToneAnalysisTaskStatus property is set
        internal bool IsSetVoiceToneAnalysisTaskStatus()
        {
            return this._voiceToneAnalysisTaskStatus != null;
        }

    }
}