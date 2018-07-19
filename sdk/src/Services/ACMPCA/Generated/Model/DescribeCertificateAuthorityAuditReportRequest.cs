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
    /// Container for the parameters to the DescribeCertificateAuthorityAuditReport operation.
    /// Lists information about a specific audit report created by calling the <a>CreateCertificateAuthorityAuditReport</a>
    /// operation. Audit information is created every time the certificate authority (CA)
    /// private key is used. The private key is used when you call the <a>IssueCertificate</a>
    /// operation or the <a>RevokeCertificate</a> operation.
    /// </summary>
    public partial class DescribeCertificateAuthorityAuditReportRequest : AmazonACMPCARequest
    {
        private string _auditReportId;
        private string _certificateAuthorityArn;

        /// <summary>
        /// Gets and sets the property AuditReportId. 
        /// <para>
        /// The report ID returned by calling the <a>CreateCertificateAuthorityAuditReport</a>
        /// operation.
        /// </para>
        /// </summary>
        public string AuditReportId
        {
            get { return this._auditReportId; }
            set { this._auditReportId = value; }
        }

        // Check to see if AuditReportId property is set
        internal bool IsSetAuditReportId()
        {
            return this._auditReportId != null;
        }

        /// <summary>
        /// Gets and sets the property CertificateAuthorityArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the private CA. This must be of the form:
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