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

namespace Amazon.Route53.Model
{
    /// <summary>
    /// A key-signing key (KSK) is a complex type that represents a public/private key pair.
    /// The private key is used to generate a digital signature for the zone signing key (ZSK).
    /// The public key is stored in the DNS and is used to authenticate the ZSK. A KSK is
    /// always associated with a hosted zone; it cannot exist by itself.
    /// </summary>
    public partial class KeySigningKey
    {
        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A string used to identify a key-signing key (KSK). <c>Name</c> can include numbers,
        /// letters, and underscores (_). <c>Name</c> must be unique for each key-signing key
        /// in the same hosted zone.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property KmsArn. 
        /// <para>
        /// The Amazon resource name (ARN) used to identify the customer managed key in Key Management
        /// Service (KMS). The <c>KmsArn</c> must be unique for each key-signing key (KSK) in
        /// a single hosted zone.
        /// </para>
        ///  
        /// <para>
        /// You must configure the customer managed key as follows:
        /// </para>
        ///  <dl> <dt>Status</dt> <dd> 
        /// <para>
        /// Enabled
        /// </para>
        ///  </dd> <dt>Key spec</dt> <dd> 
        /// <para>
        /// ECC_NIST_P256
        /// </para>
        ///  </dd> <dt>Key usage</dt> <dd> 
        /// <para>
        /// Sign and verify
        /// </para>
        ///  </dd> <dt>Key policy</dt> <dd> 
        /// <para>
        /// The key policy must give permission for the following actions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// DescribeKey
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// GetPublicKey
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Sign
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The key policy must also include the Amazon Route 53 service in the principal for
        /// your account. Specify the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>"Service": "dnssec-route53.amazonaws.com"</c> 
        /// </para>
        ///  </li> </ul> </dd> </dl> 
        /// <para>
        /// For more information about working with the customer managed key in KMS, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html">Key
        /// Management Service concepts</a>.
        /// </para>
        /// </summary>
        public string KmsArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsArn property is set.
        /// </summary>
        internal bool IsSetKmsArn() => this.KmsArn != null;

        /// <summary>
        /// Gets and sets the property Flag. 
        /// <para>
        /// An integer that specifies how the key is used. For key-signing key (KSK), this value
        /// is always 257.
        /// </para>
        /// </summary>
        public int? Flag { get; set; }

        /// <summary>
        /// Checks to see if the Flag property is set.
        /// </summary>
        internal bool IsSetFlag() => this.Flag.HasValue;

        /// <summary>
        /// Gets and sets the property SigningAlgorithmMnemonic. 
        /// <para>
        /// A string used to represent the signing algorithm. This value must follow the guidelines
        /// provided by <a href="https://tools.ietf.org/html/rfc8624#section-3.1">RFC-8624 Section
        /// 3.1</a>. 
        /// </para>
        /// </summary>
        public string SigningAlgorithmMnemonic { get; set; }

        /// <summary>
        /// Checks to see if the SigningAlgorithmMnemonic property is set.
        /// </summary>
        internal bool IsSetSigningAlgorithmMnemonic() => this.SigningAlgorithmMnemonic != null;

        /// <summary>
        /// Gets and sets the property SigningAlgorithmType. 
        /// <para>
        /// An integer used to represent the signing algorithm. This value must follow the guidelines
        /// provided by <a href="https://tools.ietf.org/html/rfc8624#section-3.1">RFC-8624 Section
        /// 3.1</a>. 
        /// </para>
        /// </summary>
        public int? SigningAlgorithmType { get; set; }

        /// <summary>
        /// Checks to see if the SigningAlgorithmType property is set.
        /// </summary>
        internal bool IsSetSigningAlgorithmType() => this.SigningAlgorithmType.HasValue;

        /// <summary>
        /// Gets and sets the property DigestAlgorithmMnemonic. 
        /// <para>
        /// A string used to represent the delegation signer digest algorithm. This value must
        /// follow the guidelines provided by <a href="https://tools.ietf.org/html/rfc8624#section-3.3">RFC-8624
        /// Section 3.3</a>. 
        /// </para>
        /// </summary>
        public string DigestAlgorithmMnemonic { get; set; }

        /// <summary>
        /// Checks to see if the DigestAlgorithmMnemonic property is set.
        /// </summary>
        internal bool IsSetDigestAlgorithmMnemonic() => this.DigestAlgorithmMnemonic != null;

