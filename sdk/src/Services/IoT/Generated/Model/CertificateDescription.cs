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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Describes a certificate.
    /// </summary>
    public partial class CertificateDescription
    {
        private string _caCertificateId;
        private string _certificateArn;
        private string _certificateId;
        private string _certificatePem;
        private DateTime? _creationDate;
        private int? _customerVersion;
        private string _generationId;
        private DateTime? _lastModifiedDate;
        private string _ownedBy;
        private string _previousOwnedBy;
        private CertificateStatus _status;
        private TransferData _transferData;

        /// <summary>
        /// Gets and sets the property CaCertificateId. 
        /// <para>
        /// The certificate ID of the CA certificate used to sign this certificate.
        /// </para>
        /// </summary>
        public string CaCertificateId
        {
            get { return this._caCertificateId; }
            set { this._caCertificateId = value; }
        }

        // Check to see if CaCertificateId property is set
        internal bool IsSetCaCertificateId()
        {
            return this._caCertificateId != null;
        }

        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// The ARN of the certificate.
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
        /// Gets and sets the property CertificateId. 
        /// <para>
        /// The ID of the certificate.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property CertificatePem. 
        /// <para>
        /// The certificate data, in PEM format.
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
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time the certificate was created.
        /// </para>
        /// </summary>
        public DateTime CreationDate
        {
            get { return this._creationDate.GetValueOrDefault(); }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CustomerVersion. 
        /// <para>
        /// The customer version of the certificate.
        /// </para>
        /// </summary>
        public int CustomerVersion
        {
            get { return this._customerVersion.GetValueOrDefault(); }
            set { this._customerVersion = value; }
        }

        // Check to see if CustomerVersion property is set
        internal bool IsSetCustomerVersion()
        {
            return this._customerVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GenerationId. 
        /// <para>
        /// The generation ID of the certificate.
        /// </para>
        /// </summary>
        public string GenerationId
        {
            get { return this._generationId; }
            set { this._generationId = value; }
        }

        // Check to see if GenerationId property is set
        internal bool IsSetGenerationId()
        {
            return this._generationId != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date and time the certificate was last modified.
        /// </para>
        /// </summary>
        public DateTime LastModifiedDate
        {
            get { return this._lastModifiedDate.GetValueOrDefault(); }
            set { this._lastModifiedDate = value; }
        }

        // Check to see if LastModifiedDate property is set
        internal bool IsSetLastModifiedDate()
        {
            return this._lastModifiedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OwnedBy. 
        /// <para>
        /// The ID of the AWS account that owns the certificate.
        /// </para>
        /// </summary>
        public string OwnedBy
        {
            get { return this._ownedBy; }
            set { this._ownedBy = value; }
        }

        // Check to see if OwnedBy property is set
        internal bool IsSetOwnedBy()
        {
            return this._ownedBy != null;
        }

        /// <summary>
        /// Gets and sets the property PreviousOwnedBy. 
        /// <para>
        /// The ID of the AWS account of the previous owner of the certificate.
        /// </para>
        /// </summary>
        public string PreviousOwnedBy
        {
            get { return this._previousOwnedBy; }
            set { this._previousOwnedBy = value; }
        }

        // Check to see if PreviousOwnedBy property is set
        internal bool IsSetPreviousOwnedBy()
        {
            return this._previousOwnedBy != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the certificate.
        /// </para>
        /// </summary>
        public CertificateStatus Status
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
        /// Gets and sets the property TransferData. 
        /// <para>
        /// The transfer data.
        /// </para>
        /// </summary>
        public TransferData TransferData
        {
            get { return this._transferData; }
            set { this._transferData = value; }
        }

        // Check to see if TransferData property is set
        internal bool IsSetTransferData()
        {
            return this._transferData != null;
        }

    }
}