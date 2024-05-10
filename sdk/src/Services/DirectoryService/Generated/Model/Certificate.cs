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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
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
namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Information about the certificate.
    /// </summary>
    public partial class Certificate
    {
        private string _certificateId;
        private ClientCertAuthSettings _clientCertAuthSettings;
        private string _commonName;
        private DateTime? _expiryDateTime;
        private DateTime? _registeredDateTime;
        private CertificateState _state;
        private string _stateReason;
        private CertificateType _type;

        /// <summary>
        /// Gets and sets the property CertificateId. 
        /// <para>
        /// The identifier of the certificate.
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
        /// Gets and sets the property ClientCertAuthSettings. 
        /// <para>
        /// A <c>ClientCertAuthSettings</c> object that contains client certificate authentication
        /// settings.
        /// </para>
        /// </summary>
        public ClientCertAuthSettings ClientCertAuthSettings
        {
            get { return this._clientCertAuthSettings; }
            set { this._clientCertAuthSettings = value; }
        }

        // Check to see if ClientCertAuthSettings property is set
        internal bool IsSetClientCertAuthSettings()
        {
            return this._clientCertAuthSettings != null;
        }

        /// <summary>
        /// Gets and sets the property CommonName. 
        /// <para>
        /// The common name for the certificate.
        /// </para>
        /// </summary>
        public string CommonName
        {
            get { return this._commonName; }
            set { this._commonName = value; }
        }

        // Check to see if CommonName property is set
        internal bool IsSetCommonName()
        {
            return this._commonName != null;
        }

        /// <summary>
        /// Gets and sets the property ExpiryDateTime. 
        /// <para>
        /// The date and time when the certificate will expire.
        /// </para>
        /// </summary>
        public DateTime? ExpiryDateTime
        {
            get { return this._expiryDateTime; }
            set { this._expiryDateTime = value; }
        }

        // Check to see if ExpiryDateTime property is set
        internal bool IsSetExpiryDateTime()
        {
            return this._expiryDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RegisteredDateTime. 
        /// <para>
        /// The date and time that the certificate was registered.
        /// </para>
        /// </summary>
        public DateTime? RegisteredDateTime
        {
            get { return this._registeredDateTime; }
            set { this._registeredDateTime = value; }
        }

        // Check to see if RegisteredDateTime property is set
        internal bool IsSetRegisteredDateTime()
        {
            return this._registeredDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the certificate.
        /// </para>
        /// </summary>
        public CertificateState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property StateReason. 
        /// <para>
        /// Describes a state change for the certificate.
        /// </para>
        /// </summary>
        public string StateReason
        {
            get { return this._stateReason; }
            set { this._stateReason = value; }
        }

        // Check to see if StateReason property is set
        internal bool IsSetStateReason()
        {
            return this._stateReason != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The function that the registered certificate performs. Valid values include <c>ClientLDAPS</c>
        /// or <c>ClientCertAuth</c>. The default value is <c>ClientLDAPS</c>.
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

    }
}