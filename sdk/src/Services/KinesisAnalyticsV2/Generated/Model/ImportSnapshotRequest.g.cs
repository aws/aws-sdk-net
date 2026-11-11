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
    /// Container for the parameters to the ImportSnapshot operation. Imports an Apache Flink
    /// savepoint from an Amazon S3 location as an enhanced snapshot. Managed Service for
    /// Apache Flink assumes the IAM role that you specify in <c>ImportSourceConfiguration</c>
    /// to read the savepoint data. <para> This operation is asynchronous. The response returns
    /// the snapshot ARN with the <c>CREATING</c> status. To track the progress of the import,
    /// use <c>DescribeSnapshotOperation</c>. </para> <para> For more information, see <a
    /// href="https://docs.aws.amazon.com/managed-flink/latest/java/snapshots-import-export.html">Import
    /// and export</a>. </para>
    /// </summary>
    public partial class ImportSnapshotRequest : AmazonKinesisAnalyticsV2Request
    {
        /// <summary>
        /// Gets and sets the property DestinationEncryptionConfiguration. 
        /// <para>
        /// The encryption configuration of the imported snapshot. If you don't specify this parameter,
        /// the snapshot is encrypted using a key of type <c>AWS_OWNED_KEY</c>. If you specify
        /// a KMS key, you must specify the key ARN.
        /// </para>
        /// </summary>
        public SnapshotEncryptionConfiguration DestinationEncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DestinationEncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetDestinationEncryptionConfiguration() => this.DestinationEncryptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property ImportSourceConfiguration. 
        /// <para>
        /// Describes the location, IAM role, and encryption configuration of the savepoint data
        /// to import.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ImportSourceConfiguration ImportSourceConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ImportSourceConfiguration property is set.
        /// </summary>
        internal bool IsSetImportSourceConfiguration() => this.ImportSourceConfiguration != null;

        /// <summary>
        /// Gets and sets the property SnapshotDescription. 
        /// <para>
        /// A summary description of the snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string SnapshotDescription { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotDescription property is set.
        /// </summary>
        internal bool IsSetSnapshotDescription() => this.SnapshotDescription != null;

        /// <summary>
        /// Gets and sets the property SnapshotFormat. 
        /// <para>
        /// The format of the snapshot being imported.
        /// </para>
        /// </summary>
        public SnapshotFormat SnapshotFormat { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotFormat property is set.
        /// </summary>
        internal bool IsSetSnapshotFormat() => this.SnapshotFormat != null;

        /// <summary>
        /// Gets and sets the property SnapshotName. 
        /// <para>
        /// The name of the enhanced snapshot. The name must be unique among the snapshots in
        /// your account and Region. You can't reuse the name of an existing snapshot, including
        /// a snapshot in the <c>FAILED</c> status, until you delete that snapshot. Names that
        /// begin with <c>SYSTEMSNAPSHOT</c> are reserved.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string SnapshotName { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotName property is set.
        /// </summary>
        internal bool IsSetSnapshotName() => this.SnapshotName != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of one or more tags to assign to the snapshot. A tag is a key-value pair that
        /// identifies a snapshot. For more information, see <a href="https://docs.aws.amazon.com/kinesisanalytics/latest/java/how-tagging.html">Using
        /// Tagging</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
