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
    /// Container for the parameters to the UpdateCACertificate operation.
    /// Updates a registered CA certificate.
    /// 
    ///  
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">UpdateCACertificate</a>
    /// action.
    /// </para>
    /// </summary>
    public partial class UpdateCACertificateRequest : AmazonIoTRequest
    {
        private string _certificateId;
        private AutoRegistrationStatus _newAutoRegistrationStatus;
        private CACertificateStatus _newStatus;
        private RegistrationConfig _registrationConfig;
        private bool? _removeAutoRegistration;

        /// <summary>
        /// Gets and sets the property CertificateId. 
        /// <para>
        /// The CA certificate identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=64, Max=64)]
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
        /// Gets and sets the property NewAutoRegistrationStatus. 
        /// <para>
        /// The new value for the auto registration status. Valid values are: "ENABLE" or "DISABLE".
        /// </para>
        /// </summary>
        public AutoRegistrationStatus NewAutoRegistrationStatus
        {
            get { return this._newAutoRegistrationStatus; }
            set { this._newAutoRegistrationStatus = value; }
        }

        // Check to see if NewAutoRegistrationStatus property is set
        internal bool IsSetNewAutoRegistrationStatus()
        {
            return this._newAutoRegistrationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property NewStatus. 
        /// <para>
        /// The updated status of the CA certificate.
        /// </para>
        ///  
        /// <para>
        ///  <b>Note:</b> The status value REGISTER_INACTIVE is deprecated and should not be used.
        /// </para>
        /// </summary>
        public CACertificateStatus NewStatus
        {
            get { return this._newStatus; }
            set { this._newStatus = value; }
        }

        // Check to see if NewStatus property is set
        internal bool IsSetNewStatus()
        {
            return this._newStatus != null;
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
        /// Gets and sets the property RemoveAutoRegistration. 
        /// <para>
        /// If true, removes auto registration.
        /// </para>
        /// </summary>
        public bool? RemoveAutoRegistration
        {
            get { return this._removeAutoRegistration; }
            set { this._removeAutoRegistration = value; }
        }

        // Check to see if RemoveAutoRegistration property is set
        internal bool IsSetRemoveAutoRegistration()
        {
            return this._removeAutoRegistration.HasValue; 
        }

    }
}