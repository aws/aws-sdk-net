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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the NotifyMigrationTaskState operation. Notifies Migration
    /// Hub of the current status, progress, or other detail regarding a migration task. This
    /// API has the following traits: <ul> <li> <para> Migration tools will call the <c>NotifyMigrationTaskState</c>
    /// API to share the latest progress and status. </para> </li> <li> <para> <c>MigrationTaskName</c>
    /// is used for addressing updates to the correct target. </para> </li> <li> <para> <c>ProgressUpdateStream</c>
    /// is used for access control and to provide a namespace for each migration tool. </para>
    /// </li> </ul>
    /// </summary>
    public partial class NotifyMigrationTaskStateRequest : AmazonMigrationHubRequest
    {
        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Optional boolean flag to indicate whether any effect should take place. Used to test
        /// if the caller has permission to make the call.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property MigrationTaskName. 
        /// <para>
        /// Unique identifier that references the migration task. <i>Do not store personal data
        /// in this field.</i> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string MigrationTaskName { get; set; }

        /// <summary>
        /// Checks to see if the MigrationTaskName property is set.
        /// </summary>
        internal bool IsSetMigrationTaskName() => this.MigrationTaskName != null;

        /// <summary>
        /// Gets and sets the property NextUpdateSeconds. 
        /// <para>
        /// Number of seconds after the UpdateDateTime within which the Migration Hub can expect
        /// an update. If Migration Hub does not receive an update within the specified interval,
        /// then the migration task will be considered stale.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? NextUpdateSeconds { get; set; }

        /// <summary>
        /// Checks to see if the NextUpdateSeconds property is set.
        /// </summary>
        internal bool IsSetNextUpdateSeconds() => this.NextUpdateSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property ProgressUpdateStream. 
        /// <para>
        /// The name of the ProgressUpdateStream. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 50)]
        public string ProgressUpdateStream { get; set; }

        /// <summary>
        /// Checks to see if the ProgressUpdateStream property is set.
        /// </summary>
        internal bool IsSetProgressUpdateStream() => this.ProgressUpdateStream != null;

        /// <summary>
        /// Gets and sets the property Task. 
        /// <para>
        /// Information about the task's progress and status.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Task Task { get; set; }

        /// <summary>
        /// Checks to see if the Task property is set.
        /// </summary>
        internal bool IsSetTask() => this.Task != null;

        /// <summary>
        /// Gets and sets the property UpdateDateTime. 
        /// <para>
        /// The timestamp when the task was gathered.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdateDateTime { get; set; }

        /// <summary>
        /// Checks to see if the UpdateDateTime property is set.
        /// </summary>
        internal bool IsSetUpdateDateTime() => this.UpdateDateTime.HasValue;
    }
}
