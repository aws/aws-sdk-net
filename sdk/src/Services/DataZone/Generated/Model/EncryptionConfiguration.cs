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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The encryption configuration details.
    /// </summary>
    public partial class EncryptionConfiguration
    {
        private string _kmsKeyArn;
        private string _sseAlgorithm;

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the KMS key to use for encryption. This field is
        /// required only when <c>sseAlgorithm</c> is set to <c>aws:kms</c>.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property SseAlgorithm. 
        /// <para>
        /// The server-side encryption algorithm to use. Valid values are AES256 for S3-managed
        /// encryption keys, or aws:kms for Amazon Web Services KMS-managed encryption keys. If
        /// you choose SSE-KMS encryption you must grant the S3 Tables maintenance principal access
        /// to your KMS key. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-kms-permissions.html">Permissions
        /// requirements for S3 Tables SSE-KMS encryption</a>.
        /// </para>
        /// </summary>
        public string SseAlgorithm
        {
            get { return this._sseAlgorithm; }
            set { this._sseAlgorithm = value; }
        }

        // Check to see if SseAlgorithm property is set
        internal bool IsSetSseAlgorithm()
        {
            return this._sseAlgorithm != null;
        }

    }
}