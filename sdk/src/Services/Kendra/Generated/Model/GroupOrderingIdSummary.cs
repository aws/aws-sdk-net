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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Summary information on the processing of <code>PUT</code> and <code>DELETE</code>
    /// actions for mapping users to their groups.
    /// </summary>
    public partial class GroupOrderingIdSummary
    {
        private string _failureReason;
        private DateTime? _lastUpdatedAt;
        private long? _orderingId;
        private DateTime? _receivedAt;
        private PrincipalMappingStatus _status;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason an action could not be processed. An action can be a <code>PUT</code> or
        /// <code>DELETE</code> action for mapping users to their groups.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The Unix timestamp when an action was last updated. An action can be a <code>PUT</code>
        /// or <code>DELETE</code> action for mapping users to their groups.
        /// </para>
        /// </summary>
        public DateTime LastUpdatedAt
        {
            get { return this._lastUpdatedAt.GetValueOrDefault(); }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OrderingId. 
        /// <para>
        /// The order in which actions should complete processing. An action can be a <code>PUT</code>
        /// or <code>DELETE</code> action for mapping users to their groups.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=32535158400000)]
        public long OrderingId
        {
            get { return this._orderingId.GetValueOrDefault(); }
            set { this._orderingId = value; }
        }

        // Check to see if OrderingId property is set
        internal bool IsSetOrderingId()
        {
            return this._orderingId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReceivedAt. 
        /// <para>
        /// The Unix timestamp when an action was received by Amazon Kendra. An action can be
        /// a <code>PUT</code> or <code>DELETE</code> action for mapping users to their groups.
        /// </para>
        /// </summary>
        public DateTime ReceivedAt
        {
            get { return this._receivedAt.GetValueOrDefault(); }
            set { this._receivedAt = value; }
        }

        // Check to see if ReceivedAt property is set
        internal bool IsSetReceivedAt()
        {
            return this._receivedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current processing status of actions for mapping users to their groups. The status
        /// can be either <code>PROCESSING</code>, <code>SUCCEEDED</code>, <code>DELETING</code>,
        /// <code>DELETED</code>, or <code>FAILED</code>.
        /// </para>
        /// </summary>
        public PrincipalMappingStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}