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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
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
        private string _name;
        private string _kmsArn;
        private int? _flag;
        private string _signingAlgorithmMnemonic;
        private int? _signingAlgorithmType;
        private string _digestAlgorithmMnemonic;
        private int? _digestAlgorithmType;
        private int? _keyTag;
        private string _digestValue;
        private string _publicKey;
        private string _dsRecord;
        private string _dnskeyRecord;
        private string _status;
        private string _statusMessage;
        private DateTime? _createdDate;
        private DateTime? _lastModifiedDate;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A string used to identify a key-signing key (KSK). <c>Name</c> can include numbers,
        /// letters, and underscores (_). <c>Name</c> must be unique for each key-signing key
        /// in the same hosted zone.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=128)]
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
        public string KmsArn
        {
            get { return this._kmsArn; }
            set { this._kmsArn = value; }
        }

        // Check to see if KmsArn property is set
        internal bool IsSetKmsArn()
        {
            return this._kmsArn != null;
        }

        /// <summary>
        /// Gets and sets the property Flag. 
        /// <para>
        /// An integer that specifies how the key is used. For key-signing key (KSK), this value
        /// is always 257.
        /// </para>
        /// </summary>
        public int? Flag
        {
            get { return this._flag; }
            set { this._flag = value; }
        }

        // Check to see if Flag property is set
        internal bool IsSetFlag()
        {
            return this._flag.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SigningAlgorithmMnemonic. 
        /// <para>
        /// A string used to represent the signing algorithm. This value must follow the guidelines
        /// provided by <a href="https://tools.ietf.org/html/rfc8624#section-3.1">RFC-8624 Section
        /// 3.1</a>. 
        /// </para>
        /// </summary>
        public string SigningAlgorithmMnemonic
        {
            get { return this._signingAlgorithmMnemonic; }
            set { this._signingAlgorithmMnemonic = value; }
        }

        // Check to see if SigningAlgorithmMnemonic property is set
        internal bool IsSetSigningAlgorithmMnemonic()
        {
            return this._signingAlgorithmMnemonic != null;
        }

        /// <summary>
        /// Gets and sets the property SigningAlgorithmType. 
        /// <para>
        /// An integer used to represent the signing algorithm. This value must follow the guidelines
        /// provided by <a href="https://tools.ietf.org/html/rfc8624#section-3.1">RFC-8624 Section
        /// 3.1</a>. 
        /// </para>
        /// </summary>
        public int? SigningAlgorithmType
        {
            get { return this._signingAlgorithmType; }
            set { this._signingAlgorithmType = value; }
        }

        // Check to see if SigningAlgorithmType property is set
        internal bool IsSetSigningAlgorithmType()
        {
            return this._signingAlgorithmType.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DigestAlgorithmMnemonic. 
        /// <para>
        /// A string used to represent the delegation signer digest algorithm. This value must
        /// follow the guidelines provided by <a href="https://tools.ietf.org/html/rfc8624#section-3.3">RFC-8624
        /// Section 3.3</a>. 
        /// </para>
        /// </summary>
        public string DigestAlgorithmMnemonic
        {
            get { return this._digestAlgorithmMnemonic; }
            set { this._digestAlgorithmMnemonic = value; }
        }

        // Check to see if DigestAlgorithmMnemonic property is set
        internal bool IsSetDigestAlgorithmMnemonic()
        {
            return this._digestAlgorithmMnemonic != null;
        }

        /// <summary>
        /// Gets and sets the property DigestAlgorithmType. 
        /// <para>
        /// An integer used to represent the delegation signer digest algorithm. This value must
        /// follow the guidelines provided by <a href="https://tools.ietf.org/html/rfc8624#section-3.3">RFC-8624
        /// Section 3.3</a>.
        /// </para>
        /// </summary>
        public int? DigestAlgorithmType
        {
            get { return this._digestAlgorithmType; }
            set { this._digestAlgorithmType = value; }
        }

        // Check to see if DigestAlgorithmType property is set
        internal bool IsSetDigestAlgorithmType()
        {
            return this._digestAlgorithmType.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KeyTag. 
        /// <para>
        /// An integer used to identify the DNSSEC record for the domain name. The process used
        /// to calculate the value is described in <a href="https://tools.ietf.org/rfc/rfc4034.txt">RFC-4034
        /// Appendix B</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=65536)]
        public int? KeyTag
        {
            get { return this._keyTag; }
            set { this._keyTag = value; }
        }

        // Check to see if KeyTag property is set
        internal bool IsSetKeyTag()
        {
            return this._keyTag.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DigestValue. 
        /// <para>
        /// A cryptographic digest of a DNSKEY resource record (RR). DNSKEY records are used to
        /// publish the public key that resolvers can use to verify DNSSEC signatures that are
        /// used to secure certain kinds of information provided by the DNS system.
        /// </para>
        /// </summary>
        public string DigestValue
        {
            get { return this._digestValue; }
            set { this._digestValue = value; }
        }

        // Check to see if DigestValue property is set
        internal bool IsSetDigestValue()
        {
            return this._digestValue != null;
        }

        /// <summary>
        /// Gets and sets the property PublicKey. 
        /// <para>
        /// The public key, represented as a Base64 encoding, as required by <a href="https://tools.ietf.org/rfc/rfc4034.txt">
        /// RFC-4034 Page 5</a>.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property DSRecord. 
        /// <para>
        /// A string that represents a delegation signer (DS) record.
        /// </para>
        /// </summary>
        public string DSRecord
        {
            get { return this._dsRecord; }
            set { this._dsRecord = value; }
        }

        // Check to see if DSRecord property is set
        internal bool IsSetDSRecord()
        {
            return this._dsRecord != null;
        }

        /// <summary>
        /// Gets and sets the property DNSKEYRecord. 
        /// <para>
        /// A string that represents a DNSKEY record.
        /// </para>
        /// </summary>
        public string DNSKEYRecord
        {
            get { return this._dnskeyRecord; }
            set { this._dnskeyRecord = value; }
        }

        // Check to see if DNSKEYRecord property is set
        internal bool IsSetDNSKEYRecord()
        {
            return this._dnskeyRecord != null;
        }

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
        [AWSProperty(Min=5, Max=150)]
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The status message provided for the following key-signing key (KSK) statuses: <c>ACTION_NEEDED</c>
        /// or <c>INTERNAL_FAILURE</c>. The status message includes information about what the
        /// problem might be and steps that you can take to correct the issue.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=512)]
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date when the key-signing key (KSK) was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedDate
        {
            get { return this._createdDate; }
            set { this._createdDate = value; }
        }

        // Check to see if CreatedDate property is set
        internal bool IsSetCreatedDate()
        {
            return this._createdDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The last time that the key-signing key (KSK) was changed.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedDate
        {
            get { return this._lastModifiedDate; }
            set { this._lastModifiedDate = value; }
        }

        // Check to see if LastModifiedDate property is set
        internal bool IsSetLastModifiedDate()
        {
            return this._lastModifiedDate.HasValue; 
        }

    }
}