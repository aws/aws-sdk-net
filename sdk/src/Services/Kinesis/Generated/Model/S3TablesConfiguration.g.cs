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

namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// Specifies a destination streaming table on Apache Iceberg.
    /// </summary>
    public partial class S3TablesConfiguration
    {
        /// <summary>
        /// Gets and sets the property CompressionType. 
        /// <para>
        /// The compression applied to Parquet data files. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>NONE</c> - No compression.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ZSTD</c> - Zstandard compression.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SNAPPY</c> - Snappy compression.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public S3TablesCompressionType CompressionType { get; set; }

        /// <summary>
        /// Checks to see if the CompressionType property is set.
        /// </summary>
        internal bool IsSetCompressionType() => this.CompressionType != null;

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace (database) of the destination table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Namespace { get; set; }

        /// <summary>
        /// Checks to see if the Namespace property is set.
        /// </summary>
        internal bool IsSetNamespace() => this.Namespace != null;

        /// <summary>
        /// Gets and sets the property PartitionSpec. 
        /// <para>
        /// The partitioning specification for the destination table.
        /// </para>
        /// </summary>
        public PartitionSpec PartitionSpec { get; set; }

        /// <summary>
        /// Checks to see if the PartitionSpec property is set.
        /// </summary>
        internal bool IsSetPartitionSpec() => this.PartitionSpec != null;

        /// <summary>
        /// Gets and sets the property TableBucketARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon S3 table bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string TableBucketARN { get; set; }

        /// <summary>
        /// Checks to see if the TableBucketARN property is set.
        /// </summary>
        internal bool IsSetTableBucketARN() => this.TableBucketARN != null;

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the destination table. Amazon Kinesis Data Streams creates this table
        /// in the specified table bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string TableName { get; set; }

        /// <summary>
        /// Checks to see if the TableName property is set.
        /// </summary>
        internal bool IsSetTableName() => this.TableName != null;
    }
}
