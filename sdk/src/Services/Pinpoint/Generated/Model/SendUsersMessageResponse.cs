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
    /// User send message response.
    /// </summary>
    public partial class SendUsersMessageResponse
    {
        private string _applicationId;
        private string _requestId;
        private Dictionary<string, Dictionary<string, EndpointMessageResult>> _result = new Dictionary<string, Dictionary<string, EndpointMessageResult>>();

        /// <summary>
        /// Gets and sets the property ApplicationId. The unique ID of the Amazon Pinpoint project
        /// used to send the message.
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
        /// Gets and sets the property RequestId. The unique ID assigned to the users-messages
        /// request.
        /// </summary>
        public string RequestId
        {
            get { return this._requestId; }
            set { this._requestId = value; }
        }

        // Check to see if RequestId property is set
        internal bool IsSetRequestId()
        {
            return this._requestId != null;
        }

        /// <summary>
        /// Gets and sets the property Result. An object that shows the endpoints that were messaged
        /// for each user. The object provides a list of user IDs. For each user ID, it provides
        /// the endpoint IDs that were messaged. For each endpoint ID, it provides an EndpointMessageResult
        /// object.
        /// </summary>
        public Dictionary<string, Dictionary<string, EndpointMessageResult>> Result
        {
            get { return this._result; }
            set { this._result = value; }
        }

        // Check to see if Result property is set
        internal bool IsSetResult()
        {
            return this._result != null && this._result.Count > 0; 
        }

    }
}