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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CopySnapshot operation. Creates an exact copy
    /// of an Amazon EBS snapshot. <para> The location of the source snapshot determines whether
    /// you can copy it or not, and the allowed destinations for the snapshot copy. </para>
    /// <ul> <li> <para> If the source snapshot is in a Region, you can copy it within that
    /// Region, to another Region, to an Outpost associated with that Region, or to a Local
    /// Zone in that Region. </para> </li> <li> <para> If the source snapshot is in a Local
    /// Zone, you can copy it within that Local Zone, to another Local Zone in the same zone
    /// group, or to the parent Region of the Local Zone. </para> </li> <li> <para> If the
    /// source snapshot is on an Outpost, you can't copy it. </para> </li> </ul> <para> When
    /// copying snapshots to a Region, the encryption outcome for the snapshot copy depends
    /// on the Amazon EBS encryption by default setting for the destination Region, the encryption
    /// status of the source snapshot, and the encryption parameters you specify in the request.
    /// For more information, see <a href="https://docs.aws.amazon.com/ebs/latest/userguide/ebs-copy-snapshot.html#creating-encrypted-snapshots">
    /// Encryption and snapshot copying</a>. </para> <para> Snapshots copied to an Outpost
    /// must be encrypted. Unencrypted snapshots are not supported on Outposts. For more information,
    /// <a href="https://docs.aws.amazon.com/ebs/latest/userguide/snapshots-outposts.html#considerations">
    /// Amazon EBS local snapshots on Outposts</a>. </para> <note> <para> Snapshots copies
    /// have an arbitrary source volume ID. Do not use this volume ID for any purpose. </para>
    /// </note> <para> For more information, see <a href="https://docs.aws.amazon.com/ebs/latest/userguide/ebs-copy-snapshot.html">Copy
    /// an Amazon EBS snapshot</a> in the <i>Amazon EBS User Guide</i>. </para>
    /// </summary>
    public partial class CopySnapshotRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property CompletionDurationMinutes. <note> 
        /// <para>
        /// Not supported when copying snapshots to or from Local Zones or Outposts.
        /// </para>
        ///  </note> 
        /// <para>
        /// Specify a completion duration, in 15 minute increments, to initiate a time-based snapshot
        /// copy. Time-based snapshot copy operations complete within the specified duration.
        /// For more information, see <a href="https://docs.aws.amazon.com/ebs/latest/userguide/time-based-copies.html">
        /// Time-based copies</a>.
        /// </para>
        ///  
        /// <para>
        /// If you do not specify a value, the snapshot copy operation is completed on a best-effort
        /// basis.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2880)]
        public int? CompletionDurationMinutes { get; set; }

        /// <summary>
        /// Checks to see if the CompletionDurationMinutes property is set.
        /// </summary>
        internal bool IsSetCompletionDurationMinutes() => this.CompletionDurationMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the EBS snapshot.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DestinationAvailabilityZone. 
        /// <para>
        /// The Local Zone, for example, <c>cn-north-1-pkx-1a</c> to which to copy the snapshot.
        /// </para>
        ///  <note> 
        /// <para>
        /// Only supported when copying a snapshot to a Local Zone.
        /// </para>
        ///  </note>
        /// </summary>
        public string DestinationAvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the DestinationAvailabilityZone property is set.
        /// </summary>
        internal bool IsSetDestinationAvailabilityZone() => this.DestinationAvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property DestinationOutpostArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Outpost to which to copy the snapshot.
        /// </para>
        ///  <note> 
        /// <para>
        /// Only supported when copying a snapshot to an Outpost.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/ebs/latest/userguide/snapshots-outposts.html#copy-snapshots">
        /// Copy snapshots from an Amazon Web Services Region to an Outpost</a> in the <i>Amazon
        /// EBS User Guide</i>.
        /// </para>
        /// </summary>
        public string DestinationOutpostArn { get; set; }

        /// <summary>
        /// Checks to see if the DestinationOutpostArn property is set.
        /// </summary>
        internal bool IsSetDestinationOutpostArn() => this.DestinationOutpostArn != null;

        /// <summary>
        /// Gets and sets the property DestinationRegion. 
        /// <para>
        /// Deprecated.
        /// </para>
        /// </summary>
        public string DestinationRegion { get; set; }

        /// <summary>
        /// Checks to see if the DestinationRegion property is set.
        /// </summary>
        internal bool IsSetDestinationRegion() => this.DestinationRegion != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property Encrypted. 
        /// <para>
        /// To encrypt a copy of an unencrypted snapshot if encryption by default is not enabled,
        /// enable encryption using this parameter. Otherwise, omit this parameter. Copies of
        /// encrypted snapshots are encrypted, even if you omit this parameter and encryption
        /// by default is not enabled. You cannot set this parameter to false. For more information,
        /// see <a href="https://docs.aws.amazon.com/ebs/latest/userguide/ebs-encryption.html">Amazon
        /// EBS encryption</a> in the <i>Amazon EBS User Guide</i>.
        /// </para>
        /// </summary>
        public bool? Encrypted { get; set; }

        /// <summary>
        /// Checks to see if the Encrypted property is set.
        /// </summary>
        internal bool IsSetEncrypted() => this.Encrypted.HasValue;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The identifier of the KMS key to use for Amazon EBS encryption. If this parameter
        /// is not specified, your KMS key for Amazon EBS is used. If <c>KmsKeyId</c> is specified,
        /// the encrypted state must be <c>true</c>.
        /// </para>
        ///  
        /// <para>
        /// You can specify the KMS key using any of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Key ID. For example, 1234abcd-12ab-34cd-56ef-1234567890ab.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key alias. For example, alias/ExampleAlias.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key ARN. For example, arn:aws:kms:us-east-1:012345678910:key/1234abcd-12ab-34cd-56ef-1234567890ab.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alias ARN. For example, arn:aws:kms:us-east-1:012345678910:alias/ExampleAlias.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Amazon Web Services authenticates the KMS key asynchronously. Therefore, if you specify
        /// an ID, alias, or ARN that is not valid, the action can appear to complete, but eventually
        /// fails.
        /// </para>
        /// </summary>
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property PresignedUrl. 
        /// <para>
        /// Deprecated.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        internal string PresignedUrl { get; set; }

        /// <summary>
        /// Checks to see if the PresignedUrl property is set.
        /// </summary>
        internal bool IsSetPresignedUrl() => this.PresignedUrl != null;

        /// <summary>
        /// Gets and sets the property SourceRegion. 
        /// <para>
        /// The ID of the Region that contains the snapshot to be copied.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SourceRegion { get; set; }

        /// <summary>
        /// Checks to see if the SourceRegion property is set.
        /// </summary>
        internal bool IsSetSourceRegion() => this.SourceRegion != null;

        /// <summary>
        /// Gets and sets the property SourceSnapshotId. 
        /// <para>
        /// The ID of the EBS snapshot to copy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SourceSnapshotId { get; set; }

        /// <summary>
        /// Checks to see if the SourceSnapshotId property is set.
        /// </summary>
        internal bool IsSetSourceSnapshotId() => this.SourceSnapshotId != null;

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the new snapshot.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagSpecification> TagSpecifications { get; set; } = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

        /// <summary>
        /// Checks to see if the TagSpecifications property is set.
        /// </summary>
        internal bool IsSetTagSpecifications() => this.TagSpecifications != null && (this.TagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
