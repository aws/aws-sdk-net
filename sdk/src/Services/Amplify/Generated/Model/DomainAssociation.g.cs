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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property AutoSubDomainCreationPatterns. 
        /// <para>
        ///  Sets branch patterns for automatic subdomain creation. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AutoSubDomainCreationPatterns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AutoSubDomainCreationPatterns property is set.
        /// </summary>
        internal bool IsSetAutoSubDomainCreationPatterns() => this.AutoSubDomainCreationPatterns != null && (this.AutoSubDomainCreationPatterns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AutoSubDomainIAMRole. 
        /// <para>
        ///  The required AWS Identity and Access Management (IAM) service role for the Amazon
        /// Resource Name (ARN) for automatically creating subdomains. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string AutoSubDomainIAMRole { get; set; }

        /// <summary>
        /// Checks to see if the AutoSubDomainIAMRole property is set.
        /// </summary>
        internal bool IsSetAutoSubDomainIAMRole() => this.AutoSubDomainIAMRole != null;

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
        public Certificate Certificate { get; set; }

        /// <summary>
        /// Checks to see if the Certificate property is set.
        /// </summary>
        internal bool IsSetCertificate() => this.Certificate != null;

        /// <summary>
        /// Gets and sets the property CertificateVerificationDNSRecord. 
        /// <para>
        ///  The DNS record for certificate verification. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string CertificateVerificationDNSRecord { get; set; }

        /// <summary>
        /// Checks to see if the CertificateVerificationDNSRecord property is set.
        /// </summary>
        internal bool IsSetCertificateVerificationDNSRecord() => this.CertificateVerificationDNSRecord != null;

        /// <summary>
        /// Gets and sets the property DomainAssociationArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) for the domain association. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1000)]
        public string DomainAssociationArn { get; set; }

        /// <summary>
        /// Checks to see if the DomainAssociationArn property is set.
        /// </summary>
        internal bool IsSetDomainAssociationArn() => this.DomainAssociationArn != null;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        ///  The name of the domain. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 64)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property DomainStatus. 
        /// <para>
        ///  The current status of the domain association. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DomainStatus DomainStatus { get; set; }

        /// <summary>
        /// Checks to see if the DomainStatus property is set.
        /// </summary>
        internal bool IsSetDomainStatus() => this.DomainStatus != null;

        /// <summary>
        /// Gets and sets the property EnableAutoSubDomain. 
        /// <para>
        ///  Enables the automated creation of subdomains for branches. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? EnableAutoSubDomain { get; set; }

        /// <summary>
        /// Checks to see if the EnableAutoSubDomain property is set.
        /// </summary>
        internal bool IsSetEnableAutoSubDomain() => this.EnableAutoSubDomain.HasValue;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        ///  Additional information that describes why the domain association is in the current
        /// state.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1000)]
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

        /// <summary>
        /// Gets and sets the property SubDomains. 
        /// <para>
        ///  The subdomains for the domain association. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 500)]
        public List<SubDomain> SubDomains { get; set; } = AWSConfigs.InitializeCollections ? new List<SubDomain>() : null;

        /// <summary>
        /// Checks to see if the SubDomains property is set.
        /// </summary>
        internal bool IsSetSubDomains() => this.SubDomains != null && (this.SubDomains.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// If your custom domain is on Route 53, Amplify handles this for you automatically.
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
        public UpdateStatus UpdateStatus { get; set; }

        /// <summary>
        /// Checks to see if the UpdateStatus property is set.
        /// </summary>
        internal bool IsSetUpdateStatus() => this.UpdateStatus != null;
    }
}
