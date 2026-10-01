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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Contains the encryption configuration for a workspace.
    /// </summary>
    public partial class WorkspaceEncryptionConfiguration
    {
        /// <summary>
        /// Gets and sets the property EncryptionType. 
        /// <para>
        /// The encryption scheme for the workspace. <c>SITEWISE_DEFAULT_ENCRYPTION</c> encrypts
        /// data with the IoT SiteWise default key. <c>KMS_BASED_ENCRYPTION</c> encrypts data
        /// with the customer managed KMS key identified by <c>kmsKeyId</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EncryptionType EncryptionType { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionType property is set.
        /// </summary>
        internal bool IsSetEncryptionType() => this.EncryptionType != null;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The customer managed KMS key used when <c>encryptionType</c> is <c>KMS_BASED_ENCRYPTION</c>.
        /// Accepts a key ID, key ARN, or key alias. Required for <c>KMS_BASED_ENCRYPTION</c>;
        /// must be omitted for <c>SITEWISE_DEFAULT_ENCRYPTION</c>. After a workspace's customer
        /// managed key configuration becomes active, the key can't be changed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;
    }
}
