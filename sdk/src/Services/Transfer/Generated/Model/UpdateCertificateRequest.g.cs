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

namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateCertificate operation. Updates the active
    /// and inactive dates for a certificate.
    /// </summary>
    public partial class UpdateCertificateRequest : AmazonTransferRequest
    {
        /// <summary>
        /// Gets and sets the property ActiveDate. 
        /// <para>
        /// An optional date that specifies when the certificate becomes active. If you do not
        /// specify a value, <c>ActiveDate</c> takes the same value as <c>NotBeforeDate</c>, which
        /// is specified by the CA. 
        /// </para>
        /// </summary>
        public DateTime? ActiveDate { get; set; }

        /// <summary>
        /// Checks to see if the ActiveDate property is set.
        /// </summary>
        internal bool IsSetActiveDate() => this.ActiveDate.HasValue;

        /// <summary>
        /// Gets and sets the property CertificateId. 
        /// <para>
        /// The identifier of the certificate object that you are updating.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 22, Max = 22)]
        public string CertificateId { get; set; }

        /// <summary>
        /// Checks to see if the CertificateId property is set.
        /// </summary>
        internal bool IsSetCertificateId() => this.CertificateId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A short description to help identify the certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property InactiveDate. 
        /// <para>
        /// An optional date that specifies when the certificate becomes inactive. If you do not
        /// specify a value, <c>InactiveDate</c> takes the same value as <c>NotAfterDate</c>,
        /// which is specified by the CA.
        /// </para>
        /// </summary>
        public DateTime? InactiveDate { get; set; }

        /// <summary>
        /// Checks to see if the InactiveDate property is set.
        /// </summary>
        internal bool IsSetInactiveDate() => this.InactiveDate.HasValue;
    }
}
