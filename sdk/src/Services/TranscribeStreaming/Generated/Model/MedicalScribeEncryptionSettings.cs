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
 * Do not modify this file. This file is generated from the transcribe-streaming-2017-10-26.normal.json service model.
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
namespace Amazon.TranscribeStreaming.Model
{
    /// <summary>
    /// Contains encryption related settings to be used for data encryption with Key Management
    /// Service, including KmsEncryptionContext and KmsKeyId. The KmsKeyId is required, while
    /// KmsEncryptionContext is optional for additional layer of security. 
    /// 
    ///  
    /// <para>
    /// By default, Amazon Web Services HealthScribe provides encryption at rest to protect
    /// sensitive customer data using Amazon S3-managed keys. HealthScribe uses the KMS key
    /// you specify as a second layer of encryption.
    /// </para>
    ///  
    /// <para>
    ///  Your <c>ResourceAccessRoleArn</c> must permission to use your KMS key. For more information,
    /// see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/health-scribe-encryption.html">Data
    /// Encryption at rest for Amazon Web Services HealthScribe</a>. 
    /// </para>
    /// </summary>
    public partial class MedicalScribeEncryptionSettings
    {
        private Dictionary<string, string> _kmsEncryptionContext = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _kmsKeyId;

        /// <summary>
        /// Gets and sets the property KmsEncryptionContext. 
        /// <para>
        /// A map of plain text, non-secret key:value pairs, known as encryption context pairs,
        /// that provide an added layer of security for your data. For more information, see <a
        /// href="https://docs.aws.amazon.com/transcribe/latest/dg/key-management.html#kms-context">KMSencryption
        /// context </a> and <a href="https://docs.aws.amazon.com/transcribe/latest/dg/symmetric-asymmetric.html">Asymmetric
        /// keys in KMS </a>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public Dictionary<string, string> KmsEncryptionContext
        {
            get { return this._kmsEncryptionContext; }
            set { this._kmsEncryptionContext = value; }
        }

        // Check to see if KmsEncryptionContext property is set
        internal bool IsSetKmsEncryptionContext()
        {
            return this._kmsEncryptionContext != null && (this._kmsEncryptionContext.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ID of the KMS key you want to use for your streaming session. You can specify
        /// its KMS key ID, key Amazon Resource Name (ARN), alias name, or alias ARN. When using
        /// an alias name, prefix it with <c>"alias/"</c>. To specify a KMS key in a different
        /// Amazon Web Services account, you must use the key ARN or alias ARN.
        /// </para>
        ///  
        /// <para>
        /// For example:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Key ID: 1234abcd-12ab-34cd-56ef-1234567890ab
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key ARN: arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Alias name: alias/ExampleAlias
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Alias ARN: arn:aws:kms:us-east-2:111122223333:alias/ExampleAlias 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  To get the key ID and key ARN for a KMS key, use the <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_ListKeys.html">ListKeys</a>
        /// or <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_DescribeKey.html">DescribeKey</a>
        /// KMS API operations. To get the alias name and alias ARN, use <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_ListAliases.html">ListKeys</a>
        /// API operation. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
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

    }
}