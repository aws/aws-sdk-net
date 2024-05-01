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
    /// Provides details about broker encryption options.
    /// </summary>
    public partial class AwsAmazonMqBrokerEncryptionOptionsDetails
    {
        private string _kmsKeyId;
        private bool? _useAwsOwnedKey;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        ///  The KMS key that’s used to encrypt your data at rest. If not provided, Amazon MQ
        /// will use a default KMS key to encrypt your data. 
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
        /// Gets and sets the property UseAwsOwnedKey. 
        /// <para>
        ///  Specifies that an KMS key should be used for at-rest encryption. Set to <c>true</c>
        /// by default if no value is provided (for example, for RabbitMQ brokers). 
        /// </para>
        /// </summary>
        public bool? UseAwsOwnedKey
        {
            get { return this._useAwsOwnedKey; }
            set { this._useAwsOwnedKey = value; }
        }

        // Check to see if UseAwsOwnedKey property is set
        internal bool IsSetUseAwsOwnedKey()
        {
            return this._useAwsOwnedKey.HasValue; 
        }

    }
}