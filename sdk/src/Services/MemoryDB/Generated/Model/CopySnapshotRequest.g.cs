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

namespace Amazon.MemoryDB.Model
{
    /// <summary>
    /// Container for the parameters to the CopySnapshot operation. Makes a copy of an existing
    /// snapshot.
    /// </summary>
    public partial class CopySnapshotRequest : AmazonMemoryDBRequest
    {
        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ID of the KMS key used to encrypt the target snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property SourceSnapshotName. 
        /// <para>
        /// The name of an existing snapshot from which to make a copy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SourceSnapshotName { get; set; }

        /// <summary>
        /// Checks to see if the SourceSnapshotName property is set.
        /// </summary>
        internal bool IsSetSourceSnapshotName() => this.SourceSnapshotName != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags to be added to this resource. A tag is a key-value pair. A tag key
        /// must be accompanied by a tag value, although null is accepted.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetBucket. 
        /// <para>
        /// The Amazon S3 bucket to which the snapshot is exported. This parameter is used only
        /// when exporting a snapshot for external access. When using this parameter to export
        /// a snapshot, be sure MemoryDB has the needed permissions to this S3 bucket. For more
        /// information, see <a href="https://docs.aws.amazon.com/MemoryDB/latest/devguide/snapshots-exporting.html">Step
        /// 2: Grant MemoryDB Access to Your Amazon S3 Bucket</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string TargetBucket { get; set; }

        /// <summary>
        /// Checks to see if the TargetBucket property is set.
        /// </summary>
        internal bool IsSetTargetBucket() => this.TargetBucket != null;

        /// <summary>
        /// Gets and sets the property TargetSnapshotName. 
        /// <para>
        /// A name for the snapshot copy. MemoryDB does not permit overwriting a snapshot, therefore
        /// this name must be unique within its context - MemoryDB or an Amazon S3 bucket if exporting.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TargetSnapshotName { get; set; }

        /// <summary>
        /// Checks to see if the TargetSnapshotName property is set.
        /// </summary>
        internal bool IsSetTargetSnapshotName() => this.TargetSnapshotName != null;
    }
}
