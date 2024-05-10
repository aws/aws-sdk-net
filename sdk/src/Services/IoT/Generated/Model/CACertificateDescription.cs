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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Describes a CA certificate.
    /// </summary>
    public partial class CACertificateDescription
    {
        private AutoRegistrationStatus _autoRegistrationStatus;
        private string _certificateArn;
        private string _certificateId;
        private CertificateMode _certificateMode;
        private string _certificatePem;
        private DateTime? _creationDate;
        private int? _customerVersion;
        private string _generationId;
        private DateTime? _lastModifiedDate;
        private string _ownedBy;
        private CACertificateStatus _status;
        private CertificateValidity _validity;

        /// <summary>
        /// Gets and sets the property AutoRegistrationStatus. 
        /// <para>
        /// Whether the CA certificate configured for auto registration of device certificates.
        /// Valid values are "ENABLE" and "DISABLE"
        /// </para>
        /// </summary>
        public AutoRegistrationStatus AutoRegistrationStatus
        {
            get { return this._autoRegistrationStatus; }
            set { this._autoRegistrationStatus = value; }
        }

        // Check to see if AutoRegistrationStatus property is set
        internal bool IsSetAutoRegistrationStatus()
        {
            return this._autoRegistrationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// The CA certificate ARN.
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
        /// The CA certificate ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=64, Max=64)]
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
        /// Gets and sets the property CertificateMode. 
        /// <para>
        /// The mode of the CA. 
        /// </para>
        ///  
        /// <para>
        /// All the device certificates that are registered using this CA will be registered in
        /// the same mode as the CA. For more information about certificate mode for device certificates,
        /// see <a href="https://docs.aws.amazon.com/iot/latest/apireference/API_CertificateDescription.html#iot-Type-CertificateDescription-certificateMode">certificate
        /// mode</a>.
        /// </para>
        /// </summary>
        public CertificateMode CertificateMode
        {
            get { return this._certificateMode; }
            set { this._certificateMode = value; }
        }

        // Check to see if CertificateMode property is set
        internal bool IsSetCertificateMode()
        {
            return this._certificateMode != null;
        }

        /// <summary>
        /// Gets and sets the property CertificatePem. 
        /// <para>
        /// The CA certificate data, in PEM format.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=65536)]
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
        /// The date the CA certificate was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDate
        {
            get { return this._creationDate; }
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
        /// The customer version of the CA certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? CustomerVersion
        {
            get { return this._customerVersion; }
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
        /// The generation ID of the CA certificate.
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
        /// The date the CA certificate was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedDate
        {
            get { return this._lastModifiedDate; }
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
        /// The owner of the CA certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of a CA certificate.
        /// </para>
        /// </summary>
        public CACertificateStatus Status
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
        /// Gets and sets the property Validity. 
        /// <para>
        /// When the CA certificate is valid.
        /// </para>
        /// </summary>
        public CertificateValidity Validity
        {
            get { return this._validity; }
            set { this._validity = value; }
        }

        // Check to see if Validity property is set
        internal bool IsSetValidity()
        {
            return this._validity != null;
        }

    }
}