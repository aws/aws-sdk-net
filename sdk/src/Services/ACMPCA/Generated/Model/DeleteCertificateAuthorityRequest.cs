/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the acm-pca-2017-08-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ACMPCA.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteCertificateAuthority operation.
    /// Deletes the private certificate authority (CA) that you created or started to create
    /// by calling the <a>CreateCertificateAuthority</a> function. This action requires that
    /// you enter an ARN (Amazon Resource Name) for the private CA that you want to delete.
    /// You can find the ARN by calling the <a>ListCertificateAuthorities</a> function. You
    /// can delete the CA if you are waiting for it to be created (the <b>Status</b> field
    /// of the <a>CertificateAuthority</a> is <code>CREATING</code>) or if the CA has been
    /// created but you haven't yet imported the signed certificate (the <b>Status</b> is
    /// <code>PENDING_CERTIFICATE</code>) into ACM PCA. If you've already imported the certificate,
    /// you cannot delete the CA unless it has been disabled for more than 30 days. To disable
    /// a CA, call the <a>UpdateCertificateAuthority</a> function and set the <b>CertificateAuthorityStatus</b>
    /// argument to <code>DISABLED</code>.
    /// </summary>
    public partial class DeleteCertificateAuthorityRequest : AmazonACMPCARequest
    {
        private string _certificateAuthorityArn;

        /// <summary>
        /// Gets and sets the property CertificateAuthorityArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that was returned when you called <a>CreateCertificateAuthority</a>.
        /// This must be of the form: 
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:acm:<i>region</i>:<i>account</i>:certificate-authority/<i>12345678-1234-1234-1234-123456789012</i>
        /// </code>. 
        /// </para>
        /// </summary>
        public string CertificateAuthorityArn
        {
            get { return this._certificateAuthorityArn; }
            set { this._certificateAuthorityArn = value; }
        }

        // Check to see if CertificateAuthorityArn property is set
        internal bool IsSetCertificateAuthorityArn()
        {
            return this._certificateAuthorityArn != null;
        }

    }
}