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

namespace Amazon.Route53Domains.Model
{
    /// <summary>
    /// Information about the DNSSEC key.
    /// 
    ///  
    /// <para>
    /// You get this from your DNS provider and then give it to Route 53 (by using <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_AssociateDelegationSignerToDomain.html">AssociateDelegationSignerToDomain</a>)
    /// to pass it to the registry to establish the chain of trust.
    /// </para>
    /// </summary>
    public partial class DnssecKey
    {
        /// <summary>
        /// Gets and sets the property Algorithm. 
        /// <para>
        /// The number of the public key’s cryptographic algorithm according to an <a href="https://www.iana.org/assignments/dns-sec-alg-numbers/dns-sec-alg-numbers.xml">IANA</a>
        /// assignment. 
        /// </para>
        ///  
        /// <para>
        /// If Route 53 is your DNS service, set this to 13.
        /// </para>
        ///  
        /// <para>
        /// For more information about enabling DNSSEC signing, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/dns-configuring-dnssec-enable-signing.html">Enabling
        /// DNSSEC signing and establishing a chain of trust</a>.
        /// </para>
        /// </summary>
        public int? Algorithm { get; set; }

        /// <summary>
        /// Checks to see if the Algorithm property is set.
        /// </summary>
        internal bool IsSetAlgorithm() => this.Algorithm.HasValue;

        /// <summary>
        /// Gets and sets the property Digest. 
        /// <para>
        ///  The delegation signer digest.
        /// </para>
        ///  
        /// <para>
        /// Digest is calculated from the public key provided using specified digest algorithm
        /// and this digest is the actual value returned from the registry nameservers as the
        /// value of DS records. 
        /// </para>
        /// </summary>
        public string Digest { get; set; }

        /// <summary>
        /// Checks to see if the Digest property is set.
        /// </summary>
        internal bool IsSetDigest() => this.Digest != null;

        /// <summary>
        /// Gets and sets the property DigestType. 
        /// <para>
        ///  The number of the DS digest algorithm according to an IANA assignment.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://www.iana.org/assignments/ds-rr-types/ds-rr-types.xhtml">IANA</a>
        /// for DNSSEC Delegation Signer (DS) Resource Record (RR) Type Digest Algorithms. 
        /// </para>
        /// </summary>
        public int? DigestType { get; set; }

        /// <summary>
        /// Checks to see if the DigestType property is set.
        /// </summary>
        internal bool IsSetDigestType() => this.DigestType.HasValue;

        /// <summary>
        /// Gets and sets the property Flags. 
        /// <para>
        /// The DNSKEY flags that indicate the key type. This field is deprecated; the <c>DnssecKey</c>
        /// response no longer returns the flags.
        /// </para>
        /// </summary>
        [Obsolete("The DnssecKey response no longer returns the flags.")]
        public int? Flags { get; set; }

        /// <summary>
        /// Checks to see if the Flags property is set.
        /// </summary>
        internal bool IsSetFlags() => this.Flags.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        ///  An ID assigned to each DS record created by <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_AssociateDelegationSignerToDomain.html">AssociateDelegationSignerToDomain</a>.
        /// 
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property KeyTag. 
        /// <para>
        ///  A numeric identification of the DNSKEY record referred to by this DS record. 
        /// </para>
        /// </summary>
        public int? KeyTag { get; set; }

        /// <summary>
        /// Checks to see if the KeyTag property is set.
        /// </summary>
        internal bool IsSetKeyTag() => this.KeyTag.HasValue;

        /// <summary>
        /// Gets and sets the property PublicKey. 
        /// <para>
        /// The base64-encoded public key of the key pair. This field is deprecated; the <c>DnssecKey</c>
        /// response no longer returns the public key.
        /// </para>
        /// </summary>
        [Obsolete("The DnssecKey response no longer returns the public key.")]
        [AWSProperty(Min = 0, Max = 32768)]
        public string PublicKey { get; set; }

        /// <summary>
        /// Checks to see if the PublicKey property is set.
        /// </summary>
        internal bool IsSetPublicKey() => this.PublicKey != null;
    }
}
