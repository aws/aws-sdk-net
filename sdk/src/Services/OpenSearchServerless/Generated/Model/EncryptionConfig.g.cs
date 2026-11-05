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

namespace Amazon.OpenSearchServerless.Model
{
    /// <summary>
    /// Encryption settings for a collection.
    /// </summary>
    public partial class EncryptionConfig
    {
        /// <summary>
        /// Gets and sets the property AWSOwnedKey. 
        /// <para>
        /// Indicates whether to use an Amazon Web Services-owned key for encryption.
        /// </para>
        /// </summary>
        public bool? AWSOwnedKey { get; set; }

        /// <summary>
        /// Checks to see if the AWSOwnedKey property is set.
        /// </summary>
        internal bool IsSetAWSOwnedKey() => this.AWSOwnedKey.HasValue;

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The ARN of the Amazon Web Services Key Management Service key used to encrypt the
        /// collection.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 2048)]
        public string KmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyArn property is set.
        /// </summary>
        internal bool IsSetKmsKeyArn() => this.KmsKeyArn != null;
    }
}
