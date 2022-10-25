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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// Access configuration parameters.
    /// </summary>
    public partial class AccessConfiguration
    {
        private AccessType _accessType;
        private SecretsManagerAccessTokenConfiguration _secretsManagerAccessTokenConfiguration;

        /// <summary>
        /// Gets and sets the property AccessType. 
        /// <para>
        /// The type of authentication used to access content from <code>HttpConfiguration::BaseUrl</code>
        /// on your source location. Accepted value: <code>S3_SIGV4</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>S3_SIGV4</code> - AWS Signature Version 4 authentication for Amazon S3 hosted
        /// virtual-style access. If your source location base URL is an Amazon S3 bucket, MediaTailor
        /// can use AWS Signature Version 4 (SigV4) authentication to access the bucket where
        /// your source content is stored. Your MediaTailor source location baseURL must follow
        /// the S3 virtual hosted-style request URL format. For example, https://bucket-name.s3.Region.amazonaws.com/key-name.
        /// </para>
        ///  
        /// <para>
        /// Before you can use <code>S3_SIGV4</code>, you must meet these requirements:
        /// </para>
        ///  
        /// <para>
        /// • You must allow MediaTailor to access your S3 bucket by granting mediatailor.amazonaws.com
        /// principal access in IAM. For information about configuring access in IAM, see Access
        /// management in the IAM User Guide.
        /// </para>
        ///  
        /// <para>
        /// • The mediatailor.amazonaws.com service principal must have permissions to read all
        /// top level manifests referenced by the VodSource packaging configurations.
        /// </para>
        ///  
        /// <para>
        /// • The caller of the API must have s3:GetObject IAM permissions to read all top level
        /// manifests referenced by your MediaTailor VodSource packaging configurations.
        /// </para>
        /// </summary>
        public AccessType AccessType
        {
            get { return this._accessType; }
            set { this._accessType = value; }
        }

        // Check to see if AccessType property is set
        internal bool IsSetAccessType()
        {
            return this._accessType != null;
        }

        /// <summary>
        /// Gets and sets the property SecretsManagerAccessTokenConfiguration. 
        /// <para>
        /// AWS Secrets Manager access token configuration parameters.
        /// </para>
        /// </summary>
        public SecretsManagerAccessTokenConfiguration SecretsManagerAccessTokenConfiguration
        {
            get { return this._secretsManagerAccessTokenConfiguration; }
            set { this._secretsManagerAccessTokenConfiguration = value; }
        }

        // Check to see if SecretsManagerAccessTokenConfiguration property is set
        internal bool IsSetSecretsManagerAccessTokenConfiguration()
        {
            return this._secretsManagerAccessTokenConfiguration != null;
        }

    }
}