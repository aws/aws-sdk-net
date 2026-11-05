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
    /// Describes the public SSH host keys or the RDP certificate.
    /// </summary>
    public partial class HostKeyAttributes
    {
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
        public string Algorithm { get; set; }

        /// <summary>
        /// Checks to see if the Algorithm property is set.
        /// </summary>
        internal bool IsSetAlgorithm() => this.Algorithm != null;

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
        public string FingerprintSHA1 { get; set; }

        /// <summary>
        /// Checks to see if the FingerprintSHA1 property is set.
        /// </summary>
        internal bool IsSetFingerprintSHA1() => this.FingerprintSHA1 != null;

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
        public string FingerprintSHA256 { get; set; }

        /// <summary>
        /// Checks to see if the FingerprintSHA256 property is set.
        /// </summary>
        internal bool IsSetFingerprintSHA256() => this.FingerprintSHA256 != null;

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
        public DateTime? NotValidAfter { get; set; }

        /// <summary>
        /// Checks to see if the NotValidAfter property is set.
        /// </summary>
        internal bool IsSetNotValidAfter() => this.NotValidAfter.HasValue;

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
        public DateTime? NotValidBefore { get; set; }

        /// <summary>
        /// Checks to see if the NotValidBefore property is set.
        /// </summary>
        internal bool IsSetNotValidBefore() => this.NotValidBefore.HasValue;

        /// <summary>
        /// Gets and sets the property PublicKey. 
        /// <para>
        /// The public SSH host key or the RDP certificate.
        /// </para>
        /// </summary>
        public string PublicKey { get; set; }

        /// <summary>
        /// Checks to see if the PublicKey property is set.
        /// </summary>
        internal bool IsSetPublicKey() => this.PublicKey != null;

        /// <summary>
        /// Gets and sets the property WitnessedAt. 
        /// <para>
        /// The time that the SSH host key or RDP certificate was recorded by Lightsail.
        /// </para>
        /// </summary>
        public DateTime? WitnessedAt { get; set; }

        /// <summary>
        /// Checks to see if the WitnessedAt property is set.
        /// </summary>
        internal bool IsSetWitnessedAt() => this.WitnessedAt.HasValue;
    }
}
