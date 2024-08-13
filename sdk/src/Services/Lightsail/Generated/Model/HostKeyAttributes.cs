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
    /// Describes the public SSH host keys or the RDP certificate.
    /// </summary>
    public partial class HostKeyAttributes
    {
        private string _algorithm;
        private string _fingerprintsha1;
        private string _fingerprintsha256;
        private DateTime? _notValidAfter;
        private DateTime? _notValidBefore;
        private string _publicKey;
        private DateTime? _witnessedAt;

        /// <summary>
        /// Gets and sets the property Algorithm. 
        /// <para>
        /// The SSH host key algorithm or the RDP certificate format.
        /// </para>
        ///  
        /// <para>
        /// For SSH host keys, the algorithm may be <c>ssh-rsa</c>, <c>ecdsa-sha2-nistp256</c>,
        /// <c>ssh-ed25519</c>, etc. For RDP certificates, the algorithm is always <c>x509-cert</c>.
        /// </para>
        /// </summary>
        public string Algorithm
        {
            get { return this._algorithm; }
            set { this._algorithm = value; }
        }

        // Check to see if Algorithm property is set
        internal bool IsSetAlgorithm()
        {
            return this._algorithm != null;
        }

        /// <summary>
        /// Gets and sets the property FingerprintSHA1. 
        /// <para>
        /// The SHA-1 fingerprint of the returned SSH host key or RDP certificate.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Example of an SHA-1 SSH fingerprint:
        /// </para>
        ///  
        /// <para>
        ///  <c>SHA1:1CHH6FaAaXjtFOsR/t83vf91SR0</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Example of an SHA-1 RDP fingerprint:
        /// </para>
        ///  
        /// <para>
        ///  <c>af:34:51:fe:09:f0:e0:da:b8:4e:56:ca:60:c2:10:ff:38:06:db:45</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string FingerprintSHA1
        {
            get { return this._fingerprintsha1; }
            set { this._fingerprintsha1 = value; }
        }

        // Check to see if FingerprintSHA1 property is set
        internal bool IsSetFingerprintSHA1()
        {
            return this._fingerprintsha1 != null;
        }

        /// <summary>
        /// Gets and sets the property FingerprintSHA256. 
        /// <para>
        /// The SHA-256 fingerprint of the returned SSH host key or RDP certificate.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Example of an SHA-256 SSH fingerprint:
        /// </para>
        ///  
        /// <para>
        ///  <c>SHA256:KTsMnRBh1IhD17HpdfsbzeGA4jOijm5tyXsMjKVbB8o</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Example of an SHA-256 RDP fingerprint:
        /// </para>
        ///  
        /// <para>
        ///  <c>03:9b:36:9f:4b:de:4e:61:70:fc:7c:c9:78:e7:d2:1a:1c:25:a8:0c:91:f6:7c:e4:d6:a0:85:c8:b4:53:99:68</c>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string FingerprintSHA256
        {
            get { return this._fingerprintsha256; }
            set { this._fingerprintsha256 = value; }
        }

        // Check to see if FingerprintSHA256 property is set
        internal bool IsSetFingerprintSHA256()
        {
            return this._fingerprintsha256 != null;
        }

        /// <summary>
        /// Gets and sets the property NotValidAfter. 
        /// <para>
        /// The returned RDP certificate is not valid after this point in time.
        /// </para>
        ///  
        /// <para>
        /// This value is listed only for RDP certificates.
        /// </para>
        /// </summary>
        public DateTime? NotValidAfter
        {
            get { return this._notValidAfter; }
            set { this._notValidAfter = value; }
        }

        // Check to see if NotValidAfter property is set
        internal bool IsSetNotValidAfter()
        {
            return this._notValidAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NotValidBefore. 
        /// <para>
        /// The returned RDP certificate is valid after this point in time.
        /// </para>
        ///  
        /// <para>
        /// This value is listed only for RDP certificates.
        /// </para>
        /// </summary>
        public DateTime? NotValidBefore
        {
            get { return this._notValidBefore; }
            set { this._notValidBefore = value; }
        }

        // Check to see if NotValidBefore property is set
        internal bool IsSetNotValidBefore()
        {
            return this._notValidBefore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PublicKey. 
        /// <para>
        /// The public SSH host key or the RDP certificate.
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
        /// Gets and sets the property WitnessedAt. 
        /// <para>
        /// The time that the SSH host key or RDP certificate was recorded by Lightsail.
        /// </para>
        /// </summary>
        public DateTime? WitnessedAt
        {
            get { return this._witnessedAt; }
            set { this._witnessedAt = value; }
        }

        // Check to see if WitnessedAt property is set
        internal bool IsSetWitnessedAt()
        {
            return this._witnessedAt.HasValue; 
        }

    }
}