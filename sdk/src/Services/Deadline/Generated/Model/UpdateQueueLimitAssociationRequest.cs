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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
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
namespace Amazon.Deadline.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateQueueLimitAssociation operation.
    /// Updates the status of the queue. If you set the status to one of the <c>STOP_LIMIT_USAGE*</c>
    /// values, there will be a delay before the status transitions to the <c>STOPPED</c>
    /// state.
    /// </summary>
    public partial class UpdateQueueLimitAssociationRequest : AmazonDeadlineRequest
    {
        private string _farmId;
        private string _limitId;
        private string _queueId;
        private UpdateQueueLimitAssociationStatus _status;

        /// <summary>
        /// Gets and sets the property FarmId. 
        /// <para>
        /// The unique identifier of the farm that contains the associated queues and limits.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FarmId
        {
            get { return this._farmId; }
            set { this._farmId = value; }
        }

        // Check to see if FarmId property is set
        internal bool IsSetFarmId()
        {
            return this._farmId != null;
        }

        /// <summary>
        /// Gets and sets the property LimitId. 
        /// <para>
        /// The unique identifier of the limit associated to the queue.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LimitId
        {
            get { return this._limitId; }
            set { this._limitId = value; }
        }

        // Check to see if LimitId property is set
        internal bool IsSetLimitId()
        {
            return this._limitId != null;
        }

        /// <summary>
        /// Gets and sets the property QueueId. 
        /// <para>
        /// The unique identifier of the queue associated to the limit.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string QueueId
        {
            get { return this._queueId; }
            set { this._queueId = value; }
        }

        // Check to see if QueueId property is set
        internal bool IsSetQueueId()
        {
            return this._queueId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Sets the status of the limit. You can mark the limit active, or you can stop usage
        /// of the limit and either complete existing tasks or cancel any existing tasks immediately.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public UpdateQueueLimitAssociationStatus Status
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