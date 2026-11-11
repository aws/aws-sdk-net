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

namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// Describes the destination of the exported snapshot data.
    /// </summary>
    public partial class ExportDestinationConfiguration
    {
        /// <summary>
        /// Gets and sets the property DestinationEncryptionConfiguration. 
        /// <para>
        /// The encryption configuration of the exported snapshot data. If you don't specify this
        /// parameter, Managed Service for Apache Flink uses a key of type <c>AWS_OWNED_KEY</c>.
        /// If you specify a KMS key, you must specify the key ARN.
        /// </para>
        /// </summary>
        public SnapshotEncryptionConfiguration DestinationEncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DestinationEncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetDestinationEncryptionConfiguration() => this.DestinationEncryptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property DestinationS3PrefixLocation. 
        /// <para>
        /// The Amazon S3 bucket and key prefix to export the snapshot data to. Managed Service
        /// for Apache Flink writes the data under a unique prefix that it appends to the key
        /// prefix that you specify. After the export completes, use <c>DescribeSnapshotOperation</c>
        /// to get the full prefix. The bucket must be owned by your account and must be in the
        /// same Region as the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public S3PrefixLocation DestinationS3PrefixLocation { get; set; }

        /// <summary>
        /// Checks to see if the DestinationS3PrefixLocation property is set.
        /// </summary>
        internal bool IsSetDestinationS3PrefixLocation() => this.DestinationS3PrefixLocation != null;

        /// <summary>
        /// Gets and sets the property DestinationType. 
        /// <para>
        /// The type of the destination location. The only supported value is <c>S3</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public StorageLocationType DestinationType { get; set; }

        /// <summary>
        /// Checks to see if the DestinationType property is set.
        /// </summary>
        internal bool IsSetDestinationType() => this.DestinationType != null;

        /// <summary>
        /// Gets and sets the property ExportRoleArn. 
        /// <para>
        /// The ARN of the IAM role that Managed Service for Apache Flink assumes to write the
        /// snapshot data to the destination location. For information about the permissions that
        /// this role requires, see <a href="https://docs.aws.amazon.com/managed-flink/latest/java/snapshots-import-export.html">Import
        /// and export</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string ExportRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ExportRoleArn property is set.
        /// </summary>
        internal bool IsSetExportRoleArn() => this.ExportRoleArn != null;
    }
}
