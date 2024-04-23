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
        /// This field accepts only the specified formats. Timestamps can end with <c>Z</c> or
        /// <c>("+" / "-") time-hour [":" time-minute]</c>. The time-secfrac after seconds is
        /// limited to a maximum of 9 digits. The offset is bounded by +/-18:00. Here are valid
        /// timestamp formats with examples:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>YYYY-MM-DDTHH:MM:SSZ</c> (for example, <c>2019-01-31T23:00:00Z</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>YYYY-MM-DDTHH:MM:SS.mmmmmmmmmZ</c> (for example, <c>2019-01-31T23:00:00.123456789Z</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>YYYY-MM-DDTHH:MM:SS+HH:MM</c> (for example, <c>2024-01-04T15:25:10+17:59</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>YYYY-MM-DDTHH:MM:SS-HHMM</c> (for example, <c>2024-01-04T15:25:10-1759</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>YYYY-MM-DDTHH:MM:SS.mmmmmmmmm+HH:MM</c> (for example, <c>2024-01-04T15:25:10.123456789+17:59</c>)
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public double CreationDate
        {
            get { return this._creationDate.GetValueOrDefault(); }
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
        public bool KeyRotationStatus
        {
            get { return this._keyRotationStatus.GetValueOrDefault(); }
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