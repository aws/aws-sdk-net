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
    /// Describes the source of the savepoint data to import.
    /// </summary>
    public partial class ImportSourceConfiguration
    {
        /// <summary>
        /// Gets and sets the property ImportRoleArn. 
        /// <para>
        /// The ARN of the IAM role that Managed Service for Apache Flink assumes to read the
        /// savepoint data from the source location. For information about the permissions that
        /// this role requires, see <a href="https://docs.aws.amazon.com/managed-flink/latest/java/snapshots-import-export.html">Import
        /// and export</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string ImportRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ImportRoleArn property is set.
        /// </summary>
        internal bool IsSetImportRoleArn() => this.ImportRoleArn != null;

        /// <summary>
        /// Gets and sets the property SourceEncryptionConfiguration. 
        /// <para>
        /// The encryption configuration of the savepoint data at the source location. If you
        /// don't specify this parameter, Managed Service for Apache Flink uses a key of type
        /// <c>AWS_OWNED_KEY</c>. If you specify a KMS key, you must specify the key ARN.
        /// </para>
        /// </summary>
        public SnapshotEncryptionConfiguration SourceEncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SourceEncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetSourceEncryptionConfiguration() => this.SourceEncryptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property SourceS3PrefixLocation. 
        /// <para>
        /// The Amazon S3 bucket and key prefix that contain the savepoint data to import. The
        /// bucket must be owned by your account and must be in the same Region as the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public S3PrefixLocation SourceS3PrefixLocation { get; set; }

        /// <summary>
        /// Checks to see if the SourceS3PrefixLocation property is set.
        /// </summary>
        internal bool IsSetSourceS3PrefixLocation() => this.SourceS3PrefixLocation != null;

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// The type of the source location. The only supported value is <c>S3</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public StorageLocationType SourceType { get; set; }

        /// <summary>
        /// Checks to see if the SourceType property is set.
        /// </summary>
        internal bool IsSetSourceType() => this.SourceType != null;
    }
}
