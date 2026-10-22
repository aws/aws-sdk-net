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
    /// Describes the full details of an Amazon Lightsail SSL/TLS certificate.
    /// 
    ///  <note> 
    /// <para>
    /// To get a summary of a certificate, use the <c>GetCertificates</c> action and omit
    /// <c>includeCertificateDetails</c> from your request. The response will include only
    /// the certificate Amazon Resource Name (ARN), certificate name, domain name, and tags.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class Certificate
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the certificate.
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
        /// The timestamp when the certificate was created.
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
        /// The domain name of the certificate.
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
        /// An array of objects that describe the domain validation records of the certificate.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DomainValidationRecord> DomainValidationRecords { get; set; } = AWSConfigs.InitializeCollections ? new List<DomainValidationRecord>() : null;

        /// <summary>
        /// Checks to see if the DomainValidationRecords property is set.
        /// </summary>
        internal bool IsSetDomainValidationRecords() => this.DomainValidationRecords != null && (this.DomainValidationRecords.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EligibleToRenew. 
        /// <para>
        /// The renewal eligibility of the certificate.
        /// </para>
        /// </summary>
        public string EligibleToRenew { get; set; }

        /// <summary>
        /// Checks to see if the EligibleToRenew property is set.
        /// </summary>
        internal bool IsSetEligibleToRenew() => this.EligibleToRenew != null;

        /// <summary>
        /// Gets and sets the property InUseResourceCount. 
        /// <para>
        /// The number of Lightsail resources that the certificate is attached to.
        /// </para>
        /// </summary>
        public int? InUseResourceCount { get; set; }

        /// <summary>
        /// Checks to see if the InUseResourceCount property is set.
        /// </summary>
        internal bool IsSetInUseResourceCount() => this.InUseResourceCount.HasValue;

        /// <summary>
        /// Gets and sets the property IssuedAt. 
        /// <para>
        /// The timestamp when the certificate was issued.
        /// </para>
        /// </summary>
        public DateTime? IssuedAt { get; set; }

        /// <summary>
        /// Checks to see if the IssuedAt property is set.
        /// </summary>
        internal bool IsSetIssuedAt() => this.IssuedAt.HasValue;

        /// <summary>
        /// Gets and sets the property IssuerCA. 
        /// <para>
        /// The certificate authority that issued the certificate.
        /// </para>
        /// </summary>
        public string IssuerCA { get; set; }

        /// <summary>
        /// Checks to see if the IssuerCA property is set.
        /// </summary>
        internal bool IsSetIssuerCA() => this.IssuerCA != null;

        /// <summary>
        /// Gets and sets the property KeyAlgorithm. 
        /// <para>
        /// The algorithm used to generate the key pair (the public and private key) of the certificate.
        /// </para>
        /// </summary>
        public string KeyAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the KeyAlgorithm property is set.
        /// </summary>
        internal bool IsSetKeyAlgorithm() => this.KeyAlgorithm != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the certificate (<c>my-certificate</c>).
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
        /// The timestamp when the certificate expires.
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
        /// The timestamp when the certificate is first valid.
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
        public RenewalSummary RenewalSummary { get; set; }

        /// <summary>
        /// Checks to see if the RenewalSummary property is set.
        /// </summary>
        internal bool IsSetRenewalSummary() => this.RenewalSummary != null;

        /// <summary>
        /// Gets and sets the property RequestFailureReason. 
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
        /// the required information, use the <a href="https://console.aws.amazon.com/support/home">Amazon
        /// Web Services Support Center</a> to contact Amazon Web Services Support.
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
        /// the <a href="https://console.aws.amazon.com/support/home">Amazon Web Services Support
        /// Center</a> and create a case.
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
        public string RequestFailureReason { get; set; }

        /// <summary>
        /// Checks to see if the RequestFailureReason property is set.
        /// </summary>
        internal bool IsSetRequestFailureReason() => this.RequestFailureReason != null;

        /// <summary>
        /// Gets and sets the property RevocationReason. 
        /// <para>
        /// The reason the certificate was revoked. This value is present only when the certificate
        /// status is <c>REVOKED</c>.
        /// </para>
        /// </summary>
        public string RevocationReason { get; set; }

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
        /// Gets and sets the property SerialNumber. 
        /// <para>
        /// The serial number of the certificate.
        /// </para>
        /// </summary>
        public string SerialNumber { get; set; }

        /// <summary>
        /// Checks to see if the SerialNumber property is set.
        /// </summary>
        internal bool IsSetSerialNumber() => this.SerialNumber != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The validation status of the certificate.
        /// </para>
        /// </summary>
        public CertificateStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property SubjectAlternativeNames. 
        /// <para>
        /// An array of strings that specify the alternate domains (<c>example2.com</c>) and subdomains
        /// (<c>blog.example.com</c>) of the certificate.
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
        /// about your Lightsail certificate. This code enables our support team to look up your
        /// Lightsail information more easily.
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
