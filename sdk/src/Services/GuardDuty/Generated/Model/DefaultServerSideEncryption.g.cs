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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information on the server side encryption method used in the S3 bucket. See
    /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/serv-side-encryption.html">S3
    /// Server-Side Encryption</a> for more information.
    /// </summary>
    public partial class DefaultServerSideEncryption
    {
        /// <summary>
        /// Gets and sets the property EncryptionType. 
        /// <para>
        /// The type of encryption used for objects within the S3 bucket.
        /// </para>
        /// </summary>
        public string EncryptionType { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionType property is set.
        /// </summary>
        internal bool IsSetEncryptionType() => this.EncryptionType != null;

        /// <summary>
        /// Gets and sets the property KmsMasterKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the KMS encryption key. Only available if the bucket
        /// <c>EncryptionType</c> is <c>aws:kms</c>.
        /// </para>
        /// </summary>
        public string KmsMasterKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsMasterKeyArn property is set.
        /// </summary>
        internal bool IsSetKmsMasterKeyArn() => this.KmsMasterKeyArn != null;
    }
}
