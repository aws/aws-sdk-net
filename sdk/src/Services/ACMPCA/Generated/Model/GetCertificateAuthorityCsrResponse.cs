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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ACMPCA.Model
{
    /// <summary>
    /// This is the response object from the GetCertificateAuthorityCsr operation.
    /// </summary>
    public partial class GetCertificateAuthorityCsrResponse : AmazonWebServiceResponse
    {
        private string _csr;

        /// <summary>
        /// Gets and sets the property Csr. 
        /// <para>
        /// The base64 PEM-encoded certificate signing request (CSR) for your private CA certificate.
        /// </para>
        /// </summary>
        public string Csr
        {
            get { return this._csr; }
            set { this._csr = value; }
        }

        // Check to see if Csr property is set
        internal bool IsSetCsr()
        {
            return this._csr != null;
        }

    }
}