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
    /// Provides information about the association between a queue and a limit.
    /// </summary>
    public partial class QueueLimitAssociationSummary
    {
        private DateTime? _createdAt;
        private string _createdBy;
        private string _limitId;
        private string _queueId;
        private QueueLimitAssociationStatus _status;
        private DateTime? _updatedAt;
        private string _updatedBy;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The Unix timestamp of the date and time that the association was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The user identifier of the person that created the association.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property LimitId. 
        /// <para>
        /// The unique identifier of the limit in the association.
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
        /// The unique identifier of the queue in the association.
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
        /// The status of task scheduling in the queue-limit association.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ACTIVE</c> - Association is active.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STOP_LIMIT_USAGE_AND_COMPLETE_TASKS</c> - Association has stopped scheduling new
        /// tasks and is completing current tasks.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STOP_LIMIT_USAGE_AND_CANCEL_TASKS</c> - Association has stopped scheduling new
        /// tasks and is canceling current tasks.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STOPPED</c> - Association has been stopped.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public QueueLimitAssociationStatus Status
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
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The Unix timestamp of the date and time that the association was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpdatedBy. 
        /// <para>
        /// The user identifier of the person that updated the association.
        /// </para>
        /// </summary>
        public string UpdatedBy
        {
            get { return this._updatedBy; }
            set { this._updatedBy = value; }
        }

        // Check to see if UpdatedBy property is set
        internal bool IsSetUpdatedBy()
        {
            return this._updatedBy != null;
        }

    }
}