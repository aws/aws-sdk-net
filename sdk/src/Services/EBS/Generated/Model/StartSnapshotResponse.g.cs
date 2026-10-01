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

namespace Amazon.EBS.Model
{
    /// <summary>
    /// This is the response object from the StartSnapshot operation.
    /// </summary>
    public partial class StartSnapshotResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property BlockSize. 
        /// <para>
        /// The size of the blocks in the snapshot, in bytes.
        /// </para>
        /// </summary>
        public int? BlockSize { get; set; }

        /// <summary>
        /// Checks to see if the BlockSize property is set.
        /// </summary>
        internal bool IsSetBlockSize() => this.BlockSize.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Key Management Service (KMS) key used to encrypt
        /// the snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 2048)]
        public string KmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyArn property is set.
        /// </summary>
        internal bool IsSetKmsKeyArn() => this.KmsKeyArn != null;

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The Amazon Web Services account ID of the snapshot owner.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 24)]
        public string OwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerId property is set.
        /// </summary>
        internal bool IsSetOwnerId() => this.OwnerId != null;

        /// <summary>
        /// Gets and sets the property ParentSnapshotId. 
        /// <para>
        /// The ID of the parent snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ParentSnapshotId { get; set; }

        /// <summary>
        /// Checks to see if the ParentSnapshotId property is set.
        /// </summary>
        internal bool IsSetParentSnapshotId() => this.ParentSnapshotId != null;

        /// <summary>
        /// Gets and sets the property SnapshotId. 
        /// <para>
        /// The ID of the snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotId property is set.
        /// </summary>
        internal bool IsSetSnapshotId() => this.SnapshotId != null;

        /// <summary>
        /// Gets and sets the property SseType. 
        /// <para>
        /// Reserved for future use.
        /// </para>
        /// </summary>
        public SSEType SseType { get; set; }

        /// <summary>
        /// Checks to see if the SseType property is set.
        /// </summary>
        internal bool IsSetSseType() => this.SseType != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The timestamp when the snapshot was created.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 32)]
        public Status Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags applied to the snapshot. You can specify up to 50 tags per snapshot. For
        /// more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">
        /// Tagging your Amazon EC2 resources</a> in the <i>Amazon Elastic Compute Cloud User
        /// Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VolumeSize. 
        /// <para>
        /// The size of the volume, in GiB.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public long? VolumeSize { get; set; }

        /// <summary>
        /// Checks to see if the VolumeSize property is set.
        /// </summary>
        internal bool IsSetVolumeSize() => this.VolumeSize.HasValue;
    }
}
