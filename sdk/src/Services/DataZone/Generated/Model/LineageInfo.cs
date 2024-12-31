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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The data lineage information.
    /// </summary>
    public partial class LineageInfo
    {
        private string _errorMessage;
        private string _eventId;
        private LineageEventProcessingStatus _eventStatus;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// The data lineage error message.
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
        /// The data lineage event ID.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property EventStatus. 
        /// <para>
        /// The data lineage event status.
        /// </para>
        /// </summary>
        public LineageEventProcessingStatus EventStatus
        {
            get { return this._eventStatus; }
            set { this._eventStatus = value; }
        }

        // Check to see if EventStatus property is set
        internal bool IsSetEventStatus()
        {
            return this._eventStatus != null;
        }

    }
}