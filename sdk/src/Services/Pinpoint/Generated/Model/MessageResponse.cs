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
    /// Send message response.
    /// </summary>
    public partial class MessageResponse
    {
        private string _applicationId;
        private Dictionary<string, EndpointMessageResult> _endpointResult = new Dictionary<string, EndpointMessageResult>();
        private string _requestId;
        private Dictionary<string, MessageResult> _result = new Dictionary<string, MessageResult>();

        /// <summary>
        /// Gets and sets the property ApplicationId. Application id of the message.
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
        /// Gets and sets the property EndpointResult. A map containing a multi part response
        /// for each address, with the endpointId as the key and the result as the value.
        /// </summary>
        public Dictionary<string, EndpointMessageResult> EndpointResult
        {
            get { return this._endpointResult; }
            set { this._endpointResult = value; }
        }

        // Check to see if EndpointResult property is set
        internal bool IsSetEndpointResult()
        {
            return this._endpointResult != null && this._endpointResult.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RequestId. Original request Id for which this message was
        /// delivered.
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
        /// Gets and sets the property Result. A map containing a multi part response for each
        /// address, with the address as the key(Email address, phone number or push token) and
        /// the result as the value.
        /// </summary>
        public Dictionary<string, MessageResult> Result
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