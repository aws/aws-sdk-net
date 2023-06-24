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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CopyImage operation.
    /// Initiates the copy of an AMI. You can copy an AMI from one Region to another, or from
    /// a Region to an Outpost. You can't copy an AMI from an Outpost to a Region, from one
    /// Outpost to another, or within the same Outpost. To copy an AMI to another partition,
    /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_CreateStoreImageTask.html">CreateStoreImageTask</a>.
    /// 
    ///  
    /// <para>
    /// To copy an AMI from one Region to another, specify the source Region using the <b>SourceRegion</b>
    /// parameter, and specify the destination Region using its endpoint. Copies of encrypted
    /// backing snapshots for the AMI are encrypted. Copies of unencrypted backing snapshots
    /// remain unencrypted, unless you set <code>Encrypted</code> during the copy operation.
    /// You cannot create an unencrypted copy of an encrypted backing snapshot.
    /// </para>
    ///  
    /// <para>
    /// To copy an AMI from a Region to an Outpost, specify the source Region using the <b>SourceRegion</b>
    /// parameter, and specify the ARN of the destination Outpost using <b>DestinationOutpostArn</b>.
    /// Backing snapshots copied to an Outpost are encrypted by default using the default
    /// encryption key for the Region, or a different key that you specify in the request
    /// using <b>KmsKeyId</b>. Outposts do not support unencrypted snapshots. For more information,
    /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/snapshots-outposts.html#ami">
    /// Amazon EBS local snapshots on Outposts</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// For more information about the prerequisites and limits when copying an AMI, see <a
    /// href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/CopyingAMIs.html">Copy an
    /// AMI</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CopyImageRequest : AmazonEC2Request
    {
        private string _clientToken;
        private bool? _copyImageTags;
        private string _description;
        private string _destinationOutpostArn;
        private bool? _encrypted;
        private string _kmsKeyId;
        private string _name;
        private string _sourceImageId;
        private string _sourceRegion;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier you provide to ensure idempotency of the request.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// idempotency</a> in the <i>Amazon EC2 API Reference</i>.
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
        /// Indicates whether to include your user-defined AMI tags when copying the AMI.
        /// </para>
        ///  
        /// <para>
        /// The following tags will not be copied:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// System tags (prefixed with <code>aws:</code>)
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
        public bool CopyImageTags
        {
            get { return this._copyImageTags.GetValueOrDefault(); }
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
        /// A description for the new AMI in the destination Region.
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
        /// Gets and sets the property DestinationOutpostArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Outpost to which to copy the AMI. Only specify
        /// this parameter when copying an AMI from an Amazon Web Services Region to an Outpost.
        /// The AMI must be in the Region of the destination Outpost. You cannot copy an AMI from
        /// an Outpost to a Region, from one Outpost to another, or within the same Outpost.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/snapshots-outposts.html#copy-amis">
        /// Copy AMIs from an Amazon Web Services Region to an Outpost</a> in the <i>Amazon EC2
        /// User Guide</i>.
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
        /// Gets and sets the property Encrypted. 
        /// <para>
        /// Specifies whether the destination snapshots of the copied image should be encrypted.
        /// You can encrypt a copy of an unencrypted snapshot, but you cannot create an unencrypted
        /// copy of an encrypted snapshot. The default KMS key for Amazon EBS is used unless you
        /// specify a non-default Key Management Service (KMS) KMS key using <code>KmsKeyId</code>.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSEncryption.html">Amazon
        /// EBS encryption</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public bool Encrypted
        {
            get { return this._encrypted.GetValueOrDefault(); }
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
        /// state to <code>true</code>.
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
        /// The name of the new AMI in the destination Region.
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

    }
}