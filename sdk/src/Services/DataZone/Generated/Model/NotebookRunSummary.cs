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
    /// The summary of a notebook run in Amazon DataZone.
    /// </summary>
    public partial class NotebookRunSummary
    {
        private DateTime? _completedAt;
        private DateTime? _createdAt;
        private string _createdBy;
        private string _domainId;
        private string _id;
        private string _notebookId;
        private string _owningProjectId;
        private string _scheduleId;
        private DateTime? _startedAt;
        private NotebookRunStatus _status;
        private TriggerSource _triggerSource;
        private DateTime? _updatedAt;
        private string _updatedBy;

        /// <summary>
        /// Gets and sets the property CompletedAt. 
        /// <para>
        /// The timestamp of when the notebook run completed.
        /// </para>
        /// </summary>
        public DateTime? CompletedAt
        {
            get { return this._completedAt; }
            set { this._completedAt = value; }
        }

        // Check to see if CompletedAt property is set
        internal bool IsSetCompletedAt()
        {
            return this._completedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when the notebook run was created.
        /// </para>
        /// </summary>
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
        /// The identifier of the user who created the notebook run.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The identifier of the Amazon DataZone domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DomainId
        {
            get { return this._domainId; }
            set { this._domainId = value; }
        }

        // Check to see if DomainId property is set
        internal bool IsSetDomainId()
        {
            return this._domainId != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the notebook run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property NotebookId. 
        /// <para>
        /// The identifier of the notebook.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NotebookId
        {
            get { return this._notebookId; }
            set { this._notebookId = value; }
        }

        // Check to see if NotebookId property is set
        internal bool IsSetNotebookId()
        {
            return this._notebookId != null;
        }

        /// <summary>
        /// Gets and sets the property OwningProjectId. 
        /// <para>
        /// The identifier of the project that owns the notebook run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string OwningProjectId
        {
            get { return this._owningProjectId; }
            set { this._owningProjectId = value; }
        }

        // Check to see if OwningProjectId property is set
        internal bool IsSetOwningProjectId()
        {
            return this._owningProjectId != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduleId. 
        /// <para>
        /// The identifier of the schedule associated with the notebook run.
        /// </para>
        /// </summary>
        public string ScheduleId
        {
            get { return this._scheduleId; }
            set { this._scheduleId = value; }
        }

        // Check to see if ScheduleId property is set
        internal bool IsSetScheduleId()
        {
            return this._scheduleId != null;
        }

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The timestamp of when the notebook run started executing.
        /// </para>
        /// </summary>
        public DateTime? StartedAt
        {
            get { return this._startedAt; }
            set { this._startedAt = value; }
        }

        // Check to see if StartedAt property is set
        internal bool IsSetStartedAt()
        {
            return this._startedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the notebook run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NotebookRunStatus Status
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
        /// Gets and sets the property TriggerSource. 
        /// <para>
        /// The source that triggered the notebook run.
        /// </para>
        /// </summary>
        public TriggerSource TriggerSource
        {
            get { return this._triggerSource; }
            set { this._triggerSource = value; }
        }

        // Check to see if TriggerSource property is set
        internal bool IsSetTriggerSource()
        {
            return this._triggerSource != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp of when the notebook run was last updated.
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
        /// The identifier of the user who last updated the notebook run.
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