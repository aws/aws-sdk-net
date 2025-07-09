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
    /// Container for the parameters to the RenewCertificate operation.
    /// Renews an <a href="https://docs.aws.amazon.com/acm/latest/userguide/managed-renewal.html">eligible
    /// ACM certificate</a>. In order to renew your Amazon Web Services Private CA certificates
    /// with ACM, you must first <a href="https://docs.aws.amazon.com/privateca/latest/userguide/PcaPermissions.html">grant
    /// the ACM service principal permission to do so</a>. For more information, see <a href="https://docs.aws.amazon.com/acm/latest/userguide/manual-renewal.html">Testing
    /// Managed Renewal</a> in the ACM User Guide.
    /// </summary>
    public partial class RenewCertificateRequest : AmazonCertificateManagerRequest
    {
        private string _certificateArn;

        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// String that contains the ARN of the ACM certificate to be renewed. This must be of
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