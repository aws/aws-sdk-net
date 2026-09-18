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

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// An object that contains information about an S/MIME certificate that's associated
    /// with an email identity.
    /// </summary>
    public partial class IdentityCertificate
    {
        /// <summary>
        /// Gets and sets the property CertificateArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Certificate Manager (ACM) certificate that's
        /// associated with the email identity.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string CertificateArn { get; set; }

        /// <summary>
        /// Checks to see if the CertificateArn property is set.
        /// </summary>
        internal bool IsSetCertificateArn() => this.CertificateArn != null;

        /// <summary>
        /// Gets and sets the property CertificateExpiryTime. 
        /// <para>
        /// The timestamp after which the certificate is no longer valid.
        /// </para>
        /// </summary>
        public DateTime? CertificateExpiryTime { get; set; }

        /// <summary>
        /// Checks to see if the CertificateExpiryTime property is set.
        /// </summary>
        internal bool IsSetCertificateExpiryTime() => this.CertificateExpiryTime.HasValue;

        /// <summary>
        /// Gets and sets the property FromAddress. 
        /// <para>
        /// The email address that the certificate applies to.
        /// </para>
        /// </summary>
        public string FromAddress { get; set; }

        /// <summary>
        /// Checks to see if the FromAddress property is set.
        /// </summary>
        internal bool IsSetFromAddress() => this.FromAddress != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the certificate association. A status of <c>ACTIVE</c> indicates that
        /// the certificate is ready to use for signing.
        /// </para>
        /// </summary>
        public IdentityCertificateStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
