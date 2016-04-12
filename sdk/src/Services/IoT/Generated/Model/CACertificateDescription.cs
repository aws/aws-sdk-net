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
    /// Describes a CA certificate.
    /// </summary>
    public partial class CACertificateDescription
    {
        private string _certificateArn;
        private string _certificateId;
        private string _certificatePem;
        private DateTime? _creationDate;
        private string _ownedBy;
        private CACertificateStatus _status;

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
        /// The CA certificate data, in PEM format.
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
        /// The date the CA certificate was created.
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
        /// Gets and sets the property OwnedBy. 
        /// <para>
        /// The owner of the CA certificate.
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

    }
}