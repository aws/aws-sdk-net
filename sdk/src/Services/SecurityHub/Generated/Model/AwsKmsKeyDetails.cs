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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
        private string _awsAccountId;
        private double? _creationDate;
        private string _description;
        private string _keyId;
        private string _keyManager;
        private bool? _keyRotationStatus;
        private string _keyState;
        private string _origin;

        /// <summary>
        /// Gets and sets the property AWSAccountId. 
        /// <para>
        /// The twelve-digit account ID of the Amazon Web Services account that owns the KMS key.
        /// </para>
        /// </summary>
        public string AWSAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AWSAccountId property is set
        internal bool IsSetAWSAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// Indicates when the KMS key was created.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public double? CreationDate
        {
            get { return this._creationDate; }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the KMS key.
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
        /// Gets and sets the property KeyId. 
        /// <para>
        /// The globally unique identifier for the KMS key.
        /// </para>
        /// </summary>
        public string KeyId
        {
            get { return this._keyId; }
            set { this._keyId = value; }
        }

        // Check to see if KeyId property is set
        internal bool IsSetKeyId()
        {
            return this._keyId != null;
        }

        /// <summary>
        /// Gets and sets the property KeyManager. 
        /// <para>
        /// The manager of the KMS key. KMS keys in your Amazon Web Services account are either
        /// customer managed or Amazon Web Services managed.
        /// </para>
        /// </summary>
        public string KeyManager
        {
            get { return this._keyManager; }
            set { this._keyManager = value; }
        }

        // Check to see if KeyManager property is set
        internal bool IsSetKeyManager()
        {
            return this._keyManager != null;
        }

        /// <summary>
        /// Gets and sets the property KeyRotationStatus. 
        /// <para>
        /// Whether the key has key rotation enabled.
        /// </para>
        /// </summary>
        public bool? KeyRotationStatus
        {
            get { return this._keyRotationStatus; }
            set { this._keyRotationStatus = value; }
        }

        // Check to see if KeyRotationStatus property is set
        internal bool IsSetKeyRotationStatus()
        {
            return this._keyRotationStatus.HasValue; 
        }

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
        public string KeyState
        {
            get { return this._keyState; }
            set { this._keyState = value; }
        }

        // Check to see if KeyState property is set
        internal bool IsSetKeyState()
        {
            return this._keyState != null;
        }

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
        public string Origin
        {
            get { return this._origin; }
            set { this._origin = value; }
        }

        // Check to see if Origin property is set
        internal bool IsSetOrigin()
        {
            return this._origin != null;
        }

    }
}