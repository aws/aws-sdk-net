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
    /// Container for the parameters to the RegisterCACertificate operation.
    /// Registers a CA certificate with AWS IoT. This CA certificate can then be used to sign
    /// device certificates, which can be then registered with AWS IoT. You can register up
    /// to 10 CA certificates per AWS account that have the same subject field. This enables
    /// you to have up to 10 certificate authorities sign your device certificates. If you
    /// have more than one CA certificate registered, make sure you pass the CA certificate
    /// when you register your device certificates with the RegisterCertificate API.
    /// </summary>
    public partial class RegisterCACertificateRequest : AmazonIoTRequest
    {
        private bool? _allowAutoRegistration;
        private string _caCertificate;
        private RegistrationConfig _registrationConfig;
        private bool? _setAsActive;
        private string _verificationCertificate;

        /// <summary>
        /// Gets and sets the property AllowAutoRegistration. 
        /// <para>
        /// Allows this CA certificate to be used for auto registration of device certificates.
        /// </para>
        /// </summary>
        public bool AllowAutoRegistration
        {
            get { return this._allowAutoRegistration.GetValueOrDefault(); }
            set { this._allowAutoRegistration = value; }
        }

        // Check to see if AllowAutoRegistration property is set
        internal bool IsSetAllowAutoRegistration()
        {
            return this._allowAutoRegistration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CaCertificate. 
        /// <para>
        /// The CA certificate.
        /// </para>
        /// </summary>
        public string CaCertificate
        {
            get { return this._caCertificate; }
            set { this._caCertificate = value; }
        }

        // Check to see if CaCertificate property is set
        internal bool IsSetCaCertificate()
        {
            return this._caCertificate != null;
        }

        /// <summary>
        /// Gets and sets the property RegistrationConfig. 
        /// <para>
        /// Information about the registration configuration.
        /// </para>
        /// </summary>
        public RegistrationConfig RegistrationConfig
        {
            get { return this._registrationConfig; }
            set { this._registrationConfig = value; }
        }

        // Check to see if RegistrationConfig property is set
        internal bool IsSetRegistrationConfig()
        {
            return this._registrationConfig != null;
        }

        /// <summary>
        /// Gets and sets the property SetAsActive. 
        /// <para>
        /// A boolean value that specifies if the CA certificate is set to active.
        /// </para>
        /// </summary>
        public bool SetAsActive
        {
            get { return this._setAsActive.GetValueOrDefault(); }
            set { this._setAsActive = value; }
        }

        // Check to see if SetAsActive property is set
        internal bool IsSetSetAsActive()
        {
            return this._setAsActive.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VerificationCertificate. 
        /// <para>
        /// The private key verification certificate.
        /// </para>
        /// </summary>
        public string VerificationCertificate
        {
            get { return this._verificationCertificate; }
            set { this._verificationCertificate = value; }
        }

        // Check to see if VerificationCertificate property is set
        internal bool IsSetVerificationCertificate()
        {
            return this._verificationCertificate != null;
        }

    }
}