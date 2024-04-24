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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
        private LoadBalancerTlsCertificateDnsRecordCreationState _dnsRecordCreationState;
        private string _domainName;
        private string _name;
        private string _type;
        private LoadBalancerTlsCertificateDomainStatus _validationStatus;
        private string _value;

        /// <summary>
        /// Gets and sets the property DnsRecordCreationState. 
        /// <para>
        /// An object that describes the state of the canonical name (CNAME) records that are
        /// automatically added by Lightsail to the DNS of a domain to validate domain ownership.
        /// </para>
        /// </summary>
        public LoadBalancerTlsCertificateDnsRecordCreationState DnsRecordCreationState
        {
            get { return this._dnsRecordCreationState; }
            set { this._dnsRecordCreationState = value; }
        }

        // Check to see if DnsRecordCreationState property is set
        internal bool IsSetDnsRecordCreationState()
        {
            return this._dnsRecordCreationState != null;
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The domain name against which your SSL/TLS certificate was validated.
        /// </para>
        /// </summary>
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A fully qualified domain name in the certificate. For example, <c>example.com</c>.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of validation record. For example, <c>CNAME</c> for domain validation.
        /// </para>
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property ValidationStatus. 
        /// <para>
        /// The validation status. Valid values are listed below.
        /// </para>
        /// </summary>
        public LoadBalancerTlsCertificateDomainStatus ValidationStatus
        {
            get { return this._validationStatus; }
            set { this._validationStatus = value; }
        }

        // Check to see if ValidationStatus property is set
        internal bool IsSetValidationStatus()
        {
            return this._validationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value for that type.
        /// </para>
        /// </summary>
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}