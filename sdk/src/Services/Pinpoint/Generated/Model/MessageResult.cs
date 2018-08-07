/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// The result from sending a message to an address.
    /// </summary>
    public partial class MessageResult
    {
        private DeliveryStatus _deliveryStatus;
        private string _messageId;
        private int? _statusCode;
        private string _statusMessage;
        private string _updatedToken;

        /// <summary>
        /// Gets and sets the property DeliveryStatus. The delivery status of the message. Possible
        /// values:SUCCESS - The message was successfully delivered to the endpoint.TRANSIENT_FAILURE
        /// - A temporary error occurred. Amazon Pinpoint will attempt to deliver the message
        /// again later.FAILURE_PERMANENT - An error occurred when delivering the message to the
        /// endpoint. Amazon Pinpoint won't attempt to send the message again.TIMEOUT - The message
        /// couldn't be sent within the timeout period.QUIET_TIME - The local time for the endpoint
        /// was within the Quiet Hours for the campaign.DAILY_CAP - The endpoint has received
        /// the maximum number of messages it can receive within a 24-hour period.HOLDOUT - The
        /// endpoint was in a hold out treatment for the campaign.THROTTLED - Amazon Pinpoint
        /// throttled sending to this endpoint.EXPIRED - The endpoint address is expired.CAMPAIGN_CAP
        /// - The endpoint received the maximum number of messages allowed by the campaign.SERVICE_FAILURE
        /// - A service-level failure prevented Amazon Pinpoint from delivering the message.UNKNOWN
        /// - An unknown error occurred.
        /// </summary>
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
        /// Gets and sets the property MessageId. Unique message identifier associated with the
        /// message that was sent.
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
        /// Gets and sets the property StatusCode. Downstream service status code.
        /// </summary>
        public int StatusCode
        {
            get { return this._statusCode.GetValueOrDefault(); }
            set { this._statusCode = value; }
        }

        // Check to see if StatusCode property is set
        internal bool IsSetStatusCode()
        {
            return this._statusCode.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. Status message for message delivery.
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
        /// Gets and sets the property UpdatedToken. If token was updated as part of delivery.
        /// (This is GCM Specific)
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