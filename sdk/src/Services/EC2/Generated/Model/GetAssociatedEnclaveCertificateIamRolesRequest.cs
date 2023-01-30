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
    /// Container for the parameters to the GetAssociatedEnclaveCertificateIamRoles operation.
    /// Returns the IAM roles that are associated with the specified ACM (ACM) certificate.
    /// It also returns the name of the Amazon S3 bucket and the Amazon S3 object key where
    /// the certificate, certificate chain, and encrypted private key bundle are stored, and
    /// the ARN of the KMS key that's used to encrypt the private key.
    /// </summary>
    public partial class GetAssociatedEnclaveCertificateIamRolesRequest : AmazonEC2Request
    {
        private string _certificateArn;

        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// The ARN of the ACM certificate for which to view the associated IAM roles, encryption
        /// keys, and Amazon S3 object information.
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

    }
}