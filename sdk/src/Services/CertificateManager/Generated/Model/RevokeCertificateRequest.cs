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
 * Do not modify this file. This file is generated from the acm-2015-12-08.normal.json service model.
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
namespace Amazon.CertificateManager.Model
{
    /// <summary>
    /// Container for the parameters to the RevokeCertificate operation.
    /// Revokes a public ACM certificate. You can only revoke certificates that have been
    /// previously exported.
    /// </summary>
    public partial class RevokeCertificateRequest : AmazonCertificateManagerRequest
    {
        private string _certificateArn;
        private RevocationReason _revocationReason;

        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the public or private certificate that will be revoked.
        /// The ARN must have the following form: 
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:aws:acm:region:account:certificate/12345678-1234-1234-1234-123456789012</c>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
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
        /// Gets and sets the property RevocationReason. 
        /// <para>
        /// Specifies why you revoked the certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RevocationReason RevocationReason
        {
            get { return this._revocationReason; }
            set { this._revocationReason = value; }
        }

        // Check to see if RevocationReason property is set
        internal bool IsSetRevocationReason()
        {
            return this._revocationReason != null;
        }

    }
}