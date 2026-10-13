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
    /// The object that shows the details of the column stats run.
    /// </summary>
    public partial class ColumnStatisticsTaskRun
    {
        /// <summary>
        /// Gets and sets the property CatalogID. 
        /// <para>
        /// The ID of the Data Catalog where the table resides. If none is supplied, the Amazon
        /// Web Services account ID is used by default.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string CatalogID { get; set; }

        /// <summary>
        /// Checks to see if the CatalogID property is set.
        /// </summary>
        internal bool IsSetCatalogID() => this.CatalogID != null;

        /// <summary>
        /// Gets and sets the property ColumnNameList. 
        /// <para>
        /// A list of the column names. If none is supplied, all column names for the table will
        /// be used by default.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ColumnNameList { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ColumnNameList property is set.
        /// </summary>
        internal bool IsSetColumnNameList() => this.ColumnNameList != null && (this.ColumnNameList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ColumnStatisticsTaskRunId. 
        /// <para>
        /// The identifier for the particular column statistics task run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ColumnStatisticsTaskRunId { get; set; }

        /// <summary>
        /// Checks to see if the ColumnStatisticsTaskRunId property is set.
        /// </summary>
        internal bool IsSetColumnStatisticsTaskRunId() => this.ColumnStatisticsTaskRunId != null;

        /// <summary>
        /// Gets and sets the property ComputationType. 
        /// <para>
        /// The type of column statistics computation.
        /// </para>
        /// </summary>
        public ComputationType ComputationType { get; set; }

        /// <summary>
        /// Checks to see if the ComputationType property is set.
        /// </summary>
        internal bool IsSetComputationType() => this.ComputationType != null;

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
        /// Gets and sets the property NumberOfWorkers. 
        /// <para>
        /// The number of workers used to generate column statistics. The job is preconfigured
        /// to autoscale up to 25 instances.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? NumberOfWorkers { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfWorkers property is set.
        /// </summary>
        internal bool IsSetNumberOfWorkers() => this.NumberOfWorkers.HasValue;

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// The IAM role that the service assumes to generate statistics.
        /// </para>
        /// </summary>
        public string Role { get; set; }

        /// <summary>
        /// Checks to see if the Role property is set.
        /// </summary>
        internal bool IsSetRole() => this.Role != null;

        /// <summary>
        /// Gets and sets the property SampleSize. 
        /// <para>
        /// The percentage of rows used to generate statistics. If none is supplied, the entire
        /// table will be used to generate stats.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public double? SampleSize { get; set; }

        /// <summary>
        /// Checks to see if the SampleSize property is set.
        /// </summary>
        internal bool IsSetSampleSize() => this.SampleSize.HasValue;

        /// <summary>
        /// Gets and sets the property SecurityConfiguration. 
        /// <para>
        /// Name of the security configuration that is used to encrypt CloudWatch logs for the
        /// column stats task run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string SecurityConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SecurityConfiguration property is set.
        /// </summary>
        internal bool IsSetSecurityConfiguration() => this.SecurityConfiguration != null;

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
        public ColumnStatisticsState Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the table for which column statistics is generated.
        /// </para>
        /// </summary>
        public string TableName { get; set; }

        /// <summary>
        /// Checks to see if the TableName property is set.
        /// </summary>
        internal bool IsSetTableName() => this.TableName != null;

        /// <summary>
        /// Gets and sets the property WorkerType. 
        /// <para>
        /// The type of workers being used for generating stats. The default is <c>g.1x</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string WorkerType { get; set; }

        /// <summary>
        /// Checks to see if the WorkerType property is set.
        /// </summary>
        internal bool IsSetWorkerType() => this.WorkerType != null;
    }
}
