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
 * Do not modify this file. This file is generated from the timestream-write-2018-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.TimestreamWrite.Model
{
    /// <summary>
    /// Container for the parameters to the CreateBatchLoadTask operation.
    /// Creates a new Timestream batch load task. A batch load task processes data from a
    /// CSV source in an S3 location and writes to a Timestream table. A mapping from source
    /// to target is defined in a batch load task. Errors and events are written to a report
    /// at an S3 location. For the report, if the KMS key is not specified, the batch load
    /// task will be encrypted with a Timestream managed KMS key located in your account.
    /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-cmk">Amazon
    /// Web Services managed keys</a>. <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/ts-limits.html">Service
    /// quotas apply</a>. For details, see <a href="https://docs.aws.amazon.com/timestream/latest/developerguide/code-samples.create-batch-load.html">code
    /// sample</a>.
    /// </summary>
    public partial class CreateBatchLoadTaskRequest : AmazonTimestreamWriteRequest
    {
        private string _clientToken;
        private DataModelConfiguration _dataModelConfiguration;
        private DataSourceConfiguration _dataSourceConfiguration;
        private long? _recordVersion;
        private ReportConfiguration _reportConfiguration;
        private string _targetDatabaseName;
        private string _targetTableName;

        /// <summary>
        /// Gets and sets the property ClientToken.
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property DataModelConfiguration.
        /// </summary>
        public DataModelConfiguration DataModelConfiguration
        {
            get { return this._dataModelConfiguration; }
            set { this._dataModelConfiguration = value; }
        }

        // Check to see if DataModelConfiguration property is set
        internal bool IsSetDataModelConfiguration()
        {
            return this._dataModelConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property DataSourceConfiguration. 
        /// <para>
        /// Defines configuration details about the data source for a batch load task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataSourceConfiguration DataSourceConfiguration
        {
            get { return this._dataSourceConfiguration; }
            set { this._dataSourceConfiguration = value; }
        }

        // Check to see if DataSourceConfiguration property is set
        internal bool IsSetDataSourceConfiguration()
        {
            return this._dataSourceConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RecordVersion.
        /// </summary>
        public long RecordVersion
        {
            get { return this._recordVersion.GetValueOrDefault(); }
            set { this._recordVersion = value; }
        }

        // Check to see if RecordVersion property is set
        internal bool IsSetRecordVersion()
        {
            return this._recordVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReportConfiguration.
        /// </summary>
        [AWSProperty(Required=true)]
        public ReportConfiguration ReportConfiguration
        {
            get { return this._reportConfiguration; }
            set { this._reportConfiguration = value; }
        }

        // Check to see if ReportConfiguration property is set
        internal bool IsSetReportConfiguration()
        {
            return this._reportConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property TargetDatabaseName. 
        /// <para>
        /// Target Timestream database for a batch load task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TargetDatabaseName
        {
            get { return this._targetDatabaseName; }
            set { this._targetDatabaseName = value; }
        }

        // Check to see if TargetDatabaseName property is set
        internal bool IsSetTargetDatabaseName()
        {
            return this._targetDatabaseName != null;
        }

        /// <summary>
        /// Gets and sets the property TargetTableName. 
        /// <para>
        /// Target Timestream table for a batch load task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TargetTableName
        {
            get { return this._targetTableName; }
            set { this._targetTableName = value; }
        }

        // Check to see if TargetTableName property is set
        internal bool IsSetTargetTableName()
        {
            return this._targetTableName != null;
        }

    }
}