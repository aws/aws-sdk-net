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
    ///  <b>CREATING:</b> ACM PCA is creating your private certificate authority.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>PENDING_CERTIFICATE:</b> The certificate is pending. You must use your on-premises
    /// root or subordinate CA to sign your private CA CSR and then import it into PCA. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>ACTIVE:</b> Your private CA is active.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>DISABLED:</b> Your private CA has been disabled.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>EXPIRED:</b> Your private CA certificate has expired.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>FAILED:</b> Your private CA has failed. Your CA can fail for problems such a network
    /// outage or backend AWS failure or other errors. A failed CA can never return to the
    /// pending state. You must create a new CA. 
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