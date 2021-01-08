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
 * Do not modify this file. This file is generated from the mq-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MQ.Model
{
    /// <summary>
    /// Encryption options for the broker.
    /// </summary>
    public partial class EncryptionOptions
    {
        private string _kmsKeyId;
        private bool? _useAwsOwnedKey;

        /// <summary>
        /// Gets and sets the property KmsKeyId. The symmetric customer master key (CMK) to use
        /// for the AWS Key Management Service (KMS). This key is used to encrypt your data at
        /// rest. If not provided, Amazon MQ will use a default CMK to encrypt your data.
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
        /// Gets and sets the property UseAwsOwnedKey. Enables the use of an AWS owned CMK using
        /// AWS Key Management Service (KMS).
        /// </summary>
        [AWSProperty(Required=true)]
        public bool UseAwsOwnedKey
        {
            get { return this._useAwsOwnedKey.GetValueOrDefault(); }
            set { this._useAwsOwnedKey = value; }
        }

        // Check to see if UseAwsOwnedKey property is set
        internal bool IsSetUseAwsOwnedKey()
        {
            return this._useAwsOwnedKey.HasValue; 
        }

    }
}