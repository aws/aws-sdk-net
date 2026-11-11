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
    /// Container for the parameters to the CreateBatchLoadTask operation. Creates a new Timestream
    /// batch load task. A batch load task processes data from a CSV source in an S3 location
    /// and writes to a Timestream table. A mapping from source to target is defined in a
    /// batch load task. Errors and events are written to a report at an S3 location. For
    /// the report, if the KMS key is not specified, the report will be encrypted with an
    /// S3 managed key when <c>SSE_S3</c> is the option. Otherwise an error is thrown. For
    /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-cmk">Amazon
    /// Web Services managed keys</a>. <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/ts-limits.html">Service
    /// quotas apply</a>. For details, see <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/code-samples.create-batch-load.html">code
    /// sample</a>.
    /// </summary>
    public partial class CreateBatchLoadTaskRequest : AmazonTimestreamWriteRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DataModelConfiguration.
        /// </summary>
        public DataModelConfiguration DataModelConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DataModelConfiguration property is set.
        /// </summary>
        internal bool IsSetDataModelConfiguration() => this.DataModelConfiguration != null;

        /// <summary>
        /// Gets and sets the property DataSourceConfiguration. 
        /// <para>
        /// Defines configuration details about the data source for a batch load task.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DataSourceConfiguration DataSourceConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DataSourceConfiguration property is set.
        /// </summary>
        internal bool IsSetDataSourceConfiguration() => this.DataSourceConfiguration != null;

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
        /// </summary>
        [AWSProperty(Required = true)]
        public ReportConfiguration ReportConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ReportConfiguration property is set.
        /// </summary>
        internal bool IsSetReportConfiguration() => this.ReportConfiguration != null;

        /// <summary>
        /// Gets and sets the property TargetDatabaseName. 
        /// <para>
        /// Target Timestream database for a batch load task.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TargetDatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the TargetDatabaseName property is set.
        /// </summary>
        internal bool IsSetTargetDatabaseName() => this.TargetDatabaseName != null;

        /// <summary>
        /// Gets and sets the property TargetTableName. 
        /// <para>
        /// Target Timestream table for a batch load task.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TargetTableName { get; set; }

        /// <summary>
        /// Checks to see if the TargetTableName property is set.
        /// </summary>
        internal bool IsSetTargetTableName() => this.TargetTableName != null;
    }
}
