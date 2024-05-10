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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the CreatePersistentContactAssociation operation.
    /// Enables rehydration of chats for the lifespan of a contact. For more information about
    /// chat rehydration, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/chat-persistence.html">Enable
    /// persistent chat</a> in the <i>Amazon Connect Administrator Guide</i>.
    /// </summary>
    public partial class CreatePersistentContactAssociationRequest : AmazonConnectRequest
    {
        private string _clientToken;
        private string _initialContactId;
        private string _instanceId;
        private RehydrationType _rehydrationType;
        private string _sourceContactId;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If not provided, the Amazon Web Services SDK populates this field. For
        /// more information about idempotency, see <a href="https://aws.amazon.com/builders-library/making-retries-safe-with-idempotent-APIs/">Making
        /// retries safe with idempotent APIs</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=500)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property InitialContactId. 
        /// <para>
        /// This is the contactId of the current contact that the <c>CreatePersistentContactAssociation</c>
        /// API is being called from.
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
        /// The identifier of the Amazon Connect instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
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
        /// Gets and sets the property RehydrationType. 
        /// <para>
        /// The contactId chosen for rehydration depends on the type chosen.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ENTIRE_PAST_SESSION</c>: Rehydrates a chat from the most recently terminated past
        /// chat contact of the specified past ended chat session. To use this type, provide the
        /// <c>initialContactId</c> of the past ended chat session in the <c>sourceContactId</c>
        /// field. In this type, Amazon Connect determines what the most recent chat contact on
        /// the past ended chat session and uses it to start a persistent chat. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FROM_SEGMENT</c>: Rehydrates a chat from the specified past chat contact provided
        /// in the <c>sourceContactId</c> field. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The actual contactId used for rehydration is provided in the response of this API.
        /// </para>
        ///  
        /// <para>
        /// To illustrate how to use rehydration type, consider the following example: A customer
        /// starts a chat session. Agent a1 accepts the chat and a conversation starts between
        /// the customer and Agent a1. This first contact creates a contact ID <b>C1</b>. Agent
        /// a1 then transfers the chat to Agent a2. This creates another contact ID <b>C2</b>.
        /// At this point Agent a2 ends the chat. The customer is forwarded to the disconnect
        /// flow for a post chat survey that creates another contact ID <b>C3</b>. After the chat
        /// survey, the chat session ends. Later, the customer returns and wants to resume their
        /// past chat session. At this point, the customer can have following use cases: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Use Case 1</b>: The customer wants to continue the past chat session but they
        /// want to hide the post chat survey. For this they will use the following configuration:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Configuration</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// SourceContactId = "C2"
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RehydrationType = "FROM_SEGMENT"
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <b>Expected behavior</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// This starts a persistent chat session from the specified past ended contact (C2).
        /// Transcripts of past chat sessions C2 and C1 are accessible in the current persistent
        /// chat session. Note that chat segment C3 is dropped from the persistent chat session.
        /// </para>
        ///  </li> </ul> </li> </ul> </li> <li> 
        /// <para>
        ///  <b>Use Case 2</b>: The customer wants to continue the past chat session and see the
        /// transcript of the entire past engagement, including the post chat survey. For this
        /// they will use the following configuration:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Configuration</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// SourceContactId = "C1"
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RehydrationType = "ENTIRE_PAST_SESSION"
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <b>Expected behavior</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// This starts a persistent chat session from the most recently ended chat contact (C3).
        /// Transcripts of past chat sessions C3, C2 and C1 are accessible in the current persistent
        /// chat session.
        /// </para>
        ///  </li> </ul> </li> </ul> </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public RehydrationType RehydrationType
        {
            get { return this._rehydrationType; }
            set { this._rehydrationType = value; }
        }

        // Check to see if RehydrationType property is set
        internal bool IsSetRehydrationType()
        {
            return this._rehydrationType != null;
        }

        /// <summary>
        /// Gets and sets the property SourceContactId. 
        /// <para>
        /// The contactId from which a persistent chat session must be started.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string SourceContactId
        {
            get { return this._sourceContactId; }
            set { this._sourceContactId = value; }
        }

        // Check to see if SourceContactId property is set
        internal bool IsSetSourceContactId()
        {
            return this._sourceContactId != null;
        }

    }
}