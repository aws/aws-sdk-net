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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes the validation record of each domain name in the SSL/TLS certificate.
    /// </summary>
    public partial class LoadBalancerTlsCertificateDomainValidationRecord
    {
        /// <summary>
        /// Gets and sets the property DnsRecordCreationState. 
        /// <para>
        /// An object that describes the state of the canonical name (CNAME) records that are
        /// automatically added by Lightsail to the DNS of a domain to validate domain ownership.
        /// </para>
        /// </summary>
        public LoadBalancerTlsCertificateDnsRecordCreationState DnsRecordCreationState { get; set; }

        /// <summary>
        /// Checks to see if the DnsRecordCreationState property is set.
        /// </summary>
        internal bool IsSetDnsRecordCreationState() => this.DnsRecordCreationState != null;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The domain name against which your SSL/TLS certificate was validated.
        /// </para>
        /// </summary>
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A fully qualified domain name in the certificate. For example, <c>example.com</c>.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of validation record. For example, <c>CNAME</c> for domain validation.
        /// </para>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property ValidationStatus. 
        /// <para>
        /// The validation status. Valid values are listed below.
        /// </para>
        /// </summary>
        public LoadBalancerTlsCertificateDomainStatus ValidationStatus { get; set; }

        /// <summary>
        /// Checks to see if the ValidationStatus property is set.
        /// </summary>
        internal bool IsSetValidationStatus() => this.ValidationStatus != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value for that type.
        /// </para>
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
