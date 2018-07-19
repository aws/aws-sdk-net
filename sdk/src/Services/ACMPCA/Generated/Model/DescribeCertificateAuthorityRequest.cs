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
    /// Container for the parameters to the DescribeCertificateAuthority operation.
    /// Lists information about your private certificate authority (CA). You specify the private
    /// CA on input by its ARN (Amazon Resource Name). The output contains the status of your
    /// CA. This can be any of the following: 
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <code>CREATING</code> - ACM PCA is creating your private certificate authority.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>PENDING_CERTIFICATE</code> - The certificate is pending. You must use your
    /// on-premises root or subordinate CA to sign your private CA CSR and then import it
    /// into PCA. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>ACTIVE</code> - Your private CA is active.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DISABLED</code> - Your private CA has been disabled.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>EXPIRED</code> - Your private CA certificate has expired.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>FAILED</code> - Your private CA has failed. Your CA can fail because of problems
    /// such a network outage or backend AWS failure or other errors. A failed CA can never
    /// return to the pending state. You must create a new CA. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>DELETED</code> - Your private CA is within the restoration period, after which
    /// it will be permanently deleted. The length of time remaining in the CA's restoration
    /// period will also be included in this operation's output.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DescribeCertificateAuthorityRequest : AmazonACMPCARequest
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
        ///  <code>arn:aws:acm-pca:<i>region</i>:<i>account</i>:certificate-authority/<i>12345678-1234-1234-1234-123456789012</i>
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