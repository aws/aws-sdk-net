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
 * Do not modify this file. This file is generated from the eventbridgev2-2025-05-15.normal.json service model.
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
namespace Amazon.EventBridgeV2.Model
{
    /// <summary>
    /// Result entry for a published event. The position of each entry in the response list
    /// aligns 1:1 with the corresponding request entry, enabling co-location by index.
    /// </summary>
    public partial class PutRawEventsResultEntry
    {
        private string _errorCode;
        private string _errorMessage;
        private string _eventId;
        private string _sequenceNumber;
        private SuccessCode _successCode;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// Error code if the entry failed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// Error message if the entry failed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Unique event ID assigned by the service. Present on successful entries.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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

        /// <summary>
        /// Gets and sets the property SequenceNumber. 
        /// <para>
        /// Sequence number for ordering within the event group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string SequenceNumber
        {
            get { return this._sequenceNumber; }
            set { this._sequenceNumber = value; }
        }

        // Check to see if SequenceNumber property is set
        internal bool IsSetSequenceNumber()
        {
            return this._sequenceNumber != null;
        }

        /// <summary>
        /// Gets and sets the property SuccessCode. 
        /// <para>
        /// Indicates how the entry was processed. Present only on successful entries.
        /// </para>
        /// </summary>
        public SuccessCode SuccessCode
        {
            get { return this._successCode; }
            set { this._successCode = value; }
        }

        // Check to see if SuccessCode property is set
        internal bool IsSetSuccessCode()
        {
            return this._successCode != null;
        }

    }
}