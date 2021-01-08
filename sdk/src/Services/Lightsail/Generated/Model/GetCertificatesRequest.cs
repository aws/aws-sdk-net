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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the GetCertificates operation.
    /// Returns information about one or more Amazon Lightsail SSL/TLS certificates.
    /// 
    ///  <note> 
    /// <para>
    /// To get a summary of a certificate, ommit <code>includeCertificateDetails</code> from
    /// your request. The response will include only the certificate Amazon Resource Name
    /// (ARN), certificate name, domain name, and tags.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GetCertificatesRequest : AmazonLightsailRequest
    {
        private string _certificateName;
        private List<string> _certificateStatuses = new List<string>();
        private bool? _includeCertificateDetails;

        /// <summary>
        /// Gets and sets the property CertificateName. 
        /// <para>
        /// The name for the certificate for which to return information.
        /// </para>
        ///  
        /// <para>
        /// When omitted, the response includes all of your certificates in the AWS Region where
        /// the request is made.
        /// </para>
        /// </summary>
        public string CertificateName
        {
            get { return this._certificateName; }
            set { this._certificateName = value; }
        }

        // Check to see if CertificateName property is set
        internal bool IsSetCertificateName()
        {
            return this._certificateName != null;
        }

        /// <summary>
        /// Gets and sets the property CertificateStatuses. 
        /// <para>
        /// The status of the certificates for which to return information.
        /// </para>
        ///  
        /// <para>
        /// For example, specify <code>ISSUED</code> to return only certificates with an <code>ISSUED</code>
        /// status.
        /// </para>
        ///  
        /// <para>
        /// When omitted, the response includes all of your certificates in the AWS Region where
        /// the request is made, regardless of their current status.
        /// </para>
        /// </summary>
        public List<string> CertificateStatuses
        {
            get { return this._certificateStatuses; }
            set { this._certificateStatuses = value; }
        }

        // Check to see if CertificateStatuses property is set
        internal bool IsSetCertificateStatuses()
        {
            return this._certificateStatuses != null && this._certificateStatuses.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IncludeCertificateDetails. 
        /// <para>
        /// Indicates whether to include detailed information about the certificates in the response.
        /// </para>
        ///  
        /// <para>
        /// When omitted, the response includes only the certificate names, Amazon Resource Names
        /// (ARNs), domain names, and tags.
        /// </para>
        /// </summary>
        public bool IncludeCertificateDetails
        {
            get { return this._includeCertificateDetails.GetValueOrDefault(); }
            set { this._includeCertificateDetails = value; }
        }

        // Check to see if IncludeCertificateDetails property is set
        internal bool IsSetIncludeCertificateDetails()
        {
            return this._includeCertificateDetails.HasValue; 
        }

    }
}