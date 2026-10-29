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
    /// The certificate issuer indentifier.
    /// </summary>
    public partial class IssuerCertificateIdentifier
    {
        /// <summary>
        /// Gets and sets the property IssuerCertificateSerialNumber. 
        /// <para>
        /// The issuer certificate serial number.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public string IssuerCertificateSerialNumber { get; set; }

        /// <summary>
        /// Checks to see if the IssuerCertificateSerialNumber property is set.
        /// </summary>
        internal bool IsSetIssuerCertificateSerialNumber() => this.IssuerCertificateSerialNumber != null;

        /// <summary>
        /// Gets and sets the property IssuerCertificateSubject. 
        /// <para>
        /// The subject of the issuer certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string IssuerCertificateSubject { get; set; }

        /// <summary>
        /// Checks to see if the IssuerCertificateSubject property is set.
        /// </summary>
        internal bool IsSetIssuerCertificateSubject() => this.IssuerCertificateSubject != null;

        /// <summary>
        /// Gets and sets the property IssuerId. 
        /// <para>
        /// The issuer ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string IssuerId { get; set; }

        /// <summary>
        /// Checks to see if the IssuerId property is set.
        /// </summary>
        internal bool IsSetIssuerId() => this.IssuerId != null;
    }
}
