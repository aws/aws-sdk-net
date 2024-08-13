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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
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
namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// The SSL certificate that can be used to encrypt connections between the endpoints
    /// and the replication instance.
    /// </summary>
    public partial class Certificate
    {
        private string _certificateArn;
        private DateTime? _certificateCreationDate;
        private string _certificateIdentifier;
        private string _certificateOwner;
        private string _certificatePem;
        private MemoryStream _certificateWallet;
        private int? _keyLength;
        private string _signingAlgorithm;
        private DateTime? _validFromDate;
        private DateTime? _validToDate;

        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the certificate.
        /// </para>
        /// </summary>
        public string CertificateArn
        {
            get { return this._certificateArn; }
            set { this._certificateArn = value; }
        }

        // Check to see if CertificateArn property is set
        internal bool IsSetCertificateArn()
        {
            return this._certificateArn != null;
        }

        /// <summary>
        /// Gets and sets the property CertificateCreationDate. 
        /// <para>
        /// The date that the certificate was created.
        /// </para>
        /// </summary>
        public DateTime? CertificateCreationDate
        {
            get { return this._certificateCreationDate; }
            set { this._certificateCreationDate = value; }
        }

        // Check to see if CertificateCreationDate property is set
        internal bool IsSetCertificateCreationDate()
        {
            return this._certificateCreationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CertificateIdentifier. 
        /// <para>
        /// A customer-assigned name for the certificate. Identifiers must begin with a letter
        /// and must contain only ASCII letters, digits, and hyphens. They can't end with a hyphen
        /// or contain two consecutive hyphens.
        /// </para>
        /// </summary>
        public string CertificateIdentifier
        {
            get { return this._certificateIdentifier; }
            set { this._certificateIdentifier = value; }
        }

        // Check to see if CertificateIdentifier property is set
        internal bool IsSetCertificateIdentifier()
        {
            return this._certificateIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property CertificateOwner. 
        /// <para>
        /// The owner of the certificate.
        /// </para>
        /// </summary>
        public string CertificateOwner
        {
            get { return this._certificateOwner; }
            set { this._certificateOwner = value; }
        }

        // Check to see if CertificateOwner property is set
        internal bool IsSetCertificateOwner()
        {
            return this._certificateOwner != null;
        }

        /// <summary>
        /// Gets and sets the property CertificatePem. 
        /// <para>
        /// The contents of a <c>.pem</c> file, which contains an X.509 certificate.
        /// </para>
        /// </summary>
        public string CertificatePem
        {
            get { return this._certificatePem; }
            set { this._certificatePem = value; }
        }

        // Check to see if CertificatePem property is set
        internal bool IsSetCertificatePem()
        {
            return this._certificatePem != null;
        }

        /// <summary>
        /// Gets and sets the property CertificateWallet. 
        /// <para>
        /// The location of an imported Oracle Wallet certificate for use with SSL. Example: <c>filebase64("${path.root}/rds-ca-2019-root.sso")</c>
        /// 
        /// </para>
        /// </summary>
        public MemoryStream CertificateWallet
        {
            get { return this._certificateWallet; }
            set { this._certificateWallet = value; }
        }

        // Check to see if CertificateWallet property is set
        internal bool IsSetCertificateWallet()
        {
            return this._certificateWallet != null;
        }

        /// <summary>
        /// Gets and sets the property KeyLength. 
        /// <para>
        /// The key length of the cryptographic algorithm being used.
        /// </para>
        /// </summary>
        public int? KeyLength
        {
            get { return this._keyLength; }
            set { this._keyLength = value; }
        }

        // Check to see if KeyLength property is set
        internal bool IsSetKeyLength()
        {
            return this._keyLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SigningAlgorithm. 
        /// <para>
        /// The signing algorithm for the certificate.
        /// </para>
        /// </summary>
        public string SigningAlgorithm
        {
            get { return this._signingAlgorithm; }
            set { this._signingAlgorithm = value; }
        }

        // Check to see if SigningAlgorithm property is set
        internal bool IsSetSigningAlgorithm()
        {
            return this._signingAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property ValidFromDate. 
        /// <para>
        /// The beginning date that the certificate is valid.
        /// </para>
        /// </summary>
        public DateTime? ValidFromDate
        {
            get { return this._validFromDate; }
            set { this._validFromDate = value; }
        }

        // Check to see if ValidFromDate property is set
        internal bool IsSetValidFromDate()
        {
            return this._validFromDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ValidToDate. 
        /// <para>
        /// The final date that the certificate is valid.
        /// </para>
        /// </summary>
        public DateTime? ValidToDate
        {
            get { return this._validToDate; }
            set { this._validToDate = value; }
        }

        // Check to see if ValidToDate property is set
        internal bool IsSetValidToDate()
        {
            return this._validToDate.HasValue; 
        }

    }
}