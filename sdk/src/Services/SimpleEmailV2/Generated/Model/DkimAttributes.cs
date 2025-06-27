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
    /// An object that contains information about the DKIM authentication status for an email
    /// identity.
    /// 
    ///  
    /// <para>
    /// Amazon SES determines the authentication status by searching for specific records
    /// in the DNS configuration for the domain. If you used <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/easy-dkim.html">Easy
    /// DKIM</a> to set up DKIM authentication, Amazon SES tries to find three unique CNAME
    /// records in the DNS configuration for your domain. If you provided a public key to
    /// perform DKIM authentication, Amazon SES tries to find a TXT record that uses the selector
    /// that you specified. The value of the TXT record must be a public key that's paired
    /// with the private key that you specified in the process of creating the identity
    /// </para>
    /// </summary>
    public partial class DkimAttributes
    {
        private DkimSigningKeyLength _currentSigningKeyLength;
        private DateTime? _lastKeyGenerationTimestamp;
        private DkimSigningKeyLength _nextSigningKeyLength;
        private DkimSigningAttributesOrigin _signingAttributesOrigin;
        private bool? _signingEnabled;
        private DkimStatus _status;
        private List<string> _tokens = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property CurrentSigningKeyLength. 
        /// <para>
        /// [Easy DKIM] The key length of the DKIM key pair in use.
        /// </para>
        /// </summary>
        public DkimSigningKeyLength CurrentSigningKeyLength
        {
            get { return this._currentSigningKeyLength; }
            set { this._currentSigningKeyLength = value; }
        }

        // Check to see if CurrentSigningKeyLength property is set
        internal bool IsSetCurrentSigningKeyLength()
        {
            return this._currentSigningKeyLength != null;
        }

        /// <summary>
        /// Gets and sets the property LastKeyGenerationTimestamp. 
        /// <para>
        /// [Easy DKIM] The last time a key pair was generated for this identity.
        /// </para>
        /// </summary>
        public DateTime? LastKeyGenerationTimestamp
        {
            get { return this._lastKeyGenerationTimestamp; }
            set { this._lastKeyGenerationTimestamp = value; }
        }

        // Check to see if LastKeyGenerationTimestamp property is set
        internal bool IsSetLastKeyGenerationTimestamp()
        {
            return this._lastKeyGenerationTimestamp.HasValue; 
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

        /// <summary>
        /// Gets and sets the property SigningAttributesOrigin. 
        /// <para>
        /// A string that indicates how DKIM was configured for the identity. These are the possible
        /// values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AWS_SES</c> – Indicates that DKIM was configured for the identity by using <a
        /// href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/easy-dkim.html">Easy DKIM</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EXTERNAL</c> – Indicates that DKIM was configured for the identity by using Bring
        /// Your Own DKIM (BYODKIM).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_SES_AF_SOUTH_1</c> – Indicates that DKIM was configured for the identity by
        /// replicating signing attributes from a parent identity in Africa (Cape Town) region
        /// using Deterministic Easy-DKIM (DEED). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_SES_EU_NORTH_1</c> – Indicates that DKIM was configured for the identity by
        /// replicating signing attributes from a parent identity in Europe (Stockholm) region
        /// using Deterministic Easy-DKIM (DEED). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_SES_AP_SOUTH_1</c> – Indicates that DKIM was configured for the identity by
        /// replicating signing attributes from a parent identity in Asia Pacific (Mumbai) region
        /// using Deterministic Easy-DKIM (DEED). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_SES_AP_SOUTH_2</c> – Indicates that DKIM was configured for the identity by
        /// replicating signing attributes from a parent identity in Asia Pacific (Hyderabad)
        /// region using Deterministic Easy-DKIM (DEED). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_SES_EU_WEST_3</c> – Indicates that DKIM was configured for the identity by
        /// replicating signing attributes from a parent identity in Europe (Paris) region using
        /// Deterministic Easy-DKIM (DEED). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_SES_EU_WEST_2</c> – Indicates that DKIM was configured for the identity by
        /// replicating signing attributes from a parent identity in Europe (London) region using
        /// Deterministic Easy-DKIM (DEED). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_SES_EU_SOUTH_1</c> – Indicates that DKIM was configured for the identity by
        /// replicating signing attributes from a parent identity in Europe (Milan) region using
        /// Deterministic Easy-DKIM (DEED). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_SES_EU_WEST_1</c> – Indicates that DKIM was configured for the identity by
        /// replicating signing attributes from a parent identity in Europe (Ireland) region using
        /// Deterministic Easy-DKIM (DEED). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_SES_AP_NORTHEAST_3</c> – Indicates that DKIM was configured for the identity
        /// by replicating signing attributes from a parent identity in Asia Pacific (Osaka) region
        /// using Deterministic Easy-DKIM (DEED). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_SES_AP_NORTHEAST_2</c> – Indicates that DKIM was configured for the identity
        /// by replicating signing attributes from a parent identity in Asia Pacific (Seoul) region
        /// using Deterministic Easy-DKIM (DEED). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_SES_ME_CENTRAL_1</c> – Indicates that DKIM was configured for the identity
        /// by replicating signing attributes from a parent identity in Middle East (UAE) region
        /// using Deterministic Easy-DKIM (DEED). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_SES_ME_SOUTH_1</c> – Indicates that DKIM was configured for the identity by
        /// replicating signing attributes from a parent identity in Middle East (Bahrain) region
        /// using Deterministic Easy-DKIM (DEED). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_SES_AP_NORTHEAST_1</c> – Indicates that DKIM was configured for the identity
        /// by replicating signing attributes from a parent identity in Asia Pacific (Tokyo) region
        /// using Deterministic Easy-DKIM (DEED). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_SES_IL_CENTRAL_1</c> – Indicates that DKIM was configured for the identity
        /// by replicating signing attributes from a parent identity in Israel (Tel Aviv) region
        /// using Deterministic Easy-DKIM (DEED). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_SES_SA_EAST_1</c> – Indicates that DKIM was configured for the identity by
        /// replicating signing attributes from a parent identity in South America (São Paulo)
        /// region using Deterministic Easy-DKIM (DEED). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_SES_CA_CENTRAL_1</c> – Indicates that DKIM was configured for the identity
        /// by replicating signing attributes from a parent identity in Canada (Central) region
        /// using Deterministic Easy-DKIM (DEED). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_SES_AP_SOUTHEAST_1</c> – Indicates that DKIM was configured for the identity
        /// by replicating signing attributes from a parent identity in Asia Pacific (Singapore)
        /// region using Deterministic Easy-DKIM (DEED). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_SES_AP_SOUTHEAST_2</c> – Indicates that DKIM was configured for the identity
        /// by replicating signing attributes from a parent identity in Asia Pacific (Sydney)
        /// region using Deterministic Easy-DKIM (DEED). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_SES_AP_SOUTHEAST_3</c> – Indicates that DKIM was configured for the identity
        /// by replicating signing attributes from a parent identity in Asia Pacific (Jakarta)
        /// region using Deterministic Easy-DKIM (DEED). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_SES_EU_CENTRAL_1</c> – Indicates that DKIM was configured for the identity
        /// by replicating signing attributes from a parent identity in Europe (Frankfurt) region
        /// using Deterministic Easy-DKIM (DEED). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_SES_EU_CENTRAL_2</c> – Indicates that DKIM was configured for the identity
        /// by replicating signing attributes from a parent identity in Europe (Zurich) region
        /// using Deterministic Easy-DKIM (DEED). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_SES_US_EAST_1</c> – Indicates that DKIM was configured for the identity by
        /// replicating signing attributes from a parent identity in US East (N. Virginia) region
        /// using Deterministic Easy-DKIM (DEED). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_SES_US_EAST_2</c> – Indicates that DKIM was configured for the identity by
        /// replicating signing attributes from a parent identity in US East (Ohio) region using
        /// Deterministic Easy-DKIM (DEED). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_SES_US_WEST_1</c> – Indicates that DKIM was configured for the identity by
        /// replicating signing attributes from a parent identity in US West (N. California) region
        /// using Deterministic Easy-DKIM (DEED). 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS_SES_US_WEST_2</c> – Indicates that DKIM was configured for the identity by
        /// replicating signing attributes from a parent identity in US West (Oregon) region using
        /// Deterministic Easy-DKIM (DEED). 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DkimSigningAttributesOrigin SigningAttributesOrigin
        {
            get { return this._signingAttributesOrigin; }
            set { this._signingAttributesOrigin = value; }
        }

        // Check to see if SigningAttributesOrigin property is set
        internal bool IsSetSigningAttributesOrigin()
        {
            return this._signingAttributesOrigin != null;
        }

        /// <summary>
        /// Gets and sets the property SigningEnabled. 
        /// <para>
        /// If the value is <c>true</c>, then the messages that you send from the identity are
        /// signed using DKIM. If the value is <c>false</c>, then the messages that you send from
        /// the identity aren't DKIM-signed.
        /// </para>
        /// </summary>
        public bool? SigningEnabled
        {
            get { return this._signingEnabled; }
            set { this._signingEnabled = value; }
        }

        // Check to see if SigningEnabled property is set
        internal bool IsSetSigningEnabled()
        {
            return this._signingEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Describes whether or not Amazon SES has successfully located the DKIM records in the
        /// DNS records for the domain. The status can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PENDING</c> – The verification process was initiated, but Amazon SES hasn't yet
        /// detected the DKIM records in the DNS configuration for the domain.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SUCCESS</c> – The verification process completed successfully.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> – The verification process failed. This typically occurs when Amazon
        /// SES fails to find the DKIM records in the DNS configuration of the domain.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TEMPORARY_FAILURE</c> – A temporary issue is preventing Amazon SES from determining
        /// the DKIM authentication status of the domain.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NOT_STARTED</c> – The DKIM verification process hasn't been initiated for the
        /// domain.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DkimStatus Status
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
        /// Gets and sets the property Tokens. 
        /// <para>
        /// If you used <a href="https://docs.aws.amazon.com/ses/latest/DeveloperGuide/easy-dkim.html">Easy
        /// DKIM</a> to configure DKIM authentication for the domain, then this object contains
        /// a set of unique strings that you use to create a set of CNAME records that you add
        /// to the DNS configuration for your domain. When Amazon SES detects these records in
        /// the DNS configuration for your domain, the DKIM authentication process is complete.
        /// </para>
        ///  
        /// <para>
        /// If you configured DKIM authentication for the domain by providing your own public-private
        /// key pair, then this object contains the selector for the public key.
        /// </para>
        ///  
        /// <para>
        /// Regardless of the DKIM authentication method you use, Amazon SES searches for the
        /// appropriate records in the DNS configuration of the domain for up to 72 hours.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Tokens
        {
            get { return this._tokens; }
            set { this._tokens = value; }
        }

        // Check to see if Tokens property is set
        internal bool IsSetTokens()
        {
            return this._tokens != null && (this._tokens.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}