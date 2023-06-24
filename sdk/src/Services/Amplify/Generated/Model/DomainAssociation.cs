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
 * Do not modify this file. This file is generated from the amplify-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Amplify.Model
{
    /// <summary>
    /// Describes a domain association that associates a custom domain with an Amplify app.
    /// </summary>
    public partial class DomainAssociation
    {
        private List<string> _autoSubDomainCreationPatterns = new List<string>();
        private string _autoSubDomainIAMRole;
        private string _certificateVerificationDNSRecord;
        private string _domainAssociationArn;
        private string _domainName;
        private DomainStatus _domainStatus;
        private bool? _enableAutoSubDomain;
        private string _statusReason;
        private List<SubDomain> _subDomains = new List<SubDomain>();

        /// <summary>
        /// Gets and sets the property AutoSubDomainCreationPatterns. 
        /// <para>
        ///  Sets branch patterns for automatic subdomain creation. 
        /// </para>
        /// </summary>
        public List<string> AutoSubDomainCreationPatterns
        {
            get { return this._autoSubDomainCreationPatterns; }
            set { this._autoSubDomainCreationPatterns = value; }
        }

        // Check to see if AutoSubDomainCreationPatterns property is set
        internal bool IsSetAutoSubDomainCreationPatterns()
        {
            return this._autoSubDomainCreationPatterns != null && this._autoSubDomainCreationPatterns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AutoSubDomainIAMRole. 
        /// <para>
        ///  The required AWS Identity and Access Management (IAM) service role for the Amazon
        /// Resource Name (ARN) for automatically creating subdomains. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=1000)]
        public string AutoSubDomainIAMRole
        {
            get { return this._autoSubDomainIAMRole; }
            set { this._autoSubDomainIAMRole = value; }
        }

        // Check to see if AutoSubDomainIAMRole property is set
        internal bool IsSetAutoSubDomainIAMRole()
        {
            return this._autoSubDomainIAMRole != null;
        }

        /// <summary>
        /// Gets and sets the property CertificateVerificationDNSRecord. 
        /// <para>
        ///  The DNS record for certificate verification. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=1000)]
        public string CertificateVerificationDNSRecord
        {
            get { return this._certificateVerificationDNSRecord; }
            set { this._certificateVerificationDNSRecord = value; }
        }

        // Check to see if CertificateVerificationDNSRecord property is set
        internal bool IsSetCertificateVerificationDNSRecord()
        {
            return this._certificateVerificationDNSRecord != null;
        }

        /// <summary>
        /// Gets and sets the property DomainAssociationArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) for the domain association. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1000)]
        public string DomainAssociationArn
        {
            get { return this._domainAssociationArn; }
            set { this._domainAssociationArn = value; }
        }

        // Check to see if DomainAssociationArn property is set
        internal bool IsSetDomainAssociationArn()
        {
            return this._domainAssociationArn != null;
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        ///  The name of the domain. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=64)]
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
        /// Gets and sets the property DomainStatus. 
        /// <para>
        ///  The current status of the domain association. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DomainStatus DomainStatus
        {
            get { return this._domainStatus; }
            set { this._domainStatus = value; }
        }

        // Check to see if DomainStatus property is set
        internal bool IsSetDomainStatus()
        {
            return this._domainStatus != null;
        }

        /// <summary>
        /// Gets and sets the property EnableAutoSubDomain. 
        /// <para>
        ///  Enables the automated creation of subdomains for branches. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool EnableAutoSubDomain
        {
            get { return this._enableAutoSubDomain.GetValueOrDefault(); }
            set { this._enableAutoSubDomain = value; }
        }

        // Check to see if EnableAutoSubDomain property is set
        internal bool IsSetEnableAutoSubDomain()
        {
            return this._enableAutoSubDomain.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        ///  The reason for the current status of the domain association. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1000)]
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

        /// <summary>
        /// Gets and sets the property SubDomains. 
        /// <para>
        ///  The subdomains for the domain association. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=500)]
        public List<SubDomain> SubDomains
        {
            get { return this._subDomains; }
            set { this._subDomains = value; }
        }

        // Check to see if SubDomains property is set
        internal bool IsSetSubDomains()
        {
            return this._subDomains != null && this._subDomains.Count > 0; 
        }

    }
}