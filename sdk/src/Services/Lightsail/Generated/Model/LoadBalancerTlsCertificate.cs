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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

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
        private string _arn;
        private DateTime? _createdAt;
        private string _domainName;
        private List<LoadBalancerTlsCertificateDomainValidationRecord> _domainValidationRecords = new List<LoadBalancerTlsCertificateDomainValidationRecord>();
        private LoadBalancerTlsCertificateFailureReason _failureReason;
        private bool? _isAttached;
        private DateTime? _issuedAt;
        private string _issuer;
        private string _keyAlgorithm;
        private string _loadBalancerName;
        private ResourceLocation _location;
        private string _name;
        private DateTime? _notAfter;
        private DateTime? _notBefore;
        private LoadBalancerTlsCertificateRenewalSummary _renewalSummary;
        private ResourceType _resourceType;
        private LoadBalancerTlsCertificateRevocationReason _revocationReason;
        private DateTime? _revokedAt;
        private string _serial;
        private string _signatureAlgorithm;
        private LoadBalancerTlsCertificateStatus _status;
        private string _subject;
        private List<string> _subjectAlternativeNames = new List<string>();
        private string _supportCode;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the SSL/TLS certificate.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time when you created your SSL/TLS certificate.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The domain name for your SSL/TLS certificate.
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
        /// Gets and sets the property DomainValidationRecords. 
        /// <para>
        /// An array of LoadBalancerTlsCertificateDomainValidationRecord objects describing the
        /// records.
        /// </para>
        /// </summary>
        public List<LoadBalancerTlsCertificateDomainValidationRecord> DomainValidationRecords
        {
            get { return this._domainValidationRecords; }
            set { this._domainValidationRecords = value; }
        }

        // Check to see if DomainValidationRecords property is set
        internal bool IsSetDomainValidationRecords()
        {
            return this._domainValidationRecords != null && this._domainValidationRecords.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason for the SSL/TLS certificate validation failure.
        /// </para>
        /// </summary>
        public LoadBalancerTlsCertificateFailureReason FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property IsAttached. 
        /// <para>
        /// When <code>true</code>, the SSL/TLS certificate is attached to the Lightsail load
        /// balancer.
        /// </para>
        /// </summary>
        public bool IsAttached
        {
            get { return this._isAttached.GetValueOrDefault(); }
            set { this._isAttached = value; }
        }

        // Check to see if IsAttached property is set
        internal bool IsSetIsAttached()
        {
            return this._isAttached.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IssuedAt. 
        /// <para>
        /// The time when the SSL/TLS certificate was issued.
        /// </para>
        /// </summary>
        public DateTime IssuedAt
        {
            get { return this._issuedAt.GetValueOrDefault(); }
            set { this._issuedAt = value; }
        }

        // Check to see if IssuedAt property is set
        internal bool IsSetIssuedAt()
        {
            return this._issuedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Issuer. 
        /// <para>
        /// The issuer of the certificate.
        /// </para>
        /// </summary>
        public string Issuer
        {
            get { return this._issuer; }
            set { this._issuer = value; }
        }

        // Check to see if Issuer property is set
        internal bool IsSetIssuer()
        {
            return this._issuer != null;
        }

        /// <summary>
        /// Gets and sets the property KeyAlgorithm. 
        /// <para>
        /// The algorithm that was used to generate the key pair (the public and private key).
        /// </para>
        /// </summary>
        public string KeyAlgorithm
        {
            get { return this._keyAlgorithm; }
            set { this._keyAlgorithm = value; }
        }

        // Check to see if KeyAlgorithm property is set
        internal bool IsSetKeyAlgorithm()
        {
            return this._keyAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property LoadBalancerName. 
        /// <para>
        /// The load balancer name where your SSL/TLS certificate is attached.
        /// </para>
        /// </summary>
        public string LoadBalancerName
        {
            get { return this._loadBalancerName; }
            set { this._loadBalancerName = value; }
        }

        // Check to see if LoadBalancerName property is set
        internal bool IsSetLoadBalancerName()
        {
            return this._loadBalancerName != null;
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The AWS Region and Availability Zone where you created your certificate.
        /// </para>
        /// </summary>
        public ResourceLocation Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the SSL/TLS certificate (e.g., <code>my-certificate</code>).
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

        /// <summary>
        /// Gets and sets the property NotAfter. 
        /// <para>
        /// The timestamp when the SSL/TLS certificate expires.
        /// </para>
        /// </summary>
        public DateTime NotAfter
        {
            get { return this._notAfter.GetValueOrDefault(); }
            set { this._notAfter = value; }
        }

        // Check to see if NotAfter property is set
        internal bool IsSetNotAfter()
        {
            return this._notAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NotBefore. 
        /// <para>
        /// The timestamp when the SSL/TLS certificate is first valid.
        /// </para>
        /// </summary>
        public DateTime NotBefore
        {
            get { return this._notBefore.GetValueOrDefault(); }
            set { this._notBefore = value; }
        }

        // Check to see if NotBefore property is set
        internal bool IsSetNotBefore()
        {
            return this._notBefore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RenewalSummary. 
        /// <para>
        /// An object containing information about the status of Lightsail's managed renewal for
        /// the certificate.
        /// </para>
        /// </summary>
        public LoadBalancerTlsCertificateRenewalSummary RenewalSummary
        {
            get { return this._renewalSummary; }
            set { this._renewalSummary = value; }
        }

        // Check to see if RenewalSummary property is set
        internal bool IsSetRenewalSummary()
        {
            return this._renewalSummary != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The resource type (e.g., <code>LoadBalancerTlsCertificate</code>).
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <code>Instance</code> </b> - A Lightsail instance (a virtual private server)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>StaticIp</code> </b> - A static IP address
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>KeyPair</code> </b> - The key pair used to connect to a Lightsail instance
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>InstanceSnapshot</code> </b> - A Lightsail instance snapshot
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>Domain</code> </b> - A DNS zone
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>PeeredVpc</code> </b> - A peered VPC
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>LoadBalancer</code> </b> - A Lightsail load balancer
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>LoadBalancerTlsCertificate</code> </b> - An SSL/TLS certificate associated
        /// with a Lightsail load balancer
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>Disk</code> </b> - A Lightsail block storage disk
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>DiskSnapshot</code> </b> - A block storage disk snapshot
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property RevocationReason. 
        /// <para>
        /// The reason the certificate was revoked. Valid values are below.
        /// </para>
        /// </summary>
        public LoadBalancerTlsCertificateRevocationReason RevocationReason
        {
            get { return this._revocationReason; }
            set { this._revocationReason = value; }
        }

        // Check to see if RevocationReason property is set
        internal bool IsSetRevocationReason()
        {
            return this._revocationReason != null;
        }

        /// <summary>
        /// Gets and sets the property RevokedAt. 
        /// <para>
        /// The timestamp when the SSL/TLS certificate was revoked.
        /// </para>
        /// </summary>
        public DateTime RevokedAt
        {
            get { return this._revokedAt.GetValueOrDefault(); }
            set { this._revokedAt = value; }
        }

        // Check to see if RevokedAt property is set
        internal bool IsSetRevokedAt()
        {
            return this._revokedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Serial. 
        /// <para>
        /// The serial number of the certificate.
        /// </para>
        /// </summary>
        public string Serial
        {
            get { return this._serial; }
            set { this._serial = value; }
        }

        // Check to see if Serial property is set
        internal bool IsSetSerial()
        {
            return this._serial != null;
        }

        /// <summary>
        /// Gets and sets the property SignatureAlgorithm. 
        /// <para>
        /// The algorithm that was used to sign the certificate.
        /// </para>
        /// </summary>
        public string SignatureAlgorithm
        {
            get { return this._signatureAlgorithm; }
            set { this._signatureAlgorithm = value; }
        }

        // Check to see if SignatureAlgorithm property is set
        internal bool IsSetSignatureAlgorithm()
        {
            return this._signatureAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the SSL/TLS certificate. Valid values are below.
        /// </para>
        /// </summary>
        public LoadBalancerTlsCertificateStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Subject. 
        /// <para>
        /// The name of the entity that is associated with the public key contained in the certificate.
        /// </para>
        /// </summary>
        public string Subject
        {
            get { return this._subject; }
            set { this._subject = value; }
        }

        // Check to see if Subject property is set
        internal bool IsSetSubject()
        {
            return this._subject != null;
        }

        /// <summary>
        /// Gets and sets the property SubjectAlternativeNames. 
        /// <para>
        /// One or more domains or subdomains included in the certificate. This list contains
        /// the domain names that are bound to the public key that is contained in the certificate.
        /// The subject alternative names include the canonical domain name (CNAME) of the certificate
        /// and additional domain names that can be used to connect to the website, such as <code>example.com</code>,
        /// <code>www.example.com</code>, or <code>m.example.com</code>.
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
        /// Gets and sets the property SupportCode. 
        /// <para>
        /// The support code. Include this code in your email to support when you have questions
        /// about your Lightsail load balancer or SSL/TLS certificate. This code enables our support
        /// team to look up your Lightsail information more easily.
        /// </para>
        /// </summary>
        public string SupportCode
        {
            get { return this._supportCode; }
            set { this._supportCode = value; }
        }

        // Check to see if SupportCode property is set
        internal bool IsSetSupportCode()
        {
            return this._supportCode != null;
        }

    }
}