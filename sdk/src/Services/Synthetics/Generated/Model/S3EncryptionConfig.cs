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
 * Do not modify this file. This file is generated from the synthetics-2017-10-11.normal.json service model.
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
namespace Amazon.Synthetics.Model
{
    /// <summary>
    /// A structure that contains the configuration of encryption-at-rest settings for canary
    /// artifacts that the canary uploads to Amazon S3. 
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch_Synthetics_artifact_encryption.html">Encrypting
    /// canary artifacts</a> 
    /// </para>
    /// </summary>
    public partial class S3EncryptionConfig
    {
        private EncryptionMode _encryptionMode;
        private string _kmsKeyArn;

        /// <summary>
        /// Gets and sets the property EncryptionMode. 
        /// <para>
        ///  The encryption method to use for artifacts created by this canary. Specify <c>SSE_S3</c>
        /// to use server-side encryption (SSE) with an Amazon S3-managed key. Specify <c>SSE-KMS</c>
        /// to use server-side encryption with a customer-managed KMS key.
        /// </para>
        ///  
        /// <para>
        /// If you omit this parameter, an Amazon Web Services-managed KMS key is used. 
        /// </para>
        /// </summary>
        public EncryptionMode EncryptionMode
        {
            get { return this._encryptionMode; }
            set { this._encryptionMode = value; }
        }

        // Check to see if EncryptionMode property is set
        internal bool IsSetEncryptionMode()
        {
            return this._encryptionMode != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The ARN of the customer-managed KMS key to use, if you specify <c>SSE-KMS</c> for
        /// <c>EncryptionMode</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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

    }
}