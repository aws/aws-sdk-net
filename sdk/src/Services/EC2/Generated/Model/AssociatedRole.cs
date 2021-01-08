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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Information about the associated IAM roles.
    /// </summary>
    public partial class AssociatedRole
    {
        private string _associatedRoleArn;
        private string _certificateS3BucketName;
        private string _certificateS3ObjectKey;
        private string _encryptionKmsKeyId;

        /// <summary>
        /// Gets and sets the property AssociatedRoleArn. 
        /// <para>
        /// The ARN of the associated IAM role.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1283)]
        public string AssociatedRoleArn
        {
            get { return this._associatedRoleArn; }
            set { this._associatedRoleArn = value; }
        }

        // Check to see if AssociatedRoleArn property is set
        internal bool IsSetAssociatedRoleArn()
        {
            return this._associatedRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property CertificateS3BucketName. 
        /// <para>
        /// The name of the Amazon S3 bucket in which the Amazon S3 object is stored.
        /// </para>
        /// </summary>
        public string CertificateS3BucketName
        {
            get { return this._certificateS3BucketName; }
            set { this._certificateS3BucketName = value; }
        }

        // Check to see if CertificateS3BucketName property is set
        internal bool IsSetCertificateS3BucketName()
        {
            return this._certificateS3BucketName != null;
        }

        /// <summary>
        /// Gets and sets the property CertificateS3ObjectKey. 
        /// <para>
        /// The key of the Amazon S3 object ey where the certificate, certificate chain, and encrypted
        /// private key bundle is stored. The object key is formated as follows: <code>certificate_arn</code>/<code>role_arn</code>.
        /// 
        /// </para>
        /// </summary>
        public string CertificateS3ObjectKey
        {
            get { return this._certificateS3ObjectKey; }
            set { this._certificateS3ObjectKey = value; }
        }

        // Check to see if CertificateS3ObjectKey property is set
        internal bool IsSetCertificateS3ObjectKey()
        {
            return this._certificateS3ObjectKey != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionKmsKeyId. 
        /// <para>
        /// The ID of the KMS customer master key (CMK) used to encrypt the private key.
        /// </para>
        /// </summary>
        public string EncryptionKmsKeyId
        {
            get { return this._encryptionKmsKeyId; }
            set { this._encryptionKmsKeyId = value; }
        }

        // Check to see if EncryptionKmsKeyId property is set
        internal bool IsSetEncryptionKmsKeyId()
        {
            return this._encryptionKmsKeyId != null;
        }

    }
}