        /// <summary>
        /// Gets and sets the property DigestAlgorithmType. 
        /// <para>
        /// An integer used to represent the delegation signer digest algorithm. This value must
        /// follow the guidelines provided by <a href="https://tools.ietf.org/html/rfc8624#section-3.3">RFC-8624
        /// Section 3.3</a>.
        /// </para>
        /// </summary>
        public int? DigestAlgorithmType { get; set; }

        /// <summary>
        /// Checks to see if the DigestAlgorithmType property is set.
        /// </summary>
        internal bool IsSetDigestAlgorithmType() => this.DigestAlgorithmType.HasValue;

        /// <summary>
        /// Gets and sets the property KeyTag. 
        /// <para>
        /// An integer used to identify the DNSSEC record for the domain name. The process used
        /// to calculate the value is described in <a href="https://tools.ietf.org/rfc/rfc4034.txt">RFC-4034
        /// Appendix B</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 65536)]
        public int? KeyTag { get; set; }

        /// <summary>
        /// Checks to see if the KeyTag property is set.
        /// </summary>
        internal bool IsSetKeyTag() => this.KeyTag.HasValue;

        /// <summary>
        /// Gets and sets the property DigestValue. 
        /// <para>
        /// A cryptographic digest of a DNSKEY resource record (RR). DNSKEY records are used to
        /// publish the public key that resolvers can use to verify DNSSEC signatures that are
        /// used to secure certain kinds of information provided by the DNS system.
        /// </para>
        /// </summary>
        public string DigestValue { get; set; }

        /// <summary>
        /// Checks to see if the DigestValue property is set.
        /// </summary>
        internal bool IsSetDigestValue() => this.DigestValue != null;

        /// <summary>
        /// Gets and sets the property PublicKey. 
        /// <para>
        /// The public key, represented as a Base64 encoding, as required by <a href="https://tools.ietf.org/rfc/rfc4034.txt">
        /// RFC-4034 Page 5</a>.
        /// </para>
        /// </summary>
        public string PublicKey { get; set; }

        /// <summary>
        /// Checks to see if the PublicKey property is set.
        /// </summary>
        internal bool IsSetPublicKey() => this.PublicKey != null;

        /// <summary>
        /// Gets and sets the property DSRecord. 
        /// <para>
        /// A string that represents a delegation signer (DS) record.
        /// </para>
        /// </summary>
        public string DSRecord { get; set; }

        /// <summary>
        /// Checks to see if the DSRecord property is set.
        /// </summary>
        internal bool IsSetDSRecord() => this.DSRecord != null;

        /// <summary>
        /// Gets and sets the property DNSKEYRecord. 
        /// <para>
        /// A string that represents a DNSKEY record.
        /// </para>
        /// </summary>
        public string DNSKEYRecord { get; set; }

        /// <summary>
        /// Checks to see if the DNSKEYRecord property is set.
        /// </summary>
        internal bool IsSetDNSKEYRecord() => this.DNSKEYRecord != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// A string that represents the current key-signing key (KSK) status.
        /// </para>
        ///  
        /// <para>
        /// Status can have one of the following values:
        /// </para>
        ///  <dl> <dt>ACTIVE</dt> <dd> 
        /// <para>
        /// The KSK is being used for signing.
        /// </para>
        ///  </dd> <dt>INACTIVE</dt> <dd> 
        /// <para>
        /// The KSK is not being used for signing.
        /// </para>
        ///  </dd> <dt>DELETING</dt> <dd> 
        /// <para>
        /// The KSK is in the process of being deleted.
        /// </para>
        ///  </dd> <dt>ACTION_NEEDED</dt> <dd> 
        /// <para>
        /// There is a problem with the KSK that requires you to take action to resolve. For example,
        /// the customer managed key might have been deleted, or the permissions for the customer
        /// managed key might have been changed.
        /// </para>
        ///  </dd> <dt>INTERNAL_FAILURE</dt> <dd> 
        /// <para>
        /// There was an error during a request. Before you can continue to work with DNSSEC signing,
        /// including actions that involve this KSK, you must correct the problem. For example,
        /// you may need to activate or deactivate the KSK.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        [AWSProperty(Min = 5, Max = 150)]
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The status message provided for the following key-signing key (KSK) statuses: <c>ACTION_NEEDED</c>
        /// or <c>INTERNAL_FAILURE</c>. The status message includes information about what the
        /// problem might be and steps that you can take to correct the issue.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date when the key-signing key (KSK) was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Checks to see if the CreatedDate property is set.
        /// </summary>
        internal bool IsSetCreatedDate() => this.CreatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The last time that the key-signing key (KSK) was changed.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDate property is set.
        /// </summary>
        internal bool IsSetLastModifiedDate() => this.LastModifiedDate.HasValue;
    }
}
