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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// The object that shows the details of the materialized view refresh task run.
    /// </summary>
    public partial class MaterializedViewRefreshTaskRun
    {
        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The ID of the Data Catalog where the table resides. If none is supplied, the account
        /// ID is used by default.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string CatalogId { get; set; }

        /// <summary>
        /// Checks to see if the CatalogId property is set.
        /// </summary>
        internal bool IsSetCatalogId() => this.CatalogId != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time that this task was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property CustomerId. 
        /// <para>
        /// The Amazon Web Services account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 12)]
        public string CustomerId { get; set; }

        /// <summary>
        /// Checks to see if the CustomerId property is set.
        /// </summary>
        internal bool IsSetCustomerId() => this.CustomerId != null;

        /// <summary>
        /// Gets and sets the property DPUSeconds. 
        /// <para>
        /// The calculated DPU usage in seconds for all autoscaled workers.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public double? DPUSeconds { get; set; }

        /// <summary>
        /// Checks to see if the DPUSeconds property is set.
        /// </summary>
        internal bool IsSetDPUSeconds() => this.DPUSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The database where the table resides.
        /// </para>
        /// </summary>
        public string DatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseName property is set.
        /// </summary>
        internal bool IsSetDatabaseName() => this.DatabaseName != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end time of the task.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// The error message for the job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property LastUpdated. 
        /// <para>
        /// The last point in time when this task was modified.
        /// </para>
        /// </summary>
        public DateTime? LastUpdated { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdated property is set.
        /// </summary>
        internal bool IsSetLastUpdated() => this.LastUpdated.HasValue;

        /// <summary>
        /// Gets and sets the property MaterializedViewRefreshTaskRunId. 
        /// <para>
        /// The identifier of the materialized view refresh task run.
        /// </para>
        /// </summary>
        public string MaterializedViewRefreshTaskRunId { get; set; }

        /// <summary>
        /// Checks to see if the MaterializedViewRefreshTaskRunId property is set.
        /// </summary>
        internal bool IsSetMaterializedViewRefreshTaskRunId() => this.MaterializedViewRefreshTaskRunId != null;

        /// <summary>
        /// Gets and sets the property ProcessedBytes. 
        /// <para>
        /// The number of bytes the refresh task run has scanned to refresh the materialized view.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? ProcessedBytes { get; set; }

        /// <summary>
        /// Checks to see if the ProcessedBytes property is set.
        /// </summary>
        internal bool IsSetProcessedBytes() => this.ProcessedBytes.HasValue;

        /// <summary>
        /// Gets and sets the property RefreshType. 
        /// <para>
        /// The type of the refresh task run. Either FULL or INCREMENTAL.
        /// </para>
        /// </summary>
        public MaterializedViewRefreshType RefreshType { get; set; }

        /// <summary>
        /// Checks to see if the RefreshType property is set.
        /// </summary>
        internal bool IsSetRefreshType() => this.RefreshType != null;

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// The IAM role that the service assumes to run the materialized view refresh task.
        /// </para>
        /// </summary>
        public string Role { get; set; }

        /// <summary>
        /// Checks to see if the Role property is set.
        /// </summary>
        internal bool IsSetRole() => this.Role != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time of the task.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the task run.
        /// </para>
        /// </summary>
        public MaterializedViewRefreshState Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the materialized view.
        /// </para>
        /// </summary>
        public string TableName { get; set; }

        /// <summary>
        /// Checks to see if the TableName property is set.
        /// </summary>
        internal bool IsSetTableName() => this.TableName != null;
    }
}
