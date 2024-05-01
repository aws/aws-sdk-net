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
 * Do not modify this file. This file is generated from the acm-pca-2017-08-22.normal.json service model.
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
namespace Amazon.ACMPCA.Model
{
    /// <summary>
    /// Describes an ASN.1 X.400 <c>GeneralName</c> as defined in <a href="https://datatracker.ietf.org/doc/html/rfc5280">RFC
    /// 5280</a>. Only one of the following naming options should be provided. Providing more
    /// than one option results in an <c>InvalidArgsException</c> error.
    /// </summary>
    public partial class GeneralName
    {
        private ASN1Subject _directoryName;
        private string _dnsName;
        private EdiPartyName _ediPartyName;
        private string _ipAddress;
        private OtherName _otherName;
        private string _registeredId;
        private string _rfc822Name;
        private string _uniformResourceIdentifier;

        /// <summary>
        /// Gets and sets the property DirectoryName.
        /// </summary>
        public ASN1Subject DirectoryName
        {
            get { return this._directoryName; }
            set { this._directoryName = value; }
        }

        // Check to see if DirectoryName property is set
        internal bool IsSetDirectoryName()
        {
            return this._directoryName != null;
        }

        /// <summary>
        /// Gets and sets the property DnsName. 
        /// <para>
        /// Represents <c>GeneralName</c> as a DNS name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=253)]
        public string DnsName
        {
            get { return this._dnsName; }
            set { this._dnsName = value; }
        }

        // Check to see if DnsName property is set
        internal bool IsSetDnsName()
        {
            return this._dnsName != null;
        }

        /// <summary>
        /// Gets and sets the property EdiPartyName. 
        /// <para>
        /// Represents <c>GeneralName</c> as an <c>EdiPartyName</c> object.
        /// </para>
        /// </summary>
        public EdiPartyName EdiPartyName
        {
            get { return this._ediPartyName; }
            set { this._ediPartyName = value; }
        }

        // Check to see if EdiPartyName property is set
        internal bool IsSetEdiPartyName()
        {
            return this._ediPartyName != null;
        }

        /// <summary>
        /// Gets and sets the property IpAddress. 
        /// <para>
        /// Represents <c>GeneralName</c> as an IPv4 or IPv6 address.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=39)]
        public string IpAddress
        {
            get { return this._ipAddress; }
            set { this._ipAddress = value; }
        }

        // Check to see if IpAddress property is set
        internal bool IsSetIpAddress()
        {
            return this._ipAddress != null;
        }

        /// <summary>
        /// Gets and sets the property OtherName. 
        /// <para>
        /// Represents <c>GeneralName</c> using an <c>OtherName</c> object.
        /// </para>
        /// </summary>
        public OtherName OtherName
        {
            get { return this._otherName; }
            set { this._otherName = value; }
        }

        // Check to see if OtherName property is set
        internal bool IsSetOtherName()
        {
            return this._otherName != null;
        }

        /// <summary>
        /// Gets and sets the property RegisteredId. 
        /// <para>
        ///  Represents <c>GeneralName</c> as an object identifier (OID).
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=64)]
        public string RegisteredId
        {
            get { return this._registeredId; }
            set { this._registeredId = value; }
        }

        // Check to see if RegisteredId property is set
        internal bool IsSetRegisteredId()
        {
            return this._registeredId != null;
        }

        /// <summary>
        /// Gets and sets the property Rfc822Name. 
        /// <para>
        /// Represents <c>GeneralName</c> as an <a href="https://datatracker.ietf.org/doc/html/rfc822">RFC
        /// 822</a> email address.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string Rfc822Name
        {
            get { return this._rfc822Name; }
            set { this._rfc822Name = value; }
        }

        // Check to see if Rfc822Name property is set
        internal bool IsSetRfc822Name()
        {
            return this._rfc822Name != null;
        }

        /// <summary>
        /// Gets and sets the property UniformResourceIdentifier. 
        /// <para>
        /// Represents <c>GeneralName</c> as a URI.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=253)]
        public string UniformResourceIdentifier
        {
            get { return this._uniformResourceIdentifier; }
            set { this._uniformResourceIdentifier = value; }
        }

        // Check to see if UniformResourceIdentifier property is set
        internal bool IsSetUniformResourceIdentifier()
        {
            return this._uniformResourceIdentifier != null;
        }

    }
}