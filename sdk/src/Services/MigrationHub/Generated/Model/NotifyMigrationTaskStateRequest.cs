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
 * Do not modify this file. This file is generated from the AWSMigrationHub-2017-05-31.normal.json service model.
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
namespace Amazon.MigrationHub.Model
{
    /// <summary>
    /// Container for the parameters to the NotifyMigrationTaskState operation.
    /// Notifies Migration Hub of the current status, progress, or other detail regarding
    /// a migration task. This API has the following traits:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Migration tools will call the <c>NotifyMigrationTaskState</c> API to share the latest
    /// progress and status.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>MigrationTaskName</c> is used for addressing updates to the correct target.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ProgressUpdateStream</c> is used for access control and to provide a namespace
    /// for each migration tool.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class NotifyMigrationTaskStateRequest : AmazonMigrationHubRequest
    {
        private bool? _dryRun;
        private string _migrationTaskName;
        private int? _nextUpdateSeconds;
        private string _progressUpdateStream;
        private Task _task;
        private DateTime? _updateDateTime;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Optional boolean flag to indicate whether any effect should take place. Used to test
        /// if the caller has permission to make the call.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MigrationTaskName. 
        /// <para>
        /// Unique identifier that references the migration task. <i>Do not store personal data
        /// in this field.</i> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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
        /// Gets and sets the property NextUpdateSeconds. 
        /// <para>
        /// Number of seconds after the UpdateDateTime within which the Migration Hub can expect
        /// an update. If Migration Hub does not receive an update within the specified interval,
        /// then the migration task will be considered stale.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int? NextUpdateSeconds
        {
            get { return this._nextUpdateSeconds; }
            set { this._nextUpdateSeconds = value; }
        }

        // Check to see if NextUpdateSeconds property is set
        internal bool IsSetNextUpdateSeconds()
        {
            return this._nextUpdateSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProgressUpdateStream. 
        /// <para>
        /// The name of the ProgressUpdateStream. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
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
        /// Gets and sets the property Task. 
        /// <para>
        /// Information about the task's progress and status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        [AWSProperty(Required=true)]
        public DateTime? UpdateDateTime
        {
            get { return this._updateDateTime; }
            set { this._updateDateTime = value; }
        }

        // Check to see if UpdateDateTime property is set
        internal bool IsSetUpdateDateTime()
        {
            return this._updateDateTime.HasValue; 
        }

    }
}