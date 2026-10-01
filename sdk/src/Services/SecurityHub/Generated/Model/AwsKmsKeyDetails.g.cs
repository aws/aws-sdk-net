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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Contains metadata about an KMS key.
    /// </summary>
    public partial class AwsKmsKeyDetails
    {
        /// <summary>
        /// Gets and sets the property AWSAccountId. 
        /// <para>
        /// The twelve-digit account ID of the Amazon Web Services account that owns the KMS key.
        /// </para>
        /// </summary>
        public string AWSAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AWSAccountId property is set.
        /// </summary>
        internal bool IsSetAWSAccountId() => this.AWSAccountId != null;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// Indicates when the KMS key was created.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public double? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the KMS key.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// The globally unique identifier for the KMS key.
        /// </para>
        /// </summary>
        public string KeyId { get; set; }

        /// <summary>
        /// Checks to see if the KeyId property is set.
        /// </summary>
        internal bool IsSetKeyId() => this.KeyId != null;

        /// <summary>
        /// Gets and sets the property KeyManager. 
        /// <para>
        /// The manager of the KMS key. KMS keys in your Amazon Web Services account are either
        /// customer managed or Amazon Web Services managed.
        /// </para>
        /// </summary>
        public string KeyManager { get; set; }

        /// <summary>
        /// Checks to see if the KeyManager property is set.
        /// </summary>
        internal bool IsSetKeyManager() => this.KeyManager != null;

        /// <summary>
        /// Gets and sets the property KeyRotationStatus. 
        /// <para>
        /// Whether the key has key rotation enabled.
        /// </para>
        /// </summary>
        public bool? KeyRotationStatus { get; set; }

        /// <summary>
        /// Checks to see if the KeyRotationStatus property is set.
        /// </summary>
        internal bool IsSetKeyRotationStatus() => this.KeyRotationStatus.HasValue;

        /// <summary>
        /// Gets and sets the property KeyState. 
        /// <para>
        /// The state of the KMS key. Valid values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Disabled</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Enabled</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PendingDeletion</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PendingImport</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Unavailable</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string KeyState { get; set; }

        /// <summary>
        /// Checks to see if the KeyState property is set.
        /// </summary>
        internal bool IsSetKeyState() => this.KeyState != null;

        /// <summary>
        /// Gets and sets the property Origin. 
        /// <para>
        /// The source of the KMS key material.
        /// </para>
        ///  
        /// <para>
        /// When this value is <c>AWS_KMS</c>, KMS created the key material.
        /// </para>
        ///  
        /// <para>
        /// When this value is <c>EXTERNAL</c>, the key material was imported from your existing
        /// key management infrastructure or the KMS key lacks key material.
        /// </para>
        ///  
        /// <para>
        /// When this value is <c>AWS_CLOUDHSM</c>, the key material was created in the CloudHSM
        /// cluster associated with a custom key store.
        /// </para>
        /// </summary>
        public string Origin { get; set; }

        /// <summary>
        /// Checks to see if the Origin property is set.
        /// </summary>
        internal bool IsSetOrigin() => this.Origin != null;
    }
}
