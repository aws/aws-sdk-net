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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Specifies the default server-side encryption to apply to new objects in the bucket.
    /// </summary>
    public partial class AwsS3BucketServerSideEncryptionByDefault
    {
        /// <summary>
        /// Gets and sets the property KMSMasterKeyID. 
        /// <para>
        /// KMS key ID to use for the default encryption.
        /// </para>
        /// </summary>
        public string KMSMasterKeyID { get; set; }

        /// <summary>
        /// Checks to see if the KMSMasterKeyID property is set.
        /// </summary>
        internal bool IsSetKMSMasterKeyID() => this.KMSMasterKeyID != null;

        /// <summary>
        /// Gets and sets the property SSEAlgorithm. 
        /// <para>
        /// Server-side encryption algorithm to use for the default encryption. Valid values are
        /// <c>aws: kms</c> or <c>AES256</c>.
        /// </para>
        /// </summary>
        public string SSEAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the SSEAlgorithm property is set.
        /// </summary>
        internal bool IsSetSSEAlgorithm() => this.SSEAlgorithm != null;
    }
}
