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

namespace Amazon.MQ.Model
{
    /// <summary>
    /// Encryption options for the broker.
    /// </summary>
    public partial class EncryptionOptions
    {
        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The customer master key (CMK) to use for the A KMS (KMS). This key is used to encrypt
        /// your data at rest. If not provided, Amazon MQ will use a default CMK to encrypt your
        /// data.
        /// </para>
        /// </summary>
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property UseAwsOwnedKey. 
        /// <para>
        /// Enables the use of an Amazon Web Services owned CMK using KMS (KMS). Set to true by
        /// default, if no value is provided, for example, for RabbitMQ brokers.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? UseAwsOwnedKey { get; set; }

        /// <summary>
        /// Checks to see if the UseAwsOwnedKey property is set.
        /// </summary>
        internal bool IsSetUseAwsOwnedKey() => this.UseAwsOwnedKey.HasValue;
    }
}
