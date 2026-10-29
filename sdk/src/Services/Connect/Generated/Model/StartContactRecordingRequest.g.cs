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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the StartContactRecording operation. Starts recording
    /// the contact: <ul> <li> <para> If the API is called <i>before</i> the agent joins the
    /// call, recording starts when the agent joins the call. </para> </li> <li> <para> If
    /// the API is called <i>after</i> the agent joins the call, recording starts at the time
    /// of the API call. </para> </li> </ul> <para> StartContactRecording is a one-time action.
    /// For example, if you use StopContactRecording to stop recording an ongoing call, you
    /// can't use StartContactRecording to restart it. For scenarios where the recording has
    /// started and you want to suspend and resume it, such as when collecting sensitive information
    /// (for example, a credit card number), use SuspendContactRecording and ResumeContactRecording.
    /// </para> <para> You can use this API to override the recording behavior configured
    /// in the <a href="https://docs.aws.amazon.com/connect/latest/adminguide/set-recording-behavior.html">Set
    /// recording behavior</a> block. </para> <para> Only voice recordings are supported at
    /// this time. </para>
    /// </summary>
    public partial class StartContactRecordingRequest : AmazonConnectRequest
    {
        /// <summary>
        /// Gets and sets the property ContactId. 
        /// <para>
        /// The identifier of the contact.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ContactId { get; set; }

        /// <summary>
        /// Checks to see if the ContactId property is set.
        /// </summary>
        internal bool IsSetContactId() => this.ContactId != null;

        /// <summary>
        /// Gets and sets the property InitialContactId. 
        /// <para>
        /// The identifier of the contact. This is the identifier of the contact associated with
        /// the first interaction with the contact center.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string InitialContactId { get; set; }

        /// <summary>
        /// Checks to see if the InitialContactId property is set.
        /// </summary>
        internal bool IsSetInitialContactId() => this.InitialContactId != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Connect Customer instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property VoiceRecordingConfiguration. 
        /// <para>
        /// The person being recorded.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public VoiceRecordingConfiguration VoiceRecordingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the VoiceRecordingConfiguration property is set.
        /// </summary>
        internal bool IsSetVoiceRecordingConfiguration() => this.VoiceRecordingConfiguration != null;
    }
}
