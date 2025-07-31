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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateEncryptionConfiguration operation.
    /// Updates the encryption configuration. By default, all Amazon Web Services IoT Core
    /// data at rest is encrypted using Amazon Web Services owned keys. Amazon Web Services
    /// IoT Core also supports symmetric customer managed keys from Amazon Web Services Key
    /// Management Service (KMS). With customer managed keys, you create, own, and manage
    /// the KMS keys in your Amazon Web Services account. For more information, see <a href="https://docs.aws.amazon.com/iot/latest/developerguide/data-encryption.html">Data
    /// encryption</a> in the <i>Amazon Web Services IoT Core Developer Guide</i>.
    /// </summary>
    public partial class UpdateEncryptionConfigurationRequest : AmazonIoTRequest
    {
        private EncryptionType _encryptionType;
        private string _kmsAccessRoleArn;
        private string _kmsKeyArn;

        /// <summary>
        /// Gets and sets the property EncryptionType. 
        /// <para>
        /// The type of the Amazon Web Services Key Management Service (KMS) key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EncryptionType EncryptionType
        {
            get { return this._encryptionType; }
            set { this._encryptionType = value; }
        }

        // Check to see if EncryptionType property is set
        internal bool IsSetEncryptionType()
        {
            return this._encryptionType != null;
        }

        /// <summary>
        /// Gets and sets the property KmsAccessRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role assumed by Amazon Web Services IoT
        /// Core to call KMS on behalf of the customer.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string KmsAccessRoleArn
        {
            get { return this._kmsAccessRoleArn; }
            set { this._kmsAccessRoleArn = value; }
        }

        // Check to see if KmsAccessRoleArn property is set
        internal bool IsSetKmsAccessRoleArn()
        {
            return this._kmsAccessRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The ARN of the customer-managed KMS key.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string KmsKeyArn
        {
            get { return this._kmsKeyArn; }
            set { this._kmsKeyArn = value; }
        }

        // Check to see if KmsKeyArn property is set
        internal bool IsSetKmsKeyArn()
        {
            return this._kmsKeyArn != null;
        }

    }
}