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

namespace Amazon.CertificateManager.Model
{
    /// <summary>
    /// This structure is returned in the response object of <a>ListCertificates</a> action.
    /// </summary>
    public partial class CertificateSummary
    {
        private string _certificateArn;
        private string _domainName;

        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the certificate. This is of the form:
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:aws:acm:region:123456789012:certificate/12345678-1234-1234-1234-123456789012</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs) and AWS Service Namespaces</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
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
        /// Gets and sets the property DomainName. 
        /// <para>
        /// Fully qualified domain name (FQDN), such as www.example.com or example.com, for the
        /// certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=253)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

    }
}