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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// An object that contains configuration for Bring Your Own DKIM (BYODKIM), or, for Easy
    /// DKIM
    /// </summary>
    public partial class DkimSigningAttributes
    {
        private DkimSigningAttributesOrigin _domainSigningAttributesOrigin;
        private string _domainSigningPrivateKey;
        private string _domainSigningSelector;
        private DkimSigningKeyLength _nextSigningKeyLength;

        /// <summary>
        /// Gets and sets the property DomainSigningAttributesOrigin. 
        /// <para>
        /// The attribute to use for configuring DKIM for the identity depends on the operation:
        /// 
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// For <c>PutEmailIdentityDkimSigningAttributes</c>: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// None of the values are allowed - use the <a href="https://docs.aws.amazon.com/ses/latest/APIReference-V2/API_PutEmailIdentityDkimSigningAttributes.html#SES-PutEmailIdentityDkimSigningAttributes-request-SigningAttributesOrigin">
        /// <c>SigningAttributesOrigin</c> </a> parameter instead 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// For <c>CreateEmailIdentity</c> when replicating a parent identity's DKIM configuration:
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Allowed values: All values except <c>AWS_SES</c> and <c>EXTERNAL</c> 
        /// </para>
        ///  </li> </ul> </li> </ol> <ul> <li> 
        /// <para>
        ///  <c>AWS_SES</c> – Configure DKIM for the identity by using Easy DKIM. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EXTERNAL</c> – Configure DKIM for the identity by using Bring Your Own DKIM (BYODKIM).
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_SES_AF_SOUTH_1</c> – Configure DKIM for the identity by replicating from a
        /// parent identity in Africa (Cape Town) region using Deterministic Easy-DKIM (DEED).
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_SES_EU_NORTH_1</c> – Configure DKIM for the identity by replicating from a
        /// parent identity in Europe (Stockholm) region using Deterministic Easy-DKIM (DEED).
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_SES_AP_SOUTH_1</c> – Configure DKIM for the identity by replicating from a
        /// parent identity in Asia Pacific (Mumbai) region using Deterministic Easy-DKIM (DEED).
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_SES_AP_SOUTH_2</c> – Configure DKIM for the identity by replicating from a
        /// parent identity in Asia Pacific (Hyderabad) region using Deterministic Easy-DKIM (DEED).
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_SES_EU_WEST_3</c> – Configure DKIM for the identity by replicating from a
        /// parent identity in Europe (Paris) region using Deterministic Easy-DKIM (DEED). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_SES_EU_WEST_2</c> – Configure DKIM for the identity by replicating from a
        /// parent identity in Europe (London) region using Deterministic Easy-DKIM (DEED). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_SES_EU_SOUTH_1</c> – Configure DKIM for the identity by replicating from a
        /// parent identity in Europe (Milan) region using Deterministic Easy-DKIM (DEED). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_SES_EU_WEST_1</c> – Configure DKIM for the identity by replicating from a
        /// parent identity in Europe (Ireland) region using Deterministic Easy-DKIM (DEED). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_SES_AP_NORTHEAST_3</c> – Configure DKIM for the identity by replicating from
        /// a parent identity in Asia Pacific (Osaka) region using Deterministic Easy-DKIM (DEED).
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_SES_AP_NORTHEAST_2</c> – Configure DKIM for the identity by replicating from
        /// a parent identity in Asia Pacific (Seoul) region using Deterministic Easy-DKIM (DEED).
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_SES_ME_CENTRAL_1</c> – Configure DKIM for the identity by replicating from
        /// a parent identity in Middle East (UAE) region using Deterministic Easy-DKIM (DEED).
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_SES_ME_SOUTH_1</c> – Configure DKIM for the identity by replicating from a
        /// parent identity in Middle East (Bahrain) region using Deterministic Easy-DKIM (DEED).
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_SES_AP_NORTHEAST_1</c> – Configure DKIM for the identity by replicating from
        /// a parent identity in Asia Pacific (Tokyo) region using Deterministic Easy-DKIM (DEED).
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_SES_IL_CENTRAL_1</c> – Configure DKIM for the identity by replicating from
        /// a parent identity in Israel (Tel Aviv) region using Deterministic Easy-DKIM (DEED).
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_SES_SA_EAST_1</c> – Configure DKIM for the identity by replicating from a
        /// parent identity in South America (São Paulo) region using Deterministic Easy-DKIM
        /// (DEED). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_SES_CA_CENTRAL_1</c> – Configure DKIM for the identity by replicating from
        /// a parent identity in Canada (Central) region using Deterministic Easy-DKIM (DEED).
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_SES_AP_SOUTHEAST_1</c> – Configure DKIM for the identity by replicating from
        /// a parent identity in Asia Pacific (Singapore) region using Deterministic Easy-DKIM
        /// (DEED). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_SES_AP_SOUTHEAST_2</c> – Configure DKIM for the identity by replicating from
        /// a parent identity in Asia Pacific (Sydney) region using Deterministic Easy-DKIM (DEED).
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_SES_AP_SOUTHEAST_3</c> – Configure DKIM for the identity by replicating from
        /// a parent identity in Asia Pacific (Jakarta) region using Deterministic Easy-DKIM (DEED).
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_SES_EU_CENTRAL_1</c> – Configure DKIM for the identity by replicating from
        /// a parent identity in Europe (Frankfurt) region using Deterministic Easy-DKIM (DEED).
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_SES_EU_CENTRAL_2</c> – Configure DKIM for the identity by replicating from
        /// a parent identity in Europe (Zurich) region using Deterministic Easy-DKIM (DEED).
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_SES_US_EAST_1</c> – Configure DKIM for the identity by replicating from a
        /// parent identity in US East (N. Virginia) region using Deterministic Easy-DKIM (DEED).
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_SES_US_EAST_2</c> – Configure DKIM for the identity by replicating from a
        /// parent identity in US East (Ohio) region using Deterministic Easy-DKIM (DEED). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_SES_US_WEST_1</c> – Configure DKIM for the identity by replicating from a
        /// parent identity in US West (N. California) region using Deterministic Easy-DKIM (DEED).
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_SES_US_WEST_2</c> – Configure DKIM for the identity by replicating from a
        /// parent identity in US West (Oregon) region using Deterministic Easy-DKIM (DEED). 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DkimSigningAttributesOrigin DomainSigningAttributesOrigin
        {
            get { return this._domainSigningAttributesOrigin; }
            set { this._domainSigningAttributesOrigin = value; }
        }

        // Check to see if DomainSigningAttributesOrigin property is set
        internal bool IsSetDomainSigningAttributesOrigin()
        {
            return this._domainSigningAttributesOrigin != null;
        }

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