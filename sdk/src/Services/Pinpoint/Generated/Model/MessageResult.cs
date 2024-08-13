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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
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
        private DeliveryStatus _deliveryStatus;
        private string _messageId;
        private int? _statusCode;
        private string _statusMessage;
        private string _updatedToken;

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
        /// </li>   <li>
        /// <para>
        /// OPT_OUT - The user who's associated with the endpoint address has opted out of receiving
        /// messages from you. Amazon Pinpoint won't attempt to send the message again.
        /// </para>
        /// </li> <li>
        /// <para>
        /// PERMANENT_FAILURE - An error occurred when delivering the message to the endpoint
        /// address. Amazon Pinpoint won't attempt to send the message again.
        /// </para>
        /// </li>   <li>
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
        [AWSProperty(Required=true)]
        public DeliveryStatus DeliveryStatus
        {
            get { return this._deliveryStatus; }
            set { this._deliveryStatus = value; }
        }

        // Check to see if DeliveryStatus property is set
        internal bool IsSetDeliveryStatus()
        {
            return this._deliveryStatus != null;
        }

        /// <summary>
        /// Gets and sets the property MessageId. 
        /// <para>
        /// The unique identifier for the message that was sent.
        /// </para>
        /// </summary>
        public string MessageId
        {
            get { return this._messageId; }
            set { this._messageId = value; }
        }

        // Check to see if MessageId property is set
        internal bool IsSetMessageId()
        {
            return this._messageId != null;
        }

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// The downstream service status code for delivering the message.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? StatusCode
        {
            get { return this._statusCode; }
            set { this._statusCode = value; }
        }

        // Check to see if StatusCode property is set
        internal bool IsSetStatusCode()
        {
            return this._statusCode.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The status message for delivering the message.
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
        /// Gets and sets the property UpdatedToken. 
        /// <para>
        /// For push notifications that are sent through the GCM channel, specifies whether the
        /// endpoint's device registration token was updated as part of delivering the message.
        /// </para>
        /// </summary>
        public string UpdatedToken
        {
            get { return this._updatedToken; }
            set { this._updatedToken = value; }
        }

        // Check to see if UpdatedToken property is set
        internal bool IsSetUpdatedToken()
        {
            return this._updatedToken != null;
        }

    }
}