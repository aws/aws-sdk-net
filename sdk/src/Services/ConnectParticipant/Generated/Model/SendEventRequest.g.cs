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

namespace Amazon.ConnectParticipant.Model
{
    /// <summary>
    /// Container for the parameters to the SendEvent operation. <note> <para> The <c>application/vnd.amazonaws.connect.event.connection.acknowledged</c>
    /// ContentType is no longer maintained since December 31, 2024. This event has been migrated
    /// to the <a href="https://docs.aws.amazon.com/connect-participant/latest/APIReference/API_CreateParticipantConnection.html">CreateParticipantConnection</a>
    /// API using the <c>ConnectParticipant</c> field. </para> </note> <para> Sends an event.
    /// Message receipts are not supported when there are more than two active participants
    /// in the chat. Using the SendEvent API for message receipts when a supervisor is barged-in
    /// will result in a conflict exception. </para> <para> For security recommendations,
    /// see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/security-best-practices.html#bp-security-chat">Connect
    /// Customer Chat security best practices</a>. </para> <note> <para> <c>ConnectionToken</c>
    /// is used for invoking this API instead of <c>ParticipantToken</c>. </para> </note>
    /// <para> The Amazon Connect Participant Service APIs do not use <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
    /// Version 4 authentication</a>. </para>
    /// </summary>
    public partial class SendEventRequest : AmazonConnectParticipantRequest
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
        /// Gets and sets the property ConnectionToken. 
        /// <para>
        /// The authentication token associated with the participant's connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1000)]
        public string ConnectionToken { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionToken property is set.
        /// </summary>
        internal bool IsSetConnectionToken() => this.ConnectionToken != null;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The content of the event to be sent (for example, message text). For content related
        /// to message receipts, this is supported in the form of a JSON string.
        /// </para>
        ///  
        /// <para>
        /// Sample Content: "{\"messageId\":\"11111111-aaaa-bbbb-cccc-EXAMPLE01234\"}"
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 16384)]
        public string Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The content type of the request. Supported types are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// application/vnd.amazonaws.connect.event.typing
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// application/vnd.amazonaws.connect.event.connection.acknowledged (is no longer maintained
        /// since December 31, 2024) 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// application/vnd.amazonaws.connect.event.message.delivered
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// application/vnd.amazonaws.connect.event.message.read
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string ContentType { get; set; }

        /// <summary>
        /// Checks to see if the ContentType property is set.
        /// </summary>
        internal bool IsSetContentType() => this.ContentType != null;
    }
}
