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
    /// Container for the parameters to the SendUsersMessages operation.
    /// Use this resource to message a list of users. Amazon Pinpoint sends the message to
    /// all of the endpoints that are associated with each user.A user represents an individual
    /// who is assigned a unique user ID, and this ID is assigned to one or more endpoints.
    /// For example, if an individual uses your app on multiple devices, your app could assign
    /// that person's user ID to the endpoint for each device.With the users-messages resource,
    /// you specify the message recipients as user IDs. For each user ID, Amazon Pinpoint
    /// delivers the message to all of the user's endpoints. Within the body of your request,
    /// you can specify a default message, and you can tailor your message for different channels,
    /// including those for mobile push and SMS.With this resource, you send a direct message,
    /// which is a one time message that you send to a limited audience without creating a
    /// campaign. You can send the message to up to 100 users per request. You cannot use
    /// the message to engage a segment. When you send the message, Amazon Pinpoint delivers
    /// it immediately, and you cannot schedule the delivery. To engage a user segment, and
    /// to schedule the message delivery, create a campaign instead of using the users-messages
    /// resource.
    /// </summary>
    public partial class SendUsersMessagesRequest : AmazonPinpointRequest
    {
        private string _applicationId;
        private SendUsersMessageRequest _sendUsersMessageRequest;

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
        /// Gets and sets the property SendUsersMessageRequest.
        /// </summary>
        public SendUsersMessageRequest SendUsersMessageRequest
        {
            get { return this._sendUsersMessageRequest; }
            set { this._sendUsersMessageRequest = value; }
        }

        // Check to see if SendUsersMessageRequest property is set
        internal bool IsSetSendUsersMessageRequest()
        {
            return this._sendUsersMessageRequest != null;
        }

    }
}