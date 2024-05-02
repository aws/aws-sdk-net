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
 * Do not modify this file. This file is generated from the eventbridge-2015-10-07.normal.json service model.
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
namespace Amazon.EventBridge.Model
{
    /// <summary>
    /// Represents the results of an event submitted to an event bus.
    /// 
    ///  
    /// <para>
    /// If the submission was successful, the entry has the event ID in it. Otherwise, you
    /// can use the error code and error message to identify the problem with the entry.
    /// </para>
    ///  
    /// <para>
    /// For information about the errors that are common to all actions, see <a href="https://docs.aws.amazon.com/eventbridge/latest/APIReference/CommonErrors.html">Common
    /// Errors</a>.
    /// </para>
    /// </summary>
    public partial class PutEventsResultEntry
    {
        private string _errorCode;
        private string _errorMessage;
        private string _eventId;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The error code that indicates why the event submission failed.
        /// </para>
        ///  
        /// <para>
        /// Retryable errors include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c> <a href="https://docs.aws.amazon.com/eventbridge/latest/APIReference/CommonErrors.html">InternalFailure</a>
        /// </c> 
        /// </para>
        ///  
        /// <para>
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c> <a href="https://docs.aws.amazon.com/eventbridge/latest/APIReference/CommonErrors.html">ThrottlingException</a>
        /// </c> 
        /// </para>
        ///  
        /// <para>
        /// The request was denied due to request throttling.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Non-retryable errors include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c> <a href="https://docs.aws.amazon.com/eventbridge/latest/APIReference/CommonErrors.html">AccessDeniedException</a>
        /// </c> 
        /// </para>
        ///  
        /// <para>
        /// You do not have sufficient access to perform this action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>InvalidAccountIdException</c> 
        /// </para>
        ///  
        /// <para>
        /// The account ID provided is not valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>InvalidArgument</c> 
        /// </para>
        ///  
        /// <para>
        /// A specified parameter is not valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MalformedDetail</c> 
        /// </para>
        ///  
        /// <para>
        /// The JSON provided is not valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RedactionFailure</c> 
        /// </para>
        ///  
        /// <para>
        /// Redacting the CloudTrail event failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NotAuthorizedForSourceException</c> 
        /// </para>
        ///  
        /// <para>
        /// You do not have permissions to publish events with this source onto this event bus.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NotAuthorizedForDetailTypeException</c> 
        /// </para>
        ///  
        /// <para>
        /// You do not have permissions to publish events with this detail type onto this event
        /// bus.
        /// </para>
        ///  </li> </ul>
        /// </summary>
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
        /// The error message that explains why the event submission failed.
        /// </para>
        /// </summary>
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
        /// The ID of the event.
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
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