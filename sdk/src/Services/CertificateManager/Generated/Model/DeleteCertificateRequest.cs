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
    /// Container for the parameters to the DeleteCertificate operation.
    /// Deletes a certificate and its associated private key. If this action succeeds, the
    /// certificate no longer appears in the list that can be displayed by calling the <a>ListCertificates</a>
    /// action or be retrieved by calling the <a>GetCertificate</a> action. The certificate
    /// will not be available for use by Amazon Web Services services integrated with ACM.
    /// 
    /// 
    ///  <note> 
    /// <para>
    /// You cannot delete an ACM certificate that is being used by another Amazon Web Services
    /// service. To delete a certificate that is in use, the certificate association must
    /// first be removed.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DeleteCertificateRequest : AmazonCertificateManagerRequest
    {
        private string _certificateArn;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DeleteCertificateRequest() { }

        /// <summary>
        /// Instantiates DeleteCertificateRequest with the parameterized properties
        /// </summary>
        /// <param name="certificateArn">String that contains the ARN of the ACM certificate to be deleted. This must be of the form:  <c>arn:aws:acm:region:123456789012:certificate/12345678-1234-1234-1234-123456789012</c>  For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon Resource Names (ARNs)</a>.</param>
        public DeleteCertificateRequest(string certificateArn)
        {
            _certificateArn = certificateArn;
        }

        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// String that contains the ARN of the ACM certificate to be deleted. This must be of
        /// the form:
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:aws:acm:region:123456789012:certificate/12345678-1234-1234-1234-123456789012</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs)</a>.
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