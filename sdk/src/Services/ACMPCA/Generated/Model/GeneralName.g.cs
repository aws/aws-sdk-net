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

namespace Amazon.ACMPCA.Model
{
    /// <summary>
    /// Describes an ASN.1 X.400 <c>GeneralName</c> as defined in <a href="https://datatracker.ietf.org/doc/html/rfc5280">RFC
    /// 5280</a>. Only one of the following naming options should be provided. Providing more
    /// than one option results in an <c>InvalidArgsException</c> error.
    /// </summary>
    public partial class GeneralName
    {
        /// <summary>
        /// Gets and sets the property DirectoryName.
        /// </summary>
        public ASN1Subject DirectoryName { get; set; }

        /// <summary>
        /// Checks to see if the DirectoryName property is set.
        /// </summary>
        internal bool IsSetDirectoryName() => this.DirectoryName != null;

        /// <summary>
        /// Gets and sets the property DnsName. 
        /// <para>
        /// Represents <c>GeneralName</c> as a DNS name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 253)]
        public string DnsName { get; set; }

        /// <summary>
        /// Checks to see if the DnsName property is set.
        /// </summary>
        internal bool IsSetDnsName() => this.DnsName != null;

        /// <summary>
        /// Gets and sets the property EdiPartyName. 
        /// <para>
        /// Represents <c>GeneralName</c> as an <c>EdiPartyName</c> object.
        /// </para>
        /// </summary>
        public EdiPartyName EdiPartyName { get; set; }

        /// <summary>
        /// Checks to see if the EdiPartyName property is set.
        /// </summary>
        internal bool IsSetEdiPartyName() => this.EdiPartyName != null;

        /// <summary>
        /// Gets and sets the property IpAddress. 
        /// <para>
        /// Represents <c>GeneralName</c> as an IPv4 or IPv6 address.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 39)]
        public string IpAddress { get; set; }

        /// <summary>
        /// Checks to see if the IpAddress property is set.
        /// </summary>
        internal bool IsSetIpAddress() => this.IpAddress != null;

        /// <summary>
        /// Gets and sets the property OtherName. 
        /// <para>
        /// Represents <c>GeneralName</c> using an <c>OtherName</c> object.
        /// </para>
        /// </summary>
        public OtherName OtherName { get; set; }

        /// <summary>
        /// Checks to see if the OtherName property is set.
        /// </summary>
        internal bool IsSetOtherName() => this.OtherName != null;

        /// <summary>
        /// Gets and sets the property RegisteredId. 
        /// <para>
        ///  Represents <c>GeneralName</c> as an object identifier (OID).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string RegisteredId { get; set; }

        /// <summary>
        /// Checks to see if the RegisteredId property is set.
        /// </summary>
        internal bool IsSetRegisteredId() => this.RegisteredId != null;

        /// <summary>
        /// Gets and sets the property Rfc822Name. 
        /// <para>
        /// Represents <c>GeneralName</c> as an <a href="https://datatracker.ietf.org/doc/html/rfc822">RFC
        /// 822</a> email address.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Rfc822Name { get; set; }

        /// <summary>
        /// Checks to see if the Rfc822Name property is set.
        /// </summary>
        internal bool IsSetRfc822Name() => this.Rfc822Name != null;

        /// <summary>
        /// Gets and sets the property UniformResourceIdentifier. 
        /// <para>
        /// Represents <c>GeneralName</c> as a URI.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 253)]
        public string UniformResourceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the UniformResourceIdentifier property is set.
        /// </summary>
        internal bool IsSetUniformResourceIdentifier() => this.UniformResourceIdentifier != null;
    }
}
