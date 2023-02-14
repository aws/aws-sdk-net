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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// An object that contains configuration for Bring Your Own DKIM (BYODKIM), or, for Easy
    /// DKIM
    /// </summary>
    public partial class DkimSigningAttributes
    {
        private string _domainSigningPrivateKey;
        private string _domainSigningSelector;
        private DkimSigningKeyLength _nextSigningKeyLength;

        /// <summary>
        /// Gets and sets the property DomainSigningPrivateKey. 
        /// <para>
        /// [Bring Your Own DKIM] A private key that's used to generate a DKIM signature.
        /// </para>
        ///  
        /// <para>
        /// The private key must use 1024 or 2048-bit RSA encryption, and must be encoded using
        /// base64 encoding.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=20480)]
        public string DomainSigningPrivateKey
        {
            get { return this._domainSigningPrivateKey; }
            set { this._domainSigningPrivateKey = value; }
        }

        // Check to see if DomainSigningPrivateKey property is set
        internal bool IsSetDomainSigningPrivateKey()
        {
            return this._domainSigningPrivateKey != null;
        }

        /// <summary>
        /// Gets and sets the property DomainSigningSelector. 
        /// <para>
        /// [Bring Your Own DKIM] A string that's used to identify a public key in the DNS configuration
        /// for a domain.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string DomainSigningSelector
        {
            get { return this._domainSigningSelector; }
            set { this._domainSigningSelector = value; }
        }

        // Check to see if DomainSigningSelector property is set
        internal bool IsSetDomainSigningSelector()
        {
            return this._domainSigningSelector != null;
        }

        /// <summary>
        /// Gets and sets the property NextSigningKeyLength. 
        /// <para>
        /// [Easy DKIM] The key length of the future DKIM key pair to be generated. This can be
        /// changed at most once per day.
        /// </para>
        /// </summary>
        public DkimSigningKeyLength NextSigningKeyLength
        {
            get { return this._nextSigningKeyLength; }
            set { this._nextSigningKeyLength = value; }
        }

        // Check to see if NextSigningKeyLength property is set
        internal bool IsSetNextSigningKeyLength()
        {
            return this._nextSigningKeyLength != null;
        }

    }
}