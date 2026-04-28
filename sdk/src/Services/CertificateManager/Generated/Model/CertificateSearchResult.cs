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
    /// Contains information about a certificate returned by the <a>SearchCertificates</a>
    /// action. This structure includes the certificate ARN, X.509 attributes, and ACM metadata.
    /// </summary>
    public partial class CertificateSearchResult
    {
        private string _certificateArn;
        private CertificateMetadata _certificateMetadata;
        private X509Attributes _x509Attributes;

        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the certificate.
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
        /// Gets and sets the property CertificateMetadata. 
        /// <para>
        /// ACM-specific metadata about the certificate.
        /// </para>
        /// </summary>
        public CertificateMetadata CertificateMetadata
        {
            get { return this._certificateMetadata; }
            set { this._certificateMetadata = value; }
        }

        // Check to see if CertificateMetadata property is set
        internal bool IsSetCertificateMetadata()
        {
            return this._certificateMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property X509Attributes. 
        /// <para>
        /// X.509 certificate attributes such as subject, issuer, and validity period.
        /// </para>
        /// </summary>
        public X509Attributes X509Attributes
        {
            get { return this._x509Attributes; }
            set { this._x509Attributes = value; }
        }

        // Check to see if X509Attributes property is set
        internal bool IsSetX509Attributes()
        {
            return this._x509Attributes != null;
        }

    }
}