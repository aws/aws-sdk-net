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
 * Do not modify this file. This file is generated from the route53domains-2014-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53Domains.Model
{
    /// <summary>
    /// Information about the DNSSEC key.
    /// 
    ///  
    /// <para>
    /// You get this from your DNS provider and then give it to Route 53 (by using <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_AssociateDelegationSignerToDomain.html">AssociateDelegationSignerToDomain</a>)
    /// to pass it to the registry to establish the chain of trust.
    /// </para>
    /// </summary>
    public partial class DnssecKey
    {
        private int? _algorithm;
        private string _digest;
        private int? _digestType;
        private int? _flags;
        private string _id;
        private int? _keyTag;
        private string _publicKey;

        /// <summary>
        /// Gets and sets the property Algorithm. 
        /// <para>
        /// The number of the public key’s cryptographic algorithm according to an <a href="https://www.iana.org/assignments/dns-sec-alg-numbers/dns-sec-alg-numbers.xml">IANA</a>
        /// assignment. 
        /// </para>
        ///  
        /// <para>
        /// If Route 53 is your DNS service, set this to 13.
        /// </para>
        ///  
        /// <para>
        /// For more information about enabling DNSSEC signing, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/dns-configuring-dnssec-enable-signing.html">Enabling
        /// DNSSEC signing and establishing a chain of trust</a>.
        /// </para>
        /// </summary>
        public int Algorithm
        {
            get { return this._algorithm.GetValueOrDefault(); }
            set { this._algorithm = value; }
        }

        // Check to see if Algorithm property is set
        internal bool IsSetAlgorithm()
        {
            return this._algorithm.HasValue; 
        }

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
        public string Digest
        {
            get { return this._digest; }
            set { this._digest = value; }
        }

        // Check to see if Digest property is set
        internal bool IsSetDigest()
        {
            return this._digest != null;
        }

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
        public int DigestType
        {
            get { return this._digestType.GetValueOrDefault(); }
            set { this._digestType = value; }
        }

        // Check to see if DigestType property is set
        internal bool IsSetDigestType()
        {
            return this._digestType.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Flags. 
        /// <para>
        /// Defines the type of key. It can be either a KSK (key-signing-key, value 257) or ZSK
        /// (zone-signing-key, value 256). Using KSK is always encouraged. Only use ZSK if your
        /// DNS provider isn't Route 53 and you don’t have KSK available.
        /// </para>
        ///  
        /// <para>
        /// If you have KSK and ZSK keys, always use KSK to create a delegations signer (DS) record.
        /// If you have ZSK keys only – use ZSK to create a DS record.
        /// </para>
        /// </summary>
        public int Flags
        {
            get { return this._flags.GetValueOrDefault(); }
            set { this._flags = value; }
        }

        // Check to see if Flags property is set
        internal bool IsSetFlags()
        {
            return this._flags.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        ///  An ID assigned to each DS record created by <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_domains_AssociateDelegationSignerToDomain.html">AssociateDelegationSignerToDomain</a>.
        /// 
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property KeyTag. 
        /// <para>
        ///  A numeric identification of the DNSKEY record referred to by this DS record. 
        /// </para>
        /// </summary>
        public int KeyTag
        {
            get { return this._keyTag.GetValueOrDefault(); }
            set { this._keyTag = value; }
        }

        // Check to see if KeyTag property is set
        internal bool IsSetKeyTag()
        {
            return this._keyTag.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PublicKey. 
        /// <para>
        /// The base64-encoded public key part of the key pair that is passed to the registry
        /// .
        /// </para>
        /// </summary>
        [AWSProperty(Max=32768)]
        public string PublicKey
        {
            get { return this._publicKey; }
            set { this._publicKey = value; }
        }

        // Check to see if PublicKey property is set
        internal bool IsSetPublicKey()
        {
            return this._publicKey != null;
        }

    }
}