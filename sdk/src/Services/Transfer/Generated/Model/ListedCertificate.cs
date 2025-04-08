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
    public partial class ListedCertificate
    {
        private DateTime? _activeDate;
        private string _arn;
        private string _certificateId;
        private string _description;
        private DateTime? _inactiveDate;
        private CertificateStatusType _status;
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
        /// The Amazon Resource Name (ARN) of the specified certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=1600)]
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
        /// The name or short description that's used to identify the certificate.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The certificate can be either <c>ACTIVE</c>, <c>PENDING_ROTATION</c>, or <c>INACTIVE</c>.
        /// <c>PENDING_ROTATION</c> means that this certificate will replace the current certificate
        /// when it expires.
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The type for the certificate. If a private key has been specified for the certificate,
        /// its type is <c>CERTIFICATE_WITH_PRIVATE_KEY</c>. If there is no private key, the type
        /// is <c>CERTIFICATE</c>.
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