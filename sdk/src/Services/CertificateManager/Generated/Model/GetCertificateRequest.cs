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
    /// Container for the parameters to the GetCertificate operation.
    /// Retrieves an Amazon-issued certificate and its certificate chain. The chain consists
    /// of the certificate of the issuing CA and the intermediate certificates of any other
    /// subordinate CAs. All of the certificates are base64 encoded. You can use <a href="https://wiki.openssl.org/index.php/Command_Line_Utilities">OpenSSL</a>
    /// to decode the certificates and inspect individual fields.
    /// </summary>
    public partial class GetCertificateRequest : AmazonCertificateManagerRequest
    {
        private string _certificateArn;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public GetCertificateRequest() { }

        /// <summary>
        /// Instantiates GetCertificateRequest with the parameterized properties
        /// </summary>
        /// <param name="certificateArn">String that contains a certificate ARN in the following format:  <code>arn:aws:acm:region:123456789012:certificate/12345678-1234-1234-1234-123456789012</code>  For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon Resource Names (ARNs) and AWS Service Namespaces</a>.</param>
        public GetCertificateRequest(string certificateArn)
        {
            _certificateArn = certificateArn;
        }

        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// String that contains a certificate ARN in the following format:
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

    }
}