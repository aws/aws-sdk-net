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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ChimeSDKVoice.Model
{
    /// <summary>
    /// A representation of an asynchronous request to perform speaker search analysis on
    /// a Voice Connector call.
    /// </summary>
    public partial class SpeakerSearchTask
    {
        private CallDetails _callDetails;
        private DateTime? _createdTimestamp;
        private SpeakerSearchDetails _speakerSearchDetails;
        private string _speakerSearchTaskId;
        private string _speakerSearchTaskStatus;
        private DateTime? _startedTimestamp;
        private string _statusMessage;
        private DateTime? _updatedTimestamp;

        /// <summary>
        /// Gets and sets the property CallDetails. 
        /// <para>
        /// The call details of a speaker search task.
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
        /// The time at which a speaker search task was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp
        {
            get { return this._createdTimestamp; }
            set { this._createdTimestamp = value; }
        }

        // Check to see if CreatedTimestamp property is set
        internal bool IsSetCreatedTimestamp()
        {
            return this._createdTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SpeakerSearchDetails. 
        /// <para>
        /// The details of a speaker search task.
        /// </para>
        /// </summary>
        public SpeakerSearchDetails SpeakerSearchDetails
        {
            get { return this._speakerSearchDetails; }
            set { this._speakerSearchDetails = value; }
        }

        // Check to see if SpeakerSearchDetails property is set
        internal bool IsSetSpeakerSearchDetails()
        {
            return this._speakerSearchDetails != null;
        }

        /// <summary>
        /// Gets and sets the property SpeakerSearchTaskId. 
        /// <para>
        /// The speaker search task ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string SpeakerSearchTaskId
        {
            get { return this._speakerSearchTaskId; }
            set { this._speakerSearchTaskId = value; }
        }

        // Check to see if SpeakerSearchTaskId property is set
        internal bool IsSetSpeakerSearchTaskId()
        {
            return this._speakerSearchTaskId != null;
        }

        /// <summary>
        /// Gets and sets the property SpeakerSearchTaskStatus. 
        /// <para>
        /// The status of the speaker search task, <c>IN_QUEUE</c>, <c>IN_PROGRESS</c>, <c>PARTIAL_SUCCESS</c>,
        /// <c>SUCCEEDED</c>, <c>FAILED</c>, or <c>STOPPED</c>.
        /// </para>
        /// </summary>
        public string SpeakerSearchTaskStatus
        {
            get { return this._speakerSearchTaskStatus; }
            set { this._speakerSearchTaskStatus = value; }
        }

        // Check to see if SpeakerSearchTaskStatus property is set
        internal bool IsSetSpeakerSearchTaskStatus()
        {
            return this._speakerSearchTaskStatus != null;
        }

        /// <summary>
        /// Gets and sets the property StartedTimestamp. 
        /// <para>
        /// The time at which the speaker search task began.
        /// </para>
        /// </summary>
        public DateTime? StartedTimestamp
        {
            get { return this._startedTimestamp; }
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
        /// A detailed message about the status of a speaker search.
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
        /// The time at which a speaker search task was updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedTimestamp
        {
            get { return this._updatedTimestamp; }
            set { this._updatedTimestamp = value; }
        }

        // Check to see if UpdatedTimestamp property is set
        internal bool IsSetUpdatedTimestamp()
        {
            return this._updatedTimestamp.HasValue; 
        }

    }
}