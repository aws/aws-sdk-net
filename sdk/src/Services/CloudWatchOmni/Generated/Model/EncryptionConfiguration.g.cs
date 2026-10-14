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

namespace Amazon.CloudWatchOmni.Model
{
    /// <summary>
    /// How a resource's data at rest is encrypted. `kmsKeyArn` is required when `encryptionStrategy`
    /// is CUSTOMER_MANAGED and must be absent when it is AWS_OWNED; a mismatch is a ValidationException
    /// rather than a silently ignored field, so a caller that selects AWS_OWNED while still
    /// passing a key learns that the key was not applied.
    /// </summary>
    public partial class EncryptionConfiguration
    {
        /// <summary>
        /// Gets and sets the property EncryptionStrategy. Which kind of key to use. Required.
        /// </summary>
        [AWSProperty(Required = true)]
        public EncryptionStrategy EncryptionStrategy { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionStrategy property is set.
        /// </summary>
        internal bool IsSetEncryptionStrategy() => this.EncryptionStrategy != null;

        /// <summary>
        /// Gets and sets the property KmsKeyArn. Customer managed KMS key ARN. Required when
        /// `encryptionStrategy` is CUSTOMER_MANAGED, and must be omitted when it is AWS_OWNED.
        /// Must be a symmetric ENCRYPT_DECRYPT key in the caller's account and region.
        /// </summary>
        public string KmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyArn property is set.
        /// </summary>
        internal bool IsSetKmsKeyArn() => this.KmsKeyArn != null;
    }
}
