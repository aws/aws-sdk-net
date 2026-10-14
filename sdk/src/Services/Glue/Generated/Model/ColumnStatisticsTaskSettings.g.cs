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
    /// The settings for a column statistics task.
    /// </summary>
    public partial class ColumnStatisticsTaskSettings
    {
        /// <summary>
        /// Gets and sets the property CatalogID. 
        /// <para>
        /// The ID of the Data Catalog in which the database resides.
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
        /// A list of column names for which to run statistics.
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
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name of the database where the table resides.
        /// </para>
        /// </summary>
        public string DatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseName property is set.
        /// </summary>
        internal bool IsSetDatabaseName() => this.DatabaseName != null;

        /// <summary>
        /// Gets and sets the property LastExecutionAttempt. 
        /// <para>
        /// The last <c>ExecutionAttempt</c> for the column statistics task run.
        /// </para>
        /// </summary>
        public ExecutionAttempt LastExecutionAttempt { get; set; }

        /// <summary>
        /// Checks to see if the LastExecutionAttempt property is set.
        /// </summary>
        internal bool IsSetLastExecutionAttempt() => this.LastExecutionAttempt != null;

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// The role used for running the column statistics.
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
        /// The percentage of data to sample.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public double? SampleSize { get; set; }

        /// <summary>
        /// Checks to see if the SampleSize property is set.
        /// </summary>
        internal bool IsSetSampleSize() => this.SampleSize.HasValue;

        /// <summary>
        /// Gets and sets the property Schedule. 
        /// <para>
        /// A schedule for running the column statistics, specified in CRON syntax.
        /// </para>
        /// </summary>
        public Schedule Schedule { get; set; }

        /// <summary>
        /// Checks to see if the Schedule property is set.
        /// </summary>
        internal bool IsSetSchedule() => this.Schedule != null;

        /// <summary>
        /// Gets and sets the property ScheduleType. 
        /// <para>
        /// The type of schedule for a column statistics task. Possible values may be <c>CRON</c>
        /// or <c>AUTO</c>.
        /// </para>
        /// </summary>
        public ScheduleType ScheduleType { get; set; }

        /// <summary>
        /// Checks to see if the ScheduleType property is set.
        /// </summary>
        internal bool IsSetScheduleType() => this.ScheduleType != null;

        /// <summary>
        /// Gets and sets the property SecurityConfiguration. 
        /// <para>
        /// Name of the security configuration that is used to encrypt CloudWatch logs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string SecurityConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SecurityConfiguration property is set.
        /// </summary>
        internal bool IsSetSecurityConfiguration() => this.SecurityConfiguration != null;

        /// <summary>
        /// Gets and sets the property SettingSource. 
        /// <para>
        /// The source of setting the column statistics task. Possible values may be <c>CATALOG</c>
        /// or <c>TABLE</c>.
        /// </para>
        /// </summary>
        public SettingSource SettingSource { get; set; }

        /// <summary>
        /// Checks to see if the SettingSource property is set.
        /// </summary>
        internal bool IsSetSettingSource() => this.SettingSource != null;

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the table for which to generate column statistics.
        /// </para>
        /// </summary>
        public string TableName { get; set; }

        /// <summary>
        /// Checks to see if the TableName property is set.
        /// </summary>
        internal bool IsSetTableName() => this.TableName != null;
    }
}
