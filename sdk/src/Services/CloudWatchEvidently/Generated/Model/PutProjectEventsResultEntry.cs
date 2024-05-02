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
 * Do not modify this file. This file is generated from the evidently-2021-02-01.normal.json service model.
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
namespace Amazon.CloudWatchEvidently.Model
{
    /// <summary>
    /// A structure that contains Evidently's response to the sent events, including an event
    /// ID and error codes, if any.
    /// </summary>
    public partial class PutProjectEventsResultEntry
    {
        private string _errorCode;
        private string _errorMessage;
        private string _eventId;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// If the <c>PutProjectEvents</c> operation has an error, the error code is returned
        /// here.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// If the <c>PutProjectEvents</c> operation has an error, the error message is returned
        /// here.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property EventId. 
        /// <para>
        /// A unique ID assigned to this <c>PutProjectEvents</c> operation. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string EventId
        {
            get { return this._eventId; }
            set { this._eventId = value; }
        }

        // Check to see if EventId property is set
        internal bool IsSetEventId()
        {
            return this._eventId != null;
        }

    }
}