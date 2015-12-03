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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// Represents a domain name that is contained in a simpler, more intuitive URL that can
    /// be called.
    /// </summary>
    public partial class GetDomainNameResponse : AmazonWebServiceResponse
    {
        private string _certificateName;
        private DateTime? _certificateUploadDate;
        private string _distributionDomainName;
        private string _name;

        /// <summary>
        /// Gets and sets the property CertificateName. 
        /// <para>
        /// The name of the certificate.
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
        /// Gets and sets the property CertificateUploadDate. 
        /// <para>
        /// The date when the certificate was uploaded, in <a target="_blank" href="http://www.iso.org/iso/home/standards/iso8601.htm">ISO
        /// 8601 format</a>.
        /// </para>
        /// </summary>
        public DateTime CertificateUploadDate
        {
            get { return this._certificateUploadDate.GetValueOrDefault(); }
            set { this._certificateUploadDate = value; }
        }

        // Check to see if CertificateUploadDate property is set
        internal bool IsSetCertificateUploadDate()
        {
            return this._certificateUploadDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DistributionDomainName. 
        /// <para>
        /// The domain name of the Amazon CloudFront distribution. For more information, see the
        /// <a target="_blank" href="http://aws.amazon.com/documentation/cloudfront/">Amazon CloudFront
        /// documentation</a>.
        /// </para>
        /// </summary>
        public string DistributionDomainName
        {
            get { return this._distributionDomainName; }
            set { this._distributionDomainName = value; }
        }

        // Check to see if DistributionDomainName property is set
        internal bool IsSetDistributionDomainName()
        {
            return this._distributionDomainName != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the <a>DomainName</a> resource.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}