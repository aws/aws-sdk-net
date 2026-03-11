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
    /// Container for the parameters to the CopyImage operation.
    /// Initiates an AMI copy operation. You must specify the source AMI ID and both the source
    /// and destination locations. The copy operation must be initiated in the destination
    /// Region.
    /// 
    ///  
    /// <para>
    ///  <b>CopyImage supports the following source to destination copies:</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Region to Region
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Region to Outpost
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Parent Region to Local Zone
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Local Zone to parent Region
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Between Local Zones with the same parent Region (only supported for certain Local
    /// Zones)
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>CopyImage does not support the following source to destination copies:</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Local Zone to non-parent Regions
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Between Local Zones with different parent Regions
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Local Zone to Outpost
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Outpost to Local Zone
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Outpost to Region
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Between Outposts
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Within same Outpost
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Cross-partition copies (use <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_CreateStoreImageTask.html">CreateStoreImageTask</a>
    /// instead)
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Destination specification</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Region to Region: The destination Region is the Region in which you initiate the copy
    /// operation.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Region to Outpost: Specify the destination using the <c>DestinationOutpostArn</c>
    /// parameter (the ARN of the Outpost)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Region to Local Zone, and Local Zone to Local Zone copies: Specify the destination
    /// using the <c>DestinationAvailabilityZone</c> parameter (the name of the destination
    /// Local Zone) or <c>DestinationAvailabilityZoneId</c> parameter (the ID of the destination
    /// Local Zone).
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Snapshot encryption</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Region to Outpost: Backing snapshots copied to an Outpost are encrypted by default
    /// using the default encryption key for the Region or the key that you specify. Outposts
    /// do not support unencrypted snapshots.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Region to Local Zone, and Local Zone to Local Zone: Not all Local Zones require encrypted
    /// snapshots. In Local Zones that require encrypted snapshots, backing snapshots are
    /// automatically encrypted during copy. In Local Zones where encryption is not required,
    /// snapshots retain their original encryption state (encrypted or unencrypted) by default.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information, including the required permissions for copying an AMI, see <a
    /// href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/CopyingAMIs.html">Copy an
    /// Amazon EC2 AMI</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CopyImageRequest : AmazonEC2Request
    {
        private string _clientToken;
        private bool? _copyImageTags;
        private string _description;
        private string _destinationAvailabilityZone;
        private string _destinationAvailabilityZoneId;
        private string _destinationOutpostArn;
        private bool? _dryRun;
        private bool? _encrypted;
        private string _kmsKeyId;
        private string _name;
        private long? _snapshotCopyCompletionDurationMinutes;
        private string _sourceImageId;
        private string _sourceRegion;
        private List<TagSpecification> _tagSpecifications = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier you provide to ensure idempotency of the request.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// idempotency in Amazon EC2 API requests</a> in the <i>Amazon EC2 API Reference</i>.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property CopyImageTags. 
        /// <para>
        /// Specifies whether to copy your user-defined AMI tags to the new AMI.
        /// </para>
        ///  
        /// <para>
        /// The following tags are not be copied:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// System tags (prefixed with <c>aws:</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For public and shared AMIs, user-defined tags that are attached by other Amazon Web
        /// Services accounts
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default: Your user-defined AMI tags are not copied.
        /// </para>
        /// </summary>
        public bool? CopyImageTags
        {
            get { return this._copyImageTags; }
            set { this._copyImageTags = value; }
        }

        // Check to see if CopyImageTags property is set
        internal bool IsSetCopyImageTags()
        {
            return this._copyImageTags.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the new AMI.
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
        /// The Local Zone for the new AMI (for example, <c>cn-north-1-pkx-1a</c>).
        /// </para>
        ///  
        /// <para>
        /// Only one of <c>DestinationAvailabilityZone</c>, <c>DestinationAvailabilityZoneId</c>,
        /// or <c>DestinationOutpostArn</c> can be specified.
        /// </para>
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
        /// Gets and sets the property DestinationAvailabilityZoneId. 
        /// <para>
        /// The ID of the Local Zone for the new AMI (for example, <c>cnn1-pkx1-az1</c>).
        /// </para>
        ///  
        /// <para>
        /// Only one of <c>DestinationAvailabilityZone</c>, <c>DestinationAvailabilityZoneId</c>,
        /// or <c>DestinationOutpostArn</c> can be specified.
        /// </para>
        /// </summary>
        public string DestinationAvailabilityZoneId
        {
            get { return this._destinationAvailabilityZoneId; }
            set { this._destinationAvailabilityZoneId = value; }
        }

        // Check to see if DestinationAvailabilityZoneId property is set
        internal bool IsSetDestinationAvailabilityZoneId()
        {
            return this._destinationAvailabilityZoneId != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationOutpostArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Outpost for the new AMI.
        /// </para>
        ///  
        /// <para>
        /// Only specify this parameter when copying an AMI from an Amazon Web Services Region
        /// to an Outpost. The AMI must be in the Region of the destination Outpost. You can't
        /// copy an AMI from an Outpost to a Region, from one Outpost to another, or within the
        /// same Outpost.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/ebs/latest/userguide/snapshots-outposts.html#copy-amis">Copy
        /// AMIs from an Amazon Web Services Region to an Outpost</a> in the <i>Amazon EBS User
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Only one of <c>DestinationAvailabilityZone</c>, <c>DestinationAvailabilityZoneId</c>,
        /// or <c>DestinationOutpostArn</c> can be specified.
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
        /// Specifies whether to encrypt the snapshots of the copied image.
        /// </para>
        ///  
        /// <para>
        /// You can encrypt a copy of an unencrypted snapshot, but you cannot create an unencrypted
        /// copy of an encrypted snapshot. The default KMS key for Amazon EBS is used unless you
        /// specify a non-default Key Management Service (KMS) KMS key using <c>KmsKeyId</c>.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/AMIEncryption.html">Use
        /// encryption with EBS-backed AMIs</a> in the <i>Amazon EC2 User Guide</i>.
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
        /// The identifier of the symmetric Key Management Service (KMS) KMS key to use when creating
        /// encrypted volumes. If this parameter is not specified, your Amazon Web Services managed
        /// KMS key for Amazon EBS is used. If you specify a KMS key, you must also set the encrypted
        /// state to <c>true</c>.
        /// </para>
        ///  
        /// <para>
        /// You can specify a KMS key using any of the following:
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
        /// an identifier that is not valid, the action can appear to complete, but eventually
        /// fails.
        /// </para>
        ///  
        /// <para>
        /// The specified KMS key must exist in the destination Region.
        /// </para>
        ///  
        /// <para>
        /// Amazon EBS does not support asymmetric KMS keys.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the new AMI.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotCopyCompletionDurationMinutes. 
        /// <para>
        /// Specify a completion duration, in 15 minute increments, to initiate a time-based AMI
        /// copy. The specified completion duration applies to each of the snapshots associated
        /// with the AMI. Each snapshot associated with the AMI will be completed within the specified
        /// completion duration, with copy throughput automatically adjusted for each snapshot
        /// based on its size to meet the timing target.
        /// </para>
        ///  
        /// <para>
        /// If you do not specify a value, the AMI copy operation is completed on a best-effort
        /// basis.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is not supported when copying an AMI to or from a Local Zone, or to
        /// an Outpost.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/ebs/latest/userguide/time-based-copies.html">Time-based
        /// copies for Amazon EBS snapshots and EBS-backed AMIs</a>.
        /// </para>
        /// </summary>
        public long? SnapshotCopyCompletionDurationMinutes
        {
            get { return this._snapshotCopyCompletionDurationMinutes; }
            set { this._snapshotCopyCompletionDurationMinutes = value; }
        }

        // Check to see if SnapshotCopyCompletionDurationMinutes property is set
        internal bool IsSetSnapshotCopyCompletionDurationMinutes()
        {
            return this._snapshotCopyCompletionDurationMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceImageId. 
        /// <para>
        /// The ID of the AMI to copy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceImageId
        {
            get { return this._sourceImageId; }
            set { this._sourceImageId = value; }
        }

        // Check to see if SourceImageId property is set
        internal bool IsSetSourceImageId()
        {
            return this._sourceImageId != null;
        }

        /// <summary>
        /// Gets and sets the property SourceRegion. 
        /// <para>
        /// The name of the Region that contains the AMI to copy.
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
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the new AMI and new snapshots. You can tag the AMI, the snapshots,
        /// or both.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To tag the new AMI, the value for <c>ResourceType</c> must be <c>image</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To tag the new snapshots, the value for <c>ResourceType</c> must be <c>snapshot</c>.
        /// The same tag is applied to all the new snapshots.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you specify other values for <c>ResourceType</c>, the request fails.
        /// </para>
        ///  
        /// <para>
        /// To tag an AMI or snapshot after it has been created, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_CreateTags.html">CreateTags</a>.
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