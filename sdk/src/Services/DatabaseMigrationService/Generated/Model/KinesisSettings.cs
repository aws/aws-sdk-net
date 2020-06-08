/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Provides information that describes an Amazon Kinesis Data Stream endpoint. This information
    /// includes the output format of records applied to the endpoint and details of transaction
    /// and control table data information.
    /// </summary>
    public partial class KinesisSettings
    {
        private bool? _includeControlDetails;
        private bool? _includePartitionValue;
        private bool? _includeTableAlterOperations;
        private bool? _includeTransactionDetails;
        private MessageFormatValue _messageFormat;
        private bool? _partitionIncludeSchemaTable;
        private string _serviceAccessRoleArn;
        private string _streamArn;

        /// <summary>
        /// Gets and sets the property IncludeControlDetails. 
        /// <para>
        /// Shows detailed control information for table definition, column definition, and table
        /// and column changes in the Kinesis message output. The default is <code>False</code>.
        /// </para>
        /// </summary>
        public bool IncludeControlDetails
        {
            get { return this._includeControlDetails.GetValueOrDefault(); }
            set { this._includeControlDetails = value; }
        }

        // Check to see if IncludeControlDetails property is set
        internal bool IsSetIncludeControlDetails()
        {
            return this._includeControlDetails.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncludePartitionValue. 
        /// <para>
        /// Shows the partition value within the Kinesis message output, unless the partition
        /// type is <code>schema-table-type</code>. The default is <code>False</code>.
        /// </para>
        /// </summary>
        public bool IncludePartitionValue
        {
            get { return this._includePartitionValue.GetValueOrDefault(); }
            set { this._includePartitionValue = value; }
        }

        // Check to see if IncludePartitionValue property is set
        internal bool IsSetIncludePartitionValue()
        {
            return this._includePartitionValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncludeTableAlterOperations. 
        /// <para>
        /// Includes any data definition language (DDL) operations that change the table in the
        /// control data, such as <code>rename-table</code>, <code>drop-table</code>, <code>add-column</code>,
        /// <code>drop-column</code>, and <code>rename-column</code>. The default is <code>False</code>.
        /// </para>
        /// </summary>
        public bool IncludeTableAlterOperations
        {
            get { return this._includeTableAlterOperations.GetValueOrDefault(); }
            set { this._includeTableAlterOperations = value; }
        }

        // Check to see if IncludeTableAlterOperations property is set
        internal bool IsSetIncludeTableAlterOperations()
        {
            return this._includeTableAlterOperations.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncludeTransactionDetails. 
        /// <para>
        /// Provides detailed transaction information from the source database. This information
        /// includes a commit timestamp, a log position, and values for <code>transaction_id</code>,
        /// previous <code>transaction_id</code>, and <code>transaction_record_id</code> (the
        /// record offset within a transaction). The default is <code>False</code>.
        /// </para>
        /// </summary>
        public bool IncludeTransactionDetails
        {
            get { return this._includeTransactionDetails.GetValueOrDefault(); }
            set { this._includeTransactionDetails = value; }
        }

        // Check to see if IncludeTransactionDetails property is set
        internal bool IsSetIncludeTransactionDetails()
        {
            return this._includeTransactionDetails.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MessageFormat. 
        /// <para>
        /// The output format for the records created on the endpoint. The message format is <code>JSON</code>
        /// (default) or <code>JSON_UNFORMATTED</code> (a single line with no tab).
        /// </para>
        /// </summary>
        public MessageFormatValue MessageFormat
        {
            get { return this._messageFormat; }
            set { this._messageFormat = value; }
        }

        // Check to see if MessageFormat property is set
        internal bool IsSetMessageFormat()
        {
            return this._messageFormat != null;
        }

        /// <summary>
        /// Gets and sets the property PartitionIncludeSchemaTable. 
        /// <para>
        /// Prefixes schema and table names to partition values, when the partition type is <code>primary-key-type</code>.
        /// Doing this increases data distribution among Kinesis shards. For example, suppose
        /// that a SysBench schema has thousands of tables and each table has only limited range
        /// for a primary key. In this case, the same primary key is sent from thousands of tables
        /// to the same shard, which causes throttling. The default is <code>False</code>.
        /// </para>
        /// </summary>
        public bool PartitionIncludeSchemaTable
        {
            get { return this._partitionIncludeSchemaTable.GetValueOrDefault(); }
            set { this._partitionIncludeSchemaTable = value; }
        }

        // Check to see if PartitionIncludeSchemaTable property is set
        internal bool IsSetPartitionIncludeSchemaTable()
        {
            return this._partitionIncludeSchemaTable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServiceAccessRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the AWS Identity and Access Management (IAM) role
        /// that AWS DMS uses to write to the Kinesis data stream.
        /// </para>
        /// </summary>
        public string ServiceAccessRoleArn
        {
            get { return this._serviceAccessRoleArn; }
            set { this._serviceAccessRoleArn = value; }
        }

        // Check to see if ServiceAccessRoleArn property is set
        internal bool IsSetServiceAccessRoleArn()
        {
            return this._serviceAccessRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property StreamArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the Amazon Kinesis Data Streams endpoint.
        /// </para>
        /// </summary>
        public string StreamArn
        {
            get { return this._streamArn; }
            set { this._streamArn = value; }
        }

        // Check to see if StreamArn property is set
        internal bool IsSetStreamArn()
        {
            return this._streamArn != null;
        }

    }
}