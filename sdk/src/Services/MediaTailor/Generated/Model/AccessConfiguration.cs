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

#pragma warning disable CS0612,CS0618,CS1570
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
        /// The type of authentication used to access content from <c>HttpConfiguration::BaseUrl</c>
        /// on your source location.
        /// </para>
        ///  
        /// <para>
        ///  <c>S3_SIGV4</c> - AWS Signature Version 4 authentication for Amazon S3 hosted virtual-style
        /// access. If your source location base URL is an Amazon S3 bucket, MediaTailor can use
        /// AWS Signature Version 4 (SigV4) authentication to access the bucket where your source
        /// content is stored. Your MediaTailor source location baseURL must follow the S3 virtual
        /// hosted-style request URL format. For example, https://bucket-name.s3.Region.amazonaws.com/key-name.
        /// </para>
        ///  
        /// <para>
        /// Before you can use <c>S3_SIGV4</c>, you must meet these requirements:
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
        ///  
        /// <para>
        ///  <c>AUTODETECT_SIGV4</c> - AWS Signature Version 4 authentication for a set of supported
        /// services: MediaPackage Version 2 and Amazon S3 hosted virtual-style access. If your
        /// source location base URL is a MediaPackage Version 2 endpoint or an Amazon S3 bucket,
        /// MediaTailor can use AWS Signature Version 4 (SigV4) authentication to access the resource
        /// where your source content is stored.
        /// </para>
        ///  
        /// <para>
        /// Before you can use <c>AUTODETECT_SIGV4</c> with a MediaPackage Version 2 endpoint,
        /// you must meet these requirements:
        /// </para>
        ///  
        /// <para>
        /// • You must grant MediaTailor access to your MediaPackage endpoint by granting <c>mediatailor.amazonaws.com</c>
        /// principal access in an Origin Access policy on the endpoint.
        /// </para>
        ///  
        /// <para>
        /// • Your MediaTailor source location base URL must be a MediaPackage V2 endpoint.
        /// </para>
        ///  
        /// <para>
        /// • The caller of the API must have <c>mediapackagev2:GetObject</c> IAM permissions
        /// to read all top level manifests referenced by the MediaTailor source packaging configurations.
        /// </para>
        ///  
        /// <para>
        /// Before you can use <c>AUTODETECT_SIGV4</c> with an Amazon S3 bucket, you must meet
        /// these requirements:
        /// </para>
        ///  
        /// <para>
        /// • You must grant MediaTailor access to your S3 bucket by granting <c>mediatailor.amazonaws.com</c>
        /// principal access in IAM. For more information about configuring access in IAM, see
        /// <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access.html">Access management</a>
        /// in the <i>IAM User Guide.</i>.
        /// </para>
        ///  
        /// <para>
        /// • The <c>mediatailor.amazonaws.com</c> service principal must have permissions to
        /// read all top-level manifests referenced by the <c>VodSource</c> packaging configurations.
        /// </para>
        ///  
        /// <para>
        /// • The caller of the API must have <c>s3:GetObject</c> IAM permissions to read all
        /// top level manifests referenced by your MediaTailor <c>VodSource</c> packaging configurations.
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