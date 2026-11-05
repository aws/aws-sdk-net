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

namespace Amazon.TimestreamWrite.Model
{
    /// <summary>
    /// Details about a batch load task.
    /// </summary>
    public partial class BatchLoadTaskDescription
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time when the Timestream batch load task was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DataModelConfiguration. 
        /// <para>
        /// Data model configuration for a batch load task. This contains details about where
        /// a data model for a batch load task is stored.
        /// </para>
        /// </summary>
        public DataModelConfiguration DataModelConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DataModelConfiguration property is set.
        /// </summary>
        internal bool IsSetDataModelConfiguration() => this.DataModelConfiguration != null;

        /// <summary>
        /// Gets and sets the property DataSourceConfiguration. 
        /// <para>
        /// Configuration details about the data source for a batch load task.
        /// </para>
        /// </summary>
        public DataSourceConfiguration DataSourceConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DataSourceConfiguration property is set.
        /// </summary>
        internal bool IsSetDataSourceConfiguration() => this.DataSourceConfiguration != null;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The time when the Timestream batch load task was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property ProgressReport. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        public BatchLoadProgressReport ProgressReport { get; set; }

        /// <summary>
        /// Checks to see if the ProgressReport property is set.
        /// </summary>
        internal bool IsSetProgressReport() => this.ProgressReport != null;

        /// <summary>
        /// Gets and sets the property RecordVersion. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        public long? RecordVersion { get; set; }

        /// <summary>
        /// Checks to see if the RecordVersion property is set.
        /// </summary>
        internal bool IsSetRecordVersion() => this.RecordVersion.HasValue;

        /// <summary>
        /// Gets and sets the property ReportConfiguration. 
        /// <para>
        /// Report configuration for a batch load task. This contains details about where error
        /// reports are stored.
        /// </para>
        /// </summary>
        public ReportConfiguration ReportConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ReportConfiguration property is set.
        /// </summary>
        internal bool IsSetReportConfiguration() => this.ReportConfiguration != null;

        /// <summary>
        /// Gets and sets the property ResumableUntil. 
        /// <para>
        ///  
        /// </para>
        /// </summary>
        public DateTime? ResumableUntil { get; set; }

        /// <summary>
        /// Checks to see if the ResumableUntil property is set.
        /// </summary>
        internal bool IsSetResumableUntil() => this.ResumableUntil.HasValue;

        /// <summary>
        /// Gets and sets the property TargetDatabaseName. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        public string TargetDatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the TargetDatabaseName property is set.
        /// </summary>
        internal bool IsSetTargetDatabaseName() => this.TargetDatabaseName != null;

        /// <summary>
        /// Gets and sets the property TargetTableName. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        public string TargetTableName { get; set; }

        /// <summary>
        /// Checks to see if the TargetTableName property is set.
        /// </summary>
        internal bool IsSetTargetTableName() => this.TargetTableName != null;

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        /// The ID of the batch load task.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 32)]
        public string TaskId { get; set; }

        /// <summary>
        /// Checks to see if the TaskId property is set.
        /// </summary>
        internal bool IsSetTaskId() => this.TaskId != null;

        /// <summary>
        /// Gets and sets the property TaskStatus. 
        /// <para>
        /// Status of the batch load task.
        /// </para>
        /// </summary>
        public BatchLoadStatus TaskStatus { get; set; }

        /// <summary>
        /// Checks to see if the TaskStatus property is set.
        /// </summary>
        internal bool IsSetTaskStatus() => this.TaskStatus != null;
    }
}
