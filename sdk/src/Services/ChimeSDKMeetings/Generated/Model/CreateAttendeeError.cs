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
 * Do not modify this file. This file is generated from the chime-sdk-meetings-2021-07-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ChimeSDKMeetings.Model
{
    /// <summary>
    /// The list of errors returned when errors are encountered during the BatchCreateAttendee
    /// and CreateAttendee actions. This includes external user IDs, error codes, and error
    /// messages.
    /// </summary>
    public partial class CreateAttendeeError
    {
        private string _errorCode;
        private string _errorMessage;
        private string _externalUserId;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The error code.
        /// </para>
        /// </summary>
        [AWSProperty(Max=4096)]
        public string ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }

        // Check to see if ErrorCode property is set
        internal bool IsSetErrorCode()
        {
            return this._errorCode != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// The error message.
        /// </para>
        /// </summary>
        [AWSProperty(Max=4096)]
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property ExternalUserId. 
        /// <para>
        /// The Amazon Chime SDK external user ID. An idempotency token. Links the attendee to
        /// an identity managed by a builder application.
        /// </para>
        ///  
        /// <para>
        /// Pattern: <code>[-_&amp;@+=,(){}\[\]\/«».:|'"#a-zA-Z0-9À-ÿ\s]*</code> 
        /// </para>
        ///  
        /// <para>
        /// Values that begin with <code>aws:</code> are reserved. You can't configure a value
        /// that uses this prefix. Case insensitive.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=2, Max=64)]
        public string ExternalUserId
        {
            get { return this._externalUserId; }
            set { this._externalUserId = value; }
        }

        // Check to see if ExternalUserId property is set
        internal bool IsSetExternalUserId()
        {
            return this._externalUserId != null;
        }

    }
}