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
    /// Describes a CA certificate.
    /// </summary>
    public partial class CACertificateDescription
    {
        /// <summary>
        /// Gets and sets the property AutoRegistrationStatus. 
        /// <para>
        /// Whether the CA certificate configured for auto registration of device certificates.
        /// Valid values are "ENABLE" and "DISABLE"
        /// </para>
        /// </summary>
        public AutoRegistrationStatus AutoRegistrationStatus { get; set; }

        /// <summary>
        /// Checks to see if the AutoRegistrationStatus property is set.
        /// </summary>
        internal bool IsSetAutoRegistrationStatus() => this.AutoRegistrationStatus != null;

        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// The CA certificate ARN.
        /// </para>
        /// </summary>
        public string CertificateArn { get; set; }

        /// <summary>
        /// Checks to see if the CertificateArn property is set.
        /// </summary>
        internal bool IsSetCertificateArn() => this.CertificateArn != null;

        /// <summary>
        /// Gets and sets the property CertificateId. 
        /// <para>
        /// The CA certificate ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 64, Max = 64)]
        public string CertificateId { get; set; }

        /// <summary>
        /// Checks to see if the CertificateId property is set.
        /// </summary>
        internal bool IsSetCertificateId() => this.CertificateId != null;

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
        public CertificateMode CertificateMode { get; set; }

        /// <summary>
        /// Checks to see if the CertificateMode property is set.
        /// </summary>
        internal bool IsSetCertificateMode() => this.CertificateMode != null;

        /// <summary>
        /// Gets and sets the property CertificatePem. 
        /// <para>
        /// The CA certificate data, in PEM format.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 65536)]
        public string CertificatePem { get; set; }

        /// <summary>
        /// Checks to see if the CertificatePem property is set.
        /// </summary>
        internal bool IsSetCertificatePem() => this.CertificatePem != null;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date the CA certificate was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property CustomerVersion. 
        /// <para>
        /// The customer version of the CA certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? CustomerVersion { get; set; }

        /// <summary>
        /// Checks to see if the CustomerVersion property is set.
        /// </summary>
        internal bool IsSetCustomerVersion() => this.CustomerVersion.HasValue;

        /// <summary>
        /// Gets and sets the property GenerationId. 
        /// <para>
        /// The generation ID of the CA certificate.
        /// </para>
        /// </summary>
        public string GenerationId { get; set; }

        /// <summary>
        /// Checks to see if the GenerationId property is set.
        /// </summary>
        internal bool IsSetGenerationId() => this.GenerationId != null;

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date the CA certificate was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDate property is set.
        /// </summary>
        internal bool IsSetLastModifiedDate() => this.LastModifiedDate.HasValue;

        /// <summary>
        /// Gets and sets the property OwnedBy. 
        /// <para>
        /// The owner of the CA certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string OwnedBy { get; set; }

        /// <summary>
        /// Checks to see if the OwnedBy property is set.
        /// </summary>
        internal bool IsSetOwnedBy() => this.OwnedBy != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of a CA certificate.
        /// </para>
        /// </summary>
        public CACertificateStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Validity. 
        /// <para>
        /// When the CA certificate is valid.
        /// </para>
        /// </summary>
        public CertificateValidity Validity { get; set; }

        /// <summary>
        /// Checks to see if the Validity property is set.
        /// </summary>
        internal bool IsSetValidity() => this.Validity != null;
    }
}
