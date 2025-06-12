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
    /// Container for the parameters to the ImportSnapshot operation.
    /// Imports a disk into an EBS snapshot.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/vm-import/latest/userguide/vmimport-import-snapshot.html">Importing
    /// a disk as a snapshot using VM Import/Export</a> in the <i>VM Import/Export User Guide</i>.
    /// </para>
    /// </summary>
    public partial class ImportSnapshotRequest : AmazonEC2Request
    {
        private ClientData _clientData;
        private string _clientToken;
        private string _description;
        private SnapshotDiskContainer _diskContainer;
        private bool? _dryRun;
        private bool? _encrypted;
        private string _kmsKeyId;
        private string _roleName;
        private List<TagSpecification> _tagSpecifications = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

        /// <summary>
        /// Gets and sets the property ClientData. 
        /// <para>
        /// The client-specific data.
        /// </para>
        /// </summary>
        public ClientData ClientData
        {
            get { return this._clientData; }
            set { this._clientData = value; }
        }

        // Check to see if ClientData property is set
        internal bool IsSetClientData()
        {
            return this._clientData != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Token to enable idempotency for VM import requests.
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The description string for the import snapshot task.
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
        /// Gets and sets the property DiskContainer. 
        /// <para>
        /// Information about the disk container.
        /// </para>
        /// </summary>
        public SnapshotDiskContainer DiskContainer
        {
            get { return this._diskContainer; }
            set { this._diskContainer = value; }
        }

        // Check to see if DiskContainer property is set
        internal bool IsSetDiskContainer()
        {
            return this._diskContainer != null;
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
        /// Specifies whether the destination snapshot of the imported image should be encrypted.
        /// The default KMS key for EBS is used unless you specify a non-default KMS key using
        /// <c>KmsKeyId</c>. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSEncryption.html">Amazon
        /// EBS Encryption</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
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
        /// An identifier for the symmetric KMS key to use when creating the encrypted snapshot.
        /// This parameter is only required if you want to use a non-default KMS key; if this
        /// parameter is not specified, the default KMS key for EBS is used. If a <c>KmsKeyId</c>
        /// is specified, the <c>Encrypted</c> flag must also be set. 
        /// </para>
        ///  
        /// <para>
        /// The KMS key identifier may be provided in any of the following formats: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Key ID
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key alias
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ARN using key ID. The ID ARN contains the <c>arn:aws:kms</c> namespace, followed by
        /// the Region of the key, the Amazon Web Services account ID of the key owner, the <c>key</c>
        /// namespace, and then the key ID. For example, arn:aws:kms:<i>us-east-1</i>:<i>012345678910</i>:key/<i>abcd1234-a123-456a-a12b-a123b4cd56ef</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ARN using key alias. The alias ARN contains the <c>arn:aws:kms</c> namespace, followed
        /// by the Region of the key, the Amazon Web Services account ID of the key owner, the
        /// <c>alias</c> namespace, and then the key alias. For example, arn:aws:kms:<i>us-east-1</i>:<i>012345678910</i>:alias/<i>ExampleAlias</i>.
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Amazon Web Services parses <c>KmsKeyId</c> asynchronously, meaning that the action
        /// you call may appear to complete even though you provided an invalid identifier. This
        /// action will eventually report failure. 
        /// </para>
        ///  
        /// <para>
        /// The specified KMS key must exist in the Region that the snapshot is being copied to.
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
        /// Gets and sets the property RoleName. 
        /// <para>
        /// The name of the role to use when not using the default role, 'vmimport'.
        /// </para>
        /// </summary>
        public string RoleName
        {
            get { return this._roleName; }
            set { this._roleName = value; }
        }

        // Check to see if RoleName property is set
        internal bool IsSetRoleName()
        {
            return this._roleName != null;
        }

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the import snapshot task during creation.
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