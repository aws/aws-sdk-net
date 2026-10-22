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

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// This object provides a collection of statistics about a serverless replication.
    /// </summary>
    public partial class ReplicationStats
    {
        /// <summary>
        /// Gets and sets the property ElapsedTimeMillis. 
        /// <para>
        /// The elapsed time of the replication, in milliseconds.
        /// </para>
        /// </summary>
        public long? ElapsedTimeMillis { get; set; }

        /// <summary>
        /// Checks to see if the ElapsedTimeMillis property is set.
        /// </summary>
        internal bool IsSetElapsedTimeMillis() => this.ElapsedTimeMillis.HasValue;

        /// <summary>
        /// Gets and sets the property FreshStartDate. 
        /// <para>
        /// The date the replication was started either with a fresh start or a target reload.
        /// </para>
        /// </summary>
        public DateTime? FreshStartDate { get; set; }

        /// <summary>
        /// Checks to see if the FreshStartDate property is set.
        /// </summary>
        internal bool IsSetFreshStartDate() => this.FreshStartDate.HasValue;

        /// <summary>
        /// Gets and sets the property FullLoadFinishDate. 
        /// <para>
        /// The date the replication full load was finished.
        /// </para>
        /// </summary>
        public DateTime? FullLoadFinishDate { get; set; }

        /// <summary>
        /// Checks to see if the FullLoadFinishDate property is set.
        /// </summary>
        internal bool IsSetFullLoadFinishDate() => this.FullLoadFinishDate.HasValue;

        /// <summary>
        /// Gets and sets the property FullLoadProgressPercent. 
        /// <para>
        /// The percent complete for the full load serverless replication.
        /// </para>
        /// </summary>
        public int? FullLoadProgressPercent { get; set; }

        /// <summary>
        /// Checks to see if the FullLoadProgressPercent property is set.
        /// </summary>
        internal bool IsSetFullLoadProgressPercent() => this.FullLoadProgressPercent.HasValue;

        /// <summary>
        /// Gets and sets the property FullLoadStartDate. 
        /// <para>
        /// The date the replication full load was started.
        /// </para>
        /// </summary>
        public DateTime? FullLoadStartDate { get; set; }

        /// <summary>
        /// Checks to see if the FullLoadStartDate property is set.
        /// </summary>
        internal bool IsSetFullLoadStartDate() => this.FullLoadStartDate.HasValue;

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The date the replication is scheduled to start.
        /// </para>
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Checks to see if the StartDate property is set.
        /// </summary>
        internal bool IsSetStartDate() => this.StartDate.HasValue;

        /// <summary>
        /// Gets and sets the property StopDate. 
        /// <para>
        /// The date the replication was stopped.
        /// </para>
        /// </summary>
        public DateTime? StopDate { get; set; }

        /// <summary>
        /// Checks to see if the StopDate property is set.
        /// </summary>
        internal bool IsSetStopDate() => this.StopDate.HasValue;

        /// <summary>
        /// Gets and sets the property TablesErrored. 
        /// <para>
        /// The number of errors that have occured for this replication.
        /// </para>
        /// </summary>
        public int? TablesErrored { get; set; }

        /// <summary>
        /// Checks to see if the TablesErrored property is set.
        /// </summary>
        internal bool IsSetTablesErrored() => this.TablesErrored.HasValue;

        /// <summary>
        /// Gets and sets the property TablesLoaded. 
        /// <para>
        /// The number of tables loaded for this replication.
        /// </para>
        /// </summary>
        public int? TablesLoaded { get; set; }

        /// <summary>
        /// Checks to see if the TablesLoaded property is set.
        /// </summary>
        internal bool IsSetTablesLoaded() => this.TablesLoaded.HasValue;

        /// <summary>
        /// Gets and sets the property TablesLoading. 
        /// <para>
        /// The number of tables currently loading for this replication.
        /// </para>
        /// </summary>
        public int? TablesLoading { get; set; }

        /// <summary>
        /// Checks to see if the TablesLoading property is set.
        /// </summary>
        internal bool IsSetTablesLoading() => this.TablesLoading.HasValue;

        /// <summary>
        /// Gets and sets the property TablesQueued. 
        /// <para>
        /// The number of tables queued for this replication.
        /// </para>
        /// </summary>
        public int? TablesQueued { get; set; }

        /// <summary>
        /// Checks to see if the TablesQueued property is set.
        /// </summary>
        internal bool IsSetTablesQueued() => this.TablesQueued.HasValue;
    }
}
