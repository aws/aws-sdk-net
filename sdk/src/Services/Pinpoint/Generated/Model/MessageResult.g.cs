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

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Provides information about the results of sending a message directly to an endpoint
    /// address.
    /// </summary>
    public partial class MessageResult
    {
        /// <summary>
        /// Gets and sets the property DeliveryStatus. 
        /// <para>
        /// The delivery status of the message. Possible values are:
        /// </para>
        ///  <ul> <li>
        /// <para>
        /// DUPLICATE - The endpoint address is a duplicate of another endpoint address. Amazon
        /// Pinpoint won't attempt to send the message again.
        /// </para>
        /// </li> <li>
        /// <para>
        /// OPT_OUT - The user who's associated with the endpoint address has opted out of receiving
        /// messages from you. Amazon Pinpoint won't attempt to send the message again.
        /// </para>
        /// </li> <li>
        /// <para>
        /// PERMANENT_FAILURE - An error occurred when delivering the message to the endpoint
        /// address. Amazon Pinpoint won't attempt to send the message again.
        /// </para>
        /// </li> <li>
        /// <para>
        /// SUCCESSFUL - The message was successfully delivered to the endpoint address.
        /// </para>
        /// </li> <li>
        /// <para>
        /// TEMPORARY_FAILURE - A temporary error occurred. Amazon Pinpoint won't attempt to send
        /// the message again.
        /// </para>
        /// </li> <li>
        /// <para>
        /// THROTTLED - Amazon Pinpoint throttled the operation to send the message to the endpoint
        /// address.
        /// </para>
        /// </li> <li>
        /// <para>
        /// UNKNOWN_FAILURE - An unknown error occurred.
        /// </para>
        /// </li></ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public DeliveryStatus DeliveryStatus { get; set; }

        /// <summary>
        /// Checks to see if the DeliveryStatus property is set.
        /// </summary>
        internal bool IsSetDeliveryStatus() => this.DeliveryStatus != null;

        /// <summary>
        /// Gets and sets the property MessageId. 
        /// <para>
        /// The unique identifier for the message that was sent.
        /// </para>
        /// </summary>
        public string MessageId { get; set; }

        /// <summary>
        /// Checks to see if the MessageId property is set.
        /// </summary>
        internal bool IsSetMessageId() => this.MessageId != null;

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// The downstream service status code for delivering the message.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? StatusCode { get; set; }

        /// <summary>
        /// Checks to see if the StatusCode property is set.
        /// </summary>
        internal bool IsSetStatusCode() => this.StatusCode.HasValue;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The status message for delivering the message.
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property UpdatedToken. 
        /// <para>
        /// For push notifications that are sent through the GCM channel, specifies whether the
        /// endpoint's device registration token was updated as part of delivering the message.
        /// </para>
        /// </summary>
        public string UpdatedToken { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedToken property is set.
        /// </summary>
        internal bool IsSetUpdatedToken() => this.UpdatedToken != null;
    }
}
