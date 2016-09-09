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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// A CA certificate for an AWS account.
    /// </summary>
    public partial class Certificate
    {
        private string _certificateArn;
        private string _certificateIdentifier;
        private string _certificateType;
        private string _thumbprint;
        private DateTime? _validFrom;
        private DateTime? _validTill;

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
        /// Gets and sets the property CertificateIdentifier. 
        /// <para>
        /// The unique key that identifies a certificate.
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
        /// Gets and sets the property CertificateType. 
        /// <para>
        /// The type of the certificate.
        /// </para>
        /// </summary>
        public string CertificateType
        {
            get { return this._certificateType; }
            set { this._certificateType = value; }
        }

        // Check to see if CertificateType property is set
        internal bool IsSetCertificateType()
        {
            return this._certificateType != null;
        }

        /// <summary>
        /// Gets and sets the property Thumbprint. 
        /// <para>
        /// The thumbprint of the certificate.
        /// </para>
        /// </summary>
        public string Thumbprint
        {
            get { return this._thumbprint; }
            set { this._thumbprint = value; }
        }

        // Check to see if Thumbprint property is set
        internal bool IsSetThumbprint()
        {
            return this._thumbprint != null;
        }

        /// <summary>
        /// Gets and sets the property ValidFrom. 
        /// <para>
        /// The starting date from which the certificate is valid.
        /// </para>
        /// </summary>
        public DateTime ValidFrom
        {
            get { return this._validFrom.GetValueOrDefault(); }
            set { this._validFrom = value; }
        }

        // Check to see if ValidFrom property is set
        internal bool IsSetValidFrom()
        {
            return this._validFrom.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ValidTill. 
        /// <para>
        /// The final date that the certificate continues to be valid.
        /// </para>
        /// </summary>
        public DateTime ValidTill
        {
            get { return this._validTill.GetValueOrDefault(); }
            set { this._validTill = value; }
        }

        // Check to see if ValidTill property is set
        internal bool IsSetValidTill()
        {
            return this._validTill.HasValue; 
        }

    }
}