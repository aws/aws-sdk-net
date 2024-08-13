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
 * Do not modify this file. This file is generated from the frauddetector-2019-11-15.normal.json service model.
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
namespace Amazon.FraudDetector.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteEvent operation.
    /// Deletes the specified event.
    /// 
    ///  
    /// <para>
    /// When you delete an event, Amazon Fraud Detector permanently deletes that event and
    /// the event data is no longer stored in Amazon Fraud Detector. If <c>deleteAuditHistory</c>
    /// is <c>True</c>, event data is available through search for up to 30 seconds after
    /// the delete operation is completed.
    /// </para>
    /// </summary>
    public partial class DeleteEventRequest : AmazonFraudDetectorRequest
    {
        private bool? _deleteAuditHistory;
        private string _eventId;
        private string _eventTypeName;

        /// <summary>
        /// Gets and sets the property DeleteAuditHistory. 
        /// <para>
        /// Specifies whether or not to delete any predictions associated with the event. If set
        /// to <c>True</c>, 
        /// </para>
        /// </summary>
        public bool? DeleteAuditHistory
        {
            get { return this._deleteAuditHistory; }
            set { this._deleteAuditHistory = value; }
        }

        // Check to see if DeleteAuditHistory property is set
        internal bool IsSetDeleteAuditHistory()
        {
            return this._deleteAuditHistory.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        /// The ID of the event to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// Gets and sets the property EventTypeName. 
        /// <para>
        /// The name of the event type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string EventTypeName
        {
            get { return this._eventTypeName; }
            set { this._eventTypeName = value; }
        }

        // Check to see if EventTypeName property is set
        internal bool IsSetEventTypeName()
        {
            return this._eventTypeName != null;
        }

    }
}