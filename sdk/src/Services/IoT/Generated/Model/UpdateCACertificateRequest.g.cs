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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the UpdateCACertificate operation. Updates a registered
    /// CA certificate. <para> Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">UpdateCACertificate</a>
    /// action. </para>
    /// </summary>
    public partial class UpdateCACertificateRequest : AmazonIoTRequest
    {
        /// <summary>
        /// Gets and sets the property CertificateId. 
        /// <para>
        /// The CA certificate identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 64, Max = 64)]
        public string CertificateId { get; set; }

        /// <summary>
        /// Checks to see if the CertificateId property is set.
        /// </summary>
        internal bool IsSetCertificateId() => this.CertificateId != null;

        /// <summary>
        /// Gets and sets the property NewAutoRegistrationStatus. 
        /// <para>
        /// The new value for the auto registration status. Valid values are: "ENABLE" or "DISABLE".
        /// </para>
        /// </summary>
        public AutoRegistrationStatus NewAutoRegistrationStatus { get; set; }

        /// <summary>
        /// Checks to see if the NewAutoRegistrationStatus property is set.
        /// </summary>
        internal bool IsSetNewAutoRegistrationStatus() => this.NewAutoRegistrationStatus != null;

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
        public CACertificateStatus NewStatus { get; set; }

        /// <summary>
        /// Checks to see if the NewStatus property is set.
        /// </summary>
        internal bool IsSetNewStatus() => this.NewStatus != null;

        /// <summary>
        /// Gets and sets the property RegistrationConfig. 
        /// <para>
        /// Information about the registration configuration.
        /// </para>
        /// </summary>
        public RegistrationConfig RegistrationConfig { get; set; }

        /// <summary>
        /// Checks to see if the RegistrationConfig property is set.
        /// </summary>
        internal bool IsSetRegistrationConfig() => this.RegistrationConfig != null;

        /// <summary>
        /// Gets and sets the property RemoveAutoRegistration. 
        /// <para>
        /// If true, removes auto registration.
        /// </para>
        /// </summary>
        public bool? RemoveAutoRegistration { get; set; }

        /// <summary>
        /// Checks to see if the RemoveAutoRegistration property is set.
        /// </summary>
        internal bool IsSetRemoveAutoRegistration() => this.RemoveAutoRegistration.HasValue;
    }
}
