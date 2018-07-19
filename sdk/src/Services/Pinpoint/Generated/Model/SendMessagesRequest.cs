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
    /// Container for the parameters to the SendMessages operation.
    /// Use this resource to send a direct message, which is a one time message that you send
    /// to a limited audience without creating a campaign. You can send the message to up
    /// to 100 recipients. You cannot use the message to engage a segment. When you send the
    /// message, Amazon Pinpoint delivers it immediately, and you cannot schedule the delivery.
    /// To engage a user segment, and to schedule the message delivery, create a campaign
    /// instead of sending a direct message.You can send a direct message as a push notification
    /// to your mobile app or as an SMS message to SMS-enabled devices.
    /// </summary>
    public partial class SendMessagesRequest : AmazonPinpointRequest
    {
        private string _applicationId;
        private MessageRequest _messageRequest;

        /// <summary>
        /// Gets and sets the property ApplicationId. The unique ID of your Amazon Pinpoint application.
        /// </summary>
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property MessageRequest.
        /// </summary>
        public MessageRequest MessageRequest
        {
            get { return this._messageRequest; }
            set { this._messageRequest = value; }
        }

        // Check to see if MessageRequest property is set
        internal bool IsSetMessageRequest()
        {
            return this._messageRequest != null;
        }

    }
}