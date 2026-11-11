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
    /// Container for the parameters to the SendChatIntegrationEvent operation. Processes
    /// chat integration events from Amazon Web Services or external integrations to Connect
    /// Customer. A chat integration event includes: <ul> <li> <para> SourceId, DestinationId,
    /// and Subtype: a set of identifiers, uniquely representing a chat </para> </li> <li>
    /// <para> ChatEvent: details of the chat action to perform such as sending a message,
    /// event, or disconnecting from a chat </para> </li> </ul> <para> When a chat integration
    /// event is sent with chat identifiers that do not map to an active chat contact, a new
    /// chat contact is also created before handling chat action. </para> <para> Access to
    /// this API is currently restricted to Amazon Web Services End User Messaging for supporting
    /// SMS integration. </para>
    /// </summary>
    public partial class SendChatIntegrationEventRequest : AmazonConnectRequest
    {
        /// <summary>
        /// Gets and sets the property DestinationId. 
        /// <para>
        /// Chat system identifier, used in part to uniquely identify chat. This is associated
        /// with the Connect Customer instance and flow to be used to start chats. For Server
        /// Migration Service, this is the phone number destination of inbound Server Migration
        /// Service messages represented by an Amazon Web Services End User Messaging phone number
        /// ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string DestinationId { get; set; }

        /// <summary>
        /// Checks to see if the DestinationId property is set.
        /// </summary>
        internal bool IsSetDestinationId() => this.DestinationId != null;

        /// <summary>
        /// Gets and sets the property Event. 
        /// <para>
        /// Chat integration event payload
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ChatEvent Event { get; set; }

        /// <summary>
        /// Checks to see if the Event property is set.
        /// </summary>
        internal bool IsSetEvent() => this.Event != null;

        /// <summary>
        /// Gets and sets the property NewSessionDetails. 
        /// <para>
        /// Contact properties to apply when starting a new chat. If the integration event is
        /// handled with an existing chat, this is ignored.
        /// </para>
        /// </summary>
        public NewSessionDetails NewSessionDetails { get; set; }

        /// <summary>
        /// Checks to see if the NewSessionDetails property is set.
        /// </summary>
        internal bool IsSetNewSessionDetails() => this.NewSessionDetails != null;

        /// <summary>
        /// Gets and sets the property SourceId. 
        /// <para>
        /// External identifier of chat customer participant, used in part to uniquely identify
        /// a chat. For SMS, this is the E164 phone number of the chat customer participant.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string SourceId { get; set; }

        /// <summary>
        /// Checks to see if the SourceId property is set.
        /// </summary>
        internal bool IsSetSourceId() => this.SourceId != null;

        /// <summary>
        /// Gets and sets the property Subtype. 
        /// <para>
        /// Classification of a channel. This is used in part to uniquely identify chat. 
        /// </para>
        ///  
        /// <para>
        /// Valid value: <c>["connect:sms", connect:"WhatsApp"]</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string Subtype { get; set; }

        /// <summary>
        /// Checks to see if the Subtype property is set.
        /// </summary>
        internal bool IsSetSubtype() => this.Subtype != null;
    }
}
