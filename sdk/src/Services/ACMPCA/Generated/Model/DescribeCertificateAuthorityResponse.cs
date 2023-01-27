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
 * Do not modify this file. This file is generated from the acm-pca-2017-08-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ACMPCA.Model
{
    /// <summary>
    /// This is the response object from the DescribeCertificateAuthority operation.
    /// </summary>
    public partial class DescribeCertificateAuthorityResponse : AmazonWebServiceResponse
    {
        private CertificateAuthority _certificateAuthority;

        /// <summary>
        /// Gets and sets the property CertificateAuthority. 
        /// <para>
        /// A <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_CertificateAuthority.html">CertificateAuthority</a>
        /// structure that contains information about your private CA.
        /// </para>
        /// </summary>
        public CertificateAuthority CertificateAuthority
        {
            get { return this._certificateAuthority; }
            set { this._certificateAuthority = value; }
        }

        // Check to see if CertificateAuthority property is set
        internal bool IsSetCertificateAuthority()
        {
            return this._certificateAuthority != null;
        }

    }
}