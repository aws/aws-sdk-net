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

namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// Encryption configuration for the invocation
    /// </summary>
    public partial class EncryptionConfiguration
    {
        /// <summary>
        /// Gets and sets the property KMSEncryptionContext. 
        /// <para>
        /// A map of plain text, non-secret key:value pairs, known as encryption context pairs,
        /// that provide an added layer of security for your data. For more information, see <a
        /// href="https://docs.aws.amazon.com/transcribe/latest/dg/key-management.html#kms-context">KMS
        /// encryption context</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public Dictionary<string, string> KMSEncryptionContext { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the KMSEncryptionContext property is set.
        /// </summary>
        internal bool IsSetKMSEncryptionContext() => this.KMSEncryptionContext != null && (this.KMSEncryptionContext.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property KMSKey. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the KMS key you want to use to encrypt your resource
        /// artifacts. Only full KMS key ARN format is supported.
        /// </para>
        ///  
        /// <para>
        /// KMS key ARNs have the format <c>arn:partition:kms:region:account:key/key-id</c>. For
        /// example: <c>arn:aws:kms:us-west-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#key-id-key-ARN">KMS
        /// key ARNs</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string KMSKey { get; set; }

        /// <summary>
        /// Checks to see if the KMSKey property is set.
        /// </summary>
        internal bool IsSetKMSKey() => this.KMSKey != null;
    }
}
