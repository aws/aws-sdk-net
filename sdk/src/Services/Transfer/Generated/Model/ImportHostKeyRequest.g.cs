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

namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Container for the parameters to the ImportHostKey operation. Adds a host key to the
    /// server that's specified by the <c>ServerId</c> parameter.
    /// </summary>
    public partial class ImportHostKeyRequest : AmazonTransferRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The text description that identifies this host key.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property HostKeyBody. 
        /// <para>
        /// The private key portion of an SSH key pair.
        /// </para>
        ///  
        /// <para>
        /// Transfer Family accepts RSA, ECDSA, and ED25519 keys.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 0, Max = 4096)]
        public string HostKeyBody { get; set; }

        /// <summary>
        /// Checks to see if the HostKeyBody property is set.
        /// </summary>
        internal bool IsSetHostKeyBody() => this.HostKeyBody != null;

        /// <summary>
        /// Gets and sets the property KmsKey. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the KMS key used to encrypt the Secrets Manager
        /// secret that stores the host key. If you specify a customer managed key, its key policy
        /// must allow the <c>AWSServiceRoleForTransfer</c> service-linked role to decrypt the
        /// secret. If you don't specify a value, Transfer Family uses the Amazon Web Services
        /// managed key for Secrets Manager.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 1600)]
        public string KmsKey { get; set; }

        /// <summary>
        /// Checks to see if the KmsKey property is set.
        /// </summary>
        internal bool IsSetKmsKey() => this.KmsKey != null;

        /// <summary>
        /// Gets and sets the property ServerId. 
        /// <para>
        /// The identifier of the server that contains the host key that you are importing.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 19, Max = 19)]
        public string ServerId { get; set; }

        /// <summary>
        /// Checks to see if the ServerId property is set.
        /// </summary>
        internal bool IsSetServerId() => this.ServerId != null;

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        /// Specifies whether the host key is stored by Transfer Family (<c>SERVICE_MANAGED</c>)
        /// or in Secrets Manager (<c>SECRETS_MANAGER</c>). When you specify <c>SECRETS_MANAGER</c>,
        /// Transfer Family stores the private host key material in an Secrets Manager secret.
        /// </para>
        /// </summary>
        public HostKeyStorageType StorageType { get; set; }

        /// <summary>
        /// Checks to see if the StorageType property is set.
        /// </summary>
        internal bool IsSetStorageType() => this.StorageType != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Key-value pairs that can be used to group and search for host keys.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
