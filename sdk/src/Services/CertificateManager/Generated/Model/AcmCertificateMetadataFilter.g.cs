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

namespace Amazon.CertificateManager.Model
{
    /// <summary>
    /// Filters certificates by ACM metadata.
    /// </summary>
    public partial class AcmCertificateMetadataFilter
    {
        /// <summary>
        /// Gets and sets the property AcmeAccountId. 
        /// <para>
        /// Filter by ACME account identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string AcmeAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AcmeAccountId property is set.
        /// </summary>
        internal bool IsSetAcmeAccountId() => this.AcmeAccountId != null;

        /// <summary>
        /// Gets and sets the property AcmeEndpointArn. 
        /// <para>
        /// Filter by ACME endpoint ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string AcmeEndpointArn { get; set; }

        /// <summary>
        /// Checks to see if the AcmeEndpointArn property is set.
        /// </summary>
        internal bool IsSetAcmeEndpointArn() => this.AcmeEndpointArn != null;

        /// <summary>
        /// Gets and sets the property CertificateKeyPairOrigin. 
        /// <para>
        /// Filter by certificate key pair origin.
        /// </para>
        /// </summary>
        public CertificateKeyPairOrigin CertificateKeyPairOrigin { get; set; }

        /// <summary>
        /// Checks to see if the CertificateKeyPairOrigin property is set.
        /// </summary>
        internal bool IsSetCertificateKeyPairOrigin() => this.CertificateKeyPairOrigin != null;

        /// <summary>
        /// Gets and sets the property ExportOption. 
        /// <para>
        /// Filter by certificate export option.
        /// </para>
        /// </summary>
        public CertificateExport ExportOption { get; set; }

        /// <summary>
        /// Checks to see if the ExportOption property is set.
        /// </summary>
        internal bool IsSetExportOption() => this.ExportOption != null;

        /// <summary>
        /// Gets and sets the property Exported. 
        /// <para>
        /// Filter by whether the certificate has been exported.
        /// </para>
        /// </summary>
        public bool? Exported { get; set; }

        /// <summary>
        /// Checks to see if the Exported property is set.
        /// </summary>
        internal bool IsSetExported() => this.Exported.HasValue;

        /// <summary>
        /// Gets and sets the property InUse. 
        /// <para>
        /// Filter by whether the certificate is in use.
        /// </para>
        /// </summary>
        public bool? InUse { get; set; }

        /// <summary>
        /// Checks to see if the InUse property is set.
        /// </summary>
        internal bool IsSetInUse() => this.InUse.HasValue;

        /// <summary>
        /// Gets and sets the property ManagedBy. 
        /// <para>
        /// Filter by the entity that manages the certificate.
        /// </para>
        /// </summary>
        public CertificateManagedBy ManagedBy { get; set; }

        /// <summary>
        /// Checks to see if the ManagedBy property is set.
        /// </summary>
        internal bool IsSetManagedBy() => this.ManagedBy != null;

        /// <summary>
        /// Gets and sets the property RenewalStatus. 
        /// <para>
        /// Filter by certificate renewal status.
        /// </para>
        /// </summary>
        public RenewalStatus RenewalStatus { get; set; }

        /// <summary>
        /// Checks to see if the RenewalStatus property is set.
        /// </summary>
        internal bool IsSetRenewalStatus() => this.RenewalStatus != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Filter by certificate status.
        /// </para>
        /// </summary>
        public CertificateStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Filter by certificate type.
        /// </para>
        /// </summary>
        public CertificateType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property ValidationMethod. 
        /// <para>
        /// Filter by validation method.
        /// </para>
        /// </summary>
        public ValidationMethod ValidationMethod { get; set; }

        /// <summary>
        /// Checks to see if the ValidationMethod property is set.
        /// </summary>
        internal bool IsSetValidationMethod() => this.ValidationMethod != null;
    }
}
