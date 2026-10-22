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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes a load balancer SSL/TLS certificate.
    /// 
    ///  
    /// <para>
    /// TLS is just an updated, more secure version of Secure Socket Layer (SSL).
    /// </para>
    /// </summary>
    public partial class LoadBalancerTlsCertificate
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the SSL/TLS certificate.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time when you created your SSL/TLS certificate.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The domain name for your SSL/TLS certificate.
        /// </para>
        /// </summary>
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property DomainValidationRecords. 
        /// <para>
        /// An array of LoadBalancerTlsCertificateDomainValidationRecord objects describing the
        /// records.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LoadBalancerTlsCertificateDomainValidationRecord> DomainValidationRecords { get; set; } = AWSConfigs.InitializeCollections ? new List<LoadBalancerTlsCertificateDomainValidationRecord>() : null;

        /// <summary>
        /// Checks to see if the DomainValidationRecords property is set.
        /// </summary>
        internal bool IsSetDomainValidationRecords() => this.DomainValidationRecords != null && (this.DomainValidationRecords.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The validation failure reason, if any, of the certificate.
        /// </para>
        ///  
        /// <para>
        /// The following failure reasons are possible:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <c>NO_AVAILABLE_CONTACTS</c> </b> - This failure applies to email validation,
        /// which is not available for Lightsail certificates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>ADDITIONAL_VERIFICATION_REQUIRED</c> </b> - Lightsail requires additional
        /// information to process this certificate request. This can happen as a fraud-protection
        /// measure, such as when the domain ranks within the Alexa top 1000 websites. To provide
        /// the required information, use the <a href="https://console.aws.amazon.com/support/home">AWS
        /// Support Center</a> to contact AWS Support.
        /// </para>
        ///  <note> 
        /// <para>
        /// You cannot request a certificate for Amazon-owned domain names such as those ending
        /// in amazonaws.com, cloudfront.net, or elasticbeanstalk.com.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        ///  <b> <c>DOMAIN_NOT_ALLOWED</c> </b> - One or more of the domain names in the certificate
        /// request was reported as an unsafe domain by <a href="https://www.virustotal.com/gui/home/url">VirusTotal</a>.
        /// To correct the problem, search for your domain name on the <a href="https://www.virustotal.com/gui/home/url">VirusTotal</a>
        /// website. If your domain is reported as suspicious, see <a href="https://developers.google.com/web/fundamentals/security/hacked">Google
        /// Help for Hacked Websites</a> to learn what you can do.
        /// </para>
        ///  
        /// <para>
        /// If you believe that the result is a false positive, notify the organization that is
        /// reporting the domain. VirusTotal is an aggregate of several antivirus and URL scanners
        /// and cannot remove your domain from a block list itself. After you correct the problem
        /// and the VirusTotal registry has been updated, request a new certificate.
        /// </para>
        ///  
        /// <para>
        /// If you see this error and your domain is not included in the VirusTotal list, visit
        /// the <a href="https://console.aws.amazon.com/support/home">AWS Support Center</a> and
        /// create a case.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>INVALID_PUBLIC_DOMAIN</c> </b> - One or more of the domain names in the certificate
        /// request is not valid. Typically, this is because a domain name in the request is not
        /// a valid top-level domain. Try to request a certificate again, correcting any spelling
        /// errors or typos that were in the failed request, and ensure that all domain names
        /// in the request are for valid top-level domains. For example, you cannot request a
        /// certificate for <c>example.invalidpublicdomain</c> because <c>invalidpublicdomain</c>
        /// is not a valid top-level domain.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>OTHER</c> </b> - Typically, this failure occurs when there is a typographical
        /// error in one or more of the domain names in the certificate request. Try to request
        /// a certificate again, correcting any spelling errors or typos that were in the failed
        /// request. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public LoadBalancerTlsCertificateFailureReason FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property IsAttached. 
        /// <para>
        /// When <c>true</c>, the SSL/TLS certificate is attached to the Lightsail load balancer.
        /// </para>
        /// </summary>
        public bool? IsAttached { get; set; }

        /// <summary>
        /// Checks to see if the IsAttached property is set.
        /// </summary>
        internal bool IsSetIsAttached() => this.IsAttached.HasValue;

        /// <summary>
        /// Gets and sets the property IssuedAt. 
        /// <para>
        /// The time when the SSL/TLS certificate was issued.
        /// </para>
        /// </summary>
        public DateTime? IssuedAt { get; set; }

        /// <summary>
        /// Checks to see if the IssuedAt property is set.
        /// </summary>
        internal bool IsSetIssuedAt() => this.IssuedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Issuer. 
        /// <para>
        /// The issuer of the certificate.
        /// </para>
        /// </summary>
        public string Issuer { get; set; }

        /// <summary>
        /// Checks to see if the Issuer property is set.
        /// </summary>
        internal bool IsSetIssuer() => this.Issuer != null;

        /// <summary>
        /// Gets and sets the property KeyAlgorithm. 
        /// <para>
        /// The algorithm used to generate the key pair (the public and private key).
        /// </para>
        /// </summary>
        public string KeyAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the KeyAlgorithm property is set.
        /// </summary>
        internal bool IsSetKeyAlgorithm() => this.KeyAlgorithm != null;

        /// <summary>
        /// Gets and sets the property LoadBalancerName. 
        /// <para>
        /// The load balancer name where your SSL/TLS certificate is attached.
        /// </para>
        /// </summary>
        public string LoadBalancerName { get; set; }

        /// <summary>
        /// Checks to see if the LoadBalancerName property is set.
        /// </summary>
        internal bool IsSetLoadBalancerName() => this.LoadBalancerName != null;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The Amazon Web Services Region and Availability Zone where you created your certificate.
        /// </para>
        /// </summary>
        public ResourceLocation Location { get; set; }

        /// <summary>
        /// Checks to see if the Location property is set.
        /// </summary>
        internal bool IsSetLocation() => this.Location != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the SSL/TLS certificate (<c>my-certificate</c>).
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NotAfter. 
        /// <para>
        /// The timestamp when the SSL/TLS certificate expires.
        /// </para>
        /// </summary>
        public DateTime? NotAfter { get; set; }

        /// <summary>
        /// Checks to see if the NotAfter property is set.
        /// </summary>
        internal bool IsSetNotAfter() => this.NotAfter.HasValue;

        /// <summary>
        /// Gets and sets the property NotBefore. 
        /// <para>
        /// The timestamp when the SSL/TLS certificate is first valid.
        /// </para>
        /// </summary>
        public DateTime? NotBefore { get; set; }

        /// <summary>
        /// Checks to see if the NotBefore property is set.
        /// </summary>
        internal bool IsSetNotBefore() => this.NotBefore.HasValue;

        /// <summary>
        /// Gets and sets the property RenewalSummary. 
        /// <para>
        /// An object that describes the status of the certificate renewal managed by Lightsail.
        /// </para>
        /// </summary>
        public LoadBalancerTlsCertificateRenewalSummary RenewalSummary { get; set; }

        /// <summary>
        /// Checks to see if the RenewalSummary property is set.
        /// </summary>
        internal bool IsSetRenewalSummary() => this.RenewalSummary != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The resource type (<c>LoadBalancerTlsCertificate</c>).
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <c>Instance</c> </b> - A Lightsail instance (a virtual private server)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>StaticIp</c> </b> - A static IP address
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>KeyPair</c> </b> - The key pair used to connect to a Lightsail instance
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>InstanceSnapshot</c> </b> - A Lightsail instance snapshot
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>Domain</c> </b> - A DNS zone
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>PeeredVpc</c> </b> - A peered VPC
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>LoadBalancer</c> </b> - A Lightsail load balancer
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>LoadBalancerTlsCertificate</c> </b> - An SSL/TLS certificate associated with
        /// a Lightsail load balancer
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>Disk</c> </b> - A Lightsail block storage disk
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <c>DiskSnapshot</c> </b> - A block storage disk snapshot
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property RevocationReason. 
        /// <para>
        /// The reason the certificate was revoked. This value is present only when the certificate
        /// status is <c>REVOKED</c>.
        /// </para>
        /// </summary>
        public LoadBalancerTlsCertificateRevocationReason RevocationReason { get; set; }

        /// <summary>
        /// Checks to see if the RevocationReason property is set.
        /// </summary>
        internal bool IsSetRevocationReason() => this.RevocationReason != null;

        /// <summary>
        /// Gets and sets the property RevokedAt. 
        /// <para>
        /// The timestamp when the certificate was revoked. This value is present only when the
        /// certificate status is <c>REVOKED</c>.
        /// </para>
        /// </summary>
        public DateTime? RevokedAt { get; set; }

        /// <summary>
        /// Checks to see if the RevokedAt property is set.
        /// </summary>
        internal bool IsSetRevokedAt() => this.RevokedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Serial. 
        /// <para>
        /// The serial number of the certificate.
        /// </para>
        /// </summary>
        public string Serial { get; set; }

        /// <summary>
        /// Checks to see if the Serial property is set.
        /// </summary>
        internal bool IsSetSerial() => this.Serial != null;

        /// <summary>
        /// Gets and sets the property SignatureAlgorithm. 
        /// <para>
        /// The algorithm that was used to sign the certificate.
        /// </para>
        /// </summary>
        public string SignatureAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the SignatureAlgorithm property is set.
        /// </summary>
        internal bool IsSetSignatureAlgorithm() => this.SignatureAlgorithm != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The validation status of the SSL/TLS certificate. Valid values are below.
        /// </para>
        /// </summary>
        public LoadBalancerTlsCertificateStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Subject. 
        /// <para>
        /// The name of the entity that is associated with the public key contained in the certificate.
        /// </para>
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Checks to see if the Subject property is set.
        /// </summary>
        internal bool IsSetSubject() => this.Subject != null;

        /// <summary>
        /// Gets and sets the property SubjectAlternativeNames. 
        /// <para>
        /// An array of strings that specify the alternate domains (<c>example2.com</c>) and subdomains
        /// (<c>blog.example.com</c>) for the certificate.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SubjectAlternativeNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SubjectAlternativeNames property is set.
        /// </summary>
        internal bool IsSetSubjectAlternativeNames() => this.SubjectAlternativeNames != null && (this.SubjectAlternativeNames.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SupportCode. 
        /// <para>
        /// The support code. Include this code in your email to support when you have questions
        /// about your Lightsail load balancer or SSL/TLS certificate. This code enables our support
        /// team to look up your Lightsail information more easily.
        /// </para>
        /// </summary>
        public string SupportCode { get; set; }

        /// <summary>
        /// Checks to see if the SupportCode property is set.
        /// </summary>
        internal bool IsSetSupportCode() => this.SupportCode != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tag keys and optional values for the resource. For more information about tags
        /// in Lightsail, see the <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-tags">Amazon
        /// Lightsail Developer Guide</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
