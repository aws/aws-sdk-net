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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
    /// Container for the parameters to the CopySnapshot operation.
    /// Creates an exact copy of an Amazon EBS snapshot.
    /// 
    ///  
    /// <para>
    /// The location of the source snapshot determines whether you can copy it or not, and
    /// the allowed destinations for the snapshot copy.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If the source snapshot is in a Region, you can copy it within that Region, to another
    /// Region, to an Outpost associated with that Region, or to a Local Zone in that Region.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the source snapshot is in a Local Zone, you can copy it within that Local Zone,
    /// to another Local Zone in the same zone group, or to the parent Region of the Local
    /// Zone.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the source snapshot is on an Outpost, you can't copy it.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// When copying snapshots to a Region, the encryption outcome for the snapshot copy depends
    /// on the Amazon EBS encryption by default setting for the destination Region, the encryption
    /// status of the source snapshot, and the encryption parameters you specify in the request.
    /// For more information, see <a href="https://docs.aws.amazon.com/ebs/latest/userguide/ebs-copy-snapshot.html#creating-encrypted-snapshots">
    /// Encryption and snapshot copying</a>.
    /// </para>
    ///  
    /// <para>
    /// Snapshots copied to an Outpost must be encrypted. Unencrypted snapshots are not supported
    /// on Outposts. For more information, <a href="https://docs.aws.amazon.com/ebs/latest/userguide/snapshots-outposts.html#considerations">
    /// Amazon EBS local snapshots on Outposts</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// Snapshots copies have an arbitrary source volume ID. Do not use this volume ID for
    /// any purpose.
    /// </para>
    ///  </note> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/ebs/latest/userguide/ebs-copy-snapshot.html">Copy
    /// an Amazon EBS snapshot</a> in the <i>Amazon EBS User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CopySnapshotRequest : AmazonEC2Request
    {
        private int? _completionDurationMinutes;
        private string _description;
        private string _destinationAvailabilityZone;
        private string _destinationOutpostArn;
        private string _destinationRegion;
        private bool? _dryRun;
        private bool? _encrypted;
        private string _kmsKeyId;
        private string _presignedUrl;
        private string _sourceRegion;
        private string _sourceSnapshotId;
        private List<TagSpecification> _tagSpecifications = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

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
        [AWSProperty(Min=1, Max=2880)]
        public int? CompletionDurationMinutes
        {
            get { return this._completionDurationMinutes; }
            set { this._completionDurationMinutes = value; }
        }

        // Check to see if CompletionDurationMinutes property is set
        internal bool IsSetCompletionDurationMinutes()
        {
            return this._completionDurationMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the EBS snapshot.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

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
        public string DestinationAvailabilityZone
        {
            get { return this._destinationAvailabilityZone; }
            set { this._destinationAvailabilityZone = value; }
        }

        // Check to see if DestinationAvailabilityZone property is set
        internal bool IsSetDestinationAvailabilityZone()
        {
            return this._destinationAvailabilityZone != null;
        }

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
        public string DestinationOutpostArn
        {
            get { return this._destinationOutpostArn; }
            set { this._destinationOutpostArn = value; }
        }

        // Check to see if DestinationOutpostArn property is set
        internal bool IsSetDestinationOutpostArn()
        {
            return this._destinationOutpostArn != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationRegion. 
        /// <para>
        /// The destination Region to use in the <c>PresignedUrl</c> parameter of a snapshot copy
        /// operation. This parameter is only valid for specifying the destination Region in a
        /// <c>PresignedUrl</c> parameter, where it is required.
        /// </para>
        ///  
        /// <para>
        /// The snapshot copy is sent to the regional endpoint that you sent the HTTP request
        /// to (for example, <c>ec2.us-east-1.amazonaws.com</c>). With the CLI, this is specified
        /// using the <c>--region</c> parameter or the default Region in your Amazon Web Services
        /// configuration file.
        /// </para>
        /// </summary>
        public string DestinationRegion
        {
            get { return this._destinationRegion; }
            set { this._destinationRegion = value; }
        }

        // Check to see if DestinationRegion property is set
        internal bool IsSetDestinationRegion()
        {
            return this._destinationRegion != null;
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

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
        public bool? Encrypted
        {
            get { return this._encrypted; }
            set { this._encrypted = value; }
        }

        // Check to see if Encrypted property is set
        internal bool IsSetEncrypted()
        {
            return this._encrypted.HasValue; 
        }

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
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property PresignedUrl. 
        /// <para>
        /// When you copy an encrypted source snapshot using the Amazon EC2 Query API, you must
        /// supply a pre-signed URL. This parameter is optional for unencrypted snapshots. For
        /// more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Query-Requests.html">Query
        /// requests</a>.
        /// </para>
        ///  
        /// <para>
        /// The <c>PresignedUrl</c> should use the snapshot source endpoint, the <c>CopySnapshot</c>
        /// action, and include the <c>SourceRegion</c>, <c>SourceSnapshotId</c>, and <c>DestinationRegion</c>
        /// parameters. The <c>PresignedUrl</c> must be signed using Amazon Web Services Signature
        /// Version 4. Because EBS snapshots are stored in Amazon S3, the signing algorithm for
        /// this parameter uses the same logic that is described in <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/sigv4-query-string-auth.html">
        /// Authenticating Requests: Using Query Parameters (Amazon Web Services Signature Version
        /// 4)</a> in the <i>Amazon S3 API Reference</i>. An invalid or improperly signed <c>PresignedUrl</c>
        /// will cause the copy operation to fail asynchronously, and the snapshot will move to
        /// an <c>error</c> state.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        internal string PresignedUrl
        {
            get { return this._presignedUrl; }
            set { this._presignedUrl = value; }
        }

        // Check to see if PresignedUrl property is set
        internal bool IsSetPresignedUrl()
        {
            return this._presignedUrl != null;
        }

        /// <summary>
        /// Gets and sets the property SourceRegion. 
        /// <para>
        /// The ID of the Region that contains the snapshot to be copied.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceRegion
        {
            get { return this._sourceRegion; }
            set { this._sourceRegion = value; }
        }

        // Check to see if SourceRegion property is set
        internal bool IsSetSourceRegion()
        {
            return this._sourceRegion != null;
        }

        /// <summary>
        /// Gets and sets the property SourceSnapshotId. 
        /// <para>
        /// The ID of the EBS snapshot to copy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceSnapshotId
        {
            get { return this._sourceSnapshotId; }
            set { this._sourceSnapshotId = value; }
        }

        // Check to see if SourceSnapshotId property is set
        internal bool IsSetSourceSnapshotId()
        {
            return this._sourceSnapshotId != null;
        }

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the new snapshot.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && (this._tagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}