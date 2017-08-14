/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the AWSMigrationHub-2017-05-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MigrationHub.Model
{
    /// <summary>
    /// Represents a migration task in a migration tool.
    /// </summary>
    public partial class MigrationTask
    {
        private string _migrationTaskName;
        private string _progressUpdateStream;
        private List<ResourceAttribute> _resourceAttributeList = new List<ResourceAttribute>();
        private Task _task;
        private DateTime? _updateDateTime;

        /// <summary>
        /// Gets and sets the property MigrationTaskName. 
        /// <para>
        /// Unique identifier that references the migration task.
        /// </para>
        /// </summary>
        public string MigrationTaskName
        {
            get { return this._migrationTaskName; }
            set { this._migrationTaskName = value; }
        }

        // Check to see if MigrationTaskName property is set
        internal bool IsSetMigrationTaskName()
        {
            return this._migrationTaskName != null;
        }

        /// <summary>
        /// Gets and sets the property ProgressUpdateStream. 
        /// <para>
        /// A name that identifies the vendor of the migration tool being used.
        /// </para>
        /// </summary>
        public string ProgressUpdateStream
        {
            get { return this._progressUpdateStream; }
            set { this._progressUpdateStream = value; }
        }

        // Check to see if ProgressUpdateStream property is set
        internal bool IsSetProgressUpdateStream()
        {
            return this._progressUpdateStream != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceAttributeList.
        /// </summary>
        public List<ResourceAttribute> ResourceAttributeList
        {
            get { return this._resourceAttributeList; }
            set { this._resourceAttributeList = value; }
        }

        // Check to see if ResourceAttributeList property is set
        internal bool IsSetResourceAttributeList()
        {
            return this._resourceAttributeList != null && this._resourceAttributeList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Task. 
        /// <para>
        /// Task object encapsulating task information.
        /// </para>
        /// </summary>
        public Task Task
        {
            get { return this._task; }
            set { this._task = value; }
        }

        // Check to see if Task property is set
        internal bool IsSetTask()
        {
            return this._task != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateDateTime. 
        /// <para>
        /// The timestamp when the task was gathered.
        /// </para>
        /// </summary>
        public DateTime UpdateDateTime
        {
            get { return this._updateDateTime.GetValueOrDefault(); }
            set { this._updateDateTime = value; }
        }

        // Check to see if UpdateDateTime property is set
        internal bool IsSetUpdateDateTime()
        {
            return this._updateDateTime.HasValue; 
        }

    }
}