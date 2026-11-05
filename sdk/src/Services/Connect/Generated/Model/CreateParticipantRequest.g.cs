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
    /// Container for the parameters to the CreateParticipant operation. Adds a new participant
    /// into an on-going chat contact or webRTC call. For more information, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/chat-customize-flow.html">Customize
    /// chat flow experiences by integrating custom participants</a> or <a href="https://docs.aws.amazon.com/connect/latest/adminguide/enable-multiuser-inapp.html">Enable
    /// multi-user web, in-app, and video calling</a>.
    /// </summary>
    public partial class CreateParticipantRequest : AmazonConnectRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If not provided, the Amazon Web Services SDK populates this field. For
        /// more information about idempotency, see <a href="https://aws.amazon.com/builders-library/making-retries-safe-with-idempotent-APIs/">Making
        /// retries safe with idempotent APIs</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property ContactId. 
        /// <para>
        /// The identifier of the contact in this instance of Connect Customer. Supports contacts
        /// in the CHAT channel and VOICE (WebRTC) channels. For WebRTC calls, this should be
        /// the initial contact ID that was generated when the contact was first created (from
        /// the StartWebRTCContact API) in the VOICE channel
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ContactId { get; set; }

        /// <summary>
        /// Checks to see if the ContactId property is set.
        /// </summary>
        internal bool IsSetContactId() => this.ContactId != null;

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
        /// Gets and sets the property ParticipantDetails. 
        /// <para>
        /// Information identifying the participant.
        /// </para>
        ///  <important> 
        /// <para>
        /// The only valid value for <c>ParticipantRole</c> is <c>CUSTOM_BOT</c> for chat contact
        /// and <c>CUSTOMER</c> for voice contact.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required = true)]
        public ParticipantDetailsToAdd ParticipantDetails { get; set; }

        /// <summary>
        /// Checks to see if the ParticipantDetails property is set.
        /// </summary>
        internal bool IsSetParticipantDetails() => this.ParticipantDetails != null;
    }
}
