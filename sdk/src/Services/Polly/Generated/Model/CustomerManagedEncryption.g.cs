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

namespace Amazon.Polly.Model
{
    /// <summary>
    /// The customer managed key that encrypts your custom voice. If you don't specify a key,
    /// Amazon Polly encrypts the voice with an Amazon Web Services owned key.
    /// </summary>
    public partial class CustomerManagedEncryption
    {
        /// <summary>
        /// Gets and sets the property EncryptionContext. 
        /// <para>
        /// The key-value pairs that Amazon Polly includes as the encryption context when it encrypts
        /// or decrypts the voice with the key. You can use these pairs in key policy conditions.
        /// Don't use keys that start with <c>aws:</c>, which are reserved.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public Dictionary<string, string> EncryptionContext { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the EncryptionContext property is set.
        /// </summary>
        internal bool IsSetEncryptionContext() => this.EncryptionContext != null && (this.EncryptionContext.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the key. The key must be a symmetric encryption
        /// key in the same Amazon Web Services Region as the voice. To create the voice, you
        /// need <c>kms:DescribeKey</c>, <c>kms:GenerateDataKey</c>, and <c>kms:Decrypt</c> permissions
        /// on the key. To synthesize speech with the voice, you need <c>kms:Decrypt</c> permission
        /// on the key.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string KmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyArn property is set.
        /// </summary>
        internal bool IsSetKmsKeyArn() => this.KmsKeyArn != null;
    }
}
