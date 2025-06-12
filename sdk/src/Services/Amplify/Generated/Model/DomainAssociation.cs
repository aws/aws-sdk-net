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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Amplify.Model
{
    /// <summary>
    /// Describes the association between a custom domain and an Amplify app.
    /// </summary>
    public partial class DomainAssociation
    {
        private List<string> _autoSubDomainCreationPatterns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _autoSubDomainIAMRole;
        private Certificate _certificate;
        private string _certificateVerificationDNSRecord;
        private string _domainAssociationArn;
        private string _domainName;
        private DomainStatus _domainStatus;
        private bool? _enableAutoSubDomain;
        private string _statusReason;
        private List<SubDomain> _subDomains = AWSConfigs.InitializeCollections ? new List<SubDomain>() : null;
        private UpdateStatus _updateStatus;

        /// <summary>
        /// Gets and sets the property AutoSubDomainCreationPatterns. 
        /// <para>
        ///  Sets branch patterns for automatic subdomain creation. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AutoSubDomainCreationPatterns
        {
            get { return this._autoSubDomainCreationPatterns; }
            set { this._autoSubDomainCreationPatterns = value; }
        }

        // Check to see if AutoSubDomainCreationPatterns property is set
        internal bool IsSetAutoSubDomainCreationPatterns()
        {
            return this._autoSubDomainCreationPatterns != null && (this._autoSubDomainCreationPatterns.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property Certificate. 
        /// <para>
        /// Describes the SSL/TLS certificate for the domain association. This can be your own
        /// custom certificate or the default certificate that Amplify provisions for you.
        /// </para>
        ///  
        /// <para>
        /// If you are updating your domain to use a different certificate, <c>certificate</c>
        /// points to the new certificate that is being created instead of the current active
        /// certificate. Otherwise, <c>certificate</c> points to the current active certificate.
        /// </para>
        /// </summary>
        public Certificate Certificate
        {
            get { return this._certificate; }
            set { this._certificate = value; }
        }

        // Check to see if Certificate property is set
        internal bool IsSetCertificate()
        {
            return this._certificate != null;
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
        public bool? EnableAutoSubDomain
        {
            get { return this._enableAutoSubDomain; }
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
        ///  Additional information that describes why the domain association is in the current
        /// state.
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._subDomains != null && (this._subDomains.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UpdateStatus. 
        /// <para>
        /// The status of the domain update operation that is currently in progress. The following
        /// list describes the valid update states.
        /// </para>
        ///  <dl> <dt>REQUESTING_CERTIFICATE</dt> <dd> 
        /// <para>
        /// The certificate is in the process of being updated.
        /// </para>
        ///  </dd> <dt>PENDING_VERIFICATION</dt> <dd> 
        /// <para>
        /// Indicates that an Amplify managed certificate is in the process of being verified.
        /// This occurs during the creation of a custom domain or when a custom domain is updated
        /// to use a managed certificate.
        /// </para>
        ///  </dd> <dt>IMPORTING_CUSTOM_CERTIFICATE</dt> <dd> 
        /// <para>
        /// Indicates that an Amplify custom certificate is in the process of being imported.
        /// This occurs during the creation of a custom domain or when a custom domain is updated
        /// to use a custom certificate.
        /// </para>
        ///  </dd> <dt>PENDING_DEPLOYMENT</dt> <dd> 
        /// <para>
        /// Indicates that the subdomain or certificate changes are being propagated.
        /// </para>
        ///  </dd> <dt>AWAITING_APP_CNAME</dt> <dd> 
        /// <para>
        /// Amplify is waiting for CNAME records corresponding to subdomains to be propagated.
        /// If your custom domain is on Route 53, Amplify handles this for you automatically.
        /// For more information about custom domains, see <a href="https://docs.aws.amazon.com/amplify/latest/userguide/custom-domains.html">Setting
        /// up custom domains</a> in the <i>Amplify Hosting User Guide</i>. 
        /// </para>
        ///  </dd> <dt>UPDATE_COMPLETE</dt> <dd> 
        /// <para>
        /// The certificate has been associated with a domain.
        /// </para>
        ///  </dd> <dt>UPDATE_FAILED</dt> <dd> 
        /// <para>
        /// The certificate has failed to be provisioned or associated, and there is no existing
        /// active certificate to roll back to.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public UpdateStatus UpdateStatus
        {
            get { return this._updateStatus; }
            set { this._updateStatus = value; }
        }

        // Check to see if UpdateStatus property is set
        internal bool IsSetUpdateStatus()
        {
            return this._updateStatus != null;
        }

    }
}