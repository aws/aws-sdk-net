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
    /// Container for the parameters to the CreateCertificate operation.
    /// Creates an SSL/TLS certificate for a Amazon Lightsail content delivery network (CDN)
    /// distribution.
    /// 
    ///  
    /// <para>
    /// After the certificate is created, use the <code>AttachCertificateToDistribution</code>
    /// action to attach the certificate to your distribution.
    /// </para>
    ///  <important> 
    /// <para>
    /// Only certificates created in the <code>us-east-1</code> AWS Region can be attached
    /// to Lightsail distributions. Lightsail distributions are global resources that can
    /// reference an origin in any AWS Region, and distribute its content globally. However,
    /// all distributions are located in the <code>us-east-1</code> Region.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class CreateCertificateRequest : AmazonLightsailRequest
    {
        private string _certificateName;
        private string _domainName;
        private List<string> _subjectAlternativeNames = new List<string>();
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property CertificateName. 
        /// <para>
        /// The name for the certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The domain name (e.g., <code>example.com</code>) for the certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property SubjectAlternativeNames. 
        /// <para>
        /// An array of strings that specify the alternate domains (e.g., <code>example2.com</code>)
        /// and subdomains (e.g., <code>blog.example.com</code>) for the certificate.
        /// </para>
        ///  
        /// <para>
        /// You can specify a maximum of nine alternate domains (in addition to the primary domain
        /// name).
        /// </para>
        ///  
        /// <para>
        /// Wildcard domain entries (e.g., <code>*.example.com</code>) are not supported.
        /// </para>
        /// </summary>
        public List<string> SubjectAlternativeNames
        {
            get { return this._subjectAlternativeNames; }
            set { this._subjectAlternativeNames = value; }
        }

        // Check to see if SubjectAlternativeNames property is set
        internal bool IsSetSubjectAlternativeNames()
        {
            return this._subjectAlternativeNames != null && this._subjectAlternativeNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tag keys and optional values to add to the certificate during create.
        /// </para>
        ///  
        /// <para>
        /// Use the <code>TagResource</code> action to tag a resource after it's created.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}