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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the StartContactRecording operation.
    /// This API starts recording the contact when the agent joins the call. StartContactRecording
    /// is a one-time action. For example, if you use StopContactRecording to stop recording
    /// an ongoing call, you can't use StartContactRecording to restart it. For scenarios
    /// where the recording has started and you want to suspend and resume it, such as when
    /// collecting sensitive information (for example, a credit card number), use SuspendContactRecording
    /// and ResumeContactRecording.
    /// 
    ///  
    /// <para>
    /// You can use this API to override the recording behavior configured in the <a href="https://docs.aws.amazon.com/connect/latest/adminguide/set-recording-behavior.html">Set
    /// recording behavior</a> block.
    /// </para>
    ///  
    /// <para>
    /// Only voice recordings are supported at this time.
    /// </para>
    /// </summary>
    public partial class StartContactRecordingRequest : AmazonConnectRequest
    {
        private string _contactId;
        private string _initialContactId;
        private string _instanceId;
        private VoiceRecordingConfiguration _voiceRecordingConfiguration;

        /// <summary>
        /// Gets and sets the property ContactId. 
        /// <para>
        /// The identifier of the contact.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ContactId
        {
            get { return this._contactId; }
            set { this._contactId = value; }
        }

        // Check to see if ContactId property is set
        internal bool IsSetContactId()
        {
            return this._contactId != null;
        }

        /// <summary>
        /// Gets and sets the property InitialContactId. 
        /// <para>
        /// The identifier of the contact. This is the identifier of the contact associated with
        /// the first interaction with the contact center.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string InitialContactId
        {
            get { return this._initialContactId; }
            set { this._initialContactId = value; }
        }

        // Check to see if InitialContactId property is set
        internal bool IsSetInitialContactId()
        {
            return this._initialContactId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property VoiceRecordingConfiguration. 
        /// <para>
        /// Who is being recorded.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VoiceRecordingConfiguration VoiceRecordingConfiguration
        {
            get { return this._voiceRecordingConfiguration; }
            set { this._voiceRecordingConfiguration = value; }
        }

        // Check to see if VoiceRecordingConfiguration property is set
        internal bool IsSetVoiceRecordingConfiguration()
        {
            return this._voiceRecordingConfiguration != null;
        }

    }
}