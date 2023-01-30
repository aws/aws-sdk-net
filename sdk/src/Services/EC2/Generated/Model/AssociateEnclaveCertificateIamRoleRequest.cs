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
    /// Container for the parameters to the AssociateEnclaveCertificateIamRole operation.
    /// Associates an Identity and Access Management (IAM) role with an Certificate Manager
    /// (ACM) certificate. This enables the certificate to be used by the ACM for Nitro Enclaves
    /// application inside an enclave. For more information, see <a href="https://docs.aws.amazon.com/enclaves/latest/user/nitro-enclave-refapp.html">Certificate
    /// Manager for Nitro Enclaves</a> in the <i>Amazon Web Services Nitro Enclaves User Guide</i>.
    /// 
    ///  
    /// <para>
    /// When the IAM role is associated with the ACM certificate, the certificate, certificate
    /// chain, and encrypted private key are placed in an Amazon S3 location that only the
    /// associated IAM role can access. The private key of the certificate is encrypted with
    /// an Amazon Web Services managed key that has an attached attestation-based key policy.
    /// </para>
    ///  
    /// <para>
    /// To enable the IAM role to access the Amazon S3 object, you must grant it permission
    /// to call <code>s3:GetObject</code> on the Amazon S3 bucket returned by the command.
    /// To enable the IAM role to access the KMS key, you must grant it permission to call
    /// <code>kms:Decrypt</code> on the KMS key returned by the command. For more information,
    /// see <a href="https://docs.aws.amazon.com/enclaves/latest/user/nitro-enclave-refapp.html#add-policy">
    /// Grant the role permission to access the certificate and encryption key</a> in the
    /// <i>Amazon Web Services Nitro Enclaves User Guide</i>.
    /// </para>
    /// </summary>
    public partial class AssociateEnclaveCertificateIamRoleRequest : AmazonEC2Request
    {
        private string _certificateArn;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// The ARN of the ACM certificate with which to associate the IAM role.
        /// </para>
        /// </summary>
        public string CertificateArn
        {
            get { return this._certificateArn; }
            set { this._certificateArn = value; }
        }

        // Check to see if CertificateArn property is set
        internal bool IsSetCertificateArn()
        {
            return this._certificateArn != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the IAM role to associate with the ACM certificate. You can associate up
        /// to 16 IAM roles with an ACM certificate.
        /// </para>
        /// </summary>
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

    }
}