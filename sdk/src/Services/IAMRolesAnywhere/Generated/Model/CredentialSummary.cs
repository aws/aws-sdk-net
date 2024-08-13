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
 * Do not modify this file. This file is generated from the rolesanywhere-2018-05-10.normal.json service model.
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
namespace Amazon.IAMRolesAnywhere.Model
{
    /// <summary>
    /// A record of a presented X509 credential from a temporary credential request.
    /// </summary>
    public partial class CredentialSummary
    {
        private bool? _enabled;
        private bool? _failed;
        private string _issuer;
        private DateTime? _seenAt;
        private string _serialNumber;
        private string _x509CertificateData;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Indicates whether the credential is enabled.
        /// </para>
        /// </summary>
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Failed. 
        /// <para>
        /// Indicates whether the temporary credential request was successful. 
        /// </para>
        /// </summary>
        public bool? Failed
        {
            get { return this._failed; }
            set { this._failed = value; }
        }

        // Check to see if Failed property is set
        internal bool IsSetFailed()
        {
            return this._failed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Issuer. 
        /// <para>
        /// The fully qualified domain name of the issuing certificate for the presented end-entity
        /// certificate.
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
        /// Gets and sets the property SeenAt. 
        /// <para>
        /// The ISO-8601 time stamp of when the certificate was last used in a temporary credential
        /// request.
        /// </para>
        /// </summary>
        public DateTime? SeenAt
        {
            get { return this._seenAt; }
            set { this._seenAt = value; }
        }

        // Check to see if SeenAt property is set
        internal bool IsSetSeenAt()
        {
            return this._seenAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SerialNumber. 
        /// <para>
        /// The serial number of the certificate.
        /// </para>
        /// </summary>
        public string SerialNumber
        {
            get { return this._serialNumber; }
            set { this._serialNumber = value; }
        }

        // Check to see if SerialNumber property is set
        internal bool IsSetSerialNumber()
        {
            return this._serialNumber != null;
        }

        /// <summary>
        /// Gets and sets the property X509CertificateData. 
        /// <para>
        /// The PEM-encoded data of the certificate.
        /// </para>
        /// </summary>
        public string X509CertificateData
        {
            get { return this._x509CertificateData; }
            set { this._x509CertificateData = value; }
        }

        // Check to see if X509CertificateData property is set
        internal bool IsSetX509CertificateData()
        {
            return this._x509CertificateData != null;
        }

    }
}