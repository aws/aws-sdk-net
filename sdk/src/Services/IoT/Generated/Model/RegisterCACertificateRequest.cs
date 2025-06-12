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
    /// Container for the parameters to the RegisterCACertificate operation.
    /// Registers a CA certificate with Amazon Web Services IoT Core. There is no limit to
    /// the number of CA certificates you can register in your Amazon Web Services account.
    /// You can register up to 10 CA certificates with the same <c>CA subject field</c> per
    /// Amazon Web Services account.
    /// 
    ///  
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">RegisterCACertificate</a>
    /// action.
    /// </para>
    /// </summary>
    public partial class RegisterCACertificateRequest : AmazonIoTRequest
    {
        private bool? _allowAutoRegistration;
        private string _caCertificate;
        private CertificateMode _certificateMode;
        private RegistrationConfig _registrationConfig;
        private bool? _setAsActive;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _verificationCertificate;

        /// <summary>
        /// Gets and sets the property AllowAutoRegistration. 
        /// <para>
        /// Allows this CA certificate to be used for auto registration of device certificates.
        /// </para>
        /// </summary>
        public bool? AllowAutoRegistration
        {
            get { return this._allowAutoRegistration; }
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
        [AWSProperty(Required=true, Min=1, Max=65536)]
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
        /// Gets and sets the property CertificateMode. 
        /// <para>
        /// Describes the certificate mode in which the Certificate Authority (CA) will be registered.
        /// If the <c>verificationCertificate</c> field is not provided, set <c>certificateMode</c>
        /// to be <c>SNI_ONLY</c>. If the <c>verificationCertificate</c> field is provided, set
        /// <c>certificateMode</c> to be <c>DEFAULT</c>. When <c>certificateMode</c> is not provided,
        /// it defaults to <c>DEFAULT</c>. All the device certificates that are registered using
        /// this CA will be registered in the same certificate mode as the CA. For more information
        /// about certificate mode for device certificates, see <a href="https://docs.aws.amazon.com/iot/latest/apireference/API_CertificateDescription.html#iot-Type-CertificateDescription-certificateMode">
        /// certificate mode</a>. 
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
        ///  
        /// <para>
        /// Valid values: <c>ACTIVE | INACTIVE</c> 
        /// </para>
        /// </summary>
        public bool? SetAsActive
        {
            get { return this._setAsActive; }
            set { this._setAsActive = value; }
        }

        // Check to see if SetAsActive property is set
        internal bool IsSetSetAsActive()
        {
            return this._setAsActive.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata which can be used to manage the CA certificate.
        /// </para>
        ///  <note> 
        /// <para>
        /// For URI Request parameters use format: ...key1=value1&amp;key2=value2...
        /// </para>
        ///  
        /// <para>
        /// For the CLI command-line parameter use format: &amp;&amp;tags "key1=value1&amp;key2=value2..."
        /// </para>
        ///  
        /// <para>
        /// For the cli-input-json file use format: "tags": "key1=value1&amp;key2=value2..."
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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
        /// Gets and sets the property VerificationCertificate. 
        /// <para>
        /// The private key verification certificate. If <c>certificateMode</c> is <c>SNI_ONLY</c>,
        /// the <c>verificationCertificate</c> field must be empty. If <c>certificateMode</c>
        /// is <c>DEFAULT</c> or not provided, the <c>verificationCertificate</c> field must not
        /// be empty. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=65536)]
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