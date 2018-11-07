/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ImportSnapshot operation.
    /// Imports a disk into an EBS snapshot.
    /// </summary>
    public partial class ImportSnapshotRequest : AmazonEC2Request
    {
        private ClientData _clientData;
        private string _clientToken;
        private string _description;
        private SnapshotDiskContainer _diskContainer;
        private bool? _encrypted;
        private string _kmsKeyId;
        private string _roleName;

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
        /// Gets and sets the property Encrypted. 
        /// <para>
        /// Specifies whether the destination snapshot of the imported image should be encrypted.
        /// The default CMK for EBS is used unless you specify a non-default AWS Key Management
        /// Service (AWS KMS) CMK using <code>KmsKeyId</code>. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSEncryption.html">Amazon
        /// EBS Encryption</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
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
        /// An identifier for the AWS Key Management Service (AWS KMS) customer master key (CMK)
        /// to use when creating the encrypted snapshot. This parameter is only required if you
        /// want to use a non-default CMK; if this parameter is not specified, the default CMK
        /// for EBS is used. If a <code>KmsKeyId</code> is specified, the <code>Encrypted</code>
        /// flag must also be set. 
        /// </para>
        ///  
        /// <para>
        /// The CMK identifier may be provided in any of the following formats: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Key ID
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key alias, in the form <code>alias/<i>ExampleAlias</i> </code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ARN using key ID. The ID ARN contains the <code>arn:aws:kms</code> namespace, followed
        /// by the region of the CMK, the AWS account ID of the CMK owner, the <code>key</code>
        /// namespace, and then the CMK ID. For example, arn:aws:kms:<i>us-east-1</i>:<i>012345678910</i>:key/<i>abcd1234-a123-456a-a12b-a123b4cd56ef</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ARN using key alias. The alias ARN contains the <code>arn:aws:kms</code> namespace,
        /// followed by the region of the CMK, the AWS account ID of the CMK owner, the <code>alias</code>
        /// namespace, and then the CMK alias. For example, arn:aws:kms:<i>us-east-1</i>:<i>012345678910</i>:alias/<i>ExampleAlias</i>.
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// AWS parses <code>KmsKeyId</code> asynchronously, meaning that the action you call
        /// may appear to complete even though you provided an invalid identifier. This action
        /// will eventually report failure. 
        /// </para>
        ///  
        /// <para>
        /// The specified CMK must exist in the region that the snapshot is being copied to. 
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

    }
}