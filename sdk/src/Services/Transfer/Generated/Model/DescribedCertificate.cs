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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
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
namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Describes the properties of a certificate.
    /// </summary>
    public partial class DescribedCertificate
    {
        private DateTime? _activeDate;
        private string _arn;
        private string _certificate;
        private string _certificateChain;
        private string _certificateId;
        private string _description;
        private DateTime? _inactiveDate;
        private DateTime? _notAfterDate;
        private DateTime? _notBeforeDate;
        private string _serial;
        private CertificateStatusType _status;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private CertificateType _type;
        private CertificateUsageType _usage;

        /// <summary>
        /// Gets and sets the property ActiveDate. 
        /// <para>
        /// An optional date that specifies when the certificate becomes active. If you do not
        /// specify a value, <c>ActiveDate</c> takes the same value as <c>NotBeforeDate</c>, which
        /// is specified by the CA. 
        /// </para>
        /// </summary>
        public DateTime? ActiveDate
        {
            get { return this._activeDate; }
            set { this._activeDate = value; }
        }

        // Check to see if ActiveDate property is set
        internal bool IsSetActiveDate()
        {
            return this._activeDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The unique Amazon Resource Name (ARN) for the certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=1600)]
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
        /// Gets and sets the property Certificate. 
        /// <para>
        /// The file name for the certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=16384)]
        public string Certificate
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
        /// Gets and sets the property CertificateChain. 
        /// <para>
        /// The list of certificates that make up the chain for the certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=2097152)]
        public string CertificateChain
        {
            get { return this._certificateChain; }
            set { this._certificateChain = value; }
        }

        // Check to see if CertificateChain property is set
        internal bool IsSetCertificateChain()
        {
            return this._certificateChain != null;
        }

        /// <summary>
        /// Gets and sets the property CertificateId. 
        /// <para>
        /// An array of identifiers for the imported certificates. You use this identifier for
        /// working with profiles and partner profiles.
        /// </para>
        /// </summary>
        [AWSProperty(Min=22, Max=22)]
        public string CertificateId
        {
            get { return this._certificateId; }
            set { this._certificateId = value; }
        }

        // Check to see if CertificateId property is set
        internal bool IsSetCertificateId()
        {
            return this._certificateId != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The name or description that's used to identity the certificate. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property InactiveDate. 
        /// <para>
        /// An optional date that specifies when the certificate becomes inactive. If you do not
        /// specify a value, <c>InactiveDate</c> takes the same value as <c>NotAfterDate</c>,
        /// which is specified by the CA.
        /// </para>
        /// </summary>
        public DateTime? InactiveDate
        {
            get { return this._inactiveDate; }
            set { this._inactiveDate = value; }
        }

        // Check to see if InactiveDate property is set
        internal bool IsSetInactiveDate()
        {
            return this._inactiveDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NotAfterDate. 
        /// <para>
        /// The final date that the certificate is valid.
        /// </para>
        /// </summary>
        public DateTime? NotAfterDate
        {
            get { return this._notAfterDate; }
            set { this._notAfterDate = value; }
        }

        // Check to see if NotAfterDate property is set
        internal bool IsSetNotAfterDate()
        {
            return this._notAfterDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NotBeforeDate. 
        /// <para>
        /// The earliest date that the certificate is valid.
        /// </para>
        /// </summary>
        public DateTime? NotBeforeDate
        {
            get { return this._notBeforeDate; }
            set { this._notBeforeDate = value; }
        }

        // Check to see if NotBeforeDate property is set
        internal bool IsSetNotBeforeDate()
        {
            return this._notBeforeDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Serial. 
        /// <para>
        /// The serial number for the certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=48)]
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
        /// Gets and sets the property Status. 
        /// <para>
        /// A certificate's status can be either <c>ACTIVE</c> or <c>INACTIVE</c>.
        /// </para>
        ///  
        /// <para>
        /// You can set <c>ActiveDate</c> and <c>InactiveDate</c> in the <c>UpdateCertificate</c>
        /// call. If you set values for these parameters, those values are used to determine whether
        /// the certificate has a status of <c>ACTIVE</c> or <c>INACTIVE</c>.
        /// </para>
        ///  
        /// <para>
        /// If you don't set values for <c>ActiveDate</c> and <c>InactiveDate</c>, we use the
        /// <c>NotBefore</c> and <c>NotAfter</c> date as specified on the X509 certificate to
        /// determine when a certificate is active and when it is inactive.
        /// </para>
        /// </summary>
        public CertificateStatusType Status
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Key-value pairs that can be used to group and search for certificates.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// If a private key has been specified for the certificate, its type is <c>CERTIFICATE_WITH_PRIVATE_KEY</c>.
        /// If there is no private key, the type is <c>CERTIFICATE</c>.
        /// </para>
        /// </summary>
        public CertificateType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Usage. 
        /// <para>
        /// Specifies how this certificate is used. It can be used in the following ways:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SIGNING</c>: For signing AS2 messages
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ENCRYPTION</c>: For encrypting AS2 messages
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TLS</c>: For securing AS2 communications sent over HTTPS
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public CertificateUsageType Usage
        {
            get { return this._usage; }
            set { this._usage = value; }
        }

        // Check to see if Usage property is set
        internal bool IsSetUsage()
        {
            return this._usage != null;
        }

    }
}