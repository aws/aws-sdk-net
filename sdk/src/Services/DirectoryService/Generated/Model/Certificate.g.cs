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

namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Information about the certificate.
    /// </summary>
    public partial class Certificate
    {
        /// <summary>
        /// Gets and sets the property CertificateId. 
        /// <para>
        /// The identifier of the certificate.
        /// </para>
        /// </summary>
        public string CertificateId { get; set; }

        /// <summary>
        /// Checks to see if the CertificateId property is set.
        /// </summary>
        internal bool IsSetCertificateId() => this.CertificateId != null;

        /// <summary>
        /// Gets and sets the property ClientCertAuthSettings. 
        /// <para>
        /// A <c>ClientCertAuthSettings</c> object that contains client certificate authentication
        /// settings.
        /// </para>
        /// </summary>
        public ClientCertAuthSettings ClientCertAuthSettings { get; set; }

        /// <summary>
        /// Checks to see if the ClientCertAuthSettings property is set.
        /// </summary>
        internal bool IsSetClientCertAuthSettings() => this.ClientCertAuthSettings != null;

        /// <summary>
        /// Gets and sets the property CommonName. 
        /// <para>
        /// The common name for the certificate.
        /// </para>
        /// </summary>
        public string CommonName { get; set; }

        /// <summary>
        /// Checks to see if the CommonName property is set.
        /// </summary>
        internal bool IsSetCommonName() => this.CommonName != null;

        /// <summary>
        /// Gets and sets the property ExpiryDateTime. 
        /// <para>
        /// The date and time when the certificate will expire.
        /// </para>
        /// </summary>
        public DateTime? ExpiryDateTime { get; set; }

        /// <summary>
        /// Checks to see if the ExpiryDateTime property is set.
        /// </summary>
        internal bool IsSetExpiryDateTime() => this.ExpiryDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property RegisteredDateTime. 
        /// <para>
        /// The date and time that the certificate was registered.
        /// </para>
        /// </summary>
        public DateTime? RegisteredDateTime { get; set; }

        /// <summary>
        /// Checks to see if the RegisteredDateTime property is set.
        /// </summary>
        internal bool IsSetRegisteredDateTime() => this.RegisteredDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the certificate.
        /// </para>
        /// </summary>
        public CertificateState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StateReason. 
        /// <para>
        /// Describes a state change for the certificate.
        /// </para>
        /// </summary>
        public string StateReason { get; set; }

        /// <summary>
        /// Checks to see if the StateReason property is set.
        /// </summary>
        internal bool IsSetStateReason() => this.StateReason != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The function that the registered certificate performs. Valid values include <c>ClientLDAPS</c>
        /// or <c>ClientCertAuth</c>. The default value is <c>ClientLDAPS</c>.
        /// </para>
        /// </summary>
        public CertificateType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
