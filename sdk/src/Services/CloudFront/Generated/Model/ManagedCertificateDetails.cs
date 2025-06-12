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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
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
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Contains details about the CloudFront managed ACM certificate.
    /// </summary>
    public partial class ManagedCertificateDetails
    {
        private string _certificateArn;
        private ManagedCertificateStatus _certificateStatus;
        private List<ValidationTokenDetail> _validationTokenDetails = AWSConfigs.InitializeCollections ? new List<ValidationTokenDetail>() : null;
        private ValidationTokenHost _validationTokenHost;

        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// The ARN of the CloudFront managed ACM certificate.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property CertificateStatus. 
        /// <para>
        /// The status of the CloudFront managed ACM certificate.
        /// </para>
        ///  <note> 
        /// <para>
        /// Your distribution tenant will be updated with the latest certificate status. When
        /// calling the <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_UpdateDistributionTenant.html">UpdateDistributionTenant</a>
        /// operation, use the latest value for the <c>ETag</c>.
        /// </para>
        ///  </note>
        /// </summary>
        public ManagedCertificateStatus CertificateStatus
        {
            get { return this._certificateStatus; }
            set { this._certificateStatus = value; }
        }

        // Check to see if CertificateStatus property is set
        internal bool IsSetCertificateStatus()
        {
            return this._certificateStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ValidationTokenDetails. 
        /// <para>
        /// Contains details about the validation token of the specified CloudFront managed ACM
        /// certificate.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ValidationTokenDetail> ValidationTokenDetails
        {
            get { return this._validationTokenDetails; }
            set { this._validationTokenDetails = value; }
        }

        // Check to see if ValidationTokenDetails property is set
        internal bool IsSetValidationTokenDetails()
        {
            return this._validationTokenDetails != null && (this._validationTokenDetails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ValidationTokenHost. 
        /// <para>
        /// Contains details about the validation token host of the specified CloudFront managed
        /// ACM certificate.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For <c>cloudfront</c>, CloudFront will automatically serve the validation token. Choose
        /// this mode if you can point the domain's DNS to CloudFront immediately.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For <c>self-hosted</c>, you serve the validation token from your existing infrastructure.
        /// Choose this mode when you need to maintain current traffic flow while your certificate
        /// is being issued. You can place the validation token at the well-known path on your
        /// existing web server, wait for ACM to validate and issue the certificate, and then
        /// update your DNS to point to CloudFront.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// This setting only affects the initial certificate request. Once the DNS points to
        /// CloudFront, all future certificate renewals are automatically handled through CloudFront.
        /// </para>
        ///  </note>
        /// </summary>
        public ValidationTokenHost ValidationTokenHost
        {
            get { return this._validationTokenHost; }
            set { this._validationTokenHost = value; }
        }

        // Check to see if ValidationTokenHost property is set
        internal bool IsSetValidationTokenHost()
        {
            return this._validationTokenHost != null;
        }

    }
}