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
 * Do not modify this file. This file is generated from the amplify-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Amplify.Model
{
    /// <summary>
    /// Structure for Domain Association, which associates a custom domain with an Amplify
    /// App.
    /// </summary>
    public partial class DomainAssociation
    {
        private string _certificateVerificationDNSRecord;
        private string _domainAssociationArn;
        private string _domainName;
        private DomainStatus _domainStatus;
        private bool? _enableAutoSubDomain;
        private string _statusReason;
        private List<SubDomain> _subDomains = new List<SubDomain>();

        /// <summary>
        /// Gets and sets the property CertificateVerificationDNSRecord. 
        /// <para>
        ///  DNS Record for certificate verification. 
        /// </para>
        /// </summary>
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
        ///  ARN for the Domain Association. 
        /// </para>
        /// </summary>
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
        ///  Name of the domain. 
        /// </para>
        /// </summary>
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
        ///  Status fo the Domain Association. 
        /// </para>
        /// </summary>
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
        ///  Enables automated creation of Subdomains for branches. 
        /// </para>
        /// </summary>
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
        ///  Reason for the current status of the Domain Association. 
        /// </para>
        /// </summary>
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
        ///  Subdomains for the Domain Association. 
        /// </para>
        /// </summary>
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