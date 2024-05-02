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
    /// A structure that contains the configuration for canary artifacts, including the encryption-at-rest
    /// settings for artifacts that the canary uploads to Amazon S3.
    /// </summary>
    public partial class ArtifactConfigInput
    {
        private S3EncryptionConfig _s3Encryption;

        /// <summary>
        /// Gets and sets the property S3Encryption. 
        /// <para>
        /// A structure that contains the configuration of the encryption-at-rest settings for
        /// artifacts that the canary uploads to Amazon S3. Artifact encryption functionality
        /// is available only for canaries that use Synthetics runtime version syn-nodejs-puppeteer-3.3
        /// or later. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch_Synthetics_artifact_encryption.html">Encrypting
        /// canary artifacts</a> 
        /// </para>
        /// </summary>
        public S3EncryptionConfig S3Encryption
        {
            get { return this._s3Encryption; }
            set { this._s3Encryption = value; }
        }

        // Check to see if S3Encryption property is set
        internal bool IsSetS3Encryption()
        {
            return this._s3Encryption != null;
        }

    }
}