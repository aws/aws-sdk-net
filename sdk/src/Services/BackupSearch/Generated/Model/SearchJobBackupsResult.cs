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
 * Do not modify this file. This file is generated from the backupsearch-2018-05-10.normal.json service model.
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
namespace Amazon.BackupSearch.Model
{
    /// <summary>
    /// This contains the information about recovery points returned in results of a search
    /// job.
    /// </summary>
    public partial class SearchJobBackupsResult
    {
        private DateTime? _backupCreationTime;
        private string _backupResourceArn;
        private DateTime? _indexCreationTime;
        private ResourceType _resourceType;
        private string _sourceResourceArn;
        private SearchJobState _status;
        private string _statusMessage;

        /// <summary>
        /// Gets and sets the property BackupCreationTime. 
        /// <para>
        /// This is the creation time of the backup (recovery point).
        /// </para>
        /// </summary>
        public DateTime BackupCreationTime
        {
            get { return this._backupCreationTime.GetValueOrDefault(); }
            set { this._backupCreationTime = value; }
        }

        // Check to see if BackupCreationTime property is set
        internal bool IsSetBackupCreationTime()
        {
            return this._backupCreationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BackupResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies the backup resources.
        /// </para>
        /// </summary>
        public string BackupResourceArn
        {
            get { return this._backupResourceArn; }
            set { this._backupResourceArn = value; }
        }

        // Check to see if BackupResourceArn property is set
        internal bool IsSetBackupResourceArn()
        {
            return this._backupResourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property IndexCreationTime. 
        /// <para>
        /// This is the creation time of the backup index.
        /// </para>
        /// </summary>
        public DateTime IndexCreationTime
        {
            get { return this._indexCreationTime.GetValueOrDefault(); }
            set { this._indexCreationTime = value; }
        }

        // Check to see if IndexCreationTime property is set
        internal bool IsSetIndexCreationTime()
        {
            return this._indexCreationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// This is the resource type of the search.
        /// </para>
        /// </summary>
        public ResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property SourceResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies the source resources.
        /// </para>
        /// </summary>
        public string SourceResourceArn
        {
            get { return this._sourceResourceArn; }
            set { this._sourceResourceArn = value; }
        }

        // Check to see if SourceResourceArn property is set
        internal bool IsSetSourceResourceArn()
        {
            return this._sourceResourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// This is the status of the search job backup result.
        /// </para>
        /// </summary>
        public SearchJobState Status
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
        /// This is the status message included with the results.
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

    }
}