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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a tag key that is being monitored by Capacity Manager, including its activation
    /// status and the earliest available data point.
    /// </summary>
    public partial class CapacityManagerMonitoredTagKey
    {
        private bool? _capacityManagerProvided;
        private DateTime? _earliestDatapointTimestamp;
        private CapacityManagerMonitoredTagKeyStatus _status;
        private string _statusMessage;
        private string _tagKey;

        /// <summary>
        /// Gets and sets the property CapacityManagerProvided. 
        /// <para>
        ///  Indicates whether this tag key is provided by Capacity Manager by default, rather
        /// than being user-activated. 
        /// </para>
        /// </summary>
        public bool? CapacityManagerProvided
        {
            get { return this._capacityManagerProvided; }
            set { this._capacityManagerProvided = value; }
        }

        // Check to see if CapacityManagerProvided property is set
        internal bool IsSetCapacityManagerProvided()
        {
            return this._capacityManagerProvided.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EarliestDatapointTimestamp. 
        /// <para>
        ///  The earliest timestamp from which tag data is available for queries, in UTC ISO 8601
        /// format. 
        /// </para>
        /// </summary>
        public DateTime? EarliestDatapointTimestamp
        {
            get { return this._earliestDatapointTimestamp; }
            set { this._earliestDatapointTimestamp = value; }
        }

        // Check to see if EarliestDatapointTimestamp property is set
        internal bool IsSetEarliestDatapointTimestamp()
        {
            return this._earliestDatapointTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The current status of the monitored tag key. Valid values are <c>activating</c>,
        /// <c>activated</c>, <c>deactivating</c>, and <c>suspended</c>. 
        /// </para>
        /// </summary>
        public CapacityManagerMonitoredTagKeyStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        ///  A message providing additional details about the current status of the monitored
        /// tag key. 
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property TagKey. 
        /// <para>
        ///  The tag key being monitored. 
        /// </para>
        /// </summary>
        public string TagKey
        {
            get { return this._tagKey; }
            set { this._tagKey = value; }
        }

        // Check to see if TagKey property is set
        internal bool IsSetTagKey()
        {
            return this._tagKey != null;
        }

    }
}